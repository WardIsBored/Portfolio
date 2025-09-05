@echo off
:setlocal
cd "%~dp0"
:start
cls
echo type a song name to search for:
set /p songname="Song Name: "
if "%songname%"=="" (
    echo No song name provided. Exiting...
    exit /b
)
echo Searching for "%songname%"...
cd /d "Songs"

if exist "%songname%.mp3" (
    echo Found "%songname%.mp3". Playing...
    start "" /min "%songname%.mp3"
) else (
    echo "%songname%" not found in the Songs directory.
)
pause
echo Returning to main menu...
timeout /t 2 /nobreak >nul
cd ..
echo.
goto start