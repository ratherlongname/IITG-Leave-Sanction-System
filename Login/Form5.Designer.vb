﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lsviewDetailLeaveView = New System.Windows.Forms.ListView()
        Me.Update_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Date_Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.User_Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLeaSanSys = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeaveID = New System.Windows.Forms.TextBox()
        Me.txtTypeofLeave = New System.Windows.Forms.TextBox()
        Me.txtCurrentStatus = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsviewDetailLeaveView
        '
        Me.lsviewDetailLeaveView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lsviewDetailLeaveView.BackColor = System.Drawing.Color.Gainsboro
        Me.lsviewDetailLeaveView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsviewDetailLeaveView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Update_ID, Me.Date_Time, Me.User_Action, Me.Action, Me.Remark})
        Me.lsviewDetailLeaveView.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsviewDetailLeaveView.FullRowSelect = True
        Me.lsviewDetailLeaveView.Location = New System.Drawing.Point(227, 278)
        Me.lsviewDetailLeaveView.MultiSelect = False
        Me.lsviewDetailLeaveView.Name = "lsviewDetailLeaveView"
        Me.lsviewDetailLeaveView.Size = New System.Drawing.Size(824, 391)
        Me.lsviewDetailLeaveView.TabIndex = 0
        Me.lsviewDetailLeaveView.UseCompatibleStateImageBehavior = False
        Me.lsviewDetailLeaveView.View = System.Windows.Forms.View.Details
        '
        'Update_ID
        '
        Me.Update_ID.Text = "Update ID"
        Me.Update_ID.Width = 142
        '
        'Date_Time
        '
        Me.Date_Time.Text = "Date / Time"
        Me.Date_Time.Width = 144
        '
        'User_Action
        '
        Me.User_Action.Text = "Username"
        Me.User_Action.Width = 90
        '
        'Action
        '
        Me.Action.Text = "Action"
        Me.Action.Width = 96
        '
        'Remark
        '
        Me.Remark.Text = "Remark"
        Me.Remark.Width = 348
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Teal
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(271, 112)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(419, 22)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "SOFTWARE ENGINEERING LAB ASSIGNMENT 2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(333, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 30)
        Me.Label16.TabIndex = 41
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
        Me.lblLeaSanSys.Location = New System.Drawing.Point(331, 13)
        Me.lblLeaSanSys.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLeaSanSys.Name = "lblLeaSanSys"
        Me.lblLeaSanSys.Size = New System.Drawing.Size(420, 38)
        Me.lblLeaSanSys.TabIndex = 40
        Me.lblLeaSanSys.Text = "Leave Sanctioning System"
        Me.lblLeaSanSys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Teal
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(0, 101)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1065, 46)
        Me.TextBox1.TabIndex = 43
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 41)
        Me.Panel3.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Appliation Details"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 147)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 535)
        Me.Panel1.TabIndex = 45
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(946, 101)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(86, 46)
        Me.btnBack.TabIndex = 47
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(211, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'txtDateTime
        '
        Me.txtDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDateTime.BackColor = System.Drawing.Color.White
        Me.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTime.Location = New System.Drawing.Point(407, 177)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.ReadOnly = True
        Me.txtDateTime.Size = New System.Drawing.Size(196, 19)
        Me.txtDateTime.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(634, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Date:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(634, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Start Date:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(634, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Current Status:"
        '
        'txtLeaveID
        '
        Me.txtLeaveID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLeaveID.BackColor = System.Drawing.Color.White
        Me.txtLeaveID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLeaveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaveID.Location = New System.Drawing.Point(407, 203)
        Me.txtLeaveID.Name = "txtLeaveID"
        Me.txtLeaveID.ReadOnly = True
        Me.txtLeaveID.Size = New System.Drawing.Size(196, 19)
        Me.txtLeaveID.TabIndex = 12
        '
        'txtTypeofLeave
        '
        Me.txtTypeofLeave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTypeofLeave.BackColor = System.Drawing.Color.White
        Me.txtTypeofLeave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTypeofLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeofLeave.Location = New System.Drawing.Point(407, 229)
        Me.txtTypeofLeave.Name = "txtTypeofLeave"
        Me.txtTypeofLeave.ReadOnly = True
        Me.txtTypeofLeave.Size = New System.Drawing.Size(196, 19)
        Me.txtTypeofLeave.TabIndex = 11
        '
        'txtCurrentStatus
        '
        Me.txtCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCurrentStatus.BackColor = System.Drawing.Color.White
        Me.txtCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentStatus.Location = New System.Drawing.Point(773, 177)
        Me.txtCurrentStatus.Name = "txtCurrentStatus"
        Me.txtCurrentStatus.ReadOnly = True
        Me.txtCurrentStatus.Size = New System.Drawing.Size(196, 19)
        Me.txtCurrentStatus.TabIndex = 10
        '
        'txtStartDate
        '
        Me.txtStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStartDate.BackColor = System.Drawing.Color.White
        Me.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartDate.Location = New System.Drawing.Point(773, 203)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Size = New System.Drawing.Size(196, 19)
        Me.txtStartDate.TabIndex = 9
        '
        'txtEndDate
        '
        Me.txtEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEndDate.BackColor = System.Drawing.Color.White
        Me.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndDate.Location = New System.Drawing.Point(773, 229)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(196, 19)
        Me.txtEndDate.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Type of Leave:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Leave ID:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date / Time Applied:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCurrentStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTypeofLeave)
        Me.Controls.Add(Me.txtLeaveID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblLeaSanSys)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lsviewDetailLeaveView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Viewer"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsviewDetailLeaveView As System.Windows.Forms.ListView
    Friend WithEvents Update_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Date_Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents User_Action As System.Windows.Forms.ColumnHeader
    Friend WithEvents Action As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remark As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblLeaSanSys As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents txtDateTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLeaveID As TextBox
    Friend WithEvents txtTypeofLeave As TextBox
    Friend WithEvents txtCurrentStatus As TextBox
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
