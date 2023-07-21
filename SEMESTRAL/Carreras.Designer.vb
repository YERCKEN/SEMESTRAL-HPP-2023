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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        PanelBotones = New Panel()
        BtnEliminar = New Button()
        BtnActualizar = New Button()
        BtnNuevaCarrera = New Button()
        PanelNuevaCarrera = New Panel()
        BtnSalirDeNuevaCarrera = New Button()
        PanelNuevoAutor = New Panel()
        textBoxAutor = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        listaFacultad = New ComboBox()
        Label4 = New Label()
        btnIngresar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelBotones.SuspendLayout()
        PanelNuevaCarrera.SuspendLayout()
        PanelNuevoAutor.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
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
        DataGridView1.Location = New Point(67, 71)
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
        DataGridView1.Size = New Size(572, 404)
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
        BtnNuevaCarrera.ForeColor = Color.FromArgb(CByte(255), CByte(230), CByte(133))
        BtnNuevaCarrera.Location = New Point(23, 23)
        BtnNuevaCarrera.Name = "BtnNuevaCarrera"
        BtnNuevaCarrera.Size = New Size(169, 68)
        BtnNuevaCarrera.TabIndex = 48
        BtnNuevaCarrera.Text = "➕" & vbCrLf & " Nueva"
        BtnNuevaCarrera.UseVisualStyleBackColor = False
        ' 
        ' PanelNuevaCarrera
        ' 
        PanelNuevaCarrera.Controls.Add(BtnSalirDeNuevaCarrera)
        PanelNuevaCarrera.Controls.Add(PanelNuevoAutor)
        PanelNuevaCarrera.Controls.Add(Panel1)
        PanelNuevaCarrera.Controls.Add(btnIngresar)
        PanelNuevaCarrera.Location = New Point(698, 118)
        PanelNuevaCarrera.Name = "PanelNuevaCarrera"
        PanelNuevaCarrera.Size = New Size(535, 324)
        PanelNuevaCarrera.TabIndex = 69
        PanelNuevaCarrera.Visible = False
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
        ' PanelNuevoAutor
        ' 
        PanelNuevoAutor.Controls.Add(textBoxAutor)
        PanelNuevoAutor.Controls.Add(Label1)
        PanelNuevoAutor.Location = New Point(16, 122)
        PanelNuevoAutor.Name = "PanelNuevoAutor"
        PanelNuevoAutor.Size = New Size(507, 102)
        PanelNuevoAutor.TabIndex = 39
        ' 
        ' textBoxAutor
        ' 
        textBoxAutor.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        textBoxAutor.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        textBoxAutor.Location = New Point(0, 44)
        textBoxAutor.Name = "textBoxAutor"
        textBoxAutor.Size = New Size(504, 30)
        textBoxAutor.TabIndex = 13
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
        ' Panel1
        ' 
        Panel1.Controls.Add(listaFacultad)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(16, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(507, 87)
        Panel1.TabIndex = 45
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
        Controls.Add(PanelNuevaCarrera)
        Controls.Add(PanelBotones)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Carreras"
        Text = "Carreras"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelBotones.ResumeLayout(False)
        PanelNuevaCarrera.ResumeLayout(False)
        PanelNuevoAutor.ResumeLayout(False)
        PanelNuevoAutor.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnNuevaCarrera As Button
    Friend WithEvents PanelNuevaCarrera As Panel
    Friend WithEvents PanelNuevoAutor As Panel
    Friend WithEvents textBoxAutor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents listaFacultad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents BtnSalirDeNuevaCarrera As Button
End Class
