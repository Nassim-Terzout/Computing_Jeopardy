Public Class q2004form
    Private Sub Nextq2004_Click(sender As Object, e As EventArgs) Handles Nextq2004.Click
        If q2004ans5.Checked = True Then
            Boardform.s += 400
            Boardform.score.Text = Boardform.s
            Boardform.q2004.Visible = False
            Resultsq100.qresult.Text = "Correct, 400 points!"
            Resultsq100.qresultgood24.Visible = True
            Resultsq100.qresultgood11.Visible = False
            Resultsq100.qresultgood12.Visible = False
            Resultsq100.qresultgood13.Visible = False
            Resultsq100.qresultgood14.Visible = False
            Resultsq100.qresultgood21.Visible = False
            Resultsq100.qresultgood22.Visible = False
            Resultsq100.qresultgood23.Visible = False
            Resultsq100.qresultgood31.Visible = False
            Resultsq100.qresultgood32.Visible = False
            Resultsq100.qresultgood33.Visible = False
            Resultsq100.qresultgood34.Visible = False
            Resultsq100.qresultgood41.Visible = False
            Resultsq100.qresultgood42.Visible = False
            Resultsq100.qresultgood43.Visible = False
            Resultsq100.qresultgood44.Visible = False
            Resultsq100.qresultbad11.Visible = False
            Resultsq100.qresultbad12.Visible = False
            Resultsq100.qresultbad13.Visible = False
            Resultsq100.qresultbad14.Visible = False
            Resultsq100.qresultbad21.Visible = False
            Resultsq100.qresultbad22.Visible = False
            Resultsq100.qresultbad23.Visible = False
            Resultsq100.qresultbad24.Visible = False
            Resultsq100.qresultbad31.Visible = False
            Resultsq100.qresultbad32.Visible = False
            Resultsq100.qresultbad33.Visible = False
            Resultsq100.qresultbad34.Visible = False
            Resultsq100.qresultbad41.Visible = False
            Resultsq100.qresultbad42.Visible = False
            Resultsq100.qresultbad43.Visible = False
            Resultsq100.qresultbad44.Visible = False
            If Boardform.s < 0 Then
                Boardform.grade.Text = "Grade: F"
                Boardform.rating.Text = "IQ: Failure"
            ElseIf Boardform.s > 0 And Boardform.s < 333 Then
                Boardform.grade.Text = "Grade: D-"
                Boardform.rating.Text = "IQ: Donkey"
            ElseIf Boardform.s > 333 And Boardform.s < 666 Then
                Boardform.grade.Text = "Grade: D"
                Boardform.rating.Text = "IQ: Cow"
            ElseIf Boardform.s > 666 And Boardform.s < 999 Then
                Boardform.grade.Text = "Grade: D+"
                Boardform.rating.Text = "IQ: Chimpanzee"
            ElseIf Boardform.s > 999 And Boardform.s < 1333 Then
                Boardform.grade.Text = "Grade: C-"
                Boardform.rating.Text = "IQ: Donald Trump"
            ElseIf Boardform.s > 1333 And Boardform.s < 1666 Then
                Boardform.grade.Text = "Grade: C"
                Boardform.rating.Text = "IQ: Dog"
            ElseIf Boardform.s > 1666 And Boardform.s < 1999 Then
                Boardform.grade.Text = "Grade: C+"
                Boardform.rating.Text = "IQ: Cat"
            ElseIf Boardform.s > 1999 And Boardform.s < 2333 Then
                Boardform.grade.Text = "Grade: B-"
                Boardform.rating.Text = "IQ: Under Average"
            ElseIf Boardform.s > 2333 And Boardform.s < 2666 Then
                Boardform.grade.Text = "Grade: B"
                Boardform.rating.Text = "IQ: Average"
            ElseIf Boardform.s > 2666 And Boardform.s < 2999 Then
                Boardform.grade.Text = "Grade: B+"
                Boardform.rating.Text = "IQ: Above Average"
            ElseIf Boardform.s > 2999 And Boardform.s < 3333 Then
                Boardform.grade.Text = "Grade: A-"
                Boardform.rating.Text = "IQ: Intelligent"
            ElseIf Boardform.s > 3333 And Boardform.s < 3666 Then
                Boardform.grade.Text = "Grade: A"
                Boardform.rating.Text = "IQ: Genius"
            ElseIf Boardform.s > 3666 And Boardform.s < 4000 Then
                Boardform.grade.Text = "Grade: A+"
                Boardform.rating.Text = "IQ: Hacker"
            ElseIf Boardform.s > 4000 Then
                Boardform.grade.Text = "Grade: A++"
                Boardform.rating.Text = "IQ: Legendary"




            End If
            Resultsq100.graderesult.Text = Boardform.grade.Text
            Resultsq100.ratingresult.Text = Boardform.rating.Text
            Me.Hide()
            Resultsq100.Show()
        Else
            Boardform.s -= 400
            Boardform.score.Text = Boardform.s
            Boardform.q2004.Visible = False
            Resultsq100.qresult.Text = "Incorrect! The answer was Hard-Disk Drive and Solid-State Drive!"
            Resultsq100.qresultbad24.Visible = True
            Resultsq100.qresultgood11.Visible = False
            Resultsq100.qresultgood12.Visible = False
            Resultsq100.qresultgood13.Visible = False
            Resultsq100.qresultgood14.Visible = False
            Resultsq100.qresultgood21.Visible = False
            Resultsq100.qresultgood22.Visible = False
            Resultsq100.qresultgood23.Visible = False
            Resultsq100.qresultgood24.Visible = False
            Resultsq100.qresultgood31.Visible = False
            Resultsq100.qresultgood32.Visible = False
            Resultsq100.qresultgood33.Visible = False
            Resultsq100.qresultgood34.Visible = False
            Resultsq100.qresultgood41.Visible = False
            Resultsq100.qresultgood42.Visible = False
            Resultsq100.qresultgood43.Visible = False
            Resultsq100.qresultgood44.Visible = False
            Resultsq100.qresultbad11.Visible = False
            Resultsq100.qresultbad12.Visible = False
            Resultsq100.qresultbad13.Visible = False
            Resultsq100.qresultbad14.Visible = False
            Resultsq100.qresultbad21.Visible = False
            Resultsq100.qresultbad22.Visible = False
            Resultsq100.qresultbad23.Visible = False
            Resultsq100.qresultbad31.Visible = False
            Resultsq100.qresultbad32.Visible = False
            Resultsq100.qresultbad33.Visible = False
            Resultsq100.qresultbad34.Visible = False
            Resultsq100.qresultbad41.Visible = False
            Resultsq100.qresultbad42.Visible = False
            Resultsq100.qresultbad43.Visible = False
            Resultsq100.qresultbad44.Visible = False
            If Boardform.s < 0 Then
                Boardform.grade.Text = "Grade: F"
                Boardform.rating.Text = "IQ: Failure"
            ElseIf Boardform.s > 0 And Boardform.s < 333 Then
                Boardform.grade.Text = "Grade: D-"
                Boardform.rating.Text = "IQ: Donkey"
            ElseIf Boardform.s > 333 And Boardform.s < 666 Then
                Boardform.grade.Text = "Grade: D"
                Boardform.rating.Text = "IQ: Cow"
            ElseIf Boardform.s > 666 And Boardform.s < 999 Then
                Boardform.grade.Text = "Grade: D+"
                Boardform.rating.Text = "IQ: Chimpanzee"
            ElseIf Boardform.s > 999 And Boardform.s < 1333 Then
                Boardform.grade.Text = "Grade: C-"
                Boardform.rating.Text = "IQ: Donald Trump"
            ElseIf Boardform.s > 1333 And Boardform.s < 1666 Then
                Boardform.grade.Text = "Grade: C"
                Boardform.rating.Text = "IQ: Dog"
            ElseIf Boardform.s > 1666 And Boardform.s < 1999 Then
                Boardform.grade.Text = "Grade: C+"
                Boardform.rating.Text = "IQ: Cat"
            ElseIf Boardform.s > 1999 And Boardform.s < 2333 Then
                Boardform.grade.Text = "Grade: B-"
                Boardform.rating.Text = "IQ: Under Average"
            ElseIf Boardform.s > 2333 And Boardform.s < 2666 Then
                Boardform.grade.Text = "Grade: B"
                Boardform.rating.Text = "IQ: Average"
            ElseIf Boardform.s > 2666 And Boardform.s < 2999 Then
                Boardform.grade.Text = "Grade: B+"
                Boardform.rating.Text = "IQ: Above Average"
            ElseIf Boardform.s > 2999 And Boardform.s < 3333 Then
                Boardform.grade.Text = "Grade: A-"
                Boardform.rating.Text = "IQ: Intelligent"
            ElseIf Boardform.s > 3333 And Boardform.s < 3666 Then
                Boardform.grade.Text = "Grade: A"
                Boardform.rating.Text = "IQ: Genius"
            ElseIf Boardform.s > 3666 And Boardform.s < 4000 Then
                Boardform.grade.Text = "Grade: A+"
                Boardform.rating.Text = "IQ: Hacker"
            ElseIf Boardform.s > 4000 Then
                Boardform.grade.Text = "Grade: A++"
                Boardform.rating.Text = "IQ: Legendary"




            End If
            Resultsq100.graderesult.Text = Boardform.grade.Text
            Resultsq100.ratingresult.Text = Boardform.rating.Text
            Me.Hide()
            Resultsq100.Show()
        End If
    End Sub

    Private Sub q2004text_Click(sender As Object, e As EventArgs) Handles q2004text.Click

    End Sub
End Class