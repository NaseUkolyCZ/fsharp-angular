powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"

choco install nodejs -y

call npm install -g grunt-cli bower

cd src\fsharp-angular-web

call npm install grunt
call npm install

call bower install

call dnvm install 1.0.0-beta7
call dnvm upgrade
call dnvm update-self
call dnvm list
call dnvm use 1.0.0-beta7
call %userprofile%\.dnx\runtimes\dnx-clr-win-x86.1.0.0-beta7\bin\dnu restore

cd ..
cd ..

.paket\paket update

echo "Finished" > setup_done.txt
