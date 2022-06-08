Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.Spreadsheet

Public Class frmOrderItemsAdd

    Public oOrderID As Guid
    Public BPPONumber As String

    Private Sub frmOrderItemsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiBS_DB_ProdDataSet3.omPartners' table. You can move, or remove it, as needed.
        'Me.OmPartnersTableAdapter.Fill(Me.DiBS_DB_ProdDataSet3.omPartners)
        LoadPartners()
        LoadOrderSets()
        ' LoadStates2()
        InitAddByISBNSpread()
        InitAddByISBNFreeForm()

    End Sub
    Public Sub InitAddByISBNSpread()
        Dim oWorkSheet As Spreadsheet.Worksheet


        oWorkSheet = spreadAddByISBN.ActiveWorksheet


        With oWorkSheet.Range("A1")
            .Value = "ISBN (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With
        'oWorkSheet.Range.FromLTRB(1, 0, 1, 0)
        oWorkSheet.Columns("A").NumberFormat = "#####"
        With oWorkSheet.Range("B1")
            .Value = "Title (Optional)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("C1")
            .Value = "QTY (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("D1")
            .Value = "Add Status #"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("E1")
            .Value = "Add Status MSG"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 3000

        End With

        Dim range As CellRange = oWorkSheet("A1:E10000")
        oWorkSheet.AutoFilter.Apply(range)



    End Sub
    Public Sub InitAddByISBNFreeForm()
        Dim oWorkSheet As Spreadsheet.Worksheet


        oWorkSheet = spreadAddFreeForm.ActiveWorksheet


        With oWorkSheet.Range("A1")
            .Value = "ISBN (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With
        'oWorkSheet.Range.FromLTRB(1, 0, 1, 0)
        oWorkSheet.Columns("A").NumberFormat = "#####"

        With oWorkSheet.Range("B1")
            .Value = "Title (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("C1")
            .Value = "QTY (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("D1")
            .Value = "List Price (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("E1")
            .Value = "Add Status #"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("F1")
            .Value = "Add Status MSG"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 3000

        End With

        Dim range As CellRange = oWorkSheet("A1:F10000")
        oWorkSheet.AutoFilter.Apply(range)



    End Sub
    Private Sub LoadOrderSets()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim sSQL As String = "SELECT OrderSetID,SetName FROM dbo.omOrderSets where OrderID='" & oOrderID.ToString & "' ORDER BY omOrderSets.SetName"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        iCount = ds.Tables(0).Rows.Count

        Dim oNewRow As DataRow
        With ds.Tables(0)
            oNewRow = .NewRow()

            oNewRow.Item(0) = Guid.Empty
            oNewRow.Item(1) = 0
            'oNewRow.Item(2) = ""
            .Rows.Add(oNewRow)
        End With

        With cmbOrderSet.Properties
            .DataSource = ds.Tables(0)
            'Column Names are Case Sensitive

            .ValueMember = "OrderSetID"
            .DisplayMember = "SetName"

        End With

        cmbOrderSet.EditValue = Guid.Empty


        With cmbOrderSet2.Properties
            .DataSource = ds.Tables(0)
            'Column Names are Case Sensitive

            .ValueMember = "OrderSetID"
            .DisplayMember = "SetName"

        End With
        cmbOrderSet2.EditValue = Guid.Empty
    End Sub
    Private Sub LoadPartners()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim sSQL As String = "SELECT PartnerID,PublisherName FROM dbo.omPartners Order BY omPartners.PublisherName"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count

        Dim oNewRow As DataRow
        With ds.Tables(0)
            oNewRow = .NewRow()

            oNewRow.Item(0) = -1
            oNewRow.Item(1) = ""
            .Rows.Add(oNewRow)
        End With


        With cmbPartner.Properties
            'Column Names are Case Sensitive
            .ValueMember = "PartnerID"
            .DisplayMember = "PublisherName"
            .DataSource = ds.Tables(0)





        End With
        cmbPartner.EditValue = -1

    End Sub

    Private Sub LoadStates2()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim sSQL As String = "SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count


        With cmbPartner.Properties
            .DataSource = ds.Tables(0)
            .ValueMember = "State"
            .DisplayMember = "State"






        End With

    End Sub

    Private Sub cmdAddNewOrderSet_Click(sender As Object, e As EventArgs)
        MsgBox(cmbPartner.EditValue)
    End Sub

    Private Sub mainTab_Paint(sender As Object, e As PaintEventArgs) Handles mainTab.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub cmdAddOrderItemsByISBN_Click(sender As Object, e As EventArgs) Handles cmdAddOrderItemsByISBN.Click
        Dim oWorkSheet As Spreadsheet.Worksheet
        Dim iMaxRows As Integer = 10000
        Dim oOrderItems As New List(Of OrderItem)
        Dim iBlankCount As Integer
        Dim oOrderItem As OrderItem
        Dim iRow As Integer
        Dim iPartnerID As Integer
        Dim sPartner As String
        Dim iMsgRtrn As DialogResult
        Dim sMsg As String

        Dim sOrderSetID As String
        Dim sOrderSet As String
        Dim sQTY As String
        Dim iOrderItemCount As Integer

        Dim sItemNumberISBN As String
        Dim iPreviousRunStatus As OrderItemStatus
        Dim sPreviousRunStatusText As String
        Dim bRecordAlreadyAddPrevious As Boolean

        oWorkSheet = spreadAddByISBN.ActiveWorksheet

        iPartnerID = cmbPartner.EditValue
        sPartner = cmbPartner.Text

        If IsNothing(cmbOrderSet.EditValue) = False Then
            sOrderSetID = cmbOrderSet.EditValue.ToString
        Else
            sOrderSetID = ""
        End If

        sOrderSet = cmbOrderSet.Text
        sMsg = "You are about to add 'Order Items' for the Partner: '" & sPartner & "' into the Order Set: '" & sOrderSet & "' Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMsg, "Add Order Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If
        For iRow = 2 To iMaxRows
            oOrderItem = New OrderItem
            sPreviousRunStatusText = oWorkSheet.Range("D" & iRow).Value.ToString()
            bRecordAlreadyAddPrevious = False

            If sPreviousRunStatusText = "" Then
                'It is ok...we can 
            Else


            End If
            With oOrderItem

                sItemNumberISBN = oWorkSheet.Range("A" & iRow).Value.ToString()


                If iBlankCount > 3 Then
                    GoTo BlankCountMaxHit
                End If

                If sItemNumberISBN.Length = 0 Then
                    iBlankCount = iBlankCount + 1
                    GoTo BlankRowHit
                Else
                    iBlankCount = 0
                End If
                .OrderItemID = Guid.NewGuid.ToString
                .OrderSetID = sOrderSetID
                'we want to get the partner from DB if possible
                '.PartnerID = iPartnerID
                .MetaDataID = vbNullString

                .ItemNumberISBN = sItemNumberISBN

                .ItemDesc = oWorkSheet.Range("B" & iRow).Value.ToString
                sQTY = oWorkSheet.Range("C" & iRow).Value.ToString

                If sQTY = "" Then
                    .OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                    .OrderItemStatusText = "Missing QTY"
                Else
                    .QTY = sQTY
                End If


            End With

            'No use to hit db if you are missing critical info like QTY
            If oOrderItem.OrderItemStatus <> OrderItemStatus.MissingCriticalInfo Then
                SetOtherMetaData(oOrderItem)
            End If
            oOrderItems.Add(oOrderItem)
