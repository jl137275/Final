<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bracket_Chooser
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
        Me.btn4Team = New System.Windows.Forms.Button()
        Me.btn8Team = New System.Windows.Forms.Button()
        Me.btn16Team = New System.Windows.Forms.Button()
        Me.btn32Team = New System.Windows.Forms.Button()
        Me.btn64Team = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn4Team
        '
        Me.btn4Team.Location = New System.Drawing.Point(3, 77)
        Me.btn4Team.Name = "btn4Team"
        Me.btn4Team.Size = New System.Drawing.Size(75, 35)
        Me.btn4Team.TabIndex = 0
        Me.btn4Team.Text = "4 team"
        Me.btn4Team.UseVisualStyleBackColor = True
        '
        'btn8Team
        '
        Me.btn8Team.Location = New System.Drawing.Point(99, 77)
        Me.btn8Team.Name = "btn8Team"
        Me.btn8Team.Size = New System.Drawing.Size(75, 35)
        Me.btn8Team.TabIndex = 1
        Me.btn8Team.Text = "8 team"
        Me.btn8Team.UseVisualStyleBackColor = True
        '
        'btn16Team
        '
        Me.btn16Team.Location = New System.Drawing.Point(197, 77)
        Me.btn16Team.Name = "btn16Team"
        Me.btn16Team.Size = New System.Drawing.Size(75, 35)
        Me.btn16Team.TabIndex = 2
        Me.btn16Team.Text = "16 team"
        Me.btn16Team.UseVisualStyleBackColor = True
        '
        'btn32Team
        '
        Me.btn32Team.Location = New System.Drawing.Point(56, 140)
        Me.btn32Team.Name = "btn32Team"
        Me.btn32Team.Size = New System.Drawing.Size(75, 33)
        Me.btn32Team.TabIndex = 3
        Me.btn32Team.Text = "32 team"
        Me.btn32Team.UseVisualStyleBackColor = True
        '
        'btn64Team
        '
        Me.btn64Team.Location = New System.Drawing.Point(156, 140)
        Me.btn64Team.Name = "btn64Team"
        Me.btn64Team.Size = New System.Drawing.Size(75, 33)
        Me.btn64Team.TabIndex = 4
        Me.btn64Team.Text = "64 team"
        Me.btn64Team.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Choose a Bracket Size"
        '
        'Bracket_Chooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn64Team)
        Me.Controls.Add(Me.btn32Team)
        Me.Controls.Add(Me.btn16Team)
        Me.Controls.Add(Me.btn8Team)
        Me.Controls.Add(Me.btn4Team)
        Me.Name = "Bracket_Chooser"
        Me.Text = "Bracket_Chooser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn4Team As System.Windows.Forms.Button
    Friend WithEvents btn8Team As System.Windows.Forms.Button
    Friend WithEvents btn16Team As System.Windows.Forms.Button
    Friend WithEvents btn32Team As System.Windows.Forms.Button
    Friend WithEvents btn64Team As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
