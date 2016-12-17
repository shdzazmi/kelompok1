Public Class Form_Selamat_Datang

    Private Sub lanjutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lanjutButton.Click
        Me.Hide()
        formStore.Show()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Application.Exit()
    End Sub

End Class