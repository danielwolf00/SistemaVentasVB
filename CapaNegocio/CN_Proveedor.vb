Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Proveedor
        Private objcd_Proveedor As CapaDatos.CD_Proveedor = New CapaDatos.CD_Proveedor()


        Public Function Listar() As List(Of Proveedor)
            Return objcd_Proveedor.Listar()
        End Function

        Public Function Registrar(ByVal obj As Proveedor, <Out> ByRef Mensaje As String) As Integer
            Mensaje = String.Empty

            If Equals(obj.Documento, "") Then
                Mensaje += "Es necesario el documento del Proveedor" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.RazonSocial, "") Then
                Mensaje += "Es necesario la razon social del Proveedor" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Correo, "") Then
                Mensaje += "Es necesario la correo del Proveedor" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return 0
            Else
                Return objcd_Proveedor.Registrar(obj, Mensaje)
            End If


        End Function


        Public Function Editar(ByVal obj As Proveedor, <Out> ByRef Mensaje As String) As Boolean

            Mensaje = String.Empty

            If Equals(obj.Documento, "") Then
                Mensaje += "Es necesario el documento del Proveedor" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.RazonSocial, "") Then
                Mensaje += "Es necesario la razon social del Proveedor" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Correo, "") Then
                Mensaje += "Es necesario la correo del Proveedor" & Microsoft.VisualBasic.Constants.vbLf
            End If



            If Not Equals(Mensaje, String.Empty) Then
                Return False
            Else
                Return objcd_Proveedor.Editar(obj, Mensaje)
            End If


        End Function


        Public Function Eliminar(ByVal obj As Proveedor, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_Proveedor.Eliminar(obj, Mensaje)
        End Function

    End Class
End Namespace
