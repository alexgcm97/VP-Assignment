Imports System.Text

Public Class FrmStaffReport
    Dim db As New DataClasses1DataContext
    Private position As String

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Staff Position Listing"
        Dim subHearder As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Staff: " & FrmLogin.txtUserID.Text & " (ID Number)", DateTime.Now
        )

        Dim body As New StringBuilder()

        body.AppendLine("No  ID Number  Name                    IC No           Contact Number      Email")
        body.AppendLine("--  ---------  --------------------    --------------- ----------------    -------------------")

        Dim cnt As Integer = 0
        If rbStaff.Checked Then
            position = "Staff"
        ElseIf rbManager.Checked Then
            position = "Manager"
        End If

        Dim retrieve = From stf In db.Staffs
                       Where stf.Position = position

        For Each staffRetrieve In retrieve
            cnt += 1
            body.AppendFormat("{0, 2}    {1, -8} {2, -23} {3, -15} {4, -19} {5, -25}" & vbNewLine,
                              cnt, staffRetrieve.Id, staffRetrieve.Name, staffRetrieve.IcNo, staffRetrieve.ContactNo, staffRetrieve.Email)
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} records(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.Staff, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHearder, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog(Me)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub FrmStaffReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmMainMenu.Show()
    End Sub

    Private Sub FrmStaffReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class