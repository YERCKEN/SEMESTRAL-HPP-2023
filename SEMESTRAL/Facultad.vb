Imports System.Data.SqlClient

Public Class Facultad


    Private Sub Facultad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub BtnNuevaCarrera_Click(sender As Object, e As EventArgs) Handles BtnNuevaCarrera.Click

        PanelBotones.Visible = False
        PanelNuevaCarrera.Visible = True
        btnIngresar.Text = "Agregar Facultad"
        PanelNombre.Visible = True

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        PanelBotones.Visible = False
        PanelSelecion.Visible = True

        btnIngresar.Text = "Actualizar Facultad"

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        PanelBotones.Visible = False
        PanelSelecion.Visible = True

        btnIngresar.Text = "Eliminar Facultad"

    End Sub

    Private Sub BtnSalirDeNuevaCarrera_Click(sender As Object, e As EventArgs) Handles BtnSalirDeNuevaCarrera.Click
        PanelNuevaCarrera.Visible = False
        PanelBotones.Visible = True
    End Sub

    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click




        PanelSelecion.Visible = False
        PanelBotones.Visible = True
    End Sub



    Private Sub CargarDatos()
        ' Cadena de conexión a la base de datos (cambiar los valores según tu configuración)

        ' Consulta SELECT que deseas ejecutar
        Dim query As String = "SELECT ID, NombreFacultad FROM Facultades"

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            ' Crear el comando SQL y asignar la conexión
            Dim command As New SqlCommand(query, connection)

            Try
                ' Abrir la conexión a la base de datos
                connection.Open()

                ' Crear un adaptador de datos para ejecutar la consulta y llenar un DataSet
                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet)

                ' Asignar los resultados al DataGridView
                DataGridView1.DataSource = dataSet.Tables(0)

                ' Opcional: Ajustar el tamaño de las columnas del DataGridView
                DataGridView1.AutoResizeColumns()
            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub InsertarDatos()

        ' Datos que deseas insertar en la tabla Facultades (reemplaza estos valores con los que desees)
        Dim nombreFacultad As String

        nombreFacultad = textBoxNombre.Text

        ' Consulta INSERT que deseas ejecutar
        Dim query As String = "INSERT INTO Facultades (NombreFacultad) VALUES (@NombreFacultad)"

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            ' Crear el comando SQL y asignar la conexión
            Dim command As New SqlCommand(query, connection)

            ' Agregar parámetros a la consulta para evitar SQL Injection y asignar los valores
            command.Parameters.AddWithValue("@NombreFacultad", nombreFacultad)

            Try
                ' Abrir la conexión a la base de datos
                connection.Open()

                ' Ejecutar la consulta INSERT
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Comprobar si se insertó correctamente
                If rowsAffected > 0 Then
                    MessageBox.Show("Se ha insertado un nuevo registro correctamente.")
                    CargarDatos()

                Else
                    MessageBox.Show("No se pudo insertar el nuevo registro.")
                End If
            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error al insertar datos: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub ActualizarDatos()

        ' Datos que deseas actualizar en la tabla Facultades (reemplaza estos valores con los que desees)
        Dim idFacultad As Integer ' ID del registro que deseas actualizar
        Dim nuevoNombreFacultad As String

        idFacultad = TextBoxId.Text
        nuevoNombreFacultad = textBoxNombre.Text


        ' Consulta UPDATE que deseas ejecutar
        Dim query As String = "UPDATE Facultades SET NombreFacultad = @NombreFacultad WHERE ID = @ID"

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            ' Crear el comando SQL y asignar la conexión
            Dim command As New SqlCommand(query, connection)

            ' Agregar parámetros a la consulta para evitar SQL Injection y asignar los valores
            command.Parameters.AddWithValue("@NombreFacultad", nuevoNombreFacultad)
            command.Parameters.AddWithValue("@ID", idFacultad)

            Try
                ' Abrir la conexión a la base de datos
                connection.Open()

                ' Ejecutar la consulta UPDATE
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Comprobar si se actualizó correctamente
                If rowsAffected > 0 Then
                    MessageBox.Show("Se ha actualizado el registro correctamente.")
                    CargarDatos()

                Else
                    MessageBox.Show("No se pudo actualizar el registro.")
                End If
            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error al actualizar datos: " & ex.Message)
            End Try
        End Using
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

                            If btnIngresar.Text = "Eliminar Facultad" Then
                                fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 222, 222) ' Establecer el color de fondo de la fila encontrada
                                PanelNuevaCarrera.Visible = True
                                PanelNombre.Visible = False
                            Else
                                fila.DefaultCellStyle.BackColor = Color.FromArgb(240, 245, 252) ' Establecer el color de fondo de la fila encontrada
                                PanelNuevaCarrera.Visible = True
                                PanelNombre.Visible = True

                            End If

                            ' Obtener el nombre de la facultad en la celda correspondiente
                            Dim nombreFacultad As String = fila.Cells("NombreFacultad").Value.ToString()

                            ' Asignar el nombre de la facultad a la TextBox
                            textBoxNombre.Text = nombreFacultad


                            PanelSelecion.Visible = False
                            Exit For
                        End If
                    End If
                Next

                'SI EL ID NO EXISTE
                If Not existeId Then
                    TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("ERROR: EL ID NO EXISTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBoxId.BackColor = Color.White
                End If
            End If
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

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If btnIngresar.Text = "Eliminar Facultad" Then
            EliminarDatos()
        ElseIf btnIngresar.Text = "Agregar Facultad" Then
            InsertarDatos()
        ElseIf btnIngresar.Text = "Actualizar Facultad" Then
            ActualizarDatos()
        End If
    End Sub







    Private Sub EliminarDatos()
        ' Cadena de conexión a la base de datos (cambiar los valores según tu configuración)

        ' ID del registro que deseas eliminar (reemplaza este valor con el ID del registro que deseas eliminar)
        Dim idFacultad As Integer

        idFacultad = TextBoxId.Text


        ' Consulta DELETE que deseas ejecutar
        Dim query As String = "DELETE FROM Facultades WHERE ID = @ID"

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            ' Crear el comando SQL y asignar la conexión
            Dim command As New SqlCommand(query, connection)

            ' Agregar parámetro a la consulta para evitar SQL Injection y asignar el valor
            command.Parameters.AddWithValue("@ID", idFacultad)

            Try
                ' Abrir la conexión a la base de datos
                connection.Open()

                ' Ejecutar la consulta DELETE
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Comprobar si se eliminó correctamente
                If rowsAffected > 0 Then
                    MessageBox.Show("Se ha eliminado el registro correctamente.")
                    CargarDatos()

                Else
                    MessageBox.Show("No se pudo eliminar el registro.")
                End If
            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error al eliminar datos: " & ex.Message)
            End Try
        End Using
    End Sub



End Class







