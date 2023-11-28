
Namespace CapaPresentacion
    Partial Class FrmUsuarios
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            label6 = New Windows.Forms.Label()
            txtdocumentoUsuario = New Windows.Forms.TextBox()
            txtNombeCompletoUsuario = New Windows.Forms.TextBox()
            txtClaveUsuario = New Windows.Forms.TextBox()
            cboEstado = New Windows.Forms.ComboBox()
            label7 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            label9 = New Windows.Forms.Label()
            txtCorreoUsuario = New Windows.Forms.TextBox()
            btnGuardarFRMUsuario = New FontAwesome.Sharp.IconButton()
            btnEditarFRMUsuario = New FontAwesome.Sharp.IconButton()
            btnEliminarFRMUsuario = New FontAwesome.Sharp.IconButton()
            label10 = New Windows.Forms.Label()
            dtgData = New Windows.Forms.DataGridView()
            BtnSeleccionar = New Windows.Forms.DataGridViewTextBoxColumn()
            Id_Usuario = New Windows.Forms.DataGridViewTextBoxColumn()
            Documento = New Windows.Forms.DataGridViewTextBoxColumn()
            NombreCompleto = New Windows.Forms.DataGridViewTextBoxColumn()
            Correo = New Windows.Forms.DataGridViewTextBoxColumn()
            Contraeña = New Windows.Forms.DataGridViewTextBoxColumn()
            Id_Rol = New Windows.Forms.DataGridViewTextBoxColumn()
            Rol = New Windows.Forms.DataGridViewTextBoxColumn()
            Estado = New Windows.Forms.DataGridViewTextBoxColumn()
            EstadoValor = New Windows.Forms.DataGridViewTextBoxColumn()
            label11 = New Windows.Forms.Label()
            label12 = New Windows.Forms.Label()
            btnLimpiar = New FontAwesome.Sharp.IconButton()
            btnBusqueda = New FontAwesome.Sharp.IconButton()
            cboBusqueda = New Windows.Forms.ComboBox()
            cboRol = New Windows.Forms.ComboBox()
            txtBusqueda = New Windows.Forms.TextBox()
            CType(dtgData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Dock = Windows.Forms.DockStyle.Left
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(0, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(0, 25)
            label1.TabIndex = 0
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(90, 59)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 13)
            label2.TabIndex = 1
            ' 
            ' label3
            ' 
            label3.BackColor = Drawing.Color.White
            label3.Dock = Windows.Forms.DockStyle.Left
            label3.Location = New Drawing.Point(0, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(296, 463)
            label3.TabIndex = 2
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(32, 26)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(82, 13)
            label4.TabIndex = 3
            label4.Text = "No_Documento"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.White
            label5.Location = New Drawing.Point(32, 83)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(88, 13)
            label5.TabIndex = 4
            label5.Text = "NombreCompleto"
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(32, 220)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(61, 13)
            label6.TabIndex = 5
            label6.Text = "Contraseña"
            ' 
            ' txtdocumentoUsuario
            ' 
            txtdocumentoUsuario.Location = New Drawing.Point(37, 53)
            txtdocumentoUsuario.Name = "txtdocumentoUsuario"
            txtdocumentoUsuario.Size = New Drawing.Size(168, 20)
            txtdocumentoUsuario.TabIndex = 6
            ' 
            ' txtNombeCompletoUsuario
            ' 
            txtNombeCompletoUsuario.Location = New Drawing.Point(37, 114)
            txtNombeCompletoUsuario.Name = "txtNombeCompletoUsuario"
            txtNombeCompletoUsuario.Size = New Drawing.Size(168, 20)
            txtNombeCompletoUsuario.TabIndex = 7
            ' 
            ' txtClaveUsuario
            ' 
            txtClaveUsuario.Location = New Drawing.Point(35, 251)
            txtClaveUsuario.Name = "txtClaveUsuario"
            txtClaveUsuario.PasswordChar = "*"c
            txtClaveUsuario.Size = New Drawing.Size(168, 20)
            txtClaveUsuario.TabIndex = 8
            ' 
            ' cboEstado
            ' 
            cboEstado.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboEstado.FormattingEnabled = True
            cboEstado.Location = New Drawing.Point(37, 387)
            cboEstado.Name = "cboEstado"
            cboEstado.Size = New Drawing.Size(168, 21)
            cboEstado.TabIndex = 10
            AddHandler cboEstado.SelectedIndexChanged, New EventHandler(AddressOf cboEstado_SelectedIndexChanged)
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.BackColor = Drawing.Color.White
            label7.Location = New Drawing.Point(32, 294)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(23, 13)
            label7.TabIndex = 11
            label7.Text = "Rol"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.BackColor = Drawing.Color.White
            label8.Location = New Drawing.Point(32, 360)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(40, 13)
            label8.TabIndex = 12
            label8.Text = "Estado"
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(32, 149)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(38, 13)
            label9.TabIndex = 13
            label9.Text = "Correo"
            ' 
            ' txtCorreoUsuario
            ' 
            txtCorreoUsuario.Location = New Drawing.Point(35, 182)
            txtCorreoUsuario.Name = "txtCorreoUsuario"
            txtCorreoUsuario.Size = New Drawing.Size(168, 20)
            txtCorreoUsuario.TabIndex = 14
            ' 
            ' btnGuardarFRMUsuario
            ' 
            btnGuardarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnGuardarFRMUsuario.IconColor = Drawing.Color.Black
            btnGuardarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnGuardarFRMUsuario.Location = New Drawing.Point(9, 420)
            btnGuardarFRMUsuario.Name = "btnGuardarFRMUsuario"
            btnGuardarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnGuardarFRMUsuario.TabIndex = 15
            btnGuardarFRMUsuario.Text = "GUARDAR"
            btnGuardarFRMUsuario.UseVisualStyleBackColor = True
            AddHandler btnGuardarFRMUsuario.Click, New EventHandler(AddressOf btnGuardarFRMUsuario_Click)
            ' 
            ' btnEditarFRMUsuario
            ' 
            btnEditarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEditarFRMUsuario.IconColor = Drawing.Color.Black
            btnEditarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEditarFRMUsuario.Location = New Drawing.Point(107, 420)
            btnEditarFRMUsuario.Name = "btnEditarFRMUsuario"
            btnEditarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEditarFRMUsuario.TabIndex = 16
            btnEditarFRMUsuario.Text = "EDITAR"
            btnEditarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' btnEliminarFRMUsuario
            ' 
            btnEliminarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEliminarFRMUsuario.IconColor = Drawing.Color.Black
            btnEliminarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEliminarFRMUsuario.Location = New Drawing.Point(202, 420)
            btnEliminarFRMUsuario.Name = "btnEliminarFRMUsuario"
            btnEliminarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEliminarFRMUsuario.TabIndex = 17
            btnEliminarFRMUsuario.Text = "ELIMINAR"
            btnEliminarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(112, 9)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(76, 13)
            label10.TabIndex = 18
            label10.Text = "DetalleUsuario"
            ' 
            ' dtgData
            ' 
            dtgData.AllowUserToAddRows = False
            dtgData.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dtgData.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {BtnSeleccionar, Id_Usuario, Documento, NombreCompleto, Correo, Contraeña, Id_Rol, Rol, Estado, EstadoValor})
            dtgData.Location = New Drawing.Point(302, 59)
            dtgData.MultiSelect = False
            dtgData.Name = "dtgData"
            dtgData.ReadOnly = True
            dtgData.Size = New Drawing.Size(757, 397)
            dtgData.TabIndex = 19
            ' 
            ' BtnSeleccionar
            ' 
            BtnSeleccionar.HeaderText = ""
            BtnSeleccionar.Name = "BtnSeleccionar"
            BtnSeleccionar.ReadOnly = True
            BtnSeleccionar.Width = 30
            ' 
            ' Id_Usuario
            ' 
            Id_Usuario.HeaderText = "Id_Usuario"
            Id_Usuario.Name = "Id_Usuario"
            Id_Usuario.ReadOnly = True
            Id_Usuario.Visible = False
            Id_Usuario.Width = 30
            ' 
            ' Documento
            ' 
            Documento.HeaderText = "No.Documento"
            Documento.Name = "Documento"
            Documento.ReadOnly = True
            Documento.Width = 150
            ' 
            ' NombreCompleto
            ' 
            NombreCompleto.HeaderText = "Nombre Completo"
            NombreCompleto.Name = "NombreCompleto"
            NombreCompleto.ReadOnly = True
            NombreCompleto.Width = 180
            ' 
            ' Correo
            ' 
            Correo.HeaderText = "Correo"
            Correo.Name = "Correo"
            Correo.ReadOnly = True
            Correo.Width = 150
            ' 
            ' Contraeña
            ' 
            Contraeña.HeaderText = "Contraeña"
            Contraeña.Name = "Contraeña"
            Contraeña.ReadOnly = True
            Contraeña.Visible = False
            ' 
            ' Id_Rol
            ' 
            Id_Rol.HeaderText = "Id_Rol"
            Id_Rol.Name = "Id_Rol"
            Id_Rol.ReadOnly = True
            Id_Rol.Visible = False
            ' 
            ' Rol
            ' 
            Rol.HeaderText = "Rol"
            Rol.Name = "Rol"
            Rol.ReadOnly = True
            ' 
            ' Estado
            ' 
            Estado.HeaderText = "Estado"
            Estado.Name = "Estado"
            Estado.ReadOnly = True
            ' 
            ' EstadoValor
            ' 
            EstadoValor.HeaderText = "EstadoValor"
            EstadoValor.Name = "EstadoValor"
            EstadoValor.ReadOnly = True
            EstadoValor.Visible = False
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.ForeColor = Drawing.Color.White
            label11.Location = New Drawing.Point(345, 21)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(86, 13)
            label11.TabIndex = 20
            label11.Text = "Lista de usuarios"
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.ForeColor = Drawing.Color.White
            label12.Location = New Drawing.Point(491, 21)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(59, 13)
            label12.TabIndex = 21
            label12.Text = "BUSQEDA"
            AddHandler label12.Click, New EventHandler(AddressOf label12_Click)
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None
            btnLimpiar.IconColor = Drawing.Color.Black
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnLimpiar.Location = New Drawing.Point(920, 16)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New Drawing.Size(75, 23)
            btnLimpiar.TabIndex = 23
            btnLimpiar.Text = "LIMPIAR"
            btnLimpiar.UseVisualStyleBackColor = True
            ' 
            ' btnBusqueda
            ' 
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.None
            btnBusqueda.IconColor = Drawing.Color.Black
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnBusqueda.Location = New Drawing.Point(839, 16)
            btnBusqueda.Name = "btnBusqueda"
            btnBusqueda.Size = New Drawing.Size(75, 23)
            btnBusqueda.TabIndex = 22
            btnBusqueda.Text = "BUSQUEDA"
            btnBusqueda.UseVisualStyleBackColor = True
            ' 
            ' cboBusqueda
            ' 
            cboBusqueda.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboBusqueda.FormattingEnabled = True
            cboBusqueda.Location = New Drawing.Point(556, 13)
            cboBusqueda.Name = "cboBusqueda"
            cboBusqueda.Size = New Drawing.Size(102, 21)
            cboBusqueda.TabIndex = 24
            ' 
            ' cboRol
            ' 
            cboRol.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboRol.FormattingEnabled = True
            cboRol.Location = New Drawing.Point(35, 325)
            cboRol.Name = "cboRol"
            cboRol.Size = New Drawing.Size(168, 21)
            cboRol.TabIndex = 9
            ' 
            ' txtBusqueda
            ' 
            txtBusqueda.Location = New Drawing.Point(677, 14)
            txtBusqueda.Name = "txtBusqueda"
            txtBusqueda.Size = New Drawing.Size(99, 20)
            txtBusqueda.TabIndex = 25
            ' 
            ' FrmUsuarios
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Black
            ClientSize = New Drawing.Size(1110, 463)
            Controls.Add(txtBusqueda)
            Controls.Add(cboBusqueda)
            Controls.Add(btnLimpiar)
            Controls.Add(btnBusqueda)
            Controls.Add(label12)
            Controls.Add(label11)
            Controls.Add(dtgData)
            Controls.Add(label10)
            Controls.Add(btnEliminarFRMUsuario)
            Controls.Add(btnEditarFRMUsuario)
            Controls.Add(btnGuardarFRMUsuario)
            Controls.Add(txtCorreoUsuario)
            Controls.Add(label9)
            Controls.Add(label8)
            Controls.Add(label7)
            Controls.Add(cboEstado)
            Controls.Add(cboRol)
            Controls.Add(txtClaveUsuario)
            Controls.Add(txtNombeCompletoUsuario)
            Controls.Add(txtdocumentoUsuario)
            Controls.Add(label6)
            Controls.Add(label5)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "FrmUsuarios"
            Text = "FrmUsuariosvb"
            AddHandler Load, New EventHandler(AddressOf FrmUsuarios_Load)
            CType(dtgData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private label6 As Windows.Forms.Label
        Private txtdocumentoUsuario As Windows.Forms.TextBox
        Private txtNombeCompletoUsuario As Windows.Forms.TextBox
        Private txtClaveUsuario As Windows.Forms.TextBox
        Private cboEstado As Windows.Forms.ComboBox
        Private label7 As Windows.Forms.Label
        Private label8 As Windows.Forms.Label
        Private label9 As Windows.Forms.Label
        Private txtCorreoUsuario As Windows.Forms.TextBox
        Private btnGuardarFRMUsuario As FontAwesome.Sharp.IconButton
        Private btnEditarFRMUsuario As FontAwesome.Sharp.IconButton
        Private btnEliminarFRMUsuario As FontAwesome.Sharp.IconButton
        Private label10 As Windows.Forms.Label
        Private dtgData As Windows.Forms.DataGridView
        Private BtnSeleccionar As Windows.Forms.DataGridViewTextBoxColumn
        Private Id_Usuario As Windows.Forms.DataGridViewTextBoxColumn
        Private Documento As Windows.Forms.DataGridViewTextBoxColumn
        Private NombreCompleto As Windows.Forms.DataGridViewTextBoxColumn
        Private Correo As Windows.Forms.DataGridViewTextBoxColumn
        Private Contraeña As Windows.Forms.DataGridViewTextBoxColumn
        Private Id_Rol As Windows.Forms.DataGridViewTextBoxColumn
        Private Rol As Windows.Forms.DataGridViewTextBoxColumn
        Private Estado As Windows.Forms.DataGridViewTextBoxColumn
        Private EstadoValor As Windows.Forms.DataGridViewTextBoxColumn
        Private label11 As Windows.Forms.Label
        Private label12 As Windows.Forms.Label
        Private btnLimpiar As FontAwesome.Sharp.IconButton
        Private btnBusqueda As FontAwesome.Sharp.IconButton
        Private cboBusqueda As Windows.Forms.ComboBox
        Private cboRol As Windows.Forms.ComboBox
        Private txtBusqueda As Windows.Forms.TextBox
    End Class
End Namespace
