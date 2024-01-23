Public Class frmCalculator

    ' Scott Wegley, CSC-300 Spring 2024, Homework #? - Build a Calculator

    Public dblTermOne As Double
    Public dblTermTwo As Double

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged
        For index = 0 To txtDisplay.TextLength - 1
            If Not IsNumeric(txtDisplay.Text.Substring(index, 1)) Then
                txtDisplay.Text = txtDisplay.Text.Replace(txtDisplay.Text.Substring(index, 1), "")
            End If
        Next
    End Sub

    Private Sub btnNumerics_Click(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click, btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click, btnZero.Click, btnDoubleZero.Click
        txtDisplay.Text = txtDisplay.Text & CType(sender, Button).Text
    End Sub
End Class
