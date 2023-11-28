Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio
Imports CapaPresentacion.Utilidades

Namespace CapaPresentacion.Modales
    Public Partial Class mdProvedor
        Inherits Form

        Public Property _Producto As Producto

        Public Sub New()

            InitializeComponent()
        End Sub

        Private Sub mdProvedor_Load(ByVal sender As Object, ByVal e As EventArgs)
            For Each columna As DataGridViewColumn In dgvdata.Columns

                If columna.Visible = True Then
                    cbobusqueda.Items.Add(New OpcionCombo() With {
                        .Valor = columna.Name,
                        .Texto = columna.HeaderText
                    })
                End If
            Next
            cbobusqueda.DisplayMember = "Texto"
            cbobusqueda.ValueMember = "Valor"
            cbobusqueda.SelectedIndex = 0

            Dim lista As List(Of Producto) = New CN__Producto().Listar()

            For Each item In lista
                dgvdata.Rows.Add(New Object() {item.IdProducto, item.Codigo, item.Nombre, item.oCategoria.Descripcion, item.Stock, item.PrecioCompra, item.PrecioVenta})
            Next
        End Sub

        Private Sub dgvdata_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
            Dim iRow = e.RowIndex
            Dim iColum = e.ColumnIndex
            If iRow >= 0 AndAlso iColum > 0 Then
                _Producto = New Producto() With {
    .IdProducto = Convert.ToInt32(dgvdata.Rows(iRow).Cells("Id").Value.ToString()),
    .Codigo = dgvdata.Rows(iRow).Cells("Codigo").Value.ToString(),
    .Nombre = dgvdata.Rows(iRow).Cells("Nombre").Value.ToString(),
    .Stock = Convert.ToInt32(dgvdata.Rows(iRow).Cells("Stock").Value.ToString()),
    .PrecioCompra = Convert.ToDecimal(dgvdata.Rows(iRow).Cells("PrecioCompra").Value.ToString()),
    .PrecioVenta = Convert.ToDecimal(dgvdata.Rows(iRow).Cells("PrecioVenta").Value.ToString())
}
                DialogResult = DialogResult.OK
                Close()
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
    End Class
End Namespace
