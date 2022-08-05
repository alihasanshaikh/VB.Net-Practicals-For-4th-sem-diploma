Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text ) > Val(TextBox2.Text And Val(TextBox1.Text) > Val(TextBox3.Text)  Then 
            Label4.Text = (TextBox1.Text + " is greatest number")

        ElseIf  Val(TextBox1.Text ) > Val(TextBox2.Text And Val(TextBox1.Text) > Val(TextBox3.Text) Then
            Label4.Text = (TextBox2.Text + " is greatest number")

        ElseIf (TextBox1.Text ) > Val(TextBox2.Text And Val(TextBox1.Text) > Val(TextBox3.Text) Then
            Label4.Text = (TextBox3.Text + " is greatest number")

        End If

    End Sub
End Class
