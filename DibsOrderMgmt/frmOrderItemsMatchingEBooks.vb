Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmOrderItemsMatchingEBooks
    Public oOrderID As Guid
    Public BHPONumber As String

    Public Sub LoadMatchingEBooks()
        Dim sSQL As String = "SELECT * FROM omqryMatchingOrderItemEBooks where OrderID='" & oOrderID.ToString & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer
        Dim iRowCnt As Integer


        Dim daDetail As SqlDataAdapter

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "omOrderItemsMatchingEBooks")
        iRowCnt = ds.Tables(0).Rows.Count
        ' LabelControl2_TotalRows.Text = iRowCnt

        'Need to add "IsSelected" column to persist Row selection in grid
        '  Gridview1.Columns.Item("IsSelected").Visible = False
        Gridview1.OptionsSelection.CheckBoxSelectorField = "IsSelected"

        With ds.Tables("omOrderItemsMatchingEBooks")
            .Columns.Add("IsSelected", GetType(Boolean))
            .AcceptChanges()
        End With

        'Lets Try and do the detail - Endi

        gridOrderItems.DataSource = ds.Tables("omOrderItemsMatchingEBooks")
    End Sub

    Private Sub frmOrderItemsMatchingEBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMatchingEBooks()
    End Sub

    Private Sub cmdExportOrdersGrid_Click(sender As Object, e As EventArgs) Handles cmdExportGrid.Click
        Dim sPath As String
        Dim oDialog As New SaveFileDialog

        With oDialog
            .ShowDialog()
            sPath = .FileName
        End With
        gridOrderItems.ExportToXlsx(sPath)
    End Sub

    Private Sub cmdToggleRowCellSelection_Click(sender As Object, e As EventArgs) Handles cmdToggleRowCellSelection.Click
        'Gridview1

        Select Case Gridview1.OptionsSelection.MultiSelectMode
            Case DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
                Gridview1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
                cmdToggleRowCellSelection.Text = "Cell Select"

            Case DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
                Gridview1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
                cmdToggleRowCellSelection.Text = "Checkbox Select"
        End Select

    End Sub

    Private Sub cmdGenerateLabels_Click(sender As Object, e As EventArgs) Handles cmdGenerateLabels.Click
        Dim oTable As DataTable
        Dim oTableSelected As DataTable

        Dim selectedRowHandles As Int32() = Gridview1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow
        oTable = gridOrderItems.DataSource

        oTableSelected = oTable.Clone






        If selectedRowHandles.Count = 0 Then
            MsgBox("Must select 1 Row")
            Exit Sub
        End If
        selectedRowHandle = selectedRowHandles(0)

        For Each selectedRowHandle In selectedRowHandles
            oRow = Gridview1.GetDataRow(selectedRowHandle)
            oTableSelected.ImportRow(oRow)


        Next
        oTableSelected.DefaultView.Sort = "ItemDesc ASC"

        oTableSelected.AcceptChanges()

        ShowSelectedLabels10(oTableSelected, BHPONumber)

    End Sub


    Private Sub ShowSelectedLabels10(oSelectedDataTable As DataTable, sBHPONumber As String)
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer
        Dim sName As String

        sName = "Select_" & sBHPONumber & "_Labels10"


        'Dim report As New XtraReport1_10Labels()
        Dim report As New XtraReport1_Label10_2



        report.DataSource = oSelectedDataTable
        report.DataMember = "selectQuery" ' This line is critical or you only get 1 page
        report.CreateDocument(False)

        report.DisplayName = sName


        'Dim pdfOptions As PdfExportOptions = report.ExportOptions.Pdf
        'With pdfOptions
        '    .DocumentOptions.Title = "Test 2"


        'End With

        Dim rpt As New ReportPrintTool(report)
        Dim oReportViewer As New frmReportViewer

        With oReportViewer
            .Text = sName
            .DocumentViewer1.DocumentSource = report

            .Show(Me)
        End With

    End Sub

    Private Sub gridOrderItems_Click(sender As Object, e As EventArgs) Handles gridOrderItems.Click

    End Sub
End Class