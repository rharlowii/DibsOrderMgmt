
Imports System.IO
Imports Amazon.S3
Imports HtmlAgilityPack
Imports Amazon.Util
Imports Amazon.S3.Model
Imports System.Net
Imports Amazon.S3.Transfer




Module DIBS_AWS_S3
    Public Const AWS_ACCESS_KEY As String = "AKIAJUDADCNLURPR6NOA"
    Public Const AWS_SECRET_KEY As String = "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"
    Public Const AWS_S3_DiBS_Bucket As String = "dibseditedimages"
    Public Const AWS_S3_DIBS_BucketPath As String = "https://s3-us-west-2.amazonaws.com/dibseditedimages/"
    Public Const AWS_S3_DIBS_BucketPath_West As String = "https://s3-us-west-2.amazonaws.com/{Bucket}/"
    Public Const AWS_S3_DIBS_BucketPath_East As String = "https://s3.amazonaws.com/{Bucket}/"

    '  Dim client As New Amazon.S3(AWS_ACCESS_KEY, AWS_SECRET_KEY)

    'Dim client As New Amazon.S3.AmazonS3Client(AWS_ACCESS_KEY, AWS_SECRET_KEY)



    Public Function UploadFile_AWS_S3(sLocalFilePath As String, sFileName As String, sFileData As String, Optional sBucket As String = "", Optional oPicbox As PictureBox = Nothing) As String

        Dim oEndPoint As Amazon.RegionEndpoint
        Dim sBucketName As String
        Dim sBucketPath As String

        If sBucket = "" Then
            sBucketName = AWS_S3_DiBS_Bucket
            oEndPoint = Amazon.RegionEndpoint.USWest2
            sBucketPath = AWS_S3_DIBS_BucketPath_West
        Else
            oEndPoint = Amazon.RegionEndpoint.USEast1
            sBucketName = "dibsuploads"
            sBucketPath = AWS_S3_DIBS_BucketPath_East
        End If

        sBucketPath = sBucketPath.Replace("{Bucket}", sBucketName)

        '  Dim client As New Amazon.S3.AmazonS3Client(AWS_ACCESS_KEY, AWS_SECRET_KEY, Amazon.RegionEndpoint.USWest2)
        Dim client As New Amazon.S3.AmazonS3Client(AWS_ACCESS_KEY, AWS_SECRET_KEY, oEndPoint)

        '  Dim S3_KEY As [String] = "DemoCreateFile6.jpg"

        If sFileName = "" Then
            'sFileName = sLocalFilePath.Substring(sLocalFilePath.LastIndexOf("/") + 1)
            '  sFileName = Guid.NewGuid.ToString & ".jpg"
            'This from a web Page so need to download to local then upload

            Dim oGuid As New Guid
            oGuid = Guid.NewGuid
            Dim sReturnAWSPath As String

            sFileName = oGuid.ToString & ".jpg"


            Dim sFilepath As String
            sFilepath = "C:\DiBS_FrontCovers\" & sFileName

            oPicbox.Image.Save(sFilepath, Imaging.ImageFormat.Jpeg)
            sLocalFilePath = sFilepath
        End If

        Dim S3_KEY As String = sFileName
        Dim request As New TransferUtilityUploadRequest
        Dim oTranferUtil As New TransferUtility(client)
        Dim sReturnPath As String
        request.BucketName = sBucketName

        'If sBucket = "" Then
        '    request.BucketName = AWS_S3_DiBS_Bucket
        '    oEndPoint = Amazon.RegionEndpoint.USWest2
        'Else
        '    oEndPoint = Amazon.RegionEndpoint.USEast1
        '    request.BucketName = "dibsuploads"
        'End If


        request.Key = S3_KEY
        request.FilePath = sLocalFilePath
        request.CannedACL = S3CannedACL.PublicRead
        'request.ContentBody = sFileData.ToString
        oTranferUtil.Upload(request)

        sReturnPath = sBucketPath & sFileName

        Return sReturnPath






    End Function

End Module
