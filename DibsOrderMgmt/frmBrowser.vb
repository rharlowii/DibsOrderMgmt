Imports System.IO

Public Class frmBrowser
    Public CurrentPage As Integer = 0
    Public HTMLFolder As String
    Public ExtType As String = ".html"
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        GotoNextPage()
    End Sub

    Private Sub GotoNextPage()
        Dim sPage As String
        CurrentPage = CurrentPage + 1
        sPage = HTMLFolder & "\" & CurrentPage & ExtType

        ChromiumWebBrowser1.LoadUrlAsync(sPage)
    End Sub

    Private Sub GotoPreviousPage()
        Dim sPage As String
        If CurrentPage > 1 Then
            CurrentPage = CurrentPage - 1
            sPage = HTMLFolder & "\" & CurrentPage & ExtType

            ChromiumWebBrowser1.LoadUrlAsync(sPage)
        End If

    End Sub

    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        GotoPreviousPage()
    End Sub

    Private Sub frmBrowser_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If Directory.Exists(HTMLFolder) Then
            Directory.Delete(HTMLFolder, True)
        End If
    End Sub
End Class