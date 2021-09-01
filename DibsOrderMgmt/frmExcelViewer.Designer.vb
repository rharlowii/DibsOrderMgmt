<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcelViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExcelViewer))
        Me.SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SpreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.CustomSaveBarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.FileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
        Me.InfoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
        Me.SpreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(Me.components)
        Me.SpreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpreadsheetControl1
        '
        Me.SpreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpreadsheetControl1.Location = New System.Drawing.Point(0, 150)
        Me.SpreadsheetControl1.MenuManager = Me.RibbonControl1
        Me.SpreadsheetControl1.Name = "SpreadsheetControl1"
        Me.SpreadsheetControl1.Size = New System.Drawing.Size(800, 300)
        Me.SpreadsheetControl1.TabIndex = 0
        Me.SpreadsheetControl1.Text = "SpreadsheetControl1"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.SpreadsheetCommandBarButtonItem1, Me.SpreadsheetCommandBarButtonItem2, Me.SpreadsheetCommandBarButtonItem3, Me.SpreadsheetCommandBarButtonItem4, Me.SpreadsheetCommandBarButtonItem5, Me.SpreadsheetCommandBarButtonItem6, Me.SpreadsheetCommandBarButtonItem7, Me.SpreadsheetCommandBarButtonItem8, Me.SpreadsheetCommandBarButtonItem9, Me.SpreadsheetCommandBarButtonItem10, Me.SpreadsheetCommandBarButtonItem11, Me.CustomSaveBarButtonItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(800, 150)
        '
        'SpreadsheetCommandBarButtonItem1
        '
        Me.SpreadsheetCommandBarButtonItem1.CommandName = "FileNew"
        Me.SpreadsheetCommandBarButtonItem1.Id = 1
        Me.SpreadsheetCommandBarButtonItem1.Name = "SpreadsheetCommandBarButtonItem1"
        '
        'SpreadsheetCommandBarButtonItem2
        '
        Me.SpreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
        Me.SpreadsheetCommandBarButtonItem2.Id = 2
        Me.SpreadsheetCommandBarButtonItem2.Name = "SpreadsheetCommandBarButtonItem2"
        '
        'SpreadsheetCommandBarButtonItem3
        '
        Me.SpreadsheetCommandBarButtonItem3.CommandName = "FileSave"
        Me.SpreadsheetCommandBarButtonItem3.Id = 3
        Me.SpreadsheetCommandBarButtonItem3.Name = "SpreadsheetCommandBarButtonItem3"
        '
        'SpreadsheetCommandBarButtonItem4
        '
        Me.SpreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
        Me.SpreadsheetCommandBarButtonItem4.Id = 4
        Me.SpreadsheetCommandBarButtonItem4.Name = "SpreadsheetCommandBarButtonItem4"
        '
        'SpreadsheetCommandBarButtonItem5
        '
        Me.SpreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
        Me.SpreadsheetCommandBarButtonItem5.Id = 5
        Me.SpreadsheetCommandBarButtonItem5.Name = "SpreadsheetCommandBarButtonItem5"
        '
        'SpreadsheetCommandBarButtonItem6
        '
        Me.SpreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
        Me.SpreadsheetCommandBarButtonItem6.Id = 6
        Me.SpreadsheetCommandBarButtonItem6.Name = "SpreadsheetCommandBarButtonItem6"
        '
        'SpreadsheetCommandBarButtonItem7
        '
        Me.SpreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
        Me.SpreadsheetCommandBarButtonItem7.Id = 7
        Me.SpreadsheetCommandBarButtonItem7.Name = "SpreadsheetCommandBarButtonItem7"
        '
        'SpreadsheetCommandBarButtonItem8
        '
        Me.SpreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
        Me.SpreadsheetCommandBarButtonItem8.Id = 8
        Me.SpreadsheetCommandBarButtonItem8.Name = "SpreadsheetCommandBarButtonItem8"
        '
        'SpreadsheetCommandBarButtonItem9
        '
        Me.SpreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
        Me.SpreadsheetCommandBarButtonItem9.Id = 9
        Me.SpreadsheetCommandBarButtonItem9.Name = "SpreadsheetCommandBarButtonItem9"
        '
        'SpreadsheetCommandBarButtonItem10
        '
        Me.SpreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
        Me.SpreadsheetCommandBarButtonItem10.Id = 10
        Me.SpreadsheetCommandBarButtonItem10.Name = "SpreadsheetCommandBarButtonItem10"
        '
        'SpreadsheetCommandBarButtonItem11
        '
        Me.SpreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
        Me.SpreadsheetCommandBarButtonItem11.Id = 11
        Me.SpreadsheetCommandBarButtonItem11.Name = "SpreadsheetCommandBarButtonItem11"
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
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem2)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.CustomSaveBarButtonItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem4)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem5)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem6)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem7)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem8)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem9)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'InfoRibbonPageGroup1
        '
        Me.InfoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem10)
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem11)
        Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
        '
        'SpreadsheetBarController1
        '
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem1)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem2)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem3)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem4)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem5)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem6)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem7)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem8)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem9)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem10)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem11)
        Me.SpreadsheetBarController1.Control = Me.SpreadsheetControl1
        '
        'SpreadsheetCommandBarButtonItem12
        '
        Me.SpreadsheetCommandBarButtonItem12.CommandName = "FileSave"
        Me.SpreadsheetCommandBarButtonItem12.Id = 3
        Me.SpreadsheetCommandBarButtonItem12.Name = "SpreadsheetCommandBarButtonItem12"
        '
        'frmExcelViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SpreadsheetControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmExcelViewer"
        Me.Text = "frmExcelViewer"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SpreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents SpreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
    Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup
    Friend WithEvents SpreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
    Friend WithEvents SpreadsheetCommandBarButtonItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents CustomSaveBarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
