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
        BtnGenerarInforme = New System.Windows.Forms.Button()
        ListaProvedores = New ComboBox()
        SuspendLayout()
        ' 
        ' BtnGenerarInforme
        ' 
        BtnGenerarInforme.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnGenerarInforme.Cursor = Cursors.Hand
        BtnGenerarInforme.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnGenerarInforme.FlatAppearance.BorderSize = 0
        BtnGenerarInforme.FlatStyle = FlatStyle.Flat
        BtnGenerarInforme.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnGenerarInforme.ForeColor = Color.White
        BtnGenerarInforme.Location = New System.Drawing.Point(381, 281)
        BtnGenerarInforme.Name = "BtnGenerarInforme"
        BtnGenerarInforme.Size = New Size(388, 68)
        BtnGenerarInforme.TabIndex = 52
        BtnGenerarInforme.Text = "Generar Informe.xlsx"
        BtnGenerarInforme.UseVisualStyleBackColor = False
        ' 
        ' ListaProvedores
        ' 
        ListaProvedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaProvedores.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaProvedores.FormattingEnabled = True
        ListaProvedores.Location = New System.Drawing.Point(381, 181)
        ListaProvedores.Name = "ListaProvedores"
        ListaProvedores.Size = New Size(388, 33)
        ListaProvedores.TabIndex = 53
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.FONDO_EXECL
        ClientSize = New Size(1163, 525)
        Controls.Add(ListaProvedores)
        Controls.Add(BtnGenerarInforme)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GENERAR INFORMES"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BtnGenerarInforme As System.Windows.Forms.Button
    Friend WithEvents ListaProvedores As ComboBox
End Class
