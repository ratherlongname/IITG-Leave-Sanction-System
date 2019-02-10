Public Class Form3
    Private Access As New DBControl
    Dim Start_Date As Date
    Dim End_Date As Date

    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If Label4.Text = Nothing Then
            Me.tabctrlMainTabs.TabPages.Remove(tabpgLeavesToApprove)
        End If

        ' INITIALIZE VIEW LEAVES TAB
        cmbbxViewLeavesSortBy.SelectedIndex = 0
        chkdlsbxViewLeavesTypeOfLeave.SetItemChecked(0, True)
        chkdlsbxViewLeavesTypeOfLeave.SetItemChecked(1, True)
        chkdlsbxViewLeavesTypeOfLeave.SetItemChecked(2, True)

        chkdlsbxViewLeavesStatus.SetItemChecked(0, True)
        chkdlsbxViewLeavesStatus.SetItemChecked(1, True)
        chkdlsbxViewLeavesStatus.SetItemChecked(2, True)
        chkdlsbxViewLeavesStatus.SetItemChecked(3, True)

        RefreshViewLeaves()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub


    Private Sub tabpgViewLeaves_Enter(sender As Object, e As EventArgs) Handles tabpgViewLeaves.Enter
        RefreshViewLeaves()
    End Sub

    Private Sub tabpgLeavesToApprove_Enter(sender As Object, e As EventArgs) Handles tabpgLeavesToApprove.Enter

        Dim user As String = Label1.Text
        Access.ExecQuery("SELECT * FROM Leave_DB")
        Dim str(Access.RecordCount) As Integer
        Dim i As Integer = 0
        Dim curr_i As Integer = 0

        If Access.RecordCount > 0 Then
            For Each r As DataRow In Access.DBDT.Rows
                Dim s As String
                Dim flag As Integer = 0
                s = Access.DBDT.Rows(i).Item("List_of_Participating_Users")
                MessageBox.Show(s)
                Dim s1 As String = ""
                For Each c As Char In s
                    If c <> "," And c <> " " Then
                        s1 = s1 + c
                    Else
                        If s1 = user Then
                            flag = 1
                            Exit For
                        End If
                        s1 = ""
                    End If
                Next
                If flag = 1 Then
                    'MessageBox.Show(r(0))
                    str(curr_i) = i
                    curr_i = curr_i + 1
                    Dim dum As String = r(6)
                    Dim v As New ListViewItem(dum)
                    v.SubItems.Add(r(0))
                    v.SubItems.Add(r(1))
                    v.SubItems.Add(r(4))
                    v.SubItems.Add(r(5))
                    v.SubItems.Add(r(3))
                    APPROVED.Items.Add(v)
                End If
                i = i + 1
            Next
        End If
    End Sub


    Private Sub btnViewLeavesRefresh_Click(sender As Object, e As EventArgs) Handles btnViewLeavesRefresh.Click
        RefreshViewLeaves()
    End Sub

    Private Sub RefreshViewLeaves()
        ' CLEAR EXISTING DATA IN LISTVIEW
        lsviewViewLeavesListOfLeaves.Items.Clear()

        ' REPOPULATE LISTVIEW
        'Access.AddParam("@user", Label1.Text)
        'Access.ExecQuery("SELECT Date/Time Applied, Leave_ID, Type_of_leave, Start_Date, End_Date, Current_Status FROM Leave_DB WHERE Username=@user")


        ' TODO

    End Sub

    Private Sub Date_Calc_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Date_Calc.DateChanged
        Start_Date = e.Start
        End_Date = e.End
        E_Date.Enabled = False
        S_Date.Enabled = False
        S_Date.Text = e.Start.ToShortDateString()
        E_Date.Text = e.End.ToShortDateString()
    End Sub

    Private Sub Submit_new_Click(sender As Object, e As EventArgs) Handles Submit_new.Click
        'Getting all the Required Inputs fr database
        End_Date = CDate(End_Date.ToShortDateString)
        Dim D1 As Date = Start_Date
        Dim D2 As Date = End_Date
        'Calculating The duration of leave
        Dim difference As TimeSpan = D2.Subtract(D1)
        Dim number_of_days As Integer = difference.TotalDays
        Dim remark As String = Remark_Box.Text
        Dim type As String = Type_Of_Leave.Text
        Dim status As String = "Pending"
        Dim username As String = Label1.Text
        Dim d As Date = System.DateTime.Now()
        'Generating Leave_ID
        Dim l_id As String = ""
        l_id = username(0) + username(1) + username(0) + username(1)
        Dim d_2 As String = Nothing
        d_2 = d.ToString()
        For Each c As Char In d_2
            If c <> " " And c <> "-" And c <> ":" Then
                l_id = l_id + c
            End If
        Next
        'MessageBox.Show(l_id)
        Dim list_of_Update As String = l_id
        Dim list_of_participating_users As String = ""

        Dim s As String = "HOD"
        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Designation='" & s & "'")
        Dim hod As String = Access.DBDT.Rows(0).Item(0)

        Dim s2 As String = "ADOAA"
        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Designation='" & s2 & "'")
        Dim adoaa As String = Access.DBDT.Rows(0).Item("Username")

        Access.AddParam("@user", username)
        Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user")



        'If the Student is logged in
        If Access.RecordCount > 0 Then
            'Adding TA Superviser and guide in list of participating users
            Dim ta As String = Access.DBDT.Rows(0).Item("TA_Superviser")
            Dim guide As String = Access.DBDT.Rows(0).Item("Guide")
            Dim BALANCE_LEFT As Integer = Access.DBDT.Rows(0).Item(type)
            If type = "Ordinary" Then
                If BALANCE_LEFT < number_of_days Then
                    MessageBox.Show("Can't apply for ordinary leave")
                    Exit Sub
                Else
                    Dim help As Integer = BALANCE_LEFT - number_of_days
                    Access.ExecQuery("UPDATE Student_DB SET Ordinary=" & help & "")
                End If
            ElseIf type = "Medical" Then
                If BALANCE_LEFT < number_of_days Then
                    MessageBox.Show("Can't apply for medical leave")
                    Exit Sub
                Else
                    Dim help As Integer = BALANCE_LEFT - number_of_days
                    Access.ExecQuery("UPDATE Student_DB SET Medical=" & help & "")
                End If
            Else
                If BALANCE_LEFT < number_of_days Then
                    MessageBox.Show("Can't apply for academic leave")
                    Exit Sub
                Else
                    Dim help As Integer = BALANCE_LEFT - number_of_days
                    Access.ExecQuery("UPDATE Student_DB SET Academic=" & help & "")
                End If
            End If


            If ta <> "" Then
                list_of_participating_users = list_of_participating_users + ta + ","
            End If

            If guide <> "" Then
                list_of_participating_users = list_of_participating_users + guide + ","
            End If

            'Deciding the UPSTREAM of leave by checking leave duration and type of leave
            If Type_Of_Leave.Text = "Ordinary" Then
                If number_of_days > 15 Then
                    list_of_participating_users = list_of_participating_users + hod + ","
                End If
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                End If
            End If
            If Type_Of_Leave.Text = "Medical" Then
                If number_of_days > 15 Then
                    list_of_participating_users = list_of_participating_users + hod + ","
                End If
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                End If
            End If
            If Type_Of_Leave.Text = "Academic" Then
                If number_of_days > 15 Then
                    list_of_participating_users = list_of_participating_users + hod + ","
                End If
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                End If
            End If
            'Entering the Data into the Leave DataBase
            Access.AddParam("@user2", username)
            Access.AddParam("@date2", d)
            Access.AddParam("@current", status)
            Access.AddParam("@type2", type)
            Access.AddParam("@start_d", Start_Date)
            Access.AddParam("@end_d", End_Date)
            Access.AddParam("@leave_id", l_id)
            Access.AddParam("@lopu", list_of_participating_users)
            Access.AddParam("@leave_log", list_of_Update)
            Access.AddParam("@remarks", remark)
            'Insert Query to insert into the Leave DATABASE
            Access.ExecQuery("INSERT INTO Leave_DB([Username], [Date/Time Applied], [Current_Status], [Type_of_Leave], [Start_Date], [End_Date], [Leave_ID], [List_of_Participating_Users], [Leave_Log], [Remarks])VALUES(@user2, @date2, @current, @type2, @start_d, @end_d, @leave_id, @lopu, @leave_log, @remarks)")

            'Entering the data into the update DataBase
            Access.AddParam("@leave_id2", l_id)
            Access.AddParam("@leave_id3", l_id)
            Access.AddParam("@date3", d)
            Access.AddParam("@user3", username)
            Dim dum As String = ""
            Dim dum2 As String = "Pending"
            Access.AddParam("@dum", dum)
            Access.AddParam("@dum2", dum2)
            Access.AddParam("@user4", username)
            Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status], [Username_Action])VALUES(@leave_id2, @leave_id3, @date3, @user3, @dum, @dum2, @user4)")
        Else
            'For the case when Faculty is Logged in
            Access.AddParam("@user2", username)
            Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username = @user2")
            If Access.RecordCount > 0 Then
                'Adding HOD and ADOAA in list of participating Users
                list_of_participating_users = list_of_participating_users + hod + ","
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                End If

                Dim BALANCE_LEFT As Integer = Access.DBDT.Rows(0).Item(type)
                If type = "Ordinary" Then
                    If BALANCE_LEFT < number_of_days Then
                        MessageBox.Show("Can't apply for ordinary leave")
                        Exit Sub
                    Else
                        Dim help As Integer = BALANCE_LEFT - number_of_days
                        Access.ExecQuery("UPDATE Student_DB SET Ordinary=" & help & "")
                    End If
                ElseIf type = "Medical" Then
                    If BALANCE_LEFT < number_of_days Then
                        MessageBox.Show("Can't apply for medical leave")
                        Exit Sub
                    Else
                        Dim help As Integer = BALANCE_LEFT - number_of_days
                        Access.ExecQuery("UPDATE Student_DB SET Medical=" & help & "")
                    End If
                Else
                    If BALANCE_LEFT < number_of_days Then
                        MessageBox.Show("Can't apply for academic leave")
                        Exit Sub
                    Else
                        Dim help As Integer = BALANCE_LEFT - number_of_days
                        Access.ExecQuery("UPDATE Student_DB SET Academic=" & help & "")
                    End If
                End If

                'Adding Parameters for the insert query
                Access.AddParam("@user2", username)
                Access.AddParam("@date2", d)
                Access.AddParam("@current", status)
                Access.AddParam("@type2", type)
                Access.AddParam("@start_d", Start_Date)
                Access.AddParam("@end_d", End_Date)
                Access.AddParam("@leave_id", l_id)
                Access.AddParam("@lopu", list_of_participating_users)
                Access.AddParam("@leave_log", list_of_Update)
                Access.AddParam("@remarks", remark)
                'Insert Command for Entering the Data into the Leave Database
                Access.ExecQuery("INSERT INTO Leave_DB([Username], [Date/Time Applied], [Current_Status], [Type_of_Leave], [Start_Date], [End_Date], [Leave_ID], [List_of_Participating_Users], [Leave_Log], [Remarks])VALUES(@user2, @date2, @current, @type2, @start_d, @end_d, @leave_id, @lopu, @leave_log, @remarks)")

                'Adding parameters for the Insert query in Update DB
                Access.AddParam("@leave_id2", l_id)
                Access.AddParam("@leave_id3", l_id)
                Access.AddParam("@date3", d)
                Access.AddParam("@user3", username)
                Dim dum As String = ""
                Dim dum2 As String = "Pending"
                Access.AddParam("@dum", dum)
                Access.AddParam("@dum2", dum2)
                Access.AddParam("@user4", username)
                'Insert Command for the Update_DB
                Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status], [Username_Action])VALUES(@leave_id2, @leave_id3, @date3, @user3, @dum, @dum2, @user4)")

            End If

        End If
            MessageBox.Show("LEAVE APLLIED SUCCESSFULLY")
    End Sub

    'This Button is for EDITING the profile
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click

        'Not making username Editable
        Form2.USERNAME.Text = Label1.Text
        Form2.USERNAME.Enabled = False
        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & Label1.Text & "'")
        'if the faculty is logged in (Includes the case of HOD
        If Access.RecordCount > 0 Then

            Form2.FIRST_NAME.Text = Access.DBDT.Rows(0).Item("First_Name")
            Form2.LAST_NAME.Text = Access.DBDT.Rows(0).Item("Last_Name")
            'FOR Faculties which are not HOD
            If Access.DBDT.Rows(0).Item("Designation") <> "HOD" Then
                Form2.Faculty_Checkbox.Checked = True
                Form2.Student_Checkbox.Enabled = False
                Form2.HOD_CheckBox.Enabled = False
                Form2.DEPARTMENT_FAC.Text = Access.DBDT.Rows(0).Item("Department")
                Form2.DESIGNATION.Text = Access.DBDT.Rows(0).Item("Designation")
                Form2.PASSWORD.Text = Access.DBDT.Rows(0).Item("Password")
                Form2.PASSWORD.Enabled = False
                Form2.PASSWORD.PasswordChar = "*"
                Form2.DEPARTMENT_FAC.Visible = True
                Form2.DESIGNATION.Visible = True

                'For The HOD
            Else
                Form2.DEPARTMENT_FAC.Text = Access.DBDT.Rows(0).Item("Department")
                Form2.PASSWORD.Text = Access.DBDT.Rows(0).Item("Password")
                Form2.PASSWORD.Enabled = False
                Form2.PASSWORD.PasswordChar = "*"
                Form2.HOD_CheckBox.Checked = True
                Form2.Student_Checkbox.Enabled = False
                Form2.Faculty_Checkbox.Enabled = False
                Form2.DEPARTMENT_FAC.Visible = True
            End If

            'If The student is logged in
        Else
            Access.AddParam("@user2", Label1.Text)
            Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user2")
            If Access.RecordCount > 0 Then
                'Getting all the old Deatails and filling into the EDIT FORM
                Form2.FIRST_NAME.Text = Access.DBDT.Rows(0).Item("First_name")
                Form2.LAST_NAME.Text = Access.DBDT.Rows(0).Item("Last_name")
                Form2.ROLL_NO.Text = Access.DBDT.Rows(0).Item("Roll_no")
                Form2.YEAR.Text = Access.DBDT.Rows(0).Item("Year_of_joining")
                Form2.PROGRAMME.Text = Access.DBDT.Rows(0).Item("Programme")
                Form2.TA_SUPERVISER.Text = Access.DBDT.Rows(0).Item("TA_Superviser")
                Form2.GUIDE.Text = Access.DBDT.Rows(0).Item("Guide")
                Form2.DEPARTMENT.Text = Access.DBDT.Rows(0).Item("Department")
                Form2.PASSWORD.Text = Access.DBDT.Rows(0).Item("Password")
                Form2.PASSWORD.Enabled = False
                Form2.PASSWORD.PasswordChar = "*"
                Form2.Student_Checkbox.Checked = True
                Form2.Faculty_Checkbox.Enabled = False
                Form2.HOD_CheckBox.Enabled = False

            End If

        End If

        'Opening the EDIT FORM
        Me.Close()
        Form2.Show()
    End Sub
End Class