Imports System.Configuration

Namespace CapaDatos
    Public Class Conexion
        Public Shared cadena As String = ConfigurationManager.ConnectionStrings("cadena_conexion").ToString()
    End Class
End Namespace
