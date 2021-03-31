<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JeuEnReseau
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Score = New System.Windows.Forms.GroupBox()
        Me.Help = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltestMF = New System.Windows.Forms.Label()
        Me.lbltestTMF = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.PBEchange = New System.Windows.Forms.PictureBox()
        Me.cmdValidation = New System.Windows.Forms.Button()
        Me.lblJoueurTour = New System.Windows.Forms.Label()
        Me.lblTour = New System.Windows.Forms.Label()
        Me.TLPMainJoueur = New System.Windows.Forms.TableLayoutPanel()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB4 = New System.Windows.Forms.PictureBox()
        Me.PB5 = New System.Windows.Forms.PictureBox()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.PB6 = New System.Windows.Forms.PictureBox()
        Me.cmdMenu = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
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
        Me.Score.Location = New System.Drawing.Point(13, 166)
        Me.Score.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Score.Name = "Score"
        Me.Score.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Score.Size = New System.Drawing.Size(417, 423)
        Me.Score.TabIndex = 7
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
        Me.TLPMainJoueur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TLPMainJoueur.Controls.Add(Me.PB2, 1, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB3, 2, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB4, 3, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB5, 4, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB1, 0, 0)
        Me.TLPMainJoueur.Controls.Add(Me.PB6, 5, 0)
        Me.TLPMainJoueur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLPMainJoueur.Location = New System.Drawing.Point(469, 596)
        Me.TLPMainJoueur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TLPMainJoueur.Name = "TLPMainJoueur"
        Me.TLPMainJoueur.RowCount = 1
        Me.TLPMainJoueur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPMainJoueur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TLPMainJoueur.Size = New System.Drawing.Size(836, 111)
        Me.TLPMainJoueur.TabIndex = 9
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
        'cmdMenu
        '
        Me.cmdMenu.BackColor = System.Drawing.Color.Silver
        Me.cmdMenu.FlatAppearance.BorderSize = 0
        Me.cmdMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMenu.Location = New System.Drawing.Point(13, 619)
        Me.cmdMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMenu.Name = "cmdMenu"
        Me.cmdMenu.Size = New System.Drawing.Size(417, 88)
        Me.cmdMenu.TabIndex = 10
        Me.cmdMenu.Text = "Menu"
        Me.cmdMenu.UseVisualStyleBackColor = False
        '
        'JeuEnReseau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1349, 721)
        Me.Controls.Add(Me.cmdMenu)
        Me.Controls.Add(Me.TLPMainJoueur)
        Me.Controls.Add(Me.Score)
        Me.Name = "JeuEnReseau"
        Me.Text = "Qwirkle"
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Score As GroupBox
    Friend WithEvents Help As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltestMF As Label
    Friend WithEvents lbltestTMF As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdStart As Button
    Friend WithEvents PBEchange As PictureBox
    Friend WithEvents cmdValidation As Button
    Friend WithEvents lblJoueurTour As Label
    Friend WithEvents lblTour As Label
    Friend WithEvents TLPMainJoueur As TableLayoutPanel
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB4 As PictureBox
    Friend WithEvents PB5 As PictureBox
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents PB6 As PictureBox
    Friend WithEvents cmdMenu As Button
End Class
