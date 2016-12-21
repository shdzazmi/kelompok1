Imports System.Data
Imports System.Data.SqlClient

Public Class formStore
    Public ImageNum As Integer
    Public con As New SqlConnection
    Public cmd As New SqlCommand

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Enabled = True
        FadeIn()
    End Sub

    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click

        ImageNum = ImageNum + 1
        If ImageNum > 12 Then ImageNum = 1

        Select Case ImageNum
            Case 1
                produk.Image = My.Resources.Resource1.baju1
                TextBox1.Text = "B01"
                TextBox2.Text = "T-SHIRT RED SIMPLE EDITION"
                TextBox3.Text = "90000"
                TextBox4.Text = "S-XL"
                TextBox5.Text = "MERAH-HITAM"
            Case 2
                produk.Image = My.Resources.Resource1.baju2
                TextBox1.Text = "B02"
                TextBox2.Text = "T-SHIRT HORIZONTAL MOTIF PINK"
                TextBox3.Text = "90000"
                TextBox4.Text = "S-XL"
                TextBox5.Text = "PINK-HITAM"
            Case 3
                produk.Image = My.Resources.Resource1.kaos1
                TextBox1.Text = "K01"
                TextBox2.Text = "KAOS KAKI RASTA PREMIUM"
                TextBox3.Text = "45000"
                TextBox4.Text = "26"
                TextBox5.Text = "HIJAU"
            Case 4
                produk.Image = My.Resources.Resource1.kaos2
                TextBox1.Text = "K02"
                TextBox2.Text = "KAOS STCL GRADIENT ABU ABU"
                TextBox3.Text = "45000"
                TextBox4.Text = "26"
                TextBox5.Text = "ABU-ABU-HITAM"
            Case 5
                produk.Image = My.Resources.Resource1.kemeja1
                TextBox1.Text = "M01"
                TextBox2.Text = "KEMEJA RIPCURL PREMIUM DESIGN"
                TextBox3.Text = "140000"
                TextBox4.Text = "M-XL"
                TextBox5.Text = "MERAH"
            Case 6
                produk.Image = My.Resources.Resource1.kemeja2
                TextBox1.Text = "M02"
                TextBox2.Text = "KEMEJA RIPCURL 02 PREMIUM DESIGN"
                TextBox3.Text = "150000"
                TextBox4.Text = "M-XL"
                TextBox5.Text = "HITAM"
            Case 7
                produk.Image = My.Resources.Resource1.sepatu1
                TextBox1.Text = "S01"
                TextBox2.Text = "VANS OFF THE WALL NEW"
                TextBox3.Text = "250000"
                TextBox4.Text = "39-42"
                TextBox5.Text = "ABU-ABU"
            Case 8
                produk.Image = My.Resources.Resource1.sepatu2
                TextBox1.Text = "S02"
                TextBox2.Text = "VANS OFF THE WALL R30"
                TextBox3.Text = "210000"
                TextBox4.Text = "39-41"
                TextBox5.Text = "HITAM"
            Case 9
                produk.Image = My.Resources.Resource1.tas1
                TextBox1.Text = "T01"
                TextBox2.Text = "BACKPACKER LEATHER BROWN UNISEX"
                TextBox3.Text = "250000"
                TextBox4.Text = "36X15X25"
                TextBox5.Text = "COKLAT"
            Case 10
                produk.Image = My.Resources.Resource1.tas2
                TextBox1.Text = "T02"
                TextBox2.Text = "BACKPACKER FOR TRAVEL UNISEX"
                TextBox3.Text = "220000"
                TextBox4.Text = "36X12X26"
                TextBox5.Text = "COKLAT TUA"
            Case 11
                produk.Image = My.Resources.Resource1.topi1
                TextBox1.Text = "H01"
                TextBox2.Text = "BEAR SNAPBACK BROWN-GREY"
                TextBox3.Text = "70000"
                TextBox4.Text = "M-L"
                TextBox5.Text = "COKLAT"
            Case 12
                produk.Image = My.Resources.Resource1.topi2
                TextBox1.Text = "H02"
                TextBox2.Text = "RIDECORE HAT GREY"
                TextBox3.Text = "60000"
                TextBox4.Text = "S-L"
                TextBox5.Text = "ABU-ABU"

        End Select
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        ImageNum = ImageNum - 1
        If ImageNum < 1 Then ImageNum = 12

        Select Case ImageNum
            Case 1
                produk.Image = My.Resources.Resource1.baju1
                TextBox1.Text = "B01"
                TextBox2.Text = "T-SHIRT RED SIMPLE EDITION"
                TextBox3.Text = "90000"
                TextBox4.Text = "S-XL"
                TextBox5.Text = "MERAH-HITAM"
            Case 2
                produk.Image = My.Resources.Resource1.baju2
                TextBox1.Text = "B02"
                TextBox2.Text = "T-SHIRT HORIZONTAL MOTIF PINK"
                TextBox3.Text = "90000"
                TextBox4.Text = "S-XL"
                TextBox5.Text = "PINK-HITAM"
            Case 3
                produk.Image = My.Resources.Resource1.kaos1
                TextBox1.Text = "K01"
                TextBox2.Text = "KAOS KAKI RASTA PREMIUM"
                TextBox3.Text = "45000"
                TextBox4.Text = "26"
                TextBox5.Text = "HIJAU"
            Case 4
                produk.Image = My.Resources.Resource1.kaos2
                TextBox1.Text = "K02"
                TextBox2.Text = "KAOS STCL GRADIENT ABU ABU"
                TextBox3.Text = "45000"
                TextBox4.Text = "26"
                TextBox5.Text = "ABU-ABU-HITAM"
            Case 5
                produk.Image = My.Resources.Resource1.kemeja1
                TextBox1.Text = "M01"
                TextBox2.Text = "KEMEJA RIPCURL PREMIUM DESIGN"
                TextBox3.Text = "140000"
                TextBox4.Text = "M-XL"
                TextBox5.Text = "MERAH"
            Case 6
                produk.Image = My.Resources.Resource1.kemeja2
                TextBox1.Text = "M02"
                TextBox2.Text = "KEMEJA RIPCURL 02 PREMIUM DESIGN"
                TextBox3.Text = "150000"
                TextBox4.Text = "M-XL"
                TextBox5.Text = "HITAM"
            Case 7
                produk.Image = My.Resources.Resource1.sepatu1
                TextBox1.Text = "S01"
                TextBox2.Text = "VANS OFF THE WALL NEW"
                TextBox3.Text = "250000"
                TextBox4.Text = "39-42"
                TextBox5.Text = "ABU-ABU"
            Case 8
                produk.Image = My.Resources.Resource1.sepatu2
                TextBox1.Text = "S02"
                TextBox2.Text = "VANS OFF THE WALL R30"
                TextBox3.Text = "210000"
                TextBox4.Text = "39-41"
                TextBox5.Text = "HITAM"
            Case 9
                produk.Image = My.Resources.Resource1.tas1
                TextBox1.Text = "T01"
                TextBox2.Text = "BACKPACKER LEATHER BROWN UNISEX"
                TextBox3.Text = "250000"
                TextBox4.Text = "36X15X25"
                TextBox5.Text = "COKLAT"
            Case 10
                produk.Image = My.Resources.Resource1.tas2
                TextBox1.Text = "T02"
                TextBox2.Text = "BACKPACKER FOR TRAVEL UNISEX"
                TextBox3.Text = "220000"
                TextBox4.Text = "36X12X26"
                TextBox5.Text = "COKLAT TUA"
            Case 11
                produk.Image = My.Resources.Resource1.topi1
                TextBox1.Text = "H01"
                TextBox2.Text = "BEAR SNAPBACK BROWN-GREY"
                TextBox3.Text = "70000"
                TextBox4.Text = "M-L"
                TextBox5.Text = "COKLAT"
            Case 12
                produk.Image = My.Resources.Resource1.topi2
                TextBox1.Text = "H02"
                TextBox2.Text = "RIDECORE HAT GREY"
                TextBox3.Text = "60000"
                TextBox4.Text = "S-L"
                TextBox5.Text = "ABU-ABU"
        End Select
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        fadeout()
        Application.Exit()
    End Sub

    Private Sub minimizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizeButton.Click
        fadeout()
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        FadeIn()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles databaseButton.Click
        Me.Enabled = False
        LOGIN.Show()
    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlinesotreDataSet.pembelian' table. You can move, or remove it, as needed.
        Me.PembelianTableAdapter.Fill(Me.OnlinesotreDataSet.pembelian)
        Me.Enabled = True
        FadeIn()
    End Sub

    Private Sub produk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles produk.Click

    End Sub

    Private Sub keranjangButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keranjangButton.Click
        Me.Enabled = False
        formKeranjang.Show()
    End Sub

    Private Sub tambahkanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahkanButton.Click
        'con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "INSERT INTO pembelian(tanggal, produk_idproduk, nama, warna, ukuran, harga) VALUES('" & Date.Now & "' , '" & TextBox1.Text & "' ,'" & TextBox2.Text & "' , '" & TextBox5.Text & "' , '" & TextBox4.Text & "' , '" & TextBox3.Text & "' "
        
        MessageBox.Show("Barang Berhasil Ditambah")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        MessageBox.Show("Barang Berhasil Ditambah")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Barang Berhasil Ditambah")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PembelianBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PembelianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlinesotreDataSet)

    End Sub

    Private Sub IdPembelianTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class