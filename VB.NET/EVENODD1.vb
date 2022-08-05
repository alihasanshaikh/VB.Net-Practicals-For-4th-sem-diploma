Public Class Form1

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) Mod 2 = 0 Then
            Label1.Text = "EVEN"
        Else
            Label1.Text = "ODD"

        End If
    End Sub
End Class
