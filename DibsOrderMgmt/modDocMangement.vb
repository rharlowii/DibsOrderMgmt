Imports System.Data.SqlClient
Imports System.IO

Module modDocMangement
    'Public Enum OrderDocTypes
    '    NoDocumentType = 0
    '    CustPO = 10
    '    CustQuote = 20
    '    CustInvoice = 30
    '    CustLabels = 40
    '    PubPO = 50
    '    PubInvoice = 60
    '    Other = 1000

    'End Enum


    'Public Structure OrderDocTypes
    '    Const NoDocumentType = 0
    '    Const CustPO = 10
    '    Const CustQuote = 20
    '    Const CustInvoice = 30
    '    Const CustLabels = 40
    '    Const PubPO = 50
    '    Const PubInvoice = 60
    '    Const Other = 1000

    'End Structure
    Public Structure OrderDocument
        Public OrderID As Guid
        Public DocumentID As Guid
        Public OrderDocName As String
        Public OrderDoc As Byte()  ' Actual bytes of file
        Public OrderDocFilePath As String
        Public OrderDocTypeID As Integer
        Public OrderDocNotes As String
        Public PartnerID As Integer
        Public bFromDragDrop As Boolean
        Public bExistingDocument As Boolean
        Public bReplaceDocument As Boolean


    End Structure

    Public Function InsertDocumentIntoDB(oOrderDocument As OrderDocument) As String
        Dim sFileName As String
        Dim bytes As Byte()
        ' From a local file so need to read into Memory
        If oOrderDocument.bExistingDocument = False Or oOrderDocument.bReplaceDocument = True Then
            'If not an exisiting document
            If oOrderDocument.bFromDragDrop = False Then

                sFileName = oOrderDocument.OrderDocFilePath

                ' sFileName = "Y:\MEP - Shared\BrainHive\BH_OrderMgmt\PO_Customer\AL_BIBB_CO_BOE_WEST_BLOCTON_PO_GF21-155.pdf"

                Dim fs As New IO.FileStream(sFileName, FileMode.Open, FileAccess.Read)

                Dim br As New BinaryReader(fs)



                bytes = System.IO.File.ReadAllBytes(sFileName)
            Else
                'So this if from Memory..go ahead copy the bytes
                bytes = oOrderDocument.OrderDoc

            End If

        End If

        'insert the file into database

        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1
        'Added partner ID and narrowed the matching
        Dim sEXEC As String

        If oOrderDocument.bExistingDocument = False Or oOrderDocument.bReplaceDocument = True Then

            sEXEC = "omOrderDocuments_IU_ALT @OrderID,@DocumentID,@OrderDocName,@OrderDoc,@OrderDocTypeID ,@OrderDocNotes, @CreateTime, @UpdateTime,@PartnerID"

        Else
            sEXEC = "UPDATE dbo.omOrderDocuments SET OrderDocName = @OrderDocName,OrderDocTypeID = @OrderDocTypeID,OrderDocNotes =@OrderDocNotes,UpdateTime = GETDATE() where DocumentID = @DocumentID"

        End If
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            If oOrderDocument.bExistingDocument = False Or oOrderDocument.bReplaceDocument = True Then

                .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = oOrderDocument.OrderID
                .Parameters.Add("@DocumentID", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid

                .Parameters.Add("@OrderDocName", SqlDbType.NVarChar).Value = oOrderDocument.OrderDocName

                .Parameters.Add("@OrderDoc", SqlDbType.Binary).Value = bytes
                .Parameters.Add("@OrderDocTypeID", SqlDbType.Int).Value = oOrderDocument.OrderDocTypeID
                .Parameters.Add("@OrderDocNotes", SqlDbType.NVarChar).Value = oOrderDocument.OrderDocNotes

                .Parameters.Add("@CreateTime", SqlDbType.Date).Value = Now()
                .Parameters.Add("@UpdateTime", SqlDbType.Date).Value = Now()

                .Parameters.Add("@PartnerID", SqlDbType.Int).Value = oOrderDocument.PartnerID

            Else



                .Parameters.Add("@DocumentID", SqlDbType.UniqueIdentifier).Value = oOrderDocument.DocumentID

                .Parameters.Add("@OrderDocName", SqlDbType.NVarChar).Value = oOrderDocument.OrderDocName

            .Parameters.Add("@OrderDocTypeID", SqlDbType.Int).Value = oOrderDocument.OrderDocTypeID
            .Parameters.Add("@OrderDocNotes", SqlDbType.NVarChar).Value = oOrderDocument.OrderDocNotes

            .Parameters.Add("@UpdateTime", SqlDbType.Date).Value = Now()



            End If


            sReturn = .ExecuteNonQuery
        End With





        oConnection.Close()
        Return sReturn
        'sqlStr = "update YourTable set Columns = @Columns WHERE Column =      '" & detgrd(detgrd.Row, 0).ToString().ToUpper().Trim() & "' "

    End Function
    Public Function SaveOrderDocument(oOrderDocument As OrderDocument)

        Dim sEXEC As String = "Update omOrderDocuments Set OrderDoc= @OrderDoc,UpdateTime= @UpdateTime where DocumentID=@DocumentID"
        Dim sReturn As String

        Dim bytes As Byte()

        bytes = oOrderDocument.OrderDoc

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@DocumentID", SqlDbType.UniqueIdentifier).Value = oOrderDocument.DocumentID

            .Parameters.Add("@OrderDoc", SqlDbType.Binary).Value = bytes
            .Parameters.Add("@UpdateTime", SqlDbType.Date).Value = Now()

            sReturn = .ExecuteNonQuery
        End With





        oConnection.Close()
        Return sReturn
    End Function

    Public Function DeleteOrderDocument(sDocumentID As String)

        Dim sEXEC As String = "DELETE FROM dbo.omOrderDocuments where DocumentID=@DocumentID"
        Dim sReturn As String

        Dim bytes As Byte()

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@DocumentID", SqlDbType.UniqueIdentifier).Value = Guid.Parse(sDocumentID)


            sReturn = .ExecuteNonQuery
        End With





        oConnection.Close()
        Return sReturn
    End Function

End Module
