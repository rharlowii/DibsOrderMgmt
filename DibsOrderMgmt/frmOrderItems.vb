﻿Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmOrderItems
    Public oOrderID As Guid
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        '  OmqryOrderItemsTableAdapter1.Fill(DiBS_DB_ProdDataSet41.omqryOrderItems)
    End Sub

    Private Sub frmOrderItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrdersItemsGrid()
    End Sub

    Private Sub LoadOrdersItemsGrid()

        Dim sSQL As String = "SELECT * FROM omqryOrderItems where OrderID='" & oOrderID.ToString & "'"
        Dim sSQLDetail As String = "SELECT OrderItemID,ItemNumber,ItemDesc,QTY,ListPrice,ExtendedPrice FROM omOrderItemSubs where OrderID='" & oOrderID.ToString & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer


        Dim daDetail As SqlDataAdapter

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "omOrderItems")


        'Lets Try and do the detail - Begin
        daDetail = New SqlDataAdapter(sSQLDetail, oConnection)


        daDetail.Fill(ds, "omOrderItemSubs")


        'Set up a master-detail relationship between the DataTables
        Dim keyColumn As DataColumn = ds.Tables("omOrderItems").Columns("OrderItemID")
        Dim foreignKeyColumn As DataColumn = ds.Tables("omOrderItemSubs").Columns("OrderItemID")
        ds.Relations.Add("omOrderItemsomOrderItemSubs", keyColumn, foreignKeyColumn)



        'Lets Try and do the detail - Endi

        gridOrderItems.DataSource = ds.Tables("omOrderItems")
        gridOrderItems.ForceInitialize()
        oConnection.Close()

        'Assign a CardView to the relationship
        ' Dim cardView1 As New CardView(gridOrderItems)
        Dim cardView1 As New CardView()

        ' cardView1 = gridOrderItems.Views(1)

        'OrderItemID
        'Hide the CategoryID column for the master View
        With cardView1
            .PopulateColumns(ds.Tables("omOrderItemSubs"))
            .Columns("OrderItemID").Visible = False
            ' .Editable = False
            .Appearance.Card.Options.UseFont = True

            .OptionsView.ShowCardCaption = False
            .OptionsView.ShowCardExpandButton = False
            .OptionsView.ShowQuickCustomizeButton = False
            .OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never

            ' .Appearance.Card.Font = New Font("Arial", 12, FontStyle.Bold)
            .Appearance.FieldCaption.Font = New Font("Arial", 12, FontStyle.Bold)
            .Appearance.FieldValue.Font = New Font("Arial", 12, FontStyle.Bold)

            .CardWidth = 600
            .ViewCaption = "Substituted for:"
            .Appearance.Card.Options.UseBackColor = True
            .Appearance.Card.Options.UseBorderColor = True

            .Appearance.EmptySpace.Options.UseBackColor = True
            .Appearance.Card.BackColor = Color.Beige
            .Appearance.Card.BorderColor = Color.Beige
            .Appearance.EmptySpace.BackColor = Color.Beige
            .PaintStyleName = "Flat"

        End With
        gridOrderItems.LevelTree.Nodes.Add("omOrderItemsomOrderItemSubs", cardView1)

    End Sub

    Private Sub cmdAddOrderItems_Click(sender As Object, e As EventArgs) Handles cmdAddOrderItems.Click
        LoadAddOrderItemsForm()
    End Sub

    Public Sub LoadAddOrderItemsForm()
        Dim oAddItems As New frmOrderItemsAdd

        With oAddItems
            .oOrderID = oOrderID

            .ShowDialog()

        End With

        LoadOrdersItemsGrid()
    End Sub

    Public Function DeleteOrderItem(oOrderItemID As String) As String
        Dim sEXEC As String = "DELETE FROM dbo.omOrderItems where OrderItemID=@OrderItemID"

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderItemID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItemID.ToString)


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function

    Public Function UpdateOrderQTYOrPrice(oOrderItemID As String, iQTY As Integer, oListPrice As Decimal, oExtendedPrice As Decimal)

        Dim sEXEC As String = "UPDATE dbo.omOrderItems SET QTY = @QTY,ListPrice = @ListPrice,ExtendedPrice = @ExtendedPrice WHERE OrderItemID = @OrderItemID"

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderItemID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(oOrderItemID.ToString)

            .Parameters.Add("@QTY", SqlDbType.Int).Value = iQTY

            .Parameters.Add("@ListPrice", SqlDbType.Decimal).Value = oListPrice
            .Parameters.Add("@ExtendedPrice", SqlDbType.Decimal).Value = oExtendedPrice

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function



    Private Sub BarButtonItem_AddOrderItems_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem_AddOrderItems.ItemClick
        LoadAddOrderItemsForm()
    End Sub

    Private Sub BarButtonItem1_DeleteOrderItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_DeleteOrderItem.ItemClick

        Dim iMsgRtrn As DialogResult
        Dim sMSG As String
        Dim iDeleteCount As Integer

        Dim oDeleteOrderItemID As Guid
        Dim selectedRowHandles As Int32() = Gridview1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow


        If selectedRowHandles.Count = 0 Then
            MsgBox("Must select 1 Row")
            Exit Sub
        End If

        iDeleteCount = selectedRowHandles.Count


        sMSG = "You are about to Delete: " & iDeleteCount & " 'Order Items'! Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMSG, "Delete Order Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If

        For x = 0 To iDeleteCount - 1

            selectedRowHandle = selectedRowHandles(x)

            oRow = Gridview1.GetDataRow(selectedRowHandle)
            oDeleteOrderItemID = Guid.Parse(oRow.Item("OrderItemID").ToString())
            DeleteOrderItem(oDeleteOrderItemID.ToString)
        Next


        LoadOrdersItemsGrid()
    End Sub

    Private Sub GridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles Gridview1.MouseUp

        If e.Button = MouseButtons.Right Then
            PopupMenu_OrderItems.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub BarButtonItem1_UpdateQTYOrderItems_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_UpdateQTYOrderItems.ItemClick
        Dim ofrmQTYPriceUpdate As New frmQTYPriceUpdate
        Dim miCurrentQTY As Integer
        Dim moCurrentListPrice As Decimal
        Dim moCurrentExtendedPrice As Decimal

        Dim iMsgRtrn As DialogResult

        Dim iUpdateCount As Integer
        Dim sMSG As String

        Dim oUpdateOrderItemID As Guid
        Dim selectedRowHandles As Int32() = Gridview1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow

        selectedRowHandle = selectedRowHandles(0)
        oRow = Gridview1.GetDataRow(selectedRowHandle)

        miCurrentQTY = oRow.Item("QTY").ToString
        moCurrentListPrice = oRow.Item("ListPrice").ToString
        moCurrentExtendedPrice = oRow.Item("ExtendedPrice").ToString

        With frmQTYPriceUpdate
            .iCurrentQTY = miCurrentQTY
            .oCurrentListPrice = moCurrentListPrice
            .oCurrentExtendedPrice = moCurrentExtendedPrice

            .ShowDialog()

            If .bCanceled = True Then Exit Sub

            miCurrentQTY = .iCurrentQTY
            moCurrentListPrice = .oCurrentListPrice
            moCurrentExtendedPrice = .oCurrentExtendedPrice
        End With

        If selectedRowHandles.Count = 0 Then
            MsgBox("Must select 1 Row")
            Exit Sub
        End If



        iUpdateCount = selectedRowHandles.Count


        sMSG = "You are about to Update the QTY and List Price of: " & iUpdateCount & " 'Order Items'! Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMSG, "Update QTY & List Price of Order Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If

        For x = 0 To iUpdateCount - 1

            selectedRowHandle = selectedRowHandles(x)

            oRow = Gridview1.GetDataRow(selectedRowHandle)
            oUpdateOrderItemID = Guid.Parse(oRow.Item("OrderItemID").ToString())
            UpdateOrderQTYOrPrice(oUpdateOrderItemID.ToString, miCurrentQTY, moCurrentListPrice, moCurrentExtendedPrice)

            ' DeleteOrderItem(oDeleteOrderItemID.ToString)
        Next


        LoadOrdersItemsGrid()




    End Sub

    Private Sub BarButtonItem1_SubOrderItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_SubOrderItem.ItemClick
        Dim ofrmOrderItemSub As New frmOrderItemSub
        Dim oOrderItem As New OrderItem
        Dim oNewOrderItem As New OrderItem


        Dim iMsgRtrn As DialogResult

        Dim iUpdateCount As Integer
        Dim sMSG As String

        Dim oCurrentOrderItemID As Guid
        Dim oSubOrderItemID As Guid

        Dim selectedRowHandles As Int32() = Gridview1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow

        selectedRowHandle = selectedRowHandles(0)
        oRow = Gridview1.GetDataRow(selectedRowHandle)

        oCurrentOrderItemID = Guid.Parse(oRow.Item("OrderItemID").ToString())
        oSubOrderItemID = Guid.NewGuid

        With oOrderItem

            .OrderItemID = oCurrentOrderItemID.ToString
            .OrderID = oOrderID.ToString
            .OrderSetID = oRow.Item("OrderSetID").ToString
            .PartnerID = oRow.Item("PartnerID").ToString
            .MetaDataID = oRow.Item("MetaDataID").ToString

            .ItemNumberISBN = oRow.Item("ItemNumber").ToString
            .ItemDesc = oRow.Item("ItemDesc").ToString

            .QTY = oRow.Item("QTY").ToString
            .ListPrice = oRow.Item("ListPrice").ToString
            .ExtendedPrice = oRow.Item("ExtendedPrice").ToString

            .SubOrderItemID = oSubOrderItemID.ToString


        End With


        With ofrmOrderItemSub
            .oCurrentOrderItem = oOrderItem

            .ShowDialog()

            If .bCanceled = True Then Exit Sub
            oNewOrderItem = .oNewOrderItem


        End With

        If selectedRowHandles.Count = 0 Then
            MsgBox("Must select 1 Row")
            Exit Sub
        End If
        'ok...take the orginal order item and put it in the omOrderItemSubs table
        iUpdateCount = omOrderItems_IU_ALT(oOrderItem, oOrderID, True)
        'if success, then we can update the current order item to the new elements, and add add the Sub Order Ite
        If iUpdateCount = 1 Then
            UpdateSubOrderItem(oNewOrderItem)

        End If



        LoadOrdersItemsGrid()
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim view As GridView = TryCast(sender, GridView)
        ' Dim _mark As Boolean = CBool(view.GetRowCellValue(e.RowHandle, "Mark"))
        Dim oColor As Color
        Dim sColorName As String
        'SubOrderItemID
        Dim sGuid As String
        If e.Column.FieldName = "ItemNumber" Or e.Column.FieldName = "ItemDesc" Then
            If Not IsNothing(view.GetRowCellValue(e.RowHandle, "SubOrderItemID")) Then
                sGuid = view.GetRowCellValue(e.RowHandle, "SubOrderItemID").ToString
                If sGuid.Length = 0 Then Exit Sub
                'sColorName = view.GetRowCellValue(e.RowHandle, "OrderStatusColor").ToString
                sColorName = "Red" 'FEF8DD


                If IsNothing(sColorName) Or sColorName = "" Then Exit Sub
                ' oColor = Color.FromName(sColorName)
                oColor = Color.Beige
                e.Appearance.BackColor = oColor

            End If


            'e.Appearance.BackColor = If(_mark, Color.LightGreen, Color.LightSalmon)
            'e.Appearance.TextOptions.HAlignment = If(_mark, HorzAlignment.Far, HorzAlignment.Near)
        End If
        'If e.Column.FieldName = "Length" Then
        '    Dim _length As Double = CDbl(e.CellValue)
        '    If _length > 25 Then
        '        e.Appearance.ForeColor = Color.Red
        '    End If
        'End If
    End Sub
End Class