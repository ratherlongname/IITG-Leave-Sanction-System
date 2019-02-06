Public Class Form2
    Private Access As New DBControl

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Student_Checkbox.Checked = False Then
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            YEAR.Visible = False
            ROLL_NO.Visible = False
            PROGRAMME.Visible = False
            DEPARTMENT.Visible = False
            TA_SUPERVISER.Visible = False
            GUIDE.Visible = False
        End If

        If Faculty_Checkbox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If

    End Sub

    Private Sub Student_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Student_Checkbox.CheckedChanged
        If Student_Checkbox.Checked = False Then
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            YEAR.Visible = False
            ROLL_NO.Visible = False
            PROGRAMME.Visible = False
            DEPARTMENT.Visible = False
            TA_SUPERVISER.Visible = False
            GUIDE.Visible = False
        End If
        If Student_Checkbox.Checked = True Then
            Faculty_Checkbox.Checked = False
            HOD_CheckBox.Checked = False
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            YEAR.Visible = True
            ROLL_NO.Visible = True
            PROGRAMME.Visible = True
            DEPARTMENT.Visible = True
            TA_SUPERVISER.Visible = True
            GUIDE.Visible = True
        End If
    End Sub

    Private Sub Faculty_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Faculty_Checkbox.CheckedChanged
        If Faculty_Checkbox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If
        If Faculty_Checkbox.Checked = True Then
            Student_Checkbox.Checked = False
            HOD_CheckBox.Checked = False
            Label11.Visible = True
            Label12.Visible = True
            DEPARTMENT_FAC.Visible = True
            DESIGNATION.Visible = True
        End If
    End Sub

    Private Sub SUBMIT_Click(sender As Object, e As EventArgs) Handles SUBMIT.Click
        
        Dim flag As Integer = 0
        Dim fname As String = FIRST_NAME.Text
        Dim lname As String = LAST_NAME.Text
        Dim roll As String = ROLL_NO.Text
        Dim y As String = YEAR.Text
        'Checking whether the entered roll number is valid or not 
        If (Not (IsNumeric(roll)) And roll <> "") Then
            MessageBox.Show("The roll number entered is invalid", roll)
            flag = 1
        End If
        y.Trim()
        'Checking whether the entered year is valid or not
        If (Not (IsNumeric(y)) And y <> "") Then
            MessageBox.Show("The year entered is invalid", y)
            flag = 1
        End If
        'After removing the leading and trailing spaces from name ,checking whether the name contains special characters or not
        If ((ContainsSpecialChars(fname.Trim()) Or ContainsSpecialChars(lname.Trim())) And fname <> "" And lname <> "") Then
            MessageBox.Show("The Name is not in a valid format,contains unacceptable characters", "INVALID DATA ENTERED")
            flag = 1
        End If

        'PLEASE USE fname.Trim() and lname.Trim() to feed in the database
        If (flag = 0) Then
            Try
                
                Dim userAlreadyExists As Boolean = False

                Access.AddParam("@user", USERNAME.Text)
                Access.ExecQuery("SELECT * FROM Student_DB WHERE Username=@user")
                If Access.RecordCount > 0 Then userAlreadyExists = True

                Access.AddParam("@user", USERNAME.Text)
                Access.ExecQuery("SELECT * FROM Faculty_DB WHERE Username=@user")
                If Access.RecordCount > 0 Then userAlreadyExists = True

                If userAlreadyExists Then
                    MessageBox.Show("User already exists with the same username try entering a differnet username", "USER EXISTS")
                Else
                    Access.AddParam("@user", USERNAME.Text)
                    Access.AddParam("@pwd", PASSWORD.Text)
                    Access.ExecQuery("INSERT INTO Student_DB([Username], [Password])VALUES(@user, @pwd)")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Public Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?\]1234567890 ".ToCharArray) <> -1
    End Function



    Private Sub HOD_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HOD_CheckBox.CheckedChanged
        'Making appropriate controls hidden
        If HOD_CheckBox.Checked = False Then
            Label11.Visible = False
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = False
            DESIGNATION.Visible = False
        End If
        If HOD_CheckBox.Checked = True Then
            Student_Checkbox.Checked = False
            Faculty_Checkbox.Checked = False
            Label11.Visible = True
            Label12.Visible = False
            DEPARTMENT_FAC.Visible = True
            DESIGNATION.Visible = False
        End If
    End Sub
End Class