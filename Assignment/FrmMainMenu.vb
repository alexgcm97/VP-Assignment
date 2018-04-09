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
        FrmLogin.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        FrmChgsPsw.Show()
        Me.Hide()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        FrmStaffReport.Show()
        Me.Hide()
    End Sub

    Private Sub OrderReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderReportToolStripMenuItem.Click
        FrmOrderReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnCust_Click(sender As Object, e As EventArgs) Handles btnCust.Click
        FrmCustomerRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReportToolStripMenuItem.Click
        FrmCustomerReport.Show()
        Me.Hide()
    End Sub

    Private Sub PaymentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentReportToolStripMenuItem.Click
        FrmPaymentReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        FrmMenuItem.Show()
        Me.Hide()
    End Sub

    Private Sub MenuDetailReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuDetailReportToolStripMenuItem.Click
        FrmMenuDetailReport.Show()
        Me.Hide()
    End Sub
End Class