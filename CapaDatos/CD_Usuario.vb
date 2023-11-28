Imports System
Imports System.Collections.Generic
Imports System.Text

Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Usuario


        Public Function Listar() As List(Of Usuario)
            Dim lista As List(Of Usuario) = New List(Of Usuario)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion from USUARIO u")
                    query.AppendLine(" inner join ROL r on r.IdRol = u.IdRol")
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text
                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lista.Add(New Usuario() With {
    .IdUsuario = Convert.ToInt32(dr("IdUsuario")),
    .Documento = dr("Documento").ToString(),
    .NombreCompleto = dr("NombreCompleto").ToString(),
    .Correo = dr("Correo").ToString(),
    .Clave = dr("Clave").ToString(),
    .Estado = Convert.ToBoolean(dr("Estado")),
    .oRol = New Rol() With {
        .IdRol = Convert.ToInt32(dr("IdRol")),
        .Descripcion = dr("Descripcion").ToString()
    }
    })
                        End While
                    End Using
                Catch ex As Exception
                    lista = New List(Of Usuario)()
                End Try
            End Using
            Return lista
        End Function

        Public Function Registrar(ByVal obj As Usuario, <Out> ByRef Mensaje As String) As Integer
            Dim idusuariogenerado = 0
            Mensaje = String.Empty


            Try
                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                    Dim cmd As SqlCommand = New SqlCommand("SP_REGISTRARUSUARIO", oconexion)
                    cmd.Parameters.AddWithValue("Documento", obj.Documento)
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto)
                    cmd.Parameters.AddWithValue("Correo", obj.Correo)
                    cmd.Parameters.AddWithValue("Clave", obj.Clave)
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters("IdUsuarioResultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()
                End Using
            Catch ex As Exception
                idusuariogenerado = 0
                Mensaje = ex.Message
            End Try
            Return idusuariogenerado
        End Function
        Public Function Editar(ByVal obj As Usuario, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty


            Try
                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                    Dim cmd As SqlCommand = New SqlCommand("SP_EDITARUSUARIO", oconexion)
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario)
                    cmd.Parameters.AddWithValue("Documento", obj.Documento)
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto)
                    cmd.Parameters.AddWithValue("Correo", obj.Correo)
                    cmd.Parameters.AddWithValue("Clave", obj.Clave)
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
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
        Public Function Eliminar(ByVal obj As Usuario, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty


            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                    Dim cmd As SqlCommand = New SqlCommand("SP_ELIMINARUSUARIO", oconexion)
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario)
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
