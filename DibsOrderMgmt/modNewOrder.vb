Imports System.Data.SqlClient

Public Structure AddressStructure

    Public AddressName As String
    Public StreetAddress As String
    Public City As String
    Public State As String
    Public Zip As String
    Public Zip4 As String

    Public Phone As String
    Public ID As Guid
    Public ATTN As String


End Structure

Public Structure Order
    Public OrderID As Guid
    Public DistrictID As String
    Public SchoolID As String
    Public BHPONumber As String
    Public BillToAddress As AddressStructure
    Public ShipToAddress As AddressStructure

    Public PurchasingContactName As String
    Public PurchasingContactPhone As String
    Public PurchasingContactEmail As String
    Public PurchasingPONumber As String
    Public PurchasingPODueDate As String

    Public EnteredBy As String


    Public OrderNotes As String

    Public PO_Amount As Decimal
    Public PO_DiscountAmount As Decimal
    Public PO_Shipping As Decimal
    Public PO_TotalAmount As Decimal
    Public OrderStatus As Integer
    Public OrderStatusDigital As Integer
    Public OrderStatusComm As Integer

    Public CreateTime As Date
    Public TrackingNumbers As String

    Public SalesRepID As Guid
    Public CommissionRate As Decimal
    Public OrderDescShort As String
    Public OrderHasDiffCommisionItems As Integer

