<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbluser
        '
        Me.lbluser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(157, 21)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(84, 13)
        Me.lbluser.TabIndex = 0
        Me.lbluser.Text = "Tên Tài Khoản :"
        '
        'lblpw
        '
        Me.lblpw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpw.AutoSize = True
        Me.lblpw.Location = New System.Drawing.Point(157, 55)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(59, 13)
        Me.lblpw.TabIndex = 0
        Me.lblpw.Text = "Mật Khẩu :"
        '
        'txtuser
        '
        Me.txtuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtuser.Location = New System.Drawing.Point(247, 18)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(195, 20)
        Me.txtuser.TabIndex = 1
        '
        'txtpw
        '
        Me.txtpw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpw.Location = New System.Drawing.Point(247, 52)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(195, 20)
        Me.txtpw.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(278, 90)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 33)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Đăng Nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(371, 90)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(71, 33)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Thoát Ra"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblpw)
        Me.Controls.Add(Me.lbluser)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập phần mềm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpw As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
