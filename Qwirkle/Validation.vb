Imports QwirkleLibrary

Public Class frmV
    Private Sub Oui_Click(sender As Object, e As EventArgs) Handles Oui.Click
        frmMEJ.valid = 1
        Close()
    End Sub

    Private Sub Non_Click(sender As Object, e As EventArgs) Handles Non.Click
        frmMEJ.valid = 0
        Close()
    End Sub

End Class