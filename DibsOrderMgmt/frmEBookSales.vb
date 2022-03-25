Imports System.Data.SqlClient

Public Class frmEBookSales
    Public oOrderID As Guid
    Public bAllEBookSales As Boolean = True

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub LoadEBooksSalesGrid()

        Dim sSQL As String

        If bAllEBookSales = True Then
            sSQL = "SELECT * FROM DiBS_DB_Prod.dbo.omEbookSales"
        Else
            sSQL = "SELECT * FROM DiBS_DB_Prod.dbo.omEbookSales where OrderId='" & oOrderID.ToString & "'"
        End If


        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        gridEBookSales.DataSource = ds.Tables(0)





    End Sub

    Private Sub frmEBookSales_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadEBooksSalesGrid()
    End Sub

    Private Sub cmdAddeBookSales_Click(sender As Object, e As EventArgs) Handles cmdAddeBookSales.Click
        Dim ofrmBrowser As New frmEBookSalesAdd
        'frmEBookSalesAdd
        With ofrmBrowser
            ' .oOrderID = Guid.Parse(sOrderID)
            ' .bAllEBookSales = True
            ' .HTMLFolder = seBookPath

            .Show(Me.Owner)
        End With
    End Sub
End Class