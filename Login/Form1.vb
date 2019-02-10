Public Class Form1
    Private Access As New DBControl

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Vaibles storing the values the text from user
        Dim user_name As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If (user_name = "" Or password = "") Then
            MessageBox.Show("Please Enter the data", "NO DATA ENTERED")
        Else
            Access.AddParam("@user", user_name)
            Access.AddParam("@pwd", password)

            Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user and Password=@pwd")

            If Access.RecordCount > 0 Then
                Me.Hide()
                Form3.Show()
                Form3.Label1.Text = Access.DBDT.Rows(0).Item("Username")
                Form3.Label2.Text = Access.DBDT.Rows(0).Item("Department")
                Form3.Label3.Text = Access.DBDT.Rows(0).Item("Programme")
                Form3.Label4.Text = Access.DBDT.Rows(0).Item("Year_of_joining")
            Else
                Access.AddParam("@user", user_name)
                Access.AddParam("@pwd", password)

                Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username=@user and Password=@pwd")

                If Access.RecordCount > 0 Then
                    Me.Hide()
                    Form3.Show()
                    Form3.Label1.Text = Access.DBDT.Rows(0).Item("Username")
                    Form3.Label2.Text = Access.DBDT.Rows(0).Item("Department")
                    Form3.Label3.Text = Access.DBDT.Rows(0).Item("Designation")
                    Form3.Label4.Text = ""

                Else
                    MsgBox("Invalid Username/ Password")
                End If
            End If
        End If
    End Sub
End Class
