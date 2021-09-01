﻿Imports DevExpress.XtraEditors.BaseCheckedListBoxControl
Public Class frmOrderPublishersSelect
    Public oOrderID As Guid
    Public oOrderPartners As DataTable
    Public bCanceled As Boolean = False
    Public oPartnersSelected As New List(Of DataRowView)



    Private Sub frmOrderPublishersSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With CheckedListBoxControl1
            .ValueMember = "PartnerID"
            .DisplayMember = "PublisherShortName"
            .DataSource = oOrderPartners
            .CheckAll()
        End With


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        bCanceled = True
        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        bCanceled = False
        Dim oItem As DataRowView




        For Each oItem In CheckedListBoxControl1.CheckedItems

            oPartnersSelected.Add(oItem)
        Next

        Me.Close()
    End Sub
End Class