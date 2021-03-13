Imports QwirkleLibrary

Public Class frmADFDP
    Private Sub frmADFDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.giphy

        Dim gagnant As New Joueur("Personne", 10) 'indiquera qui sera designé vainqueur de la partie
        If Plateau.joueur1.GetScore() > gagnant.GetScore() Then
            gagnant = Plateau.joueur1
        End If
        If Plateau.joueur2.GetScore() > gagnant.GetScore() Then
            gagnant = Plateau.joueur2
        End If
        If Plateau.joueur3.GetScore() > gagnant.GetScore() Then
            gagnant = Plateau.joueur3
        End If
        If Plateau.joueur4.GetScore() > gagnant.GetScore() Then
            gagnant = Plateau.joueur4
        End If
        lblJoueurGagnant.Text = String.Format("{0},
avec un score de {1}", gagnant.GetName(), gagnant.GetScore())

    End Sub

    Private Sub RetourMenuPrincipal(sender As Object, e As EventArgs) Handles cmdMenuPrincipal.Click
        FrmMP.Show()
        Me.Visible = False
        FrmMP.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class