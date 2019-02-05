Imports System.Data.OleDb


Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataBaseDataSet.Leave_Update_DB' table. You can move, or remove it, as needed.
        Me.Leave_Update_DBTableAdapter.Fill(Me.DataBaseDataSet.Leave_Update_DB)
        'TODO: This line of code loads data into the 'DataBaseDataSet.Faculty_DB' table. You can move, or remove it, as needed.
        Me.Faculty_DBTableAdapter.Fill(Me.DataBaseDataSet.Faculty_DB)
        'TODO: This line of code loads data into the 'DataBaseDataSet.Leave_DB' table. You can move, or remove it, as needed.
        Me.Leave_DBTableAdapter.Fill(Me.DataBaseDataSet.Leave_DB)

    End Sub



    Private Sub btnSubmitLeave_Click(sender As Object, e As EventArgs) Handles btnSubmitLeave.Click
        Dim leave_type As String = comboxSelectLeaveType.Text
        Dim date_time_applied As Date = DateAndTime.Now()
        Dim current_status As String = "Pending"
        Dim username As String = Label1.Text
        Dim start_date As Date = daycalLeaveDays.SelectionStart
        Dim end_date As Date = daycalLeaveDays.SelectionEnd
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim hash_bytes As Byte() = md5Obj.ComputeHash(System.Text.Encoding.ASCII.GetBytes(username + date_time_applied.ToString))
        Dim leave_ID As New System.Text.StringBuilder()
        For i As Integer = 0 To hash_bytes.Length - 1
            leave_ID.Append(hash_bytes(i).ToString("x2"))
        Next




        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vakul Gupta\Desktop\different\IITG-Leave-Sanction-System\Login\DataBase.accdb"
        Dim conn As OleDbConnection = New OleDbConnection(connectionString)
        conn.Open()
        Dim query As String = "SELECT * FROM Student_DB WHERE Username= '" & Label1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()
        Dim duration_of_leave As TimeSpan = daycalLeaveDays.SelectionEnd - daycalLeaveDays.SelectionStart
        Dim participating_faculty As String = ""
        participating_faculty = participating_faculty & reader("Guide") & ", "
        participating_faculty = participating_faculty & reader("TA_Superviser")
        conn.Close()

        Dim connectionString1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vakul Gupta\Desktop\different\IITG-Leave-Sanction-System\Login\DataBase.accdb"
        Dim conn1 As OleDbConnection = New OleDbConnection(connectionString1)
        conn1.Open()
        Dim query1 As String = "SELECT * FROM Faculty_DB WHERE Designation= '" & "HOD" & "' and Department= '" & Label2.Text & "'"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query1, conn1)
        Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()
        reader1.Read()

        If duration_of_leave.Days > 30 Then
            participating_faculty = participating_faculty & reader1("Username") & ", "
        End If

        conn1.Close()

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vakul Gupta\Desktop\IITG-Leave-Sanction-System\Login\DataBase.accdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            Dim a As String
            a = "12345"
            sqlquery.CommandText = "INSERT INTO Leave_DB([Leave_ID], [Username])VALUES(@leave_ID, @username)"
            sqlquery.Parameters.AddWithValue("@leave_ID", a)
            sqlquery.Parameters.AddWithValue("@username", username)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class