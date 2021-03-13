Imports QwirkleLibrary

Public Class frmMEJ
    Public valid As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdReprendrePartie.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdRetourMenuPrincipal.Click
        frmV.ShowDialog()
        If valid = 1 Then
            frmMCJ.Show()
            Close()
            frmFDJ.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdRegles.Click
        frmR.Show()
        Close()
    End Sub

    Private Sub frmMEJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class