Public Class formDatabase

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

    'Private Sub formDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'OnlinesotreDataSet.user' table. You can move, or remove it, as needed.
    '  Me.UserTableAdapter.Fill(Me.OnlinesotreDataSet.user)
    'TODO: This line of code loads data into the 'OnlinesotreDataSet.produk' table. You can move, or remove it, as needed.
    '  Me.ProdukTableAdapter.Fill(Me.OnlinesotreDataSet.produk)
    'TODO: This line of code loads data into the 'OnlinesotreDataSet.pembelian' table. You can move, or remove it, as needed.
    ' Me.PembelianTableAdapter.Fill(Me.OnlinesotreDataSet.pembelian)

    'End Sub

End Class