Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class dangky
    Dim connectionString As String = "Data Source=HUYTHU2\SQLEXPRESS01;Initial Catalog=admin;Integrated Security=True;Trust Server Certificate=True"

    Private Sub btdk_Click(sender As Object, e As EventArgs) Handles btdk.Click
        Dim taiKhoan As String = tbtk.Text.Trim()
        Dim matKhau As String = tbmk.Text.Trim()
        Dim nhapLai As String = tbnhaplaimk.Text.Trim()


        If matKhau <> nhapLai Then
            MessageBox.Show("Mật khẩu nhập lại không khớp!")
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Dim checkSql As String = "SELECT COUNT(*) FROM admin WHERE TaiKhoan=@tk"
                Using checkCmd As New SqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@tk", taiKhoan)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Tài khoản đã tồn tại!")
                        Exit Sub
                    End If
                End Using

                Dim sql As String = "INSERT INTO admin (TaiKhoan, MatKhau) VALUES (@tk, @mk)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@tk", taiKhoan)
                    cmd.Parameters.AddWithValue("@mk", matKhau)

                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Đăng ký thành công!")
                    Else
                        MessageBox.Show("Đăng ký thất bại!")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dangky_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class