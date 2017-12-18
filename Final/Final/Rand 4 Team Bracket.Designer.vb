<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rand_4_Team_Bracket
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
        Me.lblChampion = New System.Windows.Forms.Label()
        Me.lblSeed2R2 = New System.Windows.Forms.Label()
        Me.lblSeed1R2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtSeed2 = New System.Windows.Forms.TextBox()
        Me.txtSeed4 = New System.Windows.Forms.TextBox()
        Me.txtSeed1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChampion
        '
        Me.lblChampion.BackColor = System.Drawing.Color.LightGray
        Me.lblChampion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChampion.Location = New System.Drawing.Point(539, 264)
        Me.lblChampion.Name = "lblChampion"
        Me.lblChampion.Size = New System.Drawing.Size(141, 23)
        Me.lblChampion.TabIndex = 19
        '
        'lblSeed2R2
        '
        Me.lblSeed2R2.BackColor = System.Drawing.Color.LightGray
        Me.lblSeed2R2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeed2R2.Location = New System.Drawing.Point(333, 387)
        Me.lblSeed2R2.Name = "lblSeed2R2"
        Me.lblSeed2R2.Size = New System.Drawing.Size(141, 23)
        Me.lblSeed2R2.TabIndex = 18
        '
        'lblSeed1R2
        '
        Me.lblSeed1R2.BackColor = System.Drawing.Color.LightGray
        Me.lblSeed1R2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeed1R2.Location = New System.Drawing.Point(333, 144)
        Me.lblSeed1R2.Name = "lblSeed1R2"
        Me.lblSeed1R2.Size = New System.Drawing.Size(141, 23)
        Me.lblSeed1R2.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.LightGray
        Me.TextBox4.Location = New System.Drawing.Point(110, 451)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(141, 20)
        Me.TextBox4.TabIndex = 15
        '
        'txtSeed2
        '
        Me.txtSeed2.BackColor = System.Drawing.Color.LightGray
        Me.txtSeed2.Location = New System.Drawing.Point(110, 329)
        Me.txtSeed2.Name = "txtSeed2"
        Me.txtSeed2.Size = New System.Drawing.Size(141, 20)
        Me.txtSeed2.TabIndex = 14
        '
        'txtSeed4
        '
        Me.txtSeed4.BackColor = System.Drawing.Color.LightGray
        Me.txtSeed4.Location = New System.Drawing.Point(110, 210)
        Me.txtSeed4.Name = "txtSeed4"
        Me.txtSeed4.Size = New System.Drawing.Size(141, 20)
        Me.txtSeed4.TabIndex = 13
        '
        'txtSeed1
        '
        Me.txtSeed1.BackColor = System.Drawing.Color.LightGray
        Me.txtSeed1.Location = New System.Drawing.Point(110, 88)
        Me.txtSeed1.Name = "txtSeed1"
        Me.txtSeed1.Size = New System.Drawing.Size(141, 20)
        Me.txtSeed1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final.My.Resources.Resources._4_Team_Single_Elimination
        Me.PictureBox2.Location = New System.Drawing.Point(4, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(782, 534)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Rand_4_Team_Bracket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 497)
        Me.Controls.Add(Me.lblChampion)
        Me.Controls.Add(Me.lblSeed2R2)
        Me.Controls.Add(Me.lblSeed1R2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtSeed2)
        Me.Controls.Add(Me.txtSeed4)
        Me.Controls.Add(Me.txtSeed1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Rand_4_Team_Bracket"
        Me.Text = "Rand_4_Team_Bracket"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChampion As System.Windows.Forms.Label
    Friend WithEvents lblSeed2R2 As System.Windows.Forms.Label
    Friend WithEvents lblSeed1R2 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSeed2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSeed4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSeed1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
