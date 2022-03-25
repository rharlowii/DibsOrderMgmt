<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEBookSales
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddeBookSales = New DevExpress.XtraEditors.SimpleButton()
        Me.gridEBookSales = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEbookSaleID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPubID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPubName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISBN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSchoolName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDistributor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.cmdRunDigtalReport = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.gridEBookSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdRunDigtalReport)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.cmdAddeBookSales)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 81)
        Me.Panel1.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(292, 58)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "eBook Sales"
        '
        'cmdAddeBookSales
        '
        Me.cmdAddeBookSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddeBookSales.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddeBookSales.Appearance.Options.UseFont = True
        Me.cmdAddeBookSales.Location = New System.Drawing.Point(797, 11)
        Me.cmdAddeBookSales.Name = "cmdAddeBookSales"
        Me.cmdAddeBookSales.Size = New System.Drawing.Size(184, 28)
        Me.cmdAddeBookSales.TabIndex = 1
        Me.cmdAddeBookSales.Text = "Add eBook Sales"
        '
        'gridEBookSales
        '
        Me.gridEBookSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridEBookSales.DataMember = "omqryOrderItems"
        Me.gridEBookSales.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEBookSales.Location = New System.Drawing.Point(1, 88)
        Me.gridEBookSales.MainView = Me.Gridview1
        Me.gridEBookSales.Name = "gridEBookSales"
        Me.gridEBookSales.Size = New System.Drawing.Size(1006, 627)
        Me.gridEBookSales.TabIndex = 8
        Me.gridEBookSales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1, Me.CardView1})
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEbookSaleID, Me.colOrderID, Me.colPubID, Me.colPubName, Me.colISBN, Me.colTitle, Me.colPrice, Me.colSchoolName, Me.colLoadDate, Me.colDistributor, Me.colQTY})
        Me.Gridview1.GridControl = Me.gridEBookSales
        Me.Gridview1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", Nothing, "SUM={0:0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QTY", Nothing, "(QTY: SUM={0:0})")})
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.AutoExpandAllGroups = True
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsView.ShowAutoFilterRow = True
        Me.Gridview1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'colEbookSaleID
        '
        Me.colEbookSaleID.Caption = "EbookSaleID"
        Me.colEbookSaleID.FieldName = "EbookSaleID"
        Me.colEbookSaleID.Name = "colEbookSaleID"
        '
        'colOrderID
        '
        Me.colOrderID.Caption = "OrderID"
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        '
        'colPubID
        '
        Me.colPubID.Caption = "PubID"
        Me.colPubID.FieldName = "PubID"
        Me.colPubID.Name = "colPubID"
        '
        'colPubName
        '
        Me.colPubName.Caption = "Pub Name"
        Me.colPubName.FieldName = "PubName"
        Me.colPubName.Name = "colPubName"
        Me.colPubName.Visible = True
        Me.colPubName.VisibleIndex = 0
        '
        'colISBN
        '
        Me.colISBN.Caption = "ISBN"
        Me.colISBN.FieldName = "ISBN"
        Me.colISBN.Name = "colISBN"
        Me.colISBN.Visible = True
        Me.colISBN.VisibleIndex = 1
        '
        'colTitle
        '
        Me.colTitle.Caption = "Title"
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 2
        '
        'colPrice
        '
        Me.colPrice.Caption = "Price"
        Me.colPrice.DisplayFormat.FormatString = "c2"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 3
        '
        'colSchoolName
        '
        Me.colSchoolName.Caption = "School Name"
        Me.colSchoolName.FieldName = "SchoolName"
        Me.colSchoolName.Name = "colSchoolName"
        Me.colSchoolName.Visible = True
        Me.colSchoolName.VisibleIndex = 4
        '
        'colLoadDate
        '
        Me.colLoadDate.Caption = "Load Date"
        Me.colLoadDate.FieldName = "LoadDate"
        Me.colLoadDate.Name = "colLoadDate"
        Me.colLoadDate.Visible = True
        Me.colLoadDate.VisibleIndex = 5
        '
        'colDistributor
        '
        Me.colDistributor.Caption = "Distributor"
        Me.colDistributor.FieldName = "Distributor"
        Me.colDistributor.Name = "colDistributor"
        Me.colDistributor.Visible = True
        Me.colDistributor.VisibleIndex = 6
        '
        'colQTY
        '
        Me.colQTY.Caption = "QTY"
        Me.colQTY.FieldName = "QTY"
        Me.colQTY.Name = "colQTY"
        Me.colQTY.Visible = True
        Me.colQTY.VisibleIndex = 7
        '
        'CardView1
        '
        Me.CardView1.Appearance.Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CardView1.Appearance.Card.Options.UseBackColor = True
        Me.CardView1.GridControl = Me.gridEBookSales
        Me.CardView1.Name = "CardView1"
        Me.CardView1.PaintStyleName = "Flat"
        '
        'cmdRunDigtalReport
        '
        Me.cmdRunDigtalReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRunDigtalReport.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRunDigtalReport.Appearance.Options.UseFont = True
        Me.cmdRunDigtalReport.Location = New System.Drawing.Point(797, 45)
        Me.cmdRunDigtalReport.Name = "cmdRunDigtalReport"
        Me.cmdRunDigtalReport.Size = New System.Drawing.Size(184, 28)
        Me.cmdRunDigtalReport.TabIndex = 8
        Me.cmdRunDigtalReport.Text = "Run Digital Report"
        '
        'frmEBookSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 719)
        Me.Controls.Add(Me.gridEBookSales)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEBookSales"
        Me.Text = "frmEBookSales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridEBookSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddeBookSales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridEBookSales As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEbookSaleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPubID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPubName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISBN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSchoolName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistributor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents cmdRunDigtalReport As DevExpress.XtraEditors.SimpleButton
End Class
