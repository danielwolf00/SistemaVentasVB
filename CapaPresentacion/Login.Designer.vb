
Namespace CapaPresentacion
    Partial Class Login
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
            iconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
            btn_Ingresar = New FontAwesome.Sharp.IconButton()
            btn_Cancelar = New FontAwesome.Sharp.IconButton()
            txtclave = New Windows.Forms.TextBox()
            txtdocumento = New Windows.Forms.TextBox()
            label3 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            CType(iconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.BackColor = Drawing.Color.DimGray
            label1.Dock = Windows.Forms.DockStyle.Left
            label1.ForeColor = Drawing.SystemColors.ControlLightLight
            label1.Location = New Drawing.Point(0, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(225, 256)
            label1.TabIndex = 0
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.Color.DimGray
            label2.Location = New Drawing.Point(47, 174)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(94, 13)
            label2.TabIndex = 1
            label2.Text = "Sistema de ventas"
            ' 
            ' iconPictureBox1
            ' 
            iconPictureBox1.BackColor = Drawing.Color.DimGray
            iconPictureBox1.ForeColor = Drawing.SystemColors.ControlText
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Meteor
            iconPictureBox1.IconColor = Drawing.SystemColors.ControlText
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
            iconPictureBox1.IconSize = 95
            iconPictureBox1.Location = New Drawing.Point(50, 57)
            iconPictureBox1.Name = "iconPictureBox1"
            iconPictureBox1.Size = New Drawing.Size(106, 95)
            iconPictureBox1.TabIndex = 2
            iconPictureBox1.TabStop = False
            ' 
            ' btn_Ingresar
            ' 
            btn_Ingresar.BackColor = Drawing.Color.DarkCyan
            btn_Ingresar.IconChar = FontAwesome.Sharp.IconChar.None
            btn_Ingresar.IconColor = Drawing.Color.Black
            btn_Ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btn_Ingresar.Location = New Drawing.Point(256, 196)
            btn_Ingresar.Name = "btn_Ingresar"
            btn_Ingresar.Size = New Drawing.Size(75, 23)
            btn_Ingresar.TabIndex = 3
            btn_Ingresar.Text = "Ingresar"
            btn_Ingresar.UseVisualStyleBackColor = False
            AddHandler btn_Ingresar.Click, New EventHandler(AddressOf iconButton1_Click)
            ' 
            ' btn_Cancelar
            ' 
            btn_Cancelar.BackColor = Drawing.Color.DarkRed
            btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.None
            btn_Cancelar.IconColor = Drawing.Color.Black
            btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btn_Cancelar.Location = New Drawing.Point(380, 196)
            btn_Cancelar.Name = "btn_Cancelar"
            btn_Cancelar.Size = New Drawing.Size(75, 23)
            btn_Cancelar.TabIndex = 4
            btn_Cancelar.Text = "Cancelar"
            btn_Cancelar.UseVisualStyleBackColor = False
            AddHandler btn_Cancelar.Click, New EventHandler(AddressOf iconButton2_Click)
            ' 
            ' txtclave
            ' 
            txtclave.Location = New Drawing.Point(288, 112)
            txtclave.Name = "txtclave"
            txtclave.PasswordChar = "*"c
            txtclave.Size = New Drawing.Size(100, 20)
            txtclave.TabIndex = 5
            ' 
            ' txtdocumento
            ' 
            txtdocumento.Location = New Drawing.Point(288, 29)
            txtdocumento.Name = "txtdocumento"
            txtdocumento.Size = New Drawing.Size(100, 20)
            txtdocumento.TabIndex = 6
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(288, 13)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(43, 13)
            label3.TabIndex = 7
            label3.Text = "Uusario"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(288, 74)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(61, 13)
            label4.TabIndex = 8
            label4.Text = "Contraseña"
            ' 
            ' Login
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(476, 256)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(txtdocumento)
            Controls.Add(txtclave)
            Controls.Add(btn_Cancelar)
            Controls.Add(btn_Ingresar)
            Controls.Add(iconPictureBox1)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "Login"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Login"
            ' this.Load += new System.EventHandler(this.Login);
            CType(iconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private iconPictureBox1 As FontAwesome.Sharp.IconPictureBox
        Private btn_Ingresar As FontAwesome.Sharp.IconButton
        Private btn_Cancelar As FontAwesome.Sharp.IconButton
        Private txtclave As Windows.Forms.TextBox
        Private txtdocumento As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
    End Class
End Namespace
