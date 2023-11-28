
Namespace CapaPresentacion.Modales
    Partial Class mdProvedor
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
            label3 = New Windows.Forms.Label()
            cboBusqueda = New Windows.Forms.ComboBox()
            btnLimpiar = New FontAwesome.Sharp.IconButton()
            btnBusqueda = New FontAwesome.Sharp.IconButton()
            label12 = New Windows.Forms.Label()
            txtBusqueda = New Windows.Forms.TextBox()
            label1 = New Windows.Forms.Label()
            BtnSeleccionar = New Windows.Forms.DataGridViewTextBoxColumn()
            Documento = New Windows.Forms.DataGridViewTextBoxColumn()
            razonsocial = New Windows.Forms.DataGridViewTextBoxColumn()
            CType(dtgData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' dtgData
            ' 
            dtgData.AllowUserToAddRows = False
            dtgData.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dtgData.Columns.AddRange(New Windows.Forms.DataGridViewColumn() {BtnSeleccionar, Documento, razonsocial})
            dtgData.Location = New Drawing.Point(31, 123)
            dtgData.MultiSelect = False
            dtgData.Name = "dtgData"
            dtgData.ReadOnly = True
            dtgData.Size = New Drawing.Size(448, 190)
            dtgData.TabIndex = 71
            ' 
            ' label3
            ' 
            label3.BackColor = Drawing.Color.White
            label3.Location = New Drawing.Point(28, 15)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(618, 89)
            label3.TabIndex = 70
            ' 
            ' cboBusqueda
            ' 
            cboBusqueda.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cboBusqueda.FormattingEnabled = True
            cboBusqueda.Location = New Drawing.Point(140, 65)
            cboBusqueda.Name = "cboBusqueda"
            cboBusqueda.Size = New Drawing.Size(102, 21)
            cboBusqueda.TabIndex = 79
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None
            btnLimpiar.IconColor = Drawing.Color.Black
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnLimpiar.Location = New Drawing.Point(504, 65)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New Drawing.Size(75, 23)
            btnLimpiar.TabIndex = 78
            btnLimpiar.Text = "LIMPIAR"
            btnLimpiar.UseVisualStyleBackColor = True
            ' 
            ' btnBusqueda
            ' 
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.None
            btnBusqueda.IconColor = Drawing.Color.Black
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto
            btnBusqueda.Location = New Drawing.Point(423, 65)
            btnBusqueda.Name = "btnBusqueda"
            btnBusqueda.Size = New Drawing.Size(75, 23)
            btnBusqueda.TabIndex = 77
            btnBusqueda.Text = "BUSQUEDA"
            btnBusqueda.UseVisualStyleBackColor = True
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.BackColor = Drawing.Color.Black
            label12.ForeColor = Drawing.Color.White
            label12.Location = New Drawing.Point(75, 70)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(59, 13)
            label12.TabIndex = 76
            label12.Text = "BUSQEDA"
            ' 
            ' txtBusqueda
            ' 
            txtBusqueda.Location = New Drawing.Point(261, 65)
            txtBusqueda.Name = "txtBusqueda"
            txtBusqueda.Size = New Drawing.Size(99, 20)
            txtBusqueda.TabIndex = 80
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(78, 31)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(106, 13)
            label1.TabIndex = 81
            label1.Text = "Lista de proveedores"
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
            ' razonsocial
            ' 
            razonsocial.HeaderText = "Razon Social"
            razonsocial.Name = "razonsocial"
            razonsocial.ReadOnly = True
            razonsocial.Width = 180
            ' 
            ' mdProvedor
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(681, 344)
            Controls.Add(label1)
            Controls.Add(cboBusqueda)
            Controls.Add(btnLimpiar)
            Controls.Add(btnBusqueda)
            Controls.Add(label12)
            Controls.Add(txtBusqueda)
            Controls.Add(dtgData)
            Controls.Add(label3)
            Name = "mdProvedor"
            Text = "mdProvedor"
            AddHandler Load, New EventHandler(AddressOf mdProvedor_Load)
            CType(dtgData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private dtgData As Windows.Forms.DataGridView
        Private label3 As Windows.Forms.Label
        Private BtnSeleccionar As Windows.Forms.DataGridViewTextBoxColumn
        Private Documento As Windows.Forms.DataGridViewTextBoxColumn
        Private razonsocial As Windows.Forms.DataGridViewTextBoxColumn
        Private cboBusqueda As Windows.Forms.ComboBox
        Private btnLimpiar As FontAwesome.Sharp.IconButton
        Private btnBusqueda As FontAwesome.Sharp.IconButton
        Private label12 As Windows.Forms.Label
        Private txtBusqueda As Windows.Forms.TextBox
        Private label1 As Windows.Forms.Label
    End Class
End Namespace
