<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carreras
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
        PanelBotones = New Panel()
        BtnEliminar = New Button()
        BtnActualizar = New Button()
        BtnNuevaCarrera = New Button()
        PanelNuevaCarrera = New Panel()
        PanelSelecion = New Panel()
        BtnSalirSeleccion = New Button()
        TextBoxId = New TextBox()
        BtnSeleccionar = New Button()
        Label9 = New Label()
        BtnSalirDeNuevaCarrera = New Button()
        PanelNombre = New Panel()
        textBoxNombre = New TextBox()
        Label1 = New Label()
        PanelFacultad = New Panel()
        listaFacultad = New ComboBox()
        Label4 = New Label()
        btnIngresar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelBotones.SuspendLayout()
        PanelNuevaCarrera.SuspendLayout()
        PanelSelecion.SuspendLayout()
        PanelNombre.SuspendLayout()
        PanelFacultad.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
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
        DataGridView1.Location = New Point(67, 52)
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
        DataGridView1.Size = New Size(572, 436)
        DataGridView1.TabIndex = 5
        ' 
        ' PanelBotones
        ' 
        PanelBotones.Controls.Add(BtnEliminar)
        PanelBotones.Controls.Add(BtnActualizar)
        PanelBotones.Controls.Add(BtnNuevaCarrera)
        PanelBotones.Location = New Point(760, 71)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(425, 203)
        PanelBotones.TabIndex = 68
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
        BtnNuevaCarrera.Text = "➕" & vbCrLf & " Nueva"
        BtnNuevaCarrera.UseVisualStyleBackColor = False
        ' 
        ' PanelNuevaCarrera
        ' 
        PanelNuevaCarrera.Controls.Add(PanelSelecion)
        PanelNuevaCarrera.Controls.Add(BtnSalirDeNuevaCarrera)
        PanelNuevaCarrera.Controls.Add(PanelNombre)
        PanelNuevaCarrera.Controls.Add(PanelFacultad)
        PanelNuevaCarrera.Controls.Add(btnIngresar)
        PanelNuevaCarrera.Location = New Point(698, 118)
        PanelNuevaCarrera.Name = "PanelNuevaCarrera"
        PanelNuevaCarrera.Size = New Size(535, 324)
        PanelNuevaCarrera.TabIndex = 69
        PanelNuevaCarrera.Visible = False
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(TextBoxId)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Location = New Point(0, 29)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(535, 96)
        PanelSelecion.TabIndex = 70
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
        BtnSalirSeleccion.Location = New Point(421, 35)
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
        TextBoxId.Location = New Point(73, 47)
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
        BtnSeleccionar.Location = New Point(328, 35)
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
        Label9.Location = New Point(73, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 27)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' BtnSalirDeNuevaCarrera
        ' 
        BtnSalirDeNuevaCarrera.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSalirDeNuevaCarrera.Cursor = Cursors.Hand
        BtnSalirDeNuevaCarrera.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSalirDeNuevaCarrera.FlatAppearance.BorderSize = 0
        BtnSalirDeNuevaCarrera.FlatStyle = FlatStyle.Flat
        BtnSalirDeNuevaCarrera.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSalirDeNuevaCarrera.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSalirDeNuevaCarrera.Location = New Point(433, 244)
        BtnSalirDeNuevaCarrera.Name = "BtnSalirDeNuevaCarrera"
        BtnSalirDeNuevaCarrera.Size = New Size(87, 51)
        BtnSalirDeNuevaCarrera.TabIndex = 49
        BtnSalirDeNuevaCarrera.Text = "🔙"
        BtnSalirDeNuevaCarrera.UseVisualStyleBackColor = False
        ' 
        ' PanelNombre
        ' 
        PanelNombre.Controls.Add(textBoxNombre)
        PanelNombre.Controls.Add(Label1)
        PanelNombre.Location = New Point(16, 122)
        PanelNombre.Name = "PanelNombre"
        PanelNombre.Size = New Size(507, 102)
        PanelNombre.TabIndex = 39
        ' 
        ' textBoxNombre
        ' 
        textBoxNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        textBoxNombre.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        textBoxNombre.Location = New Point(0, 44)
        textBoxNombre.Name = "textBoxNombre"
        textBoxNombre.Size = New Size(504, 30)
        textBoxNombre.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(2, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 27)
        Label1.TabIndex = 17
        Label1.Text = "Nombre "
        ' 
        ' PanelFacultad
        ' 
        PanelFacultad.Controls.Add(listaFacultad)
        PanelFacultad.Controls.Add(Label4)
        PanelFacultad.Location = New Point(16, 14)
        PanelFacultad.Name = "PanelFacultad"
        PanelFacultad.Size = New Size(507, 81)
        PanelFacultad.TabIndex = 45
        ' 
        ' listaFacultad
        ' 
        listaFacultad.AutoCompleteMode = AutoCompleteMode.Suggest
        listaFacultad.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        listaFacultad.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        listaFacultad.FormattingEnabled = True
        listaFacultad.Location = New Point(0, 46)
        listaFacultad.Name = "listaFacultad"
        listaFacultad.Size = New Size(504, 33)
        listaFacultad.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label4.Location = New Point(3, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 27)
        Label4.TabIndex = 42
        Label4.Text = "Facultad"
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.FromArgb(CByte(0), CByte(116), CByte(255))
        btnIngresar.BackgroundImage = My.Resources.Resources.BTN_AZUL
        btnIngresar.Cursor = Cursors.Hand
        btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(19, 244)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(408, 51)
        btnIngresar.TabIndex = 44
        btnIngresar.Text = "Agregar Carrera"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' Carreras
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 520)
        Controls.Add(DataGridView1)
        Controls.Add(PanelNuevaCarrera)
        Controls.Add(PanelBotones)
        FormBorderStyle = FormBorderStyle.None
        Name = "Carreras"
        Text = "Carreras"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelBotones.ResumeLayout(False)
        PanelNuevaCarrera.ResumeLayout(False)
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        PanelNombre.ResumeLayout(False)
        PanelNombre.PerformLayout()
        PanelFacultad.ResumeLayout(False)
        PanelFacultad.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnNuevaCarrera As Button
    Friend WithEvents PanelNuevaCarrera As Panel
    Friend WithEvents PanelNombre As Panel
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFacultad As Panel
    Friend WithEvents listaFacultad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents BtnSalirDeNuevaCarrera As Button
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSalirSeleccion As Button
End Class
