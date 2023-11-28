Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Categoria
        Private objcd_Categoria As CapaDatos.CD_Categoria = New CapaDatos.CD_Categoria()

        Public Function Listar() As List(Of Categoria)
            Return objcd_Categoria.Listar()
        End Function

        Public Function Registrar(ByVal obj As Categoria, <Out> ByRef Mensaje As String) As Integer
            Mensaje = String.Empty


            If Equals(obj.Descripcion, "") Then
                Mensaje += "Es necesario la descripcion de la Categoria" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return 0
            Else
                Return objcd_Categoria.Registrar(obj, Mensaje)
            End If


        End Function


        Public Function Editar(ByVal obj As Categoria, <Out> ByRef Mensaje As String) As Boolean

            Mensaje = String.Empty

            If Equals(obj.Descripcion, "") Then
                Mensaje += "Es necesario la descripcion de la Categoria" & Microsoft.VisualBasic.Constants.vbLf
            End If

            If Not Equals(Mensaje, String.Empty) Then
                Return False
            Else
                Return objcd_Categoria.Editar(obj, Mensaje)
            End If


        End Function


        Public Function Eliminar(ByVal obj As Categoria, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_Categoria.Eliminar(obj, Mensaje)
        End Function
    End Class
End Namespace
