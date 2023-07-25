

Imports Microsoft.Office.Interop
Imports System.Data.SqlClient



Public Class Form1

    'CADENA CONEXIÓN
    Dim connectionString As String = "Data source =YERCKEN\SQLEXPRESS; Initial Catalog=baseDeDatos2; integrated security = true"
    Dim query As String
    Dim newColumnNames As String()
    Dim tituloTabla As String
    Sub generadorDeExcel()

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




            ' Agregar el encabezado "Universidad de Chiriquí" que abarque el ancho de la tabla
            Dim encabezado As Excel.Range = excelWorkSheet.Range("A1", excelWorkSheet.Cells(1, dataTable.Columns.Count))
            encabezado.Merge()
            encabezado.Value = "Universidad de Chiriquí"
            encabezado.HorizontalAlignment = Excel.Constants.xlCenter

            'COLOR
            encabezado.Interior.Color = RGB(0, 116, 255)
            encabezado.Font.Color = Color.White

            'NEGRITA y tamaño
            encabezado.Font.Size = 20
            encabezado.Font.Bold = True


            ' Agregar título de tabla
            Dim rangoTituloDeLaTabla As Excel.Range = excelWorkSheet.Range("A3", excelWorkSheet.Cells(3, dataTable.Columns.Count))
            rangoTituloDeLaTabla.Merge()
            rangoTituloDeLaTabla.Value = tituloTabla
            rangoTituloDeLaTabla.HorizontalAlignment = Excel.Constants.xlCenter

            'COLORs
            rangoTituloDeLaTabla.Interior.Color = Color.White

            rangoTituloDeLaTabla.Font.Color = RGB(0, 116, 255)

            'NEGRITA y tamaño
            rangoTituloDeLaTabla.Font.Size = 15
            rangoTituloDeLaTabla.Font.Bold = True

            rangoTituloDeLaTabla.Font.Italic = True



            ' Escribir el encabezado de la tabla
            Dim headerRange As Excel.Range = excelWorkSheet.Range("A5", excelWorkSheet.Cells(5, dataTable.Columns.Count))
            ' Cambiar los nombres de las columnas de la DataTable según tus necesidades


            headerRange.Value = newColumnNames
            headerRange.Font.Bold = True

            headerRange.HorizontalAlignment = Excel.Constants.xlCenter

            headerRange.Font.Color = Color.FromArgb(83, 97, 98)

            ' Encontrar la columna "observacion" o "Observaciones"
            Dim observacionColumnIndex As Integer = -1
            For i As Integer = 1 To dataTable.Columns.Count
                If String.Equals(dataTable.Columns(i - 1).ColumnName, "observacion", StringComparison.OrdinalIgnoreCase) _
                OrElse String.Equals(dataTable.Columns(i - 1).ColumnName, "Observaciones", StringComparison.OrdinalIgnoreCase) Then
                    observacionColumnIndex = i
                    Exit For
                End If
            Next

            ' Si se encuentra la columna "observacion" o "Observaciones", aplicar WrapText
            If observacionColumnIndex > 0 Then
                Dim observacionColumn As Excel.Range = excelWorkSheet.Range(excelWorkSheet.Cells(6, observacionColumnIndex), excelWorkSheet.Cells(excelWorkSheet.Rows.Count, observacionColumnIndex))
                observacionColumn.WrapText = True
                observacionColumn.HorizontalAlignment = Excel.Constants.xlCenter

                observacionColumn.ColumnWidth = 30


            End If



            ' Escribir los datos en la hoja de trabajo
            Dim startCell As Excel.Range = excelWorkSheet.Range("A6")
            Dim dataArr(dataTable.Rows.Count - 1, dataTable.Columns.Count - 1) As Object
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    dataArr(i, j) = dataTable.Rows(i)(j)

                    Dim currentCell As Excel.Range = startCell.Offset(i, j)

                    'ESTILO 
                    currentCell.Font.Color = RGB(120, 127, 130)
                    currentCell.HorizontalAlignment = Excel.Constants.xlCenter
                    currentCell.VerticalAlignment = Excel.Constants.xlCenter
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

    Private Sub BtnProvedores_Click(sender As Object, e As EventArgs) Handles BtnProvedores.Click
        query = "SELECT *FROM proveedores"
        newColumnNames = {"ID", "RUC", "Nombre", "Correo", "Tipo", "Teléfono", "Observación"}
        tituloTabla = "PROVEDORES"
        generadorDeExcel()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click

        query = "SELECT * FROM clientes;"
        newColumnNames = {"ID", "Nombre", "Apellido", "Residencia", "Lugar de Trabajo", "Teléfono 1", "Teléfono 2", "Correo", "Tipo", "Observación"}
        tituloTabla = "Clientes"
        generadorDeExcel()
    End Sub
End Class
