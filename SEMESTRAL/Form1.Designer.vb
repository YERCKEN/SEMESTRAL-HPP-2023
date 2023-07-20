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
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        Menu.SuspendLayout()
        SuspendLayout()
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.FromArgb(CByte(108), CByte(0), CByte(255))
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
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ServiciosToolStripMenuItem, ProvedoresToolStripMenuItem, CarrerasToolStripMenuItem, InventarioToolStripMenuItem, InformeToolStripMenuItem})
        MenuToolStripMenuItem.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MenuToolStripMenuItem.ForeColor = Color.White
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Padding = New Padding(5, 20, 5, 0)
        MenuToolStripMenuItem.Size = New Size(75, 48)
        MenuToolStripMenuItem.Text = "Menú"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(224, 28)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ServiciosToolStripMenuItem
        ' 
        ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        ServiciosToolStripMenuItem.Size = New Size(224, 28)
        ServiciosToolStripMenuItem.Text = "Servicios"
        ' 
        ' ProvedoresToolStripMenuItem
        ' 
        ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        ProvedoresToolStripMenuItem.Size = New Size(224, 28)
        ProvedoresToolStripMenuItem.Text = "Provedores"
        ' 
        ' CarrerasToolStripMenuItem
        ' 
        CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        CarrerasToolStripMenuItem.Size = New Size(224, 28)
        CarrerasToolStripMenuItem.Text = "Carreras"
        ' 
        ' InventarioToolStripMenuItem
        ' 
        InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        InventarioToolStripMenuItem.Size = New Size(224, 28)
        InventarioToolStripMenuItem.Text = "Inventario"
        ' 
        ' InformeToolStripMenuItem
        ' 
        InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        InformeToolStripMenuItem.Size = New Size(224, 28)
        InformeToolStripMenuItem.Text = "Informe"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Padding = New Padding(5, 20, 5, 0)
        ToolStripMenuItem1.Size = New Size(81, 48)
        ToolStripMenuItem1.Text = "Ayuda"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 620)
        Controls.Add(Menu)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
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
End Class
