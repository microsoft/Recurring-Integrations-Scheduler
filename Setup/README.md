**Recurring Integrations Scheduler.iss** file contains packaging instructions for [Inno Setup](http://www.jrsoftware.org/isinfo.php) installer.

Example command to create installation package (executed from root folder of the solution):
```
"C:\Program Files (x86)\Inno Setup 5\Compil32.exe" /cc ".\Setup\Recurring Integrations Scheduler.iss"
```

Please download Quartz.NET server binaries and copy those files to this folder.
This version of Recurring Integrations Scheduler requires Quartz.NET 2.4.1

Download zip archive from https://sourceforge.net/projects/quartznet/files/quartznet/Quartz.NET%202.4.1/Quartz.NET-2.4.1.zip/download

Listed below are files that should be extracted from server\bin\4.0\ folder into this folder.

* Quartz.Server.exe
* Topshelf.dll
