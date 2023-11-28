Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio

Namespace CapaPresentacion
    Public Partial Class FrmClientes
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FrmClientes_Load(ByVal sender As Object, ByVal e As EventArgs)
            boestado.Items.Add(New OpcionCombo() With {
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
            Dim lista As List(Of Cliente) = New CN_Cliente().Listar()

            For Each item In lista
                dgvdata.Rows.Add(New Object() {"", item.IdCliente, item.Documento, item.NombreCompleto, item.Correo, item.Telefono, If(item.Estado = True, 1, 0), If(item.Estado = True, "Activo", "No Activo")})
            Next
        End Sub

        Private Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim mensaje = String.Empty

            Dim obj As Cliente = New Cliente() With {
    .IdCliente = Convert.ToInt32(txtid.Text),
    .Documento = txtdocumento.Text,
    .NombreCompleto = txtnombrecompleto.Text,
    .Correo = txtcorreo.Text,
    .Telefono = txttelefono.Text,
    .Estado = If(Convert.ToInt32(CType(cboestado.SelectedItem, OpcionCombo).Valor) = 1, True, False)
}

            If obj.IdCliente = 0 Then
                Dim idgenerado As Integer = New CN_Cliente().Registrar(obj, mensaje)

                If idgenerado <> 0 Then

                    dgvdata.Rows.Add(New Object() {"", idgenerado, txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txttelefono.Text, CType(cboestado.SelectedItem, OpcionCombo).Valor.ToString(), CType(cboestado.SelectedItem, OpcionCombo).Texto.ToString()})

                    Limpiar()
                Else
                    MessageBox.Show(mensaje)
                End If
            Else
                Dim resultado As Boolean = New CN_Cliente().Editar(obj, mensaje)

                If resultado Then
                    Dim row As DataGridViewRow = dgvdata.Rows(Convert.ToInt32(txtindice.Text))
                    row.Cells("Id").Value = txtid.Text
                    row.Cells("Documento").Value = txtdocumento.Text
                    row.Cells("NombreCompleto").Value = txtnombrecompleto.Text
                    row.Cells("Correo").Value = txtcorreo.Text
                    row.Cells("Telefono").Value = txttelefono.Text
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
            txtdocumento.Text = ""
            txtnombrecompleto.Text = ""
            txtcorreo.Text = ""
            txttelefono.Text = ""
            cboestado.SelectedIndex = 0
            txtdocumento.[Select]()
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
                    txtdocumento.Text = dgvdata.Rows(indice).Cells("Documento").Value.ToString()
                    txtnombrecompleto.Text = dgvdata.Rows(indice).Cells("NombreCompleto").Value.ToString()
                    txtcorreo.Text = dgvdata.Rows(indice).Cells("Correo").Value.ToString()
                    txttelefono.Text = dgvdata.Rows(indice).Cells("Telefono").Value.ToString()

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
                If MessageBox.Show("¿Desea eliminar el cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim mensaje = String.Empty
                    Dim obj As Cliente = New Cliente() With {
    .IdCliente = Convert.ToInt32(txtid.Text)
}

                    Dim respuesta As Boolean = New CN_Cliente().Eliminar(obj, mensaje)

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
    End Class
End Namespace
' TODO: Error SkippedTokensTrivia '}'

