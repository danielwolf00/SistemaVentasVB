
Namespace CapaPresentacion
    Partial Class FrmReportes
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            label1 = New Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 15F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(201, 147)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(167, 25)
            label1.TabIndex = 1
            label1.Text = "Form de Reportes"
            ' 
            ' FrmReportes
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(558, 318)
            Controls.Add(label1)
            Name = "FrmReportes"
            Text = "FrmReportes"
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
    End Class
End Namespace
