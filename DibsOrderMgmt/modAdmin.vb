Imports System.IO
Imports System.Net

Module modAdmin
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
End Module
