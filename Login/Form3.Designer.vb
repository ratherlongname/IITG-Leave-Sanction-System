<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabctrlMainTabs = New System.Windows.Forms.TabControl()
        Me.tabpgViewLeaves = New System.Windows.Forms.TabPage()
        Me.tabpgNewLeaves = New System.Windows.Forms.TabPage()
        Me.E_Date = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.S_Date = New System.Windows.Forms.TextBox()
        Me.Submit_new = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Remark_Box = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Date_Calc = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Type_Of_Leave = New System.Windows.Forms.ComboBox()
        Me.tabpgLeavesToApprove = New System.Windows.Forms.TabPage()
        Me.tabpgNotifications = New System.Windows.Forms.TabPage()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.tabctrlMainTabs.SuspendLayout()
        Me.tabpgNewLeaves.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'tabctrlMainTabs
        '
        Me.tabctrlMainTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgViewLeaves)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgNewLeaves)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgLeavesToApprove)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgNotifications)
        Me.tabctrlMainTabs.Location = New System.Drawing.Point(150, 12)
        Me.tabctrlMainTabs.Name = "tabctrlMainTabs"
        Me.tabctrlMainTabs.SelectedIndex = 0
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(720, 513)
        Me.tabctrlMainTabs.TabIndex = 4
        '
        'tabpgViewLeaves
        '
        Me.tabpgViewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgViewLeaves.Name = "tabpgViewLeaves"
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(712, 487)
        Me.tabpgViewLeaves.TabIndex = 0
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
        '
        'tabpgNewLeaves
        '
        Me.tabpgNewLeaves.Controls.Add(Me.E_Date)
        Me.tabpgNewLeaves.Controls.Add(Me.Label9)
        Me.tabpgNewLeaves.Controls.Add(Me.Label8)
        Me.tabpgNewLeaves.Controls.Add(Me.S_Date)
        Me.tabpgNewLeaves.Controls.Add(Me.Submit_new)
        Me.tabpgNewLeaves.Controls.Add(Me.Label7)
        Me.tabpgNewLeaves.Controls.Add(Me.Remark_Box)
        Me.tabpgNewLeaves.Controls.Add(Me.Label6)
        Me.tabpgNewLeaves.Controls.Add(Me.Date_Calc)
        Me.tabpgNewLeaves.Controls.Add(Me.Label5)
        Me.tabpgNewLeaves.Controls.Add(Me.Type_Of_Leave)
        Me.tabpgNewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNewLeaves.Name = "tabpgNewLeaves"
        Me.tabpgNewLeaves.Size = New System.Drawing.Size(712, 487)
        Me.tabpgNewLeaves.TabIndex = 1
        Me.tabpgNewLeaves.Text = "New Leaves"
        Me.tabpgNewLeaves.UseVisualStyleBackColor = True
        '
        'E_Date
        '
        Me.E_Date.Enabled = False
        Me.E_Date.Location = New System.Drawing.Point(279, 274)
        Me.E_Date.Name = "E_Date"
        Me.E_Date.Size = New System.Drawing.Size(120, 20)
        Me.E_Date.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Ending Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Starting Date"
        '
        'S_Date
        '
        Me.S_Date.Enabled = False
        Me.S_Date.Location = New System.Drawing.Point(279, 245)
        Me.S_Date.Name = "S_Date"
        Me.S_Date.Size = New System.Drawing.Size(120, 20)
        Me.S_Date.TabIndex = 7
        '
        'Submit_new
        '
        Me.Submit_new.Location = New System.Drawing.Point(321, 428)
        Me.Submit_new.Name = "Submit_new"
        Me.Submit_new.Size = New System.Drawing.Size(114, 31)
        Me.Submit_new.TabIndex = 6
        Me.Submit_new.Text = "SUBMIT"
        Me.Submit_new.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Remarks (if any)"
        '
        'Remark_Box
        '
        Me.Remark_Box.Location = New System.Drawing.Point(279, 304)
        Me.Remark_Box.Name = "Remark_Box"
        Me.Remark_Box.Size = New System.Drawing.Size(227, 96)
        Me.Remark_Box.TabIndex = 4
        Me.Remark_Box.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Duration of Leave"
        '
        'Date_Calc
        '
        Me.Date_Calc.Location = New System.Drawing.Point(279, 70)
        Me.Date_Calc.MaxSelectionCount = 365
        Me.Date_Calc.Name = "Date_Calc"
        Me.Date_Calc.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Type of Leave"
        '
        'Type_Of_Leave
        '
        Me.Type_Of_Leave.FormattingEnabled = True
        Me.Type_Of_Leave.Items.AddRange(New Object() {"Ordinary", "Medical", "Academic"})
        Me.Type_Of_Leave.Location = New System.Drawing.Point(279, 27)
        Me.Type_Of_Leave.Name = "Type_Of_Leave"
        Me.Type_Of_Leave.Size = New System.Drawing.Size(135, 21)
        Me.Type_Of_Leave.TabIndex = 0
        '
        'tabpgLeavesToApprove
        '
        Me.tabpgLeavesToApprove.Location = New System.Drawing.Point(4, 22)
        Me.tabpgLeavesToApprove.Name = "tabpgLeavesToApprove"
        Me.tabpgLeavesToApprove.Size = New System.Drawing.Size(712, 487)
        Me.tabpgLeavesToApprove.TabIndex = 2
        Me.tabpgLeavesToApprove.Text = "Leaves to Approve"
        Me.tabpgLeavesToApprove.UseVisualStyleBackColor = True
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(712, 487)
        Me.tabpgNotifications.TabIndex = 3
        Me.tabpgNotifications.Text = "Notifications"
        Me.tabpgNotifications.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 483)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 23)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 537)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabctrlMainTabs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.tabctrlMainTabs.ResumeLayout(False)
        Me.tabpgNewLeaves.ResumeLayout(False)
        Me.tabpgNewLeaves.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabctrlMainTabs As System.Windows.Forms.TabControl
    Friend WithEvents tabpgViewLeaves As System.Windows.Forms.TabPage
    Friend WithEvents tabpgNewLeaves As System.Windows.Forms.TabPage
    Friend WithEvents tabpgLeavesToApprove As System.Windows.Forms.TabPage
    Friend WithEvents tabpgNotifications As System.Windows.Forms.TabPage
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Type_Of_Leave As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Date_Calc As System.Windows.Forms.MonthCalendar
    Friend WithEvents Submit_new As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Remark_Box As System.Windows.Forms.RichTextBox
    Friend WithEvents S_Date As System.Windows.Forms.TextBox
    Friend WithEvents E_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
