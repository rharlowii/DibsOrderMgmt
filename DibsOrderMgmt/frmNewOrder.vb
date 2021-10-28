Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Public Class frmNewOrder

    Public oOrderID As Guid
    Public bExistingOrder As Boolean = False


    Private Sub frmNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetConnection()

        ' LoadLines()
        ' LoadStates()
        LoadStates2()
        LoadDisctricts2()
        LoadOrderStatus()
        If bExistingOrder = True Then
            'Existing order, so we need to set the textboxes
            LoadExistingOrder(oOrderID.ToString)
        Else
            'New Order
            cmbOrderStatus.EditValue = 0
        End If



        cmbStates2.Focus()


    End Sub


    Private Sub LoadDisctricts()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString
        sState = cmbStates2.EditValue

        If sState = "" Then
            sSQL = "SELECT * FROM SchoolDistricts Order by Name"
        Else
            sSQL = "SELECT * FROM SchoolDistricts where State='" & sState & "' Order by Name"
        End If
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With cmbDistricts2.Properties
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)


        End With

    End Sub

    Private Sub LoadDisctricts2()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString
        sState = cmbStates2.EditValue

        If sState = "" Then
            sSQL = "SELECT ID,Name FROM SchoolDistricts Order by Name"
        Else
            sSQL = "SELECT ID,Name FROM SchoolDistricts where State='" & sState & "' Order by Name"
        End If
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With cmbDistricts2.Properties


            .DataSource = ds.Tables(0)
            .ValueMember = "ID"
            .DisplayMember = "Name"


        End With


    End Sub
    Private Sub LoadOrderStatus()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim sSQL As String = "SELECT * FROM dbo.omOrderStatus ORDER BY omOrderStatus.OrderStatusID"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count


        With cmbOrderStatus.Properties
            .DataSource = ds.Tables(0)
            .ValueMember = "OrderStatusID"
            .DisplayMember = "OrderStatus"






        End With

    End Sub

    Private Sub LoadStates2()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim sSQL As String = "SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count


        With cmbStates2.Properties
            .DataSource = ds.Tables(0)
            .ValueMember = "State"
            .DisplayMember = "State"






        End With

    End Sub

    Private Sub LoadSchools2(Optional sSearchText As String = "")

        Dim sSQL As String
        Dim sDistrictID As String


        If IsNothing(cmbDistricts2.EditValue) Then
            sDistrictID = ""
        Else
            sDistrictID = cmbDistricts2.EditValue.ToString
        End If
        txtDistrictID.Text = sDistrictID

        If sDistrictID.Length > 0 Then
            If chkShowOnlySchoolsWBooks.CheckState = CheckState.Unchecked Then
                sSQL = "SELECT ID,Name FROM Schools where SchoolDistrictID='" & sDistrictID & "' Order by Name"

            Else
                sSQL = "SELECT ID,Name FROM School_BookCountGreaterThanZero where SchoolDistrictID='" & sDistrictID & "' Order by Name"

            End If
        Else
            If chkShowOnlySchoolsWBooks.CheckState = CheckState.Unchecked Then

                sSQL = "SELECT * FROM Schools Order by Name"


            Else
                sSQL = "SELECT * FROM School_BookCountGreaterThanZero Order by Name"

            End If
        End If

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        If sSearchText.Length > 0 Then
            ds.Tables(0).DefaultView.RowFilter = "Name LIKE '*" & sSearchText & "*'"
        End If
        With cmbSchools2.Properties
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)


        End With

    End Sub

    Private Sub LoadExistingOrder(sOrderID As String)

        Dim sSQL As String = "SELECT * FROM omqryOrdersMain where OrderID='" & sOrderID & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer
        Dim sDueDate As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count



        Dim oOrder As New Order
        Dim oBillToAddress As New AddressStructure
        Dim oShipToAddress As New AddressStructure
        Dim sReturn As String

        With ds.Tables(0).Rows(0)
            '.item("BHPONumber")
            'BillTo_Name

            txtBillTo_Name.Text = .Item("BillTo_Name").ToString
            txtBillTo_Street.Text = .Item("BillTo_Street").ToString
            txtBillTo_City.Text = .Item("BillTo_City").ToString
            txtBillTo_Zip.Text = .Item("BillTo_Zip").ToString
            txtBillTo_State.Text = .Item("BillTo_State").ToString

            txtShipTo_Name.Text = .Item("ShipTo_Name").ToString
            txtShipTo_Address.Text = .Item("ShipTo_Street").ToString
            txtShipTo_City.Text = .Item("ShipTo_City").ToString
            txtShipTo_Zip.Text = .Item("ShipTo_Zip").ToString
            txtShipTo_State.Text = .Item("ShipTo_State").ToString
            txtShipTo_Attn.Text = .Item("ShipTo_ATTN").ToString

            txtDistrictID.Text = .Item("DistrictID").ToString
            txtSchoolID.Text = .Item("SchoolID").ToString

            txtBillTo_BHPO.Text = .Item("BHPONumber").ToString

            txtPurchasing_Name.Text = .Item("PurchasingContactName").ToString
            txtPurchasing_Phone.Text = .Item("PurchasingContactPhone").ToString
            txtPurchasing_email.Text = .Item("PurchasingContactEmail").ToString
            txtPurchasing_PurchasingPONumber.Text = .Item("PurchasingPONumber").ToString

            sDueDate = .Item("DueDate").ToString

            If sDueDate.Length > 0 Then
                txtPurchasing_DueDate.Text = FormatDateTime(.Item("DueDate").ToString, DateFormat.ShortDate)
            Else
                txtPurchasing_DueDate.Text = ""
            End If






            txtOrderNotes.Text = .Item("OrderNotes").ToString
            'Need to add Order & Due Dates to both Save and retrieve

            txtPO_Amount.Text = .Item("PO_Amount").ToString
            txtPO_DiscountAmount.Text = .Item("PO_DiscountAmount").ToString
            'Format("YOUR VALUE","#,##0.00")
            'txtPO_Amount.Text
            txtPO_TotalAmount.Text = .Item("PO_TotalAmount").ToString
            txtPO_Shipping.Text = .Item("PO_Shipping").ToString

            cmbOrderStatus.EditValue = .Item("OrderStatusID")
            'cmbOrderStatus.se

            txtCreateTime.Text = .Item("CreateTime").ToString
        End With





    End Sub
    Private Sub cmbStates_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadDisctricts()
        'LoadSchools()

    End Sub
    Private Sub cmbDistrict_SelectedIndexChanged(sender As Object, e As EventArgs)
        ''LoadSchools()
        'txtDistrictID.Text = cmbDistrict.SelectedValue.ToString

    End Sub



    Private Sub cmdSetDistrictBillToShipTo_Click(sender As Object, e As EventArgs) Handles cmdSetDistrictBillToShipTo.Click
        Dim sDistrictID As String

        Dim oAddress As AddressStructure
        sDistrictID = txtDistrictID.Text
        oAddress = GetDistrictMailAddress(sDistrictID)

        With oAddress
            txtBillTo_Name.Text = .AddressName
            txtBillTo_Street.Text = .StreetAddress
            txtBillTo_City.Text = .City
            txtBillTo_Zip.Text = .Zip


            txtBillTo_State.Text = .State
        End With

        With oAddress
            txtShipTo_Name.Text = .AddressName
            txtShipTo_Address.Text = .StreetAddress
            txtShipTo_City.Text = .City
            txtShipTo_Zip.Text = .Zip
            txtShipTo_State.Text = .State

        End With

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cmbStates2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbStates2.EditValueChanged
        LoadDisctricts2()
        'LoadSchools()
    End Sub

    Private Sub cmbStates2_ListChanged(sender As Object, e As ListChangedEventArgs) Handles cmbStates2.ListChanged

    End Sub

    Private Sub cmbDistrict2_EditValueChanged(sender As Object, e As EventArgs)
        'LoadSchools()
    End Sub

    Private Sub cmbDistrict2_SelectedIndexChanged(sender As Object, e As EventArgs)



        ''Lets Try and get the District Address
        'Dim moAddress As AddressStructure
        'Dim sDistrictID As String
        'sDistrictID = txtDistrictID.Text

        'If sDistrictID = "" Then Exit Sub
        'moAddress = GetSchoolDistrictAddress(sDistrictID)

        'With moAddress
        '    txtBillTo_Name.Text = .AddressName
        '    txtBillTo_Street.Text = .StreetAddress
        '    txtBillTo_City.Text = .City
        '    txtBillTo_State.Text = .State
        '    txtBillTo_Zip.Text = .Zip

        'End With
    End Sub

    Private Sub cmbDistricts2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDistricts2.EditValueChanged
        LoadSchools2()
        txtDistrictID.Text = cmbDistricts2.EditValue.ToString
    End Sub

    Private Sub cmbDistricts2_Popup(sender As Object, e As EventArgs) Handles cmbDistricts2.Popup


    End Sub

    Private Sub cmbSchools2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSchools2.EditValueChanged
        txtSchoolID.Text = cmbSchools2.EditValue.ToString
    End Sub

    Private Sub cmdSetSchoolShipTo_Click(sender As Object, e As EventArgs) Handles cmdSetSchoolShipTo.Click
        Dim sSchoolID As String

        Dim oAddress As AddressStructure
        sSchoolID = txtSchoolID.Text
        oAddress = GetSchoolMailAddress(sSchoolID)

        With oAddress
            txtShipTo_Name.Text = .AddressName
            txtShipTo_Address.Text = .StreetAddress
            txtShipTo_City.Text = .City
            txtShipTo_Zip.Text = .Zip
            txtShipTo_State.Text = .State

        End With
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim oOrder As New Order
        Dim oBillToAddress As New AddressStructure
        Dim oShipToAddress As New AddressStructure
        Dim sReturn As String


        With oBillToAddress
            .AddressName = txtBillTo_Name.Text
            .StreetAddress = txtBillTo_Street.Text
            .City = txtBillTo_City.Text
            .Zip = txtBillTo_Zip.Text
            .State = txtBillTo_State.Text

        End With

        With oShipToAddress
            .AddressName = txtShipTo_Name.Text
            .StreetAddress = txtShipTo_Address.Text
            .City = txtShipTo_City.Text
            .Zip = txtShipTo_Zip.Text
            .State = txtShipTo_State.Text
            .ATTN = txtShipTo_Attn.Text

        End With

        With oOrder
            .OrderID = Me.oOrderID

            If txtDistrictID.Text = "" Then
                .DistrictID = Guid.Empty.ToString
            Else
                .DistrictID = txtDistrictID.Text
            End If

            If txtSchoolID.Text = "" Then
                .SchoolID = Guid.Empty.ToString
            Else
                .SchoolID = txtSchoolID.Text
            End If


            .BHPONumber = txtBillTo_BHPO.Text

            .BillToAddress = oBillToAddress
            .ShipToAddress = oShipToAddress

            .PurchasingContactName = txtPurchasing_Name.Text
            .PurchasingContactPhone = txtPurchasing_Phone.Text
            .PurchasingContactEmail = txtPurchasing_email.Text
            .PurchasingPONumber = txtPurchasing_PurchasingPONumber.Text
            .PurchasingPODueDate = txtPurchasing_DueDate.Text

            .OrderNotes = txtOrderNotes.Text

            .PO_Amount = txtPO_Amount.Text
            .PO_DiscountAmount = txtPO_DiscountAmount.Text
            .PO_TotalAmount = txtPO_TotalAmount.Text
            .PO_Shipping = txtPO_Shipping.Text

            .OrderStatus = cmbOrderStatus.EditValue

            'Need to keep these because we write back to DB

            If txtCreateTime.Text.Length > 0 Then
                .CreateTime = CDate(txtCreateTime.Text)

            Else
                .CreateTime = Now()
            End If




        End With

        sReturn = omOrders_IU(oOrder, bExistingOrder)

        Select Case sReturn
            Case "1"
                MsgBox("Order Saved.")
                Me.Close()

            Case ""
                MsgBox("There was a problem saving the order.")

            Case Else
                MsgBox("There was a problem saving the order.")
        End Select

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Dim iResponse As DialogResult

        iResponse = MessageBox.Show("Are you sure you want to Cancel with out saving?", "cancel?", MessageBoxButtons.YesNo)

        If iResponse = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub txtPO_Amount_TextChanged(sender As Object, e As EventArgs) Handles txtPO_Amount.TextChanged
        UpdatePOTotal()
    End Sub

    Private Sub txtPO_Shipping_TextChanged(sender As Object, e As EventArgs) Handles txtPO_Shipping.TextChanged
        UpdatePOTotal()
    End Sub

    Public Sub UpdatePOTotal()
        Dim oAmount As Decimal
        Dim oDiscountAmount As Decimal
        Dim oShipping As Decimal
        Dim oTotal As Decimal

        If txtPO_Amount.Text = "" Then
            txtPO_Amount.Text = "0.00"
            oAmount = 0.00

        Else
            oAmount = txtPO_Amount.Text
        End If

        If txtPO_DiscountAmount.Text = "" Then
            txtPO_DiscountAmount.Text = "0.00"
            oDiscountAmount = 0.00

        Else
            oDiscountAmount = txtPO_DiscountAmount.Text
        End If

        If txtPO_Shipping.Text = "" Then
            txtPO_Shipping.Text = "0.00"
            oShipping = 0.00
        Else
            oShipping = txtPO_Shipping.Text
        End If

        txtPO_TotalAmount.Text = (oShipping + oAmount) - oDiscountAmount
    End Sub

    Private Sub txtPO_Amount_Validating(sender As Object, e As CancelEventArgs) Handles txtPO_Amount.Validating
        If sender.text = "" Then Exit Sub

        If IsNumeric(sender.text) = False Then

            MsgBox("Must be Numeric")
            e.Cancel = True
            sender.focus()
        End If


    End Sub

    Private Sub txtPO_Amount_Validated(sender As Object, e As EventArgs) Handles txtPO_Amount.Validated
        UpdatePOTotal()
    End Sub

    Private Sub txtPO_Shipping_Validating(sender As Object, e As CancelEventArgs) Handles txtPO_Shipping.Validating
        If sender.text = "" Then Exit Sub

        If IsNumeric(sender.text) = False Then

            MsgBox("Must be Numeric")
            e.Cancel = True
            sender.focus()
        End If
    End Sub

    Private Sub txtPO_Shipping_Validated(sender As Object, e As EventArgs) Handles txtPO_Shipping.Validated
        UpdatePOTotal()
    End Sub

    Private Sub txtPurchasing_email_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasing_email.TextChanged

    End Sub

    Private Sub txtPurchasing_email_Validating(sender As Object, e As CancelEventArgs) Handles txtPurchasing_email.Validating

        If sender.text = "" Then Exit Sub

        If IsValidEmailFormat(sender.text) = False Then
            MsgBox("Must be a valid email")
            e.Cancel = True
            sender.focus()
        End If

    End Sub

    Private Sub txtPurchasing_DueDate_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasing_DueDate.TextChanged

    End Sub

    Private Sub txtPurchasing_DueDate_Validating(sender As Object, e As CancelEventArgs) Handles txtPurchasing_DueDate.Validating
        If sender.text = "" Then Exit Sub

        If IsDate(sender.text) = False Then

            MsgBox("Must be a Valid Date")
            e.Cancel = True
            sender.focus()
        End If

    End Sub

    Private Sub cmbOrderStatus_EditValueChanged(sender As Object, e As EventArgs) Handles cmbOrderStatus.EditValueChanged
        Call SetOrderStatusBackColor(sender)
    End Sub

    Private Sub cmbOrderStatus_CustomDrawCell(sender As Object, e As LookUpCustomDrawCellArgs) Handles cmbOrderStatus.CustomDrawCell



    End Sub

    Private Sub cmbOrderStatus_CustomDrawRow(sender As Object, e As LookUpCustomDrawRowArgs) Handles cmbOrderStatus.CustomDrawRow
        Dim edit As LookUpEdit = TryCast(sender, LookUpEdit)
        Dim sColor As String
        Dim oColor As Color


        Select Case e.Row


            Case Else

                If e.RowInfo.GetCellValue(1) <> "" Then
                    sColor = e.RowInfo.GetCellValue(1)
                    'e.RowInfo.GetColumn(2).ToString
                    'Dim blueBrush As SolidBrush = New SolidBrush(Color.Blue)

                    oColor = Color.FromName(sColor)
                    Dim ColorBrush As SolidBrush = New SolidBrush(oColor)
                    Dim rect As Rectangle = New Rectangle(0, 0, 200, 200)
                    rect = e.Bounds
                    e.Graphics.FillRectangle(ColorBrush, rect)

                    'e..BackColor = Color.FromName(e.RowInfo.GetColumn(2).ToString)
                End If


        End Select
    End Sub

    Private Sub cmbOrderStatus_Validated(sender As Object, e As EventArgs) Handles cmbOrderStatus.Validated
        Call SetOrderStatusBackColor(sender)

    End Sub


    Public Sub SetOrderStatusBackColor(sender As Object)
        Dim edit As LookUpEdit = TryCast(sender, LookUpEdit)
        Dim sColor As String
        Dim oColor As Color
        Dim oEditRow As DataRowView


        oEditRow = edit.GetSelectedDataRow

        If IsNothing(oEditRow) Then Exit Sub

        sColor = oEditRow.Row.Item(2).ToString()


        If sColor <> "" Then
            oColor = Color.FromName(sColor)

            edit.BackColor = oColor
        Else
            edit.BackColor = Color.White
        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs)
        'TextEdit1.Properties.DisplayFormat.FormatString = "c2"
    End Sub

    Private Sub TextEdit1_EditValueChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPO_DiscountAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPO_DiscountAmount.TextChanged
        UpdatePOTotal()
    End Sub

    Private Sub cmbDistricts2_ListChanged(sender As Object, e As ListChangedEventArgs) Handles cmbDistricts2.ListChanged

    End Sub

    Private Sub cmbDistricts2_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles cmbDistricts2.EditValueChanging

    End Sub

    Private Sub cmdSetDistrictBillTo_Click(sender As Object, e As EventArgs) Handles cmdSetDistrictBillTo.Click
        Dim sDistrictID As String

        Dim oAddress As AddressStructure
        sDistrictID = txtDistrictID.Text
        oAddress = GetDistrictMailAddress(sDistrictID)

        With oAddress
            txtBillTo_Name.Text = .AddressName
            txtBillTo_Street.Text = .StreetAddress
            txtBillTo_City.Text = .City
            txtBillTo_State.Text = .State
            txtBillTo_Zip.Text = .Zip



        End With
    End Sub
End Class