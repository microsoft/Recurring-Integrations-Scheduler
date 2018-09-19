#define MyAppName "Recurring Integrations Scheduler - solution for file-based integrations with Dynamics 365 for Finance and Operations, Enterprise Edition"
#define MyAppShortName "Recurring Integrations Scheduler"
#define MyAppVersion GetFileVersion("..\Output\Release\RecurringIntegrationsScheduler.exe")
                                                                                      
[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{0746B957-721B-4245-A6B9-01D5DBF187F6}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
VersionInfoVersion={#MyAppVersion}
DefaultDirName={pf}\{#MyAppShortName}
DefaultGroupName={#MyAppShortName}
AllowNoIcons=yes
OutputBaseFilename=Recurring Integrations Scheduler Setup
OutputDir=..\
SetupIconFile=.\Recurring Integrations Scheduler.ico
Compression=lzma
SolidCompression=yes
LicenseFile=..\LICENSE.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Types]
Name: "full"; Description: "Full installation (Recurring Integrations Scheduler)"
Name: "app"; Description: "Recurring Integrations Scheduler App"
Name: "scheduler"; Description: "Recurring Integrations Scheduler Service"

[Components]
Name: App; Description: Recurring Integrations Scheduler App; Types: full app; Flags: fixed
Name: Scheduler; Description: Recurring Integrations Scheduler Service; Types: full scheduler; Flags: fixed

[Files]
; Quartz
Source: "..\Output\Release\Quartz.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\log4net.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: ".\Quartz.Plugins.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: ".\Quartz.Jobs.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: ".\Quartz.Serialization.Json.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: ".\Quartz.Server.exe"; DestDir: "{app}"; Flags: ignoreversion; Components: Scheduler
Source: ".\Topshelf.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: Scheduler
; Common
Source: "..\Output\Release\RecurringIntegrationsScheduler.Common.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
; Jobs
Source: "..\Output\Release\RecurringIntegrationsScheduler.Job.Upload.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\RecurringIntegrationsScheduler.Job.ProcessingMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\RecurringIntegrationsScheduler.Job.Download.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\RecurringIntegrationsScheduler.Job.Import.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\RecurringIntegrationsScheduler.Job.Export.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\RecurringIntegrationsScheduler.Job.ExecutionMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
; References
Source: "..\Output\Release\Microsoft.IdentityModel.Clients.ActiveDirectory.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\Microsoft.IdentityModel.Clients.ActiveDirectory.Platform.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Linq.Dynamic.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\Polly.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\PortableSettingsProvider.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\Microsoft.Win32.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\netstandard.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.AppContext.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Collections.Concurrent.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Collections.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Collections.NonGeneric.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Collections.Specialized.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.ComponentModel.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.ComponentModel.EventBasedAsync.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.ComponentModel.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.ComponentModel.TypeConverter.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Console.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Data.Common.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.Contracts.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.Debug.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.FileVersionInfo.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.Process.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.StackTrace.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.TextWriterTraceListener.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.Tools.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.TraceSource.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Diagnostics.Tracing.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Drawing.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Dynamic.Runtime.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Globalization.Calendars.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Globalization.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Globalization.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.Compression.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.Compression.ZipFile.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.FileSystem.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.FileSystem.DriveInfo.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.FileSystem.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.FileSystem.Watcher.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.IsolatedStorage.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.MemoryMappedFiles.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.Pipes.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.IO.UnmanagedMemoryStream.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Linq.Expressions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Linq.Parallel.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Linq.Queryable.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.Http.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.NameResolution.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.NetworkInformation.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.Ping.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.Requests.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.Security.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.Sockets.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.WebHeaderCollection.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.WebSockets.Client.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Net.WebSockets.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.ObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Reflection.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Reflection.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Reflection.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Resources.Reader.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Resources.ResourceManager.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Resources.Writer.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.CompilerServices.VisualC.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Handles.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.InteropServices.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.InteropServices.RuntimeInformation.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Numerics.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Serialization.Formatters.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Serialization.Json.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Serialization.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Runtime.Serialization.Xml.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Claims.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Cryptography.Algorithms.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Cryptography.Csp.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Cryptography.Encoding.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Cryptography.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Cryptography.X509Certificates.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.Principal.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Security.SecureString.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Text.Encoding.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Text.Encoding.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Text.RegularExpressions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.Overlapped.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.Tasks.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.Tasks.Parallel.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.Thread.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.ThreadPool.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Threading.Timer.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.ValueTuple.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Xml.ReaderWriter.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Xml.XDocument.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Xml.XmlDocument.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Xml.XmlSerializer.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Xml.XPath.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Release\System.Xml.XPath.XDocument.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler

; App
Source: "..\Output\Release\RecurringIntegrationsScheduler.exe"; DestDir: "{app}"; Flags: ignoreversion; Components: App
Source: "..\Output\Release\RecurringIntegrationsScheduler.exe"; DestDir: "{app}"; Flags: ignoreversion; Components: App
Source: "..\Output\Release\RecurringIntegrationsScheduler.exe.config"; DestDir: "{app}"; Flags: ignoreversion; Components: App

; Configuration files
Source: ".\Schedule.xml"; DestDir: "{app}"; Flags: onlyifdoesntexist uninsneveruninstall; Components: Scheduler
Source: ".\Quartz.Server.exe.config"; DestDir: "{app}"; Flags: onlyifdoesntexist; Components: Scheduler
; ReadMe
Source: "..\README.MD"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
; License
Source: "..\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Third Party Notices.txt"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler

[Registry]
Root: HKLM; Subkey: "System\CurrentControlSet\Services\EventLog\Recurring Integrations Scheduler\Recurring Integrations Scheduler App"; ValueType: expandsz; ValueName: "EventMessageFile"; ValueData: "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\EventLogMessages.dll"; Flags: uninsdeletekey; Components: App
[Icons]
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{group}\Recurring Integrations Scheduler App"; Filename: "{app}\RecurringIntegrationsScheduler.exe"; WorkingDir: "{app}"

[Run]
Filename: "{app}\Quartz.Server.exe"; Parameters: "install"; Flags: runhidden; Components: Scheduler
Filename: {sys}\sc.exe; Parameters: "start RecurringIntegrationsScheduler" ; Flags: runhidden

[UninstallRun]
Filename: {sys}\sc.exe; Parameters: "stop RecurringIntegrationsScheduler" ; Flags: runhidden
Filename: "{app}\Quartz.Server.exe"; Parameters: "uninstall"; Flags: runhidden; Components: Scheduler
