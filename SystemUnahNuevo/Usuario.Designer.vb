<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuario
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
        Dim Nombre_usuarioLabel As System.Windows.Forms.Label
        Dim Clave_usuarioLabel As System.Windows.Forms.Label
        Dim Estado_usuarioLabel As System.Windows.Forms.Label
        Dim Tipo_usuarioLabel As System.Windows.Forms.Label
        Dim Fecha_usuarioLabel As System.Windows.Forms.Label
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnahsistemDataSet = New SystemUnahNuevo.unahsistemDataSet()
        Me.Nombre_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Clave_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Estado_usuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tipo_usuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New SystemUnahNuevo.unahsistemDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New SystemUnahNuevo.unahsistemDataSetTableAdapters.TableAdapterManager()
        Me.Fecha_usuarioLabel1 = New System.Windows.Forms.Label()
        Nombre_usuarioLabel = New System.Windows.Forms.Label()
        Clave_usuarioLabel = New System.Windows.Forms.Label()
        Estado_usuarioLabel = New System.Windows.Forms.Label()
        Tipo_usuarioLabel = New System.Windows.Forms.Label()
        Fecha_usuarioLabel = New System.Windows.Forms.Label()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnahsistemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre_usuarioLabel
        '
        Nombre_usuarioLabel.AutoSize = True
        Nombre_usuarioLabel.Location = New System.Drawing.Point(54, 88)
        Nombre_usuarioLabel.Name = "Nombre_usuarioLabel"
        Nombre_usuarioLabel.Size = New System.Drawing.Size(47, 13)
        Nombre_usuarioLabel.TabIndex = 11
        Nombre_usuarioLabel.Text = "Nombre:"
        '
        'Clave_usuarioLabel
        '
        Clave_usuarioLabel.AutoSize = True
        Clave_usuarioLabel.Location = New System.Drawing.Point(54, 114)
        Clave_usuarioLabel.Name = "Clave_usuarioLabel"
        Clave_usuarioLabel.Size = New System.Drawing.Size(37, 13)
        Clave_usuarioLabel.TabIndex = 13
        Clave_usuarioLabel.Text = "Clave:"
        '
        'Estado_usuarioLabel
        '
        Estado_usuarioLabel.AutoSize = True
        Estado_usuarioLabel.Location = New System.Drawing.Point(54, 189)
        Estado_usuarioLabel.Name = "Estado_usuarioLabel"
        Estado_usuarioLabel.Size = New System.Drawing.Size(43, 13)
        Estado_usuarioLabel.TabIndex = 19
        Estado_usuarioLabel.Text = "Estado:"
        '
        'Tipo_usuarioLabel
        '
        Tipo_usuarioLabel.AutoSize = True
        Tipo_usuarioLabel.Location = New System.Drawing.Point(54, 140)
        Tipo_usuarioLabel.Name = "Tipo_usuarioLabel"
        Tipo_usuarioLabel.Size = New System.Drawing.Size(31, 13)
        Tipo_usuarioLabel.TabIndex = 24
        Tipo_usuarioLabel.Text = "Tipo:"
        '
        'Fecha_usuarioLabel
        '
        Fecha_usuarioLabel.AutoSize = True
        Fecha_usuarioLabel.Location = New System.Drawing.Point(54, 164)
        Fecha_usuarioLabel.Name = "Fecha_usuarioLabel"
        Fecha_usuarioLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_usuarioLabel.TabIndex = 30
        Fecha_usuarioLabel.Text = "fecha usuario:"
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(0, 274)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(957, 220)
        Me.UsuariosDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codigo de usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_usuario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre de usuario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "clave_usuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "clave de usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tipo_usuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tipo de usuario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha_usuario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fecha de registro de usuario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 180
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "estado_usuario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "estado de usuario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.UnahsistemDataSet
        '
        'UnahsistemDataSet
        '
        Me.UnahsistemDataSet.DataSetName = "unahsistemDataSet"
        Me.UnahsistemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombre_usuarioTextBox
        '
        Me.Nombre_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nombre_usuario", True))
        Me.Nombre_usuarioTextBox.Location = New System.Drawing.Point(164, 88)
        Me.Nombre_usuarioTextBox.MaxLength = 40
        Me.Nombre_usuarioTextBox.Name = "Nombre_usuarioTextBox"
        Me.Nombre_usuarioTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Nombre_usuarioTextBox.TabIndex = 12
        '
        'Clave_usuarioTextBox
        '
        Me.Clave_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "clave_usuario", True))
        Me.Clave_usuarioTextBox.Location = New System.Drawing.Point(164, 114)
        Me.Clave_usuarioTextBox.MaxLength = 10
        Me.Clave_usuarioTextBox.Name = "Clave_usuarioTextBox"
        Me.Clave_usuarioTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Clave_usuarioTextBox.TabIndex = 14
        '
        'Estado_usuarioComboBox
        '
        Me.Estado_usuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "estado_usuario", True))
        Me.Estado_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado_usuarioComboBox.FormattingEnabled = True
        Me.Estado_usuarioComboBox.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.Estado_usuarioComboBox.Location = New System.Drawing.Point(164, 189)
        Me.Estado_usuarioComboBox.Name = "Estado_usuarioComboBox"
        Me.Estado_usuarioComboBox.Size = New System.Drawing.Size(245, 21)
        Me.Estado_usuarioComboBox.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(744, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Nuevo registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tipo_usuarioComboBox
        '
        Me.Tipo_usuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "tipo_usuario", True))
        Me.Tipo_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_usuarioComboBox.FormattingEnabled = True
        Me.Tipo_usuarioComboBox.Items.AddRange(New Object() {"", "Admin", "Estandar"})
        Me.Tipo_usuarioComboBox.Location = New System.Drawing.Point(164, 140)
        Me.Tipo_usuarioComboBox.Name = "Tipo_usuarioComboBox"
        Me.Tipo_usuarioComboBox.Size = New System.Drawing.Size(245, 21)
        Me.Tipo_usuarioComboBox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Buscar por"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Codigo", "Nombre"})
        Me.ComboBox1.Location = New System.Drawing.Point(164, 220)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(433, 223)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 20)
        Me.TextBox1.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(744, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(744, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.participantesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SystemUnahNuevo.unahsistemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'Fecha_usuarioLabel1
        '
        Me.Fecha_usuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "fecha_usuario", True))
        Me.Fecha_usuarioLabel1.Location = New System.Drawing.Point(161, 164)
        Me.Fecha_usuarioLabel1.Name = "Fecha_usuarioLabel1"
        Me.Fecha_usuarioLabel1.Size = New System.Drawing.Size(248, 23)
        Me.Fecha_usuarioLabel1.TabIndex = 31
        Me.Fecha_usuarioLabel1.Text = "Label2"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(957, 494)
        Me.Controls.Add(Fecha_usuarioLabel)
        Me.Controls.Add(Me.Fecha_usuarioLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Tipo_usuarioLabel)
        Me.Controls.Add(Me.Tipo_usuarioComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Nombre_usuarioLabel)
        Me.Controls.Add(Me.Nombre_usuarioTextBox)
        Me.Controls.Add(Clave_usuarioLabel)
        Me.Controls.Add(Me.Clave_usuarioTextBox)
        Me.Controls.Add(Estado_usuarioLabel)
        Me.Controls.Add(Me.Estado_usuarioComboBox)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnahsistemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UnahsistemDataSet As unahsistemDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As unahsistemDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As unahsistemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents Nombre_usuarioTextBox As TextBox
    Friend WithEvents Clave_usuarioTextBox As TextBox
    Friend WithEvents Estado_usuarioComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Tipo_usuarioComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Fecha_usuarioLabel1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
