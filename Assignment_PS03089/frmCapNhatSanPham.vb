Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapNhatSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=SQL5014.HostBuddy.com;Initial Catalog=DB_9F5270_Final;User Id=DB_9F5270_Final_admin;Password=9873729765;"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMaSP.Text = dgvSanpham.Item(0, click).Value
        txtTenSP.Text = dgvSanpham.Item(1, click).Value
        txtMaLoai.Text = dgvSanpham.Item(2, click).Value
        txtTenLoai.Text = dgvSanpham.Item(3, click).Value
        txtSoluong.Text = dgvSanpham.Item(4, click).Value
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnTimKiem_Click_1(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP='" & txtMaSP.Text & "'", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@SOLUONG)"
        Dim query1 As String = "insert into LOAISANPHAM values(@MALOAI,@MASP,@TENLOAI)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Dim save1 As SqlCommand = New SqlCommand(query1, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtMaLoai.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMaLoai.Focus()
                        If txtSoluong.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
                            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
                            save.ExecuteNonQuery()
                            save1.Parameters.AddWithValue("@MALOAI", txtMaLoai.Text)
                            save1.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                            save1.Parameters.AddWithValue("@TENLOAI", txtTenLoai.Text)
                            save1.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaSP.Text = Nothing
                            txtMaLoai.Text = Nothing
                            txtSoluong.Text = Nothing
                            txtTenSP.Text = Nothing
                            txtTenLoai.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SANPHAM set MASP=@MASP, TENSP=@TENSP, SOLUONG=@SOLUONG where MASP=@MASP"
        Dim updatequery1 As String = "update LOAISANPHAM set MALOAI=@MALOAI, MASP=@MASP, TENLOAI=@TENLOAI where MASP=@MASP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        Dim addupdate1 As SqlCommand = New SqlCommand(updatequery1, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMaLoai.Focus()
                    If txtMaLoai.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSoluong.Focus()
                        If txtSoluong.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                            addupdate.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
                            addupdate.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
                            addupdate.ExecuteNonQuery()
                            addupdate.Parameters.AddWithValue("@MALOAI", txtMaLoai.Text)
                            addupdate.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                            addupdate.Parameters.AddWithValue("@TENLOAI", txtTenLoai.Text)
                            addupdate1.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMaSP.Text = Nothing
                            txtTenSP.Text = Nothing
                            txtMaLoai.Text = Nothing
                            txtTenLoai.Text = Nothing
                            txtSoluong.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SANPHAM where MASP=@MASP delete from LOAISANPHAM where MASP=@MASP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaSP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMaSP.Text = Nothing
                    txtTenSP.Text = Nothing
                    txtMaLoai.Text = Nothing
                    txtTenLoai.Text = Nothing
                    txtSoluong.Text = Nothing
                    txtMaSP.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
        conn.Close()
        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        Me.Close()
    End Sub
End Class