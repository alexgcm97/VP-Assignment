Imports System.Text.RegularExpressions

Public Class FrmCustomerRegistration
    Dim db As New DataClasses1DataContext
    Dim genderTxt As String
    Dim getMaxCustID As String
    Private Const memberPoint = 0
    Private count As Integer = 1
    Dim regDate As Date = Date.Now()
    Dim strDate As String = regDate.ToString("dd-MMM-yyyy")



    Private Sub FrmCustomerRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = strDate
        txtName.Select()
        getMaxCustID = (From c In db.Customers Select c.CustID).Max()
        lblCustID.Text = getMaxCustID + 1
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radGender(sender As Object, e As EventArgs) Handles radMale.Click, radFemale.Click
        If radMale.Checked Then
            genderTxt = "Male"
        ElseIf radFemale.Checked Then
            genderTxt = "Female"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim IcNo As New Regex("\d{6}-\d{2}-\d{4}") 'check icno
        If IcNo.IsMatch(txtIcNo.Text) Then
            Dim phoneNo As New Regex("[0-9]-\d{7}") ' check phoneNo
            If phoneNo.IsMatch(txtContactNo.Text) Then
                Dim Email As New Regex("^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")
                If Email.IsMatch(txtEmail.Text) Then
                    count = 0
                Else
                    MessageBox.Show("Invalid Email Format (E.g sample@gmail.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid Contact Number Format (E.g : 012-5672234)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid IC No Format (E.g : 970313-10-****)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If count = 0 Then
            Try
                Dim cst As New Customer With {
                                .CustID = Integer.Parse(lblCustID.Text),
                                .CustName = txtName.Text,
                                .CustIcNo = txtIcNo.Text,
                                .Gender = genderTxt.ToString,
                                .CustContactNo = txtContactNo.Text,
                                .Email = txtEmail.Text,
                                .Address = txtAddress.Text,
                                .MemberPoints = memberPoint,
                                .JoinDate = strDate
                            }

                db.Customers.InsertOnSubmit(cst)
            Catch ex As Exception
                MessageBox.Show("Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                db.SubmitChanges()
                db.Dispose()
                MessageBox.Show(txtName.Text & " inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim cst As New FrmCustomerRegistration
                cst.Show()
                Me.Hide()
            Catch
                MessageBox.Show("Insert Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        For Each txt In {txtName, txtIcNo, txtContactNo, txtEmail, txtAddress}
            txt.Clear()
        Next
        txtName.Select()
        radMale.Checked = True


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {txtName, txtIcNo, txtContactNo, txtEmail, txtAddress}
            txt.Clear()
        Next
        txtName.Select()
        radMale.Checked = True

    End Sub

    Private Sub FrmCustomerRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMainMenu.Show()
    End Sub

    Private Sub UpdateProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProfileToolStripMenuItem.Click
        FrmCustomerUpdate.Show()
        Me.Hide()
    End Sub
End Class