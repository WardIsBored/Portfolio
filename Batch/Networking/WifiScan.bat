@echo off
color A
title Wifi Scan - made by t_b0n311
:loop
cls
netsh wlan show networks
timeout /t 10 > nul
goto loop