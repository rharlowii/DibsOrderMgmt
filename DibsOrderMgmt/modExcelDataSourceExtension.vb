Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.DataAccess.Excel
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export

Public Module ExcelDataSourceExtension
    <System.Runtime.CompilerServices.Extension>
    Public Function ToDataTable(ByVal excelDataSource As ExcelDataSource) As DataTable
        Dim list As IList = (CType(excelDataSource, IListSource)).GetList()
        Dim dataView As DevExpress.DataAccess.Native.Excel.DataView = CType(list, DevExpress.DataAccess.Native.Excel.DataView)
        Dim props As List(Of DevExpress.DataAccess.Native.Excel.ViewColumn) = dataView.Columns

        Dim table As New DataTable()
        For i As Integer = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(i)
            table.Columns.Add(Trim(prop.Name), prop.PropertyType)
        Next i
        Dim values(props.Count - 1) As Object
        For Each item As DevExpress.DataAccess.Native.Excel.ViewRow In list
            For i As Integer = 0 To values.Length - 1
                values(i) = props(i).GetValue(item)
            Next i
            table.Rows.Add(values)
        Next item
        Return table
    End Function

    Public Function ToDataTable2(ByVal Worksheet As DevExpress.Spreadsheet.Worksheet) As DataTable

        Dim range As CellRange = Worksheet.SelectedCell()
        Dim rangeHasHeaders As Boolean = True 'Me.barCheckItemHasHeaders1.Checked

        ' Create a data table with column names obtained from the first row in a range if it has headers.
        ' Column data types are obtained from cell value types of cells in the first data row of the worksheet range.
        Dim dataTable As DataTable = Worksheet.CreateDataTable(range, rangeHasHeaders)

        'Validate cell value types. If cell value types in a column are different, the column values are exported as text.
        For col As Integer = 0 To range.ColumnCount - 1
            Dim cellType As CellValueType = range(0, col).Value.Type
            For r As Integer = 1 To range.RowCount - 1
                If cellType <> range(r, col).Value.Type Then
                    dataTable.Columns(col).DataType = GetType(String)
                    Exit For
                End If
            Next r
        Next col

        ' Create the exporter that obtains data from the specified range, 
        ' skips the header row (if required) and populates the previously created data table. 
        Dim exporter As DataTableExporter = Worksheet.CreateDataTableExporter(range, dataTable, rangeHasHeaders)
        ' Handle value conversion errors.
        AddHandler exporter.CellValueConversionError, AddressOf exporter_CellValueConversionError

        ' Perform the export.
        exporter.Export()
        Return dataTable
    End Function

    Private Sub exporter_CellValueConversionError(ByVal sender As Object, ByVal e As CellValueConversionErrorEventArgs)
        MessageBox.Show("Error in cell " & e.Cell.GetReferenceA1())
        e.DataTableValue = Nothing
        e.Action = DataTableExporterAction.Continue
    End Sub

End Module
