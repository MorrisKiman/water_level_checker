<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CollectionInterface))
        Me.AquaGauge1 = New AquaControls.AquaGauge()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.volLitres = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.volMetres = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WHeight = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Money_due = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LPumped = New System.Windows.Forms.Label()
        Me.distErr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.current_rate = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lastFill = New System.Windows.Forms.Label()
        Me.AquaGauge2 = New AquaControls.AquaGauge()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.Outletstatus = New System.Windows.Forms.Label()
        Me.inletstatus = New System.Windows.Forms.Label()
        Me.PumpOff = New System.Windows.Forms.Button()
        Me.PumpOn = New System.Windows.Forms.Button()
        Me.BothPumps = New System.Windows.Forms.RadioButton()
        Me.outLetPump = New System.Windows.Forms.RadioButton()
        Me.inletPump = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MMenu = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.PortConn = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dbstat = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AquaGauge1
        '
        Me.AquaGauge1.BackColor = System.Drawing.Color.Transparent
        Me.AquaGauge1.DialColor = System.Drawing.Color.Ivory
        Me.AquaGauge1.DialText = "Water Level (1000 ltrs)"
        Me.AquaGauge1.Glossiness = 11.36364!
        Me.AquaGauge1.Location = New System.Drawing.Point(8, 11)
        Me.AquaGauge1.Margin = New System.Windows.Forms.Padding(5)
        Me.AquaGauge1.MaxValue = 20.0!
        Me.AquaGauge1.MinValue = 0.0!
        Me.AquaGauge1.Name = "AquaGauge1"
        Me.AquaGauge1.RecommendedValue = 0.0!
        Me.AquaGauge1.Size = New System.Drawing.Size(300, 300)
        Me.AquaGauge1.TabIndex = 1
        Me.AquaGauge1.ThresholdPercent = 0.0!
        Me.AquaGauge1.Value = 0.0!
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(723, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data Collection and Communication Interface"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.volLitres)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.volMetres)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.WHeight)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.AquaGauge1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 310)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Water Level and Quantity"
        '
        'volLitres
        '
        Me.volLitres.AutoSize = True
        Me.volLitres.BackColor = System.Drawing.Color.Transparent
        Me.volLitres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volLitres.Location = New System.Drawing.Point(334, 208)
        Me.volLitres.Name = "volLitres"
        Me.volLitres.Size = New System.Drawing.Size(58, 25)
        Me.volLitres.TabIndex = 13
        Me.volLitres.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(316, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Water Volume (Litres)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(431, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "m"
        '
        'volMetres
        '
        Me.volMetres.AutoSize = True
        Me.volMetres.BackColor = System.Drawing.Color.Transparent
        Me.volMetres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volMetres.Location = New System.Drawing.Point(334, 138)
        Me.volMetres.Name = "volMetres"
        Me.volMetres.Size = New System.Drawing.Size(58, 25)
        Me.volMetres.TabIndex = 9
        Me.volMetres.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(458, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Water Volume (m   )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(410, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "m"
        '
        'WHeight
        '
        Me.WHeight.AutoSize = True
        Me.WHeight.BackColor = System.Drawing.Color.Transparent
        Me.WHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WHeight.Location = New System.Drawing.Point(334, 51)
        Me.WHeight.Name = "WHeight"
        Me.WHeight.Size = New System.Drawing.Size(58, 25)
        Me.WHeight.TabIndex = 4
        Me.WHeight.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Water Height (m)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(463, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Money_due)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.LPumped)
        Me.GroupBox2.Controls.Add(Me.distErr)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.current_rate)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lastFill)
        Me.GroupBox2.Controls.Add(Me.AquaGauge2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(744, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 310)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pumping Rates"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(319, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Money Due (Ksh)"
        '
        'Money_due
        '
        Me.Money_due.AutoSize = True
        Me.Money_due.Location = New System.Drawing.Point(351, 250)
        Me.Money_due.Name = "Money_due"
        Me.Money_due.Size = New System.Drawing.Size(44, 20)
        Me.Money_due.TabIndex = 15
        Me.Money_due.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(306, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Last Fill Level (Litres)"
        '
        'LPumped
        '
        Me.LPumped.AutoSize = True
        Me.LPumped.Location = New System.Drawing.Point(349, 187)
        Me.LPumped.Name = "LPumped"
        Me.LPumped.Size = New System.Drawing.Size(44, 20)
        Me.LPumped.TabIndex = 13
        Me.LPumped.Text = "0.00"
        '
        'distErr
        '
        Me.distErr.AutoSize = True
        Me.distErr.BackColor = System.Drawing.Color.Transparent
        Me.distErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distErr.Location = New System.Drawing.Point(460, 163)
        Me.distErr.Name = "distErr"
        Me.distErr.Size = New System.Drawing.Size(14, 20)
        Me.distErr.TabIndex = 12
        Me.distErr.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(316, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Litres Distributed"
        '
        'current_rate
        '
        Me.current_rate.AutoSize = True
        Me.current_rate.BackColor = System.Drawing.Color.Transparent
        Me.current_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_rate.Location = New System.Drawing.Point(337, 125)
        Me.current_rate.Name = "current_rate"
        Me.current_rate.Size = New System.Drawing.Size(58, 25)
        Me.current_rate.TabIndex = 9
        Me.current_rate.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(306, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Current Rate (Litres/Second )"
        '
        'lastFill
        '
        Me.lastFill.AutoSize = True
        Me.lastFill.BackColor = System.Drawing.Color.Transparent
        Me.lastFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastFill.Location = New System.Drawing.Point(337, 50)
        Me.lastFill.Name = "lastFill"
        Me.lastFill.Size = New System.Drawing.Size(58, 25)
        Me.lastFill.TabIndex = 4
        Me.lastFill.Text = "0.00"
        '
        'AquaGauge2
        '
        Me.AquaGauge2.BackColor = System.Drawing.Color.Transparent
        Me.AquaGauge2.DialColor = System.Drawing.Color.Ivory
        Me.AquaGauge2.DialText = "Liters/Second"
        Me.AquaGauge2.Glossiness = 11.36364!
        Me.AquaGauge2.Location = New System.Drawing.Point(8, 11)
        Me.AquaGauge2.Margin = New System.Windows.Forms.Padding(5)
        Me.AquaGauge2.MaxValue = 100.0!
        Me.AquaGauge2.MinValue = 0.0!
        Me.AquaGauge2.Name = "AquaGauge2"
        Me.AquaGauge2.RecommendedValue = 0.0!
        Me.AquaGauge2.Size = New System.Drawing.Size(300, 300)
        Me.AquaGauge2.TabIndex = 1
        Me.AquaGauge2.ThresholdPercent = 0.0!
        Me.AquaGauge2.Value = 0.0!
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Status)
        Me.GroupBox3.Controls.Add(Me.Outletstatus)
        Me.GroupBox3.Controls.Add(Me.inletstatus)
        Me.GroupBox3.Controls.Add(Me.PumpOff)
        Me.GroupBox3.Controls.Add(Me.PumpOn)
        Me.GroupBox3.Controls.Add(Me.BothPumps)
        Me.GroupBox3.Controls.Add(Me.outLetPump)
        Me.GroupBox3.Controls.Add(Me.inletPump)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(42, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 235)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pump States"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 20)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Pumping Status:"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(148, 29)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(83, 20)
        Me.Status.TabIndex = 17
        Me.Status.Text = "Stagnant"
        '
        'Outletstatus
        '
        Me.Outletstatus.AutoSize = True
        Me.Outletstatus.BackColor = System.Drawing.Color.Transparent
        Me.Outletstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outletstatus.Location = New System.Drawing.Point(157, 110)
        Me.Outletstatus.Name = "Outletstatus"
        Me.Outletstatus.Size = New System.Drawing.Size(44, 20)
        Me.Outletstatus.TabIndex = 16
        Me.Outletstatus.Text = "OFF"
        '
        'inletstatus
        '
        Me.inletstatus.AutoSize = True
        Me.inletstatus.BackColor = System.Drawing.Color.Transparent
        Me.inletstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inletstatus.Location = New System.Drawing.Point(157, 66)
        Me.inletstatus.Name = "inletstatus"
        Me.inletstatus.Size = New System.Drawing.Size(44, 20)
        Me.inletstatus.TabIndex = 12
        Me.inletstatus.Text = "OFF"
        '
        'PumpOff
        '
        Me.PumpOff.Location = New System.Drawing.Point(245, 193)
        Me.PumpOff.Name = "PumpOff"
        Me.PumpOff.Size = New System.Drawing.Size(118, 34)
        Me.PumpOff.TabIndex = 15
        Me.PumpOff.Text = "OFF"
        Me.PumpOff.UseVisualStyleBackColor = True
        '
        'PumpOn
        '
        Me.PumpOn.Location = New System.Drawing.Point(85, 193)
        Me.PumpOn.Name = "PumpOn"
        Me.PumpOn.Size = New System.Drawing.Size(118, 34)
        Me.PumpOn.TabIndex = 14
        Me.PumpOn.Text = "ON"
        Me.PumpOn.UseVisualStyleBackColor = True
        '
        'BothPumps
        '
        Me.BothPumps.AutoSize = True
        Me.BothPumps.Location = New System.Drawing.Point(6, 156)
        Me.BothPumps.Name = "BothPumps"
        Me.BothPumps.Size = New System.Drawing.Size(124, 24)
        Me.BothPumps.TabIndex = 13
        Me.BothPumps.TabStop = True
        Me.BothPumps.Text = "Both Pumps"
        Me.BothPumps.UseVisualStyleBackColor = True
        '
        'outLetPump
        '
        Me.outLetPump.AutoSize = True
        Me.outLetPump.Location = New System.Drawing.Point(6, 108)
        Me.outLetPump.Name = "outLetPump"
        Me.outLetPump.Size = New System.Drawing.Size(126, 24)
        Me.outLetPump.TabIndex = 12
        Me.outLetPump.TabStop = True
        Me.outLetPump.Text = "Outlet Pump"
        Me.outLetPump.UseVisualStyleBackColor = True
        '
        'inletPump
        '
        Me.inletPump.AutoSize = True
        Me.inletPump.Location = New System.Drawing.Point(6, 62)
        Me.inletPump.Name = "inletPump"
        Me.inletPump.Size = New System.Drawing.Size(113, 24)
        Me.inletPump.TabIndex = 11
        Me.inletPump.TabStop = True
        Me.inletPump.Text = "Inlet Pump"
        Me.inletPump.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(482, 445)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 206)
        Me.DataGridView1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(484, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Data Table"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1029, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 34)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MMenu
        '
        Me.MMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMenu.Location = New System.Drawing.Point(1029, 513)
        Me.MMenu.Name = "MMenu"
        Me.MMenu.Size = New System.Drawing.Size(118, 34)
        Me.MMenu.TabIndex = 18
        Me.MMenu.Text = "Menu"
        Me.MMenu.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(579, 98)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(165, 32)
        Me.comPort_ComboBox.TabIndex = 20
        '
        'PortConn
        '
        Me.PortConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortConn.Location = New System.Drawing.Point(579, 137)
        Me.PortConn.Name = "PortConn"
        Me.PortConn.Size = New System.Drawing.Size(161, 37)
        Me.PortConn.TabIndex = 21
        Me.PortConn.Text = "Connect"
        Me.PortConn.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(583, 177)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(34, 24)
        Me.Timer_LBL.TabIndex = 22
        Me.Timer_LBL.Text = "----"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(583, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Select Port"
        '
        'dbstat
        '
        Me.dbstat.AutoSize = True
        Me.dbstat.BackColor = System.Drawing.Color.Transparent
        Me.dbstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbstat.Location = New System.Drawing.Point(484, 654)
        Me.dbstat.Name = "dbstat"
        Me.dbstat.Size = New System.Drawing.Size(21, 20)
        Me.dbstat.TabIndex = 20
        Me.dbstat.Text = "--"
        '
        'CollectionInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1319, 683)
        Me.Controls.Add(Me.dbstat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.PortConn)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CollectionInterface"
        Me.Text = "Mùgùtha Ward Water Project Data Interface"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AquaGauge1 As AquaControls.AquaGauge
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents volMetres As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WHeight As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents current_rate As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lastFill As System.Windows.Forms.Label
    Friend WithEvents AquaGauge2 As AquaControls.AquaGauge
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Outletstatus As System.Windows.Forms.Label
    Friend WithEvents inletstatus As System.Windows.Forms.Label
    Friend WithEvents PumpOff As System.Windows.Forms.Button
    Friend WithEvents PumpOn As System.Windows.Forms.Button
    Friend WithEvents BothPumps As System.Windows.Forms.RadioButton
    Friend WithEvents outLetPump As System.Windows.Forms.RadioButton
    Friend WithEvents inletPump As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MMenu As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents comPort_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PortConn As System.Windows.Forms.Button
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents volLitres As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents dbstat As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents distErr As System.Windows.Forms.Label
    Friend WithEvents LPumped As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Money_due As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
