SET mypath=%~dp0
echo %mypath:~0,-1%
cd %mypath:~0,-1%
cd ..
call nuget.pack.bat Ticketmaster.Core