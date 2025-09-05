@echo off
echo encoder



:ask
set /p "one=Enter a single character or number: "
if "%one%"=="" goto :eof

rem Take just the first character
set "chr=%one:~0,1%"

rem Letters A–Z
if /I "%chr%"=="A" echo C4^@
if /I "%chr%"=="B" echo C2^&
if /I "%chr%"=="C" echo C3^(
if /I "%chr%"=="D" echo C4^)
if /I "%chr%"=="E" echo C5^*
if /I "%chr%"=="F" echo C6^+
if /I "%chr%"=="G" echo C7^^
if /I "%chr%"=="H" echo C8^-
if /I "%chr%"=="I" echo C9^_
if /I "%chr%"=="J" echo C0^=
if /I "%chr%"=="K" echo C1^[
if /I "%chr%"=="L" echo C2^]
if /I "%chr%"=="M" echo C3^{
if /I "%chr%"=="N" echo C4^}
if /I "%chr%"=="O" echo C5^|
if /I "%chr%"=="P" echo C6^/
if /I "%chr%"=="Q" echo C7^?
if /I "%chr%"=="R" echo C8^!
if /I "%chr%"=="S" echo C9^%
if /I "%chr%"=="T" echo D0^$
if /I "%chr%"=="U" echo D1^^

rem Numeric 0–9
if "%chr%"=="0" echo N0⁰
if "%chr%"=="1" echo N1¹
if "%chr%"=="2" echo N2²
if "%chr%"=="3" echo N3³
if "%chr%"=="4" echo N4⁴
if "%chr%"=="5" echo N5⁵
if "%chr%"=="6" echo N6⁶
if "%chr%"=="7" echo N7⁷
if "%chr%"=="8" echo N8⁸
if "%chr%"=="9" echo N9⁹

goto ask

:EOF

