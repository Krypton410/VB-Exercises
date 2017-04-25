<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Birthdays
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.op1 = New System.Windows.Forms.Label()
        Me.op2 = New System.Windows.Forms.Label()
        Me.op3 = New System.Windows.Forms.Label()
        Me.op4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Show Format"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Birthday"
        '
        'op1
        '
        Me.op1.AutoSize = True
        Me.op1.Location = New System.Drawing.Point(105, 91)
        Me.op1.Name = "op1"
        Me.op1.Size = New System.Drawing.Size(45, 13)
        Me.op1.TabIndex = 15
        Me.op1.Text = "Birthday"
        '
        'op2
        '
        Me.op2.AutoSize = True
        Me.op2.Location = New System.Drawing.Point(105, 114)
        Me.op2.Name = "op2"
        Me.op2.Size = New System.Drawing.Size(45, 13)
        Me.op2.TabIndex = 16
        Me.op2.Text = "Birthday"
        '
        'op3
        '
        Me.op3.AutoSize = True
        Me.op3.Location = New System.Drawing.Point(105, 138)
        Me.op3.Name = "op3"
        Me.op3.Size = New System.Drawing.Size(45, 13)
        Me.op3.TabIndex = 17
        Me.op3.Text = "Birthday"
        '
        'op4
        '
        Me.op4.AutoSize = True
        Me.op4.Location = New System.Drawing.Point(105, 163)
        Me.op4.Name = "op4"
        Me.op4.Size = New System.Drawing.Size(45, 13)
        Me.op4.TabIndex = 18
        Me.op4.Text = "Birthday"
        '
        'Birthdays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.op4)
        Me.Controls.Add(Me.op3)
        Me.Controls.Add(Me.op2)
        Me.Controls.Add(Me.op1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Birthdays"
        Me.Text = "Birthday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents op1 As System.Windows.Forms.Label
    Friend WithEvents op2 As System.Windows.Forms.Label
    Friend WithEvents op3 As System.Windows.Forms.Label
    Friend WithEvents op4 As System.Windows.Forms.Label
End Class
