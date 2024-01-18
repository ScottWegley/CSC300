Public Class frmHello
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        MsgBox("Hello")
        frmHello.ActiveForm.Close()
    End Sub
End Class
