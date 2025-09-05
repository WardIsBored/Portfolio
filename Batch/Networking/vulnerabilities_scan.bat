@echo off
setlocal enabledelayedexpansion
color A
title Vulnerabilities Scan by tb0n31
cd /d "%~dp0"

:: Prepare scans folder (clear if exists)
if exist scans (
    del /q scans\* >nul 2>&1
    mkdir scans >nul 2>&1
) else (
    mkdir scans >nul 2>&1
)

:: Check for admin rights
net session >nul 2>&1
if errorlevel 1 (
    echo Please run this script as Administrator!
    pause
    exit /b
)

:: Get the first IP address from arp -a output (skip first 3 lines)
set "originalServer="
for /f "skip=3 tokens=1" %%a in ('arp -a') do (
    echo %%a | findstr "." >nul
    if !errorlevel! == 0 (
        set "originalServer=%%a"
        goto :confirm
    )
)

echo No IP addresses found in ARP table. Exiting.
pause
exit /b

:confirm
echo Are you sure you want to scan the server: !originalServer! ?
set /p confirm="Type 'yes' to continue: "

if /i not "!confirm!"=="yes" (
    echo Scan cancelled.
    pause
    exit /b
)

echo Starting vulnerability scans on all detected IPs in ARP table...
echo.

:: Scan all IPs in ARP table
for /f "skip=3 tokens=1" %%a in ('arp -a') do (
    echo %%a | findstr "." >nul
    if !errorlevel! == 0 (
        set "server=%%a"
        echo Scanning !server! ...
        nmap -Pn -p 80,443,21,22,23,3389,8080,8443 !server! > "scans\scan_!server!.txt" 2>&1
        if errorlevel 1 (
            echo Error occurred scanning !server!.
        ) else (
            echo Scan of !server! completed.
        )
        echo.
    )
)

echo All scans complete. Results saved in the "scans" folder.
pause
