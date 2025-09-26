<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thongtin
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
        lablemsv = New Label()
        txtMaHS = New TextBox()
        btnTimKiem = New Button()
        btnXoa = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtHoTen = New TextBox()
        txtNgaySinh = New TextBox()
        txtChieuCao = New TextBox()
        txtCanNang = New TextBox()
        txtQueQuan = New TextBox()
        txtDiaChi = New TextBox()
        txtTenBo = New TextBox()
        txtSDTBo = New TextBox()
        txtTenMe = New TextBox()
        txtSDTMe = New TextBox()
        btnThem = New Button()
        btnSua = New Button()
        btnThoat = New Button()
        SuspendLayout()
        ' 
        ' lablemsv
        ' 
        lablemsv.AutoSize = True
        lablemsv.BackColor = Color.White
        lablemsv.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lablemsv.ForeColor = Color.Black
        lablemsv.Location = New Point(12, 41)
        lablemsv.Name = "lablemsv"
        lablemsv.Size = New Size(87, 17)
        lablemsv.TabIndex = 1
        lablemsv.Text = "Mã học sinh:"
        ' 
        ' txtMaHS
        ' 
        txtMaHS.Location = New Point(102, 38)
        txtMaHS.Multiline = True
        txtMaHS.Name = "txtMaHS"
        txtMaHS.Size = New Size(123, 27)
        txtMaHS.TabIndex = 2
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnTimKiem.Location = New Point(26, 81)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(88, 27)
        btnTimKiem.TabIndex = 3
        btnTimKiem.Text = "Tìm kiếm"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.ForeColor = Color.Red
        btnXoa.Location = New Point(137, 81)
        btnXoa.Name = "btnXoa"
        btnXoa.RightToLeft = RightToLeft.No
        btnXoa.Size = New Size(86, 27)
        btnXoa.TabIndex = 4
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(291, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 17)
        Label1.TabIndex = 5
        Label1.Text = "Họ và tên:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(291, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 17)
        Label2.TabIndex = 6
        Label2.Text = "Ngày sinh:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(291, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 17)
        Label3.TabIndex = 7
        Label3.Text = "Chiều cao (cm):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(291, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 17)
        Label4.TabIndex = 8
        Label4.Text = "Cân nặng (kg):"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(291, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 17)
        Label5.TabIndex = 9
        Label5.Text = "Quê quán:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(292, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 17)
        Label6.TabIndex = 10
        Label6.Text = "Địa chỉ:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(291, 296)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 17)
        Label7.TabIndex = 11
        Label7.Text = "SĐT của bố:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(291, 373)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 17)
        Label8.TabIndex = 12
        Label8.Text = "SĐT của mẹ:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(292, 263)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 17)
        Label9.TabIndex = 13
        Label9.Text = "Tên bố:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(291, 332)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 17)
        Label10.TabIndex = 14
        Label10.Text = "Tên mẹ:"
        ' 
        ' txtHoTen
        ' 
        txtHoTen.Location = New Point(404, 57)
        txtHoTen.Name = "txtHoTen"
        txtHoTen.Size = New Size(167, 25)
        txtHoTen.TabIndex = 15
        ' 
        ' txtNgaySinh
        ' 
        txtNgaySinh.Location = New Point(404, 91)
        txtNgaySinh.Name = "txtNgaySinh"
        txtNgaySinh.Size = New Size(167, 25)
        txtNgaySinh.TabIndex = 16
        ' 
        ' txtChieuCao
        ' 
        txtChieuCao.Location = New Point(404, 120)
        txtChieuCao.Name = "txtChieuCao"
        txtChieuCao.Size = New Size(167, 25)
        txtChieuCao.TabIndex = 17
        ' 
        ' txtCanNang
        ' 
        txtCanNang.Location = New Point(404, 155)
        txtCanNang.Name = "txtCanNang"
        txtCanNang.Size = New Size(167, 25)
        txtCanNang.TabIndex = 18
        ' 
        ' txtQueQuan
        ' 
        txtQueQuan.Location = New Point(404, 190)
        txtQueQuan.Name = "txtQueQuan"
        txtQueQuan.Size = New Size(167, 25)
        txtQueQuan.TabIndex = 19
        ' 
        ' txtDiaChi
        ' 
        txtDiaChi.Location = New Point(404, 225)
        txtDiaChi.Name = "txtDiaChi"
        txtDiaChi.Size = New Size(167, 25)
        txtDiaChi.TabIndex = 20
        ' 
        ' txtTenBo
        ' 
        txtTenBo.Location = New Point(404, 260)
        txtTenBo.Name = "txtTenBo"
        txtTenBo.Size = New Size(167, 25)
        txtTenBo.TabIndex = 21
        ' 
        ' txtSDTBo
        ' 
        txtSDTBo.Location = New Point(404, 293)
        txtSDTBo.Name = "txtSDTBo"
        txtSDTBo.Size = New Size(167, 25)
        txtSDTBo.TabIndex = 22
        ' 
        ' txtTenMe
        ' 
        txtTenMe.Location = New Point(404, 329)
        txtTenMe.Name = "txtTenMe"
        txtTenMe.Size = New Size(167, 25)
        txtTenMe.TabIndex = 23
        ' 
        ' txtSDTMe
        ' 
        txtSDTMe.Location = New Point(404, 370)
        txtSDTMe.Name = "txtSDTMe"
        txtSDTMe.Size = New Size(167, 25)
        txtSDTMe.TabIndex = 24
        ' 
        ' btnThem
        ' 
        btnThem.ForeColor = Color.Black
        btnThem.Location = New Point(137, 122)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(88, 29)
        btnThem.TabIndex = 25
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.ForeColor = Color.Lime
        btnSua.Location = New Point(26, 124)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(88, 27)
        btnSua.TabIndex = 26
        btnSua.Text = "Cập nhật"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.ForeColor = Color.Red
        btnThoat.Location = New Point(85, 167)
        btnThoat.Name = "btnThoat"
        btnThoat.RightToLeft = RightToLeft.No
        btnThoat.Size = New Size(86, 27)
        btnThoat.TabIndex = 27
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' thongtin
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(914, 510)
        Controls.Add(btnThoat)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(txtSDTMe)
        Controls.Add(txtTenMe)
        Controls.Add(txtSDTBo)
        Controls.Add(txtTenBo)
        Controls.Add(txtDiaChi)
        Controls.Add(txtQueQuan)
        Controls.Add(txtCanNang)
        Controls.Add(txtChieuCao)
        Controls.Add(txtNgaySinh)
        Controls.Add(txtHoTen)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnXoa)
        Controls.Add(btnTimKiem)
        Controls.Add(txtMaHS)
        Controls.Add(lablemsv)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "thongtin"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lablemsv As Label
    Friend WithEvents txtMaHS As TextBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtChieuCao As TextBox
    Friend WithEvents txtCanNang As TextBox
    Friend WithEvents txtQueQuan As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtTenBo As TextBox
    Friend WithEvents txtSDTBo As TextBox
    Friend WithEvents txtTenMe As TextBox
    Friend WithEvents txtSDTMe As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThoat As Button
End Class
