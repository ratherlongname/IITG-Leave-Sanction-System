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
        For c As Integer = d1.Length() - 1 To 0 Step -1

            If (IsNumeric(d1(c))) Then
                l_id = l_id + d1(c)
            Else
                c = c - 1
            End If

        Next c






    End Sub
End Class