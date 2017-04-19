Public Class NewTabWorker

    Public Shared browserNewBrowser As New WebBrowser

    Shared Function tabAddMoreTabs()
        ' This SO answer is much better for tabbed browsing:
        ' http://stackoverflow.com/a/7459409
        Dim tabNewTabPage As New TabPage

        tabNewTabPage.Name = "BrowserTab"
        tabNewTabPage.Text = "New Tab"
        browserMainWindow.tabcontrolWebBrowserView.TabPages.Add(tabNewTabPage)

        browserMainWindow.tabcontrolWebBrowserView.SelectedTab = tabNewTabPage

        If My.Settings.browserBlankNewTab = True Then
            browserNewBrowser.Url = New Uri("about:blank", UriKind.Absolute)
        ElseIf My.Settings.browserBlankNewTab = False Then
            browserNewBrowser.GoHome()
        End If

        If My.Settings.browserSuppressScriptErrors = True Then
            browserNewBrowser.ScriptErrorsSuppressed = True
        Else
            browserNewBrowser.ScriptErrorsSuppressed = False
        End If
        browserNewBrowser.Dock = DockStyle.Fill
        tabNewTabPage.Controls.Add(browserNewBrowser)
        'tabNewTabPage.Text = browserNewBrowser.DocumentTitle
        Return True
    End Function
End Class
