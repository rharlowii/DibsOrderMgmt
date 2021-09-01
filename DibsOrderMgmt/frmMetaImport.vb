﻿Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet

Imports DevExpress.Spreadsheet.Export

Public Class frmMetaImport

    Public CurrentDataTable As DataTable

    Public oSpread As New SpreadsheetControl
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a ExcelDataSource asynchronously
        '     ExcelDataSource1.FillAsync()
        ' This line of code is generated by Data Source Configuration Wizard

    End Sub

    Private Sub frmMetaImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMetaDataMappings()


    End Sub


    Private Sub LoadMetaDataMappings()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString
        ' sState = cmbMetaDataMappings.EditValue


        sSQL = "SELECT MetaDataMappingsID,MappingName,PartnerID FROM omMetaDataMappings"


        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With cmbMetaDataMappings.Properties


            .DataSource = ds.Tables(0)
            .ValueMember = "MetaDataMappingsID"
            .DisplayMember = "MappingName"


        End With


    End Sub

    Private Sub cmd_FileSelect2_Click(sender As Object, e As EventArgs) Handles cmd_FileSelect2.Click

        With XtraOpenFileDialog1
            .FileName = ""
            .CheckFileExists = True

            .ShowDialog()

            If My.Computer.FileSystem.FileExists(.FileName) = False Then Exit Sub

            txtFullPath.Text = .FileName


        End With



        oSpread.LoadDocument(txtFullPath.Text)
        Dim workbook As IWorkbook = oSpread.Document
        ' Access a collection of worksheets.
        Dim worksheets As WorksheetCollection = workbook.Worksheets

        ' Access a worksheet by its index.
        Dim worksheet1 As Worksheet = workbook.Worksheets(0)
        '  worksheet1.


        CurrentDataTable = LoadExcelFile2(worksheet1.Name, txtFullPath.Text)
    End Sub

    Private Sub panelTop_Paint(sender As Object, e As PaintEventArgs) Handles panelTop.Paint

    End Sub





    Private Function LoadExcelFile2(sWorkSheetName As String, sFileName As String) As DataTable

        Dim myExcelSource As New DevExpress.DataAccess.Excel.ExcelDataSource()
        myExcelSource.FileName = txtFullPath.Text
        Dim excelWorksheetSettings As ExcelWorksheetSettings = New ExcelWorksheetSettings()
        excelWorksheetSettings.WorksheetName = sWorkSheetName

        Dim excelSourceOptions As ExcelSourceOptions = New ExcelSourceOptions(excelWorksheetSettings)

        excelSourceOptions.SkipHiddenRows = False
        excelSourceOptions.SkipHiddenColumns = False
        excelSourceOptions.UseFirstRowAsHeader = True




        '  txtOrderDocName.Text = FileIO.FileSystem.GetName(DocFullFilePath)


        With myExcelSource

            .SourceOptions = excelSourceOptions

            .Fill()
        End With

        Dim oDataTable As DataTable
        oDataTable = ToDataTable(myExcelSource)

        With gridMetaImport
            GridView1.Columns.Clear()
            .DataSource = myExcelSource
        End With


        Return oDataTable




    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdImportMeta.Click
        Dim oMappColNames As New omMetaDataColumnMappingNames
        Dim oMapMeta As New omMetaData
        Dim oMeta As omMetaData

        Dim oDataTable As DataTable
        '  oDataTable = ToDataTable(ExcelDataSource1)
        oMappColNames.SetColumnNames(cmbMetaDataMappings.EditValue)

        Dim oMetaList As List(Of omMetaData)
        oMetaList = LoadomMetdata(CurrentDataTable, oMappColNames)

        For Each oMeta In oMetaList

            InsertNewomMetaData(oMeta)
        Next


    End Sub

    Private Sub cmbMetaDataMappings_EditValueChanged(sender As Object, e As EventArgs) Handles cmbMetaDataMappings.EditValueChanged
        ' MsgBox("")


        Dim oDataRowView As DataRowView = CType(sender.GetSelectedDataRow(), DataRowView)
        Dim oDataRow As DataRow = oDataRowView.Row

        'Need to get the PartnerID
        CurrentPartnerID = oDataRow.Item(2)

    End Sub
End Class