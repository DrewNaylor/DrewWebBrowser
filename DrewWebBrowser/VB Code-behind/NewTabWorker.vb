'Drew's Lightweight Browser - Browse the Web with a Lightweight Browser! (Not recommended for everyday use.)
'Copyright (C) 2015-2017  Drew Naylor
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of Drew's Lightweight Browser
'(Program is also known as "DrewWebBrowser.")
'
'Drew's Lightweight Browser is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'Drew's Lightweight Browser is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with Drew's Lightweight Browser.  If not, see <http://www.gnu.org/licenses/>.



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
