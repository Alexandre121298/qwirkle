Imports QwirkleLibrary

Public Class FrmMP

    Private Sub FrmMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPhraseIntro.Text = "Bienvenue sur le "

    End Sub
    Private Sub Jouer_Click(sender As Object, e As EventArgs) Handles cmdJouer.Click
        frmMCJ.Show()
        Me.Visible = False

    End Sub

End Class
