<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Provedores
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panelIngresoDatos2 = New Panel()
        correoTb = New TextBox()
        rucTb = New TextBox()
        tipoCb = New ComboBox()
        Label8 = New Label()
        telefonoTb = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        BtnVolver = New Button()
        BtnactualizarNuevoTicket = New Button()
        observacionTb = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        nombreTb = New TextBox()
        Label7 = New Label()
        BtnNuevoTicket = New Button()
        PanelSelecion = New Panel()
        btnselecccionarElimina = New Button()
        BtnSalirSeleccion = New Button()
        idProveedoresTb = New TextBox()
        BtnSeleccionar = New Button()
        Label9 = New Label()
        PanelBotones = New Panel()
        eliminarBtn = New Button()
        actualizarBtn = New Button()
        crearBtn = New Button()
        DataGridView1 = New DataGridView()
        panelIngresoDatos2.SuspendLayout()
        PanelSelecion.SuspendLayout()
        PanelBotones.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.BackColor = Color.Transparent
        panelIngresoDatos2.Controls.Add(correoTb)
        panelIngresoDatos2.Controls.Add(rucTb)
        panelIngresoDatos2.Controls.Add(tipoCb)
        panelIngresoDatos2.Controls.Add(Label8)
        panelIngresoDatos2.Controls.Add(telefonoTb)
        panelIngresoDatos2.Controls.Add(Label3)
        panelIngresoDatos2.Controls.Add(Label2)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(BtnactualizarNuevoTicket)
        panelIngresoDatos2.Controls.Add(observacionTb)
        panelIngresoDatos2.Controls.Add(Label1)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(nombreTb)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Controls.Add(BtnNuevoTicket)
        panelIngresoDatos2.Location = New Point(50, 50)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(793, 360)
        panelIngresoDatos2.TabIndex = 77
        panelIngresoDatos2.Visible = False
        ' 
        ' correoTb
        ' 
        correoTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        correoTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        correoTb.Location = New Point(6, 292)
        correoTb.Name = "correoTb"
        correoTb.Size = New Size(461, 30)
        correoTb.TabIndex = 73
        ' 
        ' rucTb
        ' 
        rucTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rucTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        rucTb.Location = New Point(6, 52)
        rucTb.Name = "rucTb"
        rucTb.Size = New Size(206, 30)
        rucTb.TabIndex = 72
        ' 
        ' tipoCb
        ' 
        tipoCb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tipoCb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        tipoCb.FormattingEnabled = True
        tipoCb.Items.AddRange(New Object() {"Preventivo", "Correctivo", "Predictivo"})
        tipoCb.Location = New Point(261, 173)
        tipoCb.Name = "tipoCb"
        tipoCb.Size = New Size(206, 33)
        tipoCb.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label8.Location = New Point(261, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 27)
        Label8.TabIndex = 58
        Label8.Text = "Tipo"
        ' 
        ' telefonoTb
        ' 
        telefonoTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        telefonoTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        telefonoTb.Location = New Point(4, 170)
        telefonoTb.Name = "telefonoTb"
        telefonoTb.Size = New Size(206, 30)
        telefonoTb.TabIndex = 52
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(4, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 27)
        Label3.TabIndex = 53
        Label3.Text = "Teléfono"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(6, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 27)
        Label2.TabIndex = 50
        Label2.Text = "Correo"
        ' 
        ' BtnVolver
        ' 
        BtnVolver.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnVolver.Cursor = Cursors.Hand
        BtnVolver.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnVolver.FlatAppearance.BorderSize = 0
        BtnVolver.FlatStyle = FlatStyle.Flat
        BtnVolver.Font = New Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnVolver.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnVolver.Location = New Point(699, 273)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(87, 68)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' BtnactualizarNuevoTicket
        ' 
        BtnactualizarNuevoTicket.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnactualizarNuevoTicket.Cursor = Cursors.Hand
        BtnactualizarNuevoTicket.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnactualizarNuevoTicket.FlatAppearance.BorderSize = 0
        BtnactualizarNuevoTicket.FlatStyle = FlatStyle.Flat
        BtnactualizarNuevoTicket.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnactualizarNuevoTicket.ForeColor = Color.White
        BtnactualizarNuevoTicket.Location = New Point(506, 272)
        BtnactualizarNuevoTicket.Name = "BtnactualizarNuevoTicket"
        BtnactualizarNuevoTicket.Size = New Size(179, 68)
        BtnactualizarNuevoTicket.TabIndex = 47
        BtnactualizarNuevoTicket.Text = "Actualizar Datos"
        BtnactualizarNuevoTicket.UseVisualStyleBackColor = False
        ' 
        ' observacionTb
        ' 
        observacionTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        observacionTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        observacionTb.Location = New Point(506, 52)
        observacionTb.Multiline = True
        observacionTb.Name = "observacionTb"
        observacionTb.Size = New Size(277, 200)
        observacionTb.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(506, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 27)
        Label1.TabIndex = 20
        Label1.Text = "Observación"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label6.Location = New Point(4, 4)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 27)
        Label6.TabIndex = 16
        Label6.Text = "Ruc"
        ' 
        ' nombreTb
        ' 
        nombreTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nombreTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        nombreTb.Location = New Point(261, 52)
        nombreTb.Name = "nombreTb"
        nombreTb.Size = New Size(206, 30)
        nombreTb.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(261, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 27)
        Label7.TabIndex = 18
        Label7.Text = "Nombre"
        ' 
        ' BtnNuevoTicket
        ' 
        BtnNuevoTicket.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnNuevoTicket.Cursor = Cursors.Hand
        BtnNuevoTicket.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnNuevoTicket.FlatAppearance.BorderSize = 0
        BtnNuevoTicket.FlatStyle = FlatStyle.Flat
        BtnNuevoTicket.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNuevoTicket.ForeColor = Color.White
        BtnNuevoTicket.Location = New Point(506, 270)
        BtnNuevoTicket.Name = "BtnNuevoTicket"
        BtnNuevoTicket.Size = New Size(179, 68)
        BtnNuevoTicket.TabIndex = 74
        BtnNuevoTicket.Text = "Nuevos Datos"
        BtnNuevoTicket.UseVisualStyleBackColor = False
        BtnNuevoTicket.Visible = False
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(btnselecccionarElimina)
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(idProveedoresTb)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Location = New Point(128, 158)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(425, 96)
        PanelSelecion.TabIndex = 79
        PanelSelecion.Visible = False
        ' 
        ' btnselecccionarElimina
        ' 
        btnselecccionarElimina.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        btnselecccionarElimina.Cursor = Cursors.Hand
        btnselecccionarElimina.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnselecccionarElimina.FlatAppearance.BorderSize = 0
        btnselecccionarElimina.FlatStyle = FlatStyle.Flat
        btnselecccionarElimina.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnselecccionarElimina.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnselecccionarElimina.Location = New Point(302, 35)
        btnselecccionarElimina.Name = "btnselecccionarElimina"
        btnselecccionarElimina.Size = New Size(51, 50)
        btnselecccionarElimina.TabIndex = 59
        btnselecccionarElimina.Text = "✓"
        btnselecccionarElimina.UseVisualStyleBackColor = False
        btnselecccionarElimina.Visible = False
        ' 
        ' BtnSalirSeleccion
        ' 
        BtnSalirSeleccion.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSalirSeleccion.Cursor = Cursors.Hand
        BtnSalirSeleccion.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSalirSeleccion.FlatAppearance.BorderSize = 0
        BtnSalirSeleccion.FlatStyle = FlatStyle.Flat
        BtnSalirSeleccion.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSalirSeleccion.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSalirSeleccion.Location = New Point(358, 34)
        BtnSalirSeleccion.Name = "BtnSalirSeleccion"
        BtnSalirSeleccion.Size = New Size(50, 50)
        BtnSalirSeleccion.TabIndex = 57
        BtnSalirSeleccion.Text = "🔙"
        BtnSalirSeleccion.UseVisualStyleBackColor = False
        ' 
        ' idProveedoresTb
        ' 
        idProveedoresTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        idProveedoresTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        idProveedoresTb.Location = New Point(19, 43)
        idProveedoresTb.Name = "idProveedoresTb"
        idProveedoresTb.Size = New Size(267, 36)
        idProveedoresTb.TabIndex = 56
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSeleccionar.Cursor = Cursors.Hand
        BtnSeleccionar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSeleccionar.FlatAppearance.BorderSize = 0
        BtnSeleccionar.FlatStyle = FlatStyle.Flat
        BtnSeleccionar.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSeleccionar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSeleccionar.Location = New Point(302, 34)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(51, 50)
        BtnSeleccionar.TabIndex = 55
        BtnSeleccionar.Text = "✓"
        BtnSeleccionar.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(19, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(33, 25)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' PanelBotones
        ' 
        PanelBotones.Controls.Add(eliminarBtn)
        PanelBotones.Controls.Add(actualizarBtn)
        PanelBotones.Controls.Add(crearBtn)
        PanelBotones.Location = New Point(127, 106)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(425, 199)
        PanelBotones.TabIndex = 78
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        eliminarBtn.Cursor = Cursors.Hand
        eliminarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        eliminarBtn.FlatAppearance.BorderSize = 0
        eliminarBtn.FlatStyle = FlatStyle.Flat
        eliminarBtn.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        eliminarBtn.ForeColor = Color.FromArgb(CByte(255), CByte(176), CByte(176))
        eliminarBtn.Location = New Point(19, 118)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(369, 68)
        eliminarBtn.TabIndex = 50
        eliminarBtn.Text = "✖️Eliminar"
        eliminarBtn.UseVisualStyleBackColor = False
        ' 
        ' actualizarBtn
        ' 
        actualizarBtn.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        actualizarBtn.Cursor = Cursors.Hand
        actualizarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        actualizarBtn.FlatAppearance.BorderSize = 0
        actualizarBtn.FlatStyle = FlatStyle.Flat
        actualizarBtn.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        actualizarBtn.ForeColor = Color.White
        actualizarBtn.Location = New Point(220, 23)
        actualizarBtn.Name = "actualizarBtn"
        actualizarBtn.Size = New Size(166, 68)
        actualizarBtn.TabIndex = 49
        actualizarBtn.Text = "✏️" & vbCrLf & "Actualizar"
        actualizarBtn.UseVisualStyleBackColor = False
        ' 
        ' crearBtn
        ' 
        crearBtn.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        crearBtn.Cursor = Cursors.Hand
        crearBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        crearBtn.FlatAppearance.BorderSize = 0
        crearBtn.FlatStyle = FlatStyle.Flat
        crearBtn.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        crearBtn.ForeColor = Color.FromArgb(CByte(189), CByte(255), CByte(221))
        crearBtn.Location = New Point(19, 23)
        crearBtn.Name = "crearBtn"
        crearBtn.Size = New Size(169, 68)
        crearBtn.TabIndex = 48
        crearBtn.Text = "➕" & vbCrLf & " Nueva"
        crearBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(252))
        DataGridViewCellStyle1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.Padding = New Padding(0, 5, 0, 5)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(230), CByte(235), CByte(242))
        DataGridView1.Location = New Point(50, 478)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1192, 278)
        DataGridView1.TabIndex = 83
        ' 
        ' Provedores
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.fondoProvedores
        ClientSize = New Size(1280, 791)
        Controls.Add(DataGridView1)
        Controls.Add(PanelSelecion)
        Controls.Add(panelIngresoDatos2)
        Controls.Add(PanelBotones)
        FormBorderStyle = FormBorderStyle.None
        Name = "Provedores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Provedores"
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        PanelBotones.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents correoTb As TextBox
    Friend WithEvents rucTb As TextBox
    Friend WithEvents tipoCb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents telefonoTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnactualizarNuevoTicket As Button
    Friend WithEvents observacionTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nombreTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents BtnSalirSeleccion As Button
    Friend WithEvents idProveedoresTb As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents actualizarBtn As Button
    Friend WithEvents crearBtn As Button
    Friend WithEvents btnselecccionarElimina As Button
    Friend WithEvents BtnNuevoTicket As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
