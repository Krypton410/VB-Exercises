<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doloop1
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
        Me.Box1 = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.Label()
        Me.rslt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter number"
        '
        'Box1
        '
        Me.Box1.Location = New System.Drawing.Point(97, 19)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(100, 20)
        Me.Box1.TabIndex = 2
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(111, 86)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 13)
        Me.result.TabIndex = 3
        '
        'rslt
        '
        Me.rslt.AutoSize = True
        Me.rslt.Location = New System.Drawing.Point(111, 117)
        Me.rslt.Name = "rslt"
        Me.rslt.Size = New System.Drawing.Size(0, 13)
        Me.rslt.TabIndex = 4
        '
        'Doloop1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.rslt)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Box1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Doloop1"
        Me.Text = "Do loop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Box1 As System.Windows.Forms.TextBox
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents rslt As System.Windows.Forms.Label
End Class
