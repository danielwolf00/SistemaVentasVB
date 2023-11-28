Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio

Namespace CapaPresentacion
    Public Partial Class FrmProducto
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FrmProducto_Load(ByVal sender As Object, ByVal e As EventArgs)
            cboestado.Items.Add(New OpcionCombo() With {
                .Valor = 1,
                .Texto = "Activo"
            })
            cboestado.Items.Add(New OpcionCombo() With {
                .Valor = 0,
                .Texto = "No Activo"
            })
            cboestado.DisplayMember = "Texto"
            cboestado.ValueMember = "Valor"
            cboestado.SelectedIndex = 0


            Dim listacategoria As List(Of Categoria) = New CapaNegocio.CN_Categoria().Listar()

            For Each item In listacategoria
                cbocategoria.Items.Add(New OpcionCombo() With {
                    .Valor = item.IdCategoria,
                    .Texto = item.Descripcion
                })
            Next
            cbocategoria.DisplayMember = "Texto"
            cbocategoria.ValueMember = "Valor"
            cbocategoria.SelectedIndex = 0


            For Each columna As DataGridViewColumn In dgvdata.Columns

                If columna.Visible = True AndAlso Not Equals(columna.Name, "btnseleccionar") Then
                    cbobusqueda.Items.Add(New OpcionCombo() With {
                        .Valor = columna.Name,
                        .Texto = columna.HeaderText
                    })
                End If
            Next
            cbobusqueda.DisplayMember = "Texto"
            cbobusqueda.ValueMember = "Valor"
            cbobusqueda.SelectedIndex = 0



            'MOSTRAR TODOS LOS USUARIOS
            Dim lista As List(Of Producto) = New CN__Producto().Listar()

            For Each item In lista

                dgvdata.Rows.Add(New Object() {"", item.IdProducto, item.Codigo, item.Nombre, item.Descripcion, item.oCategoria.IdCategoria, item.oCategoria.Descripcion, item.Stock, item.PrecioCompra, item.PrecioVenta, If(item.Estado = True, 1, 0), If(item.Estado = True, "Activo", "No Activo")})
            Next

        End Sub

        Private Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs)

            Dim mensaje = String.Empty

            Dim obj As Producto = New Producto() With {
    .IdProducto = Convert.ToInt32(txtid.Text),
    .Codigo = txtcodigo.Text,
    .Nombre = txtnombre.Text,
    .Descripcion = txtdescripcion.Text,
    .oCategoria = New Categoria() With {
        .IdCategoria = Convert.ToInt32(CType(cbocategoria.SelectedItem, OpcionCombo).Valor)
    },
    .Estado = If(Convert.ToInt32(CType(cboestado.SelectedItem, OpcionCombo).Valor) = 1, True, False)
}

            If obj.IdProducto = 0 Then
                Dim idgenerado As Integer = New CN__Producto().Registrar(obj, mensaje)

                If idgenerado <> 0 Then

                    dgvdata.Rows.Add(New Object() {"", idgenerado, txtcodigo.Text, txtnombre.Text, txtdescripcion.Text, CType(cbocategoria.SelectedItem, OpcionCombo).Valor.ToString(), CType(cbocategoria.SelectedItem, OpcionCombo).Texto.ToString(), "0", "0.00", "0.00", CType(cboestado.SelectedItem, OpcionCombo).Valor.ToString(), CType(cboestado.SelectedItem, OpcionCombo).Texto.ToString()})

                    Limpiar()
                Else
                    MessageBox.Show(mensaje)
                End If
            Else
                Dim resultado As Boolean = New CN__Producto().Editar(obj, mensaje)

                If resultado Then
                    Dim row As DataGridViewRow = dgvdata.Rows(Convert.ToInt32(txtindice.Text))
                    row.Cells("Id").Value = txtid.Text
                    row.Cells("Codigo").Value = txtcodigo.Text
                    row.Cells("Nombre").Value = txtnombre.Text
                    row.Cells("Descripcion").Value = txtdescripcion.Text
                    row.Cells("IdCategoria").Value = CType(cbocategoria.SelectedItem, OpcionCombo).Valor.ToString()
                    row.Cells("Categoria").Value = CType(cbocategoria.SelectedItem, OpcionCombo).Texto.ToString()
                    row.Cells("EstadoValor").Value = CType(cboestado.SelectedItem, OpcionCombo).Valor.ToString()
                    row.Cells("Estado").Value = CType(cboestado.SelectedItem, OpcionCombo).Texto.ToString()

                    Limpiar()
                Else
                    MessageBox.Show(mensaje)
                End If
            End If


        End Sub



        Private Sub Limpiar()

            txtindice.Text = "-1"
            txtid.Text = "0"
            txtcodigo.Text = ""
            txtnombre.Text = ""
            txtdescripcion.Text = ""
            cbocategoria.SelectedIndex = 0
            cboestado.SelectedIndex = 0

            txtcodigo.Select()

        End Sub

        Private Sub dgvdata_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs)
            If e.RowIndex < 0 Then Return

            If e.ColumnIndex = 0 Then

                e.Paint(e.CellBounds, DataGridViewPaintParts.All)

                Dim w = Properties.Resources.check20.Width
                Dim h = Properties.Resources.check20.Height
                Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
                Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2

                e.Graphics.DrawImage(Properties.Resources.check20, New Rectangle(x, y, w, h))
                e.Handled = True
            End If
        End Sub

        Private Sub dgvdata_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
            If dgvdata.Columns(e.ColumnIndex).Name Is "btnseleccionar" Then

                Dim indice = e.RowIndex

                If indice >= 0 Then

                    txtindice.Text = indice.ToString()
                    txtid.Text = dgvdata.Rows(indice).Cells("Id").Value.ToString()

                    txtcodigo.Text = dgvdata.Rows(indice).Cells("Codigo").Value.ToString()
                    txtnombre.Text = dgvdata.Rows(indice).Cells("Nombre").Value.ToString()
                    txtdescripcion.Text = dgvdata.Rows(indice).Cells("Descripcion").Value.ToString()


                    For Each oc As OpcionCombo In cbocategoria.Items
                        If Convert.ToInt32(oc.Valor) = Convert.ToInt32(dgvdata.Rows(indice).Cells("IdCategoria").Value) Then
                            Dim indice_combo As Integer = cbocategoria.Items.IndexOf(oc)
                            cbocategoria.SelectedIndex = indice_combo
                            Exit For
                        End If
                    Next


                    For Each oc As OpcionCombo In cboestado.Items
                        If Convert.ToInt32(oc.Valor) = Convert.ToInt32(dgvdata.Rows(indice).Cells("EstadoValor").Value) Then
                            Dim indice_combo = cboestado.Items.IndexOf(oc)
                            cboestado.SelectedIndex = indice_combo
                            Exit For
                        End If
                    Next


                End If


            End If
        End Sub

        Private Sub btneliminar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Convert.ToInt32(txtid.Text) <> 0 Then
                If MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim mensaje = String.Empty
                    Dim obj As Producto = New Producto() With {
    .IdProducto = Convert.ToInt32(txtid.Text)
}

                    Dim respuesta As Boolean = New CN__Producto().Eliminar(obj, mensaje)

                    If respuesta Then
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text))
                        Limpiar()
                    Else
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                End If
            End If
        End Sub

        Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim columnaFiltro As String = CType(cbobusqueda.SelectedItem, OpcionCombo).Valor.ToString()

            If dgvdata.Rows.Count > 0 Then
                For Each row As DataGridViewRow In dgvdata.Rows

                    If row.Cells(columnaFiltro).Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()) Then
                        row.Visible = True
                    Else
                        row.Visible = False
                    End If
                Next
            End If
        End Sub

        Private Sub btnlimpiarbuscador_Click(ByVal sender As Object, ByVal e As EventArgs)
            txtbusqueda.Text = ""
            For Each row As DataGridViewRow In dgvdata.Rows
                row.Visible = True
            Next
        End Sub

        Private Sub btnlimpiar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Limpiar()
        End Sub

        Private Sub btnexportar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If dgvdata.Rows.Count < 1 Then
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim dt As DataTable = New DataTable()

                For Each columna As DataGridViewColumn In dgvdata.Columns
                    If Not Equals(columna.HeaderText, "") AndAlso columna.Visible Then dt.Columns.Add(columna.HeaderText, GetType(String))
                Next

                For Each row As DataGridViewRow In dgvdata.Rows

                    If row.Visible Then dt.Rows.Add(New Object() {row.Cells(2).Value.ToString(), row.Cells(3).Value.ToString(), row.Cells(4).Value.ToString(), row.Cells(6).Value.ToString(), row.Cells(7).Value.ToString(), row.Cells(8).Value.ToString(), row.Cells(9).Value.ToString(), row.Cells(11).Value.ToString()})
                Next

                Dim savefile As SaveFileDialog = New SaveFileDialog()
                savefile.FileName = String.Format("ReporteProducto_{0}.xlsx", Date.Now.ToString("ddMMyyyyHHmmss"))
                savefile.Filter = "Excel Files | *.xlsx"

                If savefile.ShowDialog() = DialogResult.OK Then

                    Try
                        Dim wb As XLWorkbook = New XLWorkbook()
                        Dim hoja = wb.Worksheets.Add(dt, "Informe")
                        hoja.ColumnsUsed().AdjustToContents()
                        wb.SaveAs(savefile.FileName)
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try

                End If

            End If
        End Sub
    End Class
End Namespace
