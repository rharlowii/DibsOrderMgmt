Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Imports DevExpress
Imports DevExpress.Export.Xl
Imports DevExpress.Spreadsheet
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEBookMGMT
    Public DiBSBooksTabClickedOnce As Boolean = False

    Private Sub frmEBookMGMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetConnection()
        ' LoadLines()
        ' LoadStates()
        LoadStates2()
        LoadDisctricts2()
        LoadLines()
        InitAddByISBNFreeForm()


        'If bExistingOrder = True Then
        '    'Existing order, so we need to set the textboxes
        '    LoadExistingOrder(oOrderID.ToString)
        'Else
        '    'New Order
        '    cmbOrderStatus.EditValue = 0
        'End If



        cmbStates2.Focus()
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


        With cmbStates2.Properties
            .DataSource = ds.Tables(0)
            .ValueMember = "State"
            .DisplayMember = "State"






        End With

    End Sub

    Private Sub LoadSchools2(Optional sSearchText As String = "")

        Dim sSQL As String
        Dim sDistrictID As String


        If IsNothing(cmbDistricts2.EditValue) Then
            sDistrictID = ""
        Else
            sDistrictID = cmbDistricts2.EditValue.ToString
        End If
        txtDistrictID.Text = sDistrictID

        If sDistrictID.Length > 0 Then
            If chkShowOnlySchoolsWBooks.CheckState = CheckState.Unchecked Then
                sSQL = "SELECT ID,Name FROM Schools where SchoolDistrictID='" & sDistrictID & "' Order by Name"

            Else
                sSQL = "SELECT ID,Name FROM School_BookCountGreaterThanZero where SchoolDistrictID='" & sDistrictID & "' Order by Name"

            End If
        Else
            If chkShowOnlySchoolsWBooks.CheckState = CheckState.Unchecked Then

                sSQL = "SELECT * FROM Schools Order by Name"


            Else
                sSQL = "SELECT * FROM School_BookCountGreaterThanZero Order by Name"

            End If
        End If

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)


        da.Fill(ds)
        oConnection.Close()

        If sSearchText.Length > 0 Then
            ds.Tables(0).DefaultView.RowFilter = "Name LIKE '*" & sSearchText & "*'"
        End If
        With cmbSchools2.Properties
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)


        End With

    End Sub
    Private Sub cmbStates2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbStates2.EditValueChanged
        LoadDisctricts2()
        'LoadSchools()
    End Sub
    Private Sub cmbDistricts2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDistricts2.EditValueChanged
        LoadSchools2()
        txtDistrictID.Text = cmbDistricts2.EditValue.ToString
    End Sub
    Private Sub LoadDisctricts2()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString
        sState = cmbStates2.EditValue.ToString

        If sState = "" Then
            sSQL = "SELECT ID,Name FROM SchoolDistricts Order by Name"
        Else
            sSQL = "SELECT ID,Name FROM SchoolDistricts where State='" & sState & "' Order by Name"
        End If
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With cmbDistricts2.Properties


            .DataSource = ds.Tables(0)
            .ValueMember = "ID"
            .DisplayMember = "Name"


        End With


    End Sub

    Private Sub cmbSchools2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSchools2.EditValueChanged
        txtSchoolID.Text = cmbSchools2.EditValue.ToString
    End Sub

    Private Sub cmdGetSchoolBooks_Click(sender As Object, e As EventArgs) Handles cmdGetSchoolBooks.Click
        Dim sSQL As String

        If cmbSchools2.EditValue.ToString.Length > 0 Then
            'Need to have it so we have an add createtime dateso we can filter by when a book was added
            sSQL = "Select * from BooksInASchool2 where SChoolID='" & cmbSchools2.EditValue.ToString & "'"


            'Temp Code...useful when you need to do permlinks for just a few titles
            ' sSQL = sSQL & " and (ISBN='9781612367255' or ISBN='9781612367286' or ISBN='9781612367309')"
            'sSQL = sSQL & " and PublisherID='1b3b9ae0-e5bc-4805-bcce-2c708295ce6a'"
            '  sSQL = sSQL & " and PublisherID='164af604-0ea5-4d0a-a760-8006d11e45ba' and ebookpath is null"
            'sSQL = sSQL.Replace("Order By GuidedReadingLevel", "")


        Else
            MsgBox("You need To Select a school")
            Exit Sub

        End If


        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With gridSchoolBooks
            .DataSource = ds.Tables(0)




        End With
    End Sub

    Private Sub cmdGetSchoolUsers_Click(sender As Object, e As EventArgs) Handles cmdGetSchoolUsers.Click
        LoadSchoolUsers()
    End Sub
    Private Sub LoadSchoolUsers()
        Dim sSQL As String

        If cmbSchools2.EditValue.ToString.Length > 0 Then
            sSQL = "SELECT Accounts.* ,Roles.Name AS RoleName FROM dbo.Accounts INNER JOIN dbo.Roles ON Accounts.RoleID = Roles.ID where SChoolID='" & cmbSchools2.EditValue.ToString & "'"

        Else
            MsgBox("You need to select a school")
            Exit Sub

        End If


        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With gridSchoolUsers
            .DataSource = ds.Tables(0)




        End With
    End Sub

    Private Sub cmdAddSchoolUser_Click(sender As Object, e As EventArgs) Handles cmdAddSchoolUser.Click
        Dim oForm As New frmUserAddUpdate

        With oForm
            .txtDistrictID.Text = txtDistrictID.Text
            .txtSchoolID.Text = txtSchoolID.Text

            .ShowDialog()
        End With
    End Sub

    Private Sub cmdDeleteSelectedUsers_Click(sender As Object, e As EventArgs) Handles cmdDeleteSelectedUsers.Click
        Dim iSelectedCount As Integer
        Dim oRow As DataRow


        Dim iRtrn As Integer
        Dim iRowCnt As Integer
        Dim sMessage As String
        Dim sAccountID As String
        Dim sSchoolID As String

        Dim sLogin As String
        Dim sName As String
        Dim selectedRowHandles As Int32()
        Dim selectedRowHandle As Int32

        Dim oUsersView As GridView

        oUsersView = GridView1

        'GridView1= Users
        selectedRowHandles = oUsersView.GetSelectedRows
        iSelectedCount = selectedRowHandles.Count



        If iSelectedCount = 0 Then
            MsgBox("You must select at least 1 row to Delete Accounts from:" & cmbSchools2.Text)
            Exit Sub
        End If

        sSchoolID = cmbSchools2.EditValue.ToString
        If sSchoolID.Length = 0 Then
            'We are going to delete rows at a time for this school
            MsgBox("You must select a school before you can delete Delete Accounts.")
            Exit Sub


        End If

        If iSelectedCount > 0 Then
            iRtrn = MsgBox("You are about to DELETE '" & iSelectedCount & "' Users from the school: '" & cmbSchools2.Text & "'. Are you sure you want to continue?", MsgBoxStyle.YesNo, "DELETE USERS?")

            If iRtrn = MsgBoxResult.No Then Exit Sub

        End If






        Dim iErrorCnt As Integer
        Dim iSuccessCnt As Integer

        Dim sReturn As String

        For Each selectedRowHandle In selectedRowHandles
            'selectedRowHandle = selectedRowHandles(0)

            'GridView1= Users
            oRow = oUsersView.GetDataRow(selectedRowHandle)

            sAccountID = oRow.Item("ID").ToString()
            sLogin = oRow.Item("ID").ToString()
            sName = oRow.Item("First").ToString() & " " & oRow.Item("Last").ToString()

            sReturn = DeleteUserFromSchool(sSchoolID, sAccountID)
            sMessage = sMessage & sLogin & "," & sName & ",User Deleted" & vbCrLf
            iSuccessCnt = iSuccessCnt + 1
        Next





        Dim oForm As New frmMessage

        With oForm
            .txtLog.Text = sMessage
            .Show()
        End With
    End Sub

    Private Sub cmdDeleteSelectedBooks_Click(sender As Object, e As EventArgs) Handles cmdDeleteSelectedBooks.Click
        Dim iSelectedCount As Integer
        Dim oRow As DataRow

        Dim BookSchoolsID As String
        'Dim sISBN As String
        ' Dim iISBNColIndex As Integer
        'Dim sISBNColText As String
        Dim iRtrn As Integer
        Dim iRowCnt As Integer
        Dim sMessage As String
        Dim sBookSchoolsID As String
        Dim sSchoolID As String
        Dim sDeleteSQL As String
        Dim sDeleteSQLTemp As String
        Dim sTitle As String
        Dim sISBN As String
        Dim selectedRowHandles As Int32()
        Dim selectedRowHandle As Int32

        Dim oBooksView As GridView

        oBooksView = GridView3

        'GridView3= books
        selectedRowHandles = oBooksView.GetSelectedRows
        iSelectedCount = selectedRowHandles.Count



        If iSelectedCount = 0 Then
            MsgBox("You must select at least 1 row to Delete books:" & cmbSchools2.Text)
            Exit Sub
        End If

        sSchoolID = cmbSchools2.EditValue.ToString
        If sSchoolID.Length = 0 Then
            'We are going to delete rows at a time for this school
            MsgBox("You must select a school before you can delete Delete books.")
            Exit Sub


        End If

        If iSelectedCount > 0 Then
            iRtrn = MsgBox("You are about to DELETE '" & iSelectedCount & "' ISBNs from the school: '" & cmbSchools2.Text & "'. Are you sure you want to continue?", MsgBoxStyle.YesNo, "DELETE BOOKS?")

            If iRtrn = MsgBoxResult.No Then Exit Sub

        End If






        Dim iErrorCnt As Integer
        Dim iSuccessCnt As Integer

        Dim sReturn As String

        For Each selectedRowHandle In selectedRowHandles
            'selectedRowHandle = selectedRowHandles(0)

            'GridView3= books
            oRow = oBooksView.GetDataRow(selectedRowHandle)

            sBookSchoolsID = oRow.Item("BookSchoolsID").ToString()
            sTitle = oRow.Item("Title").ToString()
            sISBN = oRow.Item("ISBN").ToString()



            sReturn = DeleteBookFromSchool(sSchoolID, sBookSchoolsID)
            sMessage = sMessage & sISBN & "," & sTitle & ",Book Deleted" & vbCrLf
            iSuccessCnt = iSuccessCnt + 1


        Next



        '  sReturn = Insert_Collection(sSchoolID, sLineID, sItemNumber, iISSixPack)
        sMessage = sMessage & iSuccessCnt & ": Books Deleted" & vbCrLf
        sMessage = sMessage & iErrorCnt & ": Book Deletes Failed" & vbCrLf


        Dim oForm As New frmMessage

        With oForm
            .txtLog.Text = sMessage
            .Show()
        End With

    End Sub

    Private Sub cmd_FileSelect2_Click(sender As Object, e As EventArgs) Handles cmd_FileSelect2.Click
        With XtraOpenFileDialog1
            .ShowDialog()
            txtFile_SchoolByISBN.Text = .FileName

        End With

        Dim filePath As String = txtFile_SchoolByISBN.Text
        Dim directory As String = Path.GetDirectoryName(filePath)
        Dim sFileName As String = Path.GetFileName(filePath)
        Dim dt As New DataTable

        txtFile_SchoolByISBN.Text = filePath
        'LoadExcelFileISBN2(txtFilename.Text)
        dt = GetCsvData(directory, sFileName)
        With dgv_ImportBooksInSchool
            .DataSource = dt




        End With

        'Loaded the Table Columns into cmbISBNCol
        Dim oCol As DataColumn
        cmbISBNCol.Items.Clear()

        For Each oCol In dt.Columns

            With oCol
                cmbISBNCol.Items.Add(oCol.ColumnName)
            End With

        Next
    End Sub

    Private Sub cmdAddBooksToSchool_Click(sender As Object, e As EventArgs) Handles cmdAddBooksToSchool.Click
        Dim sSchoolID As String
        Dim sSchoolName As String
        Dim iISBNColIndex As Integer
        Dim sISBNColText As String
        Dim iRtrn As Integer
        Dim iRowCnt As Integer
        Dim sMessage As String
        Dim bAddToSchool As Boolean
        Dim iSelected As Integer
        Dim bIgnoreISBNCheck As Boolean

        Dim sQuantityType As String

        Dim iSchoolIDCount As Integer

        iSchoolIDCount = txtSchoolIDs.Lines.Count()


        If iSchoolIDCount <= 1 Then

            If Not cmbSchools2.EditValue Is Nothing Then
                sSchoolID = cmbSchools2.EditValue.ToString
                sSchoolName = cmbSchools2.Text.ToString

            Else
                MsgBox("You need To Select a school")
                Exit Sub

            End If
        End If


        If cmbISBNCol.Text.ToString.Length > 0 Then
            iISBNColIndex = cmbISBNCol.SelectedIndex
            sISBNColText = cmbISBNCol.Text
        Else
            If iSchoolIDCount <= 1 Then
                MsgBox("You need To Select a ISBN Column.")
                Exit Sub
            End If

        End If

        If chk_ISSixPack.Checked = True Then
            sQuantityType = "6-Pack"

        End If

        If chkEBooks.Checked = True Then
            sQuantityType = "e-Book"

        End If

        iRowCnt = dgv_ImportBooksInSchool.RowCount

        If chk_AddBookToSchool.CheckState = CheckState.Checked Then
            bAddToSchool = True
        Else
            bAddToSchool = False

        End If


        If iRowCnt > 0 Then
            iRtrn = MsgBox("You are about To import '" & iRowCnt & "' ISBNs in the school: '" & cmbSchools2.Text & "'. Are you sure you want to continue?", MsgBoxStyle.YesNo)
        Else
            MsgBox("You need to load a ISBN CSV file to import.")
            Exit Sub
        End If


        If iSchoolIDCount > 1 Then
            iRtrn = MsgBox("You are about to import '" & iRowCnt & "' ISBNs into this number of schools: '" & iSchoolIDCount & "'. Are you sure you want to continue?", MsgBoxStyle.YesNo)

        End If

        If iRtrn = MsgBoxResult.No Then Exit Sub

        If iSchoolIDCount <= 1 Then
            If bAddToSchool = True Then
                sMessage = sMessage & "ISBNs Import to " & cmbSchools2.Text & " " & Now() & vbCrLf & vbCrLf
            Else
                sMessage = sMessage & "ISBNs Import Simulation for " & cmbSchools2.Text & ". NO RECORDS will be imported!: " & Now() & vbCrLf & vbCrLf
            End If
        End If

        Dim oRow As DataRow
        Dim sISBN As String
        Dim sLocation As String
        Dim sReturn As String
        Dim iErrorCnt As Integer
        Dim iSuccessCnt As Integer
        Dim sBookID As String
        Dim bISSixPack As Boolean
        Dim bBookAlreadyInSchool As Boolean
        Dim bCheckHasEBookPath As Boolean
        sLocation = "Bookroom"

        If chk_ISSixPack.CheckState = CheckState.Checked Then
            bISSixPack = True
            sQuantityType = "6-Pack"
        Else
            bISSixPack = False

        End If


        'If chkCheckIfEbookPathOnly.CheckState = CheckState.Checked Then
        '    bCheckHasEBookPath = True
        'Else
        '    bCheckHasEBookPath = False

        'End If

        If chkEBooks.Checked = True Then
            sQuantityType = "e-Book"
        End If

        Dim newGuid As Guid

        If iSchoolIDCount <= 1 Then
            txtSchoolIDs.Text = "Replace me with School IDs"
        End If

        If chkIgnoreISBNCheck.Checked = True Then
            bIgnoreISBNCheck = True
        Else
            bIgnoreISBNCheck = False
        End If


        For Each oLine In txtSchoolIDs.Lines()
            If iSchoolIDCount > 1 Then

                sSchoolID = oLine.ToString

                If Guid.TryParse(sSchoolID, newGuid) = False Then
                    sMessage = sMessage & "ISBNs Import to " & sSchoolID.ToString & " - Failed...not GUID " & Now() & vbCrLf & vbCrLf
                    GoTo NotSchoolID
                End If

                If bAddToSchool = True Then
                    sMessage = sMessage & "ISBNs Import to " & sSchoolID.ToString & " " & Now() & vbCrLf & vbCrLf
                Else
                    sMessage = sMessage & "ISBNs Import Simulation for " & sSchoolID.ToString & ". NO RECORDS will be imported!: " & Now() & vbCrLf & vbCrLf
                End If



            End If



            For Each oRow In dgv_ImportBooksInSchool.DataSource.rows
                bBookAlreadyInSchool = False

                If chkIgnoreISBNCheck.Checked = False Then
                    sISBN = RemoveHyphens(oRow.Item(iISBNColIndex).ToString)
                Else
                    sISBN = oRow.Item(iISBNColIndex).ToString
                End If


                If sISBN.Length = 10 Or sISBN.Length = 13 Or chkIgnoreISBNCheck.Checked = True Then

                    sBookID = GetBookIDByISBN(sISBN)



                    If sBookID = "" Then
                        sMessage = sMessage & sISBN & "," & "ISBN Not found in DiBS" & vbCrLf
                        iErrorCnt = iErrorCnt + 1
                    Else

                        If bCheckHasEBookPath = True Then
                            'Need to see if the isbn has a ebook path
                            If GetEBookPathByISBN(sISBN) = "" Then
                                sMessage = sMessage & sISBN & "," & "No e-Book Path" & vbCrLf
                            End If
                        End If

                        ' MsgBox("Found a match")
                        sMessage = sMessage & sISBN & "," & "ISBN Found in DiBS" & vbCrLf

                        'So we can run simulations
                        If bAddToSchool = True Then

                            If sQuantityType = "e-Book" Then

                                'Check to see if book is already in school...is so then do NOT add
                                bBookAlreadyInSchool = IsBookAlreadyInSchool(sBookID, sSchoolID)

                                If bBookAlreadyInSchool = False Then
                                    sReturn = Insert_SchoolBooks(sSchoolID, sBookID, bISSixPack, sLocation, sQuantityType)
                                Else
                                    sReturn = "InSchoolAlready"
                                End If

                            Else
                                'If not e-book.....then ok to add again...for now....may change that later
                                sReturn = Insert_SchoolBooks(sSchoolID, sBookID, bISSixPack, sLocation, sQuantityType)
                            End If

                        End If

                        If sReturn = "1" Then
                            sMessage = sMessage & sISBN & "," & "ISBN Added to School" & vbCrLf
                            iSuccessCnt = iSuccessCnt + 1
                        Else
                            If bAddToSchool = True Then

                                If sReturn = "InSchoolAlready" Then
                                    sMessage = sMessage & sISBN & "," & "ISBN already in School....NOT Inserted." & vbCrLf
                                    iErrorCnt = iErrorCnt + 1

                                Else
                                    sMessage = sMessage & sISBN & "," & "ISBN failed to Insert into DiBS." & vbCrLf
                                    iErrorCnt = iErrorCnt + 1

                                End If


                            Else
                                sMessage = sMessage & sISBN & "," & "ISBN would have been Inserted into DiBS." & vbCrLf
                                iSuccessCnt = iSuccessCnt + 1
                            End If

                        End If
                        'sReturn = AddBookByISBN(sISBN, sSchoolID, bISSixPack,
                    End If
                Else
                    sMessage = sMessage & sISBN & "," & "Not a Valid ISBN" & vbCrLf
                    iErrorCnt = iErrorCnt + 1

                End If



            Next
            '  sReturn = Insert_Collection(sSchoolID, sLineID, sItemNumber, iISSixPack)
            sMessage = sMessage & iSuccessCnt & ": Books Added" & vbCrLf
            sMessage = sMessage & iErrorCnt & ": Books Add Failed" & vbCrLf
