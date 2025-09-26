Public Class menu
    Private Sub thongtin_Click(sender As Object, e As EventArgs) Handles thongtin.Click
        Dim f As New Thongtin()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub bangdiem_Click(sender As Object, e As EventArgs) Handles bangdiem.Click
        Dim g As New bangdiem()
        g.Show()
        Me.Hide()
    End Sub

    Private Sub thanhtich_Click(sender As Object, e As EventArgs) Handles thanhtich.Click
        Dim j As New thanhtich()
        j.Show()
        Me.Hide()
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        Application.Exit()
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class