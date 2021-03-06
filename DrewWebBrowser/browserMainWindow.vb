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



Public Class browserMainWindow

    ' Go button (Address bar)
    Private Sub goButton_Click(sender As System.Object, e As System.EventArgs) Handles goButton.Click
        ' This forum post helped me do this properly: 
        'http://forums.devx.com/showthread.php?151064-VB-Net-Tabcontrol-And-webbrowser-control/page3

        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.Navigate(urlBox.Text)
    End Sub

    ' Refresh button (Address Bar)
    Private Sub buttonReload_Click(sender As System.Object, e As System.EventArgs) Handles buttonReload.Click
        Dim currentBrowser As New WebBrowser
        CType(tabcontrolWebBrowserView.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        'currentBrowser.Refresh()
    End Sub

    ' Go Back (Address Bar)
    Private Sub buttonBack_Click(sender As System.Object, e As System.EventArgs) Handles buttonBack.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.GoBack()
    End Sub

    ' Go Forward (Address Bar)
    Private Sub forwardButton_Click(sender As System.Object, e As System.EventArgs) Handles forwardButton.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.GoForward()
    End Sub

    ' Stop Navigation (Address bar)
    Private Sub buttonStopLoading_Click(sender As System.Object, e As System.EventArgs) Handles buttonStopLoading.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.Stop()
    End Sub

    ' Exits the Application (Menubar)
    Private Sub menubarFile_Exit_Click(sender As System.Object, e As System.EventArgs) Handles menubarFile_Exit.Click
        Application.Exit()
    End Sub

    ' Go Back (Menubar)
    Private Sub menubarView_GoToMenu_Back_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_Back.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.GoBack()
    End Sub

    ' Go Forward (Menubar)
    Private Sub menubarView_GoToMenu_Forward_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_Forward.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.GoForward()
    End Sub

    ' Go to Home Page (Menubar)
    Private Sub menubarView_GoToMenu_HomePage_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_HomePage.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.GoHome()
    End Sub

    ' Refresh Page (Menubar)
    Private Sub menubarView_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_Refresh.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.Refresh()
    End Sub

    ' Stop Navigation (Menubar)
    Private Sub menubarView_Stop_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_Stop.Click
        Dim currentBrowser As WebBrowser = Me.tabcontrolWebBrowserView.SelectedTab.Tag
        currentBrowser.Stop()
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
