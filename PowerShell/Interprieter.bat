@echo off
:setlocal
cd /d "%~dp0"
color 01
:start
cls
echo.
echo Please put in a ps1 file to run.
echo.
set /p psfile=Enter the name of the PowerShell script (without .ps1):
if "%psfile%"=="" set psfile=PSCommands.ps1
PowerShell -ExecutionPolicy Bypass -File "%psfile%.ps1"
if %errorlevel% neq 0 (
    echo An error occurred while executing the PowerShell script.
    exit /b %errorlevel%
)
pause
goto start