Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.Spreadsheet
Public Class frmEBookSalesAdd
    Public oOrderID As Guid


    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub frmEBookSalesAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitAddEBookByISBNFreeForm()
    End Sub

    Public Sub InitAddEBookByISBNFreeForm()
        Dim oWorkSheet As Spreadsheet.Worksheet


        oWorkSheet = spreadAddeBooks.ActiveWorksheet


        With oWorkSheet.Range("A1")
            .Value = "Title (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With
        'oWorkSheet.Range.FromLTRB(1, 0, 1, 0)

        With oWorkSheet.Range("B1")
            .Value = "Pub ID (Not Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("C1")
            .Value = "Pub Name (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("D1")
            .Value = "ISBN (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("E1")
            .Value = "Price (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("F1")
            .Value = "School Name (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("G1")
            .Value = "Load Dates (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("H1")
            .Value = "Distributor (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("I1")
            .Value = "Add Status #"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 800

        End With

        With oWorkSheet.Range("J1")
            .Value = "Add Status MSG"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 2000

        End With

        Dim range As CellRange = oWorkSheet("A1:J10000")
        oWorkSheet.AutoFilter.Apply(range)



    End Sub

    Private Sub cmdAddeBookSales_Click(sender As Object, e As EventArgs) Handles cmdAddeBookSales.Click
        Dim oWorkSheet As Spreadsheet.Worksheet
        Dim iMaxRows As Integer = 10000
        Dim oEBookSaleItems As New List(Of EBookSaleItem)
        Dim iBlankCount As Integer
        Dim oeBookSaleItem As EBookSaleItem
        Dim iRow As Integer

        Dim iMsgRtrn As DialogResult
        Dim sMsg As String

        Dim sOrderSetID As String
        Dim sOrderSet As String
        Dim sQTY As String
        Dim ieBookSaleItemCount As Integer

        Dim sItemNumberISBN As String
        Dim iPreviousRunStatus As OrderItemStatus
        Dim sPreviousRunStatusText As String
        Dim bRecordAlreadyAddPrevious As Boolean

        oWorkSheet = spreadAddeBooks.ActiveWorksheet

        'oWorkSheet.Range("A1").Value = "Title (Required)"
        'oWorkSheet.Range("B1").Value = "Pub ID (Not Required)"
        'oWorkSheet.Range("C1").Value = "Pub Name (Required)"
        'oWorkSheet.Range("D1").Value = "ISBN (Required)"
        'oWorkSheet.Range("E1").Value = "Price (Required)"
        'oWorkSheet.Range("F1").Value = "School Name (Required)"
        'oWorkSheet.Range("G1").Value = "Load Dates (Required)"
        'oWorkSheet.Range("H1").Value = "Distributor (Required)"
        'oWorkSheet.Range("I1").Value = "Add Status #"
        'oWorkSheet.Range("J1").Value = "Add Status MSG"



        ' sOrderSet = cmbOrderSet.Text
        sMsg = "You are about to add 'eBook Sales' Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMsg, "Add eBook Sales?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.Cancel Then
            Exit Sub

        End If
        For iRow = 2 To iMaxRows
            oeBookSaleItem = New EBookSaleItem
            sPreviousRunStatusText = oWorkSheet.Range("J" & iRow).Value.ToString()
            bRecordAlreadyAddPrevious = False

            If sPreviousRunStatusText = "" Then
                'It is ok...we can 
            Else


            End If
            With oeBookSaleItem
                .OrderID = oOrderID.ToString

                'Create a new id....but if an update...it will not be used
                .EBookSaleItemID = Guid.NewGuid.ToString


                sItemNumberISBN = oWorkSheet.Range("D" & iRow).Value.ToString()

                If iBlankCount > 3 Then
                    GoTo BlankCountMaxHit
                End If

                If sItemNumberISBN.Length = 0 Then
                    iBlankCount = iBlankCount + 1
                    GoTo BlankRowHit
                Else
                    iBlankCount = 0
                End If


                .ISBN = sItemNumberISBN
                If .ISBN = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing ISBN"

                End If

                .Title = oWorkSheet.Range("A" & iRow).Value.ToString

                If .Title = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing Title"

                End If
                .PubID = oWorkSheet.Range("B" & iRow).Value.ToString
                .PubName = oWorkSheet.Range("C" & iRow).Value.ToString

                If .PubName = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing Pub Name"

                End If
                .Price = oWorkSheet.Range("E" & iRow).Value.ToString

                If .Price.ToString = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing Price"

                End If
                .SchoolName = oWorkSheet.Range("F" & iRow).Value.ToString
                If .SchoolName = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing School Name"

                End If
                .LoadDate = oWorkSheet.Range("G" & iRow).Value.ToString
                If .LoadDate.ToString = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing Load Date"

                End If
                .Distributor = oWorkSheet.Range("H" & iRow).Value.ToString
                If .Distributor = "" Then
                    .EBookSaleItemStatus = EBookSaleItemStatus.MissingCriticalInfo
                    .EBookSaleItemStatusText = "Missing Distributor"

                End If
                'Lets default eBooks Sales as 1 just to make DB calcs easier
                sQTY = 1
                .QTY = sQTY

                'If sQTY = "" Then
                '    .OrderItemStatus = OrderItemStatus.MissingCriticalInfo
                '    .OrderItemStatusText = "Missing QTY"
                'Else
                '    .QTY = sQTY
                'End If


            End With

            ''No use to hit db if you are missing critical info like QTY
            'If oeBookSaleItem.EBookSaleItemStatus <> EBookSaleItemStatus.MissingCriticalInfo Then
            '    SetOtherMetaData(oOrderItem)
            'End If
            oEBookSaleItems.Add(oeBookSaleItem)
BlankRowHit:
        Next
BlankCountMaxHit:


        'Lets add the items that we can

        For Each moEBookSaleItem In oEBookSaleItems
            ieBookSaleItemCount = ieBookSaleItemCount + 1
            'No use to hit db if you are missing critical info like QTY
            If moEBookSaleItem.EBookSaleItemStatus = OrderItemStatus.NoStaus Then

                'ok...try and add to the Database
                omEbookSales_IU_ALT(moEBookSaleItem, oOrderID)


            End If

            If moEBookSaleItem.EBookSaleItemStatus <> 0 Then
                oWorkSheet.Range("I" & ieBookSaleItemCount + 1).Value = moEBookSaleItem.EBookSaleItemStatus
                oWorkSheet.Range("j" & ieBookSaleItemCount + 1).Value = moEBookSaleItem.EBookSaleItemStatusText

                oWorkSheet.Range("I" & ieBookSaleItemCount + 1).Fill.BackgroundColor = Color.MistyRose
                oWorkSheet.Range("J" & ieBookSaleItemCount + 1).Fill.BackgroundColor = Color.MistyRose
            Else
                'Clear the text because it could be a rerun
                oWorkSheet.Range("I" & ieBookSaleItemCount + 1).Value = ""
                oWorkSheet.Range("J" & ieBookSaleItemCount + 1).Value = ""

                oWorkSheet.Range("I" & ieBookSaleItemCount + 1).Fill.BackgroundColor = Color.Empty
                oWorkSheet.Range("J" & ieBookSaleItemCount + 1).Fill.BackgroundColor = Color.Empty

            End If


        Next






    End Sub
End Class