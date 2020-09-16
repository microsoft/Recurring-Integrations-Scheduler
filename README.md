# Recurring Integrations Scheduler RIS

This tool helps to quickly set up and orchestrate file based integration scenarios to and from Dynamics 365 Finance and Dynamics 365 Supply Chain Management. We see this tool to be a good implementation accelerator for use during the implementation phase of the project for data migration, ad hoc file integration needs and to be used as a proof of concept validator among others. 

## Recurring Integrations Scheduler Service

Recurring Integrations Scheduler Service is a Windows service that can trigger many integration jobs at predefined schedule. You can schedule jobs and set their recurrence in a very similar way to well-known D365FO batch framework.

There are six types of integration jobs you can use: [Import](https://github.com/microsoft/Recurring-Integrations-Scheduler/wiki#import-job), [Export](https://github.com/microsoft/Recurring-Integrations-Scheduler/wiki#export-job) and [Execution monitor](https://github.com/microsoft/Recurring-Integrations-Scheduler/wiki#execution-monitor-job) as well as [Upload](https://github.com/microsoft/Recurring-Integrations-Scheduler/wiki#upload-job), [Download](https://github.com/microsoft/Recurring-Integrations-Scheduler/wiki#download-job) and [Processing monitor](https://github.com/microsoft/Recurring-Integrations-Scheduler/wiki#processing-monitor-job). First three use [Data management package REST API](https://docs.microsoft.com/en-us/dynamics365/fin-ops-core/dev-itpro/data-entities/data-management-api). Three other use [Recurring Integrations REST API](https://docs.microsoft.com/en-us/dynamics365/fin-ops-core/dev-itpro/data-entities/recurring-integrations) and recurring data jobs.
More details in wiki.

Single Recurring Integrations Scheduler service can work with multiple D365FO instances even within different tenants. This enables both production and implementation scenarios where you need to work with multiple non-prod instances. Recurring Integrations Scheduler logs important events to Windows Event Log. It is possible to increase its logging level to log every step for debugging purposes and to trace possible problems.

## Recurring Integrations Scheduler App

Recurring Integrations Scheduler App is a win32 application that can be used as a configuration front-end for Recurring Integrations Scheduler service or as a completely independent, interactive application used to upload or download files to and from Dynamics 365 Finance or SCM without Recurring Integrations Scheduler Service.
It is possible thanks to internal, private scheduler embedded in Recurring Integrations Scheduler App that works exactly the same way as the Scheduler Service does with one difference - it will stop working once the App is closed.

## Installation and configuration

Please check https://github.com/Microsoft/Recurring-Integrations-Scheduler/wiki

## Support

RIS is not officially supported by Microsoft. Please log an issue here on Github if you encounter a bug in RIS.
