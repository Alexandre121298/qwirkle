<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFDJ
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdMenu = New System.Windows.Forms.Button()
        Me.lblJ4Score = New System.Windows.Forms.Label()
        Me.lblJ3Score = New System.Windows.Forms.Label()
        Me.lblJ2Score = New System.Windows.Forms.Label()
        Me.lblJ1Score = New System.Windows.Forms.Label()
        Me.lblTitreScore = New System.Windows.Forms.Label()
        Me.lblTitreJoueur = New System.Windows.Forms.Label()
        Me.lblJ4 = New System.Windows.Forms.Label()
        Me.lblJ3 = New System.Windows.Forms.Label()
        Me.PlateauVB = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdValidation = New System.Windows.Forms.Button()
        Me.lblJoueurTour = New System.Windows.Forms.Label()
        Me.lblTour = New System.Windows.Forms.Label()
        Me.lblJ2 = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.GroupBox()
        Me.Help = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltestMF = New System.Windows.Forms.Label()
        Me.lbltestTMF = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.PBEchange = New System.Windows.Forms.PictureBox()
        Me.lblJ1 = New System.Windows.Forms.Label()
        Me.TLPMainJoueur = New System.Windows.Forms.TableLayoutPanel()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB4 = New System.Windows.Forms.PictureBox()
        Me.PB5 = New System.Windows.Forms.PictureBox()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.PB6 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.GroupBox()
        Me.Help_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Score.SuspendLayout()
        Me.Help.SuspendLayout()
        CType(Me.PBEchange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPMainJoueur.SuspendLayout()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Player.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdMenu
        '
        Me.cmdMenu.BackColor = System.Drawing.Color.Silver
        Me.cmdMenu.FlatAppearance.BorderSize = 0
        Me.cmdMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMenu.Location = New System.Drawing.Point(12, 874)
        Me.cmdMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMenu.Name = "cmdMenu"
        Me.cmdMenu.Size = New System.Drawing.Size(417, 88)
        Me.cmdMenu.TabIndex = 9
        Me.cmdMenu.Text = "Menu"
        Me.cmdMenu.UseVisualStyleBackColor = False
        '
        'lblJ4Score
        '
        Me.lblJ4Score.AutoSize = True
        Me.lblJ4Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ4Score.Location = New System.Drawing.Point(320, 357)
        Me.lblJ4Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ4Score.Name = "lblJ4Score"
        Me.lblJ4Score.Size = New System.Drawing.Size(32, 36)
        Me.lblJ4Score.TabIndex = 9
        Me.lblJ4Score.Text = "0"
        '
        'lblJ3Score
        '
        Me.lblJ3Score.AutoSize = True
        Me.lblJ3Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ3Score.Location = New System.Drawing.Point(320, 280)
        Me.lblJ3Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ3Score.Name = "lblJ3Score"
        Me.lblJ3Score.Size = New System.Drawing.Size(32, 36)
        Me.lblJ3Score.TabIndex = 8
        Me.lblJ3Score.Text = "0"
        '
        'lblJ2Score
        '
        Me.lblJ2Score.AutoSize = True
        Me.lblJ2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ2Score.Location = New System.Drawing.Point(320, 198)
        Me.lblJ2Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ2Score.Name = "lblJ2Score"
        Me.lblJ2Score.Size = New System.Drawing.Size(32, 36)
        Me.lblJ2Score.TabIndex = 7
        Me.lblJ2Score.Text = "0"
        '
        'lblJ1Score
        '
        Me.lblJ1Score.AutoSize = True
        Me.lblJ1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ1Score.Location = New System.Drawing.Point(320, 111)
        Me.lblJ1Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ1Score.Name = "lblJ1Score"
        Me.lblJ1Score.Size = New System.Drawing.Size(32, 36)
        Me.lblJ1Score.TabIndex = 6
        Me.lblJ1Score.Text = "0"
        '
        'lblTitreScore
        '
        Me.lblTitreScore.AutoSize = True
        Me.lblTitreScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitreScore.Location = New System.Drawing.Point(240, 34)
        Me.lblTitreScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitreScore.Name = "lblTitreScore"
        Me.lblTitreScore.Size = New System.Drawing.Size(148, 46)
        Me.lblTitreScore.TabIndex = 5
        Me.lblTitreScore.Text = "Score :"
        '
        'lblTitreJoueur
        '
        Me.lblTitreJoueur.AutoSize = True
        Me.lblTitreJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitreJoueur.Location = New System.Drawing.Point(14, 34)
        Me.lblTitreJoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitreJoueur.Name = "lblTitreJoueur"
        Me.lblTitreJoueur.Size = New System.Drawing.Size(164, 46)
        Me.lblTitreJoueur.TabIndex = 4
        Me.lblTitreJoueur.Text = "Joueur :"
        '
        'lblJ4
        '
        Me.lblJ4.AutoSize = True
        Me.lblJ4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ4.Location = New System.Drawing.Point(15, 357)
        Me.lblJ4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ4.Name = "lblJ4"
        Me.lblJ4.Size = New System.Drawing.Size(132, 36)
        Me.lblJ4.TabIndex = 3
        Me.lblJ4.Text = "Joueur 4"
        '
        'lblJ3
        '
        Me.lblJ3.AutoSize = True
        Me.lblJ3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ3.Location = New System.Drawing.Point(15, 280)
        Me.lblJ3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ3.Name = "lblJ3"
        Me.lblJ3.Size = New System.Drawing.Size(132, 36)
        Me.lblJ3.TabIndex = 2
        Me.lblJ3.Text = "Joueur 3"
        '
        'PlateauVB
        '
        Me.PlateauVB.AllowDrop = True
        Me.PlateauVB.BackColor = System.Drawing.Color.White
        Me.PlateauVB.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.PlateauVB.ColumnCount = 20
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.Location = New System.Drawing.Point(460, 15)
        Me.PlateauVB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PlateauVB.Name = "PlateauVB"
        Me.PlateauVB.RowCount = 20
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.PlateauVB.Size = New System.Drawing.Size(836, 805)
        Me.PlateauVB.TabIndex = 7
        '
        'cmdValidation
        '
        Me.cmdValidation.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdValidation.FlatAppearance.BorderSize = 0
        Me.cmdValidation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.cmdValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdValidation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdValidation.Location = New System.Drawing.Point(9, 331)
        Me.cmdValidation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdValidation.Name = "cmdValidation"
        Me.cmdValidation.Size = New System.Drawing.Size(99, 83)
        Me.cmdValidation.TabIndex = 11
        Me.cmdValidation.Text = "Valider"
        Me.cmdValidation.UseVisualStyleBackColor = False
        '
        'lblJoueurTour
        '
        Me.lblJoueurTour.AutoSize = True
        Me.lblJoueurTour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblJoueurTour.Location = New System.Drawing.Point(146, 55)
        Me.lblJoueurTour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueurTour.Name = "lblJoueurTour"
        Me.lblJoueurTour.Size = New System.Drawing.Size(111, 25)
        Me.lblJoueurTour.TabIndex = 10
        Me.lblJoueurTour.Text = "Joueur N°1"
        '
        'lblTour
        '
        Me.lblTour.AutoSize = True
        Me.lblTour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTour.Location = New System.Drawing.Point(111, 8)
        Me.lblTour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTour.Name = "lblTour"
        Me.lblTour.Size = New System.Drawing.Size(180, 46)
        Me.lblTour.TabIndex = 0
        Me.lblTour.Text = "Tour N°1"
        '
        'lblJ2
        '
        Me.lblJ2.AutoSize = True
        Me.lblJ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ2.Location = New System.Drawing.Point(15, 198)
        Me.lblJ2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ2.Name = "lblJ2"
        Me.lblJ2.Size = New System.Drawing.Size(132, 36)
        Me.lblJ2.TabIndex = 1
        Me.lblJ2.Text = "Joueur 2"
        '
        'Score
        '
        Me.Score.BackColor = System.Drawing.Color.Silver
        Me.Score.Controls.Add(Me.Help)
        Me.Score.Controls.Add(Me.cmdStart)
        Me.Score.Controls.Add(Me.PBEchange)
        Me.Score.Controls.Add(Me.cmdValidation)
        Me.Score.Controls.Add(Me.lblJoueurTour)
        Me.Score.Controls.Add(Me.lblTour)
        Me.Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!)
        Me.Score.Location = New System.Drawing.Point(12, 440)
        Me.Score.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Score.Name = "Score"
        Me.Score.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Score.Size = New System.Drawing.Size(417, 423)
        Me.Score.TabIndex = 6
        Me.Score.TabStop = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Help.Controls.Add(Me.Label4)
        Me.Help.Controls.Add(Me.Label3)
        Me.Help.Controls.Add(Me.Label2)
        Me.Help.Controls.Add(Me.Label1)
        Me.Help.Controls.Add(Me.lbltestMF)
        Me.Help.Controls.Add(Me.lbltestTMF)
        Me.Help.Controls.Add(Me.Button1)
        Me.Help.Location = New System.Drawing.Point(14, 86)
        Me.Help.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Help.Name = "Help"
        Me.Help.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Help.Size = New System.Drawing.Size(394, 233)
        Me.Help.TabIndex = 17
        Me.Help.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(75, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Accès  à l'écran de fin :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Coordonnées de dernière tuile posée :"
        '
        'lbltestMF
        '
        Me.lbltestMF.AutoSize = True
        Me.lbltestMF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbltestMF.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltestMF.Location = New System.Drawing.Point(47, 152)
        Me.lbltestMF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltestMF.Name = "lbltestMF"
        Me.lbltestMF.Size = New System.Drawing.Size(86, 25)
        Me.lbltestMF.TabIndex = 10
        Me.lbltestMF.Text = "Colonne"
        '
        'lbltestTMF
        '
        Me.lbltestTMF.AutoSize = True
        Me.lbltestTMF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbltestTMF.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltestTMF.Location = New System.Drawing.Point(217, 152)
        Me.lbltestTMF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltestTMF.Name = "lbltestTMF"
        Me.lbltestTMF.Size = New System.Drawing.Size(60, 25)
        Me.lbltestTMF.TabIndex = 16
        Me.lbltestTMF.Text = "Ligne"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 38)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdStart.Location = New System.Drawing.Point(130, 339)
        Me.cmdStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(152, 66)
        Me.cmdStart.TabIndex = 15
        Me.cmdStart.Text = "Commencer"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'PBEchange
        '
        Me.PBEchange.BackColor = System.Drawing.Color.Maroon
        Me.PBEchange.Location = New System.Drawing.Point(326, 329)
        Me.PBEchange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBEchange.Name = "PBEchange"
        Me.PBEchange.Padding = New System.Windows.Forms.Padding(4, 5, 0, 0)
        Me.PBEchange.Size = New System.Drawing.Size(82, 85)
        Me.PBEchange.TabIndex = 13
        Me.PBEchange.TabStop = False
        '
        'lblJ1
        '
        Me.lblJ1.AutoSize = True
        Me.lblJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblJ1.Location = New System.Drawing.Point(14, 111)
        Me.lblJ1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ1.Name = "lblJ1"
        Me.lblJ1.Size = New System.Drawing.Size(132, 36)
        Me.lblJ1.TabIndex = 0
        Me.lblJ1.Text = "Joueur 1"
        '
        'TLPMainJoueur
        '
        Me.TLPMainJoueur.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLPMainJoueur.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TLPMainJoueur.ColumnCount = 6
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.TLPMainJoueur.Controls.Add(Me.PB2, 1, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB3, 2, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB4, 3, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB5, 4, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB1, 0, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB6, 5, 0)
        Me.TLPMainJoueur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLPMainJoueur.Location = New System.Drawing.Point(460, 851)
        Me.TLPMainJoueur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TLPMainJoueur.Name = "TLPMainJoueur"
        Me.TLPMainJoueur.RowCount = 1
        Me.TLPMainJoueur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPMainJoueur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TLPMainJoueur.Size = New System.Drawing.Size(836, 111)
        Me.TLPMainJoueur.TabIndex = 8
        '
        'PB2
        '
        Me.PB2.Location = New System.Drawing.Point(161, 7)
        Me.PB2.Margin = New System.Windows.Forms.Padding(22, 5, 4, 5)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(90, 92)
        Me.PB2.TabIndex = 1
        Me.PB2.TabStop = False
        '
        'PB3
        '
        Me.PB3.Location = New System.Drawing.Point(298, 7)
        Me.PB3.Margin = New System.Windows.Forms.Padding(22, 5, 4, 5)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(90, 92)
        Me.PB3.TabIndex = 2
        Me.PB3.TabStop = False
        '
        'PB4
        '
        Me.PB4.Location = New System.Drawing.Point(435, 7)
        Me.PB4.Margin = New System.Windows.Forms.Padding(22, 5, 4, 5)
        Me.PB4.Name = "PB4"
        Me.PB4.Size = New System.Drawing.Size(90, 92)
        Me.PB4.TabIndex = 3
        Me.PB4.TabStop = False
        '
        'PB5
        '
        Me.PB5.Location = New System.Drawing.Point(572, 7)
        Me.PB5.Margin = New System.Windows.Forms.Padding(22, 5, 4, 5)
        Me.PB5.Name = "PB5"
        Me.PB5.Size = New System.Drawing.Size(90, 92)
        Me.PB5.TabIndex = 4
        Me.PB5.TabStop = False
        '
        'PB1
        '
        Me.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PB1.Location = New System.Drawing.Point(24, 7)
        Me.PB1.Margin = New System.Windows.Forms.Padding(22, 5, 4, 5)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(90, 92)
        Me.PB1.TabIndex = 0
        Me.PB1.TabStop = False
        '
        'PB6
        '
        Me.PB6.Location = New System.Drawing.Point(709, 7)
        Me.PB6.Margin = New System.Windows.Forms.Padding(22, 5, 4, 5)
        Me.PB6.Name = "PB6"
        Me.PB6.Size = New System.Drawing.Size(90, 92)
        Me.PB6.TabIndex = 5
        Me.PB6.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Silver
        Me.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Player.Controls.Add(Me.lblJ4Score)
        Me.Player.Controls.Add(Me.lblJ3Score)
        Me.Player.Controls.Add(Me.lblJ2Score)
        Me.Player.Controls.Add(Me.lblJ1Score)
        Me.Player.Controls.Add(Me.lblTitreScore)
        Me.Player.Controls.Add(Me.lblTitreJoueur)
        Me.Player.Controls.Add(Me.lblJ4)
        Me.Player.Controls.Add(Me.lblJ3)
        Me.Player.Controls.Add(Me.lblJ2)
        Me.Player.Controls.Add(Me.lblJ1)
        Me.Player.Cursor = System.Windows.Forms.Cursors.Default
        Me.Player.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!)
        Me.Player.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Player.Location = New System.Drawing.Point(12, 15)
        Me.Player.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Player.Name = "Player"
        Me.Player.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Player.Size = New System.Drawing.Size(417, 415)
        Me.Player.TabIndex = 5
        Me.Player.TabStop = False
        '
        'Help_Button
        '
        Me.Help_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Help_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Help_Button.Cursor = System.Windows.Forms.Cursors.Help
        Me.Help_Button.FlatAppearance.BorderSize = 0
        Me.Help_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Help_Button.ForeColor = System.Drawing.Color.Black
        Me.Help_Button.Location = New System.Drawing.Point(1305, 851)
        Me.Help_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(38, 128)
        Me.Help_Button.TabIndex = 10
        Me.Help_Button.TabStop = False
        Me.Help_Button.Text = "?"
        Me.Help_Button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(47, 189)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Couleur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(217, 189)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Forme"
        '
        'frmFDJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1360, 997)
        Me.Controls.Add(Me.Help_Button)
        Me.Controls.Add(Me.cmdMenu)
        Me.Controls.Add(Me.PlateauVB)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.TLPMainJoueur)
        Me.Controls.Add(Me.Player)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmFDJ"
        Me.Text = "Qwirkle - En Jeu"
        Me.Score.ResumeLayout(False)
        Me.Score.PerformLayout()
        Me.Help.ResumeLayout(False)
        Me.Help.PerformLayout()
        CType(Me.PBEchange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPMainJoueur.ResumeLayout(False)
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Player.ResumeLayout(False)
        Me.Player.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdMenu As Button
    Friend WithEvents lblJ4Score As Label
    Friend WithEvents lblJ3Score As Label
    Friend WithEvents lblJ2Score As Label
    Friend WithEvents lblJ1Score As Label
    Friend WithEvents lblTitreScore As Label
    Friend WithEvents lblTitreJoueur As Label
    Friend WithEvents lblJ4 As Label
    Friend WithEvents lblJ3 As Label
    Friend WithEvents PlateauVB As TableLayoutPanel
    Friend WithEvents cmdValidation As Button
    Friend WithEvents lblJoueurTour As Label
    Friend WithEvents lblTour As Label
    Friend WithEvents lblJ2 As Label
    Friend WithEvents Score As GroupBox
    Friend WithEvents lblJ1 As Label
    Friend WithEvents TLPMainJoueur As TableLayoutPanel
    Friend WithEvents Player As GroupBox
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB4 As PictureBox
    Friend WithEvents PB5 As PictureBox
    Friend WithEvents PB6 As PictureBox
    Friend WithEvents PBEchange As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdStart As Button
    Friend WithEvents lbltestMF As Label
    Friend WithEvents lbltestTMF As Label
    Friend WithEvents Help As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Help_Button As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
