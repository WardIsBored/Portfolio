@echo off
setlocal
cd %~dp0



:Interpret
cls
echo Open any lua file in the current directory.
set /p filename="Enter the name of the Lua file (without .lua): "
if "%filename%"=="" (
    echo No file name provided. Exiting.
    exit /b 1
)
start cmd /K C:\Users\t_b0n\scoop\shims\lua.exe %filename%.lua

if %errorlevel% neq 0 (
    echo An error occurred while executing the script.
    exit /b %errorlevel%
)
echo "%filename%" executed successfully.
goto Interpret

