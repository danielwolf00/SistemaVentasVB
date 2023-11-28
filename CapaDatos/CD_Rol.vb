Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidad

Namespace CapaDatos
    Public Class CD_Rol
        Public Function Listar() As List(Of Rol)
            Dim lista As List(Of Rol) = New List(Of Rol)()

            Using oconexion As SqlConnection = New SqlConnection(Conexion.cadena)
                Try
                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("select IdRol,Descripcion from ROL")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), oconexion)
                    cmd.CommandType = CommandType.Text

                    oconexion.Open()

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lista.Add(New Rol() With {
    .IdRol = Convert.ToInt32(dr("IdRol")),
    .Descripcion = dr("Descripcion").ToString()
})
                        End While
                    End Using
                Catch ex As Exception
                    lista = New List(Of Rol)()
                End Try
            End Using
            Return lista
        End Function
    End Class
End Namespace
