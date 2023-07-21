Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class Form1

    Dim querysBDYercken As New querysBDYercken()

    'CARGA DEL FORMS----------------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INICIALIZACIÓN DEL RENDER DEL MENU
        Menu.Renderer = New RenderMenu()


        'SHOW LOGIN
        Login.Show()
        Login.Owner = Me
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

        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Provedores.Close()
        Servicios.Close()
        Carreras.Close()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        'ABRIR ------------
        Servicios.Show()
        Servicios.Owner = Me

        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Provedores.Close()
        Clientes.Close()
        Carreras.Close()

    End Sub

    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvedoresToolStripMenuItem.Click
        'ABRIR ------------
        Provedores.Show()
        Provedores.Owner = Me

        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Servicios.Close()
        Clientes.Close()
        Carreras.Close()

    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        'ABRIR ------------
        Carreras.Show()
        Carreras.Owner = Me

        'CERRAR -----------------------------------------
        Login.Close()
        Inventario.Close()
        Servicios.Close()
        Clientes.Close()
        Provedores.Close()

    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        'ABRIR ------------
        Inventario.Show()
        Inventario.Owner = Me

        'CERRAR -----------------------------------------
        Login.Close()
        Carreras.Close()
        Servicios.Close()
        Clientes.Close()
        Provedores.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
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

