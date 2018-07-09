Public Class Usuario
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UnahsistemDataSet)

    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UnahsistemDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.UnahsistemDataSet.usuarios)
        Me.UsuariosBindingSource.AddNew()

        Fecha_usuarioLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy")
        MinimizeBox = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        MessageBox.Show("datos ingresados", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        limpiar()

    End Sub

    Private Sub limpiar()
        Nombre_usuarioTextBox.Text = ""
        Clave_usuarioTextBox.Text = ""
        Tipo_usuarioComboBox.Text = ""
        Estado_usuarioComboBox.Text = ""
    End Sub

    Private Sub Nombre_usuarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre_usuarioTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Clave_usuarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Clave_usuarioTextBox.KeyPress

    End Sub

    Private Sub Tipo_usuarioComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tipo_usuarioComboBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Estado_usuarioComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Estado_usuarioComboBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If ComboBox1.Text = "Codigo" Then
                Me.UsuariosTableAdapter.buscarporcodigo(Me.UnahsistemDataSet.usuarios, Me.TextBox1.Text)

            Else
                If Me.ValidateChildren And Clave_usuarioTextBox.Text <> String.Empty Then
                End If
            End If

            If ComboBox1.Text = "Nombre" Then
                Me.UsuariosTableAdapter.Fill(Me.UnahsistemDataSet.usuarios)
                Me.UsuariosTableAdapter.Buscapornombre(Me.UnahsistemDataSet.usuarios, Me.TextBox1.Text)

            Else
                If Me.ValidateChildren And Clave_usuarioTextBox.Text <> String.Empty Then
                End If
            End If


        Catch
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UsuariosTableAdapter.Fill(UnahsistemDataSet.usuarios)
        TextBox1.Text = ""
    End Sub

    Private Sub Fecha_usuarioLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_usuarioLabel1_Click(sender As Object, e As EventArgs) Handles Fecha_usuarioLabel1.Click
        Fecha_usuarioLabel1.Text = DateTime.Now.ToString("dd/MM/yyy")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UnahsistemDataSet)
    End Sub


End Class