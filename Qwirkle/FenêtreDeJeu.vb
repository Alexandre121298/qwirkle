Imports QwirkleLibrary
Public Class frmFDJ

    'initialisation du jeu

    Dim Tour_joueur As Integer = 0
    Dim Tour As Integer = 0 'nombre de tours
    Dim nb_joueurs As Integer = 2 'condidere les 2 premiers joueurs obligatoires
    Dim joueuractuel As Joueur 'indiquera le joueur actuel, pratique pour la récupération de tuiles
    Dim TuileMainChoisi = 0 'numero de la tuile dans la main dont on cherche à placer, pratique pour la récupération de tuiles

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



    'le drag and drop


    'bouger les pions
    Private Sub PictureBoxT_MouseMove(sender As Object, e As MouseEventArgs)
        Dim EffetRealise As DragDropEffects
        Dim picT As PictureBox = sender
        If e.Button = MouseButtons.Left Then
            picT.AllowDrop = False
            EffetRealise = picT.DoDragDrop(picT.Image, DragDropEffects.Move)
            If EffetRealise = DragDropEffects.Move Then
                TuileMainChoisi = TLPMainJoueur.GetColumn(sender)
                picT.Image = Nothing
            End If
            picT.AllowDrop = True
        End If

    End Sub


    'poser sur le plateau
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


    Private Sub pic_DragDrop(sender As Object, e As DragEventArgs)
        sender.Image = e.Data.GetData(DataFormats.Bitmap)
        joueuractuel.SetScore(joueuractuel.GetScore() + Plateau.CalculScore(PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString))
        joueuractuel.PlacerTuile(TuileMainChoisi, PlateauVB.GetColumn(sender).ToString, PlateauVB.GetRow(sender).ToString)
        Plateau.SetPose_Finie(True)
        lbltestMF.Text = "Colonne " & PlateauVB.GetColumn(sender)
        lbltestTMF.Text = "Ligne " & PlateauVB.GetRow(sender)

    End Sub


    'poser dans le swap
    Private Sub PBEchange_DragEnter(sender As Object, e As DragEventArgs) Handles PBEchange.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub PBEchange_DragDrop(sender As Object, e As DragEventArgs) Handles PBEchange.DragDrop
        sender.Image = e.Data.GetData(DataFormats.Bitmap)
        Echange.SetSwap(joueuractuel.GetMain(TuileMainChoisi))
        joueuractuel.EnleverTuileMain(TuileMainChoisi)
    End Sub



    'boutons
    Private Sub BoutonAffichageMenu(sender As Object, e As EventArgs) Handles cmdMenu.Click
        frmMEJ.ShowDialog()
    End Sub

    Private Sub ValidationTour(sender As Object, e As EventArgs) Handles cmdValidation.Click

        'réinitialisation du swap
        Echange.ValiderSwap()
        PBEchange.Image = Nothing

        If Tour_joueur = nb_joueurs Then
            Tour_joueur = 1
        End If
        Plateau.SetPose_Finie(False)


        If Plateau.joueur1.GetOrdre_Tour() = Tour_joueur Then 'recupere le joueur qui va jouer

            If nb_joueurs = 2 Then
                lblJ2Score.Text = Plateau.joueur2.GetScore()
                Plateau.joueur2 = joueuractuel
            Else
                If nb_joueurs = 3 Then
                    lblJ3Score.Text = Plateau.joueur3.GetScore()
                    Plateau.joueur3 = joueuractuel
                Else
                    If nb_joueurs = 4 Then
                        lblJ4Score.Text = Plateau.joueur4.GetScore()
                        Plateau.joueur4 = joueuractuel
                    End If
                End If
            End If

            joueuractuel = Plateau.joueur1

            Plateau.joueur1.AjouterTuileMain() 'organise si fin de partie ou non
            If Plateau.joueur1.TuilesRestantes() = 0 Then

                frmADFDP.ShowDialog()
                Me.Visible = False
            End If


            Tour = Tour + 1 'le vrai numéro de tour
            lblTour.Text = String.Format("Tour N°{0}", Tour)
            lblJoueurTour.Text = Plateau.joueur1.GetName()

            PB1.Image = Image.FromFile(Plateau.joueur1.GetMain(0).GetPath())
            PB2.Image = Image.FromFile(Plateau.joueur1.GetMain(1).GetPath())
            PB3.Image = Image.FromFile(Plateau.joueur1.GetMain(2).GetPath())
            PB4.Image = Image.FromFile(Plateau.joueur1.GetMain(3).GetPath())
            PB5.Image = Image.FromFile(Plateau.joueur1.GetMain(4).GetPath())
            PB6.Image = Image.FromFile(Plateau.joueur1.GetMain(5).GetPath())

            'finir son tour, via le button valider qui mettra le paramètre pose finie sur true. Donc pas besoin de la code ici


        End If





        If Plateau.joueur2.GetOrdre_Tour() = Tour_joueur Then 'recupere le joueur qui va jouer

            lblJ1Score.Text = Plateau.joueur1.GetScore()
            Plateau.joueur1 = joueuractuel
            joueuractuel = Plateau.joueur2

            Plateau.joueur2.AjouterTuileMain() 'organise si fin de partie ou non
            If Plateau.joueur2.TuilesRestantes() = 0 Then

                frmADFDP.ShowDialog()
                Me.Visible = False
            End If
            Plateau.joueur1 = joueuractuel
            joueuractuel = Plateau.joueur2

            Tour = Tour  'le vrai numéro de tour
            lblTour.Text = String.Format("Tour N°{0}", Tour)
            lblJoueurTour.Text = Plateau.joueur2.GetName()

            PB1.Image = Image.FromFile(Plateau.joueur2.GetMain(0).GetPath)
            PB2.Image = Image.FromFile(Plateau.joueur2.GetMain(1).GetPath)
            PB3.Image = Image.FromFile(Plateau.joueur2.GetMain(2).GetPath)
            PB4.Image = Image.FromFile(Plateau.joueur2.GetMain(3).GetPath)
            PB5.Image = Image.FromFile(Plateau.joueur2.GetMain(4).GetPath)
            PB6.Image = Image.FromFile(Plateau.joueur2.GetMain(5).GetPath)

            'finir son tour, via le button valider qui mettra le paramètre pose finie sur true. Donc pas besoin de la code ici

        End If






        If Plateau.joueur3.GetOrdre_Tour() = Tour_joueur Then 'recupere le joueur qui va jouer

            lblJ2Score.Text = Plateau.joueur2.GetScore()
            Plateau.joueur2 = joueuractuel
            joueuractuel = Plateau.joueur3

            Plateau.joueur3.AjouterTuileMain() 'organise si fin de partie ou non
            If Plateau.joueur3.TuilesRestantes() = 0 Then

                frmADFDP.ShowDialog()
                Me.Visible = False
            End If


            Tour = Tour  'le vrai numéro de tour
            lblTour.Text = String.Format("Tour N°{0}", Tour)
            lblJoueurTour.Text = Plateau.joueur3.GetName()

            PB1.Image = Image.FromFile(Plateau.joueur3.GetMain(0).GetPath)
            PB2.Image = Image.FromFile(Plateau.joueur3.GetMain(1).GetPath)
            PB3.Image = Image.FromFile(Plateau.joueur3.GetMain(2).GetPath)
            PB4.Image = Image.FromFile(Plateau.joueur3.GetMain(3).GetPath)
            PB5.Image = Image.FromFile(Plateau.joueur3.GetMain(4).GetPath)
            PB6.Image = Image.FromFile(Plateau.joueur3.GetMain(5).GetPath)

            'finir son tour, via le button valider qui mettra le paramètre pose finie sur true. Donc pas besoin de la code ici
        End If






        If Plateau.joueur4.GetOrdre_Tour() = Tour_joueur Then 'recupere le joueur qui va jouer

            lblJ3Score.Text = Plateau.joueur3.GetScore()
            Plateau.joueur3 = joueuractuel
            joueuractuel = Plateau.joueur4

            Plateau.joueur4.AjouterTuileMain() 'organise si fin de partie ou non
            If Plateau.joueur4.TuilesRestantes() = 0 Then
                frmADFDP.ShowDialog()
                Me.Visible = False
            End If


            Tour = Tour  'le vrai numéro de tour
            lblTour.Text = String.Format("Tour N°{0}", Tour)
            lblJoueurTour.Text = Plateau.joueur4.GetName()

            PB1.Image = Image.FromFile(Plateau.joueur4.GetMain(0).GetPath)
            PB2.Image = Image.FromFile(Plateau.joueur4.GetMain(1).GetPath)
            PB3.Image = Image.FromFile(Plateau.joueur4.GetMain(2).GetPath)
            PB4.Image = Image.FromFile(Plateau.joueur4.GetMain(3).GetPath)
            PB5.Image = Image.FromFile(Plateau.joueur4.GetMain(4).GetPath)
            PB6.Image = Image.FromFile(Plateau.joueur4.GetMain(5).GetPath)

            'finir son tour, via le button valider qui mettra le paramètre pose finie sur true. Donc pas besoin de la code ici
        End If


        Tour_joueur = Tour_joueur + 1

    End Sub

    Private Sub Test_Fin(sender As Object, e As EventArgs) Handles Button1.Click
        frmADFDP.ShowDialog()
        Me.Visible = False
    End Sub

    Private Sub DébutDePartie(sender As Object, e As EventArgs) Handles cmdStart.Click

        sender.visible = False
        PBEchange.Visible = True
        cmdValidation.Visible = True
        Plateau.joueur1.AjouterTuileMain() 'initialise la main des joueurs
        joueuractuel = Plateau.joueur1


        'deroulement de la partie
        Plateau.SetPose_Finie(False)
        Tour_joueur = Tour_joueur + 1 'permet de tourner sur les différents joueurs

        Tour = Tour + 1 'le vrai numéro de tour
        lblTour.Text = String.Format("Tour N°{0}", Tour)
        lblJoueurTour.Text = Plateau.joueur1.GetName()

        PB1.Image = Image.FromFile(Plateau.joueur1.GetMain(0).GetPath)
        PB2.Image = Image.FromFile(Plateau.joueur1.GetMain(1).GetPath)
        PB3.Image = Image.FromFile(Plateau.joueur1.GetMain(2).GetPath)
        PB4.Image = Image.FromFile(Plateau.joueur1.GetMain(3).GetPath)
        PB5.Image = Image.FromFile(Plateau.joueur1.GetMain(4).GetPath)
        PB6.Image = Image.FromFile(Plateau.joueur1.GetMain(5).GetPath)

        'finir son tour, via le button valider qui incrémentera le tour et donc changera le joueur actuel. Donc pas besoin de le coder ici

    End Sub

    Private Sub Aide(sender As Object, e As EventArgs) Handles Help_Button.Click 'petite aide si problèmes

        If Help.Visible = False Then
            Help.Visible = True
        Else
            Help.Visible = False
        End If

    End Sub


End Class