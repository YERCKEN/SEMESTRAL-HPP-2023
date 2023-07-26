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
        Label9 = New Label()
        horaInicioDt = New DateTimePicker()
        Label5 = New Label()
        fechaFinalizacionDt = New DateTimePicker()
        Label8 = New Label()
        fechaInicioDt = New DateTimePicker()
        tipoCb = New ComboBox()
        BtnVolver = New Button()
        observacionTb = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        eventoTb = New TextBox()
        Label7 = New Label()
        BtnNuevoTicket = New Button()
        BtnactualizarNuevoTicket = New Button()
        PanelSelecion = New Panel()
        btnselecccionarElimina = New Button()
        BtnSalirSeleccion = New Button()
        idServicioTb = New TextBox()
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
        panelIngresoDatos2.BackColor = Color.Transparent
        panelIngresoDatos2.Controls.Add(Label9)
        panelIngresoDatos2.Controls.Add(horaInicioDt)
        panelIngresoDatos2.Controls.Add(Label5)
        panelIngresoDatos2.Controls.Add(fechaFinalizacionDt)
        panelIngresoDatos2.Controls.Add(Label8)
        panelIngresoDatos2.Controls.Add(fechaInicioDt)
        panelIngresoDatos2.Controls.Add(tipoCb)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(observacionTb)
        panelIngresoDatos2.Controls.Add(Label1)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(eventoTb)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Controls.Add(BtnNuevoTicket)
        panelIngresoDatos2.Controls.Add(BtnactualizarNuevoTicket)
        panelIngresoDatos2.Location = New Point(53, 53)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(825, 412)
        panelIngresoDatos2.TabIndex = 72
        panelIngresoDatos2.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(583, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(157, 27)
        Label9.TabIndex = 62
        Label9.Text = "Hora de inicio"
        ' 
        ' horaInicioDt
        ' 
        horaInicioDt.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        horaInicioDt.CalendarForeColor = Color.Gray
        horaInicioDt.CalendarTitleBackColor = Color.Transparent
        horaInicioDt.CalendarTitleForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        horaInicioDt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        horaInicioDt.Format = DateTimePickerFormat.Time
        horaInicioDt.Location = New Point(583, 188)
        horaInicioDt.Name = "horaInicioDt"
        horaInicioDt.Size = New Size(206, 30)
        horaInicioDt.TabIndex = 61
        horaInicioDt.Value = New DateTime(2023, 7, 23, 17, 55, 59, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label5.Location = New Point(302, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(235, 27)
        Label5.TabIndex = 60
        Label5.Text = "Fecha de finalización"
        ' 
        ' fechaFinalizacionDt
        ' 
        fechaFinalizacionDt.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        fechaFinalizacionDt.CalendarForeColor = Color.Gray
        fechaFinalizacionDt.CalendarTitleBackColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        fechaFinalizacionDt.CalendarTitleForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        fechaFinalizacionDt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        fechaFinalizacionDt.Format = DateTimePickerFormat.Custom
        fechaFinalizacionDt.Location = New Point(302, 188)
        fechaFinalizacionDt.Name = "fechaFinalizacionDt"
        fechaFinalizacionDt.Size = New Size(206, 30)
        fechaFinalizacionDt.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label8.Location = New Point(0, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(172, 27)
        Label8.TabIndex = 58
        Label8.Text = "Fecha de inicio"
        ' 
        ' fechaInicioDt
        ' 
        fechaInicioDt.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        fechaInicioDt.CalendarForeColor = Color.Gray
        fechaInicioDt.CalendarTitleBackColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        fechaInicioDt.CalendarTitleForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        fechaInicioDt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        fechaInicioDt.Format = DateTimePickerFormat.Custom
        fechaInicioDt.Location = New Point(3, 188)
        fechaInicioDt.Name = "fechaInicioDt"
        fechaInicioDt.Size = New Size(206, 30)
        fechaInicioDt.TabIndex = 57
        ' 
        ' tipoCb
        ' 
        tipoCb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tipoCb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        tipoCb.FormattingEnabled = True
        tipoCb.Items.AddRange(New Object() {"Preventivo", "Correctivo", "Predictivo"})
        tipoCb.Location = New Point(3, 56)
        tipoCb.Name = "tipoCb"
        tipoCb.Size = New Size(206, 33)
        tipoCb.TabIndex = 49
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
        BtnVolver.Location = New Point(702, 325)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(87, 68)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' observacionTb
        ' 
        observacionTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        observacionTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        observacionTb.Location = New Point(7, 305)
        observacionTb.Multiline = True
        observacionTb.Name = "observacionTb"
        observacionTb.Size = New Size(434, 88)
        observacionTb.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(3, 267)
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
        Label6.Location = New Point(3, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 27)
        Label6.TabIndex = 16
        Label6.Text = "Tipo"
        ' 
        ' eventoTb
        ' 
        eventoTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        eventoTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        eventoTb.Location = New Point(302, 59)
        eventoTb.Name = "eventoTb"
        eventoTb.Size = New Size(487, 30)
        eventoTb.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(302, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 27)
        Label7.TabIndex = 18
        Label7.Text = "Evento"
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
        BtnNuevoTicket.Location = New Point(517, 325)
        BtnNuevoTicket.Name = "BtnNuevoTicket"
        BtnNuevoTicket.Size = New Size(179, 68)
        BtnNuevoTicket.TabIndex = 63
        BtnNuevoTicket.Text = "Nuevos Datos"
        BtnNuevoTicket.UseVisualStyleBackColor = False
        BtnNuevoTicket.Visible = False
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
        BtnactualizarNuevoTicket.Location = New Point(517, 325)
        BtnactualizarNuevoTicket.Name = "BtnactualizarNuevoTicket"
        BtnactualizarNuevoTicket.Size = New Size(179, 68)
        BtnactualizarNuevoTicket.TabIndex = 47
        BtnactualizarNuevoTicket.Text = "Actualizar Datos"
        BtnactualizarNuevoTicket.UseVisualStyleBackColor = False
        BtnactualizarNuevoTicket.Visible = False
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(btnselecccionarElimina)
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(idServicioTb)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label2)
        PanelSelecion.Location = New Point(124, 226)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(425, 96)
        PanelSelecion.TabIndex = 81
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
        btnselecccionarElimina.TabIndex = 58
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
        ' idServicioTb
        ' 
        idServicioTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        idServicioTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        idServicioTb.Location = New Point(19, 43)
        idServicioTb.Name = "idServicioTb"
        idServicioTb.Size = New Size(267, 36)
        idServicioTb.TabIndex = 56
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
        BtnSeleccionar.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(19, 15)
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
        PanelBotones.Location = New Point(124, 175)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(425, 199)
        PanelBotones.TabIndex = 80
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
        eliminarBtn.Location = New Point(23, 118)
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
        actualizarBtn.Location = New Point(224, 23)
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
        crearBtn.Location = New Point(23, 23)
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
        DataGridView1.Location = New Point(41, 491)
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
        DataGridView1.TabIndex = 82
        ' 
        ' Servicios
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.fondoServicios_png2
        ClientSize = New Size(1280, 781)
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
    Friend WithEvents fechaInicioDt As DateTimePicker
    Friend WithEvents tipoCb As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnactualizarNuevoTicket As Button
    Friend WithEvents observacionTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents eventoTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents fechaFinalizacionDt As DateTimePicker
    Friend WithEvents horaInicioDt As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents BtnSalirSeleccion As Button
    Friend WithEvents idServicioTb As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents actualizarBtn As Button
    Friend WithEvents crearBtn As Button
    Friend WithEvents BtnNuevoTicket As Button
    Friend WithEvents btnselecccionarElimina As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
