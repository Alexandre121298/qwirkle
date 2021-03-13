Imports QwirkleLibrary

Public Class frmMCJ
    Public nomJ1 As String
    Public nomJ2 As String
    Public nomJ3 As String
    Public nomJ4 As String
    Public nbJoueur As Integer
    Private Sub Joueur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIndicJ2.Visible = False
        lblIndicJ3.Visible = False
        lblIndicJ4.Visible = False
        txtbNomJ2.Visible = False
        txtbNomJ3.Visible = False
        txtbNomJ4.Visible = False
        cbChoix2J.Checked = True
    End Sub

    Private Sub J2_CheckedChanged(sender As Object, e As EventArgs) Handles cbChoix2J.CheckedChanged
        lblIndicJ2.Visible = True
        txtbNomJ2.Visible = True
        If txtbNomJ3.Visible = True Or txtbNomJ4.Visible = True Then
            txtbNomJ3.Visible = False
            lblIndicJ3.Visible = False
            txtbNomJ4.Visible = False
            lblIndicJ4.Visible = False
        End If
        nbJoueur = 2
    End Sub

    Private Sub J3_CheckedChanged(sender As Object, e As EventArgs) Handles cbChoix3J.CheckedChanged
        lblIndicJ3.Visible = True
        txtbNomJ3.Visible = True
        If txtbNomJ4.Visible Then
            txtbNomJ4.Visible = False
            lblIndicJ4.Visible = False
        End If
        lblIndicJ2.Visible = True
        txtbNomJ2.Visible = True
        nbJoueur = 3
    End Sub

    Private Sub J4_CheckedChanged(sender As Object, e As EventArgs) Handles cbChoix4J.CheckedChanged
        lblIndicJ4.Visible = True
        txtbNomJ4.Visible = True
        lblIndicJ3.Visible = True
        txtbNomJ3.Visible = True
        lblIndicJ2.Visible = True
        txtbNomJ2.Visible = True
        nbJoueur = 4
    End Sub


    Private Sub Retour_Click(sender As Object, e As EventArgs) Handles cmdRetourMenu.Click
        FrmMP.Visible = True
        Close()
    End Sub

    Private Sub PartieJeux_Click(sender As Object, e As EventArgs) Handles cmdCommencerPartie.Click
        nomJ1 = txtbNomJ1.Text
        nomJ2 = txtbNomJ2.Text
        nomJ3 = txtbNomJ3.Text
        nomJ4 = txtbNomJ4.Text
        Plateau.joueur1.SetName(txtbNomJ1.Text)
        Plateau.joueur2.SetName(txtbNomJ2.Text)
        Plateau.joueur3.SetName(txtbNomJ3.Text)
        Plateau.joueur4.SetName(txtbNomJ4.Text)


        If nbJoueur = 2 Then
            If nomJ1 = "" Or nomJ2 = "" Then
                MessageBox.Show("Nom joueur est vide !!")
            Else
                frmFDJ.Show()
                Close()
            End If
        ElseIf nbJoueur = 3 Then
            If nomJ1 = "" Or nomJ2 = "" Or nomJ3 = "" Then
                MessageBox.Show("Nom joueur est vide !!")
            Else
                frmFDJ.Show()
                Close()
            End If
        ElseIf nbJoueur = 4 Then
            If nomJ1 = "" Or nomJ2 = "" Or nomJ3 = "" Or nomJ4 = "" Then
                MessageBox.Show("Nom joueur est vide !!")
            Else
                frmFDJ.Show()
                Close()
            End If
        End If

    End Sub
End Class