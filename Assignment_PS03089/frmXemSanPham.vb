Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=SQL5014.HostBuddy.com;Initial Catalog=DB_9F5270_Final;User Id=DB_9F5270_Final_admin;Password=9873729765;"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP ='" & txtMaSP.Text & "' ", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXemTatCa_Click_1(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btnQuaylai_Click(sender As Object, e As EventArgs) Handles btnQuaylai.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmXemSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class