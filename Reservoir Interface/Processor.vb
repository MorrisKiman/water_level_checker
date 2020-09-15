Imports MySql
Imports iTextSharp
Imports MySql.Data.MySqlClient
Public Class Processor
    Dim MySqlKon As MySqlConnection
    Dim Kommando As MySqlCommand
    Dim Soma As MySqlDataReader

    Private Sub Processor_closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Main_Menu.Show()
    End Sub
    Private Sub Processor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySqlKon = New MySqlConnection
        MySqlKon.ConnectionString = "server=localhost; userid=root; password=morris;"
        Update_Table()
    End Sub
    Private Sub summaryFiller()
        Dim price As Decimal
        price = price
            Try
                MySQLKon.Open()
            Dim Query As String 'hapa
            'Query = "insert into maji.data_summary (Summary_ID, Summary_Date, Liters_Pumped_Out, Pump_rate, Payments_Due) values ('""', Now(), CURTIME(), '" & LPumped.Text & "', '" & current_rate.Text & "', '" & price & "')"
                Kommando = New MySqlCommand(Query, MySQLKon)
                Soma = Kommando.ExecuteReader

            Catch ex As Exception

        End Try
    End Sub

    Private Sub litres_pd() 'calculates the volume of water that has been pumped out to consumers
        'I need the following things: last level that the tank was filled-the current level of water present 
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand
        Dim lastFill As Decimal

        Try
            MySqlKon.Open()
            Dim Query As String
            Query = "select water_volume from water_level where status like '%Filling%' and data_id = (select max(data_id) from water_level where status like '%Filling%')"
            Command = New MySqlCommand(Query, MySqlKon)
            READER = Command.ExecuteReader
            While READER.Read
                lastFill = READER.GetString("water_volume")
            End While

            MySqlKon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub prevol()
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand

        Try
            MySQLKon.Open()
            Dim Query As String
            'Query = "select water_Volume from maji.water_level where Status like '%Distributing%'summary_id = (select max(water_Volume) from maji.water_level)"
            Query = "select water_volume from maji.water_level where status like '%Distributing%' and data_id = (select max(data_id) from water_level where status like '%Distributing%')"
            Command = New MySqlCommand(Query, MySqlKon)
            READER = Command.ExecuteReader
            While READER.Read
                'previousRate.Text = READER.GetString("water_Volume")
            End While
            MySqlKon.Close()
        Catch ex As Exception
            'previousRate.Text = 0.0
        End Try

    End Sub    '

    Private Sub cntgetter()
        MySqlKon = New MySqlConnection
        MySqlKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand
        Try
            MySqlKon.Open()
            Dim Query As String
            Query = "select count(Status) from maji.water_level where Status = 'Distributing' and Date_Checked between '2018-11-3' and '2018-11-29'"
            '" & sdv.Text & "' and '" & sdvsd.Text & "'"""
            Command = New MySqlCommand(Query, MySqlKon)
            READER = Command.ExecuteReader
            While READER.Read
                DataCnt.Text = READER.GetString("count(Status)") '29/11/1993
            End While

            MySqlKon.Close()
        Catch ex As Exception

        End Try
        '
    End Sub
    Private Sub searcher_Click(sender As System.Object, e As System.EventArgs) Handles searcher.Click
        MySqlKon = New MySqlConnection
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim Query As String
        Dim bSource As New BindingSource
        MySqlKon.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"
        Try
            MySqlKon.Open()
            'Query = "Select *from maji.data_summary"
            Query = "Select * from maji.water_level where Date_Checked between '@d1' and '@d2'"
            '"select * from maji.water_level where Status like '%Distributing%' and Date_Checked between '2018-11-3' and '2018-11-  status = 'Distributing' and
            Kommando = New MySqlCommand(Query, MySqlKon)
            Kommando.Parameters.Add("@d1", MySqlDbType.Date).Value = fromdt.Text
            Kommando.Parameters.Add("@d2", MySqlDbType.Date).Value = Todt.Text
            SDA.SelectCommand = Kommando
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlKon.Close()
            cntgetter()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlKon.Dispose()
        End Try
    End Sub
    Private Sub Update_Table()
        'It will refresh the table imediately the data is pushed into the database
        MySQLKon = New MySqlConnection
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        MySQLKon.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select *from maji.water_level where status = 'Distributing'"
            Kommando = New MySqlCommand(Query, MySQLKon)
            SDA.SelectCommand = Kommando
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)
            MySQLKon.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
End Class