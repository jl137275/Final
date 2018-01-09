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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picSports = New System.Windows.Forms.PictureBox()
        CType(Me.picSports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(31, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(771, 96)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to the B-mac and the Benchwarmers Tournament Bracket"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Cursor = System.Windows.Forms.Cursors.No
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(159, 451)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(485, 37)
        Me.lblStart.TabIndex = 2
        Me.lblStart.Text = "To Start Press the Start Button"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(326, 529)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(142, 60)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start "
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picSports
        '
        Me.picSports.Image = Global.Final.My.Resources.Resources._32890960
        Me.picSports.Location = New System.Drawing.Point(26, 44)
        Me.picSports.Name = "picSports"
        Me.picSports.Size = New System.Drawing.Size(776, 510)
        Me.picSports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSports.TabIndex = 4
        Me.picSports.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 591)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picSports)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.picSports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents picSports As System.Windows.Forms.PictureBox

End Class
