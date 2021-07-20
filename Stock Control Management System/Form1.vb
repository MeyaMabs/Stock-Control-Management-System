﻿Public Class Form1
    Private btnExit As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("Master Card")
        cmbPaymentMethod.Items.Add("Visa Card")
        cmbPaymentMethod.Items.Add("Visa Debit Cash")

        cmbAccountType.Items.Add("Credit Account")
        cmbAccountType.Items.Add("Debit Account")
        cmbAccountType.Items.Add("Commercial Account")
        cmbAccountType.Items.Add("Online Order")
        cmbAccountType.Items.Add("Customer Account")

        cmbVAT.Items.Add("Yes")


        cmbProductName.Items.Add("Rice")
        cmbProductName.Items.Add("Beans")
        cmbProductName.Items.Add("Carrot")
        cmbProductName.Items.Add("Bread")
        cmbProductName.Items.Add("Eggs")

        cmbNoSale.Items.Add("Yes")
        cmbNoSale.Items.Add("No")

        For q = 18 To 28
            cmbOrderID.Items.Add("OrID" & q)
            cmbCustomerID.Items.Add("CID002" & q)


        Next

        For d = 0 To 25 Step 5

            cmbDiscount.Items.Add(d)

        Next


    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("comfirm if you want to exit", "Stock Control", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If iExit = DialogResult.Yes Then

        End If
        Application.Exit()

    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductName.SelectedIndexChanged
        If cmbProductName.Text = "Rice" Then
            txtProductID.Text = "PIDOO1"
            txtDescription.Text = "White Seed"
            txtStockLevel.Text = "200"
            lblReOrderLevel.Text = "50"
            lblOutofStock.Text = "2"
            txtCost.Text = "20"
        ElseIf cmbProductName.Text = "Beans" Then
            txtProductID.Text = "PIDO12"
            txtDescription.Text = "White Seed eye"
            txtStockLevel.Text = "120"
            lblReOrderLevel.Text = "10"
            lblOutofStock.Text = "2"
            txtCost.Text = "17"
        ElseIf cmbProductName.Text = "Carrot" Then
            txtProductID.Text = "PIDO13"
            txtDescription.Text = "Vegetable"
            txtStockLevel.Text = "150"
            lblReOrderLevel.Text = "15"
            lblOutofStock.Text = "2"
            txtCost.Text = "3"
        ElseIf cmbProductName.Text = "Bread" Then
            txtProductID.Text = "PIDO14"
            txtDescription.Text = "Flour/ Grain"
            lblReOrderLevel.Text = "400"
            lblReOrderLevel.Text = "100"
            lblOutofStock.Text = "2"
            txtCost.Text = "1.5"
        ElseIf cmbProductName.Text = "Eggs" Then
            txtProductID.Text = "PIDO15"
            txtDescription.Text = "Poultry"
            txtStockLevel.Text = "500"
            lblReOrderLevel.Text = "150"
            lblOutofStock.Text = "2"
            txtCost.Text = "1.34"

        End If
    End Sub


    Private Sub txtNoOrder_TextChanged(sender As Object, e As EventArgs) Handles txtNoOrder.TextChanged
        lblNoItemOrder.Text = txtNoOrder.Text

        lblReminder.Text = Val(txtStockLevel.Text) - Val(txtNoOrder.Text)

        If (lblReminder.Text <= 2) Then
            lblAction.Text = "Order more product "
        Else
            lblAction.Text = "No order requested "
        End If

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim iTax As Decimal

        If cmbDiscount.Text = 0 Then



            iTax = ((Val(txtCost.Text) * Val(txtNoOrder.Text) * 7.5) / 100)

            lblTax.Text = iTax
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text)


            lblTotal.Text = (Val(lblSubTotal.Text) + (iTax))

        ElseIf cmbDiscount.Text = 5 Then
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text) - (((Val(txtCost.Text) * Val(txtNoOrder.Text)) * 5) / 100)
            iTax = ((Val(lblSubTotal.Text) * 7.5) / 100)
            lblTax.Text = iTax
            lblTotal.Text = (Val(lblSubTotal.Text) + (iTax))

        ElseIf cmbDiscount.Text = 10 Then
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text) - (((Val(txtCost.Text) * Val(txtNoOrder.Text)) * 10) / 100)
            iTax = ((Val(lblSubTotal.Text) * 7.5) / 100)
            lblTax.Text = iTax
            lblTotal.Text = (Val(lblSubTotal.Text) + (iTax))

        ElseIf cmbDiscount.Text = 15 Then
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text) - (((Val(txtCost.Text) * Val(txtNoOrder.Text)) * 15) / 100)
            iTax = ((Val(lblSubTotal.Text) * 7.5) / 100)
            lblTax.Text = iTax
            lblTotal.Text = (Val(lblSubTotal.Text) + (iTax))

        ElseIf cmbDiscount.Text = 20 Then
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text) - (((Val(txtCost.Text) * Val(txtNoOrder.Text)) * 20) / 100)
            iTax = (Val(lblSubTotal.Text) * 7.5) / 100
            lblTax.Text = iTax
            lblTotal.Text = (Val(lblSubTotal.Text) + (iTax))

        ElseIf cmbDiscount.Text = 25 Then
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text) - (((Val(txtCost.Text) * Val(txtNoOrder.Text)) * 25) / 100)
            iTax = ((Val(lblSubTotal.Text) * 7.5) / 100)
            lblTax.Text = iTax
            lblTotal.Text = (Val(lblSubTotal.Text) + (iTax))
        End If

        lblTax.Text = FormatCurrency(lblTax.Text)
        lblSubTotal.Text = FormatCurrency(lblSubTotal.Text)
        lblTotal.Text = FormatCurrency(lblTotal.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCost.Text = ""
        lblTax.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtCost.Text = ""
        lblTax.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""
        cmbCustomerID.Text = "0"
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        btnExit.PerformClick
    End Sub

    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        If cmbPaymentMethod.Text = "Cash" Then
            cmbAccountType.Text = "Pay"
        Else
            cmbAccountType.Text = "Account Type"
        End If
    End Sub
End Class
