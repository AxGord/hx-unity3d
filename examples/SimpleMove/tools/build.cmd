@echo off
chcp 1251>Nul
del /s "bin\Assets\src\*.*" /q >NuL
neko tools\fdgcl.n SimpleMove.hxproj "-cs bin\Assets -cmd tools\after.cmd"