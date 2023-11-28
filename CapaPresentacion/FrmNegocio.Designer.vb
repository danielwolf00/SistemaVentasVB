
Namespace CapaPresentacion
    Partial Class FrmNegocio
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
            label10 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            btnGuardarNeg = New FontAwesome.Sharp.IconButton()
            txtdireccion = New Windows.Forms.TextBox()
            label9 = New Windows.Forms.Label()
            txtRUC = New Windows.Forms.TextBox()
            txtNombreNegocio = New Windows.Forms.TextBox()
            label5 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            txtsubir = New FontAwesome.Sharp.IconButton()
            piclogo = New Windows.Forms.PictureBox()
            groupBox1.SuspendLayout()
            CType(piclogo, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.BackColor = Drawing.Color.White
            label10.Location = New Drawing.Point(41, 18)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(80, 13)
            label10.TabIndex = 20
            label10.Text = "DetalleNegocio"
            ' 
            ' label3
            ' 
            label3.BackColor = Drawing.Color.White
            label3.Dock = Windows.Forms.DockStyle.Left
            label3.Location = New Drawing.Point(0, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(453, 349)
            label3.TabIndex = 19
            ' 
            ' groupBox1
            ' 
            groupBox1.BackColor = Drawing.Color.White
            groupBox1.Controls.Add(btnGuardarNeg)
            groupBox1.Controls.Add(txtdireccion)
            groupBox1.Controls.Add(label9)
            groupBox1.Controls.Add(txtRUC)
            groupBox1.Controls.Add(txtNombreNegocio)
            groupBox1.Controls.Add(label5)
            groupBox1.Controls.Add(label4)
            groupBox1.Controls.Add(txtsubir)
            groupBox1.Controls.Add(piclogo)
            groupBox1.Location = New Drawing.Point(27, 61)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(406, 276)
            groupBox1.TabIndex = 21
            groupBox1.TabStop = False
            ' 
            ' btnGuardarNeg
            ' 
            btnGuardarNeg.IconChar = FontAwesome.Sharp.IconChar.None
            btnGuardarNeg.IconColor = Drawing.Color.Black
            btnGuardarNeg.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnGuardarNeg.Location = New Drawing.Point(232, 175)
            btnGuardarNeg.Name = "btnGuardarNeg"
            btnGuardarNeg.Size = New Drawing.Size(75, 23)
            btnGuardarNeg.TabIndex = 21
            btnGuardarNeg.Text = "Guardar"
            btnGuardarNeg.UseVisualStyleBackColor = True
            ' 
            ' txtdireccion
            ' 
            txtdireccion.Location = New Drawing.Point(201, 137)
            txtdireccion.Name = "txtdireccion"
            txtdireccion.Size = New Drawing.Size(168, 20)
            txtdireccion.TabIndex = 20
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.BackColor = Drawing.Color.White
            label9.Location = New Drawing.Point(198, 121)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(52, 13)
            label9.TabIndex = 19
            label9.Text = "Direccion"
            ' 
            ' txtRUC
            ' 
            txtRUC.Location = New Drawing.Point(201, 85)
            txtRUC.Name = "txtRUC"
            txtRUC.Size = New Drawing.Size(168, 20)
            txtRUC.TabIndex = 18
            ' 
            ' txtNombreNegocio
            ' 
            txtNombreNegocio.Location = New Drawing.Point(201, 35)
            txtNombreNegocio.Name = "txtNombreNegocio"
            txtNombreNegocio.Size = New Drawing.Size(168, 20)
            txtNombreNegocio.TabIndex = 17
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.White
            label5.Location = New Drawing.Point(198, 69)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(30, 13)
            label5.TabIndex = 16
            label5.Text = "RUC"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.White
            label4.Location = New Drawing.Point(198, 19)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(87, 13)
            label4.TabIndex = 15
            label4.Text = "Nombre Negocio"
            ' 
            ' txtsubir
            ' 
            txtsubir.IconChar = FontAwesome.Sharp.IconChar.None
            txtsubir.IconColor = Drawing.Color.Black
            txtsubir.IconFont = FontAwesome.Sharp.IconFont.Auto
            txtsubir.Location = New Drawing.Point(43, 175)
            txtsubir.Name = "txtsubir"
            txtsubir.Size = New Drawing.Size(75, 23)
            txtsubir.TabIndex = 1
            txtsubir.Text = "Subir"
            txtsubir.UseVisualStyleBackColor = True
            AddHandler txtsubir.Click, New EventHandler(AddressOf iconButton1_Click)
            ' 
            ' piclogo
            ' 
            piclogo.Location = New Drawing.Point(17, 19)
            piclogo.Name = "piclogo"
            piclogo.Size = New Drawing.Size(144, 132)
            piclogo.TabIndex = 0
            piclogo.TabStop = False
            AddHandler piclogo.Click, New EventHandler(AddressOf piclogo_Click)
            ' 
            ' FrmNegocio
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Black
            ClientSize = New Drawing.Size(609, 349)
            Controls.Add(groupBox1)
            Controls.Add(label10)
            Controls.Add(label3)
            Name = "FrmNegocio"
            Text = "FrmNegocio"
            AddHandler Load, New EventHandler(AddressOf FrmNegocio_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(piclogo, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label10 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private groupBox1 As Windows.Forms.GroupBox
        Private txtsubir As FontAwesome.Sharp.IconButton
        Private piclogo As Windows.Forms.PictureBox
        Private btnGuardarNeg As FontAwesome.Sharp.IconButton
        Private txtdireccion As Windows.Forms.TextBox
        Private label9 As Windows.Forms.Label
        Private txtRUC As Windows.Forms.TextBox
        Private txtNombreNegocio As Windows.Forms.TextBox
        Private label5 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
    End Class
End Namespace
