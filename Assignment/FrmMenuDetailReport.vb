Imports System.Text

Public Class FrmMenuDetailReport

    Dim db As New DataClasses1DataContext
    Private category As Decimal

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String
        Dim subHearder As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Staff: " & FrmLogin.txtUserID.Text & " (ID Number)", DateTime.Now
        )

        Dim body As New StringBuilder()

        body.AppendLine("No    ID                 Name                  Price   ")
        body.AppendLine("--  ------   ------------------------------  --------- ")

        Dim cnt As Integer = 0
        If rbFood.Checked Then
            category = 1
            header = "Food Category Listing"
        ElseIf rbBeverage.Checked Then
            category = 2
            header = "Beverage Category Listing"
        End If

        Dim retrieve = From menus In db.Menus
                       Where menus.Category = category

        For Each menuRetrieve In retrieve
            cnt += 1
            body.AppendFormat("{0, 2}  {1, -10} {2, -30} {3, 5}" & vbNewLine,
                              cnt, menuRetrieve.MenuID, menuRetrieve.MenuName, menuRetrieve.Price)
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} records(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.Menu_Report_Logo, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHearder, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FrmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub FrmStaffReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmMainMenu.Show()
    End Sub


End Class