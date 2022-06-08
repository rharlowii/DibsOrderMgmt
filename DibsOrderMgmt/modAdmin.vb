Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Module modAdmin

    Public Structure UserAccount
        Public ID As String
        Public First As String
        Public Last As String
        Public LoginID As String
        Public RoleID As String



    End Structure
    Public MetaSearchTabClickedOnce As Boolean = False
    Public PubInvoiceTabClickedOnce As Boolean = False


    'Need to chage relative path
    Public HiveTemplatePath As String = "Y:\MEP - Shared\BrainHive\BH_OrderMgmt\HIVE_Templates\"
    Private Function GetImageBase64(sImage64 As String, oPictureBox As PictureBox)
        Try
            Dim txt As String
            'Need to add because David no longer puts data in the field for front and back images

            If sImage64.EndsWith(".jpg") Then
                txt = sImage64
                oPictureBox.ImageLocation = sImage64
            Else
                txt = GetJPFDataStream(sImage64)
                '   txt = "data:image/jpeg;base64," & txt






                If txt.StartsWith("data:") Then
                    Dim poscomma As Integer = txt.IndexOf(",") + 1
                    txt = txt.Substring(poscomma, txt.Length - poscomma)
                End If

                If txt.Length > 0 Then
                    Dim ms As New MemoryStream(Convert.FromBase64String(txt))

                    Dim bm As Bitmap = Bitmap.FromStream(ms) '<---load bitmap from memory stream
                    'create new memory stream
                    Dim jpgms As New MemoryStream()
                    jpgms.Position = 0
                    bm.Save(jpgms, System.Drawing.Imaging.ImageFormat.Jpeg) '<---convert to jpeg

                    oPictureBox.Image = Image.FromStream(jpgms)
                End If
            End If
            'jpgms.toArray() '<--used as data source for sql 2008 image
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Function
    Public Function GetImageBase64NoPicBox(sImage64 As String) As Image

        Try
            Dim txt As String
            'Need to add because David no longer puts data in the field for front and back images

            If sImage64.EndsWith(".jpg") Then
                txt = sImage64
                Dim oPicBox As New PictureBox
                oPicBox.ImageLocation = sImage64
                oPicBox.Load()
                Return oPicBox.Image

            Else
                txt = GetJPFDataStream(sImage64)
                '   txt = "data:image/jpeg;base64," & txt



                If txt.StartsWith("data:") Then
                    Dim poscomma As Integer = txt.IndexOf(",") + 1
                    txt = txt.Substring(poscomma, txt.Length - poscomma)
                End If

                If txt.Length > 0 Then
                    Dim ms As New MemoryStream(Convert.FromBase64String(txt))

                    Dim bm As Bitmap = Bitmap.FromStream(ms) '<---load bitmap from memory stream
                    'create new memory stream
                    Dim jpgms As New MemoryStream()
                    jpgms.Position = 0
                    bm.Save(jpgms, System.Drawing.Imaging.ImageFormat.Jpeg) '<---convert to jpeg

                    Return Image.FromStream(jpgms)
                End If
            End If
            'jpgms.toArray() '<--used as data source for sql 2008 image
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Function
    Public Function ImageToBase64(image As Image, format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As New MemoryStream()
            ' Convert Image to byte[]
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()

            ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Public Function GetJPFDataStream(uri As String)
        Dim results As String

        ' The number of bytes read
        Try
            Dim req As HttpWebRequest = CType(WebRequest.Create(uri), HttpWebRequest)
            Dim resp As HttpWebResponse = CType(req.GetResponse, HttpWebResponse)
            Dim sr As StreamReader = New StreamReader(resp.GetResponseStream)
            results = sr.ReadToEnd
            sr.Close()

            Return results

        Finally


        End Try
    End Function

    Public Function ScaleThumbnailImage(ByVal ImageToScale As Image, ByVal MaxWidth As Integer, ByVal MaxHeight As Integer) As Image
        Try


            Dim ratioX As Double = CDbl(MaxWidth) / ImageToScale.Width
            Dim ratioY As Double = CDbl(MaxHeight) / ImageToScale.Height
            Dim ratio As Double = Math.Min(ratioX, ratioY)
            Dim newWidth As Integer = CInt((ImageToScale.Width * ratio))
            Dim newHeight As Integer = CInt((ImageToScale.Height * ratio))
            Dim newImage As Image = New Bitmap(newWidth, newHeight)
            Graphics.FromImage(newImage).DrawImage(ImageToScale, 0, 0, newWidth, newHeight)
            Return newImage
        Catch ex As Exception

        End Try
    End Function

    Public Sub PasteFilesFromClipboard(ByVal aTargetFolder As String)
        Dim aFileDropList = Clipboard.GetFileDropList()
        If aFileDropList Is Nothing OrElse aFileDropList.Count = 0 Then Return
        Dim aMove As Boolean = False
        Dim aDataDropEffect = Clipboard.GetData("Preferred DropEffect")

        If aDataDropEffect IsNot Nothing Then
            Dim aDropEffect As MemoryStream = CType(aDataDropEffect, MemoryStream)
            Dim aMoveEffect As Byte() = New Byte(3) {}
            aDropEffect.Read(aMoveEffect, 0, aMoveEffect.Length)
            Dim aDragDropEffects = CType(BitConverter.ToInt32(aMoveEffect, 0), DragDropEffects)
            aMove = aDragDropEffects.HasFlag(DragDropEffects.Move)
        End If

        For Each aFileName As String In aFileDropList

            If aMove Then
            Else
            End If
        Next
    End Sub

    <Flags>
    Public Enum DragDropEffects
        Scroll = Integer.MinValue
        All = -2147483645
        None = 0
        Copy = 1
        Move = 2
        Link = 4
    End Enum

    Public Function GetFileFromClipBoard()
        If My.Computer.Clipboard.ContainsData("specialFormat") Then
            MsgBox("Data found.")
        End If

        MsgBox(My.Computer.Clipboard.GetType().ToString)
        If My.Computer.Clipboard.ContainsData("FileGroupDescriptorW") Then
            MsgBox("Data found.")
        End If

    End Function

    Public Function SetCoverImage(sISBN As String, sAWSCoverImageURL As String)

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

    Public Function GetOfficalImage(sISBN As String) As String


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

End Module
