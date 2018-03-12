/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Properties;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    public static class FileOperationsHelper
    {
        /// <summary>
        /// Deletes file specified by file path
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Boolean with operation result</returns>
        public static void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// Opens file as a file stream
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Stream</returns>
        public static Stream Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                return new FileStream(filePath,
                    FileMode.Open,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite,
                    4096,
                    true);
            }
            return null;
         }

        /// <summary>
        /// Creates a file
        /// </summary>
        /// <param name="sourceStream">Source stream</param>
        /// <param name="filePath">Target file path</param>
        /// <returns>Boolean with operation result</returns>
        public static void Create(Stream sourceStream, string filePath)
        {
            var targetDirectoryName = Path.GetDirectoryName(filePath);
            if (targetDirectoryName == null)
                throw new DirectoryNotFoundException();

            Directory.CreateDirectory(targetDirectoryName);
            using (var fileStream = File.Create(filePath))
            {
                sourceStream.Seek(0, SeekOrigin.Begin);
                sourceStream.CopyTo(fileStream);
            }
        }

        /// <summary>
        /// Searches for source files in target path and returns list of dataMessage objects
        /// </summary>
        /// <param name="messageStatus">Data message status for found files</param>
        /// <param name="path">Path to search</param>
        /// <param name="searchPatterns">File pattern</param>
        /// <param name="searchOption">Search option</param>
        /// <param name="sortBy">Sort by field</param>
        /// <param name="reverse">Order of files</param>
        /// <returns>List of dataMessage objects</returns>
        public static IEnumerable<DataMessage> GetFiles(MessageStatus messageStatus, string path, string searchPatterns = "*.*",
            SearchOption searchOption = SearchOption.AllDirectories, OrderByOptions sortBy = OrderByOptions.Created,
            bool reverse = false)
        {
            var dir = new DirectoryInfo(path);
            var sortByProperty = string.Empty;
            switch (sortBy)
            {
                case OrderByOptions.Created:
                    sortByProperty = @"CreationTimeUtc";
                    break;

                case OrderByOptions.Modified:
                    sortByProperty = @"LastWriteTimeUtc";
                    break;

                case OrderByOptions.Size:
                    sortByProperty = @"Length";
                    break;

                case OrderByOptions.FileName:
                    sortByProperty = @"FullName";
                    break;
            }

            foreach (FileInfo fileName in dir.EnumerateFiles(searchPatterns, searchOption).Sort(sortByProperty, reverse)
            )
            {
                var dataMessage = new DataMessage
                {
                    Name = fileName.Name,
                    FullPath = fileName.FullName,
                    MessageStatus = messageStatus
                };
                yield return dataMessage;
            }
        }

        /// <summary>
        /// Searches for status files in target path and returns list of dataMessage objects
        /// </summary>
        /// <param name="messageStatus">Data message status for found files</param>
        /// <param name="path">Path to search</param>
        /// <param name="searchPatterns">File pattern</param>
        /// <param name="searchOption">Search option</param>
        /// <param name="sortBy">Sort by field</param>
        /// <param name="reverse">Order of files</param>
        /// <returns>List of dataMessage objects</returns>
        public static IEnumerable<DataMessage> GetStatusFiles(MessageStatus messageStatus, string path,
            string searchPatterns = "*.Status", SearchOption searchOption = SearchOption.AllDirectories,
            OrderByOptions sortBy = OrderByOptions.Created, bool reverse = false)
        {
            var dir = new DirectoryInfo(path);
            var sortByProperty = string.Empty;
            switch (sortBy)
            {
                case OrderByOptions.Created:
                    sortByProperty = @"CreationTimeUtc";
                    break;

                case OrderByOptions.Modified:
                    sortByProperty = @"LastWriteTimeUtc";
                    break;

                case OrderByOptions.Size:
                    sortByProperty = @"Length";
                    break;

                case OrderByOptions.FileName:
                    sortByProperty = @"FullName";
                    break;
            }

            foreach (FileInfo fileName in dir.EnumerateFiles(searchPatterns, searchOption).Sort(sortByProperty, reverse)
            )
            {
                DataMessage dataMessage;
                using (var file = File.OpenText(fileName.FullName))
                {
                    var serializer = new JsonSerializer();
                    dataMessage = (DataMessage) serializer.Deserialize(file, typeof(DataMessage));
                }
                yield return dataMessage;
            }
        }

        /// <summary>
        /// Searches for all subfolders of given path
        /// </summary>
        /// <param name="directory">Root directory</param>
        /// <returns>List of subfolders' paths</returns>
        public static IEnumerable<string> FindAllSubfolders(string directory)
        {
            var allSubfolders = new List<string>();
            foreach (var d in Directory.GetDirectories(directory))
            {
                allSubfolders.Add(d);
                allSubfolders.AddRange(FindAllSubfolders(d));
            }
            return allSubfolders;
        }

        /// <summary>
        /// Extracts content of data package zip archive
        /// </summary>
        /// <param name="filePath">File path of data package</param>
        /// <param name="deletePackage">Flag whether to delete zip file</param>
        /// <param name="addTimestamp">Flag whether to add timestamp to extracted file name</param>
        /// <returns>Boolean with operation result</returns>
        public static void UnzipPackage(string filePath, bool deletePackage, bool addTimestamp = false)
        {
            if (File.Exists(filePath))
            {
                using (var zip = ZipFile.OpenRead(filePath))
                {
                    foreach (var entry in zip.Entries)
                    {
                        if ((entry.Length == 0) || (entry.FullName == "Manifest.xml") ||
                            (entry.FullName == "PackageHeader.xml"))
                            continue;

                        string fileName;

                        if (addTimestamp)
                            fileName =
                                Path.Combine(Path.GetDirectoryName(filePath) ?? throw new InvalidOperationException(),
                                    Path.GetFileNameWithoutExtension(filePath) ?? throw new InvalidOperationException()) + "-" + entry.FullName;
                        else
                            fileName = Path.Combine(Path.GetDirectoryName(filePath) ?? throw new InvalidOperationException(), entry.FullName);

                        entry.ExtractToFile(fileName, !addTimestamp);
                    }
                }
                if (deletePackage)
                    File.Delete(filePath);
            }
        }

        /// <summary>
        /// Moves source file between folders and deletes status files when needed
        /// </summary>
        /// <param name="sourceFilePath">Source file path</param>
        /// <param name="targetFilePath">Target file path</param>
        /// <param name="deleteStatusFile">Flag whether to delete status file</param>
        /// <param name="statusFileExtension">Status file extension</param>
        public static void MoveDataToTarget(string sourceFilePath, string targetFilePath, bool deleteStatusFile = false, string statusFileExtension = ".Status")
        {
            Move(sourceFilePath, targetFilePath);

            //Now status file
            if (!deleteStatusFile)
            {
                var sourceStatusFile = Path.Combine(Path.GetDirectoryName(sourceFilePath) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(sourceFilePath) + statusFileExtension);
                var targetStatusFile = Path.Combine(Path.GetDirectoryName(targetFilePath) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(targetFilePath) + statusFileExtension);
                Move(sourceStatusFile, targetStatusFile);
            }
            else
            {
                var sourceStatusFile = Path.Combine(Path.GetDirectoryName(sourceFilePath) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(sourceFilePath) + statusFileExtension);
                Delete(sourceStatusFile);
            }
        }

        /// <summary>
        /// Moves source file between folders
        /// </summary>
        /// <param name="sourceFilePath">Source file path</param>
        /// <param name="targetFilePath">Target file path</param>
        /// <returns>Boolean with operation result</returns>
        public static void Move(string sourceFilePath, string targetFilePath)
        {
            if (File.Exists(targetFilePath))
            {
                File.Delete(targetFilePath);
            }
            File.Move(sourceFilePath, targetFilePath);
        }

        /// <summary>
        /// Creates status file for data message
        /// </summary>
        /// <param name="dataMessage">dataMessage object</param>
        /// <param name="statusFileExtension">Status file extension</param>
        public static void WriteStatusFile(DataMessage dataMessage, string statusFileExtension = ".Status")
        {
            if (dataMessage == null)
            {
                return;
            }
            var statusData = JsonConvert.SerializeObject(dataMessage, Formatting.Indented, new StringEnumConverter());

            using (var statusFileMemoryStream = new MemoryStream(Encoding.Default.GetBytes(statusData)))
            {
                Create(statusFileMemoryStream, Path.Combine(Path.GetDirectoryName(dataMessage.FullPath) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(dataMessage.FullPath) + statusFileExtension));
            }
        }

        /// <summary>
        /// Creates status log file for data message
        /// </summary>
        /// <param name="targetDataMessage">target dataMessage object</param>
        /// <param name="httpResponse">httpResponse object</param>
        /// <param name="statusFileExtension">Status file extension</param>
        public static void WriteStatusLogFile(DataMessage targetDataMessage, HttpResponseMessage httpResponse, string statusFileExtension = ".Status")
        {
            if (targetDataMessage == null || httpResponse == null)
            {
                return;
            }
            var logFilePath = Path.Combine(Path.GetDirectoryName(targetDataMessage.FullPath) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(targetDataMessage.FullPath) + statusFileExtension);
            var logData = JsonConvert.SerializeObject(httpResponse, Formatting.Indented, new StringEnumConverter());

            using (var logMemoryStream = new MemoryStream(Encoding.Default.GetBytes(logData)))
            {
                Create(logMemoryStream, logFilePath);
            }
        }

        /// <summary>
        /// Creates status log file for data message
        /// </summary>
        /// <param name="jobStatusDetail">DataJobStatusDetail object</param>
        /// <param name="targetDataMessage">target dataMessage object</param>
        /// <param name="httpResponse">httpResponse object</param>
        /// <param name="statusFileExtension">Status file extension</param>
        public static void WriteStatusLogFile(DataJobStatusDetail jobStatusDetail, DataMessage targetDataMessage, HttpResponseMessage httpResponse, string statusFileExtension = ".Status")
        {
            if (targetDataMessage == null)
            {
                return;
            }
            var logFilePath = Path.Combine(Path.GetDirectoryName(targetDataMessage.FullPath) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(targetDataMessage.FullPath) + statusFileExtension);
            string logData;

            if (null != jobStatusDetail)
            {
                logData = JsonConvert.SerializeObject(jobStatusDetail, Formatting.Indented, new StringEnumConverter());
            }
            else if (null != httpResponse)
            {
                logData = JsonConvert.SerializeObject(httpResponse, Formatting.Indented, new StringEnumConverter());
            }
            else
            {
                logData = Resources.Unknown_error;
            }

            using (var logMemoryStream = new MemoryStream(Encoding.Default.GetBytes(logData)))
            {
                Create(logMemoryStream, logFilePath);
            }
        }
    }
}