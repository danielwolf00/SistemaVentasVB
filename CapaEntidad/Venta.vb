Imports System.Collections.Generic

Namespace CapaEntidad
    Public Class Venta
        Public Property IdVenta As Integer
        Public Property oUsuario As Usuario
        Public Property TipoDocumento As String
        Public Property NumeroDocumento As String
        Public Property DocumentoCliente As String
        Public Property NombreCliente As String
        Public Property MontoPago As Decimal
        Public Property MontoCambio As Decimal
        Public Property MontoTotal As Decimal
        Public Property oDetalle_Venta As List(Of Detalle_Venta)
        Public Property FechaRegistro As String
    End Class
End Namespace
