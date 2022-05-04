Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.Spreadsheet
Public Class frmPubInvoiceItemsAdd
    Private Sub frmPubInvoiceItemsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBHPOOrders()

        '   LoadOrderPartners2("75f7af25-5a67-47c4-b226-444b4b4ae9ab")
        ' InitAddPubInvoicesFreeForm()
    End Sub

    Private Sub LoadOrderPartners(OrderID As String)
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State

        If OrderID = "" Then
            'No Order Selected...so clear
            With cmbPartner.Properties
                .DataSource = Nothing

            End With
        Else


            Dim sSQL As String = "SELECT * FROM dbo.omqryOrderPartners where OrderID='{OrderID}' Order BY PublisherName"

            sSQL = sSQL.Replace("{OrderID}", OrderID)

            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim iCount As Integer

            oConnection = New SqlConnection(sConnectionString)
            oConnection.Open()
            da = New SqlDataAdapter(sSQL, oConnection)
            da.Fill(ds)
            oConnection.Close()



            iCount = ds.Tables(0).Rows.Count

            Dim oNewRow As DataRow
            With ds.Tables(0)
                oNewRow = .NewRow()

                oNewRow.Item(0) = -1
                oNewRow.Item(1) = ""
                .Rows.Add(oNewRow)
            End With


            With cmbPartner.Properties
                'Column Names are Case Sensitive
                .ValueMember = "PartnerID"
                .DisplayMember = "PublisherName"
                .DataSource = ds.Tables(0)





            End With
            cmbPartner.EditValue = -1
        End If
    End Sub
    Private Sub LoadOrderPartners2(BHPONumber As String)
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State

        If BHPONumber = "" Then
            'No Order Selected...so clear
            With cmbPartner.Properties
                .DataSource = Nothing

            End With
        Else


            Dim sSQL As String = "SELECT * FROM dbo.omqryOrderPartners where BHPONumber='{BHPONumber}' Order BY PublisherName"

            sSQL = sSQL.Replace("{BHPONumber}", BHPONumber)

            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim iCount As Integer

            oConnection = New SqlConnection(sConnectionString)
            oConnection.Open()
            da = New SqlDataAdapter(sSQL, oConnection)
            da.Fill(ds)
            oConnection.Close()



            iCount = ds.Tables(0).Rows.Count

            Dim oNewRow As DataRow
            With ds.Tables(0)
                oNewRow = .NewRow()

                oNewRow.Item(0) = -1
                oNewRow.Item(1) = ""
                .Rows.Add(oNewRow)
            End With


            With cmbPartner.Properties
                'Column Names are Case Sensitive
                .ValueMember = "PartnerID"
                .DisplayMember = "PublisherName"
                .DataSource = ds.Tables(0)





            End With
            cmbPartner.EditValue = -1
        End If
    End Sub

    Private Sub LoadBHPOOrders()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim oDataTable As DataTable
        Dim iCount As Integer

        oDataTable = GetAddPubInvoiceOrders()


        iCount = oDataTable.Rows.Count

        Dim oNewRow As DataRow
        With oDataTable
            oNewRow = .NewRow()

            '  oNewRow.Item(0) = Guid.Empty.ToString
            oNewRow.Item(0) = ""
            oNewRow.Item(1) = ""
            .Rows.Add(oNewRow)
        End With


        With cmbBHPONumber.Properties
            'Column Names are Case Sensitive
            '  .ValueMember = "OrderID"
            .ValueMember = "BHPONumberID"
            .DisplayMember = "BHPONumber"
            .DataSource = oDataTable


        End With
        ' cmbBHPONumber.EditValue = Guid.Empty.ToString
        cmbBHPONumber.EditValue = ""
    End Sub

    Private Sub cmbBHPONumber_EditValueChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub cmbBHPONumber_Validated(sender As Object, e As EventArgs) Handles cmbBHPONumber.EditValueChanged

    End Sub

    Private Sub cmbBHPONumber_Validating(sender As Object, e As CancelEventArgs) Handles cmbBHPONumber.Validating

    End Sub

    Private Sub cmbBHPONumber_LostFocus(sender As Object, e As EventArgs) Handles cmbBHPONumber.LostFocus
        LoadOrderPartners2(cmbBHPONumber.EditValue)
    End Sub

    Private Sub cmdAddPubInvoice_Click(sender As Object, e As EventArgs) Handles cmdAddPubInvoice.Click
        Dim oDataRowView As DataRowView
        Dim OrderID As String
        Dim PartnerID As Integer


        oDataRowView = cmbBHPONumber.GetSelectedDataRow

        With oDataRowView
            OrderID = .Row.Item(2).ToString
        End With

        PartnerID = cmbPartner.EditValue

        If OrderID = "" Or PartnerID = -1 Then
            MsgBox("You Must select a Brain Hive PO # & Partner")
            Exit Sub
        End If

    End Sub
End Class