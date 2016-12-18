Public Class formStore
    Public ImageNum As Integer
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
            Case 2
                produk.Image = My.Resources.Resource1.baju2
            Case 3
                produk.Image = My.Resources.Resource1.kaos1
            Case 4
                produk.Image = My.Resources.Resource1.kaos2
            Case 5
                produk.Image = My.Resources.Resource1.kemeja1
            Case 6
                produk.Image = My.Resources.Resource1.kemeja2
            Case 7
                produk.Image = My.Resources.Resource1.sepatu1
            Case 8
                produk.Image = My.Resources.Resource1.sepatu2
            Case 9
                produk.Image = My.Resources.Resource1.tas1
            Case 10
                produk.Image = My.Resources.Resource1.tas2
            Case 11
                produk.Image = My.Resources.Resource1.topi1
            Case 12
                produk.Image = My.Resources.Resource1.topi2

        End Select
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        ImageNum = ImageNum - 1
        If ImageNum < 1 Then ImageNum = 12

        Select Case ImageNum
            Case 1
                produk.Image = My.Resources.Resource1.baju1
            Case 2
                produk.Image = My.Resources.Resource1.baju2
            Case 3
                produk.Image = My.Resources.Resource1.kaos1
            Case 4
                produk.Image = My.Resources.Resource1.kaos2
            Case 5
                produk.Image = My.Resources.Resource1.kemeja1
            Case 6
                produk.Image = My.Resources.Resource1.kemeja2
            Case 7
                produk.Image = My.Resources.Resource1.sepatu1
            Case 8
                produk.Image = My.Resources.Resource1.sepatu2
            Case 9
                produk.Image = My.Resources.Resource1.tas1
            Case 10
                produk.Image = My.Resources.Resource1.tas2
            Case 11
                produk.Image = My.Resources.Resource1.topi1
            Case 12
                produk.Image = My.Resources.Resource1.topi2

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
End Class