﻿Imports System.Data.SqlClient

Public Class Clientes
    Dim conexion As New SqlConnection(VARIABLES_GLOBALES.cadenaConexion2)

    Dim connectionString As String = VARIABLES_GLOBALES.cadenaConexion2
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

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        ' Obtener el valor del TextBoxId (asegúrate de validar que el valor sea un número antes de usarlo)
        Dim clienteId As Integer
        If Integer.TryParse(TextBoxId.Text, clienteId) Then
            MostrarClientes(clienteId)
        Else
            MessageBox.Show("Ingrese un ID de cliente válido (número entero).")
        End If
    End Sub
End Class