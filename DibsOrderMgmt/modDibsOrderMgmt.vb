
Imports System.Data.SqlClient

Module modDibsOrderMgmt

    Public Structure PubInvoiceItem
        Public PubPaymentID As String
        Public OrderID As String
        Public PartnerID As Integer
        Public PublisherInvoiceNumber As String
        Public InvoiceAmount As Decimal
        Public DueDate As Date
        Public PlanToPlay As Date
        Public DatePaid As Date

        Public BHPONumber As String '' ' Optional
        Public PublisherName As String ' Optional

    End Structure

    Public Structure MissingItem

        Public OrderID As String
        Public PartnerID As Integer
        Public ItemNumber As String
        Public ItemDesc As String
        Public BHPONumber As String '' ' Optional
        Public PublisherName As String ' Optional
        Public QTYMissing As Integer


    End Structure

    Public Structure AddEbookToSchool

        Public BookID As String
        Public ISBN As String
        Public Title As String 'Optional
        Public PublisherName As String ' Optional
        Public AddEbookStatus As AddBookToSchoolStatus
        Public AddEbookStatusText As String
        Public MissingEBookPath As Boolean



    End Structure

    Public Enum AddBookToSchoolStatus
        NotFoundInDB = -1
        NoStatus = 0
        AddedToSchoolNoIssues = 1
        AddedToSchoolMissingBookPath = 2
        BookAlreadyInSchool = 3
        MissingCriticalInfo = 4
        Morethan1FoundInDB = 5
        InValidISBN = 6
        FoundInDB = 7
        MissingEBookPath = 8




    End Enum

    Public Function omPubPaymentTracker_IU_ALT(oPubInvoiceItem As PubInvoiceItem) As String


        Dim sEXEC As String

        sEXEC = "omPubPaymentTracker_IU_ALT @PubPaymentID,@OrderID,@PartnerID,@PublisherInvoiceNumber,@InvoiceAmount,@DueDate,@PlanToPay,@DatePaid"


        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@PubPaymentID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oPubInvoiceItem.PubPaymentID)
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oPubInvoiceItem.OrderID)

            .Parameters.Add("@PartnerID", SqlDbType.Int).Value = oPubInvoiceItem.PartnerID


            .Parameters.Add("@PublisherInvoiceNumber", SqlDbType.NVarChar).Value = oPubInvoiceItem.PublisherInvoiceNumber
            .Parameters.Add("@InvoiceAmount", SqlDbType.Decimal).Value = oPubInvoiceItem.InvoiceAmount

            If oPubInvoiceItem.DueDate = DateTime.MinValue Then
                .Parameters.Add("@DueDate", SqlDbType.Date).Value = DBNull.Value
            Else
                .Parameters.Add("@DueDate", SqlDbType.Date).Value = oPubInvoiceItem.DueDate
            End If

            If oPubInvoiceItem.PlanToPlay = DateTime.MinValue Then
                .Parameters.Add("@PlanToPlay", SqlDbType.Date).Value = DBNull.Value
            Else
                .Parameters.Add("@PlanToPay", SqlDbType.Date).Value = oPubInvoiceItem.PlanToPlay
            End If


            If oPubInvoiceItem.DatePaid = DateTime.MinValue Then
                .Parameters.Add("@DatePaid", SqlDbType.Date).Value = DBNull.Value

            Else
                .Parameters.Add("@DatePaid", SqlDbType.Date).Value = oPubInvoiceItem.DatePaid
            End If



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function
    Public Function GetPartnerInfo(iPartnerID As Integer) As DataTable

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString



        sSQL = "SELECT * FROM omPartners WHERE PartnerID={PartnerID}"
        sSQL = sSQL.Replace("{PartnerID}", iPartnerID)

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
