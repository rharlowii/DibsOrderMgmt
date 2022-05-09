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
        Me.ShipTo_ATTN = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.cmdExportOrdersGrid = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefreshGrid = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage1_PubInvoiceTracker = New DevExpress.XtraTab.XtraTabPage()
        Me.gridPubInvoices = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PubPaymentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartnerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PublisherName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PublisherInvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InvoiceAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NetTermDays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PlanToPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DatePaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdMarkPubInvoicesPaid = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefreshPubInvoicesGrid = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddPubInvoices = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage3_MetaSearch = New DevExpress.XtraTab.XtraTabPage()
        Me.GridMetaSearch = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMetaDataID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartnerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPublisherName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaperback_ISBN_13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaperback_List_Price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassification = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuided_Reading_Level = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLexile_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLexile_Text = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colATOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeries_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHardcover_Print_ISBN_13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHardcover_Print_List_Price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleBook_ISBN_13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleBook_List_Price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImprint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPage_Count = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAge_Level_Start = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAge_Level_End = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterest_Level_Start = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterest_Level_End = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReading_Level_Start = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReading_Level_End = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDewey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBISAC_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBISAC_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBISAC_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrade_Level = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuthor_First_Name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuthor_Middle_Name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuthor_Last_Name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCopyright = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeries_Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenre_Interest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeywords = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitleDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OfficialImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EBookPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem_OrderDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_Documents = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_OrderSets = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_OrderItems = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1_PublisherPOs = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1_PublisherCheckIn = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2_CreateQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_CustomerInvoiceOrderSets = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_CustomerInvoiceOrderItems = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_CustomerPackingSlip = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_CreateQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_ViewBook = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_ViewCover = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_EBookSales = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1_PubInvoiceDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_Divider1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2_PubInvoiceDocs = New DevExpress.XtraBars.BarButtonItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.XtraTabPage1_MetaData = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdMetaImport = New DevExpress.XtraEditors.SimpleButton()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarSubItem1_EditOrder = New DevExpress.XtraBars.BarSubItem()
        Me.PopupMenu_Orders = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.OmqryOrdersMainTableAdapter1 = New DibsOrderMgmt.DiBS_DB_ProdDataSetTableAdapters.omqryOrdersMainTableAdapter()
        Me.DiBS_DB_ProdDataSet5 = New DibsOrderMgmt.DiBS_DB_ProdDataSet5()
        Me.OmMetaDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmMetaDataTableAdapter = New DibsOrderMgmt.DiBS_DB_ProdDataSet5TableAdapters.omMetaDataTableAdapter()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        BarStaticItem1_divider = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2_Orders.SuspendLayout()
        CType(Me.gridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiBS_DB_ProdDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.XtraTabPage1_PubInvoiceTracker.SuspendLayout()
        CType(Me.gridPubInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.XtraTabPage3_MetaSearch.SuspendLayout()
        CType(Me.GridMetaSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1_MetaData.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiBS_DB_ProdDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmMetaDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2_Orders, Me.XtraTabPage1_PubInvoiceTracker, Me.XtraTabPage3_MetaSearch, Me.XtraTabPage1_MetaData})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colDistrictID, Me.colSchoolID, Me.colBHPONumber, Me.colOrderDate, Me.colBillTo_State, Me.colBillTo_Name, Me.colShipTo_Name, Me.colPO_TotalAmount, Me.OrderSetsTotal, Me.colOrderStatus, Me.colDueDate, Me.ShipTo_ATTN, Me.colBillTo_Street, Me.colBillTo_City, Me.colBillTo_Zip, Me.colShipTo_Street, Me.colShipTo_City, Me.colShipTo_Zip, Me.colShipTo_State, Me.colPurchasingContactName, Me.colPurchasingContactPhone, Me.colPurchasingContactEmail, Me.colPurchasingPONumber, Me.colEnteredBy, Me.colOrderNotes, Me.colSpecialInstruction, Me.colCreateTime, Me.colUpdateTime, Me.PO_DiscountAmount, Me.colPO_Amount, Me.colPO_Shipping, Me.colOrderStatusID, Me.colOrderStatusColor})
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
        'ShipTo_ATTN
        '
        Me.ShipTo_ATTN.Caption = "ShipTo_ATTN"
        Me.ShipTo_ATTN.FieldName = "ShipTo_ATTN"
        Me.ShipTo_ATTN.Name = "ShipTo_ATTN"
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
        Me.Panel1.Controls.Add(Me.cmdExportOrdersGrid)
        Me.Panel1.Controls.Add(Me.cmdRefreshGrid)
        Me.Panel1.Controls.Add(Me.cmdNewOrder)
        Me.Panel1.Location = New System.Drawing.Point(6, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 60)
        Me.Panel1.TabIndex = 4
        '
        'cmdExportOrdersGrid
        '
        Me.cmdExportOrdersGrid.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportOrdersGrid.Appearance.Options.UseFont = True
        Me.cmdExportOrdersGrid.Location = New System.Drawing.Point(8, 15)
        Me.cmdExportOrdersGrid.Name = "cmdExportOrdersGrid"
        Me.cmdExportOrdersGrid.Size = New System.Drawing.Size(130, 28)
        Me.cmdExportOrdersGrid.TabIndex = 3
        Me.cmdExportOrdersGrid.Text = "Export Orders"
        '
        'cmdRefreshGrid
        '
        Me.cmdRefreshGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefreshGrid.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefreshGrid.Appearance.Options.UseFont = True
        Me.cmdRefreshGrid.Location = New System.Drawing.Point(973, 15)
        Me.cmdRefreshGrid.Name = "cmdRefreshGrid"
        Me.cmdRefreshGrid.Size = New System.Drawing.Size(130, 28)
        Me.cmdRefreshGrid.TabIndex = 2
        Me.cmdRefreshGrid.Text = "Refresh Grid"
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
        'XtraTabPage1_PubInvoiceTracker
        '
        Me.XtraTabPage1_PubInvoiceTracker.Controls.Add(Me.gridPubInvoices)
        Me.XtraTabPage1_PubInvoiceTracker.Controls.Add(Me.Panel3)
        Me.XtraTabPage1_PubInvoiceTracker.Name = "XtraTabPage1_PubInvoiceTracker"
        Me.XtraTabPage1_PubInvoiceTracker.Size = New System.Drawing.Size(1253, 641)
        Me.XtraTabPage1_PubInvoiceTracker.Text = "Pub Invoice Tracker"
        '
        'gridPubInvoices
        '
        Me.gridPubInvoices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPubInvoices.DataMember = "omqryOrdersMain"
        Me.gridPubInvoices.DataSource = Me.DiBS_DB_ProdDataSet1
        Me.gridPubInvoices.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPubInvoices.Location = New System.Drawing.Point(4, 53)
        Me.gridPubInvoices.MainView = Me.GridView3
        Me.gridPubInvoices.Name = "gridPubInvoices"
        Me.gridPubInvoices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.gridPubInvoices.Size = New System.Drawing.Size(1244, 544)
        Me.gridPubInvoices.TabIndex = 8
        Me.gridPubInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PubPaymentID, Me.OrderID, Me.PartnerID, Me.GridColumn4, Me.PublisherName, Me.PublisherInvoiceNumber, Me.InvoiceAmount, Me.NetTermDays, Me.DueDate, Me.PlanToPay, Me.DatePaid})
        Me.GridView3.GridControl = Me.gridPubInvoices
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'PubPaymentID
        '
        Me.PubPaymentID.Caption = "Pub Payment ID"
        Me.PubPaymentID.FieldName = "PubPaymentID"
        Me.PubPaymentID.Name = "PubPaymentID"
        '
        'OrderID
        '
        Me.OrderID.FieldName = "OrderID"
        Me.OrderID.Name = "OrderID"
        '
        'PartnerID
        '
        Me.PartnerID.Caption = "Partner ID"
        Me.PartnerID.FieldName = "PartnerID"
        Me.PartnerID.Name = "PartnerID"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "BH PO Number"
        Me.GridColumn4.FieldName = "BHPONumber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 101
        '
        'PublisherName
        '
        Me.PublisherName.Caption = "Publisher Name"
        Me.PublisherName.FieldName = "PublisherName"
        Me.PublisherName.Name = "PublisherName"
        Me.PublisherName.OptionsColumn.AllowEdit = False
        Me.PublisherName.Visible = True
        Me.PublisherName.VisibleIndex = 1
        Me.PublisherName.Width = 101
        '
        'PublisherInvoiceNumber
        '
        Me.PublisherInvoiceNumber.Caption = "Pub Invoice #"
        Me.PublisherInvoiceNumber.FieldName = "PublisherInvoiceNumber"
        Me.PublisherInvoiceNumber.Name = "PublisherInvoiceNumber"
        Me.PublisherInvoiceNumber.Visible = True
        Me.PublisherInvoiceNumber.VisibleIndex = 2
        Me.PublisherInvoiceNumber.Width = 101
        '
        'InvoiceAmount
        '
        Me.InvoiceAmount.Caption = "Pub Invoice Amount"
        Me.InvoiceAmount.DisplayFormat.FormatString = "c2"
        Me.InvoiceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.InvoiceAmount.FieldName = "InvoiceAmount"
        Me.InvoiceAmount.Name = "InvoiceAmount"
        Me.InvoiceAmount.Visible = True
        Me.InvoiceAmount.VisibleIndex = 3
        '
        'NetTermDays
        '
        Me.NetTermDays.Caption = "Net Term"
        Me.NetTermDays.FieldName = "NetTermDays"
        Me.NetTermDays.Name = "NetTermDays"
        Me.NetTermDays.OptionsColumn.AllowEdit = False
        Me.NetTermDays.Visible = True
        Me.NetTermDays.VisibleIndex = 4
        Me.NetTermDays.Width = 101
        '
        'DueDate
        '
        Me.DueDate.Caption = "Due Date"
        Me.DueDate.FieldName = "DueDate"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.Visible = True
        Me.DueDate.VisibleIndex = 5
        Me.DueDate.Width = 101
        '
        'PlanToPay
        '
        Me.PlanToPay.Caption = "Plan To Pay Date"
        Me.PlanToPay.FieldName = "PlanToPay"
        Me.PlanToPay.Name = "PlanToPay"
        Me.PlanToPay.Visible = True
        Me.PlanToPay.VisibleIndex = 6
        Me.PlanToPay.Width = 101
        '
        'DatePaid
        '
        Me.DatePaid.Caption = "Date Paid"
        Me.DatePaid.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.DatePaid.FieldName = "DatePaid"
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.Visible = True
        Me.DatePaid.VisibleIndex = 7
        Me.DatePaid.Width = 109
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.cmdMarkPubInvoicesPaid)
        Me.Panel3.Controls.Add(Me.cmdRefreshPubInvoicesGrid)
        Me.Panel3.Controls.Add(Me.cmdAddPubInvoices)
        Me.Panel3.Location = New System.Drawing.Point(5, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1244, 44)
        Me.Panel3.TabIndex = 7
        '
        'cmdMarkPubInvoicesPaid
        '
        Me.cmdMarkPubInvoicesPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMarkPubInvoicesPaid.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMarkPubInvoicesPaid.Appearance.Options.UseFont = True
        Me.cmdMarkPubInvoicesPaid.Location = New System.Drawing.Point(831, 7)
        Me.cmdMarkPubInvoicesPaid.Name = "cmdMarkPubInvoicesPaid"
        Me.cmdMarkPubInvoicesPaid.Size = New System.Drawing.Size(216, 28)
        Me.cmdMarkPubInvoicesPaid.TabIndex = 8
        Me.cmdMarkPubInvoicesPaid.Text = "Mark Pub Invoice(s) Paid"
        '
        'cmdRefreshPubInvoicesGrid
        '
        Me.cmdRefreshPubInvoicesGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefreshPubInvoicesGrid.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefreshPubInvoicesGrid.Appearance.Options.UseFont = True
        Me.cmdRefreshPubInvoicesGrid.Location = New System.Drawing.Point(695, 7)
        Me.cmdRefreshPubInvoicesGrid.Name = "cmdRefreshPubInvoicesGrid"
        Me.cmdRefreshPubInvoicesGrid.Size = New System.Drawing.Size(130, 28)
        Me.cmdRefreshPubInvoicesGrid.TabIndex = 7
        Me.cmdRefreshPubInvoicesGrid.Text = "Refresh Grid"
        '
        'cmdAddPubInvoices
        '
        Me.cmdAddPubInvoices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddPubInvoices.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPubInvoices.Appearance.Options.UseFont = True
        Me.cmdAddPubInvoices.Location = New System.Drawing.Point(1053, 7)
        Me.cmdAddPubInvoices.Name = "cmdAddPubInvoices"
        Me.cmdAddPubInvoices.Size = New System.Drawing.Size(175, 28)
        Me.cmdAddPubInvoices.TabIndex = 6
        Me.cmdAddPubInvoices.Text = "Add Pub Invoices"
        '
        'XtraTabPage3_MetaSearch
        '
        Me.XtraTabPage3_MetaSearch.Controls.Add(Me.GridMetaSearch)
        Me.XtraTabPage3_MetaSearch.Controls.Add(Me.Panel2)
        Me.XtraTabPage3_MetaSearch.Name = "XtraTabPage3_MetaSearch"
        Me.XtraTabPage3_MetaSearch.Size = New System.Drawing.Size(1253, 641)
        Me.XtraTabPage3_MetaSearch.Text = "Meta Search"
        '
        'GridMetaSearch
        '
        Me.GridMetaSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMetaSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMetaSearch.Location = New System.Drawing.Point(4, 77)
        Me.GridMetaSearch.MainView = Me.GridView2
        Me.GridMetaSearch.MenuManager = Me.BarManager1
        Me.GridMetaSearch.Name = "GridMetaSearch"
        Me.GridMetaSearch.Size = New System.Drawing.Size(1244, 553)
        Me.GridMetaSearch.TabIndex = 7
        Me.GridMetaSearch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMetaDataID, Me.colPartnerID, Me.colPartner, Me.colPublisherName, Me.colPaperback_ISBN_13, Me.colTitle, Me.colSubTitle, Me.colPaperback_List_Price, Me.colClassification, Me.colGuided_Reading_Level, Me.colLexile_Number, Me.colLexile_Text, Me.colATOS, Me.colSeries_Name, Me.colHardcover_Print_ISBN_13, Me.colHardcover_Print_List_Price, Me.coleBook_ISBN_13, Me.coleBook_List_Price, Me.colImprint, Me.colLanguage, Me.colPage_Count, Me.colAge_Level_Start, Me.colAge_Level_End, Me.colInterest_Level_Start, Me.colInterest_Level_End, Me.colReading_Level_Start, Me.colReading_Level_End, Me.colDewey, Me.colBISAC_1, Me.colBISAC_2, Me.colBISAC_3, Me.colGrade_Level, Me.colAuthor_First_Name1, Me.colAuthor_Middle_Name1, Me.colAuthor_Last_Name1, Me.colCopyright, Me.colSeries_Description, Me.colGenre_Interest, Me.colSubject, Me.colKeywords, Me.colTitleDescription, Me.OfficialImage, Me.EBookPath})
        Me.GridView2.GridControl = Me.GridMetaSearch
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'colMetaDataID
        '
        Me.colMetaDataID.FieldName = "MetaDataID"
        Me.colMetaDataID.Name = "colMetaDataID"
        '
        'colPartnerID
        '
        Me.colPartnerID.FieldName = "PartnerID"
        Me.colPartnerID.Name = "colPartnerID"
        '
        'colPartner
        '
        Me.colPartner.FieldName = "Partner"
        Me.colPartner.Name = "colPartner"
        Me.colPartner.Visible = True
        Me.colPartner.VisibleIndex = 0
        Me.colPartner.Width = 130
        '
        'colPublisherName
        '
        Me.colPublisherName.FieldName = "PublisherName"
        Me.colPublisherName.Name = "colPublisherName"
        Me.colPublisherName.Width = 108
        '
        'colPaperback_ISBN_13
        '
        Me.colPaperback_ISBN_13.FieldName = "Paperback_ISBN_13"
        Me.colPaperback_ISBN_13.Name = "colPaperback_ISBN_13"
        Me.colPaperback_ISBN_13.Visible = True
        Me.colPaperback_ISBN_13.VisibleIndex = 2
        Me.colPaperback_ISBN_13.Width = 150
        '
        'colTitle
        '
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 1
        Me.colTitle.Width = 200
        '
        'colSubTitle
        '
        Me.colSubTitle.FieldName = "SubTitle"
        Me.colSubTitle.Name = "colSubTitle"
        '
        'colPaperback_List_Price
        '
        Me.colPaperback_List_Price.FieldName = "Paperback_List_Price"
        Me.colPaperback_List_Price.Name = "colPaperback_List_Price"
        Me.colPaperback_List_Price.Visible = True
        Me.colPaperback_List_Price.VisibleIndex = 3
        Me.colPaperback_List_Price.Width = 65
        '
        'colClassification
        '
        Me.colClassification.FieldName = "Classification"
        Me.colClassification.Name = "colClassification"
        Me.colClassification.Visible = True
        Me.colClassification.VisibleIndex = 4
        Me.colClassification.Width = 82
        '
        'colGuided_Reading_Level
        '
        Me.colGuided_Reading_Level.FieldName = "Guided_Reading_Level"
        Me.colGuided_Reading_Level.Name = "colGuided_Reading_Level"
        Me.colGuided_Reading_Level.Visible = True
        Me.colGuided_Reading_Level.VisibleIndex = 5
        Me.colGuided_Reading_Level.Width = 60
        '
        'colLexile_Number
        '
        Me.colLexile_Number.FieldName = "Lexile_Number"
        Me.colLexile_Number.Name = "colLexile_Number"
        Me.colLexile_Number.Visible = True
        Me.colLexile_Number.VisibleIndex = 6
        Me.colLexile_Number.Width = 57
        '
        'colLexile_Text
        '
        Me.colLexile_Text.FieldName = "Lexile_Text"
        Me.colLexile_Text.Name = "colLexile_Text"
        Me.colLexile_Text.Visible = True
        Me.colLexile_Text.VisibleIndex = 7
        Me.colLexile_Text.Width = 21
        '
        'colATOS
        '
        Me.colATOS.FieldName = "ATOS"
        Me.colATOS.Name = "colATOS"
        Me.colATOS.Width = 38
        '
        'colSeries_Name
        '
        Me.colSeries_Name.FieldName = "Series_Name"
        Me.colSeries_Name.Name = "colSeries_Name"
        Me.colSeries_Name.Visible = True
        Me.colSeries_Name.VisibleIndex = 8
        Me.colSeries_Name.Width = 100
        '
        'colHardcover_Print_ISBN_13
        '
        Me.colHardcover_Print_ISBN_13.FieldName = "Hardcover_Print_ISBN_13"
        Me.colHardcover_Print_ISBN_13.Name = "colHardcover_Print_ISBN_13"
        '
        'colHardcover_Print_List_Price
        '
        Me.colHardcover_Print_List_Price.FieldName = "Hardcover_Print_List_Price"
        Me.colHardcover_Print_List_Price.Name = "colHardcover_Print_List_Price"
        '
        'coleBook_ISBN_13
        '
        Me.coleBook_ISBN_13.FieldName = "eBook_ISBN_13"
        Me.coleBook_ISBN_13.Name = "coleBook_ISBN_13"
        Me.coleBook_ISBN_13.Visible = True
        Me.coleBook_ISBN_13.VisibleIndex = 9
        Me.coleBook_ISBN_13.Width = 122
        '
        'coleBook_List_Price
        '
        Me.coleBook_List_Price.FieldName = "eBook_List_Price"
        Me.coleBook_List_Price.Name = "coleBook_List_Price"
        '
        'colImprint
        '
        Me.colImprint.FieldName = "Imprint"
        Me.colImprint.Name = "colImprint"
        Me.colImprint.Visible = True
        Me.colImprint.VisibleIndex = 10
        '
        'colLanguage
        '
        Me.colLanguage.FieldName = "Language"
        Me.colLanguage.Name = "colLanguage"
        Me.colLanguage.Visible = True
        Me.colLanguage.VisibleIndex = 15
        '
        'colPage_Count
        '
        Me.colPage_Count.FieldName = "Page_Count"
        Me.colPage_Count.Name = "colPage_Count"
        '
        'colAge_Level_Start
        '
        Me.colAge_Level_Start.FieldName = "Age_Level_Start"
        Me.colAge_Level_Start.Name = "colAge_Level_Start"
        Me.colAge_Level_Start.Visible = True
        Me.colAge_Level_Start.VisibleIndex = 16
        '
        'colAge_Level_End
        '
        Me.colAge_Level_End.FieldName = "Age_Level_End"
        Me.colAge_Level_End.Name = "colAge_Level_End"
        Me.colAge_Level_End.Visible = True
        Me.colAge_Level_End.VisibleIndex = 17
        '
        'colInterest_Level_Start
        '
        Me.colInterest_Level_Start.FieldName = "Interest_Level_Start"
        Me.colInterest_Level_Start.Name = "colInterest_Level_Start"
        Me.colInterest_Level_Start.Visible = True
        Me.colInterest_Level_Start.VisibleIndex = 18
        '
        'colInterest_Level_End
        '
        Me.colInterest_Level_End.FieldName = "Interest_Level_End"
        Me.colInterest_Level_End.Name = "colInterest_Level_End"
        Me.colInterest_Level_End.Visible = True
        Me.colInterest_Level_End.VisibleIndex = 19
        '
        'colReading_Level_Start
        '
        Me.colReading_Level_Start.FieldName = "Reading_Level_Start"
        Me.colReading_Level_Start.Name = "colReading_Level_Start"
        Me.colReading_Level_Start.Visible = True
        Me.colReading_Level_Start.VisibleIndex = 20
        '
        'colReading_Level_End
        '
        Me.colReading_Level_End.FieldName = "Reading_Level_End"
        Me.colReading_Level_End.Name = "colReading_Level_End"
        Me.colReading_Level_End.Visible = True
        Me.colReading_Level_End.VisibleIndex = 21
        '
        'colDewey
        '
        Me.colDewey.FieldName = "Dewey"
        Me.colDewey.Name = "colDewey"
        '
        'colBISAC_1
        '
        Me.colBISAC_1.FieldName = "BISAC_1"
        Me.colBISAC_1.Name = "colBISAC_1"
        '
        'colBISAC_2
        '
        Me.colBISAC_2.FieldName = "BISAC_2"
        Me.colBISAC_2.Name = "colBISAC_2"
        '
        'colBISAC_3
        '
        Me.colBISAC_3.FieldName = "BISAC_3"
        Me.colBISAC_3.Name = "colBISAC_3"
        '
        'colGrade_Level
        '
        Me.colGrade_Level.FieldName = "Grade_Level"
        Me.colGrade_Level.Name = "colGrade_Level"
        Me.colGrade_Level.Visible = True
        Me.colGrade_Level.VisibleIndex = 22
        Me.colGrade_Level.Width = 21
        '
        'colAuthor_First_Name1
        '
        Me.colAuthor_First_Name1.FieldName = "Author_First_Name1"
        Me.colAuthor_First_Name1.Name = "colAuthor_First_Name1"
        '
        'colAuthor_Middle_Name1
        '
        Me.colAuthor_Middle_Name1.FieldName = "Author_Middle_Name1"
        Me.colAuthor_Middle_Name1.Name = "colAuthor_Middle_Name1"
        '
        'colAuthor_Last_Name1
        '
        Me.colAuthor_Last_Name1.FieldName = "Author_Last_Name1"
        Me.colAuthor_Last_Name1.Name = "colAuthor_Last_Name1"
        '
        'colCopyright
        '
        Me.colCopyright.FieldName = "Copyright"
        Me.colCopyright.Name = "colCopyright"
        '
        'colSeries_Description
        '
        Me.colSeries_Description.FieldName = "Series_Description"
        Me.colSeries_Description.Name = "colSeries_Description"
        '
        'colGenre_Interest
        '
        Me.colGenre_Interest.FieldName = "Genre_Interest"
        Me.colGenre_Interest.Name = "colGenre_Interest"
        Me.colGenre_Interest.Visible = True
        Me.colGenre_Interest.VisibleIndex = 11
        Me.colGenre_Interest.Width = 150
        '
        'colSubject
        '
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 12
        Me.colSubject.Width = 150
        '
        'colKeywords
        '
        Me.colKeywords.FieldName = "Keywords"
        Me.colKeywords.Name = "colKeywords"
        Me.colKeywords.Visible = True
        Me.colKeywords.VisibleIndex = 13
        Me.colKeywords.Width = 150
        '
        'colTitleDescription
        '
        Me.colTitleDescription.FieldName = "TitleDescription"
        Me.colTitleDescription.MinWidth = 50
        Me.colTitleDescription.Name = "colTitleDescription"
        Me.colTitleDescription.Visible = True
        Me.colTitleDescription.VisibleIndex = 14
        Me.colTitleDescription.Width = 250
        '
        'OfficialImage
        '
        Me.OfficialImage.Caption = "GridColumn1"
        Me.OfficialImage.FieldName = "OfficialImage"
        Me.OfficialImage.Name = "OfficialImage"
        '
        'EBookPath
        '
        Me.EBookPath.Caption = "GridColumn1"
        Me.EBookPath.FieldName = "EBookPath"
        Me.EBookPath.Name = "EBookPath"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem_OrderDetail, Me.BarButtonItem1_Documents, Me.BarButtonItem1_OrderSets, Me.BarButtonItem1_OrderItems, BarStaticItem1_divider, Me.BarStaticItem2, Me.BarButtonItem1_PublisherPOs, Me.BarSubItem1, Me.BarButtonItem1_CreateQuote, Me.BarButtonItem2_CreateQuote, Me.BarButtonItem1_CustomerInvoiceOrderSets, Me.BarButtonItem1_CustomerInvoiceOrderItems, Me.BarButtonItem1_CustomerPackingSlip, Me.BarButtonItem1_ViewBook, Me.BarButtonItem1_ViewCover, Me.BarButtonItem1_EBookSales, Me.BarStaticItem1, Me.BarButtonItem1_PublisherCheckIn, Me.BarButtonItem1_PubInvoiceDetail, Me.BarButtonItem1_Divider1, Me.BarButtonItem1, Me.BarButtonItem2_PubInvoiceDocs})
        Me.BarManager1.MaxItemId = 22
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
        Me.BarButtonItem1_OrderSets.Caption = "Order Sets (Cust. PO)"
        Me.BarButtonItem1_OrderSets.Id = 2
        Me.BarButtonItem1_OrderSets.Name = "BarButtonItem1_OrderSets"
        '
        'BarButtonItem1_OrderItems
        '
        Me.BarButtonItem1_OrderItems.Caption = "Order Items (Pub. PO)"
        Me.BarButtonItem1_OrderItems.Id = 3
        Me.BarButtonItem1_OrderItems.Name = "BarButtonItem1_OrderItems"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Id = 5
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarButtonItem1_PublisherPOs
        '
        Me.BarButtonItem1_PublisherPOs.Caption = "Create Publisher POs"
        Me.BarButtonItem1_PublisherPOs.Id = 6
        Me.BarButtonItem1_PublisherPOs.Name = "BarButtonItem1_PublisherPOs"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Reports/Quotes/Invoices"
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_PublisherPOs), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_PublisherCheckIn), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem2_CreateQuote, False), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_CustomerInvoiceOrderSets), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_CustomerInvoiceOrderItems), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_CustomerPackingSlip)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1_PublisherCheckIn
        '
        Me.BarButtonItem1_PublisherCheckIn.Caption = "Create Publisher 'Check In'"
        Me.BarButtonItem1_PublisherCheckIn.Id = 17
        Me.BarButtonItem1_PublisherCheckIn.Name = "BarButtonItem1_PublisherCheckIn"
        '
        'BarButtonItem2_CreateQuote
        '
        Me.BarButtonItem2_CreateQuote.Caption = "Create Quote"
        Me.BarButtonItem2_CreateQuote.Id = 9
        Me.BarButtonItem2_CreateQuote.Name = "BarButtonItem2_CreateQuote"
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
        'BarButtonItem1_CustomerPackingSlip
        '
        Me.BarButtonItem1_CustomerPackingSlip.Caption = "Create Customer Packing Slip"
        Me.BarButtonItem1_CustomerPackingSlip.Id = 12
        Me.BarButtonItem1_CustomerPackingSlip.Name = "BarButtonItem1_CustomerPackingSlip"
        '
        'BarButtonItem1_CreateQuote
        '
        Me.BarButtonItem1_CreateQuote.Caption = "Create Customer Quote"
        Me.BarButtonItem1_CreateQuote.Id = 8
        Me.BarButtonItem1_CreateQuote.Name = "BarButtonItem1_CreateQuote"
        '
        'BarButtonItem1_ViewBook
        '
        Me.BarButtonItem1_ViewBook.Caption = "View eBook"
        Me.BarButtonItem1_ViewBook.Id = 13
        Me.BarButtonItem1_ViewBook.Name = "BarButtonItem1_ViewBook"
        '
        'BarButtonItem1_ViewCover
        '
        Me.BarButtonItem1_ViewCover.Caption = "View Book Cover"
        Me.BarButtonItem1_ViewCover.Id = 14
        Me.BarButtonItem1_ViewCover.Name = "BarButtonItem1_ViewCover"
        '
        'BarButtonItem1_EBookSales
        '
        Me.BarButtonItem1_EBookSales.Caption = "eBook Sales"
        Me.BarButtonItem1_EBookSales.Id = 15
        Me.BarButtonItem1_EBookSales.Name = "BarButtonItem1_EBookSales"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 16
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarButtonItem1_PubInvoiceDetail
        '
        Me.BarButtonItem1_PubInvoiceDetail.Caption = "Edit Pub Invoice"
        Me.BarButtonItem1_PubInvoiceDetail.Id = 18
        Me.BarButtonItem1_PubInvoiceDetail.Name = "BarButtonItem1_PubInvoiceDetail"
        '
        'BarButtonItem1_Divider1
        '
        Me.BarButtonItem1_Divider1.Id = 19
        Me.BarButtonItem1_Divider1.Name = "BarButtonItem1_Divider1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = 20
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2_PubInvoiceDocs
        '
        Me.BarButtonItem2_PubInvoiceDocs.Caption = "Documents - Pub Invoices"
        Me.BarButtonItem2_PubInvoiceDocs.Id = 21
        Me.BarButtonItem2_PubInvoiceDocs.Name = "BarButtonItem2_PubInvoiceDocs"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(4, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1244, 60)
        Me.Panel2.TabIndex = 6
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
        Me.cmdMetaImport.Location = New System.Drawing.Point(1022, 26)
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
        Me.PopupMenu_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem_OrderDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_Documents), New DevExpress.XtraBars.LinkPersistInfo(BarStaticItem1_divider), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_OrderSets), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_OrderItems), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_EBookSales)})
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
        'OmqryOrdersMainTableAdapter1
        '
        Me.OmqryOrdersMainTableAdapter1.ClearBeforeFill = True
        '
        'DiBS_DB_ProdDataSet5
        '
        Me.DiBS_DB_ProdDataSet5.DataSetName = "DiBS_DB_ProdDataSet5"
        Me.DiBS_DB_ProdDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OmMetaDataBindingSource
        '
        Me.OmMetaDataBindingSource.DataMember = "omMetaData"
        Me.OmMetaDataBindingSource.DataSource = Me.DiBS_DB_ProdDataSet5
        '
        'OmMetaDataTableAdapter
        '
        Me.OmMetaDataTableAdapter.ClearBeforeFill = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_ViewBook), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_ViewCover)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_PubInvoiceDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_Divider1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2_PubInvoiceDocs), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1255, 812)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2_Orders.ResumeLayout(False)
        CType(Me.gridOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiBS_DB_ProdDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.XtraTabPage1_PubInvoiceTracker.ResumeLayout(False)
        CType(Me.gridPubInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.XtraTabPage3_MetaSearch.ResumeLayout(False)
        CType(Me.GridMetaSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1_MetaData.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiBS_DB_ProdDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmMetaDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BarButtonItem1_CustomerPackingSlip As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShipTo_ATTN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRefreshGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage3_MetaSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridMetaSearch As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DiBS_DB_ProdDataSet5 As DiBS_DB_ProdDataSet5
    Friend WithEvents OmMetaDataBindingSource As BindingSource
    Friend WithEvents OmMetaDataTableAdapter As DiBS_DB_ProdDataSet5TableAdapters.omMetaDataTableAdapter
    Friend WithEvents colMetaDataID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartnerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPublisherName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaperback_ISBN_13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaperback_List_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuided_Reading_Level As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLexile_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLexile_Text As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHardcover_Print_ISBN_13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHardcover_Print_List_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleBook_ISBN_13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleBook_List_Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImprint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPage_Count As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAge_Level_Start As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAge_Level_End As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterest_Level_Start As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterest_Level_End As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReading_Level_Start As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReading_Level_End As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDewey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBISAC_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBISAC_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBISAC_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrade_Level As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuthor_First_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuthor_Middle_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuthor_Last_Name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCopyright As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeries_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeries_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenre_Interest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeywords As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitleDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OfficialImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EBookPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents BarButtonItem1_ViewBook As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1_ViewCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_EBookSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1_PublisherCheckIn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExportOrdersGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage1_PubInvoiceTracker As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridPubInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PubPaymentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartnerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PublisherName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PublisherInvoiceNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvoiceAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NetTermDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PlanToPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DatePaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmdAddPubInvoices As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefreshPubInvoicesGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMarkPubInvoicesPaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem1_PubInvoiceDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1_Divider1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2_PubInvoiceDocs As DevExpress.XtraBars.BarButtonItem
End Class
