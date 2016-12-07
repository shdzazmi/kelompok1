Public Class LOGIN

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        formStore.Show()
        formStore.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = 1234 Then
            Me.Hide()
            formDatabase.Show()
            TextBox1.Clear()
        Else
            MessageBox.Show("Password Salah")
            TextBox1.Clear()
        End If
    End Sub
End Class