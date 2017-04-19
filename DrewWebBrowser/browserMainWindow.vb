﻿Public Class browserMainWindow

    ' Go button (Address bar)
    Private Sub goButton_Click(sender As System.Object, e As System.EventArgs) Handles goButton.Click
        NewTabWorker.browserNewBrowser.Navigate(urlBox.Text)
    End Sub

    ' Refresh button (Address Bar)
    Private Sub buttonReload_Click(sender As System.Object, e As System.EventArgs) Handles buttonReload.Click
        NewTabWorker.browserNewBrowser.Refresh()
    End Sub

    ' Go Back (Address Bar)
    Private Sub buttonBack_Click(sender As System.Object, e As System.EventArgs) Handles buttonBack.Click
        NewTabWorker.browserNewBrowser.GoBack()
    End Sub

    ' Go Forward (Address Bar)
    Private Sub forwardButton_Click(sender As System.Object, e As System.EventArgs) Handles forwardButton.Click
        NewTabWorker.browserNewBrowser.GoForward()
    End Sub

    ' Stop Navigation (Address bar)
    Private Sub buttonStopLoading_Click(sender As System.Object, e As System.EventArgs) Handles buttonStopLoading.Click
        NewTabWorker.browserNewBrowser.Stop()
    End Sub

    ' Exits the Application (Menubar)
    Private Sub menubarFile_Exit_Click(sender As System.Object, e As System.EventArgs) Handles menubarFile_Exit.Click
        Application.Exit()
    End Sub

    ' Go Back (Menubar)
    Private Sub menubarView_GoToMenu_Back_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_Back.Click
        NewTabWorker.browserNewBrowser.GoBack()
    End Sub

    ' Go Forward (Menubar)
    Private Sub menubarView_GoToMenu_Forward_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_Forward.Click
        NewTabWorker.browserNewBrowser.GoForward()
    End Sub

    ' Go to Home Page (Menubar)
    Private Sub menubarView_GoToMenu_HomePage_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_GoToMenu_HomePage.Click
        NewTabWorker.browserNewBrowser.GoHome()
    End Sub

    ' Refresh Page (Menubar)
    Private Sub menubarView_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_Refresh.Click
        NewTabWorker.browserNewBrowser.Refresh()
    End Sub

    ' Stop Navigation (Menubar)
    Private Sub menubarView_Stop_Click(sender As System.Object, e As System.EventArgs) Handles menubarView_Stop.Click
        NewTabWorker.browserNewBrowser.Stop()
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
