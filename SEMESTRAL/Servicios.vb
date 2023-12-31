﻿Imports System.Data.SqlClient

Public Class Servicios
    Dim connectionString2 As String = VARIABLES_GLOBALES.cadenaConexion2
    Dim connectionString1 As String = VARIABLES_GLOBALES.cadenaConexion
    Private Sub Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Location = New Point(Form1.Location.X, 60)

        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        MostrarServicios()
        tipoCb.Items.Clear()
        tipoCb.Items.Add("Eventos especiales")
        tipoCb.Items.Add("Giras de promoción de carreras")
        tipoCb.Items.Add("Descuento de carreras")
        tipoCb.Items.Add("Atención al cliente")

        'ESTILO DATAGRIDVIEW
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'RENOMBRADO =============================================================================

        DataGridView1.Columns("id_Servicios").HeaderText = "ID"
        DataGridView1.Columns("id_Servicios").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("tipo").HeaderText = "Tipo"
        DataGridView1.Columns("evento").HeaderText = "Evento"
        DataGridView1.Columns("horainicio").HeaderText = "Hora de Inicio"
        DataGridView1.Columns("fechainicio").HeaderText = "F.Inicio"
        DataGridView1.Columns("fechafinal").HeaderText = "F.Final"
        DataGridView1.Columns("observacion").HeaderText = "Observacion"

        Me.BackgroundImage = My.Resources.fondoServicios_png
        'DATA SIN EDITAR
        DataGridView1.ClearSelection()
        DataGridView1.ReadOnly = True


    End Sub
    Private Sub MostrarServicios()
        Try
            ' Crear una nueva conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                ' Crear una nueva consulta SQL
                Dim query As String = "SELECT * FROM servicios"

                ' Crear un nuevo SqlDataAdapter para ejecutar la consulta
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Crear un nuevo DataTable para almacenar los datos
                    Dim table As New DataTable()

                    ' Llenar el DataTable con los datos de la consulta
                    adapter.Fill(table)

                    ' Configurar el DataGridView para mostrar los datos
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            ' Mostrar un mensaje si hay un error
            MessageBox.Show("Error al cargar los datos de los servicios: " & ex.Message)
        End Try
    End Sub
    Private Sub MostrarDatosServicio(id_servicio As Integer)
        Try
            ' Crear una nueva conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para obtener los datos del servicio filtrado por id_servicio
                Dim query As String = "SELECT tipo, evento, horainicio, fechainicio, fechafinal, observacion " &
                                  "FROM servicios " &
                                  "WHERE id_servicios = @servicioId"

                ' Crear un nuevo comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@servicioId", id_servicio)

                    ' Ejecutar el comando y leer los datos del servicio
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Mostrar los datos del servicio en los controles correspondientes
                            tipoCb.Text = reader("tipo").ToString()
                            eventoTb.Text = reader("evento").ToString()

                            Dim horaInicio As TimeSpan
                            If TimeSpan.TryParse(reader("horainicio").ToString(), horaInicio) Then
                                horaInicioDt.Value = DateTime.Today.Add(horaInicio)
                            End If

                            Dim fechaInicio As Date
                            If Date.TryParse(reader("fechainicio").ToString(), fechaInicio) Then
                                fechaInicioDt.Value = fechaInicio
                            End If

                            Dim fechaFinal As Date
                            If Date.TryParse(reader("fechafinal").ToString(), fechaFinal) Then
                                fechaFinalizacionDt.Value = fechaFinal
                            End If

                            observacionTb.Text = reader("observacion").ToString()
                        Else
                            ' Si no se encuentra el servicio, mostrar mensaje de error
                            MessageBox.Show("Servicio no encontrado.")
                        End If
                    End Using
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del servicio: " & ex.Message)
        End Try
    End Sub
    Private Function ExisteServicio() As Boolean
        Dim existe As Boolean = False
        Dim servicioId As Integer

        ' Intentar convertir el texto del TextBox a un entero
        If Integer.TryParse(idServicioTb.Text, servicioId) Then
            Try
                ' Crear una conexión a la base de datos
                Using connection As New SqlConnection(connectionString2)
                    connection.Open()

                    ' Consulta para verificar si existe el servicio
                    Dim query As String = "SELECT COUNT(*) " &
                                  "FROM servicios " &
                                  "WHERE id_servicios = @servicioId"

                    ' Crear un comando con la consulta y el parámetro proporcionado
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@servicioId", servicioId)

                        ' Ejecutar el comando y obtener el resultado
                        Dim count As Integer = CInt(cmd.ExecuteScalar())

                        ' Si count es mayor que 0, entonces el servicio existe
                        If count > 0 Then
                            existe = True
                        End If
                    End Using

                    ' Cerrar la conexión
                    connection.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al verificar la existencia del servicio: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor, introduce un ID de servicio válido.")
        End If

        Return existe
    End Function
    Private Sub ActualizarServicio()
        Try
            ' Verificar si las entradas son nulas o están vacías
            If String.IsNullOrEmpty(idServicioTb.Text) OrElse
           String.IsNullOrEmpty(tipoCb.Text) OrElse
           String.IsNullOrEmpty(eventoTb.Text) OrElse
           String.IsNullOrEmpty(horaInicioDt.Value.ToString()) OrElse
           String.IsNullOrEmpty(fechaInicioDt.Value.ToString()) OrElse
           String.IsNullOrEmpty(fechaFinalizacionDt.Value.ToString()) OrElse
           String.IsNullOrEmpty(observacionTb.Text) Then

                MessageBox.Show("Por favor asegúrese de que todos los campos están llenos.")
                Return
            End If
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para actualizar el servicio en la base de datos
                Dim query As String = "UPDATE servicios SET tipo = @tipo, evento = @evento, horainicio = @horainicio, fechainicio = @fechainicio, " &
                                  "fechafinal = @fechafinal, observacion = @observacion WHERE id_servicios = @servicioId"

                ' Crear un comando con la consulta y los parámetros proporcionados
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@servicioId", Integer.Parse(idServicioTb.Text))
                    cmd.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmd.Parameters.AddWithValue("@evento", eventoTb.Text)
                    cmd.Parameters.AddWithValue("@horainicio", horaInicioDt.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@fechainicio", fechaInicioDt.Value.Date)
                    cmd.Parameters.AddWithValue("@fechafinal", fechaFinalizacionDt.Value.Date)
                    cmd.Parameters.AddWithValue("@observacion", observacionTb.Text)

                    ' Ejecutar el comando para actualizar el servicio
                    cmd.ExecuteNonQuery()
                End Using

                ' Cerrar la conexión
                connection.Close()

                MessageBox.Show("Servicio actualizado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el servicio: " & ex.Message)
        End Try
    End Sub
    Private Sub CrearServicio()
        Try
            ' Verificar si las entradas son nulas o están vacías8
            If String.IsNullOrEmpty(tipoCb.Text) OrElse
           String.IsNullOrEmpty(eventoTb.Text) OrElse
           String.IsNullOrEmpty(horaInicioDt.Value.ToString()) OrElse
           String.IsNullOrEmpty(fechaInicioDt.Value.ToString()) OrElse
           String.IsNullOrEmpty(fechaFinalizacionDt.Value.ToString()) OrElse
           String.IsNullOrEmpty(observacionTb.Text) Then

                MessageBox.Show("Por favor asegúrese de que todos los campos están llenos.")
                Return
            End If
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para insertar un nuevo servicio en la base de datos
                Dim query As String = "INSERT INTO servicios (tipo, evento, horainicio, fechainicio, fechafinal, observacion) " &
                                  "VALUES (@tipo, @evento, @horainicio, @fechainicio, @fechafinal, @observacion)"

                ' Crear un comando con la consulta y los parámetros proporcionados
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmd.Parameters.AddWithValue("@evento", eventoTb.Text)
                    cmd.Parameters.AddWithValue("@horainicio", horaInicioDt.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@fechainicio", fechaInicioDt.Value.Date)
                    cmd.Parameters.AddWithValue("@fechafinal", fechaFinalizacionDt.Value.Date)
                    cmd.Parameters.AddWithValue("@observacion", observacionTb.Text)

                    ' Ejecutar el comando para insertar el nuevo servicio
                    cmd.ExecuteNonQuery()
                End Using

                ' Cerrar la conexión
                connection.Close()

                MessageBox.Show("Nuevo servicio creado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al crear el servicio: " & ex.Message)
        End Try
    End Sub
    Private Sub EliminarServicio(id_servicio As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para eliminar el servicio de la base de datos
                Dim query As String = "DELETE FROM servicios WHERE id_servicios = @servicioId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@servicioId", id_servicio)

                    ' Ejecutar el comando para eliminar el servicio
                    cmd.ExecuteNonQuery()
                End Using

                ' Cerrar la conexión
                connection.Close()

                MessageBox.Show("Servicio eliminado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el servicio: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim servicioId As Integer
        ' Intentar convertir el texto del TextBox a un número entero
        If Integer.TryParse(idServicioTb.Text, servicioId) Then
            ' Si la conversión es exitosa, utilizar la función ExisteProveedor para verificar si el proveedor existe
            If ExisteServicio() Then
                MostrarDatosServicio(servicioId)
                panelIngresoDatos2.Visible = True
                PanelSelecion.Visible = False
                BtnactualizarNuevoTicket.Visible = True
                BtnNuevoTicket.Visible = False

                Me.BackgroundImage = My.Resources.fondoServicios_png2

            Else
                MessageBox.Show("El servicio no existe.")
            End If
        Else
            MessageBox.Show("Por favor, introduce un número válido para el ID del servicio.")
        End If
    End Sub
    Private Sub btnselecccionarElimina_Click(sender As Object, e As EventArgs) Handles btnselecccionarElimina.Click
        Dim servicioId As Integer
        ' Intentar convertir el texto del TextBox a un número entero
        If Integer.TryParse(idServicioTb.Text, servicioId) Then
            ' Si la conversión es exitosa, utilizar la función ExisteProveedor para verificar si el proveedor existe
            If ExisteServicio() Then
                EliminarServicio(servicioId)
                MostrarServicios()
                PanelSelecion.Visible = False
                PanelBotones.Visible = True

            Else
                MessageBox.Show("El servicio no existe.")
            End If
        Else
            MessageBox.Show("Por favor, introduce un número válido para el ID del servicio.")
        End If
    End Sub
    Private Sub actualizarBtn_Click(sender As Object, e As EventArgs) Handles actualizarBtn.Click
        PanelSelecion.Visible = True
        PanelBotones.Visible = False
        btnselecccionarElimina.Visible = False
        BtnSeleccionar.Visible = True
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        PanelSelecion.Visible = True
        PanelBotones.Visible = False
        btnselecccionarElimina.Visible = True
        BtnSeleccionar.Visible = False
        MostrarServicios()
    End Sub

    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        idServicioTb.Clear()
        PanelBotones.Visible = True
        PanelSelecion.Visible = False
        Me.BackgroundImage = My.Resources.fondoServicios_png

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        idServicioTb.Clear()
        panelIngresoDatos2.Visible = False
        PanelBotones.Visible = True

        Me.BackgroundImage = My.Resources.fondoServicios_png
    End Sub

    Private Sub crearBtn_Click(sender As Object, e As EventArgs) Handles crearBtn.Click
        panelIngresoDatos2.Visible = True
        PanelBotones.Visible = False
        BtnactualizarNuevoTicket.Visible = False
        BtnNuevoTicket.Visible = True

        Me.BackgroundImage = My.Resources.fondoServicios_png2

        eventoTb.Clear()
        observacionTb.Clear()
        tipoCb.SelectedIndex = -1

    End Sub

    Private Sub BtnNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnNuevoTicket.Click
        CrearServicio()
        MostrarServicios()
        panelIngresoDatos2.Visible = False
        PanelBotones.Visible = True

        Me.BackgroundImage = My.Resources.fondoServicios_png

    End Sub

    Private Sub BtnactualizarNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnactualizarNuevoTicket.Click
        ActualizarServicio()
        MostrarServicios()
        panelIngresoDatos2.Visible = False
        PanelBotones.Visible = True

        Me.BackgroundImage = My.Resources.fondoServicios_png
    End Sub


    Private Sub tipoCb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipoCb.KeyPress
        ' Cancelar la pulsación de tecla para evitar que el usuario escriba en la lista
        MessageBox.Show("La escritura sobre este campo está prohíbida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        e.Handled = True
    End Sub


    'marcar Aproximacin

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting


        If PanelBotones IsNot Nothing Then

            If DataGridView1.Columns(e.ColumnIndex).Name = "fechainicio" Then
                Dim value = e.Value

                If Not DBNull.Value.Equals(value) Then
                    Dim fechaFinalizacion As Date = CDate(value)
                    Dim diasRestantes As Integer = (fechaFinalizacion - DateTime.Now).Days


                    ' Verificar si la fecha de finalización está próxima
                    ' Verificar si la fecha de finalización está próxima
                    If diasRestantes = 0 Then
                        ' MsgBox(diasRestantes)
                        e.CellStyle.BackColor = Color.FromArgb(255, 222, 222)
                        e.CellStyle.ForeColor = Color.Red

                        'MsgBox("Tikets con fecha de finalizacuón hoy")

                    ElseIf diasRestantes <= 3 Then
                        ' MsgBox(diasRestantes)
                        e.CellStyle.BackColor = Color.FromArgb(255, 222, 222)
                        e.CellStyle.ForeColor = Color.Red

                    ElseIf diasRestantes <= 5 And diasRestantes > 3 Then
                        'MsgBox(diasRestantes)

                        e.CellStyle.BackColor = Color.FromArgb(255, 234, 222)


                    ElseIf diasRestantes <= 7 And diasRestantes > 5 Then
                        ' MsgBox(diasRestantes)

                        e.CellStyle.BackColor = Color.FromArgb(255, 252, 222)

                    ElseIf diasRestantes <= 20 And diasRestantes > 7 Then
                        ' MsgBox(diasRestantes)

                        e.CellStyle.BackColor = Color.FromArgb(234, 255, 222)

                    End If

                End If
            End If
        End If
    End Sub





End Class