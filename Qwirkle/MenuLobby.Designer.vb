<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLobby
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
        Me.cmdCreateGame = New System.Windows.Forms.Button()
        Me.cmdJoinGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCreateGame
        '
        Me.cmdCreateGame.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdCreateGame.FlatAppearance.BorderSize = 0
        Me.cmdCreateGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.cmdCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreateGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateGame.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdCreateGame.Location = New System.Drawing.Point(220, 69)
        Me.cmdCreateGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCreateGame.Name = "cmdCreateGame"
        Me.cmdCreateGame.Size = New System.Drawing.Size(584, 130)
        Me.cmdCreateGame.TabIndex = 5
        Me.cmdCreateGame.Text = "Creer une partie"
        Me.cmdCreateGame.UseVisualStyleBackColor = False
        '
        'cmdJoinGame
        '
        Me.cmdJoinGame.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdJoinGame.FlatAppearance.BorderSize = 0
        Me.cmdJoinGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.cmdJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdJoinGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJoinGame.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdJoinGame.Location = New System.Drawing.Point(220, 318)
        Me.cmdJoinGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdJoinGame.Name = "cmdJoinGame"
        Me.cmdJoinGame.Size = New System.Drawing.Size(584, 135)
        Me.cmdJoinGame.TabIndex = 6
        Me.cmdJoinGame.Text = "Rejoindre une partie"
        Me.cmdJoinGame.UseVisualStyleBackColor = False
        '
        'MenuLobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 604)
        Me.Controls.Add(Me.cmdJoinGame)
        Me.Controls.Add(Me.cmdCreateGame)
        Me.Name = "MenuLobby"
        Me.Text = "Jeu en Reseau"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCreateGame As Button
    Friend WithEvents cmdJoinGame As Button
End Class
