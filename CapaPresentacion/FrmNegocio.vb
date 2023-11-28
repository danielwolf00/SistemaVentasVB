Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio

Namespace CapaPresentacion
    Public Partial Class FrmNegocio
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Function ByteToImage(ByVal imageBytes As Byte()) As Image
            Dim ms As MemoryStream = New MemoryStream()
            ms.Write(imageBytes, 0, imageBytes.Length)
            Dim image As Image = New Bitmap(ms)

            Return image
        End Function

        Private Sub iconButton1_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub piclogo_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub FrmNegocio_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim obtenido = True
            Dim byteimage As Byte() = New CapaNegocio.CN_Negocio().ObtenerLogo(obtenido)

            If obtenido Then picLogo.Image = ByteToImage(byteimage)

            Dim datos As Negocio = New CapaNegocio.CN_Negocio().ObtenerDatos()

            txtnombre.Text = datos.Nombre
            txtruc.Text = datos.RUC
            txtdireccion.Text = datos.Direccion

        End Sub

        Private Sub btnsubir_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim mensaje = String.Empty

            Dim oOpenFileDialog As OpenFileDialog = New OpenFileDialog()
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png"

            If oOpenFileDialog.ShowDialog() = DialogResult.OK Then

                Dim byteimage = File.ReadAllBytes(oOpenFileDialog.FileName)
                Dim respuesta As Boolean = New CapaNegocio.CN_Negocio().ActualizarLogo(byteimage, mensaje)

                If respuesta Then
                    picLogo.Image = ByteToImage(byteimage)
                Else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End If

        End Sub

        Private Sub btnguardarcambios_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim mensaje = String.Empty

            Dim obj As Negocio = New Negocio() With {
    .Nombre = txtnombre.Text,
    .RUC = txtruc.Text,
    .Direccion = txtdireccion.Text
}

            Dim respuesta As Boolean = New CapaNegocio.CN_Negocio().GuardarDatos(obj, mensaje)

            If respuesta Then
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End Sub
    End Class
End Namespace
