Public Class formKeranjang

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Hide()
        formStore.Show()
        formStore.Enabled = True
    End Sub

    Private Sub PembelianBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PembelianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)

    End Sub

    Private Sub formKeranjang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlinesotreDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.OnlinesotreDataSet.user)
        'TODO: This line of code loads data into the 'OnlinesotreDataSet.pembelian' table. You can move, or remove it, as needed.
        Me.PembelianTableAdapter.Fill(Me.OnlinesotreDataSet.pembelian)

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        TextBox8.Text = Val(TextBox3.Text) * Val(TextBox7.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class