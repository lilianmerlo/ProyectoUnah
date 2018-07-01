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
        MinimizeBox = False



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("datos ingresados", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class