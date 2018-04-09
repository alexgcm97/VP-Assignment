Imports System.Text

Public Class FrmCustomerReport
    Dim db As New DataClasses1DataContext

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim month As Integer = picker.Value.Month
        Dim year As Integer = picker.Value.Year



        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold Or FontStyle.Underline)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Customer Monthly Registration Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Staff", DateTime.Now)

        Dim body As New StringBuilder()
        body.AppendLine("No   Customer ID          Customer Name             Join Date")
        body.AppendLine("---    ----------       ----------------------    -----------------")

        Dim count As Integer = 0
        Dim cstQuery = db.Customers

        For Each cst In cstQuery
            Dim joinDate As DateTime = cst.JoinDate
            Dim joinYear As Integer = joinDate.Year
            Dim joinMonth As Integer = joinDate.Month

            If (month = joinMonth And year = joinYear) Then
                count += 1
                body.AppendFormat("{0,2}     {1,10}       {2,20}    {3,20} " & vbNewLine,
                          count, cst.CustID, cst.CustName, joinDate.ToString("dd-MMMM-yyyy"))
            End If

        Next

        body.AppendFormat(vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine)
        body.AppendFormat("-------------------------------------------------------------------------" & vbNewLine)



        With e.Graphics
            .DrawImage(My.Resources.orderReport, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Blue, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontBody, Brushes.Black, 0, 120)
        End With

    End Sub

    Private Sub btnCancecl_Click(sender As Object, e As EventArgs) Handles btnCancecl.Click
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)

    End Sub


End Class