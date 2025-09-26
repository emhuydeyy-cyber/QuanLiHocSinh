Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class thongtin

    Dim connStr As String = "Data Source=HUYTHU2\SQLEXPRESS01;Initial Catalog=QuanLyHocSinh;Integrated Security=True;Trust Server Certificate=True"

    Private Sub ClearAllTextBox()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "INSERT INTO HocSinh (MaHS, HoTen, NgaySinh, ChieuCao, CanNang, QueQuan, DiaChi, TenBo, SDTBo, TenMe, SDTMe) 
                                 VALUES (@MaHS, @HoTen, @NgaySinh, @ChieuCao, @CanNang, @QueQuan, @DiaChi, @TenBo, @SDTBo, @TenMe, @SDTMe)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text)
                cmd.Parameters.AddWithValue("@ChieuCao", txtChieuCao.Text)
                cmd.Parameters.AddWithValue("@CanNang", txtCanNang.Text)
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text)
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                cmd.Parameters.AddWithValue("@TenBo", txtTenBo.Text)
                cmd.Parameters.AddWithValue("@SDTBo", txtSDTBo.Text)
                cmd.Parameters.AddWithValue("@TenMe", txtTenMe.Text)
                cmd.Parameters.AddWithValue("@SDTMe", txtSDTMe.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm học sinh thành công!")
                ClearAllTextBox()
            End Using
        End Using
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT * FROM HocSinh WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                Dim rd As SqlDataReader = cmd.ExecuteReader()
                If rd.Read() Then
                    txtHoTen.Text = rd("HoTen").ToString()
                    txtNgaySinh.Text = rd("NgaySinh").ToString()
                    txtChieuCao.Text = rd("ChieuCao").ToString()
                    txtCanNang.Text = rd("CanNang").ToString()
                    txtQueQuan.Text = rd("QueQuan").ToString()
                    txtDiaChi.Text = rd("DiaChi").ToString()
                    txtTenBo.Text = rd("TenBo").ToString()
                    txtSDTBo.Text = rd("SDTBo").ToString()
                    txtTenMe.Text = rd("TenMe").ToString()
                    txtSDTMe.Text = rd("SDTMe").ToString()
                Else
                    MessageBox.Show("Không tìm thấy học sinh!")
                    ClearAllTextBox()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaHS.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập mã học sinh để xóa!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ dữ liệu học sinh này?",
                                                "Xác nhận",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning)
        If result = DialogResult.No Then Return

        Using conn As New SqlConnection(connStr)
            conn.Open()


            Dim sqlDelKQ As String = "DELETE FROM KetQua WHERE MaHS=@MaHS"
            Using cmd0 As New SqlCommand(sqlDelKQ, conn)
                cmd0.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd0.ExecuteNonQuery()
            End Using


            Dim sqlDelTT As String = "DELETE FROM ThanhTich WHERE MaHS=@MaHS"
            Using cmd1 As New SqlCommand(sqlDelTT, conn)
                cmd1.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd1.ExecuteNonQuery()
            End Using


            Dim sqlDelHS As String = "DELETE FROM HocSinh WHERE MaHS=@MaHS"
            Using cmd2 As New SqlCommand(sqlDelHS, conn)
                cmd2.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                Dim rows = cmd2.ExecuteNonQuery()
                If rows > 0 Then
                    MessageBox.Show("Đã xóa toàn bộ dữ liệu học sinh thành công!")
                    ClearAllTextBox()
                Else
                    MessageBox.Show("Không tìm thấy mã học sinh để xóa!")
                End If
            End Using
        End Using
    End Sub


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "UPDATE HocSinh SET HoTen=@HoTen, NgaySinh=@NgaySinh, ChieuCao=@ChieuCao, CanNang=@CanNang, QueQuan=@QueQuan, DiaChi=@DiaChi,
                                 TenBo=@TenBo, SDTBo=@SDTBo, TenMe=@TenMe, SDTMe=@SDTMe WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text)
                cmd.Parameters.AddWithValue("@ChieuCao", txtChieuCao.Text)
                cmd.Parameters.AddWithValue("@CanNang", txtCanNang.Text)
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text)
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                cmd.Parameters.AddWithValue("@TenBo", txtTenBo.Text)
                cmd.Parameters.AddWithValue("@SDTBo", txtSDTBo.Text)
                cmd.Parameters.AddWithValue("@TenMe", txtTenMe.Text)
                cmd.Parameters.AddWithValue("@SDTMe", txtSDTMe.Text)
                Dim rows = cmd.ExecuteNonQuery()
                If rows > 0 Then
                    MessageBox.Show("Cập nhật thành công!")
                    ClearAllTextBox()
                Else
                    MessageBox.Show("Không tìm thấy mã học sinh để cập nhật!")
                End If
            End Using
        End Using
    End Sub

    Private Sub thongtin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click

        Me.Hide()

        Dim f As New menu()
        f.Show()
    End Sub
End Class
