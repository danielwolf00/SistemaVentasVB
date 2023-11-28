Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports CapaNegocio
Imports CapaEntidad


Namespace CapaPresentacion
    Public Partial Class Login
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub iconButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub iconButton1_Click(ByVal sender As Object, ByVal e As EventArgs)

            Dim Test As List(Of Usuario) = New CapaNegocio.CN_Usuario().Listar()
            Dim ousuario As Usuario = New CapaNegocio.CN_Usuario().Listar().Where(Function(u) Equals(u.Documento, txtdocumento.Text) AndAlso Equals(u.Clave, txtclave.Text)).FirstOrDefault()
            'if (ousuario != null)
            '{
            ' Inicio form = new Inicio();
            ' form.Show();
            ' this.Hide();
            ' form.FormClosing += frm_closing;
            ' }
            'else
            '{
            '   MessageBox.Show("no se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            '  }


            Dim form As Inicio = New Inicio()
            form.Show()
            Hide()
            AddHandler form.FormClosing, AddressOf frm_closing
        End Sub

        Private Sub frm_closing(ByVal sender As Object, ByVal e As FormClosingEventArgs)

            txtdocumento.Text = ""
            txtclave.Text = ""
            Show()
        End Sub
    End Class
End Namespace
