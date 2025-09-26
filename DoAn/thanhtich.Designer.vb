<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thanhtich
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
        txtMaHS = New TextBox()
        lablemsv = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        btnTimKiem = New Button()
        btnLuu = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtDiemTB = New TextBox()
        cboHanhKiem = New ComboBox()
        Label3 = New Label()
        txtXepLoai = New TextBox()
        Label4 = New Label()
        txtHoTen = New TextBox()
        btnSua = New Button()
        btnXoa = New Button()
        txtNhanXet = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtMaHS
        ' 
        txtMaHS.Location = New Point(118, 24)
        txtMaHS.Multiline = True
        txtMaHS.Name = "txtMaHS"
        txtMaHS.Size = New Size(123, 27)
        txtMaHS.TabIndex = 4
        ' 
        ' lablemsv
        ' 
        lablemsv.AutoSize = True
        lablemsv.BackColor = Color.White
        lablemsv.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lablemsv.ForeColor = Color.Black
        lablemsv.Location = New Point(25, 25)
        lablemsv.Name = "lablemsv"
        lablemsv.Size = New Size(87, 17)
        lablemsv.TabIndex = 3
        lablemsv.Text = "Mã học sinh:"
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnTimKiem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnTimKiem.Location = New Point(37, 68)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(88, 27)
        btnTimKiem.TabIndex = 5
        btnTimKiem.Text = "Tìm kiếm"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btnLuu
        ' 
        btnLuu.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnLuu.ForeColor = Color.Black
        btnLuu.Location = New Point(141, 67)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(88, 29)
        btnLuu.TabIndex = 26
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(288, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 17)
        Label1.TabIndex = 27
        Label1.Text = "Điểm Trung Bình:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(288, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 17)
        Label2.TabIndex = 28
        Label2.Text = "Hạch Kiểm:"
        ' 
        ' txtDiemTB
        ' 
        txtDiemTB.Location = New Point(448, 72)
        txtDiemTB.Multiline = True
        txtDiemTB.Name = "txtDiemTB"
        txtDiemTB.Size = New Size(123, 27)
        txtDiemTB.TabIndex = 29
        ' 
        ' cboHanhKiem
        ' 
        cboHanhKiem.FormattingEnabled = True
        cboHanhKiem.Items.AddRange(New Object() {"Tốt", "Khá", "Trung Bình", "Yếu"})
        cboHanhKiem.Location = New Point(448, 123)
        cboHanhKiem.Name = "cboHanhKiem"
        cboHanhKiem.Size = New Size(123, 23)
        cboHanhKiem.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(288, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 17)
        Label3.TabIndex = 31
        Label3.Text = "Xếp loại:"
        ' 
        ' txtXepLoai
        ' 
        txtXepLoai.Location = New Point(448, 168)
        txtXepLoai.Multiline = True
        txtXepLoai.Name = "txtXepLoai"
        txtXepLoai.Size = New Size(123, 27)
        txtXepLoai.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(288, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 17)
        Label4.TabIndex = 33
        Label4.Text = "Họ và Tên:"
        ' 
        ' txtHoTen
        ' 
        txtHoTen.Location = New Point(448, 32)
        txtHoTen.Multiline = True
        txtHoTen.Name = "txtHoTen"
        txtHoTen.Size = New Size(123, 27)
        txtHoTen.TabIndex = 34
        ' 
        ' btnSua
        ' 
        btnSua.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnSua.ForeColor = Color.Lime
        btnSua.Location = New Point(37, 112)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(88, 28)
        btnSua.TabIndex = 35
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnXoa.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnXoa.Location = New Point(141, 111)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(88, 29)
        btnXoa.TabIndex = 36
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' txtNhanXet
        ' 
        txtNhanXet.Location = New Point(448, 216)
        txtNhanXet.Multiline = True
        txtNhanXet.Name = "txtNhanXet"
        txtNhanXet.Size = New Size(326, 186)
        txtNhanXet.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(288, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 17)
        Label5.TabIndex = 38
        Label5.Text = "Nhận xét của giáo viên:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button1.Location = New Point(97, 157)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 29)
        Button1.TabIndex = 39
        Button1.Text = "Thoát"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' thanhtich
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(818, 450)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(txtNhanXet)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(txtHoTen)
        Controls.Add(Label4)
        Controls.Add(txtXepLoai)
        Controls.Add(Label3)
        Controls.Add(cboHanhKiem)
        Controls.Add(txtDiemTB)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLuu)
        Controls.Add(btnTimKiem)
        Controls.Add(txtMaHS)
        Controls.Add(lablemsv)
        Name = "thanhtich"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMaHS As TextBox
    Friend WithEvents lablemsv As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiemTB As TextBox
    Friend WithEvents cboHanhKiem As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtXepLoai As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtNhanXet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
