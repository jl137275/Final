Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStart.Parent = picSports
        lblWelcome.Parent = picSports
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Box = New Bracket
        Box.Show()
    End Sub
End Class
