<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMP))
        Me.lblPhraseIntro = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdJouer = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPhraseIntro
        '
        Me.lblPhraseIntro.AutoSize = True
        Me.lblPhraseIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhraseIntro.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPhraseIntro.Location = New System.Drawing.Point(462, 14)
        Me.lblPhraseIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhraseIntro.Name = "lblPhraseIntro"
        Me.lblPhraseIntro.Size = New System.Drawing.Size(0, 33)
        Me.lblPhraseIntro.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 55)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(974, 258)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'cmdJouer
        '
        Me.cmdJouer.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdJouer.FlatAppearance.BorderSize = 0
        Me.cmdJouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.cmdJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdJouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJouer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdJouer.Location = New System.Drawing.Point(410, 356)
        Me.cmdJouer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdJouer.Name = "cmdJouer"
        Me.cmdJouer.Size = New System.Drawing.Size(396, 106)
        Me.cmdJouer.TabIndex = 4
        Me.cmdJouer.Text = "Jouer"
        Me.cmdJouer.UseVisualStyleBackColor = False
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCopyright.Location = New System.Drawing.Point(18, 655)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(71, 25)
        Me.lblCopyright.TabIndex = 5
        Me.lblCopyright.Text = "©2021"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(410, 516)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(396, 106)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Jouer en Reseau"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 695)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.cmdJouer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPhraseIntro)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle - Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPhraseIntro As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdJouer As Button
    Friend WithEvents lblCopyright As Label
    Friend WithEvents Button1 As Button
End Class
