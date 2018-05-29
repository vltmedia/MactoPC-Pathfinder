Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Text

Public Class PathTracer

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
        Dim Pathh = ""

        If Pathspasted.Contains(MarketingMac1) Or Pathspasted.Contains(MarketingMac2) Then


            Dim Windowspath = Pathspasted.Replace(MarketingMac1, Marketingc)
            Windowspath = Windowspath.Replace(MarketingMac2, Marketingc)
            'Continue on
            Windowspath = Windowspath.Replace("/", "\")
            Thread.Sleep(200)
            TxtA.Text = Windowspath
            LblA.Text = Windowspath
            LinkA.Text = Windowspath
            Mainpath = Windowspath
            If Directory.Exists(Windowspath) Then
                'MessageBox.Show(Windowspath)

                Dim cd As String = "cd /d " & Windowspath


                Process.Start("cmd.exe")


                Threading.Thread.Sleep(Delay)
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
                Pathh = Windowspath
                'Process.Start(Windowspath)
            Else
                Console.WriteLine("BAD" & LinkA.Text)

            End If



        ElseIf Pathspasted.Contains(StorageNyMac1) Or Pathspasted.Contains(StorageNyMac2) Then


            Dim Windowspath = Pathspasted.Replace(StorageNyMac1, StorageNyc)
            Windowspath = Windowspath.Replace(StorageNyMac2, StorageNyc)
            'Continue on
            Windowspath = Windowspath.Replace("/", "\")
            Thread.Sleep(200)
            TxtA.Text = Windowspath
            LblA.Text = Windowspath
            LinkA.Text = Windowspath
            Mainpath = Windowspath
            Console.WriteLine(Windowspath)
            If Directory.Exists(Windowspath) Then
                'MessageBox.Show(Windowspath)

                Dim cd As String = "cd /d " & Windowspath

                Console.WriteLine(Windowspath)


                Process.Start("cmd.exe")


                Threading.Thread.Sleep(Delay)
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
                Pathh = Windowspath
                'Process.Start(Windowspath)
            Else
                Console.WriteLine("BAD" & LinkA.Text)

            End If



            'User Shares
        Else
            If Pathspasted.Contains(UsersharesMac1) Or Pathspasted.Contains(UsersharesMac2) Then


                Dim Windowspath = Pathspasted.Replace(UsersharesMac1, Usersharesc)
                Windowspath = Windowspath.Replace(UsersharesMac2, Usersharesc)
                'Continue on
                Windowspath = Windowspath.Replace("/", "\")
                Thread.Sleep(200)
                TxtA.Text = Windowspath
                LblA.Text = Windowspath
                LinkA.Text = Windowspath
                Mainpath = Windowspath
                Console.WriteLine(Windowspath)
                If Directory.Exists(Windowspath) Then
                    'MessageBox.Show(Windowspath)

                    Dim cd As String = "cd /d " & Windowspath

                    Console.WriteLine(Windowspath)


                    Process.Start("cmd.exe")


                    Threading.Thread.Sleep(Delay)
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
                    Pathh = Windowspath
                    'Process.Start(Windowspath)
                Else
                    Pathh = Windowspath

                End If

                'Software
            Else
                If Pathspasted.Contains(SoftwareMac1) Or Pathspasted.Contains(SoftwareMac2) Then


                    Dim Windowspath = Pathspasted.Replace(SoftwareMac1, Softwarec)
                    Windowspath = Windowspath.Replace(SoftwareMac2, StorageNyc)
                    'Continue on
                    Windowspath = Windowspath.Replace("/", "\")
                    Thread.Sleep(200)
                    TxtA.Text = Windowspath
                    LblA.Text = Windowspath
                    LinkA.Text = Windowspath
                    Mainpath = Windowspath
                    Console.WriteLine(Windowspath)
                    If Directory.Exists(Windowspath) Then
                        'MessageBox.Show(Windowspath)

                        Dim cd As String = "cd /d " & Windowspath

                        Console.WriteLine(Windowspath)


                        Process.Start("cmd.exe")


                        Threading.Thread.Sleep(Delay)
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
                        Pathh = Windowspath
                        'Process.Start(Windowspath)
                    Else
                        Pathh = Windowspath

                    End If

                    'Multimedia
                Else
                    If Pathspasted.Contains(MultimediaMac1) Or Pathspasted.Contains(MultimediaMac2) Then


                        Dim Windowspath = Pathspasted.Replace(MultimediaMac1, Multimediac)
                        Windowspath = Windowspath.Replace(MultimediaMac2, Multimediac)
                        'Continue on
                        Windowspath = Windowspath.Replace("/", "\")
                        Thread.Sleep(200)
                        TxtA.Text = Windowspath
                        LblA.Text = Windowspath
                        LinkA.Text = Windowspath
                        Mainpath = Windowspath
                        Console.WriteLine(Windowspath)
                        If Directory.Exists(Windowspath) Then
                            'MessageBox.Show(Windowspath)

                            Dim cd As String = "cd /d " & Windowspath

                            Console.WriteLine(Windowspath)


                            Process.Start("cmd.exe")


                            Threading.Thread.Sleep(Delay)
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
                            Pathh = Windowspath
                            'Process.Start(Windowspath)
                        Else
                            Pathh = Windowspath

                        End If

                    Else

                        'JKRAssetBank

                        If Pathspasted.Contains(JKRAssetBankMac1) Or Pathspasted.Contains(JKRAssetBankMac2) Then


                            Dim Windowspath = Pathspasted.Replace(JKRAssetBankMac1, JKRAssetBankc)
                            Windowspath = Windowspath.Replace(JKRAssetBankMac2, JKRAssetBankc)
                            'Continue on
                            Windowspath = Windowspath.Replace("/", "\")
                            Thread.Sleep(200)
                            TxtA.Text = Windowspath
                            LblA.Text = Windowspath
                            LinkA.Text = Windowspath
                            Mainpath = Windowspath
                            Console.WriteLine(Windowspath)
                            If Directory.Exists(Windowspath) Then
                                'MessageBox.Show(Windowspath)

                                Dim cd As String = "cd /d " & Windowspath

                                Console.WriteLine(Windowspath)


                                Process.Start("cmd.exe")


                                Threading.Thread.Sleep(Delay)
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
                                Pathh = Windowspath
                                'Process.Start(Windowspath)
                            Else
                                Pathh = Windowspath

                            End If

                            'ArchiveProjects2016
                        Else
                            If Pathspasted.Contains(ArchiveProjects2016Mac1) Or Pathspasted.Contains(ArchiveProjects2016Mac2) Then


                                Dim Windowspath = Pathspasted.Replace(ArchiveProjects2016Mac1, ArchiveProjects2016c)
                                Windowspath = Windowspath.Replace(ArchiveProjects2016Mac2, ArchiveProjects2016c)
                                'Continue on
                                Windowspath = Windowspath.Replace("/", "\")
                                Thread.Sleep(200)
                                TxtA.Text = Windowspath
                                LblA.Text = Windowspath
                                LinkA.Text = Windowspath
                                Mainpath = Windowspath
                                Console.WriteLine(Windowspath)
                                Pathh = Windowspath
                                TxtA.Text = Pathh
                                LblA.Text = Pathh
                                LinkA.Text = Pathh
                                Mainpath = Pathh
                                If Directory.Exists(Windowspath) Then
                                    'MessageBox.Show(Windowspath)

                                    Dim cd As String = "cd /d " & Windowspath

                                    Console.WriteLine(Windowspath)


                                    Process.Start("cmd.exe")


                                    Threading.Thread.Sleep(Delay)
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
                                    Pathh = Windowspath
                                    TxtA.Text = Pathh
                                    LblA.Text = Pathh
                                    LinkA.Text = Pathh
                                    Mainpath = Pathh
                                    'Process.Start(Windowspath)
                                Else
                                    Pathh = Windowspath

                                End If

                                'ArchiveProjects2017
                            Else
                                If Pathspasted.Contains(ArchiveProjects2017Mac1) Or Pathspasted.Contains(ArchiveProjects2017Mac2) Then


                                    Dim Windowspath = Pathspasted.Replace(ArchiveProjects2017Mac1, ArchiveProjects2017c)
                                    Windowspath = Windowspath.Replace(ArchiveProjects2017Mac2, ArchiveProjects2017c)
                                    'Continue on
                                    Windowspath = Windowspath.Replace("/", "\")
                                    Thread.Sleep(200)
                                    TxtA.Text = Windowspath
                                    LblA.Text = Windowspath
                                    LinkA.Text = Windowspath
                                    Mainpath = Windowspath
                                    Console.WriteLine(Windowspath)
                                    Pathh = Windowspath
                                    TxtA.Text = Pathh
                                    LblA.Text = Pathh
                                    LinkA.Text = Pathh
                                    Mainpath = Pathh
                                    If Directory.Exists(Windowspath) Then
                                        'MessageBox.Show(Windowspath)

                                        Dim cd As String = "cd /d " & Windowspath

                                        Console.WriteLine(Windowspath)


                                        Process.Start("cmd.exe")


                                        Threading.Thread.Sleep(Delay)
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
                                        Pathh = Windowspath
                                        'Process.Start(Windowspath)
                                    Else
                                        Pathh = Windowspath

                                    End If



                                End If

                            End If

                        End If


                    End If



                    ' User Shares


                End If

            End If

        End If




        'Dim Windowspath = Pathspasted.Replace("afp://NY01-MP02/Storage NY", "Y:\Storage NY")
        'Windowspath = Windowspath.Replace("/", "\")
        ''k

        TxtA.Text = Pathh
        LblA.Text = Pathh
        LinkA.Text = Pathh
        Mainpath = Pathh

    End Sub

    Public Shared Sub screenCapture()
        Dim Countdown = 10

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
            If Windowtit.Contains("Chrome") Or Windowtit.Contains("Slack") Or Windowtit.Contains("Mail") Then
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
                Thread.Sleep(20)
                SendKeys.Send("^c")
                Thread.Sleep(20)
                SendKeys.Send("^c")
                Thread.Sleep(20)
                SendKeys.Send("^c")
                Thread.Sleep(100)
                Dim Clipboardcopy = Clipboard.GetText()
                'My.Computer.Keyboard.SendKeys("111", True)
                'MessageBox.Show(Clipboardcopy)
                Console.WriteLine(Clipboardcopy)

                Dim Pathspasted = Clipboardcopy


                ' Marketing 

                If Pathspasted.Contains(MarketingMac1) Or Pathspasted.Contains(MarketingMac2) Then


                    Dim Windowspath = Pathspasted.Replace(MarketingMac1, Marketingc)
                    Windowspath = Windowspath.Replace(MarketingMac2, Marketingc)
                    'Continue on
                    Windowspath = Windowspath.Replace("/", "\")
                    Thread.Sleep(200)
                    PathTracer.TxtA.Text = Windowspath
                    PathTracer.LblA.Text = Windowspath
                    PathTracer.LinkA.Text = Windowspath
                    PathTracer.Mainpath = Windowspath
                    If Directory.Exists(Windowspath) Then
                        'MessageBox.Show(Windowspath)
                        Opening.Show()
                        Opening.TopMost = True
                        Dim cd As String = "cd /d " & Windowspath


                        Process.Start("cmd.exe")


                        Threading.Thread.Sleep(Delay)
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
                        MessageBox.Show("The directory does not exist. Check again.")
                        Countdown = Countdown - 1
                        Console.WriteLine(Countdown)
                        NoDir.Show()
                        NoDir.TopMost = True
                    End If



                ElseIf Pathspasted.Contains(StorageNyMac1) Or Pathspasted.Contains(StorageNyMac2) Then


                    Dim Windowspath = Pathspasted.Replace(StorageNyMac1, StorageNyc)
                    Windowspath = Windowspath.Replace(StorageNyMac2, StorageNyc)
                    'Continue on
                    Windowspath = Windowspath.Replace("/", "\")
                    Thread.Sleep(200)
                    PathTracer.TxtA.Text = Windowspath
                    PathTracer.LblA.Text = Windowspath
                    PathTracer.LinkA.Text = Windowspath
                    PathTracer.Mainpath = Windowspath
                    Console.WriteLine(Windowspath)
                    If Directory.Exists(Windowspath) Then
                        'MessageBox.Show(Windowspath)
                        Opening.Show()
                        Opening.TopMost = True
                        Dim cd As String = "cd /d " & Windowspath

                        Console.WriteLine(Windowspath)


                        Process.Start("cmd.exe")


                        Threading.Thread.Sleep(Delay)
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
                        Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                        NoDir.Show()
                        NoDir.TopMost = True
                    End If



                    'User Shares
                Else
                    If Pathspasted.Contains(UsersharesMac1) Or Pathspasted.Contains(UsersharesMac2) Then


                        Dim Windowspath = Pathspasted.Replace(UsersharesMac1, Usersharesc)
                        Windowspath = Windowspath.Replace(UsersharesMac2, Usersharesc)
                        'Continue on
                        Windowspath = Windowspath.Replace("/", "\")
                        Thread.Sleep(200)
                        PathTracer.TxtA.Text = Windowspath
                        PathTracer.LblA.Text = Windowspath
                        PathTracer.LinkA.Text = Windowspath
                        PathTracer.Mainpath = Windowspath
                        Console.WriteLine(Windowspath)
                        If Directory.Exists(Windowspath) Then
                            'MessageBox.Show(Windowspath)
                            Opening.Show()
                            Opening.TopMost = True
                            Dim cd As String = "cd /d " & Windowspath

                            Console.WriteLine(Windowspath)


                            Process.Start("cmd.exe")


                            Threading.Thread.Sleep(Delay)
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
                            Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                            MessageBox.Show("The directory does not exist. Check again.")
                            NoDir.Show()
                            NoDir.TopMost = True
                        End If

                        'Software
                    Else
                        If Pathspasted.Contains(SoftwareMac1) Or Pathspasted.Contains(SoftwareMac2) Then


                            Dim Windowspath = Pathspasted.Replace(SoftwareMac1, Softwarec)
                            Windowspath = Windowspath.Replace(SoftwareMac2, StorageNyc)
                            'Continue on
                            Windowspath = Windowspath.Replace("/", "\")
                            Thread.Sleep(200)
                            PathTracer.TxtA.Text = Windowspath
                            PathTracer.LblA.Text = Windowspath
                            PathTracer.LinkA.Text = Windowspath
                            PathTracer.Mainpath = Windowspath
                            Console.WriteLine(Windowspath)
                            If Directory.Exists(Windowspath) Then
                                'MessageBox.Show(Windowspath)
                                Opening.Show()
                                Opening.TopMost = True
                                Dim cd As String = "cd /d " & Windowspath

                                Console.WriteLine(Windowspath)


                                Process.Start("cmd.exe")


                                Threading.Thread.Sleep(Delay)
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
                                Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                                NoDir.Show()
                                NoDir.TopMost = True
                            End If

                            'Multimedia
                        Else
                            If Pathspasted.Contains(MultimediaMac1) Or Pathspasted.Contains(MultimediaMac2) Then


                                Dim Windowspath = Pathspasted.Replace(MultimediaMac1, Multimediac)
                                Windowspath = Windowspath.Replace(MultimediaMac2, Multimediac)
                                'Continue on
                                Windowspath = Windowspath.Replace("/", "\")
                                Thread.Sleep(200)
                                PathTracer.TxtA.Text = Windowspath
                                PathTracer.LblA.Text = Windowspath
                                PathTracer.LinkA.Text = Windowspath
                                PathTracer.Mainpath = Windowspath
                                Console.WriteLine(Windowspath)
                                If Directory.Exists(Windowspath) Then
                                    'MessageBox.Show(Windowspath)
                                    Opening.Show()
                                    Opening.TopMost = True
                                    Dim cd As String = "cd /d " & Windowspath

                                    Console.WriteLine(Windowspath)


                                    Process.Start("cmd.exe")


                                    Threading.Thread.Sleep(Delay)
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
                                    Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                                    NoDir.Show()
                                    NoDir.TopMost = True
                                End If

                            Else

                                'JKRAssetBank

                                If Pathspasted.Contains(JKRAssetBankMac1) Or Pathspasted.Contains(JKRAssetBankMac2) Then


                                    Dim Windowspath = Pathspasted.Replace(JKRAssetBankMac1, JKRAssetBankc)
                                    Windowspath = Windowspath.Replace(JKRAssetBankMac2, JKRAssetBankc)
                                    'Continue on
                                    Windowspath = Windowspath.Replace("/", "\")
                                    Thread.Sleep(200)
                                    PathTracer.TxtA.Text = Windowspath
                                    PathTracer.LblA.Text = Windowspath
                                    PathTracer.LinkA.Text = Windowspath
                                    PathTracer.Mainpath = Windowspath
                                    Console.WriteLine(Windowspath)
                                    If Directory.Exists(Windowspath) Then
                                        'MessageBox.Show(Windowspath)
                                        Opening.Show()
                                        Opening.TopMost = True
                                        Dim cd As String = "cd /d " & Windowspath

                                        Console.WriteLine(Windowspath)


                                        Process.Start("cmd.exe")


                                        Threading.Thread.Sleep(Delay)
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
                                        Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                                        NoDir.Show()
                                        NoDir.TopMost = True
                                    End If

                                    'ArchiveProjects2016
                                Else
                                    If Pathspasted.Contains(ArchiveProjects2016Mac1) Or Pathspasted.Contains(ArchiveProjects2016Mac2) Then


                                        Dim Windowspath = Pathspasted.Replace(ArchiveProjects2016Mac1, ArchiveProjects2016c)
                                        Windowspath = Windowspath.Replace(ArchiveProjects2016Mac2, ArchiveProjects2016c)
                                        'Continue on
                                        Windowspath = Windowspath.Replace("/", "\")
                                        Thread.Sleep(200)
                                        PathTracer.TxtA.Text = Windowspath
                                        PathTracer.LblA.Text = Windowspath
                                        PathTracer.LinkA.Text = Windowspath
                                        PathTracer.Mainpath = Windowspath
                                        Console.WriteLine(Windowspath)
                                        If Directory.Exists(Windowspath) Then
                                            'MessageBox.Show(Windowspath)
                                            Opening.Show()
                                            Opening.TopMost = True
                                            Dim cd As String = "cd /d " & Windowspath

                                            Console.WriteLine(Windowspath)


                                            Process.Start("cmd.exe")


                                            Threading.Thread.Sleep(Delay)
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
                                            Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                                            NoDir.Show()
                                            NoDir.TopMost = True
                                        End If

                                        'ArchiveProjects2017
                                    Else
                                        If Pathspasted.Contains(ArchiveProjects2017Mac1) Or Pathspasted.Contains(ArchiveProjects2017Mac2) Then


                                            Dim Windowspath = Pathspasted.Replace(ArchiveProjects2017Mac1, ArchiveProjects2017c)
                                            Windowspath = Windowspath.Replace(ArchiveProjects2017Mac2, ArchiveProjects2017c)
                                            'Continue on
                                            Windowspath = Windowspath.Replace("/", "\")
                                            Thread.Sleep(200)
                                            PathTracer.TxtA.Text = Windowspath
                                            PathTracer.LblA.Text = Windowspath
                                            PathTracer.LinkA.Text = Windowspath
                                            PathTracer.Mainpath = Windowspath
                                            Console.WriteLine(Windowspath)
                                            If Directory.Exists(Windowspath) Then
                                                'MessageBox.Show(Windowspath)
                                                Opening.Show()
                                                Opening.TopMost = True
                                                Dim cd As String = "cd /d " & Windowspath

                                                Console.WriteLine(Windowspath)


                                                Process.Start("cmd.exe")


                                                Threading.Thread.Sleep(Delay)
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
                                                Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                                                NoDir.Show()
                                                NoDir.TopMost = True
                                            End If

                                        Else
                                            If Pathspasted.Contains("C:\") Then


                                                Dim Windowspath = Pathspasted.Replace(ArchiveProjects2017Mac1, ArchiveProjects2017c)
                                                Windowspath = Windowspath.Replace(ArchiveProjects2017Mac2, ArchiveProjects2017c)
                                                'Continue on
                                                Windowspath = Windowspath.Replace("/", "\")
                                                Thread.Sleep(200)
                                                PathTracer.TxtA.Text = Windowspath
                                                PathTracer.LblA.Text = Windowspath
                                                PathTracer.LinkA.Text = Windowspath
                                                PathTracer.Mainpath = Windowspath
                                                Console.WriteLine(Windowspath)
                                                If Directory.Exists(Windowspath) Then
                                                    'MessageBox.Show(Windowspath)
                                                    Opening.Show()
                                                    Opening.TopMost = True
                                                    Dim cd As String = "cd /d " & Windowspath

                                                    Console.WriteLine(Windowspath)


                                                    Process.Start("cmd.exe")


                                                    Threading.Thread.Sleep(Delay)
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
                                                    Console.WriteLine("BAD" & PathTracer.LinkA.Text)
                                                    NoDir.Show()
                                                    NoDir.TopMost = True
                                                End If


                                            End If

                                        End If

                                    End If


                                End If



                                ' User Shares

                            End If
                        End If

                    End If

                End If

            End If

        End If

        Opening.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Hotkey.registerHotkey(Me, Shortcutkey, SModifierkey)
        Shortcutkey = My.Settings.Shortcutkey
        SModifierkey = My.Settings.SModifierkey

        Delay = My.Settings.Delay

    End Sub

    Public Sub closingform1() Handles Me.FormClosing
        My.Settings.Shortcutkey = Shortcutkey
        My.Settings.SModifierkey = SModifierkey

        My.Settings.Delay = Delay

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


        If Pathspasted.Contains(Marketingc) Then
            Console.WriteLine(StorageNyc)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)
            Macpath = Macpath.Replace(StorageNyc, StorageNyMac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(Usersharesc) Then

            Console.WriteLine(Usersharesc)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)
            Macpath = Macpath.Replace(Usersharesc, UsersharesMac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(Softwarec) Then

            Console.WriteLine(Softwarec)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)
            Macpath = Macpath.Replace(Softwarec, SoftwareMac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(Multimediac) Then

            Console.WriteLine(Multimediac)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)

            Macpath = Macpath.Replace(Multimediac, MultimediaMac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(JKRAssetBankc) Then

            Console.WriteLine(JKRAssetBankc)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)
            Macpath = Macpath.Replace(JKRAssetBankc, JKRAssetBankMac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(ArchiveProjects2016c) Then

            Console.WriteLine(ArchiveProjects2016c)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)

            Macpath = Macpath.Replace(ArchiveProjects2016c, ArchiveProjects2016Mac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(ArchiveProjects2017c) Then

            Console.WriteLine(ArchiveProjects2017c)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)
            Macpath = Macpath.Replace(ArchiveProjects2017c, ArchiveProjects2017Mac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        ElseIf Pathspasted.Contains(StorageNyc) Then

            Console.WriteLine(ArchiveProjects2017c)
            Console.WriteLine(Pathspasted)
            Dim Macpath = Pathspasted
            'Continue on
            Console.WriteLine(Pathspasted)
            Macpath = Macpath.Replace(StorageNyc, StorageNyMac1)
            'MessageBox.Show(Macpath)
            Macpath = Macpath.Replace("\", "/")
            Thread.Sleep(200)
            TxtA.Text = Macpath
            LblA.Text = Macpath
            LinkA.Text = Macpath
            Mainpath = Macpath
            Console.WriteLine(Macpath)
        End If




        'Dim Macpath = Pathspasted.Replace("\", "/")

        'Console.WriteLine(TxtA.Text)
        'Console.WriteLine(LblA.Text)
        'Console.WriteLine(LinkA.Text)
        'Console.WriteLine(Macpath)
        'Console.WriteLine(LblA.Text)
        'Console.WriteLine(LinkA.Text)


        'TxtA.Text = Macpath
        'LblA.Text = Macpath
        'LinkA.Text = Macpath
        'Mainpath = Macpath


    End Sub

    Private Sub LinkA_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkA.LinkClicked

        Process.Start(Mainpath)

    End Sub

    Private Sub btnQuest_Click(sender As Object, e As EventArgs) Handles btnQuest.Click

        Help.Show()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Settings.Show()


    End Sub
End Class
