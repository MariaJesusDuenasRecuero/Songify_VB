Public Class Queries
    Private Sub GoBackBtn_Click(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow()
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub firstQuerie_Click(sender As Object, e As EventArgs) Handles firstQuerie.Click
        ListBox1.Visible = True
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False



    End Sub

    Private Sub SecondQuerie_Click(sender As Object, e As EventArgs) Handles SecondQuerie.Click
        ListBox1.Visible = False
        ListBox2.Visible = True
        ListBox3.Visible = False
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False

    End Sub

    Private Sub thirdQuerie_Click(sender As Object, e As EventArgs) Handles thirdQuerie.Click
        ListBox1.Visible = False
        ListBox2.Visible = True
        ListBox3.Visible = False
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False

    End Sub

    Private Sub fourthQuerie_Click(sender As Object, e As EventArgs) Handles fourthQuerie.Click
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = True
        playbackTime.Visible = False
        lblSeconds.Visible = False


    End Sub

    Private Sub fifthQuerie_Click(sender As Object, e As EventArgs) Handles fifthQuerie.Click
        playbackTime.Visible = True
        lblSeconds.Visible = True
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = False




    End Sub
End Class