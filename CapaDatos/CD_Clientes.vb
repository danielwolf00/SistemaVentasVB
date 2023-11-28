Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Clientes
        Public Function Listar() As List(Of Cliente)
            Dim lista As List(Of Cliente) = New List(Of Cliente)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try

                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select IdCliente,Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE")
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text
                    oconexion.Open()
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lista.Add(New Cliente() With {
    .IdCliente = Convert.ToInt32(dr("IdCliente")),
    .Documento = dr("Documento").ToString(),
    .NombreCompleto = dr("NombreCompleto").ToString(),
    .Correo = dr("Correo").ToString(),
    .Telefono = dr("Telefono").ToString(),
    .Estado = Convert.ToBoolean(dr("Estado"))
})

                        End While

                    End Using
                Catch ex As Exception

                    lista = New List(Of Cliente)()
                End Try
            End Using

            Return lista

        End Function




        Public Function Registrar(ByVal obj As Cliente, <Out> ByRef Mensaje As String) As Integer
            Dim idClientegenerado = 0
            Mensaje = String.Empty
            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("sp_RegistrarCliente", oconexion)
                    cmd.Parameters.AddWithValue("Documento", obj.Documento)
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto)
                    cmd.Parameters.AddWithValue("Correo", obj.Correo)
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    idClientegenerado = Convert.ToInt32(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()

                End Using
            Catch ex As Exception
                idClientegenerado = 0
                Mensaje = ex.Message
            End Try



            Return idClientegenerado
        End Function



        Public Function Editar(ByVal obj As Cliente, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty


            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("sp_ModificarCliente", oconexion)
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente)
                    cmd.Parameters.AddWithValue("Documento", obj.Documento)
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto)
                    cmd.Parameters.AddWithValue("Correo", obj.Correo)
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono)
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


        Public Function Eliminar(ByVal obj As Cliente, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty
            Try
                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("delete from cliente where IdCliente = @id", oconexion)
                    cmd.Parameters.AddWithValue("@id", obj.IdCliente)
                    cmd.CommandType = CommandType.Text
                    oconexion.Open()
                    respuesta = If(cmd.ExecuteNonQuery() > 0, True, False)
                End Using
            Catch ex As Exception
                respuesta = False
                Mensaje = ex.Message
            End Try

            Return respuesta
        End Function
    End Class
End Namespace
