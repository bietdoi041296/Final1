Imports System.Threading.Thread
Imports System.Globalization
Public Class Language

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CurrentThread.CurrentUICulture = New CultureInfo("EN")
        Dim frmMainEN As New frmMain
        frmMainEN.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentThread.CurrentUICulture = New CultureInfo("VI")
        Dim frmMainVI As New frmMain
        frmMainVI.Show()
    End Sub
End Class