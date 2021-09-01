﻿Imports System.IO
Imports System.Text
Imports Outlook = Microsoft.Office.Interop.Outlook

Module modEmail
    Public Structure BHMailItem
        Public ToEmail As String
        Public CCEmail As String
        Public Subject As String
        Public Body As String
        Public Attachments As List(Of MailItemAttachement)


    End Structure

    Public Structure MailItemAttachement
        Public FilePath As String
        Public FileName As String

    End Structure
    Public Sub CreateBHMailItem(oBHMailItem As BHMailItem)

        Dim application As Outlook.Application = New Outlook.Application()
        '  Dim olAccounts As Outlook.Accounts
        Dim oAttachment As MailItemAttachement
        Dim iAttachmentCnt As Integer
        '  olAccounts = application.Session.Accounts

        Dim oInspector As Object
        application.CreateItem(Outlook.OlItemType.olMailItem)
        Dim mailItem As Outlook.MailItem '= CType(Me.Application.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)
        mailItem = application.CreateItem(Outlook.OlItemType.olMailItem)
        '  mailItem.SendUsingAccount = olAccounts.Item(1)

        mailItem.Subject = oBHMailItem.Subject
        mailItem.[To] = oBHMailItem.ToEmail
        mailItem.CC = oBHMailItem.CCEmail
        iAttachmentCnt = oBHMailItem.Attachments.Count

        For Each oAttachment In oBHMailItem.Attachments
            mailItem.Attachments.Add(oAttachment.FilePath, Outlook.OlAttachmentType.olByValue, iAttachmentCnt, oAttachment.FileName)
            iAttachmentCnt = iAttachmentCnt + 1
        Next

        mailItem.Importance = Outlook.OlImportance.olImportanceNormal

        mailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML

        'ReadSignature - get the html Email signature
        'Saw one post where adding attachments clear body....so put last
        mailItem.HTMLBody = "<br>" + oBHMailItem.Body + "<br>" + "<br>"
        mailItem.HTMLBody = mailItem.HTMLBody + "<br>" & "<br>" & ReadSignature()



        mailItem.Display(True)
    End Sub

    Private Function ReadSignature() As String
        Dim appDataDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Signatures"
        Dim signature As String = String.Empty
        Dim diInfo As DirectoryInfo = New DirectoryInfo(appDataDir)

        If diInfo.Exists Then
            Dim fiSignature As FileInfo() = diInfo.GetFiles("*.htm")

            If fiSignature.Length > 0 Then
                Dim sr As StreamReader = New StreamReader(fiSignature(0).FullName, Encoding.[Default])
                signature = sr.ReadToEnd()

                If Not String.IsNullOrEmpty(signature) Then
                    Dim fileName As String = fiSignature(0).Name.Replace(fiSignature(0).Extension, String.Empty)
                    signature = signature.Replace(fileName & "_files/", appDataDir & "/" & fileName & "_files/")
                End If
            End If
        End If

        Return signature
    End Function
End Module