<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmV
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
        Me.Oui = New System.Windows.Forms.Button()
        Me.Non = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Oui
        '
        Me.Oui.BackColor = System.Drawing.Color.LimeGreen
        Me.Oui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.Oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Oui.Location = New System.Drawing.Point(104, 189)
        Me.Oui.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Oui.Name = "Oui"
        Me.Oui.Size = New System.Drawing.Size(244, 95)
        Me.Oui.TabIndex = 2
        Me.Oui.Text = "Oui"
        Me.Oui.UseVisualStyleBackColor = False
        '
        'Non
        '
        Me.Non.BackColor = System.Drawing.Color.Red
        Me.Non.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Non.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Non.Location = New System.Drawing.Point(453, 189)
        Me.Non.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Non.Name = "Non"
        Me.Non.Size = New System.Drawing.Size(244, 95)
        Me.Non.TabIndex = 4
        Me.Non.Text = "Non"
        Me.Non.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(96, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(613, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Etes-vous sur de vouloir retourner au menu ?"
        '
        'frmV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 366)
        Me.Controls.Add(Me.Non)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Oui)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmV"
        Me.Text = "Qwrikle - Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Oui As Button
    Friend WithEvents Non As Button
    Friend WithEvents Label1 As Label
End Class
