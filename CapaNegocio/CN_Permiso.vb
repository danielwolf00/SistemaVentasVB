Imports System.Collections.Generic
Imports CapaDatos
Imports CapaEntidad

Namespace CapaNegocio
    Public Class CN_Permiso
        Private objcd_permiso As CapaDatos.CD_Permiso = New CapaDatos.CD_Permiso()


        Public Function Listar(ByVal IdUsuario As Integer) As List(Of Permiso)
            Return objcd_permiso.Listar(IdUsuario)
        End Function



    End Class
End Namespace
