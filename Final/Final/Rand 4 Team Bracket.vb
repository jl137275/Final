Public Class Rand_4_Team_Bracket
    Dim startSoundSystemYourALmostThere As New System.Media.SoundPlayer("http://www.pacdv.com/sounds/voices/youre-almost-there.wav")
    Dim startSoundSystemWinner As New System.Media.SoundPlayer("http://static1.grsites.com/archive/sounds/people/people093.wav")
    Private Sub btnRound1_Click(sender As Object, e As EventArgs) Handles btnRound1.Click
        Dim intWinner1 As Integer ' To indicate which team wins
        Dim intWinner2 As Integer
        Dim rand As New Random ' Random number generator


        startSoundSystemYourALmostThere.Play()
        Dim strWinnerOne As String

        For intWinner = 0 To 1
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)
        Next

        'Get a random number in the range of 0 through 1.
        intWinner1 = rand.Next(2)
        ' Display the Winner
        If intWinner1 = 0 Then
            ' 0 means txtseed1 is the winner
            strWinnerOne = txtSeed1.Text
        Else
            ' 1 means txtseed4 is the winner
            strWinnerOne = txtSeed4.Text
        End If
        lblSeed1R2.Text = strWinnerOne

        If intWinner2 = 0 Then
            strWinnerOne = txtSeed2.Text
        Else
            strWinnerOne = txtSeed3.Text
        End If
        lblSeed2R2.Text = strWinnerOne
    End Sub

    Private Sub btnRound2_Click(sender As Object, e As EventArgs) Handles btnRound2.Click
        Dim intWinner1 As Integer

        startSoundSystemWinner.Play()

        Dim rand As New Random
        Dim strWinnerOne As String
        intWinner1 = rand.Next(2)
        If intWinner1 = 0 Then
            strWinnerOne = lblSeed1R2.Text
        Else
            strWinnerOne = lblSeed2R2.Text
        End If
        lblChampion.Text = strWinnerOne
    End Sub
End Class