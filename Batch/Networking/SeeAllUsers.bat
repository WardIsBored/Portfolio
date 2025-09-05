@echo off

:loop
cls
arp -a
timeout /t 1
goto loop
