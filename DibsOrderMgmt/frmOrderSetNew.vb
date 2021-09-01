Public Class frmOrderSetNew
    Public oOrderSet As Object
    Public oOrderSetID As Guid
    Public oOrderID As Guid
    Public bCanceled As Boolean
    Public bUpdateOrderSet As Boolean = False

    Private Sub cmdAddNewOrderSet_Click(sender As Object, e As EventArgs) Handles cmdAddNewOrderSet.Click
        Dim sMsg As String
        Dim moOrderSet As New OrderSet

        sMsg = "'Item Number' must be a number and 'Set Name' can not be blank."

        If txtQTY.Text = "" Or IsNumeric(txtQTY.Text) = False Or txtSetName.Text = "" Then
            MsgBox(sMsg)
            Exit Sub

        End If

        With moOrderSet
            .OrderID = oOrderID.ToString

            If bUpdateOrderSet = True Then
                .OrderSetID = oOrderSetID.ToString
            Else
                .OrderSetID = Guid.NewGuid.ToString

            End If

            .SetName = txtSetName.Text
            .SetDesc = txtSetDesc.Text

            .QTY = txtQTY.Text
            .ListPrice = txtListPrice.Text
            .ExtendedPrice = txtExtendedPrice.Text
        End With


        oOrderSet = moOrderSet
        bCanceled = False
        Me.Close()


    End Sub

    Public Sub UpdateExtendedPrice()
        Dim iQTY As Integer
        Dim oListPrice As Decimal
        Dim oExtendendPrice As Decimal

        If txtQTY.Text = "" Then
            txtQTY.Text = "0"
            iQTY = 0

        Else
            iQTY = txtQTY.Text
        End If

        If txtListPrice.Text = "" Then
            txtListPrice.Text = "0.00"
            oListPrice = 0.00
        Else
            oListPrice = txtListPrice.Text
        End If

        oExtendendPrice = iQTY * oListPrice
        txtExtendedPrice.Text = oExtendendPrice



    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged
        UpdateExtendedPrice()

    End Sub

    Private Sub txtListPrice_TextChanged(sender As Object, e As EventArgs) Handles txtListPrice.TextChanged
        UpdateExtendedPrice()
    End Sub

    Private Sub txtSetName_TextChanged(sender As Object, e As EventArgs) Handles txtSetName.TextChanged

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        bCanceled = True
        Me.Close()

    End Sub
End Class