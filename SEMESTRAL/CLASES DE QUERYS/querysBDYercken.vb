Imports System.Data.SqlClient

Public Class querysBDYercken

    'VARIABLES
    Public rollUsuarioLogeado As String
    Public usuarioLogeado As String

    'FUNCIÓN LOGIN==============================================================================================================
    Public Function Login(usuario As String, contraseña As String) As Integer

        Dim resultado As Integer

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            ' Abrir la conexión
            connection.Open()

            ' Crear un comando SQL que llame al procedimiento almacenado
            Using command As New SqlCommand("VerificarLogin", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros al comando
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@contraseña", contraseña)

                ' Ejecutar el comando y obtener el resultado
                resultado = CInt(command.ExecuteScalar())
            End Using
        End Using

        ' Devolver el resultado
        Return resultado
    End Function

    'OBTENER TIPO DE ROLL

    Public Sub obtenerRolUsuario(ByVal nombreUsuario As String)

        ' Query para ejecutar el procedimiento almacenado
        Dim query As String = "EXEC ObtenerRolUsuario @NombreUsuario;"

        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing Then
                    rollUsuarioLogeado = result.ToString()
                End If
            End Using
        End Using
    End Sub

    'OBTENERE CARRERAS CON FACULTADES
    Public Function obtenerCarrerasConFacultades() As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            Dim query As String = "
                SELECT Carreras.ID, Carreras.NombreCarrera, Facultades.NombreFacultad
                FROM Carreras
                JOIN CarrerasFacultad ON Carreras.ID = CarrerasFacultad.CarreraID
                JOIN Facultades ON Facultades.ID = CarrerasFacultad.FacultadID;
            "

            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Llenar el DataTable con los datos del query
                    dataTable.Load(command.ExecuteReader())
                Catch ex As Exception
                    ' Manejo de excepciones en caso de errores de conexión o consulta
                    MessageBox.Show("Error al obtener los datos: " & ex.Message)
                End Try
            End Using
        End Using

        Return dataTable
    End Function


    'OBTENER ID DE LA FAULTAD -------------------------------------------------------------------------
    Public Function ObtenerIdFacultad(nombreFacultad As String) As Integer

        Dim facultadID As Integer = -1
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            Using command As New SqlCommand("obtenerIdFacultad", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@NombreFacultad", nombreFacultad)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    facultadID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return facultadID
    End Function


    'AGREGAR CARRERA -------------------------------------------------------------------------
    Public Function AgregarCarrera(nombreCarrera As String) As Integer

        Dim carreraID As Integer = -1
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            Using command As New SqlCommand("agregarCarrera", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@NombreCarrera", nombreCarrera)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    carreraID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return carreraID
    End Function

    'RELACIONAR -------------------------------------------------------------------------

    Public Sub RelacionarCarrerasFacultad(carreraID As Integer, facultadID As Integer)

        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            Using command As New SqlCommand("relacionarCarrerasFacultad", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@CarreraID", carreraID)
                command.Parameters.AddWithValue("@FacultadID", facultadID)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Función para actualizar el nombre de una carrera
    Public Sub ActualizarNombreCarrera(carreraID As Integer, nuevoNombreCarrera As String)
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            Using command As New SqlCommand("ActualizarNombreCarrera", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@CarreraID", carreraID)
                command.Parameters.AddWithValue("@NuevoNombreCarrera", nuevoNombreCarrera)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' Función para actualizar el ID de la facultad asociada a una carrera
    Public Sub ActualizarFacultadID(carreraID As Integer, nuevoFacultadID As Integer)
        Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
            Using command As New SqlCommand("ActualizarFacultadID", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@CarreraID", carreraID)
                command.Parameters.AddWithValue("@NuevoFacultadID", nuevoFacultadID)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub




    ' Función para obtener el nombre de la carrera y su facultad por ID
    Public Function selectCarreraFacultad(carreraID As Integer) As (String, String)

        Dim nombreCarrera As String = ""
        Dim nombreFacultad As String = ""

        ' Verificar que el ID de la carrera ingresado sea un número válido
        If carreraID > 0 Then

            Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
                Try
                    connection.Open()

                    ' Crear el comando para ejecutar el SELECT
                    Dim sql As String = "SELECT c.NombreCarrera, f.NombreFacultad " &
                                       "FROM Carreras c " &
                                       "INNER JOIN CarrerasFacultad cf ON c.ID = cf.CarreraID " &
                                       "INNER JOIN Facultades f ON cf.FacultadID = f.ID " &
                                       "WHERE c.ID = @CarreraID;"

                    Using command As New SqlCommand(sql, connection)
                        ' Parámetro de entrada: ID de la carrera
                        command.Parameters.AddWithValue("@CarreraID", carreraID)

                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                nombreCarrera = CStr(reader("NombreCarrera"))
                                nombreFacultad = CStr(reader("NombreFacultad"))
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    ' Manejar la excepción en caso de error de conexión o ejecución
                    MessageBox.Show("Error al obtener los datos de la carrera: " & ex.Message)
                End Try
            End Using
        End If

        Return (nombreCarrera, nombreFacultad)
    End Function



    Public Sub EliminarCarrera(ByVal carreraID As Integer)
        Try
            Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion)
                connection.Open()

                ' Eliminar el registro correspondiente de la tabla CarrerasFacultad
                Dim deleteCarrerasFacultadQuery As String = "DELETE FROM CarrerasFacultad WHERE CarreraID = @CarreraID;"
                Using cmdDeleteCarrerasFacultad As New SqlCommand(deleteCarrerasFacultadQuery, connection)
                    cmdDeleteCarrerasFacultad.Parameters.AddWithValue("@CarreraID", carreraID)
                    cmdDeleteCarrerasFacultad.ExecuteNonQuery()
                End Using

                ' Eliminar el registro de la tabla Carreras
                Dim deleteCarreraQuery As String = "DELETE FROM Carreras WHERE ID = @CarreraID;"
                Using cmdDeleteCarrera As New SqlCommand(deleteCarreraQuery, connection)
                    cmdDeleteCarrera.Parameters.AddWithValue("@CarreraID", carreraID)
                    cmdDeleteCarrera.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Carrera eliminada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al eliminar la carrera: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class
