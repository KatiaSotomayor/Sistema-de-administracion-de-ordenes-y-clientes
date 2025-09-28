Imports System.Data.OleDb 'SE IMPORTA PARA PODER TRABAJAR CON BASES DE DATOS ACCESS

Public Class Form1
    Dim opacidadActual As Single = 0.0F 'CONTROLA LA OPACIDAD DE LA IMAGEN EN EL FADE
    Dim imagenOriginal As Image 'ACA SE GUARDA LA IMAGEN ORIGINAL ANTES DE APLICARLE EFECTOS
    Dim enFadeIn As Boolean = True 'ESTO ES PARA SABER SI ESTOY EN FASE DE ENTRADA (FADE IN)

    Dim cadena As New OleDbConnection 'CONEXION CON LA BASE DE DATOS

    'CUANDO SE CARGA EL FORMULARIO
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cursor.Hide() 'SE ESCONDE EL CURSOR CUANDO SE INICIA EL FORMULARIO

        PictureBox3.Dock = DockStyle.Fill 'PICTUREBOX3 OCUPA TODA LA PANTALLA
        PictureBox3.Visible = True

        imagenOriginal = PictureBox4.BackgroundImage 'SE GUARDA LA IMAGEN ORIGINAL

        'EMPIEZA EL EFECTO DE OPACIDAD EN CERO
        PictureBox4.BackgroundImage = CambiarOpacidad(imagenOriginal, 0.0F)
        opacidadActual = 0.0F
        enFadeIn = True

        Timer3.Interval = 50 'VELOCIDAD DEL TIMER EN EL FADE
        Timer3.Start()


        'TIMER PARA OCULTAR LA PANTALLA INICIAL
        Timer2.Start()
        Label4.Visible = False
        Label5.Visible = False
        Me.WindowState = FormWindowState.Maximized  'MAXIMIZA LA VENTANA


        'SE INTENTA CONECTAR LA BASE DE DATOS
        Try
            Dim rutaBD As String = System.IO.Path.Combine(Application.StartupPath, "Database2.mdb")
            cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD

            Mostrar() 'LLAMO A LA FUNCION MOSTRAR PARA CARGAR LOS DATOS EN EL DATAGRID


        Catch ex As Exception
            MsgBox("No se ha conectado a la base de datos", vbCritical, "Aviso")
        End Try


        'SE AJUSTAN TODOS LOS CONTROLES PARA QUE SE ADAPTEN AL TAMAÑO DE LA VENTANA
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        usuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        contra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        punto1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        punto2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        punto3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub

    ' FUNCION PARA CAMBIAR LA OPACIDAD DE LA IMAGEN
    Public Function CambiarOpacidad(imagenOriginal As Image, opacidad As Single) As Image
        Dim bmp As New Bitmap(imagenOriginal.Width, imagenOriginal.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim cm As New Imaging.ColorMatrix()
            cm.Matrix33 = opacidad 'SE APLICA OPACIDAD EN EL CANAL ALFA

            Dim ia As New Imaging.ImageAttributes()
            ia.SetColorMatrix(cm, Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Bitmap)

            g.DrawImage(imagenOriginal, New Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, imagenOriginal.Width, imagenOriginal.Height,
                    GraphicsUnit.Pixel, ia)
        End Using
        Return bmp
    End Function

    ' ANIMACION DE ENTRADA SUAVE - FADE IN
    Public Async Function FadeIn() As Task

        Dim imagenOriginal As Image = PictureBox4.BackgroundImage
        For i As Single = 0.0F To 1.0F Step 0.02F
            PictureBox4.BackgroundImage = CambiarOpacidad(imagenOriginal, i)
            Await Task.Delay(25)
        Next
    End Function

    ' ANIMACION DE SALIDA SUAVE - FADE OUT
    Public Async Function FadeOut() As Task
        Dim imagenOriginal As Image = PictureBox4.BackgroundImage
        For i As Single = 1.0F To 0.0F Step -0.02F
            PictureBox4.BackgroundImage = CambiarOpacidad(imagenOriginal, i)
            Await Task.Delay(25)
        Next
    End Function


    ' TIMER QUE MANEJA EL PROGRESO DE LA BARRA DE CARGA UNA VEZ QUE SE INICIO SESION
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value = 20 Then
            punto1.Visible = True
        End If
        If ProgressBar1.Value = 50 Then
            punto2.Visible = True
        End If
        If ProgressBar1.Value = 80 Then
            punto3.Visible = True
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide() 'ESCONDE EL FORMULARIO ACTUAL
            bases_de_datos.Show() 'ABRE EL FORMULARIO QUE TIENE LA BASE DE DATOS PRINCIPAL
        End If
    End Sub



    'FUNCION PARA MOSTRAR LOS DATOS EN LA TABLA DE INICIO

    'SOBRE LA TABLA DE DATOS DE "INICIO"
    'Esta tabla contiene los datos de usuario, para administrar usuarios y crearlos
    'Esta en un DataGrid invisible en el form1 para que se puedan tomar los datos
    Private Sub Mostrar()
        Try
            Dim oda As New OleDbDataAdapter("SELECT * FROM inicio", cadena)
            Dim tabla As New DataTable()
            oda.Fill(tabla)

            DataGridView1.DataSource = tabla


        Catch ex As Exception
            MsgBox("Error al mostrar los datos: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cadena.Close()
        End Try



    End Sub

    'BOTON DE INICIO DE SESION
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        detectar()
        detectar2()

        If detectar() = 1 And detectar2() = 1 Then

            Timer1.Enabled = True
            Me.Cursor = Cursors.AppStarting
            Button1.Enabled = False
            ProgressBar1.Visible = True
            Label5.Visible = False
            Label4.Visible = True
            aceptar.Enabled = False
            ojo1.Enabled = False
            ojo2.Enabled = False
            aceptar.Enabled = False
            Button4.Enabled = False


        ElseIf detectar() = 0 Or detectar2() = 0 Or usuario.Text = "" Or contra.Text = "" Then
            Label5.Visible = True
            contra.Text = ""
            usuario.Text = ""
        End If
    End Sub


    'BOTON PARA SALIR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    'MOSTRAR/OCULTAR EL DATA GRID VIEW DE INICIO SESION
    'EL CUAL ESTA EN INVISIBLE
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.Visible = True Then
            DataGridView1.Visible = False
            Button3.Text = "OCULTAR"
        Else
            DataGridView1.Visible = True
            Button3.Text = "VER"
        End If
    End Sub


    'FUNCION PARA VERIFICAR SI EL USUARIO EXISTE
    Function detectar() As Integer
        Dim veri As Integer = 0
        Try
            cadena.Open()
            Dim query = "SELECT COUNT(*) FROM inicio WHERE nom_user = @nom_user"
            Dim command As New OleDb.OleDbCommand(query, cadena)
            command.Parameters.AddWithValue("@nom_user", usuario.Text)
            Dim resultado As Integer = Convert.ToInt32(command.ExecuteScalar())
            If resultado > 0 Then
                veri = 1
            End If
        Catch ex As Exception
            veri = 1   'NO TOCAR
        Finally
            cadena.Close()
        End Try
        Return veri
    End Function


    'VERIFICA SI LA CONTRASEÑA EXISTE
    Function detectar2() As Integer
        Dim veri2 As Integer = 0
        Try
            cadena.Open()
            Dim query2 = "SELECT COUNT(*) FROM inicio WHERE contraseña = @contraseña"
            Dim command2 As New OleDb.OleDbCommand(query2, cadena)
            command2.Parameters.AddWithValue("@contraseña", contra.Text)
            Dim resultado2 As Integer = Convert.ToInt32(command2.ExecuteScalar())
            If resultado2 > 0 Then
                veri2 = 1
            End If
        Catch ex As Exception
            veri2 = 1 'NO TOCAR
        Finally
            cadena.Close()
        End Try
        Return veri2

    End Function


    'MOSTRAS/OCULTAR CONTRASEÑA (BOTON CON ICONO DE OJO)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If contra.PasswordChar = "*" Then
            contra.PasswordChar = ""

            Button4.BackgroundImage = My.Resources.ojo_cerrado
        Else
            contra.PasswordChar = "*"
            Button4.BackgroundImage = My.Resources.ojo_abierto
        End If
    End Sub



    'BOTON PARA CREAR USUARIO (CON VALIDACIONES DE SEGURIDAD EN LA CONTRASEÑA
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        Dim numeros As Integer = 0
        Dim mayusculas As Integer = 0
        Dim minusculas As Integer = 0
        Dim texto As String = contrabox.Text


        'VALIDACION DE CAMPOS VACIOS
        If String.IsNullOrWhiteSpace(usuariobox.Text) OrElse
       String.IsNullOrWhiteSpace(contrabox.Text) OrElse
       String.IsNullOrWhiteSpace(repcontrabox.Text) Then

            MessageBox.Show("Todos los campos deben estar llenos.")
            Return
        End If


        'RECORRO LA CONTRASEÑA Y CUENTO TIPOS DE CARACTERES
        For Each c As Char In texto
            If Char.IsDigit(c) Then
                numeros += 1
            ElseIf Char.IsUpper(c) Then
                mayusculas += 1
            ElseIf Char.IsLower(c) Then
                minusculas += 1
            End If

        Next


        'VALIDACIONES
        If contrabox.Text <> repcontrabox.Text Then

            noiguales.Visible = True
            contrabox.Text = ""
            repcontrabox.Text = ""

        ElseIf texto.Length < 8 Or numeros < 2 Or mayusculas < 2 Or minusculas < 2 Then

            MessageBox.Show("La contraseña debe tener al menos 8 caracteres. También debe tener al menos 2 minúsculas, 2 mayúsculas y 2 números para ser válida")

        ElseIf contrabox.Text = "" Or repcontrabox.Text = "" Or usuariobox.Text = "" Then
            MessageBox.Show("Todos los campos deben estar llenos")

        Else
            noiguales.Visible = False

            Try
                cadena.Open()
                Dim comando As New OleDbCommand("INSERT INTO inicio (nom_user, contraseña) VALUES (?, ?)", cadena)
                comando.Parameters.AddWithValue("?", usuariobox.Text)
                comando.Parameters.AddWithValue("?", contrabox.Text)

                comando.ExecuteNonQuery()
                MessageBox.Show("Usuario creado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                contrabox.Text = ""
                usuariobox.Text = ""
                repcontrabox.Text = ""

            Catch ex As Exception
                MessageBox.Show("Error al crear usuario: " & ex.Message)
            Finally

                Mostrar()

            End Try
        End If
    End Sub


    '--------------------------------------------------------------


    'CAMBIO DE IMAGEN DE LOS BOTONES DE OJO
    Private Sub ojo1_Click(sender As Object, e As EventArgs) Handles ojo1.Click
        If repcontrabox.PasswordChar = "*" Then
            repcontrabox.PasswordChar = ""

            ojo1.BackgroundImage = My.Resources.ojo_cerrado
        Else

            repcontrabox.PasswordChar = "*"
            ojo1.BackgroundImage = My.Resources.ojo_abierto
        End If
    End Sub

    Private Sub ojo2_Click(sender As Object, e As EventArgs) Handles ojo2.Click
        If contrabox.PasswordChar = "*" Then
            contrabox.PasswordChar = ""

            ojo2.BackgroundImage = My.Resources.ojo_cerrado
        Else
            contrabox.PasswordChar = "*"
            ojo2.BackgroundImage = My.Resources.ojo_abierto
        End If
    End Sub




    '-----------------------------------------------------



    'TIMER QUE OCULTA LA PANTALLA INICIAL Y MUESTRA EL CURSOR
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox3.Visible = False
        Timer2.Stop()
        Cursor.Show()
    End Sub



    'TIMER QUE MANEJA EL FADE DE LA IMAGEN
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If enFadeIn Then
            opacidadActual += 0.05F
            If opacidadActual >= 1.0F Then
                opacidadActual = 1.0F
                enFadeIn = False
                'PAUSA ANTES DEL FADE
                Timer3.Stop()
                Task.Delay(1000).ContinueWith(Sub() Timer3.Start(), TaskScheduler.FromCurrentSynchronizationContext())
            End If
        Else
            opacidadActual -= 0.05F
            If opacidadActual <= 0.0F Then
                opacidadActual = 0.0F
                Timer3.Stop()
                PictureBox4.Visible = False
            End If
        End If

        PictureBox4.BackgroundImage = CambiarOpacidad(imagenOriginal, opacidadActual)
    End Sub


    'BOTON QUE PRUEVA LA CONEXION Y MUESTRA LA RUTA DE LA BASE DE DATOS
    'Creada y usada en caso de que se pierda la dirección de la base de datos
    'o haya problemas sobre la direccion
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim rutaBD As String = System.IO.Path.Combine(Application.StartupPath, "Database2.mdb")
            MsgBox("Ruta usada: " & rutaBD)

            If Not System.IO.File.Exists(rutaBD) Then
                MsgBox("NO SE ENCONTRÓ EL ARCHIVO EN ESA RUTA")
                Exit Sub
            End If

            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD)
            con.Open()
            MsgBox("¡Conexión exitosa!", MsgBoxStyle.Information)
            con.Close()
        Catch ex As Exception
            MsgBox("Error de conexión: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    'BOTON QUE PREGUNTA ANTES DE SALIR DEL PROGRAMA
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Seguro que quieres salir del programa?", "Confirmar salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub
End Class
