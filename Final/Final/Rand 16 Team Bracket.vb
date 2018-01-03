Public Class Rand_16_Team_Bracket

	Private Sub btnRound1_Click(sender As Object, e As EventArgs) Handles btnRound1.Click
		Dim in
		    tWinner1 As Integer ' To indicate which team wins
		Dim intWinner2 As Integer '
		Dim intWinner3 As Integer
		Dim intWinner4 As Integer
		Dim intWinner5 As Integer
		Dim intWinner6 As Integer
		Dim intWinner7 As Integer
		Dim intWinner8 As Integer
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

		Next

		'Get a random number in the range of 0 through 1.
		intWinner1 = rand.Next(2)
		' Display the Winner
		If intWinner1 = 0 Then
			' 0 means txtseed1 is the winner
			strWinnerOne = txtSeed1.Text
		Else
			' 1 means txtseed2 is the winner
			strWinnerOne = txtSeed16.Text
		End If
		lblSeed1R2.Text = strWinnerOne

		If intWinner2 = 0 Then
			' 0 means txtseed4 is the winner
			strWinnerOne = txtSeed5.Text
		Else
			' 1 means txtseed5 is the winner
			strWinnerOne = txtSeed12.Text
		End If
		lblSeed5R2.Text = strWinnerOne

		If intWinner3 = 0 Then
			' 0 means txtseed4 is the winner
			strWinnerOne = txtSeed4.Text
		Else
			' 1 means txtseed5 is the winner
			strWinnerOne = txtSeed13.Text
		End If
		lblSeed4R2.Text = strWinnerOne

		If intWinner4 = 0 Then
			' 0 means txtseed4 is the winner
			strWinnerOne = txtSeed8.Text
		Else
			' 1 means txtseed5 is the winner
			strWinnerOne = txtSeed9.Text
		End If
		lblSeed8R2.Text = strWinnerOne

		intWinner5 = rand.Next(2)
		' Display the Winner
		If intWinner1 = 0 Then
			' 0 means txtseed1 is the winner
			strWinnerOne = txtSeed2.Text
		Else
			' 1 means txtseed2 is the winner
			strWinnerOne = txtSeed15.Text
		End If
		lblSeed2R2.Text = strWinnerOne

		If intWinner2 = 0 Then
			' 0 means txtseed4 is the winner
			strWinnerOne = txtSeed6.Text
		Else
			' 1 means txtseed5 is the winner
			strWinnerOne = txtSeed11.Text
		End If
		lblSeed6R2.Text = strWinnerOne

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

	Private Sub btnRound2_Click(sender As Object, e As EventArgs) Handles btnRound2.Click
		Dim intWinner1 As Integer ' To indicate which team wins
		Dim intWinner2 As Integer '
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
			' 0 means txtseed1 is the winner
			strWinnerOne = lblSeed1R2.Text
		Else
				' 1 means lblround2seed4 is the winner
				strWinnerOne = lblSeed5R2.Text
			End If
			lblSeed1R3.Text = strWinnerOne

			'Get a random number in the range of 0 through 1.
			intWinner2 = rand.Next(2)
			' Display the Winner
			If intWinner2 = 0 Then
				' 0 means txtseed1 is the winner
				strWinnerOne = lblSeed4R2.Text
			Else
				' 1 means lblround2seed4 is the winner
				strWinnerOne = lblSeed8R2.Text
			End If
		lblSeed4R3.Text = strWinnerOne
		'Get a random number in the range of 0 through 1.
		intWinner3 = rand.Next(2)
		' Display the Winner
		If intWinner3 = 0 Then
			' 0 means txtseed1 is the winner
			strWinnerOne = lblSeed2R2.Text
		Else
			' 1 means lblround2seed4 is the winner
			strWinnerOne = lblSeed6R2.Text
		End If
		lblSeed2R3.Text = strWinnerOne

		'Get a random number in the range of 0 through 1.
		intWinner4 = rand.Next(2)
		' Display the Winner
		If intWinner4 = 0 Then
			' 0 means txtseed1 is the winner
			strWinnerOne = lblSeed3R2.Text
		Else
			' 1 means lblround2seed4 is the winner
			strWinnerOne = lblSeed7R2.Text
		End If
		lblSeed3R3.Text = strWinnerOne
	End Sub

	Private Sub btnRound3_Click(sender As Object, e As EventArgs) Handles btnRound3.Click
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
			' 0 means txtseed1 is the winner
			strWinnerOne = lblSeed1R3.Text
		Else
			' 1 means lblround2seed4 is the winner
			strWinnerOne = lblSeed4R3.Text
		End If
		lblSeed1R4.Text = strWinnerOne

		'Get a random number in the range of 0 through 1.
		intWinner2 = rand.Next(2)
		' Display the Winner
		If intWinner2 = 0 Then
			' 0 means txtseed1 is the winner
			strWinnerOne = lblSeed2R3.Text
		Else
			' 1 means lblround2seed4 is the winner
			strWinnerOne = lblSeed3R3.Text
		End If
		lblSeed2R4.Text = strWinnerOne
	End Sub

	Private Sub btnRound4_Click(sender As Object, e As EventArgs) Handles btnRound4.Click
		Dim intWinner1 As Integer
		Dim rand As New Random ' Random number generator
		Dim strWinnerOne As String

		'Get a random number in the range of 0 through 1.
		intWinner1 = rand.Next(2)
		' Display the Winner
		If intWinner1 = 0 Then
			' 0 means txtseed1 is the winner
			strWinnerOne = lblSeed1R4.Text
		Else
			' 1 means lblround2seed4 is the winner
			strWinnerOne = lblSeed2R4.Text
		End If
		lblChampion.Text = strWinnerOne
	End Sub
End Class