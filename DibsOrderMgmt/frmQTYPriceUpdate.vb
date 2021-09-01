Public Class frmQTYPriceUpdate
    Public iCurrentQTY As Integer
    Public oCurrentListPrice As Decimal
    Public oCurrentExtendedPrice As Decimal
    Public bCanceled As Boolean = False

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged
        UpdateExtendedPrice()
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


        iCurrentQTY = iQTY
        oCurrentListPrice = oListPrice
        oCurrentExtendedPrice = oExtendendPrice
    End Sub

    Private Sub txtListPrice_TextChanged(sender As Object, e As EventArgs) Handles txtListPrice.TextChanged
        UpdateExtendedPrice()
    End Sub

    Private Sub frmQTYPriceUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtQTY.Text = iCurrentQTY
        txtListPrice.Text = oCurrentListPrice
        txtExtendedPrice.Text = oCurrentExtendedPrice

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        bCanceled = True
        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        bCanceled = False
        Me.Close()
    End Sub
End Class