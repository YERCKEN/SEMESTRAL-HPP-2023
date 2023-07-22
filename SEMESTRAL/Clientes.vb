Imports System.Data.SqlClient

Public Class Clientes
    Dim conexion As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion2)

    Dim connectionString As String = VARIABLES_GLOBALES.cadenaConexion2
    Dim clienteId As Integer
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        MostrarClientes()
    End Sub
    Private Sub MostrarClientes()
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para obtener datos de las tablas clientes y clienteopciones
                Dim query As String = "SELECT c.id_clientes, c.nombre, c.apellido, c.residencia, c.lugar_trabajo, c.telefono1, c.telefono2, c.email, co.opcion1, co.opcion2, co.opcion3, co.convocatoria " &
                                      "FROM clientes c LEFT JOIN clienteopciones co ON c.id_clientes = co.id_cliente"

                ' Crear un adaptador para ejecutar la consulta y llenar un DataTable
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Asignar el DataTable al DataGridView
                    DataGridView1.DataSource = dt
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarClientes(id_clientes As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para obtener datos de las tablas clientes y clienteopciones filtrados por id_clientes
                Dim query As String = "SELECT c.id_clientes, c.nombre, c.apellido, c.residencia, c.lugar_trabajo, c.telefono1, c.telefono2, c.email, co.opcion1, co.opcion2, co.opcion3, co.convocatoria " &
                                      "FROM clientes c LEFT JOIN clienteopciones co ON c.id_clientes = co.id_cliente " &
                                      "WHERE c.id_clientes = @clienteId"

                ' Crear un adaptador para ejecutar la consulta y llenar un DataTable con el parámetro proporcionado
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@clienteId", id_clientes)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Asignar el DataTable al DataGridView
                    DataGridView1.DataSource = dt
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub MostrarDatosCliente(id_clientes As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para obtener los datos del cliente filtrado por id_clientes
                Dim query As String = "SELECT nombre, apellido, residencia, telefono1, telefono2, email, tipo, lugar_trabajo, convocatoria, opcion1, opcion2, opcion3, observacion " &
                                      "FROM clientes LEFT JOIN clienteopciones ON clientes.id_clientes = clienteopciones.id_cliente " &
                                      "WHERE clientes.id_clientes = @clienteId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@clienteId", id_clientes)

                    ' Ejecutar el comando y leer los datos del cliente
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Mostrar los datos del cliente en los controles correspondientes
                            nombreTb.Text = reader("nombre").ToString()
                            apellidoTb.Text = reader("apellido").ToString()
                            residenciatb.Text = reader("residencia").ToString()
                            telefono1Tb.Text = reader("telefono1").ToString()
                            telefono2Tb.Text = reader("telefono2").ToString()
                            emailTb.Text = reader("email").ToString()
                            tipoCb.Text = reader("tipo").ToString()
                            lugarTrabajoTb.Text = reader("lugar_trabajo").ToString()
                            convocatoriaCb.Text = reader("convocatoria").ToString()
                            Opcion1Cb.Text = reader("opcion1").ToString()
                            opcion2Cb.Text = reader("opcion2").ToString()
                            opcion3Cb.Text = reader("opcion3").ToString()
                            ObservacionTb.Text = reader("observacion").ToString()
                        Else
                            ' Si no se encuentra el cliente, mostrar mensaje de error
                            MessageBox.Show("Cliente no encontrado.")
                        End If
                    End Using
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub ActualizarDatosCliente(id_clientes As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para actualizar los datos del cliente en la base de datos
                Dim query As String = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, residencia = @residencia, " &
                                      "telefono1 = @telefono1, telefono2 = @telefono2, email = @email, tipo = @tipo, " &
                                      "lugar_trabajo = @lugar_trabajo, convocatoria = @convocatoria, opcion1 = @opcion1, " &
                                      "opcion2 = @opcion2, opcion3 = @opcion3, observacion = @observacion " &
                                      "WHERE id_clientes = @clienteId"

                ' Crear un comando con la consulta y los parámetros proporcionados
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@clienteId", id_clientes)
                    cmd.Parameters.AddWithValue("@nombre", nombreTb.Text)
                    cmd.Parameters.AddWithValue("@apellido", apellidoTb.Text)
                    cmd.Parameters.AddWithValue("@residencia", residenciatb.Text)
                    cmd.Parameters.AddWithValue("@telefono1", telefono1Tb.Text)
                    cmd.Parameters.AddWithValue("@telefono2", telefono2Tb.Text)
                    cmd.Parameters.AddWithValue("@email", emailTb.Text)
                    cmd.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmd.Parameters.AddWithValue("@lugar_trabajo", lugarTrabajoTb.Text)
                    cmd.Parameters.AddWithValue("@convocatoria", convocatoriaCb.Text)
                    cmd.Parameters.AddWithValue("@opcion1", Opcion1Cb.Text)
                    cmd.Parameters.AddWithValue("@opcion2", opcion2Cb.Text)
                    cmd.Parameters.AddWithValue("@opcion3", opcion3Cb.Text)
                    cmd.Parameters.AddWithValue("@observacion", ObservacionTb.Text)

                    ' Ejecutar el comando para actualizar los datos del cliente
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Datos del cliente actualizados correctamente.")
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub EliminarCliente(id_clientes As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para eliminar el cliente de la base de datos
                Dim query As String = "DELETE FROM clientes WHERE id_clientes = @clienteId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@clienteId", id_clientes)

                    ' Ejecutar el comando para eliminar el cliente
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Cliente eliminado correctamente.")
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente: " & ex.Message)
        End Try
    End Sub
    Private Sub CrearCliente()
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para insertar un nuevo cliente en la base de datos
                Dim query As String = "INSERT INTO clientes (nombre, apellido, residencia, telefono1, telefono2, email, tipo, lugar_trabajo, convocatoria, opcion1, opcion2, opcion3, observacion) " &
                                      "VALUES (@nombre, @apellido, @residencia, @telefono1, @telefono2, @email, @tipo, @lugar_trabajo, @convocatoria, @opcion1, @opcion2, @opcion3, @observacion)"

                ' Crear un comando con la consulta y los parámetros proporcionados
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@nombre", nombreTb.Text)
                    cmd.Parameters.AddWithValue("@apellido", apellidoTb.Text)
                    cmd.Parameters.AddWithValue("@residencia", residenciatb.Text)
                    cmd.Parameters.AddWithValue("@telefono1", telefono1Tb.Text)
                    cmd.Parameters.AddWithValue("@telefono2", telefono2Tb.Text)
                    cmd.Parameters.AddWithValue("@email", emailTb.Text)
                    cmd.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmd.Parameters.AddWithValue("@lugar_trabajo", lugarTrabajoTb.Text)
                    cmd.Parameters.AddWithValue("@convocatoria", convocatoriaCb.Text)
                    cmd.Parameters.AddWithValue("@opcion1", Opcion1Cb.Text)
                    cmd.Parameters.AddWithValue("@opcion2", opcion2Cb.Text)
                    cmd.Parameters.AddWithValue("@opcion3", opcion3Cb.Text)
                    cmd.Parameters.AddWithValue("@observacion", ObservacionTb.Text)

                    ' Ejecutar el comando para insertar el nuevo cliente
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Nuevo cliente creado correctamente.")
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al crear el cliente: " & ex.Message)
        End Try
    End Sub
    Private Function ClienteExiste(id_clientes As Integer) As Boolean
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para verificar si el cliente existe en la base de datos
                Dim query As String = "SELECT COUNT(*) FROM clientes WHERE id_clientes = @clienteId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@clienteId", id_clientes)

                    ' Ejecutar el comando y obtener el resultado
                    Dim result As Integer = CInt(cmd.ExecuteScalar())

                    ' Si el resultado es mayor que cero, el cliente existe
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar el cliente: " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        ' Obtener el valor del TextBoxId (asegúrate de validar que el valor sea un número antes de usarlo)
        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            If ClienteExiste(clienteId) Then
                MostrarClientes(clienteId)
                MostrarDatosCliente(clienteId)
                PanelBotones.Enabled = True
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
                TextBoxId.Clear()
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
            TextBoxId.Clear()
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        panelIngresoDatos2.Enabled = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            If ClienteExiste(clienteId) Then
                EliminarCliente(clienteId)
                MostrarDatosCliente(clienteId)
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            If ClienteExiste(clienteId) Then
                CrearCliente()
                MostrarDatosCliente(clienteId)
                panelIngresoDatos2.Enabled = True
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
        End If
    End Sub

    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        TextBoxId.Clear()
    End Sub

    Private Sub BtnIngresarNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnIngresarNuevoTicket.Click
        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            If ClienteExiste(clienteId) Then
                ActualizarDatosCliente(clienteId)
                MostrarDatosCliente(clienteId)
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
        End If
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        nombreTb.Clear()
        apellidoTb.Clear()
        residenciatb.Clear()
        telefono1Tb.Clear()
        telefono2Tb.Clear()
        emailTb.Clear()
        tipoCb.SelectedIndex = -1
        lugarTrabajoTb.Clear()
        ObservacionTb.Clear()
        convocatoriaCb.SelectedIndex = -1
        Opcion1Cb.SelectedIndex = -1
        opcion2Cb.SelectedIndex = -1
        opcion3Cb.SelectedIndex = -1
        panelIngresoDatos2.Enabled = False
    End Sub
End Class