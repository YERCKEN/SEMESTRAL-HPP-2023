<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        PanelLogin = New Panel()
        LabelIncorrecto = New Label()
        Label1 = New Label()
        textboxUsuario = New TextBox()
        TextBoxContraseña = New TextBox()
        BtnLogin = New Button()
        PictureBox1 = New PictureBox()
        PanelLogin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = Color.Transparent
        PanelLogin.Controls.Add(LabelIncorrecto)
        PanelLogin.Controls.Add(Label1)
        PanelLogin.Controls.Add(textboxUsuario)
        PanelLogin.Controls.Add(TextBoxContraseña)
        PanelLogin.Controls.Add(BtnLogin)
        PanelLogin.Location = New Point(142, 80)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(430, 436)
        PanelLogin.TabIndex = 59
        ' 
        ' LabelIncorrecto
        ' 
        LabelIncorrecto.AutoSize = True
        LabelIncorrecto.BackColor = Color.FromArgb(CByte(255), CByte(222), CByte(222))
        LabelIncorrecto.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        LabelIncorrecto.ForeColor = Color.Red
        LabelIncorrecto.Location = New Point(63, 287)
        LabelIncorrecto.Name = "LabelIncorrecto"
        LabelIncorrecto.Padding = New Padding(20, 5, 20, 5)
        LabelIncorrecto.Size = New Size(302, 32)
        LabelIncorrecto.TabIndex = 58
        LabelIncorrecto.Text = "usuario o contraseña incorrecta"
        LabelIncorrecto.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(152, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 46)
        Label1.TabIndex = 54
        Label1.Text = "Login"
        ' 
        ' textboxUsuario
        ' 
        textboxUsuario.BackColor = Color.White
        textboxUsuario.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        textboxUsuario.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        textboxUsuario.Location = New Point(23, 143)
        textboxUsuario.Name = "textboxUsuario"
        textboxUsuario.ShortcutsEnabled = False
        textboxUsuario.Size = New Size(377, 34)
        textboxUsuario.TabIndex = 48
        textboxUsuario.Text = "Usuario"
        textboxUsuario.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxContraseña
        ' 
        TextBoxContraseña.BackColor = Color.White
        TextBoxContraseña.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxContraseña.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxContraseña.Location = New Point(23, 216)
        TextBoxContraseña.Name = "TextBoxContraseña"
        TextBoxContraseña.ShortcutsEnabled = False
        TextBoxContraseña.Size = New Size(377, 34)
        TextBoxContraseña.TabIndex = 49
        TextBoxContraseña.Text = "Contraseña"
        TextBoxContraseña.TextAlign = HorizontalAlignment.Center
        TextBoxContraseña.UseSystemPasswordChar = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(25, 349)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(377, 51)
        BtnLogin.TabIndex = 53
        BtnLogin.Text = "Iniciar Sesión"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.FONDO_LOGIN
        PictureBox1.Location = New Point(578, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(702, 575)
        PictureBox1.TabIndex = 60
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 572)
        Controls.Add(PanelLogin)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        PanelLogin.ResumeLayout(False)
        PanelLogin.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents LabelIncorrecto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textboxUsuario As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
