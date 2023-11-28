
Namespace CapaPresentacion
    Partial Class Inicio
        ''' <summary>
        ''' Variable del diseñador necesaria.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Limpiar los recursos que se estén usando.
        ''' </summary>
        ''' <paramname="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Código generado por el Diseñador de Windows Forms"

        ''' <summary>
        ''' Método necesario para admitir el Diseñador. No se puede modificar
        ''' el contenido de este método con el editor de código.
        ''' </summary>
        Private Sub InitializeComponent()
            menu = New Windows.Forms.MenuStrip()
            menuUsuarios = New FontAwesome.Sharp.IconMenuItem()
            menuMantenedor = New FontAwesome.Sharp.IconMenuItem()
            SubMenuCategoria = New FontAwesome.Sharp.IconMenuItem()
            SubMenuProducto = New FontAwesome.Sharp.IconMenuItem()
            menuVentas = New FontAwesome.Sharp.IconMenuItem()
            SubMenuRegistrar = New FontAwesome.Sharp.IconMenuItem()
            SubMenuDettaleVenta = New FontAwesome.Sharp.IconMenuItem()
            menuCompras = New FontAwesome.Sharp.IconMenuItem()
            SubMenuRegistrarCompra = New FontAwesome.Sharp.IconMenuItem()
            SubMenuVerDetalleCompra = New FontAwesome.Sharp.IconMenuItem()
            menuClientes = New FontAwesome.Sharp.IconMenuItem()
            menuProveedores = New FontAwesome.Sharp.IconMenuItem()
            menuReportes = New FontAwesome.Sharp.IconMenuItem()
            SubMenuReporteCompras = New FontAwesome.Sharp.IconMenuItem()
            SubMenuVentasReportes = New FontAwesome.Sharp.IconMenuItem()
            menuAcercade = New FontAwesome.Sharp.IconMenuItem()
            menutitulo = New Windows.Forms.MenuStrip()
            label1 = New Windows.Forms.Label()
            Contenedor = New Windows.Forms.Panel()
            ImNegocio = New FontAwesome.Sharp.IconMenuItem()
            menu.SuspendLayout()
            SuspendLayout()
            ' 
            ' menu
            ' 
            menu.BackColor = Drawing.Color.White
            menu.Items.AddRange(New Windows.Forms.ToolStripItem() {menuUsuarios, menuMantenedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercade})
            menu.Location = New Drawing.Point(0, 48)
            menu.Name = "menu"
            menu.RightToLeft = Windows.Forms.RightToLeft.No
            menu.Size = New Drawing.Size(876, 43)
            menu.TabIndex = 0
            menu.Text = "Mantenedor"
            ' 
            ' menuUsuarios
            ' 
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuUsuarios.IconColor = Drawing.Color.Black
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuUsuarios.IconSize = 20
            menuUsuarios.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuUsuarios.Name = "menuUsuarios"
            menuUsuarios.Size = New Drawing.Size(64, 39)
            menuUsuarios.Text = "Usuarios"
            menuUsuarios.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            AddHandler menuUsuarios.Click, New EventHandler(AddressOf menuUsuarios_Click)
            ' 
            ' menuMantenedor
            ' 
            menuMantenedor.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {SubMenuCategoria, SubMenuProducto, ImNegocio})
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuMantenedor.IconColor = Drawing.Color.Black
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuMantenedor.IconSize = 20
            menuMantenedor.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuMantenedor.Name = "menuMantenedor"
            menuMantenedor.Size = New Drawing.Size(84, 39)
            menuMantenedor.Text = "Mantenedor"
            menuMantenedor.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            AddHandler menuMantenedor.Click, New EventHandler(AddressOf menuMantenedor_Click)
            ' 
            ' SubMenuCategoria
            ' 
            SubMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuCategoria.IconColor = Drawing.Color.Black
            SubMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuCategoria.Name = "SubMenuCategoria"
            SubMenuCategoria.Size = New Drawing.Size(180, 22)
            SubMenuCategoria.Text = "Categoria"
            AddHandler SubMenuCategoria.Click, New EventHandler(AddressOf SubMenuCategoria_Click)
            ' 
            ' SubMenuProducto
            ' 
            SubMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuProducto.IconColor = Drawing.Color.Black
            SubMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuProducto.Name = "SubMenuProducto"
            SubMenuProducto.Size = New Drawing.Size(180, 22)
            SubMenuProducto.Text = "Producto"
            AddHandler SubMenuProducto.Click, New EventHandler(AddressOf SubMenuProducto_Click)
            ' 
            ' menuVentas
            ' 
            menuVentas.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {SubMenuRegistrar, SubMenuDettaleVenta})
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuVentas.IconColor = Drawing.Color.Black
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuVentas.IconSize = 20
            menuVentas.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuVentas.Name = "menuVentas"
            menuVentas.Size = New Drawing.Size(53, 39)
            menuVentas.Text = "Ventas"
            menuVentas.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            AddHandler menuVentas.Click, New EventHandler(AddressOf menuVentas_Click)
            ' 
            ' SubMenuRegistrar
            ' 
            SubMenuRegistrar.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuRegistrar.IconColor = Drawing.Color.Black
            SubMenuRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuRegistrar.Name = "SubMenuRegistrar"
            SubMenuRegistrar.Size = New Drawing.Size(129, 22)
            SubMenuRegistrar.Text = "Registrar"
            AddHandler SubMenuRegistrar.Click, New EventHandler(AddressOf SubMenuRegistrar_Click)
            ' 
            ' SubMenuDettaleVenta
            ' 
            SubMenuDettaleVenta.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuDettaleVenta.IconColor = Drawing.Color.Black
            SubMenuDettaleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuDettaleVenta.Name = "SubMenuDettaleVenta"
            SubMenuDettaleVenta.Size = New Drawing.Size(129, 22)
            SubMenuDettaleVenta.Text = "Ver Detalle"
            AddHandler SubMenuDettaleVenta.Click, New EventHandler(AddressOf SubMenuDettaleVenta_Click)
            ' 
            ' menuCompras
            ' 
            menuCompras.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {SubMenuRegistrarCompra, SubMenuVerDetalleCompra})
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuCompras.IconColor = Drawing.Color.Black
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuCompras.IconSize = 20
            menuCompras.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuCompras.Name = "menuCompras"
            menuCompras.Size = New Drawing.Size(67, 39)
            menuCompras.Text = "Compras"
            menuCompras.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' SubMenuRegistrarCompra
            ' 
            SubMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuRegistrarCompra.IconColor = Drawing.Color.Black
            SubMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuRegistrarCompra.Name = "SubMenuRegistrarCompra"
            SubMenuRegistrarCompra.Size = New Drawing.Size(129, 22)
            SubMenuRegistrarCompra.Text = "Registrar"
            AddHandler SubMenuRegistrarCompra.Click, New EventHandler(AddressOf SubMenuRegistrarCompra_Click)
            ' 
            ' SubMenuVerDetalleCompra
            ' 
            SubMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuVerDetalleCompra.IconColor = Drawing.Color.Black
            SubMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuVerDetalleCompra.Name = "SubMenuVerDetalleCompra"
            SubMenuVerDetalleCompra.Size = New Drawing.Size(129, 22)
            SubMenuVerDetalleCompra.Text = "Ver Detalle"
            AddHandler SubMenuVerDetalleCompra.Click, New EventHandler(AddressOf SubMenuVerDetalleCompra_Click)
            ' 
            ' menuClientes
            ' 
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuClientes.IconColor = Drawing.Color.Black
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuClientes.IconSize = 20
            menuClientes.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuClientes.Name = "menuClientes"
            menuClientes.Size = New Drawing.Size(61, 39)
            menuClientes.Text = "Clientes"
            menuClientes.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            AddHandler menuClientes.Click, New EventHandler(AddressOf menuClientes_Click)
            ' 
            ' menuProveedores
            ' 
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuProveedores.IconColor = Drawing.Color.Black
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuProveedores.IconSize = 20
            menuProveedores.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuProveedores.Name = "menuProveedores"
            menuProveedores.Size = New Drawing.Size(84, 39)
            menuProveedores.Text = "Proveedores"
            menuProveedores.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            AddHandler menuProveedores.Click, New EventHandler(AddressOf menuProveedores_Click)
            ' 
            ' menuReportes
            ' 
            menuReportes.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {SubMenuReporteCompras, SubMenuVentasReportes})
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuReportes.IconColor = Drawing.Color.Black
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuReportes.IconSize = 20
            menuReportes.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuReportes.Name = "menuReportes"
            menuReportes.Size = New Drawing.Size(65, 39)
            menuReportes.Text = "Reportes"
            menuReportes.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            AddHandler menuReportes.Click, New EventHandler(AddressOf menuReportes_Click)
            ' 
            ' SubMenuReporteCompras
            ' 
            SubMenuReporteCompras.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuReporteCompras.IconColor = Drawing.Color.Black
            SubMenuReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuReporteCompras.Name = "SubMenuReporteCompras"
            SubMenuReporteCompras.Size = New Drawing.Size(122, 22)
            SubMenuReporteCompras.Text = "Compras"
            ' 
            ' SubMenuVentasReportes
            ' 
            SubMenuVentasReportes.IconChar = FontAwesome.Sharp.IconChar.None
            SubMenuVentasReportes.IconColor = Drawing.Color.Black
            SubMenuVentasReportes.IconFont = FontAwesome.Sharp.IconFont.Auto
            SubMenuVentasReportes.Name = "SubMenuVentasReportes"
            SubMenuVentasReportes.Size = New Drawing.Size(122, 22)
            SubMenuVentasReportes.Text = "Ventas"
            ' 
            ' menuAcercade
            ' 
            menuAcercade.IconChar = FontAwesome.Sharp.IconChar.Meteor
            menuAcercade.IconColor = Drawing.Color.Black
            menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto
            menuAcercade.IconSize = 20
            menuAcercade.ImageScaling = Windows.Forms.ToolStripItemImageScaling.None
            menuAcercade.Name = "menuAcercade"
            menuAcercade.Size = New Drawing.Size(71, 39)
            menuAcercade.Text = "Acerca de"
            menuAcercade.TextImageRelation = Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' menutitulo
            ' 
            menutitulo.AutoSize = False
            menutitulo.BackColor = Drawing.Color.DimGray
            menutitulo.Location = New Drawing.Point(0, 0)
            menutitulo.Name = "menutitulo"
            menutitulo.RightToLeft = Windows.Forms.RightToLeft.Yes
            menutitulo.Size = New Drawing.Size(876, 48)
            menutitulo.TabIndex = 1
            menutitulo.Text = "menuStrip2"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.Color.DimGray
            label1.ForeColor = Drawing.Color.Black
            label1.Location = New Drawing.Point(47, 13)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(94, 13)
            label1.TabIndex = 2
            label1.Text = "Sistema de ventas"
            ' 
            ' Contenedor
            ' 
            Contenedor.Dock = Windows.Forms.DockStyle.Fill
            Contenedor.Location = New Drawing.Point(0, 91)
            Contenedor.Name = "Contenedor"
            Contenedor.RightToLeft = Windows.Forms.RightToLeft.No
            Contenedor.Size = New Drawing.Size(876, 324)
            Contenedor.TabIndex = 3
            ' 
            ' ImNegocio
            ' 
            ImNegocio.IconChar = FontAwesome.Sharp.IconChar.None
            ImNegocio.IconColor = Drawing.Color.Black
            ImNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto
            ImNegocio.Name = "ImNegocio"
            ImNegocio.RightToLeftAutoMirrorImage = True
            ImNegocio.Size = New Drawing.Size(180, 22)
            ImNegocio.Text = "Negocio"
            ' 
            ' Inicio
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.White
            ClientSize = New Drawing.Size(876, 415)
            Controls.Add(Contenedor)
            Controls.Add(label1)
            Controls.Add(menu)
            Controls.Add(menutitulo)
            MainMenuStrip = menu
            Name = "Inicio"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Inicio_Load)
            menu.ResumeLayout(False)
            menu.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private menu As Windows.Forms.MenuStrip
        Private menuUsuarios As FontAwesome.Sharp.IconMenuItem
        Private menutitulo As Windows.Forms.MenuStrip
        Private label1 As Windows.Forms.Label
        Private menuMantenedor As FontAwesome.Sharp.IconMenuItem
        Private menuVentas As FontAwesome.Sharp.IconMenuItem
        Private menuCompras As FontAwesome.Sharp.IconMenuItem
        Private menuClientes As FontAwesome.Sharp.IconMenuItem
        Private menuProveedores As FontAwesome.Sharp.IconMenuItem
        Private menuReportes As FontAwesome.Sharp.IconMenuItem
        Private menuAcercade As FontAwesome.Sharp.IconMenuItem
        Private SubMenuCategoria As FontAwesome.Sharp.IconMenuItem
        Private SubMenuProducto As FontAwesome.Sharp.IconMenuItem
        Private Contenedor As Windows.Forms.Panel
        Private SubMenuRegistrar As FontAwesome.Sharp.IconMenuItem
        Private SubMenuDettaleVenta As FontAwesome.Sharp.IconMenuItem
        Private SubMenuRegistrarCompra As FontAwesome.Sharp.IconMenuItem
        Private SubMenuVerDetalleCompra As FontAwesome.Sharp.IconMenuItem
        Private SubMenuReporteCompras As FontAwesome.Sharp.IconMenuItem
        Private SubMenuVentasReportes As FontAwesome.Sharp.IconMenuItem
        Private ImNegocio As FontAwesome.Sharp.IconMenuItem
    End Class
End Namespace
