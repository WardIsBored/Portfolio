@echo off
setlocal
cd %~dp0



:Interpret
cls
echo Open any python file in the current directory.
set /p filename="Enter the name of the Python file (without .py): "
if "%filename%"=="" (
    echo No file name provided. Exiting.
    exit /b 1
)
start cmd /K python %filename%.py
if %errorlevel% neq 0 (
    echo An error occurred while executing the script.
    exit /b %errorlevel%
)
echo "%filename%" executed successfully.
goto Interpret

