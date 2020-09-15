Imports MySql
Imports MySql.Data.MySqlClient
Public Class Login
    Dim Konnect As MySqlConnection
    Dim Soma As MySqlDataReader
    Dim Kommand As MySqlCommand
    Private Sub Login_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        splash.Show()
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Konnect = New MySqlConnection
        Konnect.ConnectionString = "server=localhost; userid=root; password=morris"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Konnect = New MySqlConnection
        Konnect.ConnectionString = "server=localhost; userid=root; password=morris"
        If UserName.Text = "" Or Password.Text = "" Then
            MsgBox("Please Enter a username and Password to proceed!", MsgBoxStyle.Critical)
        Else
            Try
                Konnect.Open()
                Dim Query As String
                Query = "select * from maji.employees where Username ='" & UserName.Text & "' and Access_Code ='" & Password.Text & "'"
                Kommand = New MySqlCommand(Query, Konnect)
                Soma = Kommand.ExecuteReader
                Dim count As Integer
                count = 0
                While Soma.Read
                    count = count + 1
                End While
                If count = 1 Then
                    'Step 1: open the connection to the database
                    'step 2: declare a command that you will use to communicate with the database
                    'step 3: use the string to enter the data into the database
                    MessageBox.Show("Login Successful")
                    Password.ResetText()
                    UserName.ResetText()
                    Main_Menu.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("A similar username or password has been found" & vbCrLf & "Resolve this issue with the database administrator", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Login Failed", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Password.ResetText()
                    UserName.ResetText()
                End If

            Catch ex As MySqlException
                MessageBox.Show("Unable to connect to the database. Check Server settings.")

                'System.(ex)
                Password.ResetText()
                UserName.ResetText()
                UserName.Focus()
            Finally
                Konnect.Dispose()
            End Try
            UserName.ResetText()
            Password.ResetText()
        End If
    End Sub
End Class