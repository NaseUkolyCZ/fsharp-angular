"&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"
dnvm install 1.0.0-beta7
dnvm upgrade
dnvm update-self
dnvm list
dnvm use 1.0.0-beta7
npm cache clean
npm install -g gulp bower grunt-cli
dnu restore
