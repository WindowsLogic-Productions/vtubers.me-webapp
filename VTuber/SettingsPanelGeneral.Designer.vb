<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelGeneral))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FullScreenBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SysTrayMinimiseBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GPSetLabel = New System.Windows.Forms.Label()
        Me.GPSetButton = New System.Windows.Forms.Button()
        Me.GPText = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.SettingsPanelButton = New System.Windows.Forms.RadioButton()
        Me.SystemTrayButton = New System.Windows.Forms.RadioButton()
        Me.NothingButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AutoBox = New System.Windows.Forms.CheckBox()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.WidgetButton = New System.Windows.Forms.Button()
        Me.WidgetText = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 13
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
        Me.TitleLabel.Size = New System.Drawing.Size(252, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change general settings..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "VTubers.me"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.FullScreenBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 60)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Full Screen"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VTuber.My.Resources.Resources.Fullscreen
        Me.PictureBox3.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'FullScreenBox
        '
        Me.FullScreenBox.AutoSize = True
        Me.FullScreenBox.Location = New System.Drawing.Point(44, 37)
        Me.FullScreenBox.Name = "FullScreenBox"
        Me.FullScreenBox.Size = New System.Drawing.Size(117, 17)
        Me.FullScreenBox.TabIndex = 1
        Me.FullScreenBox.Text = "Enable full screen"
        Me.FullScreenBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Use VTubers.me Web App in full screen."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SysTrayMinimiseBox)
        Me.GroupBox4.Controls.Add(Me.PictureBox7)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 73)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Minimising"
        '
        'SysTrayMinimiseBox
        '
        Me.SysTrayMinimiseBox.AutoSize = True
        Me.SysTrayMinimiseBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SysTrayMinimiseBox.Location = New System.Drawing.Point(44, 49)
        Me.SysTrayMinimiseBox.Name = "SysTrayMinimiseBox"
        Me.SysTrayMinimiseBox.Size = New System.Drawing.Size(151, 18)
        Me.SysTrayMinimiseBox.TabIndex = 2
        Me.SysTrayMinimiseBox.Text = "Minimise to system tray"
        Me.SysTrayMinimiseBox.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.VTuber.My.Resources.Resources.Minimise
        Me.PictureBox7.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(342, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "When minimising Tweeter, it will hide itself in the system tray and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "run in the b" &
    "ackground."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(409, 179)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Profile"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "KNOWN  BUG: Profile will not save after closing the app."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GPSetLabel)
        Me.GroupBox5.Controls.Add(Me.GPSetButton)
        Me.GroupBox5.Controls.Add(Me.GPText)
        Me.GroupBox5.Controls.Add(Me.PictureBox6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(397, 81)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Profile"
        '
        'GPSetLabel
        '
        Me.GPSetLabel.AutoSize = True
        Me.GPSetLabel.Location = New System.Drawing.Point(301, 52)
        Me.GPSetLabel.Name = "GPSetLabel"
        Me.GPSetLabel.Size = New System.Drawing.Size(61, 13)
        Me.GPSetLabel.TabIndex = 4
        Me.GPSetLabel.Text = "Profile set!"
        Me.GPSetLabel.Visible = False
        '
        'GPSetButton
        '
        Me.GPSetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GPSetButton.Location = New System.Drawing.Point(220, 47)
        Me.GPSetButton.Name = "GPSetButton"
        Me.GPSetButton.Size = New System.Drawing.Size(75, 23)
        Me.GPSetButton.TabIndex = 3
        Me.GPSetButton.Text = "Set"
        Me.GPSetButton.UseVisualStyleBackColor = True
        '
        'GPText
        '
        Me.GPText.Location = New System.Drawing.Point(86, 47)
        Me.GPText.Name = "GPText"
        Me.GPText.Size = New System.Drawing.Size(128, 22)
        Me.GPText.TabIndex = 2
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.VTuber.My.Resources.Resources.Social
        Me.PictureBox6.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Set your profile username to access all of VTubers.me."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Start-up"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.SettingsPanelButton)
        Me.GroupBox3.Controls.Add(Me.SystemTrayButton)
        Me.GroupBox3.Controls.Add(Me.NothingButton)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 59)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Start-up"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VTuber.My.Resources.Resources.Start_up
        Me.PictureBox5.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'SettingsPanelButton
        '
        Me.SettingsPanelButton.AutoSize = True
        Me.SettingsPanelButton.Location = New System.Drawing.Point(271, 36)
        Me.SettingsPanelButton.Name = "SettingsPanelButton"
        Me.SettingsPanelButton.Size = New System.Drawing.Size(98, 17)
        Me.SettingsPanelButton.TabIndex = 3
        Me.SettingsPanelButton.TabStop = True
        Me.SettingsPanelButton.Text = "Settings Panel"
        Me.SettingsPanelButton.UseVisualStyleBackColor = True
        '
        'SystemTrayButton
        '
        Me.SystemTrayButton.AutoSize = True
        Me.SystemTrayButton.Location = New System.Drawing.Point(121, 36)
        Me.SystemTrayButton.Name = "SystemTrayButton"
        Me.SystemTrayButton.Size = New System.Drawing.Size(144, 17)
        Me.SystemTrayButton.TabIndex = 2
        Me.SystemTrayButton.TabStop = True
        Me.SystemTrayButton.Text = "Minimise to system tray"
        Me.SystemTrayButton.UseVisualStyleBackColor = True
        '
        'NothingButton
        '
        Me.NothingButton.AutoSize = True
        Me.NothingButton.Location = New System.Drawing.Point(47, 36)
        Me.NothingButton.Name = "NothingButton"
        Me.NothingButton.Size = New System.Drawing.Size(68, 17)
        Me.NothingButton.TabIndex = 1
        Me.NothingButton.TabStop = True
        Me.NothingButton.Text = "Nothing"
        Me.NothingButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Set how you want VTubers.me Web App to start."
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(409, 179)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "OBS Widget"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AutoBox)
        Me.GroupBox2.Controls.Add(Me.LinkLabel5)
        Me.GroupBox2.Controls.Add(Me.LinkLabel4)
        Me.GroupBox2.Controls.Add(Me.LinkLabel3)
        Me.GroupBox2.Controls.Add(Me.LinkLabel2)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.WidgetButton)
        Me.GroupBox2.Controls.Add(Me.WidgetText)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 167)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OBS Widget"
        '
        'AutoBox
        '
        Me.AutoBox.AutoSize = True
        Me.AutoBox.Location = New System.Drawing.Point(300, 144)
        Me.AutoBox.Name = "AutoBox"
        Me.AutoBox.Size = New System.Drawing.Size(91, 17)
        Me.AutoBox.TabIndex = 9
        Me.AutoBox.Text = "Auto-refresh"
        Me.ToolTip1.SetToolTip(Me.AutoBox, "Auto-refresh the feed you're on every 10 seconds while streaming.")
        Me.AutoBox.UseVisualStyleBackColor = True
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(41, 120)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel5.TabIndex = 8
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "#VtuberUprising"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(235, 95)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel4.TabIndex = 7
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "#VtuberSupport"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(165, 95)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel3.TabIndex = 6
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "#PNGtuber"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(110, 95)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(49, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "#Vtuber"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(41, 95)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "#ENVtuber"
        '
        'WidgetButton
        '
        Me.WidgetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.WidgetButton.Location = New System.Drawing.Point(282, 50)
        Me.WidgetButton.Name = "WidgetButton"
        Me.WidgetButton.Size = New System.Drawing.Size(90, 23)
        Me.WidgetButton.TabIndex = 3
        Me.WidgetButton.Text = "Start Widget"
        Me.ToolTip1.SetToolTip(Me.WidgetButton, "Start the OBS Widget with the specified URL.")
        Me.WidgetButton.UseVisualStyleBackColor = True
        '
        'WidgetText
        '
        Me.WidgetText.Location = New System.Drawing.Point(44, 50)
        Me.WidgetText.Name = "WidgetText"
        Me.WidgetText.Size = New System.Drawing.Size(232, 22)
        Me.WidgetText.TabIndex = 2
        Me.WidgetText.Text = "https://vtubers.me/"
        Me.ToolTip1.SetToolTip(Me.WidgetText, "Insert a URL you want for the widget.")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VTuber.My.Resources.Resources.vtubers1
        Me.PictureBox4.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(331, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Choose a hashtag or type a URL to open so you can share it on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "stream."
        '
        'SettingsPanelGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > General"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SysTrayMinimiseBox As CheckBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SettingsPanelButton As RadioButton
    Friend WithEvents SystemTrayButton As RadioButton
    Friend WithEvents NothingButton As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents FullScreenBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GPSetLabel As Label
    Friend WithEvents GPSetButton As Button
    Friend WithEvents GPText As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AutoBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents WidgetButton As Button
    Friend WithEvents WidgetText As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
End Class
