Public Class Form4
    Private Sub btn_close_4_Click(sender As Object, e As EventArgs) Handles btn_close_4.Click
        End


    End Sub

    Private Sub btn_minimi_4_Click(sender As Object, e As EventArgs) Handles btn_minimi_4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_perfil_4_Click(sender As Object, e As EventArgs) Handles btn_perfil_4.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub btn_conta_4_Click(sender As Object, e As EventArgs) Handles btn_conta_4.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub btn_inve_4_Click(sender As Object, e As EventArgs) Handles btn_inve_4.Click
        Me.Close()

        frm_main.Show()

    End Sub
End Class