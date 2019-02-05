Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim user_name As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DataBase.accdb"
        Dim conn As OleDbConnection = New OleDbConnection(connectionString)
        conn.Open()
        Dim query As String = "SELECT * FROM Student_DB WHERE Username= '" & user_name & "'  and Password = '" & password & "'"
        Dim query1 As String = "SELECT * FROM Faculty_DB WHERE Username= '" & user_name & "' and Password = '" & password & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn)
        Dim cmd1 As OleDbCommand = New OleDbCommand(query1, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()



        If ((Not (reader.HasRows())) And (Not (reader1.HasRows()))) Then
            MessageBox.Show("NO USER FOUND", "WRONG CREDENTIALS")

        Else
            Me.Hide()
            Form3.Show()
            While (reader.Read() Or reader1.Read())
                If (reader.HasRows()) Then
                    Form3.Label1.Text = reader("Username")
                    Form3.Label2.Text = reader("Department")
                    Form3.Label3.Text = reader("Programme")
                    Form3.Label4.Text = reader("Year_of_joining")
                ElseIf (reader1.HasRows()) Then
                    Form3.Label1.Text = reader1("Username")
                    Form3.Label2.Text = reader1("Department")
                    Form3.Label3.Text = reader1("Designation")
                    Form3.Label4.Text = ""

                End If
            End While
        End If

        conn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
