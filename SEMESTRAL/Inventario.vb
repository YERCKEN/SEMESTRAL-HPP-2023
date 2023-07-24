Public Class Inventario

    'VARIABLES 
    Dim query As String = "ObtenerTodosLosRegistros"
    Dim querysBDYercken As New querysBDYercken()

    'VARIABLES DE BOTON NUEVA CARRERA
    Private originalSize As Size
    Private originalLocation As Point
    Private originalFont As Font
    Dim idBuscado As Integer


    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Location = New Point(Form1.Location.X, 30)
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1


        'PictureBox1.BackgroundImage = My.Resources.INVENTARIO

        'CRECIMIENTO DE BOTON
        originalSize = BtnIngresar.Size
        originalLocation = BtnIngresar.Location
        originalFont = BtnIngresar.Font
        'OBTENER DATOS GRIDVIEW

        'CARGA DE DATOS
        DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)
        listaMostrar.Text = "Equipos & Recursos"





        'ESTILO DATAGRIDVIEW
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'DataGridView1.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns("Nombre").Width = 250

        DataGridView1.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ''DataGridView1.Columns("Tipo").Width = 100

        'DataGridView1.Columns("Ubicacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'DataGridView1.Columns("Observaciones").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        'DataGridView1.Columns("Fecha").HeaderText = "Fecha"
        'DataGridView1.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        'DATA SIN EDITAR
        DataGridView1.ClearSelection()
        DataGridView1.ReadOnly = True


        ' Configura la columna de observación como de varias líneas
        Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        cellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Observaciones").DefaultCellStyle = cellStyle


        'seleccion



        ' Configurar el DataGridView para permitir la selección de celdas
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect

        ' Suscribir el evento CellClick al control DataGridView
        AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellClick

    End Sub


    Private Sub btnIngresar_MouseEnter(sender As Object, e As EventArgs) Handles BtnIngresar.MouseEnter
        ' Cuando el mouse entra en el botón, aumentamos su tamaño y ajustamos su posición y fuente
        Dim growthFactor As Integer = 10 ' Puedes ajustar este valor según tus preferencias

        ' Calculamos el nuevo tamaño del botón
        Dim newSize As Size = New Size(originalSize.Width + growthFactor, originalSize.Height + growthFactor)
        ' Calculamos la nueva posición del botón para que quede centrado
        Dim newPosition As Point = New Point(originalLocation.X - growthFactor \ 2, originalLocation.Y - growthFactor \ 2)

        ' Calculamos la nueva fuente del botón con un tamaño mayor
        Dim newFont As Font = New Font(originalFont.FontFamily, originalFont.Size + growthFactor / 10)

        BtnIngresar.Size = newSize
        BtnIngresar.Location = newPosition
        BtnIngresar.Font = newFont
    End Sub

    Private Sub btnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles BtnIngresar.MouseLeave
        ' Cuando el mouse sale del botón, restauramos su tamaño, posición y fuente original
        BtnIngresar.Size = originalSize
        BtnIngresar.Location = originalLocation
        BtnIngresar.Font = originalFont
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

    'TEXTBOX BUSQUEDAD ====================================================================================================

    Private Sub TextBoxBusquedad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusquedad.TextChanged
        ' Obtener el texto ingresado en el TextBox de búsqueda
        Dim filtro As String = TextBoxBusquedad.Text.Trim()

        ' Obtener la vista de la tabla de datos del DataGridView
        Dim vista As DataView = DirectCast(DataGridView1.DataSource, DataTable).DefaultView

        ' Aplicar el filtro al campo "usuario" en la vista de datos
        vista.RowFilter = $"Nombre LIKE '%{filtro}%'"
    End Sub

    Private Sub panelIngresoDatos2_Paint(sender As Object, e As PaintEventArgs) Handles panelIngresoDatos2.Paint

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        For Each fila As DataGridViewRow In DataGridView1.Rows
            fila.DefaultCellStyle.BackColor = Color.White
            fila.Selected = False
            fila.DefaultCellStyle.ForeColor = Color.FromArgb(120, 127, 130)
        Next

        ' Verificar que se haya hecho clic en una celda (y no en los encabezados de columna)
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then

            ' Obtener el valor de la celda de la columna "ID"
            Dim idValue As Object = DataGridView1.Rows(e.RowIndex).Cells("ID").Value

            ' Obtener la fila seleccionada
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Desmarcar cualquier fila previamente seleccionada
            DataGridView1.ClearSelection()

            ' Marcar la fila seleccionada de color amarillo

            If BtnIngresar.Text = "Eliminar" Then
                filaSeleccionada.DefaultCellStyle.BackColor = Color.FromArgb(250, 80, 80)
                filaSeleccionada.DefaultCellStyle.ForeColor = Color.White

            ElseIf BtnIngresar.Text = "Almacenar" Then
                filaSeleccionada.DefaultCellStyle.BackColor = Color.FromArgb(227, 252, 245)

            Else
                filaSeleccionada.DefaultCellStyle.BackColor = Color.FromArgb(240, 245, 252)
            End If

            ' Puedes usar el valor de la columna "ID" según tus necesidades
            ' Por ejemplo, mostrarlo en un TextBox:
            TextBoxId.Text = idValue.ToString()
        End If
    End Sub

    Private Sub BtnNuevaCarrera_Click(sender As Object, e As EventArgs) Handles BtnNuevaCarrera.Click
        'limpiar()
        'PanelNuevaCarrera.Visible = True
        'PanelBotones.Visible = False
        'PanelFacultad.Visible = True
        'PanelNombre.Visible = True
        PanelSelecion.Visible = False
        'BtnIngresar.Visible = True
        'BtnSalirDeNuevaCarrera.Visible = True
        PanelBotones.Visible = False
        panelIngresoDatos2.Visible = True

        PictureBox1.Visible = False

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 196, 135)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 196, 135)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 196, 135)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 196, 135)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 196, 135)

        'IMAGEN DE FONDO BOTON
        BtnIngresar.Text = "Almacenar"
        BtnIngresar.BackgroundImage = My.Resources.BTN_VERDE_jpg


        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(227, 252, 245)



        ListaEstado.Items.Clear()
        ' Agrega nuevos valores a la lista desplegable
        ListaEstado.Items.Add("Disponible")
        ListaEstado.Items.Add("En uso")



        ListaEstado.Text = "Disponible"
        TextBoxUbicacion.Text = "Depósito"
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        TextBoxId.Text = ""
        'PanelNuevaCarrera.Visible = True
        PanelBotones.Visible = False

        'PanelFacultad.Visible = False
        'PanelNombre.Visible = False
        PanelSelecion.Visible = True
        'BtnSalirDeNuevaCarrera.Visible = False

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 116, 255)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 116, 255)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 116, 255)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 116, 255)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 116, 255)

        'IMAGEN DE FONDO BOTON
        BtnIngresar.Text = "Actualizar Datos"
        BtnIngresar.BackgroundImage = My.Resources.BTN_AZUL

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 252)

    End Sub


    'BTN NUEVA ELIMINAR =================================================================================================

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'limpiar()
        TextBoxId.Text = ""
        'PanelNuevaCarrera.Visible = True
        PanelBotones.Visible = False
        'PanelFacultad.Visible = False
        'PanelNombre.Visible = False

        PanelSelecion.Visible = True
        'BtnIngresar.Visible = False
        'BtnSalirDeNuevaCarrera.Visible = False

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(250, 80, 80)
        Form1.PictureBox1.BackColor = Color.FromArgb(250, 80, 80)
        Form1.LabelActividad.BackColor = Color.FromArgb(250, 80, 80)
        Form1.BtnMin.BackColor = Color.FromArgb(250, 80, 80)
        Form1.btnCerrar.BackColor = Color.FromArgb(250, 80, 80)



        'IMAGEN DE FONDO BOTON
        BtnIngresar.Text = "Eliminar"
        'BtnIngresar.BackgroundImage = My.Resources.BTN_ROJO

        PictureBox1.BackgroundImage = My.Resources.FONDO_ELIMINACIÓN_INVENTARIO_vcambiante

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White


    End Sub







    'salir de seleeción
    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        'PanelNuevaCarrera.Visible = False
        panelIngresoDatos2.Visible = False
        PanelSelecion.Visible = False

        PictureBox1.Visible = True

        festiloDelFormsStandar()
        PictureBox1.BackgroundImage = My.Resources.INVENTARIO


    End Sub


    'FUNCIÓN PARA OBTENER LA FILA DEL ID SELECCIONADO

    Private Function ObtenerFilaPorID(id As Integer) As DataGridViewRow
        ' Recorrer las filas del DataGridView para encontrar la que tenga el ID específico
        For Each fila As DataGridViewRow In DataGridView1.Rows
            ' Obtener el valor de la celda de la columna "ID" de la fila actual
            Dim idValue As Integer = Convert.ToInt32(fila.Cells("ID").Value)

            ' Verificar si el ID coincide con el ID buscado
            If idValue = id Then
                ' Devolver la fila encontrada
                Return fila
            End If
        Next

        ' Si no se encuentra una fila con el ID buscado, devolver Nothing
        Return Nothing
    End Function

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click



        ' Obtener el ID ingresado por el usuario desde el TextBox
        If Integer.TryParse(TextBoxId.Text, idBuscado) Then
            ' Buscar la fila en el DataGridView por el ID ingresado
            Dim filaEncontrada As DataGridViewRow = ObtenerFilaPorID(idBuscado)

            ' Si se encuentra la fila, mostrar sus datos en los TextBoxes
            If filaEncontrada IsNot Nothing Then
                ListaTipo.Text = filaEncontrada.Cells("Tipo").Value.ToString()
                TextBoxNombre.Text = filaEncontrada.Cells("Nombre").Value.ToString()
                TextBoxCantidad.Text = filaEncontrada.Cells("Cantidad").Value.ToString()
                ListaEstado.Text = filaEncontrada.Cells("Estado").Value.ToString()
                TextBoxUbicacion.Text = filaEncontrada.Cells("Ubicacion").Value.ToString()
                TextBoxObservacion.Text = filaEncontrada.Cells("Observaciones").Value.ToString()

                If BtnIngresar.Text = "Eliminar" Then

                    PanelEliminación.Visible = True
                    LabelMensaje.Text = "¿ Seguro quieres eliminar el Registro #" & idBuscado & " ?"

                    PanelSelecion.Visible = False

                    PictureBox1.Visible = False


                Else
                    'PANEL VISIBLE
                    panelIngresoDatos2.Visible = True
                    PanelSelecion.Visible = False
                    PictureBox1.Visible = False


                    ListaEstado.Items.Clear()
                    ' Agrega nuevos valores a la lista desplegable
                    ListaEstado.Items.Add("Disponible")
                    ListaEstado.Items.Add("En uso")
                    ListaEstado.Items.Add("Reparación")




                End If

            Else
                ' Si no se encuentra la fila, mostrar un mensaje de error
                MessageBox.Show("No se encontró ninguna fila con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            ' Si el ID ingresado no es un número válido, mostrar un mensaje de error
            MessageBox.Show("Ingrese un valor de ID válido (número entero).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        If BtnIngresar.Text = "Almacenar" Then
            festiloDelFormsStandar()
            PictureBox1.Visible = True
        Else
            PanelSelecion.Visible = True
            PictureBox1.Visible = True

        End If

        panelIngresoDatos2.Visible = False
        fLimpiezaDeFormulario()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        PanelEliminación.Visible = False
        PanelSelecion.Visible = True

    End Sub


    Sub fLimpiarEstiloDeLaTabla()
        For Each fila As DataGridViewRow In DataGridView1.Rows
            fila.DefaultCellStyle.BackColor = Color.White
            fila.Selected = False
            fila.DefaultCellStyle.ForeColor = Color.FromArgb(120, 127, 130)
        Next
    End Sub

    Sub festiloDelFormsStandar()
        PanelBotones.Visible = True


        fLimpiarEstiloDeLaTabla()
        BtnIngresar.Text = "Actualizar Datos"
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 252)

        'CAMBIOS ESTILOS FORMS 1
        Form1.Menu.BackColor = Color.FromArgb(0, 116, 255)
        Form1.PictureBox1.BackColor = Color.FromArgb(0, 116, 255)
        Form1.LabelActividad.BackColor = Color.FromArgb(0, 116, 255)
        Form1.BtnMin.BackColor = Color.FromArgb(0, 116, 255)
        Form1.btnCerrar.BackColor = Color.FromArgb(0, 116, 255)


        fLimpiarEstiloDeLaTabla()
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 252)
    End Sub


    'INGRESAR DATOS PARA ACTULIZAR Y ELIMINAR 
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        'INSERT
        If ListaTipo.Text = "" Then

            ListaTipo.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo no opcional vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListaTipo.BackColor = Color.White

        ElseIf TextBoxNombre.Text = "" Then

            TextBoxNombre.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo no opcional vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxNombre.BackColor = Color.White

        ElseIf TextBoxCantidad.Text = "" Then
            TextBoxCantidad.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo no opcional vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxCantidad.BackColor = Color.White
        ElseIf TextBoxUbicacion.Text = "" Then
            TextBoxUbicacion.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo no opcional vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxUbicacion.BackColor = Color.White


        Else

            If BtnIngresar.Text = "Almacenar" Then

                'REALIZAR INSERT
                querysBDYercken.InsertarInventario(ListaTipo.Text, TextBoxNombre.Text, TextBoxCantidad.Text, ListaEstado.Text, TextBoxUbicacion.Text, DateTime.Now.ToString("yyyy-MM-dd"), TextBoxObservacion.Text)
                DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)


                panelIngresoDatos2.Visible = False
                festiloDelFormsStandar()

            Else


                querysBDYercken.ActualizarInventario(idBuscado, ListaTipo.Text, TextBoxNombre.Text, CInt(TextBoxCantidad.Text), ListaEstado.Text, TextBoxUbicacion.Text, DateTime.Now, TextBoxObservacion.Text)
                DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)


                panelIngresoDatos2.Visible = False
                PanelSelecion.Visible = True
            End If



            PictureBox1.Visible = True
            fLimpiezaDeFormulario()
        End If



    End Sub


    Private Sub BtnAceptarEliminacion_Click(sender As Object, e As EventArgs) Handles BtnAceptarEliminacion.Click

        'ELIMINAR PAPA
        querysBDYercken.EliminarInventario(idBuscado)

        DataGridView1.DataSource = querysBDYercken.ObtenerDatosInventario(query)

        panelIngresoDatos2.Visible = False
        PanelSelecion.Visible = True
        PanelEliminación.Visible = False
        PictureBox1.Visible = True



    End Sub


    Sub fLimpiezaDeFormulario()
        ListaEstado.Text = ""
        ListaTipo.Text = ""
        TextBoxNombre.Text = ""
        TextBoxCantidad.Text = ""
        TextBoxUbicacion.Text = ""
        TextBoxObservacion.Text = ""
    End Sub



    Private Sub TextBoxCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxId.BackColor = Color.White

        End If
    End Sub

    Private Sub ListaEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListaEstado.KeyPress
        ' Cancelar la pulsación de tecla para evitar que el usuario escriba en la lista
        MessageBox.Show("La escritura sobre este campo está prohíbida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        e.Handled = True

    End Sub


    Private Sub ListaTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListaTipo.KeyPress
        ' Cancelar la pulsación de tecla para evitar que el usuario escriba en la lista
        MessageBox.Show("La escritura sobre este campo está prohíbida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        e.Handled = True
    End Sub

    Private Sub ListaTipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListaTipo.SelectedValueChanged
        ' Realiza alguna acción aquí en función del valor seleccionado si es necesario

        ' Luego, quita el enfoque del listaFacultad moviéndolo al formulario
        Me.Focus()
        Me.SelectNextControl(ListaTipo, True, True, True, True)
    End Sub

    Private Sub ListaEstado_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListaEstado.SelectedValueChanged
        ' Realiza alguna acción aquí en función del valor seleccionado si es necesario

        ' Luego, quita el enfoque del listaFacultad moviéndolo al formulario
        Me.Focus()
        Me.SelectNextControl(ListaEstado, True, True, True, True)
    End Sub



    'CONTROL


End Class