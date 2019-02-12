Public Class Form3
    Private Access As New DBControl
    Dim Start_Date As Date
    Dim End_Date As Date

    ' FORM3 IS RUN
    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If Label1.Text = "ADMIN" Then
            Me.VIEW_3.Visible = False
            Me.tabctrlMainTabs.TabPages.Remove(tabpgLeavesToApprove)
            Me.tabctrlMainTabs.TabPages.Remove(tabpgViewLeaves)
            Me.tabctrlMainTabs.TabPages.Remove(tabpgNotifications)
            Me.tabctrlMainTabs.TabPages.Remove(tabpgNewLeaves)
            Me.BALANCES.Visible = False
            admin_refresh()
        Else
            Me.tabctrlMainTabs.TabPages.Remove(TabPage1)
        End If
        If Label4.Text = "M.Tech/M.Sc" Or Label4.Text = "PhD" Then
            Me.tabctrlMainTabs.TabPages.Remove(tabpgLeavesToApprove)
        End If

        ' INITIALIZE VIEW LEAVES TAB
        SORT_DROPBOX.SelectedIndex = 0
        ORDINARY.Checked = True
        MEDICAL.Checked = True
        ACADEMIC.Checked = True
        ACCEPTED.Checked = True
        REJECTED.Checked = True
        PENDING.Checked = True
        CANCELLED.Checked = True
        ORDINARY_2.Checked = True
        MEDICAL_2.Checked = True
        ACADEMIC_2.Checked = True
        DROPBOX_2.SelectedIndex = 0
        NEWEST_2.Checked = True
        NEWEST_CHECKBOX.Checked = True

        RefreshViewLeaves()

    End Sub





    ' BUTTONS OUTSIDE TABS
    ' Logout Button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.txtPassword.Text = Nothing
        Form1.Show()
    End Sub

    ' Profile Edit Button


    ' View Profile Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VIEW_3.Click
        'take that from selected list view rows
        Dim dum As String = Label1.Text()
        Access.ExecQuery("SELECT * FROM Student_DB WHERE Username='" & dum & "'")
        If Access.RecordCount > 0 Then
            'Getting all the old Deatails and filling into the EDIT FORM
            Form4.FULLNAME_TB.Text = Access.DBDT.Rows(0).Item("Username")
            Form4.USERNAME_TB.Text = Access.DBDT.Rows(0).Item("First_name")
            Form4.LAST_NAME_TB.Text = Access.DBDT.Rows(0).Item("Last_name")
            Form4.OPT_TB.Text = Access.DBDT.Rows(0).Item("Roll_no")
            Form4.YEAR_OF_JOINING_TB.Text = Access.DBDT.Rows(0).Item("Year_of_joining")
            Form4.PROGRAMME_TB.Text = Access.DBDT.Rows(0).Item("Programme")
            Form4.TA_SUPERVISER_TB.Text = Access.DBDT.Rows(0).Item("TA_Superviser")
            Form4.GUIDE_TB.Text = Access.DBDT.Rows(0).Item("Guide")
            Form4.DEPARTMENT_TB.Text = Access.DBDT.Rows(0).Item("Department")
            Form4.Label13.Text = "Roll No."
        End If

        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & dum & "'")
        If Access.RecordCount > 0 Then
            'Getting all the old Deatails and filling into the EDIT FORM
            Form4.FULLNAME_TB.Text = Access.DBDT.Rows(0).Item("Username")
            Form4.USERNAME_TB.Text = Access.DBDT.Rows(0).Item("First_Name")
            Form4.LAST_NAME_TB.Text = Access.DBDT.Rows(0).Item("Last_Name")
            Form4.DEPARTMENT_TB.Text = Access.DBDT.Rows(0).Item("Department")
            Form4.OPT_TB.Text = Access.DBDT.Rows(0).Item("Designation")
            Form4.Label13.Text = "Designation"
            Form4.Label9.Visible = False
            Form4.YEAR_OF_JOINING_TB.Visible = False
            Form4.PROGRAMME_TB.Visible = False
            Form4.Label8.Visible = False
            Form4.Label10.Visible = False
            Form4.TA_SUPERVISER_TB.Visible = False
            Form4.Label11.Visible = False
            Form4.GUIDE_TB.Visible = False
            Form4.Label18.Visible = False
            Form4.Label21.Visible = False
            Form4.Label23.Visible = False
            Form4.Label19.Visible = False
        End If
        Me.Hide()
        Form4.Show()
    End Sub







    ' ADMIN PAGE
    ' View Button
    Private Sub VIEW_Click(sender As Object, e As EventArgs) Handles View.Click
        'take that from selected list view rows
        Dim dum As New ListViewItem
        dum = ADMIN_SelectedItem()
        If dum.SubItems(0).Text() = "" Then
            MsgBox("No entry selected!")
            Exit Sub
        End If

        Access.ExecQuery("SELECT * FROM Student_DB WHERE Username='" & dum.SubItems(0).Text() & "'")
        If Access.RecordCount > 0 Then
            'Getting all the old Deatails and filling into the EDIT FORM
            Form4.FULLNAME_TB.Text = Access.DBDT.Rows(0).Item("First_name") + " " + Access.DBDT.Rows(0).Item("Last_name")
            Form4.USERNAME_TB.Text = Access.DBDT.Rows(0).Item("Username")
            Form4.FIRST_NAME_TB.Text = Access.DBDT.Rows(0).Item("First_name")
            Form4.LAST_NAME_TB.Text = Access.DBDT.Rows(0).Item("Last_name")
            Form4.OPT_TB.Text = Access.DBDT.Rows(0).Item("Roll_no")
            Form4.YEAR_OF_JOINING_TB.Text = Access.DBDT.Rows(0).Item("Year_of_joining")
            Form4.PROGRAMME_TB.Text = Access.DBDT.Rows(0).Item("Programme")
            Form4.TA_SUPERVISER_TB.Text = Access.DBDT.Rows(0).Item("TA_Superviser")
            Form4.GUIDE_TB.Text = Access.DBDT.Rows(0).Item("Guide")
            Form4.DEPARTMENT_TB.Text = Access.DBDT.Rows(0).Item("Department")
            Form4.Label13.Text = "Roll No."
            Form4.Label7.Text = Access.DBDT.Rows(0).Item("Programme")
            Form4.Label12.Text = Access.DBDT.Rows(0).Item("Department")

        End If

        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & dum.SubItems(0).Text() & "'")
        If Access.RecordCount > 0 Then
            'Getting all the old Deatails and filling into the EDIT FORM
            Form4.FULLNAME_TB.Text = Access.DBDT.Rows(0).Item("First_Name") + " " + Access.DBDT.Rows(0).Item("Last_Name")
            Form4.USERNAME_TB.Text = Access.DBDT.Rows(0).Item("Username")
            Form4.FIRST_NAME_TB.Text = Access.DBDT.Rows(0).Item("First_Name")
            Form4.LAST_NAME_TB.Text = Access.DBDT.Rows(0).Item("Last_Name")
            Form4.DEPARTMENT_TB.Text = Access.DBDT.Rows(0).Item("Department")
            Form4.OPT_TB.Text = Access.DBDT.Rows(0).Item("Designation")
            Form4.Label13.Text = "Designation"
            Form4.Label9.Visible = False
            Form4.YEAR_OF_JOINING_TB.Visible = False
            Form4.PROGRAMME_TB.Visible = False
            Form4.Label8.Visible = False
            Form4.Label10.Visible = False
            Form4.TA_SUPERVISER_TB.Visible = False
            Form4.Label11.Visible = False
            Form4.GUIDE_TB.Visible = False
            Form4.Label18.Visible = False
            Form4.Label21.Visible = False
            Form4.Label23.Visible = False
            Form4.Label19.Visible = False
            Form4.Label7.Text = Access.DBDT.Rows(0).Item("Designation")
            Form4.Label12.Text = Access.DBDT.Rows(0).Item("Department")



        End If
        Me.Hide()
        Form4.Show()
    End Sub

    ' Approve Button
    Private Sub APPROVE_Click(sender As Object, e As EventArgs) Handles APPROVE.Click
        Dim dum As New ListViewItem
        dum = ADMIN_SelectedItem()
        If dum.SubItems(0).Text() = "" Then
            MsgBox("No entry selected!")
            Exit Sub
        End If

        Dim username As String = dum.SubItems(0).Text()
        Dim help As String = "YES"
        Dim dum2 As New ListViewItem
        dum2 = ADMIN_SelectedItem()
        If dum2.SubItems(4).Text() = "" Then
            MsgBox("No entry selected!")
            Exit Sub
        End If
        Dim type As String = dum.SubItems(4).Text()
        If type = "FACULTY" Then
            Access.ExecQuery("UPDATE Faculty_DB SET Approved='" & help & "' WHERE Username ='" & username & "'")
        Else
            Access.ExecQuery("UPDATE Student_DB SET Approved='" & help & "' WHERE Username ='" & username & "'")
        End If
        Access.ExecQuery("UPDATE Faculty_DB SET Approved='" & help & "' WHERE Username ='" & username & "'")
        admin_refresh()
    End Sub

    ' Disapprove Button
    Private Sub DISAPPROVE_Click(sender As Object, e As EventArgs) Handles DISAPPROVE.Click
        Dim dum As New ListViewItem
        dum = ADMIN_SelectedItem()
        If dum.SubItems(0).Text() = "" Then
            MsgBox("No entry selected!")
            Exit Sub
        End If

        Dim username As String = dum.SubItems(0).Text()
        Dim help As String = "NO"

        Dim type As String = dum.SubItems(4).Text()
        If type = "FACULTY" Then
            Access.AddParam("@user", username)
            Access.ExecQuery("DELETE FROM Faculty_DB WHERE Username=@user")
        Else
            Access.AddParam("@user", username)
            Access.ExecQuery("DELETE FROM Student_DB WHERE Username=@user")
        End If
        admin_refresh()
    End Sub

    ' Finds and returns selected row from listview
    Private Function ADMIN_SelectedItem() As ListViewItem
        Dim selectedEntry As New ListViewItem
        If ADMIN.SelectedItems.Count > 0 Then
            selectedEntry = ADMIN.SelectedItems(0)
        End If

        Return selectedEntry
    End Function

    ' Populates ADMIN page
    Private Sub admin_refresh()
        ADMIN.Items.Clear()
        Dim help As String = "PENDING"
        Access.ExecQuery("SELECT * FROM Student_DB WHERE Approved='" & help & "'")
        If Access.RecordCount > 0 Then
            For Each r As DataRow In Access.DBDT.Rows
                Dim dum As String = r(0)
                Dim dum2 As String = "STUDENT"
                Dim v As New ListViewItem(dum)
                v.SubItems.Add(r(5))
                v.SubItems.Add(r(6))
                v.SubItems.Add(r(4))
                v.SubItems.Add(dum2)
                ADMIN.Items.Add(v)
            Next
        End If

        Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Approved='" & help & "'")
        If Access.RecordCount > 0 Then
            For Each r As DataRow In Access.DBDT.Rows
                Dim dum As String = r(0)
                Dim dum2 As String = "FACULTY"
                Dim v As New ListViewItem(dum)
                v.SubItems.Add(r(2))
                v.SubItems.Add(r(3))
                v.SubItems.Add(r(4))
                v.SubItems.Add(dum2)
                ADMIN.Items.Add(v)
            Next
        End If
    End Sub

    ' VIEW LEAVES
    ' Refresh view leaves upon entering
    Private Sub tabpgViewLeaves_Enter(sender As Object, e As EventArgs) Handles tabpgViewLeaves.Enter
        RefreshViewLeaves()
    End Sub

    ' Refresh view leaves upon sorting or anything
    Private Sub MEDICAL_Click(sender As Object, e As EventArgs) Handles MEDICAL.Click
        RefreshViewLeaves()
    End Sub
    Private Sub ACADEMIC_Click(sender As Object, e As EventArgs) Handles ACADEMIC.Click
        RefreshViewLeaves()
    End Sub
    Private Sub ORDINARY_Click(sender As Object, e As EventArgs) Handles ORDINARY.Click
        RefreshViewLeaves()
    End Sub
    Private Sub PENDING_Click(sender As Object, e As EventArgs) Handles PENDING.Click
        RefreshViewLeaves()
    End Sub
    Private Sub ACCEPTED_Click(sender As Object, e As EventArgs) Handles ACCEPTED.Click
        RefreshViewLeaves()
    End Sub
    Private Sub REJECTED_Click(sender As Object, e As EventArgs) Handles REJECTED.Click
        RefreshViewLeaves()
    End Sub
    Private Sub CANCELLED_Click(sender As Object, e As EventArgs) Handles CANCELLED.Click
        RefreshViewLeaves()
    End Sub
    Private Sub SORT_DROPBOX_Click(sender As Object, e As EventArgs) Handles SORT_DROPBOX.Click
        RefreshViewLeaves()
    End Sub
    Private Sub NEWEST_CHECKBOX_Click(sender As Object, e As EventArgs) Handles NEWEST_CHECKBOX.Click
        RefreshViewLeaves()
    End Sub
    Private Sub OLD_CHECKBOX_Click(sender As Object, e As EventArgs) Handles OLD_CHECKBOX.Click
        RefreshViewLeaves()
    End Sub

    ' Sub to refresh view leaves
    Private Sub RefreshViewLeaves()
        ' CLEAR EXISTING DATA IN LISTVIEW
        lsviewViewLeavesListOfLeaves.Items.Clear()

        ' REPOPULATE LISTVIEW

        If NEWEST_CHECKBOX.Checked = True Then
            If SORT_DROPBOX.Text = "Date / Time Applied" Then
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "') ORDER BY [Date/Time Applied] DESC")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            ElseIf SORT_DROPBOX.Text = "Start Date" Then
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "') ORDER BY [Start_Date] DESC")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            ElseIf SORT_DROPBOX.Text = "End Date" Then
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "') ORDER BY [End_Date] DESC")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            Else
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "')")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            End If

        Else
            If SORT_DROPBOX.Text = "Date / Time Applied" Then
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "') ORDER BY [Date/Time Applied]")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            ElseIf SORT_DROPBOX.Text = "Start Date" Then
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "') ORDER BY [Start_Date]")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            ElseIf SORT_DROPBOX.Text = "End Date" Then
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "') ORDER BY [End_Date]")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            Else
                'FOR STATUS
                Dim dum1 As String = ""
                Dim dum2 As String = ""
                Dim dum3 As String = ""
                Dim dum4 As String = ""
                If ACCEPTED.Checked = True Then
                    dum1 = "Accepted"
                End If
                If REJECTED.Checked = True Then
                    dum2 = "Rejected"
                End If
                If PENDING.Checked = True Then
                    dum3 = "Pending"
                End If
                If CANCELLED.Checked = True Then
                    dum4 = "Cancelled"
                End If
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC.Checked = True Then
                    dummy3 = "Academic"
                End If
                Access.ExecQuery("SELECT * FROM Leave_DB WHERE Username='" & Label1.Text & "' and Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Current_Status IN ('" & dum1 & "','" & dum2 & "','" & dum3 & "','" & dum4 & "')")
                If Access.RecordCount > 0 Then
                    For Each r As DataRow In Access.DBDT.Rows
                        Dim dum As String = r(1)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(6))
                        v.SubItems.Add(r(3))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(2))
                        lsviewViewLeavesListOfLeaves.Items.Add(v)
                    Next
                End If
            End If

        End If
    End Sub

    Private Sub btnViewLeavesView_Click(sender As Object, e As EventArgs) Handles btnViewLeavesView.Click
        Dim selectedLeave As New ListViewItem
        selectedLeave = viewleaves_SelectedItem()
        If selectedLeave.SubItems(0).Text() = "" Then
            MessageBox.Show("No Entry Selected!!!!!")
            Exit Sub
        End If
        Form5.txtDateTime.Text() = selectedLeave.SubItems(0).Text()
        Form5.txtLeaveID.Text() = selectedLeave.SubItems(1).Text()
        Form5.txtTypeofLeave.Text() = selectedLeave.SubItems(2).Text()
        Form5.txtStartDate.Text() = selectedLeave.SubItems(3).Text()
        Form5.txtEndDate.Text() = selectedLeave.SubItems(4).Text()
        Form5.txtCurrentStatus.Text() = selectedLeave.SubItems(5).Text()
        Form5.Show()
    End Sub

    Private Function viewleaves_SelectedItem() As ListViewItem
        Dim selectedLeave As New ListViewItem
        If lsviewViewLeavesListOfLeaves.SelectedItems.Count > 0 Then
            selectedLeave = lsviewViewLeavesListOfLeaves.SelectedItems(0)
        End If
        Return selectedLeave
    End Function

    Private Sub btnViewLeavesCancel_Click(sender As Object, e As EventArgs) Handles btnViewLeavesCancel.Click
        Dim selectedLeave As New ListViewItem
        selectedLeave = viewleaves_SelectedItem()
        If selectedLeave.SubItems(1).Text() = "" Then
            MsgBox("No leave selected!")
            Exit Sub
        End If

        If selectedLeave.SubItems(5).Text() <> "Pending" Then
            MsgBox("Leave cannot be cancelled")
            Exit Sub
        End If

        Dim leave_ID As String = selectedLeave.SubItems(1).Text()
        Dim update_ID As String = ""

        Dim date_Time As Date = System.DateTime.Now()
        Dim user As String = Label1.Text()
        Dim remark As String = richtxtboxViewLeaves.Text()

        Dim status As String = "Cancelled"

        Dim user_action As String = user

        'Generating Update_ID
        update_ID = user(0) + user(1) + user_action(0) + user_action(1)
        Dim d As String = date_Time.ToString()
        For Each c As Char In d
            If c <> " " And c <> "-" And c <> ":" Then
                update_ID = update_ID + c
            End If
        Next

        'Adding parameters for the Insert query in Update DB
        Access.AddParam("@LID", leave_ID)
        Access.AddParam("@UID", update_ID)
        Access.AddParam("@date", date_Time)
        Access.AddParam("@user", user)
        Access.AddParam("@remark", remark)
        Access.AddParam("@status", status)
        Access.AddParam("@user_act", user_action)
        Dim type2 As Integer = 3
        Access.AddParam("@type2", type2)
        'Insert Command for the Update_DB
        Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status], [Username_Action], [Type])VALUES(@LID, @UID, @date, @user, @remark, @status, @user_act, @type2)")
        ' Add notification for all participating users
        Access.ExecQuery("SELECT List_of_Participating_Users FROM Leave_DB WHERE Leave_ID='" & leave_ID & "'")
        If Access.RecordCount > 0 Then
            If IsDBNull(Access.DBDT.Rows(0).Item(0)) Then
            Else
                Dim help2 As String = Access.DBDT.Rows(0).Item(0)
                Dim words As String() = help2.Split(New Char() {","c})

                ' Use For Each loop over words and display them

                Dim word As String
                For Each word In words
                    Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & word & "'")
                    If Access.RecordCount > 0 Then
                        Dim noti As String = Nothing
                        If (IsDBNull(Access.DBDT.Rows(0).Item(7))) Then
                            noti = update_ID + ","
                        Else
                            noti = Access.DBDT.Rows(0).Item(7)
                            noti = noti + update_ID + ","
                        End If
                        Access.ExecQuery("UPDATE Faculty_DB SET Notifications='" & noti & "' WHERE Username='" & word & "'")
                    End If
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username='" & word & "'")
                    If Access.RecordCount > 0 Then
                        Dim s As String = Access.DBDT.Rows(0).Item(0)
                        Dim words_2 As String() = s.Split(New Char() {","c})
                        Dim append As String = Nothing
                        Dim word_2 As String = Nothing
                        For Each word_2 In words_2
                            If word_2 = leave_ID Then
                            Else
                                append = append + word_2 + ","
                            End If
                        Next
                        Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & append & "' WHERE Username='" & user & "'")
                    End If
                Next
            End If
        End If


        ' UPDATE CURRENT STATUS TO CANCELLED

        Access.AddParam("@LID", leave_ID)
        Access.AddParam("@status", status)
        Access.ExecQuery("UPDATE Leave_DB SET Current_Status='" & status & "' WHERE Leave_ID='" & leave_ID & "'")
        MsgBox("Leave status updated.")
        richtxtboxViewLeaves.Clear()
        RefreshViewLeaves()

    End Sub



    ' NEW LEAVE
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
        Dim list_of_Update As String = l_id
        Dim list_of_participating_users As String = ""

        Dim hod As String
        Access.AddParam("@desgn", "HOD")
        Access.AddParam("@dept", Label3.Text())
        Access.ExecQuery("SELECT Username FROM Faculty_DB WHERE Designation=@desgn and Department=@dept")
        If Access.RecordCount > 0 Then
            hod = Access.DBDT.Rows(0).Item("Username")
        Else
            MsgBox("HOD from your department isn't registered yet.")
        End If

        Dim adoaa As String
        Access.AddParam("@desgn", "ADOAA")
        Access.ExecQuery("SELECT Username FROM Faculty_DB WHERE Designation=@desgn")
        If Access.RecordCount > 0 Then
            adoaa = Access.DBDT.Rows(0).Item("Username")
        Else
            MsgBox("ADOAA isn't registered yet.")
        End If


        Access.AddParam("@user", username)
        Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user")


        'If the Student is logged in
        If Access.RecordCount > 0 Then
            Dim ta As String = Access.DBDT.Rows(0).Item("TA_Superviser")
            Dim guide As String = Access.DBDT.Rows(0).Item("Guide")
            Dim BALANCE_LEFT As Integer = Access.DBDT.Rows(0).Item(type)

            If number_of_days > BALANCE_LEFT Then
                Dim helper As Integer = number_of_days - BALANCE_LEFT
                MessageBox.Show("Stipend will be cut for " & helper & " days.")

                Access.AddParam("@user", username)
                Access.AddParam("@zero", 0)
                Dim query As String = "UPDATE Student_DB SET " + type + "=@zero WHERE Username=@user"
                Access.ExecQuery(query)

                Access.AddParam("@user", username)
                Access.ExecQuery("SELECT Days_of_stipend_cut FROM Student_DB WHERE Username=@user")
                Dim stipend As Integer = Access.DBDT.Rows(0).Item(0)
                stipend = stipend + helper

                Access.AddParam("@user", username)
                Access.AddParam("@stip", stipend)
                Access.ExecQuery("UPDATE Student_DB SET Days_of_stipend_cut=@stip WHERE Username=@user")

            Else
                Dim helper As Integer = BALANCE_LEFT - number_of_days

                Access.AddParam("@user", username)
                Access.AddParam("@val", helper)
                Dim query As String = "UPDATE Student_DB SET " + type + "=@val WHERE Username=@user"
                Access.ExecQuery(query)

            End If


            If ta <> "" Then
                list_of_participating_users = list_of_participating_users + ta + ","
                Access.AddParam("@ta", ta)
                Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@ta")
                Dim listofincoming As String = Nothing
                If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                    listofincoming = l_id + ","
                Else
                    listofincoming = Access.DBDT.Rows(0).Item(0)
                    listofincoming = listofincoming + l_id + ","
                End If
                Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & listofincoming & "' WHERE Username='" & ta & "'")
            End If

            If guide <> "" Then
                list_of_participating_users = list_of_participating_users + guide + ","
                Access.AddParam("@guide", guide)
                Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@guide")
                Dim listofincoming As String = Nothing
                If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                    listofincoming = l_id + ","
                Else
                    listofincoming = Access.DBDT.Rows(0).Item(0)
                    listofincoming = listofincoming + l_id + ","
                End If
                Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & listofincoming & "' WHERE Username='" & guide & "'")
            End If

            'Deciding the UPSTREAM of leave by checking leave duration and type of leave
            If Type_Of_Leave.Text = "Ordinary" Then
                If number_of_days > 15 Then
                    list_of_participating_users = list_of_participating_users + hod + ","
                    Dim help_3 As String = hod
                    Access.AddParam("@help_3", help_3)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_4 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_4 = l_id + ","
                    Else
                        help_4 = Access.DBDT.Rows(0).Item(0)
                        help_4 = help_4 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")
                End If
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                    Dim help_3 As String = adoaa
                    Access.AddParam("@help_3", help_3)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_4 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_4 = l_id + ","
                    Else
                        help_4 = Access.DBDT.Rows(0).Item(0)
                        help_4 = help_4 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")
                End If
            End If

            If Type_Of_Leave.Text = "Medical" Then
                If number_of_days > 15 Then
                    list_of_participating_users = list_of_participating_users + hod + ","
                    Dim help_3 As String = hod
                    Access.AddParam("@help_3", help_3)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_4 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_4 = l_id + ","
                    Else
                        help_4 = Access.DBDT.Rows(0).Item(0)
                        help_4 = help_4 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")
                End If
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                    Dim help_3 As String = adoaa
                    Access.AddParam("@help_3", help_3)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_4 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_4 = l_id + ","
                    Else
                        help_4 = Access.DBDT.Rows(0).Item(0)
                        help_4 = help_4 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")
                End If
            End If
            If Type_Of_Leave.Text = "Academic" Then
                If number_of_days > 15 Then
                    list_of_participating_users = list_of_participating_users + hod + ","
                    Dim help_3 As String = hod
                    Access.AddParam("@help_3", help_3)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_4 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_4 = l_id + ","
                    Else
                        help_4 = Access.DBDT.Rows(0).Item(0)
                        help_4 = help_4 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")
                End If
                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                    Dim help_3 As String = adoaa
                    Access.AddParam("@help_3", help_3)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_4 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_4 = l_id + ","
                    Else
                        help_4 = Access.DBDT.Rows(0).Item(0)
                        help_4 = help_4 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")
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
            Access.AddParam("@dum", remark)
            Access.AddParam("@dum2", dum2)
            Access.AddParam("@user4", username)
            Dim type_2 As Integer = 1
            Access.AddParam("@type2", type_2)
            Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status], [Username_Action], [Type])VALUES(@leave_id2, @leave_id3, @date3, @user3, @dum, @dum2, @user4, @type2)")

            ' Send notification to all participating users
            Dim participant As String = ""
            For Each c In list_of_participating_users
                If c <> "," Then
                    participant = participant + c
                Else
                    Access.AddParam("@user", participant)
                    Access.ExecQuery("SELECT Notifications FROM Faculty_DB WHERE Username=@user")

                    Dim notif As String

                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        notif = l_id + ","
                    Else
                        notif = Access.DBDT.Rows(0).Item(0)
                        notif = notif + l_id + ","
                    End If

                    Access.AddParam("@notif", notif)
                    Access.AddParam("@user", participant)
                    Access.ExecQuery("UPDATE Faculty_DB SET Notifications=@notif WHERE Username=@user")
                    participant = ""
                End If
            Next

        Else
            'For the case when Faculty is Logged in
            Access.AddParam("@user2", username)
            Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username = @user2")
            If Access.RecordCount > 0 Then
                'Adding HOD and ADOAA in list of participating Users
                list_of_participating_users = list_of_participating_users + hod + ","

                Dim help_3 As String = hod
                Access.AddParam("@help_3", help_3)
                Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                Dim help_4 As String = Nothing
                If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                    help_4 = l_id + ","
                Else
                    help_4 = Access.DBDT.Rows(0).Item(0)
                    help_4 = help_4 + l_id + ","
                End If
                Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_4 & "' WHERE Username='" & help_3 & "'")

                If number_of_days > 30 Then
                    list_of_participating_users = list_of_participating_users + adoaa + ","
                    Dim help_5 As String = adoaa
                    Access.AddParam("@help_3", help_5)
                    Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@help_3")
                    Dim help_6 As String = Nothing
                    If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                        help_6 = l_id + ","
                    Else
                        help_6 = Access.DBDT.Rows(0).Item(0)
                        help_6 = help_6 + l_id + ","
                    End If
                    Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & help_6 & "' WHERE Username='" & help_5 & "'")
                End If

                Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username='" & username & "'")
                Dim BALANCE_LEFT As Integer = Access.DBDT.Rows(0).Item(type)
                If type = "Ordinary" Then
                    If BALANCE_LEFT < number_of_days Then
                        MessageBox.Show("Can't apply for ordinary leave")
                        Exit Sub
                    Else
                        Dim help As Integer = BALANCE_LEFT - number_of_days
                        Access.ExecQuery("UPDATE Faculty_DB SET Ordinary=" & help & " WHERE Username ='" & username & "'")
                    End If
                ElseIf type = "Medical" Then
                    If BALANCE_LEFT < number_of_days Then
                        MessageBox.Show("Can't apply for medical leave")
                        Exit Sub
                    Else
                        Dim help As Integer = BALANCE_LEFT - number_of_days
                        Access.ExecQuery("UPDATE Faculty_DB SET Medical=" & help & " WHERE Username ='" & username & "'")
                    End If
                Else
                    If BALANCE_LEFT < number_of_days Then
                        MessageBox.Show("Can't apply for academic leave")
                        Exit Sub
                    Else
                        Dim help As Integer = BALANCE_LEFT - number_of_days
                        Access.ExecQuery("UPDATE Faculty_DB SET Academic=" & help & " WHERE Username ='" & username & "'")
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
                Access.AddParam("@dum", remark)
                Access.AddParam("@dum2", dum2)
                Access.AddParam("@user4", username)
                Dim type_3 As Integer = 1
                Access.AddParam("@type3", type_3)
                'Insert Command for the Update_DB
                Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status], [Username_Action], [Type])VALUES(@leave_id2, @leave_id3, @date3, @user3, @dum, @dum2, @user4, @type3)")

                ' Send notification to all participating users
                Dim participant As String = ""
                For Each c In list_of_participating_users
                    If c <> "," Then
                        participant = participant + c
                    Else
                        Access.AddParam("@user", participant)
                        Access.ExecQuery("SELECT Notifications FROM Faculty_DB WHERE Username=@user")
                        Dim notif As String = Nothing
                        If IsDBNull(Access.DBDT.Rows(0).Item(0)) Then
                            notif = l_id + ","
                        Else
                            notif = Access.DBDT.Rows(0).Item(0)
                            notif = notif + l_id + ","
                        End If
                        Access.AddParam("@notif", notif)
                        Access.AddParam("@user", participant)
                        Access.ExecQuery("UPDATE Faculty_DB SET Notifications=@notif WHERE Username=@user")
                        participant = ""
                    End If
                Next
            End If

        End If
        MessageBox.Show("LEAVE APLLIED SUCCESSFULLY")
    End Sub








    ' LEAVES TO BE APPROVED
    Private Sub tabpgLeavesToApprove_Enter(sender As Object, e As EventArgs) Handles tabpgLeavesToApprove.Enter
        RefreshLeavestoApprove()
    End Sub

    Private Sub RefreshLeavestoApprove()
        ' Clear existing listview
        APPROVED.Items.Clear()

        ' WRITTEN BY SHIVAM
        Access.AddParam("@user", Label1.Text())
        Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username=@user")
        Dim loil As String = ""
        If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
            MsgBox("No leaves to be approved!")
        Else
            loil = Access.DBDT.Rows(0).Item(0)
        End If
        Dim loilWithSingleQuotes As String = ""
        Dim helper As String = ""
        For Each c In loil
            If c <> "," Then
                helper = helper + c
            Else
                loilWithSingleQuotes = loilWithSingleQuotes + "'" + helper + "'" + ","
                helper = ""
            End If
        Next
        loilWithSingleQuotes = loilWithSingleQuotes.Substring(0, loilWithSingleQuotes.Length - 1)
        If NEWEST_2.Checked = True Then
            If DROPBOX_2.Text = "Date / Time Applied" Then
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If

                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ") ORDER BY [Date/Time Applied] DESC"
                Access.ExecQuery(query)
                ' WRITTEN BY SHIVAM TILL HERE



                ' Get username of faculty
                Dim user As String = Label1.Text
                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows
                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)
                    Next
                End If
            ElseIf DROPBOX_2.Text = "Start Date" Then

                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If
                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ") ORDER BY [Start_Date] DESC"
                Access.ExecQuery(query)
                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows
                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)
                    Next
                End If
            ElseIf DROPBOX_2.Text = "End Date" Then

                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If
                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ") ORDER BY [End_Date] DESC"
                Access.ExecQuery(query)

                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows


                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)

                    Next
                End If
            Else
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If

                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ")"
                Access.ExecQuery(query)

                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows



                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)


                    Next
                End If
            End If


        Else
            If DROPBOX_2.Text = "Date / Time Applied" Then
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If
                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ") ORDER BY [Date/Time Applied]"
                Access.ExecQuery(query)

                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows


                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)

                    Next
                End If
            ElseIf DROPBOX_2.Text = "Start Date" Then
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If
                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ") ORDER BY [Start_Date]"
                Access.ExecQuery(query)
                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows



                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)

                    Next
                End If
            ElseIf DROPBOX_2.Text = "End Date" Then
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If
                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ") ORDER BY [End_Date]"
                Access.ExecQuery(query)

                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows



                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)

                    Next
                End If
            Else
                'FOR TYPE
                Dim dummy1 As String = ""
                Dim dummy2 As String = ""
                Dim dummy3 As String = ""
                If ORDINARY_2.Checked = True Then
                    dummy1 = "Ordinary"
                End If
                If MEDICAL_2.Checked = True Then
                    dummy2 = "Medical"
                End If
                If ACADEMIC_2.Checked = True Then
                    dummy3 = "Academic"
                End If
                Dim query As String = "SELECT * FROM Leave_DB WHERE Type_of_Leave IN ('" & dummy1 & "','" & dummy2 & "','" & dummy3 & "') and Leave_ID IN (" + loilWithSingleQuotes + ")"
                Access.ExecQuery(query)

                ' Populate listview
                If Access.RecordCount > 0 Then
                    ' Cycle through all leaves
                    For Each r As DataRow In Access.DBDT.Rows
                        ' Add leave to listview
                        Dim dum As String = r(6)
                        Dim v As New ListViewItem(dum)
                        v.SubItems.Add(r(0))
                        v.SubItems.Add(r(1))
                        v.SubItems.Add(r(4))
                        v.SubItems.Add(r(5))
                        v.SubItems.Add(r(3))
                        APPROVED.Items.Add(v)
                    Next
                End If
            End If
        End If
    End Sub

    Private Function APPROVED_SelectedItem() As ListViewItem
        Dim selectedLeave As New ListViewItem
        If APPROVED.SelectedItems.Count > 0 Then
            selectedLeave = APPROVED.SelectedItems(0)
        End If

        Return selectedLeave
    End Function

    Private Sub btnLeavestobeApprovedView_Click(sender As Object, e As EventArgs) Handles btnLeavestobeApprovedView.Click
        Dim selectedLeave As New ListViewItem
        selectedLeave = APPROVED_SelectedItem()
        If selectedLeave.SubItems(0).Text() = "" Then
            MsgBox("No Leave selected!")
            Exit Sub
        End If

        'Access.AddParam("@LID", selectedLeave.SubItems(0).Text())
        'Access.ExecQuery("SELECT Current_Status FROM Leave_DB WHERE Leave_ID=@LID")

        Form5.txtLeaveID.Text = selectedLeave.SubItems(0).Text()
        Form5.Show()

    End Sub

    Private Sub btnLeavestobeApprovedAccept_Click(sender As Object, e As EventArgs) Handles btnLeavestobeApprovedAccept.Click
        AcceptReject(True)
    End Sub

    Private Sub btnLeavestobeApprovedReject_Click(sender As Object, e As EventArgs) Handles btnLeavestobeApprovedReject.Click
        AcceptReject(False)
    End Sub

    Private Sub AcceptReject(isAccepted As Boolean)
        Dim selectedLeave As New ListViewItem
        selectedLeave = APPROVED_SelectedItem()
        If selectedLeave.SubItems(0).Text() = "" Then
            MsgBox("No leave selected!")
            Exit Sub
        End If


        Dim leave_ID As String = selectedLeave.SubItems(0).Text()
        Dim update_ID As String = ""



        Dim date_Time As Date = System.DateTime.Now()
        Dim user As String = selectedLeave.SubItems(1).Text()
        Dim remark As String = richtxtboxLeavestobeApprovedRemarks.Text()

        Dim status As String = ""
        If isAccepted Then
            status = "Accepted"
        Else
            status = "Rejected"
        End If

        Dim user_action As String = Label1.Text()

        'Generating Update_ID
        update_ID = user(0) + user(1) + user_action(0) + user_action(1)
        Dim d As String = date_Time.ToString()
        For Each c As Char In d
            If c <> " " And c <> "-" And c <> ":" Then
                update_ID = update_ID + c
            End If
        Next

        'Adding parameters for the Insert query in Update DB
        Access.AddParam("@LID", leave_ID)
        Access.AddParam("@UID", update_ID)
        Access.AddParam("@date", date_Time)
        Access.AddParam("@user", user)
        Access.AddParam("@remark", remark)
        Access.AddParam("@status", status)
        Access.AddParam("@user_act", user_action)
        Dim type2 As Integer = 2
        Access.AddParam("@type2", type2)
        'Insert Command for the Update_DB
        Access.ExecQuery("INSERT INTO Leave_Update_DB([Leave_ID], [Update_ID], [Date/Time], [Username], [Remark], [Updated_Status], [Username_Action], [Type])VALUES(@LID, @UID, @date, @user, @remark, @status, @user_act, @type2)")
        MsgBox("Leave status updated.")
        richtxtboxLeavestobeApprovedRemarks.Clear()

        ' new stuff to be copied
        ' SEND NOTIFICATION TO ALL OWNER OF LEAVE

        ' Check if leave is of student
        Access.AddParam("@user", user)
        Access.ExecQuery("SELECT Notification FROM Student_DB WHERE Username=@user")
        If Access.RecordCount > 0 Then
            ' It is a student's leave
            Dim notif As String

            If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                notif = update_ID + ","
            Else
                notif = Access.DBDT.Rows(0).Item(0)
                notif = notif + update_ID + ","
            End If
            Access.ExecQuery("UPDATE Student_DB SET Notification='" & notif & "' WHERE Username='" & user & "'")
        Else
            Access.AddParam("@user", user)
            Access.ExecQuery("SELECT Notifications FROM Faculty_DB WHERE Username=@user")

            If Access.RecordCount > 0 Then
                ' It is a faculty's leave
                Dim notif As String

                If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                    notif = update_ID + ","
                Else
                    notif = Access.DBDT.Rows(0).Item(0)
                    notif = notif + update_ID + ","
                End If
                Access.ExecQuery("UPDATE Faculty_DB SET Notifications='" & notif & "' WHERE Username='" & user & "'")
            End If
        End If


        ' SEND NOTIFICATION TO ALL PARTICIPATING USERS
        Access.AddParam("@LID", leave_ID)
        Access.ExecQuery("SELECT List_of_Participating_Users FROM Leave_DB WHERE Leave_ID=@LID")
        Dim all_part_user As String = Access.DBDT.Rows(0).Item(0)
        Dim part_user As String = ""

        For Each c In all_part_user
            If c <> "," Then
                part_user = part_user + c
            Else
                Access.AddParam("@user", part_user)
                Access.ExecQuery("SELECT Notifications FROM Faculty_DB WHERE Username=@user")
                Dim notif As String

                If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
                    notif = update_ID + ","
                Else
                    notif = Access.DBDT.Rows(0).Item(0)
                    notif = notif + update_ID + ","
                End If
                MessageBox.Show(part_user)
                If part_user = Label1.Text Then
                Else
                    Access.ExecQuery("UPDATE Faculty_DB SET Notifications='" & notif & "' WHERE Username='" & part_user & "'")
                End If

                part_user = ""
            End If

        Next
        updateCurrentStatus(leave_ID)
        Access.ExecQuery("SELECT List_of_Incoming_Leaves FROM Faculty_DB WHERE Username='" & user & "'")
        If Access.RecordCount > 0 Then
            Dim s As String = Access.DBDT.Rows(0).Item(0)
            Dim words As String() = s.Split(New Char() {","c})
            Dim append As String = Nothing
            Dim word As String = Nothing
            For Each word In words
                If word = leave_ID Then
                Else
                    append = append + word + ","
                End If
            Next
            Access.ExecQuery("UPDATE Faculty_DB SET List_of_Incoming_Leaves='" & append & "' WHERE Username='" & user & "'")
        End If
        RefreshLeavestoApprove()
        ' till here

    End Sub

    Private Sub ACADEMIC_2_Click(sender As Object, e As EventArgs) Handles ACADEMIC_2.Click
        RefreshLeavestoApprove()
    End Sub

    Private Sub MEDICAL_2_Click(sender As Object, e As EventArgs) Handles MEDICAL_2.Click
        RefreshLeavestoApprove()
    End Sub

    Private Sub ORDINARY_2_Click(sender As Object, e As EventArgs) Handles ORDINARY_2.Click
        RefreshLeavestoApprove()
    End Sub

    Private Sub DROPBOX_2_Click(sender As Object, e As EventArgs) Handles DROPBOX_2.Click
        RefreshLeavestoApprove()
    End Sub

    Private Sub NEWEST_2_Click(sender As Object, e As EventArgs) Handles NEWEST_2.Click
        RefreshLeavestoApprove()
    End Sub

    Private Sub OLDEST_2_Click(sender As Object, e As EventArgs) Handles OLDEST_2.Click
        RefreshLeavestoApprove()
    End Sub

    Private Sub updateCurrentStatus(leave_ID As String)
        Dim new_current_status = ""
        Dim total_number_of_accepts As Integer = 0

        Access.AddParam("@LID", leave_ID)
        Access.ExecQuery("SELECT Username_Action, Updated_Status FROM Leave_Update_DB WHERE Leave_ID=@LID")
        If Access.RecordCount > 0 Then
            For Each r In Access.DBDT.Rows
                If r("Updated_Status") = "Rejected" Then
                    new_current_status = "Rejected"
                    Exit For
                ElseIf r("Updated_Status") = "Accepted" Then
                    total_number_of_accepts += 1
                End If
            Next

            ' Check if pending OR accepted
            If new_current_status <> "Rejected" Then
                Access.AddParam("@LID", leave_ID)
                Access.ExecQuery("SELECT List_of_Participating_Users FROM Leave_DB WHERE Leave_ID=@LID")
                Dim lopu As String = Access.DBDT.Rows(0).Item(0)
                ' count number of participating users
                Dim no_of_part_users As Integer = 0
                For Each c In lopu
                    If c = "," Then
                        no_of_part_users += 1
                    End If
                Next

                If no_of_part_users > total_number_of_accepts Then
                    new_current_status = "Pending"
                Else
                    new_current_status = "Accepted"
                End If
            End If

            ' update current status in db
            Access.AddParam("@LID", leave_ID)
            Access.AddParam("@status", new_current_status)
            Access.ExecQuery("UPDATE Leave_DB SET Current_Status=@status WHERE Leave_ID=@LID")
        Else
            MsgBox("Error in updating current status of leave. No updateIDs found corresponding to this leaveID.")
        End If

    End Sub

    ' NOTIFICATIONS
    Private Sub tabpgNotifications_Enter(sender As Object, e As EventArgs) Handles tabpgNotifications.Enter
        'RefreshViewLeaves()
        NOTIFICATIONS.Items.Clear()
        Dim user As String = Label1.Text
        Access.AddParam("@user", user)
        Access.ExecQuery("SELECT Notification FROM Student_DB WHERE Username=@user")
        If Not Access.RecordCount > 0 Then
            Access.AddParam("@user", user)
            Access.ExecQuery("SELECT Notifications FROM Faculty_DB WHERE Username=@user")
        End If

        If (IsDBNull(Access.DBDT.Rows(0).Item(0))) Then
            MsgBox("No notifications!")
        Else
            Dim notif As String = Access.DBDT.Rows(0).Item(0)
            Dim UID As String = ""

            For Each c In notif
                If c <> "," Then
                    UID = UID + c
                Else

                    MessageBox.Show(UID)
                    Access.AddParam("@UID", UID)
                    Access.ExecQuery("SELECT * FROM Leave_Update_DB WHERE Update_ID=@UID")

                    Dim helper As String = Access.DBDT.Rows(0).Item("Date/Time")
                    Dim v As New ListViewItem(helper)
                    Dim help2 As String = Access.DBDT.Rows(0).Item("Leave_ID")
                    v.SubItems.Add(Access.DBDT.Rows(0).Item("Leave_ID"))
                    v.SubItems.Add(Access.DBDT.Rows(0).Item("Remark"))
                    Dim description As String = Nothing
                    Dim type As Integer = Access.DBDT.Rows(0).Item(7)
                    Dim status As String = Access.DBDT.Rows(0).Item("Updated_Status")
                    Dim user_action As String = Access.DBDT.Rows(0).Item("Username_Action")
                    Access.ExecQuery("SELECT * FROM Leave_DB WHERE Leave_ID='" & help2 & "'")

                    Dim type_of_leave As String = Access.DBDT.Rows(0).Item("Type_of_Leave")

                    If type = 1 Then

                        description = "User " + Access.DBDT.Rows(0).Item("Username") + " has applied for " + type_of_leave + " leave with leave_id " + Access.DBDT.Rows(0).Item("Leave_ID")
                    End If
                    If type = 2 Then
                        'our username
                        Dim help6 As String = Label1.Text
                        If help6 = Access.DBDT.Rows(0).Item(3) Then
                            description = "Your leave with leave_ID " + Access.DBDT.Rows(0).Item("Leave_ID") + " has been " + status + " by " + user_action
                        Else
                            description = "Your colleague " + user_action + " has " + status + " the leave with leave_ID " + Access.DBDT.Rows(0).Item("Leave_ID")
                        End If
                    End If
                    If type = 3 Then
                        description = "User " + Access.DBDT.Rows(0).Item("Username") + " has cancelled for the leave application with leave_ID " + Access.DBDT.Rows(0).Item("Leave_ID")
                    End If
                    v.SubItems.Add(description)
                    NOTIFICATIONS.Items.Add(v)
                    UID = Nothing
                End If
            Next
        End If

    End Sub
    Private Function viewleaves_SelectedItem2() As ListViewItem
        Dim selectedLeave As New ListViewItem
        If NOTIFICATIONS.SelectedItems.Count > 0 Then
            selectedLeave = NOTIFICATIONS.SelectedItems(0)
        End If
        Return selectedLeave
    End Function

    Private Sub VIEW_2_Click(sender As Object, e As EventArgs) Handles VIEW_2.Click
        Dim selectedLeave As New ListViewItem
        selectedLeave = viewleaves_SelectedItem2()
        If selectedLeave.SubItems(0).Text() = "" Then
            MessageBox.Show("No Entry Selected!!!!!")
            Exit Sub
        End If
        Form5.txtLeaveID.Text = selectedLeave.SubItems(1).Text()

        Form5.Show()
    End Sub
End Class