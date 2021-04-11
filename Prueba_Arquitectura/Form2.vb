Public Class Form2
    Private Sub btn_inve_Click(sender As Object, e As EventArgs) Handles btn_inve_2.Click
        Me.Close()
        frm_main.Show()


    End Sub

    Private Sub btn_perfil_2_Click(sender As Object, e As EventArgs) Handles btn_perfil_2.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub btn_acercade_2_Click(sender As Object, e As EventArgs) Handles btn_acercade_2.Click
        Me.Close()

        Form4.Show()

    End Sub

    Private Sub btn_minimi_2_Click(sender As Object, e As EventArgs) Handles btn_minimi_2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_close_2_Click(sender As Object, e As EventArgs) Handles btn_close_2.Click
        End


    End Sub

    Private Sub btn_conta_2_Click(sender As Object, e As EventArgs) Handles btn_conta_2.Click

    End Sub
End Class