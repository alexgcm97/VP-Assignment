<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssignmentDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssignmentDataSet = New Assignment.AssignmentDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.rbBeverage = New System.Windows.Forms.RadioButton()
        Me.rbFood = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMenuID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuTableAdapter = New Assignment.AssignmentDataSetTableAdapters.MenuTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignmentDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(743, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Maintenance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(486, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "2-Beverage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "1-Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Category"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(581, 122)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(152, 60)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(581, 45)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(152, 60)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn, Me.MenuNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MenuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(460, 185)
        Me.DataGridView1.TabIndex = 6
        '
        'MenuIDDataGridViewTextBoxColumn
        '
        Me.MenuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.HeaderText = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.Name = "MenuIDDataGridViewTextBoxColumn"
        Me.MenuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuNameDataGridViewTextBoxColumn
        '
        Me.MenuNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName"
        Me.MenuNameDataGridViewTextBoxColumn.HeaderText = "MenuName"
        Me.MenuNameDataGridViewTextBoxColumn.Name = "MenuNameDataGridViewTextBoxColumn"
        Me.MenuNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "Menu"
        Me.MenuBindingSource.DataSource = Me.AssignmentDataSetBindingSource
        '
        'AssignmentDataSetBindingSource
        '
        Me.AssignmentDataSetBindingSource.DataSource = Me.AssignmentDataSet
        Me.AssignmentDataSetBindingSource.Position = 0
        '
        'AssignmentDataSet
        '
        Me.AssignmentDataSet.DataSetName = "AssignmentDataSet"
        Me.AssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.picPreview)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.grpCategory)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.lblMenuID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 260)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(743, 252)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Menu"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(581, 161)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 60)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(581, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 60)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(581, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(152, 60)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(284, 79)
        Me.picPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(220, 144)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPreview.TabIndex = 7
        Me.picPreview.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 209)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Upload Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.rbBeverage)
        Me.grpCategory.Controls.Add(Me.rbFood)
        Me.grpCategory.Location = New System.Drawing.Point(64, 111)
        Me.grpCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCategory.Size = New System.Drawing.Size(201, 91)
        Me.grpCategory.TabIndex = 6
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'rbBeverage
        '
        Me.rbBeverage.AutoSize = True
        Me.rbBeverage.Location = New System.Drawing.Point(10, 50)
        Me.rbBeverage.Margin = New System.Windows.Forms.Padding(4)
        Me.rbBeverage.Name = "rbBeverage"
        Me.rbBeverage.Size = New System.Drawing.Size(94, 20)
        Me.rbBeverage.TabIndex = 1
        Me.rbBeverage.TabStop = True
        Me.rbBeverage.Text = "Beverage"
        Me.rbBeverage.UseVisualStyleBackColor = True
        '
        'rbFood
        '
        Me.rbFood.AutoSize = True
        Me.rbFood.Location = New System.Drawing.Point(10, 25)
        Me.rbFood.Margin = New System.Windows.Forms.Padding(4)
        Me.rbFood.Name = "rbFood"
        Me.rbFood.Size = New System.Drawing.Size(62, 20)
        Me.rbFood.TabIndex = 0
        Me.rbFood.TabStop = True
        Me.rbFood.Text = "Food"
        Me.rbFood.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 47)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 16)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Menu Name :"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(124, 79)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(148, 22)
        Me.txtPrice.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 47)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 22)
        Me.txtName.TabIndex = 2
        '
        'lblMenuID
        '
        Me.lblMenuID.AutoSize = True
        Me.lblMenuID.Location = New System.Drawing.Point(124, 27)
        Me.lblMenuID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuID.Name = "lblMenuID"
        Me.lblMenuID.Size = New System.Drawing.Size(0, 16)
        Me.lblMenuID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu ID :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'FrmMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 527)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuItem"
        Me.Text = "Menu Details Module"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignmentDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMenuID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents rbBeverage As RadioButton
    Friend WithEvents rbFood As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AssignmentDataSetBindingSource As BindingSource
    Friend WithEvents AssignmentDataSet As AssignmentDataSet
    Friend WithEvents MenuBindingSource As BindingSource

    Friend WithEvents MenuTableAdapter As AssignmentDataSetTableAdapters.MenuTableAdapter
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
