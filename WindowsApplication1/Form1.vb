Public Class Form1
    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_hairy_nuts_Click(sender As Object, e As EventArgs) Handles btn_hairy_nuts.Click
        My.Computer.Audio.Play(My.Resources.Hairy_Nutz, AudioPlayMode.Background)
    End Sub

    Private Sub btn_fuck_u_Click(sender As Object, e As EventArgs) Handles btn_fuck_u.Click
        My.Computer.Audio.Play(My.Resources.Fuck_U_Tack, AudioPlayMode.Background)
    End Sub
End Class
