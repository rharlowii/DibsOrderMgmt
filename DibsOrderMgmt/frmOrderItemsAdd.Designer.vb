<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderItemsAdd
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.mainTab = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbOrderSet = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAddOrderItemsByISBN = New DevExpress.XtraEditors.SimpleButton()
        Me.spreadAddByISBN = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdClearOrderItemsFreeForm = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPartner = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbOrderSet2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAddOrderItemsFreeForm = New DevExpress.XtraEditors.SimpleButton()
        Me.spreadAddFreeForm = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.mainTab.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cmbOrderSet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cmbPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrderSet2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1147, 76)
        Me.Panel1.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(402, 58)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Add Order Items"
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(5, 84)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.mainTab
        Me.XtraTabControl1.Size = New System.Drawing.Size(1144, 564)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.mainTab, Me.XtraTabPage2})
        '
        'mainTab
        '
        Me.mainTab.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.mainTab.Appearance.PageClient.BackColor2 = System.Drawing.Color.White
        Me.mainTab.Appearance.PageClient.Options.UseBackColor = True
        Me.mainTab.Controls.Add(Me.Panel3)
        Me.mainTab.Controls.Add(Me.spreadAddByISBN)
        Me.mainTab.Name = "mainTab"
        Me.mainTab.Size = New System.Drawing.Size(1142, 519)
        Me.mainTab.Text = "Add by ISBN"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cmbOrderSet)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cmdAddOrderItemsByISBN)
        Me.Panel3.Location = New System.Drawing.Point(6, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1117, 55)
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
        'cmdAddOrderItemsByISBN
        '
        Me.cmdAddOrderItemsByISBN.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddOrderItemsByISBN.Appearance.Options.UseFont = True
        Me.cmdAddOrderItemsByISBN.Location = New System.Drawing.Point(604, 13)
        Me.cmdAddOrderItemsByISBN.Name = "cmdAddOrderItemsByISBN"
        Me.cmdAddOrderItemsByISBN.Size = New System.Drawing.Size(175, 28)
        Me.cmdAddOrderItemsByISBN.TabIndex = 5
        Me.cmdAddOrderItemsByISBN.Text = "Add Order Items"
        '
        'spreadAddByISBN
        '
        Me.spreadAddByISBN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spreadAddByISBN.Location = New System.Drawing.Point(3, 64)
        Me.spreadAddByISBN.Name = "spreadAddByISBN"
        Me.spreadAddByISBN.Size = New System.Drawing.Size(1120, 423)
        Me.spreadAddByISBN.TabIndex = 1
        Me.spreadAddByISBN.Text = "spreadAddByISBN"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Controls.Add(Me.spreadAddFreeForm)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1142, 519)
        Me.XtraTabPage2.Text = "Add Free Form"
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
        Me.Panel2.Size = New System.Drawing.Size(1133, 55)
        Me.Panel2.TabIndex = 5
        '
        'cmdClearOrderItemsFreeForm
        '
        Me.cmdClearOrderItemsFreeForm.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearOrderItemsFreeForm.Appearance.Options.UseFont = True
        Me.cmdClearOrderItemsFreeForm.Location = New System.Drawing.Point(936, 15)
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
        Me.cmdAddOrderItemsFreeForm.Location = New System.Drawing.Point(736, 15)
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
        Me.spreadAddFreeForm.Name = "spreadAddFreeForm"
        Me.spreadAddFreeForm.Size = New System.Drawing.Size(1136, 449)
        Me.spreadAddFreeForm.TabIndex = 4
        Me.spreadAddFreeForm.Text = "SpreadsheetControl1"
        '
        'frmOrderItemsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1147, 653)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOrderItemsAdd"
        Me.Text = "frmOrderItemsAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents mainTab As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents spreadAddByISBN As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmdAddOrderItemsByISBN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbOrderSet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbPartner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbOrderSet2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdAddOrderItemsFreeForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spreadAddFreeForm As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents cmdClearOrderItemsFreeForm As DevExpress.XtraEditors.SimpleButton
End Class
