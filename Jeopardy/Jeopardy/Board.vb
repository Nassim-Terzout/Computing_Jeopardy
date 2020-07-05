Public Class Boardform
    Public s As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles q1001.Click
        q1001.Visible = False
        Me.Hide()
        q1001form.Show()


    End Sub

    Private Sub returnmainboard_Click(sender As Object, e As EventArgs) Handles restartmainboard.Click
        s = 0

        score.Text = s

        q1001.Visible = True
        q1002.Visible = True
        q1003.Visible = True
        q1004.Visible = True
        q2001.Visible= True
        q2002.Visible = True
        q2003.Visible = True
        q2004.Visible = True
        q3001.Visible = True
        q3002.Visible = True
        q3003.Visible = True
        q3004.Visible = True
        q4004.Visible = True
        q4001.Visible = True
        q4002.Visible = True
        q4003.Visible = True
        Me.Hide()
        Startmenu.Show()
    End Sub

    Private Sub score_Click(sender As Object, e As EventArgs) Handles score.Click

    End Sub

    Private Sub q1002_Click(sender As Object, e As EventArgs) Handles q1002.Click
        Me.Hide()
        q1002form.Show()
    End Sub

    Private Sub q1003_Click(sender As Object, e As EventArgs) Handles q1003.Click
        Me.Hide()
        q1003form.Show()
    End Sub

    Private Sub q1004_Click(sender As Object, e As EventArgs) Handles q1004.Click
        Me.Hide()
        q1004form.Show()
    End Sub

    Private Sub q2001_Click(sender As Object, e As EventArgs) Handles q2001.Click
        Me.Hide()
        q2001form.Show()
    End Sub

    Private Sub q2002_Click(sender As Object, e As EventArgs) Handles q2002.Click
        Me.Hide()
        q2002form.Show()
    End Sub

    Private Sub q2003_Click(sender As Object, e As EventArgs) Handles q2003.Click
        Me.Hide()
        q2003form.Show()
    End Sub

    Private Sub q2004_Click(sender As Object, e As EventArgs) Handles q2004.Click
        Me.Hide()
        q2004form.Show()
    End Sub

    Private Sub q3001_Click(sender As Object, e As EventArgs) Handles q3001.Click
        Me.Hide()
        q3001form.Show()
    End Sub

    Private Sub q3002_Click(sender As Object, e As EventArgs) Handles q3002.Click
        Me.Hide()
        q3002form.Show()
    End Sub

    Private Sub q3003_Click(sender As Object, e As EventArgs) Handles q3003.Click
        Me.Hide()
        q3003form.Show()
    End Sub

    Private Sub q3004_Click(sender As Object, e As EventArgs) Handles q3004.Click
        Me.Hide()
        q3004form.Show()
    End Sub

    Private Sub q4001_Click(sender As Object, e As EventArgs) Handles q4001.Click
        Me.Hide()
        q4001form.Show()
    End Sub

    Private Sub q4002_Click(sender As Object, e As EventArgs) Handles q4002.Click
        Me.Hide()
        q4002form.Show()
    End Sub

    Private Sub q4003_Click(sender As Object, e As EventArgs) Handles q4003.Click
        Me.Hide()
        q4003form.Show()
    End Sub

    Private Sub q4004_Click(sender As Object, e As EventArgs) Handles q4004.Click
        Me.Hide()
        q4004form.Show()
    End Sub

    Private Sub grade_Click(sender As Object, e As EventArgs) Handles grade.Click

    End Sub

    Private Sub Boardback_Click(sender As Object, e As EventArgs) Handles Boardback.Click

    End Sub

    Private Sub Boardform_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged


    End Sub

    Private Sub q1001_VisibleChanged(sender As Object, e As EventArgs) Handles q1001.VisibleChanged

    End Sub

    Private Sub Gradelabel_Click(sender As Object, e As EventArgs) Handles Gradelabel.Click

    End Sub

    Private Sub rating_Click(sender As Object, e As EventArgs) Handles rating.Click

    End Sub

    Private Sub Boardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ethics_Click(sender As Object, e As EventArgs) Handles Ethics.Click

    End Sub
End Class