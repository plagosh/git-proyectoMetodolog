@echo off
echo open 144.217.78.10 21 >> (FTP.txt)
echo user unab-proyecto@escuelaministrozenteno.cl -unab2019- >> FTP.txt
echo bin >> FTP_IN.txt
echo prompt >> FTP_IN.txt
echo cd Respaldos >> FTP_IN.txt
echo put “respaldoftp”.txt >> FTP_IN.txt
echo bye >> FTP_IN.txt
ftp -n -s:FTP_IN.txt>> FTP_OUT.txt
pause
exit