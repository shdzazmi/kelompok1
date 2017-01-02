Public Class Form_Selamat_Datang

    Private Sub lanjutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lanjutButton.Click
        Me.Hide()
        formStore.Show()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lanjutButton_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lanjutButton.ForeColorChanged
    End Sub

    Private Sub Form_Selamat_Datang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Left = Label1.Left + 10
        If Label1.Left >= Me.Width - Label1.Width Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label1.Left = Label1.Left - 10
        If Label1.Left <= 0 Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub
End Class