Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEBookMGMT

    Private Sub frmEBookMGMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetConnection()
        ' LoadLines()
        ' LoadStates()
        LoadStates2()
        LoadDisctricts2()
        LoadLines()


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
        ' cmbViewerBrand
        Dim sSQL As String
        Dim sViewerBrand As String
        Dim sViewerURLTEMP As String
        Dim sSchoolID As String
        Dim sSchoolDistrictID
        sViewerBrand = cmbViewerBrand.Text
        sSchoolID = txtSchoolID.Text
        sSchoolDistrictID = txtDistrictID.Text


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

    Private Sub BarButtonItem1_ViewBook_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1_ViewBook.ItemClick
        ShowEBook()
    End Sub

    Private Sub ShowEBook()
        Dim sContainerPath As String
        Dim sISBN As String
        Dim sFileName As String
        Dim sOutPath As String
        Dim sZipFileName As String
        Dim seBookPath As String


        'sISBN = "9781427199461"
        ' sFileName = sISBN & ".zip"
        ' sOutPath = "Z:\test\temp"
        ' sContainerPath = "books/BrainHive_Partners/Crabtree/Batch4/" & sISBN & "/"


        Dim oEditOrderID As Guid
        Dim selectedRowHandles As Int32() = GridView3.GetSelectedRows()
        Dim selectedRowHandle As Int32
        Dim oRow As DataRow


        Me.Cursor = Cursors.WaitCursor
        Try


            If selectedRowHandles.Count <> 1 Then
                MsgBox("Must select 1 Row")
                Exit Sub
            End If
            selectedRowHandle = selectedRowHandles(0)

            oRow = GridView3.GetDataRow(selectedRowHandle)


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

    Private Sub ShowBookCover(oPoint As Point)
        Dim oEditOrderID As Guid
        Dim selectedRowHandle As Int32
        Dim selectedRowHandles As Int32()

        Dim oRow As DataRow
        Dim sOfficalImage As String
        Dim info As ToolTipControlInfo = Nothing
        Dim sTooltip1 As New SuperToolTip()



        selectedRowHandles = GridView3.GetSelectedRows()
        selectedRowHandle = selectedRowHandles(0)
        'oRow = GridView1.GetDataRow(selectedRowHandle)

        oRow = GridView3.GetDataRow(selectedRowHandle)
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
End Class