
Namespace CapaPresentacion
    Partial Class FrmProveedroes
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
            dtgData = New Windows.Forms.DataGridView()
            BtnSeleccionar = New Windows.Forms.DataGridViewTextBoxColumn()
            Id_Usuario = New Windows.Forms.DataGridViewTextBoxColumn()
            Documento = New Windows.Forms.DataGridViewTextBoxColumn()
            razonsocial = New Windows.Forms.DataGridViewTextBoxColumn()
            Correo = New Windows.Forms.DataGridViewTextBoxColumn()
            telefono = New Windows.Forms.DataGridViewTextBoxColumn()
            Estado = New Windows.Forms.DataGridViewTextBoxColumn()
            EstadoValor = New Windows.Forms.DataGridViewTextBoxColumn()
            cboBusqueda = New Windows.Forms.ComboBox()
            btnLimpiar = New FontAwesome.Sharp.IconButton()
            btnBusqueda = New FontAwesome.Sharp.IconButton()
            label12 = New Windows.Forms.Label()
            label11 = New Windows.Forms.Label()
            txtBusqueda = New Windows.Forms.TextBox()
            label10 = New Windows.Forms.Label()
            btnEliminarFRMUsuario = New FontAwesome.Sharp.IconButton()
            btnEditarFRMUsuario = New FontAwesome.Sharp.IconButton()
            btnGuardarFRMUsuario = New FontAwesome.Sharp.IconButton()
            txtCorreoUsuario = New Windows.Forms.TextBox()
            label9 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            cboEstado = New Windows.Forms.ComboBox()
            txtClaveUsuario = New Windows.Forms.TextBox()
            txtRazonSocial = New Windows.Forms.TextBox()
            txtdocumentoUsuario = New Windows.Forms.TextBox()
            label6 = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            CType(dtgData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' dtgData
            ' 
            dtgData.AllowUserToAddRows = False
            dtgData.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dtgData.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {BtnSeleccionar, Id_Usuario, Documento, razonsocial, Correo, telefono, Estado, EstadoValor})
            dtgData.Location = New Drawing.Point(243, 59)
            dtgData.MultiSelect = False
            dtgData.Name = "dtgData"
            dtgData.ReadOnly = True
            dtgData.Size = New Drawing.Size(755, 392)
            dtgData.TabIndex = 69
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
            Id_Usuario.HeaderText = "Id"
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
            ' razonsocial
            ' 
            razonsocial.HeaderText = "Razon Social"
            razonsocial.Name = "razonsocial"
            razonsocial.ReadOnly = True
            razonsocial.Width = 180
            ' 
            ' Correo
            ' 
            Correo.HeaderText = "Correo"
            Correo.Name = "Correo"
            Correo.ReadOnly = True
            Correo.Width = 150
            ' 
            ' telefono
            ' 
            telefono.HeaderText = "telefono"
            telefono.Name = "telefono"
            telefono.ReadOnly = True
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
            ' cboBusqueda
            ' 
            cboBusqueda.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboBusqueda.FormattingEnabled = True
            cboBusqueda.Location = New Drawing.Point(578, 13)
            cboBusqueda.Name = "cboBusqueda"
            cboBusqueda.Size = New Drawing.Size(102, 21)
            cboBusqueda.TabIndex = 74
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None
            btnLimpiar.IconColor = Drawing.Color.Black
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnLimpiar.Location = New Drawing.Point(942, 16)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New Drawing.Size(75, 23)
            btnLimpiar.TabIndex = 73
            btnLimpiar.Text = "LIMPIAR"
            btnLimpiar.UseVisualStyleBackColor = True
            ' 
            ' btnBusqueda
            ' 
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.None
            btnBusqueda.IconColor = Drawing.Color.Black
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnBusqueda.Location = New Drawing.Point(861, 16)
            btnBusqueda.Name = "btnBusqueda"
            btnBusqueda.Size = New Drawing.Size(75, 23)
            btnBusqueda.TabIndex = 72
            btnBusqueda.Text = "BUSQUEDA"
            btnBusqueda.UseVisualStyleBackColor = True
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.ForeColor = Drawing.Color.White
            label12.Location = New Drawing.Point(513, 21)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(59, 13)
            label12.TabIndex = 71
            label12.Text = "BUSQEDA"
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.ForeColor = Drawing.Color.White
            label11.Location = New Drawing.Point(367, 21)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(106, 13)
            label11.TabIndex = 70
            label11.Text = "Lista de proveedroes"
            ' 
            ' txtBusqueda
            ' 
            txtBusqueda.Location = New Drawing.Point(699, 14)
            txtBusqueda.Name = "txtBusqueda"
            txtBusqueda.Size = New Drawing.Size(99, 20)
            txtBusqueda.TabIndex = 75
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(106, 8)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(89, 13)
            label10.TabIndex = 68
            label10.Text = "DetalleProveedor"
            ' 
            ' btnEliminarFRMUsuario
            ' 
            btnEliminarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEliminarFRMUsuario.IconColor = Drawing.Color.Black
            btnEliminarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEliminarFRMUsuario.Location = New Drawing.Point(51, 409)
            btnEliminarFRMUsuario.Name = "btnEliminarFRMUsuario"
            btnEliminarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEliminarFRMUsuario.TabIndex = 67
            btnEliminarFRMUsuario.Text = "ELIMINAR"
            btnEliminarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' btnEditarFRMUsuario
            ' 
            btnEditarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEditarFRMUsuario.IconColor = Drawing.Color.Black
            btnEditarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEditarFRMUsuario.Location = New Drawing.Point(101, 361)
            btnEditarFRMUsuario.Name = "btnEditarFRMUsuario"
            btnEditarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEditarFRMUsuario.TabIndex = 66
            btnEditarFRMUsuario.Text = "EDITAR"
            btnEditarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' btnGuardarFRMUsuario
            ' 
            btnGuardarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnGuardarFRMUsuario.IconColor = Drawing.Color.Black
            btnGuardarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnGuardarFRMUsuario.Location = New Drawing.Point(3, 361)
            btnGuardarFRMUsuario.Name = "btnGuardarFRMUsuario"
            btnGuardarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnGuardarFRMUsuario.TabIndex = 65
            btnGuardarFRMUsuario.Text = "GUARDAR"
            btnGuardarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' txtCorreoUsuario
            ' 
            txtCorreoUsuario.Location = New Drawing.Point(29, 181)
            txtCorreoUsuario.Name = "txtCorreoUsuario"
            txtCorreoUsuario.Size = New Drawing.Size(168, 20)
            txtCorreoUsuario.TabIndex = 64
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(26, 148)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(38, 13)
            label9.TabIndex = 63
            label9.Text = "Correo"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.BackColor = Drawing.Color.White
            label8.Location = New Drawing.Point(26, 301)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(40, 13)
            label8.TabIndex = 62
            label8.Text = "Estado"
            ' 
            ' cboEstado
            ' 
            cboEstado.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboEstado.FormattingEnabled = True
            cboEstado.Location = New Drawing.Point(31, 328)
            cboEstado.Name = "cboEstado"
            cboEstado.Size = New Drawing.Size(168, 21)
            cboEstado.TabIndex = 61
            ' 
            ' txtClaveUsuario
            ' 
            txtClaveUsuario.Location = New Drawing.Point(29, 250)
            txtClaveUsuario.Name = "txtClaveUsuario"
            txtClaveUsuario.PasswordChar = "*"c
            txtClaveUsuario.Size = New Drawing.Size(168, 20)
            txtClaveUsuario.TabIndex = 60
            ' 
            ' txtRazonSocial
            ' 
            txtRazonSocial.Location = New Drawing.Point(31, 113)
            txtRazonSocial.Name = "txtRazonSocial"
            txtRazonSocial.Size = New Drawing.Size(168, 20)
            txtRazonSocial.TabIndex = 59
            ' 
            ' txtdocumentoUsuario
            ' 
            txtdocumentoUsuario.Location = New Drawing.Point(31, 52)
            txtdocumentoUsuario.Name = "txtdocumentoUsuario"
            txtdocumentoUsuario.Size = New Drawing.Size(168, 20)
            txtdocumentoUsuario.TabIndex = 58
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(26, 219)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(49, 13)
            label6.TabIndex = 57
            label6.Text = "Telefono"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.White
            label5.Location = New Drawing.Point(26, 82)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(67, 13)
            label5.TabIndex = 56
            label5.Text = "RazonSocial"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(26, 25)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(82, 13)
            label4.TabIndex = 55
            label4.Text = "No_Documento"
            ' 
            ' label3
            ' 
            label3.BackColor = Drawing.Color.White
            label3.Dock = Windows.Forms.DockStyle.Left
            label3.Location = New Drawing.Point(0, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(219, 460)
            label3.TabIndex = 54
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(112, 59)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 13)
            label2.TabIndex = 53
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Dock = Windows.Forms.DockStyle.Left
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(0, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(0, 25)
            label1.TabIndex = 52
            ' 
            ' FrmProveedroes
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Black
            ClientSize = New Drawing.Size(1000, 460)
            Controls.Add(dtgData)
            Controls.Add(cboBusqueda)
            Controls.Add(btnLimpiar)
            Controls.Add(btnBusqueda)
            Controls.Add(label12)
            Controls.Add(label11)
            Controls.Add(txtBusqueda)
            Controls.Add(label10)
            Controls.Add(btnEliminarFRMUsuario)
            Controls.Add(btnEditarFRMUsuario)
            Controls.Add(btnGuardarFRMUsuario)
            Controls.Add(txtCorreoUsuario)
            Controls.Add(label9)
            Controls.Add(label8)
            Controls.Add(cboEstado)
            Controls.Add(txtClaveUsuario)
            Controls.Add(txtRazonSocial)
            Controls.Add(txtdocumentoUsuario)
            Controls.Add(label6)
            Controls.Add(label5)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "FrmProveedroes"
            Text = "FrmProveedroes"
            AddHandler Load, New EventHandler(AddressOf FrmProveedroes_Load)
            CType(dtgData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private dtgData As Windows.Forms.DataGridView
        Private BtnSeleccionar As Windows.Forms.DataGridViewTextBoxColumn
        Private Id_Usuario As Windows.Forms.DataGridViewTextBoxColumn
        Private Documento As Windows.Forms.DataGridViewTextBoxColumn
        Private razonsocial As Windows.Forms.DataGridViewTextBoxColumn
        Private Correo As Windows.Forms.DataGridViewTextBoxColumn
        Private telefono As Windows.Forms.DataGridViewTextBoxColumn
        Private Estado As Windows.Forms.DataGridViewTextBoxColumn
        Private EstadoValor As Windows.Forms.DataGridViewTextBoxColumn
        Private cboBusqueda As Windows.Forms.ComboBox
        Private btnLimpiar As FontAwesome.Sharp.IconButton
        Private btnBusqueda As FontAwesome.Sharp.IconButton
        Private label12 As Windows.Forms.Label
        Private label11 As Windows.Forms.Label
        Private txtBusqueda As Windows.Forms.TextBox
        Private label10 As Windows.Forms.Label
        Private btnEliminarFRMUsuario As FontAwesome.Sharp.IconButton
        Private btnEditarFRMUsuario As FontAwesome.Sharp.IconButton
        Private btnGuardarFRMUsuario As FontAwesome.Sharp.IconButton
        Private txtCorreoUsuario As Windows.Forms.TextBox
        Private label9 As Windows.Forms.Label
        Private label8 As Windows.Forms.Label
        Private cboEstado As Windows.Forms.ComboBox
        Private txtClaveUsuario As Windows.Forms.TextBox
        Private txtRazonSocial As Windows.Forms.TextBox
        Private txtdocumentoUsuario As Windows.Forms.TextBox
        Private label6 As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
    End Class
End Namespace
