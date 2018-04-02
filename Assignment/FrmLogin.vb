Public Class FrmLogin
    Dim db As New DataClasses1DataContext
    Private chk As Integer = 1

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim check = From stf In db.Staffs

        For Each checkLogin In check
            If txtUserID.Text.Equals((checkLogin.Id).ToString) Then
                If txtPassword.Text.Equals(checkLogin.Password) Then
                    If checkLogin.Status.Equals("Active") Then
                        Dim frmmm As New FrmMainMenu
                        frmmm.Show()
                        Me.Hide()
                        chk = 0
                    End If
                End If
            End If
        Next
        If chk = 1 Then
            MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
    End Sub
End Class