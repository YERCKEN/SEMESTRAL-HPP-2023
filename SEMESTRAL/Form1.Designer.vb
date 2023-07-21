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
        Menu = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ServiciosToolStripMenuItem = New ToolStripMenuItem()
        ProvedoresToolStripMenuItem = New ToolStripMenuItem()
        CarrerasToolStripMenuItem = New ToolStripMenuItem()
        InventarioToolStripMenuItem = New ToolStripMenuItem()
        InformeToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        BtnMin = New PictureBox()
        btnCerrar = New PictureBox()
        PictureBox1 = New PictureBox()
        LabelActividad = New Label()
        PictureBox2 = New PictureBox()
        Menu.SuspendLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        Menu.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.GripMargin = New Padding(2, 60, 60, 2)
        Menu.ImageScalingSize = New Size(20, 20)
        Menu.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, ToolStripMenuItem1, ToolStripMenuItem2})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Size = New Size(1280, 52)
        Menu.TabIndex = 0
        Menu.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ServiciosToolStripMenuItem, ProvedoresToolStripMenuItem, CarrerasToolStripMenuItem, InventarioToolStripMenuItem, InformeToolStripMenuItem, ToolStripSeparator1, SalirToolStripMenuItem})
        MenuToolStripMenuItem.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MenuToolStripMenuItem.ForeColor = Color.White
        MenuToolStripMenuItem.Margin = New Padding(60, 0, 0, 0)
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Padding = New Padding(5, 20, 5, 0)
        MenuToolStripMenuItem.Size = New Size(75, 48)
        MenuToolStripMenuItem.Text = "Menú"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ClientesToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        ClientesToolStripMenuItem.Size = New Size(196, 34)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ServiciosToolStripMenuItem
        ' 
        ServiciosToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ServiciosToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        ServiciosToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        ServiciosToolStripMenuItem.Size = New Size(196, 34)
        ServiciosToolStripMenuItem.Text = "Servicios"
        ' 
        ' ProvedoresToolStripMenuItem
        ' 
        ProvedoresToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ProvedoresToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        ProvedoresToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        ProvedoresToolStripMenuItem.Size = New Size(196, 34)
        ProvedoresToolStripMenuItem.Text = "Provedores"
        ' 
        ' CarrerasToolStripMenuItem
        ' 
        CarrerasToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CarrerasToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        CarrerasToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        CarrerasToolStripMenuItem.Size = New Size(196, 34)
        CarrerasToolStripMenuItem.Text = "Carreras"
        ' 
        ' InventarioToolStripMenuItem
        ' 
        InventarioToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        InventarioToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        InventarioToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        InventarioToolStripMenuItem.Size = New Size(196, 34)
        InventarioToolStripMenuItem.Text = "Inventario"
        ' 
        ' InformeToolStripMenuItem
        ' 
        InformeToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        InformeToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        InformeToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        InformeToolStripMenuItem.Size = New Size(196, 34)
        InformeToolStripMenuItem.Text = "Informe"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Padding = New Padding(0, 5, 0, 1)
        ToolStripSeparator1.Size = New Size(193, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SalirToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Padding = New Padding(0, 5, 0, 1)
        SalirToolStripMenuItem.Size = New Size(196, 34)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem3})
        ToolStripMenuItem1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Padding = New Padding(5, 20, 5, 0)
        ToolStripMenuItem1.Size = New Size(81, 48)
        ToolStripMenuItem1.Text = "Ayuda"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Padding = New Padding(0, 5, 0, 1)
        ToolStripMenuItem3.Size = New Size(233, 34)
        ToolStripMenuItem3.Text = "Desarrolladores"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem2.ForeColor = Color.White
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Padding = New Padding(5, 20, 5, 0)
        ToolStripMenuItem2.Size = New Size(91, 48)
        ToolStripMenuItem2.Text = "Versión"
        ' 
        ' BtnMin
        ' 
        BtnMin.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnMin.Cursor = Cursors.Hand
        BtnMin.Image = My.Resources.Resources.MINIMIZAR
        BtnMin.Location = New Point(1171, 9)
        BtnMin.Margin = New Padding(4, 3, 4, 3)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(32, 32)
        BtnMin.TabIndex = 16
        BtnMin.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = My.Resources.Resources.CERRAR
        btnCerrar.Location = New Point(1217, 9)
        btnCerrar.Margin = New Padding(4, 3, 4, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(32, 32)
        btnCerrar.TabIndex = 17
        btnCerrar.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        PictureBox1.Image = My.Resources.Resources.LOGO_UC2
        PictureBox1.Location = New Point(12, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 43)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' LabelActividad
        ' 
        LabelActividad.AutoSize = True
        LabelActividad.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        LabelActividad.Font = New Font("Montserrat Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LabelActividad.ForeColor = Color.White
        LabelActividad.Location = New Point(967, 6)
        LabelActividad.Name = "LabelActividad"
        LabelActividad.Padding = New Padding(0, 5, 0, 5)
        LabelActividad.Size = New Size(73, 37)
        LabelActividad.TabIndex = 68
        LabelActividad.Text = "Login"
        LabelActividad.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(60, 144)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(397, 389)
        PictureBox2.TabIndex = 69
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 620)
        Controls.Add(PictureBox2)
        Controls.Add(LabelActividad)
        Controls.Add(PictureBox1)
        Controls.Add(btnCerrar)
        Controls.Add(BtnMin)
        Controls.Add(Menu)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelActividad As Label
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
End Class
