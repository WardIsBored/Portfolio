@echo off
title Tb0n31's Account Management Tool
setlocal enabledelayedexpansion

:: Password protection
set /p pass="Enter Password Provided To Access The App: "
if /I not "%pass%"=="tb0n31" exit

echo Welcome, %USERNAME%
timeout /t 2 >nul
cls

:menu
cls
color 0A
echo.
echo ======================= User Management Menu ========================
echo.
echo 1) List All Users
echo 2) Create New User
echo 3) Change User Password
echo 4) Delete User
echo 5) Exit
echo.
set /p input="Select an option: "

if "%input%"=="1" (
    cls
    echo --- Users on this PC ---
    net user
    echo.
    pause
    goto menu
)

if "%input%"=="2" (
    cls
    set /p user="Enter new username: "
    set /p password="Enter password: "
    net user "%user%" "%password%" /add
    echo User created.
    pause
    goto menu
)

if "%input%"=="3" (
    cls
    set /p user="Enter username to change password: "
    set /p password="Enter new password: "
    net user "%user%" "%password%"
    echo Password changed.
    pause
    goto menu
)

if "%input%"=="4" (
    goto delete_user
)

if "%input%"=="5" (
    exit
)

echo Invalid option.
pause
goto menu

:delete_user
cls
echo WARNING: You are about to delete a user account.
echo This action is irreversible.
echo.
set /p user="Enter username to delete: "

:: Check for empty input
if not defined user (
    echo No username entered.
    pause
    goto menu
)

:: Prevent deleting self
if /I "%user%"=="%USERNAME%" (
    echo You cannot delete your own account.
    pause
    goto menu
)

:: Check if user exists
net user "%user%" >nul 2>&1
if errorlevel 1 (
    echo User "%user%" does not exist.
    pause
    goto menu
)

:: Confirm
set /p confirm="Are you sure you want to delete '%user%'? (Y/N): "
if /I not "%confirm%"=="Y" (
    echo Deletion cancelled.
    pause
    goto menu
)

:: Delete the user
net user "%user%" /delete
echo User "%user%" deleted successfully.
pause
goto menu
tb0n31