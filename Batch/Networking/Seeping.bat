@echo off
:set local
color A
title made by tb0n31

:start
cls
echo See ping from a website
set /p input="Insert a website name: "
nslookup www.%input%.com > nul 2>&1

if %errorlevel% neq 0 (
    echo Error: Invalid website name or no internet connection.
    pause
    exit /b
)

if %errorlevel% equ 0 (
    echo Website found: www.%input%.com
    ping -n 1 "www.%input%.com" | findstr "time="
    echo.
    pause
)

goto start