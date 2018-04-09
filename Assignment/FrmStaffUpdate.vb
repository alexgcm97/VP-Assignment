﻿Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmStaffUpdate
    Dim db As New DataClasses1DataContext
    Private id As String
    Private count As Integer = 1
    Private count1 As Integer = 1

    Private Sub FrmSearchID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        Dim View = From stff In db.Staffs
                   Select stff.Id, stff.Name, stff.IcNo
        DataGridView1.DataSource = View

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        count = 1
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
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        count = 0
        count1 = 0
        Dim email As New Regex("^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")
        If email.IsMatch(txtEmail.Text) Then
            count = 0
        Else
            MessageBox.Show("Invalid Email Format (E.g sample@gmail.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If count = 0 Then
            Dim updateStf = (From stf In db.Staffs
                             Where stf.Id = txtIDSearch.Text).ToList()(0)

            If txtName.Text = "" Then
                MessageBox.Show("Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                count1 = 1
            Else

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

            End If

            If count1 = 0 Then

                Try
                    db.SubmitChanges()
                    db.Dispose()
                    MessageBox.Show(txtName.Text & " updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FrmStaffRegistration.Show()
                    Me.Close()
                Catch
                    MessageBox.Show("Updated Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmStaffRegistration.Close()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmStaffRegistration.Close()
        Me.Close()
    End Sub

    Private Sub FrmStaffUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmStaffRegistration.Show()
    End Sub
End Class