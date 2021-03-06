Imports System.Data.SqlClient

Module modOrderItems

    Public Structure OrderItem

        Public OrderItemID As String
        Public OrderID As String
        Public OrderSetID As String
        Public PartnerID As Integer
        Public MetaDataID As String

        Public ItemNumberISBN As String
        Public ItemDesc As String
        Public QTY As Integer
        Public ListPrice As Decimal
        Public ExtendedPrice As Decimal
        Public SubOrderItemID As String

        Public OrderItemStatus As OrderItemStatus
        Public OrderItemStatusText As String



    End Structure

    Public Structure OrderSet

        Public OrderSetID As String
        Public OrderID As String

        Public SetName As String
        Public SetDesc As String
        Public QTY As Integer
        Public ListPrice As Decimal
        Public ExtendedPrice As Decimal





    End Structure
    Public Structure DuplicateOrderSet

        Public OrderSetIDOrig As String
        Public OrderIDOrig As String
        Public OrderSetNew As OrderSet




    End Structure
    Public Enum OrderItemStatus
        NotFoundInDB = -1
        NoStaus = 0
        FoundInDB = 1
        MissingCriticalInfo = 2
        Morethan1FoundInDB = 3


    End Enum



    Public Structure PartnerList
        Public iPartnerID As Integer
        Public sPublisherShortName As String

    End Structure


    Public Function omOrderItems_IU_ALT(oOrderItem As OrderItem, oOrderID As Guid,optional bSubOrderItem As Boolean=false) As String

        'Changed the stand UI proc to accomdate running the add multiple times and it not adding duplicate
        ' WHERE OrderSetID = @OrderSetID AND OrderSetID=@OrderSetID AND ItemNumber =@ItemNumber

        Dim sEXEC As String

        'Decided to keep the code together
        'If it is a sub Order Item, then we need to call a different proc
        'They are two separate tables with identical structure
        If bSubOrderItem = False Then
            sEXEC = "omOrderItems_IU_ALT @OrderItemID,@OrderID,@OrderSetID,@PartnerID,@MetaDataID,@ItemNumber,@ItemDesc,@QTY,@ListPrice,@ExtendedPrice"

        Else
            sEXEC = "omOrderItemSubs_IU_ALT @OrderItemID,@OrderID,@OrderSetID,@PartnerID,@MetaDataID,@ItemNumber,@ItemDesc,@QTY,@ListPrice,@ExtendedPrice"

        End If
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderItemID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.OrderItemID)
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderID)

            If oOrderItem.OrderSetID <> Guid.Empty.ToString Then
                .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.OrderSetID)
            Else
                'Using NULL caused issues when comparing later in Stored Proc
                .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = Guid.Empty
            End If

            .Parameters.Add("@PartnerID", SqlDbType.Int).Value = oOrderItem.PartnerID

            ' .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.MetaDataID)
            If IsNothing(oOrderItem.MetaDataID) = False And oOrderItem.MetaDataID <> "" Then
                .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.MetaDataID)
            Else
                'Using NULL caused issues when comparing later in Stored Proc...be careful...this is probably not an issue with thise field
                .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = System.DBNull.Value
            End If
            .Parameters.Add("@ItemNumber", SqlDbType.NVarChar).Value = oOrderItem.ItemNumberISBN
            .Parameters.Add("@ItemDesc", SqlDbType.NVarChar).Value = oOrderItem.ItemDesc

            .Parameters.Add("@QTY", SqlDbType.Int).Value = oOrderItem.QTY

            .Parameters.Add("@ListPrice", SqlDbType.Decimal).Value = oOrderItem.ListPrice
            .Parameters.Add("@ExtendedPrice", SqlDbType.Decimal).Value = oOrderItem.ExtendedPrice


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function GetPartnersInOrder(sOrderID As String) As DataTable
        Dim sSQL As String

        sSQL = "Select omOrderItems.PartnerID,omOrderItems.OrderID,omPartners.PublisherShortName " &
            "From dbo.omOrderItems " &
            "INNER Join dbo.omPartners " &
            "On omOrderItems.PartnerID = omPartners.PartnerID " &
            "WHERE omOrderItems.OrderID = '{OrderID}' " &
            "GROUP BY omOrderItems.PartnerID " &
            ",omOrderItems.OrderID " &
            ",omPartners.PublisherShortName"

        sSQL = sSQL.Replace("{OrderID}", sOrderID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        Return ds.Tables(0)

    End Function
    Public Function GetPartnersInOrderMissingItems(sOrderID As String) As DataTable
        Dim sSQL As String

        sSQL = "Select omOrderItems.PartnerID,omOrderItems.OrderID,omPartners.PublisherShortName " &
            "From dbo.omOrderItems " &
            "INNER Join dbo.omPartners " &
            "On omOrderItems.PartnerID = omPartners.PartnerID " &
            "WHERE omOrderItems.OrderID = '{OrderID}' and QTYMissing > 0" &
            "GROUP BY omOrderItems.PartnerID " &
            ",omOrderItems.OrderID " &
            ",omPartners.PublisherShortName"

        sSQL = sSQL.Replace("{OrderID}", sOrderID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        Return ds.Tables(0)

    End Function
    Public Function GetOrderSetsInOrder(sOrderID As String) As DataTable
        Dim sSQL As String

        sSQL = "SELECT * FROM DiBS_DB_Prod.dbo.omOrderSets " &
               "WHERE omOrderSets.OrderID = '{OrderID}'  Order By SetName"


        sSQL = sSQL.Replace("{OrderID}", sOrderID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        Return ds.Tables(0)

    End Function
    Public Function GetOrderItemsInOrder(sOrderID As String) As DataTable
        Dim sSQL As String

        sSQL = "SELECT * FROM DiBS_DB_Prod.dbo.omOrderItems " &
               "WHERE omOrderItems.OrderID = '{OrderID}' "


        sSQL = sSQL.Replace("{OrderID}", sOrderID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        Return ds.Tables(0)

    End Function
    Public Function UpdateSubOrderItem(oOrderItem As OrderItem) As String

        'You are actually updating 
        Dim sEXEC As String = "UPDATE dbo.omOrderItems SET MetaDataID = NULL,ItemNumber = @ItemNumber,ItemDesc = @ItemDesc, QTY = @QTY,ListPrice = @ListPrice,ExtendedPrice = @ExtendedPrice,SubOrderItemID=@SubOrderItemID WHERE OrderItemID = @OrderItemID  AND OrderID=@OrderID"

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderItemID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.OrderItemID)

            .Parameters.Add("@ItemNumber", SqlDbType.NVarChar).Value = oOrderItem.ItemNumberISBN
            .Parameters.Add("@ItemDesc", SqlDbType.NVarChar).Value = oOrderItem.ItemDesc

            .Parameters.Add("@QTY", SqlDbType.Int).Value = oOrderItem.QTY

            .Parameters.Add("@ListPrice", SqlDbType.Decimal).Value = oOrderItem.ListPrice
            .Parameters.Add("@ExtendedPrice", SqlDbType.Decimal).Value = oOrderItem.ExtendedPrice

            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.OrderID)
            .Parameters.Add("@SubOrderItemID ", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.SubOrderItemID)


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function


    Public Function UpdateOrderStatus(sOrderID As String, iOrderStatus As Integer) As String

        'You are actually updating 
        Dim sEXEC As String = "UPDATE dbo.omOrders SET OrderStatusID = @OrderStatusID WHERE OrderID = @OrderID"

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sOrderID)
            .Parameters.Add("@OrderStatusID", SqlDbType.Int).Value = iOrderStatus



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function

    Public Function GetAddPubInvoiceOrders(bUpdateExisitngPubInvoice As Boolean) As DataTable

        'Basically, we only want to get BH PO #s where we actively are going to 
        '5/25/22 We narrow it down so much we could not edit ones that were a certain state
        'So for new we narrow....for edit we take anything
        '    Dim sSQL As String = "SELECT OrderId,BHPONumber FROM DiBS_DB_Prod.dbo.omOrders WHERE OrderStatusID>0 AND OrderStatusID<=40 ORDER BY BHPONumber "
        Dim sSQL As String

        If bUpdateExisitngPubInvoice = False Then
            sSQL = "SELECT BHPONumber as BHPONumberID,BHPONumber,OrderID FROM DiBS_DB_Prod.dbo.omOrders WHERE OrderStatusID>0 AND OrderStatusID<=40 ORDER BY BHPONumber "
        Else
            sSQL = "SELECT BHPONumber as BHPONumberID,BHPONumber,OrderID FROM DiBS_DB_Prod.dbo.omOrders WHERE OrderStatusID>0 ORDER BY BHPONumber "

        End If

        'BHPONumberID
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds.Tables(0)



    End Function

    Public Function omOrderSets_IU(oOrderSet As Object) As String

        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1
        'Hack to get around passing structures
        Dim moOrderSet As OrderSet
        moOrderSet = oOrderSet

        ' Dim sEXEC As String = "omOrderSets_IU @OrderSetID,@OrderID,@BoxNumber,@SetName,@SetDesc"
        Dim sEXEC As String = "omOrderSets_IU @OrderSetID,@OrderID,@SetName,@SetDesc,@QTY,@ListPrice,@ExtendPrice"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        Dim oOrderSetID As Guid

        oOrderSetID = Guid.NewGuid


        With myCommand

            .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(moOrderSet.OrderSetID)
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(moOrderSet.OrderID)

            .Parameters.Add("@QTY", SqlDbType.Int).Value = moOrderSet.QTY
            .Parameters.Add("@SetName", SqlDbType.NVarChar).Value = moOrderSet.SetName
            .Parameters.Add("@SetDesc", SqlDbType.NVarChar).Value = moOrderSet.SetDesc

            .Parameters.Add("@ListPrice", SqlDbType.Decimal).Value = moOrderSet.ListPrice
            .Parameters.Add("@ExtendPrice", SqlDbType.Decimal).Value = moOrderSet.ExtendedPrice

            sReturn = .ExecuteNonQuery


        End With


        oConnection.Close()

        Return sReturn

    End Function

    Public Function InsertDuplicateOrderItems(InsertDuplicateOrderItemsSQL As String) As String

        'You are actually updating 
        Dim sEXEC As String = InsertDuplicateOrderItemsSQL

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function
End Module
