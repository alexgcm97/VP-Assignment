<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuDetailReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuDetailReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFood = New System.Windows.Forms.RadioButton()
        Me.rbBeverage = New System.Windows.Forms.RadioButton()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(61, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Details Report"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbBeverage)
        Me.GroupBox1.Controls.Add(Me.rbFood)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Category"
        '
        'rbFood
        '
        Me.rbFood.AutoSize = True
        Me.rbFood.Location = New System.Drawing.Point(29, 33)
        Me.rbFood.Name = "rbFood"
        Me.rbFood.Size = New System.Drawing.Size(62, 21)
        Me.rbFood.TabIndex = 0
        Me.rbFood.TabStop = True
        Me.rbFood.Text = "Food"
        Me.rbFood.UseVisualStyleBackColor = True
        '
        'rbBeverage
        '
        Me.rbBeverage.AutoSize = True
        Me.rbBeverage.Location = New System.Drawing.Point(29, 67)
        Me.rbBeverage.Name = "rbBeverage"
        Me.rbBeverage.Size = New System.Drawing.Size(95, 21)
        Me.rbBeverage.TabIndex = 1
        Me.rbBeverage.TabStop = True
        Me.rbBeverage.Text = "Beverage"
        Me.rbBeverage.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2!)
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPrint.Location = New System.Drawing.Point(66, 192)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(70, 40)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2!)
        Me.btnExit.Location = New System.Drawing.Point(195, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'FrmMenuDetailReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 268)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMenuDetailReport"
        Me.Text = "FrmMenuDetailReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbBeverage As RadioButton
    Friend WithEvents rbFood As RadioButton
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
