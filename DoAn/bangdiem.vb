Imports Microsoft.Data.SqlClient

Public Class bangdiem
    Private connStr As String = "Data Source=HUYTHU2\SQLEXPRESS01;Initial Catalog=QuanLyHocSinh;Integrated Security=True;Trust Server Certificate=True"


    Private Function GetDiem(txt As String) As Double
        If txt = "" Then Return 0 Else Return Double.Parse(txt)
    End Function

    Private Sub ClearTextbox()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Text = ""
        Next
    End Sub


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String =
                "INSERT INTO ThanhTich(MaHS, Toan, Van, TiengAnh, VatLy, HoaHoc, SinhHoc, DiaLi, LichSu, TinHoc, TheDuc, QuocPhong, CongNghe) 
                 VALUES(@MaHS,@Toan,@Van,@TiengAnh,@VatLy,@HoaHoc,@SinhHoc,@DiaLi,@LichSu,@TinHoc,@TheDuc,@QuocPhong,@CongNghe)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd.Parameters.AddWithValue("@Toan", GetDiem(txtToan.Text))
                cmd.Parameters.AddWithValue("@Van", GetDiem(txtVan.Text))
                cmd.Parameters.AddWithValue("@TiengAnh", GetDiem(txtAnh.Text))
                cmd.Parameters.AddWithValue("@VatLy", GetDiem(txtLy.Text))
                cmd.Parameters.AddWithValue("@HoaHoc", GetDiem(txtHoa.Text))
                cmd.Parameters.AddWithValue("@SinhHoc", GetDiem(txtSinh.Text))
                cmd.Parameters.AddWithValue("@DiaLi", GetDiem(txtDia.Text))
                cmd.Parameters.AddWithValue("@LichSu", GetDiem(txtSu.Text))
                cmd.Parameters.AddWithValue("@TinHoc", GetDiem(txtTin.Text))
                cmd.Parameters.AddWithValue("@TheDuc", GetDiem(txtTD.Text))
                cmd.Parameters.AddWithValue("@QuocPhong", GetDiem(txtQP.Text))
                cmd.Parameters.AddWithValue("@CongNghe", GetDiem(txtCN.Text))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Thêm thành công!")
        ClearTextbox()
    End Sub


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String =
                "UPDATE ThanhTich SET 
                    Toan=@Toan, Van=@Van, TiengAnh=@TiengAnh, VatLy=@VatLy, HoaHoc=@HoaHoc, 
                    SinhHoc=@SinhHoc, DiaLi=@DiaLi, LichSu=@LichSu, TinHoc=@TinHoc, 
                    TheDuc=@TheDuc, QuocPhong=@QuocPhong, CongNghe=@CongNghe
                 WHERE MaHS=@MaHS"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd.Parameters.AddWithValue("@Toan", GetDiem(txtToan.Text))
                cmd.Parameters.AddWithValue("@Van", GetDiem(txtVan.Text))
                cmd.Parameters.AddWithValue("@TiengAnh", GetDiem(txtAnh.Text))
                cmd.Parameters.AddWithValue("@VatLy", GetDiem(txtLy.Text))
                cmd.Parameters.AddWithValue("@HoaHoc", GetDiem(txtHoa.Text))
                cmd.Parameters.AddWithValue("@SinhHoc", GetDiem(txtSinh.Text))
                cmd.Parameters.AddWithValue("@DiaLi", GetDiem(txtDia.Text))
                cmd.Parameters.AddWithValue("@LichSu", GetDiem(txtSu.Text))
                cmd.Parameters.AddWithValue("@TinHoc", GetDiem(txtTin.Text))
                cmd.Parameters.AddWithValue("@TheDuc", GetDiem(txtTD.Text))
                cmd.Parameters.AddWithValue("@QuocPhong", GetDiem(txtQP.Text))
                cmd.Parameters.AddWithValue("@CongNghe", GetDiem(txtCN.Text))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Cập nhật thành công!")
        ClearTextbox()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "DELETE FROM ThanhTich WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Xóa thành công!")
        ClearTextbox()
    End Sub



    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT * FROM ThanhTich WHERE MaHS=@MaHS"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtToan.Text = reader("Toan").ToString()
                        txtVan.Text = reader("Van").ToString()
                        txtAnh.Text = reader("TiengAnh").ToString()
                        txtLy.Text = reader("VatLy").ToString()
                        txtHoa.Text = reader("HoaHoc").ToString()
                        txtSinh.Text = reader("SinhHoc").ToString()
                        txtDia.Text = reader("DiaLi").ToString()
                        txtSu.Text = reader("LichSu").ToString()
                        txtTin.Text = reader("TinHoc").ToString()
                        txtTD.Text = reader("TheDuc").ToString()
                        txtQP.Text = reader("QuocPhong").ToString()
                        txtCN.Text = reader("CongNghe").ToString()
                    Else
                        MessageBox.Show("Không tìm thấy học sinh này!")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()

        Dim f As New menu()
        f.Show()
    End Sub
End Class
