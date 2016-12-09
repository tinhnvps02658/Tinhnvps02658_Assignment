<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlykhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmquanlykhachhang))
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.lbtennhanvien = New System.Windows.Forms.Label()
        Me.txtpw1 = New System.Windows.Forms.TextBox()
        Me.txtmakhachhang1 = New System.Windows.Forms.TextBox()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.lblmakhachhang = New System.Windows.Forms.Label()
        Me.dgvdanhsach1 = New System.Windows.Forms.DataGridView()
        Me.grquanlykhachhang = New System.Windows.Forms.GroupBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        CType(Me.dgvdanhsach1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grquanlykhachhang.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdiachi
        '
        Me.txtdiachi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtdiachi.Location = New System.Drawing.Point(96, 192)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(122, 20)
        Me.txtdiachi.TabIndex = 9
        '
        'lbldiachi
        '
        Me.lbldiachi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(6, 195)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(50, 13)
        Me.lbldiachi.TabIndex = 8
        Me.lbldiachi.Text = "Địa Chỉ  :"
        '
        'txtsdt
        '
        Me.txtsdt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsdt.Location = New System.Drawing.Point(96, 139)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(122, 20)
        Me.txtsdt.TabIndex = 7
        '
        'lbtennhanvien
        '
        Me.lbtennhanvien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbtennhanvien.AutoSize = True
        Me.lbtennhanvien.Location = New System.Drawing.Point(6, 142)
        Me.lbtennhanvien.Name = "lbtennhanvien"
        Me.lbtennhanvien.Size = New System.Drawing.Size(35, 13)
        Me.lbtennhanvien.TabIndex = 6
        Me.lbtennhanvien.Text = "SDT :"
        '
        'txtpw1
        '
        Me.txtpw1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpw1.Location = New System.Drawing.Point(96, 89)
        Me.txtpw1.Name = "txtpw1"
        Me.txtpw1.Size = New System.Drawing.Size(122, 20)
        Me.txtpw1.TabIndex = 4
        '
        'txtmakhachhang1
        '
        Me.txtmakhachhang1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtmakhachhang1.Location = New System.Drawing.Point(96, 39)
        Me.txtmakhachhang1.Name = "txtmakhachhang1"
        Me.txtmakhachhang1.Size = New System.Drawing.Size(122, 20)
        Me.txtmakhachhang1.TabIndex = 5
        '
        'lblpw
        '
        Me.lblpw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpw.AutoSize = True
        Me.lblpw.Location = New System.Drawing.Point(6, 92)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(95, 13)
        Me.lblpw.TabIndex = 2
        Me.lblpw.Text = "Tên Khách Hàng :"
        '
        'lblmakhachhang
        '
        Me.lblmakhachhang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmakhachhang.AutoSize = True
        Me.lblmakhachhang.Location = New System.Drawing.Point(6, 42)
        Me.lblmakhachhang.Name = "lblmakhachhang"
        Me.lblmakhachhang.Size = New System.Drawing.Size(91, 13)
        Me.lblmakhachhang.TabIndex = 3
        Me.lblmakhachhang.Text = "Mã Khách Hàng :"
        '
        'dgvdanhsach1
        '
        Me.dgvdanhsach1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdanhsach1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsach1.Location = New System.Drawing.Point(260, 45)
        Me.dgvdanhsach1.Name = "dgvdanhsach1"
        Me.dgvdanhsach1.Size = New System.Drawing.Size(423, 216)
        Me.dgvdanhsach1.TabIndex = 5
        '
        'grquanlykhachhang
        '
        Me.grquanlykhachhang.Controls.Add(Me.txtdiachi)
        Me.grquanlykhachhang.Controls.Add(Me.lbldiachi)
        Me.grquanlykhachhang.Controls.Add(Me.txtsdt)
        Me.grquanlykhachhang.Controls.Add(Me.lbtennhanvien)
        Me.grquanlykhachhang.Controls.Add(Me.txtpw1)
        Me.grquanlykhachhang.Controls.Add(Me.txtmakhachhang1)
        Me.grquanlykhachhang.Controls.Add(Me.lblpw)
        Me.grquanlykhachhang.Controls.Add(Me.lblmakhachhang)
        Me.grquanlykhachhang.Location = New System.Drawing.Point(21, 37)
        Me.grquanlykhachhang.Name = "grquanlykhachhang"
        Me.grquanlykhachhang.Size = New System.Drawing.Size(233, 224)
        Me.grquanlykhachhang.TabIndex = 4
        Me.grquanlykhachhang.TabStop = False
        Me.grquanlykhachhang.Text = "Điền thông tin khách hàng :"
        '
        'btnthem
        '
        Me.btnthem.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnthem.Image = CType(resources.GetObject("btnthem.Image"), System.Drawing.Image)
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(464, 278)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 34)
        Me.btnthem.TabIndex = 6
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(596, 278)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(87, 34)
        Me.btnxoa.TabIndex = 7
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'frmquanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 324)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.dgvdanhsach1)
        Me.Controls.Add(Me.grquanlykhachhang)
        Me.Name = "frmquanlykhachhang"
        Me.Text = "QUẢN LÝ KHÁCH HÀNG"
        CType(Me.dgvdanhsach1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grquanlykhachhang.ResumeLayout(False)
        Me.grquanlykhachhang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents lbtennhanvien As System.Windows.Forms.Label
    Friend WithEvents txtpw1 As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhachhang1 As System.Windows.Forms.TextBox
    Friend WithEvents lblpw As System.Windows.Forms.Label
    Friend WithEvents lblmakhachhang As System.Windows.Forms.Label
    Friend WithEvents dgvdanhsach1 As System.Windows.Forms.DataGridView
    Friend WithEvents grquanlykhachhang As System.Windows.Forms.GroupBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
End Class
