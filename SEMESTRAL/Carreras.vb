Imports System.Data.SqlClient

Public Class Carreras

    'VARIABLES
    Dim querysBDYercken As New querysBDYercken()

    'VARIABLES DE BOTON NUEVA CARRERA
    Private originalSize As Size
    Private originalLocation As Point
    Private originalFont As Font


    Private Sub Carreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        originalSize = btnIngresar.Size
        originalLocation = btnIngresar.Location
        originalFont = btnIngresar.Font



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

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 196, 135)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 196, 135)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 196, 135)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 196, 135)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 196, 135)
        'CAMBIOS ESTILOS FORMS 2
        btnIngresar.BackColor = Color.FromArgb(0, 196, 135)

        'IMAGEN DE FONDO BOTON
        btnIngresar.BackgroundImage = My.Resources.BTN_VERDE_jpg



    End Sub
    Private Sub btnIngresar_MouseEnter(sender As Object, e As EventArgs) Handles btnIngresar.MouseEnter
        ' Cuando el mouse entra en el botón, aumentamos su tamaño y ajustamos su posición y fuente
        Dim growthFactor As Integer = 10 ' Puedes ajustar este valor según tus preferencias

        ' Calculamos el nuevo tamaño del botón
        Dim newSize As Size = New Size(originalSize.Width + growthFactor, originalSize.Height + growthFactor)
        ' Calculamos la nueva posición del botón para que quede centrado
        Dim newPosition As Point = New Point(originalLocation.X - growthFactor \ 2, originalLocation.Y - growthFactor \ 2)

        ' Calculamos la nueva fuente del botón con un tamaño mayor
        Dim newFont As Font = New Font(originalFont.FontFamily, originalFont.Size + growthFactor / 10)

        btnIngresar.Size = newSize
        btnIngresar.Location = newPosition
        btnIngresar.Font = newFont
    End Sub

    Private Sub btnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles btnIngresar.MouseLeave
        ' Cuando el mouse sale del botón, restauramos su tamaño, posición y fuente original
        btnIngresar.Size = originalSize
        btnIngresar.Location = originalLocation
        btnIngresar.Font = originalFont
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