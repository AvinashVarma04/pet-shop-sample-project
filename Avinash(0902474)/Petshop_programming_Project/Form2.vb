Public Class Form2
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox2.SelectedItems.Count > 0 Then
            lblpayment.Text = "The service " + Form1.ListBox1.SelectedItem + " is processed using " +
                ListBox2.SelectedItem + " method successfully."
        Else
            MessageBox.Show("Please select a Payment method to proceed")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Form1.ListBox1.SelectedIndex = 0 Then
            Me.BackgroundImage = My.Resources.IMG_20230312_232551

        ElseIf Form1.ListBox1.SelectedIndex = 1 Then
            Me.BackgroundImage = My.Resources.IMG_20230312_232719
        ElseIf Form1.ListBox1.SelectedIndex = 2 Then
            Me.BackgroundImage = My.Resources.IMG_20230312_232827
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub lblpayment_Click(sender As Object, e As EventArgs) Handles lblpayment.Click

    End Sub

    Private Sub Form2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class