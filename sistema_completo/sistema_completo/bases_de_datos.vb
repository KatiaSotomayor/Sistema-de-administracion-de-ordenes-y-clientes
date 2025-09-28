Public Class bases_de_datos

    Private Sub bases_de_datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuStrip1.Renderer = New CustomMenuRenderer()
        Me.WindowState = FormWindowState.Maximized  ' MAXIMIZA LA VENTANA AL ABRIRSE
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        panelContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        'CODIGO PARA QUE SE CARGUE UN FORM DENTRO DE UN PANEL
        Dim client_form As New bd_clientes()
        client_form.TopLevel = False  'EVITA QUE SEA UNA VENTANA INDEPENDIENTE
        client_form.FormBorderStyle = FormBorderStyle.None  'SACA LOS BORDES
        panelContainer.Controls.Clear()  'LIMPIA EL CONTENIDO ANTERIOR
        panelContainer.Controls.Add(client_form)  'AGREGA EL FORMULARIO AL PANEL

        client_form.Show()  'MUESTRA EL FORMULARIO DENTRO DEL PANEL
    End Sub


    'PERSONALIZACION DE MENU
    Public Class CustomMenuRenderer
        Inherits ToolStripProfessionalRenderer

        'PERSONALIZACION DE COLORES
        Private hoverColor As Color = Color.FromArgb(0, 4, 94)
        Private pressedColor As Color = Color.FromArgb(0, 6, 32)
        Private normalColor As Color = Color.FromArgb(0, 20, 108)
        Private textColor As Color = Color.White

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            Dim g = e.Graphics
            Dim item = e.Item
            Dim rect = New Rectangle(Point.Empty, item.Size)

            If item.Selected Then
                g.FillRectangle(New SolidBrush(hoverColor), rect)
            ElseIf CType(item, ToolStripMenuItem).Pressed Then
                g.FillRectangle(New SolidBrush(pressedColor), rect)
            Else
                g.FillRectangle(New SolidBrush(normalColor), rect)
            End If
        End Sub

        Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
            e.TextColor = textColor
            e.TextFont = New Font("SimSun", 14, FontStyle.Bold)
            MyBase.OnRenderItemText(e)
        End Sub
    End Class

    Private Sub ClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'PARA QUE SE CARGUE EL FORM DE CLIENTES DENTRO DE UN PANEL
        Dim client_form As New bd_clientes()
        client_form.TopLevel = False  'EVITA QUE SEA UNA VENTANA INDEPENDIENTE
        client_form.FormBorderStyle = FormBorderStyle.None  'QUITA LOS BORDES
        panelContainer.Controls.Clear()  'LIMPIA LO QUE HABIA ANTES
        panelContainer.Controls.Add(client_form)  'AGREGA EL FORMULARIO DENTRO DEL PANEL

        client_form.Show()  'MUESTRA FORMULARIO DENTRO DEL PANEL


    End Sub

    'BOTON PARA ACCEDER A LAS ORDENES
    Private Sub OrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesToolStripMenuItem.Click
        Dim frm2 As New Form2()
        frm2.TopLevel = False
        frm2.FormBorderStyle = FormBorderStyle.None
        panelContainer.Controls.Clear()
        panelContainer.Controls.Add(frm2)
        frm2.Show()
    End Sub

    'BOTON PARA ACCEDER A ACERCA DE
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, "acerca_de.html")
        If System.IO.File.Exists(rutaArchivo) Then
            Process.Start(New ProcessStartInfo With {
                .FileName = rutaArchivo,
                .UseShellExecute = True
            })
        Else
            'SI NO SE ENCUENTRA EL ARCHIVO HTML DE ACERCA DE
            MessageBox.Show("El archivo HTML no se encontró en: " & rutaArchivo)
        End If
    End Sub


    'BOTON PARA ACCEDER AL MANUAL DE USUARIO
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, "manual.html")

        If System.IO.File.Exists(rutaArchivo) Then
            Process.Start(New ProcessStartInfo With {
                .FileName = rutaArchivo,
                .UseShellExecute = True
            })
        Else
            'SI NO ENCUENTRA EL MANUAL DE USUARIO
            MessageBox.Show("El archivo HTML no se encontró en: " & rutaArchivo)
        End If
    End Sub

    'BOTON PARA SALIR
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Seguro que quieres salir del programa?", "Confirmar salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub
End Class