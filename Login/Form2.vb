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

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vakul Gupta\Desktop\IITG-Leave-Sanction-System\Login\DataBase.accdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Student_DB([Username], [Password])VALUES(@Username, @Password)"
            sqlquery.Parameters.AddWithValue("@Username", USERNAME.Text)
            sqlquery.Parameters.AddWithValue("@Password", PASSWORD.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class