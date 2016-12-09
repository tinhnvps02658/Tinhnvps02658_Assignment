<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnstaikhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýTàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátRaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsbangdiem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemThôngTinSinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsmenu = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnstaikhoan, Me.mnsbangdiem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnstaikhoan
        '
        Me.mnstaikhoan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýTàiKhoảnToolStripMenuItem, Me.ThoátRaToolStripMenuItem})
        Me.mnstaikhoan.Name = "mnstaikhoan"
        Me.mnstaikhoan.ShowShortcutKeys = False
        Me.mnstaikhoan.Size = New System.Drawing.Size(72, 20)
        Me.mnstaikhoan.Text = "Hệ Thống"
        '
        'QuảnLýTàiKhoảnToolStripMenuItem
        '
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Name = "QuảnLýTàiKhoảnToolStripMenuItem"
        Me.QuảnLýTàiKhoảnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Text = "Đăng Nhập Lại"
        '
        'ThoátRaToolStripMenuItem
        '
        Me.ThoátRaToolStripMenuItem.Name = "ThoátRaToolStripMenuItem"
        Me.ThoátRaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ThoátRaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ThoátRaToolStripMenuItem.Text = "Thoát Ra"
        '
        'mnsbangdiem
        '
        Me.mnsbangdiem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSinhViênToolStripMenuItem, Me.XemThôngTinSinhViênToolStripMenuItem})
        Me.mnsbangdiem.Name = "mnsbangdiem"
        Me.mnsbangdiem.Size = New System.Drawing.Size(60, 20)
        Me.mnsbangdiem.Text = "Quản lý"
        '
        'ThêmSinhViênToolStripMenuItem
        '
        Me.ThêmSinhViênToolStripMenuItem.Name = "ThêmSinhViênToolStripMenuItem"
        Me.ThêmSinhViênToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ThêmSinhViênToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ThêmSinhViênToolStripMenuItem.Text = "Quản lý khách hàng"
        '
        'XemThôngTinSinhViênToolStripMenuItem
        '
        Me.XemThôngTinSinhViênToolStripMenuItem.Name = "XemThôngTinSinhViênToolStripMenuItem"
        Me.XemThôngTinSinhViênToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.XemThôngTinSinhViênToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.XemThôngTinSinhViênToolStripMenuItem.Text = "Quản lý nhân viên"
        '
        'tlsmenu
        '
        Me.tlsmenu.Location = New System.Drawing.Point(0, 24)
        Me.tlsmenu.Name = "tlsmenu"
        Me.tlsmenu.Size = New System.Drawing.Size(674, 25)
        Me.tlsmenu.TabIndex = 3
        Me.tlsmenu.Text = "ToolStrip1"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 433)
        Me.Controls.Add(Me.tlsmenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnstaikhoan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýTàiKhoảnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátRaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsmenu As System.Windows.Forms.ToolStrip
    Friend WithEvents mnsbangdiem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSinhViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemThôngTinSinhViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
