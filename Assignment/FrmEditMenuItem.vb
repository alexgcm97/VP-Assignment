Imports System.IO
Imports System.Text

Public Class FrmEditMenuItem
    Dim db As New DataClasses1DataContext
    Dim picSource As String
    Dim price As Decimal
    Dim menuName As String
    Dim category As Integer
    Dim imagePath As String
    Dim picOriginal As String


    Private Sub FrmEditMenuItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.Items.Add("Food")
        cboCategory.Items.Add("Beverage")
        MessageBox.Show(FrmMenuItem.index)
        Dim retrieve = From menus In db.Menus
                       Where menus.MenuID = FrmMenuItem.index


        For Each itemRetrieve In retrieve
            If itemRetrieve.MenuID = Decimal.Parse(FrmMenuItem.index) Then
                lblMenuID.Text = itemRetrieve.MenuID
                txtName.Text = itemRetrieve.MenuName
                txtPrice.Text = itemRetrieve.Price
                If itemRetrieve.Category = 1 Then
                    cboCategory.Text = "Food"
                ElseIf itemRetrieve.Category = 2 Then
                    cboCategory.Text = "Beverage"
                End If
                GetPicture()
            End If

        Next
    End Sub

    Private Function ValidateUpdate() As Boolean
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

        If cboCategory.SelectedIndex = 0 Then
            category = 1
        ElseIf cboCategory.SelectedIndex = 1 Then
            category = 2
        Else
            err.AppendLine("- Invalid Category selection. Please re-choose")
            ctr = If(ctr, cboCategory)
        End If



        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            If ctr IsNot Nothing Then
                ctr.Focus()
            End If
            Return False
            Else
                If String.Compare(imagePath, picSource) > 0 Or String.Compare(imagePath, picSource) < 0 Then
                File.Copy(picSource, "../../Images/menu/" & lblMenuID.Text & ".jpg", True)
            End If
            Return True
        End If
    End Function



    Private Sub GetPicture()
        'MessageBox.Show(FrmMenuItem.index)
        imagePath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
        imagePath = imagePath & "\Images\menu\" & FrmMenuItem.index & ".jpg"
        picPreview.ImageLocation = imagePath
        picSource = imagePath
        picOriginal = picSource
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.ShowDialog()
        picPreview.ImageLocation = OpenFileDialog1.FileName
        picSource = OpenFileDialog1.FileName
        If picSource = "OpenFileDialog1" Then
            picSource = picOriginal
            picPreview.ImageLocation = picOriginal
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateUpdate() Then
            Dim updateMenu = (From menus In db.Menus
                              Where menus.MenuID = lblMenuID.Text).ToList()(0)
            updateMenu.MenuID = lblMenuID.Text
            updateMenu.MenuName = menuName
            updateMenu.Price = price
            updateMenu.Category = category

            Try
                db.SubmitChanges()
                db.Dispose()
                MessageBox.Show("Successully Update")
                Me.Close()
            Catch
                MessageBox.Show("Fail to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class