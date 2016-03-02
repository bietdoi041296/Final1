<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemSanPham))
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.btnXem = New Assignment_PS03089.MDButton()
        Me.btnXemTatCa = New Assignment_PS03089.MDButton()
        Me.btnQuaylai = New Assignment_PS03089.MDButton()
        Me.MdLabel1 = New Assignment_PS03089.MDLabel()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaSP
        '
        resources.ApplyResources(Me.txtMaSP, "txtMaSP")
        Me.txtMaSP.Name = "txtMaSP"
        '
        'dgvXemsp
        '
        resources.ApplyResources(Me.dgvXemsp, "dgvXemsp")
        Me.dgvXemsp.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Name = "dgvXemsp"
        '
        'btnXem
        '
        resources.ApplyResources(Me.btnXem, "btnXem")
        Me.btnXem.BackColor = System.Drawing.Color.Transparent
        Me.btnXem.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnXem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Rounded = False
        Me.btnXem.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnXemTatCa
        '
        resources.ApplyResources(Me.btnXemTatCa, "btnXemTatCa")
        Me.btnXemTatCa.BackColor = System.Drawing.Color.Transparent
        Me.btnXemTatCa.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnXemTatCa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXemTatCa.Name = "btnXemTatCa"
        Me.btnXemTatCa.Rounded = False
        Me.btnXemTatCa.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnQuaylai
        '
        resources.ApplyResources(Me.btnQuaylai, "btnQuaylai")
        Me.btnQuaylai.BackColor = System.Drawing.Color.Transparent
        Me.btnQuaylai.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnQuaylai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuaylai.Name = "btnQuaylai"
        Me.btnQuaylai.Rounded = False
        Me.btnQuaylai.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MdLabel1
        '
        resources.ApplyResources(Me.MdLabel1, "MdLabel1")
        Me.MdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MdLabel1.ForeColor = System.Drawing.Color.White
        Me.MdLabel1.Name = "MdLabel1"
        '
        'frmXemSanPham
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment_PS03089.My.Resources.Resources._18mna3ozupme8jpg__1_
        Me.Controls.Add(Me.MdLabel1)
        Me.Controls.Add(Me.btnQuaylai)
        Me.Controls.Add(Me.btnXemTatCa)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.txtMaSP)
        Me.Name = "frmXemSanPham"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnXem As Assignment_PS03089.MDButton
    Friend WithEvents btnXemTatCa As Assignment_PS03089.MDButton
    Friend WithEvents btnQuaylai As Assignment_PS03089.MDButton
    Friend WithEvents MdLabel1 As Assignment_PS03089.MDLabel
End Class
