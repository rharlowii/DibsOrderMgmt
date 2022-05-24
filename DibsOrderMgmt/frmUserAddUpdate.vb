Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Public Class frmUserAddUpdate

    Private Sub frmUserAddUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoles()

    End Sub
    Private Sub LoadRoles()
        'SELECT SchoolDistricts.State FROM dbo.SchoolDistricts GROUP BY SchoolDistricts.State ORDER BY SchoolDistricts.State


        Dim sSQL As String = "SELECT * FROM Roles ORDER BY Roles.Name"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        oConnection = New SqlConnection(sConnectionString)
        oConnection.Open()
        da = New SqlDataAdapter(sSQL, oConnection)
        da.Fill(ds)
        oConnection.Close()

        With cmbRole
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = ds.Tables(0)
            .SelectedValue = "2e4030d1-bd1a-451e-b1c8-010caa433bbc"

        End With

    End Sub
    Private Sub cmdAddUpdate_Click(sender As Object, e As EventArgs) Handles cmdAddUpdate.Click

        Dim sFirst As String, sLast As String, sLoginID As String, sPassword As String, sEmail As String, sAPIKey As String, sRoleID As String, sSchoolID As String, sDistrictID As String
        Dim iRtrn As MsgBoxResult

        sFirst = txtFirst.Text
        sEmail = txtEmail.Text
        sAPIKey = Guid.NewGuid.ToString

        If Len(txtSchoolID.Text) > 0 Then
            sSchoolID = txtSchoolID.Text
        Else
            MsgBox("You need to select a school.")
            Exit Sub
        End If

        If Len(txtLoginID.Text) > 0 Then
            sDistrictID = txtDistrictID.Text
        Else
            MsgBox("You need to select a District.")
            Exit Sub
        End If





        If Len(txtLast.Text) > 1 Then
            sLast = txtLast.Text
        Else
            MsgBox("Last name must be more than 1 characters.")
            Exit Sub
        End If

        If Len(txtLoginID.Text) > 3 Then
            sLoginID = txtLoginID.Text
        Else
            MsgBox("LoginID must be more than 3 characters.")
            Exit Sub
        End If

        If IsLoginAlreadyInSchool(sLoginID, sSchoolID) = True Then

            MsgBox(sLoginID & ": is already in the school as a user. You can not add it.")
            Exit Sub
        End If
        '

        If Len(txtPassword.Text) > 4 Then
            sPassword = txtPassword.Text
        Else
            MsgBox("Password name must be more than 4 characters.")
            Exit Sub
        End If

        sRoleID = cmbRole.SelectedValue.ToString



        iRtrn = MessageBox.Show("You are about to the create the user in a school. Do you wish to continue?", "Add User?", MessageBoxButtons.YesNo)

        If iRtrn = MsgBoxResult.Yes Then
            Call Insert_NewAccount(sFirst, sLast, sLoginID, sPassword, sEmail, sAPIKey, sRoleID, sSchoolID, sDistrictID)

        End If

    End Sub

    Private Sub txtLoginID_TextChanged(sender As Object, e As EventArgs) Handles txtLoginID.TextChanged

    End Sub

    Private Sub cmdToggleGeneric_Click(sender As Object, e As EventArgs) Handles cmdToggleGeneric.Click

        Select Case txtLoginID.Text
            Case "brainhive"
                txtLoginID.Text = "rourke1"
                txtPassword.Text = "rourke1"
                txtFirst.Text = "Rourke"
            Case "rourke1"
                txtLoginID.Text = "pacific1"
                txtPassword.Text = "pacific1"
                txtFirst.Text = "Pacific"


            Case "pacific1"
                txtLoginID.Text = "crabtree1"
                txtPassword.Text = "crabtree1"
                txtFirst.Text = "Crabtree"

            Case "crabtree1"
                txtLoginID.Text = "dibs1"
                txtPassword.Text = "dibs1"
                txtFirst.Text = "DiBs"

            Case "dibs1"
                txtLoginID.Text = "brainhive"
                txtPassword.Text = "brainhive"
                txtFirst.Text = "Brain Hive"
        End Select
    End Sub
End Class