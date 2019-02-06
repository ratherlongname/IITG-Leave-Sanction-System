Public Class Form3
    Dim Start_Date As String
    Dim End_Date As String
    Private Access As New DBControl
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Date_Calc_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Date_Calc.DateChanged
        Start_Date = e.Start.ToShortDateString()
        End_Date = e.End.ToShortDateString()
        E_Date.Enabled = False
        S_Date.Enabled = False
        S_Date.Text = Start_Date
        E_Date.Text = End_Date
    End Sub

    Private Sub Submit_new_Click(sender As Object, e As EventArgs) Handles Submit_new.Click
        Dim remark As String = Remark_Box.Text
        Dim type As String = Type_Of_Leave.Text
        Dim status As String = "Pending"
        Dim username As String = Label1.Text



    End Sub
End Class