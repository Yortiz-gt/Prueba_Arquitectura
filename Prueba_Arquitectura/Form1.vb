Public Class frm_main
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnl_izquierda.Paint

    End Sub

    Private Sub btn_inve_Click(sender As Object, e As EventArgs) Handles btn_inve.Click

    End Sub

    Private Sub btn_conta_Click(sender As Object, e As EventArgs) Handles btn_conta.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_acercade.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_perfil_Click(sender As Object, e As EventArgs) Handles btn_perfil.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        End



    End Sub

    Private Sub btn_minimi_Click(sender As Object, e As EventArgs) Handles btn_minimi.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
