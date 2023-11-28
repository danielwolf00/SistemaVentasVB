Imports System
Imports System.Collections.Generic
Imports System.Text
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Producto
        Public Function Listar() As List(Of Producto)
            Dim lista As List(Of Producto) = New List(Of Producto)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select IdProducto, Codigo, Nombre, p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioCompra,PrecioVenta,p.Estado  from PRODUCTO p")
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria")
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lista.Add(New Producto() With {
    .IdProducto = Convert.ToInt32(dr("IdProducto")),
    .Codigo = dr("Codigo").ToString(),
    .Nombre = dr("Nombre").ToString(),
    .Descripcion = dr("Descripcion").ToString(),
    .oCategoria = New Categoria() With {
        .IdCategoria = Convert.ToInt32(dr("IdCategoria")),
        .Descripcion = dr("DescripcionCategoria").ToString()
    },
    .Stock = Convert.ToInt32(dr("Stock").ToString()),
    .PrecioCompra = Convert.ToDecimal(dr("PrecioCompra").ToString()),
    .PrecioVenta = Convert.ToDecimal(dr("PrecioVenta").ToString()),
    .Estado = Convert.ToBoolean(dr("Estado"))
})

                        End While

                    End Using
                Catch ex As Exception

                    lista = New List(Of Producto)()
                End Try
            End Using

            Return lista

        End Function




        Public Function Registrar(ByVal obj As Producto, <Out> ByRef Mensaje As String) As Integer
            Dim idProductogenerado = 0
            Mensaje = String.Empty


            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("sp_RegistrarProducto", oconexion)
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo)
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre)
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion)
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    idProductogenerado = Convert.ToInt32(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()

                End Using
            Catch ex As Exception
                idProductogenerado = 0
                Mensaje = ex.Message
            End Try



            Return idProductogenerado
        End Function



        Public Function Editar(ByVal obj As Producto, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty


            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("sp_ModificarProducto", oconexion)
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto)
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo)
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre)
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion)
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    respuesta = Convert.ToBoolean(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()

                End Using
            Catch ex As Exception
                respuesta = False
                Mensaje = ex.Message
            End Try



            Return respuesta
        End Function


        Public Function Eliminar(ByVal obj As Producto, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty

            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("SP_EliminarProducto", oconexion)
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto)
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    respuesta = Convert.ToBoolean(cmd.Parameters("Respuesta").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()

                End Using
            Catch ex As Exception
                respuesta = False
                Mensaje = ex.Message
            End Try

            Return respuesta
        End Function
    End Class
End Namespace
