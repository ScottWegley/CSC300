Public Class frmCalculator

    ' Scott Wegley, CSC-300 Spring 2024, Homework #? - Build a Calculator

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged
        For index = 0 To txtDisplay.TextLength - 1
            If Not IsNumeric(txtDisplay.Text.Substring(index, 1)) Then
                txtDisplay.Text = txtDisplay.Text.Replace(txtDisplay.Text.Substring(index, 1), "")
            End If
        Next
    End Sub
End Class
