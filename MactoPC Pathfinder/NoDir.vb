Public Class NoDir
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl1.Text = Val(Lbl1.Text) - 1
        If Lbl1.Text = 0 Then


            Me.Close()


        End If


    End Sub
End Class