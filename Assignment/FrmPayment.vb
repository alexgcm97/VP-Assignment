Public Class FrmPayment

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim db As New DataClasses1DataContext
        Dim orderId As Integer = 0
        Dim orderQuery = db.Orders

        If (orderQuery.Any = Nothing) Then
            orderId = 1001
        ElseIf (orderQuery.AsEnumerable.Last.OrderID <> Nothing) Then
            orderId = orderQuery.AsEnumerable.Last.OrderID + 1
        End If

        Dim ord As New Order With
                {.OrderID = orderId,
                .OrderDate = System.DateTime.Today.Date}
        db.Orders.InsertOnSubmit(ord)

        Try
            For Each row As DataGridViewRow In FrmOrder.dgvCart.Rows
                Dim od As New OrderDetail With
                    {.OrderID = orderId,
                     .MenuID = row.Cells(0).Tag,
                     .Quantity = row.Cells(3).Value}

                db.OrderDetails.InsertOnSubmit(od)

                db.SubmitChanges()
            Next
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


        FrmOrder.dgvCart.Rows.Clear()
        Me.Close()
    End Sub
End Class