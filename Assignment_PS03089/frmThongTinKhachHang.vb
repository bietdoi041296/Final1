Imports System.Data.DataTable
Imports System.Data.SqlClient
Public Class frmThongTinKhachHang
    Dim database As New DataTable
    Dim ketnoi As String = "Data Source=SQL5014.HostBuddy.com;Initial Catalog=DB_9F5270_Final;User Id=DB_9F5270_Final_admin;Password=9873729765;"
    Dim conn As SqlConnection = New SqlConnection(ketnoi)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKH.Text = DataGridView1.Item(0, Click).Value
        txtTenKH.Text = DataGridView1.Item(1, Click).Value
        txtDiaChi.Text = DataGridView1.Item(2, Click).Value
        txtSDT.Text = DataGridView1.Item(3, Click).Value
        txtEmail.Text = DataGridView1.Item(4, Click).Value
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(ketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)
        conn.Open()
        Load.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub
    Private Sub btnTimKiem_Click_1(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim connect As SqlConnection = New SqlConnection(ketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG where MAKH=N'" & txtMaKH.Text & "'", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                database.Clear()
                DataGridView1.DataSource = Nothing
                xem.Fill(database)
                If database.Rows.Count > 0 Then
                    DataGridView1.DataSource = database.DefaultView
                    txtMaKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(ketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn cần nhập tên khách hàng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtDiaChi.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn cần nhập địa chỉ", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn cần nhập số điện thoại", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtEmail.Focus()
                            If txtEmail.Text = "" Then
                                MessageBox.Show("Bạn cần nhập Email", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                save.Parameters.AddWithValue("@TENKH", txtTenKH.Text)
                                save.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Thêm thành công")
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtDiaChi.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)
        database.Clear()
        refesh.Fill(database)
        DataGridView1.DataSource = database.DefaultView
        txtMaKH.Focus()
        btnXoa.Enabled = True
    End Sub

    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If result = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtTenKH.Text = Nothing
                    txtDiaChi.Text = Nothing
                    txtSDT.Text = Nothing
                    txtEmail.Text = Nothing
                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
        conn.Close()
        'làm mới bảng
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnSua_Click_1(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(ketnoi)
        Dim updatequery As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtDiaChi.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtEmail.Focus()
                            If txtEmail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                addupdate.Parameters.AddWithValue("@TENKH", txtTenKH.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                addupdate.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtDiaChi.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Function English() As Object
        Throw New NotImplementedException
    End Function

End Class
