Public Class Rand_4_Team_Bracket

    Private Sub btnRound1_Click(sender As Object, e As EventArgs) Handles btnRound1.Click
        Dim intWinner1 As Integer
        Dim intWinner2 As Integer
        Dim rand As New Random
        Dim strWinnerOne As String

        For intWinner = 0 To 1
            intWinner1 = rand.Next(2)
            intWinner2 = rand.Next(2)
        Next
        intWinner1 = rand.Next(2)
        If intWinner1 = 0 Then
            strWinnerOne = txtSeed1.Text
        Else
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

    Private Sub txtSeed1_TextChanged(sender As Object, e As EventArgs) Handles txtSeed1.TextChanged

    End Sub

End Class