<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrderReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrderReport))
        Me.lblMonthYr = New System.Windows.Forms.Label()
        Me.dtReport = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dlgPreviewReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.printReport = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'lblMonthYr
        '
        Me.lblMonthYr.AutoSize = True
        Me.lblMonthYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYr.Location = New System.Drawing.Point(40, 73)
        Me.lblMonthYr.Name = "lblMonthYr"
        Me.lblMonthYr.Size = New System.Drawing.Size(110, 18)
        Me.lblMonthYr.TabIndex = 0
        Me.lblMonthYr.Text = "Month && Year : "
        '
        'dtReport
        '
        Me.dtReport.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtReport.CustomFormat = "MMMM yyyy"
        Me.dtReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.dtReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReport.Location = New System.Drawing.Point(43, 106)
        Me.dtReport.Name = "dtReport"
        Me.dtReport.ShowUpDown = True
        Me.dtReport.Size = New System.Drawing.Size(199, 24)
        Me.dtReport.TabIndex = 3
        Me.dtReport.Value = New Date(2018, 3, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Order Monthly Report"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(43, 172)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(90, 40)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(152, 172)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgPreviewReport
        '
        Me.dlgPreviewReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewReport.Enabled = True
        Me.dlgPreviewReport.Icon = CType(resources.GetObject("dlgPreviewReport.Icon"), System.Drawing.Icon)
        Me.dlgPreviewReport.Name = "PrintPreviewDialog1"
        Me.dlgPreviewReport.Visible = False
        '
        'printReport
        '
        Me.printReport.OriginAtMargins = True
        '
        'FrmOrderReport
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtReport)
        Me.Controls.Add(Me.lblMonthYr)
        Me.Name = "FrmOrderReport"
        Me.Text = "Order Report Module"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMonthYr As Label
    Friend WithEvents dtReport As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dlgPreviewReport As PrintPreviewDialog
    Friend WithEvents printReport As Printing.PrintDocument
End Class
