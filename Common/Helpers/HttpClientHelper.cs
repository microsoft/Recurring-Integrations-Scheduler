/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecurringIntegrationsScheduler.Common.JobSettings;
using RecurringIntegrationsScheduler.Common.Properties;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class HttpClientHelper : IDisposable
    {
        private readonly JobSettings.Settings _settings;
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;
        private readonly AuthenticationHelper _authenticationHelper;
        private Uri _enqueueUri;
        private Uri _dequeueUri;
        private Uri _ackUri;

        private bool disposed;
        private StreamContent _streamContent;
        private StringContent _stringContent;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientHelper"/> class.
        /// </summary>
        /// <param name="jobSettings">Job settings</param>
        public HttpClientHelper(JobSettings.Settings jobSettings)
        {
            _settings = jobSettings;

            //Use Tls1.2 as default transport layer
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            _httpClientHandler = new HttpClientHandler {
                AllowAutoRedirect = false,
                UseCookies = false,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            _httpClient = new HttpClient(_httpClientHandler)
            {
                Timeout = TimeSpan.FromMinutes(600) //Timeout for large uploads or downloads
            };

            _authenticationHelper = new AuthenticationHelper(_settings);
        }

        /// <summary>
        /// Post request for files
        /// </summary>
        /// <param name="uri">Enqueue endpoint URI</param>
        /// <param name="bodyStream">Body stream</param>
        /// <param name="externalCorrelationHeaderValue">ActivityMessage context</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PostStreamRequestAsync(Uri uri, Stream bodyStream, string externalCorrelationHeaderValue = null)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Authorization = await _authenticationHelper.GetValidAuthenticationHeader();

            // Add external correlation id header if specified and valid
            if (!string.IsNullOrEmpty(externalCorrelationHeaderValue))
            {
                _httpClient.DefaultRequestHeaders.Add("x-ms-dyn-externalidentifier", externalCorrelationHeaderValue);
            }

            if (bodyStream != null)
            {
                using (_streamContent = new StreamContent(bodyStream))
                {
                    return await _httpClient.PostAsync(uri, _streamContent);
                }
            }
            else
            {
                using (_stringContent = new StringContent(Resources.Request_failed_at_client, Encoding.ASCII))
                {
                    return new HttpResponseMessage
                    {
                        Content = _stringContent,
                        StatusCode = HttpStatusCode.PreconditionFailed
                    };
                }
            }
        }

        /// <summary>
        /// Post request
        /// </summary>
        /// <param name="uri">Request Uri</param>
        /// <param name="bodyString">Body string</param>
        /// <param name="externalCorrelationHeaderValue">Activity Message context</param>
        /// <returns>HTTP response</returns>
        public async Task<HttpResponseMessage> PostStringRequestAsync(Uri uri, string bodyString, string externalCorrelationHeaderValue = null)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Authorization = await _authenticationHelper.GetValidAuthenticationHeader();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Add external correlation id header if specified and valid
            if (!string.IsNullOrEmpty(externalCorrelationHeaderValue))
            {
                _httpClient.DefaultRequestHeaders.Add("x-ms-dyn-externalidentifier", externalCorrelationHeaderValue);
            }

            if (bodyString != null)
            {
                using (_stringContent = new StringContent(bodyString, Encoding.UTF8, "application/json"))
                {
                    return await _httpClient.PostAsync(uri, _stringContent);
                }
            }
            else
            {
                using (_stringContent = new StringContent(Resources.Request_failed_at_client, Encoding.ASCII))
                {
                    return new HttpResponseMessage
                    {
                        Content = _stringContent,
                        StatusCode = HttpStatusCode.PreconditionFailed
                    };
                }
            }
        }

        /// <summary>
        /// Http Get request
        /// </summary>
        /// <param name="uri">Request Uri</param>
        /// <returns>Http response</returns>
        public async Task<HttpResponseMessage> GetRequestAsync(Uri uri, bool addAuthorization = true)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            if(addAuthorization)
            {
                _httpClient.DefaultRequestHeaders.Authorization = await _authenticationHelper.GetValidAuthenticationHeader();
            }

            return await _httpClient.GetAsync(uri).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets data job enqueue request Uri
        /// </summary>
        /// <returns>
        /// Data job enqueue request Uri
        /// </returns>
        public Uri GetEnqueueUri()
        {
            if (_enqueueUri != null)
                return _enqueueUri;

            var uploadSettings = _settings as UploadJobSettings;

            var enqueueUri = new UriBuilder(uploadSettings.AosUri)
            {
                Path = "api/connector/enqueue/" + uploadSettings.ActivityId
            };

            if (uploadSettings.IsDataPackage)
            {
                if (!string.IsNullOrEmpty(uploadSettings.Company))
                    enqueueUri.Query = "company=" + uploadSettings.Company;
            }
            else // Individual file
            {
                // entity name is required
                var enqueueQuery = "entity=" + uploadSettings?.EntityName;
                // Append company if it is specified
                if (!string.IsNullOrEmpty(uploadSettings?.Company))
                    enqueueQuery += "&company=" + uploadSettings.Company;
                enqueueUri.Query = enqueueQuery;
            }
            return _enqueueUri = enqueueUri.Uri;
         }

        /// <summary>
        /// Gets data job dequeue request Uri
        /// </summary>
        /// <returns>
        /// Data job dequeue request Uri
        /// </returns>
        public Uri GetDequeueUri()
        {
            if (_dequeueUri != null)
                return _enqueueUri;

            var downloadSettings = _settings as DownloadJobSettings;
            var dequeueUri = new UriBuilder(downloadSettings.AosUri)
            {
                Path = "api/connector/dequeue/" + downloadSettings.ActivityId
            };
            return _dequeueUri = dequeueUri.Uri;
        }

        /// <summary>
        /// Gets file download acknowledgement request Uri
        /// </summary>
        /// <returns>
        /// File download acknowledgement request Uri
        /// </returns>
        public Uri GetAckUri()
        {
            if (_ackUri != null)
                return _ackUri;

            var downloadSettings = _settings as DownloadJobSettings;
            var acknowledgeUri = new UriBuilder(downloadSettings.AosUri)
            {
                Path = "api/connector/ack/" + downloadSettings.ActivityId
            };
            return _ackUri = acknowledgeUri.Uri;
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
            var jobStatusUri = new UriBuilder(processingJobSettings.AosUri)
            {
                Path = "api/connector/jobstatus/" + processingJobSettings.ActivityId,
                Query = "jobId=" + jobId.Replace(@"""", "")
            };
            return jobStatusUri.Uri;
        }

        /// <summary>
        /// Gets temporary writable location
        /// </summary>
        /// <returns>temp writable cloud url</returns>
        public async Task<string> GetAzureWriteUrl()
        {
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetAzureWriteUrl"
            };

            string uniqueFileName = Guid.NewGuid().ToString();
            var parameters = new { uniqueFileName };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var response = await PostStringRequestAsync(requestUri.Uri, parametersJson);
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
            string jvalue = jsonResponse["value"].ToString();
            return jvalue;
        }

        /// <summary>
        /// Checks execution status of a Job
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns>job's execution status</returns>
        public async Task<string> GetExecutionSummaryStatus(string executionId)
        {
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExecutionSummaryStatus"
            };

            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var response = await PostStringRequestAsync(requestUri.Uri, parametersJson);

            string result = response.Content.ReadAsStringAsync().Result;
            JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
            return jsonResponse["value"].ToString();
        }

        /// <summary>
        /// Gets exported package Url location
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns>exorted package Url location</returns>
        public async Task<Uri> GetExportedPackageUrl(string executionId)
        {
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExportedPackageUrl"
            };
            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var response = await PostStringRequestAsync(requestUri.Uri, parametersJson);
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
            string jvalue = jsonResponse["value"].ToString();
            return new Uri(jvalue);
        }

        /// <summary>
        /// Gets execution's summary page Url
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns>execution's summary page Url</returns>
        public async Task<string> GetExecutionSummaryPageUrl(string executionId)
        {
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExecutionSummaryPageUrl"
            };
            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var response = await PostStringRequestAsync(requestUri.Uri, parametersJson);
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
            return jsonResponse["value"].ToString();
        }

        /// <summary>
        /// Uploads package to a blob
        /// </summary>
        /// <param name="blobUrl">blob url</param>
        /// <param name="stream">bytes to write</param>
        /// <returns>HTTP response</returns>
        public async Task<HttpResponseMessage> UploadContentsToBlob(Uri blobUrl, Stream stream)
        {
            using (_streamContent = new StreamContent(stream))
            {
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("x-ms-date", DateTime.UtcNow.ToString("R", System.Globalization.CultureInfo.InvariantCulture));
                _httpClient.DefaultRequestHeaders.Add("x-ms-version", "2015-02-21");
                _httpClient.DefaultRequestHeaders.Add("x-ms-blob-type", "BlockBlob");
                _httpClient.DefaultRequestHeaders.Add("Overwrite", "T");
                return await _httpClient.PutAsync(blobUrl.AbsoluteUri, _streamContent);
            }
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
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                // 20180210 - mehrdadg - modified : begin
                // Use our own service
                /*
                 * Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ImportFromPackage"
                 */
                Path = "data/CgkDataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ImportFromPackage"
                // 20180210 - mehrdadg - modified : end
            };
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
            return await PostStringRequestAsync(requestUri.Uri, parametersJson);
        }

        /// <summary>
        /// Delete Execution History
        /// </summary>
        /// <param name="executionId">execution Id</param>
        /// <returns></returns>
        public async Task<string> DeleteExecutionHistoryJob(string executionId)
        {
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.DeleteExecutionHistoryJob"
            };
            var parameters = new { executionId };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var response = await PostStringRequestAsync(requestUri.Uri, parametersJson);
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
            return jsonResponse["value"].ToString();
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
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ExportToPackage"
            };
            var parameters = new
            {
                definitionGroupId,
                packageName,
                executionId,
                reExecute,
                legalEntityId
            };
            string parametersJson = JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return await PostStringRequestAsync(requestUri.Uri, parametersJson);
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
            var requestUri = new UriBuilder(_settings.AosUri)
            {
                Path = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ExportFromPackage"
            };
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
            return await PostStringRequestAsync(requestUri.Uri, parametersJson);
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
            if (!disposed)
            {
                disposed = true;
                if (disposing)
                {
                    if (_httpClient != null)
                    {
                        _httpClient.Dispose();
                    }
                    if (_streamContent != null)
                    {
                        _streamContent.Dispose();
                    }
                    if (_stringContent != null)
                    {
                        _stringContent.Dispose();
                    }
                }
            }
        }
    }
}