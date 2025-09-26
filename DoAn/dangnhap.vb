Imports Microsoft.Data.SqlClient

Public Class dangnhap

    Private connStr As String = "Data Source=HUYTHU2\SQLEXPRESS01;Initial Catalog=admin;Integrated Security=True;Trust Server Certificate=True"

    Private Sub btdn_Click(sender As Object, e As EventArgs) Handles btdn.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM Admin WHERE taikhoan=@TaiKhoan AND matkhau=@MatKhau"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TaiKhoan", tbtk.Text.Trim())
                cmd.Parameters.AddWithValue("@MatKhau", tbmk.Text.Trim())
                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Đăng nhập thành công!")
                    Dim vaomain As New menu()
                    vaomain.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!")
                End If
            End Using
        End Using
    End Sub


    Private Sub btdk_Click(sender As Object, e As EventArgs) Handles btdk.Click
        Me.Hide()
        Dim f As New dangky()
        f.ShowDialog()

    End Sub

    Private Sub dangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
