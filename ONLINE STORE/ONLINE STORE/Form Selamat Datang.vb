Public Class Form_Selamat_Datang

    Private Sub lanjutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lanjutButton.Click
        Me.Hide()
        fadeout()
        formStore.ShowDialog()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Me.Close()
        fadeout()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lanjutButton_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lanjutButton.ForeColorChanged
    End Sub
End Class