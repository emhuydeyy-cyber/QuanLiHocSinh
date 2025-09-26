<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dangky
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
        labletk = New Label()
        tbtk = New TextBox()
        tbmk = New TextBox()
        btdk = New Button()
        lablemk = New Label()
        tbnhaplaimk = New TextBox()
        lablenhaplaimk = New Label()
        SuspendLayout()
        ' 
        ' labletk
        ' 
        labletk.AutoSize = True
        labletk.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        labletk.ForeColor = Color.Black
        labletk.Location = New Point(73, 67)
        labletk.Name = "labletk"
        labletk.Size = New Size(89, 21)
        labletk.TabIndex = 1
        labletk.Text = "Tài Khoản:"
        ' 
        ' tbtk
        ' 
        tbtk.Location = New Point(244, 69)
        tbtk.Name = "tbtk"
        tbtk.Size = New Size(151, 23)
        tbtk.TabIndex = 3
        ' 
        ' tbmk
        ' 
        tbmk.Location = New Point(244, 101)
        tbmk.Name = "tbmk"
        tbmk.PasswordChar = "*"c
        tbmk.Size = New Size(151, 23)
        tbmk.TabIndex = 4
        ' 
        ' btdk
        ' 
        btdk.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btdk.ForeColor = Color.Blue
        btdk.Location = New Point(213, 206)
        btdk.Name = "btdk"
        btdk.Size = New Size(106, 43)
        btdk.TabIndex = 8
        btdk.Text = "Đăng ký"
        btdk.UseVisualStyleBackColor = True
        ' 
        ' lablemk
        ' 
        lablemk.AutoSize = True
        lablemk.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lablemk.ForeColor = Color.Black
        lablemk.Location = New Point(73, 97)
        lablemk.Name = "lablemk"
        lablemk.Size = New Size(87, 21)
        lablemk.TabIndex = 2
        lablemk.Text = "Mật Khẩu:"
        ' 
        ' tbnhaplaimk
        ' 
        tbnhaplaimk.Location = New Point(244, 130)
        tbnhaplaimk.Name = "tbnhaplaimk"
        tbnhaplaimk.PasswordChar = "*"c
        tbnhaplaimk.Size = New Size(151, 23)
        tbnhaplaimk.TabIndex = 10
        ' 
        ' lablenhaplaimk
        ' 
        lablenhaplaimk.AutoSize = True
        lablenhaplaimk.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lablenhaplaimk.ForeColor = Color.Black
        lablenhaplaimk.Location = New Point(73, 130)
        lablenhaplaimk.Name = "lablenhaplaimk"
        lablenhaplaimk.Size = New Size(155, 21)
        lablenhaplaimk.TabIndex = 9
        lablenhaplaimk.Text = "Nhập lại mật khẩu:"
        ' 
        ' dangky
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(539, 380)
        Controls.Add(tbnhaplaimk)
        Controls.Add(lablenhaplaimk)
        Controls.Add(btdk)
        Controls.Add(tbmk)
        Controls.Add(tbtk)
        Controls.Add(lablemk)
        Controls.Add(labletk)
        KeyPreview = True
        Name = "dangky"
        Text = "Đăng Ký"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labletk As Label
    Friend WithEvents tbtk As TextBox
    Friend WithEvents tbmk As TextBox
    Friend WithEvents btdk As Button
    Friend WithEvents lablemk As Label
    Friend WithEvents tbnhaplaimk As TextBox
    Friend WithEvents lablenhaplaimk As Label
End Class
