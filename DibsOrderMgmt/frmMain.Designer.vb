<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim BarStaticItem1_divider As DevExpress.XtraBars.BarStaticItem
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2_Orders = New DevExpress.XtraTab.XtraTabPage()
        Me.gridOrders = New DevExpress.XtraGrid.GridControl()
        Me.DiBS_DB_ProdDataSet1 = New DibsOrderMgmt.DiBS_DB_ProdDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDistrictID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSchoolID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBHPONumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillTo_State = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillTo_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipTo_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_TotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderSetsTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillTo_Street = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillTo_City = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillTo_Zip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipTo_Street = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipTo_City = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipTo_Zip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipTo_State = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasingContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasingContactPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasingContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasingPONumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnteredBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpecialInstruction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PO_DiscountAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_Shipping = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatusColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdNewOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage1_MetaData = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdMetaImport = New DevExpress.XtraEditors.SimpleButton()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarSubItem1_EditOrder = New DevExpress.XtraBars.BarSubItem()
        Me.PopupMenu_Orders = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem_OrderDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_Documents = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_OrderSets = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_OrderItems = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1_PublisherPOs = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2_CreateQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1_CreateQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.OmqryOrdersMainTableAdapter1 = New DibsOrderMgmt.DiBS_DB_ProdDataSetTableAdapters.omqryOrdersMainTableAdapter()
        Me.BarButtonItem1_CustomerInvoiceOrderSets = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_CustomerInvoiceOrderItems = New DevExpress.XtraBars.BarButtonItem()
        BarStaticItem1_divider = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2_Orders.SuspendLayout()
        CType(Me.gridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiBS_DB_ProdDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.XtraTabPage1_MetaData.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarStaticItem1_divider
        '
        BarStaticItem1_divider.Id = 4
        BarStaticItem1_divider.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarStaticItem1_divider.ItemAppearance.Normal.Options.UseFont = True
        BarStaticItem1_divider.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarStaticItem1_divider.ItemInMenuAppearance.Normal.Options.UseFont = True
        BarStaticItem1_divider.Name = "BarStaticItem1_divider"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(-3, 101)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2_Orders
        Me.XtraTabControl1.Size = New System.Drawing.Size(1255, 686)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2_Orders, Me.XtraTabPage1_MetaData})
        '
        'XtraTabPage2_Orders
        '
        Me.XtraTabPage2_Orders.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage2_Orders.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2_Orders.Controls.Add(Me.gridOrders)
        Me.XtraTabPage2_Orders.Controls.Add(Me.Panel1)
        Me.XtraTabPage2_Orders.Name = "XtraTabPage2_Orders"
        Me.XtraTabPage2_Orders.Size = New System.Drawing.Size(1253, 641)
        Me.XtraTabPage2_Orders.Text = "Orders/Quotes"
        '
        'gridOrders
        '
        Me.gridOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrders.DataMember = "omqryOrdersMain"
        Me.gridOrders.DataSource = Me.DiBS_DB_ProdDataSet1
        Me.gridOrders.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridOrders.Location = New System.Drawing.Point(6, 76)
        Me.gridOrders.MainView = Me.GridView1
        Me.gridOrders.Name = "gridOrders"
        Me.gridOrders.Size = New System.Drawing.Size(1244, 553)
        Me.gridOrders.TabIndex = 5
        Me.gridOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DiBS_DB_ProdDataSet1
        '
        Me.DiBS_DB_ProdDataSet1.DataSetName = "DiBS_DB_ProdDataSet"
        Me.DiBS_DB_ProdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colDistrictID, Me.colSchoolID, Me.colBHPONumber, Me.colOrderDate, Me.colBillTo_State, Me.colBillTo_Name, Me.colShipTo_Name, Me.colPO_TotalAmount, Me.OrderSetsTotal, Me.colOrderStatus, Me.colDueDate, Me.colBillTo_Street, Me.colBillTo_City, Me.colBillTo_Zip, Me.colShipTo_Street, Me.colShipTo_City, Me.colShipTo_Zip, Me.colShipTo_State, Me.colPurchasingContactName, Me.colPurchasingContactPhone, Me.colPurchasingContactEmail, Me.colPurchasingPONumber, Me.colEnteredBy, Me.colOrderNotes, Me.colSpecialInstruction, Me.colCreateTime, Me.colUpdateTime, Me.PO_DiscountAmount, Me.colPO_Amount, Me.colPO_Shipping, Me.colOrderStatusID, Me.colOrderStatusColor})
        Me.GridView1.GridControl = Me.gridOrders
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'colOrderID
        '
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        '
        'colDistrictID
        '
        Me.colDistrictID.FieldName = "DistrictID"
        Me.colDistrictID.Name = "colDistrictID"
        '
        'colSchoolID
        '
        Me.colSchoolID.FieldName = "SchoolID"
        Me.colSchoolID.Name = "colSchoolID"
        '
        'colBHPONumber
        '
        Me.colBHPONumber.Caption = "BH PO Number"
        Me.colBHPONumber.FieldName = "BHPONumber"
        Me.colBHPONumber.Name = "colBHPONumber"
        Me.colBHPONumber.Visible = True
        Me.colBHPONumber.VisibleIndex = 0
        Me.colBHPONumber.Width = 101
        '
        'colOrderDate
        '
        Me.colOrderDate.Caption = "Order Date"
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        Me.colOrderDate.Width = 101
        '
        'colBillTo_State
        '
        Me.colBillTo_State.Caption = "Bill To State"
        Me.colBillTo_State.FieldName = "BillTo_State"
        Me.colBillTo_State.Name = "colBillTo_State"
        Me.colBillTo_State.Visible = True
        Me.colBillTo_State.VisibleIndex = 2
        Me.colBillTo_State.Width = 101
        '
        'colBillTo_Name
        '
        Me.colBillTo_Name.Caption = "Bill To Name"
        Me.colBillTo_Name.FieldName = "BillTo_Name"
        Me.colBillTo_Name.Name = "colBillTo_Name"
        Me.colBillTo_Name.Visible = True
        Me.colBillTo_Name.VisibleIndex = 3
        Me.colBillTo_Name.Width = 101
        '
        'colShipTo_Name
        '
        Me.colShipTo_Name.Caption = "Ship To Name"
        Me.colShipTo_Name.FieldName = "ShipTo_Name"
        Me.colShipTo_Name.Name = "colShipTo_Name"
        Me.colShipTo_Name.Visible = True
        Me.colShipTo_Name.VisibleIndex = 4
        Me.colShipTo_Name.Width = 101
        '
        'colPO_TotalAmount
        '
        Me.colPO_TotalAmount.Caption = "PO Total Amount"
        Me.colPO_TotalAmount.DisplayFormat.FormatString = "c2"
        Me.colPO_TotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPO_TotalAmount.FieldName = "PO_TotalAmount"
        Me.colPO_TotalAmount.Name = "colPO_TotalAmount"
        Me.colPO_TotalAmount.Visible = True
        Me.colPO_TotalAmount.VisibleIndex = 6
        Me.colPO_TotalAmount.Width = 101
        '
        'OrderSetsTotal
        '
        Me.OrderSetsTotal.Caption = "Order Sets Total"
        Me.OrderSetsTotal.DisplayFormat.FormatString = "c2"
        Me.OrderSetsTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.OrderSetsTotal.FieldName = "OrderSetsTotal"
        Me.OrderSetsTotal.Name = "OrderSetsTotal"
        Me.OrderSetsTotal.Visible = True
        Me.OrderSetsTotal.VisibleIndex = 7
        Me.OrderSetsTotal.Width = 101
        '
        'colOrderStatus
        '
        Me.colOrderStatus.Caption = "Order Status"
        Me.colOrderStatus.FieldName = "OrderStatus"
        Me.colOrderStatus.Name = "colOrderStatus"
        Me.colOrderStatus.Visible = True
        Me.colOrderStatus.VisibleIndex = 8
        Me.colOrderStatus.Width = 100
        '
        'colDueDate
        '
        Me.colDueDate.Caption = "Due Date"
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 9
        Me.colDueDate.Width = 101
        '
        'colBillTo_Street
        '
        Me.colBillTo_Street.FieldName = "BillTo_Street"
        Me.colBillTo_Street.Name = "colBillTo_Street"
        '
        'colBillTo_City
        '
        Me.colBillTo_City.FieldName = "BillTo_City"
        Me.colBillTo_City.Name = "colBillTo_City"
        '
        'colBillTo_Zip
        '
        Me.colBillTo_Zip.FieldName = "BillTo_Zip"
        Me.colBillTo_Zip.Name = "colBillTo_Zip"
        '
        'colShipTo_Street
        '
        Me.colShipTo_Street.FieldName = "ShipTo_Street"
        Me.colShipTo_Street.Name = "colShipTo_Street"
        '
        'colShipTo_City
        '
        Me.colShipTo_City.FieldName = "ShipTo_City"
        Me.colShipTo_City.Name = "colShipTo_City"
        '
        'colShipTo_Zip
        '
        Me.colShipTo_Zip.FieldName = "ShipTo_Zip"
        Me.colShipTo_Zip.Name = "colShipTo_Zip"
        '
        'colShipTo_State
        '
        Me.colShipTo_State.FieldName = "ShipTo_State"
        Me.colShipTo_State.Name = "colShipTo_State"
        '
        'colPurchasingContactName
        '
        Me.colPurchasingContactName.FieldName = "PurchasingContactName"
        Me.colPurchasingContactName.Name = "colPurchasingContactName"
        '
        'colPurchasingContactPhone
        '
        Me.colPurchasingContactPhone.FieldName = "PurchasingContactPhone"
        Me.colPurchasingContactPhone.Name = "colPurchasingContactPhone"
        '
        'colPurchasingContactEmail
        '
        Me.colPurchasingContactEmail.FieldName = "PurchasingContactEmail"
        Me.colPurchasingContactEmail.Name = "colPurchasingContactEmail"
        '
        'colPurchasingPONumber
        '
        Me.colPurchasingPONumber.Caption = "PO Number"
        Me.colPurchasingPONumber.FieldName = "PurchasingPONumber"
        Me.colPurchasingPONumber.Name = "colPurchasingPONumber"
        Me.colPurchasingPONumber.Visible = True
        Me.colPurchasingPONumber.VisibleIndex = 5
        Me.colPurchasingPONumber.Width = 101
        '
        'colEnteredBy
        '
        Me.colEnteredBy.Caption = "Entered By"
        Me.colEnteredBy.FieldName = "EnteredBy"
        Me.colEnteredBy.Name = "colEnteredBy"
        Me.colEnteredBy.Visible = True
        Me.colEnteredBy.VisibleIndex = 10
        Me.colEnteredBy.Width = 101
        '
        'colOrderNotes
        '
        Me.colOrderNotes.FieldName = "OrderNotes"
        Me.colOrderNotes.Name = "colOrderNotes"
        '
        'colSpecialInstruction
        '
        Me.colSpecialInstruction.FieldName = "SpecialInstruction"
        Me.colSpecialInstruction.Name = "colSpecialInstruction"
        '
        'colCreateTime
        '
        Me.colCreateTime.Caption = "Entered Date"
        Me.colCreateTime.FieldName = "CreateTime"
        Me.colCreateTime.Name = "colCreateTime"
        Me.colCreateTime.Visible = True
        Me.colCreateTime.VisibleIndex = 11
        Me.colCreateTime.Width = 109
        '
        'colUpdateTime
        '
        Me.colUpdateTime.FieldName = "UpdateTime"
        Me.colUpdateTime.Name = "colUpdateTime"
        '
        'PO_DiscountAmount
        '
        Me.PO_DiscountAmount.Caption = "PO_DiscountAmount"
        Me.PO_DiscountAmount.FieldName = "PO_DiscountAmount"
        Me.PO_DiscountAmount.Name = "PO_DiscountAmount"
        '
        'colPO_Amount
        '
        Me.colPO_Amount.FieldName = "PO_Amount"
        Me.colPO_Amount.Name = "colPO_Amount"
        '
        'colPO_Shipping
        '
        Me.colPO_Shipping.FieldName = "PO_Shipping"
        Me.colPO_Shipping.Name = "colPO_Shipping"
        '
        'colOrderStatusID
        '
        Me.colOrderStatusID.FieldName = "OrderStatusID"
        Me.colOrderStatusID.Name = "colOrderStatusID"
        '
        'colOrderStatusColor
        '
        Me.colOrderStatusColor.FieldName = "OrderStatusColor"
        Me.colOrderStatusColor.Name = "colOrderStatusColor"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cmdNewOrder)
        Me.Panel1.Location = New System.Drawing.Point(6, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 60)
        Me.Panel1.TabIndex = 4
        '
        'cmdNewOrder
        '
        Me.cmdNewOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNewOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewOrder.Appearance.Options.UseFont = True
        Me.cmdNewOrder.Location = New System.Drawing.Point(1109, 15)
        Me.cmdNewOrder.Name = "cmdNewOrder"
        Me.cmdNewOrder.Size = New System.Drawing.Size(130, 28)
        Me.cmdNewOrder.TabIndex = 1
        Me.cmdNewOrder.Text = "Create Order"
        '
        'XtraTabPage1_MetaData
        '
        Me.XtraTabPage1_MetaData.Controls.Add(Me.cmdMetaImport)
        Me.XtraTabPage1_MetaData.Name = "XtraTabPage1_MetaData"
        Me.XtraTabPage1_MetaData.Size = New System.Drawing.Size(1253, 641)
        Me.XtraTabPage1_MetaData.Text = "Meta Data Tools"
        '
        'cmdMetaImport
        '
        Me.cmdMetaImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMetaImport.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMetaImport.Appearance.Options.UseFont = True
        Me.cmdMetaImport.Location = New System.Drawing.Point(14, 30)
        Me.cmdMetaImport.Name = "cmdMetaImport"
        Me.cmdMetaImport.Size = New System.Drawing.Size(227, 28)
        Me.cmdMetaImport.TabIndex = 3
        Me.cmdMetaImport.Text = "Meta Data Import"
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.Controls.Add(Me.SimpleButton2)
        Me.panelTop.Controls.Add(Me.SimpleButton1)
        Me.panelTop.Controls.Add(Me.LabelControl1)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Location = New System.Drawing.Point(-2, 3)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1253, 92)
        Me.panelTop.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(1022, 55)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(130, 28)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Test Docs Open"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(1022, 21)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(130, 28)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Test Docs"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(503, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(469, 58)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Order Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DibsOrderMgmt.My.Resources.Resources.BrainHive_App_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 89)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BarSubItem1_EditOrder
        '
        Me.BarSubItem1_EditOrder.Caption = "Order Detail (Edit)"
        Me.BarSubItem1_EditOrder.Id = 0
        Me.BarSubItem1_EditOrder.Name = "BarSubItem1_EditOrder"
        '
        'PopupMenu_Orders
        '
        Me.PopupMenu_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem_OrderDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_Documents), New DevExpress.XtraBars.LinkPersistInfo(BarStaticItem1_divider), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_OrderSets), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_OrderItems), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
        Me.PopupMenu_Orders.Manager = Me.BarManager1
        Me.PopupMenu_Orders.MenuAppearance.AppearanceMenu.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_Orders.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = True
        Me.PopupMenu_Orders.MenuAppearance.AppearanceMenu.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_Orders.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = True
        Me.PopupMenu_Orders.MenuAppearance.MenuBar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_Orders.MenuAppearance.MenuBar.Options.UseFont = True
        Me.PopupMenu_Orders.MenuAppearance.MenuCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_Orders.MenuAppearance.MenuCaption.Options.UseFont = True
        Me.PopupMenu_Orders.MenuAppearance.SideStrip.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu_Orders.MenuAppearance.SideStrip.Options.UseFont = True
        Me.PopupMenu_Orders.Name = "PopupMenu_Orders"
        '
        'BarButtonItem_OrderDetail
        '
        Me.BarButtonItem_OrderDetail.Caption = "Order Detail/Edit"
        Me.BarButtonItem_OrderDetail.Id = 0
        Me.BarButtonItem_OrderDetail.Name = "BarButtonItem_OrderDetail"
        '
        'BarButtonItem1_Documents
        '
        Me.BarButtonItem1_Documents.Caption = "Documents"
        Me.BarButtonItem1_Documents.Id = 1
        Me.BarButtonItem1_Documents.Name = "BarButtonItem1_Documents"
        '
        'BarButtonItem1_OrderSets
        '
        Me.BarButtonItem1_OrderSets.Caption = "Order Sets"
        Me.BarButtonItem1_OrderSets.Id = 2
        Me.BarButtonItem1_OrderSets.Name = "BarButtonItem1_OrderSets"
        '
        'BarButtonItem1_OrderItems
        '
        Me.BarButtonItem1_OrderItems.Caption = "Order Items"
        Me.BarButtonItem1_OrderItems.Id = 3
        Me.BarButtonItem1_OrderItems.Name = "BarButtonItem1_OrderItems"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Id = 5
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Reports/Quotes/Invoices"
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_PublisherPOs), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem2_CreateQuote, False), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_CustomerInvoiceOrderSets), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_CustomerInvoiceOrderItems)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1_PublisherPOs
        '
        Me.BarButtonItem1_PublisherPOs.Caption = "Create Publisher POs"
        Me.BarButtonItem1_PublisherPOs.Id = 6
        Me.BarButtonItem1_PublisherPOs.Name = "BarButtonItem1_PublisherPOs"
        '
        'BarButtonItem2_CreateQuote
        '
        Me.BarButtonItem2_CreateQuote.Caption = "Create Quote"
        Me.BarButtonItem2_CreateQuote.Id = 9
        Me.BarButtonItem2_CreateQuote.Name = "BarButtonItem2_CreateQuote"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem_OrderDetail, Me.BarButtonItem1_Documents, Me.BarButtonItem1_OrderSets, Me.BarButtonItem1_OrderItems, BarStaticItem1_divider, Me.BarStaticItem2, Me.BarButtonItem1_PublisherPOs, Me.BarSubItem1, Me.BarButtonItem1_CreateQuote, Me.BarButtonItem2_CreateQuote, Me.BarButtonItem1_CustomerInvoiceOrderSets, Me.BarButtonItem1_CustomerInvoiceOrderItems})
        Me.BarManager1.MaxItemId = 12
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1255, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 812)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1255, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 812)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1255, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 812)
        '
        'BarButtonItem1_CreateQuote
        '
        Me.BarButtonItem1_CreateQuote.Caption = "Create Customer Quote"
        Me.BarButtonItem1_CreateQuote.Id = 8
        Me.BarButtonItem1_CreateQuote.Name = "BarButtonItem1_CreateQuote"
        '
        'OmqryOrdersMainTableAdapter1
        '
        Me.OmqryOrdersMainTableAdapter1.ClearBeforeFill = True
        '
        'BarButtonItem1_CustomerInvoiceOrderSets
        '
        Me.BarButtonItem1_CustomerInvoiceOrderSets.Caption = "Create Customer Invoice - Order Sets"
        Me.BarButtonItem1_CustomerInvoiceOrderSets.Id = 10
        Me.BarButtonItem1_CustomerInvoiceOrderSets.Name = "BarButtonItem1_CustomerInvoiceOrderSets"
        '
        'BarButtonItem1_CustomerInvoiceOrderItems
        '
        Me.BarButtonItem1_CustomerInvoiceOrderItems.Caption = "Create Customer Invoice - Order Items"
        Me.BarButtonItem1_CustomerInvoiceOrderItems.Id = 11
        Me.BarButtonItem1_CustomerInvoiceOrderItems.Name = "BarButtonItem1_CustomerInvoiceOrderItems"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1255, 812)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2_Orders.ResumeLayout(False)
        CType(Me.gridOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiBS_DB_ProdDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.XtraTabPage1_MetaData.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2_Orders As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents panelTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdNewOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistrictID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSchoolID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBHPONumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillTo_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillTo_Street As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillTo_City As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillTo_Zip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillTo_State As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipTo_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipTo_Street As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipTo_City As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipTo_Zip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipTo_State As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasingContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasingContactPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasingContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasingPONumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpecialInstruction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnteredBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_Shipping As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_TotalAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatusColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1_EditOrder As DevExpress.XtraBars.BarSubItem
    Friend WithEvents PopupMenu_Orders As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem_OrderDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem1_Documents As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_OrderSets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DiBS_DB_ProdDataSet1 As DiBS_DB_ProdDataSet
    Friend WithEvents OmqryOrdersMainTableAdapter1 As DiBS_DB_ProdDataSetTableAdapters.omqryOrdersMainTableAdapter
    Friend WithEvents XtraTabPage1_MetaData As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdMetaImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem1_OrderItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1_PublisherPOs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OrderSetsTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2_CreateQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_CreateQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PO_DiscountAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1_CustomerInvoiceOrderSets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_CustomerInvoiceOrderItems As DevExpress.XtraBars.BarButtonItem
End Class
