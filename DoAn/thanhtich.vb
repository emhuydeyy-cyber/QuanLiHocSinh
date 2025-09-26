Imports Microsoft.Data.SqlClient

Public Class thanhtich
    Private connStr As String = "Data Source=HUYTHU2\SQLEXPRESS01;Initial Catalog=QuanLyHocSinh;Integrated Security=True;Trust Server Certificate=True"

    Private Function TinhDiemTB(maHS As String) As Double
        Dim diemTB As Double = 0
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT Toan, Van, TiengAnh, VatLy, HoaHoc, SinhHoc, LichSu, DiaLi, TinHoc, TheDuc, QuocPhong, CongNghe 
                                 FROM ThanhTich WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", maHS)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim tong As Double = 0
                        Dim dem As Integer = 0
                        For i As Integer = 0 To reader.FieldCount - 1
                            If Not IsDBNull(reader(i)) Then
                                tong += Convert.ToDouble(reader(i))
                                dem += 1
                            End If
                        Next
                        If dem > 0 Then diemTB = tong / dem
                    End If
                End Using
            End Using
        End Using
        Return Math.Round(diemTB, 2)
    End Function


    Private Function XepLoai(dtb As Double) As String
        If dtb >= 8.0 Then
            Return "Giỏi"
        ElseIf dtb >= 6.5 Then
            Return "Khá"
        ElseIf dtb >= 5.0 Then
            Return "Trung Bình"
        Else
            Return "Yếu"
        End If
    End Function


    Private Sub ClearForm()
        txtMaHS.Clear()
        txtHoTen.Clear()
        txtDiemTB.Clear()
        txtXepLoai.Clear()
        txtNhanXet.Clear()
        cboHanhKiem.SelectedIndex = -1
    End Sub


    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT HoTen FROM HocSinh WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtHoTen.Text = reader("HoTen").ToString()
                    Else
                        MessageBox.Show("Không tìm thấy học sinh này!")
                        Return
                    End If
                End Using
            End Using
        End Using


        Dim dtb As Double = TinhDiemTB(txtMaHS.Text)
        txtDiemTB.Text = dtb.ToString("0.00")


        txtXepLoai.Text = XepLoai(dtb)


        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT HanhKiem, NhanXet FROM KetQua WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cboHanhKiem.Text = reader("HanhKiem").ToString()
                        txtNhanXet.Text = reader("NhanXet").ToString()
                    Else

                        cboHanhKiem.Text = ""
                        txtNhanXet.Text = ""
                    End If
                End Using
            End Using
        End Using
    End Sub



    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()


            Dim checkSql As String = "SELECT COUNT(*) FROM KetQua WHERE MaHS=@MaHS"
            Using checkCmd As New SqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                Dim sql As String
                If exists > 0 Then

                    sql = "UPDATE KetQua 
                       SET DiemTB=@DiemTB, HanhKiem=@HanhKiem, XepLoai=@XepLoai, NhanXet=@NhanXet
                       WHERE MaHS=@MaHS"
                Else

                    sql = "INSERT INTO KetQua(MaHS, DiemTB, HanhKiem, XepLoai, NhanXet) 
                       VALUES(@MaHS, @DiemTB, @HanhKiem, @XepLoai, @NhanXet)"
                End If

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                    cmd.Parameters.AddWithValue("@DiemTB", Double.Parse(txtDiemTB.Text))
                    cmd.Parameters.AddWithValue("@HanhKiem", cboHanhKiem.Text)
                    cmd.Parameters.AddWithValue("@XepLoai", txtXepLoai.Text)
                    cmd.Parameters.AddWithValue("@NhanXet", txtNhanXet.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Using
        MessageBox.Show("Lưu kết quả thành công!")
        ClearForm()
    End Sub



    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "UPDATE KetQua 
                                 SET DiemTB=@DiemTB, HanhKiem=@HanhKiem, XepLoai=@XepLoai, NhanXet=@NhanXet
                                 WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd.Parameters.AddWithValue("@DiemTB", Double.Parse(txtDiemTB.Text))
                cmd.Parameters.AddWithValue("@HanhKiem", cboHanhKiem.Text)
                cmd.Parameters.AddWithValue("@XepLoai", txtXepLoai.Text)
                cmd.Parameters.AddWithValue("@NhanXet", txtNhanXet.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Cập nhật thành công!")
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaHS.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập Mã học sinh cần xóa!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa kết quả học tập của học sinh này?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim sql = "DELETE FROM KetQua WHERE MaHS=@MaHS"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Đã xóa kết quả học tập thành công!")
                        ClearForm()
                    Else
                        MessageBox.Show("Không tìm thấy kết quả để xóa!")
                    End If
                End Using
            End Using
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()

        Dim f As New menu()
        f.Show()
    End Sub
End Class
