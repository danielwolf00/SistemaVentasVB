Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Usuario
        Private objcd_usuario As CapaDatos.CD_Usuario = New CapaDatos.CD_Usuario()
        Public Function Listar() As List(Of Usuario)
            Return objcd_usuario.Listar()
        End Function
        Public Function Registrar(ByVal obj As Usuario, <Out> ByRef Mensaje As String) As Integer
            Mensaje = String.Empty

            If Equals(obj.Documento, "") Then
                Mensaje += "Es necesario el documento del usuario" & Microsoft.VisualBasic.Constants.vbLf
            End If
            If Equals(obj.NombreCompleto, "") Then
                Mensaje += "Es necesario el nombre completo del usuario" & Microsoft.VisualBasic.Constants.vbLf
            End If
            If Equals(obj.Clave, "") Then
                Mensaje += "Es necesario la clave del usuario" & Microsoft.VisualBasic.Constants.vbLf
            End If
            If Not Equals(Mensaje, String.Empty) Then
                Return 0
            Else
                Return objcd_usuario.Registrar(obj, Mensaje)
            End If
        End Function
        Public Function Editar(ByVal obj As Usuario, <Out> ByRef Mensaje As String) As Boolean
            Mensaje = String.Empty

            If Equals(obj.Documento, "") Then
                Mensaje += "Es necesario el documento del usuario" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.NombreCompleto, "") Then
                Mensaje += "Es necesario el nombre completo del usuario" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Clave, "") Then
                Mensaje += "Es necesario la clave del usuario" & Microsoft.VisualBasic.Constants.vbLf
            End If


            If Not Equals(Mensaje, String.Empty) Then
                Return False
            Else
                Return objcd_usuario.Editar(obj, Mensaje)
            End If
        End Function
        Public Function Eliminar(ByVal obj As Usuario, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_usuario.Eliminar(obj, Mensaje)
        End Function
    End Class
End Namespace
