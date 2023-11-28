
Namespace CapaPresentacion
    Partial Class FrmCompras
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
            label3 = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            label7 = New Windows.Forms.Label()
            cbotipoDocum = New Windows.Forms.ComboBox()
            txtfecha = New Windows.Forms.TextBox()
            label6 = New Windows.Forms.Label()
            groupBox2 = New Windows.Forms.GroupBox()
            iconButton1 = New FontAwesome.Sharp.IconButton()
            label4 = New Windows.Forms.Label()
            comboBox1 = New Windows.Forms.ComboBox()
            textBox1 = New Windows.Forms.TextBox()
            label5 = New Windows.Forms.Label()
            groupBox3 = New Windows.Forms.GroupBox()
            label12 = New Windows.Forms.Label()
            numericUpDown1 = New Windows.Forms.NumericUpDown()
            textBox4 = New Windows.Forms.TextBox()
            label10 = New Windows.Forms.Label()
            textBox5 = New Windows.Forms.TextBox()
            label11 = New Windows.Forms.Label()
            textBox3 = New Windows.Forms.TextBox()
            label9 = New Windows.Forms.Label()
            btnbuscar = New FontAwesome.Sharp.IconButton()
            textBox2 = New Windows.Forms.TextBox()
            label8 = New Windows.Forms.Label()
            dataGridView1 = New Windows.Forms.DataGridView()
            w = New Windows.Forms.DataGridViewButtonColumn()
            idproducto = New Windows.Forms.DataGridViewTextBoxColumn()
            Producto = New Windows.Forms.DataGridViewTextBoxColumn()
            PrecioCompra = New Windows.Forms.DataGridViewTextBoxColumn()
            PrecioVenat = New Windows.Forms.DataGridViewTextBoxColumn()
            Cantidad = New Windows.Forms.DataGridViewTextBoxColumn()
            SubTotal = New Windows.Forms.DataGridViewTextBoxColumn()
            iconButton2 = New FontAwesome.Sharp.IconButton()
            iconButton3 = New FontAwesome.Sharp.IconButton()
            textBox6 = New Windows.Forms.TextBox()
            label13 = New Windows.Forms.Label()
            groupBox1.SuspendLayout()
            groupBox2.SuspendLayout()
            groupBox3.SuspendLayout()
            CType(numericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
            CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.Color.White
            label3.Dock = Windows.Forms.DockStyle.Fill
            label3.Location = New Drawing.Point(0, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(0, 13)
            label3.TabIndex = 29
            ' 
            ' label1
            ' 
            label1.BackColor = Drawing.Color.White
            label1.Location = New Drawing.Point(45, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(813, 550)
            label1.TabIndex = 30
            AddHandler label1.Click, New EventHandler(AddressOf label1_Click)
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(64, 21)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(46, 13)
            label2.TabIndex = 31
            label2.Text = "Registro"
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(label7)
            groupBox1.Controls.Add(cbotipoDocum)
            groupBox1.Controls.Add(txtfecha)
            groupBox1.Controls.Add(label6)
            groupBox1.Location = New Drawing.Point(67, 37)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(289, 91)
            groupBox1.TabIndex = 32
            groupBox1.TabStop = False
            groupBox1.Text = "InformacionCompra"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.BackColor = Drawing.Color.White
            label7.Location = New Drawing.Point(6, 62)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(86, 13)
            label7.TabIndex = 15
            label7.Text = "Tipo Documento"
            ' 
            ' cbotipoDocum
            ' 
            cbotipoDocum.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbotipoDocum.FormattingEnabled = True
            cbotipoDocum.Location = New Drawing.Point(100, 54)
            cbotipoDocum.Name = "cbotipoDocum"
            cbotipoDocum.Size = New Drawing.Size(168, 21)
            cbotipoDocum.TabIndex = 14
            ' 
            ' txtfecha
            ' 
            txtfecha.Location = New Drawing.Point(98, 22)
            txtfecha.Name = "txtfecha"
            txtfecha.PasswordChar = "*"c
            txtfecha.Size = New Drawing.Size(168, 20)
            txtfecha.TabIndex = 13
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(6, 29)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(37, 13)
            label6.TabIndex = 12
            label6.Text = "Fecha"
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(iconButton1)
            groupBox2.Controls.Add(label4)
            groupBox2.Controls.Add(comboBox1)
            groupBox2.Controls.Add(textBox1)
            groupBox2.Controls.Add(label5)
            groupBox2.Location = New Drawing.Point(362, 37)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(383, 91)
            groupBox2.TabIndex = 33
            groupBox2.TabStop = False
            groupBox2.Text = "Informacion Porveedor"
            ' 
            ' iconButton1
            ' 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton1.IconColor = Drawing.Color.Black
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton1.Location = New Drawing.Point(294, 16)
            iconButton1.Name = "iconButton1"
            iconButton1.Size = New Drawing.Size(66, 23)
            iconButton1.TabIndex = 20
            iconButton1.Text = "Guardar"
            iconButton1.UseVisualStyleBackColor = True
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(8, 59)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(67, 13)
            label4.TabIndex = 19
            label4.Text = "RazonSocial"
            ' 
            ' comboBox1
            ' 
            comboBox1.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            comboBox1.FormattingEnabled = True
            comboBox1.Location = New Drawing.Point(122, 51)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(168, 21)
            comboBox1.TabIndex = 18
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(120, 19)
            textBox1.Name = "textBox1"
            textBox1.PasswordChar = "*"c
            textBox1.Size = New Drawing.Size(168, 20)
            textBox1.TabIndex = 17
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.White
            label5.Location = New Drawing.Point(8, 26)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(99, 13)
            label5.TabIndex = 16
            label5.Text = "NumeroDoucmento"
            ' 
            ' groupBox3
            ' 
            groupBox3.Controls.Add(label12)
            groupBox3.Controls.Add(numericUpDown1)
            groupBox3.Controls.Add(textBox4)
            groupBox3.Controls.Add(label10)
            groupBox3.Controls.Add(textBox5)
            groupBox3.Controls.Add(label11)
            groupBox3.Controls.Add(textBox3)
            groupBox3.Controls.Add(label9)
            groupBox3.Controls.Add(btnbuscar)
            groupBox3.Controls.Add(textBox2)
            groupBox3.Controls.Add(label8)
            groupBox3.Location = New Drawing.Point(67, 134)
            groupBox3.Name = "groupBox3"
            groupBox3.Size = New Drawing.Size(656, 100)
            groupBox3.TabIndex = 34
            groupBox3.TabStop = False
            groupBox3.Text = "Informacion de Porducto"
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.BackColor = Drawing.Color.White
            label12.Location = New Drawing.Point(497, 24)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(49, 13)
            label12.TabIndex = 29
            label12.Text = "Cantidad"
            ' 
            ' numericUpDown1
            ' 
            numericUpDown1.Location = New Drawing.Point(500, 60)
            numericUpDown1.Name = "numericUpDown1"
            numericUpDown1.Size = New Drawing.Size(120, 20)
            numericUpDown1.TabIndex = 28
            ' 
            ' textBox4
            ' 
            textBox4.Location = New Drawing.Point(364, 60)
            textBox4.Name = "textBox4"
            textBox4.PasswordChar = "*"c
            textBox4.Size = New Drawing.Size(103, 20)
            textBox4.TabIndex = 27
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(286, 67)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(65, 13)
            label10.TabIndex = 26
            label10.Text = "PrecioVenta"
            ' 
            ' textBox5
            ' 
            textBox5.Location = New Drawing.Point(364, 21)
            textBox5.Name = "textBox5"
            textBox5.PasswordChar = "*"c
            textBox5.Size = New Drawing.Size(103, 20)
            textBox5.TabIndex = 25
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.BackColor = Drawing.Color.White
            label11.Location = New Drawing.Point(286, 28)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(73, 13)
            label11.TabIndex = 24
            label11.Text = "PrecioCompra"
            ' 
            ' textBox3
            ' 
            textBox3.Location = New Drawing.Point(86, 61)
            textBox3.Name = "textBox3"
            textBox3.PasswordChar = "*"c
            textBox3.Size = New Drawing.Size(103, 20)
            textBox3.TabIndex = 23
            AddHandler textBox3.TextChanged, New EventHandler(AddressOf textBox3_TextChanged)
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(8, 68)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(50, 13)
            label9.TabIndex = 22
            label9.Text = "Producto"
            ' 
            ' btnbuscar
            ' 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.None
            btnbuscar.IconColor = Drawing.Color.Black
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnbuscar.Location = New Drawing.Point(202, 19)
            btnbuscar.Name = "btnbuscar"
            btnbuscar.Size = New Drawing.Size(66, 23)
            btnbuscar.TabIndex = 21
            btnbuscar.Text = "Buscar"
            btnbuscar.UseVisualStyleBackColor = True
            ' 
            ' textBox2
            ' 
            textBox2.Location = New Drawing.Point(86, 22)
            textBox2.Name = "textBox2"
            textBox2.PasswordChar = "*"c
            textBox2.Size = New Drawing.Size(103, 20)
            textBox2.TabIndex = 16
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.BackColor = Drawing.Color.White
            label8.Location = New Drawing.Point(8, 29)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(72, 13)
            label8.TabIndex = 13
            label8.Text = "Cod.Producto"
            ' 
            ' dataGridView1
            ' 
            dataGridView1.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dataGridView1.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {w, idproducto, Producto, PrecioCompra, PrecioVenat, Cantidad, SubTotal})
            dataGridView1.Location = New Drawing.Point(67, 245)
            dataGridView1.Name = "dataGridView1"
            dataGridView1.Size = New Drawing.Size(690, 249)
            dataGridView1.TabIndex = 35
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
            ' iconButton2
            ' 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton2.IconColor = Drawing.Color.Black
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton2.Location = New Drawing.Point(729, 148)
            iconButton2.Name = "iconButton2"
            iconButton2.Size = New Drawing.Size(75, 23)
            iconButton2.TabIndex = 36
            iconButton2.Text = "Agregar"
            iconButton2.UseVisualStyleBackColor = True
            ' 
            ' iconButton3
            ' 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton3.IconColor = Drawing.Color.Black
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton3.Location = New Drawing.Point(766, 321)
            iconButton3.Name = "iconButton3"
            iconButton3.Size = New Drawing.Size(75, 23)
            iconButton3.TabIndex = 37
            iconButton3.Text = "Registrar"
            iconButton3.UseVisualStyleBackColor = True
            ' 
            ' textBox6
            ' 
            textBox6.Location = New Drawing.Point(763, 279)
            textBox6.Name = "textBox6"
            textBox6.PasswordChar = "*"c
            textBox6.Size = New Drawing.Size(95, 20)
            textBox6.TabIndex = 39
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.BackColor = Drawing.Color.White
            label13.Location = New Drawing.Point(763, 250)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(71, 13)
            label13.TabIndex = 38
            label13.Text = "Total a Pagar"
            ' 
            ' FrmCompras
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(875, 594)
            Controls.Add(textBox6)
            Controls.Add(label13)
            Controls.Add(iconButton3)
            Controls.Add(iconButton2)
            Controls.Add(dataGridView1)
            Controls.Add(groupBox3)
            Controls.Add(groupBox2)
            Controls.Add(groupBox1)
            Controls.Add(label2)
            Controls.Add(label1)
            Controls.Add(label3)
            Name = "FrmCompras"
            Text = "FrmCompras"
            AddHandler Load, New EventHandler(AddressOf FrmCompras_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            groupBox3.ResumeLayout(False)
            groupBox3.PerformLayout()
            CType(numericUpDown1, ComponentModel.ISupportInitialize).EndInit()
            CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label3 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private groupBox1 As Windows.Forms.GroupBox
        Private label7 As Windows.Forms.Label
        Private cbotipoDocum As Windows.Forms.ComboBox
        Private txtfecha As Windows.Forms.TextBox
        Private label6 As Windows.Forms.Label
        Private groupBox2 As Windows.Forms.GroupBox
        Private iconButton1 As FontAwesome.Sharp.IconButton
        Private label4 As Windows.Forms.Label
        Private comboBox1 As Windows.Forms.ComboBox
        Private textBox1 As Windows.Forms.TextBox
        Private label5 As Windows.Forms.Label
        Private groupBox3 As Windows.Forms.GroupBox
        Private textBox3 As Windows.Forms.TextBox
        Private label9 As Windows.Forms.Label
        Private btnbuscar As FontAwesome.Sharp.IconButton
        Private textBox2 As Windows.Forms.TextBox
        Private label8 As Windows.Forms.Label
        Private label12 As Windows.Forms.Label
        Private numericUpDown1 As Windows.Forms.NumericUpDown
        Private textBox4 As Windows.Forms.TextBox
        Private label10 As Windows.Forms.Label
        Private textBox5 As Windows.Forms.TextBox
        Private label11 As Windows.Forms.Label
        Private dataGridView1 As Windows.Forms.DataGridView
        Private w As Windows.Forms.DataGridViewButtonColumn
        Private idproducto As Windows.Forms.DataGridViewTextBoxColumn
        Private Producto As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioCompra As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioVenat As Windows.Forms.DataGridViewTextBoxColumn
        Private Cantidad As Windows.Forms.DataGridViewTextBoxColumn
        Private SubTotal As Windows.Forms.DataGridViewTextBoxColumn
        Private iconButton2 As FontAwesome.Sharp.IconButton
        Private iconButton3 As FontAwesome.Sharp.IconButton
        Private textBox6 As Windows.Forms.TextBox
        Private label13 As Windows.Forms.Label
    End Class
End Namespace
