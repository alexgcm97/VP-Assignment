Imports System.Text.RegularExpressions

Public Class FrmCustomerUpdate
    Dim db As New DataClasses1DataContext
    Dim count As Integer = 1

    Private Sub FrmSearchID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCustomer.Visible = False
        Dim View = From cst In db.Customers
                   Select cst.CustID, cst.CustName, cst.CustIcNo
        DataGridView1.DataSource = View


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        count = 1
        Dim retrieve = From cst In db.Customers
                       Where cst.CustID = txtSearch.Text

        For Each getCust In retrieve
            If getCust.CustID = Integer.Parse(txtSearch.Text) Then
                updateCustomer.Visible = True

                Dim joinDate As DateTime = getCust.JoinDate

                lblCustomerID.Text = getCust.CustID
                lblCustomerName.Text = getCust.CustName
                lblCustomerIcNo.Text = getCust.CustIcNo
                lblGender.Text = getCust.Gender
                txtContactNo.Text = getCust.CustContactNo
                txtEmail.Text = getCust.Email
                lblJoinDate.Text = joinDate.ToShortDateString
                txtAddress.Text = getCust.Address

            End If
            count = 0
        Next
        If (count = 1) Then
            MessageBox.Show("Customer ID Not found! ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim phoneNumber As New Regex("[0-9]-\d{7}")
        If phoneNumber.IsMatch(txtContactNo.Text) Then
            Dim email As New Regex("^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")
            If email.IsMatch(txtEmail.Text) Then
                count = 0
            Else
                MessageBox.Show("Invalid Email Format (E.g sample@gmail.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid Contact Number Format (E.g : ***-*******)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If count = 0 Then
            Dim updateCst = (From cst In db.Customers
                             Where cst.CustID = txtSearch.Text).ToList()(0)
            updateCst.CustID = lblCustomerID.Text
            updateCst.CustName = lblCustomerName.Text
            updateCst.CustIcNo = lblCustomerIcNo.Text
            updateCst.Gender = lblGender.Text
            updateCst.CustContactNo = txtContactNo.Text
            updateCst.Email = txtEmail.Text
            updateCst.JoinDate = lblJoinDate.Text
            updateCst.Address = txtAddress.Text


            Try
                db.SubmitChanges()
                db.Dispose()
                MessageBox.Show(lblCustomerName.Text & " succesfully update his/her details", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmStaffRegistration.Show()
                Me.Close()
            Catch
                MessageBox.Show("Updated Fail! Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub FrmCustomerUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmCustomerRegistration.Show()
    End Sub
End Class