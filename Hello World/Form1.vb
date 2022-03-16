Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        MessageBox.Show("Hello World")

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click

        MessageBox.Show("Hello " + txtName.Text)

    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click

        txtShow.Text = "Hello " + txtName.Text

    End Sub
End Class
