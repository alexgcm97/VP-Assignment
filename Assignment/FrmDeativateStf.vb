Public Class FrmDeativateStf
    Private count As Integer = 1
    Dim db As New DataClasses1DataContext
    Private id As String

    Private Sub FrmDelStf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False

        Dim View = From stf In db.Staffs
                   Select stf.Id, stf.Name, stf.IcNo

        DataGridView1.DataSource = View
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim retrieve = From stf In db.Staffs
                       Where stf.Id = txtIDSearch.Text

        For Each staffRetrieve In retrieve
            If staffRetrieve.Status = "Active" Then
                btnConfirm.Text = "Deactive"
            ElseIf staffRetrieve.Status = "Deactive" Then
                btnConfirm.Text = "Active"
            End If

            If staffRetrieve.Id = Integer.Parse(txtIDSearch.Text) Then
                GroupBox1.Visible = True
                lblName.Text = staffRetrieve.Name
                lblIcNo.Text = staffRetrieve.IcNo
                lblContactNo.Text = staffRetrieve.ContactNo
                lblEmail.Text = staffRetrieve.Email
                lblAddress.Text = staffRetrieve.Address
                lblState.Text = staffRetrieve.State
                lblTown.Text = staffRetrieve.Town
                lblPostcode.Text = staffRetrieve.Postcode
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
        Dim deactivateStf = (From stf In db.Staffs
                             Where stf.Id = txtIDSearch.Text).ToList()(0)

        If deactivateStf.Status = "Active" Then
            deactivateStf.Status = "Deactive"
        ElseIf deactivateStf.Status = "Deactive" Then
            deactivateStf.Status = "Active"
        End If

        Try
            db.SubmitChanges()
            db.Dispose()
            MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frmsr As New FrmStaffRegistration
            frmsr.Show()
            Me.Hide()
        Catch
            MessageBox.Show("Update Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmsr As New FrmStaffRegistration
        frmsr.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim frmsr As New FrmStaffRegistration
        frmsr.Show()
        Me.Hide()
    End Sub
End Class