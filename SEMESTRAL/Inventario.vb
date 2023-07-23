Public Class Inventario

    'VARIABLES 
    Dim query As String = "ObtenerTodosLosRegistros"
    Dim querysBDYercken As New querysBDYercken()

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

        'OBTENER DATOS GRIDVIEW

        'CARGA DE DATOS
        DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)
        listaMostrar.Text = "Equipos & Recursos"

        'ESTILO DATAGRIDVIEW
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DataGridView1.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        DataGridView1.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns("Nombre").Width = 300

        DataGridView1.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns("Tipo").Width = 100

        DataGridView1.Columns("Ubicacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("Observaciones").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'DATA SIN EDITAR
        DataGridView1.ClearSelection()
        DataGridView1.ReadOnly = True


    End Sub

    Private Sub ListaMostrar_SelectedValueChanged(sender As Object, e As EventArgs) Handles listaMostrar.SelectedValueChanged



        If listaMostrar.Text = "Recursos" Then

            query = "ObtenerRegistrosTipoRecurso"
            DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)


        ElseIf listaMostrar.Text = "Equipos" Then

            query = "ObtenerRegistrosTipoEquipo"
            DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)

        ElseIf listaMostrar.Text = "Equipos & Recursos" Then

            Dim query As String = "ObtenerTodosLosRegistros"
            DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)

        End If

        ' Luego, quita el enfoque del listaFacultad moviéndolo al formulario
        Me.Focus()
        Me.SelectNextControl(listaMostrar, True, True, True, True)

    End Sub

End Class