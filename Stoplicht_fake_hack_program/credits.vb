Public Class credits

    Private Sub credits_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        info.Show()
    End Sub

    Private Sub credits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        info.Show()

    End Sub
End Class