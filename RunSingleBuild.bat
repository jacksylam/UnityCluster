start "Master" %~dp0testbuild.exe node-config-master.xml
timeout /t 8 /nobreak
start "Slave1" %~dp0testbuild.exe node-config-slave1.xml
timeout /t 8 /nobreak
start "Slave2" %~dp0testbuild.exe node-config-slave2.xml