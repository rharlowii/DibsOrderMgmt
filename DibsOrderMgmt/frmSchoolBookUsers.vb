Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Public Class frmSchoolBookUsers

    Private Sub frmSchoolBookUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStates2()
        LoadDisctricts2()
    End Sub

    Private Sub LoadDisctricts()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString
        sState = cmbStates2.EditValue

        If sState = "" Then
            sSQL = "SELECT * FROM SchoolDistricts Order by Name"
        Else
            sSQL = "SELECT * FROM SchoolDistricts where State='" & sState & "' Order by Name"
        End If
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With cmbDistricts2.Properties
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)


        End With

    End Sub

    Private Sub LoadDisctricts2()

        Dim sSQL As String
        Dim sState As String

        ' sState = cmbStates.SelectedValue.ToString
        sState = cmbStates2.EditValue

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

    Private Sub cmbDistricts2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDistricts2.EditValueChanged
        LoadSchools2()
        txtDistrictID.Text = cmbDistricts2.EditValue.ToString
    End Sub

    Private Sub cmbStates2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbStates2.EditValueChanged
        LoadDisctricts2()
    End Sub

    Private Sub cmbSchools2_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSchools2.EditValueChanged
        txtSchoolID.Text = cmbSchools2.EditValue.ToString
    End Sub

    Private Sub cmdGetSchoolBooks_Click(sender As Object, e As EventArgs) Handles cmdGetSchoolBooks.Click

        Dim sSQL As String = ""
        If cmbSchools2.EditValue.ToString <> "" Then
            'Need to have it so we have an add createtime dateso we can filter by when a book was added
            sSQL = "Select * from BooksInASchool2 where SChoolID='" & cmbSchools2.EditValue.ToString & "'"
        Else
            MsgBox("You must select a School!", MsgBoxStyle.OkOnly, "Select a School")
            Exit Sub

        End If

        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim iCount As Integer

        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        gridSchoolBooks.DataSource = ds.Tables(0)
    End Sub
End Class