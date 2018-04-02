Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmStaffUpdate
    Dim db As New DataClasses1DataContext
    Private id As String
    Private count As Integer = 1
    Private count1 As Integer = 1

    Private Sub FrmSearchID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False

        Dim View = From stf In db.Staffs
                   Select stf.Id, stf.Name, stf.IcNo
        DataGridView1.DataSource = View

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GroupBox1.Visible = True
        Dim retrieve = From stf In db.Staffs
                       Where stf.Id = txtIDSearch.Text

        For Each staffRetrieve In retrieve
            If staffRetrieve.Id = Integer.Parse(txtIDSearch.Text) Then
                txtName.Text = staffRetrieve.Name
                txtIcNo.Text = staffRetrieve.IcNo
                txtContactNo.Text = staffRetrieve.ContactNo
                txtEmail.Text = staffRetrieve.Email
                txtAddress.Text = staffRetrieve.Address
                txtState.Text = staffRetrieve.State
                txtTown.Text = staffRetrieve.Town
                txtPostcode.Text = staffRetrieve.Postcode
                lblAccount.Text = staffRetrieve.Status
                If staffRetrieve.Gender.Equals("Male") Then
                    rbMale.Checked = True
                Else
                    rbFemale.Checked = True
                End If

                If staffRetrieve.Position.Equals("Staff") Then
                    rbStaff.Checked = True
                Else
                    rbManager.Checked = True
                End If
            End If
            count = 0
        Next

        If count = 1 Then
            MessageBox.Show("ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim phoneNumber As New Regex("[0-9]-\d{7}")
        If phoneNumber.IsMatch(txtContactNo.Text) Then
            Dim icno As New Regex("\d{6}-\d{2}-\d{4}")
            If icno.IsMatch(txtIcNo.Text) Then
                Dim email As New Regex("^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")
                If email.IsMatch(txtEmail.Text) Then
                    Dim postcode As New Regex("\d{5}")
                    If postcode.IsMatch(txtPostcode.Text) Then
                        count = 0
                    Else
                        MessageBox.Show("Invalid Postcode Format (E.g *****)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Invalid Email Format (E.g sample@gmail.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid IC No Format (E.g : ******-**-****)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid Contact Number Format (E.g : ***-*******)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If count = 0 Then
            Dim updateStf = (From stf In db.Staffs
                             Where stf.Id = txtIDSearch.Text).ToList()(0)

            updateStf.Name = txtName.Text
            updateStf.IcNo = txtIcNo.Text
            updateStf.ContactNo = txtContactNo.Text
            updateStf.Email = txtEmail.Text
            updateStf.Address = txtAddress.Text
            updateStf.State = txtState.Text
            updateStf.Town = txtTown.Text
            updateStf.Postcode = txtPostcode.Text
            updateStf.Status = lblAccount.Text
            If rbMale.Checked Then
                updateStf.Gender = "Male"
            ElseIf rbFemale.Checked Then
                updateStf.Gender = "Female"
            End If

            If rbStaff.Checked Then
                updateStf.Position = "Staff"
            ElseIf rbManager.Checked Then
                updateStf.Position = "Manager"
            End If

            Try
                db.SubmitChanges()
                db.Dispose()
                MessageBox.Show(txtName.Text & " updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frmmm As New FrmMainMenu
                frmmm.Show()
                Me.Hide()
            Catch
                MessageBox.Show("Updated Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim frmsr As New FrmStaffRegistration
        frmsr.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmsr As New FrmStaffRegistration
        frmsr.Show()
        Me.Hide()
    End Sub

    Private Sub FrmStaffUpdate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmStaffRegistration.Show()
    End Sub
End Class