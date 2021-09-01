<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRTFViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRTFViewer))
        Me.RichEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.UndoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
        Me.RedoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
        Me.FileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
        Me.FileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
        Me.FileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
        Me.FileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
        Me.QuickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
        Me.PrintItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
        Me.PrintPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
        Me.EncryptDocumentItem1 = New DevExpress.XtraRichEdit.UI.EncryptDocumentItem()
        Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
        Me.CustomSaveBarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
        Me.InfoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
        Me.RichEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichEditControl1
        '
        Me.RichEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichEditControl1.Location = New System.Drawing.Point(0, 150)
        Me.RichEditControl1.MenuManager = Me.RibbonControl1
        Me.RichEditControl1.Name = "RichEditControl1"
        Me.RichEditControl1.Size = New System.Drawing.Size(800, 300)
        Me.RichEditControl1.TabIndex = 0
        Me.RichEditControl1.Text = "RichEditControl1"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.UndoItem1, Me.RedoItem1, Me.FileNewItem1, Me.FileOpenItem1, Me.FileSaveItem1, Me.FileSaveAsItem1, Me.QuickPrintItem1, Me.PrintItem1, Me.PrintPreviewItem1, Me.EncryptDocumentItem1, Me.ShowDocumentPropertiesFormItem1, Me.CustomSaveBarButtonItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(800, 150)
        '
        'UndoItem1
        '
        Me.UndoItem1.Id = 1
        Me.UndoItem1.Name = "UndoItem1"
        '
        'RedoItem1
        '
        Me.RedoItem1.Id = 2
        Me.RedoItem1.Name = "RedoItem1"
        '
        'FileNewItem1
        '
        Me.FileNewItem1.Id = 3
        Me.FileNewItem1.Name = "FileNewItem1"
        '
        'FileOpenItem1
        '
        Me.FileOpenItem1.Id = 4
        Me.FileOpenItem1.Name = "FileOpenItem1"
        '
        'FileSaveItem1
        '
        Me.FileSaveItem1.Id = 5
        Me.FileSaveItem1.Name = "FileSaveItem1"
        '
        'FileSaveAsItem1
        '
        Me.FileSaveAsItem1.Id = 6
        Me.FileSaveAsItem1.Name = "FileSaveAsItem1"
        '
        'QuickPrintItem1
        '
        Me.QuickPrintItem1.Id = 7
        Me.QuickPrintItem1.Name = "QuickPrintItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 8
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 9
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'EncryptDocumentItem1
        '
        Me.EncryptDocumentItem1.Id = 10
        Me.EncryptDocumentItem1.Name = "EncryptDocumentItem1"
        '
        'ShowDocumentPropertiesFormItem1
        '
        Me.ShowDocumentPropertiesFormItem1.Id = 11
        Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
        '
        'CustomSaveBarButtonItem1
        '
        Me.CustomSaveBarButtonItem1.Caption = "Save"
        Me.CustomSaveBarButtonItem1.Enabled = False
        Me.CustomSaveBarButtonItem1.Id = 12
        Me.CustomSaveBarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("CustomSaveBarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CustomSaveBarButtonItem1.Name = "CustomSaveBarButtonItem1"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.InfoRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.UndoItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.RedoItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileOpenItem1, "O")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.CustomSaveBarButtonItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveAsItem1, "A")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.QuickPrintItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1, "P")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'InfoRibbonPageGroup1
        '
        Me.InfoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.EncryptDocumentItem1)
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.ShowDocumentPropertiesFormItem1)
        Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
        '
        'RichEditBarController1
        '
        Me.RichEditBarController1.BarItems.Add(Me.UndoItem1)
        Me.RichEditBarController1.BarItems.Add(Me.RedoItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileNewItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileOpenItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileSaveItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileSaveAsItem1)
        Me.RichEditBarController1.BarItems.Add(Me.QuickPrintItem1)
        Me.RichEditBarController1.BarItems.Add(Me.PrintItem1)
        Me.RichEditBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.RichEditBarController1.BarItems.Add(Me.EncryptDocumentItem1)
        Me.RichEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
        Me.RichEditBarController1.Control = Me.RichEditControl1
        '
        'frmRTFViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichEditControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmRTFViewer"
        Me.Text = "frmRTFViewer"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichEditControl1 As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents UndoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
    Friend WithEvents RedoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
    Friend WithEvents FileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
    Friend WithEvents FileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
    Friend WithEvents FileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
    Friend WithEvents FileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
    Friend WithEvents QuickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
    Friend WithEvents PrintItem1 As DevExpress.XtraRichEdit.UI.PrintItem
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
    Friend WithEvents EncryptDocumentItem1 As DevExpress.XtraRichEdit.UI.EncryptDocumentItem
    Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
    Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
    Friend WithEvents RichEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    Friend WithEvents CustomSaveBarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
