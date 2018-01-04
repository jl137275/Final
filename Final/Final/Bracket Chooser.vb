Public Class Bracket_Chooser


    Private Sub btn4Team_Click(sender As Object, e As EventArgs) Handles btn4Team.Click
        Dim box = New Rand_4_Team_Bracket
        box.ShowDialog()
    End Sub

    Private Sub btn8Team_Click(sender As Object, e As EventArgs) Handles btn8Team.Click
        Dim box = New Bracket
        box.ShowDialog()
    End Sub

    Private Sub btn16Team_Click(sender As Object, e As EventArgs) Handles btn16Team.Click
        Dim box = New Rand_16_Team_Bracket
        box.ShowDialog()
    End Sub

    Private Sub btn32Team_Click(sender As Object, e As EventArgs) Handles btn32Team.Click
        Dim box = New Rand_32_Team_Bracket
        box.ShowDialog()
    End Sub

    Private Sub btn64Team_Click(sender As Object, e As EventArgs) Handles btn64Team.Click
        Dim box = New Rand_64_Team_Bracket
        box.ShowDialog()
    End Sub
End Class