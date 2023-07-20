Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Menu.Renderer = New RenderMenu()
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
    Public Overrides ReadOnly Property MenuItemSelected As Color
        ' cuando el menú está seleccionado
        Get
            Return System.Drawing.Color.FromArgb(63, 0, 148) 'Elige el color que desees para el fondo del menú seleccionado
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return System.Drawing.Color.FromArgb(63, 0, 148) 'Elige el color que desees para el inicio del gradiente del menú seleccionado
        End Get
    End Property
    'sub menu
    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return System.Drawing.Color.FromArgb(63, 0, 148) 'Elige el color que desees para el final del gradiente del menú seleccionado
        End Get
    End Property
    'Seleccion de menu

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return System.Drawing.Color.FromArgb(63, 0, 148) 'Elige el color que desees para el inicio del gradiente del submenú seleccionado
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return System.Drawing.Color.FromArgb(63, 0, 148)  'Elige el color que desees para el final del gradiente del submenú seleccionado
        End Get
    End Property
End Class

