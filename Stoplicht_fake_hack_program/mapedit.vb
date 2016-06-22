
Imports System
Imports System.Drawing
Imports System.Windows.Forms


Public Class mapedit
    Dim point As New System.Drawing.Point
    Dim X, Y As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        info.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "Stop Light 1" Then
            Stoplight1.Visible = True
        End If


    End Sub

 

    Private Sub PictureBox1_MouseMove1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            point = Control.MousePosition
            point.X = point.X - Me.Location.X - (+20) '- (X)
            point.Y = point.Y - Me.Location.Y - (+50) '- (Y)
            pointxlabel.Text = point.X
            pointylabel.Text = point.Y
        End If

    End Sub


    Private Sub PictureBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick
        If ComboBox1.SelectedItem = "Stop Light 1" Then
            Stoplight1.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight1.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight1.Location.Y)
            Stoplight1.Location = point
            Stoplight1.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "Stop Light 2" Then
            Stoplight2.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight2.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight2.Location.Y)
            Stoplight2.Location = point
            Stoplight2.BackColor = Color.Green
        End If
        If ComboBox1.SelectedItem = "Stop Light 3" Then
            Stoplight3.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight3.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight3.Location.Y)
            Stoplight3.Location = point
            Stoplight3.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "Stop Light 4" Then
            Stoplicht4.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplicht4.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplicht4.Location.Y)
            Stoplicht4.Location = point
            Stoplicht4.BackColor = Color.Green
        End If
        If ComboBox1.SelectedItem = "Stop Light 5" Then
            Stoplight5.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight5.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight5.Location.Y)
            Stoplight5.Location = point
            Stoplight5.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "Stop Light 6" Then
            Stoplight6.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight6.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight6.Location.Y)
            Stoplight6.Location = point
            Stoplight6.BackColor = Color.Green
        End If

        If ComboBox1.SelectedItem = "Stop Light 7" Then
            Stoplight7.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight7.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight7.Location.Y)
            Stoplight7.Location = point
            Stoplight7.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "Stop Light 8" Then
            Stoplight8.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight8.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight8.Location.Y)
            Stoplight8.Location = point
            Stoplight8.BackColor = Color.Green
        End If
        If ComboBox1.SelectedItem = "Stop Light 9" Then
            Stoplight9.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight9.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight9.Location.Y)
            Stoplight9.Location = point
            Stoplight9.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "Stop Light 10" Then
            Stoplight10.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight10.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight10.Location.Y)
            Stoplight10.Location = point
            Stoplight10.BackColor = Color.Green
        End If
        If ComboBox1.SelectedItem = "Stop Light 11" Then
            Stoplight11.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight11.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight11.Location.Y)
            Stoplight11.Location = point
            Stoplight11.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "Stop Light 12" Then
            Stoplight12.Visible = True
            X = Control.MousePosition.X + Me.Location.X - (Stoplight12.Location.X)
            Y = Control.MousePosition.Y + Me.Location.Y - (Stoplight12.Location.Y)
            Stoplight12.Location = point
            Stoplight12.BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Ymouse.Text = MousePosition.Y
        Xmouse.Text = MousePosition.X
        If e.Button = Windows.Forms.MouseButtons.Left Then
            point = Control.MousePosition
            point.X = point.X - Me.Location.X - (+20) '- (X)
            point.Y = point.Y - Me.Location.Y - (+50) '- (Y)
            pointxlabel.Text = point.X
            pointylabel.Text = point.Y
        End If
    End Sub

    Private Sub PictureBox1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Move

    End Sub

    Private Sub mapedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mapedit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Ymouse.Text = MousePosition.Y
        Xmouse.Text = MousePosition.X
        If e.Button = Windows.Forms.MouseButtons.Left Then
            point = Control.MousePosition
            point.X = point.X - Me.Location.X - (+20) '- (X)
            point.Y = point.Y - Me.Location.Y - (+50) '- (Y)
            pointxlabel.Text = point.X
            pointylabel.Text = point.Y
        End If
    End Sub
End Class