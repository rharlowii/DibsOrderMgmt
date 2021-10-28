Imports System.IO
Imports System.Text
Imports System.Web
Imports Azure.Storage.Blobs
Imports Azure.Storage.Blobs.Models
Imports Microsoft.Azure
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Auth
Imports Microsoft.WindowsAzure.Storage.Blob
Imports Windows.Foundation

Module modAZURE
    Public Const AZURE_STORAGE_ACCOUNT As String = "dibsbookstest"
    Public Const AZURE_STORAGE_ACCESS_KEY As String = "bAzd0y0w724GLHLt6zFAcrjKEkigf24AeI0ok55N2KULCrTHca87/zXwephNJdnC/Cbxnqm3vn3x0/35xEjN2w=="
    Public Const Delimiter_AZURE As String = "/"
    Public Const AZURE_STORAGE_CONNECTSTRING = "DefaultEndpointsProtocol=https;AccountName=dibsbookstest;AccountKey=bAzd0y0w724GLHLt6zFAcrjKEkigf24AeI0ok55N2KULCrTHca87/zXwephNJdnC/Cbxnqm3vn3x0/35xEjN2w==;"
    Public Sub UploadFileInBlob()
        '    Dim BlobstorageConnection As String = CloudConfigurationManager.GetSetting("MyBlobStorageConnectionString")
        '    Dim mycloudStorageAccount As CloudStorageAccount = CloudStorageAccount.Parse(BlobstorageConnection)

        '    If Await cloudBlobContainer.CreateIfNotExistsAsync() Then
        '    Await cloudBlobContainer.SetPermissionsAsync(New BlobContainerPermissions With {
        '        .PublicAccess = BlobContainerPublicAccessType.Blob
        '    })
        'End If

        '    Dim imageName As String = "Sample-" & Path.GetExtension(imageToUpload.FileName)
        '    Dim cloudBlockBlob As CloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(imageName)
        '    cloudBlockBlob.Properties.ContentType = imageToUpload.ContentType
        '    Await cloudBlockBlob.UploadFromStreamAsync(imageToUpload.InputStream)
    End Sub
    'Public Sub DownloadFileFromBlob()
    '    Dim containerName = "myblobcontainer"
    '    Dim BlobstorageConnection As String = CloudConfigurationManager.GetSetting("BlobStorageConnectionString")
    '    Dim MycloudStorageAccount As CloudStorageAccount = CloudStorageAccount.Parse(BlobstorageConnection)
    '    Dim MyblobClient As CloudBlobClient = MycloudStorageAccount.CreateCloudBlobClient()
    '    Dim MycloudBlobContainer As CloudBlobContainer = MyblobClient.GetContainerReference(containerName)
    '    Dim MYblockBlob As CloudBlockBlob = MycloudBlobContainer.GetBlockBlobReference("Myuploadedfilename.ext")
    '    Dim memStream As MemoryStream = New MemoryStream()
    '    MYblockBlob.DownloadToStream(memStream)
    '    HttpContext.Current.Response.ContentType = MYblockBlob.Properties.ContentType.ToString()
    '    HttpContext.Current.Response.AddHeader("Content-Disposition", "Attachment; filename=" & MYblockBlob.ToString())
    '    HttpContext.Current.Response.AddHeader("Content-Length", MYblockBlob.Properties.Length.ToString())
    '    HttpContext.Current.Response.BinaryWrite(memStream.ToArray())
    '    HttpContext.Current.Response.Flush()
    '    HttpContext.Current.Response.Close()
    'End Sub

    Public Function DownloadFileFromBlob(sContainer As String, sFileName As String, sOutputPath As String)
        Dim accountname As String = AZURE_STORAGE_ACCOUNT
        Dim accountkey As String = AZURE_STORAGE_ACCESS_KEY

        Dim creds As StorageCredentials = New StorageCredentials(accountname, accountkey)
        Dim account As CloudStorageAccount = New CloudStorageAccount(creds, useHttps:=True)

        Dim client = account.CreateCloudBlobClient()

        'Dim container As CloudBlobContainer = client.GetContainerReference("books/BrainHive_Partners/Crabtree/Batch4/9781427197825/")
        Dim container As CloudBlobContainer = client.GetContainerReference(sContainer)

        Dim blob As CloudBlockBlob = container.GetBlockBlobReference(sFileName)
        Dim oMemoryStream = New MemoryStream()
        blob.DownloadToStream(oMemoryStream)

        'My.Settings.downloadsource = System.Text.Encoding.UTF8.GetString(MemoryStream.ToArray())
        ' equipmentpdf.src = filenamelbl.Text

        'oMemoryStream.Read()

        'Dim buffer As New Byte()
        'Dim ms As New MemoryStream(buffer)
        'write to file
        Dim file As New FileStream(sOutputPath & "\" & sFileName, FileMode.Create, FileAccess.Write)
        oMemoryStream.WriteTo(file)
        file.Close()
        oMemoryStream.Close()

    End Function

    Public Function GetThumbNailFromBlob()
        Dim accountname As String = AZURE_STORAGE_ACCOUNT
        Dim accountkey As String = AZURE_STORAGE_ACCESS_KEY

        Dim blobServiceClient As BlobServiceClient = New BlobServiceClient(AZURE_STORAGE_CONNECTSTRING)
        Dim containerName As String = "books/BrainHive_Partners/Rourke/Batch10/9781615908080/thumbnails/"

        Dim ContainerClient As BlobContainerClient

        ContainerClient = blobServiceClient.GetBlobContainerClient(containerName)
        ' Dim container As CloudBlobContainer = client.GetContainerReference("https://dibsbookstest.blob.core.windows.net:443/books/BrainHive_Partners/Rourke/Batch10/9781615908080/thumbnails/")
        ' oBlobs = container.ListBlobs
        '  oDirectory = container.GetDirectoryReference("")
        ' Dim blobFiles = New List(Of String)()
        Dim blobFiles = New List(Of BlobClient)


        Dim asyncPageable As Azure.AsyncPageable(Of BlobItem) = ContainerClient.GetBlobsAsync()






    End Function

    'Public Function GetBlobFiles(containerName As String) As List(Of String)
    '    Dim blobFiles = New List(Of String)()
    '    Dim storageAccount As CloudStorageAccount = CloudStorageAccount.Parse(AZURE_STORAGE_ACCOUNT)
    '    Dim blobclient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
    '    Dim blobcontainer As CloudBlobContainer = blobclient.GetContainerReference(containerName)
    '    For Each item As IListBlobItem In blobcontainer.ListBlobs(Nothing, False)
    '        If item.[GetType]() = GetType(CloudBlockBlob) Then
    '            Dim blob As CloudBlockBlob = DirectCast(item, CloudBlockBlob)
    '            blobFiles.Add(blob.Name)
    '        End If
    '    Next
    '    Return blobFiles
    'End Function






End Module
