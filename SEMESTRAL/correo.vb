Imports System.Data.SqlClient

Public Class correo

    Dim correo As String
    Private Sub correo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'CARGAR PROVEDORES ------------------------
        CargarProveedores()




    End Sub


    Private Sub CargarProveedores()


        Using conexion As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion2)

            conexion.Open()

            Dim query As String = "SELECT nombre FROM proveedores;"
            Dim command As New SqlCommand(query, conexion)

            Dim reader As SqlDataReader = command.ExecuteReader()
            ListaProvedores.Items.Clear()

            While reader.Read()
                Dim name As String = reader.GetString(0)
                ListaProvedores.Items.Add(name)
            End While

        End Using
    End Sub

    Private Function ObtenerCorreoProveedor(nombreProveedor As String) As String
        Dim correoProveedor As String = ""

        Using conexion As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion2)
            conexion.Open()

            Dim query As String = "SELECT correo FROM proveedores WHERE nombre = @nombre;"
            Dim command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@nombre", nombreProveedor)

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                correoProveedor = reader.GetString(0)
            End If

        End Using

        Return correoProveedor
    End Function

    Private Sub ListaProvedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaProvedores.SelectedIndexChanged

        correo = ObtenerCorreoProveedor(ListaProvedores.Text)
        MsgBox(correo)
    End Sub
End Class