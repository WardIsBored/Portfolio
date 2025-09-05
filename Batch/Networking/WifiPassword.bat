@echo off
title Show Wi-Fi Password by-tb0n_31
:start
cls
set /p Wifi=[+] Enter the Wi-Fi Name:
echo.
netsh wlan show profile name="%Wifi%" key=clear | findstr /C:"Key Content"
echo.
pause
goto start