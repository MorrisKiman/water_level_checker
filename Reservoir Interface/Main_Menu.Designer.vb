<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userLevel = New System.Windows.Forms.Label()
        Me.DataInterface = New System.Windows.Forms.Button()
        Me.Report = New System.Windows.Forms.Button()
        Me.AddUser = New System.Windows.Forms.Button()
        Me.DataAnalysis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(349, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Logged in as:"
        '
        'userLevel
        '
        Me.userLevel.AutoSize = True
        Me.userLevel.BackColor = System.Drawing.Color.Transparent
        Me.userLevel.Font = New System.Drawing.Font("Swis721 Blk BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLevel.Location = New System.Drawing.Point(182, 58)
        Me.userLevel.Name = "userLevel"
        Me.userLevel.Size = New System.Drawing.Size(33, 25)
        Me.userLevel.TabIndex = 5
        Me.userLevel.Text = "---"
        '
        'DataInterface
        '
        Me.DataInterface.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataInterface.Location = New System.Drawing.Point(162, 144)
        Me.DataInterface.Name = "DataInterface"
        Me.DataInterface.Size = New System.Drawing.Size(239, 56)
        Me.DataInterface.TabIndex = 6
        Me.DataInterface.Text = "Data Interface"
        Me.DataInterface.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.Report.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Report.Location = New System.Drawing.Point(512, 144)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(239, 56)
        Me.Report.TabIndex = 7
        Me.Report.Text = "Reports Viewing"
        Me.Report.UseVisualStyleBackColor = True
        '
        'AddUser
        '
        Me.AddUser.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUser.Location = New System.Drawing.Point(162, 258)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(239, 56)
        Me.AddUser.TabIndex = 8
        Me.AddUser.Text = "Add/Edit User"
        Me.AddUser.UseVisualStyleBackColor = True
        '
        'DataAnalysis
        '
        Me.DataAnalysis.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAnalysis.Location = New System.Drawing.Point(512, 258)
        Me.DataAnalysis.Name = "DataAnalysis"
        Me.DataAnalysis.Size = New System.Drawing.Size(239, 56)
        Me.DataAnalysis.TabIndex = 9
        Me.DataAnalysis.Text = "Data Analysis"
        Me.DataAnalysis.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(871, 426)
        Me.Controls.Add(Me.DataAnalysis)
        Me.Controls.Add(Me.AddUser)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.DataInterface)
        Me.Controls.Add(Me.userLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents userLevel As System.Windows.Forms.Label
    Friend WithEvents DataInterface As System.Windows.Forms.Button
    Friend WithEvents Report As System.Windows.Forms.Button
    Friend WithEvents AddUser As System.Windows.Forms.Button
    Friend WithEvents DataAnalysis As System.Windows.Forms.Button
End Class
