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
        Me.tabpgLeavesToApprove = New System.Windows.Forms.TabPage()
        Me.tabpgNotifications = New System.Windows.Forms.TabPage()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.tabctrlMainTabs.SuspendLayout()
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
        Me.tabctrlMainTabs.Size = New System.Drawing.Size(692, 354)
        Me.tabctrlMainTabs.TabIndex = 4
        '
        'tabpgViewLeaves
        '
        Me.tabpgViewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgViewLeaves.Name = "tabpgViewLeaves"
        Me.tabpgViewLeaves.Size = New System.Drawing.Size(684, 328)
        Me.tabpgViewLeaves.TabIndex = 0
        Me.tabpgViewLeaves.Text = "View Leaves"
        Me.tabpgViewLeaves.UseVisualStyleBackColor = True
        '
        'tabpgNewLeaves
        '
        Me.tabpgNewLeaves.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNewLeaves.Name = "tabpgNewLeaves"
        Me.tabpgNewLeaves.Size = New System.Drawing.Size(684, 328)
        Me.tabpgNewLeaves.TabIndex = 1
        Me.tabpgNewLeaves.Text = "New Leaves"
        Me.tabpgNewLeaves.UseVisualStyleBackColor = True
        '
        'tabpgLeavesToApprove
        '
        Me.tabpgLeavesToApprove.Location = New System.Drawing.Point(4, 22)
        Me.tabpgLeavesToApprove.Name = "tabpgLeavesToApprove"
        Me.tabpgLeavesToApprove.Size = New System.Drawing.Size(684, 328)
        Me.tabpgLeavesToApprove.TabIndex = 2
        Me.tabpgLeavesToApprove.Text = "Leaves to Approve"
        Me.tabpgLeavesToApprove.UseVisualStyleBackColor = True
        '
        'tabpgNotifications
        '
        Me.tabpgNotifications.Location = New System.Drawing.Point(4, 22)
        Me.tabpgNotifications.Name = "tabpgNotifications"
        Me.tabpgNotifications.Size = New System.Drawing.Size(684, 328)
        Me.tabpgNotifications.TabIndex = 3
        Me.tabpgNotifications.Text = "Notifications"
        Me.tabpgNotifications.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 338)
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
        Me.ClientSize = New System.Drawing.Size(854, 378)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabctrlMainTabs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.tabctrlMainTabs.ResumeLayout(False)
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
End Class
