Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

    End Sub



    'TEXT BOX PLACEHOLDER ===============================================================================
    Private Sub textboxUsuario_GotFocus(sender As Object, e As EventArgs) Handles textboxUsuario.GotFocus
        If textboxUsuario.Text = "Usuario" Then
            textboxUsuario.Text = ""
        End If
    End Sub

    Private Sub textboxUsuario_LostFocus(sender As Object, e As EventArgs) Handles textboxUsuario.LostFocus
        If textboxUsuario.Text = "" Then
            textboxUsuario.Text = "Usuario"
            textboxUsuario.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub

    Private Sub TextBoxContraseña_GotFocus(sender As Object, e As EventArgs) Handles TextBoxContraseña.Enter
        If TextBoxContraseña.Text = "Contraseña" Then
            TextBoxContraseña.Text = ""
        End If
    End Sub

    Private Sub TextBoxContraseña_LostFocus(sender As Object, e As EventArgs) Handles TextBoxContraseña.Leave
        If TextBoxContraseña.Text = "" Then
            TextBoxContraseña.Text = "Contraseña"
            TextBoxContraseña.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub
End Class