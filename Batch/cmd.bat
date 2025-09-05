@echo off
title Tb0n31's CMD Shell
setlocal enabledelayedexpansion


:: Startup banner
echo Microsoft Windows [Version 10.0.26100.4652]
echo (c) Microsoft Corporation. All rights reserved.
echo.
echo This is a modded CMD version by Tb0n31
echo Type "exit" to quit.
echo.

:: Main command loop
:cmdline
set /p input="%cd%> "
if /i "!input!"=="exit" exit /b
if "!input!"=="" goto cmdline

call :runcmd !input!
goto cmdline

:: Dispatcher
:runcmd
set "cmd=%~1"
set "args=%*"
set "args=%args:* =%"

if /i "!cmd!"=="say" goto :say
if /i "!cmd!"=="clear" goto :clear
if /i "!cmd!"=="hello" goto :hello
if /i "!cmd!"=="rickroll" goto :rickroll
if /i "!cmd!"=="multitool" goto :multitool

call %*
goto :eof

:say
echo !args!
goto :eof

:clear
cls
goto :eof

:hello
echo Hello from a custom function!
goto :eof

:rickroll

start "" msedge "https://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1"
color 2 & curl ascii.live/rick
goto :eof


:multitool
cd /d "C:\Users\t_b0n\Documents\Scripts\Multitool"
start "" multitool
goto :eof
