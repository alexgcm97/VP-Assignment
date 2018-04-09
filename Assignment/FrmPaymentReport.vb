Imports System.Text

Public Class FrmPaymentReport
    Dim db As New DataClasses1DataContext

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        dlgPreviewReport.Document = printReport
        dlgPreviewReport.ShowDialog()
    End Sub

    Private Sub printReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printReport.PrintPage
        Dim month As Integer = dtReport.Value.Month
        Dim year As Integer = dtReport.Value.Year
        Dim grandTotal As Decimal

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold Or FontStyle.Underline)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Monthly Sales Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Staff", DateTime.Now)

        Dim body As New StringBuilder()
        body.AppendLine(" No      Order ID           Order Date               Total Amount (RM)")
        body.AppendLine("----   ------------   ----------------------    -------------------------")

        Dim cnt As Integer = 0
        Dim orderQuery = db.Orders
        Dim orderDetailQuery = db.OrderDetails
        For Each order In orderQuery
            If (order.OrderDate.Year = year And order.OrderDate.Month = month) Then
                cnt += 1
                body.AppendFormat("{0,2}     {1,10}       {2,20}",
                              cnt, order.OrderID, order.OrderDate.ToShortDateString)

                Dim totalAmount As Decimal = Decimal.Parse(order.TotalAmount)


                grandTotal += totalAmount
                body.AppendFormat(" {0,25}" & vbNewLine, totalAmount)
            End If
        Next

        body.AppendFormat(vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine)
        body.AppendFormat("-------------------------------------------------------------------------" & vbNewLine)
        body.AppendFormat("{0, 60}{1,10}" & vbNewLine, "Grand Total : ", grandTotal)

        body.AppendFormat("No of Records : {0,2} record(s)", cnt)


        With e.Graphics
            .DrawImage(My.Resources.orderReport, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Blue, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontBody, Brushes.Black, 0, 120)
        End With

    End Sub


End Class