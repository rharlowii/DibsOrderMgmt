Imports System.Data.SqlClient
Imports System.IO

Public Class frmACHDateScheduled
    Public oPubInvoiceItems As Object 'Need to get around weird module structure mess
    Private moPubInvoiceItems As List(Of PubInvoiceItem)
    Public TotalInvoices As Decimal
    Public PublisherName As String
    Public oPubInvoicesDataTable As DataTable
    Public iPartnerID As Integer


    Private Sub frmACHDateScheduled_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Need to get around weird module structure mess
        moPubInvoiceItems = oPubInvoiceItems
        '  GridView3.DataSource = oPubInvoicesDataTable
        LoadSelectedPubInvoiceGrid()

        lblPublisherName.Text = PublisherName
        lblTotalInvoiceAmounts.Text = FormatCurrency(TotalInvoices)



    End Sub

    Private Sub LoadSelectedPubInvoiceGrid()

        Dim sSQL As String = "SELECT * FROM omqryPubInvoiceTracker"
        Dim sWhereClause As String

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        sWhereClause = BuildWhereClause()

        sSQL = sSQL & sWhereClause

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        gridPubInvoices2.DataSource = ds.Tables(0)


    End Sub

    Private Function BuildWhereClause() As String
        Dim sWhere As String
        Dim oPubItem As PubInvoiceItem
        Dim iCount As Integer
        Dim x As Integer

        iCount = moPubInvoiceItems.Count
        x = 0

        For Each oPubItem In moPubInvoiceItems
            x = x + 1

            If x = iCount Then
                sWhere = sWhere & " PubPaymentID='" & oPubItem.PubPaymentID & "'"
            Else
                sWhere = sWhere & " PubPaymentID='" & oPubItem.PubPaymentID & "' or "
            End If


        Next

        sWhere = " Where " & sWhere

        Return sWhere

    End Function
    Public Function UpdatePubInvoicesPaid(oDatePaid As Date) As String

        'You are actually updating 
        Dim sWhereClause As String
        Dim sReturn As String
        Dim sEXEC As String

        sWhereClause = BuildWhereClause()
        sEXEC = "UPDATE dbo.omqryPubInvoiceTracker SET DatePaid = @DatePaid" & sWhereClause



        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            .Parameters.Add("@DatePaid", SqlDbType.Date).Value = oDatePaid


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cmdMarkInvoicesPaid_Click(sender As Object, e As EventArgs) Handles cmdMarkInvoicesPaid.Click




        Dim sMSG As String
        Dim iInvoicesCount As Integer
        Dim PaidDate As Date
        Dim iMsgBoxResult As MsgBoxResult
        Dim sRtrn As String


        iInvoicesCount = moPubInvoiceItems.Count
        PaidDate = DateEditInvoicePaidDate.EditValue

        If PaidDate = Date.MinValue Then
            sMSG = "You must enter a date that you want to mark the invoices paid."
            MsgBox(sMSG,, "No Date Selected.")
            Exit Sub
        End If


        sMSG = "You are about to mark " & iInvoicesCount & " invoices from the publisher: " & PublisherName & " as 'Paid' on " & DateEditInvoicePaidDate.Text

        iMsgBoxResult = MessageBox.Show(sMSG, "Mark Invoices Paid?", MessageBoxButtons.OKCancel)

        If iMsgBoxResult = MsgBoxResult.Cancel Then Exit Sub

        sRtrn = UpdatePubInvoicesPaid(PaidDate)

        If sRtrn > 0 Then

            sMSG = "Would you like to send an email letting the 'Publisher / Partner' know that the payment has been paid?"

            iMsgBoxResult = MessageBox.Show(sMSG, "Notify  'Publisher / Partner'?", MessageBoxButtons.YesNo)

            If iMsgBoxResult = MsgBoxResult.No Then Exit Sub


            SendPubIvoicesPaidEmail(PaidDate)
        Else
            sMSG = "THere was probably updating the 'Paid Date'"

            iMsgBoxResult = MessageBox.Show(sMSG, "Issue Updating 'Paid Date'", MessageBoxButtons.OK)
        End If







    End Sub

    Private Sub SendPubIvoicesPaidEmail(oPaidDate As date)
            
        Dim moBHMailItem As New BHMailItem
        Dim sTempFile As String
        Dim oAttachments As New List(Of MailItemAttachement)
        Dim oAttachment As New MailItemAttachement
        Dim sBHPO As String
        Dim oPartnerInfo As DataTable


        Dim moDocTypes As New clsDibsOrderMgmt.OrderDocTypes
        Dim sReturn As String


        Dim sSubject As String
        Dim sBody As String
        Dim sOrderID As String
        Dim mbNeedToUpdateMainGrid As Boolean
        Dim sTOEmail As String
        Dim sCCEmail As String
        Dim iEmailType As BHEmailTypes

        Dim ToAPContactEmail As String
        Dim CCAPContactEmail As String


        iEmailType = BHEmailTypes.PubInvoiceEmail
        oPartnerInfo = GetPartnerInfo(iPartnerID)

        ToAPContactEmail = oPartnerInfo.Rows(0).Item("ToAPContactEmail").ToString
        CCAPContactEmail = oPartnerInfo.Rows(0).Item("CCAPContactEmail").ToString

        sSubject = PublisherName & ": Scheduled Payments from Brain Hive on: " & oPaidDate.ToShortDateString

        sTOEmail = ToAPContactEmail
        sCCEmail = CCAPContactEmail

        sBody = "I have scheduled a ACH payment for the following invoices on: " & oPaidDate.ToShortDateString & "<br>"
        sBody = sBody & "<br>The total amount will be for: " & FormatCurrency(TotalInvoices) & "<br>" & "<br>"
        sBody = sBody & ConvertGridToHTMLText()
        sBody = sBody & "<br><br>Please let me know if you have any questions." & "<br>"

        With moBHMailItem
            .ToEmail = sTOEmail
            '.ToEmail = sTOEmail
            .CCEmail = sCCEmail & ";" & "rharlow@myedupartners.com"

            .Subject = sSubject
            .Body = sBody
            .EmailType = iEmailType

            ' SpreadsheetControl1.SaveDocument(sTempFile, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
            .Attachments = oAttachments
            'SpreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.Xlsx).ToString

            '.OrderID = Guid.Parse(sOrderID)
        End With
        'Passing the bNeedToUpdateMainGrid by Ref
        CreateBHMailItem(moBHMailItem)
    End Sub


    Public Function ConvertGridToHTMLText() As String
        Dim oHTMLStream As New IO.MemoryStream
        GridView3.Columns("DueDate").Visible = False
        GridView3.Columns("PlanToPay").Visible = False
        gridPubInvoices2.ExportToHtml(oHTMLStream)
        GridView3.Columns("DueDate").Visible = True
        GridView3.Columns("PlanToPay").Visible = True



        Dim sHTML As String

        oHTMLStream.Seek(0, SeekOrigin.Begin)
        Dim sr As StreamReader = New StreamReader(oHTMLStream)
        sHTML = sr.ReadToEnd()

        Return sHTML

    End Function

End Class