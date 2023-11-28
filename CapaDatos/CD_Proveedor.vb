Imports System
Imports System.Collections.Generic
Imports System.Text
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Proveedor
        Public Function Listar() As List(Of Proveedor)
            Dim lista As List(Of Proveedor) = New List(Of Proveedor)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select IdProveedor,Documento,RazonSocial,Correo,Telefono,Estado from PROVEEDOR")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            lista.Add(New Proveedor() With {
    .IdProveedor = Convert.ToInt32(dr("IdProveedor")),
    .Documento = dr("Documento").ToString(),
    .RazonSocial = dr("RazonSocial").ToString(),
    .Correo = dr("Correo").ToString(),
    .Telefono = dr("Telefono").ToString(),
    .Estado = Convert.ToBoolean(dr("Estado"))
})

                        End While

                    End Using
                Catch ex As Exception

                    lista = New List(Of Proveedor)()
                End Try
            End Using

            Return lista

        End Function




        Public Function Registrar(ByVal obj As Proveedor, <Out> ByRef Mensaje As String) As Integer
            Dim idProveedorgenerado = 0
            Mensaje = String.Empty
            Try
                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                    Dim cmd As SqlCommand = New SqlCommand("sp_RegistrarProveedor", oconexion)
                    cmd.Parameters.AddWithValue("Documento", obj.Documento)
                    cmd.Parameters.AddWithValue("RazonSocial", obj.RazonSocial)
                    cmd.Parameters.AddWithValue("Correo", obj.Correo)
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono)
                    cmd.Parameters.AddWithValue("Estado", obj.Estado)
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                    cmd.CommandType = CommandType.StoredProcedure

                    oconexion.Open()

                    cmd.ExecuteNonQuery()

                    idProveedorgenerado = Convert.ToInt32(cmd.Parameters("Resultado").Value)
                    Mensaje = cmd.Parameters("Mensaje").Value.ToString()

                End Using
            Catch ex As Exception
                idProveedorgenerado = 0
                Mensaje = ex.Message
            End Try



            Return idProveedorgenerado
        End Function



        Public Function Editar(ByVal obj As Proveedor, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty
            Try
                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)

                    Dim cmd As SqlCommand = New SqlCommand("sp_ModificarProveedor", oconexion)
                    cmd.Parameters.AddWithValue("IdProveedor", obj.IdProveedor)
                    cmd.Parameters.AddWithValue("Documento", obj.Documento)
                    cmd.Parameters.AddWithValue("RazonSocial", obj.RazonSocial)
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


        Public Function Eliminar(ByVal obj As Proveedor, <Out> ByRef Mensaje As String) As Boolean
            Dim respuesta = False
            Mensaje = String.Empty


            Try

                Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)


                    Dim cmd As SqlCommand = New SqlCommand("sp_EliminarProveedor", oconexion)
                    cmd.Parameters.AddWithValue("IdProveedor", obj.IdProveedor)
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
