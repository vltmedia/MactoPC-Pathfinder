Public Class Form1

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
