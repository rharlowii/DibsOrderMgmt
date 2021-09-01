Imports System.IO

Public Class frmPDFViewer

    Public PDFBytes As Byte()



    Public Function LoadPDF()

        Dim stream As Stream = New MemoryStream(PDFBytes)

        PdfViewer1.LoadDocument(stream)
    End Function

    Private Sub PdfViewer1_Load(sender As Object, e As EventArgs) Handles PdfViewer1.Load

    End Sub

    Private Sub frmPDFViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class