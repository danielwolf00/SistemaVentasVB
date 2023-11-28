Imports System
Imports System.Collections.Generic
Imports System.Text
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Compra
        Public Function ObtenerCorrelativo() As Integer
            Dim idcorrelativo = 0

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select count(*) + 1 from COMPRA")
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text

                    oconexion.Open()

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    idcorrelativo = 0
                End Try
            End Using
            Return idcorrelativo
        End Function


        Public Function Registrar(ByVal obj As Compra, ByVal DetalleCompra As DataTable, <Out> ByRef Mensaje As String) As Boolean
            Dim Respuesta = False
            Mensaje = String.Empty


            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try
                    Dim cmd As SqlCommand = New SqlCommand("sp_RegistrarCompra", oconexion)
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario)
                    cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor)
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento)
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento)
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal)
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra)
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    Respuesta = Convert.ToBoolean(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()
                Catch ex As Exception
                    Respuesta = False
                    Mensaje = ex.Message
                End Try
            End Using
            Return Respuesta
        End Function

        Public Function ObtenerCompra(ByVal numero As String) As Compra
            Dim obj As Compra = New Compra()
            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try

                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select c.IdCompra,")
                    query.AppendLine("u.NombreCompleto,")
                    query.AppendLine("pr.Documento,pr.RazonSocial,")
                    query.AppendLine("c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,convert(char(10), c.FechaRegistro, 103)[FechaRegistro]")
                    query.AppendLine("from COMPRA c")
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = c.IdUsuario")
                    query.AppendLine("inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor")
                    query.AppendLine("where c.NumeroDocumento = @numero")


                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.Parameters.AddWithValue("@numero", numero)
                    cmd.CommandType = CommandType.Text

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            obj = New Compra() With {
    .IdCompra = Convert.ToInt32(dr("IdCompra")),
    .oUsuario = New Usuario() With {
        .NombreCompleto = dr("NombreCompleto").ToString()
    },
    .oProveedor = New Proveedor() With {
        .Documento = dr("Documento").ToString(),
        .RazonSocial = dr("RazonSocial").ToString()
    },
    .TipoDocumento = dr("TipoDocumento").ToString(),
    .NumeroDocumento = dr("NumeroDocumento").ToString(),
    .MontoTotal = Convert.ToDecimal(dr("MontoTotal").ToString()),
    .FechaRegistro = dr("FechaRegistro").ToString()
}
                        End While

                    End Using
                Catch ex As Exception
                    obj = New Compra()
                End Try
            End Using
            Return obj
        End Function


        Public Function ObtenerDetalleCompra(ByVal idcompra As Integer) As List(Of Detalle_Compra)
            Dim oLista As List(Of Detalle_Compra) = New List(Of Detalle_Compra)()
            Try
                Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                    conexion.Open()
                    Dim query As StringBuilder = New StringBuilder()

                    query.AppendLine("select p.Nombre,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal from DETALLE_COMPRA dc")
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dc.IdProducto")
                    query.AppendLine("where dc.IdCompra =  @idcompra")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), conexion)
                    cmd.Parameters.AddWithValue("@idcompra", idcompra)
                    cmd.CommandType = CommandType.Text

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            oLista.Add(New Detalle_Compra() With {
    .oProducto = New Producto() With {
        .Nombre = dr("Nombre").ToString()
    },
    .PrecioCompra = Convert.ToDecimal(dr("PrecioCompra").ToString()),
    .Cantidad = Convert.ToInt32(dr("Cantidad").ToString()),
    .MontoTotal = Convert.ToDecimal(dr("MontoTotal").ToString())
})
                        End While
                    End Using
                End Using
            Catch ex As Exception
                oLista = New List(Of Detalle_Compra)()
            End Try
            Return oLista
        End Function

    End Class
End Namespace
