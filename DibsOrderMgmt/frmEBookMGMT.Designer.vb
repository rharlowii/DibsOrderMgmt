<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEBookMGMT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkCreateViewerForAllDisitrictSchools = New System.Windows.Forms.CheckBox()
        Me.cmbViewerBrand = New System.Windows.Forms.ComboBox()
        Me.cmdViewerForSchool = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbSchools2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbDistricts2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStates2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdDuplicateSchool = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSchoolID = New System.Windows.Forms.TextBox()
        Me.txtDistrictID = New System.Windows.Forms.TextBox()
        Me.chkShowOnlySchoolsWBooks = New System.Windows.Forms.CheckBox()
        Me.chkAnyPartOfSchoolName = New System.Windows.Forms.CheckBox()
        Me.lblSchools = New System.Windows.Forms.Label()
        Me.lblDistricts = New System.Windows.Forms.Label()
        Me.lblStates = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.mainTab = New DevExpress.XtraTab.XtraTabPage()
        Me.gridSchoolBooks = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PublisherID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SchoolID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ISBN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Title = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GuidedReadingLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsFiction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OfficialImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EBookPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsExternal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QuantityType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CreateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BookSchoolsID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdDeleteSelectedBooks = New System.Windows.Forms.Button()
        Me.cmdGetSchoolBooks = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gridSchoolUsers = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DistrictID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RoleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LoginID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.First = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Last = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Password = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APIKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdDeleteSelectedUsers = New System.Windows.Forms.Button()
        Me.cmdAddSchoolUser = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGetSchoolUsers = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage1_AddByISBNFile = New DevExpress.XtraTab.XtraTabPage()
        Me.txtSchoolIDs = New System.Windows.Forms.TextBox()
        Me.dgv_ImportBooksInSchool = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkIgnoreISBNCheck = New System.Windows.Forms.CheckBox()
        Me.chkEBooks = New System.Windows.Forms.CheckBox()
        Me.chk_AddBookToSchool = New System.Windows.Forms.CheckBox()
        Me.chk_ISSixPack = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbISBNCol = New System.Windows.Forms.ComboBox()
        Me.cmd_FileSelect2 = New System.Windows.Forms.Button()
        Me.txtFile_SchoolByISBN = New System.Windows.Forms.TextBox()
        Me.cmdAddBooksToSchool = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage1_AddBookFreeForm = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.chkIgnoreISBNCheckFree = New System.Windows.Forms.CheckBox()
        Me.chk_AddBookToSchoolFree = New System.Windows.Forms.CheckBox()
        Me.cmdClearOrderItemsFreeForm = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddOrderItemsFreeForm = New DevExpress.XtraEditors.SimpleButton()
        Me.spreadAddFreeForm = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1_ViewBook = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_ViewCover = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3_ViewBook = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1_ReplaceBookCover = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_EditUser = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1_AddNewUser = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3_ViewCover = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4_ViewBook = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4_ViewCover = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4_ReplaceBookCover = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.XtraTabPage1_CollectionsAdd = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1_AddCollectionsToSchool = New DevExpress.XtraTab.XtraTabPage()
        Me.lstvw_Collections = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantityTypeCollection = New System.Windows.Forms.TextBox()
        Me.cmd_AddCollections = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage1_AddItemsToCollection = New DevExpress.XtraTab.XtraTabPage()
        Me.dgv_CollectionBooksImport = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdAddBooksToCollection = New System.Windows.Forms.Button()
        Me.chkIgnoreISBNCollection = New System.Windows.Forms.CheckBox()
        Me.chkAddToCollection = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbISBNCol2 = New System.Windows.Forms.ComboBox()
        Me.cmdLoadCollectionBooks = New System.Windows.Forms.Button()
        Me.txtCollectionsBooksFile = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbIsSixPackCollection = New System.Windows.Forms.ComboBox()
        Me.cmdAddColletion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.txtItemNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCompanyCollections = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPublisherLine = New System.Windows.Forms.ComboBox()
        Me.XtraTabPage1_eBooks = New DevExpress.XtraTab.XtraTabPage()
        Me.gridDiBSBooks = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsAudioAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsEPub = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.XtraTabPage1_UploadeBookCovers = New DevExpress.XtraTab.XtraTabPage()
        Me.chkIfBookImageExists = New System.Windows.Forms.CheckBox()
        Me.chkUploadCoversIngonreISBN = New System.Windows.Forms.CheckBox()
        Me.cmdUpLoadCoverImages = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUploadCoverImagesDir = New System.Windows.Forms.TextBox()
        Me.XtraTabPage1_AddEBookMeta = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cmdAddBookMeta = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.cmdloadAddBookFile = New System.Windows.Forms.Button()
        Me.chkUpdateMetaData = New System.Windows.Forms.CheckBox()
        Me.chkAddBookMeta_SkipISBNCheck = New System.Windows.Forms.CheckBox()
        Me.chkAddBookAddTag = New System.Windows.Forms.CheckBox()
        Me.cmbAddBookTagType = New System.Windows.Forms.ComboBox()
        Me.chkAddBookSimulation = New System.Windows.Forms.CheckBox()
        Me.txtAddBookFileNae = New System.Windows.Forms.TextBox()
        Me.dgv_ImportAddBookMeta = New System.Windows.Forms.DataGridView()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenu3 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdGenerateWelcomeEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbSchools2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDistricts2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStates2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.mainTab.SuspendLayout()
        CType(Me.gridSchoolBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gridSchoolUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.XtraTabPage1_AddByISBNFile.SuspendLayout()
        CType(Me.dgv_ImportBooksInSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage1_AddBookFreeForm.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1_CollectionsAdd.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1_AddCollectionsToSchool.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.XtraTabPage1_AddItemsToCollection.SuspendLayout()
        CType(Me.dgv_CollectionBooksImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.XtraTabPage1_eBooks.SuspendLayout()
        CType(Me.gridDiBSBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1_UploadeBookCovers.SuspendLayout()
        Me.XtraTabPage1_AddEBookMeta.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dgv_ImportAddBookMeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdGenerateWelcomeEmail)
        Me.Panel1.Controls.Add(Me.chkCreateViewerForAllDisitrictSchools)
        Me.Panel1.Controls.Add(Me.cmbViewerBrand)
        Me.Panel1.Controls.Add(Me.cmdViewerForSchool)
        Me.Panel1.Controls.Add(Me.cmbSchools2)
        Me.Panel1.Controls.Add(Me.cmbDistricts2)
        Me.Panel1.Controls.Add(Me.cmbStates2)
        Me.Panel1.Controls.Add(Me.cmdDuplicateSchool)
        Me.Panel1.Controls.Add(Me.txtSchoolID)
        Me.Panel1.Controls.Add(Me.txtDistrictID)
        Me.Panel1.Controls.Add(Me.chkShowOnlySchoolsWBooks)
        Me.Panel1.Controls.Add(Me.chkAnyPartOfSchoolName)
        Me.Panel1.Controls.Add(Me.lblSchools)
        Me.Panel1.Controls.Add(Me.lblDistricts)
        Me.Panel1.Controls.Add(Me.lblStates)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 97)
        Me.Panel1.TabIndex = 1
        '
        'chkCreateViewerForAllDisitrictSchools
        '
        Me.chkCreateViewerForAllDisitrictSchools.AutoSize = True
        Me.chkCreateViewerForAllDisitrictSchools.Checked = True
        Me.chkCreateViewerForAllDisitrictSchools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCreateViewerForAllDisitrictSchools.Location = New System.Drawing.Point(1040, 12)
        Me.chkCreateViewerForAllDisitrictSchools.Name = "chkCreateViewerForAllDisitrictSchools"
        Me.chkCreateViewerForAllDisitrictSchools.Size = New System.Drawing.Size(184, 17)
        Me.chkCreateViewerForAllDisitrictSchools.TabIndex = 54
        Me.chkCreateViewerForAllDisitrictSchools.Text = "Create Viewer URL for all schools"
        Me.chkCreateViewerForAllDisitrictSchools.UseVisualStyleBackColor = True
        '
        'cmbViewerBrand
        '
        Me.cmbViewerBrand.FormattingEnabled = True
        Me.cmbViewerBrand.Items.AddRange(New Object() {"Brain Hive", "DiBS", "Pacific", "Rourke", "Crabtree"})
        Me.cmbViewerBrand.Location = New System.Drawing.Point(898, 10)
        Me.cmbViewerBrand.Name = "cmbViewerBrand"
        Me.cmbViewerBrand.Size = New System.Drawing.Size(136, 21)
        Me.cmbViewerBrand.TabIndex = 53
        Me.cmbViewerBrand.Text = "Brain Hive"
        '
        'cmdViewerForSchool
        '
        Me.cmdViewerForSchool.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewerForSchool.Appearance.Options.UseFont = True
        Me.cmdViewerForSchool.Location = New System.Drawing.Point(698, 9)
        Me.cmdViewerForSchool.Name = "cmdViewerForSchool"
        Me.cmdViewerForSchool.Size = New System.Drawing.Size(194, 28)
        Me.cmdViewerForSchool.TabIndex = 52
        Me.cmdViewerForSchool.Text = "Viewer for School"
        Me.cmdViewerForSchool.ToolTip = "a"
        '
        'cmbSchools2
        '
        Me.cmbSchools2.EditValue = ""
        Me.cmbSchools2.Location = New System.Drawing.Point(55, 70)
        Me.cmbSchools2.Name = "cmbSchools2"
        Me.cmbSchools2.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbSchools2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSchools2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")})
        Me.cmbSchools2.Properties.DisplayMember = "Name"
        Me.cmbSchools2.Properties.EditValueChangedDelay = 1
        Me.cmbSchools2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbSchools2.Properties.NullText = ""
        Me.cmbSchools2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbSchools2.Properties.SortColumnIndex = 1
        Me.cmbSchools2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbSchools2.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbSchools2.Properties.ValidateOnEnterKey = True
        Me.cmbSchools2.Properties.ValueMember = "ID"
        Me.cmbSchools2.Size = New System.Drawing.Size(278, 20)
        Me.cmbSchools2.TabIndex = 2
        '
        'cmbDistricts2
        '
        Me.cmbDistricts2.EditValue = ""
        Me.cmbDistricts2.Location = New System.Drawing.Point(55, 43)
        Me.cmbDistricts2.Name = "cmbDistricts2"
        Me.cmbDistricts2.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbDistricts2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDistricts2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")})
        Me.cmbDistricts2.Properties.DisplayMember = "Name"
        Me.cmbDistricts2.Properties.EditValueChangedDelay = 1
        Me.cmbDistricts2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbDistricts2.Properties.NullText = ""
        Me.cmbDistricts2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbDistricts2.Properties.SortColumnIndex = 1
        Me.cmbDistricts2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDistricts2.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbDistricts2.Properties.ValidateOnEnterKey = True
        Me.cmbDistricts2.Properties.ValueMember = "ID"
        Me.cmbDistricts2.Size = New System.Drawing.Size(278, 20)
        Me.cmbDistricts2.TabIndex = 1
        '
        'cmbStates2
        '
        Me.cmbStates2.EditValue = ""
        Me.cmbStates2.Location = New System.Drawing.Point(53, 7)
        Me.cmbStates2.Name = "cmbStates2"
        Me.cmbStates2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStates2.Properties.ValidateOnEnterKey = True
        Me.cmbStates2.Size = New System.Drawing.Size(278, 20)
        Me.cmbStates2.TabIndex = 0
        '
        'cmdDuplicateSchool
        '
        Me.cmdDuplicateSchool.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDuplicateSchool.Appearance.Options.UseFont = True
        Me.cmdDuplicateSchool.Location = New System.Drawing.Point(568, 69)
        Me.cmdDuplicateSchool.Name = "cmdDuplicateSchool"
        Me.cmdDuplicateSchool.Size = New System.Drawing.Size(194, 21)
        Me.cmdDuplicateSchool.TabIndex = 4
        Me.cmdDuplicateSchool.Text = "Duplicate School?"
        '
        'txtSchoolID
        '
        Me.txtSchoolID.Location = New System.Drawing.Point(339, 70)
        Me.txtSchoolID.Name = "txtSchoolID"
        Me.txtSchoolID.Size = New System.Drawing.Size(223, 20)
        Me.txtSchoolID.TabIndex = 31
        Me.txtSchoolID.TabStop = False
        '
        'txtDistrictID
        '
        Me.txtDistrictID.Location = New System.Drawing.Point(339, 41)
        Me.txtDistrictID.Name = "txtDistrictID"
        Me.txtDistrictID.Size = New System.Drawing.Size(223, 20)
        Me.txtDistrictID.TabIndex = 30
        Me.txtDistrictID.TabStop = False
        '
        'chkShowOnlySchoolsWBooks
        '
        Me.chkShowOnlySchoolsWBooks.AutoSize = True
        Me.chkShowOnlySchoolsWBooks.Location = New System.Drawing.Point(339, 9)
        Me.chkShowOnlySchoolsWBooks.Name = "chkShowOnlySchoolsWBooks"
        Me.chkShowOnlySchoolsWBooks.Size = New System.Drawing.Size(173, 17)
        Me.chkShowOnlySchoolsWBooks.TabIndex = 50
        Me.chkShowOnlySchoolsWBooks.TabStop = False
        Me.chkShowOnlySchoolsWBooks.Text = "Show Only Schools with Books"
        Me.chkShowOnlySchoolsWBooks.UseVisualStyleBackColor = True
        '
        'chkAnyPartOfSchoolName
        '
        Me.chkAnyPartOfSchoolName.AutoSize = True
        Me.chkAnyPartOfSchoolName.Checked = True
        Me.chkAnyPartOfSchoolName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAnyPartOfSchoolName.Location = New System.Drawing.Point(1040, 35)
        Me.chkAnyPartOfSchoolName.Name = "chkAnyPartOfSchoolName"
        Me.chkAnyPartOfSchoolName.Size = New System.Drawing.Size(176, 17)
        Me.chkAnyPartOfSchoolName.TabIndex = 51
        Me.chkAnyPartOfSchoolName.TabStop = False
        Me.chkAnyPartOfSchoolName.Text = "Search any part of school name"
        Me.chkAnyPartOfSchoolName.UseVisualStyleBackColor = False
        '
        'lblSchools
        '
        Me.lblSchools.AutoSize = True
        Me.lblSchools.Location = New System.Drawing.Point(6, 69)
        Me.lblSchools.Name = "lblSchools"
        Me.lblSchools.Size = New System.Drawing.Size(48, 13)
        Me.lblSchools.TabIndex = 15
        Me.lblSchools.Text = "Schools:"
        '
        'lblDistricts
        '
        Me.lblDistricts.AutoSize = True
        Me.lblDistricts.Location = New System.Drawing.Point(6, 42)
        Me.lblDistricts.Name = "lblDistricts"
        Me.lblDistricts.Size = New System.Drawing.Size(47, 13)
        Me.lblDistricts.TabIndex = 14
        Me.lblDistricts.Text = "Districts:"
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.Location = New System.Drawing.Point(7, 6)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(40, 13)
        Me.lblStates.TabIndex = 13
        Me.lblStates.Text = "States:"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 106)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.mainTab
        Me.XtraTabControl1.Size = New System.Drawing.Size(1242, 727)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.mainTab, Me.XtraTabPage2, Me.XtraTabPage1_AddByISBNFile, Me.XtraTabPage1_AddBookFreeForm, Me.XtraTabPage1_CollectionsAdd, Me.XtraTabPage1_eBooks, Me.XtraTabPage1_UploadeBookCovers, Me.XtraTabPage1_AddEBookMeta})
        '
        'mainTab
        '
        Me.mainTab.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.mainTab.Appearance.PageClient.BackColor2 = System.Drawing.Color.White
        Me.mainTab.Appearance.PageClient.Options.UseBackColor = True
        Me.mainTab.Controls.Add(Me.gridSchoolBooks)
        Me.mainTab.Controls.Add(Me.Panel3)
        Me.mainTab.Name = "mainTab"
        Me.mainTab.Size = New System.Drawing.Size(1240, 692)
        Me.mainTab.Text = "School Books"
        '
        'gridSchoolBooks
        '
        Me.gridSchoolBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSchoolBooks.DataMember = "omqryOrdersMain"
        Me.gridSchoolBooks.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSchoolBooks.Location = New System.Drawing.Point(-2, 69)
        Me.gridSchoolBooks.MainView = Me.GridView3
        Me.gridSchoolBooks.Name = "gridSchoolBooks"
        Me.gridSchoolBooks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemTextEdit1})
        Me.gridSchoolBooks.Size = New System.Drawing.Size(1244, 554)
        Me.gridSchoolBooks.TabIndex = 9
        Me.gridSchoolBooks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.PublisherID, Me.SchoolID, Me.colName, Me.ISBN, Me.Title, Me.GuidedReadingLevel, Me.LEX, Me.IsFiction, Me.OfficialImage, Me.EBookPath, Me.IsExternal, Me.QuantityType, Me.Description, Me.CreateTime, Me.BookSchoolsID})
        Me.GridView3.GridControl = Me.gridSchoolBooks
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'PublisherID
        '
        Me.PublisherID.Caption = "PublisherID"
        Me.PublisherID.FieldName = "PublisherID"
        Me.PublisherID.Name = "PublisherID"
        '
        'SchoolID
        '
        Me.SchoolID.Caption = "SchoolID"
        Me.SchoolID.FieldName = "SchoolID"
        Me.SchoolID.Name = "SchoolID"
        '
        'colName
        '
        Me.colName.Caption = "Publisher Name"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowEdit = False
        Me.colName.Tag = "frmEBookMGMT3"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        Me.colName.Width = 101
        '
        'ISBN
        '
        Me.ISBN.Caption = "ISBN"
        Me.ISBN.FieldName = "ISBN"
        Me.ISBN.Name = "ISBN"
        Me.ISBN.OptionsColumn.AllowEdit = False
        Me.ISBN.Visible = True
        Me.ISBN.VisibleIndex = 0
        Me.ISBN.Width = 101
        '
        'Title
        '
        Me.Title.Caption = "Title"
        Me.Title.FieldName = "Title"
        Me.Title.Name = "Title"
        Me.Title.Visible = True
        Me.Title.VisibleIndex = 2
        Me.Title.Width = 101
        '
        'GuidedReadingLevel
        '
        Me.GuidedReadingLevel.Caption = "GRL"
        Me.GuidedReadingLevel.FieldName = "GuidedReadingLevel"
        Me.GuidedReadingLevel.Name = "GuidedReadingLevel"
        Me.GuidedReadingLevel.Visible = True
        Me.GuidedReadingLevel.VisibleIndex = 4
        '
        'LEX
        '
        Me.LEX.Caption = "LEX"
        Me.LEX.FieldName = "LEX"
        Me.LEX.Name = "LEX"
        Me.LEX.Visible = True
        Me.LEX.VisibleIndex = 3
        '
        'IsFiction
        '
        Me.IsFiction.Caption = "IsFiction"
        Me.IsFiction.FieldName = "IsFiction"
        Me.IsFiction.Name = "IsFiction"
        Me.IsFiction.Visible = True
        Me.IsFiction.VisibleIndex = 5
        '
        'OfficialImage
        '
        Me.OfficialImage.Caption = "OfficialImage"
        Me.OfficialImage.FieldName = "OfficialImage"
        Me.OfficialImage.Name = "OfficialImage"
        Me.OfficialImage.Visible = True
        Me.OfficialImage.VisibleIndex = 9
        '
        'EBookPath
        '
        Me.EBookPath.Caption = "EBookPath"
        Me.EBookPath.FieldName = "EBookPath"
        Me.EBookPath.Name = "EBookPath"
        Me.EBookPath.Visible = True
        Me.EBookPath.VisibleIndex = 6
        '
        'IsExternal
        '
        Me.IsExternal.Caption = "IsExternal"
        Me.IsExternal.FieldName = "IsExternal"
        Me.IsExternal.Name = "IsExternal"
        Me.IsExternal.Visible = True
        Me.IsExternal.VisibleIndex = 7
        '
        'QuantityType
        '
        Me.QuantityType.Caption = "QuantityType"
        Me.QuantityType.FieldName = "QuantityType"
        Me.QuantityType.Name = "QuantityType"
        Me.QuantityType.Visible = True
        Me.QuantityType.VisibleIndex = 8
        '
        'Description
        '
        Me.Description.Caption = "Description"
        Me.Description.FieldName = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 12
        '
        'CreateTime
        '
        Me.CreateTime.Caption = "CreateTime"
        Me.CreateTime.DisplayFormat.FormatString = "d"
        Me.CreateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CreateTime.FieldName = "CreateTime"
        Me.CreateTime.Name = "CreateTime"
        Me.CreateTime.Visible = True
        Me.CreateTime.VisibleIndex = 10
        '
        'BookSchoolsID
        '
        Me.BookSchoolsID.Caption = "BookSchoolsID"
        Me.BookSchoolsID.FieldName = "BookSchoolsID"
        Me.BookSchoolsID.Name = "BookSchoolsID"
        Me.BookSchoolsID.Visible = True
        Me.BookSchoolsID.VisibleIndex = 11
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cmdDeleteSelectedBooks)
        Me.Panel3.Controls.Add(Me.cmdGetSchoolBooks)
        Me.Panel3.Location = New System.Drawing.Point(6, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1231, 55)
        Me.Panel3.TabIndex = 3
        '
        'cmdDeleteSelectedBooks
        '
        Me.cmdDeleteSelectedBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDeleteSelectedBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteSelectedBooks.ForeColor = System.Drawing.Color.Red
        Me.cmdDeleteSelectedBooks.Location = New System.Drawing.Point(796, 14)
        Me.cmdDeleteSelectedBooks.Name = "cmdDeleteSelectedBooks"
        Me.cmdDeleteSelectedBooks.Size = New System.Drawing.Size(241, 32)
        Me.cmdDeleteSelectedBooks.TabIndex = 35
        Me.cmdDeleteSelectedBooks.Text = "Delete Selected Books"
        Me.cmdDeleteSelectedBooks.UseVisualStyleBackColor = True
        '
        'cmdGetSchoolBooks
        '
        Me.cmdGetSchoolBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGetSchoolBooks.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetSchoolBooks.Appearance.Options.UseFont = True
        Me.cmdGetSchoolBooks.Location = New System.Drawing.Point(1043, 14)
        Me.cmdGetSchoolBooks.Name = "cmdGetSchoolBooks"
        Me.cmdGetSchoolBooks.Size = New System.Drawing.Size(175, 28)
        Me.cmdGetSchoolBooks.TabIndex = 5
        Me.cmdGetSchoolBooks.Text = "Get School Books"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Controls.Add(Me.gridSchoolUsers)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage2.Text = "School Users"
        '
        'gridSchoolUsers
        '
        Me.gridSchoolUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSchoolUsers.DataMember = "omqryOrdersMain"
        Me.gridSchoolUsers.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSchoolUsers.Location = New System.Drawing.Point(-2, 64)
        Me.gridSchoolUsers.MainView = Me.GridView1
        Me.gridSchoolUsers.Name = "gridSchoolUsers"
        Me.gridSchoolUsers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2})
        Me.gridSchoolUsers.Size = New System.Drawing.Size(1244, 608)
        Me.gridSchoolUsers.TabIndex = 10
        Me.gridSchoolUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.DistrictID, Me.GridColumn3, Me.RoleName, Me.LoginID, Me.First, Me.Last, Me.Password, Me.Email, Me.APIKey, Me.GridColumn15})
        Me.GridView1.GridControl = Me.gridSchoolUsers
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'DistrictID
        '
        Me.DistrictID.Caption = "DistrictID"
        Me.DistrictID.FieldName = "DistrictID"
        Me.DistrictID.Name = "DistrictID"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "SchoolID"
        Me.GridColumn3.FieldName = "SchoolID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'RoleName
        '
        Me.RoleName.Caption = "Role"
        Me.RoleName.FieldName = "RoleName"
        Me.RoleName.Name = "RoleName"
        Me.RoleName.Visible = True
        Me.RoleName.VisibleIndex = 0
        '
        'LoginID
        '
        Me.LoginID.Caption = "LoginID"
        Me.LoginID.FieldName = "LoginID"
        Me.LoginID.Name = "LoginID"
        Me.LoginID.Visible = True
        Me.LoginID.VisibleIndex = 1
        '
        'First
        '
        Me.First.Caption = "First"
        Me.First.FieldName = "First"
        Me.First.Name = "First"
        Me.First.OptionsColumn.AllowEdit = False
        Me.First.Visible = True
        Me.First.VisibleIndex = 2
        Me.First.Width = 101
        '
        'Last
        '
        Me.Last.Caption = "Last"
        Me.Last.FieldName = "Last"
        Me.Last.Name = "Last"
        Me.Last.Visible = True
        Me.Last.VisibleIndex = 3
        Me.Last.Width = 101
        '
        'Password
        '
        Me.Password.Caption = "Password"
        Me.Password.FieldName = "Password"
        Me.Password.Name = "Password"
        Me.Password.Visible = True
        Me.Password.VisibleIndex = 4
        '
        'Email
        '
        Me.Email.Caption = "Email"
        Me.Email.FieldName = "Email"
        Me.Email.Name = "Email"
        Me.Email.OptionsColumn.AllowEdit = False
        Me.Email.Visible = True
        Me.Email.VisibleIndex = 5
        Me.Email.Width = 101
        '
        'APIKey
        '
        Me.APIKey.Caption = "APIKey"
        Me.APIKey.FieldName = "APIKey"
        Me.APIKey.Name = "APIKey"
        Me.APIKey.Visible = True
        Me.APIKey.VisibleIndex = 6
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "CreateTime"
        Me.GridColumn15.DisplayFormat.FormatString = "d"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn15.FieldName = "CreateTime"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 7
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmdDeleteSelectedUsers)
        Me.Panel2.Controls.Add(Me.cmdAddSchoolUser)
        Me.Panel2.Controls.Add(Me.cmdGetSchoolUsers)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1237, 55)
        Me.Panel2.TabIndex = 5
        '
        'cmdDeleteSelectedUsers
        '
        Me.cmdDeleteSelectedUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDeleteSelectedUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteSelectedUsers.ForeColor = System.Drawing.Color.Red
        Me.cmdDeleteSelectedUsers.Location = New System.Drawing.Point(620, 14)
        Me.cmdDeleteSelectedUsers.Name = "cmdDeleteSelectedUsers"
        Me.cmdDeleteSelectedUsers.Size = New System.Drawing.Size(241, 28)
        Me.cmdDeleteSelectedUsers.TabIndex = 36
        Me.cmdDeleteSelectedUsers.Text = "Delete Selected Users"
        Me.cmdDeleteSelectedUsers.UseVisualStyleBackColor = True
        '
        'cmdAddSchoolUser
        '
        Me.cmdAddSchoolUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddSchoolUser.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddSchoolUser.Appearance.Options.UseFont = True
        Me.cmdAddSchoolUser.Location = New System.Drawing.Point(867, 14)
        Me.cmdAddSchoolUser.Name = "cmdAddSchoolUser"
        Me.cmdAddSchoolUser.Size = New System.Drawing.Size(175, 28)
        Me.cmdAddSchoolUser.TabIndex = 6
        Me.cmdAddSchoolUser.Text = "Add User"
        '
        'cmdGetSchoolUsers
        '
        Me.cmdGetSchoolUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGetSchoolUsers.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetSchoolUsers.Appearance.Options.UseFont = True
        Me.cmdGetSchoolUsers.Location = New System.Drawing.Point(1048, 14)
        Me.cmdGetSchoolUsers.Name = "cmdGetSchoolUsers"
        Me.cmdGetSchoolUsers.Size = New System.Drawing.Size(175, 28)
        Me.cmdGetSchoolUsers.TabIndex = 5
        Me.cmdGetSchoolUsers.Text = "Get School Users"
        '
        'XtraTabPage1_AddByISBNFile
        '
        Me.XtraTabPage1_AddByISBNFile.Controls.Add(Me.txtSchoolIDs)
        Me.XtraTabPage1_AddByISBNFile.Controls.Add(Me.dgv_ImportBooksInSchool)
        Me.XtraTabPage1_AddByISBNFile.Controls.Add(Me.Panel4)
        Me.XtraTabPage1_AddByISBNFile.Name = "XtraTabPage1_AddByISBNFile"
        Me.XtraTabPage1_AddByISBNFile.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage1_AddByISBNFile.Text = "Add Books (File)"
        '
        'txtSchoolIDs
        '
        Me.txtSchoolIDs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSchoolIDs.Location = New System.Drawing.Point(977, 64)
        Me.txtSchoolIDs.Multiline = True
        Me.txtSchoolIDs.Name = "txtSchoolIDs"
        Me.txtSchoolIDs.Size = New System.Drawing.Size(260, 578)
        Me.txtSchoolIDs.TabIndex = 18
        '
        'dgv_ImportBooksInSchool
        '
        Me.dgv_ImportBooksInSchool.AllowUserToAddRows = False
        Me.dgv_ImportBooksInSchool.AllowUserToDeleteRows = False
        Me.dgv_ImportBooksInSchool.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ImportBooksInSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ImportBooksInSchool.Location = New System.Drawing.Point(3, 64)
        Me.dgv_ImportBooksInSchool.Name = "dgv_ImportBooksInSchool"
        Me.dgv_ImportBooksInSchool.ReadOnly = True
        Me.dgv_ImportBooksInSchool.Size = New System.Drawing.Size(962, 578)
        Me.dgv_ImportBooksInSchool.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.chkIgnoreISBNCheck)
        Me.Panel4.Controls.Add(Me.chkEBooks)
        Me.Panel4.Controls.Add(Me.chk_AddBookToSchool)
        Me.Panel4.Controls.Add(Me.chk_ISSixPack)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.cmbISBNCol)
        Me.Panel4.Controls.Add(Me.cmd_FileSelect2)
        Me.Panel4.Controls.Add(Me.txtFile_SchoolByISBN)
        Me.Panel4.Controls.Add(Me.cmdAddBooksToSchool)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1237, 55)
        Me.Panel4.TabIndex = 6
        '
        'chkIgnoreISBNCheck
        '
        Me.chkIgnoreISBNCheck.AutoSize = True
        Me.chkIgnoreISBNCheck.Location = New System.Drawing.Point(365, 32)
        Me.chkIgnoreISBNCheck.Name = "chkIgnoreISBNCheck"
        Me.chkIgnoreISBNCheck.Size = New System.Drawing.Size(121, 17)
        Me.chkIgnoreISBNCheck.TabIndex = 25
        Me.chkIgnoreISBNCheck.Text = "Ignore ISBN Check?"
        Me.chkIgnoreISBNCheck.UseVisualStyleBackColor = True
        '
        'chkEBooks
        '
        Me.chkEBooks.AutoSize = True
        Me.chkEBooks.Location = New System.Drawing.Point(365, 9)
        Me.chkEBooks.Name = "chkEBooks"
        Me.chkEBooks.Size = New System.Drawing.Size(65, 17)
        Me.chkEBooks.TabIndex = 24
        Me.chkEBooks.Text = "eBooks?"
        Me.chkEBooks.UseVisualStyleBackColor = True
        '
        'chk_AddBookToSchool
        '
        Me.chk_AddBookToSchool.AutoSize = True
        Me.chk_AddBookToSchool.Checked = True
        Me.chk_AddBookToSchool.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AddBookToSchool.Location = New System.Drawing.Point(244, 32)
        Me.chk_AddBookToSchool.Name = "chk_AddBookToSchool"
        Me.chk_AddBookToSchool.Size = New System.Drawing.Size(97, 17)
        Me.chk_AddBookToSchool.TabIndex = 23
        Me.chk_AddBookToSchool.Text = "Add to School?"
        Me.chk_AddBookToSchool.UseVisualStyleBackColor = True
        '
        'chk_ISSixPack
        '
        Me.chk_ISSixPack.AutoSize = True
        Me.chk_ISSixPack.Checked = True
        Me.chk_ISSixPack.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_ISSixPack.Location = New System.Drawing.Point(244, 9)
        Me.chk_ISSixPack.Name = "chk_ISSixPack"
        Me.chk_ISSixPack.Size = New System.Drawing.Size(75, 17)
        Me.chk_ISSixPack.TabIndex = 22
        Me.chk_ISSixPack.Text = "Six Packs?"
        Me.chk_ISSixPack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ISBN Column"
        '
        'cmbISBNCol
        '
        Me.cmbISBNCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbISBNCol.FormattingEnabled = True
        Me.cmbISBNCol.Location = New System.Drawing.Point(104, 9)
        Me.cmbISBNCol.Name = "cmbISBNCol"
        Me.cmbISBNCol.Size = New System.Drawing.Size(134, 21)
        Me.cmbISBNCol.TabIndex = 20
        '
        'cmd_FileSelect2
        '
        Me.cmd_FileSelect2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_FileSelect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_FileSelect2.Location = New System.Drawing.Point(930, 13)
        Me.cmd_FileSelect2.Name = "cmd_FileSelect2"
        Me.cmd_FileSelect2.Size = New System.Drawing.Size(35, 32)
        Me.cmd_FileSelect2.TabIndex = 19
        Me.cmd_FileSelect2.Text = "..."
        Me.cmd_FileSelect2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_FileSelect2.UseVisualStyleBackColor = True
        '
        'txtFile_SchoolByISBN
        '
        Me.txtFile_SchoolByISBN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile_SchoolByISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile_SchoolByISBN.Location = New System.Drawing.Point(529, 14)
        Me.txtFile_SchoolByISBN.Name = "txtFile_SchoolByISBN"
        Me.txtFile_SchoolByISBN.Size = New System.Drawing.Size(390, 26)
        Me.txtFile_SchoolByISBN.TabIndex = 18
        '
        'cmdAddBooksToSchool
        '
        Me.cmdAddBooksToSchool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddBooksToSchool.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddBooksToSchool.Appearance.Options.UseFont = True
        Me.cmdAddBooksToSchool.Location = New System.Drawing.Point(1005, 14)
        Me.cmdAddBooksToSchool.Name = "cmdAddBooksToSchool"
        Me.cmdAddBooksToSchool.Size = New System.Drawing.Size(218, 28)
        Me.cmdAddBooksToSchool.TabIndex = 5
        Me.cmdAddBooksToSchool.Text = "Add Books To School"
        '
        'XtraTabPage1_AddBookFreeForm
        '
        Me.XtraTabPage1_AddBookFreeForm.Controls.Add(Me.Panel7)
        Me.XtraTabPage1_AddBookFreeForm.Controls.Add(Me.spreadAddFreeForm)
        Me.XtraTabPage1_AddBookFreeForm.Name = "XtraTabPage1_AddBookFreeForm"
        Me.XtraTabPage1_AddBookFreeForm.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage1_AddBookFreeForm.Text = "Add Books (Free Form)"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.chkIgnoreISBNCheckFree)
        Me.Panel7.Controls.Add(Me.chk_AddBookToSchoolFree)
        Me.Panel7.Controls.Add(Me.cmdClearOrderItemsFreeForm)
        Me.Panel7.Controls.Add(Me.cmdAddOrderItemsFreeForm)
        Me.Panel7.Location = New System.Drawing.Point(0, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1237, 55)
        Me.Panel7.TabIndex = 7
        '
        'chkIgnoreISBNCheckFree
        '
        Me.chkIgnoreISBNCheckFree.AutoSize = True
        Me.chkIgnoreISBNCheckFree.Location = New System.Drawing.Point(129, 25)
        Me.chkIgnoreISBNCheckFree.Name = "chkIgnoreISBNCheckFree"
        Me.chkIgnoreISBNCheckFree.Size = New System.Drawing.Size(121, 17)
        Me.chkIgnoreISBNCheckFree.TabIndex = 84
        Me.chkIgnoreISBNCheckFree.Text = "Ignore ISBN Check?"
        Me.chkIgnoreISBNCheckFree.UseVisualStyleBackColor = True
        '
        'chk_AddBookToSchoolFree
        '
        Me.chk_AddBookToSchoolFree.AutoSize = True
        Me.chk_AddBookToSchoolFree.Checked = True
        Me.chk_AddBookToSchoolFree.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AddBookToSchoolFree.Location = New System.Drawing.Point(8, 25)
        Me.chk_AddBookToSchoolFree.Name = "chk_AddBookToSchoolFree"
        Me.chk_AddBookToSchoolFree.Size = New System.Drawing.Size(97, 17)
        Me.chk_AddBookToSchoolFree.TabIndex = 83
        Me.chk_AddBookToSchoolFree.Text = "Add to School?"
        Me.chk_AddBookToSchoolFree.UseVisualStyleBackColor = True
        '
        'cmdClearOrderItemsFreeForm
        '
        Me.cmdClearOrderItemsFreeForm.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearOrderItemsFreeForm.Appearance.Options.UseFont = True
        Me.cmdClearOrderItemsFreeForm.Location = New System.Drawing.Point(854, 15)
        Me.cmdClearOrderItemsFreeForm.Name = "cmdClearOrderItemsFreeForm"
        Me.cmdClearOrderItemsFreeForm.Size = New System.Drawing.Size(175, 28)
        Me.cmdClearOrderItemsFreeForm.TabIndex = 82
        Me.cmdClearOrderItemsFreeForm.Text = "Clear Order Items"
        '
        'cmdAddOrderItemsFreeForm
        '
        Me.cmdAddOrderItemsFreeForm.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddOrderItemsFreeForm.Appearance.Options.UseFont = True
        Me.cmdAddOrderItemsFreeForm.Location = New System.Drawing.Point(661, 15)
        Me.cmdAddOrderItemsFreeForm.Name = "cmdAddOrderItemsFreeForm"
        Me.cmdAddOrderItemsFreeForm.Size = New System.Drawing.Size(175, 28)
        Me.cmdAddOrderItemsFreeForm.TabIndex = 5
        Me.cmdAddOrderItemsFreeForm.Text = "Add Order Items"
        '
        'spreadAddFreeForm
        '
        Me.spreadAddFreeForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spreadAddFreeForm.Location = New System.Drawing.Point(3, 64)
        Me.spreadAddFreeForm.MenuManager = Me.BarManager1
        Me.spreadAddFreeForm.Name = "spreadAddFreeForm"
        Me.spreadAddFreeForm.Size = New System.Drawing.Size(1234, 618)
        Me.spreadAddFreeForm.TabIndex = 6
        Me.spreadAddFreeForm.Text = "SpreadsheetControl1"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1_ViewBook, Me.BarButtonItem1_ViewCover, Me.BarButtonItem3_ViewBook, Me.BarButtonItem1_ReplaceBookCover, Me.BarButtonItem1_EditUser, Me.BarButtonItem1_AddNewUser, Me.BarButtonItem3_ViewCover, Me.BarButtonItem4_ViewBook, Me.BarButtonItem4_ViewCover, Me.BarButtonItem4_ReplaceBookCover, Me.BarButtonItem3, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 12
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1256, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 834)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1256, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 834)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1256, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 834)
        '
        'BarButtonItem1_ViewBook
        '
        Me.BarButtonItem1_ViewBook.Caption = "View eBook"
        Me.BarButtonItem1_ViewBook.Id = 0
        Me.BarButtonItem1_ViewBook.Name = "BarButtonItem1_ViewBook"
        '
        'BarButtonItem1_ViewCover
        '
        Me.BarButtonItem1_ViewCover.Caption = "View Book Cover"
        Me.BarButtonItem1_ViewCover.Id = 1
        Me.BarButtonItem1_ViewCover.Name = "BarButtonItem1_ViewCover"
        '
        'BarButtonItem3_ViewBook
        '
        Me.BarButtonItem3_ViewBook.Caption = "View eBook"
        Me.BarButtonItem3_ViewBook.Id = 2
        Me.BarButtonItem3_ViewBook.Name = "BarButtonItem3_ViewBook"
        '
        'BarButtonItem1_ReplaceBookCover
        '
        Me.BarButtonItem1_ReplaceBookCover.Caption = "Replace Book Cover"
        Me.BarButtonItem1_ReplaceBookCover.Id = 3
        Me.BarButtonItem1_ReplaceBookCover.Name = "BarButtonItem1_ReplaceBookCover"
        '
        'BarButtonItem1_EditUser
        '
        Me.BarButtonItem1_EditUser.Caption = "Edit User"
        Me.BarButtonItem1_EditUser.Id = 4
        Me.BarButtonItem1_EditUser.Name = "BarButtonItem1_EditUser"
        '
        'BarButtonItem1_AddNewUser
        '
        Me.BarButtonItem1_AddNewUser.Caption = "Add New User"
        Me.BarButtonItem1_AddNewUser.Id = 5
        Me.BarButtonItem1_AddNewUser.Name = "BarButtonItem1_AddNewUser"
        '
        'BarButtonItem3_ViewCover
        '
        Me.BarButtonItem3_ViewCover.Caption = "BarButtonItem1"
        Me.BarButtonItem3_ViewCover.Id = 6
        Me.BarButtonItem3_ViewCover.Name = "BarButtonItem3_ViewCover"
        '
        'BarButtonItem4_ViewBook
        '
        Me.BarButtonItem4_ViewBook.Caption = "View eBook"
        Me.BarButtonItem4_ViewBook.Id = 7
        Me.BarButtonItem4_ViewBook.Name = "BarButtonItem4_ViewBook"
        '
        'BarButtonItem4_ViewCover
        '
        Me.BarButtonItem4_ViewCover.Caption = "View Book Cover"
        Me.BarButtonItem4_ViewCover.Id = 8
        Me.BarButtonItem4_ViewCover.Name = "BarButtonItem4_ViewCover"
        '
        'BarButtonItem4_ReplaceBookCover
        '
        Me.BarButtonItem4_ReplaceBookCover.Caption = "Replace Book Cover"
        Me.BarButtonItem4_ReplaceBookCover.Id = 9
        Me.BarButtonItem4_ReplaceBookCover.Name = "BarButtonItem4_ReplaceBookCover"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Id = 10
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = 11
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'XtraTabPage1_CollectionsAdd
        '
        Me.XtraTabPage1_CollectionsAdd.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage1_CollectionsAdd.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage1_CollectionsAdd.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1_CollectionsAdd.Name = "XtraTabPage1_CollectionsAdd"
        Me.XtraTabPage1_CollectionsAdd.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage1_CollectionsAdd.Text = "Add Collections to School"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.XtraTabControl2.Appearance.Options.UseBackColor = True
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.Location = New System.Drawing.Point(3, 190)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1_AddCollectionsToSchool
        Me.XtraTabControl2.Size = New System.Drawing.Size(1234, 433)
        Me.XtraTabControl2.TabIndex = 6
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1_AddCollectionsToSchool, Me.XtraTabPage1_AddItemsToCollection})
        '
        'XtraTabPage1_AddCollectionsToSchool
        '
        Me.XtraTabPage1_AddCollectionsToSchool.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage1_AddCollectionsToSchool.Appearance.PageClient.BackColor2 = System.Drawing.Color.White
        Me.XtraTabPage1_AddCollectionsToSchool.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1_AddCollectionsToSchool.Controls.Add(Me.lstvw_Collections)
        Me.XtraTabPage1_AddCollectionsToSchool.Controls.Add(Me.Panel5)
        Me.XtraTabPage1_AddCollectionsToSchool.Name = "XtraTabPage1_AddCollectionsToSchool"
        Me.XtraTabPage1_AddCollectionsToSchool.Size = New System.Drawing.Size(1232, 388)
        Me.XtraTabPage1_AddCollectionsToSchool.Text = "Add Collection to School"
        '
        'lstvw_Collections
        '
        Me.lstvw_Collections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvw_Collections.CheckBoxes = True
        Me.lstvw_Collections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstvw_Collections.HideSelection = False
        Me.lstvw_Collections.Location = New System.Drawing.Point(4, 54)
        Me.lstvw_Collections.Name = "lstvw_Collections"
        Me.lstvw_Collections.Size = New System.Drawing.Size(1229, 331)
        Me.lstvw_Collections.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstvw_Collections.TabIndex = 5
        Me.lstvw_Collections.UseCompatibleStateImageBehavior = False
        Me.lstvw_Collections.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item #"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Description"
        Me.ColumnHeader2.Width = 405
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Is Six Pack?"
        Me.ColumnHeader3.Width = 94
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtQuantityTypeCollection)
        Me.Panel5.Controls.Add(Me.cmd_AddCollections)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1230, 50)
        Me.Panel5.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Quantity Type"
        Me.Label7.Visible = False
        '
        'txtQuantityTypeCollection
        '
        Me.txtQuantityTypeCollection.Location = New System.Drawing.Point(101, 10)
        Me.txtQuantityTypeCollection.Name = "txtQuantityTypeCollection"
        Me.txtQuantityTypeCollection.Size = New System.Drawing.Size(150, 21)
        Me.txtQuantityTypeCollection.TabIndex = 16
        Me.txtQuantityTypeCollection.Text = "e-Book"
        Me.txtQuantityTypeCollection.Visible = False
        '
        'cmd_AddCollections
        '
        Me.cmd_AddCollections.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_AddCollections.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddCollections.Appearance.Options.UseFont = True
        Me.cmd_AddCollections.Location = New System.Drawing.Point(910, 13)
        Me.cmd_AddCollections.Name = "cmd_AddCollections"
        Me.cmd_AddCollections.Size = New System.Drawing.Size(310, 28)
        Me.cmd_AddCollections.TabIndex = 5
        Me.cmd_AddCollections.Text = "Add Selected Collections to School"
        '
        'XtraTabPage1_AddItemsToCollection
        '
        Me.XtraTabPage1_AddItemsToCollection.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage1_AddItemsToCollection.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1_AddItemsToCollection.Controls.Add(Me.dgv_CollectionBooksImport)
        Me.XtraTabPage1_AddItemsToCollection.Controls.Add(Me.Panel6)
        Me.XtraTabPage1_AddItemsToCollection.Name = "XtraTabPage1_AddItemsToCollection"
        Me.XtraTabPage1_AddItemsToCollection.Size = New System.Drawing.Size(1232, 388)
        Me.XtraTabPage1_AddItemsToCollection.Text = "Add Items to Collection"
        '
        'dgv_CollectionBooksImport
        '
        Me.dgv_CollectionBooksImport.AllowUserToAddRows = False
        Me.dgv_CollectionBooksImport.AllowUserToDeleteRows = False
        Me.dgv_CollectionBooksImport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_CollectionBooksImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CollectionBooksImport.Location = New System.Drawing.Point(6, 96)
        Me.dgv_CollectionBooksImport.Name = "dgv_CollectionBooksImport"
        Me.dgv_CollectionBooksImport.ReadOnly = True
        Me.dgv_CollectionBooksImport.Size = New System.Drawing.Size(1227, 289)
        Me.dgv_CollectionBooksImport.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.cmdAddBooksToCollection)
        Me.Panel6.Controls.Add(Me.chkIgnoreISBNCollection)
        Me.Panel6.Controls.Add(Me.chkAddToCollection)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.cmbISBNCol2)
        Me.Panel6.Controls.Add(Me.cmdLoadCollectionBooks)
        Me.Panel6.Controls.Add(Me.txtCollectionsBooksFile)
        Me.Panel6.Location = New System.Drawing.Point(6, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1226, 87)
        Me.Panel6.TabIndex = 5
        '
        'cmdAddBooksToCollection
        '
        Me.cmdAddBooksToCollection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddBooksToCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddBooksToCollection.Location = New System.Drawing.Point(953, 49)
        Me.cmdAddBooksToCollection.Name = "cmdAddBooksToCollection"
        Me.cmdAddBooksToCollection.Size = New System.Drawing.Size(218, 29)
        Me.cmdAddBooksToCollection.TabIndex = 26
        Me.cmdAddBooksToCollection.Text = "Add Books to Collection"
        Me.cmdAddBooksToCollection.UseVisualStyleBackColor = True
        '
        'chkIgnoreISBNCollection
        '
        Me.chkIgnoreISBNCollection.AutoSize = True
        Me.chkIgnoreISBNCollection.Checked = True
        Me.chkIgnoreISBNCollection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIgnoreISBNCollection.Location = New System.Drawing.Point(347, 10)
        Me.chkIgnoreISBNCollection.Name = "chkIgnoreISBNCollection"
        Me.chkIgnoreISBNCollection.Size = New System.Drawing.Size(121, 17)
        Me.chkIgnoreISBNCollection.TabIndex = 25
        Me.chkIgnoreISBNCollection.Text = "Ignore ISBN Check?"
        Me.chkIgnoreISBNCollection.UseVisualStyleBackColor = True
        '
        'chkAddToCollection
        '
        Me.chkAddToCollection.AutoSize = True
        Me.chkAddToCollection.Checked = True
        Me.chkAddToCollection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAddToCollection.Location = New System.Drawing.Point(229, 10)
        Me.chkAddToCollection.Name = "chkAddToCollection"
        Me.chkAddToCollection.Size = New System.Drawing.Size(112, 17)
        Me.chkAddToCollection.TabIndex = 24
        Me.chkAddToCollection.Text = "Add to Collection?"
        Me.chkAddToCollection.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "ISBN Column"
        '
        'cmbISBNCol2
        '
        Me.cmbISBNCol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbISBNCol2.FormattingEnabled = True
        Me.cmbISBNCol2.Location = New System.Drawing.Point(77, 8)
        Me.cmbISBNCol2.Name = "cmbISBNCol2"
        Me.cmbISBNCol2.Size = New System.Drawing.Size(134, 21)
        Me.cmbISBNCol2.TabIndex = 22
        '
        'cmdLoadCollectionBooks
        '
        Me.cmdLoadCollectionBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLoadCollectionBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadCollectionBooks.Location = New System.Drawing.Point(1184, 2)
        Me.cmdLoadCollectionBooks.Name = "cmdLoadCollectionBooks"
        Me.cmdLoadCollectionBooks.Size = New System.Drawing.Size(35, 37)
        Me.cmdLoadCollectionBooks.TabIndex = 21
        Me.cmdLoadCollectionBooks.Text = "..."
        Me.cmdLoadCollectionBooks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLoadCollectionBooks.UseVisualStyleBackColor = True
        '
        'txtCollectionsBooksFile
        '
        Me.txtCollectionsBooksFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCollectionsBooksFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectionsBooksFile.Location = New System.Drawing.Point(491, 11)
        Me.txtCollectionsBooksFile.Name = "txtCollectionsBooksFile"
        Me.txtCollectionsBooksFile.Size = New System.Drawing.Size(680, 26)
        Me.txtCollectionsBooksFile.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbIsSixPackCollection)
        Me.GroupBox2.Controls.Add(Me.cmdAddColletion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtItemDescription)
        Me.GroupBox2.Controls.Add(Me.txtItemNumber)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1237, 111)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create a new 'Collection'"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Is Six Pack?"
        '
        'cmbIsSixPackCollection
        '
        Me.cmbIsSixPackCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsSixPackCollection.FormattingEnabled = True
        Me.cmbIsSixPackCollection.Items.AddRange(New Object() {"Need to Select!", "Yes", "No"})
        Me.cmbIsSixPackCollection.Location = New System.Drawing.Point(135, 58)
        Me.cmbIsSixPackCollection.Name = "cmbIsSixPackCollection"
        Me.cmbIsSixPackCollection.Size = New System.Drawing.Size(148, 27)
        Me.cmbIsSixPackCollection.TabIndex = 22
        '
        'cmdAddColletion
        '
        Me.cmdAddColletion.Location = New System.Drawing.Point(458, 58)
        Me.cmdAddColletion.Name = "cmdAddColletion"
        Me.cmdAddColletion.Size = New System.Drawing.Size(197, 31)
        Me.cmdAddColletion.TabIndex = 21
        Me.cmdAddColletion.Text = "Add New Collection"
        Me.cmdAddColletion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Item Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Item Number:"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(458, 23)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(406, 27)
        Me.txtItemDescription.TabIndex = 18
        '
        'txtItemNumber
        '
        Me.txtItemNumber.Location = New System.Drawing.Point(135, 26)
        Me.txtItemNumber.Name = "txtItemNumber"
        Me.txtItemNumber.Size = New System.Drawing.Size(148, 27)
        Me.txtItemNumber.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbCompanyCollections)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbPublisherLine)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1237, 76)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Partner and Collection:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Partner Collections:"
        '
        'cmbCompanyCollections
        '
        Me.cmbCompanyCollections.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCompanyCollections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompanyCollections.FormattingEnabled = True
        Me.cmbCompanyCollections.Location = New System.Drawing.Point(620, 28)
        Me.cmbCompanyCollections.Name = "cmbCompanyCollections"
        Me.cmbCompanyCollections.Size = New System.Drawing.Size(297, 27)
        Me.cmbCompanyCollections.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Partners:"
        '
        'cmbPublisherLine
        '
        Me.cmbPublisherLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPublisherLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPublisherLine.FormattingEnabled = True
        Me.cmbPublisherLine.Location = New System.Drawing.Point(101, 28)
        Me.cmbPublisherLine.Name = "cmbPublisherLine"
        Me.cmbPublisherLine.Size = New System.Drawing.Size(298, 27)
        Me.cmbPublisherLine.TabIndex = 14
        '
        'XtraTabPage1_eBooks
        '
        Me.XtraTabPage1_eBooks.Controls.Add(Me.gridDiBSBooks)
        Me.XtraTabPage1_eBooks.Name = "XtraTabPage1_eBooks"
        Me.XtraTabPage1_eBooks.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage1_eBooks.Text = "All eBooks"
        '
        'gridDiBSBooks
        '
        Me.gridDiBSBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDiBSBooks.DataMember = "omqryOrdersMain"
        Me.gridDiBSBooks.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDiBSBooks.Location = New System.Drawing.Point(-2, 3)
        Me.gridDiBSBooks.MainView = Me.GridView2
        Me.gridDiBSBooks.Name = "gridDiBSBooks"
        Me.gridDiBSBooks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemTextEdit2, Me.RepositoryItemToggleSwitch1, Me.RepositoryItemCheckEdit1})
        Me.gridDiBSBooks.Size = New System.Drawing.Size(1244, 620)
        Me.gridDiBSBooks.TabIndex = 10
        Me.gridDiBSBooks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn4, Me.GridColumn11, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn16, Me.IsAudioAvailable, Me.IsEPub, Me.GridColumn18})
        Me.GridView2.GridControl = Me.gridDiBSBooks
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ID"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "ID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "PublisherID"
        Me.GridColumn4.FieldName = "PublisherID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Publisher Name"
        Me.GridColumn11.FieldName = "Name"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Tag = "frmEBookMGMT3"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 101
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ISBN"
        Me.GridColumn6.FieldName = "ISBN"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 101
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Title"
        Me.GridColumn7.FieldName = "Title"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 101
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GRL"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn8.FieldName = "GuidedReadingLevel"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "LEX"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn9.FieldName = "LEX"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "IsFiction"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn10.FieldName = "IsFiction"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "OfficialImage"
        Me.GridColumn12.FieldName = "OfficialImage"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 9
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "EBookPath"
        Me.GridColumn13.FieldName = "EBookPath"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 6
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "IsExternal"
        Me.GridColumn14.FieldName = "IsExternal"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 7
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "QuantityType"
        Me.GridColumn16.FieldName = "QuantityType"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 8
        '
        'IsAudioAvailable
        '
        Me.IsAudioAvailable.Caption = "IsAudioAvailable"
        Me.IsAudioAvailable.FieldName = "IsAudioAvailable"
        Me.IsAudioAvailable.Name = "IsAudioAvailable"
        Me.IsAudioAvailable.Visible = True
        Me.IsAudioAvailable.VisibleIndex = 11
        '
        'IsEPub
        '
        Me.IsEPub.Caption = "IsEPub"
        Me.IsEPub.FieldName = "IsEPub"
        Me.IsEPub.Name = "IsEPub"
        Me.IsEPub.Visible = True
        Me.IsEPub.VisibleIndex = 12
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "CreateTime"
        Me.GridColumn18.DisplayFormat.FormatString = "d"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn18.FieldName = "CreateTime"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 10
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'XtraTabPage1_UploadeBookCovers
        '
        Me.XtraTabPage1_UploadeBookCovers.Controls.Add(Me.chkIfBookImageExists)
        Me.XtraTabPage1_UploadeBookCovers.Controls.Add(Me.chkUploadCoversIngonreISBN)
        Me.XtraTabPage1_UploadeBookCovers.Controls.Add(Me.cmdUpLoadCoverImages)
        Me.XtraTabPage1_UploadeBookCovers.Controls.Add(Me.Label14)
        Me.XtraTabPage1_UploadeBookCovers.Controls.Add(Me.txtUploadCoverImagesDir)
        Me.XtraTabPage1_UploadeBookCovers.Name = "XtraTabPage1_UploadeBookCovers"
        Me.XtraTabPage1_UploadeBookCovers.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage1_UploadeBookCovers.Text = "Upload eBook Covers"
        '
        'chkIfBookImageExists
        '
        Me.chkIfBookImageExists.AutoSize = True
        Me.chkIfBookImageExists.Location = New System.Drawing.Point(466, 92)
        Me.chkIfBookImageExists.Name = "chkIfBookImageExists"
        Me.chkIfBookImageExists.Size = New System.Drawing.Size(245, 17)
        Me.chkIfBookImageExists.TabIndex = 70
        Me.chkIfBookImageExists.Text = "DO NOT Copy....If Image path already exists"
        Me.chkIfBookImageExists.UseVisualStyleBackColor = True
        '
        'chkUploadCoversIngonreISBN
        '
        Me.chkUploadCoversIngonreISBN.AutoSize = True
        Me.chkUploadCoversIngonreISBN.Location = New System.Drawing.Point(285, 92)
        Me.chkUploadCoversIngonreISBN.Name = "chkUploadCoversIngonreISBN"
        Me.chkUploadCoversIngonreISBN.Size = New System.Drawing.Size(121, 17)
        Me.chkUploadCoversIngonreISBN.TabIndex = 69
        Me.chkUploadCoversIngonreISBN.Text = "Ignore ISBN Check?"
        Me.chkUploadCoversIngonreISBN.UseVisualStyleBackColor = True
        '
        'cmdUpLoadCoverImages
        '
        Me.cmdUpLoadCoverImages.Location = New System.Drawing.Point(32, 92)
        Me.cmdUpLoadCoverImages.Name = "cmdUpLoadCoverImages"
        Me.cmdUpLoadCoverImages.Size = New System.Drawing.Size(228, 29)
        Me.cmdUpLoadCoverImages.TabIndex = 68
        Me.cmdUpLoadCoverImages.Text = "Upload Cover Images"
        Me.cmdUpLoadCoverImages.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(225, 25)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Upload Cover Image"
        '
        'txtUploadCoverImagesDir
        '
        Me.txtUploadCoverImagesDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUploadCoverImagesDir.Location = New System.Drawing.Point(32, 48)
        Me.txtUploadCoverImagesDir.Name = "txtUploadCoverImagesDir"
        Me.txtUploadCoverImagesDir.Size = New System.Drawing.Size(803, 26)
        Me.txtUploadCoverImagesDir.TabIndex = 66
        Me.txtUploadCoverImagesDir.Text = "F:\eBooks\BrainHive_Partners\Cover Images Brain Hive Partners\Rosen"
        '
        'XtraTabPage1_AddEBookMeta
        '
        Me.XtraTabPage1_AddEBookMeta.Controls.Add(Me.Panel9)
        Me.XtraTabPage1_AddEBookMeta.Controls.Add(Me.Panel8)
        Me.XtraTabPage1_AddEBookMeta.Controls.Add(Me.dgv_ImportAddBookMeta)
        Me.XtraTabPage1_AddEBookMeta.Name = "XtraTabPage1_AddEBookMeta"
        Me.XtraTabPage1_AddEBookMeta.Size = New System.Drawing.Size(1240, 692)
        Me.XtraTabPage1_AddEBookMeta.Text = "Add eBook Meta Data"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.cmdAddBookMeta)
        Me.Panel9.Location = New System.Drawing.Point(9, 611)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1228, 78)
        Me.Panel9.TabIndex = 44
        '
        'cmdAddBookMeta
        '
        Me.cmdAddBookMeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddBookMeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddBookMeta.Location = New System.Drawing.Point(5, 19)
        Me.cmdAddBookMeta.Name = "cmdAddBookMeta"
        Me.cmdAddBookMeta.Size = New System.Drawing.Size(218, 43)
        Me.cmdAddBookMeta.TabIndex = 40
        Me.cmdAddBookMeta.Text = "Add Book Meta Data"
        Me.cmdAddBookMeta.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.txtInstructions)
        Me.Panel8.Controls.Add(Me.cmdloadAddBookFile)
        Me.Panel8.Controls.Add(Me.chkUpdateMetaData)
        Me.Panel8.Controls.Add(Me.chkAddBookMeta_SkipISBNCheck)
        Me.Panel8.Controls.Add(Me.chkAddBookAddTag)
        Me.Panel8.Controls.Add(Me.cmbAddBookTagType)
        Me.Panel8.Controls.Add(Me.chkAddBookSimulation)
        Me.Panel8.Controls.Add(Me.txtAddBookFileNae)
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1234, 88)
        Me.Panel8.TabIndex = 43
        '
        'txtInstructions
        '
        Me.txtInstructions.Enabled = False
        Me.txtInstructions.Location = New System.Drawing.Point(290, 41)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInstructions.Size = New System.Drawing.Size(923, 38)
        Me.txtInstructions.TabIndex = 50
        Me.txtInstructions.Text = "Fields:Publisher (Must Match in DB),eBook_ISBN_13,Title,WebSite_Description,Class" &
    "ification,Guided_Reading_Level,ATOS,Lexile_Level,TagsText,KeyWords,Topic,Subject" &
    ""
        '
        'cmdloadAddBookFile
        '
        Me.cmdloadAddBookFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdloadAddBookFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdloadAddBookFile.Location = New System.Drawing.Point(1178, 8)
        Me.cmdloadAddBookFile.Name = "cmdloadAddBookFile"
        Me.cmdloadAddBookFile.Size = New System.Drawing.Size(35, 32)
        Me.cmdloadAddBookFile.TabIndex = 49
        Me.cmdloadAddBookFile.Text = "..."
        Me.cmdloadAddBookFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdloadAddBookFile.UseVisualStyleBackColor = True
        '
        'chkUpdateMetaData
        '
        Me.chkUpdateMetaData.AutoSize = True
        Me.chkUpdateMetaData.Location = New System.Drawing.Point(114, 50)
        Me.chkUpdateMetaData.Name = "chkUpdateMetaData"
        Me.chkUpdateMetaData.Size = New System.Drawing.Size(154, 17)
        Me.chkUpdateMetaData.TabIndex = 48
        Me.chkUpdateMetaData.Text = "Update Existing Meta Data"
        Me.chkUpdateMetaData.UseVisualStyleBackColor = True
        '
        'chkAddBookMeta_SkipISBNCheck
        '
        Me.chkAddBookMeta_SkipISBNCheck.AutoSize = True
        Me.chkAddBookMeta_SkipISBNCheck.Location = New System.Drawing.Point(5, 50)
        Me.chkAddBookMeta_SkipISBNCheck.Name = "chkAddBookMeta_SkipISBNCheck"
        Me.chkAddBookMeta_SkipISBNCheck.Size = New System.Drawing.Size(103, 17)
        Me.chkAddBookMeta_SkipISBNCheck.TabIndex = 47
        Me.chkAddBookMeta_SkipISBNCheck.Text = "Skip ISBN Check"
        Me.chkAddBookMeta_SkipISBNCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAddBookMeta_SkipISBNCheck.UseVisualStyleBackColor = True
        '
        'chkAddBookAddTag
        '
        Me.chkAddBookAddTag.AutoSize = True
        Me.chkAddBookAddTag.Location = New System.Drawing.Point(85, 13)
        Me.chkAddBookAddTag.Name = "chkAddBookAddTag"
        Me.chkAddBookAddTag.Size = New System.Drawing.Size(199, 17)
        Me.chkAddBookAddTag.TabIndex = 46
        Me.chkAddBookAddTag.Text = "Add Tag if it does not already exist?"
        Me.chkAddBookAddTag.UseVisualStyleBackColor = True
        '
        'cmbAddBookTagType
        '
        Me.cmbAddBookTagType.FormattingEnabled = True
        Me.cmbAddBookTagType.Items.AddRange(New Object() {"National", "District", "School"})
        Me.cmbAddBookTagType.Location = New System.Drawing.Point(290, 11)
        Me.cmbAddBookTagType.Name = "cmbAddBookTagType"
        Me.cmbAddBookTagType.Size = New System.Drawing.Size(142, 21)
        Me.cmbAddBookTagType.TabIndex = 45
        Me.cmbAddBookTagType.Text = "National"
        '
        'chkAddBookSimulation
        '
        Me.chkAddBookSimulation.AutoSize = True
        Me.chkAddBookSimulation.Location = New System.Drawing.Point(5, 11)
        Me.chkAddBookSimulation.Name = "chkAddBookSimulation"
        Me.chkAddBookSimulation.Size = New System.Drawing.Size(74, 17)
        Me.chkAddBookSimulation.TabIndex = 44
        Me.chkAddBookSimulation.Text = "Simulation"
        Me.chkAddBookSimulation.UseVisualStyleBackColor = True
        '
        'txtAddBookFileNae
        '
        Me.txtAddBookFileNae.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddBookFileNae.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddBookFileNae.Location = New System.Drawing.Point(458, 9)
        Me.txtAddBookFileNae.Name = "txtAddBookFileNae"
        Me.txtAddBookFileNae.Size = New System.Drawing.Size(704, 26)
        Me.txtAddBookFileNae.TabIndex = 43
        '
        'dgv_ImportAddBookMeta
        '
        Me.dgv_ImportAddBookMeta.AllowUserToAddRows = False
        Me.dgv_ImportAddBookMeta.AllowUserToDeleteRows = False
        Me.dgv_ImportAddBookMeta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ImportAddBookMeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ImportAddBookMeta.Location = New System.Drawing.Point(9, 97)
        Me.dgv_ImportAddBookMeta.Name = "dgv_ImportAddBookMeta"
        Me.dgv_ImportAddBookMeta.ReadOnly = True
        Me.dgv_ImportAddBookMeta.Size = New System.Drawing.Size(1228, 508)
        Me.dgv_ImportAddBookMeta.TabIndex = 35
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = "XtraOpenFileDialog1"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_ViewBook), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_ViewCover), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_ReplaceBookCover)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_EditUser), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_AddNewUser)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'PopupMenu3
        '
        Me.PopupMenu3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4_ViewBook), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4_ViewCover), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4_ReplaceBookCover)})
        Me.PopupMenu3.Manager = Me.BarManager1
        Me.PopupMenu3.Name = "PopupMenu3"
        '
        'cmdGenerateWelcomeEmail
        '
        Me.cmdGenerateWelcomeEmail.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateWelcomeEmail.Appearance.Options.UseFont = True
        Me.cmdGenerateWelcomeEmail.Location = New System.Drawing.Point(784, 62)
        Me.cmdGenerateWelcomeEmail.Name = "cmdGenerateWelcomeEmail"
        Me.cmdGenerateWelcomeEmail.Size = New System.Drawing.Size(224, 28)
        Me.cmdGenerateWelcomeEmail.TabIndex = 55
        Me.cmdGenerateWelcomeEmail.Text = "Generate Welcome Email"
        Me.cmdGenerateWelcomeEmail.ToolTip = "a"
        '
        'frmEBookMGMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 834)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEBookMGMT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbSchools2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDistricts2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStates2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.mainTab.ResumeLayout(False)
        CType(Me.gridSchoolBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gridSchoolUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.XtraTabPage1_AddByISBNFile.ResumeLayout(False)
        Me.XtraTabPage1_AddByISBNFile.PerformLayout()
        CType(Me.dgv_ImportBooksInSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.XtraTabPage1_AddBookFreeForm.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1_CollectionsAdd.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1_AddCollectionsToSchool.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.XtraTabPage1_AddItemsToCollection.ResumeLayout(False)
        CType(Me.dgv_CollectionBooksImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.XtraTabPage1_eBooks.ResumeLayout(False)
        CType(Me.gridDiBSBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1_UploadeBookCovers.ResumeLayout(False)
        Me.XtraTabPage1_UploadeBookCovers.PerformLayout()
        Me.XtraTabPage1_AddEBookMeta.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.dgv_ImportAddBookMeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdViewerForSchool As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbSchools2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDistricts2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStates2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdDuplicateSchool As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSchoolID As TextBox
    Friend WithEvents txtDistrictID As TextBox
    Friend WithEvents chkShowOnlySchoolsWBooks As CheckBox
    Friend WithEvents chkAnyPartOfSchoolName As CheckBox
    Friend WithEvents lblSchools As Label
    Friend WithEvents lblDistricts As Label
    Friend WithEvents lblStates As Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents mainTab As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmdGetSchoolBooks As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdGetSchoolUsers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridSchoolBooks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PublisherID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SchoolID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ISBN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GuidedReadingLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsFiction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EBookPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsExternal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QuantityType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BookSchoolsID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridSchoolUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DistrictID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents First As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoginID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Password As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RoleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APIKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents OfficialImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAddSchoolUser As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDeleteSelectedUsers As Button
    Friend WithEvents cmdDeleteSelectedBooks As Button
    Friend WithEvents XtraTabPage1_AddByISBNFile As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtSchoolIDs As TextBox
    Friend WithEvents dgv_ImportBooksInSchool As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents chkIgnoreISBNCheck As CheckBox
    Friend WithEvents chkEBooks As CheckBox
    Friend WithEvents chk_AddBookToSchool As CheckBox
    Friend WithEvents chk_ISSixPack As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbISBNCol As ComboBox
    Friend WithEvents cmd_FileSelect2 As Button
    Friend WithEvents txtFile_SchoolByISBN As TextBox
    Friend WithEvents cmdAddBooksToSchool As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents chkCreateViewerForAllDisitrictSchools As CheckBox
    Friend WithEvents cmbViewerBrand As ComboBox
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1_ViewBook As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1_ViewCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents XtraTabPage1_AddBookFreeForm As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage1_CollectionsAdd As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbIsSixPackCollection As ComboBox
    Friend WithEvents cmdAddColletion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents txtItemNumber As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCompanyCollections As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPublisherLine As ComboBox
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1_AddCollectionsToSchool As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lstvw_Collections As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantityTypeCollection As TextBox
    Friend WithEvents cmd_AddCollections As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage1_AddItemsToCollection As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgv_CollectionBooksImport As DataGridView
    Friend WithEvents cmdAddBooksToCollection As Button
    Friend WithEvents chkIgnoreISBNCollection As CheckBox
    Friend WithEvents chkAddToCollection As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbISBNCol2 As ComboBox
    Friend WithEvents cmdLoadCollectionBooks As Button
    Friend WithEvents txtCollectionsBooksFile As TextBox
    Friend WithEvents XtraTabPage1_eBooks As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridDiBSBooks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsAudioAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsEPub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel7 As Panel
    Friend WithEvents chkIgnoreISBNCheckFree As CheckBox
    Friend WithEvents chk_AddBookToSchoolFree As CheckBox
    Friend WithEvents cmdClearOrderItemsFreeForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddOrderItemsFreeForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spreadAddFreeForm As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents BarButtonItem3_ViewBook As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1_ReplaceBookCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabPage1_UploadeBookCovers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkIfBookImageExists As CheckBox
    Friend WithEvents chkUploadCoversIngonreISBN As CheckBox
    Friend WithEvents cmdUpLoadCoverImages As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUploadCoverImagesDir As TextBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarButtonItem1_EditUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1_AddNewUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3_ViewCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4_ViewBook As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu3 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem4_ViewCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4_ReplaceBookCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabPage1_AddEBookMeta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgv_ImportAddBookMeta As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents cmdAddBookMeta As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtInstructions As TextBox
    Friend WithEvents cmdloadAddBookFile As Button
    Friend WithEvents chkUpdateMetaData As CheckBox
    Friend WithEvents chkAddBookMeta_SkipISBNCheck As CheckBox
    Friend WithEvents chkAddBookAddTag As CheckBox
    Friend WithEvents cmbAddBookTagType As ComboBox
    Friend WithEvents chkAddBookSimulation As CheckBox
    Friend WithEvents txtAddBookFileNae As TextBox
    Friend WithEvents cmdGenerateWelcomeEmail As DevExpress.XtraEditors.SimpleButton
End Class
