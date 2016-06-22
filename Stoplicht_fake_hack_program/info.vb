Imports System.Text
Imports System.Uri

Public Class info

    Private Sub info_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Form1.Show()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        alarmtotaal.Text = TextBox2.Text + TextBox5.Text + ":" + TextBox3.Text + TextBox4.Text + ":" + TextBox5.Text + TextBox6.Text
        Label11.ForeColor = Color.Green
        Label11.Text = "ALARM SET!!!"

    End Sub

    Private Sub alarmtotaal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alarmtotaal.TextChanged
        Form1.Label2.Text = alarmtotaal.Text

    End Sub

 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox5.Text = TextBox5.Text + 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox6.Text = TextBox6.Text + 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox4.Text = TextBox4.Text + 1
    
    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "10" Then
            TextBox4.Text = "0"
            TextBox3.Text = TextBox3.Text + 1
        End If
        If TextBox3.Text = "6" And TextBox4.Text = "1" Then
            TextBox3.Text = "0"
            TextBox4.Text = "0"
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "10" Then
            TextBox6.Text = "0"
            TextBox7.Text = TextBox7.Text + 1
        End If
        If TextBox7.Text = "6" And TextBox6.Text = "1" Then
            TextBox7.Text = "0"
            TextBox6.Text = "0"
        End If

        If TextBox6.Text = "-1" And TextBox7.Text = "0" Then
            TextBox7.Text = "6"
            TextBox6.Text = "0"
        End If
       
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "-1" And TextBox2.Text = "0" Then
            TextBox2.Text = "1"
            TextBox5.Text = "2"
        End If

        If TextBox5.Text = "10" Then
            TextBox5.Text = "0"
            TextBox2.Text = TextBox2.Text + 1
        End If
        If TextBox2.Text = "1" And TextBox5.Text = "3" Then
            TextBox2.Text = "0"
            TextBox5.Text = "0"
        End If

        If TextBox5.Text = "-1" And TextBox2.Text = "-1" Then
            TextBox2.Text = "0"
            TextBox5.Text = "0"
        End If

        If TextBox5.Text = "-1" And TextBox2.Text = "1" Then
            TextBox2.Text = "0"
            TextBox5.Text = "9"
        End If

   
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox5.Text = TextBox5.Text - 1
 




    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox3.Text >= 0 Then
            TextBox4.Text = TextBox4.Text - 1
        ElseIf TextBox3.Text >= 0 And TextBox4.Text = "-1" Then
            TextBox4.Text = "0"
            TextBox3.Text = "6"
        End If

        If TextBox4.Text <= 0 And TextBox3.Text >= 0 Then
            TextBox3.Text = TextBox3.Text - 1
            TextBox4.Text = "9"
        End If

        If TextBox3.Text = "-1" Then
            TextBox4.Text = TextBox4.Text - 1
            TextBox3.Text = "0"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
 
        If TextBox7.Text >= 0 Then
            TextBox6.Text = TextBox6.Text - 1
        ElseIf TextBox7.Text >= 0 And TextBox6.Text = "-1" Then
            TextBox6.Text = "0"
            TextBox7.Text = "6"
        End If

        If TextBox6.Text <= 0 And TextBox7.Text >= 0 Then
            TextBox7.Text = TextBox7.Text - 1
            TextBox6.Text = "9"
        End If

        If TextBox7.Text = "-1" Then
            TextBox6.Text = TextBox6.Text - 1
            TextBox7.Text = "0"
        End If

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "6" Then TextBox7.Text = "0"
      
    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty

            Dim queryAddress As New StringBuilder()

            queryAddress.Append("http://maps.google.com/maps/api/staticmap?size=500x500&maptype=roadmap&markers=color:green|label:S|")
            ''center of map
            If txtCity.Text <> String.Empty Then
                city = txtCity.Text.Replace(" ", "+")
            End If
            ' build street part of query string
            If txtStreet.Text <> String.Empty Then
                street = txtStreet.Text.Replace(" ", "+")
                queryAddress.Append(street + ",")
            End If
            ' build city part of query string
            If txtCity.Text <> String.Empty Then
                city = txtCity.Text.Replace(" ", "+")
                queryAddress.Append(city + ",")
            End If
            ' build state part of query string
            If TxtState.Text <> String.Empty Then
                state = TxtState.Text.Replace(" ", "+")
                queryAddress.Append(state + ",")
            End If
            ' build zip code part of query string
            If txtZipCode.Text <> String.Empty Then
                zip = txtZipCode.Text.ToString()
                queryAddress.Append(zip)
            End If
            queryAddress.Append("|" + "&markers=color:green|label:A|")
            If txtStreet2.Text <> String.Empty Then
                street = txtStreet2.Text.Replace(" ", "+")
                queryAddress.Append(street + ",")
            End If
            ' build city part of query string
            If txtCity2.Text <> String.Empty Then
                city = txtCity2.Text.Replace(" ", "+")
                queryAddress.Append(city + ",")
            End If
            ' build state part of query string
            If TxtState2.Text <> String.Empty Then
                state = TxtState2.Text.Replace(" ", "=")
                queryAddress.Append(state + ",")
            End If
            ' build zip code part of query string
            If txtZipCode2.Text <> String.Empty Then
                zip = txtZipCode2.Text.ToString()
                queryAddress.Append(zip)
            End If
            queryAddress.Append("|" + "&markers=color:green|label:A|")
            If txtStreet3.Text <> String.Empty Then
                street = txtStreet3.Text.Replace(" ", "+")
                queryAddress.Append(street + ",")
            End If
            ' build city part of query string
            If txtCity3.Text <> String.Empty Then
                city = txtCity3.Text.Replace(" ", "+")
                queryAddress.Append(city + ",")
            End If
            ' build state part of query string
            If TxtState3.Text <> String.Empty Then
                state = TxtState3.Text.Replace(" ", "=")
                queryAddress.Append(state + ",")
            End If
            ' build zip code part of query string
            If txtZipCode3.Text <> String.Empty Then
                zip = txtZipCode3.Text.ToString()
                queryAddress.Append(zip)
            End If

            ' queryAddress.Append("&sensor=false&key=apikeyishere")
            ' pass the url with the query string to web browser control
            browser.WebBrowser1.Navigate(queryAddress.ToString())
            'Me.Txtstreet2.Text = queryAddress.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        End Try
        TextBox1.Text = browser.WebBrowser1.Url.OriginalString
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Button11.BackColor = Color.DarkGray Then
            Button11.BackColor = Color.Orange
        Else If Button11.BackColor = Color.Orange Then
            Button11.BackColor = Color.DarkGray
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Button12.BackColor = Color.DarkGray Then
            Button12.BackColor = Color.Green
        Else If Button12.BackColor = Color.Green Then
                Button12.BackColor = Color.DarkGray
            End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Button10.BackColor = Color.DarkGray Then
            Button10.BackColor = Color.Red
        Else If Button10.BackColor = Color.Red Then
                Button10.BackColor = Color.DarkGray
            End If

    End Sub

  
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Button13.BackColor = Color.DarkGray Then
            Button13.BackColor = Color.Green
        ElseIf Button13.BackColor = Color.Green Then
            Button13.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Button16.BackColor = Color.DarkGray Then
            Button16.BackColor = Color.Green
        ElseIf Button16.BackColor = Color.Green Then
            Button16.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Button14.BackColor = Color.DarkGray Then
            Button14.BackColor = Color.Orange
        ElseIf Button14.BackColor = Color.Orange Then
            Button14.BackColor = Color.DarkGray
        End If

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Button17.BackColor = Color.DarkGray Then
            Button17.BackColor = Color.Orange
        ElseIf Button17.BackColor = Color.Orange Then
            Button17.BackColor = Color.DarkGray
        End If

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Button15.BackColor = Color.DarkGray Then
            Button15.BackColor = Color.Red
        ElseIf Button15.BackColor = Color.Red Then
            Button15.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If Button18.BackColor = Color.DarkGray Then
            Button18.BackColor = Color.Red
        ElseIf Button18.BackColor = Color.Red Then
            Button18.BackColor = Color.DarkGray
        End If
    End Sub

   
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim area As Rectangle
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        area = browser.WebBrowser1.Bounds
        capture = New System.Drawing.Bitmap(Bounds.Width, Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb)
        graph = Graphics.FromImage(capture)
        graph.CopyFromScreen(area.X, area.Y, 0, 0, Bounds.Size, CopyPixelOperation.SourceCopy)
        mapedit.PictureBox1.Image = capture

        mapedit.Show()
        Me.Hide()
        Form1.Hide()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        credits.Show()
        Me.Hide()
        Form1.Hide()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        browser.show()
       
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
      
    End Sub
End Class