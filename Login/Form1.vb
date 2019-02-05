Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form3.Show()
        Dim user_name As String = txtUsername.Text()
        Dim password As String = txtPassword.Text

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
        Dim conn As OleDbConnection = New OleDbConnection(connectionString)
        conn.Open()
        Dim query As String = "SELECT * FROM Student_DB WHERE Username= '" & user_name & "'  and Password = '" & password & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While (reader.Read())
            If (reader.HasRows()) Then
                Form3.Label1.Text = reader("Username")
                Form3.Label2.Text = reader("Department")
                Form3.Label3.Text = reader("Programme")
                Form3.Label4.Text = reader("Year_of_joining")
            End If
        End While
    End Sub
End Class
