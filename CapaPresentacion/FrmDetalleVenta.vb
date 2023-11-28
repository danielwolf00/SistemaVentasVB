Imports System
Imports System.Windows.Forms
Imports CapaEntidad
Imports CapaNegocio

Namespace CapaPresentacion
    Public Partial Class FrmDetalleVenta
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FrmDetalleVenta_Load(ByVal sender As Object, ByVal e As EventArgs)
            txtbusqueda.[Select]()
        End Sub
        Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim oVenta As Venta = New CapaNegocio.CN_Venta().ObtenerVenta(txtbusqueda.Text)

            If oVenta.IdVenta <> 0 Then

                txtnumerodocumento.Text = oVenta.NumeroDocumento

                txtfecha.Text = oVenta.FechaRegistro
                txttipodocumento.Text = oVenta.TipoDocumento
                txtusuario.Text = oVenta.oUsuario.NombreCompleto


                txtdoccliente.Text = oVenta.DocumentoCliente
                txtnombrecliente.Text = oVenta.NombreCliente

                dgvdata.Rows.Clear()
                For Each dv In oVenta.oDetalle_Venta
                    dgvdata.Rows.Add(New Object() {dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal})
                Next

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00")
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00")
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00")


            End If

        End Sub

        Private Sub btnborrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            txtfecha.Text = ""
            txttipodocumento.Text = ""
            txtusuario.Text = ""
            txtdoccliente.Text = ""
            txtnombrecliente.Text = ""

            dgvdata.Rows.Clear()
            txtmontototal.Text = "0.00"
            txtmontopago.Text = "0.00"
            txtmontocambio.Text = "0.00"
        End Sub

        Private Sub btndescargar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If txttipodocumento.Text Is "" Then
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim Texto_Html As String = Properties.Resources.PlantillaVenta.ToString()
            Dim odatos As Negocio = New CapaNegocio.CN_Negocio().ObtenerDatos()

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper())
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC)
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion)

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper())
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text)


            Texto_Html = Texto_Html.Replace("@doccliente", txtdoccliente.Text)
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text)
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text)
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text)

            Dim filas = String.Empty
            For Each row As DataGridViewRow In dgvdata.Rows
                filas += "<tr>"
                filas += "<td>" & row.Cells("Producto").Value.ToString() & "</td>"
                filas += "<td>" & row.Cells("Precio").Value.ToString() & "</td>"
                filas += "<td>" & row.Cells("Cantidad").Value.ToString() & "</td>"
                filas += "<td>" & row.Cells("SubTotal").Value.ToString() & "</td>"
                filas += "</tr>"
            Next
            Texto_Html = Texto_Html.Replace("@filas", filas)
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text)
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text)
            Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text)

            Dim savefile As SaveFileDialog = New SaveFileDialog()
            savefile.FileName = String.Format("Venta_{0}.pdf", txtnumerodocumento.Text)
            savefile.Filter = "Pdf Files|*.pdf"

            If savefile.ShowDialog() = DialogResult.OK Then
                Using stream As FileStream = New FileStream(savefile.FileName, FileMode.Create)

                    Dim pdfDoc As Document = New Document(PageSize.A4, 25, 25, 25, 25)

                    Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, stream)
                    pdfDoc.Open()

                    Dim obtenido = True
                    Dim byteImage As Byte() = New CapaNegocio.CN_Negocio().ObtenerLogo(obtenido)

                    If obtenido Then
                        Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(byteImage)
                        img.ScaleToFit(60, 60)
                        img.Alignment = iTextSharp.text.Image.UNDERLYING
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51))
                        pdfDoc.Add(img)
                    End If

                    Using sr As StringReader = New StringReader(Texto_Html)
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr)
                    End Using

                    pdfDoc.Close()
                    stream.Close()
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If
        End Sub
    End Class
End Namespace
