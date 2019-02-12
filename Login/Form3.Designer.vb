<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabctrlMainTabs = New System.Windows.Forms.TabControl()
        Me.tabpgViewLeaves = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnViewLeavesView = New System.Windows.Forms.Button()
        Me.richtxtboxViewLeaves = New System.Windows.Forms.RichTextBox()
        Me.btnViewLeavesCancel = New System.Windows.Forms.Button()
        Me.CANCELLED = New System.Windows.Forms.CheckBox()
        Me.MEDICAL = New System.Windows.Forms.CheckBox()
        Me.ACADEMIC = New System.Windows.Forms.CheckBox()
        Me.ACCEPTED = New System.Windows.Forms.CheckBox()
        Me.REJECTED = New System.Windows.Forms.CheckBox()
        Me.PENDING = New System.Windows.Forms.CheckBox()
        Me.ORDINARY = New System.Windows.Forms.CheckBox()
        Me.OLD_CHECKBOX = New System.Windows.Forms.RadioButton()
        Me.NEWEST_CHECKBOX = New System.Windows.Forms.RadioButton()
        Me.lblViewLeavesAscOrDesc = New System.Windows.Forms.Label()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.E_Date = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Date_Calc = New System.Windows.Forms.MonthCalendar()
        Me.S_Date = New System.Windows.Forms.TextBox()
        Me.Submit_new = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Remark_Box = New System.Windows.Forms.RichTextBox()
        Me.Type_Of_Leave = New System.Windows.Forms.ComboBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabpgLeavesToApprove = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MEDICAL_2 = New System.Windows.Forms.CheckBox()
        Me.ACADEMIC_2 = New System.Windows.Forms.CheckBox()
        Me.ORDINARY_2 = New System.Windows.Forms.CheckBox()
        Me.OLDEST_2 = New System.Windows.Forms.RadioButton()
        Me.NEWEST_2 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DROPBOX_2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnLeavestobeApprovedReject = New System.Windows.Forms.Button()
        Me.richtxtboxLeavestobeApprovedRemarks = New System.Windows.Forms.RichTextBox()
        Me.btnLeavestobeApprovedAccept = New System.Windows.Forms.Button()
        Me.btnLeavestobeApprovedView = New System.Windows.Forms.Button()
        Me.APPROVED = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabpgNotifications = New System.Windows.Forms.TabPage()
        Me.VIEW_2 = New System.Windows.Forms.Button()
        Me.NOTIFICATIONS = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DISAPPROVE = New System.Windows.Forms.Button()
        Me.APPROVE = New System.Windows.Forms.Button()
        Me.VIEW = New System.Windows.Forms.Button()
        Me.ADMIN = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BALANCES = New System.Windows.Forms.Button()
        Me.VIEW_3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLeaSanSys = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabctrlMainTabs.SuspendLayout()
        Me.tabpgViewLeaves.SuspendLayout()
        Me.tabpgNewLeaves.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.tabpgLeavesToApprove.SuspendLayout()
        Me.tabpgNotifications.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabctrlMainTabs
        '
        Me.tabctrlMainTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabctrlMainTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgViewLeaves)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgNewLeaves)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgLeavesToApprove)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgNotifications)
        Me.tabctrlMainTabs.Controls.Add(Me.TabPage1)
        Me.tabctrlMainTabs.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.tabctrlMainTabs.Location = New System.Drawing.Point(214, 155)
        Me.tabctrlMainTabs.Multiline = True
        Me.tabctrlMainTabs.Name = "tabctrlMainTabs"
        Me.tabctrlMainTabs.SelectedIndex = 0
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(852, 526)
        Me.tabctrlMainTabs.TabIndex = 0
        '
        'tabpgViewLeaves
        '
        Me.tabpgViewLeaves.Controls.Add(Me.Label12)
        Me.tabpgViewLeaves.Controls.Add(Me.btnViewLeavesView)
        Me.tabpgViewLeaves.Controls.Add(Me.richtxtboxViewLeaves)
        Me.tabpgViewLeaves.Controls.Add(Me.btnViewLeavesCancel)
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
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesStatus)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesTypeOfLeave)
        Me.tabpgViewLeaves.Controls.Add(Me.SORT_DROPBOX)
        Me.tabpgViewLeaves.Controls.Add(Me.lblViewLeavesSortBy)
        Me.tabpgViewLeaves.Controls.Add(Me.lsviewViewLeavesListOfLeaves)
        Me.tabpgViewLeaves.Location = New System.Drawing.Point(4, 33)
        Me.tabpgViewLeaves.Name = "tabpgViewLeaves"
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(844, 489)
        Me.tabpgViewLeaves.TabIndex = 0
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Tomato
        Me.Label12.Location = New System.Drawing.Point(33, 327)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 19)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Remarks (If any)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewLeavesView
        '
        Me.btnViewLeavesView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnViewLeavesView.BackColor = System.Drawing.Color.Teal
        Me.btnViewLeavesView.FlatAppearance.BorderSize = 0
        Me.btnViewLeavesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewLeavesView.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnViewLeavesView.ForeColor = System.Drawing.Color.Honeydew
        Me.btnViewLeavesView.Location = New System.Drawing.Point(567, 323)
        Me.btnViewLeavesView.Margin = New System.Windows.Forms.Padding(0)
        Me.btnViewLeavesView.Name = "btnViewLeavesView"
        Me.btnViewLeavesView.Size = New System.Drawing.Size(253, 45)
        Me.btnViewLeavesView.TabIndex = 2
        Me.btnViewLeavesView.Text = "View Application"
        Me.btnViewLeavesView.UseVisualStyleBackColor = False
        '
        'richtxtboxViewLeaves
        '
        Me.richtxtboxViewLeaves.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.richtxtboxViewLeaves.BackColor = System.Drawing.Color.White
        Me.richtxtboxViewLeaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richtxtboxViewLeaves.Cursor = System.Windows.Forms.Cursors.Default
        Me.richtxtboxViewLeaves.Location = New System.Drawing.Point(26, 323)
        Me.richtxtboxViewLeaves.Margin = New System.Windows.Forms.Padding(0)
        Me.richtxtboxViewLeaves.Name = "richtxtboxViewLeaves"
        Me.richtxtboxViewLeaves.ReadOnly = True
        Me.richtxtboxViewLeaves.Size = New System.Drawing.Size(528, 100)
        Me.richtxtboxViewLeaves.TabIndex = 1
        Me.richtxtboxViewLeaves.Text = ""
        '
        'btnViewLeavesCancel
        '
        Me.btnViewLeavesCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnViewLeavesCancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btnViewLeavesCancel.FlatAppearance.BorderSize = 0
        Me.btnViewLeavesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewLeavesCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnViewLeavesCancel.ForeColor = System.Drawing.Color.White
        Me.btnViewLeavesCancel.Location = New System.Drawing.Point(567, 378)
        Me.btnViewLeavesCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnViewLeavesCancel.Name = "btnViewLeavesCancel"
        Me.btnViewLeavesCancel.Size = New System.Drawing.Size(253, 45)
        Me.btnViewLeavesCancel.TabIndex = 3
        Me.btnViewLeavesCancel.Text = "Cancel Application"
        Me.btnViewLeavesCancel.UseVisualStyleBackColor = False
        '
        'CANCELLED
        '
        Me.CANCELLED.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CANCELLED.AutoSize = True
        Me.CANCELLED.Location = New System.Drawing.Point(530, 46)
        Me.CANCELLED.Margin = New System.Windows.Forms.Padding(2)
        Me.CANCELLED.Name = "CANCELLED"
        Me.CANCELLED.Size = New System.Drawing.Size(92, 23)
        Me.CANCELLED.TabIndex = 17
        Me.CANCELLED.Text = "Cancelled"
        Me.CANCELLED.UseVisualStyleBackColor = True
        '
        'MEDICAL
        '
        Me.MEDICAL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MEDICAL.AutoSize = True
        Me.MEDICAL.Location = New System.Drawing.Point(635, 15)
        Me.MEDICAL.Margin = New System.Windows.Forms.Padding(2)
        Me.MEDICAL.Name = "MEDICAL"
        Me.MEDICAL.Size = New System.Drawing.Size(89, 23)
        Me.MEDICAL.TabIndex = 16
        Me.MEDICAL.Text = "MEDICAL"
        Me.MEDICAL.UseVisualStyleBackColor = True
        '
        'ACADEMIC
        '
        Me.ACADEMIC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ACADEMIC.AutoSize = True
        Me.ACADEMIC.Location = New System.Drawing.Point(728, 15)
        Me.ACADEMIC.Margin = New System.Windows.Forms.Padding(2)
        Me.ACADEMIC.Name = "ACADEMIC"
        Me.ACADEMIC.Size = New System.Drawing.Size(100, 23)
        Me.ACADEMIC.TabIndex = 15
        Me.ACADEMIC.Text = "ACADEMIC"
        Me.ACADEMIC.UseVisualStyleBackColor = True
        '
        'ACCEPTED
        '
        Me.ACCEPTED.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ACCEPTED.AutoSize = True
        Me.ACCEPTED.Location = New System.Drawing.Point(268, 46)
        Me.ACCEPTED.Margin = New System.Windows.Forms.Padding(2)
        Me.ACCEPTED.Name = "ACCEPTED"
        Me.ACCEPTED.Size = New System.Drawing.Size(88, 23)
        Me.ACCEPTED.TabIndex = 14
        Me.ACCEPTED.Text = "Accepted"
        Me.ACCEPTED.UseVisualStyleBackColor = True
        '
        'REJECTED
        '
        Me.REJECTED.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.REJECTED.AutoSize = True
        Me.REJECTED.Location = New System.Drawing.Point(360, 46)
        Me.REJECTED.Margin = New System.Windows.Forms.Padding(2)
        Me.REJECTED.Name = "REJECTED"
        Me.REJECTED.Size = New System.Drawing.Size(85, 23)
        Me.REJECTED.TabIndex = 13
        Me.REJECTED.Text = "Rejected"
        Me.REJECTED.UseVisualStyleBackColor = True
        '
        'PENDING
        '
        Me.PENDING.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PENDING.AutoSize = True
        Me.PENDING.Location = New System.Drawing.Point(446, 46)
        Me.PENDING.Margin = New System.Windows.Forms.Padding(2)
        Me.PENDING.Name = "PENDING"
        Me.PENDING.Size = New System.Drawing.Size(80, 23)
        Me.PENDING.TabIndex = 12
        Me.PENDING.Text = "Pending"
        Me.PENDING.UseVisualStyleBackColor = True
        '
        'ORDINARY
        '
        Me.ORDINARY.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ORDINARY.AutoSize = True
        Me.ORDINARY.Location = New System.Drawing.Point(532, 15)
        Me.ORDINARY.Margin = New System.Windows.Forms.Padding(2)
        Me.ORDINARY.Name = "ORDINARY"
        Me.ORDINARY.Size = New System.Drawing.Size(98, 23)
        Me.ORDINARY.TabIndex = 11
        Me.ORDINARY.Text = "ORDINARY"
        Me.ORDINARY.UseVisualStyleBackColor = True
        '
        'OLD_CHECKBOX
        '
        Me.OLD_CHECKBOX.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OLD_CHECKBOX.AutoSize = True
        Me.OLD_CHECKBOX.Location = New System.Drawing.Point(377, 15)
        Me.OLD_CHECKBOX.Name = "OLD_CHECKBOX"
        Me.OLD_CHECKBOX.Size = New System.Drawing.Size(101, 23)
        Me.OLD_CHECKBOX.TabIndex = 10
        Me.OLD_CHECKBOX.Text = "Oldest First"
        Me.OLD_CHECKBOX.UseVisualStyleBackColor = True
        '
        'NEWEST_CHECKBOX
        '
        Me.NEWEST_CHECKBOX.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NEWEST_CHECKBOX.AutoSize = True
        Me.NEWEST_CHECKBOX.Checked = True
        Me.NEWEST_CHECKBOX.Location = New System.Drawing.Point(264, 15)
        Me.NEWEST_CHECKBOX.Name = "NEWEST_CHECKBOX"
        Me.NEWEST_CHECKBOX.Size = New System.Drawing.Size(107, 23)
        Me.NEWEST_CHECKBOX.TabIndex = 9
        Me.NEWEST_CHECKBOX.TabStop = True
        Me.NEWEST_CHECKBOX.Text = "Newest First"
        Me.NEWEST_CHECKBOX.UseVisualStyleBackColor = True
        '
        'lblViewLeavesAscOrDesc
        '
        Me.lblViewLeavesAscOrDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblViewLeavesAscOrDesc.AutoSize = True
        Me.lblViewLeavesAscOrDesc.Location = New System.Drawing.Point(209, 17)
        Me.lblViewLeavesAscOrDesc.Name = "lblViewLeavesAscOrDesc"
        Me.lblViewLeavesAscOrDesc.Size = New System.Drawing.Size(52, 19)
        Me.lblViewLeavesAscOrDesc.TabIndex = 8
        Me.lblViewLeavesAscOrDesc.Text = "Order:"
        '
        'lblViewLeavesStatus
        '
        Me.lblViewLeavesStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblViewLeavesStatus.AutoSize = True
        Me.lblViewLeavesStatus.Location = New System.Drawing.Point(210, 48)
        Me.lblViewLeavesStatus.Name = "lblViewLeavesStatus"
        Me.lblViewLeavesStatus.Size = New System.Drawing.Size(52, 19)
        Me.lblViewLeavesStatus.TabIndex = 5
        Me.lblViewLeavesStatus.Text = "Status:"
        '
        'lblViewLeavesTypeOfLeave
        '
        Me.lblViewLeavesTypeOfLeave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblViewLeavesTypeOfLeave.AutoSize = True
        Me.lblViewLeavesTypeOfLeave.Location = New System.Drawing.Point(484, 17)
        Me.lblViewLeavesTypeOfLeave.Name = "lblViewLeavesTypeOfLeave"
        Me.lblViewLeavesTypeOfLeave.Size = New System.Drawing.Size(43, 19)
        Me.lblViewLeavesTypeOfLeave.TabIndex = 3
        Me.lblViewLeavesTypeOfLeave.Text = "Type:"
        '
        'SORT_DROPBOX
        '
        Me.SORT_DROPBOX.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SORT_DROPBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SORT_DROPBOX.FormattingEnabled = True
        Me.SORT_DROPBOX.Items.AddRange(New Object() {"Date / Time Applied", "Start Date", "End Date"})
        Me.SORT_DROPBOX.Location = New System.Drawing.Point(69, 12)
        Me.SORT_DROPBOX.Name = "SORT_DROPBOX"
        Me.SORT_DROPBOX.Size = New System.Drawing.Size(134, 29)
        Me.SORT_DROPBOX.TabIndex = 2
        '
        'lblViewLeavesSortBy
        '
        Me.lblViewLeavesSortBy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblViewLeavesSortBy.AutoSize = True
        Me.lblViewLeavesSortBy.Location = New System.Drawing.Point(7, 17)
        Me.lblViewLeavesSortBy.Name = "lblViewLeavesSortBy"
        Me.lblViewLeavesSortBy.Size = New System.Drawing.Size(59, 19)
        Me.lblViewLeavesSortBy.TabIndex = 1
        Me.lblViewLeavesSortBy.Text = "Sort By:"
        '
        'lsviewViewLeavesListOfLeaves
        '
        Me.lsviewViewLeavesListOfLeaves.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lsviewViewLeavesListOfLeaves.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsviewViewLeavesListOfLeaves.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colhdrDateTimeOfApplication, Me.colhdrLeaveID, Me.colhdrTypeOfLeave, Me.colhdrStartDate, Me.colhdrEndDate, Me.colhdrStatus})
        Me.lsviewViewLeavesListOfLeaves.FullRowSelect = True
        Me.lsviewViewLeavesListOfLeaves.HideSelection = False
        Me.lsviewViewLeavesListOfLeaves.Location = New System.Drawing.Point(26, 87)
        Me.lsviewViewLeavesListOfLeaves.MultiSelect = False
        Me.lsviewViewLeavesListOfLeaves.Name = "lsviewViewLeavesListOfLeaves"
        Me.lsviewViewLeavesListOfLeaves.Size = New System.Drawing.Size(794, 224)
        Me.lsviewViewLeavesListOfLeaves.TabIndex = 0
        Me.lsviewViewLeavesListOfLeaves.UseCompatibleStateImageBehavior = False
        Me.lsviewViewLeavesListOfLeaves.View = System.Windows.Forms.View.Details
        '
        'colhdrDateTimeOfApplication
        '
        Me.colhdrDateTimeOfApplication.Text = "Date/Time Applied"
        Me.colhdrDateTimeOfApplication.Width = 159
        '
        'colhdrLeaveID
        '
        Me.colhdrLeaveID.Text = "Leave ID"
        Me.colhdrLeaveID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colhdrLeaveID.Width = 173
        '
        'colhdrTypeOfLeave
        '
        Me.colhdrTypeOfLeave.Text = "Type of Leave"
        Me.colhdrTypeOfLeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colhdrTypeOfLeave.Width = 129
        '
        'colhdrStartDate
        '
        Me.colhdrStartDate.Text = "Start Date"
        Me.colhdrStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colhdrStartDate.Width = 100
        '
        'colhdrEndDate
        '
        Me.colhdrEndDate.Text = "End Date"
        Me.colhdrEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colhdrEndDate.Width = 99
        '
        'colhdrStatus
        '
        Me.colhdrStatus.Text = "Status"
        Me.colhdrStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colhdrStatus.Width = 134
        '
        'tabpgNewLeaves
        '
        Me.tabpgNewLeaves.BackColor = System.Drawing.Color.White
        Me.tabpgNewLeaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpgNewLeaves.Controls.Add(Me.Panel6)
        Me.tabpgNewLeaves.Controls.Add(Me.Submit_new)
        Me.tabpgNewLeaves.Controls.Add(Me.Panel8)
        Me.tabpgNewLeaves.Location = New System.Drawing.Point(4, 33)
        Me.tabpgNewLeaves.Name = "tabpgNewLeaves"
        Me.tabpgNewLeaves.Size = New System.Drawing.Size(844, 489)
        Me.tabpgNewLeaves.TabIndex = 1
        Me.tabpgNewLeaves.Text = "New Leave"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.E_Date)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Date_Calc)
        Me.Panel6.Controls.Add(Me.S_Date)
        Me.Panel6.Location = New System.Drawing.Point(81, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(664, 161)
        Me.Panel6.TabIndex = 22
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.ForeColor = System.Drawing.Color.GhostWhite
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(436, 45)
        Me.Panel7.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label6.Location = New System.Drawing.Point(146, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Duration of Leave"
        '
        'E_Date
        '
        Me.E_Date.Enabled = False
        Me.E_Date.Location = New System.Drawing.Point(186, 103)
        Me.E_Date.Name = "E_Date"
        Me.E_Date.Size = New System.Drawing.Size(203, 27)
        Me.E_Date.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(32, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Starting Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(38, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ending Date"
        '
        'Date_Calc
        '
        Me.Date_Calc.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Date_Calc.Location = New System.Drawing.Point(436, 0)
        Me.Date_Calc.MaxSelectionCount = 365
        Me.Date_Calc.Name = "Date_Calc"
        Me.Date_Calc.TabIndex = 13
        '
        'S_Date
        '
        Me.S_Date.Enabled = False
        Me.S_Date.Location = New System.Drawing.Point(186, 70)
        Me.S_Date.Name = "S_Date"
        Me.S_Date.Size = New System.Drawing.Size(203, 27)
        Me.S_Date.TabIndex = 18
        '
        'Submit_new
        '
        Me.Submit_new.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Submit_new.BackColor = System.Drawing.Color.Teal
        Me.Submit_new.FlatAppearance.BorderSize = 0
        Me.Submit_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submit_new.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Submit_new.ForeColor = System.Drawing.Color.White
        Me.Submit_new.Location = New System.Drawing.Point(267, 409)
        Me.Submit_new.Name = "Submit_new"
        Me.Submit_new.Size = New System.Drawing.Size(308, 62)
        Me.Submit_new.TabIndex = 17
        Me.Submit_new.Text = "SUBMIT"
        Me.Submit_new.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel8.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Remark_Box)
        Me.Panel8.Controls.Add(Me.Type_Of_Leave)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Location = New System.Drawing.Point(81, 208)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(663, 189)
        Me.Panel8.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Tomato
        Me.Label17.Location = New System.Drawing.Point(223, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(210, 19)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "A brief on the purpose of leave"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(220, 43)
        Me.Panel9.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Type of Leave"
        '
        'Remark_Box
        '
        Me.Remark_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Remark_Box.Location = New System.Drawing.Point(217, 46)
        Me.Remark_Box.Margin = New System.Windows.Forms.Padding(0)
        Me.Remark_Box.Name = "Remark_Box"
        Me.Remark_Box.Size = New System.Drawing.Size(442, 138)
        Me.Remark_Box.TabIndex = 15
        Me.Remark_Box.Text = ""
        '
        'Type_Of_Leave
        '
        Me.Type_Of_Leave.BackColor = System.Drawing.Color.Tomato
        Me.Type_Of_Leave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type_Of_Leave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Type_Of_Leave.ForeColor = System.Drawing.Color.White
        Me.Type_Of_Leave.FormattingEnabled = True
        Me.Type_Of_Leave.Items.AddRange(New Object() {"Ordinary", "Medical", "Academic"})
        Me.Type_Of_Leave.Location = New System.Drawing.Point(42, 98)
        Me.Type_Of_Leave.Name = "Type_Of_Leave"
        Me.Type_Of_Leave.Size = New System.Drawing.Size(135, 29)
        Me.Type_Of_Leave.TabIndex = 11
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.ForeColor = System.Drawing.Color.GhostWhite
        Me.Panel10.Location = New System.Drawing.Point(217, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(446, 43)
        Me.Panel10.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Brief "
        '
        'tabpgLeavesToApprove
        '
        Me.tabpgLeavesToApprove.Controls.Add(Me.Label10)
        Me.tabpgLeavesToApprove.Controls.Add(Me.MEDICAL_2)
        Me.tabpgLeavesToApprove.Controls.Add(Me.ACADEMIC_2)
        Me.tabpgLeavesToApprove.Controls.Add(Me.ORDINARY_2)
        Me.tabpgLeavesToApprove.Controls.Add(Me.OLDEST_2)
        Me.tabpgLeavesToApprove.Controls.Add(Me.NEWEST_2)
        Me.tabpgLeavesToApprove.Controls.Add(Me.Label11)
        Me.tabpgLeavesToApprove.Controls.Add(Me.Label13)
        Me.tabpgLeavesToApprove.Controls.Add(Me.DROPBOX_2)
        Me.tabpgLeavesToApprove.Controls.Add(Me.Label14)
        Me.tabpgLeavesToApprove.Controls.Add(Me.btnLeavestobeApprovedReject)
        Me.tabpgLeavesToApprove.Controls.Add(Me.richtxtboxLeavestobeApprovedRemarks)
        Me.tabpgLeavesToApprove.Controls.Add(Me.btnLeavestobeApprovedAccept)
        Me.tabpgLeavesToApprove.Controls.Add(Me.btnLeavestobeApprovedView)
        Me.tabpgLeavesToApprove.Controls.Add(Me.APPROVED)
        Me.tabpgLeavesToApprove.Location = New System.Drawing.Point(4, 33)
        Me.tabpgLeavesToApprove.Name = "tabpgLeavesToApprove"
        Me.tabpgLeavesToApprove.Size = New System.Drawing.Size(844, 489)
        Me.tabpgLeavesToApprove.TabIndex = 2
        Me.tabpgLeavesToApprove.Text = "Leaves to Approve"
        Me.tabpgLeavesToApprove.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Tomato
        Me.Label10.Location = New System.Drawing.Point(22, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Remarks (if any):"
        '
        'MEDICAL_2
        '
        Me.MEDICAL_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MEDICAL_2.AutoSize = True
        Me.MEDICAL_2.Location = New System.Drawing.Point(630, 13)
        Me.MEDICAL_2.Margin = New System.Windows.Forms.Padding(2)
        Me.MEDICAL_2.Name = "MEDICAL_2"
        Me.MEDICAL_2.Size = New System.Drawing.Size(89, 23)
        Me.MEDICAL_2.TabIndex = 38
        Me.MEDICAL_2.Text = "MEDICAL"
        Me.MEDICAL_2.UseVisualStyleBackColor = True
        '
        'ACADEMIC_2
        '
        Me.ACADEMIC_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ACADEMIC_2.AutoSize = True
        Me.ACADEMIC_2.Location = New System.Drawing.Point(724, 13)
        Me.ACADEMIC_2.Margin = New System.Windows.Forms.Padding(2)
        Me.ACADEMIC_2.Name = "ACADEMIC_2"
        Me.ACADEMIC_2.Size = New System.Drawing.Size(100, 23)
        Me.ACADEMIC_2.TabIndex = 37
        Me.ACADEMIC_2.Text = "ACADEMIC"
        Me.ACADEMIC_2.UseVisualStyleBackColor = True
        '
        'ORDINARY_2
        '
        Me.ORDINARY_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ORDINARY_2.AutoSize = True
        Me.ORDINARY_2.Location = New System.Drawing.Point(526, 13)
        Me.ORDINARY_2.Margin = New System.Windows.Forms.Padding(2)
        Me.ORDINARY_2.Name = "ORDINARY_2"
        Me.ORDINARY_2.Size = New System.Drawing.Size(98, 23)
        Me.ORDINARY_2.TabIndex = 33
        Me.ORDINARY_2.Text = "ORDINARY"
        Me.ORDINARY_2.UseVisualStyleBackColor = True
        '
        'OLDEST_2
        '
        Me.OLDEST_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OLDEST_2.AutoSize = True
        Me.OLDEST_2.Location = New System.Drawing.Point(310, 13)
        Me.OLDEST_2.Name = "OLDEST_2"
        Me.OLDEST_2.Size = New System.Drawing.Size(101, 23)
        Me.OLDEST_2.TabIndex = 32
        Me.OLDEST_2.Text = "Oldest First"
        Me.OLDEST_2.UseVisualStyleBackColor = True
        '
        'NEWEST_2
        '
        Me.NEWEST_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NEWEST_2.AutoSize = True
        Me.NEWEST_2.Checked = True
        Me.NEWEST_2.Location = New System.Drawing.Point(196, 13)
        Me.NEWEST_2.Name = "NEWEST_2"
        Me.NEWEST_2.Size = New System.Drawing.Size(107, 23)
        Me.NEWEST_2.TabIndex = 31
        Me.NEWEST_2.TabStop = True
        Me.NEWEST_2.Text = "Newest First"
        Me.NEWEST_2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Order:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(418, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 19)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Type of Leave:"
        '
        'DROPBOX_2
        '
        Me.DROPBOX_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DROPBOX_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DROPBOX_2.FormattingEnabled = True
        Me.DROPBOX_2.Items.AddRange(New Object() {"Date / Time Applied", "Start Date", "End Date"})
        Me.DROPBOX_2.Location = New System.Drawing.Point(76, 10)
        Me.DROPBOX_2.Name = "DROPBOX_2"
        Me.DROPBOX_2.Size = New System.Drawing.Size(58, 29)
        Me.DROPBOX_2.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 19)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Sort By:"
        '
        'btnLeavestobeApprovedReject
        '
        Me.btnLeavestobeApprovedReject.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLeavestobeApprovedReject.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLeavestobeApprovedReject.FlatAppearance.BorderSize = 0
        Me.btnLeavestobeApprovedReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeavestobeApprovedReject.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeavestobeApprovedReject.ForeColor = System.Drawing.Color.White
        Me.btnLeavestobeApprovedReject.Location = New System.Drawing.Point(552, 412)
        Me.btnLeavestobeApprovedReject.Name = "btnLeavestobeApprovedReject"
        Me.btnLeavestobeApprovedReject.Size = New System.Drawing.Size(263, 48)
        Me.btnLeavestobeApprovedReject.TabIndex = 25
        Me.btnLeavestobeApprovedReject.Text = "REJECT"
        Me.btnLeavestobeApprovedReject.UseVisualStyleBackColor = False
        '
        'richtxtboxLeavestobeApprovedRemarks
        '
        Me.richtxtboxLeavestobeApprovedRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.richtxtboxLeavestobeApprovedRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richtxtboxLeavestobeApprovedRemarks.Location = New System.Drawing.Point(16, 313)
        Me.richtxtboxLeavestobeApprovedRemarks.Name = "richtxtboxLeavestobeApprovedRemarks"
        Me.richtxtboxLeavestobeApprovedRemarks.Size = New System.Drawing.Size(801, 68)
        Me.richtxtboxLeavestobeApprovedRemarks.TabIndex = 23
        Me.richtxtboxLeavestobeApprovedRemarks.Text = ""
        '
        'btnLeavestobeApprovedAccept
        '
        Me.btnLeavestobeApprovedAccept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLeavestobeApprovedAccept.BackColor = System.Drawing.Color.Teal
        Me.btnLeavestobeApprovedAccept.FlatAppearance.BorderSize = 0
        Me.btnLeavestobeApprovedAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeavestobeApprovedAccept.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeavestobeApprovedAccept.ForeColor = System.Drawing.Color.White
        Me.btnLeavestobeApprovedAccept.Location = New System.Drawing.Point(284, 412)
        Me.btnLeavestobeApprovedAccept.Name = "btnLeavestobeApprovedAccept"
        Me.btnLeavestobeApprovedAccept.Size = New System.Drawing.Size(263, 48)
        Me.btnLeavestobeApprovedAccept.TabIndex = 22
        Me.btnLeavestobeApprovedAccept.Text = "ACCEPT"
        Me.btnLeavestobeApprovedAccept.UseVisualStyleBackColor = False
        '
        'btnLeavestobeApprovedView
        '
        Me.btnLeavestobeApprovedView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLeavestobeApprovedView.BackColor = System.Drawing.Color.DimGray
        Me.btnLeavestobeApprovedView.FlatAppearance.BorderSize = 0
        Me.btnLeavestobeApprovedView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeavestobeApprovedView.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeavestobeApprovedView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLeavestobeApprovedView.Location = New System.Drawing.Point(16, 412)
        Me.btnLeavestobeApprovedView.Name = "btnLeavestobeApprovedView"
        Me.btnLeavestobeApprovedView.Size = New System.Drawing.Size(263, 48)
        Me.btnLeavestobeApprovedView.TabIndex = 21
        Me.btnLeavestobeApprovedView.Text = "VIEW"
        Me.btnLeavestobeApprovedView.UseVisualStyleBackColor = False
        '
        'APPROVED
        '
        Me.APPROVED.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.APPROVED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APPROVED.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.APPROVED.FullRowSelect = True
        Me.APPROVED.HideSelection = False
        Me.APPROVED.Location = New System.Drawing.Point(16, 57)
        Me.APPROVED.Margin = New System.Windows.Forms.Padding(2)
        Me.APPROVED.MultiSelect = False
        Me.APPROVED.Name = "APPROVED"
        Me.APPROVED.Size = New System.Drawing.Size(801, 241)
        Me.APPROVED.TabIndex = 20
        Me.APPROVED.UseCompatibleStateImageBehavior = False
        Me.APPROVED.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LEAVE_ID"
        Me.ColumnHeader1.Width = 167
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "APPLICANT"
        Me.ColumnHeader2.Width = 118
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE/TIME APPLIED"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "START DATE"
        Me.ColumnHeader4.Width = 117
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "END DATE"
        Me.ColumnHeader5.Width = 107
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TYPE OF LEAVE"
        Me.ColumnHeader6.Width = 126
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Controls.Add(Me.VIEW_2)
        Me.tabpgNotifications.Controls.Add(Me.NOTIFICATIONS)
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 33)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(844, 489)
        Me.tabpgNotifications.TabIndex = 3
        Me.tabpgNotifications.Text = "Notifications"
        Me.tabpgNotifications.UseVisualStyleBackColor = True
        '
        'VIEW_2
        '
        Me.VIEW_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VIEW_2.BackColor = System.Drawing.Color.Teal
        Me.VIEW_2.FlatAppearance.BorderSize = 0
        Me.VIEW_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VIEW_2.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.VIEW_2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VIEW_2.Location = New System.Drawing.Point(303, 372)
        Me.VIEW_2.Margin = New System.Windows.Forms.Padding(2)
        Me.VIEW_2.Name = "VIEW_2"
        Me.VIEW_2.Size = New System.Drawing.Size(202, 51)
        Me.VIEW_2.TabIndex = 3
        Me.VIEW_2.Text = "VIEW DETAILS"
        Me.VIEW_2.UseVisualStyleBackColor = False
        '
        'NOTIFICATIONS
        '
        Me.NOTIFICATIONS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NOTIFICATIONS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.NOTIFICATIONS.ForeColor = System.Drawing.Color.Black
        Me.NOTIFICATIONS.FullRowSelect = True
        Me.NOTIFICATIONS.HideSelection = False
        Me.NOTIFICATIONS.Location = New System.Drawing.Point(24, 44)
        Me.NOTIFICATIONS.Margin = New System.Windows.Forms.Padding(2)
        Me.NOTIFICATIONS.MultiSelect = False
        Me.NOTIFICATIONS.Name = "NOTIFICATIONS"
        Me.NOTIFICATIONS.Size = New System.Drawing.Size(802, 289)
        Me.NOTIFICATIONS.TabIndex = 2
        Me.NOTIFICATIONS.UseCompatibleStateImageBehavior = False
        Me.NOTIFICATIONS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Date/Time"
        Me.ColumnHeader10.Width = 125
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "LEAVE_ID"
        Me.ColumnHeader7.Width = 102
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "REMARKS"
        Me.ColumnHeader8.Width = 131
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Description"
        Me.ColumnHeader9.Width = 440
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DISAPPROVE)
        Me.TabPage1.Controls.Add(Me.APPROVE)
        Me.TabPage1.Controls.Add(Me.VIEW)
        Me.TabPage1.Controls.Add(Me.ADMIN)
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(883, 496)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "HOME"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DISAPPROVE
        '
        Me.DISAPPROVE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DISAPPROVE.BackColor = System.Drawing.Color.OrangeRed
        Me.DISAPPROVE.FlatAppearance.BorderSize = 0
        Me.DISAPPROVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DISAPPROVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DISAPPROVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DISAPPROVE.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.DISAPPROVE.ForeColor = System.Drawing.SystemColors.Control
        Me.DISAPPROVE.Location = New System.Drawing.Point(576, 369)
        Me.DISAPPROVE.Margin = New System.Windows.Forms.Padding(2)
        Me.DISAPPROVE.Name = "DISAPPROVE"
        Me.DISAPPROVE.Size = New System.Drawing.Size(259, 45)
        Me.DISAPPROVE.TabIndex = 3
        Me.DISAPPROVE.Text = "DISAPPROVE"
        Me.DISAPPROVE.UseVisualStyleBackColor = False
        '
        'APPROVE
        '
        Me.APPROVE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.APPROVE.BackColor = System.Drawing.Color.Teal
        Me.APPROVE.FlatAppearance.BorderSize = 0
        Me.APPROVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.APPROVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.APPROVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.APPROVE.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.APPROVE.ForeColor = System.Drawing.SystemColors.Control
        Me.APPROVE.Location = New System.Drawing.Point(306, 369)
        Me.APPROVE.Margin = New System.Windows.Forms.Padding(2)
        Me.APPROVE.Name = "APPROVE"
        Me.APPROVE.Size = New System.Drawing.Size(259, 45)
        Me.APPROVE.TabIndex = 2
        Me.APPROVE.Text = "APPROVE"
        Me.APPROVE.UseVisualStyleBackColor = False
        '
        'VIEW
        '
        Me.VIEW.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VIEW.BackColor = System.Drawing.Color.DimGray
        Me.VIEW.FlatAppearance.BorderSize = 0
        Me.VIEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.VIEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VIEW.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.VIEW.ForeColor = System.Drawing.SystemColors.Control
        Me.VIEW.Location = New System.Drawing.Point(36, 369)
        Me.VIEW.Margin = New System.Windows.Forms.Padding(2)
        Me.VIEW.Name = "VIEW"
        Me.VIEW.Size = New System.Drawing.Size(259, 45)
        Me.VIEW.TabIndex = 1
        Me.VIEW.Text = "VIEW"
        Me.VIEW.UseVisualStyleBackColor = False
        '
        'ADMIN
        '
        Me.ADMIN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ADMIN.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.ADMIN.FullRowSelect = True
        Me.ADMIN.HideSelection = False
        Me.ADMIN.Location = New System.Drawing.Point(36, 34)
        Me.ADMIN.Margin = New System.Windows.Forms.Padding(2)
        Me.ADMIN.MultiSelect = False
        Me.ADMIN.Name = "ADMIN"
        Me.ADMIN.Size = New System.Drawing.Size(799, 294)
        Me.ADMIN.TabIndex = 0
        Me.ADMIN.UseCompatibleStateImageBehavior = False
        Me.ADMIN.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "USERNAME"
        Me.ColumnHeader11.Width = 146
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "FIRST NAME"
        Me.ColumnHeader12.Width = 131
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "LAST NAME"
        Me.ColumnHeader13.Width = 136
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "DEPARTMENT"
        Me.ColumnHeader14.Width = 240
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "TYPE OF USER"
        Me.ColumnHeader15.Width = 139
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.Teal
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(958, 106)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(86, 46)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BALANCES
        '
        Me.BALANCES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BALANCES.BackColor = System.Drawing.Color.OrangeRed
        Me.BALANCES.FlatAppearance.BorderSize = 0
        Me.BALANCES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BALANCES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BALANCES.ForeColor = System.Drawing.Color.White
        Me.BALANCES.Location = New System.Drawing.Point(771, 106)
        Me.BALANCES.Margin = New System.Windows.Forms.Padding(2)
        Me.BALANCES.Name = "BALANCES"
        Me.BALANCES.Size = New System.Drawing.Size(114, 46)
        Me.BALANCES.TabIndex = 0
        Me.BALANCES.Text = "My Balances"
        Me.BALANCES.UseVisualStyleBackColor = False
        '
        'VIEW_3
        '
        Me.VIEW_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VIEW_3.BackColor = System.Drawing.Color.Teal
        Me.VIEW_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.VIEW_3.FlatAppearance.BorderSize = 0
        Me.VIEW_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VIEW_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEW_3.ForeColor = System.Drawing.Color.White
        Me.VIEW_3.Location = New System.Drawing.Point(889, 106)
        Me.VIEW_3.Margin = New System.Windows.Forms.Padding(2)
        Me.VIEW_3.Name = "VIEW_3"
        Me.VIEW_3.Size = New System.Drawing.Size(64, 46)
        Me.VIEW_3.TabIndex = 1
        Me.VIEW_3.Text = "Profile"
        Me.VIEW_3.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Teal
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(272, 117)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(419, 22)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "SOFTWARE ENGINEERING LAB ASSIGNMENT 2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Teal
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1, 106)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1065, 46)
        Me.TextBox1.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(334, 51)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 30)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "IIT Guwahati"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeaSanSys
        '
        Me.lblLeaSanSys.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLeaSanSys.AutoSize = True
        Me.lblLeaSanSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLeaSanSys.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaSanSys.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblLeaSanSys.Location = New System.Drawing.Point(332, 18)
        Me.lblLeaSanSys.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLeaSanSys.Name = "lblLeaSanSys"
        Me.lblLeaSanSys.Size = New System.Drawing.Size(420, 38)
        Me.lblLeaSanSys.TabIndex = 34
        Me.lblLeaSanSys.Text = "Leave Sanctioning System"
        Me.lblLeaSanSys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Location = New System.Drawing.Point(1, 272)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 409)
        Me.Panel5.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 192)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 41)
        Me.Panel2.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(1, 232)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 41)
        Me.Panel4.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(1, 152)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 41)
        Me.Panel3.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(212, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(1, 152)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 529)
        Me.Panel1.TabIndex = 16
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.VIEW_3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BALANCES)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblLeaSanSys)
        Me.Controls.Add(Me.tabctrlMainTabs)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.tabctrlMainTabs.ResumeLayout(False)
        Me.tabpgViewLeaves.ResumeLayout(False)
        Me.tabpgViewLeaves.PerformLayout()
        Me.tabpgNewLeaves.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.tabpgLeavesToApprove.ResumeLayout(False)
        Me.tabpgLeavesToApprove.PerformLayout()
        Me.tabpgNotifications.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabctrlMainTabs As System.Windows.Forms.TabControl
    Friend WithEvents tabpgViewLeaves As System.Windows.Forms.TabPage
    Friend WithEvents tabpgNewLeaves As System.Windows.Forms.TabPage
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BALANCES As System.Windows.Forms.Button
    Friend WithEvents CANCELLED As System.Windows.Forms.CheckBox
    Friend WithEvents MEDICAL As System.Windows.Forms.CheckBox
    Friend WithEvents ACADEMIC As System.Windows.Forms.CheckBox
    Friend WithEvents ACCEPTED As System.Windows.Forms.CheckBox
    Friend WithEvents REJECTED As System.Windows.Forms.CheckBox
    Friend WithEvents PENDING As System.Windows.Forms.CheckBox
    Friend WithEvents ORDINARY As System.Windows.Forms.CheckBox
    Friend WithEvents NOTIFICATIONS As System.Windows.Forms.ListView
    Protected Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ADMIN As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DISAPPROVE As System.Windows.Forms.Button
    Friend WithEvents APPROVE As System.Windows.Forms.Button
    Friend WithEvents VIEW As System.Windows.Forms.Button
    Friend WithEvents VIEW_3 As System.Windows.Forms.Button
    Friend WithEvents btnViewLeavesCancel As System.Windows.Forms.Button
    Friend WithEvents VIEW_2 As System.Windows.Forms.Button
    Friend WithEvents btnViewLeavesView As System.Windows.Forms.Button
    Friend WithEvents richtxtboxViewLeaves As System.Windows.Forms.RichTextBox
    Friend WithEvents tabpgLeavesToApprove As TabPage
    Friend WithEvents MEDICAL_2 As CheckBox
    Friend WithEvents ACADEMIC_2 As CheckBox
    Friend WithEvents ORDINARY_2 As CheckBox
    Friend WithEvents OLDEST_2 As RadioButton
    Friend WithEvents NEWEST_2 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DROPBOX_2 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnLeavestobeApprovedReject As Button
    Friend WithEvents richtxtboxLeavestobeApprovedRemarks As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnLeavestobeApprovedAccept As Button
    Friend WithEvents btnLeavestobeApprovedView As Button
    Friend WithEvents APPROVED As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblLeaSanSys As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
