Imports System.Data.OleDb 'SE IMPORTA PARA TRABAJAR CON BASES DE DATOS ACCESS
Imports System.Text.RegularExpressions 'SE IMPORTA PARA VALIDAR CON EXPRESIONES REGULARES (COMO CORREO ELECTRONICO)

Public Class bd_clientes
    Dim cadena As New OleDbConnection 'CADENA DE CONEXION A LA BASE DE DATOS
    Dim rutaBD As String = System.IO.Path.Combine(Application.StartupPath, "Database2.mdb") 'RUTA DE LA BASE DE DATOS ACCESS


    Private Sub bd_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'SE DEFINE LA CADENA DE CONEXION
            Dim rutaBD As String = System.IO.Path.Combine(Application.StartupPath, "Database2.mdb")
            cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
            Mostrar() 'LLAMA AL METODO PARA MOSTRAR LOS DATOS EN EL DATAGRID


        Catch ex As Exception
            MsgBox("No se ha conectado a la base de datos", vbCritical, "Aviso")
        End Try


        'ANCLA LOS ELEMENTOS PARA QUE SE ADAPTEN A LAS DIMENSIONES DEL FORMULARIO
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        limpiar_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        modificar_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        agregar_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eliminar_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        nombre_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        apellido_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dni_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        direccion_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        localidad_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        orden_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        id_box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        nombre_text.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        apellido_text.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dni_text.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        orden_text.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        localida_text.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dire_text.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub


    'FUNCION PARA MOSTRAR LA TABLA DE CLIENTES
    Private Sub Mostrar()
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Try
            If cadena.State <> ConnectionState.Open Then
                cadena.Open()
            End If

            Dim oda As New OleDbDataAdapter("SELECT * FROM clientes", cadena)
            Dim tabla As New DataTable()
            oda.Fill(tabla)

            DataGridView2.DataSource = tabla 'MUESTRA LOS DATOS EN EL DATAGRID


        Catch ex As Exception
            MsgBox("Error al mostrar los datos: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cadena.Close()
        End Try
    End Sub


    'METODOS PARA MOSTRAR CAMPOS ESPECIFICOS SEGUN EL BOTON


    'MOSTRAR SOLO NOMBRES DE CLIENTES
    Private Sub Mostrar_nomcl()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select nombr_cl from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO ID DEL CLIENTE
    Private Sub Mostrar_id()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select id_cl from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO APELLIDO DE LOS CLIENTES
    Private Sub Mostrar_ape()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select apellido_cl from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO EL DNI DE LOS CLIENTES
    Private Sub Mostrar_dni()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select dni from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO LOS NUMEROS DE ORDEN DE LOS CLIENTES
    Private Sub Mostrar_orden()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select n_orden from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO LAS LOCALIDADES DE LOS CLIENTES
    Private Sub Mostrar_localidad()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select localidad from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO LAS DIRECCIONES DE LOS CLIENTES
    Private Sub Mostrar_direccion()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select dirección from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR  SOLO LOS ID Y NOMBRES DE LOS CLIENTES
    Private Sub Mostrar_idynom()
        Dim oda As New OleDbDataAdapter()
        Dim ods As New DataSet()
        Dim consulta As String

        consulta = "SELECT id_cl, nombr_cl FROM clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    'MOSTRAR SOLO LOS ID Y DNI DE LOS CLIENTES
    Private Sub Mostrar_idydni()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select id_cl, dni from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub



    'MOSTRAR SOLO LOS NOMBRES Y DNI DE LOS CLIENTES
    Private Sub Mostrar_nomydni()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select nombr_cl, dni from clientes"

        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("clientes")
        oda.Fill(ods.Tables("clientes"))

        DataGridView2.DataSource = ods.Tables("clientes")
    End Sub


    '-----------------------------------------------------------------------'



    'BOTONES QUE EJECUTAN FILTROS Y LLAMAN A LAS FUNCIONES
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mostrar_nomcl()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mostrar_id()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mostrar_ape()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Mostrar_dni()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Mostrar_orden()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Mostrar_localidad()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Mostrar_direccion()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Mostrar_idynom()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Mostrar_idydni()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Mostrar_nomydni()
    End Sub

    '------------------------------------------------------------------------



    'FUNCION PARA IMPRIMIR EL PANEL
    Private Sub Imprimir_clientes(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PrintPreviewDialog1.ShowDialog() 'MUESTRA VISTA PREVIA DE IMPRESION
    End Sub



    'CUANDO SE SELECCIONA UNA FILA DEL DATAGRID, SE RELLENAN LOS TEXTBOX CON LOS DATOS DE LA FILA
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            id_box.Text = fila.Cells("id_cl").Value.ToString()
            nombre_box.Text = fila.Cells("nombr_cl").Value.ToString()
            apellido_box.Text = fila.Cells("apellido_cl").Value.ToString()
            dni_box.Text = fila.Cells("dni").Value.ToString()
            orden_box.Text = fila.Cells("n_orden").Value.ToString()
            direccion_box.Text = fila.Cells("dirección").Value.ToString()
            localidad_box.Text = fila.Cells("localidad").Value.ToString()
            correobox.Text = fila.Cells("correo_cl").Value.ToString()
        End If
    End Sub



    'BOTON PARA AGREGAR CLIENTE
    Private Sub agregar_btn_Click(sender As Object, e As EventArgs) Handles agregar_btn.Click
        Dim email As String = correobox.Text
        Dim regex As New Regex("^[^@\s]+@[^@\s]+\.(com)$", RegexOptions.IgnoreCase)

        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD

        'VALIDACION DE CAMPOS VACIOS, DNI Y CORREO
        If nombre_box.Text = "" Or apellido_box.Text = "" Or dni_box.Text = "" Or orden_box.Text = "" Or localidad_box.Text = "" Or direccion_box.Text = "" Or correobox.Text = "" Then
            MessageBox.Show("Todos los campos deben estar llenos para poder agregar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dni_box.Text.Length < 8 Then
            MessageBox.Show("El campo de DNI debe tener al menos 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dni_box.Focus()
        ElseIf Not Regex.IsMatch(email) Then
            MessageBox.Show("Ingrese un correo válido", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            correobox.Focus()
        Else
            Try
                Dim comando As New OleDbCommand("INSERT INTO clientes (nombr_cl, apellido_cl, dni, n_orden, dirección, localidad, correo_cl) VALUES (?, ?, ?, ?, ?, ?, ?)", cadena)
                comando.Parameters.AddWithValue("?", nombre_box.Text)
                comando.Parameters.AddWithValue("?", apellido_box.Text)
                comando.Parameters.AddWithValue("?", dni_box.Text)
                comando.Parameters.AddWithValue("?", orden_box.Text)
                comando.Parameters.AddWithValue("?", localidad_box.Text)
                comando.Parameters.AddWithValue("?", direccion_box.Text)
                comando.Parameters.AddWithValue("?", correobox.Text)

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



    'BOTON DE MODIFICAR CLIENTE
    Private Sub modificar_btn_Click(sender As Object, e As EventArgs) Handles modificar_btn.Click
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        If DataGridView2.CurrentRow IsNot Nothing Then

            Try
                Dim id As Integer = DataGridView2.CurrentRow.Cells("id_cl").Value

                Dim comando As New OleDbCommand("UPDATE clientes SET nombr_cl=?, apellido_cl=?, dni=?, n_orden=?, dirección=?, localidad=?, correo_cl=? WHERE id_cl=?", cadena)
                comando.Parameters.AddWithValue("?", nombre_box.Text)
                comando.Parameters.AddWithValue("?", apellido_box.Text)
                comando.Parameters.AddWithValue("?", dni_box.Text)
                comando.Parameters.AddWithValue("?", orden_box.Text)
                comando.Parameters.AddWithValue("?", localidad_box.Text)
                comando.Parameters.AddWithValue("?", direccion_box.Text)
                comando.Parameters.AddWithValue("?", correobox.Text)
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



    'BOTON DE ELIMINAR CLIENTE
    Private Sub eliminar_btn_Click(sender As Object, e As EventArgs) Handles eliminar_btn.Click
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        If DataGridView2.CurrentRow IsNot Nothing Then

            Try
                Dim id As Integer = DataGridView2.CurrentRow.Cells("id_cl").Value

                Dim comando As New OleDbCommand("DELETE FROM clientes WHERE id_cl=?", cadena)
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

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Mostrar()
    End Sub


    'BOTON BUSCAR CLIENTE (FILTRA POR CUALQUIER CAMPO)
    Private Sub buscar_btn_Click(sender As Object, e As EventArgs) Handles buscar_btn.Click
        cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Try
            Dim consulta As String = "SELECT * FROM clientes WHERE 1=1"
            Dim comando As New OleDbCommand()
            comando.Connection = cadena

            If id_box.Text <> "" Then
                consulta &= " AND id_cl LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & id_box.Text & "%")
            End If

            If nombre_box.Text <> "" Then
                consulta &= " AND nombr_cl LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & nombre_box.Text & "%")
            End If

            If apellido_box.Text <> "" Then
                consulta &= " AND apellido_cl LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & apellido_box.Text & "%")
            End If

            If dni_box.Text <> "" Then
                consulta &= " AND dni LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & dni_box.Text & "%")
            End If

            If orden_box.Text <> "" Then
                consulta &= " AND n_orden LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & orden_box.Text & "%")
            End If

            If direccion_box.Text <> "" Then
                consulta &= " AND dirección LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & direccion_box.Text & "%")
            End If

            If localidad_box.Text <> "" Then
                consulta &= " AND localidad LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & localidad_box.Text & "%")
            End If

            If correobox.Text <> "" Then
                consulta &= " AND correo_cl LIKE ?"
                comando.Parameters.AddWithValue("?", "%" & correobox.Text & "%")
            End If

            comando.CommandText = consulta

            Dim adaptador As New OleDbDataAdapter(comando)
            Dim tabla As New DataTable

            cadena.Open()
            adaptador.Fill(tabla)
            cadena.Close()

            If tabla.Rows.Count > 0 Then
                DataGridView2.DataSource = tabla
            Else
                MsgBox("No se encontraron resultados con los criterios ingresados.", vbExclamation, "Búsqueda")
                DataGridView2.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al buscar: " & ex.Message)
            If cadena.State = ConnectionState.Open Then cadena.Close()
        End Try
    End Sub



    'BOTON PARA LIMPIAR LOS CAMPOS
    Private Sub limpiar_btn_Click(sender As Object, e As EventArgs) Handles limpiar_btn.Click
        id_box.Text = ""
        nombre_box.Text = ""
        apellido_box.Text = ""
        dni_box.Text = ""
        orden_box.Text = ""
        localidad_box.Text = ""
        direccion_box.Text = ""
        correobox.Text = ""
    End Sub


End Class