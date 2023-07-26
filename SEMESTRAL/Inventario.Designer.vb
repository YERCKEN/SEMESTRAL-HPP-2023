<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        DataGridView1 = New DataGridView()
        listaMostrar = New ComboBox()
        LabelFiltro = New Label()
        Panel1 = New Panel()
        TextBoxBusquedad = New TextBox()
        Label1 = New Label()
        PanelBotones = New Panel()
        BtnEliminar = New Button()
        BtnActualizar = New Button()
        BtnNuevaCarrera = New Button()
        panelIngresoDatos2 = New Panel()
        TextBoxUbicacion = New TextBox()
        Label4 = New Label()
        ListaEstado = New ComboBox()
        Label2 = New Label()
        ListaTipo = New ComboBox()
        BtnVolver = New Button()
        BtnIngresar = New Button()
        TextBoxObservacion = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBoxNombre = New TextBox()
        Label7 = New Label()
        PanelSelecion = New Panel()
        BtnSalirSeleccion = New Button()
        TextBoxId = New TextBox()
        BtnSeleccionar = New Button()
        Label9 = New Label()
        PanelEliminación = New Panel()
        BtnAceptarEliminacion = New Button()
        BtnCancelar = New Button()
        LabelMensaje = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PanelBotones.SuspendLayout()
        panelIngresoDatos2.SuspendLayout()
        PanelSelecion.SuspendLayout()
        PanelEliminación.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DataGridView1.Location = New Point(10, 78)
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
        DataGridView1.TabIndex = 6
        ' 
        ' listaMostrar
        ' 
        listaMostrar.AutoCompleteMode = AutoCompleteMode.Suggest
        listaMostrar.BackColor = Color.White
        listaMostrar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        listaMostrar.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        listaMostrar.FormattingEnabled = True
        listaMostrar.Items.AddRange(New Object() {"Equipos & Recursos", "Equipos", "Recursos"})
        listaMostrar.Location = New Point(940, 5)
        listaMostrar.Name = "listaMostrar"
        listaMostrar.Size = New Size(245, 28)
        listaMostrar.TabIndex = 42
        listaMostrar.Text = "Equipos & Recursos"
        ' 
        ' LabelFiltro
        ' 
        LabelFiltro.AutoSize = True
        LabelFiltro.BackColor = Color.White
        LabelFiltro.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        LabelFiltro.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelFiltro.Location = New Point(893, 1)
        LabelFiltro.Name = "LabelFiltro"
        LabelFiltro.Size = New Size(47, 32)
        LabelFiltro.TabIndex = 64
        LabelFiltro.Text = "👁️‍🗨️"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TextBoxBusquedad)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(listaMostrar)
        Panel1.Controls.Add(LabelFiltro)
        Panel1.Location = New Point(32, 521)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1218, 372)
        Panel1.TabIndex = 65
        ' 
        ' TextBoxBusquedad
        ' 
        TextBoxBusquedad.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxBusquedad.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxBusquedad.Location = New Point(612, 6)
        TextBoxBusquedad.Name = "TextBoxBusquedad"
        TextBoxBusquedad.Size = New Size(245, 27)
        TextBoxBusquedad.TabIndex = 75
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(573, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 32)
        Label1.TabIndex = 65
        Label1.Text = "🔎"
        ' 
        ' PanelBotones
        ' 
        PanelBotones.Controls.Add(BtnEliminar)
        PanelBotones.Controls.Add(BtnActualizar)
        PanelBotones.Controls.Add(BtnNuevaCarrera)
        PanelBotones.Location = New Point(109, 180)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(425, 203)
        PanelBotones.TabIndex = 69
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnEliminar.FlatAppearance.BorderSize = 0
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnEliminar.ForeColor = Color.FromArgb(CByte(255), CByte(176), CByte(176))
        BtnEliminar.Location = New Point(23, 118)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(369, 68)
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
        BtnActualizar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnActualizar.ForeColor = Color.White
        BtnActualizar.Location = New Point(225, 23)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(167, 68)
        BtnActualizar.TabIndex = 49
        BtnActualizar.Text = "✏️" & vbCrLf & "Actualizar"
        BtnActualizar.UseVisualStyleBackColor = False
        ' 
        ' BtnNuevaCarrera
        ' 
        BtnNuevaCarrera.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        BtnNuevaCarrera.Cursor = Cursors.Hand
        BtnNuevaCarrera.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnNuevaCarrera.FlatAppearance.BorderSize = 0
        BtnNuevaCarrera.FlatStyle = FlatStyle.Flat
        BtnNuevaCarrera.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNuevaCarrera.ForeColor = Color.FromArgb(CByte(189), CByte(255), CByte(221))
        BtnNuevaCarrera.Location = New Point(23, 23)
        BtnNuevaCarrera.Name = "BtnNuevaCarrera"
        BtnNuevaCarrera.Size = New Size(169, 68)
        BtnNuevaCarrera.TabIndex = 48
        BtnNuevaCarrera.Text = "➕" & vbCrLf & " Nuevo"
        BtnNuevaCarrera.UseVisualStyleBackColor = False
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.Controls.Add(TextBoxUbicacion)
        panelIngresoDatos2.Controls.Add(Label4)
        panelIngresoDatos2.Controls.Add(ListaEstado)
        panelIngresoDatos2.Controls.Add(Label2)
        panelIngresoDatos2.Controls.Add(ListaTipo)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(BtnIngresar)
        panelIngresoDatos2.Controls.Add(TextBoxObservacion)
        panelIngresoDatos2.Controls.Add(Label5)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(TextBoxNombre)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Location = New Point(90, 81)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(728, 408)
        panelIngresoDatos2.TabIndex = 70
        panelIngresoDatos2.Visible = False
        ' 
        ' TextBoxUbicacion
        ' 
        TextBoxUbicacion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxUbicacion.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxUbicacion.Location = New Point(259, 199)
        TextBoxUbicacion.Name = "TextBoxUbicacion"
        TextBoxUbicacion.Size = New Size(430, 30)
        TextBoxUbicacion.TabIndex = 54
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label4.Location = New Point(259, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 27)
        Label4.TabIndex = 55
        Label4.Text = "Ubicación"
        ' 
        ' ListaEstado
        ' 
        ListaEstado.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaEstado.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaEstado.FormattingEnabled = True
        ListaEstado.Items.AddRange(New Object() {"En uso", "Disponible", "Reparación"})
        ListaEstado.Location = New Point(0, 199)
        ListaEstado.Name = "ListaEstado"
        ListaEstado.Size = New Size(206, 33)
        ListaEstado.TabIndex = 51
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(3, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 27)
        Label2.TabIndex = 50
        Label2.Text = "Estado"
        ' 
        ' ListaTipo
        ' 
        ListaTipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaTipo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaTipo.FormattingEnabled = True
        ListaTipo.Items.AddRange(New Object() {"Recurso", "Equipo"})
        ListaTipo.Location = New Point(0, 65)
        ListaTipo.Name = "ListaTipo"
        ListaTipo.Size = New Size(206, 33)
        ListaTipo.TabIndex = 49
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
        BtnVolver.Location = New Point(605, 306)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(84, 68)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnIngresar.Cursor = Cursors.Hand
        BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresar.FlatAppearance.BorderSize = 0
        BtnIngresar.FlatStyle = FlatStyle.Flat
        BtnIngresar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresar.ForeColor = Color.White
        BtnIngresar.Location = New Point(420, 306)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(179, 68)
        BtnIngresar.TabIndex = 47
        BtnIngresar.Text = "Actualizar Datos"
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxObservacion
        ' 
        TextBoxObservacion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxObservacion.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxObservacion.Location = New Point(3, 306)
        TextBoxObservacion.Multiline = True
        TextBoxObservacion.Name = "TextBoxObservacion"
        TextBoxObservacion.Size = New Size(380, 71)
        TextBoxObservacion.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label5.Location = New Point(2, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 27)
        Label5.TabIndex = 20
        Label5.Text = "Observación"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label6.Location = New Point(3, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 27)
        Label6.TabIndex = 16
        Label6.Text = "Categoría"
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxNombre.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxNombre.Location = New Point(259, 65)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(430, 30)
        TextBoxNombre.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(259, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 27)
        Label7.TabIndex = 18
        Label7.Text = "Nombre"
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(TextBoxId)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Location = New Point(112, 199)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(425, 96)
        PanelSelecion.TabIndex = 71
        PanelSelecion.Visible = False
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
        BtnSalirSeleccion.Location = New Point(358, 35)
        BtnSalirSeleccion.Name = "BtnSalirSeleccion"
        BtnSalirSeleccion.Size = New Size(50, 50)
        BtnSalirSeleccion.TabIndex = 58
        BtnSalirSeleccion.Text = "🔙"
        BtnSalirSeleccion.UseVisualStyleBackColor = False
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxId.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxId.Location = New Point(10, 47)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(242, 30)
        TextBoxId.TabIndex = 56
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSeleccionar.Cursor = Cursors.Hand
        BtnSeleccionar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSeleccionar.FlatAppearance.BorderSize = 0
        BtnSeleccionar.FlatStyle = FlatStyle.Flat
        BtnSeleccionar.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSeleccionar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSeleccionar.Location = New Point(265, 35)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(87, 50)
        BtnSeleccionar.TabIndex = 55
        BtnSeleccionar.Text = "✓"
        BtnSeleccionar.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(10, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 27)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' PanelEliminación
        ' 
        PanelEliminación.BackColor = Color.White
        PanelEliminación.BackgroundImage = My.Resources.Resources.FONDO_ELIMINACIÓN_INVENTARIO
        PanelEliminación.Controls.Add(BtnAceptarEliminacion)
        PanelEliminación.Controls.Add(BtnCancelar)
        PanelEliminación.Controls.Add(LabelMensaje)
        PanelEliminación.Location = New Point(37, 78)
        PanelEliminación.Name = "PanelEliminación"
        PanelEliminación.Size = New Size(1196, 424)
        PanelEliminación.TabIndex = 72
        PanelEliminación.Visible = False
        ' 
        ' BtnAceptarEliminacion
        ' 
        BtnAceptarEliminacion.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnAceptarEliminacion.Cursor = Cursors.Hand
        BtnAceptarEliminacion.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnAceptarEliminacion.FlatAppearance.BorderSize = 0
        BtnAceptarEliminacion.FlatStyle = FlatStyle.Flat
        BtnAceptarEliminacion.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAceptarEliminacion.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnAceptarEliminacion.Location = New Point(620, 183)
        BtnAceptarEliminacion.Name = "BtnAceptarEliminacion"
        BtnAceptarEliminacion.Size = New Size(187, 41)
        BtnAceptarEliminacion.TabIndex = 66
        BtnAceptarEliminacion.Text = "Aceptar"
        BtnAceptarEliminacion.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        BtnCancelar.Cursor = Cursors.Hand
        BtnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(807, 183)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(187, 41)
        BtnCancelar.TabIndex = 65
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' LabelMensaje
        ' 
        LabelMensaje.AutoSize = True
        LabelMensaje.BackColor = Color.White
        LabelMensaje.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMensaje.ForeColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        LabelMensaje.Location = New Point(535, 116)
        LabelMensaje.Name = "LabelMensaje"
        LabelMensaje.Padding = New Padding(20, 5, 20, 5)
        LabelMensaje.Size = New Size(596, 45)
        LabelMensaje.TabIndex = 63
        LabelMensaje.Text = "¿ Seguro quieres eliminar el Registro #1 ?" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.ACTUALIZAR
        PictureBox1.Location = New Point(700, 80)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(465, 352)
        PictureBox1.TabIndex = 73
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(984, -5)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 68)
        Button1.TabIndex = 74
        Button1.Text = "📩"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Inventario
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 916)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(PanelBotones)
        Controls.Add(panelIngresoDatos2)
        Controls.Add(PanelSelecion)
        Controls.Add(PanelEliminación)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventario"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelBotones.ResumeLayout(False)
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        PanelEliminación.ResumeLayout(False)
        PanelEliminación.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents listaMostrar As ComboBox
    Friend WithEvents LabelFiltro As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusquedad As TextBox
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnNuevaCarrera As Button
    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents TextBoxUbicacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListaEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListaTipo As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TextBoxObservacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents BtnSalirSeleccion As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelEliminación As Panel
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAceptarEliminacion As Button
    Friend WithEvents Button1 As Button
End Class
