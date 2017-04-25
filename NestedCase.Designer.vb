<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NestedCase
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
        Me.result = New System.Windows.Forms.Label()
        Me.resulta = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.box2 = New System.Windows.Forms.TextBox()
        Me.box1 = New System.Windows.Forms.TextBox()
        Me.value = New System.Windows.Forms.Label()
        Me.valuea = New System.Windows.Forms.Label()
        Me.valueb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(90, 129)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 13)
        Me.result.TabIndex = 45
        '
        'resulta
        '
        Me.resulta.AutoSize = True
        Me.resulta.Location = New System.Drawing.Point(46, 129)
        Me.resulta.Name = "resulta"
        Me.resulta.Size = New System.Drawing.Size(38, 13)
        Me.resulta.TabIndex = 44
        Me.resulta.Text = "result :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nested Case statement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Enter Second Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Enter First Number :"
        '
        'box2
        '
        Me.box2.Location = New System.Drawing.Point(179, 64)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(59, 20)
        Me.box2.TabIndex = 39
        '
        'box1
        '
        Me.box1.Location = New System.Drawing.Point(179, 38)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(59, 20)
        Me.box1.TabIndex = 38
        '
        'value
        '
        Me.value.AutoSize = True
        Me.value.Location = New System.Drawing.Point(90, 158)
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(0, 13)
        Me.value.TabIndex = 46
        '
        'valuea
        '
        Me.valuea.AutoSize = True
        Me.valuea.Location = New System.Drawing.Point(81, 189)
        Me.valuea.Name = "valuea"
        Me.valuea.Size = New System.Drawing.Size(0, 13)
        Me.valuea.TabIndex = 47
        '
        'valueb
        '
        Me.valueb.AutoSize = True
        Me.valueb.Location = New System.Drawing.Point(81, 211)
        Me.valueb.Name = "valueb"
        Me.valueb.Size = New System.Drawing.Size(0, 13)
        Me.valueb.TabIndex = 48
        '
        'NestedCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.valueb)
        Me.Controls.Add(Me.valuea)
        Me.Controls.Add(Me.value)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.resulta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.box1)
        Me.Name = "NestedCase"
        Me.Text = "Nested Select Case"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents resulta As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents box2 As System.Windows.Forms.TextBox
    Friend WithEvents box1 As System.Windows.Forms.TextBox
    Friend WithEvents value As System.Windows.Forms.Label
    Friend WithEvents valuea As System.Windows.Forms.Label
    Friend WithEvents valueb As System.Windows.Forms.Label
End Class
