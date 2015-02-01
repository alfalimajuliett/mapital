Public Class MissionSelect

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MissionLength = 10
        AlienAlbert.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MissionLength = 25
        AlienAlbert.Show()

        Me.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MissionLength = 50
        AlienAlbert.Show()

        Me.Hide()


    End Sub


End Class