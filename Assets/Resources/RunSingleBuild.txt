start "Master" %~dp0SingleBuild.exe node-config-master.xml
timeout /t 8 /nobreak
start "Slave1" %~dp0SingleBuild.exe node-config-slave1.xml
timeout /t 8 /nobreak
start "Slave2" %~dp0SingleBuild.exe node-config-slave2.xml