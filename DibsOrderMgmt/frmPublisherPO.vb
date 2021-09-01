﻿
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet

Public Class frmPublisherPO

    Public sFilePath As String
    Public ExcelBytes As Byte()
    Public oOrderID As Guid
    Public iPartnerID As Integer
    Private oPartnerDataTable As DataTable
    Private oOrderItemsDataTable As DataTable
    Public oOrderSetsDataTable As DataTable
    Public oOrderInfoDataTable As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Structure POPubFixedCells
        Const PODate As String = "B3"
        Const POBHNumber As String = "A6"
        Const POCustomerNumber As String = "F12"

        Const Publisher_Line1 As String = "A7"
        Const Publisher_Line2 As String = "A8"
        Const Publisher_Line3 As String = "A9"
        Const Publisher_Line4 As String = "A11"
        Const Publisher_Line5 As String = "A12"

        Const ShipTo_Line1 As String = "F7"
        Const ShipTo_Line2 As String = "F8"
        Const ShipTo_Line3 As String = "F9"
        Const ShipTo_Line4 As String = "F11"

        Const OrderItemsStartRow As Integer = 18
        Const OrderItemCol_ItemNumber As String = "A"
        Const OrderItemCol_ItemDesc As String = "B"
        Const OrderItemCol_ItemQTY As String = "C"
        Const OrderItemCol_ItemListPrice As String = "E"
        Const OrderItemCol_ItemDiscount As String = "F"
        Const OrderItemCol_ItemUnitCost As String = "G"
        Const OrderItemCol_ItemTotalCost As String = "H"

    End Structure
    Public Structure CustomerInvoiceFixedCells
        Const BHInvoiceDate As String = "D9"
        Const POBHNumber As String = "E8"
        Const POCustomerNumber As String = "B9"

        Const BillTo_Line1 As String = "A12"
        Const BillTo_Line2 As String = "A13"
        Const BillTo_Line3 As String = "A14"
        Const BillTo_Line4 As String = "A15"
        Const BillTo_Line5 As String = "A16"

        Const ShipTo_Line1 As String = "C12"
        Const ShipTo_Line2 As String = "C13"
        Const ShipTo_Line3 As String = "C14"
        Const ShipTo_Line4 As String = "C15"
        Const ShipTo_Line5 As String = "C16"

        Const InvoiceItemsStartRow As Integer = 19
        Const InvoiceItemCol_ItemNumber As String = "A"
        Const InvoiceItemCol_ItemDesc As String = "B"
        Const InvoiceItemCol_ItemQTY As String = "E"
        Const InvoiceItemCol_ItemListPrice As String = "C"
        Const InvoiceItemCol_ItemExtendedCost As String = "F"

    End Structure
    Public Sub LoadExcel()
        Dim stream As Stream = New MemoryStream(ExcelBytes)

        SpreadsheetControl1.LoadDocument(stream)
    End Sub


    Private Sub CustomSaveBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        ''This is the Save Button
        ''spreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.OpenXml)
        'Dim oOrderDocument As New OrderDocument
        'Dim sReturn As String
        'oOrderDocument.DocumentID = oDocumentID
        'oOrderDocument.OrderDoc = SpreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.Xlsx)


        'SaveOrderDocument(oOrderDocument)
        'SpreadsheetControl1.Options.Save.Reset()
        'e.Item.Reset()
    End Sub

    Private Sub SpreadsheetControl1_DocumentSaved(sender As Object, e As EventArgs)
        'CustomSaveBarButtonItem1.Enabled = False

    End Sub

    Private Sub SpreadsheetControl1_BeforeExport(sender As Object, e As SpreadsheetBeforeExportEventArgs)

    End Sub

    Private Sub SpreadsheetControl1_ActiveSheetChanged(sender As Object, e As ActiveSheetChangedEventArgs)

    End Sub

    Private Sub SpreadsheetControl1_CellValueChanged(sender As Object, e As SpreadsheetCellEventArgs)
        ' CustomSaveBarButtonItem1.Enabled = True
    End Sub
    Public Function AddOrderItems()

        Dim oOrderItemRow As DataRow
        Dim iStartRow As Integer
        Dim iRowCount As Integer

        Dim sItemCell As String
        Dim sItemDescCell As String
        Dim sItemQTYCell As String
        Dim sItemListPriceCell As String
        Dim sItemDiscountCell As String
        Dim sItemUnitCostCell As String
        Dim sItemTotalCostCell As String
        Dim sSubTotalCell As String
        Dim sSubTotalStartCell As String
        Dim sSubTotalEndCell As String
        Dim iOrderItemsCount As Integer
        Dim oPartnerDiscount As Decimal

        Dim oWorkSheet As Spreadsheet.Worksheet
        LoadOrderItemsInfo()

        oWorkSheet = SpreadsheetControl1.ActiveWorksheet

        iStartRow = POPubFixedCells.OrderItemsStartRow
        iRowCount = 0


        iOrderItemsCount = oOrderItemsDataTable.Rows.Count
        If iOrderItemsCount = 0 Then
            'If no order items then we can bail
            Exit Function
        End If



        oPartnerDiscount = oPartnerDataTable.Rows(0).Item("PrintDiscount")

        oWorkSheet.Cells.BeginUpdate()
        For Each oOrderItemRow In oOrderItemsDataTable.Rows


            'Set the cell locations for the order items
            sItemCell = POPubFixedCells.OrderItemCol_ItemNumber & (iStartRow + iRowCount)
            sItemDescCell = POPubFixedCells.OrderItemCol_ItemDesc & (iStartRow + iRowCount)
            sItemQTYCell = POPubFixedCells.OrderItemCol_ItemQTY & (iStartRow + iRowCount)
            sItemListPriceCell = POPubFixedCells.OrderItemCol_ItemListPrice & (iStartRow + iRowCount)
            sItemDiscountCell = POPubFixedCells.OrderItemCol_ItemDiscount & (iStartRow + iRowCount)
            sItemUnitCostCell = POPubFixedCells.OrderItemCol_ItemUnitCost & (iStartRow + iRowCount)
            sItemTotalCostCell = POPubFixedCells.OrderItemCol_ItemTotalCost & (iStartRow + iRowCount)

            'Now set the Values is those cells
            oWorkSheet.Range(sItemCell).Value = oOrderItemRow.Item("ItemNumber").ToString
            oWorkSheet.Range(sItemDescCell).Value = oOrderItemRow.Item("ItemDesc").ToString
            oWorkSheet.Range(sItemQTYCell).Value = oOrderItemRow.Item("QTY").ToString
            oWorkSheet.Range(sItemListPriceCell).Value = oOrderItemRow.Item("ListPrice").ToString

            'Need to get Discount from Partners table
            oWorkSheet.Range(sItemDiscountCell).Value = oPartnerDiscount


            'Need to add the formulas
            oWorkSheet.Range(sItemUnitCostCell).Formula = "=" & sItemListPriceCell & "*" & sItemDiscountCell
            oWorkSheet.Range(sItemTotalCostCell).Formula = "=" & sItemUnitCostCell & "*" & sItemQTYCell

            'Need to Fix Sub Total formula
            sSubTotalCell = POPubFixedCells.OrderItemCol_ItemTotalCost & (iStartRow + iRowCount + 3)
            sSubTotalStartCell = POPubFixedCells.OrderItemCol_ItemTotalCost & (iStartRow)
            sSubTotalEndCell = POPubFixedCells.OrderItemCol_ItemTotalCost & (iStartRow + iRowCount)


            'Need to Format the row



            iRowCount = iRowCount + 1

            'Go ahead and insert a new row for the next items or provide spacing
            oWorkSheet.Range(POPubFixedCells.OrderItemCol_ItemNumber & (iStartRow + iRowCount)).Insert(InsertCellsMode.EntireRow)
            oWorkSheet.Rows(iStartRow + iRowCount - 1).CopyFrom(oWorkSheet.Rows(iStartRow + iRowCount), PasteSpecial.Formats)
            oWorkSheet.Rows(iStartRow + iRowCount - 1).CopyFrom(oWorkSheet.Rows(iStartRow + iRowCount), PasteSpecial.NumberFormats)
            ' oWorkSheet.Rows(iStartRow + iRowCount - 1).CopyFrom(oWorkSheet.Rows(iStartRow + iRowCount), PasteSpecial.Formulas)
        Next
        oWorkSheet.Range(sSubTotalCell).Formula = "=Sum(" & sSubTotalStartCell & ":" & sSubTotalEndCell & ")"
