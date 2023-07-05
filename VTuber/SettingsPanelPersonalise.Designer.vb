<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelPersonalise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelPersonalise))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.HubBackgroundBox = New System.Windows.Forms.GroupBox()
        Me.RB1Box = New System.Windows.Forms.RadioButton()
        Me.HUCSwitch = New System.Windows.Forms.RadioButton()
        Me.HDBSwitch = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB1Button = New System.Windows.Forms.Button()
        Me.HubBackgroundPicture = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CustomColourBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CCEBox = New System.Windows.Forms.CheckBox()
        Me.CustomColourLabel = New System.Windows.Forms.Label()
        Me.CustomColourButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.HubBackgroundBox.SuspendLayout()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.CustomColourBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 14
        '
        'BackButton
        '
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.VTuber.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(53, 53)
        Me.BackButton.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(283, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Personalise your experience..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.HubBackgroundBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Background"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HubBackgroundBox
        '
        Me.HubBackgroundBox.Controls.Add(Me.RB1Box)
        Me.HubBackgroundBox.Controls.Add(Me.HUCSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.HDBSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.Label1)
        Me.HubBackgroundBox.Controls.Add(Me.CB1Button)
        Me.HubBackgroundBox.Controls.Add(Me.HubBackgroundPicture)
        Me.HubBackgroundBox.Location = New System.Drawing.Point(6, 6)
        Me.HubBackgroundBox.Name = "HubBackgroundBox"
        Me.HubBackgroundBox.Size = New System.Drawing.Size(397, 167)
        Me.HubBackgroundBox.TabIndex = 4
        Me.HubBackgroundBox.TabStop = False
        Me.HubBackgroundBox.Text = "Background"
        '
        'RB1Box
        '
        Me.RB1Box.AutoSize = True
        Me.RB1Box.Location = New System.Drawing.Point(220, 109)
        Me.RB1Box.Name = "RB1Box"
        Me.RB1Box.Size = New System.Drawing.Size(130, 17)
        Me.RB1Box.TabIndex = 2
        Me.RB1Box.TabStop = True
        Me.RB1Box.Text = "Custom background"
        Me.RB1Box.UseVisualStyleBackColor = True
        '
        'HUCSwitch
        '
        Me.HUCSwitch.AutoSize = True
        Me.HUCSwitch.Location = New System.Drawing.Point(220, 86)
        Me.HUCSwitch.Name = "HUCSwitch"
        Me.HUCSwitch.Size = New System.Drawing.Size(84, 17)
        Me.HUCSwitch.TabIndex = 1
        Me.HUCSwitch.TabStop = True
        Me.HUCSwitch.Text = "User colour"
        Me.HUCSwitch.UseVisualStyleBackColor = True
        '
        'HDBSwitch
        '
        Me.HDBSwitch.AutoSize = True
        Me.HDBSwitch.Location = New System.Drawing.Point(220, 63)
        Me.HDBSwitch.Name = "HDBSwitch"
        Me.HDBSwitch.Size = New System.Drawing.Size(129, 17)
        Me.HDBSwitch.TabIndex = 0
        Me.HDBSwitch.TabStop = True
        Me.HDBSwitch.Text = "Default background"
        Me.HDBSwitch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 39)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Enabling the background will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "disable the default background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or colour."
        '
        'CB1Button
        '
        Me.CB1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB1Button.Location = New System.Drawing.Point(329, 138)
        Me.CB1Button.Name = "CB1Button"
        Me.CB1Button.Size = New System.Drawing.Size(62, 23)
        Me.CB1Button.TabIndex = 3
        Me.CB1Button.Text = "Browse..."
        Me.CB1Button.UseVisualStyleBackColor = True
        '
        'HubBackgroundPicture
        '
        Me.HubBackgroundPicture.Location = New System.Drawing.Point(6, 21)
        Me.HubBackgroundPicture.Name = "HubBackgroundPicture"
        Me.HubBackgroundPicture.Size = New System.Drawing.Size(208, 140)
        Me.HubBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HubBackgroundPicture.TabIndex = 2
        Me.HubBackgroundPicture.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CustomColourBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colours"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CustomColourBox
        '
        Me.CustomColourBox.Controls.Add(Me.PictureBox2)
        Me.CustomColourBox.Controls.Add(Me.CCEBox)
        Me.CustomColourBox.Controls.Add(Me.CustomColourLabel)
        Me.CustomColourBox.Controls.Add(Me.CustomColourButton)
        Me.CustomColourBox.Location = New System.Drawing.Point(6, 6)
        Me.CustomColourBox.Name = "CustomColourBox"
        Me.CustomColourBox.Size = New System.Drawing.Size(397, 59)
        Me.CustomColourBox.TabIndex = 8
        Me.CustomColourBox.TabStop = False
        Me.CustomColourBox.Text = "Colour"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VTuber.My.Resources.Resources.Colours
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'CCEBox
        '
        Me.CCEBox.AutoSize = True
        Me.CCEBox.Checked = True
        Me.CCEBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CCEBox.Location = New System.Drawing.Point(44, 36)
        Me.CCEBox.Name = "CCEBox"
        Me.CCEBox.Size = New System.Drawing.Size(142, 17)
        Me.CCEBox.TabIndex = 8
        Me.CCEBox.Text = "Enable custom colours"
        Me.CCEBox.UseVisualStyleBackColor = True
        Me.CCEBox.Visible = False
        '
        'CustomColourLabel
        '
        Me.CustomColourLabel.AutoSize = True
        Me.CustomColourLabel.Location = New System.Drawing.Point(41, 21)
        Me.CustomColourLabel.Name = "CustomColourLabel"
        Me.CustomColourLabel.Size = New System.Drawing.Size(230, 13)
        Me.CustomColourLabel.TabIndex = 7
        Me.CustomColourLabel.Text = "Set your own colour by clicking the button."
        '
        'CustomColourButton
        '
        Me.CustomColourButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomColourButton.Location = New System.Drawing.Point(280, 30)
        Me.CustomColourButton.Name = "CustomColourButton"
        Me.CustomColourButton.Size = New System.Drawing.Size(111, 23)
        Me.CustomColourButton.TabIndex = 0
        Me.CustomColourButton.Text = "Select your colour..."
        Me.CustomColourButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SettingsPanelPersonalise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelPersonalise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Personalise"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.HubBackgroundBox.ResumeLayout(False)
        Me.HubBackgroundBox.PerformLayout()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.CustomColourBox.ResumeLayout(False)
        Me.CustomColourBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents HubBackgroundBox As GroupBox
    Friend WithEvents RB1Box As RadioButton
    Friend WithEvents HUCSwitch As RadioButton
    Friend WithEvents HDBSwitch As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CB1Button As Button
    Friend WithEvents HubBackgroundPicture As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CustomColourBox As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CCEBox As CheckBox
    Friend WithEvents CustomColourLabel As Label
    Friend WithEvents CustomColourButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
