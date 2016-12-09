<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.imgloading = New System.Windows.Forms.PictureBox()
        Me.prbloading = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgloading
        '
        Me.imgloading.Image = CType(resources.GetObject("imgloading.Image"), System.Drawing.Image)
        Me.imgloading.Location = New System.Drawing.Point(0, 1)
        Me.imgloading.Name = "imgloading"
        Me.imgloading.Size = New System.Drawing.Size(622, 371)
        Me.imgloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgloading.TabIndex = 0
        Me.imgloading.TabStop = False
        '
        'prbloading
        '
        Me.prbloading.ForeColor = System.Drawing.Color.LawnGreen
        Me.prbloading.Location = New System.Drawing.Point(0, 361)
        Me.prbloading.Name = "prbloading"
        Me.prbloading.Size = New System.Drawing.Size(622, 37)
        Me.prbloading.TabIndex = 1
        Me.prbloading.Value = 30
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.prbloading)
        Me.Controls.Add(Me.imgloading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.imgloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgloading As System.Windows.Forms.PictureBox
    Friend WithEvents prbloading As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
