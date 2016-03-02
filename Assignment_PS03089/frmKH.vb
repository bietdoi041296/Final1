Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKH
        Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=SQL5014.HostBuddy.com;Initial Catalog=DB_9F5270_Final;User Id=DB_9F5270_Final_admin;Password=9873729765;"
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click_1(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG where MAKH='" & txtMaKH.Text & "'", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                DataGridView1.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    DataGridView1.DataSource = db.DefaultView
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

    Private Sub btnXemTatCa_Click_1(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        Dim hienthi As New Class1
        DataGridView1.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub MdButton1_Click(sender As Object, e As EventArgs) Handles MdButton1.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class