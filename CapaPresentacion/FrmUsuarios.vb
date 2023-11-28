Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports CapaPresentacion.Utilidades



Imports CapaEntidad
Imports CapaNegocio

Namespace CapaPresentacion
    Public Partial Class FrmUsuarios
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub cboEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)




        End Sub

        Private Sub FrmUsuarios_Load(ByVal sender As Object, ByVal e As EventArgs)

            cboEstado.Items.Add(New OpcionCombo() With {
                .Valor = 1,
                .Texto = "Activo"
            })
            cboEstado.Items.Add(New OpcionCombo() With {
                .Valor = 0,
                .Texto = "No Activo"
            })
            cboEstado.DisplayMember = "Texto"
            cboEstado.ValueMember = "Valor"
            cboEstado.SelectedIndex = 0
            Dim listaRol As List(Of Rol) = New CapaNegocio.CN_Rol().Listar()

            For Each item In listaRol
                cboRol.Items.Add(New OpcionCombo() With {
                    .Valor = item.IdRol,
                    .Texto = item.Descripcion
                })
            Next
            cboRol.DisplayMember = "Texto"
            cboRol.ValueMember = "Valor"
            cboRol.SelectedIndex = 0
            For Each columna As DataGridViewColumn In dtgData.Columns
                If columna.Visible = True Then
                    cboBusqueda.Items.Add(New OpcionCombo() With {
                        .Valor = columna.Name,
                        .Texto = columna.HeaderText
                    })
                End If
            Next
            cboBusqueda.DisplayMember = "Texto"
            cboBusqueda.ValueMember = "Valor"
            cboBusqueda.SelectedIndex = 0


        End Sub

        Private Sub btnGuardarFRMUsuario_Click(ByVal sender As Object, ByVal e As EventArgs)


            dtgData.Rows.Add(New Object() {"", txtdocumentoUsuario, txtdocumentoUsuario.Text, txtNombeCompletoUsuario.Text, txtCorreoUsuario.Text, txtClaveUsuario.Text, CType(cboRol.SelectedItem, OpcionCombo).Valor.ToString(), CType(cboRol.SelectedItem, OpcionCombo).Texto.ToString(), CType(cboEstado.SelectedItem, OpcionCombo).Valor.ToString(), CType(cboEstado.SelectedItem, OpcionCombo).Texto.ToString()})
            Dim listaUsuario As List(Of Usuario) = New CapaNegocio.CN_Usuario().Listar()

            For Each item In listaUsuario
                dgvdata.Rows.Add(New Object() {"", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave, item.oRol.IdRol, item.oRol.Descripcion, If(item.Estado = True, 1, 0), If(item.Estado = True, "Activo", "No Activo")})
            Next
            If True Then

            End If





        End Sub

        Private Sub label12_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
        Private Sub Limpiar()



            txtdocumentoUsuario.Text = ""
            txtNombeCompletoUsuario.Text = ""
            txtCorreoUsuario.Text = ""
            txtClaveUsuario.Text = ""
            cboRol.SelectedIndex = 0
            cboEstado.SelectedIndex = 0

            'txtdocumentoUsuario.Select();

        End Sub
        Private Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim mensaje = String.Empty

            Dim objusuario As Usuario = New Usuario() With {
    .IdUsuario = Convert.ToInt32(txtid.Text),
    .Documento = txtdocumento.Text,
    .NombreCompleto = txtnombrecompleto.Text,
    .Correo = txtcorreo.Text,
    .Clave = txtclave.Text,
    .oRol = New Rol() With {
        .IdRol = Convert.ToInt32(CType(cboRol.SelectedItem, OpcionCombo).Valor)
    },
    .Estado = If(Convert.ToInt32(CType(cboEstado.SelectedItem, OpcionCombo).Valor) = 1, True, False)
}
            If objusuario.IdUsuario = 0 Then
                Dim idusuariogenerado As nt = New CapaNegocio.CN_Usuario().Registrar(objusuario, mensaje)

                If idusuariogenerado <> 0 Then
                    dgvdata.Rows.Add(New Object() {"", idusuariogenerado, txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txtclave.Text, CType(cborol.SelectedItem, OpcionCombo).Valor.ToString(), CType(cborol.SelectedItem, OpcionCombo).Texto.ToString(), CType(cboestado.SelectedItem, OpcionCombo).Valor.ToString(), CType(cboestado.SelectedItem, OpcionCombo).Texto.ToString()})

                    Limpiar()
                Else
                    MessageBox.Show(mensaje)
                End If
            Else
                Dim resultado As Boolean = New CapaNegocio.CN_Usuario().Editar(objusuario, mensaje)

                If resultado Then
                    Dim row As DataGridViewRow = dgvdata.Rows(Convert.ToInt32(txtindice.Text))
                    row.Cells("Id").Value = txtid.Text
                    row.Cells("Documento").Value = txtdocumento.Text
                    row.Cells("NombreCompleto").Value = txtnombrecompleto.Text
                    row.Cells("Correo").Value = txtcorreo.Text
                    row.Cells("Clave").Value = txtclave.Text
                    row.Cells("IdRol").Value = CType(cborol.SelectedItem, OpcionCombo).Valor.ToString()
                    row.Cells("Rol").Value = CType(cborol.SelectedItem, OpcionCombo).Texto.ToString()
                    row.Cells("EstadoValor").Value = CType(cboestado.SelectedItem, OpcionCombo).Valor.ToString()
                    row.Cells("Estado").Value = CType(cboestado.SelectedItem, OpcionCombo).Texto.ToString()

                    Limpiar()
                Else
                    MessageBox.Show(mensaje)
                End If
            End If

        End Sub
        Private Sub btneliminar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Convert.ToInt32(txtid.Text) <> 0 Then
                If MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim mensaje = String.Empty
                    Dim objusuario As Usuario = New Usuario() With {
    .IdUsuario = Convert.ToInt32(txtid.Text)
}

                    Dim respuesta As Boolean = New CapaNegocio.CN_Usuario().Eliminar(objusuario, mensaje)

                    If respuesta Then
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text))
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
