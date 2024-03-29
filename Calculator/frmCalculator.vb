﻿Option Strict On
Option Explicit On
Option Infer Off

Public Class frmCalculator

    ' Scott Wegley, CSC-300 Spring 2024, Homework #? - Build a Calculator

    Public dblTermOne As Double = 0
    Public dblTermTwo As Double = 0

    Public boolFirstDecimal As Boolean = False
    Public boolSecondDecimal As Boolean = False

    Public strOperation As String = ""

    Public boolStoreFirst As Boolean = True

    Public Const MAX_TAPE_LINES As Integer = 15

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged
        If Not txtDisplay.Text.IndexOf(".") = -1 Then
            If boolStoreFirst Then boolFirstDecimal = True Else boolSecondDecimal = True
        End If
        For I As Integer = 0 To txtDisplay.TextLength - 1
            If Not (IsNumeric(txtDisplay.Text.Substring(I, 1)) Or txtDisplay.Text.Substring(I, 1) = ".") Then
                txtDisplay.Text = txtDisplay.Text.Replace(txtDisplay.Text.Substring(I, 1), "")
            End If
        Next
        txtDisplay.Select(txtDisplay.TextLength, 0)
    End Sub

    Private Sub btnNumerics_Click(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click, btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click, btnZero.Click, btnDoubleZero.Click
        txtDisplay.Text = txtDisplay.Text & CType(sender, Button).Text
    End Sub

    Private Sub btnOperations_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click
        strOperation = (CType(sender, Button)).Text
        If boolStoreFirst Then
            dblTermOne = CDbl(txtDisplay.Text)
            txtDisplay.Clear()
        Else

        End If
    End Sub

    Private Sub addTapeLine(strToAdd As String)
        Dim intLineCount As Integer = lblTape.Text.Count(Function(c As Char) c = "\n")
        MsgBox(intLineCount)
        If intLineCount = MAX_TAPE_LINES Then
            lblTape.Text = lblTape.Text.Substring(0, lblTape.Text.IndexOf("\n"))
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If If(boolStoreFirst, Not boolFirstDecimal, Not boolSecondDecimal) Then
            txtDisplay.Text = txtDisplay.Text & "."
            If boolStoreFirst Then boolFirstDecimal = True Else boolSecondDecimal = True
        End If
    End Sub

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.Focus()
    End Sub

    Private Sub txtDisplay_LostFocus(sender As Object, e As EventArgs) Handles txtDisplay.LostFocus
        txtDisplay.Focus()
    End Sub
End Class
