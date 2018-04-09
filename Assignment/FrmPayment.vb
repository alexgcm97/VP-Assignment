Public Class FrmPayment
    Dim db As New DataClasses1DataContext
    Dim grandTtl As Decimal
    Dim gst As Decimal
    Dim serviceTax As Decimal
    Dim total As Decimal
    Dim payAmount As Decimal
    Dim changeAmount As Decimal
    Dim custID As Integer
    Dim points As Integer



    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPay.Focus()
        Dim orderId As Integer = 0
        Dim orderQuery = db.Orders
        Dim custID = 0

        If (orderQuery.Any = Nothing) Then
            orderId = 1001
        ElseIf (orderQuery.AsEnumerable.Last.OrderID <> Nothing) Then
            orderId = orderQuery.AsEnumerable.Last.OrderID + 1
        End If

        For Each item As Control In GroupBox3.Controls
            item.Enabled = True
        Next
        With rd100
            .Enabled = False
            .Checked = False
        End With

        With rd500
            .Enabled = False
            .Checked = False
        End With

        With rd1000
            .Enabled = False
            .Checked = False
        End With

        txtPay.Text = ""
        lblChange.Text = ""
        txtCustID.Text = ""
        lblPoints.Text = ""

        lblOrderID.Text = orderId

        calculateTotal()
    End Sub

    Private Sub calculateTotal()
        Dim grandTotalStr As String = lblGrandTotal.Text
        grandTtl = Decimal.Parse(grandTotalStr)
        gst = grandTtl * 0.06
        serviceTax = grandTtl * 0.1
        total = grandTtl + gst + serviceTax


        lblGrandTotal.Text = grandTtl.ToString("0.00")
        labelGST.Text = gst.ToString("0.00")
        labelST.Text = serviceTax.ToString("0.00")
        labelTTL.Text = total.ToString("0.00")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim orderId As Integer = 0
        Dim orderQuery = db.Orders
        Dim menuQuery = db.Menus
        Dim custQuery = From cust In db.Customers
                        Where cust.CustID = custID


        If (changeAmount >= 0 And txtPay.Text <> "") Then

            If (orderQuery.Any = Nothing) Then
                orderId = 1001
            ElseIf (orderQuery.AsEnumerable.Last.OrderID <> Nothing) Then
                orderId = orderQuery.AsEnumerable.Last.OrderID + 1
            End If

            If custID > 0 Then
                custQuery.AsEnumerable(0).MemberPoints = points
                db.SubmitChanges()
            End If

            Dim ord As New Order With
                    {.OrderID = orderId,
                    .OrderDate = System.DateTime.Today.Date,
                    .TotalAmount = labelTTL.Text}
            db.Orders.InsertOnSubmit(ord)

            Try
                For Each row As DataGridViewRow In FrmOrder.dgvCart.Rows
                    Dim menuId As Integer = row.Cells(0).Tag
                    Dim unitPrice As Decimal
                    For Each item In menuQuery
                        If (item.MenuID.Equals(menuId)) Then
                            unitPrice = item.Price
                        End If
                    Next
                    Dim od As New OrderDetail With
                        {.OrderID = orderId,
                         .MenuID = row.Cells(0).Tag,
                         .Quantity = row.Cells(3).Value,
                         .SubTotal = row.Cells(3).Value * unitPrice}

                    db.OrderDetails.InsertOnSubmit(od)
                    db.SubmitChanges()
                Next
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Me.Close()
            End Try
            FrmOrder.dgvCart.Rows.Clear()
        Else
            MessageBox.Show("Please complete payment first.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FrmPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmOrder.Show()
    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim found As Boolean = False
            Dim custQuery = db.Customers
            Try
                Dim custIDInt As Integer = Integer.Parse(txtCustID.Text)

                For Each cust In custQuery
                    If cust.CustID = txtCustID.Text Then
                        found = True
                        custID = cust.CustID
                        points = cust.MemberPoints
                        lblPoints.Text = cust.MemberPoints.ToString

                    End If
                Next
                If found = False Then

                    MessageBox.Show("Customer ID not found.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lblPoints.Text = "N/A"
                Else
                    Dim points As Integer = Integer.Parse(lblPoints.Text)

                    If points >= 100 Then
                        rd100.Enabled = True
                    End If
                    If points >= 500 Then
                        rd500.Enabled = True
                    End If
                    If points >= 1000 Then
                        rd1000.Enabled = True

                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Customer ID must be digits.", "Customer ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtPay_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPay.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If (txtPay.Text <> "") Then
                    payAmount = Decimal.Parse(txtPay.Text)
                    changeAmount = payAmount - total
                    lblChange.Text = changeAmount.ToString("RM 0.00")
                    If changeAmount < 0 Then
                        MessageBox.Show("Insufficient payment.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        changeAmount = -1
                        lblChange.Text = ""
                    End If

                Else
                    MessageBox.Show("Payment amount is empty.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    changeAmount = -1
                    lblChange.Text = ""
                End If
            Catch ex As FormatException
                MessageBox.Show("Please enter digit only.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                changeAmount = -1
                lblChange.Text = ""

            End Try
        End If
    End Sub

    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        Dim total As Decimal
        Dim grandTotalStr As String = lblGrandTotal.Text
        Dim grandTotal As Decimal = Decimal.Parse(grandTotalStr)
        If rd100.Checked Then
            If grandTotal >= 15 Then
                lblGrandTotal.Text = grandTotal - 5
                points -= 100
                calculateTotal()

                For Each item As Control In GroupBox3.Controls
                    item.Enabled = False
                Next

            Else
                MessageBox.Show("Grand Total must be >= RM15.", "Redeem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        If rd500.Checked Then
            If grandTotal >= 40 Then
                lblGrandTotal.Text = grandTotal - 30
                points -= 500
                calculateTotal()
                For Each item As Control In GroupBox3.Controls
                    item.Enabled = False
                Next

            Else
                MessageBox.Show("Grand Total must be >= RM40.", "Redeem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


        If rd1000.Checked Then
            If grandTotal >= 70 Then
                lblGrandTotal.Text = grandTotal - 60
                points -= 1000
                calculateTotal()
                For Each item As Control In GroupBox3.Controls
                    item.Enabled = False
                Next

            Else
                MessageBox.Show("Grand Total must be >= RM70.", "Redeem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub FrmPayment_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        calculateTotal()
    End Sub
End Class