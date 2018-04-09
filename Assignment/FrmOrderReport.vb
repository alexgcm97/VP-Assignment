Imports System.Text

Public Class FrmOrderReport
    Dim db As New DataClasses1DataContext

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        dlgPreviewReport.Document = printReport
        dlgPreviewReport.Size = New System.Drawing.Size(800, 1000)
        dlgPreviewReport.StartPosition = FormStartPosition.CenterScreen
        dlgPreviewReport.ShowDialog()
    End Sub

    Private Sub printReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printReport.PrintPage
        Dim reportDate As DateTime = dtReport.Value.Date
        Dim total As Decimal
        Dim totalQty As Integer

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold Or FontStyle.Underline)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim detect = (From stf In db.Staffs
                      Where stf.Id = Integer.Parse(FrmLogin.txtUserID.Text)).ToList()(0)

        Dim header As String = "Daily Sales Order Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by {1} ({2}).", DateTime.Now, detect.Name, detect.Id)

        Dim body As New StringBuilder()
        body.AppendLine("No     Menu ID   Unit Price (RM)     Order Quantity     Total Amount (RM)")
        body.AppendLine("----   -------   ---------------     --------------     -----------------")

        Dim cnt As Integer = 0
        Dim orderQuery = From o In db.Orders
                         Where o.OrderDate.Equals(reportDate)
        Dim odList As New List(Of OrderDetail)

        For Each o In orderQuery
            Dim orderDetailQuery = From od In db.OrderDetails
                                   Where od.OrderID.Equals(o.OrderID)

            Dim id As String = ""
            Dim price As Decimal = 0
            Dim quantity As Integer = 0

            For Each odRow In orderDetailQuery
                Dim orderDetail As New OrderDetail
                orderDetail.MenuID = odRow.MenuID
                orderDetail.Quantity = odRow.Quantity
                orderDetail.SubTotal = odRow.SubTotal
                total += orderDetail.SubTotal
                totalQty += odRow.Quantity

                Dim index = searchItem(orderDetail.MenuID, odList)

                If index >= 0 Then
                    Dim item As OrderDetail = odList.Item(index)
                    item.Quantity += orderDetail.Quantity
                    item.SubTotal += orderDetail.SubTotal
                    odList.Item(index) = item
                ElseIf index = -1 Then
                    odList.Add(orderDetail)
                End If
            Next
        Next

        If odList.Count > 0 Then
            odList.Sort(Function(x, y) String.Compare(x.MenuID, y.MenuID))
            For Each item As OrderDetail In odList
                cnt += 1
                Dim menu = From m In db.Menus
                           Where m.MenuID.Equals(item.MenuID)
                body.AppendFormat("{0,2}  {1,10}   {2,15}    {3,15}  {4,20}" & vbNewLine,
                cnt, item.MenuID, menu.AsEnumerable(0).Price, item.Quantity, item.SubTotal)
            Next
            body.AppendFormat(vbNewLine)
        End If

        If (cnt > 0) Then
            Dim gst As Decimal = total * 0.06
            Dim service As Decimal = total * 0.1
            Dim grandTotal = total + gst + service
            body.AppendFormat(vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            body.AppendFormat("-------------------------------------------------------------------------" & vbNewLine)
            body.AppendFormat("{0, 60}   {1,10}" & vbNewLine, "Total Amount : RM", total.ToString("0.00"))
            body.AppendFormat("{0, 60}   {1,10}" & vbNewLine, "Total GST (6%) : RM", gst.ToString("0.00"))
            body.AppendFormat("{0, 60}   {1,10}" & vbNewLine, "Total Service Charge (10%) : RM", service.ToString("0.00"))
            body.AppendFormat("{0, 60}   {1,10}" & vbNewLine & vbNewLine, "Grand Total : RM", grandTotal.ToString("0.00"))
            body.AppendFormat("{0, 60}{1,5} unit(s)" & vbNewLine, "Total Order Quantity : ", totalQty)
            body.AppendLine()
            body.AppendFormat("No of Menu Item Records : {0,2} record(s)", cnt)
        Else
            body.AppendLine(vbNewLine)
            body.AppendFormat("No records found on {0}.", dtReport.Value.ToString("dd MMMM yyyy"))
        End If


        With e.Graphics
            .DrawImage(My.Resources.orderReport, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.DarkBlue, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontBody, Brushes.Black, 0, 120)
        End With

    End Sub

    Private Function searchItem(menuId As Integer, list As List(Of OrderDetail)) As Integer
        Dim index = -1
        For Each item As OrderDetail In list
            If menuId = item.MenuID Then
                index = list.IndexOf(item)
            End If
        Next
        Return index
    End Function

    Private Sub FrmOrderReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMainMenu.Show()
    End Sub

End Class