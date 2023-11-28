
Namespace CapaPresentacion
    Partial Class FrmProducto
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
            dtgData = New Windows.Forms.DataGridView()
            BtnSeleccionar = New Windows.Forms.DataGridViewTextBoxColumn()
            Id_Usuario = New Windows.Forms.DataGridViewTextBoxColumn()
            codigo = New Windows.Forms.DataGridViewTextBoxColumn()
            Nombre = New Windows.Forms.DataGridViewTextBoxColumn()
            Descripcion = New Windows.Forms.DataGridViewTextBoxColumn()
            Id_Categoria = New Windows.Forms.DataGridViewTextBoxColumn()
            Categoria = New Windows.Forms.DataGridViewTextBoxColumn()
            Estado = New Windows.Forms.DataGridViewTextBoxColumn()
            EstadoValor = New Windows.Forms.DataGridViewTextBoxColumn()
            Stock = New Windows.Forms.DataGridViewTextBoxColumn()
            PrecioCompra = New Windows.Forms.DataGridViewTextBoxColumn()
            PrecioVenta = New Windows.Forms.DataGridViewTextBoxColumn()
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
            txtDescripcion = New Windows.Forms.TextBox()
            label9 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            label7 = New Windows.Forms.Label()
            cboEstado = New Windows.Forms.ComboBox()
            cboRol = New Windows.Forms.ComboBox()
            txtNombe = New Windows.Forms.TextBox()
            txtcodigo = New Windows.Forms.TextBox()
            label5 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            label13 = New Windows.Forms.Label()
            label14 = New Windows.Forms.Label()
            label6 = New Windows.Forms.Label()
            CType(dtgData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(204, 148)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(0, 25)
            label1.TabIndex = 1
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(209, 132)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 13)
            label2.TabIndex = 2
            ' 
            ' dtgData
            ' 
            dtgData.AllowUserToAddRows = False
            dtgData.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dtgData.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {BtnSeleccionar, Id_Usuario, codigo, Nombre, Descripcion, Id_Categoria, Categoria, Estado, EstadoValor, Stock, PrecioCompra, PrecioVenta})
            dtgData.Location = New Drawing.Point(210, 56)
            dtgData.MultiSelect = False
            dtgData.Name = "dtgData"
            dtgData.ReadOnly = True
            dtgData.Size = New Drawing.Size(1032, 397)
            dtgData.TabIndex = 45
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
            ' codigo
            ' 
            codigo.HeaderText = "codigo"
            codigo.Name = "codigo"
            codigo.ReadOnly = True
            codigo.Width = 150
            ' 
            ' Nombre
            ' 
            Nombre.HeaderText = "Nombre"
            Nombre.Name = "Nombre"
            Nombre.ReadOnly = True
            Nombre.Width = 180
            ' 
            ' Descripcion
            ' 
            Descripcion.HeaderText = "Descripcion"
            Descripcion.Name = "Descripcion"
            Descripcion.ReadOnly = True
            Descripcion.Width = 150
            ' 
            ' Id_Categoria
            ' 
            Id_Categoria.HeaderText = "Id_Categoria"
            Id_Categoria.Name = "Id_Categoria"
            Id_Categoria.ReadOnly = True
            Id_Categoria.Visible = False
            ' 
            ' Categoria
            ' 
            Categoria.HeaderText = "Categoria"
            Categoria.Name = "Categoria"
            Categoria.ReadOnly = True
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
            ' Stock
            ' 
            Stock.HeaderText = "Stock"
            Stock.Name = "Stock"
            Stock.ReadOnly = True
            ' 
            ' PrecioCompra
            ' 
            PrecioCompra.HeaderText = "Precio Compra"
            PrecioCompra.Name = "PrecioCompra"
            PrecioCompra.ReadOnly = True
            ' 
            ' PrecioVenta
            ' 
            PrecioVenta.HeaderText = "Precio Venta"
            PrecioVenta.Name = "PrecioVenta"
            PrecioVenta.ReadOnly = True
            ' 
            ' cboBusqueda
            ' 
            cboBusqueda.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboBusqueda.FormattingEnabled = True
            cboBusqueda.Location = New Drawing.Point(494, 13)
            cboBusqueda.Name = "cboBusqueda"
            cboBusqueda.Size = New Drawing.Size(102, 21)
            cboBusqueda.TabIndex = 50
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None
            btnLimpiar.IconColor = Drawing.Color.Black
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnLimpiar.Location = New Drawing.Point(858, 16)
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
            btnBusqueda.Location = New Drawing.Point(777, 16)
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
            label12.Location = New Drawing.Point(429, 21)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(59, 13)
            label12.TabIndex = 47
            label12.Text = "BUSQEDA"
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.ForeColor = Drawing.Color.White
            label11.Location = New Drawing.Point(321, 21)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(94, 13)
            label11.TabIndex = 46
            label11.Text = "Lista de productos"
            ' 
            ' txtBusqueda
            ' 
            txtBusqueda.Location = New Drawing.Point(615, 14)
            txtBusqueda.Name = "txtBusqueda"
            txtBusqueda.Size = New Drawing.Size(99, 20)
            txtBusqueda.TabIndex = 51
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(50, 9)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(86, 13)
            label10.TabIndex = 44
            label10.Text = "Detalle Producto"
            ' 
            ' btnEliminarFRMUsuario
            ' 
            btnEliminarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnEliminarFRMUsuario.IconColor = Drawing.Color.Black
            btnEliminarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnEliminarFRMUsuario.Location = New Drawing.Point(53, 461)
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
            btnEditarFRMUsuario.Location = New Drawing.Point(103, 423)
            btnEditarFRMUsuario.Name = "btnEditarFRMUsuario"
            btnEditarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnEditarFRMUsuario.TabIndex = 42
            btnEditarFRMUsuario.Text = "EDITAR"
            btnEditarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' btnGuardarFRMUsuario
            ' 
            btnGuardarFRMUsuario.IconChar = FontAwesome.Sharp.IconChar.None
            btnGuardarFRMUsuario.IconColor = Drawing.Color.Black
            btnGuardarFRMUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnGuardarFRMUsuario.Location = New Drawing.Point(5, 423)
            btnGuardarFRMUsuario.Name = "btnGuardarFRMUsuario"
            btnGuardarFRMUsuario.Size = New Drawing.Size(75, 23)
            btnGuardarFRMUsuario.TabIndex = 41
            btnGuardarFRMUsuario.Text = "GUARDAR"
            btnGuardarFRMUsuario.UseVisualStyleBackColor = True
            ' 
            ' txtDescripcion
            ' 
            txtDescripcion.Location = New Drawing.Point(31, 185)
            txtDescripcion.Name = "txtDescripcion"
            txtDescripcion.Size = New Drawing.Size(168, 20)
            txtDescripcion.TabIndex = 40
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(28, 152)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(63, 13)
            label9.TabIndex = 39
            label9.Text = "Descripcion"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.BackColor = Drawing.Color.White
            label8.Location = New Drawing.Point(28, 291)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(40, 13)
            label8.TabIndex = 38
            label8.Text = "Estado"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.BackColor = Drawing.Color.White
            label7.Location = New Drawing.Point(-30, 294)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(23, 13)
            label7.TabIndex = 37
            label7.Text = "Rol"
            ' 
            ' cboEstado
            ' 
            cboEstado.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboEstado.FormattingEnabled = True
            cboEstado.Location = New Drawing.Point(33, 318)
            cboEstado.Name = "cboEstado"
            cboEstado.Size = New Drawing.Size(168, 21)
            cboEstado.TabIndex = 36
            ' 
            ' cboRol
            ' 
            cboRol.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboRol.FormattingEnabled = True
            cboRol.Location = New Drawing.Point(31, 256)
            cboRol.Name = "cboRol"
            cboRol.Size = New Drawing.Size(168, 21)
            cboRol.TabIndex = 35
            ' 
            ' txtNombe
            ' 
            txtNombe.Location = New Drawing.Point(33, 117)
            txtNombe.Name = "txtNombe"
            txtNombe.Size = New Drawing.Size(168, 20)
            txtNombe.TabIndex = 33
            ' 
            ' txtcodigo
            ' 
            txtcodigo.Location = New Drawing.Point(33, 56)
            txtcodigo.Name = "txtcodigo"
            txtcodigo.Size = New Drawing.Size(168, 20)
            txtcodigo.TabIndex = 32
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.White
            label5.Location = New Drawing.Point(28, 86)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(44, 13)
            label5.TabIndex = 30
            label5.Text = "Nombre"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(28, 26)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(40, 13)
            label4.TabIndex = 29
            label4.Text = "Codigo"
            ' 
            ' label3
            ' 
            label3.BackColor = Drawing.Color.White
            label3.Dock = Windows.Forms.DockStyle.Left
            label3.Location = New Drawing.Point(0, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(209, 485)
            label3.TabIndex = 28
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.Location = New Drawing.Point(28, 59)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(0, 13)
            label13.TabIndex = 27
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.Dock = Windows.Forms.DockStyle.Left
            label14.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label14.Location = New Drawing.Point(0, 0)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(0, 25)
            label14.TabIndex = 26
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(30, 227)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(52, 13)
            label6.TabIndex = 52
            label6.Text = "Categoria"
            ' 
            ' FrmProducto
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Black
            ClientSize = New Drawing.Size(1254, 485)
            Controls.Add(label6)
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
            Controls.Add(txtDescripcion)
            Controls.Add(label9)
            Controls.Add(label8)
            Controls.Add(label7)
            Controls.Add(cboEstado)
            Controls.Add(cboRol)
            Controls.Add(txtNombe)
            Controls.Add(txtcodigo)
            Controls.Add(label5)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(label13)
            Controls.Add(label14)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "FrmProducto"
            Text = "FrmProducto"
            AddHandler Load, New EventHandler(AddressOf FrmProducto_Load)
            CType(dtgData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private dtgData As Windows.Forms.DataGridView
        Private BtnSeleccionar As Windows.Forms.DataGridViewTextBoxColumn
        Private Id_Usuario As Windows.Forms.DataGridViewTextBoxColumn
        Private codigo As Windows.Forms.DataGridViewTextBoxColumn
        Private Nombre As Windows.Forms.DataGridViewTextBoxColumn
        Private Descripcion As Windows.Forms.DataGridViewTextBoxColumn
        Private Id_Categoria As Windows.Forms.DataGridViewTextBoxColumn
        Private Categoria As Windows.Forms.DataGridViewTextBoxColumn
        Private Estado As Windows.Forms.DataGridViewTextBoxColumn
        Private EstadoValor As Windows.Forms.DataGridViewTextBoxColumn
        Private Stock As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioCompra As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioVenta As Windows.Forms.DataGridViewTextBoxColumn
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
        Private txtDescripcion As Windows.Forms.TextBox
        Private label9 As Windows.Forms.Label
        Private label8 As Windows.Forms.Label
        Private label7 As Windows.Forms.Label
        Private cboEstado As Windows.Forms.ComboBox
        Private cboRol As Windows.Forms.ComboBox
        Private txtNombe As Windows.Forms.TextBox
        Private txtcodigo As Windows.Forms.TextBox
        Private label5 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private label13 As Windows.Forms.Label
        Private label14 As Windows.Forms.Label
        Private label6 As Windows.Forms.Label
    End Class
End Namespace
