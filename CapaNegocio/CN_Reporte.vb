Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad

Namespace CapaNegocio
    Public Class CN_Reporte
        Private objcd_reporte As CapaDatos.CD_Reporte = New CapaDatos.CD_Reporte()

        Public Function Compra(ByVal fechainicio As String, ByVal fechafin As String, ByVal idproveedor As Integer) As List(Of ReporteCompra)
            Return objcd_reporte.Compra(fechainicio, fechafin, idproveedor)
        End Function


        Public Function Venta(ByVal fechainicio As String, ByVal fechafin As String) As List(Of ReporteVenta)
            Return objcd_reporte.Venta(fechainicio, fechafin)
        End Function
    End Class
End Namespace
