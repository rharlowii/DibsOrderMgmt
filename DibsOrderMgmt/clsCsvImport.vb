
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.DataAccess.Excel

Public Class CsvImport
    'Public Shared Function GetDataTable(ByVal csvFileName As String, ByVal columns As List(Of DataColumn), ByVal hasHeaders As Boolean, ByVal Optional encoding As System.Text.Encoding = Nothing, ByVal Optional valueSeparator As Char = ";"c, ByVal Optional textQualifier As Char = """"c, ByVal Optional cultureInfo As System.Globalization.CultureInfo = Nothing) As DataTable
    '    If encoding Is Nothing Then encoding = System.Text.Encoding.UTF8
    '    If cultureInfo Is Nothing Then cultureInfo = New Globalization.CultureInfo("cs-CZ")
    '    Dim csvDataSource As ExcelDataSource = New ExcelDataSource()
    '    csvDataSource.FileName = csvFileName
    '    Dim csvSourceOptions As CsvSourceOptions = New CsvSourceOptions()
    '    csvSourceOptions.UseFirstRowAsHeader = hasHeaders
    '    csvSourceOptions.Encoding = encoding
    '    csvSourceOptions.ValueSeparator = valueSeparator
    '    csvSourceOptions.TextQualifier = textQualifier
    '    csvSourceOptions.Culture = cultureInfo
    '    csvDataSource.SourceOptions = csvSourceOptions

    '    For Each col As DataColumn In columns
    '        Dim field As FieldInfo = New FieldInfo()
    '        field.Name = col.ColumnName
    '        field.Type = col.DataType
    '        csvDataSource.Schema.Add(field)
    '    Next

    '    csvDataSource.Fill()
    '    Return ToDataTable(csvDataSource)
    'End Function

    Public Shared Function ToDataTable(ByVal csvDataSource As ExcelDataSource) As DataTable
        'Dim lst As IList = (CType(csvDataSource, IListSource)).GetList()
        'Dim dataView As DevExpress.DataAccess.Native.Excel.DataView = CType(lst, DevExpress.DataAccess.Native.Excel.DataView)
        'Dim props As List(Of PropertyDescriptor) = dataView.Columns.ToList(Of PropertyDescriptor)()
        'Dim dt As DataTable = New DataTable()

        'For i As Integer = 0 To props.Count - 1
        '    Dim prop As PropertyDescriptor = props(i)
        '    dt.Columns.Add(prop.Name, prop.PropertyType)
        'Next

        'Dim row As Object() = New Object(props.Count - 1) {}

        'For Each item As DevExpress.DataAccess.Native.Excel.ViewRow In lst

        '    Try

        '        For i As Integer = 0 To props.Count - 1
        '            row(i) = props(i).GetValue(item)
        '        Next

        '        dt.Rows.Add(row)
        '    Catch e As Exception
        '        '  DbUtil.WriteLogMessage($"Error: {e.Message}; row {item.Index + 2}", 1000)
        '    End Try
        'Next

        'Return dt
    End Function
End Class


