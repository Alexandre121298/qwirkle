<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCJ
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
        Me.lblTitreQwirkle = New System.Windows.Forms.Label()
        Me.lblChoixJ = New System.Windows.Forms.Label()
        Me.lblIndicJ4 = New System.Windows.Forms.Label()
        Me.lblIndicJ3 = New System.Windows.Forms.Label()
        Me.lblIndicJ2 = New System.Windows.Forms.Label()
        Me.lblIndicJ1 = New System.Windows.Forms.Label()
        Me.cmdRetourMenu = New System.Windows.Forms.Button()
        Me.cmdCommencerPartie = New System.Windows.Forms.Button()
        Me.cbChoix4J = New System.Windows.Forms.RadioButton()
        Me.cbChoix3J = New System.Windows.Forms.RadioButton()
        Me.cbChoix2J = New System.Windows.Forms.RadioButton()
        Me.txtbNomJ4 = New System.Windows.Forms.TextBox()
        Me.txtbNomJ3 = New System.Windows.Forms.TextBox()
        Me.txtbNomJ2 = New System.Windows.Forms.TextBox()
        Me.txtbNomJ1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitreQwirkle
        '
        Me.lblTitreQwirkle.AutoSize = True
        Me.lblTitreQwirkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitreQwirkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreQwirkle.ForeColor = System.Drawing.Color.White
        Me.lblTitreQwirkle.Location = New System.Drawing.Point(12, 33)
        Me.lblTitreQwirkle.Name = "lblTitreQwirkle"
        Me.lblTitreQwirkle.Size = New System.Drawing.Size(277, 61)
        Me.lblTitreQwirkle.TabIndex = 15
        Me.lblTitreQwirkle.Text = "QWIRKLE"
        '
        'lblChoixJ
        '
        Me.lblChoixJ.AutoSize = True
        Me.lblChoixJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblChoixJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblChoixJ.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChoixJ.Location = New System.Drawing.Point(17, 122)
        Me.lblChoixJ.Name = "lblChoixJ"
        Me.lblChoixJ.Size = New System.Drawing.Size(279, 31)
        Me.lblChoixJ.TabIndex = 16
        Me.lblChoixJ.Text = "Nombres de joueurs ?"
        '
        'lblIndicJ4
        '
        Me.lblIndicJ4.AutoSize = True
        Me.lblIndicJ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIndicJ4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicJ4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIndicJ4.Location = New System.Drawing.Point(18, 355)
        Me.lblIndicJ4.Name = "lblIndicJ4"
        Me.lblIndicJ4.Size = New System.Drawing.Size(139, 25)
        Me.lblIndicJ4.TabIndex = 20
        Me.lblIndicJ4.Text = "Nom joueur 4 :"
        '
        'lblIndicJ3
        '
        Me.lblIndicJ3.AutoSize = True
        Me.lblIndicJ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIndicJ3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIndicJ3.Location = New System.Drawing.Point(18, 308)
        Me.lblIndicJ3.Name = "lblIndicJ3"
        Me.lblIndicJ3.Size = New System.Drawing.Size(139, 25)
        Me.lblIndicJ3.TabIndex = 19
        Me.lblIndicJ3.Text = "Nom joueur 3 :"
        '
        'lblIndicJ2
        '
        Me.lblIndicJ2.AutoSize = True
        Me.lblIndicJ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIndicJ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicJ2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIndicJ2.Location = New System.Drawing.Point(18, 254)
        Me.lblIndicJ2.Name = "lblIndicJ2"
        Me.lblIndicJ2.Size = New System.Drawing.Size(139, 25)
        Me.lblIndicJ2.TabIndex = 18
        Me.lblIndicJ2.Text = "Nom joueur 2 :"
        '
        'lblIndicJ1
        '
        Me.lblIndicJ1.AutoSize = True
        Me.lblIndicJ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIndicJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicJ1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIndicJ1.Location = New System.Drawing.Point(18, 201)
        Me.lblIndicJ1.Name = "lblIndicJ1"
        Me.lblIndicJ1.Size = New System.Drawing.Size(139, 25)
        Me.lblIndicJ1.TabIndex = 17
        Me.lblIndicJ1.Text = "Nom joueur 1 :"
        '
        'cmdRetourMenu
        '
        Me.cmdRetourMenu.BackColor = System.Drawing.Color.Red
        Me.cmdRetourMenu.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.cmdRetourMenu.FlatAppearance.BorderSize = 0
        Me.cmdRetourMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.cmdRetourMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.cmdRetourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRetourMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdRetourMenu.Location = New System.Drawing.Point(23, 394)
        Me.cmdRetourMenu.Name = "cmdRetourMenu"
        Me.cmdRetourMenu.Size = New System.Drawing.Size(144, 44)
        Me.cmdRetourMenu.TabIndex = 34
        Me.cmdRetourMenu.Text = "Retour à l'écran titre"
        Me.cmdRetourMenu.UseVisualStyleBackColor = False
        '
        'cmdCommencerPartie
        '
        Me.cmdCommencerPartie.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdCommencerPartie.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.cmdCommencerPartie.FlatAppearance.BorderSize = 0
        Me.cmdCommencerPartie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.cmdCommencerPartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCommencerPartie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCommencerPartie.Location = New System.Drawing.Point(606, 394)
        Me.cmdCommencerPartie.Name = "cmdCommencerPartie"
        Me.cmdCommencerPartie.Size = New System.Drawing.Size(144, 44)
        Me.cmdCommencerPartie.TabIndex = 33
        Me.cmdCommencerPartie.Text = "Commencer"
        Me.cmdCommencerPartie.UseVisualStyleBackColor = False
        '
        'cbChoix4J
        '
        Me.cbChoix4J.AutoSize = True
        Me.cbChoix4J.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChoix4J.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbChoix4J.Location = New System.Drawing.Point(493, 153)
        Me.cbChoix4J.Name = "cbChoix4J"
        Me.cbChoix4J.Size = New System.Drawing.Size(110, 29)
        Me.cbChoix4J.TabIndex = 31
        Me.cbChoix4J.Text = "4 joueurs"
        Me.cbChoix4J.UseVisualStyleBackColor = True
        '
        'cbChoix3J
        '
        Me.cbChoix3J.AutoSize = True
        Me.cbChoix3J.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChoix3J.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbChoix3J.Location = New System.Drawing.Point(324, 153)
        Me.cbChoix3J.Name = "cbChoix3J"
        Me.cbChoix3J.Size = New System.Drawing.Size(110, 29)
        Me.cbChoix3J.TabIndex = 30
        Me.cbChoix3J.Text = "3 joueurs"
        Me.cbChoix3J.UseVisualStyleBackColor = True
        '
        'cbChoix2J
        '
        Me.cbChoix2J.AutoSize = True
        Me.cbChoix2J.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChoix2J.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbChoix2J.Location = New System.Drawing.Point(403, 118)
        Me.cbChoix2J.Name = "cbChoix2J"
        Me.cbChoix2J.Size = New System.Drawing.Size(110, 29)
        Me.cbChoix2J.TabIndex = 29
        Me.cbChoix2J.Text = "2 joueurs"
        Me.cbChoix2J.UseVisualStyleBackColor = True
        '
        'txtbNomJ4
        '
        Me.txtbNomJ4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtbNomJ4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbNomJ4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNomJ4.ForeColor = System.Drawing.SystemColors.Window
        Me.txtbNomJ4.Location = New System.Drawing.Point(174, 355)
        Me.txtbNomJ4.Name = "txtbNomJ4"
        Me.txtbNomJ4.Size = New System.Drawing.Size(429, 23)
        Me.txtbNomJ4.TabIndex = 28
        Me.txtbNomJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbNomJ3
        '
        Me.txtbNomJ3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtbNomJ3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbNomJ3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNomJ3.ForeColor = System.Drawing.SystemColors.Window
        Me.txtbNomJ3.Location = New System.Drawing.Point(174, 308)
        Me.txtbNomJ3.Name = "txtbNomJ3"
        Me.txtbNomJ3.Size = New System.Drawing.Size(429, 23)
        Me.txtbNomJ3.TabIndex = 27
        Me.txtbNomJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbNomJ2
        '
        Me.txtbNomJ2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtbNomJ2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbNomJ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNomJ2.ForeColor = System.Drawing.SystemColors.Window
        Me.txtbNomJ2.Location = New System.Drawing.Point(174, 254)
        Me.txtbNomJ2.Name = "txtbNomJ2"
        Me.txtbNomJ2.Size = New System.Drawing.Size(429, 23)
        Me.txtbNomJ2.TabIndex = 26
        Me.txtbNomJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbNomJ1
        '
        Me.txtbNomJ1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtbNomJ1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbNomJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNomJ1.ForeColor = System.Drawing.SystemColors.Window
        Me.txtbNomJ1.Location = New System.Drawing.Point(174, 201)
        Me.txtbNomJ1.Name = "txtbNomJ1"
        Me.txtbNomJ1.Size = New System.Drawing.Size(429, 23)
        Me.txtbNomJ1.TabIndex = 25
        Me.txtbNomJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMCJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.cmdRetourMenu)
        Me.Controls.Add(Me.cmdCommencerPartie)
        Me.Controls.Add(Me.cbChoix4J)
        Me.Controls.Add(Me.cbChoix3J)
        Me.Controls.Add(Me.cbChoix2J)
        Me.Controls.Add(Me.txtbNomJ4)
        Me.Controls.Add(Me.txtbNomJ3)
        Me.Controls.Add(Me.txtbNomJ2)
        Me.Controls.Add(Me.txtbNomJ1)
        Me.Controls.Add(Me.lblIndicJ4)
        Me.Controls.Add(Me.lblIndicJ3)
        Me.Controls.Add(Me.lblIndicJ2)
        Me.Controls.Add(Me.lblIndicJ1)
        Me.Controls.Add(Me.lblChoixJ)
        Me.Controls.Add(Me.lblTitreQwirkle)
        Me.Name = "frmMCJ"
        Me.Text = "Qwirkle - Paramétrage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitreQwirkle As Label
    Friend WithEvents lblChoixJ As Label
    Friend WithEvents lblIndicJ4 As Label
    Friend WithEvents lblIndicJ3 As Label
    Friend WithEvents lblIndicJ2 As Label
    Friend WithEvents lblIndicJ1 As Label
    Friend WithEvents cmdRetourMenu As Button
    Friend WithEvents cmdCommencerPartie As Button
    Friend WithEvents cbChoix4J As RadioButton
    Friend WithEvents cbChoix3J As RadioButton
    Friend WithEvents cbChoix2J As RadioButton
    Friend WithEvents txtbNomJ4 As TextBox
    Friend WithEvents txtbNomJ3 As TextBox
    Friend WithEvents txtbNomJ2 As TextBox
    Friend WithEvents txtbNomJ1 As TextBox
End Class
