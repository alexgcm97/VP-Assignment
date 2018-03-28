Public Class FrmOrder
    Dim db As DataClasses1DataContext
    Dim imageList As New ImageList

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageList.ColorDepth = ColorDepth.Depth32Bit
        imageList.ImageSize = New Size(110, 110)
        Dim files() As String = IO.Directory.GetFiles("../../Images/menu")
        Dim imgStr As String
        For i As Integer = 0 To files.Length - 1
            imgStr = files(i)
            imageList.Images.Add(New Bitmap(imgStr))
            imageList.Images.SetKeyName(i, IO.Path.GetFileNameWithoutExtension(imgStr))
        Next
        db = New DataClasses1DataContext

        Dim menuQuery = db.Menus

        For Each menuItem In menuQuery
            Dim item As New ListViewItem
            item.Text = menuItem.menuName
            item.ToolTipText = menuItem.menuName
            For Each imgName As String In imageList.Images.Keys
                If (imgName = menuItem.menuID) Then
                    item.ImageIndex = imageList.Images.IndexOfKey(imgName)
                End If
            Next
            lvMenu.Items.Add(item)
        Next
        lvMenu.LargeImageList = imageList
    End Sub

    Private Sub foodList_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lvCart.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
