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

    Private Sub ProdukDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProdukDataGridView.CellContentClick

    End Sub

    Private Sub tambahUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UserBindingSource.AddNew()
    End Sub

    Private Sub hapusUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusUser.Click
        If MessageBox.Show("Hapus Data ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            UserBindingSource.RemoveCurrent()

            Me.Validate()
            Me.UserBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)
            MessageBox.Show("data terhapus")
        End If
    End Sub

    Private Sub simpanUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanUser.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)
        MessageBox.Show("berhasil simpan data")
    End Sub

    Private Sub simpanProduk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanProduk.Click
        Me.Validate()
        Me.ProdukBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)
        MessageBox.Show("berhasil tambah data")
    End Sub

    Private Sub editUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editUser.Click
        UserDataGridView.Enabled = True
    End Sub

    Private Sub editProduk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editProduk.Click
        ProdukDataGridView.Enabled = True
    End Sub
End Class