End Structure
Module modNewOrder


    Public Function GetDistrictMailAddress(sDistrictID As String) As AddressStructure
        Try


            Dim sSQL As String
            Dim oAddress As New AddressStructure



            sSQL = "SELECT * FROM DiBS_DB_Prod.dbo.omqrySchoolDistrictMailing where ID='" & sDistrictID & "'"



            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            oConnection = New SqlConnection(sConnectionString)
            oConnection.Open()
            da = New SqlDataAdapter(sSQL, oConnection)


            da.Fill(ds)
            oConnection.Close()

            If ds.Tables(0).Rows.Count = 0 Then
                Return oAddress

            End If
            With oAddress
                .AddressName = ds.Tables(0).Rows(0).Item("DistrictName").ToString
                .StreetAddress = ds.Tables(0).Rows(0).Item("StreetAddress").ToString
                .City = ds.Tables(0).Rows(0).Item("City").ToString
                .State = ds.Tables(0).Rows(0).Item("State").ToString
                .Zip = ds.Tables(0).Rows(0).Item("Zip").ToString
                .Zip4 = ds.Tables(0).Rows(0).Item("Zip 4-digit").ToString
                .Phone = ds.Tables(0).Rows(0).Item("Phone").ToString
                .ID = ds.Tables(0).Rows(0).Item("ID")



            End With

            Return oAddress
        Catch ex As Exception

        End Try
    End Function
    Public Function GetSchoolMailAddress(sSchoolID As String) As AddressStructure
        Try


            Dim sSQL As String
            Dim oAddress As New AddressStructure



            sSQL = "SELECT * FROM Schools where ID='" & sSchoolID & "'"



            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            oConnection = New SqlConnection(sConnectionString)
            oConnection.Open()
            da = New SqlDataAdapter(sSQL, oConnection)


            da.Fill(ds)
            oConnection.Close()

            If ds.Tables(0).Rows.Count = 0 Then
                Return oAddress

            End If
            With oAddress
                .AddressName = ds.Tables(0).Rows(0).Item("Name")
                .StreetAddress = ds.Tables(0).Rows(0).Item("Address")
                .City = ds.Tables(0).Rows(0).Item("City")
                .State = ds.Tables(0).Rows(0).Item("State")
                .Zip = ds.Tables(0).Rows(0).Item("Zip")
                '  .Zip4 = ds.Tables(0).Rows(0).Item("Zip 4-digit")
                '  .Phone = ds.Tables(0).Rows(0).Item("Phone")
                .ID = ds.Tables(0).Rows(0).Item("ID")


            End With

            Return oAddress
        Catch ex As Exception

        End Try
    End Function

    Public Function omOrders_IU(oOrder As Order, bExisitingOrder As Boolean) As String

        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "omOrders_IU @OrderID,@DistrictID,@SchoolID,@BHPONumber,@BillTo_Name ,@BillTo_Street,@BillTo_City ,@BillTo_Zip ,@BillTo_State ,@ShipTo_Name ,@ShipTo_Street ,@ShipTo_City ,@ShipTo_Zip ,@ShipTo_State ,@ShipTo_ATTN,@PurchasingContactName,@PurchasingContactPhone,@PurchasingContactEmail,@PurchasingPONumber,@OrderNotes,@OrderDate,@DueDate,@SpecialInstruction,@EnteredBy, @CreateTime, @UpdateTime,@PO_Amount,@PO_DiscountAmount,@PO_Shipping,@PO_TotalAmount,@OrderStatusID,@TrackingNumbers,@SalesRepID,@CommissionRate,@OrderDescShort,@OrderHasDiffCommisionItems,@OrderStatusDigitalID,@OrderStatusCommID"


        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrder.OrderID)

            .Parameters.Add("@DistrictID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrder.DistrictID)
            .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrder.SchoolID)

            .Parameters.Add("@BHPONumber", SqlDbType.NVarChar).Value = oOrder.BHPONumber
            .Parameters.Add("@BillTo_Name", SqlDbType.NVarChar).Value = oOrder.BillToAddress.AddressName
            .Parameters.Add("@BillTo_Street", SqlDbType.NVarChar).Value = oOrder.BillToAddress.StreetAddress
            .Parameters.Add("@BillTo_City", SqlDbType.NVarChar).Value = oOrder.BillToAddress.City
            .Parameters.Add("@BillTo_Zip", SqlDbType.NVarChar).Value = oOrder.BillToAddress.Zip
            .Parameters.Add("@BillTo_State", SqlDbType.NVarChar).Value = oOrder.BillToAddress.State


            .Parameters.Add("@ShipTo_Name", SqlDbType.NVarChar).Value = oOrder.ShipToAddress.AddressName
            .Parameters.Add("@ShipTo_Street", SqlDbType.NVarChar).Value = oOrder.ShipToAddress.StreetAddress
            .Parameters.Add("@ShipTo_City", SqlDbType.NVarChar).Value = oOrder.ShipToAddress.City
            .Parameters.Add("@ShipTo_Zip", SqlDbType.NVarChar).Value = oOrder.ShipToAddress.Zip
            .Parameters.Add("@ShipTo_State", SqlDbType.NVarChar).Value = oOrder.ShipToAddress.State

            .Parameters.Add("@ShipTo_ATTN", SqlDbType.NVarChar).Value = oOrder.ShipToAddress.ATTN
            .Parameters.Add("@PurchasingContactName", SqlDbType.NVarChar).Value = oOrder.PurchasingContactName
            .Parameters.Add("@PurchasingContactPhone", SqlDbType.NVarChar).Value = oOrder.PurchasingContactPhone
            .Parameters.Add("@PurchasingContactEmail", SqlDbType.NVarChar).Value = oOrder.PurchasingContactEmail

            .Parameters.Add("@PurchasingPONumber", SqlDbType.NVarChar).Value = oOrder.PurchasingPONumber


            .Parameters.Add("@OrderNotes", SqlDbType.NVarChar).Value = oOrder.OrderNotes


            If oOrder.PurchasingPODueDate.Length > 0 Then
                .Parameters.Add("@DueDate", SqlDbType.Date).Value = oOrder.PurchasingPODueDate
            Else
                .Parameters.Add("@DueDate", SqlDbType.Date).Value = DBNull.Value

            End If

            .Parameters.Add("@SpecialInstruction", SqlDbType.NVarChar).Value = ""


            .Parameters.Add("@EnteredBy", SqlDbType.NVarChar).Value = ""

            If bExisitingOrder = False Then
                .Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = Now()
                .Parameters.Add("@OrderDate", SqlDbType.Date).Value = Now().ToShortDateString
            Else
                .Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = oOrder.CreateTime
                .Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = oOrder.CreateTime.ToShortDateString
            End If

            .Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = Now()

            .Parameters.Add("@PO_Amount", SqlDbType.Decimal).Value = oOrder.PO_Amount
            '
            .Parameters.Add("@PO_DiscountAmount", SqlDbType.Decimal).Value = oOrder.PO_DiscountAmount
            .Parameters.Add("@PO_Shipping", SqlDbType.Decimal).Value = oOrder.PO_Shipping
            .Parameters.Add("@PO_TotalAmount", SqlDbType.Decimal).Value = oOrder.PO_TotalAmount

            .Parameters.Add("@OrderStatusID", SqlDbType.Decimal).Value = oOrder.OrderStatus

            .Parameters.Add("@TrackingNumbers", SqlDbType.NVarChar).Value = oOrder.TrackingNumbers.ToString

            .Parameters.Add("@OrderStatusDigitalID", SqlDbType.Int).Value = oOrder.OrderStatusDigital
            .Parameters.Add("@OrderStatusCommID", SqlDbType.Int).Value = oOrder.OrderStatusComm

            .Parameters.Add("@SalesRepID", SqlDbType.UniqueIdentifier).Value = oOrder.SalesRepID
            .Parameters.Add("@CommissionRate", SqlDbType.Decimal).Value = oOrder.CommissionRate
            .Parameters.Add("@OrderDescShort", SqlDbType.NVarChar).Value = oOrder.OrderDescShort
            .Parameters.Add("@OrderHasDiffCommisionItems", SqlDbType.Bit).Value = oOrder.OrderHasDiffCommisionItems


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function GetOrderInfo(oOrderID As Guid) As DataTable

        Dim sSQL As String

        sSQL = "SELECT * FROM DiBS_DB_Prod.dbo.omOrders WHERE orderid='{OrderID}'"

        sSQL = sSQL.Replace("{OrderID}", oOrderID.ToString)


        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds.Tables(0)


    End Function

    Public Function GetSchoolDistrictAddress(sDistrictID As String) As AddressStructure
        Dim sSQL As String

        sSQL = "Select * from omqrySchoolDistrictMailing where ID='{ID}'"
        Dim oAddress As New AddressStructure


        sSQL = sSQL.Replace("{ID}", sDistrictID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then


            With ds.Tables(0).Rows(0)
                oAddress.AddressName = .Item("DistrictName").ToString
                oAddress.StreetAddress = .Item("StreetAddress").ToString
                oAddress.City = .Item("City").ToString
                oAddress.State = .Item("State").ToString
                oAddress.Zip = .Item("Zip").ToString
                oAddress.Zip4 = .Item("Zip 4-digit").ToString
                oAddress.Phone = .Item("Phone").ToString
            End With
        End If
        Return oAddress

    End Function

    Public Function DuplicateOrder(oOrderIDToDuplicate As Guid) As String


        'Get the Order to Duplicate



        Dim oDuplicateOrder As New Order
        Dim oBillToAddress As New AddressStructure
        Dim oShipToAddress As New AddressStructure
        Dim oOrderDataTable As DataTable
        Dim sReturn As String
        Dim oNewOrderID As Guid
        oOrderDataTable = GetOrderInfo(oOrderIDToDuplicate)
        oNewOrderID = Guid.NewGuid



        With oOrderDataTable.Rows(0)
            oBillToAddress.AddressName = .Item("BillTo_Name").ToString
            oBillToAddress.StreetAddress = .Item("BillTo_Street").ToString
            oBillToAddress.City = .Item("BillTo_City").ToString
            oBillToAddress.Zip = .Item("BillTo_Zip").ToString
            oBillToAddress.State = .Item("BillTo_State").ToString

        End With

        With oOrderDataTable.Rows(0)
            oShipToAddress.AddressName = .Item("ShipTo_Name").ToString
            oShipToAddress.StreetAddress = .Item("ShipTo_Street").ToString
            oShipToAddress.City = .Item("ShipTo_City").ToString
            oShipToAddress.Zip = .Item("ShipTo_Zip").ToString
            oShipToAddress.State = .Item("ShipTo_State").ToString
            oShipToAddress.ATTN = .Item("ShipTo_ATTN").ToString

        End With

        With oOrderDataTable.Rows(0)

            'Need to give a new order before adding to database
            oDuplicateOrder.OrderID = oNewOrderID

            oDuplicateOrder.DistrictID = .Item("DistrictID").ToString

            oDuplicateOrder.SchoolID = .Item("SchoolID").ToString



            oDuplicateOrder.BHPONumber = .Item("BHPONumber").ToString & " (Duplicate)"

            oDuplicateOrder.BillToAddress = oBillToAddress
            oDuplicateOrder.ShipToAddress = oShipToAddress

            oDuplicateOrder.PurchasingContactName = .Item("PurchasingContactName").ToString
            oDuplicateOrder.PurchasingContactPhone = .Item("PurchasingContactPhone").ToString
            oDuplicateOrder.PurchasingContactEmail = .Item("PurchasingContactEmail").ToString
            oDuplicateOrder.PurchasingPONumber = .Item("PurchasingPONumber").ToString
            oDuplicateOrder.PurchasingPODueDate = .Item("DueDate").ToString

            oDuplicateOrder.OrderNotes = .Item("OrderNotes").ToString

            oDuplicateOrder.PO_Amount = 0.00
            oDuplicateOrder.PO_DiscountAmount = 0.00
            oDuplicateOrder.PO_TotalAmount = 0.00
            oDuplicateOrder.PO_Shipping = 0.00

            oDuplicateOrder.OrderStatus = 0
            oDuplicateOrder.TrackingNumbers = ""
            oDuplicateOrder.OrderDescShort = ""

            'Need to keep these because we write back to DB


            oDuplicateOrder.CreateTime = Now()





        End With

        sReturn = omOrders_IU(oDuplicateOrder, False)

        Select Case sReturn
            Case "1"
                Return oDuplicateOrder.OrderID.ToString

            Case ""
                Return ""

            Case Else
                Return ""
        End Select

    End Function
End Module