NotSchoolID:
        Next

        Dim oForm As New frmMessage

        With oForm
            .txtLog.Text = sMessage
            .Show()
        End With


    End Sub

    Private Sub cmdDuplicateSchool_Click(sender As Object, e As EventArgs) Handles cmdDuplicateSchool.Click
        Dim sCurrentSchool As String
        Dim sDuplicateSchool As String
        Dim sCurrentSchoolID As String

        sCurrentSchool = cmbSchools2.Text
        sCurrentSchoolID = cmbSchools2.EditValue.ToString




        sDuplicateSchool = InputBox("What do want to call this school?", "Enter a SChool Name", sCurrentSchool & " (Duplicate)")

        If sDuplicateSchool = sCurrentSchool Then
            MessageBox.Show("You must enter a different school name to continue.")
            Exit Sub
        ElseIf sDuplicateSchool = "" Then
            Exit Sub
        End If

        Insert_NewSchool(sDuplicateSchool, sCurrentSchoolID)
    End Sub

    Private Sub cmdViewerForSchool_Click(sender As Object, e As EventArgs) Handles cmdViewerForSchool.Click
        Dim sViewerURLTEMP As String
        Dim sSQL As String
        Dim sSchoolID As String
        Dim sSchoolDistrictID
        sSchoolID = txtSchoolID.Text
        sSchoolDistrictID = txtDistrictID.Text


        sViewerURLTEMP = GetViewerTempURL()

        If cmbSchools2.EditValue.ToString.Length > 0 Then

            If chkCreateViewerForAllDisitrictSchools.CheckState = CheckState.Unchecked Then
                'Current School Only
                sSQL = "Select ID,Name,CONCAT('" & sViewerURLTEMP & "',ID) FROM Schools WHERE ID='" & sSchoolID & "'"

            Else
                'Schools in the District
                sSQL = "Select ID,Name,CONCAT('" & sViewerURLTEMP & "',ID) FROM Schools WHERE SchoolDistrictID='" & sSchoolDistrictID & "'"

            End If

        Else
            MsgBox("You need To Select a school")
            Exit Sub

        End If



        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()


        Dim oFormGrid As New frmGrid2

        With oFormGrid
            .gridEmpty.DataSource = ds.Tables(0)

            .Show()
        End With

    End Sub
    Private Function GetViewerTempURL() As String

        ' cmbViewerBrand

        Dim sViewerBrand As String
        Dim sViewerURLTEMP As String

        sViewerBrand = cmbViewerBrand.Text



        Select Case sViewerBrand
            Case "Brain Hive"
                sViewerURLTEMP = "https://brainhive-viewer.digitalbookroom.com/#/login/?SchoolID="

            Case "Pacific"
                sViewerURLTEMP = "https://pacificlearning.digitalbookroom.com/#/login/?SchoolID="

            Case "Rourke"
                sViewerURLTEMP = "https://rourke.digitalbookroom.com/#/login/?SchoolID="

            Case "Crabtree"
                sViewerURLTEMP = "https://crabtree.digitalbookroom.com/#/login/?SchoolID="

            Case "DiBS"
                sViewerURLTEMP = "https://viewer.digitalbookroom.com/#/login/?SchoolID="

        End Select

        Return sViewerURLTEMP

    End Function
    Private Sub BarButtonItem1_ViewBook_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_ViewBook.ItemClick
        ShowEBook()
    End Sub

    Private Sub ShowEBook(Optional bAllEBooksTab As Boolean = False)
        Dim sContainerPath As String
        Dim sISBN As String
        Dim sFileName As String
        Dim sOutPath As String
        Dim sZipFileName As String
        Dim seBookPath As String

        Dim oCurrenteBookGridView As GridView
        'sISBN = "9781427199461"
        ' sFileName = sISBN & ".zip"
        ' sOutPath = "Z:\test\temp"
        ' sContainerPath = "books/BrainHive_Partners/Crabtree/Batch4/" & sISBN & "/"

        If bAllEBooksTab = False Then
            'School Books
            oCurrenteBookGridView = GridView3
        Else
            'All eBooks
            oCurrenteBookGridView = GridView2
        End If

        Dim oEditOrderID As Guid
        Dim selectedRowHandles As Int32() = oCurrenteBookGridView.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow


        Me.Cursor = Cursors.WaitCursor
        Try


            If selectedRowHandles.Count <> 1 Then
                MsgBox("Must select 1 Row")
                Exit Sub
            End If
            selectedRowHandle = selectedRowHandles(0)

            oRow = oCurrenteBookGridView.GetDataRow(selectedRowHandle)


            sISBN = oRow.Item("ISBN").ToString()
            sContainerPath = oRow.Item("EBookPath").ToString()
            'Need to remove 1st /
            sContainerPath = sContainerPath.Remove(0, 1)
            sContainerPath = sContainerPath & sISBN
            sFileName = sISBN & ".zip"
            ' sOutPath = "Z:\test\temp"

            sOutPath = Path.GetTempPath()

            DownloadFileFromBlob(sContainerPath, sFileName, sOutPath)
            sZipFileName = sOutPath & "\" & sFileName
            seBookPath = sOutPath & sISBN
            'Need to Zip the file
            'If File.Exists(sZipFileName) Then
            '    File.Delete(sZipFileName)
            'End If
            If Directory.Exists(seBookPath) Then
                Directory.Delete(seBookPath, True)
            End If
            ZipFile.ExtractToDirectory(sZipFileName, seBookPath)

            Dim ofrmBrowser As New frmBrowser
            Me.Cursor = Cursors.Default
            With ofrmBrowser
                .HTMLFolder = seBookPath

                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowBookCover(oPoint As Point, Optional bAllEBooksTab As Boolean = False)
        Dim oEditOrderID As Guid
        Dim selectedRowHandle As Int32
        Dim selectedRowHandles As Int32()

        Dim oRow As DataRow
        Dim sOfficalImage As String
        Dim info As ToolTipControlInfo = Nothing
        Dim sTooltip1 As New SuperToolTip()

        Dim oCurrenteBookGridView As GridView


        If bAllEBooksTab = False Then
            'School Books
            oCurrenteBookGridView = GridView3
        Else
            'All eBooks
            oCurrenteBookGridView = GridView2
        End If

        selectedRowHandles = oCurrenteBookGridView.GetSelectedRows()
        selectedRowHandle = selectedRowHandles(0)
        'oRow = GridView1.GetDataRow(selectedRowHandle)

        oRow = oCurrenteBookGridView.GetDataRow(selectedRowHandle)
        sOfficalImage = oRow.Item("OfficialImage").ToString()


        Dim args As New DevExpress.Utils.ToolTipControllerShowEventArgs

        Dim tip As New DevExpress.Utils.SuperToolTip
        Dim im As Image
        im = GetImageBase64NoPicBox(sOfficalImage)
        '  tip.MaxWidth = 100

        args.SuperTip = tip
        args.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip

        args.ImageOptions.Image = ScaleThumbnailImage(im, 300, 300)
        args.ImageOptions.Alignment = ToolTipImageAlignment.Right


        oPoint.X = oPoint.X + 300
        ToolTipController1.ShowHint(args, oPoint)

    End Sub
    Private Sub ReplaceBookCover(Optional bAllEBooksTab As Boolean = False)
        Dim oEditOrderID As Guid
        Dim selectedRowHandle As Int32
        Dim selectedRowHandles As Int32()

        Dim oRow As DataRow
        Dim sOfficalImage As String
        Dim info As ToolTipControlInfo = Nothing
        Dim sTooltip1 As New SuperToolTip()
        Dim sISBN As String
        Dim sBookID As String
        Dim sTitle As String


        ' sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        Dim oCurrenteBookGridView As GridView


        If bAllEBooksTab = False Then
            'School Books
            oCurrenteBookGridView = GridView3
        Else
            'All eBooks
            oCurrenteBookGridView = GridView2
        End If
        selectedRowHandles = oCurrenteBookGridView.GetSelectedRows()
        If selectedRowHandles.Count > 1 Then

            MsgBox("You must select 1 row")
            Exit Sub

        End If

        selectedRowHandle = selectedRowHandles(0)
        'oRow = GridView1.GetDataRow(selectedRowHandle)

        oRow = oCurrenteBookGridView.GetDataRow(selectedRowHandle)
        sOfficalImage = oRow.Item("OfficialImage").ToString()

        sBookID = oRow.Item("ID").ToString()
        sTitle = oRow.Item("Title").ToString()
        sISBN = oRow.Item("ISBN").ToString()

        Dim oForm As New frmAddCoverToBook

        With oForm
            .txtBookID.Text = sBookID
            .txtTitle.Text = sTitle
            .txtISBN.Text = sISBN
            .txtOfficalImageURL.Text = sOfficalImage
            If sOfficalImage.Length > 0 Then
                .PictureBox2.ImageLocation = sOfficalImage
            End If

            .Show()
        End With
    End Sub
    Private Sub BarButtonItem1_ViewCover_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_ViewCover.ItemClick
        ShowBookCover(Me.Location)
    End Sub

    Private Sub GridView3_MouseUp(sender As Object, e As MouseEventArgs) Handles GridView3.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub LoadLines()
        Dim sSQL As String = "SELECT * FROM CompanyLines"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "CompanyLines")
        oConnection.Close()

        With cmbPublisherLine
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)


        End With

        ' Dim myCommand As New SqlCommand(sSQL, oConnection)

    End Sub
    Private Sub LoadDiBSBooks()
        Dim sSQL As String

        sSQL = "SELECT Publishers.Name,Books.* from dbo.Books INNER JOIN dbo.Publishers ON Books.PublisherID = Publishers.ID"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "Books")
        oConnection.Close()

        gridDiBSBooks.DataSource = ds.Tables(0)
    End Sub
    Private Sub LoadCollections()
        lstvw_Collections.Items.Clear()
        '.cmbCompanyCollections.Items.Clear()

        Dim sLineID As String
        sLineID = cmbPublisherLine.SelectedValue.ToString

        Dim sSQL As String = "SELECT *, ItemNumber + ' - ' + ItemDescription AS ItemText from Collections  where LineID ='" & sLineID & "'"

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim oRow As DataRow
        Dim oListViewItem As ListViewItem

        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)

        With cmbCompanyCollections
            .DisplayMember = "ItemText"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)
        End With


        oConnection.Close()

        ' ListView1.Columns.Clear()
        'ListView1.Items.Clear()
        'For Each col As DataColumn In ds.Tables(0).Columns
        '    ListView1.Columns.Add(col.ToString)
        'Next


        For Each oRow In ds.Tables(0).Rows
            oListViewItem = New ListViewItem
            oListViewItem = lstvw_Collections.Items.Add(oRow("ItemNumber").ToString)
            oListViewItem.SubItems.Add(oRow("ItemDescription").ToString)
            oListViewItem.SubItems.Add(oRow("IsSixPack").ToString)
            oListViewItem.SubItems.Add(oRow("ID").ToString)


        Next

    End Sub

    Private Sub cmd_AddCollections_Click(sender As Object, e As EventArgs) Handles cmd_AddCollections.Click
        Dim oListViewItem As ListViewItem
        Dim sMessage As String = ""
        Dim sReturn As String
        Dim sSchoolID As String
        Dim sLineID As String
        Dim sItemNumber As String
        Dim iISSixPack As Integer
        Dim iRtrn As Integer
        Dim iChecked As Integer
        Dim sCollectionID As String

        If Not cmbSchools2.EditValue Is Nothing Then

            sSchoolID = cmbSchools2.EditValue.ToString
        Else
            sSchoolID = ""
        End If


        sLineID = cmbPublisherLine.SelectedValue.ToString
        iChecked = lstvw_Collections.CheckedItems.Count


        If sSchoolID.Length = 0 Then
            MsgBox("You need to select a School to Import the collections to.")
            Exit Sub
        End If

        If sLineID.Length = 0 Then
            MsgBox("You need to select a Publisher Line to Import the collections from.")
            Exit Sub
        End If

        If iChecked = 0 Then
            MsgBox("You need to select at least 1 collection to import.")
            Exit Sub
        End If

        iRtrn = MsgBox("You are about to import '" & iChecked & "' collections in the school: '" & cmbSchools2.Text & "'. Are you sure you want to continue?", MsgBoxStyle.YesNo)

        If iRtrn = MsgBoxResult.No Then Exit Sub


        sMessage = sMessage & "Collection Import to " & cmbSchools2.Text & " " & Now() & vbCrLf & vbCrLf



        For Each oListViewItem In lstvw_Collections.CheckedItems
            sItemNumber = oListViewItem.Text
            If oListViewItem.SubItems(2).Text = "True" Then
                iISSixPack = 1
            Else
                iISSixPack = 0
            End If

            Dim iCollectionInSchoolCnt As Integer
            'Need to check to see if collection titles are in there
            sCollectionID = oListViewItem.SubItems(3).Text
            iCollectionInSchoolCnt = GetCollectionBooksInSchoolCnt(sSchoolID, sCollectionID)

            If iCollectionInSchoolCnt > 0 Then
                iRtrn = MsgBox("The School already has '" & iCollectionInSchoolCnt & "' items from the collection: '" & oListViewItem.SubItems(1).Text & "'. Are you sure you want to import, It may cause duplicates?", MsgBoxStyle.YesNo)

                If iRtrn = MsgBoxResult.No Then
                    sMessage = sMessage & "Skipped: " & oListViewItem.Text & " - " & oListViewItem.SubItems(1).Text & vbCrLf
                    GoTo SKIPCollection
                Else
                    sMessage = sMessage & "Possible Duplicates: " & oListViewItem.Text & " - " & oListViewItem.SubItems(1).Text & vbCrLf

                End If
            End If

            sMessage = sMessage & "Import: " & oListViewItem.Text & " - " & oListViewItem.SubItems(1).Text & vbCrLf

            sReturn = Insert_Collection(sSchoolID, sLineID, sItemNumber, iISSixPack, txtQuantityTypeCollection.Text)
            sMessage = sMessage & sReturn & ": Books Added" & vbCrLf

