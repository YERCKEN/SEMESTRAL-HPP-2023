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
                SELECT Carreras.NombreCarrera, Facultades.NombreFacultad
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


End Class
