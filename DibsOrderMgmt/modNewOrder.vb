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

    Public CreateTime As Date


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
                .AddressName = ds.Tables(0).Rows(0).Item("DistrictName")
                .StreetAddress = ds.Tables(0).Rows(0).Item("StreetAddress")
                .City = ds.Tables(0).Rows(0).Item("City")
                .State = ds.Tables(0).Rows(0).Item("State")
                .Zip = ds.Tables(0).Rows(0).Item("Zip")
                .Zip4 = ds.Tables(0).Rows(0).Item("Zip 4-digit")
                .Phone = ds.Tables(0).Rows(0).Item("Phone")
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

        Dim sEXEC As String = "omOrders_IU @OrderID,@DistrictID,@SchoolID,@BHPONumber,@BillTo_Name ,@BillTo_Street,@BillTo_City ,@BillTo_Zip ,@BillTo_State ,@ShipTo_Name ,@ShipTo_Street ,@ShipTo_City ,@ShipTo_Zip ,@ShipTo_State ,@PurchasingContactName,@PurchasingContactPhone,@PurchasingContactEmail,@PurchasingPONumber,@OrderNotes,@OrderDate,@DueDate,@SpecialInstruction,@EnteredBy, @CreateTime, @UpdateTime,@PO_Amount,@PO_DiscountAmount,@PO_Shipping,@PO_TotalAmount,@OrderStatusID"
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


End Module
