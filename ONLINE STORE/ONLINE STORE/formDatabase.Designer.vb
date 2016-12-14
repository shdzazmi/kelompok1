<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDatabase
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
        Dim IdPembelianLabel As System.Windows.Forms.Label
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim User_userLabel As System.Windows.Forms.Label
        Dim Produk_idProdukLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim WarnaLabel As System.Windows.Forms.Label
        Dim UkuranLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim Total_hargaLabel As System.Windows.Forms.Label
        Dim IdProdukLabel As System.Windows.Forms.Label
        Dim NamaLabel1 As System.Windows.Forms.Label
        Dim HargaLabel1 As System.Windows.Forms.Label
        Dim UkuranLabel1 As System.Windows.Forms.Label
        Dim WarnaLabel1 As System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.PictureBox()
        Me.OnlinesotreDataSet = New ONLINE_STORE.onlinesotreDataSet()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.pembelianTableAdapter()
        Me.TableAdapterManager = New ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager()
        Me.ProdukTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.produkTableAdapter()
        Me.UserTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.userTableAdapter()
        Me.IdPembelianTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TanggalDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_userTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Produk_idProdukTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WarnaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UkuranTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HargaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.JumlahSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Total_hargaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProdukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdProdukTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NamaTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.HargaSpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.UkuranTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.WarnaTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdPembelianLabel = New System.Windows.Forms.Label()
        TanggalLabel = New System.Windows.Forms.Label()
        User_userLabel = New System.Windows.Forms.Label()
        Produk_idProdukLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        WarnaLabel = New System.Windows.Forms.Label()
        UkuranLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        Total_hargaLabel = New System.Windows.Forms.Label()
        IdProdukLabel = New System.Windows.Forms.Label()
        NamaLabel1 = New System.Windows.Forms.Label()
        HargaLabel1 = New System.Windows.Forms.Label()
        UkuranLabel1 = New System.Windows.Forms.Label()
        WarnaLabel1 = New System.Windows.Forms.Label()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnlinesotreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdPembelianTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_userTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Produk_idProdukTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UkuranTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HargaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JumlahSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_hargaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdProdukTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HargaSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UkuranTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnaTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPembelianLabel
        '
        IdPembelianLabel.AutoSize = True
        IdPembelianLabel.Location = New System.Drawing.Point(12, 112)
        IdPembelianLabel.Name = "IdPembelianLabel"
        IdPembelianLabel.Size = New System.Drawing.Size(70, 13)
        IdPembelianLabel.TabIndex = 17
        IdPembelianLabel.Text = "id Pembelian:"
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Location = New System.Drawing.Point(12, 138)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(45, 13)
        TanggalLabel.TabIndex = 19
        TanggalLabel.Text = "tanggal:"
        '
        'User_userLabel
        '
        User_userLabel.AutoSize = True
        User_userLabel.Location = New System.Drawing.Point(12, 164)
        User_userLabel.Name = "User_userLabel"
        User_userLabel.Size = New System.Drawing.Size(53, 13)
        User_userLabel.TabIndex = 21
        User_userLabel.Text = "user user:"
        '
        'Produk_idProdukLabel
        '
        Produk_idProdukLabel.AutoSize = True
        Produk_idProdukLabel.Location = New System.Drawing.Point(12, 190)
        Produk_idProdukLabel.Name = "Produk_idProdukLabel"
        Produk_idProdukLabel.Size = New System.Drawing.Size(91, 13)
        Produk_idProdukLabel.TabIndex = 23
        Produk_idProdukLabel.Text = "produk id Produk:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(12, 216)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 25
        NamaLabel.Text = "nama:"
        '
        'WarnaLabel
        '
        WarnaLabel.AutoSize = True
        WarnaLabel.Location = New System.Drawing.Point(12, 242)
        WarnaLabel.Name = "WarnaLabel"
        WarnaLabel.Size = New System.Drawing.Size(39, 13)
        WarnaLabel.TabIndex = 27
        WarnaLabel.Text = "warna:"
        '
        'UkuranLabel
        '
        UkuranLabel.AutoSize = True
        UkuranLabel.Location = New System.Drawing.Point(12, 268)
        UkuranLabel.Name = "UkuranLabel"
        UkuranLabel.Size = New System.Drawing.Size(43, 13)
        UkuranLabel.TabIndex = 29
        UkuranLabel.Text = "ukuran:"
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(12, 294)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(37, 13)
        HargaLabel.TabIndex = 31
        HargaLabel.Text = "harga:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(12, 320)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(40, 13)
        JumlahLabel.TabIndex = 33
        JumlahLabel.Text = "jumlah:"
        '
        'Total_hargaLabel
        '
        Total_hargaLabel.AutoSize = True
        Total_hargaLabel.Location = New System.Drawing.Point(12, 346)
        Total_hargaLabel.Name = "Total_hargaLabel"
        Total_hargaLabel.Size = New System.Drawing.Size(60, 13)
        Total_hargaLabel.TabIndex = 35
        Total_hargaLabel.Text = "total harga:"
        '
        'IdProdukLabel
        '
        IdProdukLabel.AutoSize = True
        IdProdukLabel.Location = New System.Drawing.Point(240, 168)
        IdProdukLabel.Name = "IdProdukLabel"
        IdProdukLabel.Size = New System.Drawing.Size(55, 13)
        IdProdukLabel.TabIndex = 37
        IdProdukLabel.Text = "id Produk:"
        '
        'NamaLabel1
        '
        NamaLabel1.AutoSize = True
        NamaLabel1.Location = New System.Drawing.Point(240, 194)
        NamaLabel1.Name = "NamaLabel1"
        NamaLabel1.Size = New System.Drawing.Size(36, 13)
        NamaLabel1.TabIndex = 39
        NamaLabel1.Text = "nama:"
        '
        'HargaLabel1
        '
        HargaLabel1.AutoSize = True
        HargaLabel1.Location = New System.Drawing.Point(240, 220)
        HargaLabel1.Name = "HargaLabel1"
        HargaLabel1.Size = New System.Drawing.Size(37, 13)
        HargaLabel1.TabIndex = 41
        HargaLabel1.Text = "harga:"
        '
        'UkuranLabel1
        '
        UkuranLabel1.AutoSize = True
        UkuranLabel1.Location = New System.Drawing.Point(240, 246)
        UkuranLabel1.Name = "UkuranLabel1"
        UkuranLabel1.Size = New System.Drawing.Size(43, 13)
        UkuranLabel1.TabIndex = 43
        UkuranLabel1.Text = "ukuran:"
        '
        'WarnaLabel1
        '
        WarnaLabel1.AutoSize = True
        WarnaLabel1.Location = New System.Drawing.Point(240, 272)
        WarnaLabel1.Name = "WarnaLabel1"
        WarnaLabel1.Size = New System.Drawing.Size(39, 13)
        WarnaLabel1.TabIndex = 45
        WarnaLabel1.Text = "warna:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(323, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "S   T   O   R   E"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 42)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "RAGS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "D A T A B A S E"
        '
        'exitButton
        '
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.Image = Global.ONLINE_STORE.My.Resources.Resource1.cancel
        Me.exitButton.Location = New System.Drawing.Point(710, 9)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(32, 32)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.exitButton.TabIndex = 16
        Me.exitButton.TabStop = False
        '
        'OnlinesotreDataSet
        '
        Me.OnlinesotreDataSet.DataSetName = "onlinesotreDataSet"
        Me.OnlinesotreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PembelianBindingSource
        '
        Me.PembelianBindingSource.DataMember = "pembelian"
        Me.PembelianBindingSource.DataSource = Me.OnlinesotreDataSet
        '
        'PembelianTableAdapter
        '
        Me.PembelianTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pembelianTableAdapter = Me.PembelianTableAdapter
        Me.TableAdapterManager.produkTableAdapter = Me.ProdukTableAdapter
        Me.TableAdapterManager.UpdateOrder = ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Me.UserTableAdapter
        '
        'ProdukTableAdapter
        '
        Me.ProdukTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'IdPembelianTextEdit
        '
        Me.IdPembelianTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "idPembelian", True))
        Me.IdPembelianTextEdit.Location = New System.Drawing.Point(109, 109)
        Me.IdPembelianTextEdit.Name = "IdPembelianTextEdit"
        Me.IdPembelianTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdPembelianTextEdit.TabIndex = 18
        '
        'TanggalDateEdit
        '
        Me.TanggalDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "tanggal", True))
        Me.TanggalDateEdit.EditValue = Nothing
        Me.TanggalDateEdit.Location = New System.Drawing.Point(109, 135)
        Me.TanggalDateEdit.Name = "TanggalDateEdit"
        Me.TanggalDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.TanggalDateEdit.TabIndex = 20
        '
        'User_userTextEdit
        '
        Me.User_userTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "user_user", True))
        Me.User_userTextEdit.Location = New System.Drawing.Point(109, 161)
        Me.User_userTextEdit.Name = "User_userTextEdit"
        Me.User_userTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.User_userTextEdit.TabIndex = 22
        '
        'Produk_idProdukTextEdit
        '
        Me.Produk_idProdukTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "produk_idProduk", True))
        Me.Produk_idProdukTextEdit.Location = New System.Drawing.Point(109, 187)
        Me.Produk_idProdukTextEdit.Name = "Produk_idProdukTextEdit"
        Me.Produk_idProdukTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Produk_idProdukTextEdit.TabIndex = 24
        '
        'NamaTextEdit
        '
        Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "nama", True))
        Me.NamaTextEdit.Location = New System.Drawing.Point(109, 213)
        Me.NamaTextEdit.Name = "NamaTextEdit"
        Me.NamaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextEdit.TabIndex = 26
        '
        'WarnaTextEdit
        '
        Me.WarnaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "warna", True))
        Me.WarnaTextEdit.Location = New System.Drawing.Point(109, 239)
        Me.WarnaTextEdit.Name = "WarnaTextEdit"
        Me.WarnaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WarnaTextEdit.TabIndex = 28
        '
        'UkuranTextEdit
        '
        Me.UkuranTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "ukuran", True))
        Me.UkuranTextEdit.Location = New System.Drawing.Point(109, 265)
        Me.UkuranTextEdit.Name = "UkuranTextEdit"
        Me.UkuranTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.UkuranTextEdit.TabIndex = 30
        '
        'HargaSpinEdit
        '
        Me.HargaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "harga", True))
        Me.HargaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HargaSpinEdit.Location = New System.Drawing.Point(109, 291)
        Me.HargaSpinEdit.Name = "HargaSpinEdit"
        Me.HargaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HargaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.HargaSpinEdit.TabIndex = 32
        '
        'JumlahSpinEdit
        '
        Me.JumlahSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "jumlah", True))
        Me.JumlahSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.JumlahSpinEdit.Location = New System.Drawing.Point(109, 317)
        Me.JumlahSpinEdit.Name = "JumlahSpinEdit"
        Me.JumlahSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JumlahSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.JumlahSpinEdit.TabIndex = 34
        '
        'Total_hargaSpinEdit
        '
        Me.Total_hargaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBindingSource, "total_harga", True))
        Me.Total_hargaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Total_hargaSpinEdit.Location = New System.Drawing.Point(109, 343)
        Me.Total_hargaSpinEdit.Name = "Total_hargaSpinEdit"
        Me.Total_hargaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Total_hargaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Total_hargaSpinEdit.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Pembelian"
        '
        'ProdukBindingSource
        '
        Me.ProdukBindingSource.DataMember = "produk"
        Me.ProdukBindingSource.DataSource = Me.OnlinesotreDataSet
        '
        'IdProdukTextEdit
        '
        Me.IdProdukTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukBindingSource, "idProduk", True))
        Me.IdProdukTextEdit.Location = New System.Drawing.Point(301, 165)
        Me.IdProdukTextEdit.Name = "IdProdukTextEdit"
        Me.IdProdukTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdProdukTextEdit.TabIndex = 38
        '
        'NamaTextEdit1
        '
        Me.NamaTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukBindingSource, "nama", True))
        Me.NamaTextEdit1.Location = New System.Drawing.Point(301, 191)
        Me.NamaTextEdit1.Name = "NamaTextEdit1"
        Me.NamaTextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextEdit1.TabIndex = 40
        '
        'HargaSpinEdit1
        '
        Me.HargaSpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukBindingSource, "harga", True))
        Me.HargaSpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HargaSpinEdit1.Location = New System.Drawing.Point(301, 217)
        Me.HargaSpinEdit1.Name = "HargaSpinEdit1"
        Me.HargaSpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HargaSpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.HargaSpinEdit1.TabIndex = 42
        '
        'UkuranTextEdit1
        '
        Me.UkuranTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukBindingSource, "ukuran", True))
        Me.UkuranTextEdit1.Location = New System.Drawing.Point(301, 243)
        Me.UkuranTextEdit1.Name = "UkuranTextEdit1"
        Me.UkuranTextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.UkuranTextEdit1.TabIndex = 44
        '
        'WarnaTextEdit1
        '
        Me.WarnaTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukBindingSource, "warna", True))
        Me.WarnaTextEdit1.Location = New System.Drawing.Point(301, 269)
        Me.WarnaTextEdit1.Name = "WarnaTextEdit1"
        Me.WarnaTextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.WarnaTextEdit1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Produk"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.OnlinesotreDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(436, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "User"
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AutoGenerateColumns = False
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.UserDataGridView.DataSource = Me.UserBindingSource
        Me.UserDataGridView.Location = New System.Drawing.Point(421, 161)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.UserDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "user"
        Me.DataGridViewTextBoxColumn1.HeaderText = "user"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "noHape"
        Me.DataGridViewTextBoxColumn3.HeaderText = "noHape"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'formDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.UserDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(IdProdukLabel)
        Me.Controls.Add(Me.IdProdukTextEdit)
        Me.Controls.Add(NamaLabel1)
        Me.Controls.Add(Me.NamaTextEdit1)
        Me.Controls.Add(HargaLabel1)
        Me.Controls.Add(Me.HargaSpinEdit1)
        Me.Controls.Add(UkuranLabel1)
        Me.Controls.Add(Me.UkuranTextEdit1)
        Me.Controls.Add(WarnaLabel1)
        Me.Controls.Add(Me.WarnaTextEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IdPembelianLabel)
        Me.Controls.Add(Me.IdPembelianTextEdit)
        Me.Controls.Add(TanggalLabel)
        Me.Controls.Add(Me.TanggalDateEdit)
        Me.Controls.Add(User_userLabel)
        Me.Controls.Add(Me.User_userTextEdit)
        Me.Controls.Add(Produk_idProdukLabel)
        Me.Controls.Add(Me.Produk_idProdukTextEdit)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextEdit)
        Me.Controls.Add(WarnaLabel)
        Me.Controls.Add(Me.WarnaTextEdit)
        Me.Controls.Add(UkuranLabel)
        Me.Controls.Add(Me.UkuranTextEdit)
        Me.Controls.Add(HargaLabel)
        Me.Controls.Add(Me.HargaSpinEdit)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahSpinEdit)
        Me.Controls.Add(Total_hargaLabel)
        Me.Controls.Add(Me.Total_hargaSpinEdit)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnlinesotreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdPembelianTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_userTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Produk_idProdukTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UkuranTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HargaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JumlahSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_hargaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdProdukTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HargaSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UkuranTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnaTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.PictureBox
    Friend WithEvents OnlinesotreDataSet As ONLINE_STORE.onlinesotreDataSet
    Friend WithEvents PembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianTableAdapter As ONLINE_STORE.onlinesotreDataSetTableAdapters.pembelianTableAdapter
    Friend WithEvents TableAdapterManager As ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProdukTableAdapter As ONLINE_STORE.onlinesotreDataSetTableAdapters.produkTableAdapter
    Friend WithEvents IdPembelianTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TanggalDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_userTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Produk_idProdukTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WarnaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UkuranTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HargaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents JumlahSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Total_hargaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProdukBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ONLINE_STORE.onlinesotreDataSetTableAdapters.userTableAdapter
    Friend WithEvents IdProdukTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NamaTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HargaSpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UkuranTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WarnaTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
