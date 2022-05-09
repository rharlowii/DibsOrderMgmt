<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPubInvoiceItemsAdd
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbBHPONumber = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPartner = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdAddPubInvoice = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAddPubInvoicesLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateEditPlanToPayDate = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditDueDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPubInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.txtInvoiceAmount = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cmbBHPONumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DateEditPlanToPayDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditPlanToPayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1168, 76)
        Me.Panel1.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(553, 58)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Add Publisher Invoices"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmbBHPONumber)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmbPartner)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(3, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1168, 86)
        Me.Panel2.TabIndex = 6
        '
        'cmbBHPONumber
        '
        Me.cmbBHPONumber.Location = New System.Drawing.Point(99, 16)
        Me.cmbBHPONumber.Name = "cmbBHPONumber"
        Me.cmbBHPONumber.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbBHPONumber.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBHPONumber.Properties.Appearance.Options.UseFont = True
        Me.cmbBHPONumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBHPONumber.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BHPONumberID", "BHPONumberID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BHPONumber", "BH PO Number", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderID", "OrderID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbBHPONumber.Properties.EditValueChangedDelay = 1
        Me.cmbBHPONumber.Properties.NullText = ""
        Me.cmbBHPONumber.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbBHPONumber.Properties.SortColumnIndex = 1
        Me.cmbBHPONumber.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbBHPONumber.Properties.ValidateOnEnterKey = True
        Me.cmbBHPONumber.Size = New System.Drawing.Size(220, 26)
        Me.cmbBHPONumber.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "BP PO #:"
        '
        'cmbPartner
        '
        Me.cmbPartner.Location = New System.Drawing.Point(396, 16)
        Me.cmbPartner.Name = "cmbPartner"
        Me.cmbPartner.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbPartner.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartner.Properties.Appearance.Options.UseFont = True
        Me.cmbPartner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPartner.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartnerID", "PartnerID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PublisherName", "Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbPartner.Properties.EditValueChangedDelay = 1
        Me.cmbPartner.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbPartner.Properties.NullText = ""
        Me.cmbPartner.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbPartner.Properties.SortColumnIndex = 1
        Me.cmbPartner.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbPartner.Properties.ValidateOnEnterKey = True
        Me.cmbPartner.Size = New System.Drawing.Size(220, 26)
        Me.cmbPartner.TabIndex = 20
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(325, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 20)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "Partner:"
        '
        'cmdAddPubInvoice
        '
        Me.cmdAddPubInvoice.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPubInvoice.Appearance.Options.UseFont = True
        Me.cmdAddPubInvoice.Location = New System.Drawing.Point(394, 105)
        Me.cmdAddPubInvoice.Name = "cmdAddPubInvoice"
        Me.cmdAddPubInvoice.Size = New System.Drawing.Size(216, 28)
        Me.cmdAddPubInvoice.TabIndex = 70
        Me.cmdAddPubInvoice.Text = "Add/Update Pub Invoices"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtAddPubInvoicesLog)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1168, 412)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'txtAddPubInvoicesLog
        '
        Me.txtAddPubInvoicesLog.Location = New System.Drawing.Point(6, 182)
        Me.txtAddPubInvoicesLog.Multiline = True
        Me.txtAddPubInvoicesLog.Name = "txtAddPubInvoicesLog"
        Me.txtAddPubInvoicesLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddPubInvoicesLog.Size = New System.Drawing.Size(1156, 216)
        Me.txtAddPubInvoicesLog.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DateEditPlanToPayDate)
        Me.GroupBox1.Controls.Add(Me.DateEditDueDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cmdAddPubInvoice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPubInvoiceNumber)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceAmount)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 160)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pub PO Details:"
        '
        'DateEditPlanToPayDate
        '
        Me.DateEditPlanToPayDate.EditValue = Nothing
        Me.DateEditPlanToPayDate.Location = New System.Drawing.Point(608, 62)
        Me.DateEditPlanToPayDate.Name = "DateEditPlanToPayDate"
        Me.DateEditPlanToPayDate.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEditPlanToPayDate.Properties.Appearance.Options.UseFont = True
        Me.DateEditPlanToPayDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditPlanToPayDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditPlanToPayDate.Size = New System.Drawing.Size(211, 26)
        Me.DateEditPlanToPayDate.TabIndex = 60
        '
        'DateEditDueDate
        '
        Me.DateEditDueDate.EditValue = Nothing
        Me.DateEditDueDate.Location = New System.Drawing.Point(608, 31)
        Me.DateEditDueDate.Name = "DateEditDueDate"
        Me.DateEditDueDate.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEditDueDate.Properties.Appearance.Options.UseFont = True
        Me.DateEditDueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDueDate.Size = New System.Drawing.Size(211, 26)
        Me.DateEditDueDate.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(482, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Plan to Pay Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(482, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 16)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Due Date:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(129, 16)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Pub Invoice Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Pub Invoice Number:"
        '
        'txtPubInvoiceNumber
        '
        Me.txtPubInvoiceNumber.AcceptsTab = True
        Me.txtPubInvoiceNumber.Location = New System.Drawing.Point(163, 25)
        Me.txtPubInvoiceNumber.Name = "txtPubInvoiceNumber"
        Me.txtPubInvoiceNumber.Size = New System.Drawing.Size(277, 26)
        Me.txtPubInvoiceNumber.TabIndex = 30
        '
        'txtInvoiceAmount
        '
        Me.txtInvoiceAmount.Location = New System.Drawing.Point(163, 57)
        Me.txtInvoiceAmount.Name = "txtInvoiceAmount"
        Me.txtInvoiceAmount.Size = New System.Drawing.Size(277, 26)
        Me.txtInvoiceAmount.TabIndex = 40
        '
        'frmPubInvoiceItemsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 549)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPubInvoiceItemsAdd"
        Me.Text = "frmPubInvoiceItemsAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmbBHPONumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DateEditPlanToPayDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditPlanToPayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbPartner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdAddPubInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPubInvoiceNumber As TextBox
    Friend WithEvents txtInvoiceAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBHPONumber As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEditPlanToPayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditDueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddPubInvoicesLog As TextBox
End Class
