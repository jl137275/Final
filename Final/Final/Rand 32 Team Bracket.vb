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
    End Sub
End Class