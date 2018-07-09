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
        Dim Num_cuenta_estudianteLabel As System.Windows.Forms.Label
        Dim Observacion_participanteLabel As System.Windows.Forms.Label
        Dim Fecha_participanteLabel As System.Windows.Forms.Label
        Dim Cod_empleadoLabel As System.Windows.Forms.Label
        Dim Cod_estudianteLabel As System.Windows.Forms.Label
        Dim Cod_usuarioLabel As System.Windows.Forms.Label
        Dim Num_cuenta_empleadoLabel As System.Windows.Forms.Label
        Dim Nombre_participanteLabel As System.Windows.Forms.Label
        Me.Num_cuenta_estudianteTextBox = New System.Windows.Forms.TextBox()
        Me.ParticipantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnahsistemDataSet = New SystemUnahNuevo.unahsistemDataSet()
        Me.Nombre_participanteTextBox = New System.Windows.Forms.TextBox()
        Me.Observacion_participanteTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_participanteLabel1 = New System.Windows.Forms.Label()
        Me.Cod_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_estudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ParticipantesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Num_cuenta_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ParticipantesTableAdapter = New SystemUnahNuevo.unahsistemDataSetTableAdapters.participantesTableAdapter()
        Me.TableAdapterManager = New SystemUnahNuevo.unahsistemDataSetTableAdapters.TableAdapterManager()
        Num_cuenta_estudianteLabel = New System.Windows.Forms.Label()
        Observacion_participanteLabel = New System.Windows.Forms.Label()
        Fecha_participanteLabel = New System.Windows.Forms.Label()
        Cod_empleadoLabel = New System.Windows.Forms.Label()
        Cod_estudianteLabel = New System.Windows.Forms.Label()
        Cod_usuarioLabel = New System.Windows.Forms.Label()
        Num_cuenta_empleadoLabel = New System.Windows.Forms.Label()
        Nombre_participanteLabel = New System.Windows.Forms.Label()
        CType(Me.ParticipantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnahsistemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParticipantesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Num_cuenta_estudianteLabel
        '
        Num_cuenta_estudianteLabel.AutoSize = True
        Num_cuenta_estudianteLabel.Location = New System.Drawing.Point(57, 135)
        Num_cuenta_estudianteLabel.Name = "Num_cuenta_estudianteLabel"
        Num_cuenta_estudianteLabel.Size = New System.Drawing.Size(173, 13)
        Num_cuenta_estudianteLabel.TabIndex = 3
        Num_cuenta_estudianteLabel.Text = "Numero de  cuenta  del estudiante:"
        '
        'Observacion_participanteLabel
        '
        Observacion_participanteLabel.AutoSize = True
        Observacion_participanteLabel.Location = New System.Drawing.Point(57, 220)
        Observacion_participanteLabel.Name = "Observacion_participanteLabel"
        Observacion_participanteLabel.Size = New System.Drawing.Size(70, 13)
        Observacion_participanteLabel.TabIndex = 7
        Observacion_participanteLabel.Text = "Observacion:"
        '
        'Fecha_participanteLabel
        '
        Fecha_participanteLabel.AutoSize = True
        Fecha_participanteLabel.Location = New System.Drawing.Point(57, 190)
        Fecha_participanteLabel.Name = "Fecha_participanteLabel"
        Fecha_participanteLabel.Size = New System.Drawing.Size(92, 13)
        Fecha_participanteLabel.TabIndex = 9
        Fecha_participanteLabel.Text = "Fecha de registro:"
        '
        'Cod_empleadoLabel
        '
        Cod_empleadoLabel.AutoSize = True
        Cod_empleadoLabel.Location = New System.Drawing.Point(57, 299)
        Cod_empleadoLabel.Name = "Cod_empleadoLabel"
        Cod_empleadoLabel.Size = New System.Drawing.Size(77, 13)
        Cod_empleadoLabel.TabIndex = 11
        Cod_empleadoLabel.Text = "cod empleado:"
        '
        'Cod_estudianteLabel
        '
        Cod_estudianteLabel.AutoSize = True
        Cod_estudianteLabel.Location = New System.Drawing.Point(57, 325)
        Cod_estudianteLabel.Name = "Cod_estudianteLabel"
        Cod_estudianteLabel.Size = New System.Drawing.Size(80, 13)
        Cod_estudianteLabel.TabIndex = 13
        Cod_estudianteLabel.Text = "cod estudiante:"
        '
        'Cod_usuarioLabel
        '
        Cod_usuarioLabel.AutoSize = True
        Cod_usuarioLabel.Location = New System.Drawing.Point(57, 351)
        Cod_usuarioLabel.Name = "Cod_usuarioLabel"
        Cod_usuarioLabel.Size = New System.Drawing.Size(65, 13)
        Cod_usuarioLabel.TabIndex = 15
        Cod_usuarioLabel.Text = "cod usuario:"
        '
        'Num_cuenta_empleadoLabel
        '
        Num_cuenta_empleadoLabel.AutoSize = True
        Num_cuenta_empleadoLabel.Location = New System.Drawing.Point(57, 105)
        Num_cuenta_empleadoLabel.Name = "Num_cuenta_empleadoLabel"
        Num_cuenta_empleadoLabel.Size = New System.Drawing.Size(167, 13)
        Num_cuenta_empleadoLabel.TabIndex = 27
        Num_cuenta_empleadoLabel.Text = "Numero de  cuenta del empleado:"
        '
        'Nombre_participanteLabel
        '
        Nombre_participanteLabel.AutoSize = True
        Nombre_participanteLabel.Location = New System.Drawing.Point(57, 163)
        Nombre_participanteLabel.Name = "Nombre_participanteLabel"
        Nombre_participanteLabel.Size = New System.Drawing.Size(47, 13)
        Nombre_participanteLabel.TabIndex = 28
        Nombre_participanteLabel.Text = "Nombre:"
        '
        'Num_cuenta_estudianteTextBox
        '
        Me.Num_cuenta_estudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "num_cuenta_estudiante", True))
        Me.Num_cuenta_estudianteTextBox.Location = New System.Drawing.Point(264, 126)
        Me.Num_cuenta_estudianteTextBox.MaxLength = 12
        Me.Num_cuenta_estudianteTextBox.Name = "Num_cuenta_estudianteTextBox"
        Me.Num_cuenta_estudianteTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Num_cuenta_estudianteTextBox.TabIndex = 4
        '
        'ParticipantesBindingSource
        '
        Me.ParticipantesBindingSource.DataMember = "participantes"
        Me.ParticipantesBindingSource.DataSource = Me.UnahsistemDataSet
        '
        'UnahsistemDataSet
        '
        Me.UnahsistemDataSet.DataSetName = "unahsistemDataSet"
        Me.UnahsistemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombre_participanteTextBox
        '
        Me.Nombre_participanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "nombre_participante", True))
        Me.Nombre_participanteTextBox.Location = New System.Drawing.Point(264, 152)
        Me.Nombre_participanteTextBox.MaxLength = 40
        Me.Nombre_participanteTextBox.Name = "Nombre_participanteTextBox"
        Me.Nombre_participanteTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Nombre_participanteTextBox.TabIndex = 6
        '
        'Observacion_participanteTextBox
        '
        Me.Observacion_participanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "observacion_participante", True))
        Me.Observacion_participanteTextBox.Location = New System.Drawing.Point(267, 213)
        Me.Observacion_participanteTextBox.MaxLength = 150
        Me.Observacion_participanteTextBox.Multiline = True
        Me.Observacion_participanteTextBox.Name = "Observacion_participanteTextBox"
        Me.Observacion_participanteTextBox.Size = New System.Drawing.Size(245, 64)
        Me.Observacion_participanteTextBox.TabIndex = 8
        '
        'Fecha_participanteLabel1
        '
        Me.Fecha_participanteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "fecha_participante", True))
        Me.Fecha_participanteLabel1.Location = New System.Drawing.Point(264, 190)
        Me.Fecha_participanteLabel1.Name = "Fecha_participanteLabel1"
        Me.Fecha_participanteLabel1.Size = New System.Drawing.Size(245, 20)
        Me.Fecha_participanteLabel1.TabIndex = 10
        Me.Fecha_participanteLabel1.Text = "Label1"
        '
        'Cod_empleadoTextBox
        '
        Me.Cod_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "cod_empleado", True))
        Me.Cod_empleadoTextBox.Location = New System.Drawing.Point(264, 295)
        Me.Cod_empleadoTextBox.Name = "Cod_empleadoTextBox"
        Me.Cod_empleadoTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Cod_empleadoTextBox.TabIndex = 12
        '
        'Cod_estudianteTextBox
        '
        Me.Cod_estudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "cod_estudiante", True))
        Me.Cod_estudianteTextBox.Location = New System.Drawing.Point(264, 318)
        Me.Cod_estudianteTextBox.Name = "Cod_estudianteTextBox"
        Me.Cod_estudianteTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Cod_estudianteTextBox.TabIndex = 14
        '
        'Cod_usuarioTextBox
        '
        Me.Cod_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "cod_usuario", True))
        Me.Cod_usuarioTextBox.Location = New System.Drawing.Point(264, 340)
        Me.Cod_usuarioTextBox.Name = "Cod_usuarioTextBox"
        Me.Cod_usuarioTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Cod_usuarioTextBox.TabIndex = 16
        '
        'ParticipantesDataGridView
        '
        Me.ParticipantesDataGridView.AllowUserToAddRows = False
        Me.ParticipantesDataGridView.AllowUserToDeleteRows = False
        Me.ParticipantesDataGridView.AutoGenerateColumns = False
        Me.ParticipantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParticipantesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ParticipantesDataGridView.DataSource = Me.ParticipantesBindingSource
        Me.ParticipantesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ParticipantesDataGridView.Location = New System.Drawing.Point(0, 449)
        Me.ParticipantesDataGridView.Name = "ParticipantesDataGridView"
        Me.ParticipantesDataGridView.ReadOnly = True
        Me.ParticipantesDataGridView.Size = New System.Drawing.Size(995, 115)
        Me.ParticipantesDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_participante"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codigo de participante"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "num_cuenta_empleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "numero de cuenta del empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "num_cuenta_estudiante"
        Me.DataGridViewTextBoxColumn3.HeaderText = "numero de cuenta del estudiante"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre_participante"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre del participante"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "observacion_participante"
        Me.DataGridViewTextBoxColumn5.HeaderText = "observacion del participante"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 140
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha_participante"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha de registrio del participante"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 140
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_empleado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cod_empleado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cod_estudiante"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cod_estudiante"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cod_usuario"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cod_usuario"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar por"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Numero de empleado", "Numero de estudiante"})
        Me.ComboBox1.Location = New System.Drawing.Point(267, 389)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(519, 389)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(801, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Nuevo Registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(801, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(801, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Num_cuenta_empleadoTextBox
        '
        Me.Num_cuenta_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "num_cuenta_empleado", True))
        Me.Num_cuenta_empleadoTextBox.Location = New System.Drawing.Point(264, 98)
        Me.Num_cuenta_empleadoTextBox.MaxLength = 7
        Me.Num_cuenta_empleadoTextBox.Name = "Num_cuenta_empleadoTextBox"
        Me.Num_cuenta_empleadoTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Num_cuenta_empleadoTextBox.TabIndex = 28
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(232, 44)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Estudiante"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(469, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "Empleado"
        Me.CheckBox2.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.constancia_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.constancia_estudianteTableAdapter = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.estudiantesTableAdapter = Nothing
        Me.TableAdapterManager.participantesTableAdapter = Me.ParticipantesTableAdapter
        Me.TableAdapterManager.UpdateOrder = SystemUnahNuevo.unahsistemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'Participantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 564)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Nombre_participanteLabel)
        Me.Controls.Add(Num_cuenta_empleadoLabel)
        Me.Controls.Add(Me.Num_cuenta_empleadoTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ParticipantesDataGridView)
        Me.Controls.Add(Num_cuenta_estudianteLabel)
        Me.Controls.Add(Me.Num_cuenta_estudianteTextBox)
        Me.Controls.Add(Me.Nombre_participanteTextBox)
        Me.Controls.Add(Observacion_participanteLabel)
        Me.Controls.Add(Me.Observacion_participanteTextBox)
        Me.Controls.Add(Fecha_participanteLabel)
        Me.Controls.Add(Me.Fecha_participanteLabel1)
        Me.Controls.Add(Cod_empleadoLabel)
        Me.Controls.Add(Me.Cod_empleadoTextBox)
        Me.Controls.Add(Cod_estudianteLabel)
        Me.Controls.Add(Me.Cod_estudianteTextBox)
        Me.Controls.Add(Cod_usuarioLabel)
        Me.Controls.Add(Me.Cod_usuarioTextBox)
        Me.Name = "Participantes"
        Me.Text = "Participantes"
        CType(Me.ParticipantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnahsistemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParticipantesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UnahsistemDataSet As unahsistemDataSet
    Friend WithEvents ParticipantesBindingSource As BindingSource
    Friend WithEvents ParticipantesTableAdapter As unahsistemDataSetTableAdapters.participantesTableAdapter
    Friend WithEvents TableAdapterManager As unahsistemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Num_cuenta_estudianteTextBox As TextBox
    Friend WithEvents Nombre_participanteTextBox As TextBox
    Friend WithEvents Observacion_participanteTextBox As TextBox
    Friend WithEvents Fecha_participanteLabel1 As Label
    Friend WithEvents Cod_empleadoTextBox As TextBox
    Friend WithEvents Cod_estudianteTextBox As TextBox
    Friend WithEvents Cod_usuarioTextBox As TextBox
    Friend WithEvents ParticipantesDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Num_cuenta_empleadoTextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
