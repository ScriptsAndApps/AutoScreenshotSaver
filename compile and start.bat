C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /out:AutoScreenShotSaver.exe /target:winexe program.cs form1.cs Form1.Designer.cs AssemblyInfo.cs -resource:Form1.resx

IF ERRORLEVEL 1 (
	pause
	exit
)

start AutoScreenShotSaver.exe
exit
