
Namespace CapaPresentacion
    Partial Class FrmCategoria
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
            dtgData = New Windows.Forms.DataGridView()
            Id = New Windows.Forms.DataGridViewTextBoxColumn()
            Correo = New Windows.Forms.DataGridViewTextBoxColumn()
            Contraeña = New Windows.Forms.DataGridViewTextBoxColumn()
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
            label9 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            label7 = New Windows.Forms.Label()
            cboEstado = New Windows.Forms.ComboBox()
            txtdocumentoUsuario = New Windows.Forms.TextBox()
            label6 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            label13 = New Windows.Forms.Label()
            iconButton1 = New FontAwesome.Sharp.IconButton()
            label3 = New Windows.Forms.Label()
            CType(dtgData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(173, 127)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(0, 25)
            label1.TabIndex = 1
            ' 
            ' dtgData
            ' 
            dtgData.AllowUserToAddRows = False
            dtgData.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dtgData.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {Id, Correo, Contraeña, Estado, EstadoValor})
            dtgData.Location = New Drawing.Point(248, 53)
            dtgData.MultiSelect = False
            dtgData.Name = "dtgData"
            dtgData.ReadOnly = True
            dtgData.Size = New Drawing.Size(616, 397)
            dtgData.TabIndex = 45
            ' 
            ' Id
            ' 
            Id.HeaderText = "Id"
            Id.Name = "Id"
            Id.ReadOnly = True
            Id.Visible = False
            Id.Width = 30
            ' 
            ' Correo
            ' 
            Correo.HeaderText = "Descripcion"
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
            cboBusqueda.Location = New Drawing.Point(444, 13)
            cboBusqueda.Name = "cboBusqueda"
            cboBusqueda.Size = New Drawing.Size(102, 21)
            cboBusqueda.TabIndex = 50
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None
            btnLimpiar.IconColor = Drawing.Color.Black
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnLimpiar.Location = New Drawing.Point(808, 16)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New Drawing.Size(75, 23)
            btnLimpiar.TabIndex = 49
            btnLimpiar.Text = "LIMPIAR"
            btnLimpiar.UseVisualStyleBackColor = True
            ' 
            ' btnBusqueda
            ' 
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.None
            btnBusqueda.IconColor = Drawing.Color.Black
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnBusqueda.Location = New Drawing.Point(727, 16)
            btnBusqueda.Name = "btnBusqueda"
            btnBusqueda.Size = New Drawing.Size(75, 23)
            btnBusqueda.TabIndex = 48
            btnBusqueda.Text = "BUSQUEDA"
            btnBusqueda.UseVisualStyleBackColor = True
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.ForeColor = Drawing.Color.White
            label12.Location = New Drawing.Point(379, 21)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(59, 13)
            label12.TabIndex = 47
            label12.Text = "BUSQEDA"
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.ForeColor = Drawing.Color.White
            label11.Location = New Drawing.Point(233, 21)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(97, 13)
            label11.TabIndex = 46
            label11.Text = "Lista de Categorias"
            ' 
            ' txtBusqueda
            ' 
            txtBusqueda.Location = New Drawing.Point(565, 14)
            txtBusqueda.Name = "txtBusqueda"
            txtBusqueda.Size = New Drawing.Size(99, 20)
            txtBusqueda.TabIndex = 51
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(9, 9)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(85, 13)
            label10.TabIndex = 44
            label10.Text = "DetalleCategoria"
            ' 
            ' btnEliminarFRMUsuario
            ' 
            btnEliminarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEliminarFRMUsuario.IconColor = Drawing.Color.Black
            btnEliminarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEliminarFRMUsuario.Location = New Drawing.Point(57, 242)
            btnEliminarFRMUsuario.Name = "btnEliminarFRMUsuario"
            btnEliminarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEliminarFRMUsuario.TabIndex = 43
            btnEliminarFRMUsuario.Text = "ELIMINAR"
            btnEliminarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' btnEditarFRMUsuario
            ' 
            btnEditarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEditarFRMUsuario.IconColor = Drawing.Color.Black
            btnEditarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEditarFRMUsuario.Location = New Drawing.Point(12, 195)
            btnEditarFRMUsuario.Name = "btnEditarFRMUsuario"
            btnEditarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEditarFRMUsuario.TabIndex = 42
            btnEditarFRMUsuario.Text = "GUARDAR"
            btnEditarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' btnGuardarFRMUsuario
            ' 
            btnGuardarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnGuardarFRMUsuario.IconColor = Drawing.Color.Black
            btnGuardarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnGuardarFRMUsuario.Location = New Drawing.Point(-103, 420)
            btnGuardarFRMUsuario.Name = "btnGuardarFRMUsuario"
            btnGuardarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnGuardarFRMUsuario.TabIndex = 41
            btnGuardarFRMUsuario.Text = "GUARDAR"
            btnGuardarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(-80, 149)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(38, 13)
            label9.TabIndex = 39
            label9.Text = "Correo"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.BackColor = Drawing.Color.White
            label8.Location = New Drawing.Point(-80, 360)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(40, 13)
            label8.TabIndex = 38
            label8.Text = "Estado"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.BackColor = Drawing.Color.White
            label7.Location = New Drawing.Point(-80, 294)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(23, 13)
            label7.TabIndex = 37
            label7.Text = "Rol"
            ' 
            ' cboEstado
            ' 
            cboEstado.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboEstado.FormattingEnabled = True
            cboEstado.Location = New Drawing.Point(12, 117)
            cboEstado.Name = "cboEstado"
            cboEstado.Size = New Drawing.Size(168, 21)
            cboEstado.TabIndex = 36
            ' 
            ' txtdocumentoUsuario
            ' 
            txtdocumentoUsuario.Location = New Drawing.Point(12, 53)
            txtdocumentoUsuario.Name = "txtdocumentoUsuario"
            txtdocumentoUsuario.Size = New Drawing.Size(168, 20)
            txtdocumentoUsuario.TabIndex = 32
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(-80, 220)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(61, 13)
            label6.TabIndex = 31
            label6.Text = "Contraseña"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(12, 37)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(63, 13)
            label4.TabIndex = 29
            label4.Text = "Descripcion"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(-22, 59)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 13)
            label2.TabIndex = 27
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.Dock = Windows.Forms.DockStyle.Left
            label13.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label13.Location = New Drawing.Point(0, 0)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(0, 25)
            label13.TabIndex = 26
            ' 
            ' iconButton1
            ' 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton1.IconColor = Drawing.Color.Black
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton1.Location = New Drawing.Point(114, 195)
            iconButton1.Name = "iconButton1"
            iconButton1.Size = New Drawing.Size(75, 23)
            iconButton1.TabIndex = 52
            iconButton1.Text = "EDITAR"
            iconButton1.UseVisualStyleBackColor = True
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.Color.White
            label3.Location = New Drawing.Point(12, 87)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(40, 13)
            label3.TabIndex = 53
            label3.Text = "Estado"
            ' 
            ' FrmCategoria
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.DimGray
            ClientSize = New Drawing.Size(888, 462)
            Controls.Add(label3)
            Controls.Add(iconButton1)
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
            Controls.Add(label9)
            Controls.Add(label8)
            Controls.Add(label7)
            Controls.Add(cboEstado)
            Controls.Add(txtdocumentoUsuario)
            Controls.Add(label6)
            Controls.Add(label4)
            Controls.Add(label2)
            Controls.Add(label13)
            Controls.Add(label1)
            Name = "FrmCategoria"
            Text = "FrmCategoria"
            AddHandler Load, New EventHandler(AddressOf FrmCategoria_Load)
            CType(dtgData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private dtgData As Windows.Forms.DataGridView
        Private Id As Windows.Forms.DataGridViewTextBoxColumn
        Private Correo As Windows.Forms.DataGridViewTextBoxColumn
        Private Contraeña As Windows.Forms.DataGridViewTextBoxColumn
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
        Private label9 As Windows.Forms.Label
        Private label8 As Windows.Forms.Label
        Private label7 As Windows.Forms.Label
        Private cboEstado As Windows.Forms.ComboBox
        Private txtdocumentoUsuario As Windows.Forms.TextBox
        Private label6 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label13 As Windows.Forms.Label
        Private iconButton1 As FontAwesome.Sharp.IconButton
        Private label3 As Windows.Forms.Label
    End Class
End Namespace
