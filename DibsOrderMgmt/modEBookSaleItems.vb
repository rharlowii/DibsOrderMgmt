Imports System.Data.SqlClient

Module modEBookSaleItems


    Public Structure EBookSaleItem

        Public EBookSaleItemID As String
        Public OrderID As String
        Public PubID As String
        Public PubName As String
        Public ISBN As String
        Public Title As String
        Public Price As Decimal
        Public SchoolName As String
        Public LoadDate As Date
        Public Distributor As String
        Public QTY As Integer
        Public EBookSaleItemStatus As EBookSaleItemStatus
        Public EBookSaleItemStatusText As String

        ' Public OrderID As String
        ' Public OrderSetID As String
        ' Public PartnerID As Integer

    End Structure

    Public Enum EBookSaleItemStatus
        NotFoundInDB = -1
        NoStaus = 0
        FoundInDB = 1
        MissingCriticalInfo = 2
        Morethan1FoundInDB = 3


    End Enum

    Public Function omEbookSales_IU_ALT(oEBookSaleItem As EBookSaleItem, oOrderID As Guid) As String

        'Changed the stand UI proc to accomdate running the add multiple times and it not adding duplicate
        ' WHERE OrderSetID = @OrderSetID AND OrderSetID=@OrderSetID AND ItemNumber =@ItemNumber

        Dim sEXEC As String


        sEXEC = "omEbookSales_IU_ALT  @EbookSaleID,@OrderID,@PubID,@PubName,@ISBN,@Title,@Price,@SchoolName,@LoadDate,@Distributor,@QTY"


        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)
        'oEBookSaleItem

        With myCommand
            .Parameters.Add("@EbookSaleID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oEBookSaleItem.EBookSaleItemID)
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderID)
            .Parameters.Add("@PubID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oEBookSaleItem.PubID)
            .Parameters.Add("@PubName", SqlDbType.NVarChar).Value = oEBookSaleItem.PubName

            .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = oEBookSaleItem.ISBN
            .Parameters.Add("@Title", SqlDbType.NVarChar).Value = oEBookSaleItem.Title
            .Parameters.Add("@Price", SqlDbType.Decimal).Value = oEBookSaleItem.Price
            .Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = oEBookSaleItem.SchoolName
            .Parameters.Add("@LoadDate", SqlDbType.Date).Value = oEBookSaleItem.LoadDate
            .Parameters.Add("@Distributor", SqlDbType.NVarChar).Value = oEBookSaleItem.Distributor

            .Parameters.Add("@QTY", SqlDbType.Int).Value = oEBookSaleItem.QTY



            sReturn = .ExecuteNonQuery

            'If oOrderItem.OrderSetID <> Guid.Empty.ToString Then
            '    .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.OrderSetID)
            'Else
            '    'Using NULL caused issues when comparing later in Stored Proc
            '    .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = Guid.Empty
            'End If
            'oEBookSaleItem


            ' .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.MetaDataID)
            'If IsNothing(oOrderItem.MetaDataID) = False And oOrderItem.MetaDataID <> "" Then
            '    .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItem.MetaDataID)
            'Else
            '    'Using NULL caused issues when comparing later in Stored Proc...be careful...this is probably not an issue with thise field
            '    .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = System.DBNull.Value
            'End If


        End With
        oConnection.Close()

        Return sReturn

    End Function

End Module
