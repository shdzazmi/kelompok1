﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim Total_hargaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formStore))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.namaBarang = New System.Windows.Forms.Label()
        Me.hargaBarang = New System.Windows.Forms.Label()
        Me.idBarang = New System.Windows.Forms.Label()
        Me.warnaBarang = New System.Windows.Forms.Label()
        Me.ukuranBarang = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.keranjangButton = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.PictureBox()
        Me.tambahkanButton = New System.Windows.Forms.PictureBox()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.nextButton = New System.Windows.Forms.PictureBox()
        Me.produk = New System.Windows.Forms.PictureBox()
        Me.databaseButton = New System.Windows.Forms.PictureBox()
        Me.minimizeButton = New System.Windows.Forms.PictureBox()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OnlinesotreDataSet = New ONLINE_STORE.onlinesotreDataSet()
        Me.PembelianTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.pembelianTableAdapter()
        Me.TableAdapterManager = New ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager()
        Me.TanggalDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.Total_hargaTextBox = New System.Windows.Forms.TextBox()
        TanggalLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        Total_hargaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.keranjangButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tambahkanButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databaseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnlinesotreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Enabled = False
        TanggalLabel.Location = New System.Drawing.Point(728, 128)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(45, 13)
        TanggalLabel.TabIndex = 24
        TanggalLabel.Text = "tanggal:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Enabled = False
        JumlahLabel.Location = New System.Drawing.Point(728, 156)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(40, 13)
        JumlahLabel.TabIndex = 36
        JumlahLabel.Text = "jumlah:"
        '
        'Total_hargaLabel
        '
        Total_hargaLabel.AutoSize = True
        Total_hargaLabel.Enabled = False
        Total_hargaLabel.Location = New System.Drawing.Point(728, 182)
        Total_hargaLabel.Name = "Total_hargaLabel"
        Total_hargaLabel.Size = New System.Drawing.Size(60, 13)
        Total_hargaLabel.TabIndex = 38
        Total_hargaLabel.Text = "total harga:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 42)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RAGS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "S   T   O   R   E"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "TAMBAHKAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(541, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "KERANJANG"
        '
        'namaBarang
        '
        Me.namaBarang.AutoSize = True
        Me.namaBarang.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaBarang.Location = New System.Drawing.Point(6, 46)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(149, 23)
        Me.namaBarang.TabIndex = 12
        Me.namaBarang.Text = "NAMABARANG"
        '
        'hargaBarang
        '
        Me.hargaBarang.AutoSize = True
        Me.hargaBarang.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hargaBarang.Location = New System.Drawing.Point(6, 101)
        Me.hargaBarang.Name = "hargaBarang"
        Me.hargaBarang.Size = New System.Drawing.Size(78, 23)
        Me.hargaBarang.TabIndex = 13
        Me.hargaBarang.Text = "HARGA"
        '
        'idBarang
        '
        Me.idBarang.AutoSize = True
        Me.idBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idBarang.Location = New System.Drawing.Point(37, 126)
        Me.idBarang.Name = "idBarang"
        Me.idBarang.Size = New System.Drawing.Size(20, 16)
        Me.idBarang.TabIndex = 12
        Me.idBarang.Text = "ID"
        '
        'warnaBarang
        '
        Me.warnaBarang.AutoSize = True
        Me.warnaBarang.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warnaBarang.Location = New System.Drawing.Point(6, 227)
        Me.warnaBarang.Name = "warnaBarang"
        Me.warnaBarang.Size = New System.Drawing.Size(80, 23)
        Me.warnaBarang.TabIndex = 14
        Me.warnaBarang.Text = "WARNA"
        '
        'ukuranBarang
        '
        Me.ukuranBarang.AutoSize = True
        Me.ukuranBarang.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ukuranBarang.Location = New System.Drawing.Point(6, 168)
        Me.ukuranBarang.Name = "ukuranBarang"
        Me.ukuranBarang.Size = New System.Drawing.Size(87, 23)
        Me.ukuranBarang.TabIndex = 14
        Me.ukuranBarang.Text = "UKURAN"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(63, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(63, 179)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(63, 234)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 20)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(63, 301)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(169, 20)
        Me.TextBox4.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(63, 360)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(169, 20)
        Me.TextBox5.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.namaBarang)
        Me.GroupBox1.Controls.Add(Me.hargaBarang)
        Me.GroupBox1.Controls.Add(Me.ukuranBarang)
        Me.GroupBox1.Controls.Add(Me.warnaBarang)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 301)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'keranjangButton
        '
        Me.keranjangButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keranjangButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.shopping_cart
        Me.keranjangButton.Location = New System.Drawing.Point(572, 441)
        Me.keranjangButton.Name = "keranjangButton"
        Me.keranjangButton.Size = New System.Drawing.Size(32, 32)
        Me.keranjangButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.keranjangButton.TabIndex = 16
        Me.keranjangButton.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.cancel
        Me.exitButton.Location = New System.Drawing.Point(876, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(32, 32)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.exitButton.TabIndex = 15
        Me.exitButton.TabStop = False
        '
        'tambahkanButton
        '
        Me.tambahkanButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tambahkanButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.shopping_bag
        Me.tambahkanButton.Location = New System.Drawing.Point(376, 441)
        Me.tambahkanButton.Name = "tambahkanButton"
        Me.tambahkanButton.Size = New System.Drawing.Size(32, 32)
        Me.tambahkanButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.tambahkanButton.TabIndex = 6
        Me.tambahkanButton.TabStop = False
        '
        'backButton
        '
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.back
        Me.backButton.Location = New System.Drawing.Point(280, 234)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(32, 32)
        Me.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.backButton.TabIndex = 5
        Me.backButton.TabStop = False
        '
        'nextButton
        '
        Me.nextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextButton.Image = CType(resources.GetObject("nextButton.Image"), System.Drawing.Image)
        Me.nextButton.Location = New System.Drawing.Point(674, 234)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(32, 32)
        Me.nextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.nextButton.TabIndex = 4
        Me.nextButton.TabStop = False
        '
        'produk
        '
        Me.produk.Image = Global.ONLINE_STORE.My.Resources.Resource1.baju1
        Me.produk.Location = New System.Drawing.Point(318, 85)
        Me.produk.Name = "produk"
        Me.produk.Size = New System.Drawing.Size(350, 350)
        Me.produk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.produk.TabIndex = 3
        Me.produk.TabStop = False
        '
        'databaseButton
        '
        Me.databaseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.databaseButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.folder
        Me.databaseButton.Location = New System.Drawing.Point(876, 469)
        Me.databaseButton.Name = "databaseButton"
        Me.databaseButton.Size = New System.Drawing.Size(32, 32)
        Me.databaseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.databaseButton.TabIndex = 2
        Me.databaseButton.TabStop = False
        '
        'minimizeButton
        '
        Me.minimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizeButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.download
        Me.minimizeButton.Location = New System.Drawing.Point(838, 12)
        Me.minimizeButton.Name = "minimizeButton"
        Me.minimizeButton.Size = New System.Drawing.Size(32, 32)
        Me.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.minimizeButton.TabIndex = 1
        Me.minimizeButton.TabStop = False
        '
        'PembelianBindingSource
        '
        Me.PembelianBindingSource.DataMember = "pembelian"
        Me.PembelianBindingSource.DataSource = Me.OnlinesotreDataSet
        '
        'OnlinesotreDataSet
        '
        Me.OnlinesotreDataSet.DataSetName = "onlinesotreDataSet"
        Me.OnlinesotreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PembelianTableAdapter
        '
        Me.PembelianTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pembelianTableAdapter = Me.PembelianTableAdapter
        Me.TableAdapterManager.produkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'TanggalDateEdit
        '
        Me.TanggalDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "tanggal", True))
        Me.TanggalDateEdit.EditValue = Nothing
        Me.TanggalDateEdit.Enabled = False
        Me.TanggalDateEdit.Location = New System.Drawing.Point(825, 125)
        Me.TanggalDateEdit.Name = "TanggalDateEdit"
        Me.TanggalDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.TanggalDateEdit.TabIndex = 25
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembelianBindingSource, "jumlah", True))
        Me.JumlahTextBox.Enabled = False
        Me.JumlahTextBox.Location = New System.Drawing.Point(825, 153)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JumlahTextBox.TabIndex = 37
        '
        'Total_hargaTextBox
        '
        Me.Total_hargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembelianBindingSource, "total_harga", True))
        Me.Total_hargaTextBox.Enabled = False
        Me.Total_hargaTextBox.Location = New System.Drawing.Point(825, 179)
        Me.Total_hargaTextBox.Name = "Total_hargaTextBox"
        Me.Total_hargaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_hargaTextBox.TabIndex = 39
        '
        'formStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 521)
        Me.ControlBox = False
        Me.Controls.Add(TanggalLabel)
        Me.Controls.Add(Me.TanggalDateEdit)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahTextBox)
        Me.Controls.Add(Total_hargaLabel)
        Me.Controls.Add(Me.Total_hargaTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.keranjangButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.idBarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tambahkanButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.produk)
        Me.Controls.Add(Me.databaseButton)
        Me.Controls.Add(Me.minimizeButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.keranjangButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tambahkanButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databaseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnlinesotreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents minimizeButton As System.Windows.Forms.PictureBox
    Friend WithEvents databaseButton As System.Windows.Forms.PictureBox
    Friend WithEvents produk As System.Windows.Forms.PictureBox
    Friend WithEvents nextButton As System.Windows.Forms.PictureBox
    Friend WithEvents backButton As System.Windows.Forms.PictureBox
    Friend WithEvents tambahkanButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents namaBarang As System.Windows.Forms.Label
    Friend WithEvents hargaBarang As System.Windows.Forms.Label
    Friend WithEvents idBarang As System.Windows.Forms.Label
    Friend WithEvents warnaBarang As System.Windows.Forms.Label
    Friend WithEvents ukuranBarang As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.PictureBox
    Friend WithEvents keranjangButton As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OnlinesotreDataSet As ONLINE_STORE.onlinesotreDataSet
    Friend WithEvents PembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianTableAdapter As ONLINE_STORE.onlinesotreDataSetTableAdapters.pembelianTableAdapter
    Friend WithEvents TableAdapterManager As ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TanggalDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_hargaTextBox As System.Windows.Forms.TextBox

End Class
