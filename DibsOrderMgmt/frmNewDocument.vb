Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.FileInfo
Imports System.Text
Imports Microsoft.VisualBasic.FileIO


Public Class frmNewDocument
    Public oOrderID As Guid
    Public oDocumentID As Guid
    Public bExistingDocument As Boolean
    Public bReplaceDocument As Boolean

    Public DocFullFilePath As String = ""
    Public bDragDropFileInMemory As Boolean = False
    Public oDragDragDropFileBytes As Byte()


    Private Sub cmd_FileSelect2_Click(sender As Object, e As EventArgs) Handles cmd_FileSelect2.Click
        With XtraOpenFileDialog1
            .ShowDialog()
            DocFullFilePath = .FileName

        End With

        txtOrderDocName.Text = FileIO.FileSystem.GetName(DocFullFilePath)
        txtFullPath.Text = DocFullFilePath


    End Sub

    Private Sub frmNewDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDocumentTypes()

        If bExistingDocument = True Then
            'Need to get the existing document properties to edit
            LoadExistingDocument(oDocumentID.ToString)
        End If
    End Sub
    Private Sub LoadExistingDocument(sDocmentID As String)

        Dim sSQL As String = "SELECT * FROM omOrderDocuments where DocumentID='" & sDocmentID & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer
        Dim iDocType As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count




        Dim sReturn As String

        With ds.Tables(0).Rows(0)
            '.item("BHPONumber")
            'BillTo_Name

            txtOrderDocName.Text = .Item("OrderDocName").ToString
            iDocType = ds.Tables(0).Rows(0).Item("OrderDocTypeID")
            cmbDocumentType.EditValue = iDocType

            txtDocNotes.Text = .Item("OrderDocNotes").ToString
            'cmbDocumentType.RefreshEditValue()


        End With


        'Disable the controls that let you change files...
        cmd_FileSelect2.Enabled = False
        Panel1.Enabled = False
        Panel1.AllowDrop = False
        txtOrderDocName.Enabled = False



    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim oOrderDoc As New OrderDocument
        Dim sReturn As String

        With oOrderDoc
            .OrderDocFilePath = DocFullFilePath
            .OrderID = oOrderID
            .DocumentID = oDocumentID

            .OrderDocName = txtOrderDocName.Text
            .OrderDocTypeID = cmbDocumentType.EditValue
            .OrderDocNotes = txtDocNotes.Text
            .bExistingDocument = bExistingDocument
            .bReplaceDocument = bReplaceDocument
            If bDragDropFileInMemory = True Then
                .bFromDragDrop = True
                .OrderDoc = oDragDragDropFileBytes
            End If

        End With
        If DocFullFilePath.Length > 0 Or bDragDropFileInMemory = True Or bExistingDocument = True Then

            sReturn = InsertDocumentIntoDB(oOrderDoc)
        End If

        Select Case sReturn
            Case "1"
                MsgBox("Order Saved.")
                Me.Close()

            Case ""
                MsgBox("There was a problem saving the order.")

            Case Else
                MsgBox("There was a problem saving the order.")
        End Select
    End Sub

    Private Sub LoadDocumentTypes()

        Dim sSQL As String
        Dim sDistrictID As String

        sSQL = "SELECT * FROM omOrderDoctypes Order by OrderDocTypeID"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()


        With cmbDocumentType.Properties
            'The datasurce needs to be set first or edit value will not work
            .DataSource = ds.Tables(0)
            .DisplayMember = "OrderDocTypeName"
            .ValueMember = "OrderDocTypeID"



        End With

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        'If e.Data.GetDataPresent(DataFormats.FileDrop) Then
        '    e.Effect = DragDropEffects.Copy
        'End If

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        'Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        'For Each path In files
        '    MsgBox(path)
        'Next

        Dim fileNames As String() = Nothing

        Try

            If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
                fileNames = CType(e.Data.GetData(DataFormats.FileDrop), String())

                For Each fileName As String In fileNames
                Next

                txtOrderDocName.Text = Path.GetFileName(fileNames(0).ToString)
                txtFullPath.Text = fileNames(0)
                DocFullFilePath = fileNames(0)
            ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                Dim theStream As Stream = CType(e.Data.GetData("FileGroupDescriptor"), Stream)
                Dim fileGroupDescriptor As Byte() = New Byte(511) {}
                theStream.Read(fileGroupDescriptor, 0, 512)
                Dim fileName As StringBuilder = New StringBuilder("")
                Dim i As Integer = 76

                While fileGroupDescriptor(i) <> 0
                    fileName.Append(Convert.ToChar(fileGroupDescriptor(i)))
                    i += 1
                End While

                theStream.Close()
                Dim spath As String = Path.GetTempPath()
                Dim theFile As String = spath & fileName.ToString()
                Dim ms As MemoryStream = CType(e.Data.GetData("FileContents", True), MemoryStream)





                bDragDropFileInMemory = True
                oDragDragDropFileBytes = ms.ToArray()
                txtOrderDocName.Text = fileName.ToString()


                'No need to actually write the file since we have it in memory
                'Dim fileBytes As Byte() = New Byte(ms.Length - 1) {}
                'ms.Position = 0
                'ms.Read(fileBytes, 0, CInt(ms.Length))
                'Dim fs As FileStream = New FileStream(theFile, FileMode.Create)
                'fs.Write(fileBytes, 0, CInt(fileBytes.Length))
                'fs.Close()
                'Dim tempFile As FileInfo = New FileInfo(theFile)

                'If tempFile.Exists = True Then
                '    tempFile.Delete()
                'Else
                '    Trace.WriteLine("File was not created!")
                'End If
            End If

        Catch ex As Exception
            Trace.WriteLine("Error in DragDrop function: " & ex.Message)
        End Try

    End Sub
    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cmbDocumentType_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDocumentType.EditValueChanged

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()

    End Sub
End Class