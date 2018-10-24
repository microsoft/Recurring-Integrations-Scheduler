/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Polly;
using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Common.JobSettings;
using RecurringIntegrationsScheduler.Job.Properties;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace RecurringIntegrationsScheduler.Job
{
    /// <summary>
    /// Job that uploads data packages using new method introduced in platform update 5
    /// </summary>
    /// <seealso cref="IJob" />
    [DisallowConcurrentExecution]
    public class Import : IJob
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The settings
        /// </summary>
        private readonly ImportJobSettings _settings = new ImportJobSettings();

        /// <summary>
        /// The HTTP client helper
        /// </summary>
        private HttpClientHelper _httpClientHelper;

        /// <summary>
        /// Job execution context
        /// </summary>
        private IJobExecutionContext _context;
        
        /// <summary>
        /// Gets or sets the input queue.
        /// </summary>
        /// <value>
        /// The input queue.
        /// </value>
        private ConcurrentQueue<DataMessage> InputQueue { get; set; }

        /// <summary>
        /// Retry policy for IO operations
        /// </summary>
        private Policy _retryPolicyForIo;

        /// <summary>
        /// Retry policy for HTTP operations
        /// </summary>
        private Policy _retryPolicyForHttp;

        /// <summary>
        /// Called by the <see cref="T:Quartz.IScheduler" /> when a <see cref="T:Quartz.ITrigger" />
        /// fires that is associated with the <see cref="T:Quartz.IJob" />.
        /// </summary>
        /// <param name="context">The execution context.</param>
        /// <exception cref="JobExecutionException">false</exception>
        /// <remarks>
        /// The implementation may wish to set a  result object on the
        /// JobExecutionContext before this method exits.  The result itself
        /// is meaningless to Quartz, but may be informative to
        /// <see cref="T:Quartz.IJobListener" />s or
        /// <see cref="T:Quartz.ITriggerListener" />s that are watching the job's
        /// execution.
        /// </remarks>
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                _context = context;
                _settings.Initialize(context);

                if (_settings.IndefinitePause)
                {
                    await context.Scheduler.PauseJob(context.JobDetail.Key);
                    Log.InfoFormat(CultureInfo.InvariantCulture,
                        string.Format(Resources.Job_0_was_paused_indefinitely, _context.JobDetail.Key));
                    return;
                }

                _retryPolicyForIo = Policy.Handle<IOException>().WaitAndRetry(
                    retryCount: _settings.RetryCount, 
                    sleepDurationProvider: attempt => TimeSpan.FromSeconds(_settings.RetryDelay),
                    onRetry: (exception, calculatedWaitDuration) => 
                    {
                        Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Retrying_IO_operation_Exception_1, _context.JobDetail.Key, exception.Message));
                    });
                _retryPolicyForHttp = Policy.Handle<HttpRequestException>().WaitAndRetryAsync(
                    retryCount: _settings.RetryCount, 
                    sleepDurationProvider: attempt => TimeSpan.FromSeconds(_settings.RetryDelay),
                    onRetry: (exception, calculatedWaitDuration) => 
                    {
                        Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Retrying_Http_operation_Exception_1, _context.JobDetail.Key, exception.Message));
                    });

                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_starting, _context.JobDetail.Key));

                await Process();

                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_ended, _context.JobDetail.Key));
            }
            catch (Exception ex)
            {
                if (_settings.PauseJobOnException)
                {
                    await context.Scheduler.PauseJob(context.JobDetail.Key);
                    Log.WarnFormat(CultureInfo.InvariantCulture,
                        string.Format(Resources.Job_0_was_paused_because_of_error, _context.JobDetail.Key));
                }
                if (Log.IsDebugEnabled)
                {
                    if (!string.IsNullOrEmpty(ex.Message))
                    {
                        Log.Error(ex.Message, ex);
                    }
                    else
                    {
                        Log.Error("Uknown exception", ex);
                    }

                    while (ex.InnerException != null)
                    {
                        if (!string.IsNullOrEmpty(ex.InnerException.Message))
                            Log.Error(ex.InnerException.Message, ex.InnerException);

                        ex = ex.InnerException;
                    }
                }
                if (context.Scheduler.SchedulerName != "Private")
                    throw new JobExecutionException(string.Format(Resources.Import_job_0_failed, _context.JobDetail.Key), ex, false);

                if (!Log.IsDebugEnabled)
                    Log.Error(string.Format(Resources.Job_0_thrown_an_error_1, _context.JobDetail.Key, ex.Message));
            }
        }

        /// <summary>
        /// Processes this instance.
        /// </summary>
        /// <returns></returns>
        private async Task Process()
        {
            InputQueue = new ConcurrentQueue<DataMessage>();

            foreach (
                var dataMessage in FileOperationsHelper.GetFiles(MessageStatus.Input, _settings.InputDir, _settings.SearchPattern, SearchOption.AllDirectories, _settings.OrderBy, _settings.ReverseOrder))
            {
                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_1_found_in_input_location, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));
                InputQueue.Enqueue(dataMessage);
            }

            if (!InputQueue.IsEmpty)
            {
                Log.InfoFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Found_1_file_s_in_input_folder, _context.JobDetail.Key, InputQueue.Count));
                await ProcessInputQueue();
            }
        }

        /// <summary>
        /// Processes input queue
        /// </summary>
        /// <returns>
        /// Task object for continuation
        /// </returns>
        private async Task ProcessInputQueue()
        {
            using (_httpClientHelper = new HttpClientHelper(_settings, _retryPolicyForHttp))
            {
                var firstFile = true;
                string fileNameInPackage = "";
                FileStream zipToOpen = null;
                ZipArchive archive = null;

                if (!string.IsNullOrEmpty(_settings.PackageTemplate))
                {
                    fileNameInPackage = GetFileNameInPackage();
                    if (string.IsNullOrEmpty(fileNameInPackage))
                    {
                        throw new Exception(string.Format(Resources.Job_0_Please_check_your_package_template_Input_file_name_in_Manifest_cannot_be_identified, _context.JobDetail.Key));
                    }
                }

                while (InputQueue.TryDequeue(out DataMessage dataMessage))
                {
                    try
                    {
                        string tempFileName = "";
                        if (!firstFile)
                        {
                            System.Threading.Thread.Sleep(_settings.Interval);
                        }
                        else
                        {
                            firstFile = false;
                        }
                        var sourceStream = _retryPolicyForIo.Execute(() => FileOperationsHelper.Read(dataMessage.FullPath));
                        if (sourceStream == null) continue;//Nothing to do here

                        //If we need to "wrap" file in package envelope
                        if (!String.IsNullOrEmpty(_settings.PackageTemplate))
                        {
                            using (zipToOpen = new FileStream(_settings.PackageTemplate, FileMode.Open))
                            {
                                tempFileName = Path.GetTempFileName();
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(zipToOpen, tempFileName));
                                var tempZipStream = _retryPolicyForIo.Execute(() => FileOperationsHelper.Read(tempFileName));
                                using (archive = new ZipArchive(tempZipStream, ZipArchiveMode.Update))
                                {
                                    //Check if package template contains input file and remove it first. It should not be there in the first place.
                                    ZipArchiveEntry entry = archive.GetEntry(fileNameInPackage);
                                    if (entry != null)
                                    {
                                        entry.Delete();
                                        Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Package_template_contains_input_file_1_Please_remove_it_from_the_template, _context.JobDetail.Key, fileNameInPackage));
                                    }

                                    // Update Manifest file with the original file name for end-to-end traceability. Use the new file name in the rest of the method.
                                    fileNameInPackage = this.UpdateManifestFile(archive, dataMessage, fileNameInPackage);

                                    var importedFile = archive.CreateEntry(fileNameInPackage, CompressionLevel.Fastest);
                                    using (var entryStream = importedFile.Open())
                                    {
                                        sourceStream.CopyTo(entryStream);
                                        sourceStream.Close();
                                        sourceStream.Dispose();
                                    }
                                }
                                sourceStream = _retryPolicyForIo.Execute(() => FileOperationsHelper.Read(tempFileName));
                            }
                        }
                        if (Log.IsDebugEnabled)
                            Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Uploading_file_1_File_size_2_bytes, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}"), sourceStream.Length));

                        // Get blob url and id. Returns in json format
                        var response = await _httpClientHelper.GetAzureWriteUrl();
                        if(String.IsNullOrEmpty(response))
                        {
                            Log.ErrorFormat(CultureInfo.InvariantCulture, "Method GetAzureWriteUrl returned empty string");
                            continue;
                        }
                        var blobInfo = (JObject)JsonConvert.DeserializeObject(response);
                        var blobUrl = blobInfo["BlobUrl"].ToString();

                        var blobUri = new Uri(blobUrl);

                        //Upload package to blob storage
                        var uploadResponse = await _httpClientHelper.UploadContentsToBlob(blobUri, sourceStream);
                        if (sourceStream != null)
                        {
                            sourceStream.Close();
                            sourceStream.Dispose();
                            if (!String.IsNullOrEmpty(_settings.PackageTemplate))
                            {
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Delete(tempFileName));
                            }
                        }
                        if (uploadResponse.IsSuccessStatusCode)
                        {
                            //Now send import request
                            var importResponse = await _httpClientHelper.ImportFromPackage(blobUri.AbsoluteUri, _settings.DataProject, CreateExecutionId(_settings.DataProject), _settings.ExecuteImport, _settings.OverwriteDataProject, _settings.Company);

                            if (importResponse.IsSuccessStatusCode)
                            {
                                var result = importResponse.Content.ReadAsStringAsync().Result;
                                var jsonResponse = (JObject)JsonConvert.DeserializeObject(result);
                                string executionId = jsonResponse["value"].ToString();

                                var targetDataMessage = new DataMessage(dataMessage)
                                {
                                    MessageId = executionId,
                                    FullPath = dataMessage.FullPath.Replace(_settings.InputDir, _settings.UploadSuccessDir),
                                    MessageStatus = MessageStatus.Enqueued
                                };

                                // Move to inprocess/success location
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Move(dataMessage.FullPath, targetDataMessage.FullPath));

                                if (_settings.ExecutionJobPresent)
                                    _retryPolicyForIo.Execute(() => FileOperationsHelper.WriteStatusFile(targetDataMessage, _settings.StatusFileExtension));
                                if (Log.IsDebugEnabled)
                                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_1_uploaded_successfully, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));
                            }
                            else
                            {
                                // import request failed. Move message to error location.
                                Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Upload_failed_for_file_1_Failure_response_Status_2_Reason_3, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}"), importResponse.StatusCode, importResponse.ReasonPhrase));

                                var targetDataMessage = new DataMessage(dataMessage)
                                {
                                    FullPath = dataMessage.FullPath.Replace(_settings.InputDir, _settings.UploadErrorsDir),
                                    MessageStatus = MessageStatus.Failed
                                };

                                // Move data to error location
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Move(dataMessage.FullPath, targetDataMessage.FullPath));

                                // Save the log with import failure details
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.WriteStatusLogFile(targetDataMessage, importResponse, _settings.StatusFileExtension));
                            }
                        }
                        else
                        {
                            // upload failed. Move message to error location.
                            Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Upload_failed_for_file_1_Failure_response_Status_2_Reason_3, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}"), uploadResponse.StatusCode, uploadResponse.ReasonPhrase));

                            var targetDataMessage = new DataMessage(dataMessage)
                            {
                                FullPath = dataMessage.FullPath.Replace(_settings.InputDir, _settings.UploadErrorsDir),
                                MessageStatus = MessageStatus.Failed
                            };

                            // Move data to error location
                            _retryPolicyForIo.Execute(() => FileOperationsHelper.Move(dataMessage.FullPath, targetDataMessage.FullPath));

                            // Save the log with import failure details
                            _retryPolicyForIo.Execute(() => FileOperationsHelper.WriteStatusLogFile(targetDataMessage, uploadResponse, _settings.StatusFileExtension));
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Failure_processing_file_1_Exception_2, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}"), ex.Message), ex);
                        throw;
                    }
                    finally
                    {
                        if (zipToOpen != null)
                        {
                            zipToOpen.Close();
                            zipToOpen.Dispose();
                        }

                        archive?.Dispose();
                    }
                }
            }
        }

        private string GetFileNameInPackage()
        {
            var manifestPath = "";
            using (var package = ZipFile.OpenRead(_settings.PackageTemplate))
            {
                foreach (var entry in package.Entries)
                {
                    if (entry.FullName.Equals("Manifest.xml", StringComparison.OrdinalIgnoreCase))
                    {
                        manifestPath = Path.Combine(Path.GetTempPath(), $"{_context.JobDetail.Key}-{entry.FullName}");
                        entry.ExtractToFile(manifestPath, true);
                    }
                }
            }
            var doc = new XmlDocument();
            string fileName;
            using (var manifestFile = new StreamReader(manifestPath))
            {
                doc.Load(new XmlTextReader(manifestFile) { Namespaces = false });
                fileName = doc.SelectSingleNode("//InputFilePath[1]")?.InnerText;
            }
            return fileName;
        }

        /// <summary>
        /// Updates the Manifest.xml file of the datapackage to be uploaded with the original file name of the related data message before the upload
        /// </summary>
        /// <param name="archive">The data package which is being prepared for upload</param>
        /// <param name="dataMessage">The data message object containing the inforation related to the file which is getting uploaded</param>
        /// <param name="fileNameInPackageOrig">Original file name in the package</param>
        /// <returns>Final file name in the package</returns>
        private string UpdateManifestFile(ZipArchive archive, DataMessage dataMessage, string fileNameInPackageOrig)
        {
            if (archive is null || dataMessage is null)
            {
                return fileNameInPackageOrig;
            }

            // This modification will cause that the original file name is used in the package that is going to be uploaded to D365
            // Get the manifest.xml entery
            ZipArchiveEntry manifestEntry = archive.GetEntry("Manifest.xml");

            // Save the Manifest.xml as temporary file
            string tempManifestFileName = Path.GetTempFileName();
            string tempManifestFileNameNew = Path.GetTempFileName();

            manifestEntry.ExtractToFile(tempManifestFileName, true);

            // Modify the file name to the original filename
            XmlDocument tempXmlDocManifest = new XmlDocument();

            using (var tempManifestFile = new StreamReader(tempManifestFileName))
            {
                tempXmlDocManifest.Load(new XmlTextReader(tempManifestFile) { Namespaces = false });
                tempXmlDocManifest.SelectSingleNode("//InputFilePath[1]").InnerText = Path.GetFileName(dataMessage.FullPath);

                // Save the document to a file and auto-indent the output.
                using (XmlTextWriter writer = new XmlTextWriter(tempManifestFileNameNew, null))
                {
                    writer.Namespaces = false;
                    writer.Formatting = System.Xml.Formatting.Indented;
                    tempXmlDocManifest.Save(writer);
                }
            }

            // Delete the Manifest.xml from the archive file
            manifestEntry.Delete();

            // Add a new Manifest.xml based on the adjusted file
            archive.CreateEntryFromFile(tempManifestFileNameNew, "Manifest.xml");

            // Delete the tempoirary file
            File.Delete(tempManifestFileName);
            File.Delete(tempManifestFileNameNew);

            // Adapt the fileNameInPackage
            string fileNameInPackage = Path.GetFileName(dataMessage.FullPath);

            // Check if package template contains input file and remove it first. It should not be there in the first place.
            ZipArchiveEntry entry = archive.GetEntry(fileNameInPackage);            
            if (entry != null)
            {
                entry.Delete();
                Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Package_template_contains_input_file_1_Please_remove_it_from_the_template, fileNameInPackage));
            }

            return fileNameInPackage;
        }

        private static string CreateExecutionId(string dataProject)
        {
            return $"{dataProject}-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-{Guid.NewGuid().ToString()}";
        }
    }
}
