﻿Public Class FrmViewStaff
    Dim db As New DataClasses1DataContext
    Private Sub FrmViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim view = From stf In db.Staffs
                   Select stf.Id, stf.Name, stf.IcNo, stf.Gender, stf.ContactNo, stf.Email, stf.Address, stf.State, stf.Town, stf.Position, stf.Status

        DataGridView1.DataSource = view
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim view = From stf In db.Staffs
                   Where stf.Id = txtIDnum.Text
                   Select stf.Id, stf.Name, stf.IcNo, stf.Gender, stf.ContactNo, stf.Email, stf.Address, stf.State, stf.Town, stf.Position, stf.Status

        DataGridView2.DataSource = view
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmStaffRegistration.Show()
        Me.Close()
    End Sub

    Private Sub FrmViewStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmStaffRegistration.Show()
    End Sub
End Class