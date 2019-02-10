Imports System.Drawing.Drawing2D

Public Class Form2
    Private Access As New DBControl
    Dim str As String = Nothing


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.PerformClick()

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

        If str <> VALIDATION.Text Then
            MessageBox.Show("Invalid Validation, Please Try Again")
            Button2.PerformClick()
            Exit Sub
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
                Button2.PerformClick()
                Exit Sub
            Else
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

                    Access.ExecQuery("INSERT INTO Student_DB([Username], [Password], [Roll_no], [Programme], [Department], [First_name], [Last_name], [Year_of_joining], [Days_of_stipend_cut], [TA_Superviser], [Guide], [List_of_leaves], [Academic], [Notification], [Ordinary], [Medical])VALUES(@user, @pwd, @roll, @prog, @dept_stu, @fname, @lname, @y, @days, @ta, @guide, @dum, @days_1, @dum2, @days_2, @days_3)")

                    Form1.Show()
                    Me.Close()

                End If


                If Faculty_Checkbox.Checked = True Then
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
                    Access.ExecQuery("INSERT INTO Faculty_DB([Username], [Password], [First_Name], [Last_Name],  [Department], [List_of_Leaves_Applied], [Notifications], [List_of_Incoming_Leaves], [Designation], [Ordinary], [Medical], [Academic])VALUES(@user, @pwd, @fname, @lname, @dept, @dum, @dum2, @dum3, @desg, @days_2, @days_3, @days_1)")
                    Form1.Show()
                    Me.Close()
                End If

                If HOD_CheckBox.Checked = True Then
                    Dim desg_2 As String = "HOD"

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
                    Access.ExecQuery("INSERT INTO Faculty_DB([Username], [Password], [First_Name], [Last_Name],  [Department], [List_of_Leaves_Applied], [Notifications], [List_of_Incoming_Leaves], [Designation], [Ordinary], [Medical], [Academic])VALUES(@user, @pwd, @fname, @lname, @dept, @dum, @dum2, @dum3, @desg_2, @days_2, @days_3, @days_1)")
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
        Form1.Show()
    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click

    End Sub
End Class