Public Class Form1
    '''--------------------------------------
    '''Documentation For Jungle Timer       |
    ''' Created by: Tyler Marshall 300210747|
    ''' Programmed on Visual Basic 2010     |
    ''' 1/18/2014 - First version released  |
    '''--------------------------------------
    ''' TO DO:
    ''' Add Hotkeys
    ''' Add Conf
    ''' Add Custom Sounds
    ''' Release to public 




    'Wolf Camp Timer 1
    Private wolfRespawn1 As TimeSpan = TimeSpan.FromSeconds(49)
    Private wolfRespawnDT1 As DateTime
    Private Sub wolfCampTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wolfCampTimer1.Tick
        Dim ts As TimeSpan = wolfRespawnDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            wct1.Text = ts.ToString("mm\:ss")
        Else
            wct1.Text = "00:00"
            wolfCampTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        wolfRespawnDT1 = DateTime.Now.Add(wolfRespawn1)
        wolfCampTimer1.Start()
        Beep()
    End Sub


    'Wolf Camp Timer 2
    Private wolfRespawn2 As TimeSpan = TimeSpan.FromSeconds(49)
    Private wolfRespawnDT2 As DateTime
    Private Sub wolfCampTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wolfCampTimer2.Tick
        Dim ts As TimeSpan = wolfRespawnDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            wct2.Text = ts.ToString("mm\:ss")
        Else
            wct2.Text = "00:00"
            wolfCampTimer2.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        wolfRespawnDT2 = DateTime.Now.Add(wolfRespawn2)
        wolfCampTimer2.Start()
        Beep()
    End Sub


    'Blue Buff Camp Timer 1
    Private blueBuffRespawn1 As TimeSpan = TimeSpan.FromSeconds(299)
    Private blueBuffRespawnDT1 As DateTime
    Private Sub blueBuffTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueBuffTimer1.Tick
        Dim ts As TimeSpan = blueBuffRespawnDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            bbct1.Text = ts.ToString("mm\:ss")
        Else
            bbct1.Text = "00:00"
            blueBuffTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        blueBuffRespawnDT1 = DateTime.Now.Add(blueBuffRespawn1)
        blueBuffTimer1.Start()
        Beep()
    End Sub


    'Blue Buff Camp Timer 2
    Private blueBuffRespawn2 As TimeSpan = TimeSpan.FromSeconds(299)
    Private blueBuffRespawnDT2 As DateTime
    Private Sub blueBuffTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueBuffTimer2.Tick
        Dim ts As TimeSpan = blueBuffRespawnDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            bbct2.Text = ts.ToString("mm\:ss")
        Else
            bbct2.Text = "00:00"
            blueBuffTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        blueBuffRespawnDT2 = DateTime.Now.Add(blueBuffRespawn2)
        blueBuffTimer2.Start()
        Beep()
    End Sub

    'Red Buff Camp Timer 1
    Private redBuffRespawn1 As TimeSpan = TimeSpan.FromSeconds(299)
    Private redBuffRespawnDT1 As DateTime
    Private Sub redBuffTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redBuffTimer1.Tick
        Dim ts As TimeSpan = redBuffRespawnDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            rbct1.Text = ts.ToString("mm\:ss")
        Else
            rbct1.Text = "00:00"
            redBuffTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        redBuffRespawnDT1 = DateTime.Now.Add(redBuffRespawn1)
        redBuffTimer1.Start()
        Beep()
    End Sub


    'Red Buff Camp Timer 2
    Private redBuffRespawn2 As TimeSpan = TimeSpan.FromSeconds(299)
    Private redBuffRespawnDT2 As DateTime
    Private Sub redBuffTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redBuffTimer2.Tick
        Dim ts As TimeSpan = redBuffRespawnDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            rbct2.Text = ts.ToString("mm\:ss")
        Else
            rbct2.Text = "00:00"
            redBuffTimer2.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        redBuffRespawnDT2 = DateTime.Now.Add(redBuffRespawn2)
        redBuffTimer2.Start()
        Beep()
    End Sub


    'White Camp Timer 1
    Private whiteCampRespawn1 As TimeSpan = TimeSpan.FromSeconds(49)
    Private whiteCampRespawnDT1 As DateTime
    Private Sub whiteCampTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whiteCampTimer1.Tick
        Dim ts As TimeSpan = whiteCampRespawnDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            whct1.Text = ts.ToString("mm\:ss")
        Else
            whct1.Text = "00:00"
            whiteCampTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        whiteCampRespawnDT1 = DateTime.Now.Add(whiteCampRespawn1)
        whiteCampTimer1.Start()
        Beep()
    End Sub


    'White Camp Timer 2
    Private whiteCampRespawn2 As TimeSpan = TimeSpan.FromSeconds(49)
    Private whiteCampRespawnDT2 As DateTime
    Private Sub whiteCampTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whiteCampTimer2.Tick
        Dim ts As TimeSpan = whiteCampRespawnDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            whct2.Text = ts.ToString("mm\:ss")
        Else
            whct2.Text = "00:00"
            whiteCampTimer2.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        whiteCampRespawnDT2 = DateTime.Now.Add(whiteCampRespawn2)
        whiteCampTimer2.Start()
        Beep()
    End Sub


    'Wraith Camp Timer 1
    Private wraithCampRespawn1 As TimeSpan = TimeSpan.FromSeconds(49)
    Private wraithCampRespawnDT1 As DateTime
    Private Sub wraithCampTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wraithCampTimer1.Tick
        Dim ts As TimeSpan = wraithCampRespawnDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            wrct1.Text = ts.ToString("mm\:ss")
        Else
            wrct1.Text = "00:00"
            wraithCampTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        wraithCampRespawnDT1 = DateTime.Now.Add(wraithCampRespawn1)
        wraithCampTimer1.Start()
        Beep()
    End Sub


    'Wraith Camp Timer 2
    Private wraithCampRespawn2 As TimeSpan = TimeSpan.FromSeconds(49)
    Private wraithCampRespawnDT2 As DateTime
    Private Sub wraithCampTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wraithCampTimer2.Tick
        Dim ts As TimeSpan = wraithCampRespawnDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            wrct2.Text = ts.ToString("mm\:ss")
        Else
            wrct2.Text = "00:00"
            wraithCampTimer2.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        wraithCampRespawnDT2 = DateTime.Now.Add(wraithCampRespawn2)
        wraithCampTimer2.Start()
        Beep()
    End Sub


    'Golem Camp Timer 1
    Private golemCampRespawn1 As TimeSpan = TimeSpan.FromSeconds(49)
    Private golemCampRespawnDT1 As DateTime
    Private Sub golemTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golemTimer1.Tick
        Dim ts As TimeSpan = golemCampRespawnDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            gct1.Text = ts.ToString("mm\:ss")
        Else
            gct1.Text = "00:00"
            golemTimer1.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        golemCampRespawnDT1 = DateTime.Now.Add(golemCampRespawn1)
        golemTimer1.Start()
        Beep()
    End Sub


    'Golem Camp Timer 2
    Private golemCampRespawn2 As TimeSpan = TimeSpan.FromSeconds(49)
    Private golemCampRespawnDT2 As DateTime
    Private Sub golemTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golemTimer2.Tick
        Dim ts As TimeSpan = golemCampRespawnDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            gct2.Text = ts.ToString("mm\:ss")
        Else
            gct2.Text = "00:00"
            golemTimer2.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        golemCampRespawnDT2 = DateTime.Now.Add(golemCampRespawn2)
        golemTimer2.Start()
        Beep()
    End Sub


    'Dragon Camp Timer
    Private dragonCampRespawn As TimeSpan = TimeSpan.FromSeconds(359)
    Private dragonCampRespawnDT As DateTime
    Private Sub dtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtimer.Tick
        Dim ts As TimeSpan = dragonCampRespawnDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            dct.Text = ts.ToString("mm\:ss")
        Else
            dct.Text = "00:00"
            dtimer.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        dragonCampRespawnDT = DateTime.Now.Add(dragonCampRespawn)
        dtimer.Start()
        Beep()
    End Sub


    'Baron Camp Timer
    Private baronCampRespawn As TimeSpan = TimeSpan.FromSeconds(419)
    Private baronCampRespawnDT As DateTime
    Private Sub btimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btimer.Tick
        Dim ts As TimeSpan = baronCampRespawnDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            bct.Text = ts.ToString("mm\:ss")
        Else
            bct.Text = "00:00"
            btimer.Stop()
            Beep()
        End If
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        baronCampRespawnDT = DateTime.Now.Add(baronCampRespawn)
        btimer.Start()
        Beep()
    End Sub
End Class
