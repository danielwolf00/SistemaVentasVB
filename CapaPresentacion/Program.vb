Imports System
Imports System.Windows.Forms

Namespace CapaPresentacion
    Friend Module Program
        ''' <summary>
        ''' Punto de entrada principal para la aplicación.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Inicio())
        End Sub
    End Module
End Namespace
