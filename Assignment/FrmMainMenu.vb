Public Class FrmMainMenu
    Dim db As New DataClasses1DataContext

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim detect = (From stf In db.Staffs
                      Where stf.Id = Integer.Parse(FrmLogin.txtUserID.Text)).ToList()(0)

        If detect.Position = "Staff" Then
            btnStfMan.Enabled = False
            ReportToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btnStfMan_Click(sender As Object, e As EventArgs) Handles btnStfMan.Click
        FrmStaffRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrder_click(sender As Object, e As EventArgs) Handles btnOrder.Click
        FrmOrder.Show()
        Me.Hide()
    End Sub

    Private Sub FrmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmLogin.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        FrmChgsPsw.Show()
        Me.Hide()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Me.Close()
        db.Dispose()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        FrmStaffReport.Show()
        Me.Hide()
    End Sub

    Private Sub OrderReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderReportToolStripMenuItem.Click
        FrmOrderReport.Show()
        Me.Hide()
    End Sub
End Class