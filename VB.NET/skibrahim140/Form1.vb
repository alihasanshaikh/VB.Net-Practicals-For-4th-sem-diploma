Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If CheckBox1.Checked = True Then
            TextBox3.Text = a + b
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If CheckBox2.Checked = True Then
            TextBox3.Text = a - b
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If CheckBox3.Checked = True Then
            TextBox3.Text = a * b
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If CheckBox4.Checked = True Then
            TextBox3.Text = a / b
        End If
    End Sub
End Class