endUpdate:
        oWorkSheet.Cells.EndUpdate()
    End Function
    Public Function AddOrderSets()

        Dim oOrderSetItemRow As DataRow
        Dim iStartRow As Integer
        Dim iRowCount As Integer

        Dim sItemCell As String
        Dim sItemDescCell As String
        Dim sItemQTYCell As String
        Dim sItemListPriceCell As String
        '  Dim sItemDiscountCell As String
        ' Dim sItemUnitCostCell As String
        Dim sItemTotalCostCell As String
        Dim sSubTotalCell As String
        Dim sSubTotalStartCell As String
        Dim sSubTotalEndCell As String
        Dim sDiscountTotalCell As String
        Dim sShippingTotalCell As String
        Dim sTaxTotalCell As String
        Dim sGrandTotalCell As String

        Dim sDiscount As String
        Dim sShipping As String
        Dim sTax As String


        Dim iOrderItemsCount As Integer
        '   Dim oPartnerDiscount As Decimal

        Dim oWorkSheet As Spreadsheet.Worksheet

        ' LoadOrderItemsInfo()
        With oOrderInfoDataTable.Rows(0)
            sDiscount = .Item("PO_DiscountAmount").ToString
            sShipping = .Item("PO_Shipping").ToString
            If sDiscount = "" Then sDiscount = 0
            If sShipping = "" Then sShipping = 0

        End With
        oWorkSheet = SpreadsheetControl1.ActiveWorksheet

        iStartRow = CustomerInvoiceFixedCells.InvoiceItemsStartRow
        iRowCount = 0


        iOrderItemsCount = oOrderSetsDataTable.Rows.Count
        If iOrderItemsCount = 0 Then
            'If no order items then we can bail
            Exit Function
        End If



        '  oPartnerDiscount = oPartnerDataTable.Rows(0).Item("PrintDiscount")

        oWorkSheet.Cells.BeginUpdate()
        'oOrderSetsDataTable is set from somewhere else

        For Each oOrderSetItemRow In oOrderSetsDataTable.Rows


            'Set the cell locations for the order items
            sItemCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemNumber & (iStartRow + iRowCount)
            sItemDescCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemDesc & (iStartRow + iRowCount)
            sItemQTYCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemQTY & (iStartRow + iRowCount)
            sItemListPriceCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemListPrice & (iStartRow + iRowCount)
            sItemTotalCostCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount)

            'Now set the Values is those cells
            oWorkSheet.Range(sItemCell).Value = oOrderSetItemRow.Item("SetName").ToString
            oWorkSheet.Range(sItemDescCell).Value = oOrderSetItemRow.Item("SetDesc").ToString
            oWorkSheet.Range(sItemQTYCell).Value = oOrderSetItemRow.Item("QTY").ToString
            oWorkSheet.Range(sItemListPriceCell).Value = oOrderSetItemRow.Item("ListPrice").ToString


            'Need to add the formulas

            oWorkSheet.Range(sItemTotalCostCell).Formula = "=" & sItemListPriceCell & "*" & sItemQTYCell

            'Need to Fix Sub Total formula
            sSubTotalCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount + 3)
            sDiscountTotalCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount + 4)
            sShippingTotalCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount + 5)
            sTaxTotalCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount + 6)
            sGrandTotalCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount + 7)

            sSubTotalStartCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow)
            sSubTotalEndCell = CustomerInvoiceFixedCells.InvoiceItemCol_ItemExtendedCost & (iStartRow + iRowCount)


            'Need to Format the row



            iRowCount = iRowCount + 1

            'Go ahead and insert a new row for the next items or provide spacing
            oWorkSheet.Range(CustomerInvoiceFixedCells.InvoiceItemCol_ItemNumber & (iStartRow + iRowCount)).Insert(InsertCellsMode.EntireRow)
            oWorkSheet.Rows(iStartRow + iRowCount - 1).CopyFrom(oWorkSheet.Rows(iStartRow + iRowCount), PasteSpecial.Formats)
            oWorkSheet.Rows(iStartRow + iRowCount - 1).CopyFrom(oWorkSheet.Rows(iStartRow + iRowCount), PasteSpecial.NumberFormats)
            ' oWorkSheet.Rows(iStartRow + iRowCount - 1).CopyFrom(oWorkSheet.Rows(iStartRow + iRowCount), PasteSpecial.Formulas)
        Next


        oWorkSheet.Range(sSubTotalCell).Formula = "=Sum(" & sSubTotalStartCell & ":" & sSubTotalEndCell & ")"

        oWorkSheet.Range(sDiscountTotalCell).Value = sDiscount * -1

        oWorkSheet.Range(sShippingTotalCell).Value = sShipping
        oWorkSheet.Range(sTaxTotalCell).Value = 0.00

        'Sum up sub
        oWorkSheet.Range(sGrandTotalCell).Formula = "=Sum(" & sSubTotalCell & ":" & sTaxTotalCell & ")"


