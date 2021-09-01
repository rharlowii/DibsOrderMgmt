﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Public Class frmOrderSets

    Public oOrderID As Guid

    Public DocFullFilePath As String = ""
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' OmOrderSetsTableAdapter1.Fill(DiBS_DB_ProdDataSet21.omOrderSets)
    End Sub

    Private Sub frmOrderSets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderSetsGrid()
    End Sub

    Private Sub LoadOrderSetsGrid()

        Dim sSQL As String = "SELECT * FROM omOrderSets where OrderID='" & oOrderID.ToString & "' Order By SetName"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        gridOrderSets.DataSource = ds.Tables(0)





    End Sub

    Private Sub gridOrderSets_Click(sender As Object, e As EventArgs) Handles gridOrderSets.Click

    End Sub

    Private Sub gridOrderSets_TextChanged(sender As Object, e As EventArgs) Handles gridOrderSets.TextChanged

    End Sub

    Private Sub gridOrderSets_Validating(sender As Object, e As CancelEventArgs) Handles gridOrderSets.Validating

    End Sub

    Private Sub gridOrderSets_Validated(sender As Object, e As EventArgs) Handles gridOrderSets.Validated



    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        Dim sColumnName As String
        Dim sValue As String
        Dim iRowHandle As Integer
        Dim oOrderSetID As Guid
        Dim oRow As DataRow
        '    Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        'Dim selectedRowHandle As Int32

        sColumnName = e.Column.FieldName
        sValue = e.Value
        iRowHandle = e.RowHandle


        oRow = GridView1.GetDataRow(iRowHandle)
        If oRow.Item("OrderSetID").ToString() = "" Then
            'Then this must be a new row....exit
            Exit Sub
        End If
        'oRow.Item("OrderID").ToString()
        oOrderSetID = Guid.Parse(oRow.Item("OrderSetID").ToString())
        sValue = oRow.Item(sColumnName).ToString()

        SaveOrderSets(sColumnName, sValue, oOrderSetID.ToString)
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        '  MsgBox("")


    End Sub

    Private Sub frmOrderSets_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing



    End Sub

    Public Function SaveOrderSets(sColumnName As String, sValue As String, sOrderSetID As String)

        Dim sEXEC As String = ""

        Dim sReturn As String



        sEXEC = sEXEC.Replace("{sColumnNameParm}", sColumnName)
        ' sEXEC = sEXEC.Replace("{sValueParm}", sColumnName)


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = Guid.Parse(sOrderSetID)

            Select Case sColumnName

                Case "BoxNumber"
                    sEXEC = "Update omOrderSets Set BoxNumber= @BoxNumberParm where OrderSetID=@OrderSetID"
                    .Parameters.Add("@BoxNumberParm", SqlDbType.Int).Value = sValue

                Case "SetName"
                    sEXEC = "Update omOrderSets Set SetName= @SetNameParm where OrderSetID=@OrderSetID"
                    .Parameters.Add("@SetNameParm", SqlDbType.NVarChar).Value = sValue

                Case "SetDesc"
                    sEXEC = "Update omOrderSets Set SetDesc= @SetDescParm where OrderSetID=@OrderSetID"
                    .Parameters.Add("@SetDescParm", SqlDbType.NVarChar).Value = sValue

                Case Else
                    MsgBox("No Column Name")
                    GoTo exitsub1
            End Select

            .CommandText = sEXEC

            sReturn = .ExecuteNonQuery
        End With




exitsub1:

        oConnection.Close()
        Return sReturn
    End Function

    Public Function omOrderSets_IU(oOrderSet As Object) As String

        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1
        'Hack to get around passing structures
        Dim moOrderSet As OrderSet
        moOrderSet = oOrderSet

        ' Dim sEXEC As String = "omOrderSets_IU @OrderSetID,@OrderID,@BoxNumber,@SetName,@SetDesc"
        Dim sEXEC As String = "omOrderSets_IU @OrderSetID,@OrderID,@SetName,@SetDesc,@QTY,@ListPrice,@ExtendPrice"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        Dim oOrderSetID As Guid

        oOrderSetID = Guid.NewGuid

        With myCommand
            .Parameters.Add("@OrderSetID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(moOrderSet.OrderSetID)
            .Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(moOrderSet.OrderID)

            .Parameters.Add("@QTY", SqlDbType.Int).Value = moOrderSet.QTY
            .Parameters.Add("@SetName", SqlDbType.NVarChar).Value = moOrderSet.SetName
            .Parameters.Add("@SetDesc", SqlDbType.NVarChar).Value = moOrderSet.SetDesc

            .Parameters.Add("@ListPrice", SqlDbType.Decimal).Value = moOrderSet.ListPrice
            .Parameters.Add("@ExtendPrice", SqlDbType.Decimal).Value = moOrderSet.ExtendedPrice

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function


    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow

    End Sub



    Private Sub GridView1_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor




    End Sub

    Private Sub ValidateRows()

    End Sub

    Private Sub cmdAddNewOrderSet_Click(sender As Object, e As EventArgs) Handles cmdAddNewOrderSet.Click
        Dim sQTY As String
        Dim sSetName As String
        Dim sSetDesc As String

        Dim oOrderSet As New OrderSet
        Dim ofrmOrderSet As New frmOrderSetNew




        With ofrmOrderSet
            .oOrderID = oOrderID

            .bUpdateOrderSet = False

            .ShowDialog()
            If .bCanceled = True Then Exit Sub
            oOrderSet = .oOrderSet
        End With




        omOrderSets_IU(oOrderSet)

        LoadOrderSetsGrid()


    End Sub

    Private Sub BarButtonItem1_EditOrderSet_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_EditOrderSet.ItemClick
        Dim oOrderSetID As Guid
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow
        Dim oOrderSet As OrderSet

        Try
            Me.Cursor = Cursors.WaitCursor

            If selectedRowHandles.Count <> 1 Then
                MsgBox("Must select 1 Row")
                Exit Sub
            End If
            selectedRowHandle = selectedRowHandles(0)

            oRow = GridView1.GetDataRow(selectedRowHandle)

            'oRow.Item("OrderID").ToString()
            oOrderSetID = Guid.Parse(oRow.Item("OrderSetID").ToString())


            Dim oForm As New frmOrderSetNew


            With oForm
                .oOrderID = oOrderID
                .oOrderSetID = oOrderSetID
                .bUpdateOrderSet = True
                '.dgv_Grid.DataSource = ds.Tables(0)
                .txtSetName.Text = oRow.Item("SetName").ToString
                .txtSetDesc.Text = oRow.Item("SetDesc").ToString

                .txtQTY.Text = oRow.Item("QTY").ToString
                .txtListPrice.Text = oRow.Item("ListPrice").ToString
                .txtExtendedPrice.Text = oRow.Item("ExtendPrice").ToString


                Me.Cursor = Cursors.Default
                .ShowDialog()

                If .bCanceled = True Then Exit Sub

                'Update
                oOrderSet = .oOrderSet
                omOrderSets_IU(oOrderSet)
            End With
            'Refresh the grid (Could speed up by not refreshing a cancel)
            LoadOrderSetsGrid()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridView1.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
End Class