@echo off
title Eclipsus
chcp 65001 >nul

:start
cls
call :banner
call :menu

pause
exit /b

:banner
setlocal enabledelayedexpansion
set ESC=

echo.
echo !ESC![38;2;255;105;180m                  ███████╗ ██████╗██╗     ██╗██████╗ ███████╗██╗   ██╗███████╗
echo !ESC![38;2;230;90;170m                  ██╔════╝██╔════╝██║     ██║██╔══██╗██╔════╝██║   ██║██╔════╝
echo !ESC![38;2;200;70;160m                  █████╗  ██║     ██║     ██║██████╔╝███████╗██║   ██║███████╗
echo !ESC![38;2;170;50;140m                  ██╔══╝  ██║     ██║     ██║██╔═══╝ ╚════██║██║   ██║╚════██║
echo !ESC![38;2;150;40;130m                  ███████╗╚██████╗███████╗██║██║     ███████║╚██████╔╝███████║
echo !ESC![38;2;128;0;128m                  ╚══════╝ ╚═════╝╚══════╝╚═╝╚═╝     ╚══════╝ ╚═════╝ ╚══════╝
echo !ESC![0m
endlocal
goto :eof

:menu
setlocal enabledelayedexpansion
set ESC=

echo.
echo !ESC![38;2;128;0;128m  ----------------------------------------------------Menu------------------------------------------------
echo !ESC![38;2;128;0;128m                                                1) Sniff IPs
echo !ESC![38;2;150;40;130m                                                2) Geolocator
echo !ESC![38;2;170;50;140m                                                3) DNS Dump
echo !ESC![38;2;200;70;160m                                                4) Port Scanner
echo !ESC![38;2;200;70;160m                                                5) What Is My Public And Private Ip
echo !ESC![38;2;255;105;180m                                                6) Exit
echo !ESC![38;2;255;105;180m
echo !ESC![0m
endlocal
echo.
set /p input="Choose one: "

if "%input%"=="1" (
goto sniffer
)

if "%input%"=="2" (
goto geolocate
)

if "%input%"=="3" (
goto dnsdump
)

if "%input%"=="4" (
goto portscan
)

if "%input%"=="5" (
goto myip
)

if "%input%"=="6" exit


:sniffer
cls
setlocal enabledelayedexpansion
set ESC=
echo.
echo !ESC![38;2;255;105;180m                  ██╗██████╗     ███████╗███╗   ██╗██╗███████╗███████╗███████╗██████╗     ██╗   ██╗ ██╗
echo !ESC![38;2;230;90;170m                  ██║██╔══██╗    ██╔════╝████╗  ██║██║██╔════╝██╔════╝██╔════╝██╔══██╗    ██║   ██║███║
echo !ESC![38;2;200;70;160m                  ██║██████╔╝    ███████╗██╔██╗ ██║██║█████╗  █████╗  █████╗  ██████╔╝    ██║   ██║╚██║
echo !ESC![38;2;170;50;140m                  ██║██╔═══╝     ╚════██║██║╚██╗██║██║██╔══╝  ██╔══╝  ██╔══╝  ██╔══██╗    ╚██╗ ██╔╝ ██║
echo !ESC![38;2;150;40;130m                  ██║██║         ███████║██║ ╚████║██║██║     ██║     ███████╗██║  ██║     ╚████╔╝  ██║
echo !ESC![38;2;128;0;128m                  ╚═╝╚═╝         ╚══════╝╚═╝  ╚═══╝╚═╝╚═╝     ╚═╝     ╚══════╝╚═╝  ╚═╝      ╚═══╝   ╚═╝
echo !ESC![0m                                                                                     
echo.
echo.
echo !ESC![38;2;128;0;128m  ----------------------------------------------------Menu------------------------------------------------
echo !ESC![38;2;128;0;128m                                                1) Arp -a (users)
echo !ESC![38;2;150;40;130m                                                2) Netstat (packages)
echo !ESC![38;2;150;40;130m                                                3) Running Network Processes
echo !ESC![38;2;170;50;140m                                                4) Exit
echo !ESC![38;2;255;105;180m
echo !ESC![0m
endlocal
echo.
set /p input="Choose one: "
if "%input%"=="1" (
:loop
cls
arp -a
timeout /t 1 >nul
goto loop
)
if "%input%"=="2" (
cls
netstat
)
if "%input%"=="3" (
goto netprocs
)
if "%input%"=="4" (
cls
goto start
)

goto start

:dnsdump
cls
setlocal enabledelayedexpansion
set ESC=
echo.
echo !ESC![38;2;255;105;180m                  ██████╗ ███╗   ██╗███████╗    ██████╗ ██╗   ██╗███╗   ███╗██████╗ 
echo !ESC![38;2;230;90;170m                  ██╔══██╗████╗  ██║██╔════╝    ██╔══██╗██║   ██║████╗ ████║██╔══██╗
echo !ESC![38;2;200;70;160m                  ██║  ██║██╔██╗ ██║███████╗    ██║  ██║██║   ██║██╔████╔██║██████╔╝
echo !ESC![38;2;170;50;140m                  ██║  ██║██║╚██╗██║╚════██║    ██║  ██║██║   ██║██║╚██╔╝██║██╔═══╝ 
echo !ESC![38;2;150;40;130m                  ██████╔╝██║ ╚████║███████║    ██████╔╝╚██████╔╝██║ ╚═╝ ██║██║     
echo !ESC![38;2;128;0;128m                  ╚═════╝ ╚═╝  ╚═══╝╚══════╝    ╚═════╝  ╚═════╝ ╚═╝     ╚═╝╚═╝  
endlocal   
echo.
echo.                                                         
echo                  put a domain name to see ip or reverse it to ip to see domain name (TIP:put "back" to exit)
echo.
set /p input="input an ip or domain name.Ex 8.8.8.8 to dns.google.com and dns.google.com to 8.8.8.8: "
if "%input%"=="back" (
goto start
)
nslookup %input%
pause
goto dnsdump

:geolocate
cls
setlocal enabledelayedexpansion
set ESC=
echo.
echo !ESC![38;2;255;105;180m                   ██████╗ ███████╗ ██████╗ ██╗      ██████╗  ██████╗ █████╗ ████████╗ ██████╗ ██████╗     
echo !ESC![38;2;230;90;170m                  ██╔════╝ ██╔════╝██╔═══██╗██║     ██╔═══██╗██╔════╝██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗    
echo !ESC![38;2;200;70;160m                  ██║  ███╗█████╗  ██║   ██║██║     ██║   ██║██║     ███████║   ██║   ██║   ██║██████╔╝    
echo !ESC![38;2;170;50;140m                  ██║   ██║██╔══╝  ██║   ██║██║     ██║   ██║██║     ██╔══██║   ██║   ██║   ██║██╔══██╗    
echo !ESC![38;2;150;40;130m                  ╚██████╔╝███████╗╚██████╔╝███████╗╚██████╔╝╚██████╗██║  ██║   ██║   ╚██████╔╝██║  ██║    
echo !ESC![38;2;128;0;128m                   ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝ ╚═════╝  ╚═════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝  
endlocal
cd C:\Users\"%username%"\Downloads\"Eclipsus Batch"\
echo                   This Will Open Up A New Process Would You Like To Continue?(Y/N)
set /p input=%BS%
if "%input%"=="N" (
goto start
)
if "%input%"=="Y" (
cls
start "" "Geolocate\GeoLocator.exe"
cls
goto start

)
if "%input%"=="n" (
goto start
)
if "%input%"=="y" (
cls
start "" "Geolocate\GeoLocator.exe"
goto start
cls
)

:myip
cls
setlocal enabledelayedexpansion
set ESC=
echo.
echo !ESC![38;2;255;105;180m                 ███╗   ███╗██╗   ██╗    ██╗██████╗      █████╗ ██████╗ ██████╗ ███████╗███████╗███████╗  
echo !ESC![38;2;230;90;170m                  ████╗ ████║╚██╗ ██╔╝    ██║██╔══██╗    ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝
echo !ESC![38;2;200;70;160m                  ██╔████╔██║ ╚████╔╝     ██║██████╔╝    ███████║██║  ██║██████╔╝█████╗  ███████╗███████╗
echo !ESC![38;2;170;50;140m                  ██║╚██╔╝██║  ╚██╔╝      ██║██╔═══╝     ██╔══██║██║  ██║██╔══██╗██╔══╝  ╚════██║╚════██║
echo !ESC![38;2;150;40;130m                  ██║ ╚═╝ ██║   ██║       ██║██║         ██║  ██║██████╔╝██║  ██║███████╗███████║███████║
echo !ESC![38;2;128;0;128m                   ╚═╝     ╚═╝   ╚═╝       ╚═╝╚═╝         ╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝
endlocal

::code type shiiiiiii
echo Retrieving public IP address...
timeout /t 1 >nul
echo Curling...
timeout /t 1 >nul
echo Fetching private ip...
timeout /t 1 >nulActivating
cls
echo Public Ip:
curl -s https://api.ipify.org
echo.
echo Private Ip:
echo.
ipconfig | findstr "IPv4 Address"
echo.
pause
goto start

:portscan
cls
setlocal enabledelayedexpansion
set ESC=
echo.
echo !ESC![38;2;255;105;180m           ██████╗  ██████╗ ██████╗ ████████╗    ███████╗ ██████╗ █████╗ ███╗   ██╗███╗   ██╗███████╗██████╗    
echo !ESC![38;2;230;90;170m            ██╔══██╗██╔═══██╗██╔══██╗╚══██╔══╝    ██╔════╝██╔════╝██╔══██╗████╗  ██║████╗  ██║██╔════╝██╔══██╗
echo !ESC![38;2;200;70;160m            ██████╔╝██║   ██║██████╔╝   ██║       ███████╗██║     ███████║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝    
echo !ESC![38;2;170;50;140m            ██╔═══╝ ██║   ██║██╔══██╗   ██║       ╚════██║██║     ██╔══██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗   
echo !ESC![38;2;150;40;130m            ██║     ╚██████╔╝██║  ██║   ██║       ███████║╚██████╗██║  ██║██║ ╚████║██║ ╚████║███████╗██║  ██║     
echo !ESC![38;2;128;0;128m             ╚═╝      ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝      
endlocal
                                                                                                                 
set /p target="Enter IP or domain to scan: "
set /p ports="Enter ports (comma separated, e.g. 80,443,22): "

echo.
echo Scanning %target% for ports: %ports%
echo.

for %%p in (%ports%) do (
    powershell -NoProfile -ExecutionPolicy Bypass -Command "try { $tcp = New-Object System.Net.Sockets.TcpClient; $tcp.Connect('%target%', %%p); Write-Host 'Port %%p is OPEN'; $tcp.Close() } catch { Write-Host 'Port %%p is CLOSED' }"
)

echo.
pause
goto start

:netprocs
cls
echo Active network-connected processes:
for /f "tokens=5" %%a in ('netstat -ano ^| findstr ESTABLISHED') do (
    tasklist /FI "PID eq %%a" | findstr /v "Image"
)
pause
goto start