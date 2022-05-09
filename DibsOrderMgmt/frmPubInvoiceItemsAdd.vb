Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.Spreadsheet
Public Class frmPubInvoiceItemsAdd
    Public UpdateExisitngPubInvoice As Boolean = False
    Public PubPaymentID As String = ""
    Public OrderID As String
    Public BHPONumber_Orig As String
    Public PartnerID_Orig As Integer
    Private InitValuesSet As Boolean = False

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
        Dim oRow As DataRowView
        Dim PartnerName As String

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
        If UpdateExisitngPubInvoice = True And InitValuesSet = False Then
            cmbBHPONumber.EditValue = BHPONumber_Orig
            LoadOrderPartners2(cmbBHPONumber.EditValue)
            cmbPartner.EditValue = PartnerID_Orig
            'oRow = cmbPartner.GetSelectedDataRow()
            'PartnerName = oRow.Item("PublisherName")
            cmbBHPONumber.Enabled = False
            cmbPartner.Enabled = False
            txtPubInvoiceNumber.Enabled = False

            InitValuesSet = True


        Else
            cmbBHPONumber.EditValue = ""
        End If

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
        Dim oPubInvoiceItem As New PubInvoiceItem
        Dim BHPONumber As String
        Dim PublisherInvoiceNumber As String
        Dim InvoiceAmount As Decimal
        Dim DueDate As Date
        Dim PlanToPay As Date
        Dim DatePaid As Date
        Dim sReturn As String

        oDataRowView = cmbBHPONumber.GetSelectedDataRow

        With oDataRowView
            OrderID = .Row.Item(2).ToString
        End With

        PartnerID = cmbPartner.EditValue

        If OrderID = "" Or PartnerID = -1 Then
            MsgBox("You Must select a Brain Hive PO # & Partner")
            Exit Sub
        End If
        BHPONumber = cmbBHPONumber.Text

        PublisherInvoiceNumber = txtPubInvoiceNumber.Text
        InvoiceAmount = txtInvoiceAmount.Text

        If PublisherInvoiceNumber.Length = 0 Then
            MsgBox("You must enter a 'Due Date' and 'Plan To Pay Date'")
            Exit Sub
        End If

        If InvoiceAmount < 0 Then
            MsgBox("You must enter a valid Invoice Amount.")
            Exit Sub
        End If
        If DateEditDueDate.EditValue <> Date.MinValue Then
            DueDate = DateEditDueDate.EditValue.ToString
        Else
            MsgBox("You must enter a 'Due Date' and 'Plan To Pay Date'")
            Exit Sub
        End If
        If DateEditPlanToPayDate.EditValue <> Date.MinValue Then
            PlanToPay = DateEditPlanToPayDate.EditValue.ToString
        Else
            MsgBox("You must enter a 'Due Date' and 'Plan To Pay Date'")
            Exit Sub
        End If




        With oPubInvoiceItem

            If PubPaymentID = "" Then
                .PubPaymentID = Guid.NewGuid.ToString
            Else
                .PubPaymentID = PubPaymentID
            End If

            .OrderID = OrderID
            .PartnerID = PartnerID
            .PublisherInvoiceNumber = PublisherInvoiceNumber
            .InvoiceAmount = InvoiceAmount
            .DueDate = DueDate
            .PlanToPlay = PlanToPay





        End With

        sReturn = omPubPaymentTracker_IU_ALT(oPubInvoiceItem)

        If sReturn = 1 Then
            LogAddUpdatePubInvoiceItem(oPubInvoiceItem)
        End If
    End Sub

    Private Sub txtInvoiceAmount_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceAmount.TextChanged

    End Sub

    Private Sub txtInvoiceAmount_Validating(sender As Object, e As CancelEventArgs) Handles txtInvoiceAmount.Validating
        ' Dim currentValue As DateTime = CType(sender, DevExpress.XtraEditors.DateEdit).DateTime
        If IsNumeric(sender.text) = False Then
            MessageBox.Show("You must enter a valid Invoice Amount", "Error")
            e.Cancel = True
        End If

    End Sub

    Public Function LogAddUpdatePubInvoiceItem(oPubInvoiceItem As Object)

        Dim moPubInvoiceItem As PubInvoiceItem
        'Some reason needed to do this
        moPubInvoiceItem = oPubInvoiceItem

        Dim sUpdateMsg As String

        With moPubInvoiceItem
            sUpdateMsg = "Added/Update: " & .BHPONumber & "," & cmbPartner.Text & "," & .PublisherInvoiceNumber & "," & .InvoiceAmount & "," & .DueDate & "," & .PlanToPlay

        End With

        txtAddPubInvoicesLog.Text = sUpdateMsg & vbCrLf & txtAddPubInvoicesLog.Text


    End Function
End Class