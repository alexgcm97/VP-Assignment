﻿Public Class FrmPayment
    Dim db As New DataClasses1DataContext

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim orderId As Integer = 0
        Dim orderQuery = db.Orders
        Dim menuQuery = db.Menus

        If (orderQuery.Any = Nothing) Then
            orderId = 1001
        ElseIf (orderQuery.AsEnumerable.Last.OrderID <> Nothing) Then
            orderId = orderQuery.AsEnumerable.Last.OrderID + 1
        End If

        Dim ord As New Order With
                {.OrderID = orderId,
                .OrderDate = System.DateTime.Today.Date,
                .TotalAmount = lblGrandTotal.Text}
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        FrmOrder.dgvCart.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub FrmPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmOrder.Show()
    End Sub
End Class