Public Class Form5
    Private Access As New DBControl

    Private Sub Form5_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim LeaveID As String = txtLeaveID.Text()

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


End Class