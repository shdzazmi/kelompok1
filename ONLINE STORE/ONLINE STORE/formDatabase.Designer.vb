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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OnlinesotreDataSet = New ONLINE_STORE.onlinesotreDataSet()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.pembelianTableAdapter()
        Me.TableAdapterManager = New ONLINE_STORE.onlinesotreDataSetTableAdapters.TableAdapterManager()
        Me.ProdukTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.produkTableAdapter()
        Me.UserTableAdapter = New ONLINE_STORE.onlinesotreDataSetTableAdapters.userTableAdapter()
        Me.ProdukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdukDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hapusProduk = New System.Windows.Forms.Button()
        Me.refreshProduk = New System.Windows.Forms.Button()
        Me.simpanProduk = New System.Windows.Forms.Button()
        Me.editProduk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hapusUser = New System.Windows.Forms.Button()
        Me.refreshUser = New System.Windows.Forms.Button()
        Me.simpanUser = New System.Windows.Forms.Button()
        Me.editUser = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.PictureBox()
        CType(Me.OnlinesotreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ProdukBindingSource
        '
        Me.ProdukBindingSource.DataMember = "produk"
        Me.ProdukBindingSource.DataSource = Me.OnlinesotreDataSet
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.OnlinesotreDataSet
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AutoGenerateColumns = False
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.UserDataGridView.DataSource = Me.UserBindingSource
        Me.UserDataGridView.Enabled = False
        Me.UserDataGridView.Location = New System.Drawing.Point(21, 30)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(326, 220)
        Me.UserDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "user"
        Me.DataGridViewTextBoxColumn1.HeaderText = "USER"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PASSWORD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "noHape"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NO HP"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'ProdukDataGridView
        '
        Me.ProdukDataGridView.AutoGenerateColumns = False
        Me.ProdukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdukDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ProdukDataGridView.DataSource = Me.ProdukBindingSource
        Me.ProdukDataGridView.Enabled = False
        Me.ProdukDataGridView.Location = New System.Drawing.Point(19, 30)
        Me.ProdukDataGridView.Name = "ProdukDataGridView"
        Me.ProdukDataGridView.Size = New System.Drawing.Size(326, 220)
        Me.ProdukDataGridView.TabIndex = 55
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idProduk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nama"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NAMA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "harga"
        Me.DataGridViewTextBoxColumn6.HeaderText = "HARGA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ukuran"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UKURAN"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "warna"
        Me.DataGridViewTextBoxColumn8.HeaderText = "WARNA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hapusProduk)
        Me.GroupBox1.Controls.Add(Me.refreshProduk)
        Me.GroupBox1.Controls.Add(Me.simpanProduk)
        Me.GroupBox1.Controls.Add(Me.editProduk)
        Me.GroupBox1.Controls.Add(Me.ProdukDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 353)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUK"
        '
        'hapusProduk
        '
        Me.hapusProduk.Location = New System.Drawing.Point(19, 314)
        Me.hapusProduk.Name = "hapusProduk"
        Me.hapusProduk.Size = New System.Drawing.Size(75, 23)
        Me.hapusProduk.TabIndex = 63
        Me.hapusProduk.Text = "Hapus"
        Me.hapusProduk.UseVisualStyleBackColor = True
        '
        'refreshProduk
        '
        Me.refreshProduk.Location = New System.Drawing.Point(100, 314)
        Me.refreshProduk.Name = "refreshProduk"
        Me.refreshProduk.Size = New System.Drawing.Size(75, 23)
        Me.refreshProduk.TabIndex = 58
        Me.refreshProduk.Text = "Refresh"
        Me.refreshProduk.UseVisualStyleBackColor = True
        '
        'simpanProduk
        '
        Me.simpanProduk.Location = New System.Drawing.Point(100, 285)
        Me.simpanProduk.Name = "simpanProduk"
        Me.simpanProduk.Size = New System.Drawing.Size(75, 23)
        Me.simpanProduk.TabIndex = 57
        Me.simpanProduk.Text = "Simpan"
        Me.simpanProduk.UseVisualStyleBackColor = True
        '
        'editProduk
        '
        Me.editProduk.Location = New System.Drawing.Point(19, 285)
        Me.editProduk.Name = "editProduk"
        Me.editProduk.Size = New System.Drawing.Size(75, 23)
        Me.editProduk.TabIndex = 56
        Me.editProduk.Text = "Edit"
        Me.editProduk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hapusUser)
        Me.GroupBox2.Controls.Add(Me.refreshUser)
        Me.GroupBox2.Controls.Add(Me.UserDataGridView)
        Me.GroupBox2.Controls.Add(Me.simpanUser)
        Me.GroupBox2.Controls.Add(Me.editUser)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(385, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 353)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USER"
        '
        'hapusUser
        '
        Me.hapusUser.Location = New System.Drawing.Point(21, 314)
        Me.hapusUser.Name = "hapusUser"
        Me.hapusUser.Size = New System.Drawing.Size(75, 23)
        Me.hapusUser.TabIndex = 62
        Me.hapusUser.Text = "Hapus"
        Me.hapusUser.UseVisualStyleBackColor = True
        '
        'refreshUser
        '
        Me.refreshUser.Location = New System.Drawing.Point(102, 314)
        Me.refreshUser.Name = "refreshUser"
        Me.refreshUser.Size = New System.Drawing.Size(75, 23)
        Me.refreshUser.TabIndex = 61
        Me.refreshUser.Text = "Refresh"
        Me.refreshUser.UseVisualStyleBackColor = True
        '
        'simpanUser
        '
        Me.simpanUser.Location = New System.Drawing.Point(102, 285)
        Me.simpanUser.Name = "simpanUser"
        Me.simpanUser.Size = New System.Drawing.Size(75, 23)
        Me.simpanUser.TabIndex = 60
        Me.simpanUser.Text = "Simpan"
        Me.simpanUser.UseVisualStyleBackColor = True
        '
        'editUser
        '
        Me.editUser.Location = New System.Drawing.Point(21, 285)
        Me.editUser.Name = "editUser"
        Me.editUser.Size = New System.Drawing.Size(75, 23)
        Me.editUser.TabIndex = 59
        Me.editUser.Text = "Edit"
        Me.editUser.UseVisualStyleBackColor = True
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
        'formDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.OnlinesotreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProdukBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ONLINE_STORE.onlinesotreDataSetTableAdapters.userTableAdapter
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProdukDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents refreshProduk As System.Windows.Forms.Button
    Friend WithEvents simpanProduk As System.Windows.Forms.Button
    Friend WithEvents editProduk As System.Windows.Forms.Button
    Friend WithEvents refreshUser As System.Windows.Forms.Button
    Friend WithEvents simpanUser As System.Windows.Forms.Button
    Friend WithEvents editUser As System.Windows.Forms.Button
    Friend WithEvents hapusUser As System.Windows.Forms.Button
    Friend WithEvents hapusProduk As System.Windows.Forms.Button
End Class
