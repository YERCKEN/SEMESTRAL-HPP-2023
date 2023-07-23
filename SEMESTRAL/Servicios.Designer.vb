<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios
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
        DateTimePicker3 = New DateTimePicker()
        Label5 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ListaTipoSoporte = New ComboBox()
        BtnVolver = New Button()
        BtnIngresarNuevoTicket = New Button()
        TextBoxObservacion = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        TextBoxEquipo = New TextBox()
        Label7 = New Label()
        Label9 = New Label()
        PanelSelecion = New Panel()
        BtnSalirSeleccion = New Button()
        idProveedoresTb = New TextBox()
        BtnSeleccionar = New Button()
        Label2 = New Label()
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
        panelIngresoDatos2.Controls.Add(Label9)
        panelIngresoDatos2.Controls.Add(DateTimePicker3)
        panelIngresoDatos2.Controls.Add(Label5)
        panelIngresoDatos2.Controls.Add(DateTimePicker2)
        panelIngresoDatos2.Controls.Add(Label8)
        panelIngresoDatos2.Controls.Add(DateTimePicker1)
        panelIngresoDatos2.Controls.Add(ListaTipoSoporte)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(BtnIngresarNuevoTicket)
        panelIngresoDatos2.Controls.Add(TextBoxObservacion)
        panelIngresoDatos2.Controls.Add(Label1)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(TextBoxEquipo)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Location = New Point(446, 12)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(671, 335)
        panelIngresoDatos2.TabIndex = 72
        panelIngresoDatos2.Visible = False
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker3.CalendarForeColor = Color.Gray
        DateTimePicker3.CalendarTitleBackColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker3.CalendarTitleForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker3.Location = New Point(411, 57)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(163, 30)
        DateTimePicker3.TabIndex = 61
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label5.Location = New Point(187, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(216, 25)
        Label5.TabIndex = 60
        Label5.Text = "Fecha de finalización"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.CalendarForeColor = Color.Gray
        DateTimePicker2.CalendarTitleBackColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker2.CalendarTitleForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(187, 159)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(163, 30)
        DateTimePicker2.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label8.Location = New Point(4, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 25)
        Label8.TabIndex = 58
        Label8.Text = "Fecha de inicio"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CalendarForeColor = Color.Gray
        DateTimePicker1.CalendarTitleBackColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker1.CalendarTitleForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(4, 159)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(163, 30)
        DateTimePicker1.TabIndex = 57
        ' 
        ' ListaTipoSoporte
        ' 
        ListaTipoSoporte.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaTipoSoporte.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaTipoSoporte.FormattingEnabled = True
        ListaTipoSoporte.Items.AddRange(New Object() {"Preventivo", "Correctivo", "Predictivo"})
        ListaTipoSoporte.Location = New Point(3, 59)
        ListaTipoSoporte.Name = "ListaTipoSoporte"
        ListaTipoSoporte.Size = New Size(184, 33)
        ListaTipoSoporte.TabIndex = 49
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
        BtnVolver.Location = New Point(588, 262)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(77, 65)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' BtnIngresarNuevoTicket
        ' 
        BtnIngresarNuevoTicket.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnIngresarNuevoTicket.Cursor = Cursors.Hand
        BtnIngresarNuevoTicket.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresarNuevoTicket.FlatAppearance.BorderSize = 0
        BtnIngresarNuevoTicket.FlatStyle = FlatStyle.Flat
        BtnIngresarNuevoTicket.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresarNuevoTicket.ForeColor = Color.White
        BtnIngresarNuevoTicket.Location = New Point(424, 262)
        BtnIngresarNuevoTicket.Name = "BtnIngresarNuevoTicket"
        BtnIngresarNuevoTicket.Size = New Size(159, 65)
        BtnIngresarNuevoTicket.TabIndex = 47
        BtnIngresarNuevoTicket.Text = "Actualizar Datos"
        BtnIngresarNuevoTicket.UseVisualStyleBackColor = False
        ' 
        ' TextBoxObservacion
        ' 
        TextBoxObservacion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxObservacion.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxObservacion.Location = New Point(4, 259)
        TextBoxObservacion.Multiline = True
        TextBoxObservacion.Name = "TextBoxObservacion"
        TextBoxObservacion.Size = New Size(415, 68)
        TextBoxObservacion.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(3, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 25)
        Label1.TabIndex = 20
        Label1.Text = "Observación"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label6.Location = New Point(3, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 25)
        Label6.TabIndex = 16
        Label6.Text = "Tipo"
        ' 
        ' TextBoxEquipo
        ' 
        TextBoxEquipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxEquipo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxEquipo.Location = New Point(209, 56)
        TextBoxEquipo.Name = "TextBoxEquipo"
        TextBoxEquipo.Size = New Size(184, 30)
        TextBoxEquipo.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label7.Location = New Point(209, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 25)
        Label7.TabIndex = 18
        Label7.Text = "Evento"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label9.Location = New Point(411, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(158, 25)
        Label9.TabIndex = 62
        Label9.Text = "Fecha de inicio"
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(idProveedoresTb)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label2)
        PanelSelecion.Location = New Point(16, 7)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(378, 91)
        PanelSelecion.TabIndex = 81
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
        BtnSalirSeleccion.Location = New Point(318, 32)
        BtnSalirSeleccion.Name = "BtnSalirSeleccion"
        BtnSalirSeleccion.Size = New Size(44, 48)
        BtnSalirSeleccion.TabIndex = 57
        BtnSalirSeleccion.Text = "🔙"
        BtnSalirSeleccion.UseVisualStyleBackColor = False
        ' 
        ' idProveedoresTb
        ' 
        idProveedoresTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        idProveedoresTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        idProveedoresTb.Location = New Point(17, 41)
        idProveedoresTb.Name = "idProveedoresTb"
        idProveedoresTb.Size = New Size(238, 36)
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
        BtnSeleccionar.Location = New Point(268, 32)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(45, 48)
        BtnSeleccionar.TabIndex = 55
        BtnSeleccionar.Text = "✓"
        BtnSeleccionar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(17, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 25)
        Label2.TabIndex = 54
        Label2.Text = "ID"
        ' 
        ' PanelBotones
        ' 
        PanelBotones.Controls.Add(eliminarBtn)
        PanelBotones.Controls.Add(actualizarBtn)
        PanelBotones.Controls.Add(crearBtn)
        PanelBotones.Location = New Point(16, 160)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(378, 190)
        PanelBotones.TabIndex = 80
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        eliminarBtn.Cursor = Cursors.Hand
        eliminarBtn.Enabled = False
        eliminarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        eliminarBtn.FlatAppearance.BorderSize = 0
        eliminarBtn.FlatStyle = FlatStyle.Flat
        eliminarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        eliminarBtn.ForeColor = Color.FromArgb(CByte(255), CByte(176), CByte(176))
        eliminarBtn.Location = New Point(17, 112)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(328, 65)
        eliminarBtn.TabIndex = 50
        eliminarBtn.Text = "✖️Eliminar"
        eliminarBtn.UseVisualStyleBackColor = False
        ' 
        ' actualizarBtn
        ' 
        actualizarBtn.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        actualizarBtn.Cursor = Cursors.Hand
        actualizarBtn.Enabled = False
        actualizarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        actualizarBtn.FlatAppearance.BorderSize = 0
        actualizarBtn.FlatStyle = FlatStyle.Flat
        actualizarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        actualizarBtn.ForeColor = Color.White
        actualizarBtn.Location = New Point(196, 22)
        actualizarBtn.Name = "actualizarBtn"
        actualizarBtn.Size = New Size(148, 65)
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
        crearBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        crearBtn.ForeColor = Color.FromArgb(CByte(255), CByte(230), CByte(133))
        crearBtn.Location = New Point(17, 22)
        crearBtn.Name = "crearBtn"
        crearBtn.Size = New Size(150, 65)
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
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
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
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(230), CByte(235), CByte(242))
        DataGridView1.Location = New Point(12, 361)
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
        DataGridView1.Size = New Size(1113, 172)
        DataGridView1.TabIndex = 82
        ' 
        ' Servicios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1138, 545)
        Controls.Add(DataGridView1)
        Controls.Add(PanelSelecion)
        Controls.Add(PanelBotones)
        Controls.Add(panelIngresoDatos2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Servicios"
        Text = "Servicios"
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        PanelBotones.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListaTipoSoporte As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnIngresarNuevoTicket As Button
    Friend WithEvents TextBoxObservacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEquipo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents BtnSalirSeleccion As Button
    Friend WithEvents idProveedoresTb As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents actualizarBtn As Button
    Friend WithEvents crearBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
