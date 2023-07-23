Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Provedores
    Dim connectionString2 As String = VARIABLES_GLOBALES.cadenaConexion2
    Dim connectionString1 As String = VARIABLES_GLOBALES.cadenaConexion
    Private Sub Provedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        tipoCb.Items.Clear()
        tipoCb.Items.Add("Insumos")
        tipoCb.Items.Add("Mensajería")
        tipoCb.Items.Add("Logística")
        MostrarProveedores()
    End Sub
    Private Sub MostrarProveedores()
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                ' Consulta para obtener todos los datos de los proveedores
                Dim query As String = "SELECT * FROM proveedores"

                ' Crear un adaptador de datos con la consulta y la conexión
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Crear un nuevo DataTable
                    Dim dtProveedores As New DataTable()

                    ' Llenar el DataTable con los datos de los proveedores
                    adapter.Fill(dtProveedores)

                    ' Asignar el DataTable como la fuente de datos del DataGridView
                    DataGridView1.DataSource = dtProveedores
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos de los proveedores: " & ex.Message)
        End Try
    End Sub
    Private Sub MostrarProveedor(id_proveedor As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                ' Consulta para obtener los datos del proveedor filtrado por id_proveedor
                Dim query As String = "SELECT * FROM proveedores WHERE id_proveedores = @proveedorId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proveedorId", id_proveedor)

                    ' Crear un nuevo DataTable
                    Dim dtProveedor As New DataTable()

                    ' Crear un adaptador de datos con el comando
                    Using adapter As New SqlDataAdapter(cmd)
                        ' Llenar el DataTable con los datos del proveedor
                        adapter.Fill(dtProveedor)

                        ' Asignar el DataTable como la fuente de datos del DataGridView
                        DataGridView1.DataSource = dtProveedor
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del proveedor: " & ex.Message)
        End Try
    End Sub


    Private Sub MostrarDatosProveedor(id_proveedor As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para obtener los datos del proveedor filtrado por id_proveedor
                Dim query As String = "SELECT ruc, nombre, correo, telefono, tipo, observacion " &
                                  "FROM proveedores " &
                                  "WHERE id_proveedores = @proveedorId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proveedorId", id_proveedor)

                    ' Ejecutar el comando y leer los datos del proveedor
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Mostrar los datos del proveedor en los controles correspondientes
                            rucTb.Text = reader("ruc").ToString()
                            nombreTb.Text = reader("nombre").ToString()
                            correoTb.Text = reader("correo").ToString()
                            telefonoTb.Text = reader("telefono").ToString()
                            tipoCb.Text = reader("tipo").ToString()
                            observacionTb.Text = reader("observacion").ToString()
                        Else
                            ' Si no se encuentra el proveedor, mostrar mensaje de error
                            MessageBox.Show("Proveedor no encontrado.")
                        End If
                    End Using
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del proveedor: " & ex.Message)
        End Try
    End Sub
    Private Sub ActualizarProveedor(id_proveedor As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para actualizar los datos del proveedor en la base de datos
                Dim query As String = "UPDATE proveedores SET ruc = @ruc, nombre = @nombre, correo = @correo, telefono = @telefono, tipo = @tipo, observacion = @observacion " &
                                  "WHERE id_proveedores = @proveedorId"

                ' Crear un comando con la consulta y los parámetros proporcionados
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proveedorId", id_proveedor)
                    cmd.Parameters.AddWithValue("@ruc", rucTb.Text)
                    cmd.Parameters.AddWithValue("@nombre", nombreTb.Text)
                    cmd.Parameters.AddWithValue("@correo", correoTb.Text)
                    cmd.Parameters.AddWithValue("@telefono", telefonoTb.Text)
                    cmd.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmd.Parameters.AddWithValue("@observacion", observacionTb.Text)

                    ' Ejecutar el comando para actualizar los datos del proveedor
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Datos del proveedor actualizados correctamente.")
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos del proveedor: " & ex.Message)
        End Try
    End Sub

    Private Function ExisteProveedor(id_proveedor As Integer) As Boolean
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para verificar si existe un proveedor con el id_proveedor proporcionado
                Dim query As String = "SELECT COUNT(*) " &
                                  "FROM proveedores " &
                                  "WHERE id_proveedores = @proveedorId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proveedorId", id_proveedor)

                    ' Ejecutar el comando y obtener el número de proveedores que coinciden con el id_proveedor
                    Dim count As Integer = CInt(cmd.ExecuteScalar())

                    ' Si count es mayor que 0, significa que existe al menos un proveedor con el id_proveedor proporcionado
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar la existencia del proveedor: " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub EliminarProveedor(id_proveedor As Integer)
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para eliminar el proveedor de la base de datos
                Dim query As String = "DELETE FROM proveedores WHERE id_proveedores = @proveedorId"

                ' Crear un comando con la consulta y el parámetro proporcionado
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proveedorId", id_proveedor)

                    ' Ejecutar el comando para eliminar el proveedor
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Proveedor eliminado correctamente.")
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el proveedor: " & ex.Message)
        End Try
    End Sub
    Private Sub CrearProveedor()
        Try
            ' Crear una conexión a la base de datos
            Using connection As New SqlConnection(connectionString2)
                connection.Open()

                ' Consulta para insertar un nuevo proveedor en la base de datos
                Dim query As String = "INSERT INTO proveedores (ruc, nombre, correo, telefono, tipo, observacion) " &
                                  "VALUES (@ruc, @nombre, @correo, @telefono, @tipo, @observacion)"

                ' Crear un comando con la consulta y los parámetros proporcionados
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ruc", rucTb.Text)
                    cmd.Parameters.AddWithValue("@nombre", nombreTb.Text)
                    cmd.Parameters.AddWithValue("@correo", correoTb.Text)
                    cmd.Parameters.AddWithValue("@telefono", telefonoTb.Text)
                    cmd.Parameters.AddWithValue("@tipo", tipoCb.Text)
                    cmd.Parameters.AddWithValue("@observacion", observacionTb.Text)

                    ' Ejecutar el comando para insertar el nuevo proveedor
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Nuevo proveedor creado correctamente.")
                End Using

                ' Cerrar la conexión
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al crear el proveedor: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        ' Crear una variable para almacenar el id del proveedor
        Dim idProveedor As Integer

        ' Intentar convertir el texto del TextBox a un número entero
        If Integer.TryParse(idProveedoresTb.Text, idProveedor) Then
            ' Si la conversión es exitosa, utilizar la función ExisteProveedor para verificar si el proveedor existe
            If ExisteProveedor(idProveedor) Then
                MostrarDatosProveedor(idProveedor)
                MostrarProveedor(idProveedor)
                panelIngresoDatos2.Enabled = False
                crearBtn.Enabled = False
                actualizarBtn.Enabled = True
                eliminarBtn.Enabled = True
            Else
                MessageBox.Show("El proveedor no existe.")
            End If
        Else
            MessageBox.Show("Por favor, introduce un número válido para el ID del proveedor.")
        End If

    End Sub

    Private Sub BtnIngresarNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnIngresarNuevoTicket.Click
        ' Crear una variable para almacenar el id del proveedor
        Dim idProveedor As Integer

        ' Intentar convertir el texto del TextBox a un número entero
        If Integer.TryParse(idProveedoresTb.Text, idProveedor) Then
            ' Si la conversión es exitosa, utilizar la función ExisteProveedor para verificar si el proveedor existe
            If ExisteProveedor(idProveedor) Then
                ActualizarProveedor(idProveedor)
                MostrarProveedores()
                crearBtn.Enabled = True
                actualizarBtn.Enabled = False
                eliminarBtn.Enabled = False
            Else
                MessageBox.Show("El proveedor no existe.")
            End If
        Else
            MessageBox.Show("Por favor, introduce un número válido para el ID del proveedor.")
        End If
    End Sub

    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        idProveedoresTb.Clear()
        crearBtn.Enabled = True
        actualizarBtn.Enabled = False
        eliminarBtn.Enabled = False
        MostrarProveedores()
    End Sub

    Private Sub actualizarBtn_Click(sender As Object, e As EventArgs) Handles actualizarBtn.Click
        panelIngresoDatos2.Enabled = True
        eliminarBtn.Enabled = False
        BtnIngresarNuevoTicket.Visible = True
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        idProveedoresTb.Clear()
        rucTb.Clear()
        nombreTb.Clear()
        correoTb.Clear()
        tipoCb.SelectedIndex = -1
        telefonoTb.Clear()
        observacionTb.Clear()
        crearBtn.Enabled = True
        actualizarBtn.Enabled = False
        eliminarBtn.Enabled = False
        BtnIngresarNuevoTicket.Visible = False
    End Sub

    Private Sub crearBtn_Click(sender As Object, e As EventArgs) Handles crearBtn.Click
        CrearProveedor()
        MostrarProveedores()
        actualizarBtn.Enabled = False
        eliminarBtn.Enabled = False
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        ' Crear una variable para almacenar el id del proveedor
        Dim idProveedor As Integer

        ' Intentar convertir el texto del TextBox a un número entero
        If Integer.TryParse(idProveedoresTb.Text, idProveedor) Then
            ' Si la conversión es exitosa, utilizar la función ExisteProveedor para verificar si el proveedor existe
            If ExisteProveedor(idProveedor) Then
                EliminarProveedor(idProveedor)
                MostrarProveedores()
                idProveedoresTb.Clear()
                rucTb.Clear()
                nombreTb.Clear()
                correoTb.Clear()
                tipoCb.SelectedIndex = -1
                telefonoTb.Clear()
                observacionTb.Clear()
                crearBtn.Enabled = False
                actualizarBtn.Enabled = True
                eliminarBtn.Enabled = True
            Else
                MessageBox.Show("El proveedor no existe.")
            End If
        Else
            MessageBox.Show("Por favor, introduce un número válido para el ID del proveedor.")
        End If
    End Sub
End Class