<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainMenu
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
        Me.btnStfMan = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCust = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PaymentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStfMan
        '
        Me.btnStfMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfMan.ForeColor = System.Drawing.Color.Black
        Me.btnStfMan.Location = New System.Drawing.Point(29, 63)
        Me.btnStfMan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStfMan.Name = "btnStfMan"
        Me.btnStfMan.Size = New System.Drawing.Size(203, 74)
        Me.btnStfMan.TabIndex = 0
        Me.btnStfMan.Text = "&Staff Mantainance"
        Me.btnStfMan.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.Black
        Me.btnOrder.Location = New System.Drawing.Point(29, 167)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(203, 74)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "&Order Module"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.AccountToolStripMenuItem.Text = "&Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "&Change Password"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.SignOutToolStripMenuItem.Text = "&Sign Out"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.OrderReportToolStripMenuItem, Me.CustomerReportToolStripMenuItem, Me.PaymentReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.ReportToolStripMenuItem.Text = "View &Report"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StaffToolStripMenuItem.Text = "&Staff Report"
        '
        'OrderReportToolStripMenuItem
        '
        Me.OrderReportToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OrderReportToolStripMenuItem.Name = "OrderReportToolStripMenuItem"
        Me.OrderReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.OrderReportToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.OrderReportToolStripMenuItem.Text = "O&rder Report"
        '
        'CustomerReportToolStripMenuItem
        '
        Me.CustomerReportToolStripMenuItem.Name = "CustomerReportToolStripMenuItem"
        Me.CustomerReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CustomerReportToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CustomerReportToolStripMenuItem.Text = "&Customer Report"
        '
        'btnCust
        '
        Me.btnCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCust.ForeColor = System.Drawing.Color.Black
        Me.btnCust.Location = New System.Drawing.Point(255, 63)
        Me.btnCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCust.Name = "btnCust"
        Me.btnCust.Size = New System.Drawing.Size(203, 74)
        Me.btnCust.TabIndex = 6
        Me.btnCust.Text = "&Customer Mantainance"
        Me.btnCust.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(255, 167)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(203, 74)
        Me.btnMenu.TabIndex = 7
        Me.btnMenu.Text = "&Menu Mantainance"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'PaymentReportToolStripMenuItem
        '
        Me.PaymentReportToolStripMenuItem.Name = "PaymentReportToolStripMenuItem"
        Me.PaymentReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PaymentReportToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.PaymentReportToolStripMenuItem.Text = "&Payment Report "
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 270)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCust)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnStfMan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStfMan As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCust As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentReportToolStripMenuItem As ToolStripMenuItem
End Class
