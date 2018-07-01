Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New unahsistemDataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim a As New MenuPrincipal
        a.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If (TxtUsuario.Text = "admin") And (TxtClave.Text = "1234") Then
            MenuPrincipal.Show()
            Hide()
        Else
            MsgBox("usuario o clave incorecta")
            TxtUsuario.Text = ""
            TxtClave.Text = ""
        End If

    End Sub
End Class
