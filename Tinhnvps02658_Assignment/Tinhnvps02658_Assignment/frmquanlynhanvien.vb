Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmquanlynhanvien
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=tinhnvps02658.mssql.somee.com;packet size=4096;user id=tinhnvps02658_SQLLogin_2;pwd=1o131o9irf;data source=tinhnvps02658.mssql.somee.com;persist security info=False;initial catalog=tinhnvps02658"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
    

   
    Private Sub frmquanlynhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvdanhsach.DataSource = database.DefaultView

    End Sub

    Private Sub dgvdanhsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdanhsach.CellContentClick
        Dim index As Integer = dgvdanhsach.CurrentCell.RowIndex
        txtmanhanvien.Text = dgvdanhsach.Item(0, index).Value
        txtpw.Text = dgvdanhsach.Item(1, index).Value
        txttennhanvien.Text = dgvdanhsach.Item(2, index).Value
        txtmakhachhang.Text = dgvdanhsach.Item(3, index).Value

    End Sub



    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into NhanVien values (@MaNhanVien,@password,@TenNhanVien,@HoaDon_MaHoaDon)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text)
            them.Parameters.AddWithValue("@password", txtpw.Text)
            them.Parameters.AddWithValue("@TenNhanVien", txttennhanvien.Text)
            them.Parameters.AddWithValue("@HoaDon_MaHoaDon", txtmakhachhang.Text)

            MessageBox.Show("Thêm nhân viên thành công!")
            'Exucute là ghi dữ liệu vào Database'
            them.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")

        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub

    Private Sub Loaddata()
        database.Clear()
        dgvdanhsach.DataSource = database
        dgvdanhsach.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)

        connect.Open()
        Query1.Fill(database)
        dgvdanhsach.DataSource = database.DefaultView
    End Sub




    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from NhanVien where MaNhanVien = @MaNhanVien"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub

    Private Sub lbmakhachhang_Click(sender As Object, e As EventArgs) Handles lbmakhachhang.Click

    End Sub
End Class