﻿'Drew's Lightweight Browser - Browse the Web with a Lightweight Browser! (Not recommended for everyday use.)
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



Imports Gecko

Public Class NewTabWorker

    Public Shared Sub tabAddMoreTabs()
        ' This SO answer is much better for tabbed browsing:
        ' http://stackoverflow.com/a/7459409
        ' Also this video
        ' https://www.youtube.com/watch?v=ZTTom7ML0ng

        If My.Settings.browserEngine = "geckofx" Then
            ' If the user wants to use GeckoFX,
            ' initialize Firefox.
            Xpcom.Initialize("Firefox")
        End If
        ' Define the browser and new tab page.
        Dim tabNewTabPage As New TabPage
        Dim webbrowserGeckoFX As New GeckoWebBrowser
        Dim webbrowserTrident As New WebBrowser

        ' Define an integer for getting the IE version.
        ' Also get the IE version at the same time.


        ' Assign name and text properties to the new tab.
        tabNewTabPage.Name = "BrowserTab"
        tabNewTabPage.Text = "New Tab"

        ' Add the new tab page to the tab control.
        browserMainWindow.tabcontrolWebBrowserView.TabPages.Add(tabNewTabPage)
        browserMainWindow.tabcontrolWebBrowserView.SelectedTab = tabNewTabPage

        ' If the user wants to go to their homepage, then do so.
        ' Otherwise, go to a blank tab.
        If My.Settings.browserBlankNewTab = True Then
            ' If we're using GeckoFX, use that instead of
            ' Trident (Internet Explorer).
            If My.Settings.browserEngine = "geckofx" Then
                webbrowserGeckoFX.Navigate("about:blank")
            Else
                webbrowserTrident.Navigate("about:blank")
            End If
        ElseIf My.Settings.browserBlankNewTab = False Then
                webbrowserGeckoFX.Navigate(My.Settings.browserHomepage, CType(UriKind.Absolute, GeckoLoadFlags))
        End If

        ' Suppress script errors if the user wants to.
        'If My.Settings.browserSuppressScriptErrors = True Then
        '    browserNewBrowser.ScriptErrorsSuppressed = True
        'Else
        '    browserNewBrowser.ScriptErrorsSuppressed = False
        'End If

        ' If we're using GeckoFX, dock that browser and
        ' add it to the tab page.
        If My.Settings.browserEngine = "geckofx" Then
            webbrowserGeckoFX.Dock = DockStyle.Fill
            tabNewTabPage.Controls.Add(webbrowserGeckoFX)
        Else
            ' Otherwise, just use Trident.
            webbrowserTrident.Dock = DockStyle.Fill
            tabNewTabPage.Controls.Add(webbrowserTrident)
        End If
        'tabNewTabPage.Text = browserNewBrowser.DocumentTitle
    End Sub
End Class
