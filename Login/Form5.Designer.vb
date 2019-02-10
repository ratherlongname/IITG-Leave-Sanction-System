<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lsviewDetailLeaveView = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtCurrentStatus = New System.Windows.Forms.TextBox()
        Me.txtTypeofLeave = New System.Windows.Forms.TextBox()
        Me.txtLeaveID = New System.Windows.Forms.TextBox()
        Me.Update_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Date_Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.User_Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lsviewDetailLeaveView
        '
        Me.lsviewDetailLeaveView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Update_ID, Me.Date_Time, Me.User_Action, Me.Action, Me.Remark})
        Me.lsviewDetailLeaveView.Location = New System.Drawing.Point(13, 94)
        Me.lsviewDetailLeaveView.Name = "lsviewDetailLeaveView"
        Me.lsviewDetailLeaveView.Size = New System.Drawing.Size(573, 329)
        Me.lsviewDetailLeaveView.TabIndex = 0
        Me.lsviewDetailLeaveView.UseCompatibleStateImageBehavior = False
        Me.lsviewDetailLeaveView.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date / Time Applied:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Start Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Current Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Type of Leave:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Leave ID:"
        '
        'txtDateTime
        '
        Me.txtDateTime.Location = New System.Drawing.Point(123, 6)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.ReadOnly = True
        Me.txtDateTime.Size = New System.Drawing.Size(100, 20)
        Me.txtDateTime.TabIndex = 7
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(382, 54)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(100, 20)
        Me.txtEndDate.TabIndex = 8
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(382, 30)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Size = New System.Drawing.Size(100, 20)
        Me.txtStartDate.TabIndex = 9
        '
        'txtCurrentStatus
        '
        Me.txtCurrentStatus.Location = New System.Drawing.Point(382, 6)
        Me.txtCurrentStatus.Name = "txtCurrentStatus"
        Me.txtCurrentStatus.ReadOnly = True
        Me.txtCurrentStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentStatus.TabIndex = 10
        '
        'txtTypeofLeave
        '
        Me.txtTypeofLeave.Location = New System.Drawing.Point(123, 54)
        Me.txtTypeofLeave.Name = "txtTypeofLeave"
        Me.txtTypeofLeave.ReadOnly = True
        Me.txtTypeofLeave.Size = New System.Drawing.Size(100, 20)
        Me.txtTypeofLeave.TabIndex = 11
        '
        'txtLeaveID
        '
        Me.txtLeaveID.Location = New System.Drawing.Point(123, 30)
        Me.txtLeaveID.Name = "txtLeaveID"
        Me.txtLeaveID.ReadOnly = True
        Me.txtLeaveID.Size = New System.Drawing.Size(100, 20)
        Me.txtLeaveID.TabIndex = 12
        '
        'Update_ID
        '
        Me.Update_ID.Text = "Update ID"
        '
        'Date_Time
        '
        Me.Date_Time.Text = "Date / Time"
        '
        'User_Action
        '
        Me.User_Action.Text = "Username"
        '
        'Action
        '
        Me.Action.Text = "Action"
        '
        'Remark
        '
        Me.Remark.Text = "Remark"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 435)
        Me.Controls.Add(Me.txtLeaveID)
        Me.Controls.Add(Me.txtTypeofLeave)
        Me.Controls.Add(Me.txtCurrentStatus)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsviewDetailLeaveView)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsviewDetailLeaveView As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDateTime As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeofLeave As System.Windows.Forms.TextBox
    Friend WithEvents txtLeaveID As System.Windows.Forms.TextBox
    Friend WithEvents Update_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Date_Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents User_Action As System.Windows.Forms.ColumnHeader
    Friend WithEvents Action As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remark As System.Windows.Forms.ColumnHeader
End Class
