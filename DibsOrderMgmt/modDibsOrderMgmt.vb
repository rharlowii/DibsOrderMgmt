
Imports System.Data.SqlClient

Module modDibsOrderMgmt

    Public Structure PubInvoiceItems
        Public PubPaymentID As String
        Public OrderID As String
        Public PartnerID As Integer
        Public PublisherInvoiceNumber As String
        Public InvoiceAmount As Decimal
        Public DueDate As Date
        Public PlanToPlay As Date
        Public DatePaid As Date

        Public BHPONumber As String '' ' Optional


    End Structure
    Public Function omPubPaymentTracker_IU_ALT(oPubInvoiceItem As PubInvoiceItems, oOrderID As Guid) As String


        Dim sEXEC As String

        sEXEC = "omPubPaymentTracker_IU_ALT @PubPaymentID,@OrderID,@PartnerID,@PublisherInvoiceNumber,@InvoiceAmount,@DueDate,@PlanToPay,@DatePaid"


        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@PubPaymentID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oPubInvoiceItem.PubPaymentID)
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderID)

            .Parameters.Add("@PartnerID", SqlDbType.Int).Value = oPubInvoiceItem.PartnerID


            .Parameters.Add("@PublisherInvoiceNumber", SqlDbType.NVarChar).Value = oPubInvoiceItem.PublisherInvoiceNumber
            .Parameters.Add("@InvoiceAmount", SqlDbType.Decimal).Value = oPubInvoiceItem.InvoiceAmount

            .Parameters.Add("@DueDate", SqlDbType.Date).Value = oPubInvoiceItem.DueDate
            .Parameters.Add("@PlanToPay", SqlDbType.Date).Value = oPubInvoiceItem.PlanToPlay
            .Parameters.Add("@DatePaid", SqlDbType.Date).Value = oPubInvoiceItem.DatePaid



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

End Module
