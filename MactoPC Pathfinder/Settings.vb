Public Class Settings

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textMarketing.Text = My.Settings.Marketing

        textStorageny.Text = My.Settings.StorageNy

        textUsershare.Text = My.Settings.Usershares

        textArchive16.Text = My.Settings.ArchiveProjects2016

        Txtsft.Text = My.Settings.Software

        textArchive17.Text = My.Settings.ArchiveProjects2017

        textMultimedia.Text = My.Settings.Multimedia

        textAssetbank.Text = My.Settings.jkrAssetBank





    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label20.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label23.Click, Label22.Click, Label21.Click, Label19.Click, Label25.Click, Label24.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboModifiers.SelectedIndexChanged
        Dim SModified = Hotkey.KeyModifier.Alt
        Dim SModifier = ComboModifiers.Text
        If SModifier.Contains("Alt") Then

            SModifierkey = Hotkey.KeyModifier.Alt

        Else
            If SModifier.Contains("Cntrl") Then


                SModifierkey = Hotkey.KeyModifier.Control

            End If

        End If
        Console.WriteLine(SModifierkey)

        My.Settings.SModifierkey = SModifierkey

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, ButtonApplyDelay.Click
        Hotkey.registerHotkey(Me, Shortcutkey, SModifierkey)
        Shortcutkey = TxtSKey.Text

        My.Settings.SModifierkey = SModifierkey

        Console.WriteLine("Shortcut:" & SModifierkey & Shortcutkey)
        Console.WriteLine(SModifierkey)

    End Sub

    Private Sub ButtonApplyDelay_Click(sender As Object, e As EventArgs) Handles ButtonApplyDelay.Click
        Delay = txtDelay.Text
        My.Settings.Delay = Delay
        Console.WriteLine(Delay)
    End Sub



    Public Sub closingsetting() Handles Me.FormClosing
        'PathTracer.Show()
        'Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Marketing = textMarketing.Text

        StorageNy = textStorageny.Text

        Usershares = textUsershare.Text

        ArchiveProjects2016 = textArchive16.Text

        Software = Txtsft.Text

        ArchiveProjects2017 = textArchive17.Text

        Multimedia = textMultimedia.Text

        JKRAssetBank = textAssetbank.Text

        Console.WriteLine(Marketing)
        My.Settings.Marketing = textMarketing.Text

        My.Settings.StorageNy = textStorageny.Text

        My.Settings.Usershares = textUsershare.Text

        My.Settings.ArchiveProjects2016 = textArchive16.Text

        My.Settings.Software = Txtsft.Text

        My.Settings.ArchiveProjects2017 = textArchive17.Text

        My.Settings.Multimedia = textMultimedia.Text

        My.Settings.jkrAssetBank = textAssetbank.Text

        Marketingc = Marketing & ":\"

        StorageNyc = StorageNy & ":\"

        Usersharesc = Usershares & ":\"

        ArchiveProjects2016c = ArchiveProjects2016 & ":\"

        Softwarec = Software & ":\"

        ArchiveProjects2017c = ArchiveProjects2017 & ":\"

        Multimediac = JKRAssetBank & ":\"

        JKRAssetBankc = JKRAssetBank & ":\"






    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        My.Settings.Reset()

        Application.Restart()


    End Sub
End Class