Public Class Form1
    Private Sub number_Click(sender As Object, e As EventArgs) Handles one.Click, two.Click, three.Click, four.Click, five.Click, six.Click, seven.Click, eight.Click, nine.Click
        Dim button As Button = CType(sender, Button)
        TextBox1.Text &= button.Text

    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        If TextBox1.Text = String.Empty Then
        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text &= "0"
        ElseIf Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Text = String.Empty
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click, subst.Click, multiply.Click, divi.Click, modu.Click
        Dim button As Button = CType(sender, Button)
        TextBox1.Text &= CType(sender, Button).Text
    End Sub

    Private Sub equle_Click(sender As Object, e As EventArgs) Handles equle.Click
        Try
            Dim expression As String = TextBox1.Text
            Dim result As Object
            Dim table As New DataTable
            result = table.Compute(expression, String.Empty)
            TextBox1.Text = result.ToString
        Catch ex As Exception
            TextBox1.Text = "wrong entry"

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub
End Class
