Windows Registry Editor Version 5.00
; @Echo off
; cls
; regedit.exe /s "%~f0"
; timeout \t -1
; exit

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\system]
"EnableLinkedConnections"=dword:00000001
