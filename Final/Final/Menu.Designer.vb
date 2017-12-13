<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.sports = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.sports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sports
        '
        Me.sports.Image = Global.Final.My.Resources.Resources.all
        Me.sports.Location = New System.Drawing.Point(-17, -5)
        Me.sports.Name = "sports"
        Me.sports.Size = New System.Drawing.Size(866, 489)
        Me.sports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sports.TabIndex = 0
        Me.sports.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 35)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(771, 96)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to the B-mac and the Bencharmers Tournament Bracket"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Cursor = System.Windows.Forms.Cursors.No
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(169, 189)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(485, 37)
        Me.lblStart.TabIndex = 2
        Me.lblStart.Text = "To Start Press the Start Button"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(313, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 473)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.sports)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.sports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sports As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
