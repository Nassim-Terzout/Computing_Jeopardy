Public Class Instructions
    Private Sub Exitinstructions_Click(sender As Object, e As EventArgs) Handles Exitinstructions.Click
        Me.Close()
    End Sub

    Private Sub Returnmain_Click(sender As Object, e As EventArgs) Handles Returnmain.Click
        Me.Hide()
        Startmenu.Show()
    End Sub

    Private Sub Startinstructions_Click(sender As Object, e As EventArgs) Handles Startinstructions.Click
        Me.Hide()
        Boardform.Show()
    End Sub

    Private Sub Backgroundinstructions_Click(sender As Object, e As EventArgs) Handles Backgroundinstructions.Click

    End Sub
End Class