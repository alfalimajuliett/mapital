<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlienAlbert
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlienAlbert))
        Me.USA = New System.Windows.Forms.PictureBox()
        Me.AlienUser = New System.Windows.Forms.PictureBox()
        Me.btnMoveAlien = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnMission = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSaveScore = New System.Windows.Forms.Button()
        CType(Me.USA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlienUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USA
        '
        Me.USA.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.USA.Image = CType(resources.GetObject("USA.Image"), System.Drawing.Image)
        Me.USA.Location = New System.Drawing.Point(12, 12)
        Me.USA.Name = "USA"
        Me.USA.Size = New System.Drawing.Size(758, 555)
        Me.USA.TabIndex = 0
        Me.USA.TabStop = False
        '
        'AlienUser
        '
        Me.AlienUser.BackColor = System.Drawing.Color.Yellow
        Me.AlienUser.Image = CType(resources.GetObject("AlienUser.Image"), System.Drawing.Image)
        Me.AlienUser.Location = New System.Drawing.Point(278, 173)
        Me.AlienUser.Name = "AlienUser"
        Me.AlienUser.Size = New System.Drawing.Size(18, 23)
        Me.AlienUser.TabIndex = 1
        Me.AlienUser.TabStop = False
        '
        'btnMoveAlien
        '
        Me.btnMoveAlien.BackColor = System.Drawing.Color.Black
        Me.btnMoveAlien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveAlien.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnMoveAlien.Location = New System.Drawing.Point(466, 31)
        Me.btnMoveAlien.Name = "btnMoveAlien"
        Me.btnMoveAlien.Size = New System.Drawing.Size(198, 36)
        Me.btnMoveAlien.TabIndex = 2
        Me.btnMoveAlien.Text = "Invade State!"
        Me.btnMoveAlien.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(573, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Quit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnScore
        '
        Me.btnScore.BackColor = System.Drawing.Color.Black
        Me.btnScore.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnScore.Location = New System.Drawing.Point(466, 73)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(101, 33)
        Me.btnScore.TabIndex = 4
        Me.btnScore.Text = "Show Score"
        Me.btnScore.UseVisualStyleBackColor = False
        '
        'btnMission
        '
        Me.btnMission.BackColor = System.Drawing.Color.Black
        Me.btnMission.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnMission.Location = New System.Drawing.Point(573, 122)
        Me.btnMission.Name = "btnMission"
        Me.btnMission.Size = New System.Drawing.Size(91, 32)
        Me.btnMission.TabIndex = 5
        Me.btnMission.Text = "&Mission"
        Me.btnMission.UseVisualStyleBackColor = False
        '
        'btnSaveScore
        '
        Me.btnSaveScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSaveScore.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnSaveScore.Location = New System.Drawing.Point(466, 122)
        Me.btnSaveScore.Name = "btnSaveScore"
        Me.btnSaveScore.Size = New System.Drawing.Size(101, 32)
        Me.btnSaveScore.TabIndex = 6
        Me.btnSaveScore.Text = "&Save Score"
        Me.btnSaveScore.UseVisualStyleBackColor = False
        '
        'AlienAlbert
        '
        Me.AcceptButton = Me.btnMoveAlien
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(779, 579)
        Me.Controls.Add(Me.btnSaveScore)
        Me.Controls.Add(Me.btnMission)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMoveAlien)
        Me.Controls.Add(Me.AlienUser)
        Me.Controls.Add(Me.USA)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "AlienAlbert"
        Me.Text = "Alien Albert Visits the United States of America"
        CType(Me.USA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlienUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents USA As System.Windows.Forms.PictureBox
    Friend WithEvents AlienUser As System.Windows.Forms.PictureBox
    Friend WithEvents btnMoveAlien As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnScore As System.Windows.Forms.Button
    Friend WithEvents btnMission As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnSaveScore As System.Windows.Forms.Button

End Class
