Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Clientes
        Private objcd_Cliente As CD_Cliente = New CD_Cliente()


        Public Function Listar() As List(Of Cliente)
            Return objcd_Cliente.Listar()
        End Function

        Public Function Registrar(ByVal obj As Cliente, <Out> ByRef Mensaje As String) As Integer
            Mensaje = String.Empty

            If Equals(obj.Documento, "") Then
                Mensaje += "Es necesario el documento del Cliente" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.NombreCompleto, "") Then
                Mensaje += "Es necesario el nombre completo del Cliente" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Correo, "") Then
                Mensaje += "Es necesario el correo del Cliente" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return 0
            Else
                Return objcd_Cliente.Registrar(obj, Mensaje)
            End If


        End Function


        Public Function Editar(ByVal obj As Cliente, <Out> ByRef Mensaje As String) As Boolean

            Mensaje = String.Empty

            If Equals(obj.Documento, "") Then
                Mensaje += "Es necesario el documento del Cliente" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.NombreCompleto, "") Then
                Mensaje += "Es necesario el nombre completo del Cliente" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Correo, "") Then
                Mensaje += "Es necesario el correo del Cliente" & Microsoft.VisualBasic.Constants.vbLf
            End If
            If Not Equals(Mensaje, String.Empty) Then
                Return False
            Else
                Return objcd_Cliente.Editar(obj, Mensaje)
            End If


        End Function


        Public Function Eliminar(ByVal obj As Cliente, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_Cliente.Eliminar(obj, Mensaje)
        End Function
    End Class
End Namespace
