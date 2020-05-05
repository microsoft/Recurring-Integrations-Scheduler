/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecurringIntegrationsScheduler.Common.JobSettings;
using RecurringIntegrationsScheduler.Common.Properties;
using RecurringIntegrationsScheduler.Common.Contracts;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UrlCombineLib;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class HttpClientHelper : IDisposable
    {
        private readonly Settings _settings;
        private readonly HttpClient _httpClient;
        private readonly AuthenticationHelper _authenticationHelper;
        private bool _disposed;

        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientHelper"/> class.
        /// </summary>
        /// <param name="jobSettings">Job settings</param>
        public HttpClientHelper(Settings jobSettings)
        {
            log4net.Config.XmlConfigurator.Configure();

            _settings = jobSettings;

            //Use Tls1.2 as default transport layer
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpClientHandler = new HttpClientHandler {
                AllowAutoRedirect = false,
                UseCookies = false,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            _httpClient = new HttpClient(new HttpRetryHandler(httpClientHandler, _settings.RetryCount, _settings.RetryDelay))
            {
                Timeout = TimeSpan.FromMinutes(60) //Timeout for large uploads or downloads
            };

            _authenticationHelper = new AuthenticationHelper(_settings);
            
            if(_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper was successfully initialized.
Request retry count: {_settings.RetryCount}.
Delay between retries: {_settings.RetryDelay} seconds.");
            }
        }

        /// <summary>
        /// Post request for files
        /// </summary>
        /// <param name="uri">Enqueue endpoint URI</param>
        /// <param name="bodyStream">Body stream</param>
        /// <param name="externalidentifier">ActivityMessage context</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PostStreamRequestAsync(Uri uri, Stream bodyStream, string externalidentifier = null)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", await _authenticationHelper.GetValidAuthenticationHeader());

            if (!string.IsNullOrEmpty(externalidentifier))
            {
                _httpClient.DefaultRequestHeaders.Add("x-ms-dyn-externalidentifier", externalidentifier);
            }

            if (bodyStream != null)
            {
                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.PostStreamRequestAsync is being called.
Uri: {uri.AbsoluteUri},

Parameters:

bodyStream is not null,
externalidentifier: {externalidentifier}");
                }
                return await _httpClient.PostAsync(uri, new StreamContent(bodyStream));
            }
            else
            {
                Log.Error($"Job: {_settings.JobKey}. HttpClientHelper.PostStreamRequestAsync method was called with empty 'bodyStream' parameter.");
                return new HttpResponseMessage
                {
                    Content = new StringContent(Resources.Request_failed_at_client, Encoding.ASCII),
                    StatusCode = HttpStatusCode.PreconditionFailed
                };
            }
        }

        /// <summary>
        /// Post request
        /// </summary>
        /// <param name="uri">Request Uri</param>
        /// <param name="bodyString">Body string</param>
        /// <param name="externalidentifier">Activity Message context</param>
        /// <returns>HTTP response</returns>
        public async Task<HttpResponseMessage> PostStringRequestAsync(Uri uri, string bodyString, string externalidentifier = null)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", await _authenticationHelper.GetValidAuthenticationHeader());
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Add external correlation id header if specified and valid
            if (!string.IsNullOrEmpty(externalidentifier))
            {
                _httpClient.DefaultRequestHeaders.Add("x-ms-dyn-externalidentifier", externalidentifier);
            }

            if (bodyString != null)
            {
                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.PostStringRequestAsync is being called.
Uri: {uri.AbsoluteUri},

Parameters:

bodyString: {bodyString},
externalidentifier: {externalidentifier}");
                }
                return await _httpClient.PostAsync(uri, new StringContent(bodyString, Encoding.UTF8, "application/json"));
            }
            else
            {
                Log.Error($"Job: {_settings.JobKey}. HttpClientHelper.PostStringRequestAsync method was called with empty 'bodyString' parameter.");
                return new HttpResponseMessage
                {
                    Content = new StringContent(Resources.Request_failed_at_client, Encoding.ASCII),
                    StatusCode = HttpStatusCode.PreconditionFailed
                };
            }
        }

        /// <summary>
        /// Http Get request
        /// </summary>
        /// <param name="uri">Request Uri</param>
        /// <param name="addAuthorization">Add authorization header</param>
        /// <returns>Http response</returns>
        public async Task<HttpResponseMessage> GetRequestAsync(Uri uri, bool addAuthorization = true)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            if(addAuthorization)
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", await _authenticationHelper.GetValidAuthenticationHeader());
            }
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetRequestAsync is being called.
Uri: {uri.AbsoluteUri},

