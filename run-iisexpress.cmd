SET DNX_HOME=%USERPROFILE%\.dnx\

SET "APP_POOL_ID=Clr4IntegratedAppPool"
SET "ASPNET_ENV=Development"
SET "COMPLUS_ForceENC=1"
SET "COMPLUS_MDA=managedDebugger"
SET "DEV_ENVIRONMENT=1"
SET "DNX_COMPILATION_SERVER_PORT=3511"
SET "DNX_CONFIGURATION=Debug"
SET "DNX_IS_WINDOWS=1"
SET "FPS_BROWSER_APP_PROFILE_STRING=Internet Explorer"
SET "FPS_BROWSER_USER_PROFILE_STRING=Default"
SET "IIS_BIN=C:\Program Files (x86)\IIS Express"
SET "IIS_DRIVE=C:"
SET "IISEXPRESS_SITENAME=fsharp-angular-web"
SET "MSBuildLoadMicrosoftTargetsReadOnly=true"
SET "VisualStudioEdition=Microsoft Visual Studio Enterprise 2015"
SET "VisualStudioVersion=14.0"
SET "VSIDE=true"
SET "VSLANG=1033"
SET "VSLOGGER_UNIQUEID=9594e643e3764536964265985c1bca9c"
SET "XTC_IDE=bed344409d854f1e8b7846625f41c407"

REM copy the AspNet.Loader.dll to bin folder
md wwwroot\bin

SET ASPNETLOADER_PACKAGE_BASEPATH=%USERPROFILE%\\.dnx\\packages\Microsoft.AspNet.Loader.IIS.Interop
REM figure out the path of AspNet.Loader.dll
FOR /F %%j IN ('dir /b /o:D %ASPNETLOADER_PACKAGE_BASEPATH%\*') do (SET AspNetLoaderPath=%ASPNETLOADER_PACKAGE_BASEPATH%\%%j\tools\AspNet.Loader.dll)
echo Found AspNetLoader.dll at %AspNetLoaderPath%. Copying to bin\
copy %AspNetLoaderPath% wwwroot\bin\

"C:\Program Files (x86)\IIS Express\iisexpress.exe" /config:".vs\config\applicationhost.config" /site:"fsharp-angular-web" /apppool:"Clr4IntegratedAppPool"
