<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCoverToBook
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOfficalImageURL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdSaveClipBoardToPictureBox1 = New System.Windows.Forms.Button()
        Me.cmdSetOfficalURL = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkNoImageSet = New System.Windows.Forms.CheckBox()
        Me.chkApprove = New System.Windows.Forms.CheckBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(136, 29)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(288, 20)
        Me.txtTitle.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Title"
        '
        'txtOfficalImageURL
        '
        Me.txtOfficalImageURL.Location = New System.Drawing.Point(136, 55)
        Me.txtOfficalImageURL.Name = "txtOfficalImageURL"
        Me.txtOfficalImageURL.ReadOnly = True
        Me.txtOfficalImageURL.Size = New System.Drawing.Size(288, 20)
        Me.txtOfficalImageURL.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Offical Image Input:"
        '
        'cmdSaveClipBoardToPictureBox1
        '
        Me.cmdSaveClipBoardToPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveClipBoardToPictureBox1.Location = New System.Drawing.Point(260, 340)
        Me.cmdSaveClipBoardToPictureBox1.Name = "cmdSaveClipBoardToPictureBox1"
        Me.cmdSaveClipBoardToPictureBox1.Size = New System.Drawing.Size(230, 23)
        Me.cmdSaveClipBoardToPictureBox1.TabIndex = 43
        Me.cmdSaveClipBoardToPictureBox1.Text = "Save Clipboard to PictureBox and AWS"
        Me.cmdSaveClipBoardToPictureBox1.UseVisualStyleBackColor = True
        '
        'cmdSetOfficalURL
        '
        Me.cmdSetOfficalURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSetOfficalURL.Location = New System.Drawing.Point(260, 385)
        Me.cmdSetOfficalURL.Name = "cmdSetOfficalURL"
        Me.cmdSetOfficalURL.Size = New System.Drawing.Size(231, 23)
        Me.cmdSetOfficalURL.TabIndex = 44
        Me.cmdSetOfficalURL.Text = "Set Cover URL"
        Me.cmdSetOfficalURL.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(733, 22)
        Me.StatusStrip1.TabIndex = 45
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(375, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(218, 216)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(151, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'chkNoImageSet
        '
        Me.chkNoImageSet.AutoSize = True
        Me.chkNoImageSet.Checked = True
        Me.chkNoImageSet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoImageSet.Location = New System.Drawing.Point(136, 81)
        Me.chkNoImageSet.Name = "chkNoImageSet"
        Me.chkNoImageSet.Size = New System.Drawing.Size(80, 17)
        Me.chkNoImageSet.TabIndex = 47
        Me.chkNoImageSet.Text = "Set Image?"
        Me.chkNoImageSet.UseVisualStyleBackColor = True
        '
        'chkApprove
        '
        Me.chkApprove.AutoSize = True
        Me.chkApprove.Checked = True
        Me.chkApprove.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkApprove.Location = New System.Drawing.Point(225, 81)
        Me.chkApprove.Name = "chkApprove"
        Me.chkApprove.Size = New System.Drawing.Size(72, 17)
        Me.chkApprove.TabIndex = 46
        Me.chkApprove.Text = "Approve?"
        Me.chkApprove.UseVisualStyleBackColor = True
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(448, 55)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(232, 20)
        Me.txtISBN.TabIndex = 49
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(447, 29)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(232, 20)
        Me.txtBookID.TabIndex = 48
        '
        'frmAddCoverToBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 450)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.chkNoImageSet)
        Me.Controls.Add(Me.chkApprove)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdSetOfficalURL)
        Me.Controls.Add(Me.cmdSaveClipBoardToPictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtOfficalImageURL)
        Me.Controls.Add(Me.Label9)
        Me.Name = "frmAddCoverToBook"
        Me.Text = "frmAddCoverToBook"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtOfficalImageURL As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdSaveClipBoardToPictureBox1 As Button
    Friend WithEvents cmdSetOfficalURL As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents chkNoImageSet As CheckBox
    Friend WithEvents chkApprove As CheckBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtBookID As TextBox
End Class