Parameters:

addAuthorization: {addAuthorization}");
            }
            return await _httpClient.GetAsync(uri);
        }

        /// <summary>
        /// Gets data job enqueue request Uri
        /// </summary>
        /// <returns>
        /// Data job enqueue request Uri
        /// </returns>
        public Uri GetEnqueueUri(string legalEntity = null)
        {
            var uploadSettings = _settings as UploadJobSettings;
            var enqueueUri = new UriBuilder(GetAosRequestUri(UrlCombine.Combine(ConnectorApiActions.EnqueuePath, uploadSettings.ActivityId.ToString())));
            var query = HttpUtility.ParseQueryString(enqueueUri.Query);

            if (!string.IsNullOrEmpty(legalEntity))
            {
                query["company"] = legalEntity;
            }
            else
            {
                if (!string.IsNullOrEmpty(uploadSettings.Company))
                {
                    query["company"] = uploadSettings.Company;
                }
            }

            if (!uploadSettings.IsDataPackage)// Individual file
            {
                // entity name is required
                query["entity"] = uploadSettings.EntityName;
            }
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetEnqueueUri is being called.
Parameters:

legalEntity: {legalEntity}

Output:

Generated Uri: {enqueueUri.Uri.AbsoluteUri}
Generated query: {enqueueUri.Query}");
            }
            enqueueUri.Query = query.ToString();
            return enqueueUri.Uri;
        }

        /// <summary>
        /// Gets data job dequeue request Uri
        /// </summary>
        /// <returns>
        /// Data job dequeue request Uri
        /// </returns>
        public Uri GetDequeueUri()
        {
            var downloadSettings = _settings as DownloadJobSettings;
            var dequeueUri = new UriBuilder(GetAosRequestUri(UrlCombine.Combine(ConnectorApiActions.DequeuePath, downloadSettings.ActivityId.ToString()))).Uri;
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetDequeueUri is being called.
Output:

Generated Uri: {dequeueUri.AbsoluteUri}");
            }
            return dequeueUri;
        }

        /// <summary>
        /// Gets file download acknowledgement request Uri
        /// </summary>
        /// <returns>
        /// File download acknowledgement request Uri
        /// </returns>
        public Uri GetAckUri()
        {
            var downloadSettings = _settings as DownloadJobSettings;
            var ackUri = new UriBuilder(GetAosRequestUri(UrlCombine.Combine(ConnectorApiActions.AckPath, downloadSettings.ActivityId.ToString()))).Uri;
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetAckUri is being called.
Output:

Generated Uri: {ackUri.AbsoluteUri}");
            }
            return ackUri;
        }

        /// <summary>
        /// Gets data job status request URI
        /// </summary>
        /// <param name="jobId">The job identifier.</param>
        /// <returns>
        /// Data job status URI
        /// </returns>
        public Uri GetJobStatusUri(string jobId)
        {
            var processingJobSettings = _settings as ProcessingJobSettings;
            var jobStatusUri = new UriBuilder(GetAosRequestUri(UrlCombine.Combine(ConnectorApiActions.JobStatusPath, processingJobSettings.ActivityId.ToString())))
            {
                Query = "jobId=" + jobId.Replace(@"""", "")
            };
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetJobStatusUri is being called.
Parameters:

jobId: {jobId}

Output:

Generated uri: {jobStatusUri.Uri.AbsoluteUri}
Generated query: {jobStatusUri.Query}");
            }
            return jobStatusUri.Uri;
        }

        /// <summary>
        /// Gets temporary writable location
        /// </summary>
        /// <returns>temp writable cloud url</returns>
        public async Task<HttpResponseMessage> GetAzureWriteUrl()
        {
            var requestUri = GetAosRequestUri(_settings.GetAzureWriteUrlActionPath);

            string uniqueFileName = Guid.NewGuid().ToString();
            var parameters = new { uniqueFileName };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetAzureWriteUrl is being called.
Uri: {requestUri}

Parameters:

uniqueFileName: {uniqueFileName}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetAzureWriteUrl request failed.
Uri: {requestUri}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
                return null;
            }
            return response;
        }

        /// <summary>
        /// Checks execution status of a Job
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns>Http response</returns>
        public async Task<HttpResponseMessage> GetExecutionSummaryStatus(string executionId)
        {
            var requestUri = GetAosRequestUri(_settings.GetExecutionSummaryStatusActionPath);

            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetExecutionSummaryStatus is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetExecutionSummaryStatus request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Gets exported package Url location
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns>Http response</returns>
        public async Task<HttpResponseMessage> GetExportedPackageUrl(string executionId)
        {
            var requestUri = GetAosRequestUri(_settings.GetExportedPackageUrlActionPath);

            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetExportedPackageUrl is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetExportedPackageUrl request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Gets execution's summary page Url
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns>Http response</returns>
        public async Task<HttpResponseMessage> GetExecutionSummaryPageUrl(string executionId)
        {
            var requestUri = GetAosRequestUri(_settings.GetExecutionSummaryPageUrlActionPath);

            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetExecutionSummaryPageUrl is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetExecutionSummaryPageUrl request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Uploads package to a blob
        /// </summary>
        /// <param name="blobUrl">blob url</param>
        /// <param name="stream">bytes to write</param>
        /// <returns>HTTP response</returns>
        public async Task<HttpResponseMessage> UploadContentsToBlob(Uri blobUrl, Stream stream)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("x-ms-date", DateTime.UtcNow.ToString("R", System.Globalization.CultureInfo.InvariantCulture));
            _httpClient.DefaultRequestHeaders.Add("x-ms-blob-type", "BlockBlob");
            _httpClient.DefaultRequestHeaders.Add("Overwrite", "T");
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.UploadContentsToBlob is being called.
Uri: {blobUrl.AbsoluteUri}");
            }
            var response = await _httpClient.PutAsync(blobUrl.AbsoluteUri, new StreamContent(stream));
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.UploadContentsToBlob request failed.
Uri: {blobUrl.AbsoluteUri}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Request to import package from specified location
        /// </summary>
        /// <param name="packageUrl">Location of uploaded package</param>
        /// <param name="definitionGroupId">Data project name</param>
        /// <param name="executionId">Execution Id</param>
        /// <param name="execute">Flag whether to execute import</param>
        /// <param name="overwrite">Flag whether to overwrite data project</param>
        /// <param name="legalEntityId">Target legal entity</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> ImportFromPackage(string packageUrl, string definitionGroupId, string executionId, bool execute, bool overwrite, string legalEntityId)
        {
            var requestUri = GetAosRequestUri(_settings.ImportFromPackageActionPath);

            var parameters = new
            {
                packageUrl,
                definitionGroupId,
                executionId,
                execute,
                overwrite,
                legalEntityId
            };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.ImportFromPackage is being called.
Uri: {requestUri}

Parameters:

packageUrl: {packageUrl}
definitionGroupId: {definitionGroupId}
executionId: {executionId}
execute: {execute}
overwrite: {overwrite}
legalEntityId: {legalEntityId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.ImportFromPackage request failed.
Uri: {requestUri}

Parameters:

packageUrl: {packageUrl}
definitionGroupId: {definitionGroupId}
executionId: {executionId}
execute: {execute}
overwrite: {overwrite}
legalEntityId: {legalEntityId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Delete Execution History
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> DeleteExecutionHistoryJob(string executionId)
        {
            var requestUri = GetAosRequestUri(_settings.DeleteExecutionHistoryJobActionPath); 

            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.DeleteExecutionHistoryJob is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.DeleteExecutionHistoryJob request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Export a package that has been already uploaded to server
        /// </summary>
        /// <param name="definitionGroupId">data project name</param>
        /// <param name="packageName">package name </param>
        /// <param name="executionId">execution id to use for results</param>
        /// <param name="legalEntityId">the company to pull</param>
        /// <param name="reExecute">reexecute flag</param>
        /// <returns>export package url</returns>
        public async Task<HttpResponseMessage> ExportToPackage(string definitionGroupId, string packageName, string executionId, string legalEntityId, bool reExecute = false)
        {            
            var requestUri = GetAosRequestUri(_settings.ExportToPackageActionPath);

            var parameters = new
            {
                definitionGroupId,
                packageName,
                executionId,
                reExecute,
                legalEntityId
            };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.ExportToPackage is being called.
Uri: {requestUri}

Parameters:

definitionGroupId: {definitionGroupId}
packageName: {packageName}
executionId: {executionId}
reExecute: {reExecute}
legalEntityId: {legalEntityId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.ExportToPackage request failed.
Uri: {requestUri}

Parameters:

definitionGroupId: {definitionGroupId}
packageName: {packageName}
executionId: {executionId}
reExecute: {reExecute}
legalEntityId: {legalEntityId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Upload a package template and export data based on that template
        /// </summary>
        /// <param name="packageUrl">Location of uploaded package template</param>
        /// <param name="definitionGroupId">Data project name</param>
        /// <param name="executionId">Execution Id</param>
        /// <param name="execute">Flag whether to execute export</param>
        /// <param name="overwrite">Flag whether to overwrite data project</param>
        /// <param name="legalEntityId">Source legal entity</param>
        /// <returns>export package url</returns>
        public async Task<HttpResponseMessage> ExportFromPackage(string packageUrl, string definitionGroupId, string executionId, bool execute, bool overwrite, string legalEntityId)
        {
            var requestUri = GetAosRequestUri(_settings.ExportFromPackageActionPath);

            var parameters = new
            {
                packageUrl,
                definitionGroupId,
                executionId,
                execute,
                overwrite,
                legalEntityId
            };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.ExportFromPackage is being called.
Uri: {requestUri}

Parameters:

packageUrl: {packageUrl}
definitionGroupId: {definitionGroupId}
executionId: {executionId}
execute: {execute}
overwrite: {overwrite}
legalEntityId: {legalEntityId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.ExportFromPackage request failed.
Uri: {requestUri}

Parameters:

packageUrl: {packageUrl}
definitionGroupId: {definitionGroupId}
executionId: {executionId}
execute: {execute}
overwrite: {overwrite}
legalEntityId: {legalEntityId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Get message status
        /// </summary>
        /// <param name="messageId">Message Id</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetMessageStatus(string messageId)
        {
            var requestUri = GetAosRequestUri(_settings.GetMessageStatusActionPath);
            var parameters = new { messageId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetMessageStatus is being called.
Uri: {requestUri}

Parameters:

messageId: {messageId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetMessageStatus request failed.
Uri: {requestUri}

Parameters:

messageId: {messageId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;

        }

        /// <summary>
        /// Generate error keys file for data entity import
        /// </summary>
        /// <param name="executionId">Execution Id</param>
        /// <param name="entityName">Entity name</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GenerateImportTargetErrorKeysFile(string executionId, string entityName)
        {
            var requestUri = GetAosRequestUri(_settings.GenerateImportTargetErrorKeysFilePath);

            var parameters = new
            {
                executionId,
                entityName
            };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GenerateImportTargetErrorKeysFile is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}
entityName: {entityName}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GenerateImportTargetErrorKeysFile request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}
entityName: {entityName}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Get error keys file URL for data entity import
        /// </summary>
        /// <param name="executionId">Execution Id</param>
        /// <param name="entityName">Entity name</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetImportTargetErrorKeysFileUrl(string executionId, string entityName)
        {
            var requestUri = GetAosRequestUri(_settings.GetImportTargetErrorKeysFileUrlPath);

            var parameters = new
            {
                executionId,
                entityName
            };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetImportTargetErrorKeysFileUrl is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}
entityName: {entityName}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetImportTargetErrorKeysFileUrl request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}
entityName: {entityName}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        /// <summary>
        /// Get execution errors
        /// </summary>
        /// <param name="executionId">Execution Id</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetExecutionErrors(string executionId)
        {
            var requestUri = GetAosRequestUri(_settings.GetExecutionErrorsPath);

            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.Debug($@"Job: {_settings.JobKey}. HttpClientHelper.GetExecutionErrors is being called.
Uri: {requestUri}

Parameters:

executionId: {executionId}");
            }
            var response = await PostStringRequestAsync(requestUri, parametersJson);
            if (!response.IsSuccessStatusCode)
            {
                Log.Error($@"Job: {_settings.JobKey}. HttpClientHelper.GetExecutionErrors request failed.
Uri: {requestUri}

Parameters:

executionId: {executionId}

Response status code: {response.StatusCode}
Response reason: {response.ReasonPhrase}
Response message: {response.Content}");
            }
            return response;
        }

        private Uri GetAosRequestUri(string requestRelativePath) 
             {
            var aosUrl = UrlCombine.Combine(_settings.AosUri, requestRelativePath);
            var aosUri = new Uri(aosUrl); 
                    return aosUri; 
             } 

        public static string ReadResponseString(HttpResponseMessage response)
        {
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
            return jsonResponse["value"].ToString();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">enable dispose</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            _disposed = true;
            if (disposing)
            {
                _httpClient?.Dispose();
            }
        }
    }
}
