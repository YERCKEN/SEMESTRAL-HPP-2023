

Imports Microsoft.Office.Interop
Imports System.Data.SqlClient



Public Class Form1



    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        ' Conexión a la base de datos (ajusta la cadena de conexión según tus datos)
        Dim connectionString As String = "Data source =YERCKEN\SQLEXPRESS; Initial Catalog=baseDeDatos2; integrated security = true"
        Dim query As String = "SELECT *FROM proveedores"

        Dim dataTable As New System.Data.DataTable() ' Uso del nombre completo del DataTable

        Try
            ' Abrir la conexión y ejecutar la consulta
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                connection.Open()

                ' Llenar el DataTable con los resultados del SELECT
                dataTable.Load(command.ExecuteReader())
            End Using

            ' Crear una nueva instancia de Excel
            Dim excelApp As New Excel.Application
            Dim excelWorkBook As Excel.Workbook
            Dim excelWorkSheet As Excel.Worksheet

            ' Preguntar dónde guardar el archivo
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Guardar archivo de Excel"
            If saveFileDialog.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            End If

            ' Crear un nuevo libro de trabajo y hoja de trabajo
            excelWorkBook = excelApp.Workbooks.Add()
            excelWorkSheet = excelWorkBook.Sheets(1)

            ' Agregar el encabezado "Universidad de Chiriquí"
            excelWorkSheet.Range("A1:D1").Merge()
            excelWorkSheet.Range("A1:D1").Value = "Universidad de Chiriquí"
            excelWorkSheet.Range("A1:D1").HorizontalAlignment = Excel.Constants.xlCenter


            ' Agregar título de tabla
            excelWorkSheet.Range("A5:D5").Merge()
            excelWorkSheet.Range("A5:D5").Value = "Título de la tabla"
            excelWorkSheet.Range("A5:D5").HorizontalAlignment = Excel.Constants.xlCenter

            ' Escribir los datos en la hoja de trabajo
            Dim startCell As Excel.Range = excelWorkSheet.Range("A7")
            Dim dataArr(dataTable.Rows.Count, dataTable.Columns.Count - 1) As Object
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    dataArr(i, j) = dataTable.Rows(i)(j)
                Next
            Next
            startCell.Resize(dataTable.Rows.Count, dataTable.Columns.Count).Value = dataArr

            ' Ajustar el ancho de las columnas para que se ajusten al contenido
            excelWorkSheet.Columns.AutoFit()

            ' Guardar el archivo
            excelWorkBook.SaveAs(saveFileDialog.FileName)

            ' Cerrar el libro de trabajo y la aplicación de Excel
            excelWorkBook.Close()
            excelApp.Quit()

            ' Liberar los recursos de Excel
            ReleaseObject(excelWorkSheet)
            ReleaseObject(excelWorkBook)
            ReleaseObject(excelApp)

            MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al imprimir en Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub




End Class
