﻿Public Class FrmOrder
    Dim db As New DataClasses1DataContext
    Dim imgList As New ImageList
    Dim dataRow As DataGridViewRow
    Dim orignalValue As Integer

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imgList.ColorDepth = ColorDepth.Depth32Bit
        imgList.ImageSize = New Size(100, 100)

        Dim files() As String = IO.Directory.GetFiles("../../Images/menu")
        Dim imgStr As String
        For i As Integer = 0 To files.Length - 1
            imgStr = files(i)
            imgList.Images.Add(New Bitmap(imgStr))
            imgList.Images.SetKeyName(i, IO.Path.GetFileNameWithoutExtension(imgStr))

        Next
        Dim menuQuery = db.Menus

        Dim foodIndex As Integer = 0
        Dim beverageIndex As Integer = 0
        For Each menuItem In menuQuery
            Dim item As New ListViewItem
            item.Text = menuItem.MenuName
            item.ToolTipText = menuItem.MenuName
            For Each imgName As String In imgList.Images.Keys
                If (imgName = menuItem.MenuID) Then
                    item.Name = imgName
                    item.ImageIndex = imgList.Images.IndexOfKey(imgName)
                End If
            Next
            If (menuItem.Category = 1) Then
                lvFood.Items.Add(item)
                lvFood.Items(foodIndex).SubItems.Add(menuItem.MenuName)
                lvFood.Items(foodIndex).SubItems.Add(menuItem.Price)
                foodIndex += 1
            ElseIf (menuItem.Category = 2) Then
                lvBeverage.Items.Add(item)
                lvBeverage.Items(beverageIndex).SubItems.Add(menuItem.MenuName)
                lvBeverage.Items(beverageIndex).SubItems.Add(menuItem.Price)
                beverageIndex += 1
            End If
        Next
        lvFood.LargeImageList = imgList
        lvBeverage.LargeImageList = imgList
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvCart.Rows.Clear()
        dgvCart.Refresh()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        lvFood.Visible = True
        lvBeverage.Visible = False
    End Sub

    Private Sub btnBeverage_Click(sender As Object, e As EventArgs) Handles btnBeverage.Click
        lvFood.Visible = False
        lvBeverage.Visible = True
    End Sub


    Private Sub lvBeverage_MouseClick(sender As Object, e As MouseEventArgs) Handles lvBeverage.MouseClick
        Dim selectedItem As ListViewItem = lvBeverage.SelectedItems(0)
        dataRow = New DataGridViewRow

        dataRow.CreateCells(dgvCart)
        dataRow.Cells(0).Value = dgvCart.Rows.Count + 1
        dataRow.Cells(0).Tag = selectedItem.Name
        dataRow.Cells(1).Value = selectedItem.Text
        dataRow.Cells(2).Value = selectedItem.SubItems(2).Text
        dataRow.Cells(3).Value = 1

        If (searchRow(dataRow) >= 0) Then
            Dim index = searchRow(dataRow)
            Dim quantity As Integer = dgvCart.Rows(index).Cells(3).Value + 1
            dgvCart.Rows(index).Cells(3).Value = quantity
        Else
            dgvCart.Rows.Add(dataRow)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (dgvCart.Rows.Count <> 0) Then
            FrmPayment.ShowDialog()
        Else
            MessageBox.Show("Food Cart is Empty.", "Order Error")
        End If
    End Sub

    Private Function searchRow(row As DataGridViewRow) As Integer
        Dim index As Integer = -1
        For Each cartRow As DataGridViewRow In dgvCart.Rows
            If cartRow.Cells(0).Tag.Equals(row.Cells(0).Tag) Then
                index = cartRow.Index
            End If
        Next
        Return index
    End Function

    Private Sub lvFood_MouseClick(sender As Object, e As MouseEventArgs) Handles lvFood.MouseClick
        Dim selectedItem As ListViewItem = lvFood.SelectedItems(0)
        dataRow = New DataGridViewRow

        dataRow.CreateCells(dgvCart)
        dataRow.Cells(0).Value = dgvCart.Rows.Count + 1
        dataRow.Cells(0).Tag = selectedItem.Name
        dataRow.Cells(1).Value = selectedItem.Text
        dataRow.Cells(2).Value = selectedItem.SubItems(2).Text
        dataRow.Cells(3).Value = 1

        If (searchRow(dataRow) >= 0) Then
            Dim index = searchRow(dataRow)
            Dim quantity As Integer = dgvCart.Rows(index).Cells(3).Value + 1
            dgvCart.Rows(index).Cells(3).Value = quantity
        Else
            dgvCart.Rows.Add(dataRow)
        End If
    End Sub


    Private Sub dgvCart_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellValidated
        If (e.ColumnIndex = 3) Then
            Dim str As String = dgvCart.Rows(e.RowIndex).Cells(3).Value
            If (IsNumeric(str) = False) Then
                MessageBox.Show("Please input only digits.", "Quantity Error")
                dgvCart.Rows(e.RowIndex).Cells(3).Value = orignalValue
            ElseIf (dgvCart.Rows(e.RowIndex).Cells(3).Value > 50) Then
                MessageBox.Show("Please input value <= 50.", "Quantity Error")
                dgvCart.Rows(e.RowIndex).Cells(3).Value = orignalValue
            ElseIf (dgvCart.Rows(e.RowIndex).Cells(3).Value <= 0) Then
                MessageBox.Show("Please input value more than 1.", "Quantity Error")
                dgvCart.Rows(e.RowIndex).Cells(3).Value = orignalValue
            Else
                dgvCart.Rows(e.RowIndex).Cells(3).Value = Integer.Parse(dgvCart.Rows(e.RowIndex).Cells(3).Value)
            End If
        End If
    End Sub

    Private Sub dgvCart_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellEnter
        orignalValue = dgvCart.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub ClearCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCartToolStripMenuItem.Click
        btnClear_Click(Nothing, Nothing)
    End Sub

    Private Sub CancelOrderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        btnCancel_Click(Nothing, Nothing)
    End Sub

    Private Sub ViewReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReportToolStripMenuItem.Click
        FrmOrderReport.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        btnCancel_Click(Nothing, Nothing)
    End Sub

End Class
