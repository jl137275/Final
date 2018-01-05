Public Class Rand_64_Team_Bracket
    Dim startSoundSystemYouCanDoit As New System.Media.SoundPlayer("http://www.pacdv.com/sounds/voices/you-can-do-it.wav")
    Dim startSoundSystemYourALmostThere As New System.Media.SoundPlayer("http://www.pacdv.com/sounds/voices/youre-almost-there.wav")
    Dim startSoundSystemYouGotIt As New System.Media.SoundPlayer("http://www.pacdv.com/sounds/people_sound_effects/you_got_it_2.wav")
    Dim startSoundSystemWinner As New System.Media.SoundPlayer("http://static1.grsites.com/archive/sounds/people/people093.wav")

    Private Sub btnRound1_Click(sender As Object, e As EventArgs) Handles btnRound1.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer
        Dim intWinner3 As Integer
        Dim intWinner4 As Integer
        Dim intWinner5 As Integer
        Dim intWinner6 As Integer
        Dim intWinner7 As Integer
        Dim intWinner8 As Integer
        Dim intWinner9 As Integer
        Dim intWinner10 As Integer
        Dim intWinner11 As Integer
        Dim intWinner12 As Integer
        Dim intWinner13 As Integer
        Dim intWinner14 As Integer
        Dim intWinner15 As Integer
        Dim intWinner16 As Integer
        Dim intWinner17 As Integer
        Dim intWinner18 As Integer
        Dim intWinner19 As Integer
        Dim intWinner20 As Integer
        Dim intWinner21 As Integer
        Dim intWinner22 As Integer
        Dim intWinner23 As Integer
        Dim intWinner24 As Integer
        Dim intWinner25 As Integer
        Dim intWinner26 As Integer
        Dim intWinner27 As Integer
        Dim intWinner28 As Integer
        Dim intWinner29 As Integer
        Dim intWinner30 As Integer
        Dim intWinner31 As Integer
        Dim intWinner32 As Integer

        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String

        For intWinner = 0 To 31
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)
            intWinner3 = rand.Next(2)
            intWinner4 = rand.Next(2)
            intWinner5 = rand.Next(2)
            intWinner6 = rand.Next(2)
            intWinner7 = rand.Next(2)
            intWinner8 = rand.Next(2)
            intWinner9 = rand.Next(2)
            intWinner10 = rand.Next(2)
            intWinner11 = rand.Next(2)
            intWinner12 = rand.Next(2)
            intWinner13 = rand.Next(2)
            intWinner14 = rand.Next(2)
            intWinner15 = rand.Next(2)
            intWinner16 = rand.Next(2)
            intWinner17 = rand.Next(2)
            intWinner18 = rand.Next(2)
            intWinner19 = rand.Next(2)
            intWinner20 = rand.Next(2)
            intWinner21 = rand.Next(2)
            intWinner22 = rand.Next(2)
            intWinner23 = rand.Next(2)
            intWinner24 = rand.Next(2)
            intWinner25 = rand.Next(2)
            intWinner26 = rand.Next(2)
            intWinner27 = rand.Next(2)
            intWinner28 = rand.Next(2)
            intWinner29 = rand.Next(2)
            intWinner30 = rand.Next(2)
            intWinner31 = rand.Next(2)
            intWinner32 = rand.Next(2)

        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            ' 0 means txtseed1 is the winner
            strWinnerOne = txtSeed1.Text
        Else
            ' 1 means txtseed64 is the winner
            strWinnerOne = txtSeed64.Text
        End If
        lblround2Seed1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner2 = rand.Next(2)
        ' Display the Winner
        If intWinner2 = 0 Then
            ' 0 means txtseed2 is the winner
            strWinnerOne = txtSeed2.Text
        Else
            ' 1 means txtseed63 is the winner
            strWinnerOne = txtSeed63.Text
        End If
        lblround2Seed2.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner3 = rand.Next(2)
        ' Display the Winner
        If intWinner3 = 0 Then
            ' 0 means txtseed3 is the winner
            strWinnerOne = txtSeed3.Text
        Else
            ' 1 means txtseed62 is the winner
            strWinnerOne = txtSeed62.Text
        End If
        lblRound2Seed3.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner4 = rand.Next(2)
        ' Display the Winner
        If intWinner4 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed4.Text
        Else
            ' 1 means txtseed61 is the winner
            strWinnerOne = txtSeed61.Text
        End If
        lblRound2Seed4.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner5 = rand.Next(2)
        ' Display the Winner
        If intWinner5 = 0 Then
            ' 0 means txtseed5 is the winner
            strWinnerOne = txtSeed5.Text
        Else
            ' 1 means txtseed60 is the winner
            strWinnerOne = txtSeed60.Text
        End If
        lblRound2Seed5.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner6 = rand.Next(2)
        ' Display the Winner
        If intWinner6 = 0 Then
            ' 0 means txtseed6 is the winner
            strWinnerOne = txtSeed6.Text
        Else
            ' 1 means txtseed59 is the winner
            strWinnerOne = txtSeed59.Text
        End If
        lblRound2Seed6.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner7 = rand.Next(2)
        ' Display the Winner
        If intWinner7 = 0 Then
            ' 0 means txtseed7 is the winner
            strWinnerOne = txtSeed7.Text
        Else
            ' 1 means txtseed58 is the winner
            strWinnerOne = txtSeed58.Text
        End If
        lblRound2Seed7.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner8 = rand.Next(2)
        ' Display the Winner
        If intWinner8 = 0 Then
            ' 0 means txtseed8 is the winner
            strWinnerOne = txtSeed8.Text
        Else
            ' 1 means txtseed57 is the winner
            strWinnerOne = txtSeed57.Text
        End If
        lblRound2Seed8.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner9 = rand.Next(2)
        ' Display the Winner
        If intWinner9 = 0 Then
            ' 0 means txtseed9 is the winner
            strWinnerOne = txtSeed9.Text
        Else
            ' 1 means txtseed56 is the winner
            strWinnerOne = txtSeed56.Text
        End If
        lblRound2Seed9.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner10 = rand.Next(2)
        ' Display the Winner
        If intWinner10 = 0 Then
            ' 0 means txtseed10 is the winner
            strWinnerOne = txtSeed10.Text
        Else
            ' 1 means txtsee55 is the winner
            strWinnerOne = txtSeed55.Text
        End If
        lblRound2Seed10.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner11 = rand.Next(2)
        ' Display the Winner
        If intWinner11 = 0 Then
            ' 0 means txtseed11 is the winner
            strWinnerOne = txtSeed11.Text
        Else
            ' 1 means txtseed54 is the winner
            strWinnerOne = txtSeed54.Text
        End If
        lblRound2Seed11.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner12 = rand.Next(2)
        ' Display the Winner
        If intWinner12 = 0 Then
            ' 0 means txtseed12 is the winner
            strWinnerOne = txtSeed12.Text
        Else
            ' 1 means txtseed53 is the winner
            strWinnerOne = txtSeed53.Text
        End If
        lblRound2Seed12.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner13 = rand.Next(2)
        ' Display the Winner
        If intWinner13 = 0 Then
            ' 0 means txtseed11 is the winner
            strWinnerOne = txtSeed13.Text
        Else
            ' 1 means txtseed52 is the winner
            strWinnerOne = txtSeed52.Text
        End If
        lblRound2Seed13.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner14 = rand.Next(2)
        ' Display the Winner
        If intWinner14 = 0 Then
            ' 0 means txtseed14 is the winner
            strWinnerOne = txtSeed14.Text
        Else
            ' 1 means txtseed51 is the winner
            strWinnerOne = txtSeed51.Text
        End If
        lblRound2Seed14.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner15 = rand.Next(2)
        ' Display the Winner
        If intWinner15 = 0 Then
            ' 0 means txtseed15 is the winner
            strWinnerOne = txtSeed15.Text
        Else
            ' 1 means txtseed50 is the winner
            strWinnerOne = txtSeed50.Text
        End If
        lblRound2Seed15.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner16 = rand.Next(2)
        ' Display the Winner
        If intWinner16 = 0 Then
            ' 0 means txtseed16 is the winner
            strWinnerOne = txtSeed16.Text
        Else
            ' 1 means txtseed49 is the winner
            strWinnerOne = txtSeed49.Text
        End If
        lblRound2Seed16.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner17 = rand.Next(2)
        ' Display the Winner
        If intWinner17 = 0 Then
            ' 0 means txtseed17 is the winner
            strWinnerOne = txtSeed17.Text
        Else
            ' 1 means txtseed48 is the winner
            strWinnerOne = txtSeed48.Text
        End If
        lblRound2Seed17.Text = strWinnerOne


        'Get a random number in the range of 0 through 1.
        intWinner18 = rand.Next(2)
        ' Display the Winner
        If intWinner18 = 0 Then
            ' 0 means txtseed18 is the winner
            strWinnerOne = txtSeed18.Text
        Else
            ' 1 means txtseed47 is the winner
            strWinnerOne = txtSeed47.Text
        End If
        lblRound2Seed18.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner19 = rand.Next(2)
        ' Display the Winner
        If intWinner19 = 0 Then
            ' 0 means txtseed19 is the winner
            strWinnerOne = txtSeed19.Text
        Else
            ' 1 means txtseed46 is the winner
            strWinnerOne = txtSeed46.Text
        End If
        lblRound2Seed19.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner20 = rand.Next(2)
        ' Display the Winner
        If intWinner20 = 0 Then
            ' 0 means txtseed20 is the winner
            strWinnerOne = txtSeed20.Text
        Else
            ' 1 means txtseed45 is the winner
            strWinnerOne = txtSeed45.Text
        End If
        lblRound2Seed20.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner21 = rand.Next(2)
        ' Display the Winner
        If intWinner21 = 0 Then
            ' 0 means txtseed21 is the winner
            strWinnerOne = txtSeed21.Text
        Else
            ' 1 means txtseed44 is the winner
            strWinnerOne = txtSeed44.Text
        End If
        lblRound2Seed21.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner22 = rand.Next(2)
        ' Display the Winner
        If intWinner22 = 0 Then
            ' 0 means txtseed22 is the winner
            strWinnerOne = txtSeed22.Text
        Else
            ' 1 means txtseed43 is the winner
            strWinnerOne = txtSeed43.Text
        End If
        lblRound2Seed22.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner23 = rand.Next(2)
        ' Display the Winner
        If intWinner23 = 0 Then
            ' 0 means txtseed23 is the winner
            strWinnerOne = txtSeed23.Text
        Else
            ' 1 means txtseed42 is the winner
            strWinnerOne = txtSeed42.Text
        End If
        lblRound2Seed23.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner24 = rand.Next(2)
        ' Display the Winner
        If intWinner24 = 0 Then
            ' 0 means txtseed24 is the winner
            strWinnerOne = txtSeed24.Text
        Else
            ' 1 means txtseed41 is the winner
            strWinnerOne = txtSeed41.Text
        End If
        lblRound2Seed24.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner25 = rand.Next(2)
        ' Display the Winner
        If intWinner25 = 0 Then
            ' 0 means txtseed25 is the winner
            strWinnerOne = txtSeed25.Text
        Else
            ' 1 means txtseed40 is the winner
            strWinnerOne = txtSeed40.Text
        End If
        lblRound2Seed25.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner26 = rand.Next(2)
        ' Display the Winner
        If intWinner26 = 0 Then
            ' 0 means txtseed26 is the winner
            strWinnerOne = txtSeed26.Text
        Else
            ' 1 means txtseed39 is the winner
            strWinnerOne = txtSeed39.Text
        End If
        lblRound2Seed26.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner27 = rand.Next(2)
        ' Display the Winner
        If intWinner27 = 0 Then
            ' 0 means txtseed27 is the winner
            strWinnerOne = txtSeed27.Text
        Else
            ' 1 means txtseed38 is the winner
            strWinnerOne = txtSeed38.Text
        End If
        lblRound2Seed27.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner28 = rand.Next(2)
        ' Display the Winner
        If intWinner28 = 0 Then
            ' 0 means txtseed28 is the winner
            strWinnerOne = txtSeed28.Text
        Else
            ' 1 means txtseed37 is the winner
            strWinnerOne = txtSeed37.Text
        End If
        lblRound2Seed28.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner29 = rand.Next(2)
        ' Display the Winner
        If intWinner29 = 0 Then
            ' 0 means txtseed29 is the winner
            strWinnerOne = txtSeed29.Text
        Else
            ' 1 means txtseed36 is the winner
            strWinnerOne = txtSeed36.Text
        End If
        lblRound2Seed29.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner30 = rand.Next(2)
        ' Display the Winner
        If intWinner30 = 0 Then
            ' 0 means txtseed30 is the winner
            strWinnerOne = txtSeed30.Text
        Else
            ' 1 means txtseed35 is the winner
            strWinnerOne = txtSeed35.Text
        End If
        lblRound2Seed30.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner31 = rand.Next(2)
        ' Display the Winner
        If intWinner31 = 0 Then
            ' 0 means txtseed31 is the winner
            strWinnerOne = txtSeed31.Text
        Else
            ' 1 means txtseed34 is the winner
            strWinnerOne = txtSeed34.Text
        End If
        lblRound2Seed31.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner32 = rand.Next(2)
        ' Display the Winner
        If intWinner32 = 0 Then
            strWinnerOne = txtSeed32.Text
        Else
            strWinnerOne = txtSeed33.Text
        End If
        lblRound2Seed32.Text = strWinnerOne

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Round2.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer
        Dim intWinner3 As Integer
        Dim intWinner4 As Integer
        Dim intWinner5 As Integer
        Dim intWinner6 As Integer
        Dim intWinner7 As Integer
        Dim intWinner8 As Integer
        Dim intWinner9 As Integer
        Dim intWinner10 As Integer
        Dim intWinner11 As Integer
        Dim intWinner12 As Integer
        Dim intWinner13 As Integer
        Dim intWinner14 As Integer
        Dim intWinner15 As Integer
        Dim intWinner16 As Integer

        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String

        For intWinner = 0 To 15
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)
            intWinner3 = rand.Next(2)
            intWinner4 = rand.Next(2)
            intWinner5 = rand.Next(2)
            intWinner6 = rand.Next(2)
            intWinner7 = rand.Next(2)
            intWinner8 = rand.Next(2)
            intWinner9 = rand.Next(2)
            intWinner10 = rand.Next(2)
            intWinner11 = rand.Next(2)
            intWinner12 = rand.Next(2)
            intWinner13 = rand.Next(2)
            intWinner14 = rand.Next(2)
            intWinner15 = rand.Next(2)
            intWinner16 = rand.Next(2)

        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblround2Seed1.Text
        Else
            strWinnerOne = lblRound2Seed32.Text
        End If
        lblR3S1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner2 = rand.Next(2)
        ' Display the Winner
        If intWinner2 = 0 Then
            strWinnerOne = lblRound2Seed17.Text
        Else
            strWinnerOne = lblRound2Seed16.Text
        End If
        lblR3S16.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner3 = rand.Next(2)
        ' Display the Winner
        If intWinner3 = 0 Then
            strWinnerOne = lblRound2Seed17.Text
        Else
            strWinnerOne = lblRound2Seed16.Text
        End If
        lblR3S16.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner4 = rand.Next(2)
        ' Display the Winner
        If intWinner4 = 0 Then
            strWinnerOne = lblRound2Seed9.Text
        Else
            strWinnerOne = lblRound2Seed24.Text
        End If
        lblR3S9.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner5 = rand.Next(2)
        ' Display the Winner
        If intWinner5 = 0 Then
            strWinnerOne = lblRound2Seed25.Text
        Else
            strWinnerOne = lblRound2Seed8.Text
        End If
        lblR3S8.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner6 = rand.Next(2)
        ' Display the Winner
        If intWinner6 = 0 Then
            strWinnerOne = lblRound2Seed4.Text
        Else
            strWinnerOne = lblRound2Seed29.Text
        End If
        lblR3S4.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner7 = rand.Next(2)
        ' Display the Winner
        If intWinner7 = 0 Then
            strWinnerOne = lblRound2Seed20.Text
        Else
            strWinnerOne = lblRound2Seed13.Text
        End If
        lblR3S13.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner8 = rand.Next(2)
        ' Display the Winner
        If intWinner8 = 0 Then
            strWinnerOne = lblRound2Seed12.Text
        Else
            strWinnerOne = lblRound2Seed21.Text
        End If
        lblR3S12.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner9 = rand.Next(2)
        ' Display the Winner
        If intWinner9 = 0 Then
            strWinnerOne = lblRound2Seed28.Text
        Else
            strWinnerOne = lblRound2Seed5.Text
        End If
        lblR3S5.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner10 = rand.Next(2)
        ' Display the Winner
        If intWinner10 = 0 Then
            strWinnerOne = lblround2Seed2.Text
        Else
            strWinnerOne = lblRound2Seed31.Text
        End If
        lblR3S2.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner11 = rand.Next(2)
        ' Display the Winner
        If intWinner11 = 0 Then
            strWinnerOne = lblRound2Seed18.Text
        Else
            strWinnerOne = lblRound2Seed15.Text
        End If
        lblR3S15.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner12 = rand.Next(2)
        ' Display the Winner
        If intWinner12 = 0 Then
            strWinnerOne = lblRound2Seed10.Text
        Else
            strWinnerOne = lblRound2Seed23.Text
        End If
        lblR3S10.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner13 = rand.Next(2)
        ' Display the Winner
        If intWinner13 = 0 Then
            strWinnerOne = lblRound2Seed26.Text
        Else
            strWinnerOne = lblRound2Seed7.Text
        End If
        lblR3S7.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblRound2Seed3.Text
        Else
            strWinnerOne = lblRound2Seed30.Text
        End If
        lblR3S3.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner14 = rand.Next(2)
        ' Display the Winner
        If intWinner14 = 0 Then
            strWinnerOne = lblRound2Seed19.Text
        Else
            strWinnerOne = lblRound2Seed14.Text
        End If
        lblR3S14.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner15 = rand.Next(2)
        ' Display the Winner
        If intWinner15 = 0 Then
            strWinnerOne = lblRound2Seed11.Text
        Else
            strWinnerOne = lblRound2Seed22.Text
        End If
        lblR3S11.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner16 = rand.Next(2)
        ' Display the Winner
        If intWinner16 = 0 Then
            strWinnerOne = lblRound2Seed27.Text
        Else
            strWinnerOne = lblRound2Seed6.Text
        End If
        lblR3S6.Text = strWinnerOne
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Round3.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer
        Dim intWinner3 As Integer
        Dim intWinner4 As Integer
        Dim intWinner5 As Integer
        Dim intWinner6 As Integer
        Dim intWinner7 As Integer
        Dim intWinner8 As Integer

        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String

        For intWinner = 0 To 7
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)
            intWinner3 = rand.Next(2)
            intWinner4 = rand.Next(2)
            intWinner5 = rand.Next(2)
            intWinner6 = rand.Next(2)
            intWinner7 = rand.Next(2)
            intWinner8 = rand.Next(2)

        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR3S1.Text
        Else
            strWinnerOne = lblR3S16.Text
        End If
        lblR4S1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner2 = rand.Next(2)
        ' Display the Winner
        If intWinner2 = 0 Then
            strWinnerOne = lblR3S9.Text
        Else
            strWinnerOne = lblR3S8.Text
        End If
        lblR4S8.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner3 = rand.Next(2)
        ' Display the Winner
        If intWinner3 = 0 Then
            strWinnerOne = lblR3S4.Text
        Else
            strWinnerOne = lblR3S13.Text
        End If
        lblR4S4.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner4 = rand.Next(2)
        ' Display the Winner
        If intWinner4 = 0 Then
            strWinnerOne = lblR3S12.Text
        Else
            strWinnerOne = lblR3S5.Text
        End If
        lblR4S5.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner5 = rand.Next(2)
        ' Display the Winner
        If intWinner5 = 0 Then
            strWinnerOne = lblR3S2.Text
        Else
            strWinnerOne = lblR3S15.Text
        End If
        lblR4S2.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner6 = rand.Next(2)
        ' Display the Winner
        If intWinner6 = 0 Then
            strWinnerOne = lblR3S10.Text
        Else
            strWinnerOne = lblR3S7.Text
        End If
        lblR4S7.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner7 = rand.Next(2)
        ' Display the Winner
        If intWinner7 = 0 Then
            strWinnerOne = lblR3S3.Text
        Else
            strWinnerOne = lblR3S14.Text
        End If
        lblR4S3.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner8 = rand.Next(2)
        ' Display the Winner
        If intWinner8 = 0 Then
            strWinnerOne = lblR3S11.Text
        Else
            strWinnerOne = lblR3S6.Text
        End If
        lblR4S6.Text = strWinnerOne
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Round4.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer
        Dim intWinner3 As Integer
        Dim intWinner4 As Integer

        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String

        For intWinner = 0 To 3
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)
            intWinner3 = rand.Next(2)
            intWinner4 = rand.Next(2)

        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR4S1.Text
        Else
            strWinnerOne = lblR4S8.Text
        End If
        lblR5S1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR4S4.Text
        Else
            strWinnerOne = lblR4S5.Text
        End If
        lblR5S4.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR3S2.Text
        Else
            strWinnerOne = lblR4S7.Text
        End If
        lblR5S2.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR4S3.Text
        Else
            strWinnerOne = lblR4S6.Text
        End If
        lblR5S3.Text = strWinnerOne
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Round5.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer


        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String

        For intWinner = 0 To 1
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)

        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR5S1.Text
        Else
            strWinnerOne = lblR4S4.Text
        End If
        lblR6S1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR5S2.Text
        Else
            strWinnerOne = lblR5S3.Text
        End If
        lblR6S2.Text = strWinnerOne
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Round6.Click
        startSoundSystemWinner.Play()
        Dim intWinner1 As Integer

        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String
        For intWinner = 0 To 1
            intWinner1 = rand.Next(2)

        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            strWinnerOne = lblR6S1.Text
        Else
            strWinnerOne = lblR6S2.Text
        End If
            lblWinner.Text = strWinnerOne
    End Sub
End Class