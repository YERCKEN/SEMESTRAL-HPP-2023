<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnInventario = New System.Windows.Forms.Button()
        SuspendLayout()
        ' 
        ' BtnInventario
        ' 
        BtnInventario.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnInventario.Cursor = Cursors.Hand
        BtnInventario.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnInventario.FlatAppearance.BorderSize = 0
        BtnInventario.FlatStyle = FlatStyle.Flat
        BtnInventario.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnInventario.ForeColor = Color.White
        BtnInventario.Location = New System.Drawing.Point(303, 66)
        BtnInventario.Name = "BtnInventario"
        BtnInventario.Size = New Size(311, 68)
        BtnInventario.TabIndex = 48
        BtnInventario.Text = "Generar Inventario.xlsx"
        BtnInventario.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(899, 466)
        Controls.Add(BtnInventario)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "GENERAR INFORMES"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnInventario As System.Windows.Forms.Button
End Class
