Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio
Imports CapaPresentacion.Utilidades

Namespace CapaPresentacion.Modales
    Public Partial Class mcCliente
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub txtBusqueda_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub mcCliente_Load(ByVal sender As Object, ByVal e As EventArgs)
            For Each columna As DataGridViewColumn In dgvdata.Columns
                cbobusqueda.Items.Add(New OpcionCombo() With {
                    .Valor = columna.Name,
                    .Texto = columna.HeaderText
                })
            Next

            cbobusqueda.DisplayMember = "Texto"
            cbobusqueda.ValueMember = "Valor"
            cbobusqueda.SelectedIndex = 0

            Dim lista As List(Of Cliente) = New CN_Cliente().Listar()

            For Each item In lista
                If item.Estado Then dgvdata.Rows.Add(New Object() {item.Documento, item.NombreCompleto})
            Next

        End Sub

        Private Sub dgvdata_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
            Dim iRow = e.RowIndex
            Dim iColum = e.ColumnIndex
            If iRow >= 0 AndAlso iColum >= 0 Then
                _Cliente = New Cliente() With {
    .Documento = dgvdata.Rows(iRow).Cells("Documento").Value.ToString(),
    .NombreCompleto = dgvdata.Rows(iRow).Cells("NombreCompleto").Value.ToString()
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
