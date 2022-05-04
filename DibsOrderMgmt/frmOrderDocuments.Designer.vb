<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderDocuments
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
        Me.gridDocuments = New DevExpress.XtraGrid.GridControl()
        Me.DiBS_DB_ProdDataSet11 = New DibsOrderMgmt.DiBS_DB_ProdDataSet1()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderDocTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDocName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDocTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDocNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1_ViewDocument = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1_SendDocumentToEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1_EditDocumentInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1_DeleteDocument = New DevExpress.XtraBars.BarButtonItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddNewDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.OmOrderDocumentsTableAdapter1 = New DibsOrderMgmt.DiBS_DB_ProdDataSet1TableAdapters.omOrderDocumentsTableAdapter()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.gridDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiBS_DB_ProdDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridDocuments
        '
        Me.gridDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDocuments.DataMember = "omOrderDocuments"
        Me.gridDocuments.DataSource = Me.DiBS_DB_ProdDataSet11
        Me.gridDocuments.Location = New System.Drawing.Point(4, 87)
        Me.gridDocuments.MainView = Me.GridView1
        Me.gridDocuments.MenuManager = Me.BarManager1
        Me.gridDocuments.Name = "gridDocuments"
        Me.gridDocuments.Size = New System.Drawing.Size(795, 351)
        Me.gridDocuments.TabIndex = 0
        Me.gridDocuments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DiBS_DB_ProdDataSet11
        '
        Me.DiBS_DB_ProdDataSet11.DataSetName = "DiBS_DB_ProdDataSet1"
        Me.DiBS_DB_ProdDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colDocumentID, Me.OrderDocTypeName, Me.colOrderDocName, Me.colOrderDocTypeID, Me.colOrderDocNotes, Me.colCreateTime, Me.colUpdateTime})
        Me.GridView1.GridControl = Me.gridDocuments
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colOrderID
        '
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        '
        'colDocumentID
        '
        Me.colDocumentID.FieldName = "DocumentID"
        Me.colDocumentID.Name = "colDocumentID"
        '
        'OrderDocTypeName
        '
        Me.OrderDocTypeName.Caption = "Doc Type"
        Me.OrderDocTypeName.FieldName = "OrderDocTypeName"
        Me.OrderDocTypeName.Name = "OrderDocTypeName"
        Me.OrderDocTypeName.Visible = True
        Me.OrderDocTypeName.VisibleIndex = 0
        '
        'colOrderDocName
        '
        Me.colOrderDocName.Caption = "Document Name"
        Me.colOrderDocName.FieldName = "OrderDocName"
        Me.colOrderDocName.Name = "colOrderDocName"
        Me.colOrderDocName.Visible = True
        Me.colOrderDocName.VisibleIndex = 1
        '
        'colOrderDocTypeID
        '
        Me.colOrderDocTypeID.FieldName = "OrderDocTypeID"
        Me.colOrderDocTypeID.Name = "colOrderDocTypeID"
        '
        'colOrderDocNotes
        '
        Me.colOrderDocNotes.Caption = "Notes"
        Me.colOrderDocNotes.FieldName = "OrderDocNotes"
        Me.colOrderDocNotes.Name = "colOrderDocNotes"
        Me.colOrderDocNotes.Visible = True
        Me.colOrderDocNotes.VisibleIndex = 2
        '
        'colCreateTime
        '
        Me.colCreateTime.Caption = "Created"
        Me.colCreateTime.FieldName = "CreateTime"
        Me.colCreateTime.Name = "colCreateTime"
        Me.colCreateTime.Visible = True
        Me.colCreateTime.VisibleIndex = 3
        '
        'colUpdateTime
        '
        Me.colUpdateTime.FieldName = "UpdateTime"
        Me.colUpdateTime.Name = "colUpdateTime"
        Me.colUpdateTime.Visible = True
        Me.colUpdateTime.VisibleIndex = 4
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1_ViewDocument, Me.BarStaticItem1, Me.BarButtonItem1_SendDocumentToEmail, Me.BarStaticItem2, Me.BarButtonItem1_EditDocumentInfo, Me.BarStaticItem3, Me.BarButtonItem1_DeleteDocument})
        Me.BarManager1.MaxItemId = 7
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(800, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 450)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(800, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 450)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(800, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 450)
        '
        'BarButtonItem1_ViewDocument
        '
        Me.BarButtonItem1_ViewDocument.Caption = "View Document"
        Me.BarButtonItem1_ViewDocument.Id = 0
        Me.BarButtonItem1_ViewDocument.Name = "BarButtonItem1_ViewDocument"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarButtonItem1_SendDocumentToEmail
        '
        Me.BarButtonItem1_SendDocumentToEmail.Caption = "Send Selected Documents to Email"
        Me.BarButtonItem1_SendDocumentToEmail.Id = 2
        Me.BarButtonItem1_SendDocumentToEmail.ItemAppearance.Hovered.Options.UseTextOptions = True
        Me.BarButtonItem1_SendDocumentToEmail.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BarButtonItem1_SendDocumentToEmail.ItemAppearance.Normal.Options.UseTextOptions = True
        Me.BarButtonItem1_SendDocumentToEmail.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BarButtonItem1_SendDocumentToEmail.Name = "BarButtonItem1_SendDocumentToEmail"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Id = 3
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarButtonItem1_EditDocumentInfo
        '
        Me.BarButtonItem1_EditDocumentInfo.Caption = "Edit Document  Info"
        Me.BarButtonItem1_EditDocumentInfo.Id = 4
        Me.BarButtonItem1_EditDocumentInfo.Name = "BarButtonItem1_EditDocumentInfo"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Id = 5
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarButtonItem1_DeleteDocument
        '
        Me.BarButtonItem1_DeleteDocument.Caption = "Delete Document"
        Me.BarButtonItem1_DeleteDocument.Id = 6
        Me.BarButtonItem1_DeleteDocument.Name = "BarButtonItem1_DeleteDocument"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.cmdAddNewDocument)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 78)
        Me.Panel1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(273, 58)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Documents"
        '
        'cmdAddNewDocument
        '
        Me.cmdAddNewDocument.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewDocument.Appearance.Options.UseFont = True
        Me.cmdAddNewDocument.Location = New System.Drawing.Point(599, 35)
        Me.cmdAddNewDocument.Name = "cmdAddNewDocument"
        Me.cmdAddNewDocument.Size = New System.Drawing.Size(175, 28)
        Me.cmdAddNewDocument.TabIndex = 5
        Me.cmdAddNewDocument.Text = "Add Document"
        '
        'OmOrderDocumentsTableAdapter1
        '
        Me.OmOrderDocumentsTableAdapter1.ClearBeforeFill = True
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_ViewDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_SendDocumentToEmail), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_EditDocumentInfo), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1_DeleteDocument)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = True
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Hovered.Options.UseTextOptions = True
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = True
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Normal.Options.UseTextOptions = True
        Me.PopupMenu1.MenuAppearance.AppearanceMenu.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'frmOrderDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridDocuments)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmOrderDocuments"
        Me.Text = "frmOrderDocuments"
        CType(Me.gridDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiBS_DB_ProdDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridDocuments As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DiBS_DB_ProdDataSet11 As DiBS_DB_ProdDataSet1
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDocName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDocTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDocNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OmOrderDocumentsTableAdapter1 As DiBS_DB_ProdDataSet1TableAdapters.omOrderDocumentsTableAdapter
    Friend WithEvents cmdAddNewDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1_ViewDocument As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1_SendDocumentToEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OrderDocTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1_EditDocumentInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1_DeleteDocument As DevExpress.XtraBars.BarButtonItem
End Class
