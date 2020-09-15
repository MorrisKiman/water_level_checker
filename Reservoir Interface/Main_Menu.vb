Public Class Main_Menu

    Private Sub Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If userLevel.Text = "Attendant" Then
            AddUser.Visible = False
        End If
    End Sub

    Private Sub DataInterface_Click(sender As System.Object, e As System.EventArgs) Handles DataInterface.Click
        Me.Hide()
        CollectionInterface.Show()
    End Sub

    Private Sub Menu_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub

    Private Sub AddUser_Click(sender As System.Object, e As System.EventArgs) Handles AddUser.Click
        AddPage.Show()
        Me.Hide()
    End Sub

    Private Sub Reports_Click(sender As System.Object, e As System.EventArgs) Handles Report.Click
        Me.Hide()
        'Reports.Show()
    End Sub

    Private Sub DataAnalysis_Click(sender As System.Object, e As System.EventArgs) Handles DataAnalysis.Click
        Me.Hide()
        Processor.Show()
    End Sub
End Class

'MKNjoroge
'marythe90vrAA@@