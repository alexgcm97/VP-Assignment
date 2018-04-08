<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvBeverage = New System.Windows.Forms.ListView()
        Me.lvFood = New System.Windows.Forms.ListView()
        Me.btnBeverage = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.ColumnImage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsCart = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearCartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCart.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.cmsRow.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvBeverage)
        Me.GroupBox1.Controls.Add(Me.lvFood)
        Me.GroupBox1.Controls.Add(Me.btnBeverage)
        Me.GroupBox1.Controls.Add(Me.btnFood)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 420)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'lvBeverage
        '
        Me.lvBeverage.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvBeverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvBeverage.HideSelection = False
        Me.lvBeverage.Location = New System.Drawing.Point(7, 62)
        Me.lvBeverage.MultiSelect = False
        Me.lvBeverage.Name = "lvBeverage"
        Me.lvBeverage.ShowGroups = False
        Me.lvBeverage.Size = New System.Drawing.Size(334, 352)
        Me.lvBeverage.TabIndex = 3
        Me.lvBeverage.UseCompatibleStateImageBehavior = False
        Me.lvBeverage.Visible = False
        '
        'lvFood
        '
        Me.lvFood.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvFood.HideSelection = False
        Me.lvFood.Location = New System.Drawing.Point(7, 62)
        Me.lvFood.MultiSelect = False
        Me.lvFood.Name = "lvFood"
        Me.lvFood.Size = New System.Drawing.Size(334, 352)
        Me.lvFood.TabIndex = 2
        Me.lvFood.UseCompatibleStateImageBehavior = False
        '
        'btnBeverage
        '
        Me.btnBeverage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBeverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBeverage.Location = New System.Drawing.Point(200, 20)
        Me.btnBeverage.Name = "btnBeverage"
        Me.btnBeverage.Size = New System.Drawing.Size(100, 35)
        Me.btnBeverage.TabIndex = 1
        Me.btnBeverage.Text = "&Beverage"
        Me.btnBeverage.UseVisualStyleBackColor = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.Location = New System.Drawing.Point(50, 20)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(100, 35)
        Me.btnFood.TabIndex = 0
        Me.btnFood.Text = "&Food"
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCart)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(382, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 339)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Food Cart"
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToResizeColumns = False
        Me.dgvCart.AllowUserToResizeRows = False
        Me.dgvCart.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnImage, Me.ColumnName, Me.ColumnPrice, Me.ColumnQuantity})
        Me.dgvCart.ContextMenuStrip = Me.cmsCart
        Me.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCart.Location = New System.Drawing.Point(3, 18)
        Me.dgvCart.MultiSelect = False
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvCart.RowTemplate.Height = 40
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(421, 318)
        Me.dgvCart.TabIndex = 1
        '
        'ColumnImage
        '
        Me.ColumnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnImage.HeaderText = "No."
        Me.ColumnImage.Name = "ColumnImage"
        Me.ColumnImage.ReadOnly = True
        Me.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnImage.Width = 38
        '
        'ColumnName
        '
        Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnName.HeaderText = "Name"
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.ReadOnly = True
        Me.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnPrice
        '
        Me.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnPrice.HeaderText = "Price(RM)"
        Me.ColumnPrice.Name = "ColumnPrice"
        Me.ColumnPrice.ReadOnly = True
        Me.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnQuantity
        '
        Me.ColumnQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnQuantity.HeaderText = "Qty"
        Me.ColumnQuantity.Name = "ColumnQuantity"
        Me.ColumnQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnQuantity.Width = 56
        '
        'cmsCart
        '
        Me.cmsCart.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearCartToolStripMenuItem1})
        Me.cmsCart.Name = "cmsCart"
        Me.cmsCart.Size = New System.Drawing.Size(127, 26)
        '
        'ClearCartToolStripMenuItem1
        '
        Me.ClearCartToolStripMenuItem1.Name = "ClearCartToolStripMenuItem1"
        Me.ClearCartToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ClearCartToolStripMenuItem1.Text = "C&lear Cart"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(382, 372)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(273, 70)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "&Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(674, 412)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 30)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnClear.Location = New System.Drawing.Point(674, 372)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear Cart"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "9001.jpg")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit "
        '
        'ClearCartToolStripMenuItem
        '
        Me.ClearCartToolStripMenuItem.Name = "ClearCartToolStripMenuItem"
        Me.ClearCartToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ClearCartToolStripMenuItem.Text = "C&lear Cart"
        '
        'cmsRow
        '
        Me.cmsRow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsRow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveItemToolStripMenuItem, Me.ClearCartToolStripMenuItem})
        Me.cmsRow.Name = "cmsCart"
        Me.cmsRow.Size = New System.Drawing.Size(145, 48)
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RemoveItemToolStripMenuItem.Text = "&Remove Item"
        '
        'FrmOrder
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(832, 460)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Module"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCart.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.cmsRow.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBeverage As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lvFood As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lvBeverage As ListView
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents ColumnImage As DataGridViewTextBoxColumn
    Friend WithEvents ColumnName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQuantity As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsRow As ContextMenuStrip
    Friend WithEvents ClearCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsCart As ContextMenuStrip
    Friend WithEvents ClearCartToolStripMenuItem1 As ToolStripMenuItem
End Class
