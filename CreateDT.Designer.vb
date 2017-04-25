<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateDT
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
        Me.d1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.d2 = New System.Windows.Forms.Label()
        Me.d3 = New System.Windows.Forms.Label()
        Me.d4 = New System.Windows.Forms.Label()
        Me.d5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'd1
        '
        Me.d1.AutoSize = True
        Me.d1.Location = New System.Drawing.Point(77, 33)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(0, 13)
        Me.d1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Display Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'd2
        '
        Me.d2.AutoSize = True
        Me.d2.Location = New System.Drawing.Point(77, 64)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(0, 13)
        Me.d2.TabIndex = 2
        '
        'd3
        '
        Me.d3.AutoSize = True
        Me.d3.Location = New System.Drawing.Point(77, 92)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(0, 13)
        Me.d3.TabIndex = 3
        '
        'd4
        '
        Me.d4.AutoSize = True
        Me.d4.Location = New System.Drawing.Point(77, 118)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(0, 13)
        Me.d4.TabIndex = 4
        '
        'd5
        '
        Me.d5.AutoSize = True
        Me.d5.Location = New System.Drawing.Point(77, 147)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(0, 13)
        Me.d5.TabIndex = 5
        '
        'CreateDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.d5)
        Me.Controls.Add(Me.d4)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.d1)
        Me.Name = "CreateDT"
        Me.Text = "Create Date & Time"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents d1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents d2 As System.Windows.Forms.Label
    Friend WithEvents d3 As System.Windows.Forms.Label
    Friend WithEvents d4 As System.Windows.Forms.Label
    Friend WithEvents d5 As System.Windows.Forms.Label
End Class
