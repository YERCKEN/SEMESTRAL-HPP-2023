﻿Imports System.Threading
Imports System.Timers

Public Class Login

    'VARIABLES
    Dim querysBDYercken As New querysBDYercken()


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Form1.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - Form1.Height) \ 2)
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

        'BOTONES INVISIBLES
        Form1.ClientesToolStripMenuItem.Visible = False
        Form1.ServiciosToolStripMenuItem.Visible = False
        Form1.ProvedoresToolStripMenuItem.Visible = False
        Form1.CarrerasToolStripMenuItem.Visible = False
        Form1.InventarioToolStripMenuItem.Visible = False
        Form1.InformeToolStripMenuItem.Visible = False

        Form1.ToolStripMenuItemCerrarSesion.Visible = False

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


    'BTN LOGIN= ======================================================================================================
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click


        'VERIFICIACIÓN
        If querysBDYercken.Login(textboxUsuario.Text, TextBoxContraseña.Text) > 0 Then


            'MsgBox("CORRECTO INICIASTE")
            querysBDYercken.usuarioLogeado = textboxUsuario.Text
            querysBDYercken.obtenerRolUsuario(querysBDYercken.usuarioLogeado)


            'MsgBox("USUARIO: " & querysBDYercken.usuarioLogeado & vbCrLf & vbCrLf & "ROLL: " & querysBDYercken.rollUsuarioLogeado)

            VARIABLES_GLOBALES.rollUsuarioLogeado = querysBDYercken.rollUsuarioLogeado

            Form1.fcargaDeImagenes()
            'DEFINICIÓN DE VARIABLES GLOBALES
            If querysBDYercken.rollUsuarioLogeado = "Admin" Then

                'REDIRECCIONAR
                Me.Close()

                'BLOQUEAR
                Form1.CarrerasToolStripMenuItem.Visible = False

                'VISIBLES
                Form1.InventarioToolStripMenuItem.Visible = True
                Form1.ClientesToolStripMenuItem.Visible = True
                Form1.ServiciosToolStripMenuItem.Visible = True
                Form1.ProvedoresToolStripMenuItem.Visible = True
                Form1.InformeToolStripMenuItem.Visible = True
                Form1.ToolStripMenuItemCerrarSesion.Visible = True


                Form1.PictureBox2.Image = Form1.listaImagenes(0)
                ' Mostrar el PictureBox si estaba oculto
                Form1.PictureBox2.Visible = True

                ' Iniciar el Timer
                Form1.Timer1.Start()

            ElseIf querysBDYercken.rollUsuarioLogeado = "Usuario" Then

                'REDIRECCIONAR
                Me.Close()

                'BLOQUEAR
                Form1.CarrerasToolStripMenuItem.Visible = False
                Form1.InventarioToolStripMenuItem.Visible = False

                'VISIBLES
                Form1.ServiciosToolStripMenuItem.Visible = True
                Form1.ProvedoresToolStripMenuItem.Visible = True
                Form1.ClientesToolStripMenuItem.Visible = True
                Form1.InformeToolStripMenuItem.Visible = True
                Form1.ToolStripMenuItemCerrarSesion.Visible = True

                Form1.PictureBox2.Image = Form1.listaImagenes(0)
                ' Mostrar el PictureBox si estaba oculto
                Form1.PictureBox2.Visible = True

                ' Iniciar el Timer
                Form1.Timer1.Start()

            ElseIf querysBDYercken.rollUsuarioLogeado = "Coordinador" Then

                'REDIRECCIONAR
                Me.Close()

                'BLOQUEAR
                Form1.ClientesToolStripMenuItem.Visible = False
                Form1.ServiciosToolStripMenuItem.Visible = False
                Form1.ProvedoresToolStripMenuItem.Visible = False

                'VISIBLES
                Form1.CarrerasToolStripMenuItem.Visible = True
                Form1.InventarioToolStripMenuItem.Visible = True
                Form1.InformeToolStripMenuItem.Visible = True
                Form1.ToolStripMenuItemCerrarSesion.Visible = True

                Form1.PictureBox2.Image = Form1.listaImagenes(0)
                ' Mostrar el PictureBox si estaba oculto
                Form1.PictureBox2.Visible = True

                ' Iniciar el Timer
                Form1.Timer1.Start()

            End If



            'FIN
            LabelIncorrecto.Visible = False
        Else
            LabelIncorrecto.Visible = True

        End If

    End Sub


End Class