Public Class frmOrderItemSub
    'Hack to get around the structure can not be public
    Private moCurrentOrderItem As OrderItem
    Private moNewOrderItem As OrderItem
    Public oCurrentOrderItem As Object
    Public oNewOrderItem As Object

    Public bCanceled As Boolean = False
    Private Sub frmOrderItemSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hack to get around the structure can not be public
        moCurrentOrderItem = oCurrentOrderItem
        moNewOrderItem = oCurrentOrderItem

        With moCurrentOrderItem
            txt_ItemNumber.Text = .ItemNumberISBN
            txt_ItemDesc.Text = .ItemDesc
            txt_QTY.Text = .QTY
            txt_ListPrice.Text = .ListPrice
            txt_ExtendedPrice.Text = .ExtendedPrice

            'Set the Totals....they may or may not change
            txt_NewQTY.Text = .QTY

        End With

    End Sub

    Public Sub UpdateExtendedPrice()
        Dim iQTY As Integer
        Dim oListPrice As Decimal
        Dim oExtendendPrice As Decimal

        If txt_NewQTY.Text = "" Then
            txt_NewQTY.Text = "0"
            iQTY = 0

        Else
            iQTY = txt_NewQTY.Text
        End If

        If txt_NewListPrice.Text = "" Then
            txt_NewListPrice.Text = "0.00"
            oListPrice = 0.00
        Else
            oListPrice = txt_NewListPrice.Text
        End If

        oExtendendPrice = iQTY * oListPrice
        txt_NewExtendedPrice.Text = oExtendendPrice

    End Sub

    Private Sub txt_NewQTY_TextChanged(sender As Object, e As EventArgs) Handles txt_NewQTY.TextChanged
        UpdateExtendedPrice()

    End Sub

    Private Sub txt_NewListPrice_TextChanged(sender As Object, e As EventArgs) Handles txt_NewListPrice.TextChanged
        UpdateExtendedPrice()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        With moNewOrderItem
            .ItemNumberISBN = txt_NewItemNumber.Text
            .ItemDesc = txt_NewItemDesc.Text
            .QTY = txt_NewQTY.Text
            .ListPrice = txt_NewListPrice.Text
            .ExtendedPrice = txt_NewExtendedPrice.Text

            'Set the Totals....they may or may not change
            .QTY = txt_NewQTY.Text

            If .ItemNumberISBN.Length = 0 Or .ItemDesc.Length = 0 Or .QTY = 0 Or .ListPrice = 0 Then
                MsgBox("Must enter a Item Number, Description, QTY & Price")
                Exit Sub

            End If

        End With

        oNewOrderItem = moNewOrderItem

        bCanceled = False
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        bCanceled = True
        Me.Close()
    End Sub
End Class