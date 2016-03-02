<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKH))
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MdButton1 = New Assignment_PS03089.MDButton()
        Me.btnXemTatCa = New Assignment_PS03089.MDButton()
        Me.btnXem = New Assignment_PS03089.MDButton()
        Me.MdLabel1 = New Assignment_PS03089.MDLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaKH
        '
        resources.ApplyResources(Me.txtMaKH, "txtMaKH")
        Me.txtMaKH.Name = "txtMaKH"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'MdButton1
        '
        Me.MdButton1.BackColor = System.Drawing.Color.Transparent
        Me.MdButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MdButton1.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.MdButton1, "MdButton1")
        Me.MdButton1.Name = "MdButton1"
        Me.MdButton1.Rounded = False
        Me.MdButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnXemTatCa
        '
        Me.btnXemTatCa.BackColor = System.Drawing.Color.Transparent
        Me.btnXemTatCa.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnXemTatCa.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnXemTatCa, "btnXemTatCa")
        Me.btnXemTatCa.Name = "btnXemTatCa"
        Me.btnXemTatCa.Rounded = False
        Me.btnXemTatCa.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnXem
        '
        Me.btnXem.BackColor = System.Drawing.Color.Transparent
        Me.btnXem.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnXem.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnXem, "btnXem")
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Rounded = False
        Me.btnXem.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MdLabel1
        '
        resources.ApplyResources(Me.MdLabel1, "MdLabel1")
        Me.MdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MdLabel1.ForeColor = System.Drawing.Color.White
        Me.MdLabel1.Name = "MdLabel1"
        '
        'frmKH
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment_PS03089.My.Resources.Resources._18mna3ozupme8jpg__1_
        Me.Controls.Add(Me.MdLabel1)
        Me.Controls.Add(Me.MdButton1)
        Me.Controls.Add(Me.btnXemTatCa)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtMaKH)
        Me.Name = "frmKH"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnXem As Assignment_PS03089.MDButton
    Friend WithEvents btnXemTatCa As Assignment_PS03089.MDButton
    Friend WithEvents MdButton1 As Assignment_PS03089.MDButton
    Friend WithEvents MdLabel1 As Assignment_PS03089.MDLabel
End Class
