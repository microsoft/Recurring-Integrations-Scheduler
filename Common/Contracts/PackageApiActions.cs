/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Class holding requests paths related to Package API
    /// </summary>
    public static class PackageApiActions
    {
        public const string GetAzureWriteUrlActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetAzureWriteUrl";
        public const string GetExecutionSummaryStatusActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExecutionSummaryStatus";
        public const string GetExportedPackageUrlActionPath =  "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExportedPackageUrl";
        public const string GetExecutionSummaryPageUrlActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExecutionSummaryPageUrl";
        public const string ImportFromPackageActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ImportFromPackage";
        public const string DeleteExecutionHistoryJobActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.DeleteExecutionHistoryJob";
        public const string ExportToPackageActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ExportToPackage";
        public const string ExportFromPackageActionPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ExportFromPackage";
        public const string GetMessageStatusActionPath =  "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetMessageStatus";
        public const string GetImportTargetErrorKeysFileUrlPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetImportTargetErrorKeysFileUrl";
        public const string GenerateImportTargetErrorKeysFilePath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GenerateImportTargetErrorKeysFile";
        public const string GetExecutionErrorsPath = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.GetExecutionErrors";
    }
}