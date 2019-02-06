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
        Me.btnViewLeavesRefresh = New System.Windows.Forms.Button()
        Me.lblViewLeavesAscOrDesc = New System.Windows.Forms.Label()
        Me.rdiobtnViewLeavesNewestFirst = New System.Windows.Forms.RadioButton()
        Me.rdiobtnViewLeavesOldestFirst = New System.Windows.Forms.RadioButton()
        Me.tabctrlMainTabs.SuspendLayout()
        Me.tabpgViewLeaves.SuspendLayout()
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
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(723, 277)
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
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(715, 251)
        Me.tabpgViewLeaves.TabIndex = 0
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
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
        Me.tabpgNewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNewLeaves.Name = "tabpgNewLeaves"
        Me.tabpgNewLeaves.Size = New System.Drawing.Size(715, 210)
        Me.tabpgNewLeaves.TabIndex = 1
        Me.tabpgNewLeaves.Text = "New Leaves"
        Me.tabpgNewLeaves.UseVisualStyleBackColor = True
        '
        'tabpgLeavesToApprove
        '
        Me.tabpgLeavesToApprove.Location = New System.Drawing.Point(4, 22)
        Me.tabpgLeavesToApprove.Name = "tabpgLeavesToApprove"
        Me.tabpgLeavesToApprove.Size = New System.Drawing.Size(1155, 328)
        Me.tabpgLeavesToApprove.TabIndex = 2
        Me.tabpgLeavesToApprove.Text = "Leaves to Approve"
        Me.tabpgLeavesToApprove.UseVisualStyleBackColor = True
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(1155, 328)
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
        'btnViewLeavesRefresh
        '
        Me.btnViewLeavesRefresh.Location = New System.Drawing.Point(3, 225)
        Me.btnViewLeavesRefresh.Name = "btnViewLeavesRefresh"
        Me.btnViewLeavesRefresh.Size = New System.Drawing.Size(167, 23)
        Me.btnViewLeavesRefresh.TabIndex = 7
        Me.btnViewLeavesRefresh.Text = "Refresh"
        Me.btnViewLeavesRefresh.UseVisualStyleBackColor = True
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 301)
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
End Class
