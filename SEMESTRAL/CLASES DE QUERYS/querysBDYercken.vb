Public Class querysBDYercken

    'VARIABLES
    Public rollUsuario As String = "hola"

    'FUNCIÓN LOGIN==============================================================================================================
    'Public Function Login(usuario As String, contraseña As String) As Integer

    '    Dim resultado As Integer

    '    ' Crear una conexión a la base de datos
    '    Using connection As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion.cadenaConexion)
    '        ' Abrir la conexión
    '        connection.Open()

    '        ' Crear un comando SQL que llame al procedimiento almacenado
    '        Using command As New SqlCommand("VerificarLogin", connection)
    '            command.CommandType = CommandType.StoredProcedure

    '            ' Agregar los parámetros al comando
    '            command.Parameters.AddWithValue("@usuario", usuario)
    '            command.Parameters.AddWithValue("@contraseña", contraseña)

    '            ' Ejecutar el comando y obtener el resultado
    '            resultado = CInt(command.ExecuteScalar())
    '        End Using
    '    End Using

    '    ' Devolver el resultado
    '    Return resultado
    'End Function

End Class
