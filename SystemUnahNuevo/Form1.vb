Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim a As New MenuPrincipal
        a.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "server=localhost; user=root; password=tete1991; database=unahsistem"
            conexion.Open()
            'MsgBox("conexion")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



        comando.CommandText = "SELECT * FROM  usuarios WHERE nombre_usuario='" + TxtUsuario.Text + "' AND clave_usuario='" + TxtClave.Text + "'"
        Dim r As MySqlDataReader

        r = comando.ExecuteReader


        If r.HasRows <> False Then
            r.Read()
            'MsgBox(r.GetString("Bienbenido"))
            MenuPrincipal.Show()
            Hide()



        Else
            MsgBox("usuario o clave incorecta")


        End If
        limpiar()







    End Sub

    Private Sub limpiar()
        TxtUsuario.Text = ""
        TxtClave.Text = ""

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("desea cancelar")
        Me.Close()

    End Sub


End Class
