Imports System.Data.OleDb
Public Class Form2
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
        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DataBase.accdb"
        'Dim conn As OleDbConnection = New OleDbConnection(connectionString)
        'conn.Open()


        'Dim sqlQu As String
        'sqlQu = "INSERT INTO Student_DB(Username, Password, Roll_no, Programme, Department, First_name)" & _
        '" VALUES (' " & Me.USERNAME.Text & " ', ' " & Me.PASSWORD.Text & " ' ,  " & Me.ROLL_NO.Text & " , ' " & Me.PROGRAMME.Text & " ', ' " & Me.DEPARTMENT.Text & " ', ' " & Me.FIRST_NAME.Text & " ')"
        'Dim cmd As New OleDb.OleDbCommand(sqlQu, conn)
        'cmd.ExecuteNonQuery()
        'conn.Close()
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
                Dim sqlconn As New OleDb.OleDbConnection
                Dim sqlquery As New OleDb.OleDbCommand
                Dim connString As String
                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vakul Gupta\Desktop\IITG-Leave-Sanction-System\Login\DataBase.accdb"
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn
                sqlconn.Open()
                Dim query As String = "SELECT * FROM Student_DB WHERE Username= '" & USERNAME.Text & "'"
                Dim query1 As String = "SELECT * FROM Faculty_DB WHERE Username= '" & USERNAME.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(query, sqlconn)
                Dim cmd1 As OleDbCommand = New OleDbCommand(query1, sqlconn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()
                If (reader1.HasRows() Or reader.HasRows()) Then
                    MessageBox.Show("User already exists with the same username try entering a differnet username", "USER EXISTS")
                Else
                    sqlquery.CommandText = "INSERT INTO Student_DB([Username], [Password])VALUES(@Username, @Password)"
                    sqlquery.Parameters.AddWithValue("@Username", USERNAME.Text)
                    sqlquery.Parameters.AddWithValue("@Password", PASSWORD.Text)
                    sqlquery.ExecuteNonQuery()
                End If
                sqlconn.Close()

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