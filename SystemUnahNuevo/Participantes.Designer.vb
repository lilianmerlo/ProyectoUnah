<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Participantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Num_cuenta_empleadoLabel As System.Windows.Forms.Label
        Dim Num_cuenta_estudianteLabel As System.Windows.Forms.Label
        Dim Nombre_participanteLabel As System.Windows.Forms.Label
        Dim Observacion_participanteLabel As System.Windows.Forms.Label
        Dim Fecha_participanteLabel As System.Windows.Forms.Label
        Me.UnahsistemDataSet = New SystemUnahNuevo.unahsistemDataSet()
        Me.ParticipantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParticipantesTableAdapter = New SystemUnahNuevo.unahsistemDataSetTableAdapters.participantesTableAdapter()
        Me.TableAdapterManager = New SystemUnahNuevo.unahsistemDataSetTableAdapters.TableAdapterManager()
        Me.Num_cuenta_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Num_cuenta_estudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_participanteTextBox = New System.Windows.Forms.TextBox()
        Me.Observacion_participanteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ParticipantesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Fecha_participanteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Num_cuenta_empleadoLabel = New System.Windows.Forms.Label()
        Num_cuenta_estudianteLabel = New System.Windows.Forms.Label()
        Nombre_participanteLabel = New System.Windows.Forms.Label()
        Observacion_participanteLabel = New System.Windows.Forms.Label()
        Fecha_participanteLabel = New System.Windows.Forms.Label()
        CType(Me.UnahsistemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParticipantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParticipantesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Num_cuenta_empleadoLabel
        '
        Num_cuenta_empleadoLabel.AutoSize = True
        Num_cuenta_empleadoLabel.Location = New System.Drawing.Point(33, 48)
        Num_cuenta_empleadoLabel.Name = "Num_cuenta_empleadoLabel"
        Num_cuenta_empleadoLabel.Size = New System.Drawing.Size(170, 13)
        Num_cuenta_empleadoLabel.TabIndex = 1
        Num_cuenta_empleadoLabel.Text = "Numero de  cuenta  del empleado:"
        '
        'Num_cuenta_estudianteLabel
        '
        Num_cuenta_estudianteLabel.AutoSize = True
        Num_cuenta_estudianteLabel.Location = New System.Drawing.Point(33, 74)
        Num_cuenta_estudianteLabel.Name = "Num_cuenta_estudianteLabel"
        Num_cuenta_estudianteLabel.Size = New System.Drawing.Size(173, 13)
        Num_cuenta_estudianteLabel.TabIndex = 3
        Num_cuenta_estudianteLabel.Text = "Numero de  cuenta del  estudiante:"
        '
        'Nombre_participanteLabel
        '
        Nombre_participanteLabel.AutoSize = True
        Nombre_participanteLabel.Location = New System.Drawing.Point(33, 100)
        Nombre_participanteLabel.Name = "Nombre_participanteLabel"
        Nombre_participanteLabel.Size = New System.Drawing.Size(50, 13)
        Nombre_participanteLabel.TabIndex = 5
        Nombre_participanteLabel.Text = "Nombre :"
        '
        'Observacion_participanteLabel
        '
        Observacion_participanteLabel.AutoSize = True
        Observacion_participanteLabel.Location = New System.Drawing.Point(33, 126)
        Observacion_participanteLabel.Name = "Observacion_participanteLabel"
        Observacion_participanteLabel.Size = New System.Drawing.Size(70, 13)
        Observacion_participanteLabel.TabIndex = 7
        Observacion_participanteLabel.Text = "Observacion:"
        '
        'Fecha_participanteLabel
        '
        Fecha_participanteLabel.AutoSize = True
        Fecha_participanteLabel.Location = New System.Drawing.Point(33, 159)
        Fecha_participanteLabel.Name = "Fecha_participanteLabel"
        Fecha_participanteLabel.Size = New System.Drawing.Size(89, 13)
        Fecha_participanteLabel.TabIndex = 16
        Fecha_participanteLabel.Text = "fecha de registro:"
        '
        'UnahsistemDataSet
        '
        Me.UnahsistemDataSet.DataSetName = "unahsistemDataSet"
        Me.UnahsistemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParticipantesBindingSource
        '
        Me.ParticipantesBindingSource.DataMember = "participantes"
        Me.ParticipantesBindingSource.DataSource = Me.UnahsistemDataSet
        '
        'ParticipantesTableAdapter
        '
        Me.ParticipantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargosTableAdapter = Nothing
        Me.TableAdapterManager.constanciasempleadoTableAdapter = Nothing
        Me.TableAdapterManager.constanciasestudianteTableAdapter = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.estudiantesTableAdapter = Nothing
        Me.TableAdapterManager.participantesTableAdapter = Me.ParticipantesTableAdapter
        Me.TableAdapterManager.UpdateOrder = SystemUnahNuevo.unahsistemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'Num_cuenta_empleadoTextBox
        '
        Me.Num_cuenta_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "num_cuenta_empleado", True))
        Me.Num_cuenta_empleadoTextBox.Location = New System.Drawing.Point(235, 41)
        Me.Num_cuenta_empleadoTextBox.Name = "Num_cuenta_empleadoTextBox"
        Me.Num_cuenta_empleadoTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Num_cuenta_empleadoTextBox.TabIndex = 2
        '
        'Num_cuenta_estudianteTextBox
        '
        Me.Num_cuenta_estudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "num_cuenta_estudiante", True))
        Me.Num_cuenta_estudianteTextBox.Location = New System.Drawing.Point(235, 67)
        Me.Num_cuenta_estudianteTextBox.Name = "Num_cuenta_estudianteTextBox"
        Me.Num_cuenta_estudianteTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Num_cuenta_estudianteTextBox.TabIndex = 4
        '
        'Nombre_participanteTextBox
        '
        Me.Nombre_participanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "nombre_participante", True))
        Me.Nombre_participanteTextBox.Location = New System.Drawing.Point(235, 93)
        Me.Nombre_participanteTextBox.Name = "Nombre_participanteTextBox"
        Me.Nombre_participanteTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Nombre_participanteTextBox.TabIndex = 6
        '
        'Observacion_participanteTextBox
        '
        Me.Observacion_participanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "observacion_participante", True))
        Me.Observacion_participanteTextBox.Location = New System.Drawing.Point(235, 119)
        Me.Observacion_participanteTextBox.Name = "Observacion_participanteTextBox"
        Me.Observacion_participanteTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Observacion_participanteTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar por"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 190)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(522, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 20)
        Me.TextBox1.TabIndex = 13
        '
        'ParticipantesDataGridView
        '
        Me.ParticipantesDataGridView.AutoGenerateColumns = False
        Me.ParticipantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParticipantesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ParticipantesDataGridView.DataSource = Me.ParticipantesBindingSource
        Me.ParticipantesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ParticipantesDataGridView.Location = New System.Drawing.Point(0, 219)
        Me.ParticipantesDataGridView.Name = "ParticipantesDataGridView"
        Me.ParticipantesDataGridView.Size = New System.Drawing.Size(1004, 322)
        Me.ParticipantesDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_participante"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codigo del participante"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "num_cuenta_empleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "numero de cuenta del empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "num_cuenta_estudiante"
        Me.DataGridViewTextBoxColumn3.HeaderText = "numero de cuenta del estudiante"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre_participante"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre del participante"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "observacion_participante"
        Me.DataGridViewTextBoxColumn5.HeaderText = "observacion del participante"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha_participante"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha de registro del participante"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 160
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(746, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Nuevo Registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(746, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(746, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Fecha_participanteDateTimePicker
        '
        Me.Fecha_participanteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParticipantesBindingSource, "fecha_participante", True))
        Me.Fecha_participanteDateTimePicker.Location = New System.Drawing.Point(235, 149)
        Me.Fecha_participanteDateTimePicker.Name = "Fecha_participanteDateTimePicker"
        Me.Fecha_participanteDateTimePicker.Size = New System.Drawing.Size(206, 20)
        Me.Fecha_participanteDateTimePicker.TabIndex = 17
        '
        'Participantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 541)
        Me.Controls.Add(Fecha_participanteLabel)
        Me.Controls.Add(Me.Fecha_participanteDateTimePicker)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ParticipantesDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Num_cuenta_empleadoLabel)
        Me.Controls.Add(Me.Num_cuenta_empleadoTextBox)
        Me.Controls.Add(Num_cuenta_estudianteLabel)
        Me.Controls.Add(Me.Num_cuenta_estudianteTextBox)
        Me.Controls.Add(Nombre_participanteLabel)
        Me.Controls.Add(Me.Nombre_participanteTextBox)
        Me.Controls.Add(Observacion_participanteLabel)
        Me.Controls.Add(Me.Observacion_participanteTextBox)
        Me.Name = "Participantes"
        Me.Text = "Participantes"
        CType(Me.UnahsistemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParticipantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParticipantesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UnahsistemDataSet As unahsistemDataSet
    Friend WithEvents ParticipantesBindingSource As BindingSource
    Friend WithEvents ParticipantesTableAdapter As unahsistemDataSetTableAdapters.participantesTableAdapter
    Friend WithEvents TableAdapterManager As unahsistemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Num_cuenta_empleadoTextBox As TextBox
    Friend WithEvents Num_cuenta_estudianteTextBox As TextBox
    Friend WithEvents Nombre_participanteTextBox As TextBox
    Friend WithEvents Observacion_participanteTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ParticipantesDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Fecha_participanteDateTimePicker As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
