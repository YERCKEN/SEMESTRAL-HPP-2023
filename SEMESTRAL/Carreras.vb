Public Class Carreras

    'VARIABLES
    Dim querysBDYercken As New querysBDYercken()
    Private Sub Carreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

        'LLENAR GRIDVIEW
        DataGridView1.DataSource = querysBDYercken.obtenerCarrerasConFacultades()

        'ESTILO DATAGRIDVIEW
        DataGridView1.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(1).Width = 572
        DataGridView1.Columns("NombreCarrera").HeaderText = "CARRERAS"

        DataGridView1.Columns("NombreFacultad").HeaderText = "FACULTADES"
        DataGridView1.Columns("NombreFacultad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        'DATA SIN EDITAR
        DataGridView1.ClearSelection()
        DataGridView1.ReadOnly = True




    End Sub


End Class