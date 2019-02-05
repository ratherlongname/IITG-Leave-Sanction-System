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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataBaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseDataSet = New Login.DataBaseDataSet()
        Me.tabctrlMainTabs = New System.Windows.Forms.TabControl()
        Me.tabpgNewLeave = New System.Windows.Forms.TabPage()
        Me.daycalLeaveDays = New System.Windows.Forms.MonthCalendar()
        Me.lblSelectLeaveDays = New System.Windows.Forms.Label()
        Me.lblTypeofLeave = New System.Windows.Forms.Label()
        Me.comboxSelectLeaveType = New System.Windows.Forms.ComboBox()
        Me.FacultyDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabpgViewLeaves = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimeAppliedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeofLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabpgNotifications = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LeaveIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveUpdateDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabpgLeavestoApprove = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeAppliedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeofLeaveDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveDBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Leave_DBTableAdapter = New Login.DataBaseDataSetTableAdapters.Leave_DBTableAdapter()
        Me.Faculty_DBTableAdapter = New Login.DataBaseDataSetTableAdapters.Faculty_DBTableAdapter()
        Me.Leave_Update_DBTableAdapter = New Login.DataBaseDataSetTableAdapters.Leave_Update_DBTableAdapter()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Leave_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSubmitLeave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabctrlMainTabs.SuspendLayout()
        Me.tabpgNewLeave.SuspendLayout()
        CType(Me.FacultyDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpgViewLeaves.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaveDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpgNotifications.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaveUpdateDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpgLeavestoApprove.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaveDBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 476)
        Me.Panel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 423)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'DataBaseDataSetBindingSource
        '
        Me.DataBaseDataSetBindingSource.DataSource = Me.DataBaseDataSet
        Me.DataBaseDataSetBindingSource.Position = 0
        '
        'DataBaseDataSet
        '
        Me.DataBaseDataSet.DataSetName = "DataBaseDataSet"
        Me.DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabctrlMainTabs
        '
        Me.tabctrlMainTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgNewLeave)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgViewLeaves)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgNotifications)
        Me.tabctrlMainTabs.Controls.Add(Me.tabpgLeavestoApprove)
        Me.tabctrlMainTabs.Location = New System.Drawing.Point(219, 12)
        Me.tabctrlMainTabs.Name = "tabctrlMainTabs"
        Me.tabctrlMainTabs.SelectedIndex = 0
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(618, 453)
        Me.tabctrlMainTabs.TabIndex = 1
        '
        'tabpgNewLeave
        '
        Me.tabpgNewLeave.Controls.Add(Me.btnSubmitLeave)
        Me.tabpgNewLeave.Controls.Add(Me.daycalLeaveDays)
        Me.tabpgNewLeave.Controls.Add(Me.lblSelectLeaveDays)
        Me.tabpgNewLeave.Controls.Add(Me.lblTypeofLeave)
        Me.tabpgNewLeave.Controls.Add(Me.comboxSelectLeaveType)
        Me.tabpgNewLeave.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNewLeave.Name = "tabpgNewLeave"
        Me.tabpgNewLeave.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpgNewLeave.Size = New System.Drawing.Size(610, 427)
        Me.tabpgNewLeave.TabIndex = 0
        Me.tabpgNewLeave.Text = "New Leave"
        Me.tabpgNewLeave.UseVisualStyleBackColor = True
        '
        'daycalLeaveDays
        '
        Me.daycalLeaveDays.Location = New System.Drawing.Point(193, 79)
        Me.daycalLeaveDays.MaxSelectionCount = 365
        Me.daycalLeaveDays.Name = "daycalLeaveDays"
        Me.daycalLeaveDays.TabIndex = 4
        '
        'lblSelectLeaveDays
        '
        Me.lblSelectLeaveDays.AutoSize = True
        Me.lblSelectLeaveDays.Location = New System.Drawing.Point(71, 79)
        Me.lblSelectLeaveDays.Name = "lblSelectLeaveDays"
        Me.lblSelectLeaveDays.Size = New System.Drawing.Size(110, 13)
        Me.lblSelectLeaveDays.TabIndex = 3
        Me.lblSelectLeaveDays.Text = "Select days of Leave:"
        '
        'lblTypeofLeave
        '
        Me.lblTypeofLeave.AutoSize = True
        Me.lblTypeofLeave.Location = New System.Drawing.Point(102, 32)
        Me.lblTypeofLeave.Name = "lblTypeofLeave"
        Me.lblTypeofLeave.Size = New System.Drawing.Size(79, 13)
        Me.lblTypeofLeave.TabIndex = 1
        Me.lblTypeofLeave.Text = "Type of Leave:"
        '
        'comboxSelectLeaveType
        '
        Me.comboxSelectLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboxSelectLeaveType.FormattingEnabled = True
        Me.comboxSelectLeaveType.Items.AddRange(New Object() {"Ordinary", "Medical", "Academic"})
        Me.comboxSelectLeaveType.Location = New System.Drawing.Point(193, 29)
        Me.comboxSelectLeaveType.Name = "comboxSelectLeaveType"
        Me.comboxSelectLeaveType.Size = New System.Drawing.Size(121, 21)
        Me.comboxSelectLeaveType.TabIndex = 0
        '
        'FacultyDBBindingSource
        '
        Me.FacultyDBBindingSource.DataMember = "Faculty_DB"
        Me.FacultyDBBindingSource.DataSource = Me.DataBaseDataSetBindingSource
        '
        'tabpgViewLeaves
        '
        Me.tabpgViewLeaves.Controls.Add(Me.DataGridView1)
        Me.tabpgViewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgViewLeaves.Name = "tabpgViewLeaves"
        Me.tabpgViewLeaves.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(610, 427)
        Me.tabpgViewLeaves.TabIndex = 1
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateTimeAppliedDataGridViewTextBoxColumn, Me.CurrentStatusDataGridViewTextBoxColumn, Me.TypeofLeaveDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.LeaveIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LeaveDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(598, 415)
        Me.DataGridView1.TabIndex = 0
        '
        'DateTimeAppliedDataGridViewTextBoxColumn
        '
        Me.DateTimeAppliedDataGridViewTextBoxColumn.DataPropertyName = "Date/Time Applied"
        Me.DateTimeAppliedDataGridViewTextBoxColumn.HeaderText = "Date/Time Applied"
        Me.DateTimeAppliedDataGridViewTextBoxColumn.Name = "DateTimeAppliedDataGridViewTextBoxColumn"
        Me.DateTimeAppliedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentStatusDataGridViewTextBoxColumn
        '
        Me.CurrentStatusDataGridViewTextBoxColumn.DataPropertyName = "Current_Status"
        Me.CurrentStatusDataGridViewTextBoxColumn.HeaderText = "Current_Status"
        Me.CurrentStatusDataGridViewTextBoxColumn.Name = "CurrentStatusDataGridViewTextBoxColumn"
        Me.CurrentStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeofLeaveDataGridViewTextBoxColumn
        '
        Me.TypeofLeaveDataGridViewTextBoxColumn.DataPropertyName = "Type_of_Leave"
        Me.TypeofLeaveDataGridViewTextBoxColumn.HeaderText = "Type_of_Leave"
        Me.TypeofLeaveDataGridViewTextBoxColumn.Name = "TypeofLeaveDataGridViewTextBoxColumn"
        Me.TypeofLeaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "Start_Date"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start_Date"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        Me.EndDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeaveIDDataGridViewTextBoxColumn
        '
        Me.LeaveIDDataGridViewTextBoxColumn.DataPropertyName = "Leave_ID"
        Me.LeaveIDDataGridViewTextBoxColumn.HeaderText = "Leave_ID"
        Me.LeaveIDDataGridViewTextBoxColumn.Name = "LeaveIDDataGridViewTextBoxColumn"
        Me.LeaveIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeaveDBBindingSource
        '
        Me.LeaveDBBindingSource.DataMember = "Leave_DB"
        Me.LeaveDBBindingSource.DataSource = Me.DataBaseDataSetBindingSource
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Controls.Add(Me.DataGridView2)
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(610, 427)
        Me.tabpgNotifications.TabIndex = 2
        Me.tabpgNotifications.Text = "Notifications"
        Me.tabpgNotifications.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LeaveIDDataGridViewTextBoxColumn2, Me.UpdateIDDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn1, Me.RemarkDataGridViewTextBoxColumn, Me.UpdatedStatusDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.LeaveUpdateDBBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(598, 415)
        Me.DataGridView2.TabIndex = 1
        '
        'LeaveIDDataGridViewTextBoxColumn2
        '
        Me.LeaveIDDataGridViewTextBoxColumn2.DataPropertyName = "Leave_ID"
        Me.LeaveIDDataGridViewTextBoxColumn2.HeaderText = "Leave_ID"
        Me.LeaveIDDataGridViewTextBoxColumn2.Name = "LeaveIDDataGridViewTextBoxColumn2"
        Me.LeaveIDDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UpdateIDDataGridViewTextBoxColumn
        '
        Me.UpdateIDDataGridViewTextBoxColumn.DataPropertyName = "Update_ID"
        Me.UpdateIDDataGridViewTextBoxColumn.HeaderText = "Update_ID"
        Me.UpdateIDDataGridViewTextBoxColumn.Name = "UpdateIDDataGridViewTextBoxColumn"
        Me.UpdateIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date/Time"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "Date/Time"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        Me.DateTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn1
        '
        Me.UsernameDataGridViewTextBoxColumn1.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn1.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn1.Name = "UsernameDataGridViewTextBoxColumn1"
        Me.UsernameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UpdatedStatusDataGridViewTextBoxColumn
        '
        Me.UpdatedStatusDataGridViewTextBoxColumn.DataPropertyName = "Updated_Status"
        Me.UpdatedStatusDataGridViewTextBoxColumn.HeaderText = "Updated_Status"
        Me.UpdatedStatusDataGridViewTextBoxColumn.Name = "UpdatedStatusDataGridViewTextBoxColumn"
        Me.UpdatedStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeaveUpdateDBBindingSource
        '
        Me.LeaveUpdateDBBindingSource.DataMember = "Leave_Update_DB"
        Me.LeaveUpdateDBBindingSource.DataSource = Me.DataBaseDataSetBindingSource
        '
        'tabpgLeavestoApprove
        '
        Me.tabpgLeavestoApprove.Controls.Add(Me.DataGridView3)
        Me.tabpgLeavestoApprove.Location = New System.Drawing.Point(4, 22)
        Me.tabpgLeavestoApprove.Name = "tabpgLeavestoApprove"
        Me.tabpgLeavestoApprove.Size = New System.Drawing.Size(610, 427)
        Me.tabpgLeavestoApprove.TabIndex = 3
        Me.tabpgLeavestoApprove.Text = "Leaves to be Approved"
        Me.tabpgLeavestoApprove.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.DateTimeAppliedDataGridViewTextBoxColumn1, Me.CurrentStatusDataGridViewTextBoxColumn1, Me.TypeofLeaveDataGridViewTextBoxColumn1, Me.StartDateDataGridViewTextBoxColumn1, Me.EndDateDataGridViewTextBoxColumn1, Me.LeaveIDDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.LeaveDBBindingSource1
        Me.DataGridView3.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(604, 421)
        Me.DataGridView3.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateTimeAppliedDataGridViewTextBoxColumn1
        '
        Me.DateTimeAppliedDataGridViewTextBoxColumn1.DataPropertyName = "Date/Time Applied"
        Me.DateTimeAppliedDataGridViewTextBoxColumn1.HeaderText = "Date/Time Applied"
        Me.DateTimeAppliedDataGridViewTextBoxColumn1.Name = "DateTimeAppliedDataGridViewTextBoxColumn1"
        Me.DateTimeAppliedDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CurrentStatusDataGridViewTextBoxColumn1
        '
        Me.CurrentStatusDataGridViewTextBoxColumn1.DataPropertyName = "Current_Status"
        Me.CurrentStatusDataGridViewTextBoxColumn1.HeaderText = "Current_Status"
        Me.CurrentStatusDataGridViewTextBoxColumn1.Name = "CurrentStatusDataGridViewTextBoxColumn1"
        Me.CurrentStatusDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TypeofLeaveDataGridViewTextBoxColumn1
        '
        Me.TypeofLeaveDataGridViewTextBoxColumn1.DataPropertyName = "Type_of_Leave"
        Me.TypeofLeaveDataGridViewTextBoxColumn1.HeaderText = "Type_of_Leave"
        Me.TypeofLeaveDataGridViewTextBoxColumn1.Name = "TypeofLeaveDataGridViewTextBoxColumn1"
        Me.TypeofLeaveDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'StartDateDataGridViewTextBoxColumn1
        '
        Me.StartDateDataGridViewTextBoxColumn1.DataPropertyName = "Start_Date"
        Me.StartDateDataGridViewTextBoxColumn1.HeaderText = "Start_Date"
        Me.StartDateDataGridViewTextBoxColumn1.Name = "StartDateDataGridViewTextBoxColumn1"
        Me.StartDateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EndDateDataGridViewTextBoxColumn1
        '
        Me.EndDateDataGridViewTextBoxColumn1.DataPropertyName = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn1.HeaderText = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn1.Name = "EndDateDataGridViewTextBoxColumn1"
        Me.EndDateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LeaveIDDataGridViewTextBoxColumn1
        '
        Me.LeaveIDDataGridViewTextBoxColumn1.DataPropertyName = "Leave_ID"
        Me.LeaveIDDataGridViewTextBoxColumn1.HeaderText = "Leave_ID"
        Me.LeaveIDDataGridViewTextBoxColumn1.Name = "LeaveIDDataGridViewTextBoxColumn1"
        Me.LeaveIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LeaveDBBindingSource1
        '
        Me.LeaveDBBindingSource1.DataMember = "Leave_DB"
        Me.LeaveDBBindingSource1.DataSource = Me.DataBaseDataSetBindingSource
        '
        'Leave_DBTableAdapter
        '
        Me.Leave_DBTableAdapter.ClearBeforeFill = True
        '
        'Faculty_DBTableAdapter
        '
        Me.Faculty_DBTableAdapter.ClearBeforeFill = True
        '
        'Leave_Update_DBTableAdapter
        '
        Me.Leave_Update_DBTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Leave_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Leave_ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Leave_ID
        '
        Me.Leave_ID.DataPropertyName = "Leave_ID"
        Me.Leave_ID.HeaderText = "Leave_ID"
        Me.Leave_ID.Name = "Leave_ID"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Leave_ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'btnSubmitLeave
        '
        Me.btnSubmitLeave.Location = New System.Drawing.Point(494, 391)
        Me.btnSubmitLeave.Name = "btnSubmitLeave"
        Me.btnSubmitLeave.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitLeave.TabIndex = 6
        Me.btnSubmitLeave.Text = "Submit"
        Me.btnSubmitLeave.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 477)
        Me.Controls.Add(Me.tabctrlMainTabs)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabctrlMainTabs.ResumeLayout(False)
        Me.tabpgNewLeave.ResumeLayout(False)
        Me.tabpgNewLeave.PerformLayout()
        CType(Me.FacultyDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpgViewLeaves.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaveDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpgNotifications.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaveUpdateDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpgLeavestoApprove.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaveDBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataBaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataBaseDataSet As Login.DataBaseDataSet
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tabctrlMainTabs As System.Windows.Forms.TabControl
    Friend WithEvents tabpgNewLeave As System.Windows.Forms.TabPage
    Friend WithEvents tabpgViewLeaves As System.Windows.Forms.TabPage
    Friend WithEvents tabpgNotifications As System.Windows.Forms.TabPage
    Friend WithEvents tabpgLeavestoApprove As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LeaveDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Leave_DBTableAdapter As Login.DataBaseDataSetTableAdapters.Leave_DBTableAdapter
    Friend WithEvents DateTimeAppliedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeofLeaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaveIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comboxSelectLeaveType As System.Windows.Forms.ComboBox
    Friend WithEvents FacultyDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Faculty_DBTableAdapter As Login.DataBaseDataSetTableAdapters.Faculty_DBTableAdapter
    Friend WithEvents lblTypeofLeave As System.Windows.Forms.Label
    Friend WithEvents daycalLeaveDays As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblSelectLeaveDays As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LeaveUpdateDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Leave_Update_DBTableAdapter As Login.DataBaseDataSetTableAdapters.Leave_Update_DBTableAdapter
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeAppliedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentStatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeofLeaveDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaveIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaveDBBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leave_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaveIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSubmitLeave As System.Windows.Forms.Button
End Class
