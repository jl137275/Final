Public Class Bracket
    Dim startSoundSystemNiceWork As New System.Media.SoundPlayer("http://www.pacdv.com/sounds/voices/nice-work.wav")
    Dim startSoundSystemYourALmostThere As New System.Media.SoundPlayer("http://www.pacdv.com/sounds/voices/youre-almost-there.wav")
    Dim startSoundSystemWinner As New System.Media.SoundPlayer("http://static1.grsites.com/archive/sounds/people/people093.wav")
    Private Sub btnRound1_Click(sender As Object, e As EventArgs) Handles btnRound1.Click

        Dim intWinner1 As Integer ' To indicate which team wins
        Dim intWinner2 As Integer
        Dim intWinner3 As Integer
        Dim intWinner4 As Integer

        startSoundSystemNiceWork.Play()

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
            ' 0 means txtseed1 is the winner
            strWinnerOne = txtSeed1.Text
        Else
            ' 1 means txtseed8 is the winner
            strWinnerOne = txtSeed8.Text
        End If
        lblRound2Seed1.Text = strWinnerOne

        If intWinner2 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed4.Text
        Else
            ' 1 means txtseed5 is the winner
            strWinnerOne = txtSeed5.Text
        End If
        lblRound2Seed4.Text = strWinnerOne

        If intWinner3 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed2.Text
        Else
            ' 1 means txtseed5 is the winner
            strWinnerOne = txtSeed7.Text
        End If
        lblRound2Seed2.Text = strWinnerOne

        If intWinner4 = 0 Then
            ' 0 means txtseed4 is the winner
            strWinnerOne = txtSeed3.Text
        Else
            ' 1 means txtseed5 is the winner
            strWinnerOne = txtSeed6.Text
        End If
        lblRound2Seed3.Text = strWinnerOne
    End Sub

    Private Sub btnRound2_Click(sender As Object, e As EventArgs) Handles btnRound2.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer

        startSoundSystemYourALmostThere.Play()

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
            ' 0 means lblround2seed1 is the winner
            strWinnerOne = lblRound2Seed1.Text
        Else
            ' 1 means lblround2seed4 is the winner
            strWinnerOne = lblRound2Seed4.Text
        End If
        lblRound3Seed1.Text = strWinnerOne

        'Get a random number in the range of 0 through 1.
        intWinner2 = rand.Next(2)
        ' Display the Winner
        If intWinner2 = 0 Then
            ' 0 means lblround2seed2 is the winner
            strWinnerOne = lblRound2Seed2.Text
        Else
            ' 1 means lblround2seed3 is the winner
            strWinnerOne = lblRound2Seed3.Text
        End If
        lblround3Seed2.Text = strWinnerOne
    End Sub
    Private Sub btnRound3_Click(sender As Object, e As EventArgs) Handles btnRound3.Click
        Dim intWinner1 As Integer

        startSoundSystemWinner.Play()

        Dim rand As New Random ' Random number generator
        Dim strWinnerOne As String

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            ' 0 means lblround3seed1 is the winner
            strWinnerOne = lblRound3Seed1.Text
        Else
            ' 1 means lblround3seed2 is the winner
            strWinnerOne = lblround3Seed2.Text
        End If
        lblChampion.Text = strWinnerOne
    End Sub
End Class