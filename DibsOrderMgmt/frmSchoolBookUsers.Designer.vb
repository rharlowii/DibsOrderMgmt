<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolBookUsers
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdSetDistrictBillTo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbSchools2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbDistricts2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStates2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdSetSchoolShipTo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSetDistrictBillToShipTo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSchoolID = New System.Windows.Forms.TextBox()
        Me.txtDistrictID = New System.Windows.Forms.TextBox()
        Me.chkShowOnlySchoolsWBooks = New System.Windows.Forms.CheckBox()
        Me.chkAnyPartOfSchoolName = New System.Windows.Forms.CheckBox()
        Me.lblSchools = New System.Windows.Forms.Label()
        Me.lblDistricts = New System.Windows.Forms.Label()
        Me.lblStates = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.mainTab = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbOrderSet = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGetSchoolBooks = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdClearOrderItemsFreeForm = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPartner = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbOrderSet2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAddOrderItemsFreeForm = New DevExpress.XtraEditors.SimpleButton()
        Me.gridSchoolBooks = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPublisherID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSchoolID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISBN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPublisherName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuidedReadingLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsFiction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficalImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleBookPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsExternal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantityType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbSchools2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDistricts2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStates2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.mainTab.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cmbOrderSet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cmbPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrderSet2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSchoolBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.cmdSetDistrictBillTo)
        Me.Panel1.Controls.Add(Me.cmbSchools2)
        Me.Panel1.Controls.Add(Me.cmbDistricts2)
        Me.Panel1.Controls.Add(Me.cmbStates2)
        Me.Panel1.Controls.Add(Me.cmdSetSchoolShipTo)
        Me.Panel1.Controls.Add(Me.cmdSetDistrictBillToShipTo)
        Me.Panel1.Controls.Add(Me.txtSchoolID)
        Me.Panel1.Controls.Add(Me.txtDistrictID)
        Me.Panel1.Controls.Add(Me.chkShowOnlySchoolsWBooks)
        Me.Panel1.Controls.Add(Me.chkAnyPartOfSchoolName)
        Me.Panel1.Controls.Add(Me.lblSchools)
        Me.Panel1.Controls.Add(Me.lblDistricts)
        Me.Panel1.Controls.Add(Me.lblStates)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 172)
        Me.Panel1.TabIndex = 1
        '
        'cmdSetDistrictBillTo
        '
        Me.cmdSetDistrictBillTo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDistrictBillTo.Appearance.Options.UseFont = True
        Me.cmdSetDistrictBillTo.Location = New System.Drawing.Point(343, 69)
        Me.cmdSetDistrictBillTo.Name = "cmdSetDistrictBillTo"
        Me.cmdSetDistrictBillTo.Size = New System.Drawing.Size(194, 28)
        Me.cmdSetDistrictBillTo.TabIndex = 52
        Me.cmdSetDistrictBillTo.Text = "Set &District Bill To"
        Me.cmdSetDistrictBillTo.ToolTip = "a"
        '
        'cmbSchools2
        '
        Me.cmbSchools2.EditValue = ""
        Me.cmbSchools2.Location = New System.Drawing.Point(59, 132)
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
        Me.cmbDistricts2.Location = New System.Drawing.Point(59, 105)
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
        Me.cmbStates2.Location = New System.Drawing.Point(57, 69)
        Me.cmbStates2.Name = "cmbStates2"
        Me.cmbStates2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStates2.Properties.ValidateOnEnterKey = True
        Me.cmbStates2.Size = New System.Drawing.Size(278, 20)
        Me.cmbStates2.TabIndex = 0
        '
        'cmdSetSchoolShipTo
        '
        Me.cmdSetSchoolShipTo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetSchoolShipTo.Appearance.Options.UseFont = True
        Me.cmdSetSchoolShipTo.Location = New System.Drawing.Point(776, 108)
        Me.cmdSetSchoolShipTo.Name = "cmdSetSchoolShipTo"
        Me.cmdSetSchoolShipTo.Size = New System.Drawing.Size(194, 28)
        Me.cmdSetSchoolShipTo.TabIndex = 4
        Me.cmdSetSchoolShipTo.Text = "Set School Ship To"
        '
        'cmdSetDistrictBillToShipTo
        '
        Me.cmdSetDistrictBillToShipTo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDistrictBillToShipTo.Appearance.Options.UseFont = True
        Me.cmdSetDistrictBillToShipTo.Location = New System.Drawing.Point(776, 69)
        Me.cmdSetDistrictBillToShipTo.Name = "cmdSetDistrictBillToShipTo"
        Me.cmdSetDistrictBillToShipTo.Size = New System.Drawing.Size(194, 28)
        Me.cmdSetDistrictBillToShipTo.TabIndex = 3
        Me.cmdSetDistrictBillToShipTo.Text = "Set District Ship To"
        '
        'txtSchoolID
        '
        Me.txtSchoolID.Location = New System.Drawing.Point(343, 132)
        Me.txtSchoolID.Name = "txtSchoolID"
        Me.txtSchoolID.Size = New System.Drawing.Size(223, 20)
        Me.txtSchoolID.TabIndex = 31
        Me.txtSchoolID.TabStop = False
        '
        'txtDistrictID
        '
        Me.txtDistrictID.Location = New System.Drawing.Point(343, 103)
        Me.txtDistrictID.Name = "txtDistrictID"
        Me.txtDistrictID.Size = New System.Drawing.Size(223, 20)
        Me.txtDistrictID.TabIndex = 30
        Me.txtDistrictID.TabStop = False
        '
        'chkShowOnlySchoolsWBooks
        '
        Me.chkShowOnlySchoolsWBooks.AutoSize = True
        Me.chkShowOnlySchoolsWBooks.Location = New System.Drawing.Point(579, 99)
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
        Me.chkAnyPartOfSchoolName.Location = New System.Drawing.Point(579, 125)
        Me.chkAnyPartOfSchoolName.Name = "chkAnyPartOfSchoolName"
        Me.chkAnyPartOfSchoolName.Size = New System.Drawing.Size(176, 17)
        Me.chkAnyPartOfSchoolName.TabIndex = 51
        Me.chkAnyPartOfSchoolName.TabStop = False
        Me.chkAnyPartOfSchoolName.Text = "Search any part of school name"
        Me.chkAnyPartOfSchoolName.UseVisualStyleBackColor = True
        '
        'lblSchools
        '
        Me.lblSchools.AutoSize = True
        Me.lblSchools.Location = New System.Drawing.Point(10, 131)
        Me.lblSchools.Name = "lblSchools"
        Me.lblSchools.Size = New System.Drawing.Size(48, 13)
        Me.lblSchools.TabIndex = 15
        Me.lblSchools.Text = "Schools:"
        '
        'lblDistricts
        '
        Me.lblDistricts.AutoSize = True
        Me.lblDistricts.Location = New System.Drawing.Point(10, 104)
        Me.lblDistricts.Name = "lblDistricts"
        Me.lblDistricts.Size = New System.Drawing.Size(47, 13)
        Me.lblDistricts.TabIndex = 14
        Me.lblDistricts.Text = "Districts:"
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.Location = New System.Drawing.Point(11, 68)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(40, 13)
        Me.lblStates.TabIndex = 13
        Me.lblStates.Text = "States:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(484, 58)
        Me.LabelControl1.TabIndex = 77
        Me.LabelControl1.Text = "School Books/Users"
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 181)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.mainTab
        Me.XtraTabControl1.Size = New System.Drawing.Size(1204, 640)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.mainTab, Me.XtraTabPage2})
        '
        'mainTab
        '
        Me.mainTab.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.mainTab.Appearance.PageClient.BackColor2 = System.Drawing.Color.White
        Me.mainTab.Appearance.PageClient.Options.UseBackColor = True
        Me.mainTab.Controls.Add(Me.gridSchoolBooks)
        Me.mainTab.Controls.Add(Me.Panel3)
        Me.mainTab.Name = "mainTab"
        Me.mainTab.Size = New System.Drawing.Size(1202, 595)
        Me.mainTab.Text = "School Books"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cmbOrderSet)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cmdGetSchoolBooks)
        Me.Panel3.Location = New System.Drawing.Point(6, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1193, 55)
        Me.Panel3.TabIndex = 3
        '
        'cmbOrderSet
        '
        Me.cmbOrderSet.Location = New System.Drawing.Point(367, 15)
        Me.cmbOrderSet.Name = "cmbOrderSet"
        Me.cmbOrderSet.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbOrderSet.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbOrderSet.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderSet.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbOrderSet.Properties.Appearance.Options.UseBackColor = True
        Me.cmbOrderSet.Properties.Appearance.Options.UseFont = True
        Me.cmbOrderSet.Properties.Appearance.Options.UseForeColor = True
        Me.cmbOrderSet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrderSet.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderSetID", "OrderSetID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SetName", "Set Name")})
        Me.cmbOrderSet.Properties.DisplayMember = "SetName"
        Me.cmbOrderSet.Properties.EditValueChangedDelay = 1
        Me.cmbOrderSet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbOrderSet.Properties.NullText = ""
        Me.cmbOrderSet.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbOrderSet.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbOrderSet.Properties.SortColumnIndex = 1
        Me.cmbOrderSet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbOrderSet.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbOrderSet.Properties.ValidateOnEnterKey = True
        Me.cmbOrderSet.Properties.ValueMember = "OrderSetID"
        Me.cmbOrderSet.Size = New System.Drawing.Size(220, 26)
        Me.cmbOrderSet.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Order Set:"
        '
        'cmdGetSchoolBooks
        '
        Me.cmdGetSchoolBooks.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetSchoolBooks.Appearance.Options.UseFont = True
        Me.cmdGetSchoolBooks.Location = New System.Drawing.Point(604, 13)
        Me.cmdGetSchoolBooks.Name = "cmdGetSchoolBooks"
        Me.cmdGetSchoolBooks.Size = New System.Drawing.Size(175, 28)
        Me.cmdGetSchoolBooks.TabIndex = 5
        Me.cmdGetSchoolBooks.Text = "Get School Books"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1202, 595)
        Me.XtraTabPage2.Text = "School Users"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmdClearOrderItemsFreeForm)
        Me.Panel2.Controls.Add(Me.cmbPartner)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.cmbOrderSet2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmdAddOrderItemsFreeForm)
        Me.Panel2.Location = New System.Drawing.Point(6, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1144, 55)
        Me.Panel2.TabIndex = 5
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
        'cmbPartner
        '
        Me.cmbPartner.Location = New System.Drawing.Point(85, 14)
        Me.cmbPartner.Name = "cmbPartner"
        Me.cmbPartner.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbPartner.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartner.Properties.Appearance.Options.UseFont = True
        Me.cmbPartner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPartner.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartnerID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PublisherName", "Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbPartner.Properties.EditValueChangedDelay = 1
        Me.cmbPartner.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbPartner.Properties.NullText = ""
        Me.cmbPartner.Properties.SortColumnIndex = 1
        Me.cmbPartner.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbPartner.Properties.ValidateOnEnterKey = True
        Me.cmbPartner.Size = New System.Drawing.Size(220, 26)
        Me.cmbPartner.TabIndex = 80
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 20)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "Partner:"
        '
        'cmbOrderSet2
        '
        Me.cmbOrderSet2.Location = New System.Drawing.Point(416, 15)
        Me.cmbOrderSet2.Name = "cmbOrderSet2"
        Me.cmbOrderSet2.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbOrderSet2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbOrderSet2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderSet2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbOrderSet2.Properties.Appearance.Options.UseBackColor = True
        Me.cmbOrderSet2.Properties.Appearance.Options.UseFont = True
        Me.cmbOrderSet2.Properties.Appearance.Options.UseForeColor = True
        Me.cmbOrderSet2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrderSet2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderSetID", "OrderSetID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SetName", "Set Name")})
        Me.cmbOrderSet2.Properties.DisplayMember = "SetName"
        Me.cmbOrderSet2.Properties.EditValueChangedDelay = 1
        Me.cmbOrderSet2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbOrderSet2.Properties.NullText = ""
        Me.cmbOrderSet2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbOrderSet2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbOrderSet2.Properties.SortColumnIndex = 1
        Me.cmbOrderSet2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbOrderSet2.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbOrderSet2.Properties.ValidateOnEnterKey = True
        Me.cmbOrderSet2.Properties.ValueMember = "OrderSetID"
        Me.cmbOrderSet2.Size = New System.Drawing.Size(220, 26)
        Me.cmbOrderSet2.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Order Set:"
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
        'gridSchoolBooks
        '
        Me.gridSchoolBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSchoolBooks.DataMember = "omqryOrdersMain"
        Me.gridSchoolBooks.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSchoolBooks.Location = New System.Drawing.Point(9, 64)
        Me.gridSchoolBooks.MainView = Me.GridView1
        Me.gridSchoolBooks.Name = "gridSchoolBooks"
        Me.gridSchoolBooks.Size = New System.Drawing.Size(1190, 510)
        Me.gridSchoolBooks.TabIndex = 6
        Me.gridSchoolBooks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colPublisherID, Me.colSchoolID, Me.colISBN, Me.colTitle, Me.colPublisherName, Me.colGuidedReadingLevel, Me.colLex, Me.colIsFiction, Me.colDescription, Me.colOfficalImage, Me.coleBookPath, Me.IsExternal, Me.colQuantityType, Me.colCreateTime})
        Me.GridView1.GridControl = Me.gridSchoolBooks
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colPublisherID
        '
        Me.colPublisherID.FieldName = "PublisherID"
        Me.colPublisherID.Name = "colPublisherID"
        '
        'colSchoolID
        '
        Me.colSchoolID.FieldName = "SchoolID"
        Me.colSchoolID.Name = "colSchoolID"
        '
        'colISBN
        '
        Me.colISBN.Caption = "ISBN"
        Me.colISBN.FieldName = "ISBN"
        Me.colISBN.Name = "colISBN"
        Me.colISBN.Visible = True
        Me.colISBN.VisibleIndex = 0
        Me.colISBN.Width = 101
        '
        'colTitle
        '
        Me.colTitle.Caption = "Title"
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 1
        Me.colTitle.Width = 101
        '
        'colPublisherName
        '
        Me.colPublisherName.Caption = "Publisher Name"
        Me.colPublisherName.FieldName = "Name"
        Me.colPublisherName.Name = "colPublisherName"
        Me.colPublisherName.Visible = True
        Me.colPublisherName.VisibleIndex = 2
        Me.colPublisherName.Width = 101
        '
        'colGuidedReadingLevel
        '
        Me.colGuidedReadingLevel.Caption = "GRL"
        Me.colGuidedReadingLevel.FieldName = "GuidedReadingLevel"
        Me.colGuidedReadingLevel.Name = "colGuidedReadingLevel"
        Me.colGuidedReadingLevel.Visible = True
        Me.colGuidedReadingLevel.VisibleIndex = 3
        Me.colGuidedReadingLevel.Width = 101
        '
        'colLex
        '
        Me.colLex.Caption = "Lex"
        Me.colLex.FieldName = "Lex"
        Me.colLex.Name = "colLex"
        Me.colLex.Visible = True
        Me.colLex.VisibleIndex = 4
        Me.colLex.Width = 101
        '
        'colIsFiction
        '
        Me.colIsFiction.Caption = "Is Fiction"
        Me.colIsFiction.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colIsFiction.FieldName = "IsFiction"
        Me.colIsFiction.Name = "colIsFiction"
        Me.colIsFiction.Visible = True
        Me.colIsFiction.VisibleIndex = 5
        Me.colIsFiction.Width = 101
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 6
        Me.colDescription.Width = 101
        '
        'colOfficalImage
        '
        Me.colOfficalImage.Caption = "Offical Image"
        Me.colOfficalImage.FieldName = "OfficalImage"
        Me.colOfficalImage.Name = "colOfficalImage"
        Me.colOfficalImage.Visible = True
        Me.colOfficalImage.VisibleIndex = 7
        Me.colOfficalImage.Width = 100
        '
        'coleBookPath
        '
        Me.coleBookPath.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.coleBookPath.AppearanceCell.Options.UseForeColor = True
        Me.coleBookPath.Caption = "eBookPath"
        Me.coleBookPath.FieldName = "EBookPath"
        Me.coleBookPath.Name = "coleBookPath"
        Me.coleBookPath.Visible = True
        Me.coleBookPath.VisibleIndex = 8
        Me.coleBookPath.Width = 101
        '
        'IsExternal
        '
        Me.IsExternal.Caption = "IsExternal"
        Me.IsExternal.FieldName = "IsExternal"
        Me.IsExternal.Name = "IsExternal"
        Me.IsExternal.Visible = True
        Me.IsExternal.VisibleIndex = 11
        '
        'colCreateTime
        '
        Me.colCreateTime.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCreateTime.AppearanceCell.Options.UseForeColor = True
        Me.colCreateTime.Caption = "Create Time"
        Me.colCreateTime.FieldName = "CreateTime"
        Me.colCreateTime.Name = "colCreateTime"
        Me.colCreateTime.Visible = True
        Me.colCreateTime.VisibleIndex = 10
        '
        'colQuantityType
        '
        Me.colQuantityType.Caption = "Quantity Type"
        Me.colQuantityType.FieldName = "QuantityType"
        Me.colQuantityType.Name = "colQuantityType"
        Me.colQuantityType.Visible = True
        Me.colQuantityType.VisibleIndex = 9
        '
        'frmSchoolBookUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 833)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSchoolBookUsers"
        Me.Text = "frmSchoolBookUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbSchools2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDistricts2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStates2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.mainTab.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cmbOrderSet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmbPartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrderSet2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSchoolBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdSetDistrictBillTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbSchools2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDistricts2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStates2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdSetSchoolShipTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSetDistrictBillToShipTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSchoolID As TextBox
    Friend WithEvents txtDistrictID As TextBox
    Friend WithEvents chkShowOnlySchoolsWBooks As CheckBox
    Friend WithEvents chkAnyPartOfSchoolName As CheckBox
    Friend WithEvents lblSchools As Label
    Friend WithEvents lblDistricts As Label
    Friend WithEvents lblStates As Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents mainTab As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbOrderSet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdGetSchoolBooks As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdClearOrderItemsFreeForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbPartner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbOrderSet2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdAddOrderItemsFreeForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridSchoolBooks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPublisherID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSchoolID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISBN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPublisherName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuidedReadingLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsFiction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficalImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleBookPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsExternal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateTime As DevExpress.XtraGrid.Columns.GridColumn
End Class
