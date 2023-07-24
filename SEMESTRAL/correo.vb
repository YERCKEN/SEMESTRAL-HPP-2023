Imports System.Data.SqlClient

Imports Outlook = Microsoft.Office.Interop.Outlook



Public Class correo

    Dim correoDestinatario As String
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

        correoDestinatario = ObtenerCorreoProveedor(ListaProvedores.Text)
        MsgBox(correoDestinatario)
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            ' Crear una instancia de la aplicación Outlook
            Dim outlookApp As Outlook.Application = New Outlook.Application()

            ' Crear un nuevo correo
            Dim correo As Outlook.MailItem = outlookApp.CreateItem(Outlook.OlItemType.olMailItem)

            ' Establecer los campos del correo
            correo.Subject = TextBoxAsunto.Text
            correo.To = correoDestinatario.ToString
            correo.Body = TextBoxCuerpo.Text

            ' Opcional: Puedes adjuntar archivos al correo si lo deseas
            'correo.Attachments.Add("C:\Ruta\archivo_adjunto.txt")

            ' Enviar el correo
            correo.Send()

            ' Liberar recursos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(correo)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookApp)

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class