Public Class Participantes
    Private Sub ParticipantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ParticipantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UnahsistemDataSet)

    End Sub

    Private Sub Participantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UnahsistemDataSet.participantes' Puede moverla o quitarla según sea necesario.
        Me.ParticipantesTableAdapter.Fill(Me.UnahsistemDataSet.participantes)
        Me.ParticipantesBindingSource.AddNew()
        Fecha_participanteLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy")

        MinimizeBox = False



    End Sub

    Private Sub Fecha_participanteLabel1_Click(sender As Object, e As EventArgs) Handles Fecha_participanteLabel1.Click
        Fecha_participanteLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("datos ingresados", "Registro de participante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        limpiar()


    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then

            Num_cuenta_estudianteTextBox.Visible = True

        Else
            Num_cuenta_empleadoTextBox.Visible = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            Num_cuenta_estudianteTextBox.Visible = False

        Else
            Num_cuenta_empleadoTextBox.Visible = True
        End If
    End Sub

    Private Sub Nombre_participanteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre_participanteTextBox.KeyPress
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

    Private Sub Observacion_participanteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Observacion_participanteTextBox.KeyPress
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

    Private Sub Num_cuenta_empleadoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Num_cuenta_empleadoTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Num_cuenta_estudianteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Num_cuenta_estudianteTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub limpiar()
        Num_cuenta_empleadoTextBox.Text = ""
        Num_cuenta_estudianteTextBox.Text = ""
        Nombre_participanteTextBox.Text = ""
        Observacion_participanteTextBox.Text = ""
        CheckBox1.Text = ""
        CheckBox2.Text = ""



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If ComboBox1.Text = "Numero de empleado" Then
                Me.ParticipantesTableAdapter.buscarem(Me.UnahsistemDataSet.participantes, Me.TextBox1.Text)

            Else
                If Me.ValidateChildren And Nombre_participanteTextBox.Text <> String.Empty Then
                End If
            End If

            If ComboBox1.Text = "Numero de estudiante" Then
                Me.ParticipantesTableAdapter.Fill(Me.UnahsistemDataSet.participantes)
                Me.ParticipantesTableAdapter.buscarestudiante(Me.UnahsistemDataSet.participantes, Me.TextBox1.Text)

            Else
                If Me.ValidateChildren And Num_cuenta_estudianteTextBox.Text <> String.Empty Then
                End If
            End If


        Catch
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ParticipantesTableAdapter.Fill(UnahsistemDataSet.participantes)
        TextBox1.Text = ""
    End Sub
End Class