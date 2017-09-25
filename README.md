# Recurring Integrations Scheduler

This tool helps to quickly set up and orchestrate file based integration scenarios to and from Dynamics 365 for Finance and Operations. We see this tool to be a good implementation accelerator for use during the implementation phase of the project for data migration, ad hoc file integration needs and to be used as a proof of concept validator among others, to be used non-production environments only. 

## Recurring Integrations Scheduler Service

Recurring Integrations Scheduler Service is a Windows service that can trigger many integration jobs at predefined schedule. You can schedule jobs and set their recurrence in a very similar way to well-known Operations' batch framework.

There is six types of integration jobs you can use: Import, Export and Execution monitor as well as Upload, Download and Processing monitor. First three use new Odata actions introduced in Platform Update 5. Three other use Connector API and recurring data jobs.
More details in wiki.

Single Recurring Integrations Scheduler service can work with multiple Operations instances even within different tenants. This enables both production and implementation scenarios where you need to work with multiple non-prod instances. Recurring Integrations Scheduler logs important events to Windows Event Log. It is possible to increase its logging level to log every step for debugging purposes and to trace possible problems.

## Recurring Integrations Scheduler App

Recurring Integrations Scheduler App is a win32 application that can be used as a configuration front-end for Recurring Integrations Scheduler service or as a completely independent, interactive application used to upload or download files to and from Dynamics 365 for Finance and Operations without Recurring Integrations Scheduler Service.
It is possible thanks to internal, private scheduler embedded in Recurring Integrations Scheduler App that works exactly the same way as the Scheduler Service does with one difference - it will stop working once the App is closed. Recurring Integrations Scheduler App is much easier to use than standard application released with new AX and at the same time offers more functions.

## Installation and configuration

Please check https://github.com/Microsoft/Recurring-Integrations-Scheduler/wiki

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
