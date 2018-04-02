<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainMenu
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
        Me.btnStfMan = New System.Windows.Forms.Button()
        Me.btnChgPsw = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStfMan
        '
        Me.btnStfMan.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfMan.ForeColor = System.Drawing.Color.Blue
        Me.btnStfMan.Location = New System.Drawing.Point(233, 20)
        Me.btnStfMan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStfMan.Name = "btnStfMan"
        Me.btnStfMan.Size = New System.Drawing.Size(152, 60)
        Me.btnStfMan.TabIndex = 0
        Me.btnStfMan.Text = "&Staff Mantainance"
        Me.btnStfMan.UseVisualStyleBackColor = True
        '
        'btnChgPsw
        '
        Me.btnChgPsw.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgPsw.ForeColor = System.Drawing.Color.Blue
        Me.btnChgPsw.Location = New System.Drawing.Point(233, 103)
        Me.btnChgPsw.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChgPsw.Name = "btnChgPsw"
        Me.btnChgPsw.Size = New System.Drawing.Size(152, 60)
        Me.btnChgPsw.TabIndex = 1
        Me.btnChgPsw.Text = "&Change Password"
        Me.btnChgPsw.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.Blue
        Me.btnGenerateReport.Location = New System.Drawing.Point(233, 188)
        Me.btnGenerateReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(152, 60)
        Me.btnGenerateReport.TabIndex = 2
        Me.btnGenerateReport.Text = "&Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Blue
        Me.btnLogout.Location = New System.Drawing.Point(233, 271)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(152, 60)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnOrder.Location = New System.Drawing.Point(432, 103)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(140, 60)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Order Module"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnChgPsw)
        Me.Controls.Add(Me.btnStfMan)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStfMan As Button
    Friend WithEvents btnChgPsw As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnOrder As Button
End Class
