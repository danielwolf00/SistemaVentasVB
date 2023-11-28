Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Venta
        Public Function ObtenerCorrelativo() As Integer
            Dim idcorrelativo = 0

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select count(*) + 1 from VENTA")
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

        Public Function RestarStock(ByVal idproducto As Integer, ByVal cantidad As Integer) As Boolean
            Dim respuesta = True

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@idproducto", idproducto)
                    cmd.CommandType = CommandType.Text
                    oconexion.Open()

                    respuesta = If(cmd.ExecuteNonQuery() > 0, True, False)
                Catch ex As Exception
                    respuesta = False
                End Try
            End Using
            Return respuesta

        End Function


        Public Function SumarStock(ByVal idproducto As Integer, ByVal cantidad As Integer) As Boolean
            Dim respuesta = True

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("update producto set stock = stock + @cantidad where idproducto = @idproducto")
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@idproducto", idproducto)
                    cmd.CommandType = CommandType.Text
                    oconexion.Open()

                    respuesta = If(cmd.ExecuteNonQuery() > 0, True, False)
                Catch ex As Exception
                    respuesta = False
                End Try
            End Using
            Return respuesta

        End Function



        Public Function Registrar(ByVal obj As Venta, ByVal DetalleVenta As DataTable, <Out> ByRef Mensaje As String) As Boolean
            Dim Respuesta = False
            Mensaje = String.Empty
            Try
                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                    Dim cmd As SqlCommand = New SqlCommand("usp_RegistrarVenta", oconexion)
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario)
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento)
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento)
                    cmd.Parameters.AddWithValue("DocumentoCliente", obj.DocumentoCliente)
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente)
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago)
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio)
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal)
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta)
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()
                    cmd.ExecuteNonQuery()

                    Respuesta = Convert.ToBoolean(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()
                End Using
            Catch ex As Exception
                Respuesta = False
                Mensaje = ex.Message
            End Try

            Return Respuesta
        End Function


        Public Function ObtenerVenta(ByVal numero As String) As Venta

            Dim obj As Venta = New Venta()

            Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                Try
                    conexion.Open()
                    Dim query As StringBuilder = New StringBuilder()

                    query.AppendLine("select v.IdVenta,u.NombreCompleto,")
                    query.AppendLine("v.DocumentoCliente,v.NombreCliente,")
                    query.AppendLine("v.TipoDocumento,v.NumeroDocumento,")
                    query.AppendLine("v.MontoPago,v.MontoCambio,v.MontoTotal,")
                    query.AppendLine("convert(char(10),v.FechaRegistro,103)[FechaRegistro]")
                    query.AppendLine("from VENTA v")
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = v.IdUsuario")
                    query.AppendLine("where v.NumeroDocumento = @numero")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), conexion)
                    cmd.Parameters.AddWithValue("@numero", numero)
                    cmd.CommandType = CommandType.Text

                    Using dr As SqlDataReader = cmd.ExecuteReader()

                        While dr.Read()
                            obj = New Venta() With {
    .IdVenta = Integer.Parse(dr("IdVenta").ToString()),
    .oUsuario = New Usuario() With {
        .NombreCompleto = dr("NombreCompleto").ToString()
    },
    .DocumentoCliente = dr("DocumentoCliente").ToString(),
    .NombreCliente = dr("NombreCliente").ToString(),
    .TipoDocumento = dr("TipoDocumento").ToString(),
    .NumeroDocumento = dr("NumeroDocumento").ToString(),
    .MontoPago = Convert.ToDecimal(dr("MontoPago").ToString()),
    .MontoCambio = Convert.ToDecimal(dr("MontoCambio").ToString()),
    .MontoTotal = Convert.ToDecimal(dr("MontoTotal").ToString()),
    .FechaRegistro = dr("FechaRegistro").ToString()
}
                        End While
                    End Using

                Catch
                    obj = New Venta()
                End Try

            End Using
            Return obj

        End Function


        Public Function ObtenerDetalleVenta(ByVal idVenta As Integer) As List(Of Detalle_Venta)
            Dim oLista As List(Of Detalle_Venta) = New List(Of Detalle_Venta)()

            Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                Try
                    conexion.Open()
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select p.Nombre,dv.PrecioVenta,dv.Cantidad,dv.SubTotal from DETALLE_VENTA dv")
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dv.IdProducto")
                    query.AppendLine(" where dv.IdVenta = @idventa")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), conexion)
                    cmd.Parameters.AddWithValue("@idventa", idVenta)
                    cmd.CommandType = CommandType.Text


                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            oLista.Add(New Detalle_Venta() With {
    .oProducto = New Producto() With {
        .Nombre = dr("Nombre").ToString()
    },
    .PrecioVenta = Convert.ToDecimal(dr("PrecioVenta").ToString()),
    .Cantidad = Convert.ToInt32(dr("Cantidad").ToString()),
    .SubTotal = Convert.ToDecimal(dr("SubTotal").ToString())
})
                        End While
                    End Using

                Catch
                    oLista = New List(Of Detalle_Venta)()
                End Try
            End Using
            Return oLista
        End Function

    End Class
End Namespace
