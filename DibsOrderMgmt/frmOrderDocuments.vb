﻿Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports System.IO.FileInfo

Imports Microsoft.VisualBasic.FileIO
Imports DibsOrderMgmt.clsDibsOrderMgmt

Public Class frmOrderDocuments
    Public oOrderID As Guid
    Public PartnerID As Integer
    Public PubInvoiceNumber As String
    Public PubPaymentID As String

    Public DocTypeSpecific As clsDibsOrderMgmt.OrderDocTypes = OrderDocTypes.NoDocumentType



    Public PublisherInvoiceDocsOnly As Boolean = False  'OrderDocTypeId - 50 

    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        '  OmOrderDocumentsTableAdapter1.Fill(DiBS_DB_ProdDataSet11.omOrderDocuments)


    End Sub

    Private Sub cmdAddNewDocument_Click(sender As Object, e As EventArgs) Handles cmdAddNewDocument.Click
        Dim sOrderID As String
        sOrderID = oOrderID.ToString

        Dim oForm As New frmNewDocument

        With oForm
            '.dgv_Grid.DataSource = ds.Tables(0)
            .oOrderID = oOrderID

            Select Case DocTypeSpecific
                Case OrderDocTypes.PubInvoice
                    .PartnerID = PartnerID
                    .PubInvoiceNumber = PubInvoiceNumber
                    .DocTypeSpecific = OrderDocTypes.PubInvoice
                    .PubPaymentID = PubPaymentID



                Case Else

            End Select

            .ShowDialog()

        End With
        LoadDocumentsGrid()
        ' Call InsertDocumentIntoDB(sOrderID, "")
    End Sub

    Private Sub frmOrderDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDocumentsGrid()
    End Sub

    Private Sub LoadDocumentsGrid()

        Dim sSQL As String

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        Select Case DocTypeSpecific
            Case clsDibsOrderMgmt.OrderDocTypes.PubInvoice
                'Only get Pub Invoice type 60 for specific PubPaymentID
                sSQL = "SELECT omOrderDocuments.* ,omOrderDoctypes.OrderDocTypeName FROM dbo.omOrderDocuments INNER JOIN dbo.omOrderDoctypes ON omOrderDocuments.OrderDocTypeID = omOrderDoctypes.OrderDocTypeID where OrderID='" & oOrderID.ToString & "' and omOrderDocuments.OrderDocTypeID=60 and omOrderDocuments.PubPaymentID='" & PubPaymentID & "'"
            Case Else
                sSQL = "SELECT omOrderDocuments.* ,omOrderDoctypes.OrderDocTypeName FROM dbo.omOrderDocuments INNER JOIN dbo.omOrderDoctypes ON omOrderDocuments.OrderDocTypeID = omOrderDoctypes.OrderDocTypeID where OrderID='" & oOrderID.ToString & "'"

        End Select

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        gridDocuments.DataSource = ds.Tables(0)





    End Sub

    Public Sub OpenPDF(sDocumentID As String)
        Dim oFrmPdf As New frmPDFViewer

        Dim sSQL As String = "SELECT * FROM omOrderDocuments where DocumentID='" & sDocumentID & "'"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()
        Dim oBytes As Byte()

        oBytes = ds.Tables(0).Rows(0).Item("OrderDoc")

        With oFrmPdf
            .PDFBytes = oBytes
            .LoadPDF()
            .Show()

        End With

    End Sub

    Public Sub OpenExcel(sDocumentID As String)
        Dim oFrmPdf As New frmPDFViewer

        Dim sSQL As String = "SELECT * FROM omOrderDocuments where DocumentID='" & sDocumentID & "'"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()
        Dim oBytes As Byte()

        oBytes = ds.Tables(0).Rows(0).Item("OrderDoc")

        With frmExcelViewer
            .oDocumentID = Guid.Parse(sDocumentID)
            .ExcelBytes = oBytes
            .LoadExcel()
            .Show()

        End With

    End Sub
    Public Sub OpenWord(sDocumentID As String)
        Dim oFrmWord As New frmRTFViewer

        Dim sSQL As String = "SELECT * FROM omOrderDocuments where DocumentID='" & sDocumentID & "'"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()
        Dim oBytes As Byte()

        oBytes = ds.Tables(0).Rows(0).Item("OrderDoc")

        With oFrmWord
            .oDocumentID = Guid.Parse(sDocumentID)
            .WordBytes = oBytes
            .LoadWord()
            .Show()

        End With

    End Sub
    Private Sub gridDocuments_MouseUp(sender As Object, e As MouseEventArgs) Handles gridDocuments.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub BarButtonItem1_ViewDocument_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_ViewDocument.ItemClick

        OpenDocument()


    End Sub

    Public Sub OpenDocument()

        Try
            Me.Cursor = Cursors.WaitCursor


            Dim oDocumentID As Guid
            Dim sOrderDocName As String
            Dim sFileExt As String

            Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
            Dim selectedRowHandle As Int32
            Dim oRow As DataRow

            If selectedRowHandles.Count <> 1 Then
                MsgBox("Must select 1 Row")
                Exit Sub
            End If
            selectedRowHandle = selectedRowHandles(0)

            oRow = GridView1.GetDataRow(selectedRowHandle)

            'oRow.Item("OrderID").ToString()
            oDocumentID = Guid.Parse(oRow.Item("DocumentID").ToString())
            sOrderDocName = oRow.Item("OrderDocName").ToString()

            If sOrderDocName <> "" Then
                sFileExt = FileIO.FileSystem.GetFileInfo(sOrderDocName).Extension
            End If

            Select Case sFileExt
                Case ".xls", ".xlsx", ".csv"
                    OpenExcel(oDocumentID.ToString)
                Case "", ".pdf"
                    OpenPDF(oDocumentID.ToString)

                Case ".doc", ".docx"
                    OpenWord(oDocumentID.ToString)
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        OpenDocument()
    End Sub

    Private Sub gridDocuments_Click(sender As Object, e As EventArgs) Handles gridDocuments.Click

    End Sub

    Private Sub BarButtonItem1_SendDocumentToEmail_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_SendDocumentToEmail.ItemClick
        Dim oUpdateOrderItemID As Guid
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow
        Dim iSelectedDocCnt As Integer
        Dim sMSG As String
        Dim iMsgRtrn As DialogResult
        Dim sTempFile As String
        Dim oDocBytes As Byte()
        Dim sDocName As String
        Dim sEXT As String
        Dim oAttachment As MailItemAttachement

        selectedRowHandle = selectedRowHandles(0)


        'miCurrentQTY = oRow.Item("QTY").ToString
        'moCurrentListPrice = oRow.Item("ListPrice").ToString
        'moCurrentExtendedPrice = oRow.Item("ExtendedPrice").ToString

        If selectedRowHandles.Count = 0 Then
            MsgBox("Must select 1 Row")
            Exit Sub
        End If



        iSelectedDocCnt = selectedRowHandles.Count


        sMSG = "You are about to put: " & iSelectedDocCnt & " 'Order Document(s)' into a email. Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMSG, "Update QTY & List Price of Order Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If

        Dim oMailItem As New BHMailItem
        Dim oAttachments As New List(Of MailItemAttachement)
        oMailItem.Attachments = oAttachments

        For Each x In GridView1.GetSelectedRows

            selectedRowHandle = x
            oRow = GridView1.GetDataRow(selectedRowHandle)

            oDocBytes = oRow.Item("OrderDoc")
            sDocName = oRow.Item("OrderDocName")


            sTempFile = System.IO.Path.GetTempFileName()
            'sTempFile = sTempFile.Replace(".tmp", ".xlsx")
            sEXT = FileIO.FileSystem.GetFileInfo(sDocName).Extension
            sTempFile = sTempFile.Replace(".tmp", sEXT)
            System.IO.File.WriteAllBytes(sTempFile, oDocBytes)

            oAttachment = New MailItemAttachement
            oAttachment.FileName = sDocName
            oAttachment.FilePath = sTempFile

            oMailItem.Attachments.Add(oAttachment)
        Next x

        CreateBHMailItem(oMailItem)
    End Sub

    Private Sub BarButtonItem1_EditDocumentInfo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_EditDocumentInfo.ItemClick
        LoadOrderDocumentDetail()
    End Sub

    Public Sub LoadOrderDocumentDetail()
        Dim oDocumentID As Guid
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow

        Try
            Me.Cursor = Cursors.WaitCursor

            If selectedRowHandles.Count <> 1 Then
                MsgBox("Must select 1 Row")
                Exit Sub
            End If
            selectedRowHandle = selectedRowHandles(0)

            oRow = GridView1.GetDataRow(selectedRowHandle)

            'oRow.Item("OrderID").ToString()
            oDocumentID = Guid.Parse(oRow.Item("DocumentID").ToString())


            Dim oForm As New frmNewDocument

            With oForm
                '.dgv_Grid.DataSource = ds.Tables(0)
                .oOrderID = oOrderID
                .oDocumentID = oDocumentID
                .bExistingDocument = True
                .bReplaceDocument = False

                Me.Cursor = Cursors.Default
                .Show()

            End With
            'Refresh the grid (Could speed up by not refreshing a cancel)
            LoadDocumentsGrid()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem1_DeleteDocument_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_DeleteDocument.ItemClick
        Dim oDocumentID As Guid
        Dim sDocumentName As String

        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow
        Dim sMSG As String
        Dim iMSGRtrn As DialogResult

        Try
            Me.Cursor = Cursors.WaitCursor

            If selectedRowHandles.Count <> 1 Then
                MsgBox("Must select 1 Row")
                Exit Sub
            End If
            selectedRowHandle = selectedRowHandles(0)

            oRow = GridView1.GetDataRow(selectedRowHandle)

            'oRow.Item("OrderID").ToString()
            oDocumentID = Guid.Parse(oRow.Item("DocumentID").ToString())
            sDocumentName = oRow.Item("OrderDocName").ToString()

            sMSG = "You are about to Permanetly delete the document: '" & sDocumentName & " Are you sure you want to continue?"
            iMSGRtrn = MessageBox.Show(sMSG, "Delete Document?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If iMSGRtrn = DialogResult.Cancel Then
                Exit Sub

            End If

            'Delete the document
            DeleteOrderDocument(oDocumentID.ToString)
            'Refresh the grid (Could speed up by not refreshing a cancel)
            LoadDocumentsGrid()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class