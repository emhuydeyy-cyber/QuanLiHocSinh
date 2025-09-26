<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dangnhap
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
        Label1 = New Label()
        Label2 = New Label()
        tbtk = New TextBox()
        tbmk = New TextBox()
        btdn = New Button()
        btdk = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(108, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 21)
        Label1.TabIndex = 0
        Label1.Text = "Tài Khoản:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(111, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 1
        Label2.Text = "Mật khẩu:"
        ' 
        ' tbtk
        ' 
        tbtk.Location = New Point(232, 98)
        tbtk.Multiline = True
        tbtk.Name = "tbtk"
        tbtk.Size = New Size(176, 29)
        tbtk.TabIndex = 2
        ' 
        ' tbmk
        ' 
        tbmk.Location = New Point(232, 133)
        tbmk.Multiline = True
        tbmk.Name = "tbmk"
        tbmk.PasswordChar = "*"c
        tbmk.Size = New Size(176, 29)
        tbmk.TabIndex = 3
        ' 
        ' btdn
        ' 
        btdn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btdn.ForeColor = Color.Black
        btdn.Location = New Point(159, 201)
        btdn.Name = "btdn"
        btdn.Size = New Size(94, 41)
        btdn.TabIndex = 4
        btdn.Text = "Đăng nhập"
        btdn.UseVisualStyleBackColor = True
        ' 
        ' btdk
        ' 
        btdk.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btdk.ForeColor = Color.Black
        btdk.Location = New Point(293, 201)
        btdk.Name = "btdk"
        btdk.Size = New Size(94, 41)
        btdk.TabIndex = 5
        btdk.Text = "Đăng ký"
        btdk.UseVisualStyleBackColor = True
        ' 
        ' dangnhap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(539, 380)
        Controls.Add(btdk)
        Controls.Add(btdn)
        Controls.Add(tbmk)
        Controls.Add(tbtk)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "dangnhap"
        Text = "dangnhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbtk As TextBox
    Friend WithEvents tbmk As TextBox
    Friend WithEvents btdn As Button
    Friend WithEvents btdk As Button
End Class
