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

    Private Sub formDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlinesotreDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.OnlinesotreDataSet.user)
        'TODO: This line of code loads data into the 'OnlinesotreDataSet.produk' table. You can move, or remove it, as needed.
        Me.ProdukTableAdapter.Fill(Me.OnlinesotreDataSet.produk)
        'TODO: This line of code loads data into the 'OnlinesotreDataSet.pembelian' table. You can move, or remove it, as needed.
        Me.PembelianTableAdapter.Fill(Me.OnlinesotreDataSet.pembelian)

        End Sub

    Private Sub ProdukDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProdukDataGridView.CellContentClick

    End Sub

    Private Sub tambahUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UserBindingSource.AddNew()
    End Sub

    Private Sub hapusUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusUser.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            UserBindingSource.RemoveCurrent()

            Me.Validate()
            Me.UserBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)
            MessageBox.Show("Data Terhapus")
        End If
    End Sub

    Private Sub simpanUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanUser.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)
        tambahUser.Enabled = True
        simpanUser.Enabled = False
        hapusUser.Enabled = False
        UserTextEdit.Visible = False
        PasswordTextEdit.Visible = False
        NoHapeTextEdit.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        MessageBox.Show("Berhasil Simpan Data")
    End Sub

    Private Sub simpanProduk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanProduk.Click
        Me.Validate()
        Me.ProdukBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)
        ProdukDataGridView.Enabled = False
        MessageBox.Show("Berhasil Simpan Data")
    End Sub

    Private Sub editUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editUser.Click
        UserDataGridView.Enabled = True
        hapusUser.Enabled = True
        simpanUser.Enabled = True
    End Sub

    Private Sub editProduk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editProduk.Click
        ProdukDataGridView.Enabled = True
    End Sub

    Private Sub tambahUser_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahUser.Click
        tambahUser.Enabled = False
        simpanUser.Enabled = True
        hapusUser.Enabled = True
        UserTextEdit.Visible = True
        PasswordTextEdit.Visible = True
        NoHapeTextEdit.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

        UserBindingSource.AddNew()

    End Sub

End Class