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



Imports Gecko

Public Class browserMainWindow

    Private Function getEngine() As String
        ' This function is used to see which engine is being used in a tab.
        ' It returns "geckofx" if using GeckoFX, "trident" if using the... 
        ' standard Windows Forms WebBrowser control, and others if they're
        ' added to the program.

        ' First, make the control easier to refer to.
        If tabcontrolWebBrowserView.SelectedTab.Controls.Item(0).GetType() Is GetType(GeckoWebBrowser) Then
            ' If it's a GeckoWebBrowser, then we return "geckofx" for the engine.
            Return "geckofx"
        Else
            ' If it's a WebBrowser or something else, then return "trident".
            Return "trident"
        End If
    End Function

    ' Go button (Address bar)
    Private Sub goButton_Click(sender As System.Object, e As System.EventArgs) Handles goButton.Click
        ' This forum post helped me do this properly: 
        'http://forums.devx.com/showthread.php?151064-VB-Net-Tabcontrol-And-webbrowser-control/page3

        ' If using GeckoFX, interact with that browser.
        If getEngine() = "geckofx" Then
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(urlBox.Text)
        Else
            ' Otherwise, interact with the Trident browser.
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).Navigate(urlBox.Text)
        End If
    End Sub

    ' Refresh button (Address Bar)
    Private Sub buttonReload_Click(sender As System.Object, e As System.EventArgs) Handles buttonReload.Click
        ' Code moved to its own sub.
        navRefresh()
    End Sub

    ' Refresh
    Private Sub navRefresh()
        ' Work with GeckoFX if that's being used.
        If getEngine() = "geckofx" Then
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), GeckoWebBrowser).Reload()
        Else
            ' Otherwise, work with IE.
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        End If
    End Sub

    ' Go Back button.
    Private Sub buttonBack_Click(sender As System.Object, e As System.EventArgs) Handles buttonBack.Click
        ' Code moved to its own sub to reduce duplication.
        navGoBack()
    End Sub

    ' Go back
    Private Sub navGoBack()
        ' If we're working with GeckoFX, use it.
        If getEngine() = "geckofx" Then
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), GeckoWebBrowser).GoBack()
        Else
            ' Otherwise, it's IE.
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        End If
    End Sub

    ' Go Forward (Address Bar)
    Private Sub forwardButton_Click(sender As System.Object, e As System.EventArgs) Handles forwardButton.Click
        ' Code moved to its own sub.
        navGoForward()
    End Sub

    ' Go forward
    Private Sub navGoForward()
        ' If working with GeckoFX, use it.
        If getEngine() = "geckofx" Then
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), GeckoWebBrowser).GoForward()
        Else
            ' Otherwise, it's just IE.
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        End If
    End Sub

    ' Stop Navigation (Address bar)
    Private Sub buttonStopLoading_Click(sender As System.Object, e As System.EventArgs) Handles buttonStopLoading.Click
        ' Code moved to its own sub.
        navStop()
    End Sub

    ' Stop navigation
    Private Sub navStop()
        ' If working with Gecko, use it.
        If getEngine() = "geckofx" Then
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), GeckoWebBrowser).Stop()
        Else
            ' Otherwise, we're just using IE.
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        End If
    End Sub

    ' Exits the Application (Menubar)
    Private Sub menubarFile_Exit_Click(sender As System.Object, e As System.EventArgs) Handles menubarFile_Exit.Click
        Application.Exit()
    End Sub

    ' Go Back (Menubar)
    Private Sub menubarView_GoToMenu_Back_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_Back.Click
        ' Code moved to its own sub.
        navGoBack()
    End Sub

    ' Go Forward (Menubar)
    Private Sub menubarView_GoToMenu_Forward_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_Forward.Click
        ' Code moved to its own sub.
        navGoForward()
    End Sub

    ' Go to Home Page (Menubar)
    Private Sub menubarView_GoToMenu_HomePage_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_HomePage.Click
        ' If we're using Gecko, use that.
        If getEngine() = "geckofx" Then
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(My.Settings.browserHomepage)
        Else
            ' Otherwise, use IE.
            CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.browserHomepage)
        End If
    End Sub

    ' Refresh Page (Menubar)
    Private Sub menubarView_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_Refresh.Click
        ' Code moved to its own sub.
        navRefresh()
    End Sub

    ' Stop Navigation (Menubar)
    Private Sub menubarView_Stop_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_Stop.Click
        ' Code moved to its own sub.
        navStop()
    End Sub



    ' Open the About Dialogue (Menubar)
    Private Sub menubarHelp_About_Click(sender As System.Object, e As System.EventArgs) Handles menubarHelp_About.Click
        BrowserAbout.ShowDialog()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Tab Pages"
        ' This makes a new tab when the app loads.
        NewTabWorker.tabAddMoreTabs()
#End Region
    End Sub

    Private Sub buttonNewTab_Click(sender As Object, e As EventArgs) Handles buttonNewTab.Click
        NewTabWorker.tabAddMoreTabs()
    End Sub
End Class
