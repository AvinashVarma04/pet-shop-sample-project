Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblprice.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedItem Is "Grooming" Then
            lblprice.Text = "price is 15.99"
        ElseIf ListBox1.SelectedItem Is "Feeding" Then
            lblprice.Text = "price is 12.99"
        ElseIf ListBox1.SelectedItem Is "Training" Then
            lblprice.Text = "Price is 19.99"
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItems.Count > 0 Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Please select a service to proceed")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
