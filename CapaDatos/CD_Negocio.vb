Imports System
Imports System.Text
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices

Namespace CapaDatos
    Public Class CD_Negocio
        Public Function ObtenerDatos() As Negocio

            Dim obj As Negocio = New Negocio()

            Try

                Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                    conexion.Open()

                    Dim query = "select IdNegocio, Nombre, RUC, Direccion from NEGOCIO where IdNegocio = 1"
                    Dim cmd As SqlCommand = New SqlCommand(query, conexion)
                    cmd.CommandType = CommandType.Text

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            obj = New Negocio() With {
    .IdNegocio = Integer.Parse(dr("IdNegocio").ToString()),
    .Nombre = dr("Nombre").ToString(),
    .RUC = dr("RUC").ToString(),
    .Direccion = dr("Direccion").ToString()
}
                        End While
                    End Using

                End Using

            Catch
                obj = New Negocio()
            End Try



            Return obj
        End Function

        Public Function GuardarDatos(ByVal objeto As Negocio, <Out> ByRef mensaje As String) As Boolean

            mensaje = String.Empty
            Dim respuesta = True

            Try

                Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                    conexion.Open()


                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("update NEGOCIO set Nombre = @nombre,")
                    query.AppendLine("RUC = @ruc,")
                    query.AppendLine("Direccion = @direccion")
                    query.AppendLine("where IdNegocio = 1;")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), conexion)
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre)
                    cmd.Parameters.AddWithValue("@ruc", objeto.RUC)
                    cmd.Parameters.AddWithValue("@direccion", objeto.Direccion)
                    cmd.CommandType = CommandType.Text

                    If cmd.ExecuteNonQuery() < 1 Then
                        mensaje = "No se pudo guardar los datos"
                        respuesta = False
                    End If

                End Using
            Catch ex As Exception
                mensaje = ex.Message
                respuesta = False
            End Try

            Return respuesta

        End Function


        Public Function ObtenerLogo(<Out> ByRef obtenido As Boolean) As Byte()
            obtenido = True
            Dim LogoBytes = New Byte(-1) {}
            Try
                Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                    conexion.Open()
                    Dim query = "select Logo from NEGOCIO where IdNegocio = 1"
                    Dim cmd As SqlCommand = New SqlCommand(query, conexion)
                    cmd.CommandType = CommandType.Text

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            LogoBytes = CType(dr("Logo"), Byte())
                        End While
                    End Using

                End Using
            Catch ex As Exception
                obtenido = False
                LogoBytes = New Byte(-1) {}
            End Try

            Return LogoBytes
        End Function

        Public Function ActualizarLogo(ByVal image As Byte(), <Out> ByRef mensaje As String) As Boolean
            mensaje = String.Empty
            Dim respuesta = True

            Try

                Using conexion As SqlConnection = New SqlConnection(CapaDatos.Conexion.cadena)
                    conexion.Open()


                    Dim query As StringBuilder = New StringBuilder()
                    query.AppendLine("update NEGOCIO set Logo = @imagen")
                    query.AppendLine("where IdNegocio = 1;")

                    Dim cmd As SqlCommand = New SqlCommand(query.ToString(), conexion)
                    cmd.Parameters.AddWithValue("@imagen", image)
                    cmd.CommandType = CommandType.Text

                    If cmd.ExecuteNonQuery() < 1 Then
                        mensaje = "No se pudo actualizar el logo"
                        respuesta = False
                    End If

                End Using
            Catch ex As Exception
                mensaje = ex.Message
                respuesta = False
            End Try

            Return respuesta

        End Function

    End Class
End Namespace
