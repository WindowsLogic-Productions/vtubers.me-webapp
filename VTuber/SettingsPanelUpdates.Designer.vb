<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelUpdates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelUpdates))
        Me.UpdateBanner = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EnableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DisableUpdates = New System.Windows.Forms.RadioButton()
        Me.UpdateStatus = New System.Windows.Forms.PictureBox()
        Me.ManualUpdateButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UpdateBanner.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateBanner
        '
        Me.UpdateBanner.BackColor = System.Drawing.Color.White
        Me.UpdateBanner.Controls.Add(Me.BackButton)
        Me.UpdateBanner.Controls.Add(Me.TitleLabel)
        Me.UpdateBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpdateBanner.Location = New System.Drawing.Point(0, 0)
        Me.UpdateBanner.Name = "UpdateBanner"
        Me.UpdateBanner.Size = New System.Drawing.Size(441, 53)
        Me.UpdateBanner.TabIndex = 15
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
        Me.TitleLabel.Size = New System.Drawing.Size(248, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change update settings..."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 67
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.UpdateStatus)
        Me.TabPage1.Controls.Add(Me.ManualUpdateButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Updates"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.EnableUpdates)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.DisableUpdates)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 128)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 26)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "VTubers.me Web App can check for updates automatically when starting. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will" &
    " ensure that your version of the application is up to date."
        '
        'EnableUpdates
        '
        Me.EnableUpdates.AutoSize = True
        Me.EnableUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EnableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUpdates.Location = New System.Drawing.Point(44, 47)
        Me.EnableUpdates.Name = "EnableUpdates"
        Me.EnableUpdates.Size = New System.Drawing.Size(193, 18)
        Me.EnableUpdates.TabIndex = 41
        Me.EnableUpdates.Text = "Enable updates (recommended)"
        Me.EnableUpdates.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(44, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Do not check for updates automatically."
        '
        'PictureBox4
        '
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.VTuber.My.Resources.Resources.Updates_On
        Me.PictureBox4.Location = New System.Drawing.Point(6, 47)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(44, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Check for updates at start-up."
        '
        'PictureBox5
        '
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.VTuber.My.Resources.Resources.Updates_Off
        Me.PictureBox5.Location = New System.Drawing.Point(6, 85)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 47
        Me.PictureBox5.TabStop = False
        '
        'DisableUpdates
        '
        Me.DisableUpdates.AutoSize = True
        Me.DisableUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DisableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisableUpdates.Location = New System.Drawing.Point(44, 85)
        Me.DisableUpdates.Name = "DisableUpdates"
        Me.DisableUpdates.Size = New System.Drawing.Size(217, 18)
        Me.DisableUpdates.TabIndex = 43
        Me.DisableUpdates.Text = "Disable updates (not recommended)"
        Me.DisableUpdates.UseVisualStyleBackColor = True
        '
        'UpdateStatus
        '
        Me.UpdateStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateStatus.Image = Global.VTuber.My.Resources.Resources.GoodGradient
        Me.UpdateStatus.Location = New System.Drawing.Point(0, 0)
        Me.UpdateStatus.Name = "UpdateStatus"
        Me.UpdateStatus.Size = New System.Drawing.Size(409, 10)
        Me.UpdateStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UpdateStatus.TabIndex = 45
        Me.UpdateStatus.TabStop = False
        '
        'ManualUpdateButton
        '
        Me.ManualUpdateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManualUpdateButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.ManualUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ManualUpdateButton.ForeColor = System.Drawing.Color.White
        Me.ManualUpdateButton.Location = New System.Drawing.Point(262, 150)
        Me.ManualUpdateButton.Name = "ManualUpdateButton"
        Me.ManualUpdateButton.Size = New System.Drawing.Size(141, 23)
        Me.ManualUpdateButton.TabIndex = 44
        Me.ManualUpdateButton.Text = "Force Update Check"
        Me.ManualUpdateButton.UseVisualStyleBackColor = False
        '
        'SettingsPanelUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UpdateBanner)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelUpdates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Updates"
        Me.TopMost = True
        Me.UpdateBanner.ResumeLayout(False)
        Me.UpdateBanner.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdateBanner As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EnableUpdates As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DisableUpdates As RadioButton
    Friend WithEvents UpdateStatus As PictureBox
    Friend WithEvents ManualUpdateButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
