<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEBookSalesAdd
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
        Me.spreadAddeBooks = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.cmdAddeBookSales = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdAddeBookSales)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 76)
        Me.Panel1.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(400, 58)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Add EBook Sales"
        '
        'spreadAddeBooks
        '
        Me.spreadAddeBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spreadAddeBooks.Location = New System.Drawing.Point(0, 88)
        Me.spreadAddeBooks.Name = "spreadAddeBooks"
        Me.spreadAddeBooks.Size = New System.Drawing.Size(1009, 403)
        Me.spreadAddeBooks.TabIndex = 6
        Me.spreadAddeBooks.Text = "spreadAddeBooks"
        '
        'cmdAddeBookSales
        '
        Me.cmdAddeBookSales.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddeBookSales.Appearance.Options.UseFont = True
        Me.cmdAddeBookSales.Location = New System.Drawing.Point(533, 25)
        Me.cmdAddeBookSales.Name = "cmdAddeBookSales"
        Me.cmdAddeBookSales.Size = New System.Drawing.Size(175, 28)
        Me.cmdAddeBookSales.TabIndex = 7
        Me.cmdAddeBookSales.Text = "Add eBook Sales"
        '
        'frmEBookSalesAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 503)
        Me.Controls.Add(Me.spreadAddeBooks)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEBookSalesAdd"
        Me.Text = "frmEBookSalesAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spreadAddeBooks As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents cmdAddeBookSales As DevExpress.XtraEditors.SimpleButton
End Class
