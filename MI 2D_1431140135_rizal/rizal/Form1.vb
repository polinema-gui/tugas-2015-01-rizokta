Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Brown Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Brown
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Brown
    End Sub
End Class
