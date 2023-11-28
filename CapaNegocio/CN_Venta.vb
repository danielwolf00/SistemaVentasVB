Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad
Imports System.Runtime.InteropServices

Namespace CapaNegocio
    Public Class CN_Venta
        Private objcd_venta As CapaDatos.CD_Venta = New CapaDatos.CD_Venta()

        Public Function RestarStock(ByVal idproducto As Integer, ByVal cantidad As Integer) As Boolean
            Return objcd_venta.RestarStock(idproducto, cantidad)
        End Function

        Public Function SumarStock(ByVal idproducto As Integer, ByVal cantidad As Integer) As Boolean
            Return objcd_venta.SumarStock(idproducto, cantidad)
        End Function

        Public Function ObtenerCorrelativo() As Integer
            Return objcd_venta.ObtenerCorrelativo()
        End Function

        Public Function Registrar(ByVal obj As Venta, ByVal DetalleVenta As DataTable, <Out> ByRef Mensaje As String) As Boolean
            Return objcd_venta.Registrar(obj, DetalleVenta, Mensaje)
        End Function

        Public Function ObtenerVenta(ByVal numero As String) As Venta
            Dim oVenta As Venta = objcd_venta.ObtenerVenta(numero)

            If oVenta.IdVenta <> 0 Then
                Dim oDetalleVenta As List(Of Detalle_Venta) = objcd_venta.ObtenerDetalleVenta(oVenta.IdVenta)
                oVenta.oDetalle_Venta = oDetalleVenta
            End If

            Return oVenta
        End Function

    End Class
End Namespace
