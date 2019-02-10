

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
        Form1.Show()

    End Sub


    Private Sub tabpgViewLeaves_Enter(sender As Object, e As EventArgs) Handles tabpgViewLeaves.Enter
        RefreshViewLeaves()
    End Sub

    Private Sub tabpgLeavesToApprove_Enter(sender As Object, e As EventArgs) Handles tabpgLeavesToApprove.Enter

        'dgv1.Rows.Clear()

        Dim user As String = Label1.Text
        Access.ExecQuery("SELECT * FROM Leave_DB")
        Dim str(Access.RecordCount) As Integer
        Dim i As Integer = 0
        Dim curr_i As Integer = 0
        Dim flag As Integer = 0

        If Access.RecordCount > 0 Then
            For Each r As DataRow In Access.DBDT.Rows
                Dim s As String
                s = Access.DBDT.Rows(i).Item("List_of_Participating_Users")
                Dim s1 As String = ""

                For Each c As Char In s
                    If c <> "," Or c <> " " Then
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
                    str(curr_i) = i
                    curr_i = curr_i + 1

                    Dim lst As ListViewItem
                    lst = APPROVED.Items.Add(r(0))
                    For index As Integer = 1 To 6
                        Debug.Print(r(index).ToString)
                        lst.SubItems.Add(r(i))
                    Next

                End If




                i = i + 1
            Next
        End If


        'For Each row As DataRow In Access.DBDT.Rows
        '    Dim lst As ListViewItem
        '    lst = APPROVED.Items.Add(row(0))
        '    For index As Integer = 1 To Data.Columns.Count - 1
        '        Debug.Print(row(index).ToString)
        '        lst.SubItems.Add(row(i))
        '    Next
        'Next











        'Dim col As New DataGridViewTextBoxColumn
        'col.DataPropertyName = "TEMP"
        'col.HeaderText = "Leave_ID"
        'col.Name = "col1"
        'dgv1.Columns.Add(col)

        'Dim col1 As New DataGridViewTextBoxColumn
        'col1.DataPropertyName = "TEMP1"
        'col1.HeaderText = "Username"
        'col1.Name = "col2"
        'dgv1.Columns.Add(col1)

        'Dim col2 As New DataGridViewTextBoxColumn
        'col2.DataPropertyName = "TEMP2"
        'col2.HeaderText = "Date/Time"
        'col2.Name = "col3"
        'dgv1.Columns.Add(col2)

        'Dim col3 As New DataGridViewTextBoxColumn
        'col3.DataPropertyName = "TEMP3"
        'col3.HeaderText = "Start Date"
        'col3.Name = "col4"
        'dgv1.Columns.Add(col3)

        'Dim col4 As New DataGridViewTextBoxColumn
        'col4.DataPropertyName = "TEMP4"
        'col4.HeaderText = "End Date"
        'col4.Name = "col5"
        'dgv1.Columns.Add(col4)
        'For j As Integer = 0 To curr_i
        '    dgv1.Rows.Insert(j, New String() {Access.DBDT.Rows(str(j)).Item("Leave_ID"), Access.DBDT.Rows(str(j)).Item("Username"), Access.DBDT.Rows(str(j)).Item("Date/Time Applied"), Access.DBDT.Rows(str(j)).Item("Start_Date"), Access.DBDT.Rows(str(j)).Item("End_Date")})
        'Next

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

        Dim D1 As Date = Start_Date
        Dim D2 As Date = End_Date
        Dim difference As TimeSpan = D2.Subtract(D1)
        Dim number_of_days As Integer = difference.TotalDays
        'MessageBox.Show(number_of_days)

        Dim remark As String = Remark_Box.Text
        Dim type As String = Type_Of_Leave.Text
        Dim status As String = "Pending"
        Dim username As String = Label1.Text
        Dim d As Date = System.DateTime.Now()
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

        If Access.RecordCount > 0 Then
            Dim ta As String = Access.DBDT.Rows(0).Item("TA_Superviser")
            Dim guide As String = Access.DBDT.Rows(0).Item("Guide")
            'Dim ord As String = Access.DBDT.Rows(0).Item("Ordinary")
            'Dim med As String = Access.DBDT.Rows(0).Item("Medical")
            'Dim acad As String = Access.DBDT.Rows(0).Item("Academic")

            If ta <> "" Then
                list_of_participating_users = list_of_participating_users + ta + ","
            End If

            If guide <> "" Then
                list_of_participating_users = list_of_participating_users + guide + ","
            End If
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
            Access.ExecQuery("INSERT INTO Leave_DB([Username], [Date/Time Applied], [Current_Status], [Type_of_Leave], [Start_Date], [End_Date], [Leave_ID], [List_of_Participating_Users], [Leave_Log], [Remarks])VALUES(@user2, @date2, @current, @type2, @start_d, @end_d, @leave_id, @lopu, @leave_log, @remarks)")

            Access.AddParam("@leave_id2", l_id)
            Access.AddParam("@leave_id3", l_id)
            Access.AddParam("@date3", d)
            Access.AddParam("@user3", username)
            Dim dum As String = ""
            Dim dum2 As String = "Pending"
            Access.AddParam("@dum", dum)
            Access.AddParam("@dum2", dum2)
            Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status])VALUES(@leave_id2, @leave_id3, @date3, @user3, @dum, @dum2)")

        Else

            Access.AddParam("@user2", username)
            Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username = @user2")
            If Access.RecordCount > 0 Then

                list_of_participating_users = list_of_participating_users + hod + ","
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                End If

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
                Access.ExecQuery("INSERT INTO Leave_DB([Username], [Date/Time Applied], [Current_Status], [Type_of_Leave], [Start_Date], [End_Date], [Leave_ID], [List_of_Participating_Users], [Leave_Log], [Remarks])VALUES(@user2, @date2, @current, @type2, @start_d, @end_d, @leave_id, @lopu, @leave_log, @remarks)")

                Access.AddParam("@leave_id2", l_id)
                Access.AddParam("@leave_id3", l_id)
                Access.AddParam("@date3", d)
                Access.AddParam("@user3", username)
                Dim dum As String = ""
                Dim dum2 As String = "Pending"
                Access.AddParam("@dum", dum)
                Access.AddParam("@dum2", dum2)
                Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status])VALUES(@leave_id2, @leave_id3, @date3, @user3, @dum, @dum2)")

            End If

        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click

        Form2.USERNAME.Text = Label1.Text
        Form2.USERNAME.Enabled = False
        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & Label1.Text & "'")

        If Access.RecordCount > 0 Then

            Form2.FIRST_NAME.Text = Access.DBDT.Rows(0).Item("First_Name")
            Form2.LAST_NAME.Text = Access.DBDT.Rows(0).Item("Last_Name")
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
                Form2.Faculty_Checkbox.Enabled = False
                Form2.HOD_CheckBox.Enabled = False

            End If

        End If

        Me.Close()
        Form2.Show()
    End Sub
End Class