SKIPCollection:
        Next

        MsgBox(sMessage)

    End Sub

    Private Sub cmdAddColletion_Click(sender As Object, e As EventArgs) Handles cmdAddColletion.Click
        Dim sMessage As String = ""
        Dim sReturn As String
        Dim sSchoolID As String
        Dim sLineID As String

        Dim iISSixPack As Integer
        Dim iRtrn As Integer
        Dim iChecked As Boolean
        Dim sItemNumber As String
        Dim sItemDesc As String
        Dim sCollectionID As String



        sItemNumber = txtItemNumber.Text
        sItemDesc = txtItemDescription.Text

        If sItemNumber.Length = 0 Or sItemNumber.Length < 3 Then
            MsgBox("You need to enter a item number that is at least 3 characters long to create a collection.")
            Exit Sub
        End If

        If sItemDesc.Length = 0 Or sItemDesc.Length < 7 Then
            MsgBox("You need to enter a item Description that is at least 10 characters long to create a collection.")
            Exit Sub
        End If

        Select Case cmbIsSixPackCollection.SelectedIndex

            Case 0, -1
                'Not Selected

                MsgBox("You need to select whether or not this collection is a 6-Pack or Single copy!")
                Exit Sub


            Case 1
                'Case Yes
                iISSixPack = 1
            Case 2
                'Case no
                iISSixPack = 0

        End Select

        sLineID = cmbPublisherLine.SelectedValue.ToString

        If sLineID.Length = 0 Then
            MsgBox("You need to select a Publisher Line to Add a collection to.")
            Exit Sub
        End If

        'Need to check to make sure item number for this line does not already exist
        sCollectionID = GetCollectionID(sLineID, sItemNumber)

        If sCollectionID.Length > 0 Then
            MsgBox("The item number:'" & sItemNumber & "' already exists for the Company:'" & cmbPublisherLine.Text & "'")
            Exit Sub
        End If

        iRtrn = MsgBox("You are about to create a collection for the Company '" & cmbPublisherLine.Text & "' with the Item Number:'" & sItemNumber & "'" & " and Item Description:'" & sItemDesc & "'. Are you sure you want to continue?", MsgBoxStyle.YesNo)

        If iRtrn = MsgBoxResult.No Then Exit Sub

        sReturn = Insert_CompanyCollection(sLineID, sItemNumber, sItemDesc, iISSixPack)

        Select Case sReturn
            Case "1"
                sMessage = sMessage & "Collection created to " & cmbPublisherLine.Text & " " & Now() & vbCrLf & vbCrLf
            Case Else
                sMessage = sMessage & "Collection NOT ADDED! " & Now() & vbCrLf & vbCrLf

        End Select

        MsgBox(sMessage)
        LoadCollections()
        ' cmbCompanyCollections.SelectedIndex = 0


    End Sub

    Private Sub cmbPublisherLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPublisherLine.SelectedIndexChanged
        LoadCollections()

    End Sub

    Private Sub cmdLoadCollectionBooks_Click(sender As Object, e As EventArgs) Handles cmdLoadCollectionBooks.Click
        With XtraOpenFileDialog1
            .ShowDialog()
            txtCollectionsBooksFile.Text = .FileName

        End With

        Dim filePath As String = txtCollectionsBooksFile.Text
        Dim directory As String = Path.GetDirectoryName(filePath)
        Dim sFileName As String = Path.GetFileName(filePath)
        Dim dt As New DataTable

        txtCollectionsBooksFile.Text = filePath
        'LoadExcelFileISBN2(txtFilename.Text)
        dt = GetCsvData(directory, sFileName)
        With dgv_CollectionBooksImport
            .DataSource = dt




        End With

        'Loaded the Table Columns into cmbISBNCol
        Dim oCol As DataColumn
        cmbISBNCol2.Items.Clear()

        For Each oCol In dt.Columns

            With oCol
                cmbISBNCol2.Items.Add(oCol.ColumnName)
            End With

        Next

    End Sub

    Private Sub XtraTabPage1_eBooks_VisibleChanged(sender As Object, e As EventArgs) Handles XtraTabPage1_eBooks.VisibleChanged
        If DiBSBooksTabClickedOnce = False Then

            LoadDiBSBooks()
            DiBSBooksTabClickedOnce = True

        End If
    End Sub

    Public Sub InitAddByISBNFreeForm()
        Dim oWorkSheet As Spreadsheet.Worksheet


        oWorkSheet = spreadAddFreeForm.ActiveWorksheet


        With oWorkSheet.Range("A1")
            .Value = "ISBN - eBook (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        oWorkSheet.Columns("A").NumberFormat = "#####"
        'oWorkSheet.Range.FromLTRB(1, 0, 1, 0)

        With oWorkSheet.Range("B1")
            .Value = "Title (Required)"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("C1")
            .Value = "Add Status #"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        With oWorkSheet.Range("D1")
            .Value = "Add Status MSG"
            .Font.Bold = True
            .Font.Size = 16
            .ColumnWidth = 1000

        End With

        Dim range As CellRange = oWorkSheet("A1:F10000")
        oWorkSheet.AutoFilter.Apply(range)



    End Sub

    Private Sub cmdAddOrderItemsFreeForm_Click(sender As Object, e As EventArgs) Handles cmdAddOrderItemsFreeForm.Click
        Dim oWorkSheet As Spreadsheet.Worksheet
        Dim iMaxRows As Integer = 10000
        Dim oEBooksToAdd As New List(Of AddEbookToSchool)
        Dim iBlankCount As Integer
        Dim oEBookToAdd As AddEbookToSchool
        Dim bBookAlreadyInSchool As Boolean
        Dim sReturn As String

        Dim iRow As Integer

        Dim iMsgRtrn As DialogResult
        Dim sMsg As String

        Dim sItemNumberISBN As String
        Dim sItemDesc As String
        Dim sQTY As String
        Dim sListPrice As String
        Dim iEBookItemCount As Integer
        Dim sSchoolName As String
        Dim sSchoolID As String
        Dim sBookID As String


        Dim iPreviousRunStatus As OrderItemStatus
        Dim sPreviousRunStatusText As String
        Dim bRecordAlreadyAddPrevious As Boolean

        oWorkSheet = spreadAddFreeForm.ActiveWorksheet

        If Not cmbSchools2.EditValue Is Nothing Then
            sSchoolID = cmbSchools2.EditValue.ToString
            sSchoolName = cmbSchools2.Text.ToString

        Else
            MsgBox("You need To Select a school")
            Exit Sub

        End If


        sMsg = "You are about to add 'eBooks' to the School: '" & sSchoolName & "' Are you sure you want to continue?"
        iMsgRtrn = MessageBox.Show(sMsg, "Add eBooks to School?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If iMsgRtrn = DialogResult.No Then
            Exit Sub

        End If

        For iRow = 2 To iMaxRows
            oEBookToAdd = New AddEbookToSchool

            sPreviousRunStatusText = oWorkSheet.Range("C" & iRow).Value.ToString()
            bRecordAlreadyAddPrevious = False

            If sPreviousRunStatusText = "" Then
                'It is ok...we can 
            Else


            End If
            With oEBookToAdd

                sItemNumberISBN = RemoveHyphens(oWorkSheet.Range("A" & iRow).Value.ToString())
                'Free...we need to set he Partner ID
                .ISBN = sItemNumberISBN


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

                sItemDesc = oWorkSheet.Range("B" & iRow).Value.ToString
                .Title = sItemDesc

                If sItemNumberISBN.Length = 10 Or sItemNumberISBN.Length = 13 Or chkIgnoreISBNCheckFree.Checked = True Then

                    sBookID = GetBookIDByISBN(sItemNumberISBN)
                    .BookID = sBookID

                    If sBookID = "" Then
                        .AddEbookStatus = AddBookToSchoolStatus.NotFoundInDB
                        .AddEbookStatusText = "ISBN Not found in DiBS"
                    Else

                        'Need to see if the isbn has a ebook path
                        If GetEBookPathByISBN(sItemNumberISBN) = "" Then
                            .MissingEBookPath = True
                            .AddEbookStatus = AddBookToSchoolStatus.MissingEBookPath
                            .AddEbookStatusText = "Missing EBook Path"
                        Else
                            .AddEbookStatus = AddBookToSchoolStatus.FoundInDB
                            .AddEbookStatusText = "Found in DB"
                        End If


                    End If


                Else
                    .AddEbookStatus = AddBookToSchoolStatus.InValidISBN
                    .AddEbookStatusText = "InValid ISBN"

                End If




            End With



            oEBooksToAdd.Add(oEBookToAdd)
BlankRowHit:
        Next
BlankCountMaxHit:


        'Lets add the items that we can

        For Each moEBookToAdd In oEBooksToAdd
            iEBookItemCount = iEBookItemCount + 1

            sBookID = ""
            If moEBookToAdd.AddEbookStatus = AddBookToSchoolStatus.InValidISBN Or moEBookToAdd.AddEbookStatus = AddBookToSchoolStatus.NotFoundInDB Then GoTo SkipInvalidISBNEmptyRow
            sBookID = moEBookToAdd.BookID
            'Check to see if book is already in school...is so then do NOT add

            bBookAlreadyInSchool = IsBookAlreadyInSchool(sBookID, sSchoolID)
            If bBookAlreadyInSchool = False Then
                sReturn = Insert_SchoolBooks(sSchoolID, sBookID, False, "Bookroom", "e-Book")
                If sReturn = "1" Then

                    Select Case moEBookToAdd.AddEbookStatus
                        Case AddBookToSchoolStatus.MissingEBookPath
                            moEBookToAdd.AddEbookStatus = AddBookToSchoolStatus.AddedToSchoolMissingBookPath
                            moEBookToAdd.AddEbookStatusText = "ISBN Added to School - But missing EBOOK Path"
                        Case Else
                            moEBookToAdd.AddEbookStatus = AddBookToSchoolStatus.AddedToSchoolNoIssues
                            moEBookToAdd.AddEbookStatusText = "ISBN Added to School"
                    End Select

                Else

                End If

            Else
                sReturn = "InSchoolAlready"
                moEBookToAdd.AddEbookStatus = AddBookToSchoolStatus.BookAlreadyInSchool
                moEBookToAdd.AddEbookStatusText = "ISBN already in School....NOT Inserted."

            End If
SkipInvalidISBNEmptyRow:


            oWorkSheet.Range("C" & iEBookItemCount + 1).Value = moEBookToAdd.AddEbookStatus
            oWorkSheet.Range("D" & iEBookItemCount + 1).Value = moEBookToAdd.AddEbookStatusText

            'If moEBookToAdd.OrderItemStatus = OrderItemStatus.NoStaus Then

            '    'ok...try and add to the Database
            '    omOrderItems_IU_ALT(moOrderItem, oOrderID)


            'End If

            'If moOrderItem.OrderItemStatus <> 0 Then
            '    oWorkSheet.Range("E" & iOrderItemCount + 1).Value = moOrderItem.OrderItemStatus
            '    oWorkSheet.Range("F" & iOrderItemCount + 1).Value = moOrderItem.OrderItemStatusText

            '    oWorkSheet.Range("E" & iOrderItemCount + 1).Fill.BackgroundColor = Color.MistyRose
            '    oWorkSheet.Range("F" & iOrderItemCount + 1).Fill.BackgroundColor = Color.MistyRose
            'Else
            '    'Clear the text because it could be a rerun
            '    oWorkSheet.Range("E" & iOrderItemCount + 1).Value = ""
            '    oWorkSheet.Range("F" & iOrderItemCount + 1).Value = ""

            '    oWorkSheet.Range("E" & iOrderItemCount + 1).Fill.BackgroundColor = Color.Empty
            '    oWorkSheet.Range("F" & iOrderItemCount + 1).Fill.BackgroundColor = Color.Empty

            'End If


        Next





    End Sub

    Private Sub BarButtonItem1_ReplaceBookCover_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_ReplaceBookCover.ItemClick
        ReplaceBookCover()


    End Sub

    Private Sub cmdUpLoadCoverImages_Click(sender As Object, e As EventArgs) Handles cmdUpLoadCoverImages.Click
        Dim FileCnt As Integer = 0
        Dim FolderCnt As Integer = 1
        Dim sReturnAWSPath As String
        Dim sISBN As String
        Dim sFilepath As String

        Dim sFilename As String
        Dim x As Integer
        Dim y As Integer
        Dim pathFrom As String = ""
        Dim pathTo As String = ""
        Dim pathToDir As String = ""
        Dim sCoverGuid As String
        Dim sCoverFileName As String
        Dim sCurrentOfficalImage As String
        Dim sBookID As String
        Dim sMessage As String
        Dim bDoNotCopyIfImageAlreadyExists As Boolean


        x = 0
        y = 0


        FileCnt = 0
        FolderCnt = 1

        Dim di As New IO.DirectoryInfo(txtUploadCoverImagesDir.Text)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        Dim sFileText As String

        sMessage = "Copy to Cover Images: " & Now() & vbCrLf

        If chkIfBookImageExists.CheckState = CheckState.Checked Then
            bDoNotCopyIfImageAlreadyExists = True

        End If



        'list the names of all files in the specified directory
        For Each dra In diar1
            sFilename = dra.ToString
            If Path.GetExtension(sFilename) = ".jpg" Then

                sFileText = ""
                sFilepath = ""
                sCoverGuid = ""
                sCoverFileName = ""
                sCurrentOfficalImage = ""




                sISBN = sFilename.Replace(".jpg", "")

                If sISBN.Length > 13 And chkUploadCoversIngonreISBN.Checked = False Then
                    sISBN = sISBN.Remove(14, sISBN.Length)
                End If

                sBookID = GetBookIDByISBNOnly(sISBN)

                If bDoNotCopyIfImageAlreadyExists = True And sBookID.Length > 0 Then
                    sCurrentOfficalImage = GetOfficalImage(sISBN)
                End If

                If sCurrentOfficalImage.Length = 0 And sBookID.Length > 0 Then


                    pathFrom = txtUploadCoverImagesDir.Text & "\" & sFilename
                    sCoverGuid = Guid.NewGuid.ToString
                    sCoverFileName = sCoverGuid & ".jpg"


                    sReturnAWSPath = UploadFile_AWS_S3(pathFrom, sCoverFileName, "")

                    If sReturnAWSPath.Length > 0 Then
                        '  File.Move(pathFrom, pathTo)
                        SetCoverImage(sISBN, sReturnAWSPath)
                    End If

                Else
                    If sCurrentOfficalImage.Length > 0 And sBookID.Length > 0 Then
                        sMessage = sMessage & sISBN & "," & sFilename & ", Image already set in DiBS." & vbCrLf
                    Else
                        sMessage = sMessage & sISBN & "," & sFilename & ", Could not set the cover image." & vbCrLf
                    End If

                End If

            End If

        Next



        Dim oForm As New frmMessage

        With oForm
            .txtLog.Text = sMessage
            .Show()
        End With


    End Sub

    Private Sub GridView2_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView2.RowUpdated
        'This is where you update the Database after updating the 
        Dim rowView As DataRowView = TryCast(e.Row, DataRowView)
        Dim row As DataRow = rowView.Row

        Dim sGuidedReadingLevel As String
        Dim sID As String


        Dim iISFiction As Boolean

        Dim sLEX As String

        'Need to validate
        With row
            sID = .Item("ID").ToString
            sGuidedReadingLevel = .Item("GuidedReadingLevel")
            iISFiction = .Item("ISFiction")
            sLEX = .Item("LEX").ToString
        End With
        'Update DB

        UpdateBookMetaSimple(sID, sGuidedReadingLevel, iISFiction, sLEX)
    End Sub


    Private Function UpdateBookMetaSimple(ID As String, sGuidedReadingLevel As String, iISFiction As Integer, sLEX As String)

        Dim sEXEC As String = "UPDATE dbo.Books SET GuidedReadingLevel = @GuidedReadingLevel,IsFiction = @IsFiction,LEX = @LEX WHERE ID = @ID"

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(ID.ToString)
            .Parameters.Add("@GuidedReadingLevel", SqlDbType.NVarChar).Value = sGuidedReadingLevel
            .Parameters.Add("@IsFiction", SqlDbType.Int).Value = iISFiction

            .Parameters.Add("@LEX", SqlDbType.NVarChar).Value = sLEX




            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn
    End Function

    Private Sub cmdClearOrderItemsFreeForm_Click(sender As Object, e As EventArgs) Handles cmdClearOrderItemsFreeForm.Click
        spreadAddFreeForm.ActiveWorksheet.Cells.Clear
        InitAddByISBNFreeForm()
    End Sub

    Private Sub GridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridView1.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu2.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub BarButtonItem1_AddNewUser_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_AddNewUser.ItemClick
        Dim oForm As New frmUserAddUpdate

        With oForm
            .txtDistrictID.Text = txtDistrictID.Text
            .txtSchoolID.Text = txtSchoolID.Text

            .ShowDialog()

        End With

        LoadSchoolUsers()
    End Sub

    Private Sub BarButtonItem1_EditUser_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_EditUser.ItemClick


        Dim oForm As New frmUserAddUpdate
        Dim oEditOrderID As Guid
        Dim selectedRowHandle As Int32
        Dim selectedRowHandles As Int32()

        Dim oRow As DataRow
        Dim oUser As New UserAccount



        ' sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))

        selectedRowHandles = GridView1.GetSelectedRows()
        If selectedRowHandles.Count <> 1 Then

            MsgBox("You must select only 1 row")
            Exit Sub

        End If

        selectedRowHandle = selectedRowHandles(0)
        'oRow = GridView1.GetDataRow(selectedRowHandle)

        oRow = GridView1.GetDataRow(selectedRowHandle)

        With oRow
            oUser.ID = oRow.Item("ID").ToString()
            oUser.First = oRow.Item("First").ToString()
            oUser.Last = oRow.Item("Last").ToString()
            oUser.LoginID = oRow.Item("LoginID").ToString()
            oUser.RoleID = oRow.Item("RoleID").ToString()


        End With

        With oForm
            .oUserAccount = oUser
            .txtLoginID.Text = oUser.LoginID
            .txtFirst.Text = oUser.First
            .txtLast.Text = oUser.Last
            .txtDistrictID.Text = txtDistrictID.Text
            .txtSchoolID.Text = txtSchoolID.Text
            .txtUserID.Text = oUser.ID.ToString
            .cmbRole.SelectedValue = oUser.RoleID
            .txtPassword.Text = "" 'Clear One Way encryption

            .ShowDialog()

        End With

        LoadSchoolUsers()



    End Sub

    Private Sub GridView2_MouseUp(sender As Object, e As MouseEventArgs) Handles GridView2.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu3.ShowPopup(Control.MousePosition)
        End If
    End Sub



    Private Sub BarButtonItem4_ViewBook_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4_ViewBook.ItemClick
        ShowEBook(True)
    End Sub

    Private Sub BarButtonItem4_ViewCover_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4_ViewCover.ItemClick
        ShowBookCover(Me.Location, True)
    End Sub

    Private Sub BarButtonItem4_ReplaceBookCover_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4_ReplaceBookCover.ItemClick
        ReplaceBookCover(True)
    End Sub

    Private Sub cmdloadAddBookFile_Click(sender As Object, e As EventArgs) Handles cmdloadAddBookFile.Click
        With XtraOpenFileDialog1
            .ShowDialog()
            txtAddBookFileNae.Text = .FileName

        End With

        Dim filePath As String = txtAddBookFileNae.Text
        Dim directory As String = Path.GetDirectoryName(filePath)
        Dim sFileName As String = Path.GetFileName(filePath)
        Dim dt As New DataTable

        txtAddBookFileNae.Text = filePath
        'LoadExcelFileISBN2(txtFilename.Text)
        dt = GetCsvData(directory, sFileName)
        dgv_ImportAddBookMeta.DataSource = Nothing

        With dgv_ImportAddBookMeta
            .DataSource = dt

        End With
    End Sub

    Private Sub cmdAddBookMeta_Click(sender As Object, e As EventArgs) Handles cmdAddBookMeta.Click
        Dim sTAGName As String
        Dim iPublisherColIndex As Integer = 0
        Dim sPublisherText As String
        Dim iISBNColIndex As Integer = 1
        Dim sISBNColText As String
        Dim iTitleCol As Integer = 2
        Dim sTitleText As String
        Dim iDescCol As Integer = 3
        Dim sDescText As String
        Dim iFNFCol As Integer = 4
        Dim sFNFText As String
        Dim iGRLCol As Integer = 5
        Dim sGRLText As String
        Dim iATOSCol As Integer = 6
        Dim sATOSText As String
        Dim iLEXCol As Integer = 7
        Dim sLEXText As String
        Dim iTAGColIndex As Integer = 8
        Dim sTagText As String
        Dim sPubliserherID As String
        Dim sPublisherName As String
        Dim oPublisherGuid As System.Guid

        Dim sRtrnMsg As String

        Dim bAddTAGS As Boolean
        Dim bAddTAGSIfDoesNotExist As Boolean

        Dim iSelected As Integer
        Dim bTagAlreadyonBook As Boolean
        Dim sTagType As String


        Dim sISBN As String


        Dim iRtrn As Integer
        Dim iRowCnt As Integer
        Dim sMessage As String
        Dim bAddBookMetaData As Boolean
        Dim bUpdateBookMetaData As Boolean
        Dim bUpdateNotInsert As Boolean

        Dim sReturnTag As String

        Dim sQuantityType As String



        iRowCnt = dgv_ImportAddBookMeta.RowCount

        If chkAddBookSimulation.CheckState = CheckState.Checked Then
            bAddBookMetaData = False
        Else
            bAddBookMetaData = True

        End If

        If chkUpdateMetaData.CheckState = CheckState.Checked Then
            bUpdateBookMetaData = True
        Else
            bUpdateBookMetaData = False

        End If

        If iRowCnt > 0 Then
            iRtrn = MsgBox("You are about to import '" & iRowCnt & "' ISBNs in the Books Table. Are you sure you want to continue?", MsgBoxStyle.YesNo)
        Else
            MsgBox("You need to load a ISBN CSV file to import.")
            Exit Sub
        End If



        If bAddBookMetaData = True Then
            sMessage = sMessage & "ISBNs Import to Books Table " & iRowCnt & " " & Now() & vbCrLf & vbCrLf
        Else
            sMessage = sMessage & "ISBNs Import Simulation for " & cmbSchools2.Text & ". NO RECORDS will be imported!: " & Now() & vbCrLf & vbCrLf
        End If


        Dim oRow As DataRow

        Dim sReturn As String
        Dim iErrorCnt As Integer
        Dim iSuccessCnt As Integer
        Dim sBookID As String

        Dim bBookAlreadyInSchool As Boolean









        For Each oRow In dgv_ImportAddBookMeta.DataSource.rows
            bBookAlreadyInSchool = False

            sPublisherName = oRow.Item(iPublisherColIndex).ToString

            If Guid.TryParse(sPublisherName, oPublisherGuid) Then
                sPubliserherID = sPublisherName
            Else
                sPubliserherID = GetPublisherIDByName(sPublisherName)
            End If

            If sPubliserherID = "" Then
                ' MsgBox("No Publisher")

                sMessage = sMessage & sISBN & "," & sPublisherName & " for this ISBN Not found in DiBS" & vbCrLf
                iErrorCnt = iErrorCnt + 1
                GoTo NextRow

            End If


            If chkAddBookMeta_SkipISBNCheck.Checked = False Then
                sISBN = RemoveHyphens(oRow.Item(iISBNColIndex).ToString)
            Else
                sISBN = oRow.Item(iISBNColIndex).ToString
            End If


            If sISBN.Length = 10 Or sISBN.Length = 13 Or chkAddBookMeta_SkipISBNCheck.Checked = True Then

                bUpdateNotInsert = False

                sBookID = GetBookIDByISBN(sISBN)

                If sBookID = "" Or bUpdateBookMetaData = True Then

                    If sBookID <> "" And bUpdateBookMetaData = True Then
                        'Book exist, we are going to do a update...and not a add
                        bUpdateNotInsert = True
                    Else
                        'new Book to insert need new book id
                        sBookID = Guid.NewGuid.ToString
                    End If
                    'Book Meta Data no

                    sTitleText = oRow.Item(iTitleCol).ToString
                    sDescText = oRow.Item(iDescCol).ToString
                    sFNFText = oRow.Item(iFNFCol).ToString
                    sGRLText = oRow.Item(iGRLCol).ToString
                    sATOSText = oRow.Item(iATOSCol).ToString
                    sLEXText = oRow.Item(iLEXCol).ToString
                    sTagText = oRow.Item(iTAGColIndex).ToString
                    'Make sure there is no Characters
                    sLEXText = CleanLex(sLEXText)

                    If bAddBookMetaData = True Then

                        'added last...Do you update or insert

                        If bUpdateNotInsert = True Then
                            sReturn = UpdateBookMetaByISBN(sPubliserherID, sISBN, sTitleText, sDescText, sFNFText, sGRLText, sATOSText, sLEXText, sBookID)
                            sMessage = sMessage & sISBN & "," & "ISBN UPDATED IN Books" & vbCrLf
                        Else
                            sReturn = AddBookMetaByISBN(sPubliserherID, sISBN, sTitleText, sDescText, sFNFText, sGRLText, sATOSText, sLEXText, sBookID)
                        End If

                    Else
                        sMessage = sMessage & "Would have tried to add: " & sPubliserherID & ", " & sISBN & ", " & sTitleText & ", " & sDescText & ", " & sFNFText & ", " & sGRLText & ", " & sATOSText & ", " & sLEXText & ", " & sBookID & vbCrLf

                    End If

                    If sReturn = "1" Then
                        sMessage = sMessage & sISBN & "," & "ISBN added to Books" & vbCrLf
                        iSuccessCnt = iSuccessCnt + 1



                    Else
                        sMessage = sMessage & sISBN & "," & "ISBN NOT Added to Books" & vbCrLf
                        iErrorCnt = iErrorCnt + 1
                    End If

                    sReturnTag = AddTagByBookID(sBookID, sISBN, sTagText, "National", sRtrnMsg)
                    sMessage = sMessage & sRtrnMsg & vbCrLf

                Else
                    ' MsgBox("Found a match")
                    sMessage = sMessage & sISBN & "," & "ISBN Already in DiBS" & vbCrLf
                    iSuccessCnt = iSuccessCnt + 1
                    GoTo NextRow

                End If


            End If


NextRow:

        Next
        '  sReturn = Insert_Collection(sSchoolID, sLineID, sItemNumber, iISSixPack)
        sMessage = sMessage & iSuccessCnt & ": Books Added" & vbCrLf
        sMessage = sMessage & iErrorCnt & ": Books Add Failed" & vbCrLf


        Dim oForm As New frmMessage

        With oForm
            .txtLog.Text = sMessage
            .Show()
        End With



    End Sub

    Private Sub cmdGenerateWelcomeEmail_Click(sender As Object, e As EventArgs) Handles cmdGenerateWelcomeEmail.Click
        Dim sWelcomeEmailTempFilePath As String
        Dim sBodyTemp As String
        Dim sSchoolDirectURL As String
        Dim sSchoolName As String
        Dim sTempFile As String
        Dim oAttachment As New MailItemAttachement
        Dim oAttachments As New List(Of MailItemAttachement)
        Dim sViewerBrand As String
        Dim sViewerURLTemp As String
        Dim sSchoolID As String
        Dim sSchoolDistrictID

        Dim sSubjectTemp As String

        If cmbSchools2.EditValue.ToString.Length > 0 Then
            'Do nothing...you have a school

        Else
            MsgBox("You need To Select a school")
            Exit Sub

        End If


        sSchoolID = txtSchoolID.Text
        sSchoolDistrictID = txtDistrictID.Text


        sViewerBrand = cmbViewerBrand.Text
        sViewerURLTemp = GetViewerTempURL()

        sSchoolDirectURL = sViewerURLTemp & sSchoolID

        sSchoolName = cmbSchools2.Text



        Select Case sViewerBrand
            Case "Pacific"
                sWelcomeEmailTempFilePath = HiveTemplatePath & "WelcomeEmail.html"
                sTempFile = HiveTemplatePath & "BH_logo_new_lockup_vertical_small.jpg"
                sBodyTemp = GetTextFromFile(sWelcomeEmailTempFilePath)
                sBodyTemp = sBodyTemp.Replace("{SchoolDirectURL}", sSchoolDirectURL)
                sBodyTemp = sBodyTemp.Replace("{SchoolName}", sSchoolName)


                sSubjectTemp = "Welcome to Brain Hive, all your included e-Books have been loaded into your account ({SchoolName})"
                sSubjectTemp = sSubjectTemp.Replace("{SchoolName}", sSchoolName)

                oAttachment.FilePath = sTempFile
                oAttachment.FileName = "BH_logo_new_lockup_vertical_small.jpg"
                oAttachments.Add(oAttachment)
            Case Else
                sWelcomeEmailTempFilePath = HiveTemplatePath & "WelcomeEmail.html"
                sTempFile = HiveTemplatePath & "BH_logo_new_lockup_vertical_small.jpg"
                sBodyTemp = GetTextFromFile(sWelcomeEmailTempFilePath)
                sBodyTemp = sBodyTemp.Replace("{SchoolDirectURL}", sSchoolDirectURL)
                sBodyTemp = sBodyTemp.Replace("{SchoolName}", sSchoolName)


                sSubjectTemp = "Welcome to Brain Hive, all your included e-Books have been loaded into your account ({SchoolName})"
                sSubjectTemp = sSubjectTemp.Replace("{SchoolName}", sSchoolName)

                oAttachment.FilePath = sTempFile
                oAttachment.FileName = "BH_logo_new_lockup_vertical_small.jpg"
                oAttachments.Add(oAttachment)
        End Select




        Dim oBHMailItem As New BHMailItem

        With oBHMailItem
            .EmailType = BHEmailTypes.CustWelcomeEmail
            .Subject = sSubjectTemp
            .Body = sBodyTemp
            .Attachments = oAttachments
        End With
        CreateBHMailItem(oBHMailItem)
    End Sub
End Class