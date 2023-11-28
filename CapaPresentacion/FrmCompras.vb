Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio

Namespace CapaPresentacion
    Public Partial Class FrmCompras
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub textBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub FrmCompras_Load(ByVal sender As Object, ByVal e As EventArgs)
            cbotipodocumento.Items.Add(New OpcionCombo() With {
                .Valor = "Boleta",
                .Texto = "Boleta"
            })
            cbotipodocumento.Items.Add(New OpcionCombo() With {
                .Valor = "Factura",
                .Texto = "Factura"
            })
            cbotipodocumento.DisplayMember = "Texto"
            cbotipodocumento.ValueMember = "Valor"
            cbotipodocumento.SelectedIndex = 0

            txtfecha.Text = Date.Now.ToString("dd/MM/yyyy")

            txtidproveedor.Text = "0"
            txtidproducto.Text = "0"
        End Sub

        Private Sub btnbuscarproveedor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using modal = New mdProveedor()
                Dim result = modal.ShowDialog()

                If result = DialogResult.OK Then
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString()
                    txtdocproveedor.Text = modal._Proveedor.Documento
                    txtnombreproveedor.Text = modal._Proveedor.RazonSocial
                Else
                    txtdocproveedor.[Select]()
                End If

            End Using
        End Sub

        Private Sub btnbuscarproducto_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using modal = New mdProducto()
                Dim result = modal.ShowDialog()

                If result = DialogResult.OK Then
                    txtidproducto.Text = modal._Producto.IdProducto.ToString()
                    txtcodproducto.Text = modal._Producto.Codigo
                    txtproducto.Text = modal._Producto.Nombre
                    txtpreciocompra.[Select]()
                Else
                    txtcodproducto.[Select]()
                End If

            End Using
        End Sub

        Private Sub txtcodproducto_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = Keys.Enter Then

                Dim oProducto As Producto = New CN__Producto().Listar().Where(Function(p) p.Codigo Is txtcodproducto.Text AndAlso p.Estado = True).FirstOrDefault()

                If oProducto IsNot Nothing Then
                    txtcodproducto.BackColor = Color.Honeydew
                    txtidproducto.Text = oProducto.IdProducto.ToString()
                    txtproducto.Text = oProducto.Nombre
                    txtpreciocompra.[Select]()
                Else
                    txtcodproducto.BackColor = Color.MistyRose
                    txtidproducto.Text = "0"
                    txtproducto.Text = ""
                End If


            End If
        End Sub

        Private Sub btnagregarproducto_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim preciocompra As Decimal = 0
            Dim precioventa As Decimal = 0
            Dim producto_existe = False

            If Integer.Parse(txtidproducto.Text) = 0 Then
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If Not Decimal.TryParse(txtpreciocompra.Text, preciocompra) Then
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpreciocompra.[Select]()
                Return
            End If

            If Not Decimal.TryParse(txtprecioventa.Text, precioventa) Then
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtprecioventa.[Select]()
                Return
            End If

            For Each fila As DataGridViewRow In dgvdata.Rows
                If fila.Cells("IdProducto").Value.ToString() Is txtidproducto.Text Then
                    producto_existe = True
                    Exit For
                End If
            Next

            If Not producto_existe Then


                dgvdata.Rows.Add(New Object() {txtidproducto.Text, txtproducto.Text, preciocompra.ToString("0.00"), precioventa.ToString("0.00"), txtcantidad.Value.ToString(), (txtcantidad.Value * preciocompra).ToString("0.00")})

                calcularTotal()
                limpiarProducto()
                txtcodproducto.[Select]()

            End If

        End Sub

        Private Sub limpiarProducto()
            txtidproducto.Text = "0"
            txtcodproducto.Text = ""
            txtcodproducto.BackColor = Color.White
            txtproducto.Text = ""
            txtpreciocompra.Text = ""
            txtprecioventa.Text = ""
            txtcantidad.Value = 1
        End Sub

        Private Sub calcularTotal()
            Dim total As Decimal = 0
            If dgvdata.Rows.Count > 0 Then
                For Each row As DataGridViewRow In dgvdata.Rows
                    total += Convert.ToDecimal(row.Cells("SubTotal").Value.ToString())
                Next
            End If
            txttotalpagar.Text = total.ToString("0.00")
        End Sub

        Private Sub dgvdata_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs)
            If e.RowIndex < 0 Then Return

            If e.ColumnIndex = 6 Then

                e.Paint(e.CellBounds, DataGridViewPaintParts.All)

                Dim w = Properties.Resources.delete25.Width
                Dim h = Properties.Resources.delete25.Height
                Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
                Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2

                e.Graphics.DrawImage(Properties.Resources.delete25, New Rectangle(x, y, w, h))
                e.Handled = True
            End If
        End Sub

        Private Sub dgvdata_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

            If dgvdata.Columns(e.ColumnIndex).Name Is "btneliminar" Then
                Dim indice = e.RowIndex

                If indice >= 0 Then
                    dgvdata.Rows.RemoveAt(indice)
                    calcularTotal()
                End If
            End If
        End Sub

        Private Sub txtpreciocompra_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                If txtpreciocompra.Text.Trim().Length = 0 AndAlso Equals(e.KeyChar.ToString(), ".") Then
                    e.Handled = True
                Else
                    If Char.IsControl(e.KeyChar) OrElse Equals(e.KeyChar.ToString(), ".") Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End Sub

        Private Sub txtprecioventa_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                If txtprecioventa.Text.Trim().Length = 0 AndAlso Equals(e.KeyChar.ToString(), ".") Then
                    e.Handled = True
                Else
                    If Char.IsControl(e.KeyChar) OrElse Equals(e.KeyChar.ToString(), ".") Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End Sub

        Private Sub btnregistrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Convert.ToInt32(txtidproveedor.Text) = 0 Then
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If dgvdata.Rows.Count < 1 Then
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim detalle_compra As DataTable = New DataTable()

            detalle_compra.Columns.Add("IdProducto", GetType(Integer))
            detalle_compra.Columns.Add("PrecioCompra", GetType(Decimal))
            detalle_compra.Columns.Add("PrecioVenta", GetType(Decimal))
            detalle_compra.Columns.Add("Cantidad", GetType(Integer))
            detalle_compra.Columns.Add("MontoTotal", GetType(Decimal))

            For Each row As DataGridViewRow In dgvdata.Rows
                detalle_compra.Rows.Add(New Object() {Convert.ToInt32(row.Cells("IdProducto").Value.ToString()), row.Cells("PrecioCompra").Value.ToString(), row.Cells("PrecioVenta").Value.ToString(), row.Cells("Cantidad").Value.ToString(), row.Cells("SubTotal").Value.ToString()})

            Next

            Dim idcorrelativo As Integer = New CapaNegocio.CN_Compra().ObtenerCorrelativo()
            Dim numerodocumento = String.Format("{0:00000}", idcorrelativo)

            Dim oCompra As Compra = New Compra() With {
    .oUsuario = New Usuario() With {
        .IdUsuario = _Usuario.IdUsuario
    },
    .oProveedor = New Proveedor() With {
        .IdProveedor = Convert.ToInt32(txtidproveedor.Text)
    },
    .TipoDocumento = CType(cbotipodocumento.SelectedItem, OpcionCombo).Texto,
    .NumeroDocumento = numerodocumento,
    .MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
}

            Dim mensaje = String.Empty
            Dim respuesta As Boolean = New CapaNegocio.CN_Compra().Registrar(oCompra, detalle_compra, mensaje)

            If respuesta Then
                Dim result = MessageBox.Show("Numero de compra generada:" & Microsoft.VisualBasic.Constants.vbLf & numerodocumento & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then Clipboard.SetText(numerodocumento)

                txtidproveedor.Text = "0"
                txtdocproveedor.Text = ""
                txtnombreproveedor.Text = ""
                dgvdata.Rows.Clear()
                calcularTotal()
            Else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub
    End Class
End Namespace
