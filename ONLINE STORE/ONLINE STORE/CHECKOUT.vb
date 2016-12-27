Public Class CHECKOUT

    Private Sub CHECKOUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = formKeranjang.UserTextEdit.Text
        Label4.Text = formKeranjang.ComboBox1.Text
        Label6.Text = formKeranjang.ComboBox2.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class