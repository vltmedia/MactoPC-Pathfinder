Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1
    <DllImport("user32.dll", EntryPoint:="GetWindowThreadProcessId")>
    Private Shared Function GetWindowThreadProcessId(<InAttribute()> ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetForegroundWindow")> Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowTextW")>
    Private Shared Function GetWindowTextW(<InAttribute()> ByVal hWnd As IntPtr, <OutAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpString As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function

    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    Private Declare Function SetFocus Lib "user32.dll" (ByVal hwnd As Int32) As Int32


    'Declare Auto Function MBox Lib "user32.dll" Alias "MessageBox" (
    'ByVal hWnd As Integer,
    'ByVal txt As String,
    'ByVal caption As String,
    'ByVal Typ As Integer) As Integer

    Dim Copiedpath = "Path"

    Dim Screencapturekey = "V"
    'Dim Clipboardcopy = "Paste"


    Private Sub GetForgroundWindowInfo()

        'If Not hWnd.Equals(IntPtr.Zero) Then

        '    Dim lgth As Integer = GetWindowTextLength(hWnd)
        '    Dim wTitle As New System.Text.StringBuilder("", lgth + 1)
        '    If lgth > 0 Then
        '        GetWindowTextW(hWnd, wTitle, wTitle.Capacity)
        '    End If

        '    Dim wProcID As Integer = Nothing
        '    GetWindowThreadProcessId(hWnd, wProcID)

        '    Dim Proc As Process = Process.GetProcessById(wProcID)
        '    Dim wFileName As String = ""
        '    Try
        '        wFileName = Proc.MainModule.FileName
        '    Catch ex As Exception
        '        wFileName = ""
        '    End Try

        '    ListBox1.Items.Add("Window Handle - " & hWnd.ToString)
        '    ListBox1.Items.Add("Window Title - " & wTitle.ToString)
        '    ListBox1.Items.Add("Process Id - " & wProcID.ToString)
        '    ListBox1.Items.Add("Main Module FileName - " & wFileName.ToString)
        'End If
    End Sub


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = Hotkey.WM_HOTKEY Then
            Hotkey.handleHotKeyEvent(m.WParam)
        End If
        MyBase.WndProc(m)
    End Sub 'System wide hotkey event handling


    Dim Mainpath As String = ""

    Private Sub BtnMactoPC_Click(sender As Object, e As EventArgs) Handles BtnMactoPC.Click
        Dim Pathspasted = Txtenter.Text
        Dim Windowspath = Pathspasted.Replace("afp://NY01-MP02/Storage NY", "Y:\Storage NY")
        Windowspath = Windowspath.Replace("/", "\")
        'k

        TxtA.Text = Windowspath
        LblA.Text = Windowspath
        LinkA.Text = Windowspath
        Mainpath = Windowspath

    End Sub

    Public Shared Sub screenCapture()
        Dim Windowtit = "Window"
        Dim hWnd As IntPtr = GetForegroundWindow()
        'hwnd = FindWindow(Nothing, "Calculator")
        If Not hWnd.Equals(IntPtr.Zero) Then

            Dim lgth As Integer = GetWindowTextLength(hWnd)
            Dim wTitle As New System.Text.StringBuilder("", lgth + 1)
            If lgth > 0 Then
                GetWindowTextW(hWnd, wTitle, wTitle.Capacity)
            End If

            Dim wProcID As Integer = Nothing
            GetWindowThreadProcessId(hWnd, wProcID)

            Dim Proc As Process = Process.GetProcessById(wProcID)
            Dim wFileName As String = ""
            Try
                wFileName = Proc.MainModule.FileName
            Catch ex As Exception
                wFileName = ""
            End Try

            Windowtit = wTitle.ToString
            If Windowtit.Contains("Chrome") Or Windowtit.Contains("Slack") Then
                hWnd = FindWindow(Nothing, Windowtit)
                Dim didSetForeground As Boolean = SetForegroundWindow(hWnd)
                If Not didSetForeground Then
                    MessageBox.Show("Failed to set the foreground window")
                End If
                'SetForegroundWindow(hWnd)
                SetFocus(hWnd)
                Thread.Sleep(200)
                Console.WriteLine(hWnd)
                Console.WriteLine(Windowtit)
                My.Computer.Keyboard.SendKeys("^c", True)
                'My.Computer.Clipboard.SetText("This is a test string.")
                SendKeys.Send("^c")
                Thread.Sleep(200)
                Dim Clipboardcopy = Clipboard.GetText()
                'My.Computer.Keyboard.SendKeys("111", True)
                'MessageBox.Show(Clipboardcopy)
                Console.WriteLine(Clipboardcopy)

                Dim Pathspasted = Clipboardcopy
                Dim Windowspath = Pathspasted.Replace("afp://NY01-MP02/Storage NY", "Y:\Storage NY")
                Windowspath = Windowspath.Replace("/", "\")
                'k
                Thread.Sleep(200)
                Form1.TxtA.Text = Windowspath
                Form1.LblA.Text = Windowspath
                Form1.LinkA.Text = Windowspath
                Form1.Mainpath = Windowspath
                If Directory.Exists(Windowspath) Then
                    'MessageBox.Show(Windowspath)

                    Dim cd As String = "cd /d " & Windowspath


                    Process.Start("cmd.exe")


                    Threading.Thread.Sleep(100)
                    SendKeys.SendWait(cd)
                    Threading.Thread.Sleep(10)
                    SendKeys.SendWait("{ENTER}")
                    Threading.Thread.Sleep(10)
                    SendKeys.SendWait("start .")
                    Threading.Thread.Sleep(10)
                    SendKeys.SendWait("{ENTER}")
                    SendKeys.SendWait("exit")
                    Threading.Thread.Sleep(10)
                    SendKeys.SendWait("{ENTER}")

                    'Process.Start(Windowspath)
                Else
                    Console.WriteLine("BAD" & Form1.LinkA.Text)

                End If

            End If

            End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Hotkey.registerHotkey(Me, Screencapturekey, Hotkey.KeyModifier.Alt)
        Screencapturekey = My.Settings.Screencapturekey


    End Sub

    Public Sub closingform1() Handles Me.FormClosing
        My.Settings.Screencapturekey = Screencapturekey

    End Sub



    Public Shared Sub handleHotKeyEvent(ByVal hotkeyID As IntPtr)
        Select Case hotkeyID
            Case 1
                screenCapture()
            Case 2
                MsgBox("2")
            Case 3
                MsgBox("3")
        End Select
    End Sub

    Private Sub BtnPCtoMac_Click(sender As Object, e As EventArgs) Handles BtnPCtoMac.Click
        Dim Pathspasted = TxtA.Text
        Dim Macpath = Pathspasted.Replace("\", "/")

        Console.WriteLine(TxtA.Text)
        Console.WriteLine(LblA.Text)
        Console.WriteLine(LinkA.Text)
        Console.WriteLine(Macpath)
        Console.WriteLine(LblA.Text)
        Console.WriteLine(LinkA.Text)


        TxtA.Text = Macpath
        LblA.Text = Macpath
        LinkA.Text = Macpath
        Mainpath = Macpath


    End Sub

    Private Sub LinkA_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkA.LinkClicked

        Process.Start(Mainpath)

    End Sub
End Class
