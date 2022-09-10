'Important note
'one cubic metre(1m3)=1000litres
'Imports libraries for the communication ports
Imports System
Imports System.IO.Ports
'Import libraries for MySql Database
Imports MySql
Imports MySql.Data.MySqlClient
'Begin the class
Public Class CollectionInterface
    'declare global variables one for the communication 
    'port and aanother one for accepting the data
    Dim ComPort As String
    'Dim ReceivedData As String = ""
    Dim ReceivedData As Decimal
    Dim MySQLKon As MySqlConnection
    Dim Kommando As MySqlCommand
    Dim Soma As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource
    Dim dbVol As Decimal
    Dim LasFil As Decimal

    Private Sub CollectionInterface_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        'handles the tiny "x" button at the top right corner of the form. The one that closes the window
        Main_Menu.Show()
    End Sub

    Private Sub CollectionInterface_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=WaterSprayer; database=sacco"
        Timer1.Enabled = False
        ComPort = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
        Update_Table()
        'dbVolume()
    End Sub

    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            ComPort = comPort_ComboBox.SelectedItem
        End If
    End Sub

    Private Sub portConn_Click(sender As System.Object, e As System.EventArgs) Handles PortConn.Click
        Try

            If (PortConn.Text = "Connect") Then
                If (ComPort <> "") Then
                    SerialPort1.Close()
                    SerialPort1.PortName = ComPort
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = Parity.None
                    SerialPort1.StopBits = StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default
                    SerialPort1.ReadTimeout = 1000000

                    SerialPort1.Open()
                    PortConn.Text = "Dis-connect"
                    Timer1.Enabled = True
                    Timer_LBL.Text = "Comport: ON"
                Else
                    MsgBox("Select a COM port first")
                End If
            Else
                SerialPort1.Close()
                PortConn.Text = "Connect"
                WHeight.Text = "0.00"
                Timer1.Enabled = False
                inletPump.Checked = False
                outLetPump.Checked = False
                Timer_LBL.Text = "Comport: OFF"
            End If
        Catch ex As Exception
            MsgBox("An error occured while trying to connect." & vbCrLf & "Ensure the com port is correct and Arduino is properly connected", MsgBoxStyle.Critical)
        End Try
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            'r=1.4572m; height= 3m; vol= (baseArea x height)= {(3.18*3.14)*height}'
            'capacity in litres= vol*1000
            Dim Artemis As String = Decimal.Parse(WHeight.Text, Globalization.NumberStyles.Currency)
            Dim vM As Double
            Dim Aquaconverted = Artemis
            ReceivedData = ReceiveSerialData()
            vM = Artemis * (3.14 * (1.4572 * 1.4572))
            volMetres.Text = vM.ToString("N2")
            WHeight.Text = ReceivedData
            AquaGauge1.Value = vM.ToString("N2")
            volLitres.Text = Math.Sqrt((vM * 1000) * (vM * 1000)).ToString("0.00")
        Catch ex As Exception

        End Try
        dbVolume() 'gets the volume of water in the db
        'Rate_Calculator()
    End Sub
    Private Sub MMenu_Click(sender As System.Object, e As System.EventArgs) Handles MMenu.Click
        Main_Menu.Show()
    End Sub
    Private Sub Save_Data()
        'It will push collected values into the database
            Try
                'Step 1: open the connection to the database
            MySQLKon.Open()
                'step 2: declare a command that you will use to communicate with the database
                Dim Query As String
                'step 3: use the string to enter the data into the database
            Query = "insert into maji.water_level (water_level, Time_Checked, Date_Checked, Status, water_Volume, Flow_rate_per_second, Liters_Pumped_Out, Payments_Due) values ('" & WHeight.Text & "', CURTIME(), Now(), '" & Status.Text & "', '" & volLitres.Text & "', '" & current_rate.Text & "', '" & LasFil & "', '" & Money_due.Text & "')"
            Kommando = New MySqlCommand(Query, MySQLKon)
                Soma = Kommando.ExecuteReader
            Update_Table()
            dbstat.Text = "Saved"
            Catch ex As Exception
            'MessageBox.Show("Error in saving data!", "Mugutha Water Reservoir", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dbstat.Text = "Error"
        End Try
    End Sub
    Private Sub Update_Table()
        'It will refresh the table imediately the data is pushed into the database
        MySQLKon = New MySqlConnection
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        MySQLKon.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=WaterSprayer; database=maji"
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select * from maji.water_level order by Data_ID DESC"
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
    Private Sub PumpOn_Click(sender As System.Object, e As System.EventArgs) Handles PumpOn.Click
        Try
            If inletPump.Checked And Outletstatus.Text = "OFF" Then
                SerialPort1.Write("a")
                inletstatus.Text = "ON"
                Status.Text = "Filling"
            ElseIf outLetPump.Checked And inletstatus.Text = "OFF" Then
                SerialPort1.Write("b")
                Outletstatus.Text = "ON"
                Status.Text = "Distributing"
            ElseIf BothPumps.Checked Then
                MsgBox("You cannot activate both pumps!" & vbCrLf & "It may damage one or both pumps.", MsgBoxStyle.Critical)
            Else
                MsgBox("An error Occurred in your selected action" & vbCrLf & "Either you haven't made a selection yet or" & vbCrLf & "Check for an already activated pump and switch it off first" & vbCrLf & "Continuing with this action may damage one or both pumps.", MsgBoxStyle.Critical, AcceptButton)
            End If
        Catch ex As Exception
            MsgBox("An error occured while trying to connect." & vbCrLf & "Ensure the com port is correct and Arduino is properly connected", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub PumpOff_Click(sender As System.Object, e As System.EventArgs) Handles PumpOff.Click
        Try
            If inletPump.Checked Then
                SerialPort1.Write("c")
                inletstatus.Text = "OFF"
            ElseIf outLetPump.Checked Then
                SerialPort1.Write("d")
                Outletstatus.Text = "OFF"
            ElseIf BothPumps.Checked Then
                SerialPort1.Write("e")
                Outletstatus.Text = "OFF"
                inletstatus.Text = "OFF"
            End If
        Catch ex As Exception
            MsgBox("An error occured while trying to connect." & vbCrLf & "Ensure the com port is correct and Arduino is properly connected", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub volLitres_TextChanged(sender As System.Object, e As System.EventArgs) Handles volLitres.TextChanged
        Save_Data() 'saves to water level
        Update_Table() 'updates the datatable on the display
        Rate_Calculator()
    End Sub
    Private Sub Rate_Calculator()
        'calculates the rate at which we are pumping water to customers
        Dim GUI_vol As Decimal = volLitres.Text
        'private static Decimal Sqrt (Decimal dy)
        Dim dy = (GUI_vol - dbVol) / 60
        current_rate.Text = Math.Sqrt(dy * dy).ToString("0.00")
        AquaGauge2.Value = current_rate.Text
        'calculate the money due
        Dim cvr As Decimal = Decimal.Parse(volLitres.Text, Globalization.NumberStyles.Currency)
        Money_due.Text = cvr * 50

    End Sub
    Private Sub dbVolume()
        'gets the most recently added water volume in the db which will be used to calculate the rate at which
        'water is being pumped.
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=WaterSprayer"
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select water_volume from maji.water_level where data_id = (select max(data_id) from maji.water_level)"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                dbVol = READER.GetString("water_volume")
            End While
            MySQLKon.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub prevol()
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=WaterSprayer"
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select water_Volume from maji.water_level where Status like '%Filling%'summary_id = (select max(data_ID) from maji.water_level where status = 'Filling')"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                lastFill.Text = READER.GetString("water_Volume")
                Dim redf = lastFill.Text
                Dim fzr = volLitres.Text
                LasFil = Math.Sqrt((redf - fzr) * (redf - fzr))
            End While
            MySQLKon.Close()
        Catch ex As Exception
            lastFill.Text = 0.0
        End Try

    End Sub

    Private Sub WHeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WHeight.Click

    End Sub
End Class

'Summary_ID, Summary_Date, Liters_Pumped_Out, Pump_rate, Payments_Due
'select water_volume from water_level where status like '%Distributing%' and data_id = (select max(data_id) from water_level where status like '%Distributing%')