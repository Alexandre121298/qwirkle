Imports QwirkleLibrary
Public Class frmFDJ

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


        'initialisation de la partie
        Plateau.Init()
        Pioche.Init()
        lblJ3.Text = "" 'on ne sait pas encore si J3 et J4 sont jouables, donc on cache leur champs
        lblJ4.Text = ""
        lblJ3Score.Text = ""
        lblJ4Score.Text = ""

        Plateau.joueur1.SetScore(0)
        Plateau.joueur2.SetScore(0)
        Plateau.joueur3.SetScore(0)
        Plateau.joueur4.SetScore(0)

        lblJ1.Text = Plateau.joueur1.GetName() 'On affiche J1 et J2, puis ensuite on conditionne les joueurs 3 et 4
        lblJ1Score.Text = Plateau.joueur1.GetScore()

        lblJ2.Text = Plateau.joueur2.GetName()
        lblJ2Score.Text = Plateau.joueur2.GetScore()



        If (frmMCJ.cbChoix3J.Checked = True) Or (frmMCJ.cbChoix4J.Checked = True) Then 'marche que si 3 joueurs ont été validés
            Plateau.joueur3.SetName(frmMCJ.txtbNomJ3.Text)
            nb_joueurs = nb_joueurs + 1
            lblJ3.Text = Plateau.joueur3.GetName()
            lblJ3Score.Text = Plateau.joueur3.GetScore()
        End If
        If frmMCJ.cbChoix4J.Checked = True Then 'idem pour 4 joueurs
            Plateau.joueur4.SetName(frmMCJ.txtbNomJ4.Text)
            nb_joueurs = nb_joueurs + 1
            lblJ4.Text = Plateau.joueur4.GetName()
            lblJ4Score.Text = Plateau.joueur4.GetScore()
        End If



        'initialisation du tableau
        Dim coordx, coordy As Integer
        For coordx = 0 To 19
            For coordy = 0 To 19

                Dim pic As New PictureBox
                pic.Size = New Size(30, 30)
                pic.SizeMode = PictureBoxSizeMode.StretchImage
                'pic.BackColor = Color.Aqua
                pic.Name = String.Format("picT{0}_{1}", coordy, coordx)
                pic.AllowDrop = True
                'AddHandler pic.Click, AddressOf pic_click
                PlateauVB.Controls.Add(pic, coordy, coordx)
                'AddHandler TLPMainJoueur.MouseMove, AddressOf PictureBoxT_MouseMove
                AddHandler pic.DragEnter, AddressOf pic_DragEnter
                AddHandler pic.DragDrop, AddressOf pic_DragDrop
            Next
        Next

    End Sub

    Private Sub DébutDePartie(sender As Object, e As EventArgs) Handles cmdStart.Click
        sender.visible = False
        PBEchange.Visible = True
        cmdValidation.Visible = True
        'Plateau.joueur1.AjouterTuileMain() 'initialise la main des joueurs
        'joueuractuel = Plateau.joueur1

        ''deroulement de la partie
        'Plateau.SetPose_Finie(False)
        'Tour_joueur = 1 'Definit le premier tour
        'Label3.Text = Tour_joueur

        'Tour = 1 'le vrai numéro de tour
        'lblTour.Text = String.Format("Tour N°{0}", Tour)
        'lblJoueurTour.Text = Plateau.joueur1.GetName()

        'PB1.Image = Image.FromFile(Plateau.joueur1.GetMain(0).GetPath)
        'PB2.Image = Image.FromFile(Plateau.joueur1.GetMain(1).GetPath)
        'PB3.Image = Image.FromFile(Plateau.joueur1.GetMain(2).GetPath)
        'PB4.Image = Image.FromFile(Plateau.joueur1.GetMain(3).GetPath)
        'PB5.Image = Image.FromFile(Plateau.joueur1.GetMain(4).GetPath)
        'PB6.Image = Image.FromFile(Plateau.joueur1.GetMain(5).GetPath)


        'finir son tour, via le button valider qui incrémentera le tour et donc changera le joueur actuel. Donc pas besoin de le coder ici

    End Sub

    ''le drag and drop


    'bouger les pions
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

    'Permet de bouger les pions sur le tableau
    Private Sub pic_DragEnter(sender As Object, e As DragEventArgs)

        If (e.Data.GetDataPresent(DataFormats.Bitmap)) And (Tour = 1) Then
            e.Effect = DragDropEffects.Move
        Else
            If (e.Data.GetDataPresent(DataFormats.Bitmap)) And (Plateau.ValiderPlacement(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString, joueuractuel.GetMain(TuileMainChoisi)) = True) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        End If

    End Sub

    'poser sur le plateau
    Private Sub pic_DragDrop(sender As Object, e As DragEventArgs)
        If Tour_joueur = 1 Then

            sender.Image = e.Data.GetData(DataFormats.Bitmap) ''Pose l'image de la tuile dans la case du tableau
            joueuractuel.SetScore(Plateau.Score(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString, joueuractuel.GetScore()))
            joueuractuel.PlacerTuile(TuileMainChoisi, PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString)
            lbltestMF.Text = "Colonne " & PlateauVB.GetColumn(sender) ''Recupere la colonne de la derniere tuile posée
            lbltestTMF.Text = "Ligne " & PlateauVB.GetRow(sender)     ''Recupere la ligne de la derniere tuile posée
            'Label4.Text = "Couleur" & Plateau.testretourcouleur(PlateauVB.GetColumn(sender), PlateauVB.GetRow(sender), joueuractuel.GetMain(TuileMainChoisi))
            Label4.Text = "Forme " & Plateau.testretourcouleur(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString, joueuractuel.GetMain(TuileMainChoisi))
            Plateau.SetPose_Finie(True)

        End If
        If Tour_joueur = 2 Then
            sender.Image = e.Data.GetData(DataFormats.Bitmap) ''Pose l'image de la tuile dans la case du tableau
            joueuractuel2.SetScore(Plateau.Score(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString, joueuractuel2.GetScore()))
            joueuractuel2.PlacerTuile(TuileMainChoisi, PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString)

            lbltestMF.Text = "Colonne " & PlateauVB.GetColumn(sender) ''Recupere la colonne de la derniere tuile posée
            lbltestTMF.Text = "Ligne " & PlateauVB.GetRow(sender)     ''Recupere la ligne de la derniere tuile posée
            Label4.Text = "Score " & joueuractuel2.GetScore()
            Plateau.SetPose_Finie(True)
        End If

        If Tour_joueur = 3 Then
            sender.Image = e.Data.GetData(DataFormats.Bitmap) ''Pose l'image de la tuile dans la case du tableau
            'joueuractuel3.SetScore(joueuractuel3.GetScore() + Plateau.Score(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString))
            joueuractuel3.PlacerTuile(TuileMainChoisi, PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString)

            lbltestMF.Text = "Colonne " & PlateauVB.GetColumn(sender) ''Recupere la colonne de la derniere tuile posée
            lbltestTMF.Text = "Ligne " & PlateauVB.GetRow(sender)     ''Recupere la ligne de la derniere tuile posée
            Label4.Text = "Couleur" & Plateau.testretourcouleur(PlateauVB.GetColumn(sender), PlateauVB.GetRow(sender), joueuractuel3.GetMain(TuileMainChoisi))
        End If

        If Tour_joueur = 4 Then
            sender.Image = e.Data.GetData(DataFormats.Bitmap) ''Pose l'image de la tuile dans la case du tableau
            'joueuractuel4.SetScore(joueuractuel4.GetScore() + Plateau.Score(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString))
            joueuractuel4.PlacerTuile(TuileMainChoisi, PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString)

            lbltestMF.Text = "Colonne " & PlateauVB.GetColumn(sender) ''Recupere la colonne de la derniere tuile posée
            lbltestTMF.Text = "Ligne " & PlateauVB.GetRow(sender)     ''Recupere la ligne de la derniere tuile posée
            Label4.Text = "Couleur" & Plateau.testretourcouleur(PlateauVB.GetColumn(sender), PlateauVB.GetRow(sender), joueuractuel4.GetMain(TuileMainChoisi))
        End If
    End Sub

    Private Sub cmdValidation_Click(sender As Object, e As EventArgs) Handles cmdValidation.Click

        Plateau.SetPose_Finie(False)

        If Tour_joueur = nb_joueurs Then 'Permet de faire la rotation des tours
            Tour_joueur = 0
        End If

        Tour_joueur = Tour_joueur + 1
        Tour = Tour + 1 'le vrai numéro de tour
        lblTour.Text = String.Format("Tour N°{0}", Tour)


        If Tour_joueur = 1 Then 'recupere le joueur qui va jouer
            Plateau.joueur1.AjouterTuileMain()

            joueuractuel = Plateau.joueur1
            lblJoueurTour.Text = joueuractuel.GetName()

            'organise si fin de partie ou non
            If Plateau.joueur1.TuilesRestantes() = 0 Then
                frmADFDP.ShowDialog()
                Me.Visible = False
            End If

            PB1.Image = Image.FromFile(joueuractuel.GetMain(0).GetPath())
            PB2.Image = Image.FromFile(joueuractuel.GetMain(1).GetPath())
            PB3.Image = Image.FromFile(joueuractuel.GetMain(2).GetPath())
            PB4.Image = Image.FromFile(joueuractuel.GetMain(3).GetPath())
            PB5.Image = Image.FromFile(joueuractuel.GetMain(4).GetPath())
            PB6.Image = Image.FromFile(joueuractuel.GetMain(5).GetPath())


            'finir son tour, via le button valider qui mettra le paramètre pose finie sur true. Donc pas besoin de la code ici
        End If



        If Tour_joueur = 2 Then 'recupere le joueur qui va jouer

            Plateau.joueur2.AjouterTuileMain() 'organise si fin de partie ou non

            joueuractuel2 = Plateau.joueur2
            lblJoueurTour.Text = joueuractuel2.GetName()

            If Plateau.joueur2.TuilesRestantes() = 0 Then
                frmADFDP.ShowDialog()
                Me.Visible = False
            End If

            PB1.Image = Image.FromFile(joueuractuel2.GetMain(0).GetPath())
            PB2.Image = Image.FromFile(joueuractuel2.GetMain(1).GetPath())
            PB3.Image = Image.FromFile(joueuractuel2.GetMain(2).GetPath())
            PB4.Image = Image.FromFile(joueuractuel2.GetMain(3).GetPath())
            PB5.Image = Image.FromFile(joueuractuel2.GetMain(4).GetPath())
            PB6.Image = Image.FromFile(joueuractuel2.GetMain(5).GetPath())

            'finir son tour, via le button valider qui mettra le paramètre pose finie sur true. Donc pas besoin de la code ici

        End If

        'Faire pour le joueur 3 & 4

        lblJ1Score.Text = Plateau.joueur1.GetScore()
        lblJ2Score.Text = Plateau.joueur2.GetScore()
        Label3.Text = "Tour_J: " & Tour_joueur
    End Sub
End Class