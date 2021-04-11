Public Class Form3
    Private Sub btn_perfil_3_Click(sender As Object, e As EventArgs) Handles btn_perfil_3.Click

    End Sub

    Private Sub btn_inve_3_Click(sender As Object, e As EventArgs) Handles btn_inve_3.Click
        Me.Close()
        frm_main.Show()

    End Sub

    Private Sub btn_conta_3_Click(sender As Object, e As EventArgs) Handles btn_conta_3.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub btn_acercade_3_Click(sender As Object, e As EventArgs) Handles btn_acercade_3.Click
        Me.Close()
        Form4.Show()

    End Sub

    Private Sub btn_close_3_Click(sender As Object, e As EventArgs) Handles btn_close_3.Click
        End

    End Sub

    Private Sub btn_minimi_3_Click(sender As Object, e As EventArgs) Handles btn_minimi_3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class