<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        bangdiem = New Button()
        thongtin = New Button()
        thanhtich = New Button()
        thoat = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' bangdiem
        ' 
        bangdiem.BackColor = SystemColors.ButtonHighlight
        bangdiem.BackgroundImage = My.Resources.Resources.bangdiem
        bangdiem.BackgroundImageLayout = ImageLayout.Stretch
        bangdiem.FlatAppearance.BorderSize = 0
        bangdiem.FlatAppearance.CheckedBackColor = Color.Transparent
        bangdiem.FlatAppearance.MouseDownBackColor = Color.Transparent
        bangdiem.FlatAppearance.MouseOverBackColor = Color.Transparent
        bangdiem.FlatStyle = FlatStyle.Flat
        bangdiem.ForeColor = Color.Transparent
        bangdiem.Location = New Point(246, 163)
        bangdiem.Name = "bangdiem"
        bangdiem.Size = New Size(137, 128)
        bangdiem.TabIndex = 2
        bangdiem.UseVisualStyleBackColor = True
        ' 
        ' thongtin
        ' 
        thongtin.BackgroundImage = My.Resources.Resources._1218712_customers_group_team_user_user_group_icon
        thongtin.BackgroundImageLayout = ImageLayout.Stretch
        thongtin.FlatAppearance.BorderSize = 0
        thongtin.FlatAppearance.CheckedBackColor = Color.Transparent
        thongtin.FlatStyle = FlatStyle.Flat
        thongtin.ForeColor = Color.Transparent
        thongtin.Location = New Point(75, 183)
        thongtin.Name = "thongtin"
        thongtin.Size = New Size(93, 88)
        thongtin.TabIndex = 1
        thongtin.UseVisualStyleBackColor = True
        ' 
        ' thanhtich
        ' 
        thanhtich.BackgroundImage = My.Resources.Resources.images
        thanhtich.BackgroundImageLayout = ImageLayout.Stretch
        thanhtich.FlatAppearance.BorderSize = 0
        thanhtich.FlatAppearance.CheckedBackColor = Color.Transparent
        thanhtich.FlatStyle = FlatStyle.Flat
        thanhtich.ForeColor = Color.Transparent
        thanhtich.Location = New Point(458, 183)
        thanhtich.Name = "thanhtich"
        thanhtich.Size = New Size(86, 88)
        thanhtich.TabIndex = 3
        thanhtich.UseVisualStyleBackColor = True
        ' 
        ' thoat
        ' 
        thoat.BackgroundImage = My.Resources.Resources.x_mark_3_64
        thoat.BackgroundImageLayout = ImageLayout.Stretch
        thoat.FlatAppearance.BorderSize = 0
        thoat.FlatAppearance.CheckedBackColor = Color.Transparent
        thoat.FlatStyle = FlatStyle.Flat
        thoat.ForeColor = Color.Transparent
        thoat.Location = New Point(619, 183)
        thoat.Name = "thoat"
        thoat.Size = New Size(93, 88)
        thoat.TabIndex = 3
        thoat.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 4
        Label1.Text = "Thông tin học sinh"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(244, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 20)
        Label2.TabIndex = 5
        Label2.Text = "Bảng điểm học sinh"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(423, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(466, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 7
        Label4.Text = "Tổng kết "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(642, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 8
        Label5.Text = "Thoát"
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(thoat)
        Controls.Add(thanhtich)
        Controls.Add(thongtin)
        Controls.Add(bangdiem)
        Name = "menu"
        Text = "menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bangdiem As Button
    Friend WithEvents thongtin As Button
    Friend WithEvents thanhtich As Button
    Friend WithEvents thoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
