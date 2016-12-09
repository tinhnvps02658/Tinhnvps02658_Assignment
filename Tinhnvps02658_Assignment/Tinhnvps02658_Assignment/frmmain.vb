Public Class frmmain

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome.ShowDialog()
        frmLogin.ShowDialog()

    End Sub



    Private Sub QuảnLýTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTàiKhoảnToolStripMenuItem.Click
        frmLogin.ShowDialog()
    End Sub


    Private Sub ThoátRaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátRaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub XemThôngTinSinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemThôngTinSinhViênToolStripMenuItem.Click
        frmquanlynhanvien.ShowDialog()

    End Sub

    Private Sub ThêmSinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSinhViênToolStripMenuItem.Click
        frmquanlykhachhang.ShowDialog()

    End Sub
End Class