Imports QwirkleLibrary

Public Class FrmMP

    Private Sub FrmMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim noma As String
        Randomize()
        noma = Int(4 * Rnd()) + 1
        If noma = 1 Then
            lblPhraseIntro.Text = "Bienvenue sur le "
        ElseIf noma = 2 Then
            lblPhraseIntro.Text = "Tant de couleurs sur le "
        ElseIf noma = 3 Then
            lblPhraseIntro.Text = "Faite top 1 sur le "
        ElseIf noma = 4 Then
            lblPhraseIntro.Text = "This is awesome in the "
        End If

    End Sub
    Private Sub Jouer_Click(sender As Object, e As EventArgs) Handles cmdJouer.Click
        frmMCJ.Show()
        Me.Visible = False

    End Sub
End Class
