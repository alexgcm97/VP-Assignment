Imports System.IO
Imports System.Text
Imports System.Globalization.NumberStyles

Public Class FrmMenuItem
    Dim db As New DataClasses1DataContext
    Dim getMaxID As Integer
    Dim picSource As String = ""
    Dim price As Decimal
    Dim category As Integer
    Dim menuName As String
    Dim id As String = getMaxID
    Public index As String = ""

    Private Sub FrmMenuItem_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'AssignmentDataSet.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.AssignmentDataSet.Menu)
        'TODO: This line of code loads data into the 'AssignmentDataSet.Menu' table. You can move, or remove it, as needed.

        getMaxID = (From q In db.Menus Select q.MenuID).Max() + 1
        lblMenuID.Text = getMaxID
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        picPreview.ImageLocation = OpenFileDialog1.FileName
        picSource = OpenFileDialog1.FileName
        If picSource = "OpenFileDialog1" Then
            picSource = ""
        End If
    End Sub

    Private Sub CopyFile()
        picSource = OpenFileDialog1.FileName
        File.Copy(picSource, "../../Images/menu/" & getMaxID & ".jpg", True)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        index = DataGridView1.CurrentRow.Cells(0).Value
        Dim editFrm As New FrmEditMenuItem
        editFrm.ShowDialog()

    End Sub

    Private Function ValidateAdd() As Boolean
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If txtName.Text = "" Then
            err.AppendLine("- Please enter [Name]")
            ctr = If(ctr, txtName)
        Else
            menuName = txtName.Text
        End If

        If txtPrice.Text = "" Then
            err.AppendLine("- Please enter [Price]")
            ctr = If(ctr, txtPrice)
        Else
            Try
                price = Decimal.Parse(txtPrice.Text)
            Catch ex As Exception
                err.AppendLine("- Invalid Price, Numbers only")
                ctr = If(ctr, txtPrice)
            End Try
        End If


        If rbFood.Checked = False And rbBeverage.Checked = False Then
            err.AppendLine("- Select Food Category")
            ctr = If(ctr, grpCategory)
        ElseIf rbFood.Checked = True Then
            category = 1
        ElseIf rbBeverage.Checked = True Then
            category = 2
        End If

        If picSource = "" Then
            err.AppendLine("- Please upload a picture")
            ctr = If(ctr, picPreview)
        Else
            CopyFile()
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If ValidateAdd() Then
            Dim menu As New Menu With {
                          .MenuID = lblMenuID.Text,
                          .MenuName = menuName,
                          .Price = price,
                          .Category = category
                      }
            db.Menus.InsertOnSubmit(menu)

            Try
                db.SubmitChanges()
                MessageBox.Show("Successully Inserted")
                txtName.Text = ""
                txtPrice.Text = ""
                rbBeverage.Checked = False
                rbFood.Checked = False
                picPreview.ImageLocation = ""
                picSource = ""
            Catch
                MessageBox.Show("Insert Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        DataGridView1.ClearSelection()
        index = DataGridView1.CurrentCell.Value()
        Dim editFrm As New FrmEditMenuItem
        editFrm.ShowDialog()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtPrice.Text = ""
        rbBeverage.Checked = False
        rbFood.Checked = False
        picPreview.ImageLocation = ""
        picSource = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FrmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        index = DataGridView1.CurrentRow.Cells(0).Value

        Dim deleteMenu = (From menus In db.Menus
                          Where menus.MenuID = index).ToList()(0)

        db.Menus.DeleteOnSubmit(deleteMenu)

        Try
            db.SubmitChanges()
            MessageBox.Show("Successully Delete Menu ID :" & index, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("Updated Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FrmMenuItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()
        FrmMainMenu.Show()
    End Sub

End Class