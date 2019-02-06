Public Class Form3
    Private Access As New DBControl

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
End Class