Imports System.Data.SqlClient

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

        'LISTA DE FACULTADES
        CargarFacultades()


    End Sub

    Private Sub BtnNuevaCarrera_Click(sender As Object, e As EventArgs) Handles BtnNuevaCarrera.Click
        PanelNuevaCarrera.Visible = True
        PanelBotones.Visible = False
    End Sub


    'LISTA DE FACULTADES ==================================================================================================================
    Private Sub listaFacultad_SelectedValueChanged(sender As Object, e As EventArgs) Handles listaFacultad.SelectedValueChanged
        ' Realiza alguna acción aquí en función del valor seleccionado si es necesario

        ' Luego, quita el enfoque del listaFacultad moviéndolo al formulario
        Me.Focus()
        Me.SelectNextControl(listaFacultad, True, True, True, True)
    End Sub

    'FUNCIÓN PARA CARGAR LA DROPLIST---------------------------------------
    Private Sub CargarFacultades()


        Using conexion As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)

            conexion.Open()

            Dim query As String = "SELECT NombreFacultad FROM Facultades"
            Dim command As New SqlCommand(query, conexion)

            Dim reader As SqlDataReader = command.ExecuteReader()
            listaFacultad.Items.Clear()

            While reader.Read()
                Dim name As String = reader.GetString(0)
                listaFacultad.Items.Add(name)
            End While

        End Using
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnSalirDeNuevaCarrera.Click
        PanelNuevaCarrera.Visible = False
    End Sub
End Class