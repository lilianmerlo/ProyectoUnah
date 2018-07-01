Public Class MenuPrincipal

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.Usuario.MdiParent = Me
        Usuario.WindowState = FormWindowState.Maximized

        My.Forms.Usuario.Show()
    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Dim resultado As MsgBoxResult
    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        resultado = CType(MessageBox.Show("Desea salir del sistema", "Avertencia ", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True

        Else
            e.Cancel = False
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Forms.Participantes.MdiParent = Me
        Participantes.WindowState = FormWindowState.Maximized

        My.Forms.Participantes.Show()
    End Sub
End Class