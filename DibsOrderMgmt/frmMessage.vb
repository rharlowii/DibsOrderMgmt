Imports System.IO

Public Class frmMessage
    Public IsPermanentLink As Boolean
    Public OutputPath As String

    Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Try
            Dim sFileOut As String

            sFileOut = OutputPath

            If IsPermanentLink = True Then
                sFileOut = OutputPath.Replace(".csv", "_PermanentLinks.csv")
                SaveFileDialog1.FileName = sFileOut
            End If




            '  SaveFileDialog1.Filter = "TXT Files (*.csv*)|*.txt"

            If SaveFileDialog1.ShowDialog = DialogResult.OK _
       Then
                My.Computer.FileSystem.WriteAllText _
         (SaveFileDialog1.FileName, txtLog.Text, True)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class