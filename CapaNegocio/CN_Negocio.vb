Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Negocio
        Private objcd_negocio As CapaDatos.CD_Negocio = New CapaDatos.CD_Negocio()


        Public Function ObtenerDatos() As Negocio
            Return objcd_negocio.ObtenerDatos()
        End Function

        Public Function GuardarDatos(ByVal obj As Negocio, <Out> ByRef Mensaje As String) As Boolean
            Mensaje = String.Empty

            If Equals(obj.Nombre, "") Then
                Mensaje += "Es necesario el nombre" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.RUC, "") Then
                Mensaje += "Es necesario el numero de RUC" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Direccion, "") Then
                Mensaje += "Es necesario la direccion" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return False
            Else
                Return objcd_negocio.GuardarDatos(obj, Mensaje)
            End If


        End Function

        Public Function ObtenerLogo(<Out> ByRef obtenido As Boolean) As Byte()
            Return objcd_negocio.ObtenerLogo(obtenido)
        End Function


        Public Function ActualizarLogo(ByVal imagen As Byte(), <Out> ByRef mensaje As String) As Boolean
            Return objcd_negocio.ActualizarLogo(imagen, mensaje)
        End Function

    End Class
End Namespace
