Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim chuoiketnoi As String = "workstation id=tinhnvps02658.mssql.somee.com;packet size=4096;user id=tinhnvps02658_SQLLogin_2;pwd=1o131o9irf;data source=tinhnvps02658.mssql.somee.com;persist security info=False;initial catalog=tinhnvps02658"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("Select * from NhanVien where MaNhanVien='" & txtuser.Text & "' And password='" & txtpw.Text & "' ", ketnoi)
        Dim tb As New DataTable

        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                Me.Close()
                frmmain.show()

            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu")
                txtuser.Clear()
                txtpw.Clear()
                txtuser.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub



    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class