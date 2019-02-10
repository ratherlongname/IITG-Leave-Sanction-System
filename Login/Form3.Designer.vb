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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabctrlMainTabs = New System.Windows.Forms.TabControl()
        Me.tabpgViewLeaves = New System.Windows.Forms.TabPage()
        Me.OLD_CHECKBOX = New System.Windows.Forms.RadioButton()
        Me.NEWEST_CHECKBOX = New System.Windows.Forms.RadioButton()
        Me.lblViewLeavesAscOrDesc = New System.Windows.Forms.Label()
        Me.btnViewLeavesRefresh = New System.Windows.Forms.Button()
        Me.lblViewLeavesStatus = New System.Windows.Forms.Label()
        Me.lblViewLeavesTypeOfLeave = New System.Windows.Forms.Label()
        Me.SORT_DROPBOX = New System.Windows.Forms.ComboBox()
        Me.lblViewLeavesSortBy = New System.Windows.Forms.Label()
        Me.lsviewViewLeavesListOfLeaves = New System.Windows.Forms.ListView()
        Me.colhdrDateTimeOfApplication = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrLeaveID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrTypeOfLeave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrStartDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrEndDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colhdrStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabpgNewLeaves = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.E_Date = New System.Windows.Forms.TextBox()
        Me.Date_Calc = New System.Windows.Forms.MonthCalendar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Type_Of_Leave = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.S_Date = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Submit_new = New System.Windows.Forms.Button()
        Me.Remark_Box = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabpgLeavesToApprove = New System.Windows.Forms.TabPage()
        Me.APPROVED = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabpgNotifications = New System.Windows.Forms.TabPage()
        Me.NOTIFICATIONS = New System.Windows.Forms.ListView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ORDINARY = New System.Windows.Forms.CheckBox()
        Me.PENDING = New System.Windows.Forms.CheckBox()
        Me.REJECTED = New System.Windows.Forms.CheckBox()
        Me.ACCEPTED = New System.Windows.Forms.CheckBox()
        Me.ACADEMIC = New System.Windows.Forms.CheckBox()
        Me.MEDICAL = New System.Windows.Forms.CheckBox()
        Me.CANCELLED = New System.Windows.Forms.CheckBox()
        Me.tabctrlMainTabs.SuspendLayout()
        Me.tabpgViewLeaves.SuspendLayout()
        Me.tabpgNewLeaves.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpgLeavesToApprove.SuspendLayout()
        Me.tabpgNotifications.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
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
        Me.tabctrlMainTabs.Location = New System.Drawing.Point(203, 16)
        Me.tabctrlMainTabs.Margin = New System.Windows.Forms.Padding(4)
        Me.tabctrlMainTabs.Name = "tabctrlMainTabs"
        Me.tabctrlMainTabs.SelectedIndex = 0
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(1214, 719)
        Me.tabctrlMainTabs.TabIndex = 4
        '
        'tabpgViewLeaves
        '
        Me.tabpgViewLeaves.Controls.Add(Me.CANCELLED)
        Me.tabpgViewLeaves.Controls.Add(Me.MEDICAL)
        Me.tabpgViewLeaves.Controls.Add(Me.ACADEMIC)
        Me.tabpgViewLeaves.Controls.Add(Me.ACCEPTED)
        Me.tabpgViewLeaves.Controls.Add(Me.REJECTED)
        Me.tabpgViewLeaves.Controls.Add(Me.PENDING)
        Me.tabpgViewLeaves.Controls.Add(Me.ORDINARY)
        Me.tabpgViewLeaves.Controls.Add(Me.OLD_CHECKBOX)
        Me.tabpgViewLeaves.Controls.Add(Me.NEWEST_CHECKBOX)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesAscOrDesc)
        Me.tabpgViewLeaves.Controls.Add(Me.btnViewLeavesRefresh)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesStatus)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesTypeOfLeave)
        Me.tabpgViewLeaves.Controls.Add(Me.SORT_DROPBOX)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesSortBy)
        Me.tabpgViewLeaves.Controls.Add(Me.lsviewViewLeavesListOfLeaves)
        Me.tabpgViewLeaves.Location = New System.Drawing.Point(4, 25)
        Me.tabpgViewLeaves.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpgViewLeaves.Name = "tabpgViewLeaves"
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(1206, 690)
        Me.tabpgViewLeaves.TabIndex = 0
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
        '
        'OLD_CHECKBOX
        '
        Me.OLD_CHECKBOX.AutoSize = True
        Me.OLD_CHECKBOX.Location = New System.Drawing.Point(115, 68)
        Me.OLD_CHECKBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.OLD_CHECKBOX.Name = "OLD_CHECKBOX"
        Me.OLD_CHECKBOX.Size = New System.Drawing.Size(101, 21)
        Me.OLD_CHECKBOX.TabIndex = 10
        Me.OLD_CHECKBOX.Text = "Oldest First"
        Me.OLD_CHECKBOX.UseVisualStyleBackColor = True
        '
        'NEWEST_CHECKBOX
        '
        Me.NEWEST_CHECKBOX.AutoSize = True
        Me.NEWEST_CHECKBOX.Checked = True
        Me.NEWEST_CHECKBOX.Location = New System.Drawing.Point(115, 39)
        Me.NEWEST_CHECKBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.NEWEST_CHECKBOX.Name = "NEWEST_CHECKBOX"
        Me.NEWEST_CHECKBOX.Size = New System.Drawing.Size(106, 21)
        Me.NEWEST_CHECKBOX.TabIndex = 9
        Me.NEWEST_CHECKBOX.TabStop = True
        Me.NEWEST_CHECKBOX.Text = "Newest First"
        Me.NEWEST_CHECKBOX.UseVisualStyleBackColor = True
        '
        'lblViewLeavesAscOrDesc
        '
        Me.lblViewLeavesAscOrDesc.AutoSize = True
        Me.lblViewLeavesAscOrDesc.Location = New System.Drawing.Point(1, 39)
        Me.lblViewLeavesAscOrDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewLeavesAscOrDesc.Name = "lblViewLeavesAscOrDesc"
        Me.lblViewLeavesAscOrDesc.Size = New System.Drawing.Size(49, 17)
        Me.lblViewLeavesAscOrDesc.TabIndex = 8
        Me.lblViewLeavesAscOrDesc.Text = "Order:"
        '
        'btnViewLeavesRefresh
        '
        Me.btnViewLeavesRefresh.Location = New System.Drawing.Point(4, 355)
        Me.btnViewLeavesRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewLeavesRefresh.Name = "btnViewLeavesRefresh"
        Me.btnViewLeavesRefresh.Size = New System.Drawing.Size(223, 28)
        Me.btnViewLeavesRefresh.TabIndex = 7
        Me.btnViewLeavesRefresh.Text = "Refresh"
        Me.btnViewLeavesRefresh.UseVisualStyleBackColor = True
        '
        'lblViewLeavesStatus
        '
        Me.lblViewLeavesStatus.AutoSize = True
        Me.lblViewLeavesStatus.Location = New System.Drawing.Point(7, 177)
        Me.lblViewLeavesStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewLeavesStatus.Name = "lblViewLeavesStatus"
        Me.lblViewLeavesStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblViewLeavesStatus.TabIndex = 5
        Me.lblViewLeavesStatus.Text = "Status:"
        '
        'lblViewLeavesTypeOfLeave
        '
        Me.lblViewLeavesTypeOfLeave.AutoSize = True
        Me.lblViewLeavesTypeOfLeave.Location = New System.Drawing.Point(1, 96)
        Me.lblViewLeavesTypeOfLeave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewLeavesTypeOfLeave.Name = "lblViewLeavesTypeOfLeave"
        Me.lblViewLeavesTypeOfLeave.Size = New System.Drawing.Size(103, 17)
        Me.lblViewLeavesTypeOfLeave.TabIndex = 3
        Me.lblViewLeavesTypeOfLeave.Text = "Type of Leave:"
        '
        'SORT_DROPBOX
        '
        Me.SORT_DROPBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SORT_DROPBOX.FormattingEnabled = True
        Me.SORT_DROPBOX.Items.AddRange(New Object() {"Date / Time Applied", "Start Date", "End Date"})
        Me.SORT_DROPBOX.Location = New System.Drawing.Point(115, 7)
        Me.SORT_DROPBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.SORT_DROPBOX.Name = "SORT_DROPBOX"
        Me.SORT_DROPBOX.Size = New System.Drawing.Size(112, 24)
        Me.SORT_DROPBOX.TabIndex = 2
        '
        'lblViewLeavesSortBy
        '
        Me.lblViewLeavesSortBy.AutoSize = True
        Me.lblViewLeavesSortBy.Location = New System.Drawing.Point(1, 11)
        Me.lblViewLeavesSortBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewLeavesSortBy.Name = "lblViewLeavesSortBy"
        Me.lblViewLeavesSortBy.Size = New System.Drawing.Size(58, 17)
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
        Me.lsviewViewLeavesListOfLeaves.Location = New System.Drawing.Point(236, 7)
        Me.lsviewViewLeavesListOfLeaves.Margin = New System.Windows.Forms.Padding(4)
        Me.lsviewViewLeavesListOfLeaves.Name = "lsviewViewLeavesListOfLeaves"
        Me.lsviewViewLeavesListOfLeaves.Size = New System.Drawing.Size(778, 389)
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
        Me.tabpgNewLeaves.Controls.Add(Me.dgv)
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
        Me.tabpgNewLeaves.Location = New System.Drawing.Point(4, 25)
        Me.tabpgNewLeaves.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpgNewLeaves.Name = "tabpgNewLeaves"
        Me.tabpgNewLeaves.Size = New System.Drawing.Size(1206, 690)
        Me.tabpgNewLeaves.TabIndex = 1
        Me.tabpgNewLeaves.Text = "New Leaves"
        Me.tabpgNewLeaves.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(620, 158)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(240, 150)
        Me.dgv.TabIndex = 22
        '
        'E_Date
        '
        Me.E_Date.Enabled = False
        Me.E_Date.Location = New System.Drawing.Point(263, 388)
        Me.E_Date.Margin = New System.Windows.Forms.Padding(4)
        Me.E_Date.Name = "E_Date"
        Me.E_Date.Size = New System.Drawing.Size(159, 22)
        Me.E_Date.TabIndex = 21
        '
        'Date_Calc
        '
        Me.Date_Calc.Location = New System.Drawing.Point(263, 70)
        Me.Date_Calc.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.Date_Calc.MaxSelectionCount = 365
        Me.Date_Calc.Name = "Date_Calc"
        Me.Date_Calc.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(152, 393)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ending Date"
        '
        'Type_Of_Leave
        '
        Me.Type_Of_Leave.FormattingEnabled = True
        Me.Type_Of_Leave.Items.AddRange(New Object() {"Ordinary", "Medical", "Academic"})
        Me.Type_Of_Leave.Location = New System.Drawing.Point(263, 17)
        Me.Type_Of_Leave.Margin = New System.Windows.Forms.Padding(4)
        Me.Type_Of_Leave.Name = "Type_Of_Leave"
        Me.Type_Of_Leave.Size = New System.Drawing.Size(179, 24)
        Me.Type_Of_Leave.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 336)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Starting Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Type of Leave"
        '
        'S_Date
        '
        Me.S_Date.Enabled = False
        Me.S_Date.Location = New System.Drawing.Point(263, 333)
        Me.S_Date.Margin = New System.Windows.Forms.Padding(4)
        Me.S_Date.Name = "S_Date"
        Me.S_Date.Size = New System.Drawing.Size(159, 22)
        Me.S_Date.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Duration of Leave"
        '
        'Submit_new
        '
        Me.Submit_new.Location = New System.Drawing.Point(332, 608)
        Me.Submit_new.Margin = New System.Windows.Forms.Padding(4)
        Me.Submit_new.Name = "Submit_new"
        Me.Submit_new.Size = New System.Drawing.Size(152, 38)
        Me.Submit_new.TabIndex = 17
        Me.Submit_new.Text = "SUBMIT"
        Me.Submit_new.UseVisualStyleBackColor = True
        '
        'Remark_Box
        '
        Me.Remark_Box.Location = New System.Drawing.Point(249, 456)
        Me.Remark_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Remark_Box.Name = "Remark_Box"
        Me.Remark_Box.Size = New System.Drawing.Size(301, 117)
        Me.Remark_Box.TabIndex = 15
        Me.Remark_Box.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 477)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Remarks (if any)"
        '
        'tabpgLeavesToApprove
        '
        Me.tabpgLeavesToApprove.Controls.Add(Me.APPROVED)
        Me.tabpgLeavesToApprove.Location = New System.Drawing.Point(4, 25)
        Me.tabpgLeavesToApprove.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpgLeavesToApprove.Name = "tabpgLeavesToApprove"
        Me.tabpgLeavesToApprove.Size = New System.Drawing.Size(1206, 690)
        Me.tabpgLeavesToApprove.TabIndex = 2
        Me.tabpgLeavesToApprove.Text = "Leaves to Approve"
        Me.tabpgLeavesToApprove.UseVisualStyleBackColor = True
        '
        'APPROVED
        '
        Me.APPROVED.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.APPROVED.Location = New System.Drawing.Point(244, 54)
        Me.APPROVED.Name = "APPROVED"
        Me.APPROVED.Size = New System.Drawing.Size(572, 319)
        Me.APPROVED.TabIndex = 0
        Me.APPROVED.UseCompatibleStateImageBehavior = False
        Me.APPROVED.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LEAVE_ID"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "APPLICANT"
        Me.ColumnHeader2.Width = 93
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE/TIME APPLIED"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "START DATE"
        Me.ColumnHeader4.Width = 137
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "END DATE"
        Me.ColumnHeader5.Width = 84
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TYPE OF LEAVE"
        Me.ColumnHeader6.Width = 267
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Controls.Add(Me.NOTIFICATIONS)
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 25)
        Me.tabpgNotifications.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(1206, 690)
        Me.tabpgNotifications.TabIndex = 3
        Me.tabpgNotifications.Text = "Notifications"
        Me.tabpgNotifications.UseVisualStyleBackColor = True
        '
        'NOTIFICATIONS
        '
        Me.NOTIFICATIONS.Location = New System.Drawing.Point(235, 55)
        Me.NOTIFICATIONS.Name = "NOTIFICATIONS"
        Me.NOTIFICATIONS.Size = New System.Drawing.Size(572, 319)
        Me.NOTIFICATIONS.TabIndex = 1
        Me.NOTIFICATIONS.UseCompatibleStateImageBehavior = False
        Me.NOTIFICATIONS.View = System.Windows.Forms.View.Details
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(20, 244)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(176, 28)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(52, 343)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 11
        Me.Edit.Text = "EDIT"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Balances"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ORDINARY
        '
        Me.ORDINARY.AutoSize = True
        Me.ORDINARY.Location = New System.Drawing.Point(111, 96)
        Me.ORDINARY.Name = "ORDINARY"
        Me.ORDINARY.Size = New System.Drawing.Size(102, 21)
        Me.ORDINARY.TabIndex = 11
        Me.ORDINARY.Text = "ORDINARY"
        Me.ORDINARY.UseVisualStyleBackColor = True
        '
        'PENDING
        '
        Me.PENDING.AutoSize = True
        Me.PENDING.Location = New System.Drawing.Point(68, 230)
        Me.PENDING.Name = "PENDING"
        Me.PENDING.Size = New System.Drawing.Size(82, 21)
        Me.PENDING.TabIndex = 12
        Me.PENDING.Text = "Pending"
        Me.PENDING.UseVisualStyleBackColor = True
        '
        'REJECTED
        '
        Me.REJECTED.AutoSize = True
        Me.REJECTED.Location = New System.Drawing.Point(68, 203)
        Me.REJECTED.Name = "REJECTED"
        Me.REJECTED.Size = New System.Drawing.Size(86, 21)
        Me.REJECTED.TabIndex = 13
        Me.REJECTED.Text = "Rejected"
        Me.REJECTED.UseVisualStyleBackColor = True
        '
        'ACCEPTED
        '
        Me.ACCEPTED.AutoSize = True
        Me.ACCEPTED.Location = New System.Drawing.Point(68, 177)
        Me.ACCEPTED.Name = "ACCEPTED"
        Me.ACCEPTED.Size = New System.Drawing.Size(89, 21)
        Me.ACCEPTED.TabIndex = 14
        Me.ACCEPTED.Text = "Accepted"
        Me.ACCEPTED.UseVisualStyleBackColor = True
        '
        'ACADEMIC
        '
        Me.ACADEMIC.AutoSize = True
        Me.ACADEMIC.Location = New System.Drawing.Point(111, 150)
        Me.ACADEMIC.Name = "ACADEMIC"
        Me.ACADEMIC.Size = New System.Drawing.Size(99, 21)
        Me.ACADEMIC.TabIndex = 15
        Me.ACADEMIC.Text = "ACADEMIC"
        Me.ACADEMIC.UseVisualStyleBackColor = True
        '
        'MEDICAL
        '
        Me.MEDICAL.AutoSize = True
        Me.MEDICAL.Location = New System.Drawing.Point(111, 123)
        Me.MEDICAL.Name = "MEDICAL"
        Me.MEDICAL.Size = New System.Drawing.Size(89, 21)
        Me.MEDICAL.TabIndex = 16
        Me.MEDICAL.Text = "MEDICAL"
        Me.MEDICAL.UseVisualStyleBackColor = True
        '
        'CANCELLED
        '
        Me.CANCELLED.AutoSize = True
        Me.CANCELLED.Location = New System.Drawing.Point(68, 257)
        Me.CANCELLED.Name = "CANCELLED"
        Me.CANCELLED.Size = New System.Drawing.Size(92, 21)
        Me.CANCELLED.TabIndex = 17
        Me.CANCELLED.Text = "Cancelled"
        Me.CANCELLED.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1430, 748)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabctrlMainTabs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.tabctrlMainTabs.ResumeLayout(False)
        Me.tabpgViewLeaves.ResumeLayout(False)
        Me.tabpgViewLeaves.PerformLayout()
        Me.tabpgNewLeaves.ResumeLayout(False)
        Me.tabpgNewLeaves.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpgLeavesToApprove.ResumeLayout(False)
        Me.tabpgNotifications.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents SORT_DROPBOX As System.Windows.Forms.ComboBox
    Friend WithEvents lblViewLeavesSortBy As System.Windows.Forms.Label
    Friend WithEvents lblViewLeavesTypeOfLeave As System.Windows.Forms.Label
    Friend WithEvents lblViewLeavesStatus As System.Windows.Forms.Label
    Friend WithEvents btnViewLeavesRefresh As System.Windows.Forms.Button
    Friend WithEvents NEWEST_CHECKBOX As System.Windows.Forms.RadioButton
    Friend WithEvents lblViewLeavesAscOrDesc As System.Windows.Forms.Label
    Friend WithEvents OLD_CHECKBOX As System.Windows.Forms.RadioButton
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
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents APPROVED As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NOTIFICATIONS As System.Windows.Forms.ListView
    Friend WithEvents CANCELLED As System.Windows.Forms.CheckBox
    Friend WithEvents MEDICAL As System.Windows.Forms.CheckBox
    Friend WithEvents ACADEMIC As System.Windows.Forms.CheckBox
    Friend WithEvents ACCEPTED As System.Windows.Forms.CheckBox
    Friend WithEvents REJECTED As System.Windows.Forms.CheckBox
    Friend WithEvents PENDING As System.Windows.Forms.CheckBox
    Friend WithEvents ORDINARY As System.Windows.Forms.CheckBox
End Class
