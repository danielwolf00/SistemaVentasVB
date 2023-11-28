
Namespace CapaPresentacion
    Partial Class FrmDetalleCompra
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
            label2 = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            label7 = New Windows.Forms.Label()
            cbotipoDocum = New Windows.Forms.ComboBox()
            txtfecha = New Windows.Forms.TextBox()
            label6 = New Windows.Forms.Label()
            btnbuscar = New FontAwesome.Sharp.IconButton()
            textBox2 = New Windows.Forms.TextBox()
            label8 = New Windows.Forms.Label()
            iconButton2 = New FontAwesome.Sharp.IconButton()
            textBox1 = New Windows.Forms.TextBox()
            label3 = New Windows.Forms.Label()
            textBox3 = New Windows.Forms.TextBox()
            label4 = New Windows.Forms.Label()
            textBox4 = New Windows.Forms.TextBox()
            label5 = New Windows.Forms.Label()
            groupBox2 = New Windows.Forms.GroupBox()
            dataGridView1 = New Windows.Forms.DataGridView()
            w = New Windows.Forms.DataGridViewButtonColumn()
            idproducto = New Windows.Forms.DataGridViewTextBoxColumn()
            Producto = New Windows.Forms.DataGridViewTextBoxColumn()
            PrecioCompra = New Windows.Forms.DataGridViewTextBoxColumn()
            PrecioVenat = New Windows.Forms.DataGridViewTextBoxColumn()
            Cantidad = New Windows.Forms.DataGridViewTextBoxColumn()
            SubTotal = New Windows.Forms.DataGridViewTextBoxColumn()
            textBox5 = New Windows.Forms.TextBox()
            label9 = New Windows.Forms.Label()
            groupBox1.SuspendLayout()
            groupBox2.SuspendLayout()
            CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label2
            ' 
            label2.BackColor = Drawing.Color.White
            label2.Location = New Drawing.Point(55, 26)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(607, 470)
            label2.TabIndex = 2
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(125, 13)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(79, 13)
            label1.TabIndex = 3
            label1.Text = "Detalle Compra"
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(textBox1)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(label7)
            groupBox1.Controls.Add(cbotipoDocum)
            groupBox1.Controls.Add(txtfecha)
            groupBox1.Controls.Add(label6)
            groupBox1.Location = New Drawing.Point(73, 82)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(533, 91)
            groupBox1.TabIndex = 33
            groupBox1.TabStop = False
            groupBox1.Text = "InformacionCompra"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.BackColor = Drawing.Color.White
            label7.Location = New Drawing.Point(262, 13)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(86, 13)
            label7.TabIndex = 15
            label7.Text = "Tipo Documento"
            ' 
            ' cbotipoDocum
            ' 
            cbotipoDocum.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbotipoDocum.FormattingEnabled = True
            cbotipoDocum.Location = New Drawing.Point(180, 29)
            cbotipoDocum.Name = "cbotipoDocum"
            cbotipoDocum.Size = New Drawing.Size(168, 21)
            cbotipoDocum.TabIndex = 14
            ' 
            ' txtfecha
            ' 
            txtfecha.Location = New Drawing.Point(6, 29)
            txtfecha.Name = "txtfecha"
            txtfecha.PasswordChar = "*"c
            txtfecha.Size = New Drawing.Size(168, 20)
            txtfecha.TabIndex = 13
            AddHandler txtfecha.TextChanged, New EventHandler(AddressOf txtfecha_TextChanged)
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(128, 13)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(37, 13)
            label6.TabIndex = 12
            label6.Text = "Fecha"
            ' 
            ' btnbuscar
            ' 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.None
            btnbuscar.IconColor = Drawing.Color.Black
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnbuscar.Location = New Drawing.Point(459, 38)
            btnbuscar.Name = "btnbuscar"
            btnbuscar.Size = New Drawing.Size(66, 23)
            btnbuscar.TabIndex = 39
            btnbuscar.Text = "Buscar"
            btnbuscar.UseVisualStyleBackColor = True
            'this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            ' 
            ' textBox2
            ' 
            textBox2.Location = New Drawing.Point(350, 42)
            textBox2.Name = "textBox2"
            textBox2.PasswordChar = "*"c
            textBox2.Size = New Drawing.Size(103, 20)
            textBox2.TabIndex = 38
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.BackColor = Drawing.Color.White
            label8.Location = New Drawing.Point(247, 48)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(97, 13)
            label8.TabIndex = 37
            label8.Text = "Nuevo Documento"
            ' 
            ' iconButton2
            ' 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton2.IconColor = Drawing.Color.Black
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton2.Location = New Drawing.Point(531, 39)
            iconButton2.Name = "iconButton2"
            iconButton2.RightToLeft = Windows.Forms.RightToLeft.No
            iconButton2.Size = New Drawing.Size(75, 23)
            iconButton2.TabIndex = 41
            iconButton2.Text = "Limpiar"
            iconButton2.UseVisualStyleBackColor = True
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(354, 30)
            textBox1.Name = "textBox1"
            textBox1.PasswordChar = "*"c
            textBox1.Size = New Drawing.Size(168, 20)
            textBox1.TabIndex = 17
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.Color.White
            label3.Location = New Drawing.Point(476, 14)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(43, 13)
            label3.TabIndex = 16
            label3.Text = "Usuario"
            ' 
            ' textBox3
            ' 
            textBox3.Location = New Drawing.Point(180, 29)
            textBox3.Name = "textBox3"
            textBox3.PasswordChar = "*"c
            textBox3.Size = New Drawing.Size(168, 20)
            textBox3.TabIndex = 17
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(278, 13)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(70, 13)
            label4.TabIndex = 16
            label4.Text = "Razon Social"
            ' 
            ' textBox4
            ' 
            textBox4.Location = New Drawing.Point(6, 29)
            textBox4.Name = "textBox4"
            textBox4.PasswordChar = "*"c
            textBox4.Size = New Drawing.Size(168, 20)
            textBox4.TabIndex = 13
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.White
            label5.Location = New Drawing.Point(75, 13)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(99, 13)
            label5.TabIndex = 12
            label5.Text = "NumeroDoucmento"
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(textBox3)
            groupBox2.Controls.Add(label4)
            groupBox2.Controls.Add(textBox4)
            groupBox2.Controls.Add(label5)
            groupBox2.Location = New Drawing.Point(73, 179)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(533, 91)
            groupBox2.TabIndex = 42
            groupBox2.TabStop = False
            groupBox2.Text = "InformacionProveedor"
            ' 
            ' dataGridView1
            ' 
            dataGridView1.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dataGridView1.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {w, idproducto, Producto, PrecioCompra, PrecioVenat, Cantidad, SubTotal})
            dataGridView1.Location = New Drawing.Point(79, 293)
            dataGridView1.Name = "dataGridView1"
            dataGridView1.Size = New Drawing.Size(527, 139)
            dataGridView1.TabIndex = 43
            ' 
            ' w
            ' 
            w.HeaderText = ""
            w.Name = "w"
            ' 
            ' idproducto
            ' 
            idproducto.HeaderText = "IdProducto"
            idproducto.Name = "idproducto"
            idproducto.Visible = False
            ' 
            ' Producto
            ' 
            Producto.HeaderText = "Producto"
            Producto.Name = "Producto"
            ' 
            ' PrecioCompra
            ' 
            PrecioCompra.HeaderText = "Precio Compra"
            PrecioCompra.Name = "PrecioCompra"
            ' 
            ' PrecioVenat
            ' 
            PrecioVenat.HeaderText = "Precio Venta"
            PrecioVenat.Name = "PrecioVenat"
            PrecioVenat.Visible = False
            ' 
            ' Cantidad
            ' 
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Name = "Cantidad"
            ' 
            ' SubTotal
            ' 
            SubTotal.HeaderText = "SubTotal"
            SubTotal.Name = "SubTotal"
            ' 
            ' textBox5
            ' 
            textBox5.Location = New Drawing.Point(143, 461)
            textBox5.Name = "textBox5"
            textBox5.PasswordChar = "*"c
            textBox5.Size = New Drawing.Size(79, 20)
            textBox5.TabIndex = 45
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(76, 468)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(61, 13)
            label9.TabIndex = 44
            label9.Text = "MontoTotal"
            ' 
            ' FrmDetalleCompra
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(824, 548)
            Controls.Add(textBox5)
            Controls.Add(label9)
            Controls.Add(dataGridView1)
            Controls.Add(groupBox2)
            Controls.Add(btnbuscar)
            Controls.Add(textBox2)
            Controls.Add(label8)
            Controls.Add(iconButton2)
            Controls.Add(groupBox1)
            Controls.Add(label1)
            Controls.Add(label2)
            Name = "FrmDetalleCompra"
            Text = "FrmDetalleCompra"
            AddHandler Load, New EventHandler(AddressOf FrmDetalleCompra_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label2 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private groupBox1 As Windows.Forms.GroupBox
        Private label7 As Windows.Forms.Label
        Private cbotipoDocum As Windows.Forms.ComboBox
        Private txtfecha As Windows.Forms.TextBox
        Private label6 As Windows.Forms.Label
        Private btnbuscar As FontAwesome.Sharp.IconButton
        Private textBox2 As Windows.Forms.TextBox
        Private label8 As Windows.Forms.Label
        Private iconButton2 As FontAwesome.Sharp.IconButton
        Private textBox1 As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
        Private textBox3 As Windows.Forms.TextBox
        Private label4 As Windows.Forms.Label
        Private textBox4 As Windows.Forms.TextBox
        Private label5 As Windows.Forms.Label
        Private groupBox2 As Windows.Forms.GroupBox
        Private dataGridView1 As Windows.Forms.DataGridView
        Private w As Windows.Forms.DataGridViewButtonColumn
        Private idproducto As Windows.Forms.DataGridViewTextBoxColumn
        Private Producto As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioCompra As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioVenat As Windows.Forms.DataGridViewTextBoxColumn
        Private Cantidad As Windows.Forms.DataGridViewTextBoxColumn
        Private SubTotal As Windows.Forms.DataGridViewTextBoxColumn
        Private textBox5 As Windows.Forms.TextBox
        Private label9 As Windows.Forms.Label
    End Class
End Namespace
