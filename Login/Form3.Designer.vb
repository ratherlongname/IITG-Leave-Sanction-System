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
        Me.rdiobtnViewLeavesOldestFirst = New System.Windows.Forms.RadioButton()
        Me.rdiobtnViewLeavesNewestFirst = New System.Windows.Forms.RadioButton()
        Me.lblViewLeavesAscOrDesc = New System.Windows.Forms.Label()
        Me.btnViewLeavesRefresh = New System.Windows.Forms.Button()
        Me.chkdlsbxViewLeavesStatus = New System.Windows.Forms.CheckedListBox()
        Me.lblViewLeavesStatus = New System.Windows.Forms.Label()
        Me.chkdlsbxViewLeavesTypeOfLeave = New System.Windows.Forms.CheckedListBox()
        Me.lblViewLeavesTypeOfLeave = New System.Windows.Forms.Label()
        Me.cmbbxViewLeavesSortBy = New System.Windows.Forms.ComboBox()
        Me.lblViewLeavesSortBy = New System.Windows.Forms.Label()
        Me.lsviewViewLeavesListOfLeaves = New System.Windows.Forms.ListView()
        Me.colhdrDateTimeOfApplication = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrLeaveID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrTypeOfLeave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrStartDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrEndDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabpgNewLeaves = New System.Windows.Forms.TabPage()
        Me.tabpgLeavesToApprove = New System.Windows.Forms.TabPage()
        Me.tabpgNotifications = New System.Windows.Forms.TabPage()
        Me.btnLogout = New System.Windows.Forms.Button()
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
        Me.tabctrlMainTabs.SuspendLayout()
        Me.tabpgViewLeaves.SuspendLayout()
        Me.tabpgNewLeaves.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 173)
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
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(723, 584)
        Me.tabctrlMainTabs.TabIndex = 4
        '
        'tabpgViewLeaves
        '
        Me.tabpgViewLeaves.Controls.Add(Me.rdiobtnViewLeavesOldestFirst)
        Me.tabpgViewLeaves.Controls.Add(Me.rdiobtnViewLeavesNewestFirst)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesAscOrDesc)
        Me.tabpgViewLeaves.Controls.Add(Me.btnViewLeavesRefresh)
        Me.tabpgViewLeaves.Controls.Add(Me.chkdlsbxViewLeavesStatus)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesStatus)
        Me.tabpgViewLeaves.Controls.Add(Me.chkdlsbxViewLeavesTypeOfLeave)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesTypeOfLeave)
        Me.tabpgViewLeaves.Controls.Add(Me.cmbbxViewLeavesSortBy)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesSortBy)
        Me.tabpgViewLeaves.Controls.Add(Me.lsviewViewLeavesListOfLeaves)
        Me.tabpgViewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgViewLeaves.Name = "tabpgViewLeaves"
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(715, 380)
        Me.tabpgViewLeaves.TabIndex = 0
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
        '
        'rdiobtnViewLeavesOldestFirst
        '
        Me.rdiobtnViewLeavesOldestFirst.AutoSize = True
        Me.rdiobtnViewLeavesOldestFirst.Location = New System.Drawing.Point(86, 55)
        Me.rdiobtnViewLeavesOldestFirst.Name = "rdiobtnViewLeavesOldestFirst"
        Me.rdiobtnViewLeavesOldestFirst.Size = New System.Drawing.Size(77, 17)
        Me.rdiobtnViewLeavesOldestFirst.TabIndex = 10
        Me.rdiobtnViewLeavesOldestFirst.Text = "Oldest First"
        Me.rdiobtnViewLeavesOldestFirst.UseVisualStyleBackColor = True
        '
        'rdiobtnViewLeavesNewestFirst
        '
        Me.rdiobtnViewLeavesNewestFirst.AutoSize = True
        Me.rdiobtnViewLeavesNewestFirst.Checked = True
        Me.rdiobtnViewLeavesNewestFirst.Location = New System.Drawing.Point(86, 32)
        Me.rdiobtnViewLeavesNewestFirst.Name = "rdiobtnViewLeavesNewestFirst"
        Me.rdiobtnViewLeavesNewestFirst.Size = New System.Drawing.Size(83, 17)
        Me.rdiobtnViewLeavesNewestFirst.TabIndex = 9
        Me.rdiobtnViewLeavesNewestFirst.TabStop = True
        Me.rdiobtnViewLeavesNewestFirst.Text = "Newest First"
        Me.rdiobtnViewLeavesNewestFirst.UseVisualStyleBackColor = True
        '
        'lblViewLeavesAscOrDesc
        '
        Me.lblViewLeavesAscOrDesc.AutoSize = True
        Me.lblViewLeavesAscOrDesc.Location = New System.Drawing.Point(1, 32)
        Me.lblViewLeavesAscOrDesc.Name = "lblViewLeavesAscOrDesc"
        Me.lblViewLeavesAscOrDesc.Size = New System.Drawing.Size(36, 13)
        Me.lblViewLeavesAscOrDesc.TabIndex = 8
        Me.lblViewLeavesAscOrDesc.Text = "Order:"
        '
        'btnViewLeavesRefresh
        '
        Me.btnViewLeavesRefresh.Location = New System.Drawing.Point(3, 225)
        Me.btnViewLeavesRefresh.Name = "btnViewLeavesRefresh"
        Me.btnViewLeavesRefresh.Size = New System.Drawing.Size(167, 23)
        Me.btnViewLeavesRefresh.TabIndex = 7
        Me.btnViewLeavesRefresh.Text = "Refresh"
        Me.btnViewLeavesRefresh.UseVisualStyleBackColor = True
        '
        'chkdlsbxViewLeavesStatus
        '
        Me.chkdlsbxViewLeavesStatus.CheckOnClick = True
        Me.chkdlsbxViewLeavesStatus.FormattingEnabled = True
        Me.chkdlsbxViewLeavesStatus.Items.AddRange(New Object() {"Pending", "Accepted", "Rejected", "Cancelled"})
        Me.chkdlsbxViewLeavesStatus.Location = New System.Drawing.Point(86, 133)
        Me.chkdlsbxViewLeavesStatus.Name = "chkdlsbxViewLeavesStatus"
        Me.chkdlsbxViewLeavesStatus.Size = New System.Drawing.Size(85, 64)
        Me.chkdlsbxViewLeavesStatus.TabIndex = 6
        '
        'lblViewLeavesStatus
        '
        Me.lblViewLeavesStatus.AutoSize = True
        Me.lblViewLeavesStatus.Location = New System.Drawing.Point(1, 133)
        Me.lblViewLeavesStatus.Name = "lblViewLeavesStatus"
        Me.lblViewLeavesStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblViewLeavesStatus.TabIndex = 5
        Me.lblViewLeavesStatus.Text = "Status:"
        '
        'chkdlsbxViewLeavesTypeOfLeave
        '
        Me.chkdlsbxViewLeavesTypeOfLeave.CheckOnClick = True
        Me.chkdlsbxViewLeavesTypeOfLeave.FormattingEnabled = True
        Me.chkdlsbxViewLeavesTypeOfLeave.Items.AddRange(New Object() {"Ordinary", "Medical", "Academic"})
        Me.chkdlsbxViewLeavesTypeOfLeave.Location = New System.Drawing.Point(86, 78)
        Me.chkdlsbxViewLeavesTypeOfLeave.Name = "chkdlsbxViewLeavesTypeOfLeave"
        Me.chkdlsbxViewLeavesTypeOfLeave.Size = New System.Drawing.Size(85, 49)
        Me.chkdlsbxViewLeavesTypeOfLeave.TabIndex = 4
        '
        'lblViewLeavesTypeOfLeave
        '
        Me.lblViewLeavesTypeOfLeave.AutoSize = True
        Me.lblViewLeavesTypeOfLeave.Location = New System.Drawing.Point(1, 78)
        Me.lblViewLeavesTypeOfLeave.Name = "lblViewLeavesTypeOfLeave"
        Me.lblViewLeavesTypeOfLeave.Size = New System.Drawing.Size(79, 13)
        Me.lblViewLeavesTypeOfLeave.TabIndex = 3
        Me.lblViewLeavesTypeOfLeave.Text = "Type of Leave:"
        '
        'cmbbxViewLeavesSortBy
        '
        Me.cmbbxViewLeavesSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxViewLeavesSortBy.FormattingEnabled = True
        Me.cmbbxViewLeavesSortBy.Items.AddRange(New Object() {"Date / Time Applied", "Start Date", "End Date"})
        Me.cmbbxViewLeavesSortBy.Location = New System.Drawing.Point(86, 6)
        Me.cmbbxViewLeavesSortBy.Name = "cmbbxViewLeavesSortBy"
        Me.cmbbxViewLeavesSortBy.Size = New System.Drawing.Size(85, 21)
        Me.cmbbxViewLeavesSortBy.TabIndex = 2
        '
        'lblViewLeavesSortBy
        '
        Me.lblViewLeavesSortBy.AutoSize = True
        Me.lblViewLeavesSortBy.Location = New System.Drawing.Point(1, 9)
        Me.lblViewLeavesSortBy.Name = "lblViewLeavesSortBy"
        Me.lblViewLeavesSortBy.Size = New System.Drawing.Size(44, 13)
        Me.lblViewLeavesSortBy.TabIndex = 1
        Me.lblViewLeavesSortBy.Text = "Sort By:"
        '
        'lsviewViewLeavesListOfLeaves
        '
        Me.lsviewViewLeavesListOfLeaves.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsviewViewLeavesListOfLeaves.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colhdrDateTimeOfApplication, Me.colhdrLeaveID, Me.colhdrTypeOfLeave, Me.colhdrStartDate, Me.colhdrEndDate, Me.colhdrStatus})
        Me.lsviewViewLeavesListOfLeaves.FullRowSelect = True
        Me.lsviewViewLeavesListOfLeaves.Location = New System.Drawing.Point(177, 6)
        Me.lsviewViewLeavesListOfLeaves.Name = "lsviewViewLeavesListOfLeaves"
        Me.lsviewViewLeavesListOfLeaves.Size = New System.Drawing.Size(437, 242)
        Me.lsviewViewLeavesListOfLeaves.TabIndex = 0
        Me.lsviewViewLeavesListOfLeaves.UseCompatibleStateImageBehavior = False
        Me.lsviewViewLeavesListOfLeaves.View = System.Windows.Forms.View.Details
        '
        'colhdrDateTimeOfApplication
        '
        Me.colhdrDateTimeOfApplication.Text = "Date / Time Applied"
        Me.colhdrDateTimeOfApplication.Width = 108
        '
        'colhdrLeaveID
        '
        Me.colhdrLeaveID.Text = "Leave ID"
        '
        'colhdrTypeOfLeave
        '
        Me.colhdrTypeOfLeave.Text = "Type of Leave"
        Me.colhdrTypeOfLeave.Width = 85
        '
        'colhdrStartDate
        '
        Me.colhdrStartDate.Text = "Start Date"
        '
        'colhdrEndDate
        '
        Me.colhdrEndDate.Text = "End Date"
        '
        'colhdrStatus
        '
        Me.colhdrStatus.Text = "Status"
        '
        'tabpgNewLeaves
        '
        Me.tabpgNewLeaves.Controls.Add(Me.E_Date)
        Me.tabpgNewLeaves.Controls.Add(Me.Date_Calc)
        Me.tabpgNewLeaves.Controls.Add(Me.Label9)
        Me.tabpgNewLeaves.Controls.Add(Me.Type_Of_Leave)
        Me.tabpgNewLeaves.Controls.Add(Me.Label8)
        Me.tabpgNewLeaves.Controls.Add(Me.Label5)
        Me.tabpgNewLeaves.Controls.Add(Me.S_Date)
        Me.tabpgNewLeaves.Controls.Add(Me.Label6)
        Me.tabpgNewLeaves.Controls.Add(Me.Submit_new)
        Me.tabpgNewLeaves.Controls.Add(Me.Remark_Box)
        Me.tabpgNewLeaves.Controls.Add(Me.Label7)
        Me.tabpgNewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNewLeaves.Name = "tabpgNewLeaves"
        Me.tabpgNewLeaves.Size = New System.Drawing.Size(715, 558)
        Me.tabpgNewLeaves.TabIndex = 1
        Me.tabpgNewLeaves.Text = "New Leaves"
        Me.tabpgNewLeaves.UseVisualStyleBackColor = True
        '
        'tabpgLeavesToApprove
        '
        Me.tabpgLeavesToApprove.Location = New System.Drawing.Point(4, 22)
        Me.tabpgLeavesToApprove.Name = "tabpgLeavesToApprove"
        Me.tabpgLeavesToApprove.Size = New System.Drawing.Size(715, 251)
        Me.tabpgLeavesToApprove.TabIndex = 2
        Me.tabpgLeavesToApprove.Text = "Leaves to Approve"
        Me.tabpgLeavesToApprove.UseVisualStyleBackColor = True
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(715, 251)
        Me.tabpgNotifications.TabIndex = 3
        Me.tabpgNotifications.Text = "Notifications"
        Me.tabpgNotifications.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(15, 198)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 23)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'E_Date
        '
        Me.E_Date.Enabled = False
        Me.E_Date.Location = New System.Drawing.Point(197, 261)
        Me.E_Date.Name = "E_Date"
        Me.E_Date.Size = New System.Drawing.Size(120, 20)
        Me.E_Date.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ending Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Starting Date"
        '
        'S_Date
        '
        Me.S_Date.Enabled = False
        Me.S_Date.Location = New System.Drawing.Point(197, 232)
        Me.S_Date.Name = "S_Date"
        Me.S_Date.Size = New System.Drawing.Size(120, 20)
        Me.S_Date.TabIndex = 18
        '
        'Submit_new
        '
        Me.Submit_new.Location = New System.Drawing.Point(239, 415)
        Me.Submit_new.Name = "Submit_new"
        Me.Submit_new.Size = New System.Drawing.Size(114, 31)
        Me.Submit_new.TabIndex = 17
        Me.Submit_new.Text = "SUBMIT"
        Me.Submit_new.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Remarks (if any)"
        '
        'Remark_Box
        '
        Me.Remark_Box.Location = New System.Drawing.Point(197, 291)
        Me.Remark_Box.Name = "Remark_Box"
        Me.Remark_Box.Size = New System.Drawing.Size(227, 96)
        Me.Remark_Box.TabIndex = 15
        Me.Remark_Box.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Duration of Leave"
        '
        'Date_Calc
        '
        Me.Date_Calc.Location = New System.Drawing.Point(197, 57)
        Me.Date_Calc.MaxSelectionCount = 365
        Me.Date_Calc.Name = "Date_Calc"
        Me.Date_Calc.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Type of Leave"
        '
        'Type_Of_Leave
        '
        Me.Type_Of_Leave.FormattingEnabled = True
        Me.Type_Of_Leave.Items.AddRange(New Object() {"Ordinary", "Medical", "Academic"})
        Me.Type_Of_Leave.Location = New System.Drawing.Point(197, 14)
        Me.Type_Of_Leave.Name = "Type_Of_Leave"
        Me.Type_Of_Leave.Size = New System.Drawing.Size(135, 21)
        Me.Type_Of_Leave.TabIndex = 11
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 608)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabctrlMainTabs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.tabctrlMainTabs.ResumeLayout(False)
        Me.tabpgViewLeaves.ResumeLayout(False)
        Me.tabpgViewLeaves.PerformLayout()
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
    Friend WithEvents lsviewViewLeavesListOfLeaves As System.Windows.Forms.ListView
    Friend WithEvents colhdrDateTimeOfApplication As System.Windows.Forms.ColumnHeader
    Friend WithEvents colhdrLeaveID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colhdrTypeOfLeave As System.Windows.Forms.ColumnHeader
    Friend WithEvents colhdrStartDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colhdrEndDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colhdrStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbbxViewLeavesSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblViewLeavesSortBy As System.Windows.Forms.Label
    Friend WithEvents chkdlsbxViewLeavesTypeOfLeave As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblViewLeavesTypeOfLeave As System.Windows.Forms.Label
    Friend WithEvents chkdlsbxViewLeavesStatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblViewLeavesStatus As System.Windows.Forms.Label
    Friend WithEvents btnViewLeavesRefresh As System.Windows.Forms.Button
    Friend WithEvents rdiobtnViewLeavesNewestFirst As System.Windows.Forms.RadioButton
    Friend WithEvents lblViewLeavesAscOrDesc As System.Windows.Forms.Label
    Friend WithEvents rdiobtnViewLeavesOldestFirst As System.Windows.Forms.RadioButton
    Friend WithEvents E_Date As System.Windows.Forms.TextBox
    Friend WithEvents Date_Calc As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Type_Of_Leave As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents S_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Submit_new As System.Windows.Forms.Button
    Friend WithEvents Remark_Box As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
