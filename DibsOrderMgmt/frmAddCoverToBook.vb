Imports System.Data.SqlClient
Imports System.Drawing.Imaging

Public Class frmAddCoverToBook
    Private Sub cmdSaveClipBoardToPictureBox1_Click(sender As Object, e As EventArgs) Handles cmdSaveClipBoardToPictureBox1.Click
        Dim bUsePhoto As Boolean
        Dim iMsgBox As MsgBoxResult

        If My.Computer.Clipboard.ContainsImage Then
            bUsePhoto = False
        Else
            iMsgBox = MessageBox.Show("No Clipboard image, do you want to use existing photo as is?", "", MessageBoxButtons.YesNo)
            If iMsgBox = MsgBoxResult.Yes Then
                bUsePhoto = True
            Else
                bUsePhoto = False
            End If

        End If



        If My.Computer.Clipboard.ContainsImage Or bUsePhoto Then
            If bUsePhoto = False Then PictureBox1.Image = My.Computer.Clipboard.GetImage


            Dim oGuid As New Guid
            oGuid = Guid.NewGuid
            Dim sReturnAWSPath As String
            Dim sFileName As String
            sFileName = oGuid.ToString & ".jpg"

            Dim sFilepath As String
            sFilepath = "C:\DiBS_FrontCovers\" & sFileName

            PictureBox1.Image.Save(sFilepath, ImageFormat.Jpeg)

            sReturnAWSPath = UploadFile_AWS_S3(sFilepath, sFileName, "")

            If sReturnAWSPath.Length > 0 Then
                txtOfficalImageURL.Text = sReturnAWSPath
            Else
                txtOfficalImageURL.Text = ""
            End If

            My.Computer.Clipboard.Clear()
        End If
    End Sub

    Private Sub cmdSetOfficalURL_Click(sender As Object, e As EventArgs) Handles cmdSetOfficalURL.Click
        ToolStripStatusLabel1.Text = ""
        SetAttributes()
        ToolStripStatusLabel1.Text = "Set Attributes Completed"
    End Sub

    Private Sub SetAttributes()
        Dim saveCommand As String
        Dim sURL As String
        Dim sISBN As String
        Dim iAffected As Integer
        Dim sPublisherID As String
        Dim sBase64 As String
        Dim bApproved As Boolean
        Dim bSetImage As Boolean
        Dim sAWSImageURL As String
        Dim sTitle As String

        sURL = txtOfficalImageURL.Text

        sISBN = txtISBN.Text
        sTitle = txtTitle.Text

        If chkApprove.Checked Then
            bApproved = True
        Else
            bApproved = False
        End If
        If sURL.Length = 0 And bSetImage = True Then
            MsgBox("Must enter a image URL")
            Return

        End If

        If sISBN.Length = 0 Then
            MsgBox("Must enter a ISBN")
            Return

        End If



        If sURL.Length > 0 Then



        End If
        If sTitle.Length = 0 Then
            MsgBox("Must enter a Title")
            Return

        End If


        If chkNoImageSet.Checked Then
            bSetImage = True
        Else
            bSetImage = False

        End If



        ' If chkConvertImagetoBase64.Checked = True And bSetImage = True Then
        'Dim sd As New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sURL)))
        'sBase64 = ConvertImagetoBase64String(sd, True)
        '  saveCommand = "UPDATE books SET OfficialImage = null,IsApproved=@Approved,Description = @Description,PublisherID=@PublisherID,FrontPhoto=@FrontPhoto where ISBN=@ISBN"
        '  Else
        If bSetImage = True Then

            If InStr(sURL, AWS_S3_DIBS_BucketPath, CompareMethod.Text) = 0 Then

                sAWSImageURL = UploadFile_AWS_S3(sURL, "", "", , PictureBox1)

                'This function from david no longer works
                ' sAWSImageURL = SaveToAWS(sURL)

                If sAWSImageURL = "A generic error occurred in GDI+." Then
                    MsgBox(sAWSImageURL, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

                    Exit Sub

                End If
            Else
                sAWSImageURL = sURL
            End If

            ' saveCommand = "UPDATE books SET Title=@Title,OfficialImage = @ImageName,IsApproved=@Approved,Description = @Description,PublisherID=@PublisherID where ISBN=@ISBN"
            saveCommand = "UPDATE books SET Title=@Title,OfficialImage = @ImageName,IsApproved=@Approved where ISBN=@ISBN"

        Else
            'saveCommand = "UPDATE books SET Title=@Title,IsApproved=@Approved,Description = @Description,PublisherID=@PublisherID where ISBN=@ISBN"
            saveCommand = "UPDATE books SET Title=@Title,IsApproved=@Approved where ISBN=@ISBN"

        End If

        '  End If

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()

        Dim setCmd As New SqlCommand(saveCommand, oConnection)

        setCmd = New SqlCommand(saveCommand, oConnection)


        '  setCmd.Parameters.Add("@Description", Data.SqlDbType.NVarChar).Value = txtDescription.Text
        setCmd.Parameters.Add("@Approved", Data.SqlDbType.Bit).Value = bApproved
        setCmd.Parameters.Add("@ISBN", Data.SqlDbType.VarChar).Value = sISBN
        ' setCmd.Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sPublisherID)
        setCmd.Parameters.Add("@Title", Data.SqlDbType.VarChar).Value = sTitle
        If bSetImage = True Then

            ' setCmd.Parameters.Add("@FrontPhoto", Data.SqlDbType.NVarChar).Value = sBase64

            setCmd.Parameters.Add("@ImageName", Data.SqlDbType.VarChar).Value = sAWSImageURL

        End If

        iAffected = setCmd.ExecuteNonQuery()

        If iAffected > 0 And bApproved Then

            saveCommand = "UPDATE books SET FrontPhoto=Null,IsApproved=@Approved,BackPhoto = Null where ISBN=@ISBN"
            setCmd = New SqlCommand(saveCommand, oConnection)

            setCmd.Parameters.Add("@Approved", Data.SqlDbType.Bit).Value = 1
            setCmd.Parameters.Add("@ISBN", Data.SqlDbType.VarChar).Value = sISBN
            iAffected = setCmd.ExecuteNonQuery()
        End If
        oConnection.Close()

    End Sub
    Private Function SetCoverImage(sISBN As String, sAWSCoverImageURL As String)

        Dim saveCommand As String
        Dim iAffected As Integer



        saveCommand = "UPDATE books SET OfficialImage = @ImageName where ISBN=@ISBN"


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()

        Dim setCmd As New SqlCommand(saveCommand, oConnection)

        setCmd = New SqlCommand(saveCommand, oConnection)



        setCmd.Parameters.Add("@ISBN", Data.SqlDbType.VarChar).Value = sISBN
        setCmd.Parameters.Add("@ImageName", Data.SqlDbType.VarChar).Value = sAWSCoverImageURL



        iAffected = setCmd.ExecuteNonQuery()
    End Function

    Private Function GetOfficalImage(sISBN As String) As String


        Dim ScalarCommand As String
        Dim sOfficalImage As String



        ScalarCommand = "SELECT OfficialImage FROM Books where ISBN=@ISBN"


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()

        Dim setCmd As New SqlCommand(ScalarCommand, oConnection)

        setCmd = New SqlCommand(ScalarCommand, oConnection)



        setCmd.Parameters.Add("@ISBN", Data.SqlDbType.VarChar).Value = sISBN




        sOfficalImage = setCmd.ExecuteScalar.ToString
        oConnection.Close()
        Return sOfficalImage
    End Function

End Class