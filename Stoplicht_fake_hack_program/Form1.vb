Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label2.Text = info.alarmtotaal.Text

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label_time.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub

    Private Sub Label_time_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label_time.TextChanged
        If Label_time.Text = Label2.Text Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Value = (ProgressBar1.Value + 1)
        If ProgressBar1.Value = "99" Then
            ProgressBar1.Value = "0"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        info.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
