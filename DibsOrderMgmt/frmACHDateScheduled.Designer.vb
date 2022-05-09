<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmACHDateScheduled
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
        Me.lblTotalInvoiceAmounts = New System.Windows.Forms.Label()
        Me.lblPublisherName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateEditInvoicePaidDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdMarkInvoicesPaid = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridPubInvoices2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PubPaymentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartnerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InvoiceAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NetTermDays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PlanToPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DatePaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.PublisherInvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lPublisherName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEditInvoicePaidDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditInvoicePaidDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPubInvoices2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTotalInvoiceAmounts)
        Me.Panel1.Controls.Add(Me.lblPublisherName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateEditInvoicePaidDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdMarkInvoicesPaid)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 235)
        Me.Panel1.TabIndex = 7
        '
        'lblTotalInvoiceAmounts
        '
        Me.lblTotalInvoiceAmounts.AutoSize = True
        Me.lblTotalInvoiceAmounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInvoiceAmounts.Location = New System.Drawing.Point(256, 134)
        Me.lblTotalInvoiceAmounts.Name = "lblTotalInvoiceAmounts"
        Me.lblTotalInvoiceAmounts.Size = New System.Drawing.Size(75, 20)
        Me.lblTotalInvoiceAmounts.TabIndex = 77
        Me.lblTotalInvoiceAmounts.Text = "{Amount}"
        '
        'lblPublisherName
        '
        Me.lblPublisherName.AutoSize = True
        Me.lblPublisherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisherName.Location = New System.Drawing.Point(256, 102)
        Me.lblPublisherName.Name = "lblPublisherName"
        Me.lblPublisherName.Size = New System.Drawing.Size(84, 20)
        Me.lblPublisherName.TabIndex = 76
        Me.lblPublisherName.Text = "{Publisher}"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Total Amount of Invoices:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Publisher:"
        '
        'DateEditInvoicePaidDate
        '
        Me.DateEditInvoicePaidDate.EditValue = Nothing
        Me.DateEditInvoicePaidDate.Location = New System.Drawing.Point(256, 161)
        Me.DateEditInvoicePaidDate.Name = "DateEditInvoicePaidDate"
        Me.DateEditInvoicePaidDate.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEditInvoicePaidDate.Properties.Appearance.Options.UseFont = True
        Me.DateEditInvoicePaidDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditInvoicePaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditInvoicePaidDate.Size = New System.Drawing.Size(211, 26)
        Me.DateEditInvoicePaidDate.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Invoice Paid Date:"
        '
        'cmdMarkInvoicesPaid
        '
        Me.cmdMarkInvoicesPaid.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMarkInvoicesPaid.Appearance.Options.UseFont = True
        Me.cmdMarkInvoicesPaid.Location = New System.Drawing.Point(256, 195)
        Me.cmdMarkInvoicesPaid.Name = "cmdMarkInvoicesPaid"
        Me.cmdMarkInvoicesPaid.Size = New System.Drawing.Size(211, 28)
        Me.cmdMarkInvoicesPaid.TabIndex = 73
        Me.cmdMarkInvoicesPaid.Text = "Mark Pub Invoices Paid"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(594, 58)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "ACH Payment Scheduled"
        '
        'gridPubInvoices2
        '
        Me.gridPubInvoices2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPubInvoices2.DataMember = "omqryOrdersMain"
        Me.gridPubInvoices2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPubInvoices2.Location = New System.Drawing.Point(3, 244)
        Me.gridPubInvoices2.MainView = Me.GridView3
        Me.gridPubInvoices2.Name = "gridPubInvoices2"
        Me.gridPubInvoices2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.gridPubInvoices2.Size = New System.Drawing.Size(900, 403)
        Me.gridPubInvoices2.TabIndex = 9
        Me.gridPubInvoices2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PubPaymentID, Me.OrderID, Me.PartnerID, Me.GridColumn4, Me.lPublisherName, Me.PublisherInvoiceNumber, Me.InvoiceAmount, Me.NetTermDays, Me.DueDate, Me.PlanToPay, Me.DatePaid})
        Me.GridView3.GridControl = Me.gridPubInvoices2
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
        Me.NetTermDays.Width = 101
        '
        'DueDate
        '
        Me.DueDate.Caption = "Due Date"
        Me.DueDate.FieldName = "DueDate"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.Visible = True
        Me.DueDate.VisibleIndex = 4
        Me.DueDate.Width = 101
        '
        'PlanToPay
        '
        Me.PlanToPay.Caption = "Plan To Pay Date"
        Me.PlanToPay.FieldName = "PlanToPay"
        Me.PlanToPay.Name = "PlanToPay"
        Me.PlanToPay.Visible = True
        Me.PlanToPay.VisibleIndex = 5
        Me.PlanToPay.Width = 101
        '
        'DatePaid
        '
        Me.DatePaid.Caption = "Date Paid"
        Me.DatePaid.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.DatePaid.FieldName = "DatePaid"
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.Width = 109
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'PublisherInvoiceNumber
        '
        Me.PublisherInvoiceNumber.Caption = "Publisher Invoice #"
        Me.PublisherInvoiceNumber.FieldName = "PublisherInvoiceNumber"
        Me.PublisherInvoiceNumber.Name = "PublisherInvoiceNumber"
        Me.PublisherInvoiceNumber.Visible = True
        Me.PublisherInvoiceNumber.VisibleIndex = 2
        '
        'lPublisherName
        '
        Me.lPublisherName.Caption = "Publisher Name"
        Me.lPublisherName.FieldName = "PublisherName"
        Me.lPublisherName.Name = "lPublisherName"
        Me.lPublisherName.Visible = True
        Me.lPublisherName.VisibleIndex = 1
        '
        'frmACHDateScheduled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 659)
        Me.Controls.Add(Me.gridPubInvoices2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmACHDateScheduled"
        Me.Text = "frmACHDateScheduled"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DateEditInvoicePaidDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditInvoicePaidDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPubInvoices2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditInvoicePaidDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdMarkInvoicesPaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotalInvoiceAmounts As Label
    Friend WithEvents lblPublisherName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gridPubInvoices2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PubPaymentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartnerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvoiceAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NetTermDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PlanToPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DatePaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lPublisherName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PublisherInvoiceNumber As DevExpress.XtraGrid.Columns.GridColumn
End Class
