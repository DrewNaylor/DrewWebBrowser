﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class browserMainWindow
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelsplitWindowGlue = New System.Windows.Forms.SplitContainer()
        Me.buttonRemoveTab = New System.Windows.Forms.Button()
        Me.buttonNewTab = New System.Windows.Forms.Button()
        Me.forwardButton = New System.Windows.Forms.Button()
        Me.buttonStopLoading = New System.Windows.Forms.Button()
        Me.buttonReload = New System.Windows.Forms.Button()
        Me.buttonBack = New System.Windows.Forms.Button()
        Me.goButton = New System.Windows.Forms.Button()
        Me.urlBox = New System.Windows.Forms.ComboBox()
        Me.menubarAContainer = New System.Windows.Forms.MenuStrip()
        Me.menubarFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarFile_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarView = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarView_GoToMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarView_GoToMenu_Back = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarView_GoToMenu_Forward = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarZSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menubarView_GoToMenu_HomePage = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarView_Stop = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarView_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelp_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabcontrolWebBrowserView = New System.Windows.Forms.TabControl()
        Me.panelStatusBar = New System.Windows.Forms.StatusStrip()
        Me.menuitemViewInTridentTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelMain.SuspendLayout()
        CType(Me.panelsplitWindowGlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelsplitWindowGlue.Panel1.SuspendLayout()
        Me.panelsplitWindowGlue.Panel2.SuspendLayout()
        Me.panelsplitWindowGlue.SuspendLayout()
        Me.menubarAContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelsplitWindowGlue)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1260, 702)
        Me.panelMain.TabIndex = 0
        '
        'panelsplitWindowGlue
        '
        Me.panelsplitWindowGlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelsplitWindowGlue.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.panelsplitWindowGlue.Location = New System.Drawing.Point(0, 0)
        Me.panelsplitWindowGlue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelsplitWindowGlue.MinimumSize = New System.Drawing.Size(990, 679)
        Me.panelsplitWindowGlue.Name = "panelsplitWindowGlue"
        Me.panelsplitWindowGlue.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'panelsplitWindowGlue.Panel1
        '
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.buttonRemoveTab)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.buttonNewTab)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.forwardButton)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.buttonStopLoading)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.buttonReload)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.buttonBack)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.goButton)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.urlBox)
        Me.panelsplitWindowGlue.Panel1.Controls.Add(Me.menubarAContainer)
        Me.panelsplitWindowGlue.Panel1MinSize = 57
        '
        'panelsplitWindowGlue.Panel2
        '
        Me.panelsplitWindowGlue.Panel2.Controls.Add(Me.tabcontrolWebBrowserView)
        Me.panelsplitWindowGlue.Panel2.Controls.Add(Me.panelStatusBar)
        Me.panelsplitWindowGlue.Size = New System.Drawing.Size(1260, 702)
        Me.panelsplitWindowGlue.SplitterDistance = 67
        Me.panelsplitWindowGlue.SplitterWidth = 1
        Me.panelsplitWindowGlue.TabIndex = 2
        '
        'buttonRemoveTab
        '
        Me.buttonRemoveTab.Location = New System.Drawing.Point(278, 4)
        Me.buttonRemoveTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonRemoveTab.Name = "buttonRemoveTab"
        Me.buttonRemoveTab.Size = New System.Drawing.Size(114, 29)
        Me.buttonRemoveTab.TabIndex = 9
        Me.buttonRemoveTab.Text = "Remove Tab"
        Me.buttonRemoveTab.UseVisualStyleBackColor = True
        '
        'buttonNewTab
        '
        Me.buttonNewTab.Location = New System.Drawing.Point(176, 4)
        Me.buttonNewTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonNewTab.Name = "buttonNewTab"
        Me.buttonNewTab.Size = New System.Drawing.Size(94, 29)
        Me.buttonNewTab.TabIndex = 8
        Me.buttonNewTab.Text = "New Tab"
        Me.buttonNewTab.UseVisualStyleBackColor = True
        '
        'forwardButton
        '
        Me.forwardButton.AutoSize = True
        Me.forwardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.forwardButton.Location = New System.Drawing.Point(64, 38)
        Me.forwardButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.forwardButton.Name = "forwardButton"
        Me.forwardButton.Size = New System.Drawing.Size(69, 27)
        Me.forwardButton.TabIndex = 2
        Me.forwardButton.Text = "Forward"
        Me.forwardButton.UseVisualStyleBackColor = True
        '
        'buttonStopLoading
        '
        Me.buttonStopLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonStopLoading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonStopLoading.Location = New System.Drawing.Point(1210, 36)
        Me.buttonStopLoading.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonStopLoading.Name = "buttonStopLoading"
        Me.buttonStopLoading.Size = New System.Drawing.Size(46, 30)
        Me.buttonStopLoading.TabIndex = 6
        Me.buttonStopLoading.Text = "Stop"
        Me.buttonStopLoading.UseVisualStyleBackColor = True
        '
        'buttonReload
        '
        Me.buttonReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonReload.Location = New System.Drawing.Point(1132, 37)
        Me.buttonReload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonReload.Name = "buttonReload"
        Me.buttonReload.Size = New System.Drawing.Size(62, 28)
        Me.buttonReload.TabIndex = 3
        Me.buttonReload.Text = "Reload"
        Me.buttonReload.UseVisualStyleBackColor = True
        '
        'buttonBack
        '
        Me.buttonBack.AutoSize = True
        Me.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonBack.Location = New System.Drawing.Point(4, 38)
        Me.buttonBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonBack.Name = "buttonBack"
        Me.buttonBack.Size = New System.Drawing.Size(49, 27)
        Me.buttonBack.TabIndex = 1
        Me.buttonBack.Text = "Back"
        Me.buttonBack.UseVisualStyleBackColor = True
        '
        'goButton
        '
        Me.goButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.goButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.goButton.Location = New System.Drawing.Point(1088, 38)
        Me.goButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(36, 27)
        Me.goButton.TabIndex = 5
        Me.goButton.Text = "Go"
        Me.goButton.UseVisualStyleBackColor = True
        '
        'urlBox
        '
        Me.urlBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.urlBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.urlBox.FormattingEnabled = True
        Me.urlBox.Items.AddRange(New Object() {"bing.com", "google.com", "facebook.com", "outlook.com", "momandpophops.com"})
        Me.urlBox.Location = New System.Drawing.Point(140, 40)
        Me.urlBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.urlBox.Name = "urlBox"
        Me.urlBox.Size = New System.Drawing.Size(939, 24)
        Me.urlBox.TabIndex = 4
        '
        'menubarAContainer
        '
        Me.menubarAContainer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menubarAContainer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFile, Me.menubarView, Me.menubarHelp})
        Me.menubarAContainer.Location = New System.Drawing.Point(0, 0)
        Me.menubarAContainer.Name = "menubarAContainer"
        Me.menubarAContainer.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menubarAContainer.Size = New System.Drawing.Size(1260, 28)
        Me.menubarAContainer.TabIndex = 7
        Me.menubarAContainer.Text = "MenuStrip1"
        '
        'menubarFile
        '
        Me.menubarFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFile_Exit, Me.menuitemViewInTridentTab})
        Me.menubarFile.Name = "menubarFile"
        Me.menubarFile.Size = New System.Drawing.Size(44, 24)
        Me.menubarFile.Text = "&File"
        '
        'menubarFile_Exit
        '
        Me.menubarFile_Exit.Name = "menubarFile_Exit"
        Me.menubarFile_Exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.menubarFile_Exit.Size = New System.Drawing.Size(257, 26)
        Me.menubarFile_Exit.Text = "E&xit"
        '
        'menubarView
        '
        Me.menubarView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarView_GoToMenu, Me.menubarView_Stop, Me.menubarView_Refresh})
        Me.menubarView.Name = "menubarView"
        Me.menubarView.Size = New System.Drawing.Size(53, 24)
        Me.menubarView.Text = "&View"
        '
        'menubarView_GoToMenu
        '
        Me.menubarView_GoToMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarView_GoToMenu_Back, Me.menubarView_GoToMenu_Forward, Me.menubarZSeperator1, Me.menubarView_GoToMenu_HomePage})
        Me.menubarView_GoToMenu.Name = "menubarView_GoToMenu"
        Me.menubarView_GoToMenu.Size = New System.Drawing.Size(205, 26)
        Me.menubarView_GoToMenu.Text = "&Go to"
        '
        'menubarView_GoToMenu_Back
        '
        Me.menubarView_GoToMenu_Back.Name = "menubarView_GoToMenu_Back"
        Me.menubarView_GoToMenu_Back.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.menubarView_GoToMenu_Back.Size = New System.Drawing.Size(257, 26)
        Me.menubarView_GoToMenu_Back.Text = "&Back"
        '
        'menubarView_GoToMenu_Forward
        '
        Me.menubarView_GoToMenu_Forward.Name = "menubarView_GoToMenu_Forward"
        Me.menubarView_GoToMenu_Forward.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.menubarView_GoToMenu_Forward.Size = New System.Drawing.Size(257, 26)
        Me.menubarView_GoToMenu_Forward.Text = "&Forward"
        '
        'menubarZSeperator1
        '
        Me.menubarZSeperator1.Name = "menubarZSeperator1"
        Me.menubarZSeperator1.Size = New System.Drawing.Size(254, 6)
        '
        'menubarView_GoToMenu_HomePage
        '
        Me.menubarView_GoToMenu_HomePage.Name = "menubarView_GoToMenu_HomePage"
        Me.menubarView_GoToMenu_HomePage.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.menubarView_GoToMenu_HomePage.Size = New System.Drawing.Size(257, 26)
        Me.menubarView_GoToMenu_HomePage.Text = "&Home Page"
        '
        'menubarView_Stop
        '
        Me.menubarView_Stop.Name = "menubarView_Stop"
        Me.menubarView_Stop.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.menubarView_Stop.Size = New System.Drawing.Size(205, 26)
        Me.menubarView_Stop.Text = "Sto&p"
        '
        'menubarView_Refresh
        '
        Me.menubarView_Refresh.Name = "menubarView_Refresh"
        Me.menubarView_Refresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.menubarView_Refresh.Size = New System.Drawing.Size(205, 26)
        Me.menubarView_Refresh.Text = "&Refresh"
        '
        'menubarHelp
        '
        Me.menubarHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarHelp_About})
        Me.menubarHelp.Name = "menubarHelp"
        Me.menubarHelp.Size = New System.Drawing.Size(53, 24)
        Me.menubarHelp.Text = "Help"
        '
        'menubarHelp_About
        '
        Me.menubarHelp_About.Name = "menubarHelp_About"
        Me.menubarHelp_About.Size = New System.Drawing.Size(125, 26)
        Me.menubarHelp_About.Text = "About"
        '
        'tabcontrolWebBrowserView
        '
        Me.tabcontrolWebBrowserView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolWebBrowserView.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrolWebBrowserView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabcontrolWebBrowserView.Name = "tabcontrolWebBrowserView"
        Me.tabcontrolWebBrowserView.SelectedIndex = 0
        Me.tabcontrolWebBrowserView.Size = New System.Drawing.Size(1260, 612)
        Me.tabcontrolWebBrowserView.TabIndex = 8
        '
        'panelStatusBar
        '
        Me.panelStatusBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.panelStatusBar.Location = New System.Drawing.Point(0, 612)
        Me.panelStatusBar.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.panelStatusBar.Name = "panelStatusBar"
        Me.panelStatusBar.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.panelStatusBar.Size = New System.Drawing.Size(1260, 22)
        Me.panelStatusBar.TabIndex = 8
        Me.panelStatusBar.Text = "StatusStrip1"
        '
        'menuitemViewInTridentTab
        '
        Me.menuitemViewInTridentTab.Name = "menuitemViewInTridentTab"
        Me.menuitemViewInTridentTab.Size = New System.Drawing.Size(257, 26)
        Me.menuitemViewInTridentTab.Text = "View in new IE/Trident tab"
        '
        'browserMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1260, 702)
        Me.Controls.Add(Me.panelMain)
        Me.MainMenuStrip = Me.menubarAContainer
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(620, 363)
        Me.Name = "browserMainWindow"
        Me.Text = "Drew's Lightweight Browser v. 0.3 [ALPHA]"
        Me.panelMain.ResumeLayout(False)
        Me.panelsplitWindowGlue.Panel1.ResumeLayout(False)
        Me.panelsplitWindowGlue.Panel1.PerformLayout()
        Me.panelsplitWindowGlue.Panel2.ResumeLayout(False)
        Me.panelsplitWindowGlue.Panel2.PerformLayout()
        CType(Me.panelsplitWindowGlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelsplitWindowGlue.ResumeLayout(False)
        Me.menubarAContainer.ResumeLayout(False)
        Me.menubarAContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents panelsplitWindowGlue As System.Windows.Forms.SplitContainer
    Friend WithEvents buttonStopLoading As System.Windows.Forms.Button
    Friend WithEvents forwardButton As System.Windows.Forms.Button
    Friend WithEvents buttonBack As System.Windows.Forms.Button
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents urlBox As System.Windows.Forms.ComboBox
    Friend WithEvents buttonReload As System.Windows.Forms.Button
    Friend WithEvents panelStatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents menubarAContainer As System.Windows.Forms.MenuStrip
    Friend WithEvents menubarFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarFile_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarView_GoToMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarView_GoToMenu_Back As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarView_GoToMenu_Forward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarZSeperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menubarView_GoToMenu_HomePage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarView_Refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarView_Stop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menubarHelp_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabcontrolWebBrowserView As TabControl
    Friend WithEvents buttonNewTab As Button
    Friend WithEvents buttonRemoveTab As Button
    Friend WithEvents menuitemViewInTridentTab As ToolStripMenuItem
End Class
