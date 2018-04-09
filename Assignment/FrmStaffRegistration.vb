Imports System.Text.RegularExpressions

Public Class FrmStaffRegistration
    Dim db As New DataClasses1DataContext
    Dim getMaxID As Integer
    Dim genderText As String
    Dim positionText As String
    Private Count As Integer = 1

    Private Sub FrmStaffRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Select()
        rbMale.Select()
        rbStaff.Select()
        getMaxID = (From q In db.Staffs Select q.Id).Max()
        lblID.Text = getMaxID + 1
    End Sub

    Private Sub radGender(sender As Object, e As EventArgs) Handles rbMale.Click, rbFemale.Click
        If rbMale.Checked Then
            genderText = "Male"
        ElseIf rbFemale.Checked Then
            genderText = "Female"
        End If
    End Sub

    Private Sub radPosition(sender As Object, e As EventArgs) Handles rbManager.Click, rbStaff.Click
        If rbManager.Checked Then
            positionText = "Manager"
        ElseIf rbStaff.Checked Then
            positionText = "Staff"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Count = 1
        Dim email As New Regex("^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")
            If email.IsMatch(txtEmail.Text) Then
            Dim stf As New Staff With {
                            .Id = Integer.Parse(lblID.Text),
                            .Password = "Abc123",
                            .Name = txtName.Text,
                            .IcNo = txtIcNo.Text,
                            .Gender = genderText.ToString,
                            .ContactNo = txtContactNo.Text,
                            .Email = txtEmail.Text,
                            .Address = txtAddress.Text,
                            .State = txtState.Text,
                            .Town = txtTown.Text,
                            .Postcode = txtPostcode.Text,
                            .Position = positionText.ToString,
                            .Status = "Active"
                        }
            If stf.Name = "" Then
                MessageBox.Show("Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Count = 0
            Else
                db.Staffs.InsertOnSubmit(stf)
            End If

        Else
                MessageBox.Show("Invalid Email Format (E.g sample@gmail.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Count = 0
            End If

            If Count = 1 Then
            Try
                db.SubmitChanges()
                db.Dispose()
                MessageBox.Show(txtName.Text & " inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frmsr As New FrmStaffRegistration
                frmsr.Show()
                Me.Hide()
            Catch
                MessageBox.Show("Insert Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        For Each txt In {txtName, txtIcNo, txtContactNo, txtEmail, txtAddress, txtState, txtTown, txtPostcode}
            txt.Clear()
        Next
        txtName.Select()
        rbMale.Checked = True
        rbStaff.Checked = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        FrmStaffUpdate.Show()
        Me.Hide()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        FrmViewStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {txtName, txtIcNo, txtContactNo, txtEmail, txtAddress, txtState, txtTown, txtPostcode}
            txt.Clear()
        Next
        txtName.Select()
        rbMale.Checked = True
        rbStaff.Checked = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        FrmDeativateStf.Show()
        Me.Hide()
    End Sub

    Private Sub FrmStaffRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmMainMenu.Show()
    End Sub
End Class