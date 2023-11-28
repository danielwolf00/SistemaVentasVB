Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Producto
        Private objcd_Producto As CapaDatos.CD_Producto = New CapaDatos.CD_Producto()


        Public Function Listar() As List(Of Producto)
            Return objcd_Producto.Listar()
        End Function

        Public Function Registrar(ByVal obj As Producto, <Out> ByRef Mensaje As String) As Integer
            Mensaje = String.Empty

            If Equals(obj.Codigo, "") Then
                Mensaje += "Es necesario el codigo del Producto" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Nombre, "") Then
                Mensaje += "Es necesario el nombre del Producto" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Descripcion, "") Then
                Mensaje += "Es necesario la Descripcion del Producto" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return 0
            Else
                Return objcd_Producto.Registrar(obj, Mensaje)
            End If


        End Function


        Public Function Editar(ByVal obj As Producto, <Out> ByRef Mensaje As String) As Boolean

            Mensaje = String.Empty


            If Equals(obj.Codigo, "") Then
                Mensaje += "Es necesario el codigo del Producto" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Nombre, "") Then
                Mensaje += "Es necesario el nombre del Producto" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Equals(obj.Descripcion, "") Then
                Mensaje += "Es necesario la Descripcion del Producto" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return False
            Else
                Return objcd_Producto.Editar(obj, Mensaje)
            End If
        End Function


        Public Function Eliminar(ByVal obj As Producto, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_Producto.Eliminar(obj, Mensaje)
        End Function
    End Class
End Namespace
