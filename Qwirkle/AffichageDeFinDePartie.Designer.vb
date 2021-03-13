<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmADFDP
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
        Me.lblIndicationJoueurGagnant = New System.Windows.Forms.Label()
        Me.lblJoueurGagnant = New System.Windows.Forms.Label()
        Me.cmdMenuPrincipal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIndicationJoueurGagnant
        '
        Me.lblIndicationJoueurGagnant.AutoSize = True
        Me.lblIndicationJoueurGagnant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIndicationJoueurGagnant.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicationJoueurGagnant.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblIndicationJoueurGagnant.Location = New System.Drawing.Point(312, 171)
        Me.lblIndicationJoueurGagnant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndicationJoueurGagnant.Name = "lblIndicationJoueurGagnant"
        Me.lblIndicationJoueurGagnant.Size = New System.Drawing.Size(576, 58)
        Me.lblIndicationJoueurGagnant.TabIndex = 0
        Me.lblIndicationJoueurGagnant.Text = "Et c'est une victoire pour :"
        '
        'lblJoueurGagnant
        '
        Me.lblJoueurGagnant.AutoSize = True
        Me.lblJoueurGagnant.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblJoueurGagnant.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJoueurGagnant.Location = New System.Drawing.Point(310, 300)
        Me.lblJoueurGagnant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueurGagnant.Name = "lblJoueurGagnant"
        Me.lblJoueurGagnant.Size = New System.Drawing.Size(555, 69)
        Me.lblJoueurGagnant.TabIndex = 1
        Me.lblJoueurGagnant.Text = "Le joueur qui gagne"
        '
        'cmdMenuPrincipal
        '
        Me.cmdMenuPrincipal.BackColor = System.Drawing.Color.Red
        Me.cmdMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.cmdMenuPrincipal.FlatAppearance.BorderSize = 0
        Me.cmdMenuPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.cmdMenuPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.cmdMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMenuPrincipal.Location = New System.Drawing.Point(470, 557)
        Me.cmdMenuPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMenuPrincipal.Name = "cmdMenuPrincipal"
        Me.cmdMenuPrincipal.Size = New System.Drawing.Size(249, 85)
        Me.cmdMenuPrincipal.TabIndex = 2
        Me.cmdMenuPrincipal.Text = "Quitter"
        Me.cmdMenuPrincipal.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1200, 692)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmADFDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.cmdMenuPrincipal)
        Me.Controls.Add(Me.lblJoueurGagnant)
        Me.Controls.Add(Me.lblIndicationJoueurGagnant)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmADFDP"
        Me.Text = "Qwirkle - Fin de partie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIndicationJoueurGagnant As Label
    Friend WithEvents lblJoueurGagnant As Label
    Friend WithEvents cmdMenuPrincipal As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
