Imports MySql
Imports MySql.Data.MySqlClient
Public Class AddPage
    Dim Konnect As MySqlConnection
    Dim Soma As MySqlDataReader
    Dim Kommando As MySqlCommand

    'Bado deleting and editting modules
    Private Sub AddPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Konnect = New MySqlConnection
        Konnect.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime=true; database=maji"
        SaveRec.Enabled = False
        edit.Enabled = False
        Delete.Enabled = False
        AccessCombo()
        employeeID()
        Update_Table()
    End Sub
    Private Sub AddPage_closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Main_Menu.Show()
    End Sub

    Private Sub Verify_Click(sender As System.Object, e As System.EventArgs) Handles Verify.Click
        If Sname.Text = "" Or TellNo.Text = "" Or IDNo.Text = "" Or Uname.Text = "" Or OthNmes.Text = "" Or Residence.Text = "" Or AccessLevel.Text = "" Or Insignia.Text = "" Then
            MessageBox.Show("Some fields have been left blank!", "Mugutha Water Reservoir", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            SaveRec.Enabled = False
            If AccessLevel.Text = "Attendant" Or AccessLevel.Text = "System Monitor" Or AccessLevel.Text = "" Then
                SaveRec.Enabled = False
                edit.Enabled = False
                Delete.Enabled = False
            Else
                MessageBox.Show("Unknown Access Level!", "Mugutha Water Reservoir", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Else
            SaveRec.Enabled = True
            edit.Enabled = True
            Delete.Enabled = True
        End If
    End Sub

    Private Sub SaveRec_Click(sender As System.Object, e As System.EventArgs) Handles SaveRec.Click
        If AccessLevel.Text = "Attendant" Or AccessLevel.Text = "System Monitor" Then
            Try
                'Step 1: open the connection to the database
                Konnect.Open()
                'step 2: declare a command that you will use to communicate with the database
                Dim Query As String
                'step 3: use the string to enter the data into the database
                Query = "insert into maji.employees (Surname, Other_Names, Telephone_Number, Residence, National_ID, Access_Level, Username, Access_Code) values ('" & Sname.Text & "', '" & OthNmes.Text & "', '" & TellNo.Text & "', '" & Residence.Text & "', '" & IDNo.Text & "', '" & AccessLevel.Text & "', '" & Uname.Text & "', '" & Insignia.Text & "')"
                Kommando = New MySqlCommand(Query, Konnect)
                Soma = Kommando.ExecuteReader
                MessageBox.Show("The new record has been added.", "Mugutha Water Reservoir", MessageBoxButtons.OK)
                basicResetter()
                SaveRec.Enabled = False
                Update_Table()
            Catch ex As Exception
                MessageBox.Show("Error in saving data! " & ex.Message, "Mugutha Water Reservoir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SaveRec.Enabled = False
                Konnect.Dispose()
            End Try
        Else
            MessageBox.Show("Unknown Access Level!", "Mugutha Water Reservoir", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            SaveRec.Enabled = False
        End If
    End Sub

    Private Sub AccessCombo()
        AccessLevel.Items.Add("Attendant")
        AccessLevel.Items.Add("System Monitor")
    End Sub

    Private Sub Update_Table()
        'It will refresh the table imediately the data is pushed into the database
        Konnect = New MySqlConnection
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Konnect.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=maji"
        Try
            Konnect.Open()
            Dim Query As String
            Query = "Select *from maji.employees"
            Kommando = New MySqlCommand(Query, Konnect)
            SDA.SelectCommand = Kommando
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)
            Konnect.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            Konnect.Dispose()
        End Try
    End Sub

    Private Sub employeeID()
        Dim Soma As MySqlDataReader
        Try
            Konnect.Open()
            Dim Query As String
            Query = "Select * from maji.employees"
            Kommando = New MySqlCommand(Query, Konnect)
            Soma = Kommando.ExecuteReader
            While Soma.Read
                Dim sName = Soma.GetString("Employee_ID")
                empid.Items.Add(sName)
            End While
            Konnect.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")
        Finally
            Konnect.Dispose()
        End Try
    End Sub

    Private Sub edit_Click(sender As System.Object, e As System.EventArgs) Handles edit.Click
        Dim Query As String
        If AccessLevel.Text = "Attendant" Or AccessLevel.Text = "System Monitor" Then
            Try
                Konnect.Open()
                Query = "update maji.employees set Surname='" & Sname.Text & "', Other_Names='" & OthNmes.Text & "', Telephone_Number='" & TellNo.Text & "', Residence ='" & Residence.Text & "', National_ID ='" & IDNo.Text & "', Access_Level ='" & AccessLevel.Text & "', Username_Name ='" & Uname.Text & "', Access_Code ='" & Insignia.Text & "' where employee_id = '" & empid.Text & "' "
                Kommando = New MySqlCommand(Query, Konnect) 'Date_of_Birth='" & AppDOB.Text & "', 
                Soma = Kommando.ExecuteReader
                MessageBox.Show("The record has been edited.", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK)
                basicResetter()
                SaveRec.Enabled = False
                edit.Enabled = False
                Delete.Enabled = False
                Update_Table()
            Catch ex As Exception
                MessageBox.Show("Error in saving data!" & vbCrLf & "1. Check connection to the database" & vbCrLf & "2. Check for error in the data", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
                edit.Enabled = False
                Delete.Enabled = False
            End Try
        Else
            MsgBox("Unknown Access Level!!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub empid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles empid.TextChanged
        Dim Query As String
        If empid.Text = "" Then
            basicResetter()
            edit.Enabled = False
            Delete.Enabled = False
        Else
            Try
                Konnect.Open()
                Query = "Select * from maji.employees where employee_ID='" & empid.Text & "'"
                Kommando = New MySqlCommand(Query, Konnect)
                Soma = Kommando.ExecuteReader
                While Soma.Read
                    Sname.Text = Soma.GetString("Surname")
                    OthNmes.Text = Soma.GetString("Other_Names")
                    TellNo.Text = Soma.GetString("Telephone_Number")
                    Residence.Text = Soma.GetString("Residence")
                    IDNo.Text = Soma.GetString("National_ID")
                    AccessLevel.Text = Soma.GetString("Access_Level")
                    Uname.Text = Soma.GetString("Username")
                    Insignia.Text = Soma.GetString("Access_Code")
                End While
            Catch ex As Exception
                MsgBox("Unable to retrieve records!! Check Server Connection." & ex.Message, MsgBoxStyle.Critical)
            Finally
                Konnect.Dispose()
            End Try
        End If
    End Sub
    Private Sub basicResetter()
        Sname.ResetText()
        OthNmes.ResetText()
        TellNo.ResetText()
        Residence.ResetText()
        IDNo.ResetText()
        AccessLevel.ResetText()
        Uname.ResetText()
        Insignia.ResetText()
        empid.ResetText()
    End Sub

    Private Sub Delete_Click(sender As System.Object, e As System.EventArgs) Handles Delete.Click
        Dim Query As String
        If AccessLevel.Text = "Attendant" Or AccessLevel.Text = "System Monitor" Then
            Try
                Konnect.Open()
                Query = "Delete from maji.employees where employee_id = '" & empid.Text & "' "
                Kommando = New MySqlCommand(Query, Konnect)
                Soma = Kommando.ExecuteReader
                MsgBox("The record has been Deleted.", MessageBoxButtons.OK)
                basicResetter()
                SaveRec.Enabled = False
                edit.Enabled = False
                Delete.Enabled = False
                Update_Table()
            Catch ex As Exception
                MsgBox("Error in saving data!" & vbCrLf & "1. Check connection to the database" & vbCrLf & "2. Check for error in the data", MsgBoxStyle.Exclamation)
                edit.Enabled = False
                Delete.Enabled = False
            End Try
        Else
            MsgBox("Unknown Access Level!!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class

