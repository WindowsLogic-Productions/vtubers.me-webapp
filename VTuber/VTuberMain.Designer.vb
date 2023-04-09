<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VTuberMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VTuberMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Back_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Forward_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Refresh_TSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Home_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Notification_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Messages_TSB = New System.Windows.Forms.ToolStripButton()
        Me.More_TSB = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExploreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Profile_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lists_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mentions_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToUser_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Account_TSB = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TwitterSettings_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTwitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Application_TSB = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanel_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdates_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsNew_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.About_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Restore_TMO = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TweetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit_TMO = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HubBackground = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SysTrayMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.HubBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Back_TSB, Me.Forward_TSB, Me.Refresh_TSB, Me.ToolStripSeparator5, Me.Home_TSB, Me.Notification_TSB, Me.Messages_TSB, Me.More_TSB, Me.ToolStripSeparator6, Me.Account_TSB, Me.ToolStripSeparator8, Me.Application_TSB})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 39)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Back_TSB
        '
        Me.Back_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Back_TSB.Image = Global.VTuber.My.Resources.Resources.Back
        Me.Back_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Back_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Back_TSB.Name = "Back_TSB"
        Me.Back_TSB.Size = New System.Drawing.Size(36, 36)
        Me.Back_TSB.Text = "Back"
        '
        'Forward_TSB
        '
        Me.Forward_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Forward_TSB.Image = Global.VTuber.My.Resources.Resources.Forward
        Me.Forward_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Forward_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Forward_TSB.Name = "Forward_TSB"
        Me.Forward_TSB.Size = New System.Drawing.Size(36, 36)
        Me.Forward_TSB.Text = "Forward"
        '
        'Refresh_TSB
        '
        Me.Refresh_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Refresh_TSB.Image = Global.VTuber.My.Resources.Resources.Refresh
        Me.Refresh_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Refresh_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refresh_TSB.Name = "Refresh_TSB"
        Me.Refresh_TSB.Size = New System.Drawing.Size(36, 36)
        Me.Refresh_TSB.Text = "Refresh"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'Home_TSB
        '
        Me.Home_TSB.Image = Global.VTuber.My.Resources.Resources.Home
        Me.Home_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Home_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Home_TSB.Name = "Home_TSB"
        Me.Home_TSB.Size = New System.Drawing.Size(76, 36)
        Me.Home_TSB.Text = "Home"
        Me.Home_TSB.ToolTipText = "Go to your VTubers.me home feed."
        '
        'Notification_TSB
        '
        Me.Notification_TSB.Image = Global.VTuber.My.Resources.Resources.Notification
        Me.Notification_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Notification_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Notification_TSB.Name = "Notification_TSB"
        Me.Notification_TSB.Size = New System.Drawing.Size(111, 36)
        Me.Notification_TSB.Text = "Notifications"
        Me.Notification_TSB.ToolTipText = "Go to your VTubers.me notifications."
        '
        'Messages_TSB
        '
        Me.Messages_TSB.Image = Global.VTuber.My.Resources.Resources.Mail
        Me.Messages_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Messages_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Messages_TSB.Name = "Messages_TSB"
        Me.Messages_TSB.Size = New System.Drawing.Size(94, 36)
        Me.Messages_TSB.Text = "Messages"
        Me.Messages_TSB.ToolTipText = "Go to your VTubers.me messages."
        '
        'More_TSB
        '
        Me.More_TSB.BackColor = System.Drawing.Color.Transparent
        Me.More_TSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExploreToolStripMenuItem, Me.Profile_TSM, Me.Lists_TSM, Me.Mentions_TSM, Me.GoToUser_TSM})
        Me.More_TSB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.More_TSB.Image = Global.VTuber.My.Resources.Resources.More
        Me.More_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.More_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.More_TSB.Name = "More_TSB"
        Me.More_TSB.Size = New System.Drawing.Size(80, 36)
        Me.More_TSB.Text = "More"
        Me.More_TSB.ToolTipText = "View more options."
        '
        'ExploreToolStripMenuItem
        '
        Me.ExploreToolStripMenuItem.Image = Global.VTuber.My.Resources.Resources.Search
        Me.ExploreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExploreToolStripMenuItem.Name = "ExploreToolStripMenuItem"
        Me.ExploreToolStripMenuItem.Size = New System.Drawing.Size(153, 38)
        Me.ExploreToolStripMenuItem.Text = "Explore"
        Me.ExploreToolStripMenuItem.ToolTipText = "Go to the VTubers.me explore page."
        '
        'Profile_TSM
        '
        Me.Profile_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Profile_TSM.Image = Global.VTuber.My.Resources.Resources.Social
        Me.Profile_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Profile_TSM.Name = "Profile_TSM"
        Me.Profile_TSM.Size = New System.Drawing.Size(153, 38)
        Me.Profile_TSM.Text = "Profile"
        Me.Profile_TSM.ToolTipText = "Go to your VTubers.me profile."
        '
        'Lists_TSM
        '
        Me.Lists_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Lists_TSM.Image = Global.VTuber.My.Resources.Resources.Analytics
        Me.Lists_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Lists_TSM.Name = "Lists_TSM"
        Me.Lists_TSM.Size = New System.Drawing.Size(153, 38)
        Me.Lists_TSM.Text = "Trending"
        Me.Lists_TSM.ToolTipText = "Go to the VTubers.me trending page."
        '
        'Mentions_TSM
        '
        Me.Mentions_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Mentions_TSM.Image = Global.VTuber.My.Resources.Resources.Mention
        Me.Mentions_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Mentions_TSM.Name = "Mentions_TSM"
        Me.Mentions_TSM.Size = New System.Drawing.Size(153, 38)
        Me.Mentions_TSM.Text = "Mentions"
        Me.Mentions_TSM.ToolTipText = "Go to your VTubers.me mentions."
        '
        'GoToUser_TSM
        '
        Me.GoToUser_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.GoToUser_TSM.Image = Global.VTuber.My.Resources.Resources.GoToUser
        Me.GoToUser_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GoToUser_TSM.Name = "GoToUser_TSM"
        Me.GoToUser_TSM.Size = New System.Drawing.Size(153, 38)
        Me.GoToUser_TSM.Text = "Go to user..."
        Me.GoToUser_TSM.ToolTipText = "Go to a specified VTubers.me user's profile."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'Account_TSB
        '
        Me.Account_TSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TwitterSettings_TSM, Me.AboutTwitterToolStripMenuItem1, Me.ToolStripSeparator10, Me.LogOutToolStripMenuItem1})
        Me.Account_TSB.Image = Global.VTuber.My.Resources.Resources.Social
        Me.Account_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Account_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Account_TSB.Name = "Account_TSB"
        Me.Account_TSB.Size = New System.Drawing.Size(97, 36)
        Me.Account_TSB.Text = "Account"
        Me.Account_TSB.ToolTipText = "Control your VTubers.me account."
        '
        'TwitterSettings_TSM
        '
        Me.TwitterSettings_TSM.Image = Global.VTuber.My.Resources.Resources.vtubers1
        Me.TwitterSettings_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TwitterSettings_TSM.Name = "TwitterSettings_TSM"
        Me.TwitterSettings_TSM.Size = New System.Drawing.Size(197, 38)
        Me.TwitterSettings_TSM.Text = "VTubers.me settings"
        Me.TwitterSettings_TSM.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.TwitterSettings_TSM.ToolTipText = "View and manage your Vtubers.me settings."
        '
        'AboutTwitterToolStripMenuItem1
        '
        Me.AboutTwitterToolStripMenuItem1.Image = Global.VTuber.My.Resources.Resources.vtubers1
        Me.AboutTwitterToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutTwitterToolStripMenuItem1.Name = "AboutTwitterToolStripMenuItem1"
        Me.AboutTwitterToolStripMenuItem1.Size = New System.Drawing.Size(197, 38)
        Me.AboutTwitterToolStripMenuItem1.Text = "About VTubers.me"
        Me.AboutTwitterToolStripMenuItem1.ToolTipText = "Learn more about VTubers.me."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(194, 6)
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Image = Global.VTuber.My.Resources.Resources.LogOut
        Me.LogOutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(197, 38)
        Me.LogOutToolStripMenuItem1.Text = "Log out"
        Me.LogOutToolStripMenuItem1.ToolTipText = "Log out of the current VTubers.me user."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'Application_TSB
        '
        Me.Application_TSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.SettingsPanel_TSM, Me.ToolStripSeparator1, Me.CheckForUpdates_TSM, Me.WhatsNew_TSM, Me.SendFeedbackToolStripMenuItem, Me.ToolStripSeparator2, Me.About_TSM, Me.ToolStripSeparator9, Me.Exit_TSM})
        Me.Application_TSB.Image = Global.VTuber.My.Resources.Resources.NewWindow
        Me.Application_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Application_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Application_TSB.Name = "Application_TSB"
        Me.Application_TSB.Size = New System.Drawing.Size(113, 36)
        Me.Application_TSB.Text = "Application"
        Me.Application_TSB.ToolTipText = "Control VTubers.me Web App and its settings."
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Image = Global.VTuber.My.Resources.Resources.NewWindow
        Me.NewWindowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.NewWindowToolStripMenuItem.Text = "New window"
        Me.NewWindowToolStripMenuItem.ToolTipText = "Open a new window."
        '
        'SettingsPanel_TSM
        '
        Me.SettingsPanel_TSM.Image = Global.VTuber.My.Resources.Resources.Settings
        Me.SettingsPanel_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanel_TSM.Name = "SettingsPanel_TSM"
        Me.SettingsPanel_TSM.Size = New System.Drawing.Size(196, 38)
        Me.SettingsPanel_TSM.Text = "Settings Panel"
        Me.SettingsPanel_TSM.ToolTipText = "Customise the settings of VTubers.me Web App."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'CheckForUpdates_TSM
        '
        Me.CheckForUpdates_TSM.Enabled = False
        Me.CheckForUpdates_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdates_TSM.Name = "CheckForUpdates_TSM"
        Me.CheckForUpdates_TSM.Size = New System.Drawing.Size(196, 38)
        Me.CheckForUpdates_TSM.Text = "Check for updates..."
        Me.CheckForUpdates_TSM.ToolTipText = "Check if you have the latest version."
        '
        'WhatsNew_TSM
        '
        Me.WhatsNew_TSM.Image = Global.VTuber.My.Resources.Resources.Changes
        Me.WhatsNew_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WhatsNew_TSM.Name = "WhatsNew_TSM"
        Me.WhatsNew_TSM.Size = New System.Drawing.Size(196, 38)
        Me.WhatsNew_TSM.Text = "What's new?"
        Me.WhatsNew_TSM.ToolTipText = "See what's changed."
        '
        'SendFeedbackToolStripMenuItem
        '
        Me.SendFeedbackToolStripMenuItem.Image = Global.VTuber.My.Resources.Resources.Feedback
        Me.SendFeedbackToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem"
        Me.SendFeedbackToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.SendFeedbackToolStripMenuItem.Text = "Send feedback..."
        Me.SendFeedbackToolStripMenuItem.ToolTipText = "Tell us what you think."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'About_TSM
        '
        Me.About_TSM.Image = Global.VTuber.My.Resources.Resources.Information
        Me.About_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.About_TSM.Name = "About_TSM"
        Me.About_TSM.Size = New System.Drawing.Size(196, 38)
        Me.About_TSM.Text = "About VTuber"
        Me.About_TSM.ToolTipText = "View legal information about Tweeter."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(193, 6)
        '
        'Exit_TSM
        '
        Me.Exit_TSM.Image = Global.VTuber.My.Resources.Resources._Exit
        Me.Exit_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Exit_TSM.Name = "Exit_TSM"
        Me.Exit_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.Exit_TSM.Size = New System.Drawing.Size(196, 38)
        Me.Exit_TSM.Text = "Exit"
        Me.Exit_TSM.ToolTipText = "End the application process."
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(0, 39)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(784, 422)
        Me.WebView21.Source = New System.Uri("https://vtubers.me/", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 11
        Me.WebView21.ZoomFactor = 1.0R
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SysTrayIcon
        '
        Me.SysTrayIcon.ContextMenuStrip = Me.SysTrayMenu
        Me.SysTrayIcon.Icon = CType(resources.GetObject("SysTrayIcon.Icon"), System.Drawing.Icon)
        Me.SysTrayIcon.Text = "VTuber"
        Me.SysTrayIcon.Visible = True
        '
        'SysTrayMenu
        '
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Restore_TMO, Me.ToolStripSeparator4, Me.TweetToolStripMenuItem, Me.SettingsPanelToolStripMenuItem, Me.ToolStripSeparator13, Me.Exit_TMO})
        Me.SysTrayMenu.Name = "SysTrayMenu"
        Me.SysTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SysTrayMenu.Size = New System.Drawing.Size(165, 168)
        '
        'Restore_TMO
        '
        Me.Restore_TMO.Image = Global.VTuber.My.Resources.Resources.Restore
        Me.Restore_TMO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Restore_TMO.Name = "Restore_TMO"
        Me.Restore_TMO.Size = New System.Drawing.Size(164, 38)
        Me.Restore_TMO.Text = "Restore"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(161, 6)
        '
        'TweetToolStripMenuItem
        '
        Me.TweetToolStripMenuItem.Enabled = False
        Me.TweetToolStripMenuItem.Image = Global.VTuber.My.Resources.Resources.Twitter_Compose
        Me.TweetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TweetToolStripMenuItem.Name = "TweetToolStripMenuItem"
        Me.TweetToolStripMenuItem.Size = New System.Drawing.Size(164, 38)
        Me.TweetToolStripMenuItem.Text = "Post"
        '
        'SettingsPanelToolStripMenuItem
        '
        Me.SettingsPanelToolStripMenuItem.Enabled = False
        Me.SettingsPanelToolStripMenuItem.Image = Global.VTuber.My.Resources.Resources.Settings
        Me.SettingsPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem.Name = "SettingsPanelToolStripMenuItem"
        Me.SettingsPanelToolStripMenuItem.Size = New System.Drawing.Size(164, 38)
        Me.SettingsPanelToolStripMenuItem.Text = "Settings Panel"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(161, 6)
        '
        'Exit_TMO
        '
        Me.Exit_TMO.Image = Global.VTuber.My.Resources.Resources._Exit
        Me.Exit_TMO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Exit_TMO.Name = "Exit_TMO"
        Me.Exit_TMO.Size = New System.Drawing.Size(164, 38)
        Me.Exit_TMO.Text = "Exit"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 30000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WebView21)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.HubBackground)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 461)
        Me.Panel1.TabIndex = 12
        '
        'HubBackground
        '
        Me.HubBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HubBackground.Image = Global.VTuber.My.Resources.Resources.WLPBackground
        Me.HubBackground.Location = New System.Drawing.Point(0, 0)
        Me.HubBackground.Name = "HubBackground"
        Me.HubBackground.Size = New System.Drawing.Size(784, 461)
        Me.HubBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HubBackground.TabIndex = 0
        Me.HubBackground.TabStop = False
        '
        'VTuberMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(350, 400)
        Me.Name = "VTuberMain"
        Me.Text = "VTuber"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SysTrayMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HubBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Back_TSB As ToolStripButton
    Friend WithEvents Forward_TSB As ToolStripButton
    Friend WithEvents Refresh_TSB As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Home_TSB As ToolStripButton
    Friend WithEvents Notification_TSB As ToolStripButton
    Friend WithEvents Messages_TSB As ToolStripButton
    Friend WithEvents More_TSB As ToolStripDropDownButton
    Friend WithEvents Profile_TSM As ToolStripMenuItem
    Friend WithEvents Lists_TSM As ToolStripMenuItem
    Friend WithEvents Mentions_TSM As ToolStripMenuItem
    Friend WithEvents GoToUser_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Account_TSB As ToolStripDropDownButton
    Friend WithEvents TwitterSettings_TSM As ToolStripMenuItem
    Friend WithEvents AboutTwitterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents LogOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Application_TSB As ToolStripDropDownButton
    Friend WithEvents SettingsPanel_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CheckForUpdates_TSM As ToolStripMenuItem
    Friend WithEvents WhatsNew_TSM As ToolStripMenuItem
    Friend WithEvents SendFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents About_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents Exit_TSM As ToolStripMenuItem
    Friend WithEvents ExploreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SysTrayIcon As NotifyIcon
    Friend WithEvents SysTrayMenu As ContextMenuStrip
    Friend WithEvents Restore_TMO As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TweetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents Exit_TMO As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HubBackground As PictureBox
End Class
