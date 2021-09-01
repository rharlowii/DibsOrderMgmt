Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet

Public Class frmExcelViewer

    Public sFilePath As String
    Public ExcelBytes As Byte()
    Public oDocumentID As Guid

    Private Sub frmExcelViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load a workbook from a file.
        Dim sFileName As String

        'sFileName = "Y:\MEP - Shared\BrainHive\Brain Hive - Quotes_2021\CA_SanJacinto_Harlow\SanJacinto_Elementary_6Packs.xlsx"
        'SpreadsheetControl1.LoadDocument(sFileName, DocumentFormat.Xlsx)
    End Sub

    Public Sub LoadDocument()

    End Sub

    Private Sub SpreadsheetControl1_Click(sender As Object, e As EventArgs) Handles SpreadsheetControl1.Click

    End Sub

    Public Sub LoadExcel()
        Dim stream As Stream = New MemoryStream(ExcelBytes)

        SpreadsheetControl1.LoadDocument(stream)
    End Sub

    Private Sub SpreadsheetCommandBarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SpreadsheetCommandBarButtonItem3.ItemClick


    End Sub

    Private Sub SpreadsheetCommandBarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SpreadsheetCommandBarButtonItem4.ItemClick

    End Sub

    Private Sub CustomSaveBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CustomSaveBarButtonItem1.ItemClick
        'This is the Save Button
        'spreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.OpenXml)
        Dim oOrderDocument As New OrderDocument
        Dim sReturn As String
        oOrderDocument.DocumentID = oDocumentID
        oOrderDocument.OrderDoc = SpreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.Xlsx)


        SaveOrderDocument(oOrderDocument)
        SpreadsheetControl1.Options.Save.Reset()
        e.Item.Reset()
    End Sub

    Private Sub SpreadsheetControl1_DocumentSaved(sender As Object, e As EventArgs) Handles SpreadsheetControl1.DocumentSaved
        CustomSaveBarButtonItem1.Enabled = False

    End Sub

    Private Sub SpreadsheetControl1_BeforeExport(sender As Object, e As SpreadsheetBeforeExportEventArgs) Handles SpreadsheetControl1.BeforeExport

    End Sub

    Private Sub SpreadsheetControl1_ActiveSheetChanged(sender As Object, e As ActiveSheetChangedEventArgs) Handles SpreadsheetControl1.ActiveSheetChanged

    End Sub

    Private Sub SpreadsheetControl1_CellValueChanged(sender As Object, e As SpreadsheetCellEventArgs) Handles SpreadsheetControl1.CellValueChanged
        CustomSaveBarButtonItem1.Enabled = True
    End Sub
End Class