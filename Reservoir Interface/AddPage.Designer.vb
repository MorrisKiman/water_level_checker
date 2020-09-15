<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPage))
        Me.Sname = New System.Windows.Forms.TextBox()
        Me.OthNmes = New System.Windows.Forms.TextBox()
        Me.Residence = New System.Windows.Forms.TextBox()
        Me.Uname = New System.Windows.Forms.TextBox()
        Me.Insignia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SaveRec = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Verify = New System.Windows.Forms.Button()
        Me.IDNo = New System.Windows.Forms.MaskedTextBox()
        Me.TellNo = New System.Windows.Forms.MaskedTextBox()
        Me.AccessLevel = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.empid = New System.Windows.Forms.ComboBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sname
        '
        Me.Sname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sname.Location = New System.Drawing.Point(152, 47)
        Me.Sname.Name = "Sname"
        Me.Sname.Size = New System.Drawing.Size(204, 26)
        Me.Sname.TabIndex = 0
        Me.Sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OthNmes
        '
        Me.OthNmes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OthNmes.Location = New System.Drawing.Point(501, 44)
        Me.OthNmes.Name = "OthNmes"
        Me.OthNmes.Size = New System.Drawing.Size(266, 26)
        Me.OthNmes.TabIndex = 1
        Me.OthNmes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Residence
        '
        Me.Residence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Residence.Location = New System.Drawing.Point(501, 76)
        Me.Residence.Name = "Residence"
        Me.Residence.Size = New System.Drawing.Size(160, 26)
        Me.Residence.TabIndex = 3
        Me.Residence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Uname
        '
        Me.Uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uname.Location = New System.Drawing.Point(152, 143)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(221, 26)
        Me.Uname.TabIndex = 6
        Me.Uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Insignia
        '
        Me.Insignia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insignia.Location = New System.Drawing.Point(501, 142)
        Me.Insignia.Name = "Insignia"
        Me.Insignia.Size = New System.Drawing.Size(160, 26)
        Me.Insignia.TabIndex = 7
        Me.Insignia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Other Names"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tel. Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(401, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Residence"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID/Passport No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Access Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "User Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(381, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Access Code"
        '
        'SaveRec
        '
        Me.SaveRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveRec.Location = New System.Drawing.Point(624, 185)
        Me.SaveRec.Name = "SaveRec"
        Me.SaveRec.Size = New System.Drawing.Size(143, 37)
        Me.SaveRec.TabIndex = 9
        Me.SaveRec.Text = "Save Record"
        Me.SaveRec.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(194, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(410, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Mùgùtha Ward Water Project Add Employee Panel"
        '
        'Verify
        '
        Me.Verify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verify.Location = New System.Drawing.Point(475, 185)
        Me.Verify.Name = "Verify"
        Me.Verify.Size = New System.Drawing.Size(143, 37)
        Me.Verify.TabIndex = 8
        Me.Verify.Text = "Verify Record"
        Me.Verify.UseVisualStyleBackColor = True
        '
        'IDNo
        '
        Me.IDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IDNo.Location = New System.Drawing.Point(152, 111)
        Me.IDNo.Mask = "00-00-00-00"
        Me.IDNo.Name = "IDNo"
        Me.IDNo.Size = New System.Drawing.Size(152, 26)
        Me.IDNo.TabIndex = 4
        Me.IDNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TellNo
        '
        Me.TellNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TellNo.Location = New System.Drawing.Point(152, 79)
        Me.TellNo.Mask = "0000-000000"
        Me.TellNo.Name = "TellNo"
        Me.TellNo.Size = New System.Drawing.Size(152, 26)
        Me.TellNo.TabIndex = 2
        Me.TellNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccessLevel
        '
        Me.AccessLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AccessLevel.FormattingEnabled = True
        Me.AccessLevel.Location = New System.Drawing.Point(501, 108)
        Me.AccessLevel.Name = "AccessLevel"
        Me.AccessLevel.Size = New System.Drawing.Size(160, 28)
        Me.AccessLevel.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(457, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.empid)
        Me.GroupBox1.Controls.Add(Me.Delete)
        Me.GroupBox1.Controls.Add(Me.edit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(475, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 116)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Employee Details"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Employee ID:"
        '
        'empid
        '
        Me.empid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.empid.FormattingEnabled = True
        Me.empid.Location = New System.Drawing.Point(132, 25)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(160, 28)
        Me.empid.TabIndex = 21
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(153, 59)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(143, 37)
        Me.Delete.TabIndex = 1
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(4, 59)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(143, 37)
        Me.edit.TabIndex = 0
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 22
        '
        'AddPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(779, 407)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AccessLevel)
        Me.Controls.Add(Me.TellNo)
        Me.Controls.Add(Me.IDNo)
        Me.Controls.Add(Me.Verify)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SaveRec)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Insignia)
        Me.Controls.Add(Me.Uname)
        Me.Controls.Add(Me.Residence)
        Me.Controls.Add(Me.OthNmes)
        Me.Controls.Add(Me.Sname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mùgùtha Ward Water Project Add Attendant"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sname As System.Windows.Forms.TextBox
    Friend WithEvents OthNmes As System.Windows.Forms.TextBox
    Friend WithEvents Residence As System.Windows.Forms.TextBox
    Friend WithEvents Uname As System.Windows.Forms.TextBox
    Friend WithEvents Insignia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SaveRec As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Verify As System.Windows.Forms.Button
    Friend WithEvents IDNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TellNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AccessLevel As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents empid As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
