Public Class frmMicrowave
    ' Scott Wegley, CSC-300 Spring 2024, Homework #1 Model a Microwave Oven
    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click, btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click, btnZero.Click
        If pnlDoor.BackColor = Color.LightGreen Then GoTo Quit
        Dim intToAdd As Integer = CInt(CType(sender, Button).Text)
        lblClock.Text = ""
        lblClock.Tag = lblClock.Tag & intToAdd
        If lblClock.Tag.ToString().Length = 5 Then
            lblClock.Tag = lblClock.Tag.ToString().Substring(1)
        End If
        If lblClock.Tag.ToString().Length > 2 Then
            lblClock.Text = Strings.Left(lblClock.Tag.ToString(), lblClock.Tag.ToString().Length - 2) & ":"
        End If
        lblClock.Text = lblClock.Text & Strings.Right(lblClock.Tag.ToString(), 2)
Quit:
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblClock.Tag = ""
        lblClock.Text = ""
        pnlDoor.BackColor = Color.LightGray
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblClock.Text = "Running"
        pnlDoor.BackColor = Color.LightGreen
    End Sub
End Class
