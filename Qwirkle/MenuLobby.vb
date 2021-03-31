Public Class MenuLobby
    Private Sub cmdCreateGame_Click(sender As Object, e As EventArgs) Handles cmdCreateGame.Click
        JeuEnReseau.Show()
        Me.Visible = False
    End Sub

    Private Sub cmdJoinGame_Click(sender As Object, e As EventArgs) Handles cmdJoinGame.Click
        JeuEnReseau.Show()
        Me.Visible = False
    End Sub
End Class