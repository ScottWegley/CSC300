<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPGCalculator
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
        Me.lblOdo1 = New System.Windows.Forms.Label()
        Me.lblOdo2 = New System.Windows.Forms.Label()
        Me.lblGals = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.txtOdo1 = New System.Windows.Forms.TextBox()
        Me.txtOdo2 = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMPG = New System.Windows.Forms.TextBox()
        Me.btnMPG = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOdo1
        '
        Me.lblOdo1.Location = New System.Drawing.Point(13, 13)
        Me.lblOdo1.Name = "lblOdo1"
        Me.lblOdo1.Size = New System.Drawing.Size(100, 23)
        Me.lblOdo1.TabIndex = 0
        Me.lblOdo1.Text = "Odo 1:"
        Me.lblOdo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOdo2
        '
        Me.lblOdo2.Location = New System.Drawing.Point(13, 42)
        Me.lblOdo2.Name = "lblOdo2"
        Me.lblOdo2.Size = New System.Drawing.Size(100, 13)
        Me.lblOdo2.TabIndex = 1
        Me.lblOdo2.Text = "Odo 2:"
        Me.lblOdo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGals
        '
        Me.lblGals.Location = New System.Drawing.Point(13, 63)
        Me.lblGals.Name = "lblGals"
        Me.lblGals.Size = New System.Drawing.Size(100, 23)
        Me.lblGals.TabIndex = 2
        Me.lblGals.Text = "Gallons:"
        Me.lblGals.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMPG
        '
        Me.lblMPG.Location = New System.Drawing.Point(13, 89)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(100, 23)
        Me.lblMPG.TabIndex = 3
        Me.lblMPG.Text = "MPG (calculated):"
        Me.lblMPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOdo1
        '
        Me.txtOdo1.Location = New System.Drawing.Point(119, 13)
        Me.txtOdo1.Name = "txtOdo1"
        Me.txtOdo1.Size = New System.Drawing.Size(100, 20)
        Me.txtOdo1.TabIndex = 4
        '
        'txtOdo2
        '
        Me.txtOdo2.Location = New System.Drawing.Point(119, 39)
        Me.txtOdo2.Name = "txtOdo2"
        Me.txtOdo2.Size = New System.Drawing.Size(100, 20)
        Me.txtOdo2.TabIndex = 5
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(119, 65)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 6
        '
        'txtMPG
        '
        Me.txtMPG.Location = New System.Drawing.Point(119, 91)
        Me.txtMPG.Name = "txtMPG"
        Me.txtMPG.Size = New System.Drawing.Size(100, 20)
        Me.txtMPG.TabIndex = 7
        '
        'btnMPG
        '
        Me.btnMPG.Location = New System.Drawing.Point(16, 115)
        Me.btnMPG.Name = "btnMPG"
        Me.btnMPG.Size = New System.Drawing.Size(203, 23)
        Me.btnMPG.TabIndex = 8
        Me.btnMPG.Text = "Calculate MPG"
        Me.btnMPG.UseVisualStyleBackColor = True
        '
        'frmMPGCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMPG)
        Me.Controls.Add(Me.txtMPG)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtOdo2)
        Me.Controls.Add(Me.txtOdo1)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.lblGals)
        Me.Controls.Add(Me.lblOdo2)
        Me.Controls.Add(Me.lblOdo1)
        Me.Name = "frmMPGCalculator"
        Me.Text = "Quiz 4 - MPG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOdo1 As Label
    Friend WithEvents lblOdo2 As Label
    Friend WithEvents lblGals As Label
    Friend WithEvents lblMPG As Label
    Friend WithEvents txtOdo1 As TextBox
    Friend WithEvents txtOdo2 As TextBox
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMPG As TextBox
    Friend WithEvents btnMPG As Button
End Class
