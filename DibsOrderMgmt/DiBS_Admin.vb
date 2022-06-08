Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Imports System.Web
Imports Microsoft.Win32
Imports System.Text.RegularExpressions
'Imports System.Windows.Forms
Imports HtmlAgilityPack
Imports System.Text
Imports System.Security.Cryptography

Public Structure BookDiBS_Status
    Const NotFound As Integer = 0
    Const Found_NoIssues As Integer = 1
    Const Found_Issues As Integer = 2
    Const Invalid_ISBN As Integer = 3
    Const Invalid_Description As Integer = 4
End Structure



Module DiBS_Admin
    Public oConnection As SqlConnection
    'Production
    Public sConnectionString = "Data Source=tcp:erwsq53v17.database.windows.net,1433;Initial Catalog=DiBS_DB_Prod;Persist Security Info=True;User ID=dibsproddatabase;Password=gYgfYAKV9h2QJVX6pxuTwFsZoHgxE{RLWie]cA>ZixC8vsAeqP"
    'Test
    ' Public sConnectionString = "Data Source=tcp:erwsq53v17.database.windows.net,1433;Initial Catalog=DiBS_DB_Test;Persist Security Info=True;User ID=dibsproddatabase;Password=gYgfYAKV9h2QJVX6pxuTwFsZoHgxE{RLWie]cA>ZixC8vsAeqP"

    'Dev
    '  Public sConnectionString = "Data Source=tcp:gfgun820ax.database.windows.net,1433;Initial Catalog=DiBS_DB_Dev;Persist Security Info=True;User ID=mepdatabase;Password=4QTtHPopGD&JgTnBVQGzXgjgdLYvfVFi}gektL=2BHVmoXEt98"

    Public Sub SetConnection()
        Try




            oConnection = New SqlConnection(sConnectionString)
            ' Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
            '  oConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Public Function DeleteBookFromSchool(sSchoolID As String, sBookSchoolID As String)

        Dim sEXEC As String = "Delete from BookSchools where SchoolID='" & sSchoolID & "' and ID='" & sBookSchoolID & "'"




        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = "0"

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function
    Public Function DeleteUserFromSchool(sSchoolID As String, sAccountID As String)

        Dim sEXEC As String = "Delete from Accounts where SchoolID='" & sSchoolID & "' and ID='" & sAccountID & "'"




        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = "0"

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function
    Public Function Insert_Collection(sSchoolID As String, sLineID As String, sItemNumber As String, iIsSixPack As Integer, sQuantityType As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_CollectionBooks_Into_SchoolBooks @SchoolID,@LineID,@ItemNumber,@IsSixPack,@QuantityType"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sSchoolID)
            .Parameters.Add("@LineID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sLineID)
            .Parameters.Add("@ItemNumber", SqlDbType.NVarChar).Value = sItemNumber
            .Parameters.Add("@IsSixPack", SqlDbType.Bit).Value = iIsSixPack
            .Parameters.Add("@QuantityType", SqlDbType.NVarChar).Value = sQuantityType
            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function GetSchoolBooksRpt(sSchoolID As String) As DataSet
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim sSQL As String
        sSQL = "Select * from BooksInASchool_Rpt Where SchoolID='" & sSchoolID & "' Order by GuidedReadingLevel, Title ASC"


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds
    End Function
    Public Function GetSchoolBooksRpt_GRLFNF(sSchoolID As String, bDistrict As Boolean) As DataSet
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim sSQL As String
        If bDistrict Then
            sSQL = "Select * from BooksInASchool_GRL_FN_Balance_Rpt Where SchoolDistrictID='" & sSchoolID & "'"

        Else
            sSQL = "Select * from BooksInASchool_GRL_FN_Balance_Rpt Where SchoolID='" & sSchoolID & "'"

        End If


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds
    End Function
    Public Function GetSchoolWishListBooksRpt_GRLFNF(sSchoolID As String, bDistrict As Boolean) As DataSet
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim sSQL As String
        If bDistrict Then
            sSQL = "Select * from qryBooksInWishLists_School_GRL_FNF_Count Where SchoolDistrictID='" & sSchoolID & "'"

        Else
            sSQL = "Select * from qryBooksInWishLists_School_GRL_FNF_Count Where SchoolID='" & sSchoolID & "'"

        End If


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds
    End Function
    Public Function GetSchoolWishListBooksRpt_Detail(sSchoolID As String, bDistrict As Boolean) As DataSet
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim sSQL As String
        If bDistrict Then
            sSQL = "Select * from qryBooksInWishLists_Detail Where SchoolDistrictID='" & sSchoolID & "'"

        Else
            sSQL = "Select * from qryBooksInWishLists_Detail Where SchoolID='" & sSchoolID & "'"

        End If


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds
    End Function
    Public Function GetSchoolCheckoutHistory(sSchoolID As String, bDistrict As Boolean) As DataSet
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim sSQL As String
        If bDistrict Then
            sSQL = "Select * from BooksCheckedOutBySchoolByUser Where SchoolDistrictID='" & sSchoolID & "'"

        Else
            sSQL = "Select * from BooksCheckedOutBySchoolByUser Where SchoolID='" & sSchoolID & "'"

        End If


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        Return ds
    End Function
    Public Function CreateCompanyCollection(sLineID As String, sItemNumber As String, sItemDescription As String)

    End Function
    Public Function AddBookByISBN(sISBN As String, sSchoolID As String, iISSixPack As Integer, sLocation As String, sGRL As String, sF_NF As String, sTitle As String, sDecription As String, sPublisherID As String, bOnlyAddToBooks As Boolean, bUpdateBooks As Boolean, sQuantityType As String)
        'Let Check to see if Book is in Dibs
        'Yes.....then let's verify it has good info: GRL,F/NF,Description, Image
        'Yes.....but has some bad info, then try and update it.....
        'No......then Insert into dibs and get additional indata
        'Finally insert into SchoolBooks
        Dim iFoundInDibS As Integer = 0
        Dim sBookID As String = ""
        Dim bIsFiction As Boolean
        Dim sReturn As String

        Select Case sF_NF
            Case ""
            Case "F", "Fiction", "F/N"
                bIsFiction = True
            Case "NF", "Non-Fiction", "NonFiction"
                bIsFiction = False

        End Select



        iFoundInDibS = IsBookinDiBS_ISBN(sISBN, sBookID)

        If bOnlyAddToBooks = False Then
            Select Case iFoundInDibS

                Case BookDiBS_Status.Found_NoIssues
                    'Just the SChools
                    Insert_SchoolBooks(sSchoolID, sBookID, iISSixPack, sLocation, sQuantityType)

                Case BookDiBS_Status.Invalid_Description
                    If sDecription.Length > 0 Then
                        Update_Books_Description(sBookID, sDecription, True)
                    End If
                Case BookDiBS_Status.Found_Issues

                Case BookDiBS_Status.NotFound

                Case BookDiBS_Status.Invalid_ISBN


            End Select
        Else

            If sBookID.Length = 0 Then
                sReturn = Insert_Books(sPublisherID, sISBN, sTitle, sDecription, sGRL, "", bIsFiction, False)

                sReturn = sReturn & ":Added " & vbCrLf

            Else
                If bUpdateBooks Then
                    sReturn = Update_Books(sBookID, sPublisherID, sTitle, sDecription, sGRL, bIsFiction, True)
                    sReturn = sReturn & ":Updated " & vbCrLf
                Else
                    sReturn = sReturn & sISBN & ":ISBN Found in DB. Not Added" & vbCrLf
                End If

            End If


        End If
    End Function

    Public Function AddBookMetaByISBN(sPublisherID As String, sISBN As String, sTitle As String, sDecription As String, sF_NF As String, sGRL As String, sATOS As String, sLEX As String, sBookID As String)
        'Book was already Checked

        Dim iFoundInDibS As Integer = 0
        Dim bIsFiction As Boolean
        Dim sReturn As String

        Select Case sF_NF
            Case ""
            Case "F", "Fiction", "F/N", "fiction"
                bIsFiction = True
            Case "NF", "Non-Fiction", "NonFiction", "Nonfiction"
                bIsFiction = False

        End Select

        sReturn = Insert_Books(sPublisherID, sISBN, sTitle, sDecription, sGRL, "", bIsFiction, False, sATOS, sLEX, sBookID)

        Return sReturn
    End Function
    Public Function UpdateBookMetaByISBN(sPublisherID As String, sISBN As String, sTitle As String, sDecription As String, sF_NF As String, sGRL As String, sATOS As String, sLEX As String, sBookID As String)
        'Book was already Checked

        Dim iFoundInDibS As Integer = 0
        Dim bIsFiction As Boolean
        Dim sReturn As String

        Select Case sF_NF
            Case ""
            Case "F", "Fiction", "F/N", "fiction"
                bIsFiction = True
            Case "NF", "Non-Fiction", "NonFiction", "Nonfiction"
                bIsFiction = False

        End Select

        sReturn = Update_BooksMetaData(sPublisherID, sISBN, sTitle, sDecription, sGRL, bIsFiction, True, sATOS, sLEX, sBookID)

        Return sReturn
    End Function
    Public Function AddTagByBookID(sBookID As String, sISBN As String, sTagString As String, sTagType As String, ByRef sRtrnMsg As String)


        'Looking for Tags with commas. mutiples tags for 1 book
        Dim oTaglist As IList(Of String) = New List(Of String)(sTagString.Split(New String() {","}, StringSplitOptions.None))
        Dim sTAGName As String
        Dim sTAGID As String
        Dim iNewTagCnt As Integer
        Dim iNewTagfailedCnt As Integer
        Dim sTagAdded As String
        Dim iErrorCnt As Integer
        Dim iSuccessCnt As Integer
        Dim bAddTAGS As Boolean
        Dim sReturn As String
        Dim sState As String


        Dim sMessage As String
        Dim bTagAlreadyonBook As Boolean

        'since we may have multiple tags delimited by comma, then we need to loop through list
        For Each element As String In oTaglist
            element = element.Trim
            sTAGName = element.Trim


            If sTAGName.Length = 0 Then
                GoTo SkipToNext
            End If


            sTAGID = GetTAGIDByTagName(sTAGName, sTagType)

            If sTAGID = "" Then
                'So this tag does not exist...add it
                sTAGID = Guid.NewGuid.ToString
                '****Need to add Distict and school id handling
                sTagAdded = Insert_NewTAG(sTAGID, sTAGName, sTagType, "", "", sState)

                If sTagAdded = "1" Then
                    sMessage = sMessage & sISBN & "," & sTAGName & ",Created New Tag in DB." & vbCrLf
                    iNewTagCnt = iNewTagCnt + 1
                Else
                    sTAGID = ""
                    sMessage = sMessage & sISBN & "," & sTAGName & ",New Add Tag Failed." & vbCrLf
                    iNewTagfailedCnt = iNewTagfailedCnt + 1
                End If

            End If




            If sTAGID = "" Then
                sMessage = sMessage & sISBN & "," & sTAGName & ",Tag Name Not found." & vbCrLf
                iErrorCnt = iErrorCnt + 1

            Else

                'Does this TAG already exist on the book?
                bTagAlreadyonBook = IsTAGAlreadyOnBook(sBookID, sTAGID)

                If bTagAlreadyonBook Then
                    sMessage = sMessage & sISBN & "," & sTAGName & ",Tag Already on Book." & vbCrLf
                    iSuccessCnt = iSuccessCnt + 1
                    GoTo SkipToNext
                End If

                sReturn = Insert_BookTAGS(sBookID, sTAGID)

                If sReturn = 1 Then
                    sMessage = sMessage & sISBN & "," & sTAGName & ",TAG Added to Book" & vbCrLf
                    iSuccessCnt = iSuccessCnt + 1
                Else

                    sMessage = sMessage & sISBN & "," & sTAGName & ",TAG failed to Insert into Book." & vbCrLf
                    iErrorCnt = iErrorCnt + 1

                End If

            End If


SkipToNext:
        Next

        sRtrnMsg = sMessage


    End Function






    Public Function IsBookinDiBS_ISBN(sISBN As String, ByRef sBookID As String) As Integer

        'SELECT @iCount=COUNT(*) FROM Books WHERE ISBN=@ISBN
        Dim sSQL As String
        Dim sTitle As String
        Dim sGRL As String
        Dim iISFiction As Integer

        Dim sDecription As String


        If sISBN.Length = 10 Or sISBN.Length = 13 Then
            sSQL = "SELECT * FROM Books WHERE ISBN='" & sISBN & "'"
        Else
            IsBookinDiBS_ISBN = BookDiBS_Status.Invalid_ISBN
            Exit Function
        End If

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()

        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then


            With ds.Tables(0).Rows(0)
                sTitle = .Item("Title")
                sGRL = .Item("GuidedReadingLevel").ToString
                iISFiction = .Item("ISFiction")
                sDecription = .Item("Description").ToString
                sBookID = .Item("ID").ToString


            End With

            If sTitle.Length = 0 Or sGRL.Length = 0 Then
                IsBookinDiBS_ISBN = BookDiBS_Status.Found_Issues
            Else
                If sDecription.Length > 0 Then
                    IsBookinDiBS_ISBN = BookDiBS_Status.Found_NoIssues
                Else

                    'Need to add code to handle updating description
                    IsBookinDiBS_ISBN = BookDiBS_Status.Invalid_Description
                End If
            End If

        Else
            IsBookinDiBS_ISBN = BookDiBS_Status.NotFound
            sBookID = ""
        End If




    End Function
    Public Function Insert_CompanyCollection(sLineID As String, sItemNumber As String, sItemDescription As String, iISSixPack As Integer) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_CompanyCollection @LineID,@ItemNumber,@ItemDescription,@IsSixPack"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@LineID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sLineID)
            .Parameters.Add("@ItemNumber", SqlDbType.NVarChar).Value = sItemNumber
            .Parameters.Add("@ItemDescription", SqlDbType.NVarChar).Value = sItemDescription
            .Parameters.Add("@IsSixPack", SqlDbType.Bit).Value = iISSixPack



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function
    Public Function Insert_SchoolBooks(sSchoolID As String, sBookID As String, iIsSixPack As Integer, sLocation As String, sQuantityType As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_SchoolBooks @SchoolID,@BookID,@IsSixPack,@Location,@QuantityType"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sSchoolID)
            .Parameters.Add("@BookID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)
            .Parameters.Add("@IsSixPack", SqlDbType.Bit).Value = iIsSixPack
            .Parameters.Add("@Location", SqlDbType.NVarChar).Value = sLocation
            .Parameters.Add("@QuantityType", SqlDbType.NVarChar).Value = sQuantityType

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function Insert_Books(sPublisherID As String, sISBN As String, sTitle As String, sDescription As String, sGuidedReadingLevel As String, sOfficialImage As String, bIsFiction As Boolean, bIsApproved As Boolean, Optional sATOS As String = "", Optional sLEX As String = "", Optional sBookID As String = "") As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_Books @PublisherID,@ISBN,@Title,@Description,@GuidedReadingLevel,@OfficialImage,@IsTeacherGuideAvailable,@IsFiction,@IsApproved,@Series,@ATOS,@LEX,@ID"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            If sPublisherID = "" Then
                .Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            Else
                .Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sPublisherID)
            End If

            .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = sISBN
            .Parameters.Add("@Title", SqlDbType.NVarChar).Value = sTitle
            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = sDescription
            .Parameters.Add("@GuidedReadingLevel", SqlDbType.NVarChar).Value = sGuidedReadingLevel
            .Parameters.Add("@OfficialImage", SqlDbType.NVarChar).Value = sOfficialImage
            .Parameters.Add("@IsTeacherGuideAvailable", SqlDbType.Bit).Value = vbNull
            .Parameters.Add("@IsFiction", SqlDbType.Bit).Value = bIsFiction
            .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = bIsApproved
            .Parameters.Add("@Series", SqlDbType.NVarChar).Value = ""
            '.Parameters.Add("@Location", SqlDbType.NVarChar).Value = sLocation
            .Parameters.Add("@ATOS", SqlDbType.NVarChar).Value = sATOS
            .Parameters.Add("@LEX", SqlDbType.NVarChar).Value = sLEX

            If sBookID = "" Then
                .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            Else
                .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)
            End If

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function Update_BooksMetaData(sPublisherID As String, sISBN As String, sTitle As String, sDescription As String, sGuidedReadingLevel As String, bIsFiction As Boolean, bIsApproved As Boolean, Optional sATOS As String = "", Optional sLEX As String = "", Optional sBookID As String = "") As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Update_BooksMetaData @PublisherID,@ISBN,@Title,@Description,@GuidedReadingLevel,@IsFiction,@IsApproved,@Series,@ATOS,@LEX,@ID"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            If sPublisherID = "" Then
                .Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            Else
                .Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sPublisherID)
            End If

            .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = sISBN
            .Parameters.Add("@Title", SqlDbType.NVarChar).Value = sTitle
            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = sDescription
            .Parameters.Add("@GuidedReadingLevel", SqlDbType.NVarChar).Value = sGuidedReadingLevel
            '.Parameters.Add("@OfficialImage", SqlDbType.NVarChar).Value = sOfficialImage
            '.Parameters.Add("@IsTeacherGuideAvailable", SqlDbType.Bit).Value = vbNull
            .Parameters.Add("@IsFiction", SqlDbType.Bit).Value = bIsFiction
            .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = bIsApproved
            .Parameters.Add("@Series", SqlDbType.NVarChar).Value = ""
            '.Parameters.Add("@Location", SqlDbType.NVarChar).Value = sLocation
            .Parameters.Add("@ATOS", SqlDbType.NVarChar).Value = sATOS
            .Parameters.Add("@LEX", SqlDbType.NVarChar).Value = sLEX

            If sBookID = "" Then
                .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            Else
                .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)
            End If

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function
    Public Function Insert_BooksMin(sBookID As String, sPublisherID As String, sISBN As String, sTitle As String, sDescription As String, sGuidedReadingLevel As String, sOfficialImage As String, bIsFiction As Boolean, bIsApproved As Boolean) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_Books @BookID,@PublisherID,@ISBN,@Title,@Description,@GuidedReadingLevel,@OfficialImage,@IsTeacherGuideAvailable,@IsFiction,@IsApproved,@Series"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@BookID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)

            .Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sPublisherID)
            .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = sISBN
            .Parameters.Add("@Title", SqlDbType.NVarChar).Value = sTitle
            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = sDescription
            .Parameters.Add("@GuidedReadingLevel", SqlDbType.NVarChar).Value = sGuidedReadingLevel
            .Parameters.Add("@OfficialImage", SqlDbType.NVarChar).Value = sOfficialImage
            .Parameters.Add("@IsTeacherGuideAvailable", SqlDbType.Bit).Value = vbNull
            .Parameters.Add("@IsFiction", SqlDbType.Bit).Value = bIsFiction
            .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = bIsApproved
            .Parameters.Add("@Series", SqlDbType.NVarChar).Value = ""
            '.Parameters.Add("@Location", SqlDbType.NVarChar).Value = sLocation


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Sub SetUpperLevelTag(sTagName As String, ByRef oTagList As IList(Of String))
        Dim oStandardLevels As IList(Of String) = New List(Of String)(sTagName.Split(New String() {"."}, StringSplitOptions.None))
        'Basically, find all of '.' and goto last and strip of the end...that will
        Dim sStandard As String
        Dim iLastPeriod As Integer
        Dim x As Integer
        sStandard = ""

        If oStandardLevels.Count > 1 Then

            iLastPeriod = oStandardLevels.Count - 2

            For x = 0 To iLastPeriod
                If sStandard <> "" Then
                    sStandard = sStandard.Trim & "." & oStandardLevels(x).Trim
                Else
                    sStandard = oStandardLevels(x).Trim
                End If

            Next
            For Each element As String In oTagList
                If element = sStandard Then
                    'already in....exit out
                    Exit Sub
                Else

                End If
            Next
            'if you get here....it was not found add it
            oTagList.Add(sStandard)

        End If




    End Sub

    Public Function Insert_BookTAGS(sBookID As String, sTAGID As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_BookTAGS @BookID,@TAGID"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@BookID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)
            .Parameters.Add("@TAGID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sTAGID)

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function Insert_NewTAG(sNewTagID As String, sTagName As String, sTagType As String, sDistrictID As String, sSchoolID As String, sStates As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_TagNew @ID, @Name,@Type,@DistrictID,@SchoolID,@States"
        Dim sReturn As String

        If IsNothing(sStates) Then
            sStates = ""
        End If
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sNewTagID)
            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = sTagName
            .Parameters.Add("@Type", SqlDbType.NVarChar).Value = sTagType



            If sDistrictID.Length > 0 Then
                .Parameters.Add("@DistrictID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sDistrictID)
            Else
                .Parameters.Add("@DistrictID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            End If

            If sSchoolID.Length > 0 Then
                .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sSchoolID)
            Else
                .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = DBNull.Value

            End If

            If sStates.Length > 0 Then
                .Parameters.Add("@States", SqlDbType.NVarChar).Value = sStates
            Else
                .Parameters.Add("@States", SqlDbType.NVarChar).Value = DBNull.Value

            End If
            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function Insert_NewAccount(sFirst As String, sLast As String, sLoginID As String, sPassword As String, sEmail As String, sAPIKEY As String, sRoleID As String, sSchoolID As String, sDistrictID As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_Account @First, @Last,@LoginID,@Password,@Email,@APIKey,@RoleID,@SchoolID,@DistrictID"
        Dim sReturn As String

        'If IsNothing(sStates) Then
        '    sStates = ""
        'End If

        sPassword = OneWayEncrypt(sPassword)


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            '  .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sNewTagID)
            .Parameters.Add("@First", SqlDbType.NVarChar).Value = sFirst
            .Parameters.Add("@Last", SqlDbType.NVarChar).Value = sLast
            .Parameters.Add("@LoginID", SqlDbType.NVarChar).Value = sLoginID
            .Parameters.Add("@Password", SqlDbType.NVarChar).Value = sPassword
            .Parameters.Add("@Email", SqlDbType.NVarChar).Value = sEmail
            .Parameters.Add("@APIKey", SqlDbType.NVarChar).Value = sAPIKEY

            If sRoleID.Length > 0 Then
                .Parameters.Add("@RoleID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sRoleID)
            Else
                .Parameters.Add("@RoleID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            End If

            If sSchoolID.Length > 0 Then
                .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sSchoolID)
            Else
                .Parameters.Add("@SchoolID", SqlDbType.UniqueIdentifier).Value = DBNull.Value

            End If

            If sDistrictID.Length > 0 Then
                .Parameters.Add("@DistrictID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sDistrictID)
            Else
                .Parameters.Add("@DistrictID", SqlDbType.UniqueIdentifier).Value = DBNull.Value

            End If

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function Update_AxistingAccount(sID As String, sFirst As String, sLast As String, sLoginID As String, sPassword As String, sEmail As String, sRoleID As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String

        If sPassword <> "" Then
            'Password is being changed
            sEXEC = "UPDATE dbo.Accounts Set First=@First,Last=@Last,LoginID=@LoginID,Password=@Password,RoleID=@RoleID Where ID=@ID"
            sPassword = OneWayEncrypt(sPassword)

        Else
            'Password NOT changed
            sEXEC = "UPDATE dbo.Accounts Set First=@First,Last=@Last,LoginID=@LoginID,RoleID=@RoleID Where ID=@ID"

        End If

        Dim sReturn As String

        'If IsNothing(sStates) Then
        '    sStates = ""
        'End If





        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sID)
            .Parameters.Add("@First", SqlDbType.NVarChar).Value = sFirst
            .Parameters.Add("@Last", SqlDbType.NVarChar).Value = sLast
            .Parameters.Add("@LoginID", SqlDbType.NVarChar).Value = sLoginID

            If sPassword <> "" Then
                .Parameters.Add("@Password", SqlDbType.NVarChar).Value = sPassword
            End If


            If sRoleID.Length > 0 Then
                .Parameters.Add("@RoleID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sRoleID)
            Else
                .Parameters.Add("@RoleID", SqlDbType.UniqueIdentifier).Value = DBNull.Value
            End If



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function


    Public Function Insert_NewSchool(sSchoolName As String, sOrigSchoolID As String) As String
        'SELECT NEWID() AS ID,Name,Address,City,State,zip,GETDATE(),GETDATE(),SchoolDistrictID,NULL,NULL FROM DiBS_DB_Prod.dbo.Schools WHERE  Schools.ID='d0a8a2a8-80c8-4164-ac79-611d8ce5976b' 



        Dim sReturn As String
        Dim sEXEC As String = "Insert INTO schools SELECT NEWID() AS ID,'" & sSchoolName & "',Address,City,State,zip,GETDATE(),GETDATE(),SchoolDistrictID,NULL,NULL FROM DiBS_DB_Prod.dbo.Schools WHERE  Schools.ID='" & sOrigSchoolID & "'"


        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn
        oConnection.Close()

        Return sReturn

    End Function


    Public Function InsertUpdate_WishListBook(sISBN As String, dblPrice As Double, sCompanyID As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "WishlistBooks_IU @ISBN, @Price,@CompanyLineID"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = sISBN
            .Parameters.Add("@Price", SqlDbType.Float).Value = dblPrice
            .Parameters.Add("@CompanyLineID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sCompanyID)


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function Insert_Collections_BooksISBN(sCollectionID As String, sISBN As String) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Insert_Collections_BooksISBN @CollectionID,@ISBN"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@CollectionID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sCollectionID)
            .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = sISBN



            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function
    Public Function Update_Books_Description(sBookID As String, sDescription As String, bIsApproved As Boolean) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Update_BooksDescription @BookID,@Description,@IsApproved,"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@BookID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)
            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = sDescription
            .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = bIsApproved

            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function
    Public Function Update_Books(sBookID As String, sPublisherID As String, sTitle As String, sDescription As String, sGuidedReadingLevel As String, bIsFiction As Boolean, bIsApproved As Boolean) As String
        'sp_Insert_CollectionBooks_Into_SchoolBooks 'c47cf20d-b1bc-4e9c-8c4e-28a8c9ae192d', 'e6a391c2-7b67-458a-982a-12884be44946','35761',1

        Dim sEXEC As String = "sp_Update_Books @BookID,@PublisherID,@Title,@Description,@GuidedReadingLevel,@IsTeacherGuideAvailable,@IsFiction,@IsApproved,@Series"
        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@BookID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sBookID)
            .Parameters.Add("@PublisherID", SqlDbType.UniqueIdentifier).Value = New System.Data.SqlTypes.SqlGuid(sPublisherID)
            ' .Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = sISBN
            .Parameters.Add("@Title", SqlDbType.NVarChar).Value = sTitle
            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = sDescription
            .Parameters.Add("@GuidedReadingLevel", SqlDbType.NVarChar).Value = sGuidedReadingLevel
            '.Parameters.Add("@OfficialImage", SqlDbType.NVarChar).Value = sOfficialImage
            .Parameters.Add("@IsTeacherGuideAvailable", SqlDbType.Bit).Value = vbNull
            .Parameters.Add("@IsFiction", SqlDbType.Bit).Value = bIsFiction
            .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = bIsApproved
            .Parameters.Add("@Series", SqlDbType.NVarChar).Value = ""
            '.Parameters.Add("@Location", SqlDbType.NVarChar).Value = sLocation


            sReturn = .ExecuteNonQuery


        End With
        oConnection.Close()

        Return sReturn

    End Function

    Public Function GetBookIDByISBN(sISBN As String)
        Dim sEXEC As String = "SELECT ID FROM Books WHERE ISBN='" & sISBN & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function

    Public Function GetEBookPathByISBN(sISBN As String)
        Dim sEXEC As String = "SELECT EBookPath FROM Books WHERE ISBN='" & sISBN & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function

    Public Function IsTAGAlreadyOnBook(sBookID As String, sTAGID As String) As Boolean
        Dim sEXEC As String = "SELECT ID FROM BookTags WHERE BookID='" & sBookID & "' and TAGID='" & sTAGID & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = False

        Else
            sReturn = True

        End If

        Return sReturn

    End Function

    Public Function IsBookAlreadyInSchool(sBookID As String, sSchoolID As String) As Boolean
        Dim sEXEC As String = "SELECT ID FROM BookSchools WHERE BookID='" & sBookID & "' and SchoolID='" & sSchoolID & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = False

        Else
            sReturn = True

        End If

        Return sReturn

    End Function

    Public Function IsLoginAlreadyInSchool(sLoginID As String, sSchoolID As String) As Boolean
        Dim sEXEC As String = "SELECT ID FROM Accounts WHERE LoginID='" & sLoginID & "' and SchoolID='" & sSchoolID & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = False

        Else
            sReturn = True

        End If

        Return sReturn

    End Function
    Public Function GetTAGIDByTagName(sTagName As String, sTagType As String)


        sTagName = sTagName.Replace("'", "''")

        Dim sEXEC As String = "SELECT ID FROM Tags WHERE Type='" & sTagType & "' and Name='" & sTagName & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function
    Public Function GetUserInfoByAPI(sAPIKey As String) As DataTable
        Dim sSQL As String = "SELECT * FROM UsersInASchoolDetail where APIKey='" & sAPIKey & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "UsersInASchoolDetail")
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then

            Return ds.Tables(0)
        Else
            Return Nothing

        End If
    End Function
    Public Function GetBookDetailByISBN(sISBN As String, sSchoolID As String) As DataTable
        Dim sSQL As String = "SELECT * FROM BooksInSchoolsDEtails where ISBN='" & sISBN & "' and SchoolID= '" & sSchoolID & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "BooksInSchoolsDEtails")
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then

            Return ds.Tables(0)
        Else
            Return Nothing

        End If
    End Function
    Public Function GetBookDetailByBookID(sBookID As String, sSchoolID As String) As DataTable
        Dim sSQL As String = "SELECT * FROM BooksInSchoolsDEtails where ID='" & sBookID & "' and SchoolID= '" & sSchoolID & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "BooksInSchoolsDEtails")
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then

            Return ds.Tables(0)
        Else
            Return Nothing

        End If
    End Function
    Public Function GetBookByBookID(sBookID As String) As DataTable
        Dim sSQL As String = "SELECT * FROM Books where ID='" & sBookID & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "Books")
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then

            Return ds.Tables(0)
        Else
            Return Nothing

        End If
    End Function
    Public Function GetBookByISBN(sISBN As String) As DataTable
        Dim sSQL As String = "SELECT * FROM Books where ISBN='" & sISBN & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "Books")
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then

            Return ds.Tables(0)
        Else
            Return Nothing

        End If
    End Function
    Public Function GetBookIDByISBNOnly(sISBN As String)
        Dim sEXEC As String = "SELECT ID FROM Books WHERE ISBN='" & sISBN & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function
    Public Function GetBookOfficalImageByISBNOnly(sISBN As String)
        Dim sEXEC As String = "SELECT OfficalImage FROM Books WHERE ISBN='" & sISBN & "'"

        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function
    Public Function GetPublisherIDByName(sName As String) As String

        sName = sName.Replace("'", "''")


        Dim sEXEC As String = "SELECT * FROM Publishers where Name='" & sName & "'"



        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn
    End Function
    Public Function GetWishListBookRecordByISBN(sISBN As String) As DataTable
        Dim sSQL As String = "SELECT * FROM WishListBooksByCompanyLine where ISBN='" & sISBN & "'"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds, "WishListBooks")
        oConnection.Close()

        If ds.Tables(0).Rows.Count > 0 Then

            Return ds.Tables(0)
        Else
            Return Nothing

        End If

    End Function
    Public Function GetCollectionID(sLineID As String, sItemNumber As String)
        Dim sEXEC As String = "SELECT ID FROM Collections WHERE LineID='" & sLineID & "'" & " and ItemNumber='" & sItemNumber & "'"


        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = ""

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function
    'qryCollectionBooksInSchool
    Public Function GetCollectionBooksInSchoolCnt(sSchoolID As String, sCollectionID As String)
        Dim sEXEC As String = "SELECT count(ISBN) FROM qryCollectionBooksInSchool WHERE SchoolID='" & sSchoolID & "'" & " and CollectionID='" & sCollectionID & "'"


        Dim sReturn As Object
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand

            sReturn = .ExecuteScalar

        End With
        oConnection.Close()

        If sReturn Is Nothing Then
            sReturn = 0

        Else
            sReturn = sReturn.ToString

        End If

        Return sReturn

    End Function

    Public Function ConvertImagetoBase64String(sd As Image, bAddDiBSHeader As Boolean)
        'Converting the image to a byte[] to later be converted to base64 string
        Dim imgStream As MemoryStream = New MemoryStream()
        sd.Save(imgStream, System.Drawing.Imaging.ImageFormat.Jpeg)

        imgStream.Close()
        Dim byteArray As Byte() = imgStream.ToArray()
        imgStream.Dispose()

        'Convert the byte[] to base64 string for use with WebRequest to upload.
        Dim final As String
        final = Convert.ToBase64String(byteArray)
        '  final = "data:image/jpeg;base64," & final
        final = final

        Return final

    End Function

    Public Function GetAbeBookValidImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        Dim sSource As String
        Dim sFileName As String

        sSource = "http://pictures.abebooks.com/isbn"


        If sISBN.Length = 13 Then
            sFileName = sSource & "/" & sISBN & "-us.jpg"

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function

    Public Function GetScholasticValidImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        'http://www.scholastic.com/content5/media/products/20/9780439064620_xlg.jpg
        'https://shop.scholastic.com/content/stores/media/products/63/9780439688963_xlg.jpg
        'http://www.scholastic.com/content5/media/products/54/9780823418954_xlg.jpg
        Dim sSource As String
        Dim sSource2 As String
        Dim sSource3 As String

        Dim sFileName As String
        Dim sFileName2 As String
        Dim sLast2 As String
        sSource = "http://www.scholastic.com/content5/media/products"
        sSource2 = "https://shop.scholastic.com/content/stores/media/products"
        sSource3 = "http://www.scholastic.com/content5/media/products/51/9780590307451_xlg.jpg"

        If sISBN.Length = 13 Then
            sLast2 = Mid(sISBN, 12, 2)
            sFileName = sSource & "/" & sLast2 & "/" & sISBN & "_xlg.jpg"
            sFileName2 = sSource2 & "/" & sLast2 & "/" & sISBN & "_xlg.jpg"

        Else
            Return ""
        End If

        'Try the first scholastic source
        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            'TRy second scholastic Source
            On Error Resume Next
            sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName2)))

            If sd Is Nothing Then
                Return ""
            Else
                Return sFileName2
            End If


        Else
            Return sFileName
        End If

    End Function


    Public Function GetSortItAppValidImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' 'https://www.ethanproductions.com/books-newDB/images/9780545165174.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "https://www.ethanproductions.com/books-newDB/images/"


        If sISBN.Length = 13 Then

            sFileName = sSource & sISBN & ".jpg"

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function



    Public Function GetHMHImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://www.hmhco.com/shop/books/k12/images/9781418900694.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "http://www.hmhco.com/shop/books/k12/images/"


        If sISBN.Length = 13 Then

            sFileName = sSource & sISBN & ".jpg"

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function

    Public Function GetStepsToLiteracyImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://www.stepstoliteracy.com/media/catalog/product/cache/1/small_image/225x135/9df78eab33525d08d6e5fb8d27136e95/9/7/{ISBN}_H1.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "http://www.stepstoliteracy.com/media/catalog/product/cache/1/small_image/225x135/9df78eab33525d08d6e5fb8d27136e95/9/7/{ISBN}_H1.jpg"


        If sISBN.Length = 13 Then

            sFileName = sSource.Replace("{ISBN}", sISBN)

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function
    'https://secure.syndetics.com/index.aspx?isbn=9781404808119/MC.GIF&client=vancp&type=xw12&oclc=









    Public Function GetCapStoneImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://www.capstonepub.com/assets/1/14/DimRegular/9781404823907.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "http://www.capstonepub.com/assets/1/14/DimRegular/"


        If sISBN.Length = 13 Then

            sFileName = sSource & sISBN & ".jpg"

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function

    Public Function GetDiBSPermenantLinkImageURL(sPermenantLinkAPIPath As String) As String


        Dim sSource As String
        Dim sNewPermenantLink As String

        sSource = sPermenantLinkAPIPath


        Dim request1 As HttpWebRequest = CType(WebRequest.Create(sPermenantLinkAPIPath), HttpWebRequest)

        request1.Credentials = CredentialCache.DefaultCredentials
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        request1.KeepAlive = False


        request1.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36"
        request1.Accept = "Accept: text/html,application/xhtml+xml,application/xml"

        Dim response1 As HttpWebResponse = CType(request1.GetResponse(), HttpWebResponse)


        Console.WriteLine("Content length is {0}", response1.ContentLength)
        Console.WriteLine("Content type is {0}", response1.ContentType)
        Dim receiveStream As Stream = response1.GetResponseStream()
        Dim readStream As StreamReader = New StreamReader(receiveStream, Encoding.UTF8)
        'Console.WriteLine("Response stream received.")
        'Console.WriteLine(readStream.ReadToEnd())
        sNewPermenantLink = readStream.ReadToEnd()
        response1.Close()
        readStream.Close()


        If sNewPermenantLink Is Nothing Then
            Return ""
        Else
            Return sNewPermenantLink
        End If

    End Function

    'http://www.datastellar.com/base/books/attachment/covers/27/55/9780673612755.jpg

    Public Function GetDataStellarImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://www.datastellar.com/base/books/attachment/covers/27/55/9780673612755.jpg
        'http://www.datastellar.com/base/books/attachment/covers/50/46/9780061935046.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        Dim sLast4 As String
        sSource = "http://www.datastellar.com/base/books/attachment/covers"


        If sISBN.Length = 13 Then
            sLast2 = Mid(sISBN, 12, 2)
            sLast4 = Mid(sISBN, 10, 2)
            sFileName = sSource & "/" & sLast4 & "/" & sLast2 & "/" & sISBN & ".jpg"



        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function



    Public Function GetPaperBackSwapImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String

        '  http://images.paperbackswap.com/l/95/5195/9780516245195.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        Dim sLast4 As String
        sSource = "http://images.paperbackswap.com/l"


        If sISBN.Length = 13 Then
            sLast2 = Mid(sISBN, 12, 2)
            sLast4 = Mid(sISBN, 10, 4)

            sFileName = sSource & "/" & sLast2 & "/" & sLast4 & "/" & sISBN & ".jpg"



        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function

    Public Function GetAbeBooksImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://pictures.abebooks.com/isbn/9781586633493-us.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        Dim sLast4 As String
        sSource = "http://pictures.abebooks.com/isbn/"


        If sISBN.Length = 13 Then

            sFileName = sSource & sISBN & "-us.jpg"



        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function


    Public Function GetBookSourceImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://images.booksource.com/HandleImage.aspx?img=9781404264717&XDim=227&YDim=227

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "http://images.booksource.com/HandleImage.aspx?img=ISBNNUMBER&XDim=227&YDim=227"


        If sISBN.Length = 13 Then

            sFileName = Replace(sSource, "ISBNNUMBER", sISBN)

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function



    Public Function GetFollettImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' http://images.follett.com/imagesystem/rest/cache/cover/isbn/9780618548811?width=150

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "http://images.follett.com/imagesystem/rest/cache/cover/isbn/ISBNNUMBER?width=150"


        If sISBN.Length = 13 Then

            sFileName = Replace(sSource, "ISBNNUMBER", sISBN)

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function


    Public Function GetAKJImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        ' https://store.akjbooks.com/A/prodInfo/image/images/9780142403549.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "https://store.akjbooks.com/A/prodInfo/image/images/ISBNNUMBER.jpg"


        If sISBN.Length = 13 Then

            sFileName = Replace(sSource, "ISBNNUMBER", sISBN)

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function





    Public Function GetBooks4SChoolImageURL(sISBN As String, Optional ByRef sd As System.Drawing.Image = Nothing) As String
        '  'https://www.books4school.com/images/product/9780545148870.jpg

        Dim sSource As String
        Dim sFileName As String
        Dim sLast2 As String
        sSource = "https://www.books4school.com/images/product/ISBNNUMBER.jpg"


        If sISBN.Length = 13 Then

            sFileName = Replace(sSource, "ISBNNUMBER", sISBN)

        Else
            Return ""
        End If

        On Error Resume Next
        sd = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sFileName)))
        If sd Is Nothing Then
            Return ""
        Else
            Return sFileName
        End If

    End Function




    ' Validates an ISBN13 number. If false, it's invalid, else if true, it's valid,
    Function bVerifySum13(ByRef s As String) As Boolean
        If Not (s Like "#############" And Mid(s, 1, 3) = "978") Then
            Return False
        End If
        Dim i As Integer = 30
        For j As Integer = 4 To 12 Step 2
            i += Convert.ToInt32(Mid(s, j - 1, 1)) + (3 * Convert.ToInt32(Mid(s, j, 1)))
        Next
        If Not (Mid(s, 13, 1) = ((10 - (i Mod 10)) Mod 10).ToString) Then
            Return False
        End If
        Return True
    End Function

    ' Conversion from ISBN13 to ISBN10
    Function sConvertN13toN10(ByRef s As String) As String

        Try


            sConvertN13toN10 = Mid(s, 4, 9)
            Dim i As Integer = 0
            For j As Integer = 10 To 2 Step -1
                i += (j * Convert.ToInt32(Mid(sConvertN13toN10, (10 - (j - 1)), 1)))
            Next
            If (i Mod 11) = 0 Then
                Return sConvertN13toN10 + "0"
            End If
            Dim iCount As Integer = 1
            Do Until ((i + iCount) Mod 11) = 0
                iCount += 1
            Loop
            If iCount = 10 Then
                Return sConvertN13toN10 + "X"
            End If
            Return sConvertN13toN10 + iCount.ToString

        Catch ex As Exception
            Return ""
        End Try
    End Function

    ' Validates an ISBN10 number. If false, it's invalid, else if true, it's valid,
    Function bVerifySum10(ByRef s As String) As Boolean

        Try


            Dim i As Integer = 0
            For j = 10 To 2 Step -1
                i += ((Convert.ToInt32(Mid(s, (10 - (j - 1)), 1))) * j)
            Next
            If (i Mod 11) = 0 And Mid(s, 10, 1) = "0" Then
                Return True
            ElseIf Mid(s, 10, 1).ToUpper = "X" Then
                i += 10
            Else
                i += Convert.ToInt32(Mid(s, 10, 1))
            End If
            If Not ((i Mod 11) = 0) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Return True
        End Try

    End Function

    ' Conversion from ISBN10 to ISBN13
    Function sConvertN10toN13(ByRef s As String) As String
        Dim i As Integer = 30
        sConvertN10toN13 = "978" + Mid(s, 1, 9)
        For j As Integer = 4 To 12 Step 2
            i += Convert.ToInt32(Mid(sConvertN10toN13, j - 1, 1)) + (3 * Convert.ToInt32(Mid(sConvertN10toN13, j, 1)))
        Next

        sConvertN10toN13 = sConvertN10toN13 & ((10 - (i Mod 10)) Mod 10).ToString
        Return sConvertN10toN13
    End Function



    Public Function OneWayEncrypt(clearText As String) As String
        Dim EncryptionKey As String = "{D4151AA2-021F-41C5-8EBD-B5322A182C80}"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                &H65, &H64, &H76, &H65, &H64, &H65,
                &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Function GetCsvData(ByVal strFolderPath As String, ByVal strFileName As String) As DataTable



        Dim strConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFolderPath & ";Extended Properties=Text"
        ' Dim strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFolderPath & ";Extended Properties=""text;HDR=No;FMT=Delimited"";"

        Dim conn As New OleDbConnection(strConnString)

        Try
            conn.Open()

            Dim cmd As New OleDbCommand("SELECT * FROM [" & strFileName & "]", conn)
            Dim da As New OleDbDataAdapter()



            da.SelectCommand = cmd



            Dim ds As New DataSet()


            da.Fill(ds)
            da.Dispose()


            Return ds.Tables(0)
        Catch
            ' Err.Description
            Return Nothing
        Finally
            conn.Close()
        End Try




    End Function
    Public Function CleanLex(sLex As String)

        'Try


        sLex = sLex.Replace("AD", "")
        sLex = sLex.Replace("NC", "")
        sLex = sLex.Replace("HL", "")
        sLex = sLex.Replace("IG", "")
        sLex = sLex.Replace("GN", "")
        sLex = sLex.Replace("BR", "")
        sLex = sLex.Replace("NP", "")
        sLex = sLex.Replace("TBD", "")
        sLex = sLex.Trim

        'Try and catch other issues like dashes and slashes
        If IsNumeric(sLex) = False Then
            sLex = ""
        End If



        Return sLex

    End Function
End Module

