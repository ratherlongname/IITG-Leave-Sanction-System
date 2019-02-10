Public Class Form3
    Private Access As New DBControl
    Dim Start_Date As Date
    Dim End_Date As Date

    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
    End Sub


    Private Sub tabpgViewLeaves_Enter(sender As Object, e As EventArgs) Handles tabpgViewLeaves.Enter
        RefreshViewLeaves()
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

        Dim remark As String = Remark_Box.Text
        Dim type As String = Type_Of_Leave.Text
        Dim status As String = "Pending"
        Dim username As String = Label1.Text
        Dim d As Date = System.DateTime.Now()
        Dim l_id As String = ""
        l_id = username(0) + username(1) + username(0) + username(1)
        Dim list_of_Update As String = l_id
        Dim list_of_participating_users As String = ""

        'Access.AddParam("@desg", "HOD")
        'Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & s & "'")
        'For Each r As DataRow In Access.DBDT.Rows
        '    MessageBox.Show(r.Item(0))
        'Next
        'dgv.DataSource = Access.DBDT
        'Dim hod As String = Access.DBDT.Rows(0).Item(0)

        ''Access.AddParam("@desg", "ADOAA")
        ''Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Designation=@desg")
        ''Dim adoaa As String = Access.DBDT.Rows(0).Item("Username")

        'Access.AddParam("@user", username)
        'Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user")

        'If Access.RecordCount > 0 Then
        '    Dim ta As String = Access.DBDT.Rows(0).Item("TA_Superviser")
        '    Dim guide As String = Access.DBDT.Rows(0).Item("Guide")
        '    If ta <> "" Then
        '        list_of_participating_users = list_of_participating_users + ta + ","
        '    End If

        '    If guide <> "" Then
        '        list_of_participating_users = list_of_participating_users + guide + ","
        '    End If
        '    Access.AddParam("@user2", username)
        '    Access.AddParam("@date2", d)
        '    Access.AddParam("@current", status)
        '    Access.AddParam("@type2", type)
        '    Access.AddParam("@start_d", Start_Date)
        '    Access.AddParam("@end_d", End_Date)
        '    Access.AddParam("@leave_id", l_id)
        '    Access.AddParam("@lopu", list_of_participating_users)
        '    Access.AddParam("@leave_log", list_of_Update)
        '    Access.AddParam("@remarks", remark)
        '    Access.ExecQuery("INSERT INTO Leave_DB([Username], [Date/Time Applied], [Current_Status], [Type_of_Leave], [Start_Date], [End_Date], [Leave_ID], [List_of_Participating_Users], [Leave_Log], [Remarks])VALUES(@user2, @date2, @current, @type2, @start_d, @end_d, @leave_id, @lopu, @leave_log, @remarks)")
        'Else

        '    Access.AddParam("@user2", username)
        '    Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username = @user2")
        '    If Access.RecordCount > 0 Then
        '        Access.AddParam("@user2", username)
        '        Access.AddParam("@date2", d)
        '        Access.AddParam("@current", status)
        '        Access.AddParam("@type2", type)
        '        Access.AddParam("@start_d", Start_Date)
        '        Access.AddParam("@end_d", End_Date)
        '        Access.AddParam("@leave_id", l_id)
        '        Access.AddParam("@lopu", list_of_participating_users)
        '        Access.AddParam("@leave_log", list_of_Update)
        '        Access.AddParam("@remarks", remark)
        '        Access.ExecQuery("INSERT INTO Leave_DB([Username], [Date/Time Applied], [Current_Status], [Type_of_Leave], [Start_Date], [End_Date], [Leave_ID], [List_of_Participating_Users], [Leave_Log], [Remarks])VALUES(@user2, @date2, @current, @type2, @start_d, @end_d, @leave_id, @lopu, @leave_log, @remarks)")
        '    End If
        'End If

    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click

        Form2.USERNAME.Text = Label1.Text
        Form2.USERNAME.Enabled = False
        Access.AddParam("@user", Label1.Text)
        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username=@user")

        If Access.RecordCount > 0 Then
            Form2.Faculty_Checkbox.Checked = True
            Form2.FIRST_NAME.Text = Access.DBDT.Rows(0).Item("First_Name")
            Form2.LAST_NAME.Text = Access.DBDT.Rows(0).Item("Last_Name")
            If Access.DBDT.Rows(0).Item("Designation") <> "HOD" Then
                Form2.DEPARTMENT_FAC.Text = Access.DBDT.Rows(0).Item("Department")
                Form2.DESIGNATION.Text = Access.DBDT.Rows(0).Item("Designation")
                Form2.PASSWORD.Text = Access.DBDT.Rows(0).Item("Password")
                Form2.PASSWORD.Enabled = False
                Form2.PASSWORD.PasswordChar = "*"

            Else
                Form2.DEPARTMENT_FAC.Text = Access.DBDT.Rows(0).Item("Department")
                Form2.PASSWORD.Text = Access.DBDT.Rows(0).Item("Password")
                Form2.PASSWORD.Enabled = False
                Form2.PASSWORD.PasswordChar = "*"
                Form2.HOD_CheckBox.Checked = True
            End If


        Else
            Access.AddParam("@user2", Label1.Text)
            Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user2")
            If Access.RecordCount > 0 Then
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
            End If

        End If

        Me.Close()
        Form2.Show()
    End Sub
End Class