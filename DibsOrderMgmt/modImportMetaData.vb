Imports System.Collections
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Text.RegularExpressions

Module modImportMetaData
    Public Const EMPTYCOLName As String = "EMPTYCOL"
    Public CurrentPartnerID As Integer
    Public Class omMetaData
        Public MetaDataID As Guid
        Public PartnerID As Integer
        Public Partner As String
        Public PublisherName As String
        Public Title As String
        Public SubTitle As String
        Public Page_Count As Integer
        Public Paperback_ISBN_13 As String
        Public Paperback_List_Price As Decimal
        Public Classification As String
        Public Guided_Reading_Level As String
        Public Lexile_Number As Integer
        Public Lexile_Text As String
        Public ATOS As Decimal
        Public Hardcover_Print_ISBN_13 As String
        Public Hardcover_Print_List_Price As Decimal
        Public eBook_ISBN_13 As String
        Public eBook_List_Price As Decimal
        Public Imprint As String
        Public Language As String
        Public Age_Level_Start As Integer
        Public Age_Level_End As Integer
        Public Interest_Level_Start As Integer
        Public Interest_Level_End As Integer
        Public Reading_Level_Start As Integer
        Public Reading_Level_End As Integer
        Public Dewey As String
        Public BISAC_1 As String
        Public BISAC_2 As String
        Public BISAC_3 As String
        Public Grade_Level As String
        Public Author_First_Name1 As String
        Public Author_Middle_Name1 As String
        Public Author_Last_Name1 As String
        Public Copyright As Integer
        Public Series_Name As String
        Public Series_Description As String
        Public Genre_Interest As String
        Public Subject As String
        Public Keywords As String
        Public TitleDescription As String

        Public Sub New()

        End Sub
    End Class

    Public Class omMetaDataColumnMappingNames
        Public MetaDataMappingsID As Integer
        Public MappingName As String
        Public PartnerCol As String
        Public PublisherNameCol As String
        Public TitleCol As String
        Public SubTitleCol As String
        Public Page_CountCol As String
        Public Paperback_ISBN_13Col As String
        Public Paperback_List_PriceCol As String
        Public ClassificationCol As String
        Public Guided_Reading_LevelCol As String
        Public Lexile_NumberCol As String
        Public Lexile_TextCol As String
        Public ATOSCol As String
        Public Hardcover_Print_ISBN_13Col As String
        Public Hardcover_Print_List_PriceCol As String
        Public eBook_ISBN_13Col As String
        Public eBook_List_PriceCol As String
        Public ImprintCol As String
        Public LanguageCol As String
        Public Age_Level_StartCol As String
        Public Age_Level_EndCol As String
        Public Interest_Level_StartCol As String
        Public Interest_Level_EndCol As String
        Public Reading_Level_StartCol As String
        Public Reading_Level_EndCol As String
        Public DeweyCol As String
        Public BISAC_1Col As String
        Public BISAC_2Col As String
        Public BISAC_3Col As String
        Public Grade_LevelCol As String
        Public Author_First_Name1Col As String
        Public Author_Middle_Name1Col As String
        Public Author_Last_Name1Col As String
        Public CopyrightCol As String
        Public Series_NameCol As String
        Public Series_DescriptionCol As String
        Public Genre_InterestCol As String
        Public SubjectCol As String
        Public KeywordsCol As String
        Public TitleDescriptionCol As String


        Public Sub New()

        End Sub

        Public Sub SetColumnNames(iMetaDataMappingsID As Integer)
            Dim sSQL As String

            sSQL = "SELECT * FROM omMetaDataMappings where MetaDataMappingsID=" & iMetaDataMappingsID


            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            oConnection = New SqlConnection(sConnectionString)
            oConnection.Open()
            da = New SqlDataAdapter(sSQL, oConnection)
            da.Fill(ds)
            oConnection.Close()

            With ds.Tables(0).Rows(0)
                MetaDataMappingsID = GetColName(.Item("MetaDataMappingsID"))

                MappingName = GetColName(.Item("MappingName").ToString)
                PartnerCol = .Item("PartnerCol")
                PublisherNameCol = .Item("PublisherNameCol")
                TitleCol = .Item("TitleCol")

                SubTitleCol = GetColName(.Item("SubTitleCol").ToString)

                Page_CountCol = GetColName(.Item("Page_CountCol").ToString)
                Paperback_ISBN_13Col = GetColName(.Item("Paperback_ISBN_13Col").ToString)
                Paperback_List_PriceCol = GetColName(.Item("Paperback_List_PriceCol").ToString)
                ClassificationCol = GetColName(.Item("ClassificationCol").ToString)
                Guided_Reading_LevelCol = GetColName(.Item("Guided_Reading_LevelCol").ToString)
                Lexile_NumberCol = GetColName(.Item("Lexile_NumberCol").ToString)
                Lexile_TextCol = GetColName(.Item("Lexile_TextCol").ToString)
                ATOSCol = GetColName(.Item("ATOSCol").ToString)
                Hardcover_Print_ISBN_13Col = GetColName(.Item("Hardcover_Print_ISBN_13Col").ToString)
                Hardcover_Print_List_PriceCol = GetColName(.Item("Hardcover_Print_List_PriceCol").ToString)
                eBook_ISBN_13Col = GetColName(.Item("eBook_ISBN_13Col").ToString)
                eBook_List_PriceCol = GetColName(.Item("eBook_List_PriceCol").ToString)
                ImprintCol = GetColName(.Item("ImprintCol").ToString)
                LanguageCol = GetColName(.Item("LanguageCol").ToString)
                Age_Level_StartCol = GetColName(.Item("Age_Level_StartCol").ToString)
                Age_Level_EndCol = GetColName(.Item("Age_Level_EndCol").ToString)
                Interest_Level_StartCol = GetColName(.Item("Interest_Level_StartCol").ToString)
                Interest_Level_EndCol = GetColName(.Item("Interest_Level_EndCol").ToString)
                Reading_Level_StartCol = GetColName(.Item("Reading_Level_StartCol").ToString)
                Reading_Level_EndCol = GetColName(.Item("Reading_Level_EndCol").ToString)
                DeweyCol = GetColName(.Item("DeweyCol").ToString)
                BISAC_1Col = GetColName(.Item("BISAC_1Col").ToString)
                BISAC_2Col = GetColName(.Item("BISAC_2Col").ToString)
                BISAC_3Col = GetColName(.Item("BISAC_3Col").ToString)
                Grade_LevelCol = GetColName(.Item("Grade_LevelCol").ToString)
                Author_First_Name1Col = GetColName(.Item("Author_First_Name1Col").ToString)
                Author_Middle_Name1Col = GetColName(.Item("Author_Middle_Name1Col").ToString)
                Author_Last_Name1Col = GetColName(.Item("Author_Last_Name1Col").ToString)
                CopyrightCol = GetColName(.Item("CopyrightCol").ToString)
                Series_NameCol = GetColName(.Item("Series_NameCol").ToString)
                Series_DescriptionCol = GetColName(.Item("Series_DescriptionCol").ToString)
                Genre_InterestCol = GetColName(.Item("Genre_InterestCol").ToString)
                SubjectCol = GetColName(.Item("SubjectCol").ToString)
                KeywordsCol = GetColName(.Item("KeywordsCol").ToString)
                TitleDescriptionCol = GetColName(.Item("TitleDescriptionCol").ToString)
            End With

        End Sub

    End Class

    Public Function LoadomMetdata(oDataTable As DataTable, omColumnNames As omMetaDataColumnMappingNames) As List(Of omMetaData)
        Dim oMetaLists As New List(Of omMetaData)
        Dim oRow As DataRow
        Dim oCol As Object
        Dim item As Object
        Dim oMetaRow As omMetaData
        '  omColumnNames.
        '  Dim oCols() As String = omColumnNames.GetType().GetEnumNames().ToArray



        For Each oRow In oDataTable.Rows
            'For Each oColin In omColumnNames.
            oMetaRow = New omMetaData

            oMetaRow.PartnerID = CurrentPartnerID
            SetMetaRow(oRow, oMetaRow, omColumnNames)
            'Next
            oMetaLists.Add(oMetaRow)
        Next

        Return oMetaLists

    End Function
    Private Sub SetMetaRow(ByRef oRow As DataRow, ByRef oMetaRow As omMetaData, oColName As omMetaDataColumnMappingNames)

        With oColName
            'oMetaRow.PartnerID = oRow.Item(c)
            oMetaRow.Partner = oRow.Item(.PartnerCol).ToString
            oMetaRow.PublisherName = oRow.Item(.PublisherNameCol).ToString
            oMetaRow.Title = oRow.Item(.TitleCol).ToString

            If .SubTitleCol <> EMPTYCOLName Then
                oMetaRow.SubTitle = oRow.Item(.SubTitleCol).ToString
            Else
                oMetaRow.SubTitle = ""
            End If


            oMetaRow.Paperback_ISBN_13 = GetISBN(oRow.Item(.Paperback_ISBN_13Col).ToString)

            If .Paperback_List_PriceCol <> EMPTYCOLName Then
                oMetaRow.Paperback_List_Price = GetPrice(GetColName(oRow.Item(.Paperback_List_PriceCol).ToString))
            Else
                oMetaRow.Paperback_List_Price = 0.00
            End If


            If .ClassificationCol <> EMPTYCOLName Then
                oMetaRow.Classification = GetClassification(oRow.Item(.ClassificationCol).ToString)
            Else

                If .BISAC_1Col <> EMPTYCOLName Then
                    oMetaRow.Classification = GetClassificationFromBISAC1(oRow.Item(.BISAC_1Col).ToString)
                Else

                    oMetaRow.Classification = ""
                End If

            End If


            If .Guided_Reading_LevelCol <> EMPTYCOLName Then
                oMetaRow.Guided_Reading_Level = GetGuidedReadingLevel(oRow.Item(.Guided_Reading_LevelCol).ToString)
            Else
                oMetaRow.Guided_Reading_Level = ""
            End If

            If .Lexile_NumberCol <> EMPTYCOLName Then
                oMetaRow.Lexile_Number = GetLexileNumber(oRow.Item(.Lexile_NumberCol).ToString)
            Else
                oMetaRow.Lexile_Number = -5000
            End If

            If .Lexile_NumberCol <> EMPTYCOLName Then
                oMetaRow.Lexile_Text = GetLexileText(oRow.Item(.Lexile_TextCol).ToString)
            Else
                oMetaRow.Lexile_Text = ""
            End If


            If .ATOSCol <> EMPTYCOLName Then
                oMetaRow.ATOS = GetATOS(oRow.Item(.ATOSCol).ToString)
            Else
                oMetaRow.ATOS = -5000
            End If


            If .Hardcover_Print_ISBN_13Col <> EMPTYCOLName Then
                oMetaRow.Hardcover_Print_ISBN_13 = GetISBN(oRow.Item(.Hardcover_Print_ISBN_13Col).ToString)
            Else
                oMetaRow.Hardcover_Print_ISBN_13 = ""
            End If

            If .Hardcover_Print_List_PriceCol <> EMPTYCOLName Then
                oMetaRow.Hardcover_Print_List_Price = GetPrice(oRow.Item(.Hardcover_Print_List_PriceCol).ToString)
            Else
                oMetaRow.Hardcover_Print_List_Price = 0.00
            End If

            If .eBook_ISBN_13Col <> EMPTYCOLName Then
                oMetaRow.eBook_ISBN_13 = GetISBN(oRow.Item(.eBook_ISBN_13Col).ToString)
            Else
                oMetaRow.eBook_ISBN_13 = ""
            End If

            If .eBook_List_PriceCol <> EMPTYCOLName Then
                oMetaRow.eBook_List_Price = GetPrice(oRow.Item(.eBook_List_PriceCol).ToString)
            Else
                oMetaRow.eBook_List_Price = 0.00
            End If


            If .ImprintCol <> EMPTYCOLName Then
                oMetaRow.Imprint = oRow.Item(.ImprintCol).ToString
            Else
                oMetaRow.Imprint = ""
            End If

            If .LanguageCol <> EMPTYCOLName Then
                oMetaRow.Language = GetLangauage(oRow.Item(.LanguageCol).ToString)
            Else
                oMetaRow.Language = ""
            End If


            If .Page_CountCol <> EMPTYCOLName Then
                oMetaRow.Page_Count = GetPageCount(oRow.Item(.Page_CountCol).ToString)
            Else
                oMetaRow.Page_Count = -1
            End If


            If .Age_Level_StartCol <> EMPTYCOLName Then
                oMetaRow.Age_Level_Start = GetInterestLevel(oRow.Item(.Age_Level_StartCol).ToString, True)
            Else
                oMetaRow.Age_Level_Start = -5000
            End If


            If .Age_Level_EndCol <> EMPTYCOLName Then
                oMetaRow.Age_Level_End = GetInterestLevel(oRow.Item(.Age_Level_EndCol).ToString, False)
            Else
                oMetaRow.Age_Level_End = -5000
            End If


            If .Interest_Level_StartCol <> EMPTYCOLName Then
                oMetaRow.Interest_Level_Start = GetInterestLevel(oRow.Item(.Interest_Level_StartCol).ToString, True)
            Else
                oMetaRow.Interest_Level_Start = -5000
            End If



            If .Interest_Level_EndCol <> EMPTYCOLName Then
                oMetaRow.Interest_Level_End = GetInterestLevel(oRow.Item(.Interest_Level_EndCol).ToString, False)
            Else
                oMetaRow.Interest_Level_End = -5000
            End If


            If .Reading_Level_StartCol <> EMPTYCOLName Then
                oMetaRow.Reading_Level_Start = GetInterestLevel(oRow.Item(.Reading_Level_StartCol).ToString, True)
            Else
                oMetaRow.Reading_Level_Start = -5000
            End If

            If .Reading_Level_EndCol <> EMPTYCOLName Then
                oMetaRow.Reading_Level_End = GetInterestLevel(oRow.Item(.Reading_Level_EndCol).ToString, False)
            Else
                oMetaRow.Reading_Level_End = -5000
            End If


            If .DeweyCol <> EMPTYCOLName Then
                oMetaRow.Dewey = oRow.Item(.DeweyCol).ToString
            Else
                oMetaRow.Dewey = ""
            End If


            If .BISAC_1Col <> EMPTYCOLName Then
                oMetaRow.BISAC_1 = oRow.Item(.BISAC_1Col).ToString
            Else
                oMetaRow.BISAC_1 = ""
            End If

            If .BISAC_2Col <> EMPTYCOLName Then
                oMetaRow.BISAC_2 = oRow.Item(.BISAC_2Col).ToString
            Else
                oMetaRow.BISAC_2 = ""
            End If
            If .BISAC_3Col <> EMPTYCOLName Then
                oMetaRow.BISAC_3 = oRow.Item(.BISAC_3Col).ToString
            Else
                oMetaRow.BISAC_3 = ""
            End If


            If .Grade_LevelCol <> EMPTYCOLName Then
                oMetaRow.Grade_Level = oRow.Item(.Grade_LevelCol).ToString
            Else
                oMetaRow.Grade_Level = ""
            End If



            If .Author_First_Name1Col <> EMPTYCOLName Then
                oMetaRow.Author_First_Name1 = oRow.Item(.Author_First_Name1Col).ToString
            Else
                oMetaRow.Author_First_Name1 = ""
            End If

            If .Author_Middle_Name1Col <> EMPTYCOLName Then
                oMetaRow.Author_Middle_Name1 = oRow.Item(.Author_Middle_Name1Col).ToString
            Else
                oMetaRow.Author_Middle_Name1 = ""
            End If

            If .Author_Last_Name1Col <> EMPTYCOLName Then
                oMetaRow.Author_Last_Name1 = oRow.Item(.Author_Last_Name1Col).ToString
            Else
                oMetaRow.Author_Last_Name1 = ""
            End If



            If .CopyrightCol <> EMPTYCOLName Then
                oMetaRow.Copyright = GetCopyRight(oRow.Item(.CopyrightCol).ToString)
            Else
                oMetaRow.Copyright = -5000
            End If



            If .Series_NameCol <> EMPTYCOLName Then
                oMetaRow.Series_Name = oRow.Item(.Series_NameCol).ToString
            Else
                oMetaRow.Series_Name = ""
            End If

            If .Series_DescriptionCol <> EMPTYCOLName Then
                oMetaRow.Series_Description = oRow.Item(.Series_DescriptionCol).ToString
            Else
                oMetaRow.Series_Description = ""
            End If

            If .Genre_InterestCol <> EMPTYCOLName Then
                oMetaRow.Genre_Interest = oRow.Item(.Genre_InterestCol).ToString
            Else
                oMetaRow.Genre_Interest = ""
            End If

            If .SubjectCol <> EMPTYCOLName Then
                oMetaRow.Subject = oRow.Item(.SubjectCol).ToString
            Else
                oMetaRow.Subject = ""
            End If

            If .KeywordsCol <> EMPTYCOLName Then
                oMetaRow.Keywords = oRow.Item(.KeywordsCol).ToString
            Else
                oMetaRow.Keywords = ""
            End If


            If .TitleDescriptionCol <> EMPTYCOLName Then
                oMetaRow.TitleDescription = oRow.Item(.TitleDescriptionCol).ToString
            Else
                oMetaRow.TitleDescription = ""
            End If
        End With




    End Sub

    Private Function GetLexileNumber(sLexile As String) As Integer
        Dim resultString As String
        resultString = ""


        If sLexile <> "" Then
            resultString = Regex.Match(sLexile, "\d+").Value

            If resultString = "" Then
                resultString = -5000
            End If
        Else
            resultString = -5000
        End If

        Return resultString

    End Function
    Private Function GetLexileText(sLexile As String) As String
        Dim resultString As String
        Dim sLexileText As String

        sLexileText = ""

        If sLexile.Contains("-") Then
            sLexileText = ""
            Return sLexileText
        End If
        If sLexile <> "" Then
            resultString = Regex.Match(sLexile, "\d+").Value
            If resultString <> "" Then
                sLexileText = sLexile.Replace(resultString, "")
            Else
                sLexileText = ""
            End If

        Else
            resultString = ""
            sLexileText = ""
        End If



        Return sLexileText


    End Function
    Private Function GetATOS(sATOS As String) As Decimal
        Dim resultString As String
        Dim sLexileText As String
        Dim iDecimal As Decimal
        resultString = ""



        resultString = Regex.Match(sATOS, "[0-9]\d{0,9}(\.\d{1,3})?%?$").Value


        If resultString = "" Then
            iDecimal = -5000
        Else
            iDecimal = resultString
        End If

        Return iDecimal


    End Function
    Private Function GetPrice(sPrice As String) As Decimal
        Dim resultString As String


        resultString = ""

        If sPrice <> "" Then
            resultString = sPrice
        Else
            resultString = "0.00"

        End If



        Return resultString


    End Function

    Private Function GetLangauage(sLanguage As String) As String

        If sLanguage <> "" Then
            Select Case sLanguage.ToLower

                Case ""
                    Return ""
                Case "ENG", "eng"
                    Return "English"
                Case "SPAN", "Spa"
                    Return "Spanish"
                Case "FRE", "fre"
                    Return "French"
                Case Else
                    Return sLanguage



            End Select
        Else
            Return sLanguage
        End If

    End Function
    Private Function GetISBN(sISBN As String) As String
        Dim sReturn As String

        sReturn = RemoveHyphens(sISBN)

        Return sReturn
    End Function
    Private Function GetPageCount(sPageCount As String) As Integer
        Dim iReturn As Integer
        Dim sTemp As String



        If sPageCount <> "" Then

            If IsNumeric(sPageCount) = False Then
                sTemp = Regex.Match(sPageCount, "\d+").Value

                sPageCount = sTemp
            End If

            iReturn = sPageCount
        Else
            iReturn = 0
        End If

        Return iReturn
    End Function

    Private Function GetCopyRight(sCopyRight As String) As Integer
        Dim iReturn As Integer
        If IsNumeric(sCopyRight) = False Then

            If IsDate(sCopyRight) = False Then

                iReturn = -5000
            Else
                iReturn = Year(sCopyRight)
            End If

        Else
            If sCopyRight <> "" Then
                iReturn = sCopyRight
            Else
                iReturn = -1000
            End If

        End If


        Return iReturn
    End Function
    Public Function RemoveHyphens(sText As String) As String
        RemoveHyphens = sText.Replace("-", "")

    End Function

    Private Function GetGuidedReadingLevel(sGuidedReadingLevel As String) As String

        Dim sReturn As String

        Dim iLength As Integer

        If IsNothing(sGuidedReadingLevel) Then
            Return ""
        End If
        iLength = sGuidedReadingLevel.Length
        sReturn = ""

        Select Case iLength
            Case 0
                sReturn = ""
            Case 1
                If IsNumeric(sGuidedReadingLevel) Then
                    sReturn = ""
                Else
                    sReturn = sGuidedReadingLevel
                End If
            Case Else
                sReturn = ""
        End Select

        Return sReturn
    End Function
    Private Function GetClassification(sClassification As String) As String
        Dim sReturn As String

        If IsNothing(sClassification) Then
            sReturn = ""
        End If
        Select Case sClassification
            Case ""
                sReturn = ""
            Case "F", "Fiction", "F/N"
                sReturn = "F"
            Case "NF", "Non-Fiction", "NonFiction", "Nonfiction"
                sReturn = "NF"

            Case Else
                MsgBox("Fiction/NF case")
                sReturn = ""
        End Select


        Return sReturn

    End Function

    Private Function GetClassificationFromBISAC1(sBISAC1 As String) As String
        Dim sReturn As String
        Dim sFirst3 As String

        If IsNothing(sBISAC1) Then
            Return sBISAC1
        End If

        If sBISAC1.Length > 3 Then
            sFirst3 = Left(sBISAC1, 3)

            Select Case sFirst3
                Case "JUV"
                    Return "F"
                Case "JNF"
                    Return "NF"
                Case Else
                    Return ""
            End Select
        Else
            Return ""
        End If






    End Function
    Private Function GetInterestLevel(sInterestLevel As String, bStart As Boolean) As Integer
        Dim resultString As Integer
        Dim sSplitValue As String

        Dim iPosition As Integer

        resultString = -5000
        sInterestLevel = Trim(sInterestLevel)
        If sInterestLevel.Contains("-") Then
            'This an overloaded field with a range, lets try and split
            iPosition = sInterestLevel.IndexOf("-")
            If bStart = True Then

                sSplitValue = Trim(sInterestLevel.Substring(0, iPosition))
            Else
                sSplitValue = Trim(sInterestLevel.Substring(iPosition + 1))
            End If
            sInterestLevel = Trim(sSplitValue)
        End If

        If sSplitValue <> "" Then
            sSplitValue = Regex.Match(sSplitValue, "\d+").Value
            If sSplitValue <> "" Then
                sInterestLevel = sSplitValue
            Else
                sInterestLevel = ""
            End If

        Else
            resultString = -5000
            sInterestLevel = ""
        End If

        Select Case sInterestLevel
            Case ""
                resultString = -5000
            Case "Pre-K", "PK", "PreK"
                resultString = -1
            Case "K", "Kindergarten"
                resultString = 0
            Case Else
                resultString = sInterestLevel
        End Select

        Return resultString

    End Function

    Private Function GetColName(sColName As String) As String
        Dim sName As String

        If String.IsNullOrEmpty(sColName) = True Then
            sName = EMPTYCOLName

        Else
            sName = Trim(sColName)
        End If

        Return sName

    End Function
    Private Function SetNullIfNeeded(iIntegerValue As Object) As Object

        If iIntegerValue = -5000 Then

            Return System.DBNull.Value
        Else
            Return iIntegerValue

        End If
    End Function
    Public Function InsertNewomMetaData(omMeta As omMetaData)


        Dim sEXEC As String = "omMetaData_IU @MetaDataID,@PartnerID,@Partner,@PublisherName,@Title,@SubTitle,@Paperback_ISBN_13,@Paperback_List_Price,@Classification,@Guided_Reading_Level,@Lexile_Number,@Lexile_Text" &
            ",@ATOS,@Hardcover_Print_ISBN_13,@Hardcover_Print_List_Price,@eBook_ISBN_13,@eBook_List_Price,@Imprint,@Language," &
            "@Page_Count,@Age_Level_Start,@Age_Level_End,@Interest_Level_Start,@Interest_Level_End,@Reading_Level_Start,@Reading_Level_End," &
            "@Dewey,@BISAC_1,@BISAC_2,@BISAC_3,@Grade_Level,@Author_First_Name1,@Author_Middle_Name1,@Author_Last_Name1,@Copyright," &
            "@Series_Name,@Series_Description,@Genre_Interest,@Subject,@Keywords,@TitleDescription"

        Dim sReturn As String

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        Dim myCommand As New SqlCommand(sEXEC, oConnection)

        With myCommand
            .Parameters.Add("@MetaDataID", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid
            .Parameters.Add("@PartnerID", SqlDbType.Int).Value = omMeta.PartnerID
            .Parameters.Add("@Partner", SqlDbType.NVarChar).Value = omMeta.Partner
            .Parameters.Add("@PublisherName", SqlDbType.NVarChar).Value = omMeta.PublisherName
            .Parameters.Add("@Title", SqlDbType.NVarChar).Value = omMeta.Title
            .Parameters.Add("@SubTitle", SqlDbType.NVarChar).Value = omMeta.SubTitle
            .Parameters.Add("@Paperback_ISBN_13", SqlDbType.NVarChar).Value = omMeta.Paperback_ISBN_13
            .Parameters.Add("@Paperback_List_Price", SqlDbType.Decimal).Value = omMeta.Paperback_List_Price

            .Parameters.Add("@Classification", SqlDbType.NVarChar).Value = omMeta.Classification


            .Parameters.Add("@Guided_Reading_Level", SqlDbType.NVarChar).Value = omMeta.Guided_Reading_Level
            .Parameters.Add("@Lexile_Number", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Lexile_Number)
            .Parameters.Add("@Lexile_Text", SqlDbType.NVarChar).Value = omMeta.Lexile_Text
            .Parameters.Add("@ATOS", SqlDbType.Decimal).Value = SetNullIfNeeded(omMeta.ATOS)

            .Parameters.Add("@Hardcover_Print_ISBN_13", SqlDbType.NVarChar).Value = omMeta.Hardcover_Print_ISBN_13
            .Parameters.Add("@Hardcover_Print_List_Price", SqlDbType.Decimal).Value = omMeta.Hardcover_Print_List_Price
            .Parameters.Add("@eBook_ISBN_13", SqlDbType.NVarChar).Value = omMeta.eBook_ISBN_13
            .Parameters.Add("@eBook_List_Price", SqlDbType.Decimal).Value = omMeta.eBook_List_Price

            .Parameters.Add("@Imprint", SqlDbType.NVarChar).Value = omMeta.Imprint
            .Parameters.Add("@Language", SqlDbType.NVarChar).Value = omMeta.Language
            .Parameters.Add("@Page_Count", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Page_Count)

            .Parameters.Add("@Age_Level_Start", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Age_Level_Start)
            .Parameters.Add("@Age_Level_End", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Age_Level_End)

            .Parameters.Add("@Interest_Level_Start", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Interest_Level_Start)
            .Parameters.Add("@Interest_Level_End", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Interest_Level_End)

            .Parameters.Add("@Reading_Level_Start", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Reading_Level_Start)
            .Parameters.Add("@Reading_Level_End", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Reading_Level_End)

            .Parameters.Add("@Dewey", SqlDbType.NVarChar).Value = omMeta.Dewey
            .Parameters.Add("@BISAC_1", SqlDbType.NVarChar).Value = omMeta.BISAC_1
            .Parameters.Add("@BISAC_2", SqlDbType.NVarChar).Value = omMeta.BISAC_2
            .Parameters.Add("@BISAC_3", SqlDbType.NVarChar).Value = omMeta.BISAC_3

            .Parameters.Add("@Grade_Level", SqlDbType.NVarChar).Value = omMeta.Grade_Level
            .Parameters.Add("@Author_First_Name1", SqlDbType.NVarChar).Value = omMeta.Author_First_Name1
            .Parameters.Add("@Author_Middle_Name1", SqlDbType.NVarChar).Value = omMeta.Author_Middle_Name1
            .Parameters.Add("@Author_Last_Name1", SqlDbType.NVarChar).Value = omMeta.Author_Last_Name1

            .Parameters.Add("@Copyright", SqlDbType.Int).Value = SetNullIfNeeded(omMeta.Copyright)
            .Parameters.Add("@Series_Name", SqlDbType.NVarChar).Value = omMeta.Series_Name
            .Parameters.Add("@Series_Description", SqlDbType.NVarChar).Value = omMeta.Series_Description
            .Parameters.Add("@Genre_Interest", SqlDbType.NVarChar).Value = omMeta.Genre_Interest

            .Parameters.Add("@Subject", SqlDbType.NVarChar).Value = omMeta.Subject
            .Parameters.Add("@Keywords", SqlDbType.NVarChar).Value = omMeta.Keywords
            .Parameters.Add("@TitleDescription", SqlDbType.NVarChar).Value = omMeta.TitleDescription


            sReturn = .ExecuteNonQuery
        End With





        oConnection.Close()
        Return sReturn
        'sqlStr = "update YourTable Set Columns = @Columns WHERE Column =      '" & detgrd(detgrd.Row, 0).ToString().ToUpper().Trim() & "' "

    End Function

End Module
