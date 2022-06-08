<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderItemsMatchingEBooks
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdGenerateLabels = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdToggleRowCellSelection = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExportGrid = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
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
        Me.Guided_Reading_Level = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Classification = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.eBook_ISBN_13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EBookPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ISBN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OfficialImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.Panel1.SuspendLayout()
        CType(Me.gridOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdGenerateLabels)
        Me.Panel1.Controls.Add(Me.cmdToggleRowCellSelection)
        Me.Panel1.Controls.Add(Me.cmdExportGrid)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 128)
        Me.Panel1.TabIndex = 7
        '
        'cmdGenerateLabels
        '
        Me.cmdGenerateLabels.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateLabels.Appearance.Options.UseFont = True
        Me.cmdGenerateLabels.Location = New System.Drawing.Point(145, 96)
        Me.cmdGenerateLabels.Name = "cmdGenerateLabels"
        Me.cmdGenerateLabels.Size = New System.Drawing.Size(211, 28)
        Me.cmdGenerateLabels.TabIndex = 10
        Me.cmdGenerateLabels.Text = "Generate Labels"
        '
        'cmdToggleRowCellSelection
        '
        Me.cmdToggleRowCellSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdToggleRowCellSelection.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdToggleRowCellSelection.Appearance.Options.UseFont = True
        Me.cmdToggleRowCellSelection.Location = New System.Drawing.Point(1098, 95)
        Me.cmdToggleRowCellSelection.Name = "cmdToggleRowCellSelection"
        Me.cmdToggleRowCellSelection.Size = New System.Drawing.Size(154, 28)
        Me.cmdToggleRowCellSelection.TabIndex = 9
        Me.cmdToggleRowCellSelection.Text = "Checkbox Select"
        '
        'cmdExportGrid
        '
        Me.cmdExportGrid.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportGrid.Appearance.Options.UseFont = True
        Me.cmdExportGrid.Location = New System.Drawing.Point(8, 97)
        Me.cmdExportGrid.Name = "cmdExportGrid"
        Me.cmdExportGrid.Size = New System.Drawing.Size(130, 28)
        Me.cmdExportGrid.TabIndex = 8
        Me.cmdExportGrid.Text = "Export Grid"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(757, 58)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Order Items - Matching eBooks"
        '
        'gridOrderItems
        '
        Me.gridOrderItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrderItems.DataMember = "omqryOrderItems"
        Me.gridOrderItems.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.gridOrderItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gridOrderItems.Location = New System.Drawing.Point(4, 140)
        Me.gridOrderItems.MainView = Me.Gridview1
        Me.gridOrderItems.Name = "gridOrderItems"
        Me.gridOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.gridOrderItems.Size = New System.Drawing.Size(1259, 678)
        Me.gridOrderItems.TabIndex = 8
        Me.gridOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1, Me.CardView1})
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderItemID, Me.colOrderID, Me.colOrderSetID, Me.colBoxNumber, Me.colSetName, Me.colPartnerID, Me.colPublisherShortName, Me.colMetaDataID, Me.colItemNumber, Me.colItemDesc, Me.Guided_Reading_Level, Me.Classification, Me.eBook_ISBN_13, Me.EBookPath, Me.ISBN, Me.OfficialImage, Me.IsSelected})
        Me.Gridview1.GridControl = Me.gridOrderItems
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.AutoExpandAllGroups = True
        Me.Gridview1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.Gridview1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Gridview1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.Gridview1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.Gridview1.OptionsView.ShowAutoFilterRow = True
        Me.Gridview1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
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
        Me.colBoxNumber.OptionsColumn.AllowEdit = False
        Me.colBoxNumber.Width = 221
        '
        'colSetName
        '
        Me.colSetName.FieldName = "SetName"
        Me.colSetName.Name = "colSetName"
        Me.colSetName.OptionsColumn.AllowEdit = False
        Me.colSetName.Visible = True
        Me.colSetName.VisibleIndex = 9
        '
        'colPartnerID
        '
        Me.colPartnerID.FieldName = "PartnerID"
        Me.colPartnerID.Name = "colPartnerID"
        Me.colPartnerID.OptionsColumn.AllowEdit = False
        '
        'colPublisherShortName
        '
        Me.colPublisherShortName.FieldName = "PublisherShortName"
        Me.colPublisherShortName.MinWidth = 10
        Me.colPublisherShortName.Name = "colPublisherShortName"
        Me.colPublisherShortName.OptionsColumn.AllowEdit = False
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
        Me.colItemNumber.OptionsColumn.AllowEdit = False
        Me.colItemNumber.Visible = True
        Me.colItemNumber.VisibleIndex = 1
        Me.colItemNumber.Width = 142
        '
        'colItemDesc
        '
        Me.colItemDesc.FieldName = "ItemDesc"
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.OptionsColumn.AllowEdit = False
        Me.colItemDesc.Visible = True
        Me.colItemDesc.VisibleIndex = 2
        Me.colItemDesc.Width = 253
        '
        'Guided_Reading_Level
        '
        Me.Guided_Reading_Level.Caption = "GRL"
        Me.Guided_Reading_Level.FieldName = "Guided_Reading_Level"
        Me.Guided_Reading_Level.Name = "Guided_Reading_Level"
        Me.Guided_Reading_Level.Visible = True
        Me.Guided_Reading_Level.VisibleIndex = 4
        '
        'Classification
        '
        Me.Classification.Caption = "Classification"
        Me.Classification.FieldName = "Classification"
        Me.Classification.Name = "Classification"
        Me.Classification.Visible = True
        Me.Classification.VisibleIndex = 3
        '
        'eBook_ISBN_13
        '
        Me.eBook_ISBN_13.Caption = "eBook_ISBN_13"
        Me.eBook_ISBN_13.FieldName = "eBook_ISBN_13"
        Me.eBook_ISBN_13.Name = "eBook_ISBN_13"
        Me.eBook_ISBN_13.Visible = True
        Me.eBook_ISBN_13.VisibleIndex = 5
        '
        'EBookPath
        '
        Me.EBookPath.Caption = "EBookPath"
        Me.EBookPath.FieldName = "EBookPath"
        Me.EBookPath.Name = "EBookPath"
        Me.EBookPath.Visible = True
        Me.EBookPath.VisibleIndex = 6
        '
        'ISBN
        '
        Me.ISBN.Caption = "Books ISBN"
        Me.ISBN.FieldName = "ISBN"
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Visible = True
        Me.ISBN.VisibleIndex = 7
        '
        'OfficialImage
        '
        Me.OfficialImage.Caption = "OfficialImage"
        Me.OfficialImage.FieldName = "OfficialImage"
        Me.OfficialImage.Name = "OfficialImage"
        Me.OfficialImage.Visible = True
        Me.OfficialImage.VisibleIndex = 8
        '
        'IsSelected
        '
        Me.IsSelected.Caption = "IsSelected"
        Me.IsSelected.Name = "IsSelected"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'CardView1
        '
        Me.CardView1.Appearance.Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CardView1.Appearance.Card.Options.UseBackColor = True
        Me.CardView1.GridControl = Me.gridOrderItems
        Me.CardView1.Name = "CardView1"
        Me.CardView1.PaintStyleName = "Flat"
        '
        'frmOrderItemsMatchingEBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 830)
        Me.Controls.Add(Me.gridOrderItems)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOrderItemsMatchingEBooks"
        Me.Text = "frmOrderItemsMatchingEBooks"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents Guided_Reading_Level As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Classification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eBook_ISBN_13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EBookPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ISBN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OfficialImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents cmdExportGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdToggleRowCellSelection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGenerateLabels As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IsSelected As DevExpress.XtraGrid.Columns.GridColumn
End Class
