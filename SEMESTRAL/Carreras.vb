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

    'BTN NUEVA CARRERA =================================================================================================
    Private Sub BtnNuevaCarrera_Click(sender As Object, e As EventArgs) Handles BtnNuevaCarrera.Click
        limpiar()
        PanelNuevaCarrera.Visible = True
        PanelBotones.Visible = False
        PanelFacultad.Visible = True
        PanelNombre.Visible = True
        PanelSelecion.Visible = False
        btnIngresar.Visible = True
        BtnSalirDeNuevaCarrera.Visible = True


        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 196, 135)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 196, 135)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 196, 135)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 196, 135)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 196, 135)

        'IMAGEN DE FONDO BOTON
        btnIngresar.Text = "Agregar Carrera"
        btnIngresar.BackgroundImage = My.Resources.BTN_VERDE_jpg


    End Sub

    'BTN NUEVA ELIMINAR =================================================================================================

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        limpiar()
        TextBoxId.Text = ""
        PanelNuevaCarrera.Visible = True
        PanelBotones.Visible = False
        PanelFacultad.Visible = False
        PanelNombre.Visible = False

        PanelSelecion.Visible = True
        btnIngresar.Visible = False
        BtnSalirDeNuevaCarrera.Visible = False

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(250, 80, 80)
        Form1.PictureBox1.BackColor = Color.FromArgb(250, 80, 80)
        Form1.LabelActividad.BackColor = Color.FromArgb(250, 80, 80)
        Form1.BtnMin.BackColor = Color.FromArgb(250, 80, 80)
        Form1.btnCerrar.BackColor = Color.FromArgb(250, 80, 80)

        'IMAGEN DE FONDO BOTON
        btnIngresar.Text = "Eliminar Carrera"
        btnIngresar.BackgroundImage = My.Resources.BTN_ROJO

    End Sub

    'BTN VOLVER =================================================================================================

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnSalirDeNuevaCarrera.Click

        PanelNuevaCarrera.Visible = False
        PanelBotones.Visible = True

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 116, 255)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 116, 255)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 116, 255)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 116, 255)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 116, 255)

        For Each fila As DataGridViewRow In DataGridView1.Rows
            fila.DefaultCellStyle.BackColor = DataGridView1.DefaultCellStyle.BackColor ' Establecer el color de fondo predeterminado del DataGridView
        Next

    End Sub


    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        PanelNuevaCarrera.Visible = False
        PanelBotones.Visible = True

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 116, 255)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 116, 255)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 116, 255)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 116, 255)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 116, 255)


        For Each fila As DataGridViewRow In DataGridView1.Rows
            fila.DefaultCellStyle.BackColor = DataGridView1.DefaultCellStyle.BackColor ' Establecer el color de fondo predeterminado del DataGridView
        Next

    End Sub
    'ACTUALIZAR =================================================================================================

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        TextBoxId.Text = ""
        PanelNuevaCarrera.Visible = True
        PanelBotones.Visible = False

        PanelFacultad.Visible = False
        PanelNombre.Visible = False
        PanelSelecion.Visible = True
        btnIngresar.Visible = False
        BtnSalirDeNuevaCarrera.Visible = False

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 116, 255)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 116, 255)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 116, 255)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 116, 255)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 116, 255)

        'IMAGEN DE FONDO BOTON
        btnIngresar.Text = "Actualizar Carrera"
        btnIngresar.BackgroundImage = My.Resources.BTN_AZUL
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

    Sub limpiar()
        listaFacultad.Text = ""
        textBoxNombre.Text = ""
    End Sub



    'CONFIRMAR =============================================================================
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        'CONTROL ------------------------------------------------------------
        If btnIngresar.Text = "Eliminar Carrera" Then


            'ELIMINAR CARRERA =================================================
            querysBDYercken.EliminarCarrera(TextBoxId.Text)
            DataGridView1.DataSource = querysBDYercken.obtenerCarrerasConFacultades()

        ElseIf listaFacultad.Text = "Facultad de Ingeniería Civil" Or listaFacultad.Text = "Facultad de Ingeniería Industrial" Or listaFacultad.Text = "Facultad de Ingeniería Eléctrica" Or listaFacultad.Text = "Facultad de Ingeniería de Sistemas Computacionales" Or listaFacultad.Text = "Facultad de Ciencias y Tecnología" Then

            If textBoxNombre.Text <> "" Then

                'QUERYS -------------------------------------------------------------
                'AGREGAR CARRERA
                If btnIngresar.Text = "Agregar Carrera" Then


                    Dim carreraID As Integer = querysBDYercken.AgregarCarrera(textBoxNombre.Text)
                    Dim facultadID As Integer = querysBDYercken.ObtenerIdFacultad(listaFacultad.Text)

                    If carreraID <> -1 AndAlso facultadID <> -1 Then

                        querysBDYercken.RelacionarCarrerasFacultad(carreraID, facultadID)
                        MessageBox.Show("Carrera agregada y relacionada con la facultad correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DataGridView1.DataSource = querysBDYercken.obtenerCarrerasConFacultades()
                    Else
                        MessageBox.Show("ERROR: al agregar la carrera o relacionarla con la facultad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    'ACTULIZAR CARRERRA

                ElseIf btnIngresar.Text = "Actualizar Carrera" Then


                    querysBDYercken.ActualizarNombreCarrera(TextBoxId.Text, textBoxNombre.Text)
                    Dim facultadID As Integer = querysBDYercken.ObtenerIdFacultad(listaFacultad.Text)

                    If facultadID <> -1 Then
                        querysBDYercken.ActualizarFacultadID(TextBoxId.Text, facultadID)

                        MessageBox.Show("Los datos de la carrera fueron actualizados", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DataGridView1.DataSource = querysBDYercken.obtenerCarrerasConFacultades()

                    Else
                        MessageBox.Show("No se encontró la facultad con el nombre especificado.")
                    End If

                End If


            Else
                textBoxNombre.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textBoxNombre.BackColor = Color.White
            End If


        Else

            listaFacultad.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Facultad Inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            listaFacultad.BackColor = Color.White

        End If



    End Sub

    Private Sub TextBoxId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxId.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxId.BackColor = Color.White

        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        'SI NO ESTÁ VACÍO
        If TextBoxId.Text <> "" Then

            'CONTROL DETERMINAR SI EL ID EXISTE Y HACER EL UPDATE
            Dim idBuscado As Integer
            If Integer.TryParse(Convert.ToInt32(TextBoxId.Text), idBuscado) Then
                Dim existeId As Boolean = False

                ' Limpiar colores de fondo de todas las filas
                For Each fila As DataGridViewRow In DataGridView1.Rows
                    fila.DefaultCellStyle.BackColor = DataGridView1.DefaultCellStyle.BackColor ' Establecer el color de fondo predeterminado del DataGridView
                Next

                For Each fila As DataGridViewRow In DataGridView1.Rows
                    Dim valorCelda As Integer
                    If fila.Cells("ID").Value IsNot Nothing AndAlso Integer.TryParse(fila.Cells("ID").Value.ToString(), valorCelda) Then
                        If valorCelda = idBuscado Then
                            existeId = True

                            If btnIngresar.Text = "Eliminar Carrera" Then
                                fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 222, 222) ' Establecer el color de fondo de la fila encontrada

                            Else
                                fila.DefaultCellStyle.BackColor = Color.Yellow ' Establecer el color de fondo de la fila encontrada

                            End If

                            Exit For
                        End If
                    End If
                Next

                'SI EL ID EXISTE
                If existeId Then

                    If btnIngresar.Text = "Eliminar Carrera" Then
                        PanelFacultad.Visible = False
                        PanelNombre.Visible = False
                        PanelSelecion.Visible = True
                        btnIngresar.Visible = True
                        BtnSalirDeNuevaCarrera.Visible = True
                    Else

                        'ACTUALIZAR
                        Dim result = querysBDYercken.selectCarreraFacultad(TextBoxId.Text)

                        ' Mostrar los resultados en los TextBox correspondientes
                        textBoxNombre.Text = result.Item1
                        listaFacultad.Text = result.Item2

                        'VISIBLES
                        PanelFacultad.Visible = True
                        PanelNombre.Visible = True
                        PanelSelecion.Visible = False
                        btnIngresar.Visible = True
                        BtnSalirDeNuevaCarrera.Visible = True

                    End If



                Else
                    TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("ERROR: EL ID NO EXISTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBoxId.BackColor = Color.White
                End If


            End If
        Else
            TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: ID no especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxId.BackColor = Color.White
        End If
    End Sub


End Class


