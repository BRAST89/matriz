Public Class Ejercicio_7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = TextBox1.Text * 1024
        TextBox3.Text = TextBox1.Text * 1073741824
        TextBox2.Text = TextBox1.Text * 8000000000

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class