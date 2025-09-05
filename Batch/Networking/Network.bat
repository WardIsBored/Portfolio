
@echo off
color A
title Network Stats-by t_b0n31
echo Loading Network Info


:loop
for /f "tokens=4 delims==" %%a in ('ping -n 3 8.8.8.8 ^| find "Average"') do set ping=%%a
for /f "tokens=2 delims=:" %%a in ('netsh wlan show interface ^| find "SSID" ^| findstr /v "BSSID"') do set ssid=%%a
for /f "tokens=2 delims=:" %%a in ('netsh wlan show interface ^| find "Description"') do set desc=%%a
for /f "tokens=2 delims=:" %%a in ('netsh wlan show interface ^| find "State"') do set state=%%a
for /f "tokens=2 delims=:" %%a in ('netsh wlan show interface ^| find "Signal"') do set signal=%%a

cls
echo   Network:
echo ------------
echo Name: %ssid%
echo Adapter: %desc%
echo State: %state%
echo Signal: %signal%
echo.
echo   Speed:
echo ------------
echo Ping: %ping%
goto loop