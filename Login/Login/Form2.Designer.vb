<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataBaseDataSet = New Login.DataBaseDataSet()
        Me.DataBaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERNAME = New System.Windows.Forms.TextBox()
        Me.PASSWORD = New System.Windows.Forms.TextBox()
        Me.FIRST_NAME = New System.Windows.Forms.TextBox()
        Me.LAST_NAME = New System.Windows.Forms.TextBox()
        Me.YEAR = New System.Windows.Forms.TextBox()
        Me.ROLL_NO = New System.Windows.Forms.TextBox()
        Me.PROGRAMME = New System.Windows.Forms.TextBox()
        Me.DEPARTMENT = New System.Windows.Forms.TextBox()
        Me.TA_SUPERVISER = New System.Windows.Forms.TextBox()
        Me.GUIDE = New System.Windows.Forms.TextBox()
        Me.DEPARTMENT_FAC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DESIGNATION = New System.Windows.Forms.ComboBox()
        Me.Student_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Faculty_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SUBMIT = New System.Windows.Forms.Button()
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataBaseDataSet
        '
        Me.DataBaseDataSet.DataSetName = "DataBaseDataSet"
        Me.DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBaseDataSetBindingSource
        '
        Me.DataBaseDataSetBindingSource.DataSource = Me.DataBaseDataSet
        Me.DataBaseDataSetBindingSource.Position = 0
        '
        'DataBaseDataSetBindingSource1
        '
        Me.DataBaseDataSetBindingSource1.DataSource = Me.DataBaseDataSet
        Me.DataBaseDataSetBindingSource1.Position = 0
        '
        'USERNAME
        '
        Me.USERNAME.Location = New System.Drawing.Point(135, 37)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Size = New System.Drawing.Size(222, 22)
        Me.USERNAME.TabIndex = 0
        '
        'PASSWORD
        '
        Me.PASSWORD.Location = New System.Drawing.Point(135, 81)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.Size = New System.Drawing.Size(222, 22)
        Me.PASSWORD.TabIndex = 1
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.Location = New System.Drawing.Point(135, 128)
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.Size = New System.Drawing.Size(222, 22)
        Me.FIRST_NAME.TabIndex = 2
        '
        'LAST_NAME
        '
        Me.LAST_NAME.Location = New System.Drawing.Point(135, 174)
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.Size = New System.Drawing.Size(222, 22)
        Me.LAST_NAME.TabIndex = 3
        '
        'YEAR
        '
        Me.YEAR.Location = New System.Drawing.Point(190, 268)
        Me.YEAR.Name = "YEAR"
        Me.YEAR.Size = New System.Drawing.Size(167, 22)
        Me.YEAR.TabIndex = 4
        '
        'ROLL_NO
        '
        Me.ROLL_NO.Location = New System.Drawing.Point(190, 296)
        Me.ROLL_NO.Name = "ROLL_NO"
        Me.ROLL_NO.Size = New System.Drawing.Size(167, 22)
        Me.ROLL_NO.TabIndex = 5
        '
        'PROGRAMME
        '
        Me.PROGRAMME.Location = New System.Drawing.Point(190, 324)
        Me.PROGRAMME.Name = "PROGRAMME"
        Me.PROGRAMME.Size = New System.Drawing.Size(167, 22)
        Me.PROGRAMME.TabIndex = 6
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.Location = New System.Drawing.Point(190, 353)
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.Size = New System.Drawing.Size(167, 22)
        Me.DEPARTMENT.TabIndex = 7
        '
        'TA_SUPERVISER
        '
        Me.TA_SUPERVISER.Location = New System.Drawing.Point(190, 381)
        Me.TA_SUPERVISER.Name = "TA_SUPERVISER"
        Me.TA_SUPERVISER.Size = New System.Drawing.Size(167, 22)
        Me.TA_SUPERVISER.TabIndex = 8
        '
        'GUIDE
        '
        Me.GUIDE.Location = New System.Drawing.Point(190, 409)
        Me.GUIDE.Name = "GUIDE"
        Me.GUIDE.Size = New System.Drawing.Size(167, 22)
        Me.GUIDE.TabIndex = 9
        '
        'DEPARTMENT_FAC
        '
        Me.DEPARTMENT_FAC.Location = New System.Drawing.Point(570, 259)
        Me.DEPARTMENT_FAC.Name = "DEPARTMENT_FAC"
        Me.DEPARTMENT_FAC.Size = New System.Drawing.Size(177, 22)
        Me.DEPARTMENT_FAC.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Roll No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Programme"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Department"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "TA Superviser"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(126, 412)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Guide"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(482, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Department"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(481, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Designation"
        '
        'DESIGNATION
        '
        Me.DESIGNATION.FormattingEnabled = True
        Me.DESIGNATION.Items.AddRange(New Object() {"HOD", "ADOAA", "Professor", "Associate Professor", "Assistant Professor"})
        Me.DESIGNATION.Location = New System.Drawing.Point(570, 296)
        Me.DESIGNATION.Name = "DESIGNATION"
        Me.DESIGNATION.Size = New System.Drawing.Size(177, 24)
        Me.DESIGNATION.TabIndex = 24
        '
        'Student_Checkbox
        '
        Me.Student_Checkbox.AutoSize = True
        Me.Student_Checkbox.Location = New System.Drawing.Point(223, 219)
        Me.Student_Checkbox.Name = "Student_Checkbox"
        Me.Student_Checkbox.Size = New System.Drawing.Size(79, 21)
        Me.Student_Checkbox.TabIndex = 25
        Me.Student_Checkbox.Text = "Student"
        Me.Student_Checkbox.UseVisualStyleBackColor = True
        '
        'Faculty_Checkbox
        '
        Me.Faculty_Checkbox.AutoSize = True
        Me.Faculty_Checkbox.Location = New System.Drawing.Point(327, 219)
        Me.Faculty_Checkbox.Name = "Faculty_Checkbox"
        Me.Faculty_Checkbox.Size = New System.Drawing.Size(75, 21)
        Me.Faculty_Checkbox.TabIndex = 26
        Me.Faculty_Checkbox.Text = "Faculty"
        Me.Faculty_Checkbox.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(114, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "USER TYPE"
        '
        'SUBMIT
        '
        Me.SUBMIT.Location = New System.Drawing.Point(570, 367)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(123, 51)
        Me.SUBMIT.TabIndex = 28
        Me.SUBMIT.Text = "Submit"
        Me.SUBMIT.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 443)
        Me.Controls.Add(Me.SUBMIT)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Faculty_Checkbox)
        Me.Controls.Add(Me.Student_Checkbox)
        Me.Controls.Add(Me.DESIGNATION)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DEPARTMENT_FAC)
        Me.Controls.Add(Me.GUIDE)
        Me.Controls.Add(Me.TA_SUPERVISER)
        Me.Controls.Add(Me.DEPARTMENT)
        Me.Controls.Add(Me.PROGRAMME)
        Me.Controls.Add(Me.ROLL_NO)
        Me.Controls.Add(Me.YEAR)
        Me.Controls.Add(Me.LAST_NAME)
        Me.Controls.Add(Me.FIRST_NAME)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.USERNAME)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataBaseDataSet As Login.DataBaseDataSet
    Friend WithEvents DataBaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataBaseDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents USERNAME As System.Windows.Forms.TextBox
    Friend WithEvents PASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents FIRST_NAME As System.Windows.Forms.TextBox
    Friend WithEvents LAST_NAME As System.Windows.Forms.TextBox
    Friend WithEvents YEAR As System.Windows.Forms.TextBox
    Friend WithEvents ROLL_NO As System.Windows.Forms.TextBox
    Friend WithEvents PROGRAMME As System.Windows.Forms.TextBox
    Friend WithEvents DEPARTMENT As System.Windows.Forms.TextBox
    Friend WithEvents TA_SUPERVISER As System.Windows.Forms.TextBox
    Friend WithEvents GUIDE As System.Windows.Forms.TextBox
    Friend WithEvents DEPARTMENT_FAC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DESIGNATION As System.Windows.Forms.ComboBox
    Friend WithEvents Student_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Faculty_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SUBMIT As System.Windows.Forms.Button
End Class
