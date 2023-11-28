Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidad

Namespace CapaDatos
    Public Class CD_Permiso
        Public Function Listar(ByVal IdUsuario As Integer) As List(Of Permiso)
            Dim lista As List(Of Permiso) = New List(Of Permiso)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try


                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("Select p.IdRol, p.NombreMenu from PERMISO p")
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol")
                    query.AppendLine("inner join USUARIO u ON u.IdRol = r.IdRol")
                    query.AppendLine("where u.IdUsuario = @IdUsuario")







                    'string query = "Select IdRol, NombreMenu from PERMISO";
                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario)
                    cmd.CommandType = CommandType.Text
                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lista.Add(New Permiso() With {
    .oRol = New Rol() With {
        .IdRol = Convert.ToInt32(dr("IdRol"))
    },
    .NombreMenu = dr("NombreMenu").ToString()
})

                        End While

                    End Using
                Catch ex As Exception
                    lista = New List(Of Permiso)()
                End Try
            End Using
            Return lista
        End Function

    End Class
End Namespace
