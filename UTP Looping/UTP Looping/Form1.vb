Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim judul As String
        Dim iterasi As Integer

        judul = TextBox1.Text
        iterasi = TextBox2.Text

        For a = 1 To iterasi
            ListBox1.Items.Add(TextBox1.Text)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListBox1.Items.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
