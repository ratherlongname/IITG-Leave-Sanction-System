Imports System.Drawing.Drawing2D

Public Class Form2
    Private Access As New DBControl
    Dim str As String = Nothing


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Access.ExecQuery("SELECT * FROM Faculty_DB")
        If Access.RecordCount > 0 Then
            For Each r As DataRow In Access.DBDT.Rows
                If r(8) <> "HOD" And r(8) <> "ADOAA" Then
                    Me.TA_SUPERVISER.Items.Add(r(0))
                    Me.GUIDE.Items.Add(r(0))
                End If
            Next
        End If
        Button2.PerformClick()
        If USERNAME.Enabled = False Then
            SUBMIT.Visible = False
        Else
            UPDATE.Visible = False
        End If
        'Making appropriate controls hidden
        If HOD_CheckBox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If
        If HOD_CheckBox.Checked = True Then
            Student_Checkbox.Checked = False
            Faculty_Checkbox.Checked = False
            Label11.Visible = True
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = True
            DESIGNATION.Visible = False
        End If

        If Student_Checkbox.Checked = False Then
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            YEAR.Visible = False
            ROLL_NO.Visible = False
            PROGRAMME.Visible = False
            DEPARTMENT.Visible = False
            TA_SUPERVISER.Visible = False
            GUIDE.Visible = False
        End If

        If Faculty_Checkbox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If

        If Faculty_Checkbox.Checked = True Then
            Label11.Visible = True
            Label12.Visible = True
            DEPARTMENT_FAC.Visible = True
            DESIGNATION.Visible = True
        End If

    End Sub

    'handling the case when student checkbox is Selected
    Private Sub Student_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Student_Checkbox.CheckedChanged
        'Making appropriate controls hidden
        If Student_Checkbox.Checked = False Then
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            YEAR.Visible = False
            ROLL_NO.Visible = False
            PROGRAMME.Visible = False
            DEPARTMENT.Visible = False
            TA_SUPERVISER.Visible = False
            GUIDE.Visible = False
        End If

        If Student_Checkbox.Checked = True Then
            Faculty_Checkbox.Checked = False
            HOD_CheckBox.Checked = False
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            YEAR.Visible = True
            ROLL_NO.Visible = True
            PROGRAMME.Visible = True
            DEPARTMENT.Visible = True
            TA_SUPERVISER.Visible = True
            GUIDE.Visible = True
        End If
    End Sub

    Private Sub Faculty_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Faculty_Checkbox.CheckedChanged
        'Making Appropriate Controls Hidden
        If Faculty_Checkbox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If
        If Faculty_Checkbox.Checked = True Then
            Student_Checkbox.Checked = False
            HOD_CheckBox.Checked = False
            Label11.Visible = True
            Label12.Visible = True
            DEPARTMENT_FAC.Visible = True
            DESIGNATION.Visible = True
        End If
    End Sub

    Private Sub SUBMIT_Click(sender As Object, e As EventArgs) Handles SUBMIT.Click
        'Storing Data in variables 

        Dim flag As Integer = 0
        Dim fname As String = FIRST_NAME.Text
        Dim lname As String = LAST_NAME.Text
        Dim uname As String = USERNAME.Text
        Dim pwd As String = PASSWORD.Text
        Dim roll As String = ROLL_NO.Text
        Dim prog As String = PROGRAMME.Text
        Dim ta As String = TA_SUPERVISER.Text
        Dim guide_2 As String = GUIDE.Text
        Dim dept_stu As String = DEPARTMENT.Text
        Dim dept_fac As String = DEPARTMENT_FAC.Text
        Dim desg As String = DESIGNATION.Text
        Dim y As String = YEAR.Text
        'Allowing user to enter Spaces along with the details
        uname = uname.Trim()
        fname = fname.Trim()
        lname = lname.Trim()
        roll = roll.Trim()
        y = y.Trim()
        If uname = "admin" Then
            MessageBox.Show("Username can't be admin")
            Button2.PerformClick()
            Exit Sub
        End If
        'Validating the user Details NOT ALLOWING TO EMPTY data
        If uname = Nothing Then
            MessageBox.Show("Please Enter some Username")
            Button2.PerformClick()
            Exit Sub
        End If
        If pwd = Nothing Then
            MessageBox.Show("Please Enter the Password")
            Button2.PerformClick()
            Exit Sub
        End If
        If fname = Nothing Then
            MessageBox.Show("Please Enter the First Name")
            Button2.PerformClick()
            Exit Sub
        End If
        If lname = Nothing Then
            MessageBox.Show("Please Enter the Last Name")
            Button2.PerformClick()
            Exit Sub
        End If

        'NOT ALLOWING USERNAME LESS THAN TWO CHARACTERS
        If uname.Length < 2 Then
            MessageBox.Show("Username should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        'NOT ALLOWING USERNAME GREATER THAN 50 CHARACTERS
        If uname.Length > 50 Then
            MessageBox.Show("Username can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        'PASSWORD LENGTH BETWEEN 2 TO 50 INCLUSIVE
        If pwd.Length < 2 Then
            MessageBox.Show("Password should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If pwd.Length > 50 Then
            MessageBox.Show("Password can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If

        'FIRST NAME  AND LAST NAME BETWEEN 2 TO 50 CHARCATERS ONLY
        If fname.Length < 2 Then
            MessageBox.Show("First Name should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If fname.Length > 50 Then
            MessageBox.Show("First Name can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If

        If lname.Length < 2 Then
            MessageBox.Show("Last Name should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If lname.Length > 50 Then
            MessageBox.Show("Last Name can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If

        'ALLOWING ONLY ALPHANUMERIC CHARCTERS IN USERNAME,FIRST NAME,LAST NAME
        For Each c As Char In uname
            If (Char.IsLetterOrDigit(c)) Then
            Else
                MessageBox.Show("Username can contain only alphanumeric characters")
                Button2.PerformClick()
                Exit Sub
            End If
        Next

        For Each c As Char In fname
            If (Char.IsLetter(c)) Then
            Else
                MessageBox.Show("Firstname can contain only Uppercase and LowerCase Letters")
                Button2.PerformClick()
                Exit Sub
            End If
        Next

        For Each c As Char In lname
            If (Char.IsLetter(c)) Then
            Else
                MessageBox.Show("Last name can contain only Uppercase and LowerCase Letters")
                Button2.PerformClick()
                Exit Sub
            End If
        Next

        'EMPTY ROLL NUMBER,YEAR OF JOINING,PROGRAMME,DEPARTMENT,GUIDE/TA_SUPERVISER IS NOT ALLOWED
        If Student_Checkbox.Checked = True Then
            If y = Nothing Then
                MessageBox.Show("Please Enter your Year of Joining")
                Button2.PerformClick()
                Exit Sub
            End If


            If roll = Nothing Then
                MessageBox.Show("Please Enter your Roll No.")
                Button2.PerformClick()
                Exit Sub
            End If
            If prog = Nothing Then
                MessageBox.Show("Please Enter in which Programme you are enrolled")
                Button2.PerformClick()
                Exit Sub
            End If
            If dept_stu = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Button2.PerformClick()
                Exit Sub
            End If
            If ta = Nothing And guide_2 = Nothing Then
                MessageBox.Show("Please Mention either your TA Superviser or Guide")
                Button2.PerformClick()
                Exit Sub
            End If

            If ta = guide_2 Then
                MessageBox.Show("TA Superviser and Guide can't be the same individual")
                Button2.PerformClick()
                Exit Sub
            End If

            'VALIDATION OF YEAR , RANGE = 0000-9999
            For Each c As Char In y
                If (Char.IsNumber(c)) Then
                Else
                    MessageBox.Show("Please enter a Valid Year")
                    Button2.PerformClick()
                    Exit Sub
                End If
            Next
            If y.Length() <> 4 Then
                MessageBox.Show("Please enter a Valid Year")
                Button2.PerformClick()
                Exit Sub
            End If

            'VALIDATION OF ROLL NUMBER
            For Each c As Char In roll
                If (Char.IsNumber(c)) Then
                Else
                    MessageBox.Show("Roll No. should contain only digits")
                    Button2.PerformClick()
                    Exit Sub
                End If
            Next
            If roll.Length() <> 9 Then
                MessageBox.Show("Roll No. should contain exactly 9 digits")
                Button2.PerformClick()
                Exit Sub
            End If
        End If

        If Faculty_Checkbox.Checked = True Then
            'VALIDATION OF DEPARTMENT,DESIGNATION  OF FACULTY
            If dept_fac = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Button2.PerformClick()
                Exit Sub
            End If
            If desg = Nothing Then
                MessageBox.Show("Please Enter your Designation")
                Button2.PerformClick()
                Exit Sub
            End If
        End If
        'VALIDATION OF FIELDS OF HOD
        If HOD_CheckBox.Checked = True Then
            If dept_fac = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Button2.PerformClick()
                Exit Sub
            End If
        End If

        'Validating the CAPTCHA
        If str <> VALIDATION.Text Then
            MessageBox.Show("Invalid Validation, Please Try Again")
            Button2.PerformClick()
            Exit Sub
        End If

        Try
            'Checking for duplicate username
            Dim userAlreadyExists As Boolean = False

            Access.AddParam("@user", USERNAME.Text)
            Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user")
            If Access.RecordCount > 0 Then userAlreadyExists = True

            Access.AddParam("@user", USERNAME.Text)
            Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username=@user")
            If Access.RecordCount > 0 Then userAlreadyExists = True

            If userAlreadyExists Then
                MessageBox.Show("User already exists with the same username try entering a differnet username", "USER EXISTS")
                Button2.PerformClick()
                Exit Sub
            Else
                'Adding parameters for the insert query
                If Student_Checkbox.Checked = True Then
                    Dim roll_2 As Integer = Convert.ToInt64(roll)
                    Dim y_2 As Integer = Convert.ToInt64(y)

                    Access.AddParam("@user", uname)
                    Access.AddParam("@pwd", pwd)
                    Access.AddParam("@roll", roll_2)
                    Access.AddParam("@prog", prog)
                    Access.AddParam("@dept_stu", dept_stu)
                    Access.AddParam("@fname", fname)
                    Access.AddParam("@lname", lname)
                    Access.AddParam("@y", y_2)
                    Dim days As Integer = 0
                    Access.AddParam("@days", days)
                    Access.AddParam("@ta", ta)
                    Access.AddParam("@guide", guide_2)
                    Dim dum As String = ""
                    Access.AddParam("@dum", dum)

                    Dim days_1 As Integer = 120
                    Access.AddParam("@days_1", days_1)
                    Dim dum2 As String = ""
                    Access.AddParam("@dum2", dum2)
                    Dim days_2 As Integer = 15
                    Access.AddParam("@days_2", days_2)
                    Dim days_3 As Integer = 30
                    Access.AddParam("@days_3", days_3)
                    Dim help As String = "PENDING"
                    Access.AddParam("@help", help)
                    'Inerst query for the Student_DB
                    Access.ExecQuery("INSERT INTO Student_DB([Username], [Password], [Roll_no], [Programme], [Department], [First_name], [Last_name], [Year_of_joining], [Days_of_stipend_cut], [TA_Superviser], [Guide], [List_of_leaves], [Academic], [Notification], [Ordinary], [Medical], [Approved])VALUES(@user, @pwd, @roll, @prog, @dept_stu, @fname, @lname, @y, @days, @ta, @guide, @dum, @days_1, @dum2, @days_2, @days_3, @help)")

                    Form1.Show()
                    Me.Close()

                End If


                If Faculty_Checkbox.Checked = True Then
                    'Adding parameters
                    Access.AddParam("@user", uname)
                    Access.AddParam("@pwd", pwd)
                    Access.AddParam("@fname", fname)
                    Access.AddParam("@lname", lname)
                    Access.AddParam("@dept", dept_fac)
                    Dim dum As String = Nothing
                    dum = ""
                    Access.AddParam("@dum", dum)
                    Dim dum2 As String = Nothing
                    dum2 = ""
                    Access.AddParam("@dum2", dum2)
                    Dim dum3 As String = Nothing
                    dum3 = ""
                    Access.AddParam("@dum3", dum3)
                    Access.AddParam("@desg", desg)
                    Dim days_2 As Integer = 15
                    Access.AddParam("@days2", days_2)
                    Dim days_3 As Integer = 30
                    Access.AddParam("@days3", days_3)
                    Dim days_1 As Integer = 120
                    Access.AddParam("@days1", days_1)
                    Dim help As String = "PENDING"
                    Access.AddParam("@help", help)
                    'Insert command for Faculty_DB 
                    Access.ExecQuery("INSERT INTO Faculty_DB([Username], [Password], [First_Name], [Last_Name],  [Department], [List_of_Leaves_Applied], [Notifications], [List_of_Incoming_Leaves], [Designation], [Ordinary], [Medical], [Academic], [Approved])VALUES(@user, @pwd, @fname, @lname, @dept, @dum, @dum2, @dum3, @desg, @days_2, @days_3, @days_1, '" & help & "')")
                    Form1.Show()
                    Me.Close()
                End If

                If HOD_CheckBox.Checked = True Then

                    Dim desg_2 As String = "HOD"
                    Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Designation='" & desg_2 & "' and Department='" & dept_fac & "'")
                    If Access.RecordCount > 0 Then
                        MessageBox.Show("HOD of this Department Already exists")
                        Button2.PerformClick()
                        Exit Sub
                    End If
                    'Adding Parameters
                    Access.AddParam("@user", uname)
                    Access.AddParam("@pwd", pwd)
                    Access.AddParam("@fname", fname)
                    Access.AddParam("@lname", lname)
                    Access.AddParam("@dept", dept_fac)
                    Dim dum As String = Nothing
                    dum = ""
                    Access.AddParam("@dum", dum)
                    Dim dum2 As String = Nothing
                    dum2 = ""
                    Access.AddParam("@dum2", dum2)
                    Dim dum3 As String = Nothing
                    dum3 = ""
                    Access.AddParam("@dum3", dum3)
                    Access.AddParam("@desg", desg_2)
                    Dim days_2 As Integer = 15
                    Access.AddParam("@days2", days_2)
                    Dim days_3 As Integer = 30
                    Access.AddParam("@days3", days_3)
                    Dim days_1 As Integer = 120
                    Access.AddParam("@days1", days_1)
                    Dim help As String = "PENDING"
                    Access.AddParam("@help", help)
                    'Insert Query for the HOD
                    Access.ExecQuery("INSERT INTO Faculty_DB([Username], [Password], [First_Name], [Last_Name],  [Department], [List_of_Leaves_Applied], [Notifications], [List_of_Incoming_Leaves], [Designation], [Ordinary], [Medical], [Academic], [Approved])VALUES(@user, @pwd, @fname, @lname, @dept, @dum, @dum2, @dum3, @desg_2, @days_2, @days_3, @days_1, '" & help & "')")
                    Form1.Show()
                    Me.Close()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub HOD_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HOD_CheckBox.CheckedChanged
        'Making appropriate controls hidden
        If HOD_CheckBox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If
        If HOD_CheckBox.Checked = True Then
            Student_Checkbox.Checked = False
            Faculty_Checkbox.Checked = False
            Label11.Visible = True
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = True
            DESIGNATION.Visible = False
        End If
    End Sub

    'CODE FOR GENERATING THE CAPTCHA
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            Str = Str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(141, 36, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(Str, New Font("Arial", 16, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5, 5)
        PictureBox2.Image = b
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.txtPassword.Text = Nothing
        Form1.Show()
    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        'Code for validation
        'Copied from line 113-311
        'For detailed commenting please visit above mentioned lines
        'It's again validating whether the user has not entered invalid data
        Dim flag As Integer = 0
        Dim fname As String = FIRST_NAME.Text
        Dim lname As String = LAST_NAME.Text
        Dim uname As String = USERNAME.Text
        Dim pwd As String = PASSWORD.Text
        Dim roll As String = ROLL_NO.Text
        Dim prog As String = PROGRAMME.Text
        Dim ta As String = TA_SUPERVISER.Text
        Dim guide_2 As String = GUIDE.Text
        Dim dept_stu As String = DEPARTMENT.Text
        Dim dept_fac As String = DEPARTMENT_FAC.Text
        Dim desg As String = DESIGNATION.Text
        Dim y As String = YEAR.Text

        uname = uname.Trim()
        fname = fname.Trim()
        lname = lname.Trim()
        roll = roll.Trim()
        y = y.Trim()


        If pwd = Nothing Then
            MessageBox.Show("Please Enter the Password")
            Button2.PerformClick()
            Exit Sub
        End If
        If fname = Nothing Then
            MessageBox.Show("Please Enter the First Name")
            Button2.PerformClick()
            Exit Sub
        End If
        If lname = Nothing Then
            MessageBox.Show("Please Enter the Last Name")
            Button2.PerformClick()
            Exit Sub
        End If

        If uname.Length < 2 Then
            MessageBox.Show("Username should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If uname.Length > 50 Then
            MessageBox.Show("Username can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If pwd.Length < 2 Then
            MessageBox.Show("Password should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If pwd.Length > 50 Then
            MessageBox.Show("Password can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If

        If fname.Length < 2 Then
            MessageBox.Show("First Name should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If fname.Length > 50 Then
            MessageBox.Show("First Name can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        '###### For detailed commenting please visit 113-311 ##############
        If lname.Length < 2 Then
            MessageBox.Show("Last Name should contain atleast 2 characters")
            Button2.PerformClick()
            Exit Sub
        End If
        If lname.Length > 50 Then
            MessageBox.Show("Last Name can contain a maximum of 50 characters")
            Button2.PerformClick()
            Exit Sub
        End If

        For Each c As Char In uname
            If (Char.IsLetterOrDigit(c)) Then
            Else
                MessageBox.Show("Username can contain only alphanumeric characters")
                Button2.PerformClick()
                Exit Sub
            End If
        Next

        For Each c As Char In fname
            If (Char.IsLetter(c)) Then
            Else
                MessageBox.Show("Firstname can contain only Uppercase and LowerCase Letters")
                Button2.PerformClick()
                Exit Sub
            End If
        Next

        For Each c As Char In lname
            If (Char.IsLetter(c)) Then
            Else
                MessageBox.Show("Last name can contain only Uppercase and LowerCase Letters")
                Button2.PerformClick()
                Exit Sub
            End If
        Next
        '####### for deatiled commenting of this section please visit 113-311
        If Student_Checkbox.Checked = True Then
            If y = Nothing Then
                MessageBox.Show("Please Enter your Year of Joining")
                Button2.PerformClick()
                Exit Sub
            End If


            If roll = Nothing Then
                MessageBox.Show("Please Enter your Roll No.")
                Button2.PerformClick()
                Exit Sub
            End If
            If prog = Nothing Then
                MessageBox.Show("Please Enter in which Programme you are enrolled")
                Button2.PerformClick()
                Exit Sub
            End If
            If dept_stu = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Button2.PerformClick()
                Exit Sub
            End If
            If ta = Nothing And guide_2 = Nothing Then
                MessageBox.Show("Please Mention either your TA Superviser or Guide")
                Button2.PerformClick()
                Exit Sub
            End If

            For Each c As Char In y
                If (Char.IsNumber(c)) Then
                Else
                    MessageBox.Show("Please enter a Valid Year")
                    Button2.PerformClick()
                    Exit Sub
                End If
            Next
            If y.Length() <> 4 Then
                MessageBox.Show("Please enter a Valid Year")
                Button2.PerformClick()
                Exit Sub
            End If


            For Each c As Char In roll
                If (Char.IsNumber(c)) Then
                Else
                    MessageBox.Show("Roll No. should contain only digits")
                    Button2.PerformClick()
                    Exit Sub
                End If
            Next
            If roll.Length() <> 9 Then
                MessageBox.Show("Roll No. should contain exactly 9 digits")
                Button2.PerformClick()
                Exit Sub
            End If
        End If

        If Faculty_Checkbox.Checked = True Then
            If dept_fac = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Button2.PerformClick()
                Exit Sub
            End If
            If desg = Nothing Then
                MessageBox.Show("Please Enter your Designation")
                Button2.PerformClick()
                Exit Sub
            End If
        End If

        If HOD_CheckBox.Checked = True Then
            If dept_fac = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Button2.PerformClick()
                Exit Sub
            End If
        End If
        'Captcha validation
        If str <> VALIDATION.Text Then
            MessageBox.Show("Invalid Validation, Please Try Again")
            Button2.PerformClick()
            Exit Sub
        End If

        'Updating DATABASE based on type of user
        Try
            If Student_Checkbox.Checked = True Then
                Access.ExecQuery("UPDATE Student_DB SET Roll_no=" & ROLL_NO.Text & ", Programme='" & PROGRAMME.Text & "', Guide='" & GUIDE.Text & "', TA_Superviser='" & TA_SUPERVISER.Text & "', First_name='" & FIRST_NAME.Text & "', Last_name='" & LAST_NAME.Text & "', Department='" & DEPARTMENT.Text & "', Year_of_joining='" & YEAR.Text & "' WHERE Username='" & USERNAME.Text & "'")
            End If
            If Faculty_Checkbox.Checked = True Then
                Access.ExecQuery("UPDATE Faculty_DB SET Designation='" & DESIGNATION.Text & "' ,First_name='" & FIRST_NAME.Text & "', Last_name='" & LAST_NAME.Text & "', Department='" & DEPARTMENT_FAC.Text & "' WHERE Username='" & USERNAME.Text & "'")
            End If
            If HOD_CheckBox.Checked = True Then
                Access.ExecQuery("UPDATE Faculty_DB SET First_name='" & FIRST_NAME.Text & "', Last_name='" & LAST_NAME.Text & "', Department='" & DEPARTMENT_FAC.Text & "' WHERE Username='" & USERNAME.Text & "'")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Form1.Show()
        Form1.txtPassword.Text = Nothing
        Me.Hide()
    End Sub
    Private Sub USERNAME_MouseMove(sender As Object, e As MouseEventArgs) Handles USERNAME.MouseMove
        USERNAME.Focus()
    End Sub

    Private Sub PASSWORD_MouseMove(sender As Object, e As MouseEventArgs) Handles PASSWORD.MouseMove
        PASSWORD.Focus()
    End Sub

    Private Sub FIRST_NAME_MouseMove(sender As Object, e As MouseEventArgs) Handles FIRST_NAME.MouseMove
        FIRST_NAME.Focus()
    End Sub

    Private Sub LAST_NAME_MouseMove(sender As Object, e As MouseEventArgs) Handles LAST_NAME.MouseMove
        LAST_NAME.Focus()
    End Sub

    Private Sub YEAR_MouseMove(sender As Object, e As MouseEventArgs) Handles Year.MouseMove
        YEAR.Focus()
    End Sub

    Private Sub ROLL_NO_MouseMove(sender As Object, e As MouseEventArgs) Handles ROLL_NO.MouseMove
        ROLL_NO.Focus()
    End Sub

    Private Sub VALIDATION_MouseMove(sender As Object, e As MouseEventArgs) Handles VALIDATION.MouseMove
        VALIDATION.Focus()
    End Sub
End Class