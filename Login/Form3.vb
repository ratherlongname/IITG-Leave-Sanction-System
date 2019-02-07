Public Class Form3
    Private Access As New DBControl
    Dim Start_Date As String
    Dim End_Date As String

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
        Access.AddParam("@user", Label1.Text)
        Access.ExecQuery("SELECT Date/Time Applied, Leave_ID, Type_of_leave, Start_Date, End_Date, Current_Status FROM Leave_DB WHERE Username=@user")


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
        Dim d1 As String = d

        Dim l_id As String = ""
        l_id = username(0) + username(1) + username(0) + username(1)
        Dim l As Integer = 0
        For c As Integer = d1.Length() - 1 To 0 Step -1

            If (IsNumeric(d1(c))) Then
                l_id = l_id + d1(c)
                l = l + 1
            Else
                c = c - 1
            End If

        Next c
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class