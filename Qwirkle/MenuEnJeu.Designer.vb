<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEJ
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
        Me.cmdRegles = New System.Windows.Forms.Button()
        Me.cmdRetourMenuPrincipal = New System.Windows.Forms.Button()
        Me.cmdReprendrePartie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdRegles
        '
        Me.cmdRegles.BackColor = System.Drawing.Color.Silver
        Me.cmdRegles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdRegles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegles.Location = New System.Drawing.Point(50, 245)
        Me.cmdRegles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRegles.Name = "cmdRegles"
        Me.cmdRegles.Size = New System.Drawing.Size(399, 94)
        Me.cmdRegles.TabIndex = 5
        Me.cmdRegles.Text = "Règles"
        Me.cmdRegles.UseVisualStyleBackColor = False
        '
        'cmdRetourMenuPrincipal
        '
        Me.cmdRetourMenuPrincipal.BackColor = System.Drawing.Color.Red
        Me.cmdRetourMenuPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.cmdRetourMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRetourMenuPrincipal.Location = New System.Drawing.Point(50, 422)
        Me.cmdRetourMenuPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRetourMenuPrincipal.Name = "cmdRetourMenuPrincipal"
        Me.cmdRetourMenuPrincipal.Size = New System.Drawing.Size(399, 94)
        Me.cmdRetourMenuPrincipal.TabIndex = 4
        Me.cmdRetourMenuPrincipal.Text = "Retourner au menu"
        Me.cmdRetourMenuPrincipal.UseVisualStyleBackColor = False
        '
        'cmdReprendrePartie
        '
        Me.cmdReprendrePartie.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdReprendrePartie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.cmdReprendrePartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReprendrePartie.Location = New System.Drawing.Point(50, 75)
        Me.cmdReprendrePartie.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdReprendrePartie.Name = "cmdReprendrePartie"
        Me.cmdReprendrePartie.Size = New System.Drawing.Size(399, 94)
        Me.cmdReprendrePartie.TabIndex = 3
        Me.cmdReprendrePartie.Text = "Reprendre la partie"
        Me.cmdReprendrePartie.UseVisualStyleBackColor = False
        '
        'frmMEJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(510, 591)
        Me.Controls.Add(Me.cmdRegles)
        Me.Controls.Add(Me.cmdRetourMenuPrincipal)
        Me.Controls.Add(Me.cmdReprendrePartie)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMEJ"
        Me.Text = "Qwirkle - Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdRegles As Button
    Friend WithEvents cmdRetourMenuPrincipal As Button
    Friend WithEvents cmdReprendrePartie As Button
End Class
