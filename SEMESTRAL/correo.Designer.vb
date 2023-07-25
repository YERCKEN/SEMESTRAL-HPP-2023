<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class correo
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(correo))
        ListaProvedores = New ComboBox()
        TextBoxCuerpo = New TextBox()
        Label5 = New Label()
        TextBoxAsunto = New TextBox()
        Label7 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        btnAdjuntarArchivo = New Button()
        SuspendLayout()
        ' 
        ' ListaProvedores
        ' 
        ListaProvedores.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaProvedores.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaProvedores.FormattingEnabled = True
        ListaProvedores.Location = New Point(521, 86)
        ListaProvedores.Name = "ListaProvedores"
        ListaProvedores.Size = New Size(411, 33)
        ListaProvedores.TabIndex = 50
        ' 
        ' TextBoxCuerpo
        ' 
        TextBoxCuerpo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCuerpo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxCuerpo.Location = New Point(521, 301)
        TextBoxCuerpo.Multiline = True
        TextBoxCuerpo.Name = "TextBoxCuerpo"
        TextBoxCuerpo.Size = New Size(609, 186)
        TextBoxCuerpo.TabIndex = 51
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label5.Location = New Point(521, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 27)
        Label5.TabIndex = 52
        Label5.Text = "Cuerpo"
        ' 
        ' TextBoxAsunto
        ' 
        TextBoxAsunto.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxAsunto.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxAsunto.Location = New Point(521, 190)
        TextBoxAsunto.Name = "TextBoxAsunto"
        TextBoxAsunto.Size = New Size(411, 30)
        TextBoxAsunto.TabIndex = 55
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(521, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 27)
        Label7.TabIndex = 56
        Label7.Text = "Asunto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(521, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 27)
        Label1.TabIndex = 57
        Label1.Text = "Provedor"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(960, 73)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 52)
        Button1.TabIndex = 75
        Button1.Text = "Enviar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAdjuntarArchivo
        ' 
        btnAdjuntarArchivo.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        btnAdjuntarArchivo.Cursor = Cursors.Hand
        btnAdjuntarArchivo.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnAdjuntarArchivo.FlatAppearance.BorderSize = 0
        btnAdjuntarArchivo.FlatStyle = FlatStyle.Flat
        btnAdjuntarArchivo.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdjuntarArchivo.ForeColor = Color.White
        btnAdjuntarArchivo.Location = New Point(1077, 73)
        btnAdjuntarArchivo.Name = "btnAdjuntarArchivo"
        btnAdjuntarArchivo.Size = New Size(53, 52)
        btnAdjuntarArchivo.TabIndex = 76
        btnAdjuntarArchivo.Text = "📄"
        btnAdjuntarArchivo.UseVisualStyleBackColor = False
        ' 
        ' correo
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1163, 525)
        Controls.Add(btnAdjuntarArchivo)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBoxAsunto)
        Controls.Add(Label7)
        Controls.Add(TextBoxCuerpo)
        Controls.Add(Label5)
        Controls.Add(ListaProvedores)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "correo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "correo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListaProvedores As ComboBox
    Friend WithEvents TextBoxCuerpo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAsunto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdjuntarArchivo As Button
End Class
