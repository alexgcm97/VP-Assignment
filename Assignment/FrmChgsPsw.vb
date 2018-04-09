Imports System.Text.RegularExpressions

Public Class FrmChgsPsw
    Dim db As New DataClasses1DataContext
    Private chk As Integer = 1
    Private chk1 As Integer = 1
    Private id As String

    Private Sub FrmChgsPsw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        id = FrmLogin.txtUserID.Text

        Dim updatePsw = (From stf In db.Staffs
                         Where stf.Id = id).ToList()(0)

        Dim password As New Regex("[A-Z][A-Za-z0-9]")
        If txtOldPsw.Text.Equals(updatePsw.Password) Then
            If TxtNewPsw.Text.Equals(txtRePsw.Text) Then
                If password.IsMatch(txtRePsw.Text) Then
                    updatePsw.Password = txtRePsw.Text
                    MessageBox.Show("Update Sucessfull, Please Re-Login gain", "Congrat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim frmlg As New FrmLogin
                    frmlg.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Password (E.g Abc123)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Password must be same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            db.SubmitChanges()
        Catch
            MessageBox.Show("Update Unsucessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub FrmChgsPsw_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMainMenu.Show()
    End Sub
End Class