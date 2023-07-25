Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class Form1


    Dim querysBDYercken As New querysBDYercken()

    'PARA EL MANEJO DEL INICIO
    Private listaImagenes As New List(Of Image)
    Private indiceActual As Integer = 0



    'CARGA DEL FORMS----------------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INICIALIZACIÓN DEL RENDER DEL MENU
        Menu.Renderer = New RenderMenu()
        ' Configuramos el Label para que el texto se fije a la derecha y crezca hacia la izquierda
        LabelActividad.RightToLeft = RightToLeft.Yes
        ' También podemos establecer la propiedad AutoSize en True para que el tamaño del Label se ajuste automáticamente al texto
        LabelActividad.AutoSize = True
        'SHOW LOGIN
        Login.Show()
        Login.Owner = Me

        'Panel1.Visible = False


        ' Ruta de la carpeta que contiene las imágenes
        Dim rutaCarpeta As String = "C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\SEMESTRAL\SEMESTRAL\SEMESTRAL\IMG\SECUENCIA ANIMACION\"

        ' Agregar las imágenes a la lista (asumiendo que los nombres son secuecIA00, secuecIA01, ... hasta secuecIA28)
        For i As Integer = 0 To 28
            Dim nombreImagen As String = "secuecIA" & i.ToString("00") & ".jpg"
            Dim rutaImagen As String = rutaCarpeta & nombreImagen

            ' Verificar si la imagen existe antes de agregarla a la lista
            If System.IO.File.Exists(rutaImagen) Then
                listaImagenes.Add(Image.FromFile(rutaImagen))
            End If
        Next

        ' Mostrar la primera imagen al cargar el formulario
        If listaImagenes.Count > 0 Then
            PictureBox2.Image = listaImagenes(0)
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Cambiar a la siguiente imagen
        If listaImagenes.Count > 0 Then
            indiceActual = (indiceActual + 1) Mod listaImagenes.Count
            PictureBox2.Image = listaImagenes(indiceActual)

            ' Verificar si se llegó a la última imagen (índice 28)
            If indiceActual = 28 Then
                ' Ocultar el PictureBox
                PictureBox2.Visible = False

                ' Deshabilitar el contador para detener la animación
                Timer1.Enabled = False
            End If
        End If

    End Sub

    'MOVIMIENTO-=====================================================================================

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = 2

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles Menu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

    End Sub

    'BARRA HERADER MOVIMIENTO relativo---------------------------------------------------------------------
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged

        'LOGIN
        If Login IsNot Nothing Then
            Login.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

        'CLIENTES
        If Clientes IsNot Nothing Then
            Clientes.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

        'Servicios
        If Servicios IsNot Nothing Then
            Servicios.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

        'Proveedores
        If Provedores IsNot Nothing Then
            Provedores.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

        'Carreras
        If Carreras IsNot Nothing Then
            Carreras.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

        'Inventario
        If Inventario IsNot Nothing Then
            Inventario.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

        'Desarrolladores
        If Desarrolladores IsNot Nothing Then
            Desarrolladores.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

    End Sub

    'BOTONES CERRAR Y MINIMIZAR ==================================================================
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'BOTÓN CLIENTES =====================================================================================================================
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

        'ABRIR ------------
        Clientes.Show()
        Clientes.Owner = Me
        LabelActividad.Text = "Clientes"
        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Provedores.Close()
        Servicios.Close()
        Carreras.Close()
        Desarrolladores.Close()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        'ABRIR ------------
        Servicios.Show()
        Servicios.Owner = Me
        LabelActividad.Text = "Servicios"
        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Provedores.Close()
        Clientes.Close()
        Carreras.Close()
        Desarrolladores.Close()
    End Sub

    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvedoresToolStripMenuItem.Click
        'ABRIR ------------
        Provedores.Show()
        Provedores.Owner = Me
        LabelActividad.Text = "Proveedores"

        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Servicios.Close()
        Clientes.Close()
        Carreras.Close()
        Desarrolladores.Close()
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        'ABRIR ------------
        Carreras.Show()
        Carreras.Owner = Me
        LabelActividad.Text = "Carreras"

        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Servicios.Close()
        Clientes.Close()
        Provedores.Close()
        Desarrolladores.Close()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        'ABRIR ------------
        Inventario.Show()
        Inventario.Owner = Me
        LabelActividad.Text = "Inventario"

        'CERRAR -----------------------------------------
        Login.Close()
        Carreras.Close()
        Servicios.Close()
        Clientes.Close()
        Provedores.Close()
        Desarrolladores.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        'ABRIR ------------
        Desarrolladores.Show()
        Desarrolladores.Owner = Me
        LabelActividad.Text = "Desarrolladores"

        'CERRAR -----------------------------------------
        Login.Close()
        Carreras.Close()
        Servicios.Close()
        Clientes.Close()
        Provedores.Close()
        Inventario.Close()


    End Sub

    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click

        Dim impresionForm As New impresionExcel.Form1

        impresionForm.UsuarioLogeado = VARIABLES_GLOBALES.rollUsuarioLogeado
        impresionForm.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class













'FUNCIÓN DE RENDER

Public Class RenderMenu
    Inherits ToolStripProfessionalRenderer
    Public Sub New()
        MyBase.New(New Cols())
    End Sub
End Class

Public Class Cols
    Inherits ProfessionalColorTable

    'over de menu
    'Public Overrides ReadOnly Property MenuItemSelected As Color
    '    ' cuando el menú está seleccionado
    '    Get
    '        Return System.Drawing.Color.FromArgb(180, 125, 255) 'Elige el color que desees para el fondo del menú seleccionado
    '    End Get
    'End Property

    'Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
    '    Get
    '        Return System.Drawing.Color.FromArgb(180, 125, 255) 'Elige el color que desees para el inicio del gradiente del menú seleccionado
    '    End Get
    'End Property

    ''sub menu
    'Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
    '    Get
    '        Return System.Drawing.Color.FromArgb(180, 125, 255) 'Elige el color que desees para el final del gradiente del menú seleccionado
    '    End Get
    'End Property

    'Seleccion de menu

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return System.Drawing.Color.FromArgb(0, 67, 173) 'Elige el color que desees para el inicio del gradiente del submenú seleccionado
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return System.Drawing.Color.FromArgb(0, 67, 173) 'Elige el color que desees para el final del gradiente del submenú seleccionado
        End Get
    End Property
End Class

