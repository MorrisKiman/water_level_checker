Public Class splash

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Enter_Click(sender As System.Object, e As System.EventArgs) Handles EnterSystem.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class