Imports System
Imports System.Collections.Generic
Imports System.Text
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Data

Namespace CapaDatos
    Public Class CD_Reporte
        Public Function Compra(ByVal fechainicio As String, ByVal fechafin As String, ByVal idproveedor As Integer) As List(Of ReporteCompra)
            Dim lista As List(Of ReporteCompra) = New List(Of ReporteCompra)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try
                    Dim query As StringBuilder = New StringBuilder()
                    Dim cmd As SqlCommand = New SqlCommand("sp_ReporteCompras", oconexion)
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio)
                    cmd.Parameters.AddWithValue("fechafin", fechafin)
                    cmd.Parameters.AddWithValue("idproveedor", idproveedor)
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            lista.Add(New ReporteCompra() With {
    .FechaRegistro = dr("FechaRegistro").ToString(),
    .TipoDocumento = dr("TipoDocumento").ToString(),
    .NumeroDocumento = dr("NumeroDocumento").ToString(),
    .MontoTotal = dr("MontoTotal").ToString(),
    .UsuarioRegistro = dr("UsuarioRegistro").ToString(),
    .DocumentoProveedor = dr("DocumentoProveedor").ToString(),
    .RazonSocial = dr("RazonSocial").ToString(),
    .CodigoProducto = dr("CodigoProducto").ToString(),
    .NombreProducto = dr("NombreProducto").ToString(),
    .Categoria = dr("Categoria").ToString(),
    .PrecioCompra = dr("PrecioCompra").ToString(),
    .PrecioVenta = dr("PrecioVenta").ToString(),
    .Cantidad = dr("Cantidad").ToString(),
    .SubTotal = dr("SubTotal").ToString()
})
                        End While
                    End Using
                Catch ex As Exception

                    lista = New List(Of ReporteCompra)()
                End Try
            End Using

            Return lista

        End Function

        Public Function Venta(ByVal fechainicio As String, ByVal fechafin As String) As List(Of ReporteVenta)
            Dim lista As List(Of ReporteVenta) = New List(Of ReporteVenta)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try
                    Dim query As StringBuilder = New StringBuilder()
                    Dim cmd As SqlCommand = New SqlCommand("sp_ReporteVentas", oconexion)
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio)
                    cmd.Parameters.AddWithValue("fechafin", fechafin)
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lista.Add(New ReporteVenta() With {
    .FechaRegistro = dr(CStr("FechaRegistro")).ToString(),
    .TipoDocumento = dr(CStr("TipoDocumento")).ToString(),
    .NumeroDocumento = dr(CStr("NumeroDocumento")).ToString(),
    .MontoTotal = dr(CStr("MontoTotal")).ToString(),
    .UsuarioRegistro = dr(CStr("UsuarioRegistro")).ToString(),
    .DocumentoCliente = dr(CStr("DocumentoCliente")).ToString(),
    .NombreCliente = dr(CStr("NombreCliente")).ToString(),
    .CodigoProducto = dr(CStr("CodigoProducto")).ToString(),
    .NombreProducto = dr(CStr("NombreProducto")).ToString(),
    .Categoria = dr(CStr("Categoria")).ToString(),
    .PrecioVenta = dr(CStr("PrecioVenta")).ToString(),
    .Cantidad = dr(CStr("Cantidad")).ToString(),
    .SubTotal = dr(CStr("SubTotal")).ToString()
})
                        End While
                    End Using
                Catch ex As Exception
                    lista = New List(Of ReporteVenta)()
                End Try
            End Using

            Return lista

        End Function

    End Class
End Namespace
