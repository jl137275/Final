Public Class Rand_32_Team_Bracket

    Private Sub btnRound1_Click(sender As Object, e As EventArgs) Handles btnRound1.Click
        Dim intWinner1 As Integer ' To indicate which team wins
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

        For intWinner = 0 To 3
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
            ' 0 means txtseed1 is the winner
            strWinnerOne = txtSeed1.Text
        Else
            ' 1 means txtseed32 is the winner
            strWinnerOne = txtSeed32.Text
        End If
        lblR2Seed1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner2 = 0 Then
            ' 0 means txtseed2 is the winner
            strWinnerOne = txtSeed2.Text
        Else
            ' 1 means txtseed31 is the winner
            strWinnerOne = txtSeed31.Text
        End If
        lblR2Seed2.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner3 = 0 Then
            ' 0 means txtseed3 is the winner
            strWinnerOne = txtSeed3.Text
        Else
            ' 1 means txtseed30 is the winner
            strWinnerOne = txtSeed30.Text
        End If
        lblR2Seed3.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner4 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed4.Text
        Else
            ' 1 means txtseed29 is the winner
            strWinnerOne = txtSeed29.Text
        End If
        lblR2Seed4.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner5 = 0 Then
            ' 0 means txtseed5 is the winner
            strWinnerOne = txtSeed5.Text
        Else
            ' 1 means txtseed28 is the winner
            strWinnerOne = txtSeed28.Text
        End If
        lblR2Seed5.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner6 = 0 Then
            ' 0 means txtseed6 is the winner
            strWinnerOne = txtSeed6.Text
        Else
            ' 1 means txtseed27 is the winner
            strWinnerOne = txtSeed27.Text
        End If
        lblR2Seed6.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner7 = 0 Then
            ' 0 means txtseed7 is the winner
            strWinnerOne = txtSeed7.Text
        Else
            ' 1 means txtseed26 is the winner
            strWinnerOne = txtSeed26.Text
        End If
        lblR2Seed7.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner8 = 0 Then
            ' 0 means txtseed8 is the winner
            strWinnerOne = txtSeed8.Text
        Else
            ' 1 means txtseed25 is the winner
            strWinnerOne = txtSeed25.Text
        End If
        lblR2Seed8.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner9 = 0 Then
            ' 0 means txtseed9 is the winner
            strWinnerOne = txtSeed9.Text
        Else
            ' 1 means txtseed24 is the winner
            strWinnerOne = txtSeed24.Text
        End If
        lblR2Seed9.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner10 = 0 Then
            ' 0 means txtseed10 is the winner
            strWinnerOne = txtSeed10.Text
        Else
            ' 1 means txtseed23 is the winner
            strWinnerOne = txtSeed23.Text
        End If
        lblR2Seed10.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner11 = 0 Then
            ' 0 means txtseed11 is the winner
            strWinnerOne = txtSeed11.Text
        Else
            ' 1 means txtseed22 is the winner
            strWinnerOne = txtSeed22.Text
        End If
        lblR2Seed11.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner12 = 0 Then
            ' 0 means txtseed12 is the winner
            strWinnerOne = txtSeed12.Text
        Else
            ' 1 means txtseed21 is the winner
            strWinnerOne = txtSeed21.Text
        End If
        lblR2Seed12.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner13 = 0 Then
            ' 0 means txtseed2 is the winner
            strWinnerOne = txtSeed13.Text
        Else
            ' 1 means txtseed20 is the winner
            strWinnerOne = txtSeed20.Text
        End If
        lblR2Seed13.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner14 = 0 Then
            ' 0 means txtseed14 is the winner
            strWinnerOne = txtSeed14.Text
        Else
            ' 1 means txtseed19 is the winner
            strWinnerOne = txtSeed19.Text
        End If
        lblR2Seed14.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner15 = 0 Then
            ' 0 means txtseed15 is the winner
            strWinnerOne = txtSeed15.Text
        Else
            ' 1 means txtseed18 is the winner
            strWinnerOne = txtSeed18.Text
        End If
        lblR2Seed15.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        If intWinner16 = 0 Then
            ' 0 means txtseed16 is the winner
            strWinnerOne = txtSeed16.Text
        Else
            ' 1 means txtseed17 is the winner
            strWinnerOne = txtSeed17.Text
        End If
        lblR2Seed16.Text = strWinnerOne
    End Sub
    Private Sub Round2_Click(sender As Object, e As EventArgs) Handles Round2.Click
        Dim intWinner1 As Integer ' To indicate which team wins
        Dim intWinner2 As Integer '
        Dim intWinner3 As Integer
        Dim intWinner4 As Integer
        Dim intWinner5 As Integer
        Dim intWinner6 As Integer
        Dim intWinner7 As Integer
        Dim intWinner8 As Integer
        Dim rand As New Random ' Random number generator

        Dim strWinnerOne As String
        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            ' 0 means txtseed1 is the winner
            strWinnerOne = txtSeed1.Text
        Else
            ' 1 means txtseed16 is the winner
            strWinnerOne = txtSeed16.Text
        End If
        lblR3Seed1.Text = strWinnerOne

        If intWinner2 = 0 Then
            ' 0 means txtseed2 is the winner
            strWinnerOne = txtSeed2.Text
        Else
            ' 1 means txtseed15 is the winner
            strWinnerOne = txtSeed15.Text
        End If
        lblR3Seed2.Text = strWinnerOne

        If intWinner3 = 0 Then
            ' 0 means txtseed3 is the winner
            strWinnerOne = txtSeed3.Text
        Else
            ' 1 means txtseed14 is the winner
            strWinnerOne = txtSeed14.Text
        End If
        lblR3Seed3.Text = strWinnerOne

        If intWinner4 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed4.Text
        Else
            ' 1 means txtseed13 is the winner
            strWinnerOne = txtSeed13.Text
        End If
        lblR3Seed4.Text = strWinnerOne

        If intWinner5 = 0 Then
            ' 0 means txtseed5 is the winner
            strWinnerOne = txtSeed5.Text
        Else
            ' 1 means txtseed12 is the winner
            strWinnerOne = txtSeed12.Text
        End If
        lblR3Seed5.Text = strWinnerOne

        If intWinner6 = 0 Then
            ' 0 means txtseed6 is the winner
            strWinnerOne = txtSeed6.Text
        Else
            ' 1 means txtseed11 is the winner
            strWinnerOne = txtSeed11.Text
        End If
        lblR3Seed11.Text = strWinnerOne

        If intWinner3 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed3.Text
        Else
            ' 1 means txtseed5 is the winner
            strWinnerOne = txtSeed14.Text
        End If
        lblSeed3R2.Text = strWinnerOne

        If intWinner4 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed7.Text
        Else
            ' 1 means txtseed5 is the winner
            strWinnerOne = txtSeed10.Text
        End If
        lblSeed7R2.Text = strWinnerOne
    End Sub
End Class