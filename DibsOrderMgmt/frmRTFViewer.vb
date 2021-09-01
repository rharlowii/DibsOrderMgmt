Imports System.IO
Imports DevExpress.XtraRichEdit

Public Class frmRTFViewer

    Public WordBytes As Byte()
    Public oDocumentID As Guid
    Private Sub frmRTFViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sFileName As String

        'sFileName = "Y:\MEP - Shared\BrainHive\Brain Hive - Quotes_2021\CA_SanJacinto_Harlow\Labels_Bellwether_Final.docx"
        'RichEditControl1.LoadDocument(sFileName)
    End Sub

    Public Function LoadWord()

        Dim stream As Stream = New MemoryStream(WordBytes)

        RichEditControl1.LoadDocument(stream)
    End Function

    Private Sub CustomSaveBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CustomSaveBarButtonItem1.ItemClick
        'This is the Save Button

        Dim oOrderDocument As New OrderDocument
        Dim sReturn As String
        oOrderDocument.DocumentID = oDocumentID
        ' Dim stream As Stream = New MemoryStream(WordBytes)
        Dim stream As MemoryStream = New MemoryStream(WordBytes)
        '     Dim ms As MemoryStream = CType(e.Data.GetData("FileContents", True), MemoryStream)
        'This seams to be different than excel viewer...so need to work around it
        RichEditControl1.SaveDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.OpenDocument)

        oOrderDocument.OrderDoc = stream.ToArray()






        SaveOrderDocument(oOrderDocument)

        e.Item.Reset()
        CustomSaveBarButtonItem1.Enabled = False
    End Sub

    Private Sub frmRTFViewer_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        CustomSaveBarButtonItem1.Enabled = True
    End Sub
End Class