endUpdate:
        oWorkSheet.Cells.EndUpdate()
    End Function
    Public Function SetPublisherPO_FixedCells()
        Dim oPartnerRow As DataRow


        'Gets partner Infor From DB
        LoadPartnerInfo()

        oPartnerRow = oPartnerDataTable.Rows(0)

        Dim oWorkSheet As Spreadsheet.Worksheet


        oWorkSheet = SpreadsheetControl1.ActiveWorksheet
        oWorkSheet.Cells.BeginUpdate()

        oWorkSheet.Range(POPubFixedCells.PODate).Value = Today.ToShortDateString
        'Need to add PO numbers from 
        ' oWorkSheet.Range(POPubFixedCells.POBHNumber).Value = oPartnerRow.Item("BHPONumber").ToString
        '  oWorkSheet.Range(POPubFixedCells.POCustomerNumber).Value = oPartnerRow.Item("PurchasingPONumber").ToString

        oWorkSheet.Range(POPubFixedCells.Publisher_Line1).Value = oPartnerRow.Item("Partner_Line1").ToString
        oWorkSheet.Range(POPubFixedCells.Publisher_Line2).Value = oPartnerRow.Item("Partner_Line2").ToString
        oWorkSheet.Range(POPubFixedCells.Publisher_Line3).Value = oPartnerRow.Item("Partner_Line3").ToString
        oWorkSheet.Range(POPubFixedCells.Publisher_Line4).Value = oPartnerRow.Item("Partner_Line4").ToString
        oWorkSheet.Range(POPubFixedCells.Publisher_Line5).Value = oPartnerRow.Item("Partner_Line5").ToString

        oWorkSheet.Range(POPubFixedCells.ShipTo_Line1).Value = oPartnerRow.Item("ShipTo_Line1").ToString
        oWorkSheet.Range(POPubFixedCells.ShipTo_Line2).Value = oPartnerRow.Item("ShipTo_Line2").ToString
        oWorkSheet.Range(POPubFixedCells.ShipTo_Line3).Value = oPartnerRow.Item("ShipTo_Line3").ToString
        oWorkSheet.Range(POPubFixedCells.ShipTo_Line4).Value = oPartnerRow.Item("ShipTo_Line4").ToString



        oWorkSheet.Cells.EndUpdate()



    End Function
    Public Function SetCustomerInvoice_FixedCells()
        Dim oOrderRow As DataRow


        Dim oWorkSheet As Spreadsheet.Worksheet


        oWorkSheet = SpreadsheetControl1.ActiveWorksheet
        oWorkSheet.Cells.BeginUpdate()
        Dim sBillToCityStateZip As String
        Dim sShipToCityStateZip As String

        oWorkSheet.Range(CustomerInvoiceFixedCells.BHInvoiceDate).Value = Today.ToShortDateString
        'Need to add PO numbers from 

        'Need to add PO numbers from 
        With oOrderInfoDataTable.Rows(0)
            oWorkSheet.Range(CustomerInvoiceFixedCells.POBHNumber).Value = .Item("BHPONumber").ToString
            oWorkSheet.Range(CustomerInvoiceFixedCells.POCustomerNumber).Value = .Item("PurchasingPONumber").ToString

            oWorkSheet.Range(CustomerInvoiceFixedCells.BillTo_Line1).Value = .Item("BillTo_Name").ToString
            oWorkSheet.Range(CustomerInvoiceFixedCells.BillTo_Line2).Value = .Item("BillTo_Street").ToString

            sBillToCityStateZip = .Item("BillTo_City").ToString & ", " & .Item("BillTo_State").ToString & " " & .Item("BillTo_Zip").ToString

            oWorkSheet.Range(CustomerInvoiceFixedCells.BillTo_Line3).Value = sBillToCityStateZip
            oWorkSheet.Range(CustomerInvoiceFixedCells.BillTo_Line4).Value = .Item("PurchasingContactPhone").ToString
            ' oWorkSheet.Range(CustomerInvoiceFixedCells.BillTo_Line5).Value = .Item("Partner_Line5").ToString

            oWorkSheet.Range(CustomerInvoiceFixedCells.ShipTo_Line1).Value = .Item("ShipTo_Name").ToString
            oWorkSheet.Range(CustomerInvoiceFixedCells.ShipTo_Line2).Value = .Item("ShipTo_Street").ToString
            sShipToCityStateZip = .Item("ShipTo_City").ToString & ", " & .Item("ShipTo_State").ToString & " " & .Item("ShipTo_Zip").ToString

            oWorkSheet.Range(CustomerInvoiceFixedCells.ShipTo_Line3).Value = sShipToCityStateZip
            ' oWorkSheet.Range(CustomerInvoiceFixedCells.ShipTo_Line4).Value = .Item("ShipTo_Line4").ToString
            'oWorkSheet.Range(CustomerInvoiceFixedCells.ShipTo_Line5).Value = .Item("ShipTo_Line5").ToString
        End With

        oWorkSheet.Cells.EndUpdate()



    End Function

    Private Sub LoadPartnerInfo()

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

        oPartnerDataTable = ds.Tables(0)


    End Sub
    Private Sub LoadOrderInfo(sOrderID As String)

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString



        sSQL = "SELECT * FROM omqryOrdersMain WHERE OrderID={OrderID}"
        sSQL = sSQL.Replace("{OrderID}", sOrderID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        oPartnerDataTable = ds.Tables(0)


    End Sub
    Private Sub LoadOrderItemsInfo()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString


        'Sort by asc, so they are inserted Desc
        sSQL = "SELECT * FROM omqryOrderItems WHERE orderid='{OrderID}' AND PartnerID={PartnerID}  ORDER BY ItemDesc ASC"

        sSQL = sSQL.Replace("{OrderID}", oOrderID.ToString)
        sSQL = sSQL.Replace("{PartnerID}", iPartnerID)

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        oOrderItemsDataTable = ds.Tables(0)


    End Sub

    Private Sub SpreadsheetCommandBarButtonItem22_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub SpreadsheetCommandBarButtonItem3_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles SpreadsheetCommandBarButtonItem3.ItemClick

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        'THis saving the Partner PO Document
        Dim oOrderDoc As New OrderDocument
        Dim sReturn As String
        Dim sPartner As String
        Dim iPartnerID As Integer
        Dim sOrderDocName As String
        Dim sBHPO As String
        Dim iMsgRtrn As DialogResult
        Dim sMSG As String

        sPartner = oPartnerDataTable.Rows(0).Item("PublisherShortName")
        iPartnerID = oPartnerDataTable.Rows(0).Item("PartnerID")
        sPartner = oPartnerDataTable.Rows(0).Item("PublisherShortName")
        iPartnerID = oPartnerDataTable.Rows(0).Item("PartnerID")

        sBHPO = oOrderInfoDataTable.Rows(0).Item("BHPONumber").ToString
        'Need to add the extension or you can not open it on the other end
        sOrderDocName = sBHPO & "_" & sPartner & "_PO_Final.xlsx"

        sMSG = "You are about 'Save/Replace' the Publisher PO: '" & sOrderDocName & "' in the Order Documents. Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMSG, "Save/Replace PO in Order Documents", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If

        With oOrderDoc
            '.OrderDocFilePath = DocFullFilePath
            .OrderID = oOrderID
            .OrderDocName = sOrderDocName
            .OrderDocTypeID = OrderDocTypes.PubPO
            .OrderDocNotes = "PO Generated by 'The Hive' for Publisher"
            .PartnerID = iPartnerID
            'Not really Drag & Drop...but more in memory
            .bFromDragDrop = True

            ''This is the Save Button
            ''spreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.OpenXml)

            .OrderDoc = SpreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.Xlsx)

        End With


        sReturn = InsertDocumentIntoDB(oOrderDoc)

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim moBHMailItem As New BHMailItem
        Dim sTempFile As String
        Dim oAttachments As New List(Of MailItemAttachement)
        Dim oAttachment As New MailItemAttachement
        Dim sBHPO As String


        sTempFile = System.IO.Path.GetTempFileName()
        sTempFile = sTempFile.Replace(".tmp", ".xlsx")

        Dim sReturn As String
        Dim sPartner As String
        Dim iPartnerID As Integer
        Dim sOrderDocName As String

        sPartner = oPartnerDataTable.Rows(0).Item("PublisherShortName")
        iPartnerID = oPartnerDataTable.Rows(0).Item("PartnerID")

        sBHPO = oOrderInfoDataTable.Rows(0).Item("BHPONumber").ToString
        'Need to add the extension or you can not open it on the other end
        sOrderDocName = sBHPO & "_" & sPartner & "_PO_Final.xlsx"

        oAttachment.FilePath = sTempFile
        oAttachment.FileName = sOrderDocName

        oAttachments.Add(oAttachment)

        With moBHMailItem
            .ToEmail = "rharlow@myedupartners.com"
            .Subject = "PO: " & sBHPO & "_" & sPartner
            .Body = "Please process the attached PO: " & sBHPO & "<br>" & "<br>" & "Please let me know if you have any questions." & vbCrLf & vbCrLf

            SpreadsheetControl1.SaveDocument(sTempFile, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
            .Attachments = oAttachments
            'SpreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.Xlsx).ToString


        End With

        CreateBHMailItem(moBHMailItem)
    End Sub

    Private Sub frmPublisherPO_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Text = Me.Text & oOrderInfoDataTable.Rows(0).Item("BHPONumber").ToString

    End Sub
End Class