BlankRowHit:
        Next
BlankCountMaxHit:


        'Lets add the items that we can

        For Each moOrderItem In oOrderItems
            iOrderItemCount = iOrderItemCount + 1
            'No use to hit db if you are missing critical info like QTY
            If moOrderItem.OrderItemStatus = OrderItemStatus.NoStaus Then

                'ok...try and add to the Database
                omOrderItems_IU_ALT(moOrderItem, oOrderID)


            End If

            If moOrderItem.OrderItemStatus <> 0 Then
                oWorkSheet.Range("D" & iOrderItemCount + 1).Value = moOrderItem.OrderItemStatus
                oWorkSheet.Range("E" & iOrderItemCount + 1).Value = moOrderItem.OrderItemStatusText

                oWorkSheet.Range("D" & iOrderItemCount + 1).Fill.BackgroundColor = Color.MistyRose
                oWorkSheet.Range("E" & iOrderItemCount + 1).Fill.BackgroundColor = Color.MistyRose
            Else
                'Clear the text because it could be a rerun
                oWorkSheet.Range("D" & iOrderItemCount + 1).Value = ""
                oWorkSheet.Range("E" & iOrderItemCount + 1).Value = ""

                oWorkSheet.Range("D" & iOrderItemCount + 1).Fill.BackgroundColor = Color.Empty
                oWorkSheet.Range("E" & iOrderItemCount + 1).Fill.BackgroundColor = Color.Empty

            End If


        Next






    End Sub


    Private Sub SetOtherMetaData(ByRef oOrderItem As OrderItem)



        Dim sSQL As String = "SELECT MetaDataID,PartnerID,Partner,Paperback_ISBN_13,Title,Paperback_List_Price FROM DiBS_DB_Prod.dbo.omMetaData WHERE Paperback_ISBN_13="
        sSQL = sSQL & "'" & oOrderItem.ItemNumberISBN & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer
        Dim sListPrice As String


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()



        iCount = ds.Tables(0).Rows.Count

        Select Case iCount
            Case 1

                With oOrderItem
                    .ItemDesc = ds.Tables(0).Rows(0).Item("Title").ToString
                    .PartnerID = ds.Tables(0).Rows(0).Item("PartnerID").ToString

                    sListPrice = ds.Tables(0).Rows(0).Item("Paperback_List_Price").ToString

                    If sListPrice <> "" Then
                        .ListPrice = sListPrice

                        .ExtendedPrice = .QTY * .ListPrice
                        .MetaDataID = ds.Tables(0).Rows(0).Item("MetaDataID").ToString

                    Else
                        oOrderItem.OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                        oOrderItem.OrderItemStatusText = "Found in DB, but the List Price is Missing."
                    End If


                End With
            Case 0
                oOrderItem.OrderItemStatus = OrderItemStatus.NotFoundInDB
                oOrderItem.OrderItemStatusText = "Item Not found in the Database"
            Case Else
                oOrderItem.OrderItemStatus = OrderItemStatus.Morethan1FoundInDB
                oOrderItem.OrderItemStatusText = "Found more than 1 Item with that number in the Database"

        End Select
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub cmdAddOrderItemsFreeForm_Click(sender As Object, e As EventArgs) Handles cmdAddOrderItemsFreeForm.Click
        Dim oWorkSheet As Spreadsheet.Worksheet
        Dim iMaxRows As Integer = 10000
        Dim oOrderItems As New List(Of OrderItem)
        Dim iBlankCount As Integer
        Dim oOrderItem As OrderItem
        Dim iRow As Integer
        Dim iPartnerID As Integer
        Dim sPartner As String
        Dim iMsgRtrn As DialogResult
        Dim sMsg As String

        Dim sOrderSetID As String
        Dim sOrderSet As String

        Dim sItemNumberISBN As String
        Dim sItemDesc As String
        Dim sQTY As String
        Dim sListPrice As String
        Dim iOrderItemCount As Integer


        Dim iPreviousRunStatus As OrderItemStatus
        Dim sPreviousRunStatusText As String
        Dim bRecordAlreadyAddPrevious As Boolean

        oWorkSheet = spreadAddFreeForm.ActiveWorksheet

        iPartnerID = cmbPartner.EditValue
        sPartner = cmbPartner.Text

        If sPartner.Length = 0 Then
            sMsg = "You must select a Partner when adding items via FREE Form."
            iMsgRtrn = MessageBox.Show(sMsg, "Select a Partner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If IsNothing(cmbOrderSet2.EditValue) = False Then
            sOrderSetID = cmbOrderSet2.EditValue.ToString
        Else
            sOrderSetID = ""
        End If

        sOrderSet = cmbOrderSet2.Text
        sMsg = "You are about to add 'Order Items' for the Partner: '" & sPartner & "' into the Order Set: '" & sOrderSet & "' Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMsg, "Add Order Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If

        For iRow = 2 To iMaxRows
            oOrderItem = New OrderItem
            sPreviousRunStatusText = oWorkSheet.Range("E" & iRow).Value.ToString()
            bRecordAlreadyAddPrevious = False

            If sPreviousRunStatusText = "" Then
                'It is ok...we can 
            Else


            End If
            With oOrderItem

                sItemNumberISBN = oWorkSheet.Range("A" & iRow).Value.ToString()
                'Free...we need to set he Partner ID
                .PartnerID = iPartnerID

                If iBlankCount > 3 Then
                    GoTo BlankCountMaxHit
                End If

                If sItemNumberISBN.Length = 0 Then
                    iBlankCount = iBlankCount + 1

                    'Since Free Form...no need to bail 
                    'GoTo BlankRowHit
                Else
                    iBlankCount = 0
                End If
                .OrderItemID = Guid.NewGuid.ToString
                .OrderSetID = sOrderSetID
                'we want to get the partner from DB if possible
                '.PartnerID = iPartnerID
                .MetaDataID = vbNullString

                ' .ItemNumberISBN = sItemNumberISBN


                If sItemNumberISBN = "" Then
                    .OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                    .OrderItemStatusText = "Missing Item Number/ISBN"
                Else
                    .ItemNumberISBN = sItemNumberISBN

                End If


                sItemDesc = oWorkSheet.Range("B" & iRow).Value.ToString

                If sItemDesc = "" Then
                    .OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                    .OrderItemStatusText = "Missing Item Desc"
                Else
                    .ItemDesc = sItemDesc

                End If

                sQTY = oWorkSheet.Range("C" & iRow).Value.ToString

                If sQTY = "" Then
                    .OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                    .OrderItemStatusText = "Missing QTY"
                Else
                    .QTY = sQTY
                End If


                sListPrice = oWorkSheet.Range("D" & iRow).Value.ToString

                If sListPrice = "" Then
                    .OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                    .OrderItemStatusText = "Missing List Price"
                Else
                    .ListPrice = sListPrice
                End If

                If .OrderItemStatus <> OrderItemStatus.MissingCriticalInfo Then
                    .ExtendedPrice = .ListPrice * .QTY

                End If
            End With



            'No use to hit db if you are missing critical info like QTY
            'For Free Form....we are not hitting the DB....because it is probably not there
            'If oOrderItem.OrderItemStatus <> OrderItemStatus.MissingCriticalInfo Then
            '    SetOtherMetaData(oOrderItem)
            'End If

            oOrderItems.Add(oOrderItem)
BlankRowHit:
        Next
BlankCountMaxHit:


        'Lets add the items that we can

        For Each moOrderItem In oOrderItems
            iOrderItemCount = iOrderItemCount + 1
            'No use to hit db if you are missing critical info like QTY
            If moOrderItem.OrderItemStatus = OrderItemStatus.NoStaus Then

                'ok...try and add to the Database
                omOrderItems_IU_ALT(moOrderItem, oOrderID)


            End If

            If moOrderItem.OrderItemStatus <> 0 Then
                oWorkSheet.Range("E" & iOrderItemCount + 1).Value = moOrderItem.OrderItemStatus
                oWorkSheet.Range("F" & iOrderItemCount + 1).Value = moOrderItem.OrderItemStatusText

                oWorkSheet.Range("E" & iOrderItemCount + 1).Fill.BackgroundColor = Color.MistyRose
                oWorkSheet.Range("F" & iOrderItemCount + 1).Fill.BackgroundColor = Color.MistyRose
            Else
                'Clear the text because it could be a rerun
                oWorkSheet.Range("E" & iOrderItemCount + 1).Value = ""
                oWorkSheet.Range("F" & iOrderItemCount + 1).Value = ""

                oWorkSheet.Range("E" & iOrderItemCount + 1).Fill.BackgroundColor = Color.Empty
                oWorkSheet.Range("F" & iOrderItemCount + 1).Fill.BackgroundColor = Color.Empty

            End If


        Next





    End Sub

    Private Sub XtraTabPage2_Paint(sender As Object, e As PaintEventArgs) Handles XtraTabPage2.Paint

    End Sub

    Private Sub cmdClearOrderItemsFreeForm_Click(sender As Object, e As EventArgs) Handles cmdClearOrderItemsFreeForm.Click
        spreadAddFreeForm.ActiveWorksheet.Cells.Clear
        InitAddByISBNFreeForm()
    End Sub

    Private Sub cmbPartner_EditValueChanged(sender As Object, e As EventArgs) Handles cmbPartner.EditValueChanged

    End Sub


End Class