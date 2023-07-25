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
        BtnProvedores = New System.Windows.Forms.Button()
        BtnServicios = New System.Windows.Forms.Button()
        BtnClientes = New System.Windows.Forms.Button()
        BtnCarrerras = New System.Windows.Forms.Button()
        BtnInventario = New System.Windows.Forms.Button()
        SuspendLayout()
        ' 
        ' BtnProvedores
        ' 
        BtnProvedores.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnProvedores.Cursor = Cursors.Hand
        BtnProvedores.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnProvedores.FlatAppearance.BorderSize = 0
        BtnProvedores.FlatStyle = FlatStyle.Flat
        BtnProvedores.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnProvedores.ForeColor = Color.White
        BtnProvedores.Location = New System.Drawing.Point(116, 113)
        BtnProvedores.Name = "BtnProvedores"
        BtnProvedores.Size = New Size(311, 68)
        BtnProvedores.TabIndex = 48
        BtnProvedores.Text = "Provedores .xlsx"
        BtnProvedores.UseVisualStyleBackColor = False
        ' 
        ' BtnServicios
        ' 
        BtnServicios.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnServicios.Cursor = Cursors.Hand
        BtnServicios.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnServicios.FlatAppearance.BorderSize = 0
        BtnServicios.FlatStyle = FlatStyle.Flat
        BtnServicios.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnServicios.ForeColor = Color.White
        BtnServicios.Location = New System.Drawing.Point(116, 207)
        BtnServicios.Name = "BtnServicios"
        BtnServicios.Size = New Size(311, 68)
        BtnServicios.TabIndex = 49
        BtnServicios.Text = "Servicios .xlsx"
        BtnServicios.UseVisualStyleBackColor = False
        ' 
        ' BtnClientes
        ' 
        BtnClientes.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnClientes.Cursor = Cursors.Hand
        BtnClientes.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnClientes.FlatAppearance.BorderSize = 0
        BtnClientes.FlatStyle = FlatStyle.Flat
        BtnClientes.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClientes.ForeColor = Color.White
        BtnClientes.Location = New System.Drawing.Point(450, 113)
        BtnClientes.Name = "BtnClientes"
        BtnClientes.Size = New Size(311, 68)
        BtnClientes.TabIndex = 50
        BtnClientes.Text = "Clientes .xlsx"
        BtnClientes.UseVisualStyleBackColor = False
        ' 
        ' BtnCarrerras
        ' 
        BtnCarrerras.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnCarrerras.Cursor = Cursors.Hand
        BtnCarrerras.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnCarrerras.FlatAppearance.BorderSize = 0
        BtnCarrerras.FlatStyle = FlatStyle.Flat
        BtnCarrerras.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCarrerras.ForeColor = Color.White
        BtnCarrerras.Location = New System.Drawing.Point(450, 207)
        BtnCarrerras.Name = "BtnCarrerras"
        BtnCarrerras.Size = New Size(311, 68)
        BtnCarrerras.TabIndex = 51
        BtnCarrerras.Text = "Carreras .xlsx"
        BtnCarrerras.UseVisualStyleBackColor = False
        ' 
        ' BtnInventario
        ' 
        BtnInventario.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnInventario.Cursor = Cursors.Hand
        BtnInventario.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnInventario.FlatAppearance.BorderSize = 0
        BtnInventario.FlatStyle = FlatStyle.Flat
        BtnInventario.Font = New System.Drawing.Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnInventario.ForeColor = Color.White
        BtnInventario.Location = New System.Drawing.Point(116, 325)
        BtnInventario.Name = "BtnInventario"
        BtnInventario.Size = New Size(645, 68)
        BtnInventario.TabIndex = 52
        BtnInventario.Text = "Inventario .xlsx"
        BtnInventario.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(899, 466)
        Controls.Add(BtnInventario)
        Controls.Add(BtnCarrerras)
        Controls.Add(BtnClientes)
        Controls.Add(BtnServicios)
        Controls.Add(BtnProvedores)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "GENERAR INFORMES"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnProvedores As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents BtnServicios As System.Windows.Forms.Button
    Friend WithEvents BtnCarrerras As System.Windows.Forms.Button
    Friend WithEvents BtnInventario As System.Windows.Forms.Button
End Class
