<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSetNew
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.txtListPrice = New System.Windows.Forms.TextBox()
        Me.txtExtendedPrice = New System.Windows.Forms.TextBox()
        Me.txtSetDesc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSetName = New System.Windows.Forms.TextBox()
        Me.cmdAddNewOrderSet = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtQTY)
        Me.GroupBox4.Controls.Add(Me.txtListPrice)
        Me.GroupBox4.Controls.Add(Me.txtExtendedPrice)
        Me.GroupBox4.Controls.Add(Me.txtSetDesc)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtSetName)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(480, 203)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Extended Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "List Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "QTY:"
        '
        'txtQTY
        '
        Me.txtQTY.AcceptsTab = True
        Me.txtQTY.Location = New System.Drawing.Point(232, 93)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(241, 26)
        Me.txtQTY.TabIndex = 27
        '
        'txtListPrice
        '
        Me.txtListPrice.Location = New System.Drawing.Point(232, 125)
        Me.txtListPrice.Name = "txtListPrice"
        Me.txtListPrice.Size = New System.Drawing.Size(241, 26)
        Me.txtListPrice.TabIndex = 28
        '
        'txtExtendedPrice
        '
        Me.txtExtendedPrice.BackColor = System.Drawing.SystemColors.Menu
        Me.txtExtendedPrice.Enabled = False
        Me.txtExtendedPrice.Location = New System.Drawing.Point(232, 157)
        Me.txtExtendedPrice.Name = "txtExtendedPrice"
        Me.txtExtendedPrice.Size = New System.Drawing.Size(241, 26)
        Me.txtExtendedPrice.TabIndex = 29
        '
        'txtSetDesc
        '
        Me.txtSetDesc.Location = New System.Drawing.Point(232, 57)
        Me.txtSetDesc.Name = "txtSetDesc"
        Me.txtSetDesc.Size = New System.Drawing.Size(242, 26)
        Me.txtSetDesc.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(160, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 16)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Set Desc:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(103, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(123, 16)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Set Name/Number:"
        '
        'txtSetName
        '
        Me.txtSetName.Location = New System.Drawing.Point(232, 25)
        Me.txtSetName.Name = "txtSetName"
        Me.txtSetName.Size = New System.Drawing.Size(242, 26)
        Me.txtSetName.TabIndex = 21
        '
        'cmdAddNewOrderSet
        '
        Me.cmdAddNewOrderSet.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewOrderSet.Appearance.Options.UseFont = True
        Me.cmdAddNewOrderSet.Location = New System.Drawing.Point(57, 301)
        Me.cmdAddNewOrderSet.Name = "cmdAddNewOrderSet"
        Me.cmdAddNewOrderSet.Size = New System.Drawing.Size(210, 28)
        Me.cmdAddNewOrderSet.TabIndex = 7
        Me.cmdAddNewOrderSet.Text = "Add/Save Order Set"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(231, 58)
        Me.LabelControl1.TabIndex = 76
        Me.LabelControl1.Text = "Order Set"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(276, 301)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(210, 28)
        Me.cmdCancel.TabIndex = 77
        Me.cmdCancel.Text = "&Cancel"
        '
        'frmOrderSetNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 341)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdAddNewOrderSet)
        Me.Name = "frmOrderSetNew"
        Me.Text = "frmOrderSetNew"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQTY As TextBox
    Friend WithEvents txtListPrice As TextBox
    Friend WithEvents txtExtendedPrice As TextBox
    Friend WithEvents txtSetDesc As TextBox
    Friend WithEvents cmdAddNewOrderSet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtSetName As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
End Class
