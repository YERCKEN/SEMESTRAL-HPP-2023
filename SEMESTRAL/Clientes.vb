Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Clientes
    Dim connectionString2 As String = VARIABLES_GLOBALES.cadenaConexion2
    Dim connectionString1 As String = VARIABLES_GLOBALES.cadenaConexion
    Dim clienteId As Integer
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        MostrarClientes()
        tipoCb.Items.Clear()
        tipoCb.Items.Add("Prospecto")
        tipoCb.Items.Add("Estudiante")
        convocatoriaCb.Items.Clear()
        convocatoriaCb.Items.Add("Primera")
        convocatoriaCb.Items.Add("Segunda")
        Opcion1Cb.Items.Clear()
        'Opcion1Cb.Items.Add("Elemento 1")
        opcion2Cb.Items.Clear()
        'opcion2Cb.Items.Add("Elemento 2")
        opcion3Cb.Items.Clear()
        'opcion3Cb.Items.Add("Elemento 3")
        MostrarCarreras()
    End Sub
    Private Sub MostrarCarreras()
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString1)
                connection.Open()

                ' Consulta para obtener todas las carreras de la tabla Carreras
                Dim query As String = "SELECT * FROM Carreras"

                ' Crear un adaptador de datos con la consulta
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Crear un nuevo DataTable
                    Dim dt As New DataTable()

                    ' Llenar el DataTable con los datos de la tabla Carreras
                    adapter.Fill(dt)

                    ' Configurar los ComboBox para mostrar las carreras
                    Opcion1Cb.DataSource = dt.Copy()
                    Opcion1Cb.DisplayMember = "NombreCarrera"
                    Opcion1Cb.ValueMember = "id"

                    opcion2Cb.DataSource = dt.Copy()
                    opcion2Cb.DisplayMember = "NombreCarrera"
                    opcion2Cb.ValueMember = "id"

                    opcion3Cb.DataSource = dt.Copy()
                    opcion3Cb.DisplayMember = "NombreCarrera"
                    opcion3Cb.ValueMember = "id"
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las carreras: " & ex.Message)
        End Try
    End Sub


    Private Sub MostrarClientes()
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para obtener datos de las tablas clientes y clienteopciones
                Dim query As String = "SELECT c.id_clientes, c.nombre, c.apellido, c.residencia, c.tipo, c.lugar_trabajo, c.telefono1, c.telefono2, c.email, co.opcion1, co.opcion2, co.opcion3, co.convocatoria " &
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


    Private Sub MostrarCliente(id_clientes As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
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
            Using connection As New SqlConnection(connectionString2)
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
            ' Comprobar si los campos están vacíos
            If String.IsNullOrWhiteSpace(nombreTb.Text) Or String.IsNullOrWhiteSpace(apellidoTb.Text) Or
           String.IsNullOrWhiteSpace(residenciatb.Text) Or String.IsNullOrWhiteSpace(telefono1Tb.Text) Or
           String.IsNullOrWhiteSpace(telefono2Tb.Text) Or String.IsNullOrWhiteSpace(emailTb.Text) Or
           String.IsNullOrWhiteSpace(tipoCb.Text) Or String.IsNullOrWhiteSpace(lugarTrabajoTb.Text) Or
           String.IsNullOrWhiteSpace(ObservacionTb.Text) Or String.IsNullOrWhiteSpace(Opcion1Cb.Text) Or
           String.IsNullOrWhiteSpace(opcion2Cb.Text) Or String.IsNullOrWhiteSpace(opcion3Cb.Text) Or
           String.IsNullOrWhiteSpace(convocatoriaCb.Text) Then

                MessageBox.Show("Por favor, rellene todos los campos.")
                Exit Sub
            End If

            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para actualizar los datos del cliente en la tabla clientes
                Dim queryClientes As String = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, residencia = @residencia, " &
                              "telefono1 = @telefono1, telefono2 = @telefono2, email = @email, tipo = @tipo, " &
                              "lugar_trabajo = @lugar_trabajo, observacion = @observacion " &
                              "WHERE id_clientes = @clienteId"

                ' Crear un comando con la consulta y los parámetros proporcionados para la tabla clientes
                Using cmdClientes As New SqlCommand(queryClientes, connection)
                    cmdClientes.Parameters.AddWithValue("@clienteId", id_clientes)
                    cmdClientes.Parameters.AddWithValue("@nombre", nombreTb.Text)
                    cmdClientes.Parameters.AddWithValue("@apellido", apellidoTb.Text)
                    cmdClientes.Parameters.AddWithValue("@residencia", residenciatb.Text)
                    cmdClientes.Parameters.AddWithValue("@telefono1", telefono1Tb.Text)
                    cmdClientes.Parameters.AddWithValue("@telefono2", telefono2Tb.Text)
                    cmdClientes.Parameters.AddWithValue("@email", emailTb.Text)
                    cmdClientes.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmdClientes.Parameters.AddWithValue("@lugar_trabajo", lugarTrabajoTb.Text)
                    cmdClientes.Parameters.AddWithValue("@observacion", ObservacionTb.Text)

                    ' Ejecutar el comando para actualizar los datos del cliente en la tabla clientes
                    cmdClientes.ExecuteNonQuery()
                End Using

                ' Consulta para comprobar si existe el registro del cliente en la tabla clienteopciones
                Dim queryClienteOpciones As String = "IF EXISTS (SELECT 1 FROM clienteopciones WHERE id_cliente = @clienteId) " &
                                            "BEGIN " &
                                            "  UPDATE clienteopciones SET opcion1 = @opcion1, opcion2 = @opcion2, opcion3 = @opcion3, convocatoria = @convocatoria " &
                                            "  WHERE id_cliente = @clienteId " &
                                            "END " &
                                            "ELSE " &
                                            "BEGIN " &
                                            "  INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria) " &
                                            "  VALUES (@clienteId, @opcion1, @opcion2, @opcion3, @convocatoria) " &
                                            "END"

                ' Crear un comando con la consulta y los parámetros proporcionados para la tabla clienteopciones
                Using cmdClienteOpciones As New SqlCommand(queryClienteOpciones, connection)
                    cmdClienteOpciones.Parameters.AddWithValue("@clienteId", id_clientes)
                    cmdClienteOpciones.Parameters.AddWithValue("@opcion1", Opcion1Cb.Text)
                    cmdClienteOpciones.Parameters.AddWithValue("@opcion2", opcion2Cb.Text)
                    cmdClienteOpciones.Parameters.AddWithValue("@opcion3", opcion3Cb.Text)
                    cmdClienteOpciones.Parameters.AddWithValue("@convocatoria", convocatoriaCb.Text)

                    ' Ejecutar el comando para actualizar o insertar el registro en la tabla clienteopciones
                    cmdClienteOpciones.ExecuteNonQuery()
                End Using

                MessageBox.Show("Datos del cliente y opciones actualizados correctamente.")

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
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Eliminar registros relacionados en la tabla clienteopciones
                Dim queryClienteOpciones As String = "DELETE FROM clienteopciones WHERE id_cliente = @clienteId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmdClienteOpciones As New SqlCommand(queryClienteOpciones, connection)
                    cmdClienteOpciones.Parameters.AddWithValue("@clienteId", id_clientes)

                    ' Ejecutar el comando para eliminar los registros relacionados en la tabla clienteopciones
                    cmdClienteOpciones.ExecuteNonQuery()
                End Using

                ' Consulta para eliminar el cliente de la tabla clientes
                Dim queryClientes As String = "DELETE FROM clientes WHERE id_clientes = @clienteId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmdClientes As New SqlCommand(queryClientes, connection)
                    cmdClientes.Parameters.AddWithValue("@clienteId", id_clientes)

                    ' Ejecutar el comando para eliminar el cliente
                    cmdClientes.ExecuteNonQuery()

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
            ' Comprueba que las entradas no sean nulas
            If String.IsNullOrEmpty(nombreTb.Text) OrElse
           String.IsNullOrEmpty(apellidoTb.Text) OrElse
           String.IsNullOrEmpty(residenciatb.Text) OrElse
           String.IsNullOrEmpty(telefono1Tb.Text) OrElse
           String.IsNullOrEmpty(telefono2Tb.Text) OrElse
           String.IsNullOrEmpty(emailTb.Text) OrElse
           String.IsNullOrEmpty(tipoCb.Text) OrElse
           String.IsNullOrEmpty(lugarTrabajoTb.Text) OrElse
           String.IsNullOrEmpty(ObservacionTb.Text) OrElse
           String.IsNullOrEmpty(Opcion1Cb.Text) OrElse
           String.IsNullOrEmpty(opcion2Cb.Text) OrElse
           String.IsNullOrEmpty(opcion3Cb.Text) OrElse
           String.IsNullOrEmpty(convocatoriaCb.Text) Then

                MessageBox.Show("Por favor asegúrese de que todos los campos están llenos.")
                Return
            End If
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Iniciar una transacción
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    ' Consulta para insertar un nuevo cliente en la tabla clientes
                    Dim queryClientes As String = "INSERT INTO clientes (nombre, apellido, residencia, telefono1, telefono2, email, tipo, lugar_trabajo, observacion) " &
                                          "OUTPUT INSERTED.id_clientes " &
                                          "VALUES (@nombre, @apellido, @residencia, @telefono1, @telefono2, @email, @tipo, @lugar_trabajo, @observacion)"

                    ' Crear un comando con la consulta y los parámetros proporcionados para la tabla clientes
                    Using cmdClientes As New SqlCommand(queryClientes, connection, transaction)
                        cmdClientes.Parameters.AddWithValue("@nombre", nombreTb.Text)
                        cmdClientes.Parameters.AddWithValue("@apellido", apellidoTb.Text)
                        cmdClientes.Parameters.AddWithValue("@residencia", residenciatb.Text)
                        cmdClientes.Parameters.AddWithValue("@telefono1", telefono1Tb.Text)
                        cmdClientes.Parameters.AddWithValue("@telefono2", telefono2Tb.Text)
                        cmdClientes.Parameters.AddWithValue("@email", emailTb.Text)
                        cmdClientes.Parameters.AddWithValue("@tipo", tipoCb.Text)
                        cmdClientes.Parameters.AddWithValue("@lugar_trabajo", lugarTrabajoTb.Text)
                        cmdClientes.Parameters.AddWithValue("@observacion", ObservacionTb.Text)

                        ' Ejecutar el comando para insertar el nuevo cliente en la tabla clientes y recuperar el ID del cliente recién insertado
                        Dim idCliente As Integer = CInt(cmdClientes.ExecuteScalar())

                        ' Consulta para insertar las opciones del cliente en la tabla clienteopciones
                        Dim queryClienteOpciones As String = "INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria) " &
                                                "VALUES (@clienteId, @opcion1, @opcion2, @opcion3, @convocatoria)"

                        ' Crear un comando con la consulta y los parámetros proporcionados para la tabla clienteopciones
                        Using cmdClienteOpciones As New SqlCommand(queryClienteOpciones, connection, transaction)
                            cmdClienteOpciones.Parameters.AddWithValue("@clienteId", idCliente)
                            cmdClienteOpciones.Parameters.AddWithValue("@opcion1", Opcion1Cb.Text)
                            cmdClienteOpciones.Parameters.AddWithValue("@opcion2", opcion2Cb.Text)
                            cmdClienteOpciones.Parameters.AddWithValue("@opcion3", opcion3Cb.Text)
                            cmdClienteOpciones.Parameters.AddWithValue("@convocatoria", convocatoriaCb.Text)

                            ' Ejecutar el comando para insertar las opciones del cliente en la tabla clienteopciones
                            cmdClienteOpciones.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Cometer la transacción si todas las consultas se ejecutan correctamente
                    transaction.Commit()

                    MessageBox.Show("Nuevo cliente creado correctamente.")
                Catch ex As Exception
                    ' Deshacer la transacción si alguna de las consultas falla
                    transaction.Rollback()

                    MessageBox.Show("Error al crear el cliente: " & ex.Message)
                End Try

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
            Using connection As New SqlConnection(connectionString2)
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
                MostrarCliente(clienteId)
                MostrarDatosCliente(clienteId)
                panelIngresoDatos2.Visible = True
                PanelSelecion.Visible = False
                BtnactualizarNuevoTicket.Visible = True
                BtnNuevoTicket.Visible = False
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
                TextBoxId.Clear()
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
            TextBoxId.Clear()
        End If
    End Sub

    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        TextBoxId.Clear()
        PanelBotones.Visible = True
        PanelSelecion.Visible = False
        MostrarClientes()
    End Sub

    Private Sub BtnIngresarNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnactualizarNuevoTicket.Click
        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            If ClienteExiste(clienteId) Then
                TextBoxId.Clear()
                ActualizarDatosCliente(clienteId)
                MostrarClientes()
                panelIngresoDatos2.Visible = False
                PanelBotones.Visible = True
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
        End If
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        TextBoxId.Clear()
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
        panelIngresoDatos2.Visible = False
        PanelBotones.Visible = True
    End Sub

    Private Sub crearBtn_Click(sender As Object, e As EventArgs) Handles crearBtn.Click
        panelIngresoDatos2.Visible = True
        PanelBotones.Visible = False
        BtnactualizarNuevoTicket.Visible = False
        BtnNuevoTicket.Visible = True

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
    End Sub

    Private Sub btnselecccionarElimina_Click(sender As Object, e As EventArgs) Handles btnselecccionarElimina.Click
        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            If ClienteExiste(clienteId) Then
                EliminarCliente(clienteId)
                MostrarClientes()
                TextBoxId.Clear()
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
                PanelSelecion.Visible = False
                PanelBotones.Visible = True
            Else
                MessageBox.Show("El cliente con ID " & clienteId & " no existe.")
            End If
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
        End If
    End Sub

    Private Sub BtnNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnNuevoTicket.Click
        CrearCliente()
        MostrarClientes()
        panelIngresoDatos2.Visible = False
        PanelBotones.Visible = True
    End Sub
End Class