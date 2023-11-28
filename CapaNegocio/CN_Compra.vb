Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Compra
        Private objcd_compra As CapaDatos.CD_Compra = New CapaDatos.CD_Compra()


        Public Function ObtenerCorrelativo() As Integer
            Return objcd_compra.ObtenerCorrelativo()
        End Function

        Public Function Registrar(ByVal obj As Compra, ByVal DetalleCompra As DataTable, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_compra.Registrar(obj, DetalleCompra, Mensaje)
        End Function

        Public Function ObtenerCompra(ByVal numero As String) As Compra

            Dim oCompra As Compra = objcd_compra.ObtenerCompra(numero)

            If oCompra.IdCompra <> 0 Then
                Dim oDetalleCompra As List(Of Detalle_Compra) = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra)

                oCompra.oDetalleCompra = oDetalleCompra
            End If
            Return oCompra
        End Function


    End Class
End Namespace
