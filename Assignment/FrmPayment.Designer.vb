<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.labelGST = New System.Windows.Forms.Label()
        Me.labelST = New System.Windows.Forms.Label()
        Me.labelTTL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AssignmentDataSet1 = New Assignment.AssignmentDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRedeem = New System.Windows.Forms.Button()
        Me.rd1000 = New System.Windows.Forms.RadioButton()
        Me.rd500 = New System.Windows.Forms.RadioButton()
        Me.rd100 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.AssignmentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Navy
        Me.btnConfirm.Location = New System.Drawing.Point(9, 630)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(124, 50)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(266, 31)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(100, 29)
        Me.lblGrandTotal.TabIndex = 1
        Me.lblGrandTotal.Text = "labelGT"
        '
        'labelGST
        '
        Me.labelGST.AutoSize = True
        Me.labelGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGST.Location = New System.Drawing.Point(266, 60)
        Me.labelGST.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelGST.Name = "labelGST"
        Me.labelGST.Size = New System.Drawing.Size(116, 29)
        Me.labelGST.TabIndex = 2
        Me.labelGST.Text = "labelGST"
        '
        'labelST
        '
        Me.labelST.AutoSize = True
        Me.labelST.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelST.Location = New System.Drawing.Point(267, 97)
        Me.labelST.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelST.Name = "labelST"
        Me.labelST.Size = New System.Drawing.Size(98, 29)
        Me.labelST.TabIndex = 3
        Me.labelST.Text = "labelST"
        '
        'labelTTL
        '
        Me.labelTTL.AutoSize = True
        Me.labelTTL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTTL.ForeColor = System.Drawing.Color.Red
        Me.labelTTL.Location = New System.Drawing.Point(267, 141)
        Me.labelTTL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelTTL.Name = "labelTTL"
        Me.labelTTL.Size = New System.Drawing.Size(111, 29)
        Me.labelTTL.TabIndex = 4
        Me.labelTTL.Text = "labelTTL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sub Total : RM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "GST (6%) : RM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Service Tax (10%) : RM"
        '
        'AssignmentDataSet1
        '
        Me.AssignmentDataSet1.DataSetName = "AssignmentDataSet"
        Me.AssignmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(140, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total : RM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.labelTTL)
        Me.GroupBox1.Controls.Add(Me.lblGrandTotal)
        Me.GroupBox1.Controls.Add(Me.labelGST)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.labelST)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(470, 180)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Change :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Amount Paid : RM"
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(272, 17)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(132, 46)
        Me.txtPay.TabIndex = 10
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Green
        Me.lblChange.Location = New System.Drawing.Point(218, 73)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(0, 29)
        Me.lblChange.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblChange)
        Me.GroupBox2.Controls.Add(Me.txtPay)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 194)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(585, 137)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(502, 29)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Order ID: "
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.ForeColor = System.Drawing.Color.Black
        Me.lblOrderID.Location = New System.Drawing.Point(520, 58)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(89, 29)
        Me.lblOrderID.TabIndex = 14
        Me.lblOrderID.Text = "labelID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRedeem)
        Me.GroupBox3.Controls.Add(Me.rd1000)
        Me.GroupBox3.Controls.Add(Me.rd500)
        Me.GroupBox3.Controls.Add(Me.rd100)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblPoints)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtCustID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 337)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(584, 287)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Membership"
        '
        'btnRedeem
        '
        Me.btnRedeem.Location = New System.Drawing.Point(452, 228)
        Me.btnRedeem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRedeem.Name = "btnRedeem"
        Me.btnRedeem.Size = New System.Drawing.Size(110, 46)
        Me.btnRedeem.TabIndex = 8
        Me.btnRedeem.Text = "&Redeem"
        Me.btnRedeem.UseVisualStyleBackColor = True
        '
        'rd1000
        '
        Me.rd1000.AutoSize = True
        Me.rd1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd1000.Location = New System.Drawing.Point(262, 186)
        Me.rd1000.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rd1000.Name = "rd1000"
        Me.rd1000.Size = New System.Drawing.Size(203, 24)
        Me.rd1000.TabIndex = 7
        Me.rd1000.TabStop = True
        Me.rd1000.Text = "1000 Points - RM60 OFF"
        Me.rd1000.UseVisualStyleBackColor = True
        '
        'rd500
        '
        Me.rd500.AutoSize = True
        Me.rd500.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd500.Location = New System.Drawing.Point(262, 158)
        Me.rd500.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rd500.Name = "rd500"
        Me.rd500.Size = New System.Drawing.Size(202, 24)
        Me.rd500.TabIndex = 6
        Me.rd500.TabStop = True
        Me.rd500.Text = "500 Points   - RM30 OFF"
        Me.rd500.UseVisualStyleBackColor = True
        '
        'rd100
        '
        Me.rd100.AutoSize = True
        Me.rd100.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd100.Location = New System.Drawing.Point(262, 129)
        Me.rd100.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rd100.Name = "rd100"
        Me.rd100.Size = New System.Drawing.Size(193, 24)
        Me.rd100.TabIndex = 5
        Me.rd100.TabStop = True
        Me.rd100.Text = "100 Points   - RM5 OFF"
        Me.rd100.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 126)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 26)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Redeem points :"
        '
        'lblPoints
        '
        Me.lblPoints.Location = New System.Drawing.Point(250, 84)
        Me.lblPoints.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(143, 26)
        Me.lblPoints.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 84)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 26)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Membership Points :"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(250, 36)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(148, 32)
        Me.txtCustID.TabIndex = 1
        Me.txtCustID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 41)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer ID :"
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 690)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmPayment"
        Me.Text = "Payment Module"
        CType(Me.AssignmentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents labelGST As Label
    Friend WithEvents labelST As Label
    Friend WithEvents labelTTL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AssignmentDataSet1 As AssignmentDataSet
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPay As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRedeem As Button
    Friend WithEvents rd1000 As RadioButton
    Friend WithEvents rd500 As RadioButton
    Friend WithEvents rd100 As RadioButton
    Friend WithEvents Label10 As Label
End Class
