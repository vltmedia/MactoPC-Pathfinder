Public Class Win32

#Region "Methods And Functions Declaration"


    Public Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Int32
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Int32) As Int32




#End Region



End Class
