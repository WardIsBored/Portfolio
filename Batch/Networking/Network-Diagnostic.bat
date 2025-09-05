@echo off
cd C:\Users\t_b0n\Documents\Scripts\Misc\
echo === NETWORK INFO %date% %time% === > net-report.txt
ipconfig /all >> net-report.txt
netstat -an >> net-report.txt
start net-report.txt