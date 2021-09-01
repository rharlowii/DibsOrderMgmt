<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSets
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
        Me.gridOrderSets = New DevExpress.XtraGrid.GridControl()
        Me.DiBS_DB_ProdDataSet21 = New DibsOrderMgmt.DiBS_DB_ProdDataSet2()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderSetID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSetDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ListPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExtendPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OmOrderSetsTableAdapter1 = New DibsOrderMgmt.DiBS_DB_ProdDataSet2TableAdapters.omOrderSetsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddNewOrderSet = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem1_EditOrderSet = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.gridOrderSets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiBS_DB_ProdDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridOrderSets
        '
        Me.gridOrderSets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrderSets.DataMember = "omOrderSets"
        Me.gridOrderSets.DataSource = Me.DiBS_DB_ProdDataSet21
        Me.gridOrderSets.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridOrderSets.Location = New System.Drawing.Point(-1, 85)
        Me.gridOrderSets.MainView = Me.GridView1
        Me.gridOrderSets.Name = "gridOrderSets"
        Me.gridOrderSets.Size = New System.Drawing.Size(1131, 321)
        Me.gridOrderSets.TabIndex = 0
        Me.gridOrderSets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DiBS_DB_ProdDataSet21
        '
        Me.DiBS_DB_ProdDataSet21.DataSetName = "DiBS_DB_ProdDataSet2"
        Me.DiBS_DB_ProdDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderSetID, Me.colOrderID, Me.colSetName, Me.colSetDesc, Me.QTY, Me.ListPrice, Me.ExtendPrice})
        Me.GridView1.GridControl = Me.gridOrderSets
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colOrderSetID
        '
        Me.colOrderSetID.FieldName = "OrderSetID"
        Me.colOrderSetID.Name = "colOrderSetID"
        '
        'colOrderID
        '
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        '
        'colSetName
        '
        Me.colSetName.Caption = "Set Name/Number"
        Me.colSetName.FieldName = "SetName"
        Me.colSetName.Name = "colSetName"
        Me.colSetName.OptionsEditForm.StartNewRow = True
        Me.colSetName.Visible = True
        Me.colSetName.VisibleIndex = 0
        Me.colSetName.Width = 254
        '
        'colSetDesc
        '
        Me.colSetDesc.FieldName = "SetDesc"
        Me.colSetDesc.Name = "colSetDesc"
        Me.colSetDesc.OptionsEditForm.StartNewRow = True
        Me.colSetDesc.Visible = True
        Me.colSetDesc.VisibleIndex = 1
        Me.colSetDesc.Width = 254
        '
        'QTY
        '
        Me.QTY.Caption = "QTY"
        Me.QTY.FieldName = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.OptionsEditForm.StartNewRow = True
        Me.QTY.Visible = True
        Me.QTY.VisibleIndex = 2
        Me.QTY.Width = 88
        '
        'ListPrice
        '
        Me.ListPrice.Caption = "List Price"
        Me.ListPrice.DisplayFormat.FormatString = "c2"
        Me.ListPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ListPrice.FieldName = "ListPrice"
        Me.ListPrice.Name = "ListPrice"
        Me.ListPrice.Visible = True
        Me.ListPrice.VisibleIndex = 3
        Me.ListPrice.Width = 254
        '
        'ExtendPrice
        '
        Me.ExtendPrice.Caption = "Extend Price"
        Me.ExtendPrice.DisplayFormat.FormatString = "c2"
        Me.ExtendPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ExtendPrice.FieldName = "ExtendPrice"
        Me.ExtendPrice.Name = "ExtendPrice"
        Me.ExtendPrice.Visible = True
        Me.ExtendPrice.VisibleIndex = 4
        Me.ExtendPrice.Width = 256
        '
        'OmOrderSetsTableAdapter1
        '
        Me.OmOrderSetsTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.cmdAddNewOrderSet)
        Me.Panel1.Location = New System.Drawing.Point(-1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1131, 77)
        Me.Panel1.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(256, 58)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Order Sets"
        '
        'cmdAddNewOrderSet
        '
        Me.cmdAddNewOrderSet.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewOrderSet.Appearance.Options.UseFont = True
        Me.cmdAddNewOrderSet.Location = New System.Drawing.Point(943, 26)
        Me.cmdAddNewOrderSet.Name = "cmdAddNewOrderSet"
        Me.cmdAddNewOrderSet.Size = New System.Drawing.Size(150, 28)
        Me.cmdAddNewOrderSet.TabIndex = 7
        Me.cmdAddNewOrderSet.Text = "Add Order Set"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_EditOrderSet)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarButtonItem1_EditOrderSet
        '
        Me.BarButtonItem1_EditOrderSet.Caption = "Edit Order Set"
        Me.BarButtonItem1_EditOrderSet.Id = 0
        Me.BarButtonItem1_EditOrderSet.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem1_EditOrderSet.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1_EditOrderSet.Name = "BarButtonItem1_EditOrderSet"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1_EditOrderSet})
        Me.BarManager1.MaxItemId = 1
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1131, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 410)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1131, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 410)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1131, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 410)
        '
        'frmOrderSets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1131, 410)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridOrderSets)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmOrderSets"
        Me.Text = "frmOrderSets"
        CType(Me.gridOrderSets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiBS_DB_ProdDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridOrderSets As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DiBS_DB_ProdDataSet21 As DiBS_DB_ProdDataSet2
    Friend WithEvents colOrderSetID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OmOrderSetsTableAdapter1 As DiBS_DB_ProdDataSet2TableAdapters.omOrderSetsTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddNewOrderSet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExtendPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1_EditOrderSet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
