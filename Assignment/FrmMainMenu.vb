Public Class FrmMainMenu
    Dim db As New DataClasses1DataContext

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim detect = (From stf In db.Staffs
                      Where stf.Id = Integer.Parse(FrmLogin.txtUserID.Text)).ToList()(0)

        If detect.Position = "Staff" Then
            btnStfMan.Enabled = False
            btnGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub btnStfMan_Click(sender As Object, e As EventArgs) Handles btnStfMan.Click
        Dim frmsr As New FrmStaffRegistration
        frmsr.Show()
        Me.Hide()
    End Sub

    Private Sub btnChgPsw_Click(sender As Object, e As EventArgs) Handles btnChgPsw.Click
        Dim frmcp As New FrmChgsPsw
        frmcp.Show()
        Me.Hide()
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim frmsr As New FrmStaffReport
        frmsr.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub
End Class