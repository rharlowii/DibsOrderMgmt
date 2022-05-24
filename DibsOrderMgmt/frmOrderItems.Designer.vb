<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gridOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderSetID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoxNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartnerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPublisherShortName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMetaDataID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colListPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtendedPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubOrderItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2_TotalRows = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddOrderItems = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem_AddOrderItems = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_DeleteOrderItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_OrderSets = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_UpdateQTYOrderItems = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem1_SubOrderItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_OrderItems = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.gridOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_OrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridOrderItems
        '
        Me.gridOrderItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrderItems.DataMember = "omqryOrderItems"
        Me.gridOrderItems.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode2.RelationName = "Level1"
        Me.gridOrderItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gridOrderItems.Location = New System.Drawing.Point(0, 92)
        Me.gridOrderItems.MainView = Me.Gridview1
        Me.gridOrderItems.Name = "gridOrderItems"
        Me.gridOrderItems.Size = New System.Drawing.Size(1135, 567)
        Me.gridOrderItems.TabIndex = 7
        Me.gridOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1, Me.CardView1})
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderItemID, Me.colOrderID, Me.colOrderSetID, Me.colBoxNumber, Me.colSetName, Me.colPartnerID, Me.colPublisherShortName, Me.colMetaDataID, Me.colItemNumber, Me.colItemDesc, Me.colQTY, Me.colListPrice, Me.colExtendedPrice, Me.SubOrderItemID})
        Me.Gridview1.GridControl = Me.gridOrderItems
        Me.Gridview1.GroupCount = 1
        Me.Gridview1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExtendedPrice", Nothing, "(Set Name: SUM={0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderItemID", Nothing, "")})
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.AutoExpandAllGroups = True
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.Gridview1.OptionsView.ShowAutoFilterRow = True
        Me.Gridview1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.Gridview1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSetName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOrderItemID
        '
        Me.colOrderItemID.FieldName = "OrderItemID"
        Me.colOrderItemID.Name = "colOrderItemID"
        '
        'colOrderID
        '
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        '
        'colOrderSetID
        '
        Me.colOrderSetID.FieldName = "OrderSetID"
        Me.colOrderSetID.Name = "colOrderSetID"
        '
        'colBoxNumber
        '
        Me.colBoxNumber.FieldName = "BoxNumber"
        Me.colBoxNumber.Name = "colBoxNumber"
        Me.colBoxNumber.Visible = True
        Me.colBoxNumber.VisibleIndex = 6
        Me.colBoxNumber.Width = 221
        '
        'colSetName
        '
        Me.colSetName.FieldName = "SetName"
        Me.colSetName.Name = "colSetName"
        Me.colSetName.Visible = True
        Me.colSetName.VisibleIndex = 4
        '
        'colPartnerID
        '
        Me.colPartnerID.FieldName = "PartnerID"
        Me.colPartnerID.Name = "colPartnerID"
        '
        'colPublisherShortName
        '
        Me.colPublisherShortName.FieldName = "PublisherShortName"
        Me.colPublisherShortName.MinWidth = 10
        Me.colPublisherShortName.Name = "colPublisherShortName"
        Me.colPublisherShortName.Visible = True
        Me.colPublisherShortName.VisibleIndex = 0
        Me.colPublisherShortName.Width = 120
        '
        'colMetaDataID
        '
        Me.colMetaDataID.FieldName = "MetaDataID"
        Me.colMetaDataID.Name = "colMetaDataID"
        '
        'colItemNumber
        '
        Me.colItemNumber.FieldName = "ItemNumber"
        Me.colItemNumber.Name = "colItemNumber"
        Me.colItemNumber.Visible = True
        Me.colItemNumber.VisibleIndex = 1
        Me.colItemNumber.Width = 142
        '
        'colItemDesc
        '
        Me.colItemDesc.FieldName = "ItemDesc"
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.Visible = True
        Me.colItemDesc.VisibleIndex = 2
        Me.colItemDesc.Width = 253
        '
        'colQTY
        '
        Me.colQTY.FieldName = "QTY"
        Me.colQTY.Name = "colQTY"
        Me.colQTY.Visible = True
        Me.colQTY.VisibleIndex = 3
        Me.colQTY.Width = 95
        '
        'colListPrice
        '
        Me.colListPrice.FieldName = "ListPrice"
        Me.colListPrice.Name = "colListPrice"
        Me.colListPrice.Visible = True
        Me.colListPrice.VisibleIndex = 4
        Me.colListPrice.Width = 108
        '
        'colExtendedPrice
        '
        Me.colExtendedPrice.FieldName = "ExtendedPrice"
        Me.colExtendedPrice.Name = "colExtendedPrice"
        Me.colExtendedPrice.Visible = True
        Me.colExtendedPrice.VisibleIndex = 5
        Me.colExtendedPrice.Width = 171
        '
        'SubOrderItemID
        '
        Me.SubOrderItemID.Caption = "GridColumn1"
        Me.SubOrderItemID.FieldName = "SubOrderItemID"
        Me.SubOrderItemID.Name = "SubOrderItemID"
        '
        'CardView1
        '
        Me.CardView1.Appearance.Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CardView1.Appearance.Card.Options.UseBackColor = True
        Me.CardView1.GridControl = Me.gridOrderItems
        Me.CardView1.Name = "CardView1"
        Me.CardView1.PaintStyleName = "Flat"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl2_TotalRows)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.cmdAddOrderItems)
        Me.Panel1.Location = New System.Drawing.Point(0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 81)
        Me.Panel1.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(680, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(152, 19)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Total Order Items:"
        '
        'LabelControl2_TotalRows
        '
        Me.LabelControl2_TotalRows.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2_TotalRows.Appearance.Options.UseFont = True
        Me.LabelControl2_TotalRows.Location = New System.Drawing.Point(838, 58)
        Me.LabelControl2_TotalRows.Name = "LabelControl2_TotalRows"
        Me.LabelControl2_TotalRows.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl2_TotalRows.TabIndex = 8
        Me.LabelControl2_TotalRows.Text = "0"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(295, 58)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Order Items"
        '
        'cmdAddOrderItems
        '
        Me.cmdAddOrderItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddOrderItems.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddOrderItems.Appearance.Options.UseFont = True
        Me.cmdAddOrderItems.Location = New System.Drawing.Point(946, 15)
        Me.cmdAddOrderItems.Name = "cmdAddOrderItems"
        Me.cmdAddOrderItems.Size = New System.Drawing.Size(184, 28)
        Me.cmdAddOrderItems.TabIndex = 1
        Me.cmdAddOrderItems.Text = "Add Order Items"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem_AddOrderItems, Me.BarButtonItem1_DeleteOrderItem, Me.BarButtonItem1_OrderSets, Me.BarButtonItem1_UpdateQTYOrderItems, Me.BarHeaderItem1, Me.BarStaticItem1, Me.BarHeaderItem2, Me.BarButtonItem1_SubOrderItem})
        Me.BarManager1.MaxItemId = 8
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1137, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 658)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1137, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 658)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1137, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 658)
        '
        'BarButtonItem_AddOrderItems
        '
        Me.BarButtonItem_AddOrderItems.Caption = "Add Order Items"
        Me.BarButtonItem_AddOrderItems.Id = 0
        Me.BarButtonItem_AddOrderItems.Name = "BarButtonItem_AddOrderItems"
        '
        'BarButtonItem1_DeleteOrderItem
        '
        Me.BarButtonItem1_DeleteOrderItem.Caption = "Delete Order Item"
        Me.BarButtonItem1_DeleteOrderItem.Id = 1
        Me.BarButtonItem1_DeleteOrderItem.Name = "BarButtonItem1_DeleteOrderItem"
        '
        'BarButtonItem1_OrderSets
        '
        Me.BarButtonItem1_OrderSets.Caption = "Order Sets"
        Me.BarButtonItem1_OrderSets.Id = 2
        Me.BarButtonItem1_OrderSets.Name = "BarButtonItem1_OrderSets"
        '
        'BarButtonItem1_UpdateQTYOrderItems
        '
        Me.BarButtonItem1_UpdateQTYOrderItems.Caption = "Update QTY/Price"
        Me.BarButtonItem1_UpdateQTYOrderItems.Id = 3
        Me.BarButtonItem1_UpdateQTYOrderItems.Name = "BarButtonItem1_UpdateQTYOrderItems"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Id = 4
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 5
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarHeaderItem2
        '
        Me.BarHeaderItem2.Id = 6
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'BarButtonItem1_SubOrderItem
        '
        Me.BarButtonItem1_SubOrderItem.Caption = "Sub Order Item"
        Me.BarButtonItem1_SubOrderItem.Id = 7
        Me.BarButtonItem1_SubOrderItem.Name = "BarButtonItem1_SubOrderItem"
        '
        'PopupMenu_OrderItems
        '
        Me.PopupMenu_OrderItems.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem_AddOrderItems), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_UpdateQTYOrderItems), New DevExpress.XtraBars.LinkPersistInfo(Me.BarHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_DeleteOrderItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BarHeaderItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_SubOrderItem)})
        Me.PopupMenu_OrderItems.Manager = Me.BarManager1
        Me.PopupMenu_OrderItems.MenuAppearance.AppearanceMenu.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_OrderItems.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = True
        Me.PopupMenu_OrderItems.MenuAppearance.AppearanceMenu.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_OrderItems.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = True
        Me.PopupMenu_OrderItems.Name = "PopupMenu_OrderItems"
        '
        'frmOrderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1137, 658)
        Me.Controls.Add(Me.gridOrderItems)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmOrderItems"
        Me.Text = "frmOrderItems"
        CType(Me.gridOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_OrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdAddOrderItems As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colOrderItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderSetID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoxNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartnerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPublisherShortName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMetaDataID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colListPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtendedPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem_AddOrderItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_DeleteOrderItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_OrderSets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_UpdateQTYOrderItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents PopupMenu_OrderItems As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem1_SubOrderItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SubOrderItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2_TotalRows As DevExpress.XtraEditors.LabelControl
End Class
