Public Class Startmenu
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If pname.Text = "" Then
            namewarning.Visible = True
            Borderwarning.Visible = True
        Else
            Me.Hide()
            Boardform.Show()

        End If
    End Sub

    Private Sub Startmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Exitstart_Click(sender As Object, e As EventArgs) Handles Exitstart.Click
        Me.Close()
    End Sub

    Private Sub Instructions_Click(sender As Object, e As EventArgs) Handles Instructionsbutton.Click
        If pname.Text = "" Then
            namewarning.Visible = True
            Borderwarning.Visible = True
        Else
            Me.Hide()
            Instructions.Show()
        End If
    End Sub

    Private Sub startback_Click(sender As Object, e As EventArgs) Handles startback.Click

    End Sub
End Class