<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMetaImport
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
        Me.components = New System.ComponentModel.Container()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.txtFullPath = New System.Windows.Forms.TextBox()
        Me.cmd_FileSelect2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbMetaDataMappings = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdImportMeta = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.gridMetaImport = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panelTop.SuspendLayout()
        CType(Me.cmbMetaDataMappings.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMetaImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.Controls.Add(Me.txtFullPath)
        Me.panelTop.Controls.Add(Me.cmd_FileSelect2)
        Me.panelTop.Controls.Add(Me.Label18)
        Me.panelTop.Controls.Add(Me.cmbMetaDataMappings)
        Me.panelTop.Controls.Add(Me.cmdImportMeta)
        Me.panelTop.Controls.Add(Me.LabelControl1)
        Me.panelTop.Location = New System.Drawing.Point(2, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(955, 159)
        Me.panelTop.TabIndex = 3
        '
        'txtFullPath
        '
        Me.txtFullPath.Enabled = False
        Me.txtFullPath.Location = New System.Drawing.Point(21, 104)
        Me.txtFullPath.Name = "txtFullPath"
        Me.txtFullPath.Size = New System.Drawing.Size(674, 20)
        Me.txtFullPath.TabIndex = 79
        '
        'cmd_FileSelect2
        '
        Me.cmd_FileSelect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_FileSelect2.Location = New System.Drawing.Point(701, 98)
        Me.cmd_FileSelect2.Name = "cmd_FileSelect2"
        Me.cmd_FileSelect2.Size = New System.Drawing.Size(35, 32)
        Me.cmd_FileSelect2.TabIndex = 78
        Me.cmd_FileSelect2.Text = "..."
        Me.cmd_FileSelect2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_FileSelect2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(29, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 20)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Import Mapping:"
        '
        'cmbMetaDataMappings
        '
        Me.cmbMetaDataMappings.Location = New System.Drawing.Point(174, 72)
        Me.cmbMetaDataMappings.Name = "cmbMetaDataMappings"
        Me.cmbMetaDataMappings.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmbMetaDataMappings.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbMetaDataMappings.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMetaDataMappings.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbMetaDataMappings.Properties.Appearance.Options.UseBackColor = True
        Me.cmbMetaDataMappings.Properties.Appearance.Options.UseFont = True
        Me.cmbMetaDataMappings.Properties.Appearance.Options.UseForeColor = True
        Me.cmbMetaDataMappings.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMetaDataMappings.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MetaDataMappingsID", "MetaDataMappingsID", 25, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MappingName", "Mapping Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartnerID", "PartnerID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbMetaDataMappings.Properties.DisplayMember = "MappingName"
        Me.cmbMetaDataMappings.Properties.EditValueChangedDelay = 1
        Me.cmbMetaDataMappings.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.cmbMetaDataMappings.Properties.NullText = ""
        Me.cmbMetaDataMappings.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbMetaDataMappings.Properties.SortColumnIndex = 1
        Me.cmbMetaDataMappings.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbMetaDataMappings.Properties.UseDropDownRowsAsMaxCount = True
        Me.cmbMetaDataMappings.Properties.ValidateOnEnterKey = True
        Me.cmbMetaDataMappings.Properties.ValueMember = "MetaDataMappingsID"
        Me.cmbMetaDataMappings.Size = New System.Drawing.Size(521, 26)
        Me.cmbMetaDataMappings.TabIndex = 76
        '
        'cmdImportMeta
        '
        Me.cmdImportMeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImportMeta.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportMeta.Appearance.Options.UseFont = True
        Me.cmdImportMeta.Location = New System.Drawing.Point(781, 67)
        Me.cmdImportMeta.Name = "cmdImportMeta"
        Me.cmdImportMeta.Size = New System.Drawing.Size(164, 28)
        Me.cmdImportMeta.TabIndex = 2
        Me.cmdImportMeta.Text = "Import Meta Data"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(305, 58)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Meta Import"
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = "XtraOpenFileDialog1"
        '
        'gridMetaImport
        '
        Me.gridMetaImport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridMetaImport.Location = New System.Drawing.Point(2, 165)
        Me.gridMetaImport.MainView = Me.GridView1
        Me.gridMetaImport.Name = "gridMetaImport"
        Me.gridMetaImport.Size = New System.Drawing.Size(945, 408)
        Me.gridMetaImport.TabIndex = 4
        Me.gridMetaImport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridMetaImport
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'frmMetaImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(959, 585)
        Me.Controls.Add(Me.gridMetaImport)
        Me.Controls.Add(Me.panelTop)
        Me.Name = "frmMetaImport"
        Me.Text = "frmMetaImport"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.cmbMetaDataMappings.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMetaImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents cmdImportMeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbMetaDataMappings As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFullPath As TextBox
    Friend WithEvents cmd_FileSelect2 As Button
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents gridMetaImport As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
