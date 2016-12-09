Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmquanlykhachhang
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online'
    'Tạo chuỗi kết nối để kết nối tới Database Online'
    Dim chuoiconnect As String = "workstation id=tinhnvps02658.mssql.somee.com;packet size=4096;user id=tinhnvps02658_SQLLogin_2;pwd=1o131o9irf;data source=tinhnvps02658.mssql.somee.com;persist security info=False;initial catalog=tinhnvps02658"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)


    Private Sub dgvdanhsach1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdanhsach1.CellContentClick
        Dim index As Integer = dgvdanhsach1.CurrentCell.RowIndex
        txtmakhachhang1.Text = dgvdanhsach1.Item(0, index).Value
        txtpw1.Text = dgvdanhsach1.Item(1, index).Value
        txtsdt.Text = dgvdanhsach1.Item(2, index).Value
        txtdiachi.Text = dgvdanhsach1.Item(3, index).Value
    End Sub

    Private Sub frmquanlykhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online'
        ' Câu truy vấn để get dữ liệu'
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database'
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview'
        dgvdanhsach1.DataSource = database.DefaultView
    End Sub





    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into'
        Dim Add As String = "insert into KhachHang values (@MaKhachHang,@TenKhachHang,@SoDT,@DiaChi)"
        'Tạo đối tượng để thực thi câu truy vấn với DB online'
        Dim them As New SqlCommand(Add, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng'
            them.Parameters.AddWithValue("@MaKhachHang", txtmakhachhang1.Text)
            them.Parameters.AddWithValue("@TenKhachHang", txtpw1.Text)
            them.Parameters.AddWithValue("@SoDT", txtsdt.Text)
            them.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)

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
        dgvdanhsach1.DataSource = database
        dgvdanhsach1.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)

        connect.Open()
        Query1.Fill(database)
        dgvdanhsach1.DataSource = database.DefaultView
    End Sub




    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim delete As String = "Delete from NhanVien where MaKhachHang = @MaKhachHang"
        Dim xoa As New SqlCommand(delete, connect)
        Try
            xoa.Parameters.AddWithValue("@MaKhachHang", txtmakhachhang1.Text)
            xoa.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub
End Class