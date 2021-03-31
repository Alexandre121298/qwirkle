Imports QwirkleLibrary

Public Class JeuEnReseau
    'initialisation du jeu
    Dim Tour_joueur As Integer = 0
    Dim Tour As Integer = 0 'nombre de tours
    Dim nb_joueurs As Integer = 2 'condidere les 2 premiers joueurs obligatoires
    Dim joueuractuel As Joueur 'indiquera le joueur actuel, pratique pour la récupération de tuiles
    Dim joueuractuel2 As Joueur
    Dim joueuractuel3 As Joueur
    Dim joueuractuel4 As Joueur
    Dim TuileMainChoisi  'numero de la tuile dans la main dont on cherche à placer, pratique pour la récupération de tuiles

    ''Bouton Pour afficher le menu en jeu
    Private Sub BoutonAffichageMenu(sender As Object, e As EventArgs) Handles cmdMenu.Click
        frmMEJ.ShowDialog()
    End Sub

    Private Sub Qwirkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Help.Visible = True
        PB1.AllowDrop = True
        AddHandler PB1.MouseMove, AddressOf PictureBoxT_MouseMove
        PB2.AllowDrop = True
        AddHandler PB2.MouseMove, AddressOf PictureBoxT_MouseMove
        PB3.AllowDrop = True
        AddHandler PB3.MouseMove, AddressOf PictureBoxT_MouseMove
        PB4.AllowDrop = True
        AddHandler PB4.MouseMove, AddressOf PictureBoxT_MouseMove
        PB5.AllowDrop = True
        AddHandler PB5.MouseMove, AddressOf PictureBoxT_MouseMove
        PB6.AllowDrop = True
        AddHandler PB6.MouseMove, AddressOf PictureBoxT_MouseMove
        PBEchange.AllowDrop = True
        PBEchange.Visible = False
        cmdValidation.Visible = False


    End Sub

    Private Sub PictureBoxT_MouseMove(sender As Object, e As MouseEventArgs)
        Dim EffetRealise As DragDropEffects
        Dim picT As PictureBox = sender
        TuileMainChoisi = TLPMainJoueur.GetColumn(sender)
        If e.Button = MouseButtons.Left Then
            picT.AllowDrop = False
            EffetRealise = picT.DoDragDrop(picT.Image, DragDropEffects.Move)
            If EffetRealise = DragDropEffects.Move Then
                picT.Image = Nothing
            End If
            picT.AllowDrop = True
        End If

    End Sub

End Class