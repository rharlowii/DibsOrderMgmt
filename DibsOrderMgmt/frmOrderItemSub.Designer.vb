<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderItemSub
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
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_NewItemNumber = New System.Windows.Forms.TextBox()
        Me.txt_NewItemDesc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_NewQTY = New System.Windows.Forms.TextBox()
        Me.txt_NewListPrice = New System.Windows.Forms.TextBox()
        Me.txt_NewExtendedPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ItemNumber = New System.Windows.Forms.TextBox()
        Me.txt_ItemDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_QTY = New System.Windows.Forms.TextBox()
        Me.txt_ListPrice = New System.Windows.Forms.TextBox()
        Me.txt_ExtendedPrice = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 76)
        Me.Panel1.TabIndex = 77
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(375, 58)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Sub Order Item"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(455, 357)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(122, 28)
        Me.cmdCancel.TabIndex = 80
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdOK
        '
        Me.cmdOK.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Appearance.Options.UseFont = True
        Me.cmdOK.Location = New System.Drawing.Point(313, 357)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(122, 28)
        Me.cmdOK.TabIndex = 79
        Me.cmdOK.Text = "&OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_NewItemNumber)
        Me.GroupBox1.Controls.Add(Me.txt_NewItemDesc)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txt_NewQTY)
        Me.GroupBox1.Controls.Add(Me.txt_NewListPrice)
        Me.GroupBox1.Controls.Add(Me.txt_NewExtendedPrice)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(455, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 212)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Item:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Item Desc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Item Number:"
        '
        'txt_NewItemNumber
        '
        Me.txt_NewItemNumber.AcceptsTab = True
        Me.txt_NewItemNumber.Location = New System.Drawing.Point(126, 25)
        Me.txt_NewItemNumber.Name = "txt_NewItemNumber"
        Me.txt_NewItemNumber.Size = New System.Drawing.Size(277, 26)
        Me.txt_NewItemNumber.TabIndex = 10
        '
        'txt_NewItemDesc
        '
        Me.txt_NewItemDesc.Location = New System.Drawing.Point(126, 57)
        Me.txt_NewItemDesc.Name = "txt_NewItemDesc"
        Me.txt_NewItemDesc.Size = New System.Drawing.Size(277, 26)
        Me.txt_NewItemDesc.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 157)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 16)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Extended Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(52, 123)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 16)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "List Price:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(78, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 16)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "QTY:"
        '
        'txt_NewQTY
        '
        Me.txt_NewQTY.AcceptsTab = True
        Me.txt_NewQTY.Location = New System.Drawing.Point(126, 91)
        Me.txt_NewQTY.Name = "txt_NewQTY"
        Me.txt_NewQTY.Size = New System.Drawing.Size(277, 26)
        Me.txt_NewQTY.TabIndex = 30
        '
        'txt_NewListPrice
        '
        Me.txt_NewListPrice.Location = New System.Drawing.Point(126, 123)
        Me.txt_NewListPrice.Name = "txt_NewListPrice"
        Me.txt_NewListPrice.Size = New System.Drawing.Size(277, 26)
        Me.txt_NewListPrice.TabIndex = 40
        '
        'txt_NewExtendedPrice
        '
        Me.txt_NewExtendedPrice.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_NewExtendedPrice.Enabled = False
        Me.txt_NewExtendedPrice.Location = New System.Drawing.Point(126, 157)
        Me.txt_NewExtendedPrice.Name = "txt_NewExtendedPrice"
        Me.txt_NewExtendedPrice.Size = New System.Drawing.Size(277, 26)
        Me.txt_NewExtendedPrice.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_ItemNumber)
        Me.GroupBox2.Controls.Add(Me.txt_ItemDesc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_QTY)
        Me.GroupBox2.Controls.Add(Me.txt_ListPrice)
        Me.GroupBox2.Controls.Add(Me.txt_ExtendedPrice)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 212)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Item Desc:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Item Number:"
        '
        'txt_ItemNumber
        '
        Me.txt_ItemNumber.AcceptsTab = True
        Me.txt_ItemNumber.Location = New System.Drawing.Point(126, 25)
        Me.txt_ItemNumber.Name = "txt_ItemNumber"
        Me.txt_ItemNumber.ReadOnly = True
        Me.txt_ItemNumber.Size = New System.Drawing.Size(277, 26)
        Me.txt_ItemNumber.TabIndex = 26
        Me.txt_ItemNumber.TabStop = False
        '
        'txt_ItemDesc
        '
        Me.txt_ItemDesc.Location = New System.Drawing.Point(126, 57)
        Me.txt_ItemDesc.Name = "txt_ItemDesc"
        Me.txt_ItemDesc.ReadOnly = True
        Me.txt_ItemDesc.Size = New System.Drawing.Size(277, 26)
        Me.txt_ItemDesc.TabIndex = 27
        Me.txt_ItemDesc.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Extended Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "List Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "QTY:"
        '
        'txt_QTY
        '
        Me.txt_QTY.AcceptsTab = True
        Me.txt_QTY.Location = New System.Drawing.Point(126, 91)
        Me.txt_QTY.Name = "txt_QTY"
        Me.txt_QTY.ReadOnly = True
        Me.txt_QTY.Size = New System.Drawing.Size(277, 26)
        Me.txt_QTY.TabIndex = 20
        Me.txt_QTY.TabStop = False
        '
        'txt_ListPrice
        '
        Me.txt_ListPrice.Location = New System.Drawing.Point(126, 123)
        Me.txt_ListPrice.Name = "txt_ListPrice"
        Me.txt_ListPrice.ReadOnly = True
        Me.txt_ListPrice.Size = New System.Drawing.Size(277, 26)
        Me.txt_ListPrice.TabIndex = 21
        Me.txt_ListPrice.TabStop = False
        '
        'txt_ExtendedPrice
        '
        Me.txt_ExtendedPrice.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_ExtendedPrice.Enabled = False
        Me.txt_ExtendedPrice.Location = New System.Drawing.Point(126, 157)
        Me.txt_ExtendedPrice.Name = "txt_ExtendedPrice"
        Me.txt_ExtendedPrice.ReadOnly = True
        Me.txt_ExtendedPrice.Size = New System.Drawing.Size(277, 26)
        Me.txt_ExtendedPrice.TabIndex = 22
        Me.txt_ExtendedPrice.TabStop = False
        '
        'frmOrderItemSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(891, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Name = "frmOrderItemSub"
        Me.Text = "frmOrderItemSub"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_NewItemNumber As TextBox
    Friend WithEvents txt_NewItemDesc As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_NewQTY As TextBox
    Friend WithEvents txt_NewListPrice As TextBox
    Friend WithEvents txt_NewExtendedPrice As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ItemNumber As TextBox
    Friend WithEvents txt_ItemDesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_QTY As TextBox
    Friend WithEvents txt_ListPrice As TextBox
    Friend WithEvents txt_ExtendedPrice As TextBox
End Class
