﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panelIngresoDatos2 = New Panel()
        residenciatb = New TextBox()
        nombreTb = New TextBox()
        ComboBox4 = New ComboBox()
        Label13 = New Label()
        ComboBox5 = New ComboBox()
        Label14 = New Label()
        Label12 = New Label()
        ComboBox2 = New ComboBox()
        Label11 = New Label()
        lugarTrabajoTb = New TextBox()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        telefono3Tb = New TextBox()
        Label5 = New Label()
        telefono2Tb = New TextBox()
        Label4 = New Label()
        telefono1Tb = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        BtnVolver = New Button()
        BtnIngresarNuevoTicket = New Button()
        ObservacionTb = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        apellidoTb = New TextBox()
        Label7 = New Label()
        PanelSelecion = New Panel()
        BtnSalirSeleccion = New Button()
        TextBoxId = New TextBox()
        BtnSeleccionar = New Button()
        Label9 = New Label()
        PanelBotones = New Panel()
        BtnEliminar = New Button()
        BtnActualizar = New Button()
        BtnAceptar = New Button()
        DataGridView1 = New DataGridView()
        ComboBox3 = New ComboBox()
        panelIngresoDatos2.SuspendLayout()
        PanelSelecion.SuspendLayout()
        PanelBotones.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.Controls.Add(ComboBox3)
        panelIngresoDatos2.Controls.Add(residenciatb)
        panelIngresoDatos2.Controls.Add(nombreTb)
        panelIngresoDatos2.Controls.Add(ComboBox4)
        panelIngresoDatos2.Controls.Add(Label13)
        panelIngresoDatos2.Controls.Add(ComboBox5)
        panelIngresoDatos2.Controls.Add(Label14)
        panelIngresoDatos2.Controls.Add(Label12)
        panelIngresoDatos2.Controls.Add(ComboBox2)
        panelIngresoDatos2.Controls.Add(Label11)
        panelIngresoDatos2.Controls.Add(lugarTrabajoTb)
        panelIngresoDatos2.Controls.Add(Label10)
        panelIngresoDatos2.Controls.Add(ComboBox1)
        panelIngresoDatos2.Controls.Add(Label8)
        panelIngresoDatos2.Controls.Add(telefono3Tb)
        panelIngresoDatos2.Controls.Add(Label5)
        panelIngresoDatos2.Controls.Add(telefono2Tb)
        panelIngresoDatos2.Controls.Add(Label4)
        panelIngresoDatos2.Controls.Add(telefono1Tb)
        panelIngresoDatos2.Controls.Add(Label3)
        panelIngresoDatos2.Controls.Add(Label2)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(BtnIngresarNuevoTicket)
        panelIngresoDatos2.Controls.Add(ObservacionTb)
        panelIngresoDatos2.Controls.Add(Label1)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(apellidoTb)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Location = New Point(405, 12)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(721, 533)
        panelIngresoDatos2.TabIndex = 76
        ' 
        ' residenciatb
        ' 
        residenciatb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        residenciatb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        residenciatb.Location = New Point(436, 57)
        residenciatb.Name = "residenciatb"
        residenciatb.Size = New Size(184, 30)
        residenciatb.TabIndex = 73
        ' 
        ' nombreTb
        ' 
        nombreTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nombreTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        nombreTb.Location = New Point(5, 57)
        nombreTb.Name = "nombreTb"
        nombreTb.Size = New Size(184, 30)
        nombreTb.TabIndex = 72
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"En espera", "En proceso", "Terminado"})
        ComboBox4.Location = New Point(232, 334)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(184, 33)
        ComboBox4.TabIndex = 71
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label13.Location = New Point(232, 288)
        Label13.Name = "Label13"
        Label13.Size = New Size(111, 25)
        Label13.TabIndex = 70
        Label13.Text = "Opción #2"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"En espera", "En proceso", "Terminado"})
        ComboBox5.Location = New Point(436, 334)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(184, 33)
        ComboBox5.TabIndex = 69
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label14.Location = New Point(436, 288)
        Label14.Name = "Label14"
        Label14.Size = New Size(111, 25)
        Label14.TabIndex = 68
        Label14.Text = "Opción #3"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label12.Location = New Point(5, 288)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 25)
        Label12.TabIndex = 64
        Label12.Text = "Opción #1"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"En espera", "En proceso", "Terminado"})
        ComboBox2.Location = New Point(436, 239)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(184, 33)
        ComboBox2.TabIndex = 63
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label11.Location = New Point(436, 193)
        Label11.Name = "Label11"
        Label11.Size = New Size(140, 25)
        Label11.TabIndex = 62
        Label11.Text = "Convocatoria"
        ' 
        ' lugarTrabajoTb
        ' 
        lugarTrabajoTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lugarTrabajoTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        lugarTrabajoTb.Location = New Point(232, 239)
        lugarTrabajoTb.Name = "lugarTrabajoTb"
        lugarTrabajoTb.Size = New Size(163, 30)
        lugarTrabajoTb.TabIndex = 60
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label10.Location = New Point(232, 193)
        Label10.Name = "Label10"
        Label10.Size = New Size(169, 25)
        Label10.TabIndex = 61
        Label10.Text = "Lugar de trabajo"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Preventivo", "Correctivo", "Predictivo"})
        ComboBox1.Location = New Point(4, 236)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(184, 33)
        ComboBox1.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label8.Location = New Point(4, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 25)
        Label8.TabIndex = 58
        Label8.Text = "Tipo"
        ' 
        ' telefono3Tb
        ' 
        telefono3Tb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        telefono3Tb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        telefono3Tb.Location = New Point(436, 146)
        telefono3Tb.Name = "telefono3Tb"
        telefono3Tb.Size = New Size(163, 30)
        telefono3Tb.TabIndex = 56
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label5.Location = New Point(436, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 25)
        Label5.TabIndex = 57
        Label5.Text = "Email"
        ' 
        ' telefono2Tb
        ' 
        telefono2Tb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        telefono2Tb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        telefono2Tb.Location = New Point(232, 146)
        telefono2Tb.Name = "telefono2Tb"
        telefono2Tb.Size = New Size(163, 30)
        telefono2Tb.TabIndex = 54
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label4.Location = New Point(232, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 55
        Label4.Text = "Teléfono 2"
        ' 
        ' telefono1Tb
        ' 
        telefono1Tb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        telefono1Tb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        telefono1Tb.Location = New Point(4, 146)
        telefono1Tb.Name = "telefono1Tb"
        telefono1Tb.Size = New Size(184, 30)
        telefono1Tb.TabIndex = 52
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label3.Location = New Point(4, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 53
        Label3.Text = "Teléfono 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label2.Location = New Point(436, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 25)
        Label2.TabIndex = 50
        Label2.Text = "Residencia"
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
        BtnVolver.Location = New Point(589, 434)
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
        BtnIngresarNuevoTicket.Location = New Point(424, 434)
        BtnIngresarNuevoTicket.Name = "BtnIngresarNuevoTicket"
        BtnIngresarNuevoTicket.Size = New Size(159, 65)
        BtnIngresarNuevoTicket.TabIndex = 47
        BtnIngresarNuevoTicket.Text = "Actualizar Datos"
        BtnIngresarNuevoTicket.UseVisualStyleBackColor = False
        ' 
        ' ObservacionTb
        ' 
        ObservacionTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ObservacionTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ObservacionTb.Location = New Point(5, 434)
        ObservacionTb.Multiline = True
        ObservacionTb.Name = "ObservacionTb"
        ObservacionTb.Size = New Size(415, 68)
        ObservacionTb.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(4, 391)
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
        Label6.Location = New Point(4, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 16
        Label6.Text = "Nombre"
        ' 
        ' apellidoTb
        ' 
        apellidoTb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        apellidoTb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        apellidoTb.Location = New Point(232, 57)
        apellidoTb.Name = "apellidoTb"
        apellidoTb.Size = New Size(184, 30)
        apellidoTb.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label7.Location = New Point(232, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 25)
        Label7.TabIndex = 18
        Label7.Text = "Apellido"
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(TextBoxId)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Location = New Point(12, 112)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(378, 91)
        PanelSelecion.TabIndex = 75
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
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxId.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxId.Location = New Point(17, 41)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(238, 36)
        TextBoxId.TabIndex = 56
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(17, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(33, 25)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' PanelBotones
        ' 
        PanelBotones.Controls.Add(BtnEliminar)
        PanelBotones.Controls.Add(BtnActualizar)
        PanelBotones.Controls.Add(BtnAceptar)
        PanelBotones.Location = New Point(12, 265)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(378, 190)
        PanelBotones.TabIndex = 74
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnEliminar.FlatAppearance.BorderSize = 0
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnEliminar.ForeColor = Color.FromArgb(CByte(255), CByte(176), CByte(176))
        BtnEliminar.Location = New Point(17, 112)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(328, 65)
        BtnEliminar.TabIndex = 50
        BtnEliminar.Text = "✖️Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnActualizar.Cursor = Cursors.Hand
        BtnActualizar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnActualizar.FlatAppearance.BorderSize = 0
        BtnActualizar.FlatStyle = FlatStyle.Flat
        BtnActualizar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnActualizar.ForeColor = Color.White
        BtnActualizar.Location = New Point(196, 22)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(148, 65)
        BtnActualizar.TabIndex = 49
        BtnActualizar.Text = "✏️" & vbCrLf & "Actualizar"
        BtnActualizar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnAceptar.Cursor = Cursors.Hand
        BtnAceptar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAceptar.ForeColor = Color.FromArgb(CByte(255), CByte(230), CByte(133))
        BtnAceptar.Location = New Point(17, 22)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(150, 65)
        BtnAceptar.TabIndex = 48
        BtnAceptar.Text = "➕" & vbCrLf & " Nueva"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle4.Padding = New Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(230), CByte(235), CByte(242))
        DataGridView1.Location = New Point(12, 551)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1113, 217)
        DataGridView1.TabIndex = 77
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"En espera", "En proceso", "Terminado"})
        ComboBox3.Location = New Point(5, 334)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(184, 33)
        ComboBox3.TabIndex = 74
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1138, 780)
        Controls.Add(DataGridView1)
        Controls.Add(panelIngresoDatos2)
        Controls.Add(PanelSelecion)
        Controls.Add(PanelBotones)
        FormBorderStyle = FormBorderStyle.None
        Name = "Clientes"
        Text = "Clientes"
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        PanelBotones.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lugarTrabajoTb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents telefono3Tb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents telefono2Tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents telefono1Tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnIngresarNuevoTicket As Button
    Friend WithEvents ObservacionTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents apellidoTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents BtnSalirSeleccion As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents residenciatb As TextBox
    Friend WithEvents nombreTb As TextBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
