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
        If user_name = "admin" Then
            If password = "admin" Then
                Me.Hide()
                Form3.Show()
                Form3.Label1.Text = "ADMIN"
                Form3.Label2.Text = ""
                Form3.Label3.Text = ""
                Form3.Label4.Text = ""
                Form3.Panel2.Visible = False
                Form3.Panel4.Visible = False
                Form3.Panel5.Visible = False

                Exit Sub
            Else
                MessageBox.Show("Incorrect Password")
                Exit Sub
            End If
        End If

        If (user_name = "" Or password = "") Then
            MessageBox.Show("Please Enter the data", "NO DATA ENTERED")
            Exit Sub
        Else
            Access.AddParam("@user", user_name)
            Access.AddParam("@pwd", password)

            Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user and Password=@pwd")

            If Access.RecordCount > 0 Then
                If Access.DBDT.Rows(0).Item("Approved") = "PENDING" Then
                    MessageBox.Show("Your Registration Request has not been approved yet")
                    Exit Sub
                End If
                Me.Hide()
                Form3.Show()
                Form3.Label1.Text = Access.DBDT.Rows(0).Item("Username")
                Form3.Label2.Text = Access.DBDT.Rows(0).Item("First_name") + " " + Access.DBDT.Rows(0).Item("Last_name")
                Form3.Label3.Text = Access.DBDT.Rows(0).Item("Department")
                Form3.Label4.Text = Access.DBDT.Rows(0).Item("Programme")
            Else
                Access.AddParam("@user", user_name)
                Access.AddParam("@pwd", password)

                Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username=@user and Password=@pwd")

                If Access.RecordCount > 0 Then
                    If Access.DBDT.Rows(0).Item("Approved") = "PENDING" Then
                        MessageBox.Show("Your Registration Request has not been approved yet")
                        Exit Sub
                    End If
                    Me.Hide()
                    Form3.Show()
                    Form3.Label1.Text = Access.DBDT.Rows(0).Item("Username")
                    Form3.Label2.Text = Access.DBDT.Rows(0).Item("First_Name") + Access.DBDT.Rows(0).Item("Last_Name")
                    Form3.Label3.Text = Access.DBDT.Rows(0).Item("Department")
                    Form3.Label4.Text = Access.DBDT.Rows(0).Item("Designation")
                Else
                    MessageBox.Show("Invalid Username/ Password")
                    Exit Sub
                End If
            End If
        End If
    End Sub
End Class
