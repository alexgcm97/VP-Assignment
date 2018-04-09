Imports System.Text
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
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim name As String = txtName.Text.Trim()
        Dim icno As String = If(txtIcNo.MaskCompleted, txtIcNo.Text, "")
        Dim contactnum As String = If(txtContactNo.MaskCompleted, txtContactNo.Text, "")
        Dim email1 As String = txtEmail.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim state As String = txtState.Text.Trim()
        Dim town As String = txtTown.Text.Trim()
        Dim postcode As String = txtPostcode.Text.Trim()


        If name = "" Then
            err.AppendLine("- Name empty")
            ctr = If(ctr, txtName)
        End If

        If icno = "" Then
            err.AppendLine("- IC No empty")
            ctr = If(ctr, txtIcNo)
        End If

        If contactnum = "" Then
            err.AppendLine("- Contact Number empty")
            ctr = If(ctr, txtContactNo)
        End If

        If email1 = "" Then
            err.AppendLine("- Email empty")
            ctr = If(ctr, txtEmail)
        End If

        If address = "" Then
            err.AppendLine("- Address empty")
            ctr = If(ctr, txtAddress)
        End If

        If state = "" Then
            err.AppendLine("- State empty")
            ctr = If(ctr, txtState)
        End If

        If town = "" Then
            err.AppendLine("- Town empty")
            ctr = If(ctr, txtTown)
        End If

        If postcode = "" Then
            err.AppendLine("- Postcode empty")
            ctr = If(ctr, txtPostcode)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

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
            db.Staffs.InsertOnSubmit(stf)

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