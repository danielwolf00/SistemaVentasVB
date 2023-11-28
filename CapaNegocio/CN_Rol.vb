Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad

Namespace CapaNegocio
    Public Class CN_Rol
        Private objcd_rol As CapaDatos.CD_Rol = New CapaDatos.CD_Rol()


        Public Function Listar() As List(Of Rol)
            Return objcd_rol.Listar()
        End Function
    End Class
End Namespace
