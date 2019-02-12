Public Class Form5
    Private Access As New DBControl

    Private Sub Form5_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim LeaveID As String = txtLeaveID.Text()
        Access.ExecQuery("SELECT * FROM Leave_DB WHERE Leave_ID='" & LeaveID & "'")
        txtDateTime.Text = Access.DBDT.Rows(0).Item("Date/Time Applied")
        txtStartDate.Text = Access.DBDT.Rows(0).Item("Start_Date")
        txtEndDate.Text = Access.DBDT.Rows(0).Item("End_Date")
        txtCurrentStatus.Text = Access.DBDT.Rows(0).Item("Current_Status")
        txtTypeofLeave.Text = Access.DBDT.Rows(0).Item("Type_of_Leave")
        txtLeaveID.Text = Access.DBDT.Rows(0).Item("Leave_ID")
        Access.AddParam("@LID", LeaveID)
        Access.ExecQuery("SELECT * FROM Leave_Update_DB WHERE Leave_ID=@LID ORDER BY [Date/Time] DESC")

        For Each r As DataRow In Access.DBDT.Rows
            Dim helper As String = r("Update_ID")
            Dim v As New ListViewItem(helper)
            v.SubItems.Add(r("Date/Time"))
            v.SubItems.Add(r("Username_Action"))
            v.SubItems.Add(r("Updated_Status"))
            v.SubItems.Add(r("Remark"))
            lsviewDetailLeaveView.Items.Add(v)
        Next

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        Form3.Show()
    End Sub
End Class