
Namespace CapaPresentacion
    Partial Class FrmDetalleVenta
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
            groupBox2 = New Windows.Forms.GroupBox()
            textBox3 = New Windows.Forms.TextBox()
            label4 = New Windows.Forms.Label()
            textBox4 = New Windows.Forms.TextBox()
            label5 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            textBox1 = New Windows.Forms.TextBox()
            label3 = New Windows.Forms.Label()
            txtfecha = New Windows.Forms.TextBox()
            label6 = New Windows.Forms.Label()
            btnbuscar = New FontAwesome.Sharp.IconButton()
            groupBox3 = New Windows.Forms.GroupBox()
            label12 = New Windows.Forms.Label()
            numericUpDown1 = New Windows.Forms.NumericUpDown()
            textBox2 = New Windows.Forms.TextBox()
            label10 = New Windows.Forms.Label()
            textBox5 = New Windows.Forms.TextBox()
            label11 = New Windows.Forms.Label()
            textBox6 = New Windows.Forms.TextBox()
            label9 = New Windows.Forms.Label()
            iconButton1 = New FontAwesome.Sharp.IconButton()
            textBox7 = New Windows.Forms.TextBox()
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
            textBox9 = New Windows.Forms.TextBox()
            label13 = New Windows.Forms.Label()
            textBox10 = New Windows.Forms.TextBox()
            label14 = New Windows.Forms.Label()
            label15 = New Windows.Forms.Label()
            textBox11 = New Windows.Forms.TextBox()
            iconButton3 = New FontAwesome.Sharp.IconButton()
            groupBox2.SuspendLayout()
            groupBox1.SuspendLayout()
            groupBox3.SuspendLayout()
            CType(numericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
            CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(106, 19)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(71, 13)
            label1.TabIndex = 0
            label1.Text = " DetalleVenta"
            ' 
            ' label2
            ' 
            label2.BackColor = Drawing.Color.White
            label2.Location = New Drawing.Point(63, 45)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(864, 435)
            label2.TabIndex = 3
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(textBox3)
            groupBox2.Controls.Add(label4)
            groupBox2.Controls.Add(textBox4)
            groupBox2.Controls.Add(label5)
            groupBox2.Location = New Drawing.Point(88, 58)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(361, 91)
            groupBox2.TabIndex = 43
            groupBox2.TabStop = False
            groupBox2.Text = "InformacionProveedor"
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
            label4.Location = New Drawing.Point(268, 13)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(80, 13)
            label4.TabIndex = 16
            label4.Text = "tipo documento"
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
            label5.Location = New Drawing.Point(140, 13)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(34, 13)
            label5.TabIndex = 12
            label5.Text = "fecha"
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(btnbuscar)
            groupBox1.Controls.Add(textBox1)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(txtfecha)
            groupBox1.Controls.Add(label6)
            groupBox1.Location = New Drawing.Point(467, 58)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(392, 91)
            groupBox1.TabIndex = 44
            groupBox1.TabStop = False
            groupBox1.Text = "Infocliente"
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(180, 29)
            textBox1.Name = "textBox1"
            textBox1.PasswordChar = "*"c
            textBox1.Size = New Drawing.Size(168, 20)
            textBox1.TabIndex = 17
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.Color.White
            label3.Location = New Drawing.Point(302, 13)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(43, 13)
            label3.TabIndex = 16
            label3.Text = "Usuario"
            ' 
            ' txtfecha
            ' 
            txtfecha.Location = New Drawing.Point(6, 29)
            txtfecha.Name = "txtfecha"
            txtfecha.PasswordChar = "*"c
            txtfecha.Size = New Drawing.Size(168, 20)
            txtfecha.TabIndex = 13
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.BackColor = Drawing.Color.White
            label6.Location = New Drawing.Point(75, 13)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(99, 13)
            label6.TabIndex = 12
            label6.Text = "NumeroDocumento"
            ' 
            ' btnbuscar
            ' 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.None
            btnbuscar.IconColor = Drawing.Color.Black
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnbuscar.Location = New Drawing.Point(282, 62)
            btnbuscar.Name = "btnbuscar"
            btnbuscar.Size = New Drawing.Size(66, 23)
            btnbuscar.TabIndex = 40
            btnbuscar.Text = "Buscar"
            btnbuscar.UseVisualStyleBackColor = True
            ' 
            ' groupBox3
            ' 
            groupBox3.Controls.Add(label12)
            groupBox3.Controls.Add(numericUpDown1)
            groupBox3.Controls.Add(textBox2)
            groupBox3.Controls.Add(label10)
            groupBox3.Controls.Add(textBox5)
            groupBox3.Controls.Add(label11)
            groupBox3.Controls.Add(textBox6)
            groupBox3.Controls.Add(label9)
            groupBox3.Controls.Add(iconButton1)
            groupBox3.Controls.Add(textBox7)
            groupBox3.Controls.Add(label8)
            groupBox3.Location = New Drawing.Point(88, 170)
            groupBox3.Name = "groupBox3"
            groupBox3.Size = New Drawing.Size(656, 100)
            groupBox3.TabIndex = 45
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
            ' textBox2
            ' 
            textBox2.Location = New Drawing.Point(364, 60)
            textBox2.Name = "textBox2"
            textBox2.PasswordChar = "*"c
            textBox2.Size = New Drawing.Size(103, 20)
            textBox2.TabIndex = 27
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(286, 67)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(33, 13)
            label10.TabIndex = 26
            label10.Text = "stock"
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
            label11.Size = New Drawing.Size(37, 13)
            label11.TabIndex = 24
            label11.Text = "Precio"
            ' 
            ' textBox6
            ' 
            textBox6.Location = New Drawing.Point(86, 61)
            textBox6.Name = "textBox6"
            textBox6.PasswordChar = "*"c
            textBox6.Size = New Drawing.Size(103, 20)
            textBox6.TabIndex = 23
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
            ' iconButton1
            ' 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton1.IconColor = Drawing.Color.Black
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton1.Location = New Drawing.Point(202, 19)
            iconButton1.Name = "iconButton1"
            iconButton1.Size = New Drawing.Size(66, 23)
            iconButton1.TabIndex = 21
            iconButton1.Text = "Buscar"
            iconButton1.UseVisualStyleBackColor = True
            ' 
            ' textBox7
            ' 
            textBox7.Location = New Drawing.Point(86, 22)
            textBox7.Name = "textBox7"
            textBox7.PasswordChar = "*"c
            textBox7.Size = New Drawing.Size(103, 20)
            textBox7.TabIndex = 16
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
            dataGridView1.Location = New Drawing.Point(88, 276)
            dataGridView1.Name = "dataGridView1"
            dataGridView1.Size = New Drawing.Size(656, 195)
            dataGridView1.TabIndex = 46
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
            iconButton2.Location = New Drawing.Point(808, 199)
            iconButton2.Name = "iconButton2"
            iconButton2.Size = New Drawing.Size(75, 55)
            iconButton2.TabIndex = 47
            iconButton2.Text = "Agregar"
            iconButton2.UseVisualStyleBackColor = True
            ' 
            ' textBox9
            ' 
            textBox9.Location = New Drawing.Point(780, 289)
            textBox9.Name = "textBox9"
            textBox9.PasswordChar = "*"c
            textBox9.Size = New Drawing.Size(103, 20)
            textBox9.TabIndex = 51
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.BackColor = Drawing.Color.White
            label13.Location = New Drawing.Point(777, 273)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(72, 13)
            label13.TabIndex = 50
            label13.Text = "Total A Pagar"
            ' 
            ' textBox10
            ' 
            textBox10.Location = New Drawing.Point(780, 402)
            textBox10.Name = "textBox10"
            textBox10.PasswordChar = "*"c
            textBox10.Size = New Drawing.Size(103, 20)
            textBox10.TabIndex = 49
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.BackColor = Drawing.Color.White
            label14.Location = New Drawing.Point(777, 369)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(42, 13)
            label14.TabIndex = 48
            label14.Text = "Cambio"
            ' 
            ' label15
            ' 
            label15.AutoSize = True
            label15.BackColor = Drawing.Color.White
            label15.Location = New Drawing.Point(777, 320)
            label15.Name = "label15"
            label15.Size = New Drawing.Size(54, 13)
            label15.TabIndex = 52
            label15.Text = "Paga Con"
            ' 
            ' textBox11
            ' 
            textBox11.Location = New Drawing.Point(780, 336)
            textBox11.Name = "textBox11"
            textBox11.PasswordChar = "*"c
            textBox11.Size = New Drawing.Size(103, 20)
            textBox11.TabIndex = 53
            ' 
            ' iconButton3
            ' 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None
            iconButton3.IconColor = Drawing.Color.Black
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconButton3.Location = New Drawing.Point(795, 428)
            iconButton3.Name = "iconButton3"
            iconButton3.Size = New Drawing.Size(75, 43)
            iconButton3.TabIndex = 54
            iconButton3.Text = "CrearVenta"
            iconButton3.UseVisualStyleBackColor = True
            ' 
            ' FrmDetalleVenta
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(950, 525)
            Controls.Add(iconButton3)
            Controls.Add(textBox11)
            Controls.Add(label15)
            Controls.Add(textBox9)
            Controls.Add(label13)
            Controls.Add(textBox10)
            Controls.Add(label14)
            Controls.Add(iconButton2)
            Controls.Add(dataGridView1)
            Controls.Add(groupBox3)
            Controls.Add(groupBox1)
            Controls.Add(groupBox2)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "FrmDetalleVenta"
            Text = "FrmVerDetalleVenta"
            AddHandler Load, New EventHandler(AddressOf FrmDetalleVenta_Load)
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            groupBox3.ResumeLayout(False)
            groupBox3.PerformLayout()
            CType(numericUpDown1, ComponentModel.ISupportInitialize).EndInit()
            CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private groupBox2 As Windows.Forms.GroupBox
        Private textBox3 As Windows.Forms.TextBox
        Private label4 As Windows.Forms.Label
        Private textBox4 As Windows.Forms.TextBox
        Private label5 As Windows.Forms.Label
        Private groupBox1 As Windows.Forms.GroupBox
        Private textBox1 As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
        Private txtfecha As Windows.Forms.TextBox
        Private label6 As Windows.Forms.Label
        Private btnbuscar As FontAwesome.Sharp.IconButton
        Private groupBox3 As Windows.Forms.GroupBox
        Private label12 As Windows.Forms.Label
        Private numericUpDown1 As Windows.Forms.NumericUpDown
        Private textBox2 As Windows.Forms.TextBox
        Private label10 As Windows.Forms.Label
        Private textBox5 As Windows.Forms.TextBox
        Private label11 As Windows.Forms.Label
        Private textBox6 As Windows.Forms.TextBox
        Private label9 As Windows.Forms.Label
        Private iconButton1 As FontAwesome.Sharp.IconButton
        Private textBox7 As Windows.Forms.TextBox
        Private label8 As Windows.Forms.Label
        Private dataGridView1 As Windows.Forms.DataGridView
        Private w As Windows.Forms.DataGridViewButtonColumn
        Private idproducto As Windows.Forms.DataGridViewTextBoxColumn
        Private Producto As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioCompra As Windows.Forms.DataGridViewTextBoxColumn
        Private PrecioVenat As Windows.Forms.DataGridViewTextBoxColumn
        Private Cantidad As Windows.Forms.DataGridViewTextBoxColumn
        Private SubTotal As Windows.Forms.DataGridViewTextBoxColumn
        Private iconButton2 As FontAwesome.Sharp.IconButton
        Private textBox9 As Windows.Forms.TextBox
        Private label13 As Windows.Forms.Label
        Private textBox10 As Windows.Forms.TextBox
        Private label14 As Windows.Forms.Label
        Private label15 As Windows.Forms.Label
        Private textBox11 As Windows.Forms.TextBox
        Private iconButton3 As FontAwesome.Sharp.IconButton
    End Class
End Namespace
