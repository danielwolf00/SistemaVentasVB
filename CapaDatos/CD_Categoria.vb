Imports System
Imports System.Collections.Generic
Imports System.Text
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Categoria
        Public Function Listar() As List(Of Categoria)
            Dim lista As List(Of Categoria) = New List(Of Categoria)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try

                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select IdCategoria,Descripcion,Estado from CATEGORIA")
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            lista.Add(New Categoria() With {
    .IdCategoria = Convert.ToInt32(dr("IdCategoria")),
    .Descripcion = dr("Descripcion").ToString(),
    .Estado = Convert.ToBoolean(dr("Estado"))
})
                        End While
                    End Using
                Catch ex As Exception

                    lista = New List(Of Categoria)()
                End Try
            End Using

            Return lista

        End Function




        Public Function Registrar(ByVal obj As Categoria, <Out> ByRef Mensaje As String) As Integer
            Dim idCategoriagenerado = 0
            Mensaje = String.Empty

            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("SP_RegistrarCategoria", oconexion)
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    idCategoriagenerado = Convert.ToInt32(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()

                End Using
            Catch ex As Exception
                idCategoriagenerado = 0
                Mensaje = ex.Message
            End Try

            Return idCategoriagenerado
        End Function



        Public Function Editar(ByVal obj As Categoria, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty


            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("sp_EditarCategoria", oconexion)
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria)
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion)
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


        Public Function Eliminar(ByVal obj As Categoria, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty
            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                    Dim cmd As SqlCommand = New SqlCommand("sp_EliminarCategoria", oconexion)
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria)
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
    End Class
End Namespace
