<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LabelActividad = New Label()
        SuspendLayout()
        ' 
        ' LabelActividad
        ' 
        LabelActividad.AutoSize = True
        LabelActividad.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        LabelActividad.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelActividad.ForeColor = Color.White
        LabelActividad.Location = New Point(1104, 63)
        LabelActividad.Name = "LabelActividad"
        LabelActividad.Padding = New Padding(10, 5, 50, 5)
        LabelActividad.Size = New Size(182, 45)
        LabelActividad.TabIndex = 65
        LabelActividad.Text = "Clientes"
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 572)
        Controls.Add(LabelActividad)
        FormBorderStyle = FormBorderStyle.None
        Name = "Clientes"
        Text = "Clientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelActividad As Label
End Class
