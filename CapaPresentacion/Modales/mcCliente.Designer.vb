
Namespace CapaPresentacion.Modales
    Partial Class mcCliente
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
            label1 = New Windows.Forms.Label()
            cboBusqueda = New Windows.Forms.ComboBox()
            btnLimpiar = New FontAwesome.Sharp.IconButton()
            btnBusqueda = New FontAwesome.Sharp.IconButton()
            label12 = New Windows.Forms.Label()
            txtBusqueda = New Windows.Forms.TextBox()
            label3 = New Windows.Forms.Label()
            BtnSeleccionar = New Windows.Forms.DataGridViewTextBoxColumn()
            Documento = New Windows.Forms.DataGridViewTextBoxColumn()
            nombrecompleto = New Windows.Forms.DataGridViewTextBoxColumn()
            CType(dtgData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' dtgData
            ' 
            dtgData.AllowUserToAddRows = False
            dtgData.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dtgData.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {BtnSeleccionar, Documento, nombrecompleto})
            dtgData.Location = New Drawing.Point(27, 141)
            dtgData.MultiSelect = False
            dtgData.Name = "dtgData"
            dtgData.ReadOnly = True
            dtgData.Size = New Drawing.Size(448, 190)
            dtgData.TabIndex = 83
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(74, 49)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(83, 13)
            label1.TabIndex = 89
            label1.Text = "Lista de clientes" & Microsoft.VisualBasic.Constants.vbCrLf
            ' 
            ' cboBusqueda
            ' 
            cboBusqueda.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboBusqueda.FormattingEnabled = True
            cboBusqueda.Location = New Drawing.Point(136, 83)
            cboBusqueda.Name = "cboBusqueda"
            cboBusqueda.Size = New Drawing.Size(102, 21)
            cboBusqueda.TabIndex = 87
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None
            btnLimpiar.IconColor = Drawing.Color.Black
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnLimpiar.Location = New Drawing.Point(453, 83)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New Drawing.Size(75, 23)
            btnLimpiar.TabIndex = 86
            btnLimpiar.Text = "LIMPIAR"
            btnLimpiar.UseVisualStyleBackColor = True
            ' 
            ' btnBusqueda
            ' 
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.None
            btnBusqueda.IconColor = Drawing.Color.Black
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnBusqueda.Location = New Drawing.Point(372, 83)
            btnBusqueda.Name = "btnBusqueda"
            btnBusqueda.Size = New Drawing.Size(75, 23)
            btnBusqueda.TabIndex = 85
            btnBusqueda.Text = "BUSQUEDA"
            btnBusqueda.UseVisualStyleBackColor = True
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.BackColor = Drawing.Color.Black
            label12.ForeColor = Drawing.Color.White
            label12.Location = New Drawing.Point(71, 88)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(59, 13)
            label12.TabIndex = 84
            label12.Text = "BUSQEDA"
            ' 
            ' txtBusqueda
            ' 
            txtBusqueda.Location = New Drawing.Point(257, 83)
            txtBusqueda.Name = "txtBusqueda"
            txtBusqueda.Size = New Drawing.Size(99, 20)
            txtBusqueda.TabIndex = 88
            AddHandler txtBusqueda.TextChanged, New EventHandler(AddressOf txtBusqueda_TextChanged)
            ' 
            ' label3
            ' 
            label3.BackColor = Drawing.Color.White
            label3.Location = New Drawing.Point(24, 33)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(526, 89)
            label3.TabIndex = 82
            ' 
            ' BtnSeleccionar
            ' 
            BtnSeleccionar.HeaderText = ""
            BtnSeleccionar.Name = "BtnSeleccionar"
            BtnSeleccionar.ReadOnly = True
            BtnSeleccionar.Width = 30
            ' 
            ' Documento
            ' 
            Documento.HeaderText = "No.Documento"
            Documento.Name = "Documento"
            Documento.ReadOnly = True
            Documento.Width = 150
            ' 
            ' nombrecompleto
            ' 
            nombrecompleto.HeaderText = "Nombre Completo"
            nombrecompleto.Name = "nombrecompleto"
            nombrecompleto.ReadOnly = True
            nombrecompleto.Width = 180
            ' 
            ' mcCliente
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(572, 365)
            Controls.Add(dtgData)
            Controls.Add(label1)
            Controls.Add(cboBusqueda)
            Controls.Add(btnLimpiar)
            Controls.Add(btnBusqueda)
            Controls.Add(label12)
            Controls.Add(txtBusqueda)
            Controls.Add(label3)
            Name = "mcCliente"
            Text = "mcCliente"
            AddHandler Load, New EventHandler(AddressOf mcCliente_Load)
            CType(dtgData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private dtgData As Windows.Forms.DataGridView
        Private label1 As Windows.Forms.Label
        Private cboBusqueda As Windows.Forms.ComboBox
        Private btnLimpiar As FontAwesome.Sharp.IconButton
        Private btnBusqueda As FontAwesome.Sharp.IconButton
        Private label12 As Windows.Forms.Label
        Private txtBusqueda As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
        Private BtnSeleccionar As Windows.Forms.DataGridViewTextBoxColumn
        Private Documento As Windows.Forms.DataGridViewTextBoxColumn
        Private nombrecompleto As Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
