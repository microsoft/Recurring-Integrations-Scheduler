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

                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_starting, _context.JobDetail.Key));
                }
                await Process();

                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_ended, _context.JobDetail.Key));
                }
            }
            catch (Exception ex)
            {
                if (_settings.PauseJobOnException)
                {
                    await context.Scheduler.PauseJob(context.JobDetail.Key);
                    Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_was_paused_because_of_error, _context.JobDetail.Key));
                }
                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    if (!string.IsNullOrEmpty(ex.Message))
                    {
                        Log.Error(ex.Message, ex);
                    }
                }
                if (context.Scheduler.SchedulerName != "Private")
                {
                    throw new JobExecutionException(string.Format(Resources.Import_job_0_failed, _context.JobDetail.Key), ex, false);
                }
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
                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_1_found_in_input_location, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));
                }
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
            using (_httpClientHelper = new HttpClientHelper(_settings))
            {
                var fileCount = 0;
                string fileNameInPackageTemplate = "";
                FileStream zipToOpen = null;
                ZipArchive archive = null;

                if (_settings.InputFilesArePackages == false)
                {
                    fileNameInPackageTemplate = GetFileNameInPackageTemplate();
                    if (string.IsNullOrEmpty(fileNameInPackageTemplate))
                    {
                        throw new JobExecutionException(string.Format(Resources.Job_0_Please_check_your_package_template_Input_file_name_in_Manifest_cannot_be_identified, _context.JobDetail.Key));
                    }
                }

                while (InputQueue.TryDequeue(out DataMessage dataMessage))
                {
                    try
                    {
                        if (fileCount > 0 && _settings.DelayBetweenFiles > 0) //Only delay after first file and never after last.
                        {
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_settings.DelayBetweenFiles));
                        }
                        fileCount++;

                        var sourceStream = _retryPolicyForIo.Execute(() => FileOperationsHelper.Read(dataMessage.FullPath));
                        if (sourceStream == null) continue;//Nothing to do here

                        string tempFileName = "";

                        //If we need to "wrap" file in package envelope
                        if (_settings.InputFilesArePackages == false)
                        {
                            using (zipToOpen = new FileStream(_settings.PackageTemplate, FileMode.Open))
                            {
                                tempFileName = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(zipToOpen, tempFileName));
                                var tempZipStream = _retryPolicyForIo.Execute(() => FileOperationsHelper.Read(tempFileName));
                                using (archive = new ZipArchive(tempZipStream, ZipArchiveMode.Update))
                                {
                                    //Check if package template contains input file and remove it first. It should not be there in the first place.
                                    ZipArchiveEntry entry = archive.GetEntry(fileNameInPackageTemplate);
                                    if (entry != null)
                                    {
                                        entry.Delete();
                                        Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Package_template_contains_input_file_1_Please_remove_it_from_the_template, _context.JobDetail.Key, fileNameInPackageTemplate));
                                    }

                                    // Update Manifest file with the original file name for end-to-end traceability. Use the new file name in the rest of the method.
                                    fileNameInPackageTemplate = UpdateManifestFile(archive, dataMessage, fileNameInPackageTemplate);

                                    var importedFile = archive.CreateEntry(fileNameInPackageTemplate, CompressionLevel.Fastest);
                                    using var entryStream = importedFile.Open();
                                    sourceStream.CopyTo(entryStream);
                                    sourceStream.Close();
                                    sourceStream.Dispose();
                                }
                                sourceStream = _retryPolicyForIo.Execute(() => FileOperationsHelper.Read(tempFileName));
                            }
                        }
                        if (Log.IsDebugEnabled)
                            Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Uploading_file_1_File_size_2_bytes, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}"), sourceStream.Length));

                        // Get blob url and id. Returns in json format
                        var response = await _httpClientHelper.GetAzureWriteUrl();
                        if(!response.IsSuccessStatusCode)
                        {
                            throw new JobExecutionException($"Job: {_settings.JobKey}. Request GetAzureWriteUrl failed.");
                        }
                        var blobInfo = (JObject)JsonConvert.DeserializeObject(HttpClientHelper.ReadResponseString(response));
                        var blobUrl = blobInfo["BlobUrl"].ToString();

                        var blobUri = new Uri(blobUrl);

                        //Upload package to blob storage
                        var uploadResponse = await _httpClientHelper.UploadContentsToBlob(blobUri, sourceStream);
                        
                        if (sourceStream != null)
                        {
                            sourceStream.Close();
                            sourceStream.Dispose();
                            if (!_settings.InputFilesArePackages)//if we wraped file in package envelop we need to delete temp file
                            {
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Delete(tempFileName));
                            }
                        }
                        if (uploadResponse.IsSuccessStatusCode)
                        {
                            //Now send import request
                            var targetLegalEntity = _settings.Company;
                            if (_settings.MultiCompanyImport && _settings.GetLegalEntityFromSubfolder)
                            {
                                targetLegalEntity = new FileInfo(dataMessage.FullPath).Directory.Name;
                            }
                            if (_settings.MultiCompanyImport && _settings.GetLegalEntityFromFilename)
                            {
                                String[] separator = { _settings.FilenameSeparator };
                                var tokenList = dataMessage.Name.Split(separator, 10, StringSplitOptions.RemoveEmptyEntries);

                                targetLegalEntity = tokenList[_settings.LegalEntityTokenPosition - 1];
                            }
                            if(targetLegalEntity.Length > 4)
                            {
                                Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Target_legal_entity_is_not_valid_1, _context.JobDetail.Key, targetLegalEntity));
                            }

                            if(string.IsNullOrEmpty(targetLegalEntity))
                            {
                                throw new Exception(string.Format(Resources.Job_0_Unable_to_get_target_legal_entity_name, _context.JobDetail.Key));
                            }
                            var executionIdGenerated = CreateExecutionId(_settings.DataProject);
                            var importResponse = await _httpClientHelper.ImportFromPackage(blobUri.AbsoluteUri, _settings.DataProject, executionIdGenerated, _settings.ExecuteImport, _settings.OverwriteDataProject, targetLegalEntity);

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
                                Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Upload_failed_for_file_1_Failure_response_Status_2_Reason_3, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}"), importResponse.StatusCode, importResponse.ReasonPhrase, $"{Environment.NewLine}packageUrl: {blobUri.AbsoluteUri}{Environment.NewLine}definitionGroupId: {_settings.DataProject}{Environment.NewLine}executionId: {executionIdGenerated}{Environment.NewLine}execute: {_settings.ExecuteImport}{Environment.NewLine}overwrite: {_settings.OverwriteDataProject}{Environment.NewLine}legalEntityId: {targetLegalEntity}"));

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

        private string GetFileNameInPackageTemplate()
        {
            using var package = ZipFile.OpenRead(_settings.PackageTemplate);
            foreach (var entry in package.Entries)
            {
                if (entry.FullName.Equals("Manifest.xml", StringComparison.OrdinalIgnoreCase))
                {
                    var manifestPath = Path.Combine(Path.GetTempPath(), $"{_context.JobDetail.Key}-{entry.FullName}");
                    entry.ExtractToFile(manifestPath, true);

                    var doc = new XmlDocument();
                    using var manifestFile = new StreamReader(manifestPath);
                    doc.Load(new XmlTextReader(manifestFile) { Namespaces = false });
                    return doc.SelectSingleNode("//InputFilePath[1]")?.InnerText;
                }
            }
            return null;
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
            string tempManifestFileName = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            string tempManifestFileNameNew = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            manifestEntry.ExtractToFile(tempManifestFileName, true);

            // Modify the file name to the original filename
            XmlDocument tempXmlDocManifest = new XmlDocument();

            using (var tempManifestFile = new StreamReader(tempManifestFileName))
            {
                tempXmlDocManifest.Load(new XmlTextReader(tempManifestFile) { Namespaces = false });
                tempXmlDocManifest.SelectSingleNode("//InputFilePath[1]").InnerText = Path.GetFileName(dataMessage.FullPath);

                // Save the document to a file and auto-indent the output.
                using XmlTextWriter writer = new XmlTextWriter(tempManifestFileNameNew, null)
                {
                    Namespaces = false,
                    Formatting = System.Xml.Formatting.Indented
                };
                tempXmlDocManifest.Save(writer);
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
            return $"{dataProject}-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-{Guid.NewGuid()}";
        }
    }
}
