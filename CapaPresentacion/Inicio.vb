Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports FontAwesome.Sharp
Imports CapaNegocio
Imports CapaEntidad

Namespace CapaPresentacion
    Public Partial Class Inicio
        Inherits Form

        Private Shared usuarioActual As Usuario
        Private Shared MenuActivo As IconMenuItem = Nothing
        Private Shared FormularioActivo As Form = Nothing
        Public Sub New(ByVal objusuario As Usuario)

            usuarioActual = objusuario
            InitializeComponent()



        End Sub

        Private Sub Inicio_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim ListaPermisos As List(Of Permiso) = New CapaNegocio.CN_Permiso().Listar(usuarioActual.IdUsuario)
            For Each iconmenu As IconMenuItem In menu.Items
                Dim encontrado = ListaPermisos.Any(Function(m) Equals(m.NombreMenu, iconmenu.Name))

                If encontrado = False Then
                    iconmenu.Visible = False
                End If

            Next
            Return ListaPermisos

        End Sub


        Private Sub iconMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
        Private Sub AbrirFormulario(ByVal menu As IconMenuItem, ByVal formulario As Form)
            If MenuActivo IsNot Nothing Then
                MenuActivo.BackColor = Color.White
            End If
            menu.BackColor = Color.Silver
            MenuActivo = menu

            If FormularioActivo IsNot Nothing Then
                Call FormularioActivo.Close()
            End If
            FormularioActivo = formulario
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            formulario.BackColor = Color.SteelBlue

            Contenedor.Controls.Add(formulario)
            formulario.Show()
        End Sub



        Private Sub menuUsuarios_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(CType(sender, IconMenuItem), New FrmUsuarios())
        End Sub

        Private Sub SubMenuCategoria_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(menuMantenedor, New FrmCategoria())
        End Sub

        Private Sub SubMenuProducto_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(menuMantenedor, New FrmProducto())
        End Sub

        Private Sub menuMantenedor_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub menuVentas_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub SubMenuRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(menuVentas, New FrmVentas())
        End Sub

        Private Sub SubMenuDettaleVenta_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(menuVentas, New FrmDetalleVenta())
        End Sub

        Private Sub SubMenuRegistrarCompra_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(menuCompras, New FrmCompras())
        End Sub

        Private Sub SubMenuVerDetalleCompra_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(menuCompras, New FrmDetalleCompra())
        End Sub

        Private Sub menuClientes_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(CType(sender, IconMenuItem), New FrmClientes())
        End Sub

        Private Sub menuProveedores_Click(ByVal sender As Object, ByVal e As EventArgs)
            AbrirFormulario(CType(sender, IconMenuItem), New FrmProveedroes())
        End Sub

        Private Sub menuReportes_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

    End Class
End Namespace
