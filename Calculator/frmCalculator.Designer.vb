<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.pnlNumerics = New System.Windows.Forms.Panel()
        Me.btnDoubleZero = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.pnlOperations = New System.Windows.Forms.Panel()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.pnlFunctions = New System.Windows.Forms.Panel()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.lblTape = New System.Windows.Forms.Label()
        Me.pnlNumerics.SuspendLayout()
        Me.pnlOperations.SuspendLayout()
        Me.pnlFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(12, 21)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ShortcutsEnabled = False
        Me.txtDisplay.Size = New System.Drawing.Size(560, 31)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlNumerics
        '
        Me.pnlNumerics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNumerics.Controls.Add(Me.btnDoubleZero)
        Me.pnlNumerics.Controls.Add(Me.btnZero)
        Me.pnlNumerics.Controls.Add(Me.btnNine)
        Me.pnlNumerics.Controls.Add(Me.btnEight)
        Me.pnlNumerics.Controls.Add(Me.btnSeven)
        Me.pnlNumerics.Controls.Add(Me.btnSix)
        Me.pnlNumerics.Controls.Add(Me.btnFive)
        Me.pnlNumerics.Controls.Add(Me.btnFour)
        Me.pnlNumerics.Controls.Add(Me.btnThree)
        Me.pnlNumerics.Controls.Add(Me.btnTwo)
        Me.pnlNumerics.Controls.Add(Me.btnOne)
        Me.pnlNumerics.Location = New System.Drawing.Point(12, 59)
        Me.pnlNumerics.Name = "pnlNumerics"
        Me.pnlNumerics.Size = New System.Drawing.Size(230, 178)
        Me.pnlNumerics.TabIndex = 1
        '
        'btnDoubleZero
        '
        Me.btnDoubleZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoubleZero.Location = New System.Drawing.Point(77, 135)
        Me.btnDoubleZero.Name = "btnDoubleZero"
        Me.btnDoubleZero.Size = New System.Drawing.Size(146, 38)
        Me.btnDoubleZero.TabIndex = 10
        Me.btnDoubleZero.Text = "00"
        Me.btnDoubleZero.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(3, 135)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(70, 38)
        Me.btnZero.TabIndex = 9
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(153, 91)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(70, 38)
        Me.btnNine.TabIndex = 8
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(77, 91)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(70, 38)
        Me.btnEight.TabIndex = 7
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(3, 91)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(70, 38)
        Me.btnSeven.TabIndex = 6
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(153, 47)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(70, 38)
        Me.btnSix.TabIndex = 5
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(77, 47)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(70, 38)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(3, 48)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(70, 38)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(153, 3)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(70, 38)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(77, 3)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(70, 38)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(3, 4)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(70, 38)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'pnlOperations
        '
        Me.pnlOperations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOperations.Controls.Add(Me.btnEquals)
        Me.pnlOperations.Controls.Add(Me.btnDivide)
        Me.pnlOperations.Controls.Add(Me.btnMultiply)
        Me.pnlOperations.Controls.Add(Me.btnMinus)
        Me.pnlOperations.Controls.Add(Me.btnDecimal)
        Me.pnlOperations.Controls.Add(Me.btnPlus)
        Me.pnlOperations.Location = New System.Drawing.Point(248, 58)
        Me.pnlOperations.Name = "pnlOperations"
        Me.pnlOperations.Size = New System.Drawing.Size(158, 179)
        Me.pnlOperations.TabIndex = 2
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(81, 134)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(70, 38)
        Me.btnEquals.TabIndex = 13
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(81, 92)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(70, 38)
        Me.btnDivide.TabIndex = 11
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(81, 49)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(70, 38)
        Me.btnMultiply.TabIndex = 12
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(81, 5)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(70, 38)
        Me.btnMinus.TabIndex = 11
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(3, 136)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(72, 36)
        Me.btnDecimal.TabIndex = 7
        Me.btnDecimal.Text = "●"
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(3, 3)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(72, 127)
        Me.btnPlus.TabIndex = 6
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'pnlFunctions
        '
        Me.pnlFunctions.Controls.Add(Me.btnClearAll)
        Me.pnlFunctions.Controls.Add(Me.btnClear)
        Me.pnlFunctions.Location = New System.Drawing.Point(412, 59)
        Me.pnlFunctions.Name = "pnlFunctions"
        Me.pnlFunctions.Size = New System.Drawing.Size(65, 125)
        Me.pnlFunctions.TabIndex = 3
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(3, 66)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(59, 56)
        Me.btnClearAll.TabIndex = 1
        Me.btnClearAll.Text = "C/A"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(3, 6)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 56)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(412, 190)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(65, 47)
        Me.btnOff.TabIndex = 4
        Me.btnOff.Text = "OFF"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'lblTape
        '
        Me.lblTape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTape.Location = New System.Drawing.Point(483, 59)
        Me.lblTape.Name = "lblTape"
        Me.lblTape.Size = New System.Drawing.Size(89, 178)
        Me.lblTape.TabIndex = 5
        Me.lblTape.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 246)
        Me.Controls.Add(Me.lblTape)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.pnlFunctions)
        Me.Controls.Add(Me.pnlOperations)
        Me.Controls.Add(Me.pnlNumerics)
        Me.Controls.Add(Me.txtDisplay)
        Me.Name = "frmCalculator"
        Me.Text = "Form1"
        Me.pnlNumerics.ResumeLayout(False)
        Me.pnlOperations.ResumeLayout(False)
        Me.pnlFunctions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents pnlNumerics As Panel
    Friend WithEvents pnlOperations As Panel
    Friend WithEvents pnlFunctions As Panel
    Friend WithEvents btnOff As Button
    Friend WithEvents lblTape As Label
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnDoubleZero As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnClear As Button
End Class
