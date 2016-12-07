Public Class formKeranjang

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Hide()
        formStore.Show()
        formStore.Enabled = True
    End Sub
End Class