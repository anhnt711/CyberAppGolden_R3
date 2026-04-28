chcp 65001
timeout /t 5
xcopy /y /e /v "D:\02.CyberSoft_9.0\24.BUS Liên Ninh\CyberAppGolden_R3\UpdateFile" "D:\02.CyberSoft_9.0\24.BUS Liên Ninh\CyberAppGolden_R3"
 start "" "D:\02.CyberSoft_9.0\24.BUS Liên Ninh\CyberAppGolden_R3\Cyber.MainMenu.exe" 
del  /S /Q "D:\02.CyberSoft_9.0\24.BUS Liên Ninh\CyberAppGolden_R3\UpdateFile" 
exit