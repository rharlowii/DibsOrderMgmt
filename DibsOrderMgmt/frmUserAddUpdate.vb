Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Public Class frmUserAddUpdate
    Public oUserAccount As Object
    Private moUserAccount As UserAccount


    Private Sub frmUserAddUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Work around the structure public issue
        moUserAccount = oUserAccount

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

            If IsNothing(moUserAccount.RoleID) Then
                .SelectedValue = "2e4030d1-bd1a-451e-b1c8-010caa433bbc"
            Else
                .SelectedValue = moUserAccount.RoleID
            End If
        End With

    End Sub
    Private Sub cmdAddUpdate_Click(sender As Object, e As EventArgs) Handles cmdAddUpdate.Click

        If IsNothing(moUserAccount.ID) Then
            AddNewUser()
        Else
            UpdateExistingUser()
        End If

    End Sub
    Private Sub AddNewUser()
        Dim sFirst As String, sLast As String, sLoginID As String, sPassword As String, sEmail As String, sAPIKey As String, sRoleID As String, sSchoolID As String, sDistrictID As String
        Dim iRtrn As MsgBoxResult
        Dim sReturn As String



        sFirst = txtFirst.Text
        sEmail = txtEmail.Text
        Me.StatusStrip1.Items(0).Text = ""

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
            sReturn = Insert_NewAccount(sFirst, sLast, sLoginID, sPassword, sEmail, sAPIKey, sRoleID, sSchoolID, sDistrictID)

            If sReturn = "1" Then
                Me.StatusStrip1.Items(0).Text = sLoginID & ": succcessfully added. You can add another or close the window."
            End If

        End If
    End Sub
    Private Sub UpdateExistingUser()
        Dim sFirst As String, sLast As String, sLoginID As String, sPassword As String, sEmail As String, sAPIKey As String, sRoleID As String, sSchoolID As String, sDistrictID As String
        Dim iRtrn As MsgBoxResult
        Dim sRtrn As String



        sFirst = txtFirst.Text
        sEmail = txtEmail.Text


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


        If sLoginID <> moUserAccount.LoginID Then 'If LoginID did not change, then you do not need to check
            If IsLoginAlreadyInSchool(sLoginID, sSchoolID) = True Then

                MsgBox(sLoginID & ": is already in the school as a user. You can not change it to this.")
                Exit Sub
            End If
        End If
        '
        'Allow password to only be black if update
        If Len(txtPassword.Text) > 4 Or Len(txtPassword.Text) = 0 Then
            sPassword = txtPassword.Text
        Else
            MsgBox("Password name must be more than 4 characters. Or Leave blank to use the already existing password")
            Exit Sub
        End If

        sRoleID = cmbRole.SelectedValue.ToString



        iRtrn = MessageBox.Show("You are about to the Update the user in a school. Do you wish to continue?", "Update User?", MessageBoxButtons.YesNo)

        If iRtrn = MsgBoxResult.Yes Then
            sRtrn = Update_AxistingAccount(moUserAccount.ID, sFirst, sLast, sLoginID, sPassword, sEmail, sRoleID)
            'sFirst As String, sLast As String, sLoginID As String, sPassword As String, sEmail As String, sRoleID As String
            If sRtrn = "1" Then
                'successfully updated...close
                Me.Close()
            End If
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