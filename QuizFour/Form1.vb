Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMPGCalculator
    Private Sub btnMPG_Click(sender As Object, e As EventArgs) Handles btnMPG.Click
        Try
            Dim intOdoOne As Integer = CInt(txtOdo1.Text)
            Dim intOdoTwo As Integer = CInt(txtOdo2.Text)
            Dim dblGallons As Double = CDbl(txtGallons.Text)
            Dim dblResult As Double = CalculateMPG(intOdoOne, intOdoTwo, dblGallons)
            If Not dblResult = -1 Then
                txtMPG.Text = CStr(dblResult)
            Else
                Throw New System.Exception("There was an error when calculating the miles per gallon.")
            End If
        Catch ex As Exception
            txtMPG.Text = "ERROR"
        End Try
    End Sub

    Private Function CalculateMPG(ByVal intOdoOne As Integer, ByVal intOdoTwo As Integer, ByVal dblGallons As Double) As Double
        Dim dblMPG As Double
        Try
            ' Handles the case of divide by zero
            Dim intOdoDiff As Integer = Math.Abs(intOdoOne - intOdoTwo)
            dblMPG = intOdoDiff / dblGallons
        Catch ex As Exception
            Return -1
        End Try
        Return dblMPG
    End Function
End Class
