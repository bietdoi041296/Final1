
Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmKH.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmThongTinKhachHang.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmXemSanPham.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmCapNhatSanPham.Show()
        Me.Hide()
    End Sub
End Class