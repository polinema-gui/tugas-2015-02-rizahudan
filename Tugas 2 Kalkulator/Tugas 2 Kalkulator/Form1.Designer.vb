<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.layarKalkulator = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.samadenganButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.kurangButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'layarKalkulator
        '
        Me.layarKalkulator.Location = New System.Drawing.Point(12, 13)
        Me.layarKalkulator.Multiline = True
        Me.layarKalkulator.Name = "layarKalkulator"
        Me.layarKalkulator.ReadOnly = True
        Me.layarKalkulator.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.layarKalkulator.Size = New System.Drawing.Size(178, 20)
        Me.layarKalkulator.TabIndex = 0
        Me.layarKalkulator.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(104, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 40)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(58, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(104, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 39)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 40)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(58, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(40, 40)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(104, 39)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(40, 40)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(12, 177)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(40, 40)
        Me.Button0.TabIndex = 10
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'samadenganButton
        '
        Me.samadenganButton.Location = New System.Drawing.Point(58, 177)
        Me.samadenganButton.Name = "samadenganButton"
        Me.samadenganButton.Size = New System.Drawing.Size(86, 40)
        Me.samadenganButton.TabIndex = 11
        Me.samadenganButton.Text = "="
        Me.samadenganButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(150, 39)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(40, 86)
        Me.clearButton.TabIndex = 12
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'kurangButton
        '
        Me.kurangButton.Location = New System.Drawing.Point(150, 131)
        Me.kurangButton.Name = "kurangButton"
        Me.kurangButton.Size = New System.Drawing.Size(40, 40)
        Me.kurangButton.TabIndex = 13
        Me.kurangButton.Text = "-"
        Me.kurangButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Location = New System.Drawing.Point(150, 177)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(40, 40)
        Me.tambahButton.TabIndex = 14
        Me.tambahButton.Text = "+"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 228)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Me.kurangButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.samadenganButton)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.layarKalkulator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents layarKalkulator As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents samadenganButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents kurangButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button

End Class
