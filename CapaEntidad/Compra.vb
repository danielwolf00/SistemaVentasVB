Imports System.Collections.Generic

Namespace CapaEntidad
    Public Class Compra
        Public Property IdCompra As Integer
        Public Property oUsuario As Usuario
        Public Property oProveedor As Proveedor
        Public Property TipoDocumento As String
        Public Property NumeroDocumento As String
        Public Property MontoTotal As Decimal
        Public Property oDetalleCompra As List(Of Detalle_Compra)
        Public Property FechaRegistro As String
    End Class
End Namespace
