<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewOrder
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdViewDocuments = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBillTo_BHPO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBillTo_Zip = New System.Windows.Forms.TextBox()
        Me.txtBillTo_Name = New System.Windows.Forms.TextBox()
        Me.txtBillTo_State = New System.Windows.Forms.TextBox()
        Me.txtBillTo_Street = New System.Windows.Forms.TextBox()
        Me.txtBillTo_City = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTrackingNumbers = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtShipTo_Attn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShipTo_Zip = New System.Windows.Forms.TextBox()
        Me.txtShipTo_Name = New System.Windows.Forms.TextBox()
        Me.txtShipTo_State = New System.Windows.Forms.TextBox()
        Me.txtShipTo_Address = New System.Windows.Forms.TextBox()
        Me.txtShipTo_City = New System.Windows.Forms.TextBox()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPurchasing_DueDate = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPurchasing_PurchasingPONumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPurchasing_Name = New System.Windows.Forms.TextBox()
        Me.txtPurchasing_Phone = New System.Windows.Forms.TextBox()
        Me.txtPurchasing_email = New System.Windows.Forms.TextBox()
        Me.txtOrderNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPO_DiscountAmount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPO_Amount = New System.Windows.Forms.TextBox()
        Me.txtPO_Shipping = New System.Windows.Forms.TextBox()
        Me.txtPO_TotalAmount = New System.Windows.Forms.TextBox()
        Me.cmbOrderStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCreateTime = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbOrderHasDiffCommisionItems = New System.Windows.Forms.ComboBox()
        Me.cmbSalesRep = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSalesRep_OrderDescShort = New System.Windows.Forms.TextBox()
        Me.txtSalesRep_CommissionRate = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbOrderStatusDigital = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbOrderStatusComm = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbSchools2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDistricts2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStates2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cmbOrderStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.cmbSalesRep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrderStatusDigital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrderStatusComm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdViewDocuments)
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
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 97)
        Me.Panel1.TabIndex = 0
        '
        'cmdViewDocuments
        '
        Me.cmdViewDocuments.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewDocuments.Appearance.Options.UseFont = True
        Me.cmdViewDocuments.Location = New System.Drawing.Point(1062, 27)
        Me.cmdViewDocuments.Name = "cmdViewDocuments"
        Me.cmdViewDocuments.Size = New System.Drawing.Size(194, 28)
        Me.cmdViewDocuments.TabIndex = 53
        Me.cmdViewDocuments.Text = "View Documents"
        '
        'cmdSetDistrictBillTo
        '
        Me.cmdSetDistrictBillTo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDistrictBillTo.Appearance.Options.UseFont = True
        Me.cmdSetDistrictBillTo.Location = New System.Drawing.Point(339, 3)
        Me.cmdSetDistrictBillTo.Name = "cmdSetDistrictBillTo"
        Me.cmdSetDistrictBillTo.Size = New System.Drawing.Size(194, 28)
        Me.cmdSetDistrictBillTo.TabIndex = 52
        Me.cmdSetDistrictBillTo.Text = "Set &District Bill To"
        Me.cmdSetDistrictBillTo.ToolTip = "a"
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
        'cmdSetSchoolShipTo
        '
        Me.cmdSetSchoolShipTo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetSchoolShipTo.Appearance.Options.UseFont = True
        Me.cmdSetSchoolShipTo.Location = New System.Drawing.Point(772, 46)
        Me.cmdSetSchoolShipTo.Name = "cmdSetSchoolShipTo"
        Me.cmdSetSchoolShipTo.Size = New System.Drawing.Size(194, 28)
        Me.cmdSetSchoolShipTo.TabIndex = 4
        Me.cmdSetSchoolShipTo.Text = "Set School Ship To"
        '
        'cmdSetDistrictBillToShipTo
        '
        Me.cmdSetDistrictBillToShipTo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDistrictBillToShipTo.Appearance.Options.UseFont = True
        Me.cmdSetDistrictBillToShipTo.Location = New System.Drawing.Point(772, 7)
        Me.cmdSetDistrictBillToShipTo.Name = "cmdSetDistrictBillToShipTo"
        Me.cmdSetDistrictBillToShipTo.Size = New System.Drawing.Size(194, 28)
        Me.cmdSetDistrictBillToShipTo.TabIndex = 3
        Me.cmdSetDistrictBillToShipTo.Text = "Set District Ship To"
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
        Me.chkShowOnlySchoolsWBooks.Location = New System.Drawing.Point(575, 37)
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
        Me.chkAnyPartOfSchoolName.Location = New System.Drawing.Point(575, 63)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtBillTo_BHPO)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtBillTo_Zip)
        Me.GroupBox3.Controls.Add(Me.txtBillTo_Name)
        Me.GroupBox3.Controls.Add(Me.txtBillTo_State)
        Me.GroupBox3.Controls.Add(Me.txtBillTo_Street)
        Me.GroupBox3.Controls.Add(Me.txtBillTo_City)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 274)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bill To:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 156)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 16)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "BH PO:"
        '
        'txtBillTo_BHPO
        '
        Me.txtBillTo_BHPO.Location = New System.Drawing.Point(69, 156)
        Me.txtBillTo_BHPO.Name = "txtBillTo_BHPO"
        Me.txtBillTo_BHPO.Size = New System.Drawing.Size(277, 26)
        Me.txtBillTo_BHPO.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Zip:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "City:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Street:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Name:"
        '
        'txtBillTo_Zip
        '
        Me.txtBillTo_Zip.Location = New System.Drawing.Point(221, 123)
        Me.txtBillTo_Zip.Name = "txtBillTo_Zip"
        Me.txtBillTo_Zip.Size = New System.Drawing.Size(125, 26)
        Me.txtBillTo_Zip.TabIndex = 9
        '
        'txtBillTo_Name
        '
        Me.txtBillTo_Name.Location = New System.Drawing.Point(69, 25)
        Me.txtBillTo_Name.Name = "txtBillTo_Name"
        Me.txtBillTo_Name.Size = New System.Drawing.Size(277, 26)
        Me.txtBillTo_Name.TabIndex = 5
        '
        'txtBillTo_State
        '
        Me.txtBillTo_State.Location = New System.Drawing.Point(69, 121)
        Me.txtBillTo_State.Name = "txtBillTo_State"
        Me.txtBillTo_State.Size = New System.Drawing.Size(52, 26)
        Me.txtBillTo_State.TabIndex = 8
        '
        'txtBillTo_Street
        '
        Me.txtBillTo_Street.Location = New System.Drawing.Point(69, 57)
        Me.txtBillTo_Street.Name = "txtBillTo_Street"
        Me.txtBillTo_Street.Size = New System.Drawing.Size(277, 26)
        Me.txtBillTo_Street.TabIndex = 6
        '
        'txtBillTo_City
        '
        Me.txtBillTo_City.Location = New System.Drawing.Point(69, 89)
        Me.txtBillTo_City.Name = "txtBillTo_City"
        Me.txtBillTo_City.Size = New System.Drawing.Size(277, 26)
        Me.txtBillTo_City.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTrackingNumbers)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtShipTo_Attn)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtShipTo_Zip)
        Me.GroupBox2.Controls.Add(Me.txtShipTo_Name)
        Me.GroupBox2.Controls.Add(Me.txtShipTo_State)
        Me.GroupBox2.Controls.Add(Me.txtShipTo_Address)
        Me.GroupBox2.Controls.Add(Me.txtShipTo_City)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(387, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 273)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ship To:"
        '
        'txtTrackingNumbers
        '
        Me.txtTrackingNumbers.Location = New System.Drawing.Point(6, 212)
        Me.txtTrackingNumbers.Multiline = True
        Me.txtTrackingNumbers.Name = "txtTrackingNumbers"
        Me.txtTrackingNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTrackingNumbers.Size = New System.Drawing.Size(349, 55)
        Me.txtTrackingNumbers.TabIndex = 73
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 193)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(255, 16)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Tracking Numbers (Separate by comma):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "ATTN:"
        '
        'txtShipTo_Attn
        '
        Me.txtShipTo_Attn.Location = New System.Drawing.Point(68, 158)
        Me.txtShipTo_Attn.Name = "txtShipTo_Attn"
        Me.txtShipTo_Attn.Size = New System.Drawing.Size(277, 26)
        Me.txtShipTo_Attn.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(185, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Zip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Street:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Name:"
        '
        'txtShipTo_Zip
        '
        Me.txtShipTo_Zip.Location = New System.Drawing.Point(221, 123)
        Me.txtShipTo_Zip.Name = "txtShipTo_Zip"
        Me.txtShipTo_Zip.Size = New System.Drawing.Size(125, 26)
        Me.txtShipTo_Zip.TabIndex = 15
        '
        'txtShipTo_Name
        '
        Me.txtShipTo_Name.Location = New System.Drawing.Point(69, 25)
        Me.txtShipTo_Name.Name = "txtShipTo_Name"
        Me.txtShipTo_Name.Size = New System.Drawing.Size(277, 26)
        Me.txtShipTo_Name.TabIndex = 11
        '
        'txtShipTo_State
        '
        Me.txtShipTo_State.Location = New System.Drawing.Point(69, 121)
        Me.txtShipTo_State.Name = "txtShipTo_State"
        Me.txtShipTo_State.Size = New System.Drawing.Size(52, 26)
        Me.txtShipTo_State.TabIndex = 14
        '
        'txtShipTo_Address
        '
        Me.txtShipTo_Address.Location = New System.Drawing.Point(69, 57)
        Me.txtShipTo_Address.Name = "txtShipTo_Address"
        Me.txtShipTo_Address.Size = New System.Drawing.Size(277, 26)
        Me.txtShipTo_Address.TabIndex = 12
        '
        'txtShipTo_City
        '
        Me.txtShipTo_City.Location = New System.Drawing.Point(69, 89)
        Me.txtShipTo_City.Name = "txtShipTo_City"
        Me.txtShipTo_City.Size = New System.Drawing.Size(277, 26)
        Me.txtShipTo_City.TabIndex = 13
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(435, 601)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(130, 28)
        Me.cmdSave.TabIndex = 32
        Me.cmdSave.Text = "&Save"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(575, 601)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(130, 28)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "&Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPurchasing_DueDate)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtPurchasing_PurchasingPONumber)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPurchasing_Name)
        Me.GroupBox1.Controls.Add(Me.txtPurchasing_Phone)
        Me.GroupBox1.Controls.Add(Me.txtPurchasing_email)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(766, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 273)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Contact:"
        '
        'txtPurchasing_DueDate
        '
        Me.txtPurchasing_DueDate.Location = New System.Drawing.Point(69, 155)
        Me.txtPurchasing_DueDate.Name = "txtPurchasing_DueDate"
        Me.txtPurchasing_DueDate.Size = New System.Drawing.Size(277, 26)
        Me.txtPurchasing_DueDate.TabIndex = 54
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 16)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Due Date:"
        '
        'txtPurchasing_PurchasingPONumber
        '
        Me.txtPurchasing_PurchasingPONumber.Location = New System.Drawing.Point(69, 120)
        Me.txtPurchasing_PurchasingPONumber.Name = "txtPurchasing_PurchasingPONumber"
        Me.txtPurchasing_PurchasingPONumber.Size = New System.Drawing.Size(277, 26)
        Me.txtPurchasing_PurchasingPONumber.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "PO:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "email:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Phone:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Name:"
        '
        'txtPurchasing_Name
        '
        Me.txtPurchasing_Name.Location = New System.Drawing.Point(69, 25)
        Me.txtPurchasing_Name.Name = "txtPurchasing_Name"
        Me.txtPurchasing_Name.Size = New System.Drawing.Size(277, 26)
        Me.txtPurchasing_Name.TabIndex = 50
        '
        'txtPurchasing_Phone
        '
        Me.txtPurchasing_Phone.Location = New System.Drawing.Point(69, 57)
        Me.txtPurchasing_Phone.Name = "txtPurchasing_Phone"
        Me.txtPurchasing_Phone.Size = New System.Drawing.Size(277, 26)
        Me.txtPurchasing_Phone.TabIndex = 51
        '
        'txtPurchasing_email
        '
        Me.txtPurchasing_email.Location = New System.Drawing.Point(69, 89)
        Me.txtPurchasing_email.Name = "txtPurchasing_email"
        Me.txtPurchasing_email.Size = New System.Drawing.Size(277, 26)
        Me.txtPurchasing_email.TabIndex = 52
        '
        'txtOrderNotes
        '
        Me.txtOrderNotes.Location = New System.Drawing.Point(387, 543)
        Me.txtOrderNotes.Multiline = True
        Me.txtOrderNotes.Name = "txtOrderNotes"
        Me.txtOrderNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrderNotes.Size = New System.Drawing.Size(828, 52)
        Me.txtOrderNotes.TabIndex = 72
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtPO_DiscountAmount)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtPO_Amount)
        Me.GroupBox4.Controls.Add(Me.txtPO_Shipping)
        Me.GroupBox4.Controls.Add(Me.txtPO_TotalAmount)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 387)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(361, 189)
        Me.GroupBox4.TabIndex = 73
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PO Amounts:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 16)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Discount $:"
        '
        'txtPO_DiscountAmount
        '
        Me.txtPO_DiscountAmount.AcceptsTab = True
        Me.txtPO_DiscountAmount.Location = New System.Drawing.Point(88, 61)
        Me.txtPO_DiscountAmount.Name = "txtPO_DiscountAmount"
        Me.txtPO_DiscountAmount.Size = New System.Drawing.Size(258, 26)
        Me.txtPO_DiscountAmount.TabIndex = 21
        Me.txtPO_DiscountAmount.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(41, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 16)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(19, 99)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Shipping:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Amount:"
        '
        'txtPO_Amount
        '
        Me.txtPO_Amount.AcceptsTab = True
        Me.txtPO_Amount.Location = New System.Drawing.Point(88, 25)
        Me.txtPO_Amount.Name = "txtPO_Amount"
        Me.txtPO_Amount.Size = New System.Drawing.Size(258, 26)
        Me.txtPO_Amount.TabIndex = 20
        Me.txtPO_Amount.Text = "0.00"
        '
        'txtPO_Shipping
        '
        Me.txtPO_Shipping.Location = New System.Drawing.Point(88, 93)
        Me.txtPO_Shipping.Name = "txtPO_Shipping"
        Me.txtPO_Shipping.Size = New System.Drawing.Size(258, 26)
        Me.txtPO_Shipping.TabIndex = 22
        Me.txtPO_Shipping.Text = "0.00"
        '
        'txtPO_TotalAmount
        '
        Me.txtPO_TotalAmount.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPO_TotalAmount.Enabled = False
        Me.txtPO_TotalAmount.Location = New System.Drawing.Point(88, 128)
        Me.txtPO_TotalAmount.Name = "txtPO_TotalAmount"
        Me.txtPO_TotalAmount.Size = New System.Drawing.Size(258, 26)
        Me.txtPO_TotalAmount.TabIndex = 23
        Me.txtPO_TotalAmount.TabStop = False
        Me.txtPO_TotalAmount.Text = "0.00"
        '
        'cmbOrderStatus
        '
        Me.cmbOrderStatus.Location = New System.Drawing.Point(387, 511)
        Me.cmbOrderStatus.Name = "cmbOrderStatus"
        Me.cmbOrderStatus.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbOrderStatus.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbOrderStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbOrderStatus.Properties.Appearance.Options.UseBackColor = True
        Me.cmbOrderStatus.Properties.Appearance.Options.UseFont = True
        Me.cmbOrderStatus.Properties.Appearance.Options.UseForeColor = True
        Me.cmbOrderStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrderStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusID", "OrderStatusID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatus", "OrderStatus", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusColor", "OrderStatusColor", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbOrderStatus.Properties.DisplayMember = "OrderStatus"
        Me.cmbOrderStatus.Properties.EditValueChangedDelay = 1
        Me.cmbOrderStatus.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbOrderStatus.Properties.NullText = ""
        Me.cmbOrderStatus.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbOrderStatus.Properties.SortColumnIndex = 1
        Me.cmbOrderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbOrderStatus.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbOrderStatus.Properties.ValidateOnEnterKey = True
        Me.cmbOrderStatus.Properties.ValueMember = "OrderStatusID"
        Me.cmbOrderStatus.Size = New System.Drawing.Size(278, 26)
        Me.cmbOrderStatus.TabIndex = 74
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(386, 484)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 20)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Order Status:"
        '
        'txtCreateTime
        '
        Me.txtCreateTime.Enabled = False
        Me.txtCreateTime.Location = New System.Drawing.Point(509, 485)
        Me.txtCreateTime.Name = "txtCreateTime"
        Me.txtCreateTime.Size = New System.Drawing.Size(156, 20)
        Me.txtCreateTime.TabIndex = 76
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbOrderHasDiffCommisionItems)
        Me.GroupBox5.Controls.Add(Me.cmbSalesRep)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.txtSalesRep_OrderDescShort)
        Me.GroupBox5.Controls.Add(Me.txtSalesRep_CommissionRate)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(387, 387)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(740, 87)
        Me.GroupBox5.TabIndex = 77
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sales Rep"
        '
        'cmbOrderHasDiffCommisionItems
        '
        Me.cmbOrderHasDiffCommisionItems.FormattingEnabled = True
        Me.cmbOrderHasDiffCommisionItems.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.cmbOrderHasDiffCommisionItems.Location = New System.Drawing.Point(663, 53)
        Me.cmbOrderHasDiffCommisionItems.Name = "cmbOrderHasDiffCommisionItems"
        Me.cmbOrderHasDiffCommisionItems.Size = New System.Drawing.Size(62, 28)
        Me.cmbOrderHasDiffCommisionItems.TabIndex = 78
        '
        'cmbSalesRep
        '
        Me.cmbSalesRep.Location = New System.Drawing.Point(92, 20)
        Me.cmbSalesRep.Name = "cmbSalesRep"
        Me.cmbSalesRep.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbSalesRep.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbSalesRep.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesRep.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbSalesRep.Properties.Appearance.Options.UseBackColor = True
        Me.cmbSalesRep.Properties.Appearance.Options.UseFont = True
        Me.cmbSalesRep.Properties.Appearance.Options.UseForeColor = True
        Me.cmbSalesRep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSalesRep.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalesRepID", "SalesRepID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "CompanyName", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerritoryName", "TerritoryName", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbSalesRep.Properties.DisplayMember = "CompanyName"
        Me.cmbSalesRep.Properties.EditValueChangedDelay = 1
        Me.cmbSalesRep.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbSalesRep.Properties.NullText = ""
        Me.cmbSalesRep.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbSalesRep.Properties.SortColumnIndex = 1
        Me.cmbSalesRep.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbSalesRep.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbSalesRep.Properties.ValidateOnEnterKey = True
        Me.cmbSalesRep.Properties.ValueMember = "SalesRepID"
        Me.cmbSalesRep.Size = New System.Drawing.Size(347, 26)
        Me.cmbSalesRep.TabIndex = 75
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(481, 59)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(176, 16)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Different Commission Items?"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(537, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 16)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Commission Rate:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Order Desc:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(10, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 16)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Sales Rep:"
        '
        'txtSalesRep_OrderDescShort
        '
        Me.txtSalesRep_OrderDescShort.Location = New System.Drawing.Point(92, 51)
        Me.txtSalesRep_OrderDescShort.Name = "txtSalesRep_OrderDescShort"
        Me.txtSalesRep_OrderDescShort.Size = New System.Drawing.Size(347, 26)
        Me.txtSalesRep_OrderDescShort.TabIndex = 76
        '
        'txtSalesRep_CommissionRate
        '
        Me.txtSalesRep_CommissionRate.Location = New System.Drawing.Point(660, 21)
        Me.txtSalesRep_CommissionRate.Name = "txtSalesRep_CommissionRate"
        Me.txtSalesRep_CommissionRate.Size = New System.Drawing.Size(65, 26)
        Me.txtSalesRep_CommissionRate.TabIndex = 77
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(677, 486)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(123, 20)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Digital Status:"
        '
        'cmbOrderStatusDigital
        '
        Me.cmbOrderStatusDigital.Location = New System.Drawing.Point(681, 509)
        Me.cmbOrderStatusDigital.Name = "cmbOrderStatusDigital"
        Me.cmbOrderStatusDigital.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbOrderStatusDigital.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbOrderStatusDigital.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderStatusDigital.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbOrderStatusDigital.Properties.Appearance.Options.UseBackColor = True
        Me.cmbOrderStatusDigital.Properties.Appearance.Options.UseFont = True
        Me.cmbOrderStatusDigital.Properties.Appearance.Options.UseForeColor = True
        Me.cmbOrderStatusDigital.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrderStatusDigital.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusDigitalID", "OrderStatusDigitalID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusDigital", "OrderStatusDigital", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusDigitalColor", "OrderStatusDigitalColor", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbOrderStatusDigital.Properties.DisplayMember = "OrderStatusDigital"
        Me.cmbOrderStatusDigital.Properties.EditValueChangedDelay = 1
        Me.cmbOrderStatusDigital.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbOrderStatusDigital.Properties.NullText = ""
        Me.cmbOrderStatusDigital.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbOrderStatusDigital.Properties.SortColumnIndex = 1
        Me.cmbOrderStatusDigital.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbOrderStatusDigital.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbOrderStatusDigital.Properties.ValidateOnEnterKey = True
        Me.cmbOrderStatusDigital.Properties.ValueMember = "OrderStatusDigitalID"
        Me.cmbOrderStatusDigital.Size = New System.Drawing.Size(278, 26)
        Me.cmbOrderStatusDigital.TabIndex = 79
        '
        'cmbOrderStatusComm
        '
        Me.cmbOrderStatusComm.Location = New System.Drawing.Point(986, 509)
        Me.cmbOrderStatusComm.Name = "cmbOrderStatusComm"
        Me.cmbOrderStatusComm.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbOrderStatusComm.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbOrderStatusComm.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderStatusComm.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbOrderStatusComm.Properties.Appearance.Options.UseBackColor = True
        Me.cmbOrderStatusComm.Properties.Appearance.Options.UseFont = True
        Me.cmbOrderStatusComm.Properties.Appearance.Options.UseForeColor = True
        Me.cmbOrderStatusComm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrderStatusComm.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusCommID", "OrderStatusCommID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusComm", "OrderStatusComm", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderStatusCommColor", "OrderStatusCommColor", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbOrderStatusComm.Properties.DisplayMember = "OrderStatusComm"
        Me.cmbOrderStatusComm.Properties.EditValueChangedDelay = 1
        Me.cmbOrderStatusComm.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbOrderStatusComm.Properties.NullText = ""
        Me.cmbOrderStatusComm.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbOrderStatusComm.Properties.SortColumnIndex = 1
        Me.cmbOrderStatusComm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbOrderStatusComm.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbOrderStatusComm.Properties.ValidateOnEnterKey = True
        Me.cmbOrderStatusComm.Properties.ValueMember = "OrderStatusCommID"
        Me.cmbOrderStatusComm.Size = New System.Drawing.Size(229, 26)
        Me.cmbOrderStatusComm.TabIndex = 81
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(982, 486)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(154, 20)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "Comission Status:"
        '
        'frmNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 639)
        Me.Controls.Add(Me.cmbOrderStatusComm)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmbOrderStatusDigital)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtCreateTime)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmbOrderStatus)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtOrderNotes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmNewOrder"
        Me.Text = "frmNewOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbSchools2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDistricts2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStates2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cmbOrderStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.cmbSalesRep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrderStatusDigital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrderStatusComm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkAnyPartOfSchoolName As CheckBox
    Friend WithEvents lblSchools As Label
    Friend WithEvents lblDistricts As Label
    Friend WithEvents lblStates As Label
    Friend WithEvents chkShowOnlySchoolsWBooks As CheckBox
    Friend WithEvents txtSchoolID As TextBox
    Friend WithEvents txtDistrictID As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBillTo_Zip As TextBox
    Friend WithEvents txtBillTo_Name As TextBox
    Friend WithEvents txtBillTo_State As TextBox
    Friend WithEvents txtBillTo_Street As TextBox
    Friend WithEvents txtBillTo_City As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtShipTo_Attn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtShipTo_Zip As TextBox
    Friend WithEvents txtShipTo_Name As TextBox
    Friend WithEvents txtShipTo_State As TextBox
    Friend WithEvents txtShipTo_Address As TextBox
    Friend WithEvents txtShipTo_City As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBillTo_BHPO As TextBox
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSetDistrictBillToShipTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSetSchoolShipTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbStates2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDistricts2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSchools2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPurchasing_PurchasingPONumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPurchasing_Name As TextBox
    Friend WithEvents txtPurchasing_Phone As TextBox
    Friend WithEvents txtPurchasing_email As TextBox
    Friend WithEvents txtOrderNotes As TextBox
    Friend WithEvents txtPurchasing_DueDate As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPO_Amount As TextBox
    Friend WithEvents txtPO_Shipping As TextBox
    Friend WithEvents txtPO_TotalAmount As TextBox
    Friend WithEvents cmbOrderStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCreateTime As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPO_DiscountAmount As TextBox
    Friend WithEvents cmdSetDistrictBillTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTrackingNumbers As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtSalesRep_OrderDescShort As TextBox
    Friend WithEvents txtSalesRep_CommissionRate As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cmbSalesRep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbOrderHasDiffCommisionItems As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cmbOrderStatusDigital As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdViewDocuments As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbOrderStatusComm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label25 As Label
End Class
