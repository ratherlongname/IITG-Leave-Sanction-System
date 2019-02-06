Imports System.Drawing.Drawing2D
Public Class Form2
    Private Access As New DBControl

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.PerformClick()

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

    End Sub

    Private Sub Student_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Student_Checkbox.CheckedChanged
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

        If uname = Nothing Then
            MessageBox.Show("Please Enter some Username")
            Exit Sub
        End If
        If pwd = Nothing Then
            MessageBox.Show("Please Enter the Password")
            Exit Sub
        End If
        If fname = Nothing Then
            MessageBox.Show("Please Enter the First Name")
            Exit Sub
        End If
        If lname = Nothing Then
            MessageBox.Show("Please Enter the Last Name")
            Exit Sub
        End If

        For Each c As Char In uname
            If (Char.IsLetterOrDigit(c)) Then
            Else
                MessageBox.Show("Username can contain only alphanumeric characters")
                Exit Sub
            End If
        Next

        For Each c As Char In fname
            If (Char.IsLetter(c)) Then
            Else
                MessageBox.Show("Firstname can contain only Uppercase and LowerCase Letters")
                Exit Sub
            End If
        Next

        For Each c As Char In lname
            If (Char.IsLetter(c)) Then
            Else
                MessageBox.Show("Last name can contain only Uppercase and LowerCase Letters")
                Exit Sub
            End If
        Next

        If Student_Checkbox.Checked = True Then
            If y = Nothing Then
                MessageBox.Show("Please Enter your Year of Joining")
                Exit Sub
            End If


            If roll = Nothing Then
                MessageBox.Show("Please Enter your Roll No.")
                Exit Sub
            End If
            If prog = Nothing Then
                MessageBox.Show("Please Enter in which Programme you are enrolled")
                Exit Sub
            End If
            If dept_stu = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Exit Sub
            End If
            If ta = Nothing And guide_2 = Nothing Then
                MessageBox.Show("Please Mention either your TA Superviser or Guide")
                Exit Sub
            End If

            For Each c As Char In y
                If (Char.IsNumber(c)) Then
                Else
                    MessageBox.Show("Please enter a Valid Year")
                    Exit Sub
                End If
            Next
            If y.Length() <> 4 Then
                MessageBox.Show("Please enter a Valid Year")
                Exit Sub
            End If


            For Each c As Char In roll
                If (Char.IsNumber(c)) Then
                Else
                    MessageBox.Show("Roll No. should contain only digits")
                    Exit Sub
                End If
            Next
            If roll.Length() <> 9 Then
                MessageBox.Show("Roll No. should contain exactly 9 digits")
                Exit Sub
            End If
        End If

        If Faculty_Checkbox.Checked = True Then
            If dept_fac = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Exit Sub
            End If
            If desg = Nothing Then
                MessageBox.Show("Please Enter your Designation")
                Exit Sub
            End If
        End If

        If HOD_CheckBox.Checked = True Then
            If dept_fac = Nothing Then
                MessageBox.Show("Please Enter your Department")
                Exit Sub
            End If
        End If


        'PLEASE USE fname.Trim() and lname.Trim() to feed in the database
        Try
            Dim userAlreadyExists As Boolean = False

            Access.AddParam("@user", USERNAME.Text)
            Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user")
            If Access.RecordCount > 0 Then userAlreadyExists = True

            Access.AddParam("@user", USERNAME.Text)
            Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username=@user")
            If Access.RecordCount > 0 Then userAlreadyExists = True

            If userAlreadyExists Then
                MessageBox.Show("User already exists with the same username try entering a differnet username", "USER EXISTS")
            Else
                If Student_Checkbox.Checked = True Then
                    roll = CInt(roll)
                    y = CInt(y)

                    Access.AddParam("@user", uname)
                    Access.AddParam("@pwd", pwd)
                    Access.AddParam("@fname", fname)
                    Access.AddParam("@lname", lname)
                    Access.AddParam("@y", y)
                    Access.AddParam("@roll", roll)
                    Access.AddParam("@ta", ta)
                    Access.AddParam("@guide", guide_2)
                    Access.AddParam("@dept_stu", dept_stu)
                    Access.AddParam("@prog", prog)
                    Dim dum As String = ""
                    Access.AddParam("@dum", dum)
                    Dim days As Integer = 0
                    Access.AddParam("@days", days)
                    Dim days_1 As Integer = 120
                    Access.AddParam("@days_1", days_1)
                    Dim days_2 As Integer = 15
                    Access.AddParam("@days_2", days_2)
                    Dim days_3 As Integer = 30
                    Access.AddParam("@days_3", days_3)


                    Access.ExecQuery("INSERT INTO Student_DB([Username], [Password], [Roll_no], [Programme], [Department], [First_name], [Last_name], [Year_of_joining], [Days_of_stipend_cut], [TA_Superviser], [Guide], [List_of_leaves], [Academic], [Notification], [Ordinary], [Medical])VALUES(@user, @pwd, @roll, @prog, @dept_stu, @fname, @lname, @y, @days, @ta, @guide, @dum, @days_1, @dum, @days_2, @days_3)")
                End If

                If Faculty_Checkbox.Checked = True Then
                    Access.AddParam("@user", uname)
                    Access.AddParam("@pwd", pwd)
                    Access.AddParam("@fname", fname)
                    Access.AddParam("@lname", lname)
                    Access.AddParam("@dept", dept_fac)
                    Access.AddParam("@desg", desg)
                    Dim days As Integer = 0
                    Access.AddParam("@days", days)
                    Dim days_1 As Integer = 120
                    Access.AddParam("@days_1", days_1)
                    Dim days_2 As Integer = 15
                    Access.AddParam("@days_2", days_2)
                    Dim days_3 As Integer = 30
                    Access.AddParam("@days_3", days_3)
                    Access.ExecQuery("INSERT INTO Faculty_DB([Username], [Password], [Department], [First_name], [Last_name], [List_of_Leaves_Applied], [Academic], [Notifications], [Ordinary], [Medical], [List_of_Incoming_Leaves], [Designation])VALUES(@user, @pwd, @roll, @dept, @fname, @lname, @dum, @days_1, @dum, @days_2, @days_3, @dum, @desg)")
                End If

                If HOD_CheckBox.Checked = True Then
                    Dim desg_2 As String = "HOD"

                    Access.AddParam("@user", uname)
                    Access.AddParam("@pwd", pwd)
                    Access.AddParam("@fname", fname)
                    Access.AddParam("@lname", lname)
                    Access.AddParam("@dept", dept_fac)
                    Access.AddParam("@desg_2", desg_2)

                    Dim days As Integer = 0
                    Access.AddParam("@days", days)
                    Dim days_1 As Integer = 120
                    Access.AddParam("@days_1", days_1)
                    Dim days_2 As Integer = 15
                    Access.AddParam("@days_2", days_2)
                    Dim days_3 As Integer = 30
                    Access.AddParam("@days_3", days_3)
                    Access.ExecQuery("INSERT INTO Faculty_DB([Username], [Password], [Department], [First_name], [Last_name], [List_of_Leaves_Applied], [Academic], [Notifications], [Ordinary], [Medical], [List_of_Incoming_Leaves], [Designation])VALUES(@user, @pwd, @roll, @dept, @fname, @lname, @dum, @days_1, @dum, @days_2, @days_3, @dum, @desg_2)")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    'Public Function ContainsSpecialChars(s As String) As Boolean
    '    Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?\]1234567890 ".ToCharArray) <> -1
    'End Function



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




    'Dim roll As String = ROLL_NO.Text
    'Dim y As String = YEAR.Text
    ''Checking whether the entered roll number is valid or not 
    '    If (Not (IsNumeric(roll)) And roll <> "") Then
    '        MessageBox.Show("The roll number entered is invalid", roll)
    '        flag = 1
    '    End If
    ''Checking whether the entered year is valid or not
    '    If (Not (IsNumeric(y)) And y <> "") Then
    '        MessageBox.Show("The year entered is invalid", y)
    '        flag = 1
    '    End If
    ''After removing the leading and trailing spaces from name ,checking whether the name contains special characters or not
    '    If ((ContainsSpecialChars(fname.Trim()) Or ContainsSpecialChars(lname.Trim())) And fname <> "" And lname <> "") Then
    '        MessageBox.Show("The Name is not in a valid format,contains unacceptable characters", "INVALID DATA ENTERED")
    '        flag = 1
    '    End If

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim Str As String = Nothing
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
End Class