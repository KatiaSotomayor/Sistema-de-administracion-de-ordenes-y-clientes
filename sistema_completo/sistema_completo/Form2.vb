Imports System.Data.OleDb 'PARA TRABAJAR CON ACCESS
Imports itextsharp.text 'CREAR DOCUMENTOS PDF
Imports itextsharp.pdfa 'COMPATIBILIDAD CON PDF/A
Imports itextsharp.text.pdf 'HERRAMIENTAS PARA PDF (ESCRITURA, IMAGENES)
Imports System.IO 'MANEJO DE ARCHIVOS
Imports System.Drawing.Printing 'PARA FUNCIONES DE IMPRESION
Imports System.Collections.ObjectModel 'COLECCIONES DE .NET
Imports System.Net 'REDES
Imports System.Net.Mail 'PARA ENVIAR CORREOS ELECTRONICOS



Public Class Form2

    Dim cadena As New OleDbConnection 'CADENA DE CONEXION
    Dim rutaBD As String = System.IO.Path.Combine(Application.StartupPath, "Database2.mdb")

    Public Property A4 As itextsharp.text.Rectangle

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'SE DEFINE LA CADENA DE CONEXION
            Dim rutaBD As String = System.IO.Path.Combine(Application.StartupPath, "Database2.mdb")
            cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
            Mostrar() 'MUESTRA LAS ORDENES EN EL DATAGRID


        Catch ex As Exception
            MsgBox("No se ha conectado a la base de datos", vbCritical, "Aviso")
        End Try


        'ANCLA TODOS LOS ELEMENTOS PARA QUE SE ADAPTEN A LAS DIMENSIONES DLE FORMULARIO
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        descripción_ord_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        precio_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fecha_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        n_orden_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        modificar_btn2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eliminar_btn2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        agregar_btn2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buscar_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

    End Sub


    'MOSTRAR TODAS LAS ORDENES EN EL DATA GRID
    Private Sub Mostrar()
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select * from Orden"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("Orden")
        oda.Fill(ods.Tables("Orden"))

        DataGridView3.DataSource = ods.Tables("Orden")
    End Sub

    'IMPRIME EL PANEL CON LAS ORDENES
    Private Sub ImprimirOrdenes(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim bm2 As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm2, New System.Drawing.Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm2, 0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog2.ShowDialog() 'VISTA PREVIA DE LA IMPRESION
    End Sub



    'BOTON PARA CREAR FACTURA EN PDF
    Private Sub crear_pdf_Click(sender As Object, e As EventArgs) Handles crear_pdf.Click

        'VALIDA QUE TODOS LOS CAMPOS ESTEN LLENOS
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Or correo_box.Text = "" Then
            MessageBox.Show("Todos los campos deben estar llenos para poder crear una factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'GUARDADO DEL PDF
            Dim SaveFileDialog As New SaveFileDialog
            Dim ruta As String
            With SaveFileDialog
                .Title = "Guardar"
                'SE SELECCIONA LA RUTA DE GENERACION POR DEFECTO
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                .Filter = "Archivos PDF (*.pdf)|*.pdf"
                .FileName = "Factura_cliente_" & TextBox4.Text & "_orden_" & TextBox2.Text
                .OverwritePrompt = True
                .CheckFileExists = False
            End With


            'SE GUARDA EN LA RUTA
            If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ruta = SaveFileDialog.FileName
            Else
                ruta = String.Empty
                Exit Sub
            End If


            'GENERACION DEL PDF
            Try
                'ACA SE CREA EL DOCUMENTP
                Dim documento As New itextsharp.text.Document(itextsharp.text.PageSize.A4)

                documento.AddAuthor("Empresa AKA  -  Reparaciones informaticas")
                documento.AddTitle("Factura")

                Dim writer As PdfWriter = PdfWriter.GetInstance(documento, New System.IO.FileStream(ruta, System.IO.FileMode.Create))

                'PARA QUE EL DOC SEA PRESENTADO EN PAGINA SIMPLE
                writer.ViewerPreferences = PdfWriter.PageLayoutSinglePage


                'ABRIMOS EL DOC PARA EMPEZAR A ESCRIBIR
                documento.Open()

                'FUENTES Y ESTILOS
                Dim titulofont As itextsharp.text.Font = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25, BaseColor.BLACK)
                Dim titulo As New Paragraph("Factura", titulofont)
                titulo.Alignment = Element.ALIGN_CENTER
                Dim akatitulo As itextsharp.text.Font = FontFactory.GetFont(FontFactory.COURIER_BOLD, 20)
                Dim fuente As itextsharp.text.Font = FontFactory.GetFont(FontFactory.COURIER_BOLD, 10)

                'LOGO DE LA EMPRESA
                Dim logo As itextsharp.text.Image = itextsharp.text.Image.GetInstance("imagenes\logo_azul.png")
                logo.ScaleAbsolute(100, 100)
                logo.SetAbsolutePosition(40, documento.PageSize.Height - 120)


                'ICONO DE TELEFONO
                Dim telefono As itextsharp.text.Image = itextsharp.text.Image.GetInstance("imagenes\telefono_icono.png")
                telefono.ScaleAbsolute(15, 15)
                telefono.SetAbsolutePosition(40, documento.PageSize.Height - 680)

                'CONTENIDO DEL PDF
                Dim cb As PdfContentByte = writer.DirectContent
                cb.BeginText()
                cb.AddImage(logo)

                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(titulo)
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Empresa AKA - Reparaciones informaticas", akatitulo))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Factura emitida el " & Date.Today.ToShortDateString(), fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Fecha de la realización de la orden: " & TextBox1.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Orden N° " & TextBox2.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Descripción de la orden: " & TextBox3.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Cliente N° " & TextBox4.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Nombre y apellido: " & TextBox5.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("DNI: " & TextBox6.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Domicilio: " & TextBox7.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Monto final: $" & TextBox9.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Correo: " & correo_box.Text, fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("Si su pedido es incorrecto, le fue enviado el pedido de alguien más o no se envió su pedido correspondiente, llame a nuestro número de reclamos:", fuente))
                documento.Add(New Paragraph("         "))
                cb.AddImage(telefono)
                documento.Add(New Paragraph("      +54 9 11 ********", fuente))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))
                documento.Add(New Paragraph("         "))



                cb.EndText()
                documento.Close()

            Catch ex As Exception
                MessageBox.Show("Error en la generación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'GUARDA LA RUTA DEL PDF EN UN TEXTBOX
            TextBox8.Text = ruta
            '''''''''
        End If

    End Sub


    'BOTON PARA MODIFICAR LAS ORDENES
    Private Sub modificar_btn2_Click(sender As Object, e As EventArgs) Handles modificar_btn2.Click
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        If DataGridView3.CurrentRow IsNot Nothing Then
            Try
                Dim id As Integer = DataGridView3.CurrentRow.Cells("n_orden").Value

                Dim comando As New OleDbCommand("UPDATE Orden SET descripción_ord=?, precio=?  WHERE n_orden=?", cadena)
                comando.Parameters.AddWithValue("?", descripción_ord_box.Text)
                comando.Parameters.AddWithValue("?", precio_box.Text)
                comando.Parameters.AddWithValue("?", n_orden_box.Text)
                comando.Parameters.AddWithValue("?", id)

                cadena.Open()
                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al modificar: " & ex.Message)
            Finally

                cadena.Close()

                Mostrar()
            End Try
        End If
    End Sub


    'BOTON PARA AGREGAR ORDENES
    Private Sub agregar_btn2_Click(sender As Object, e As EventArgs) Handles agregar_btn2.Click
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        If n_orden_box.Text = "" Or descripción_ord_box.Text = "" Or precio_box.Text = "" Or fecha_box.Text = "" Then
            MessageBox.Show("Todos los campos deben estar llenos para poder agregar una orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim comando As New OleDbCommand("INSERT INTO Orden (descripción_ord, precio, fecha_orden) VALUES (?, ?, ?)", cadena)
                comando.Parameters.AddWithValue("?", descripción_ord_box.Text)
                comando.Parameters.AddWithValue("?", precio_box.Text)
                comando.Parameters.AddWithValue("?", fecha_box.Text)
                comando.Parameters.AddWithValue("?", n_orden_box.Text)

                cadena.Open()
                comando.ExecuteNonQuery()
                MsgBox("Registro agregado con éxito.", vbInformation, "Exito")

            Catch ex As Exception
                MsgBox("Error al agregar: " & ex.Message)
            Finally
                cadena.Close()
                Mostrar()
            End Try
        End If


    End Sub


    'CUANDO SE SELECCIONA UNA CELDA DE LA TABLA DE ORDENES
    'SE RELLENAN LOS CAMPOS CON LOS DATOS CORRESPONDIENTES A ESA ORDEN Y A QUE CLIENTE ESTA RELACIONADO
    'SEGUN EL N_ORDEN
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        cadena.Open()
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""



        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
            descripción_ord_box.Text = fila.Cells("descripción_ord").Value.ToString()
            precio_box.Text = fila.Cells("precio").Value.ToString()
            fecha_box.Text = fila.Cells("fecha_orden").Value.ToString()
            n_orden_box.Text = fila.Cells("n_orden").Value.ToString()

            TextBox1.Text = fila.Cells("fecha_orden").Value.ToString()
            TextBox2.Text = fila.Cells("n_orden").Value.ToString()
            TextBox3.Text = fila.Cells("descripción_ord").Value.ToString()
            TextBox9.Text = fila.Cells("precio").Value.ToString()
            Try
                Dim n_orden As String = DataGridView3.Rows(e.RowIndex).Cells("n_orden").Value.ToString()
                Dim nosexd As String = "SELECT * FROM clientes WHERE n_orden = @n_orden"
                Dim cmd As New OleDbCommand(nosexd, cadena)
                cmd.Parameters.AddWithValue("@n_orden", n_orden)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim nombre = reader("nombr_cl").ToString()
                    Dim apellido = reader("apellido_cl").ToString()
                    TextBox4.Text = reader("id_cl").ToString()
                    TextBox5.Text = nombre + " " + apellido
                    TextBox6.Text = reader("dni").ToString()
                    Dim domicilio = reader("dirección").ToString()
                    Dim localidad = reader("localidad").ToString()
                    TextBox7.Text = domicilio + ", " + localidad
                    correo_box.Text = reader("correo_cl").ToString()
                    correo_para.Text = reader("correo_cl").ToString()




                Else
                    ' SI NO ENCUENTRA AL CLIENTE
                    MessageBox.Show("No se encontró cliente para esta orden.")
                End If

                asunto_box.Text = "✅AKA Orden N° " & TextBox2.Text & " - " & TextBox5.Text & "-" & Date.Today.ToShortDateString()
                msj.Text = "¡Gracias por su compra, " & TextBox5.Text & "! Su pedido estará listo entre 2 o 5 días. Si no, puede retirarlo en nuestra sede en ******* en cuanto el pedido esté listo.

Saludos,
El equipo de AKA


©2025 AKA Inc. Todos los derechos reservados.
                "


                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                cadena.Close()
            End Try
        End If
    End Sub


    'BOTON DE ELIMINAR ORDEN
    Private Sub eliminar_btn2_Click(sender As Object, e As EventArgs) Handles eliminar_btn2.Click
        If DataGridView3.CurrentRow IsNot Nothing Then
            Try
                Dim id As Integer = DataGridView3.CurrentRow.Cells("n_orden").Value

                Dim comando As New OleDbCommand("DELETE FROM Orden WHERE n_orden=?", cadena)
                comando.Parameters.AddWithValue("?", id)

                cadena.Open()
                comando.ExecuteNonQuery()
                MsgBox("Registro eliminado con éxito.", vbInformation, "Éxito")
            Catch ex As Exception
                MsgBox("Error al eliminar: " & ex.Message)
            Finally
                cadena.Close()

                Mostrar()
            End Try
        End If
    End Sub


    'BOTON DE LIMPIAR TEXTBOX Y CAMPOS
    Private Sub limpiar_btn_Click(sender As Object, e As EventArgs) Handles limpiar_btn.Click
        descripción_ord_box.Text = ""
        precio_box.Text = ""
        n_orden_box.Text = ""
        fecha_box.Text = ""
    End Sub

    'BOTON DE BUSCAR ORDENES SEGUN CAMPOS
    Private Sub buscar_btn_Click(sender As Object, e As EventArgs) Handles buscar_btn.Click
        Try
            Dim consulta As String = "SELECT * FROM Orden WHERE 1=1"
            Dim comando As New OleDbCommand()
            comando.Connection = cadena

            If descripción_ord_box.Text <> "" Then
                consulta &= " AND descripción_ord LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & descripción_ord_box.Text & "%")
            End If

            If n_orden_box.Text <> "" Then
                consulta &= " AND n_orden LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & n_orden_box.Text & "%")
            End If

            If precio_box.Text <> "" Then
                consulta &= " AND precio LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & precio_box.Text & "%")
            End If

            If fecha_box.Text <> "" Then
                consulta &= " AND fecha_orden LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & fecha_box.Text & "%")
            End If

            comando.CommandText = consulta

            Dim adaptador As New OleDbDataAdapter(comando)
            Dim tabla As New DataTable

            cadena.Open()
            adaptador.Fill(tabla)
            cadena.Close()

            If tabla.Rows.Count > 0 Then
                DataGridView3.DataSource = tabla
            Else
                MsgBox("No se encontraron resultados con los criterios ingresados.", vbExclamation, "Búsqueda")
                DataGridView3.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al buscar: " & ex.Message)
            If cadena.State = ConnectionState.Open Then cadena.Close()
        End Try
    End Sub



    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Try
            Me.Cursor = Cursors.AppStarting
            Dim mensaje As New MailMessage()
            mensaje.From = New MailAddress("") 'ACA INGRESE EL CORREO ELECTRONICO DEL CUAL QUIERE ENVIAR LA FACTURA'
            mensaje.To.Add(correo_para.Text.Trim())
            mensaje.Subject = asunto_box.Text
            mensaje.Body = msj.Text

            'SE ADJUNTA EL PDF
            If File.Exists(TextBox8.Text) Then
                Dim adjunto As New Attachment(TextBox8.Text)
                mensaje.Attachments.Add(adjunto)
            Else
                MessageBox.Show("No se encontró el archivo adjunto.")
                Exit Sub
            End If

            'CLIENTE SMTP 
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True

            'EN DONDE DICE "CORREO ELECTRONICO EMISOR" DEBE ESCRIBIRSE EL CORREO DEL CUAL QUIERE ENVIAR LAS FACTURAS
            smtp.Credentials = New NetworkCredential("CORREO ELECTRONICO EMISOR", "CODIGO DE INGRESO")

            'ENVIAR
            smtp.Send(mensaje)
            MessageBox.Show("Factura enviada correctamente al cliente.", "Envío exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class