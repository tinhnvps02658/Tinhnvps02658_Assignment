<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlynhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmquanlynhanvien))
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.grquanlynhanvien = New System.Windows.Forms.GroupBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.lbmakhachhang = New System.Windows.Forms.Label()
        Me.txttennhanvien = New System.Windows.Forms.TextBox()
        Me.lbtennhanvien = New System.Windows.Forms.Label()
        Me.txtmanhanvien = New System.Windows.Forms.TextBox()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.lbmanhanvien = New System.Windows.Forms.Label()
        Me.dgvdanhsach = New System.Windows.Forms.DataGridView()
        Me.grquanlynhanvien.SuspendLayout()
        CType(Me.dgvdanhsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnxoa
        '
        Me.btnxoa.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(627, 281)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(87, 34)
        Me.btnxoa.TabIndex = 1
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnthem.Image = CType(resources.GetObject("btnthem.Image"), System.Drawing.Image)
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(520, 281)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 34)
        Me.btnthem.TabIndex = 1
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'grquanlynhanvien
        '
        Me.grquanlynhanvien.Controls.Add(Me.txtpw)
        Me.grquanlynhanvien.Controls.Add(Me.txtmakhachhang)
        Me.grquanlynhanvien.Controls.Add(Me.lbmakhachhang)
        Me.grquanlynhanvien.Controls.Add(Me.txttennhanvien)
        Me.grquanlynhanvien.Controls.Add(Me.lbtennhanvien)
        Me.grquanlynhanvien.Controls.Add(Me.txtmanhanvien)
        Me.grquanlynhanvien.Controls.Add(Me.lblpw)
        Me.grquanlynhanvien.Controls.Add(Me.lbmanhanvien)
        Me.grquanlynhanvien.Location = New System.Drawing.Point(12, 34)
        Me.grquanlynhanvien.Name = "grquanlynhanvien"
        Me.grquanlynhanvien.Size = New System.Drawing.Size(224, 231)
        Me.grquanlynhanvien.TabIndex = 2
        Me.grquanlynhanvien.TabStop = False
        Me.grquanlynhanvien.Text = "Điền thông tin nhân viên :"
        '
        'txtpw
        '
        Me.txtpw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpw.Location = New System.Drawing.Point(96, 85)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(122, 20)
        Me.txtpw.TabIndex = 10
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtmakhachhang.Location = New System.Drawing.Point(96, 192)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(122, 20)
        Me.txtmakhachhang.TabIndex = 9
        '
        'lbmakhachhang
        '
        Me.lbmakhachhang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbmakhachhang.AutoSize = True
        Me.lbmakhachhang.Location = New System.Drawing.Point(6, 195)
        Me.lbmakhachhang.Name = "lbmakhachhang"
        Me.lbmakhachhang.Size = New System.Drawing.Size(74, 13)
        Me.lbmakhachhang.TabIndex = 8
        Me.lbmakhachhang.Text = "Mã Hóa Đơn :"
        '
        'txttennhanvien
        '
        Me.txttennhanvien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttennhanvien.Location = New System.Drawing.Point(96, 139)
        Me.txttennhanvien.Name = "txttennhanvien"
        Me.txttennhanvien.Size = New System.Drawing.Size(122, 20)
        Me.txttennhanvien.TabIndex = 7
        '
        'lbtennhanvien
        '
        Me.lbtennhanvien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbtennhanvien.AutoSize = True
        Me.lbtennhanvien.Location = New System.Drawing.Point(6, 142)
        Me.lbtennhanvien.Name = "lbtennhanvien"
        Me.lbtennhanvien.Size = New System.Drawing.Size(85, 13)
        Me.lbtennhanvien.TabIndex = 6
        Me.lbtennhanvien.Text = "Tên Nhân Viên :"
        '
        'txtmanhanvien
        '
        Me.txtmanhanvien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtmanhanvien.Location = New System.Drawing.Point(96, 35)
        Me.txtmanhanvien.Name = "txtmanhanvien"
        Me.txtmanhanvien.Size = New System.Drawing.Size(122, 20)
        Me.txtmanhanvien.TabIndex = 5
        '
        'lblpw
        '
        Me.lblpw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpw.AutoSize = True
        Me.lblpw.Location = New System.Drawing.Point(6, 92)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(59, 13)
        Me.lblpw.TabIndex = 2
        Me.lblpw.Text = "Password :"
        '
        'lbmanhanvien
        '
        Me.lbmanhanvien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbmanhanvien.AutoSize = True
        Me.lbmanhanvien.Location = New System.Drawing.Point(6, 42)
        Me.lbmanhanvien.Name = "lbmanhanvien"
        Me.lbmanhanvien.Size = New System.Drawing.Size(81, 13)
        Me.lbmanhanvien.TabIndex = 3
        Me.lbmanhanvien.Text = "Mã Nhân Viên :"
        '
        'dgvdanhsach
        '
        Me.dgvdanhsach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsach.Location = New System.Drawing.Point(274, 44)
        Me.dgvdanhsach.Name = "dgvdanhsach"
        Me.dgvdanhsach.Size = New System.Drawing.Size(440, 231)
        Me.dgvdanhsach.TabIndex = 3
        '
        'frmquanlynhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 332)
        Me.Controls.Add(Me.dgvdanhsach)
        Me.Controls.Add(Me.grquanlynhanvien)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxoa)
        Me.Name = "frmquanlynhanvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ NHÂN VIÊN"
        Me.grquanlynhanvien.ResumeLayout(False)
        Me.grquanlynhanvien.PerformLayout()
        CType(Me.dgvdanhsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents grquanlynhanvien As System.Windows.Forms.GroupBox
    Friend WithEvents txttennhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lbtennhanvien As System.Windows.Forms.Label
    Friend WithEvents txtmanhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lblpw As System.Windows.Forms.Label
    Friend WithEvents lbmanhanvien As System.Windows.Forms.Label
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents lbmakhachhang As System.Windows.Forms.Label
    Friend WithEvents dgvdanhsach As System.Windows.Forms.DataGridView
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
End Class
