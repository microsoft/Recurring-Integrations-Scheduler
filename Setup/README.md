To create installation package you need few additional binary files which are not included in RIS source code.

Please download the following Quartz.NET server binaries and copy those files to this folder.

* Quartz.Server.exe
* Quartz.Jobs.dll
* Quartz.Plugins.dll
* Quartz.Serialization.Json.dll
* Topshelf.dll

This version of Recurring Integrations Scheduler requires Quartz.NET 3.0.6
Download zip archive from https://github.com/quartznet/quartznet/releases


**Recurring Integrations Scheduler.iss** file contains packaging instructions for [Inno Setup](http://www.jrsoftware.org/isinfo.php) installer.

Example command to create installation package (executed from root folder of the solution):
```
"C:\Program Files (x86)\Inno Setup 5\Compil32.exe" /cc ".\Setup\Recurring Integrations Scheduler.iss"
```
