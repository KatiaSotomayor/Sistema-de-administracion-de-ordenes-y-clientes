<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.crear_pdf = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.descripción_ord_box = New System.Windows.Forms.TextBox()
        Me.precio_box = New System.Windows.Forms.TextBox()
        Me.modificar_btn2 = New System.Windows.Forms.Button()
        Me.agregar_btn2 = New System.Windows.Forms.Button()
        Me.eliminar_btn2 = New System.Windows.Forms.Button()
        Me.limpiar_btn = New System.Windows.Forms.Button()
        Me.buscar_btn = New System.Windows.Forms.Button()
        Me.n_orden_box = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecha_box = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.correo_box = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.correo_de = New System.Windows.Forms.TextBox()
        Me.correo_para = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.asunto_box = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.msj = New System.Windows.Forms.TextBox()
        Me.enviar = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(783, 544)
        Me.DataGridView3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(44, 647)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 102)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Imprimir base de datos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.DataGridView3)
        Me.Panel1.Location = New System.Drawing.Point(30, 81)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 552)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1025, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Factura"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(887, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero orden:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(867, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero cliente:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(837, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción orden:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(837, 279)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre y Apellido:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(977, 326)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "DNI:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(917, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Domicilio:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(957, 116)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Fecha:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1031, 114)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 27)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1031, 155)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 27)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1031, 197)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 27)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(1031, 240)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 27)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1031, 282)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(272, 27)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1031, 326)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(132, 27)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox7.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1031, 368)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 27)
        Me.TextBox7.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox9.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(1031, 458)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(132, 27)
        Me.TextBox9.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(897, 458)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Monto total:"
        '
        'crear_pdf
        '
        Me.crear_pdf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.crear_pdf.BackgroundImage = CType(resources.GetObject("crear_pdf.BackgroundImage"), System.Drawing.Image)
        Me.crear_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.crear_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.crear_pdf.FlatAppearance.BorderSize = 0
        Me.crear_pdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.crear_pdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.crear_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.crear_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crear_pdf.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crear_pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.crear_pdf.Location = New System.Drawing.Point(1017, 502)
        Me.crear_pdf.Margin = New System.Windows.Forms.Padding(4)
        Me.crear_pdf.Name = "crear_pdf"
        Me.crear_pdf.Size = New System.Drawing.Size(169, 41)
        Me.crear_pdf.TabIndex = 22
        Me.crear_pdf.Text = "Crear factura PDF"
        Me.crear_pdf.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(208, 691)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(239, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Descripción de la orden"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(378, 738)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Precio"
        '
        'descripción_ord_box
        '
        Me.descripción_ord_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.descripción_ord_box.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripción_ord_box.Location = New System.Drawing.Point(471, 691)
        Me.descripción_ord_box.Name = "descripción_ord_box"
        Me.descripción_ord_box.Size = New System.Drawing.Size(1035, 27)
        Me.descripción_ord_box.TabIndex = 25
        '
        'precio_box
        '
        Me.precio_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.precio_box.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio_box.Location = New System.Drawing.Point(471, 736)
        Me.precio_box.Name = "precio_box"
        Me.precio_box.Size = New System.Drawing.Size(100, 27)
        Me.precio_box.TabIndex = 26
        '
        'modificar_btn2
        '
        Me.modificar_btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.modificar_btn2.BackgroundImage = CType(resources.GetObject("modificar_btn2.BackgroundImage"), System.Drawing.Image)
        Me.modificar_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modificar_btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar_btn2.FlatAppearance.BorderSize = 0
        Me.modificar_btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.modificar_btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.modificar_btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.modificar_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar_btn2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar_btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.modificar_btn2.Location = New System.Drawing.Point(979, 751)
        Me.modificar_btn2.Name = "modificar_btn2"
        Me.modificar_btn2.Size = New System.Drawing.Size(161, 68)
        Me.modificar_btn2.TabIndex = 27
        Me.modificar_btn2.Text = "Modificar"
        Me.modificar_btn2.UseVisualStyleBackColor = True
        '
        'agregar_btn2
        '
        Me.agregar_btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.agregar_btn2.BackgroundImage = CType(resources.GetObject("agregar_btn2.BackgroundImage"), System.Drawing.Image)
        Me.agregar_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.agregar_btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar_btn2.FlatAppearance.BorderSize = 0
        Me.agregar_btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.agregar_btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.agregar_btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.agregar_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregar_btn2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar_btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregar_btn2.Location = New System.Drawing.Point(1160, 751)
        Me.agregar_btn2.Name = "agregar_btn2"
        Me.agregar_btn2.Size = New System.Drawing.Size(156, 68)
        Me.agregar_btn2.TabIndex = 28
        Me.agregar_btn2.Text = "Agregar"
        Me.agregar_btn2.UseVisualStyleBackColor = True
        '
        'eliminar_btn2
        '
        Me.eliminar_btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.eliminar_btn2.BackgroundImage = CType(resources.GetObject("eliminar_btn2.BackgroundImage"), System.Drawing.Image)
        Me.eliminar_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.eliminar_btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar_btn2.FlatAppearance.BorderSize = 0
        Me.eliminar_btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.eliminar_btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.eliminar_btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.eliminar_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_btn2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar_btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.eliminar_btn2.Location = New System.Drawing.Point(1332, 751)
        Me.eliminar_btn2.Name = "eliminar_btn2"
        Me.eliminar_btn2.Size = New System.Drawing.Size(169, 67)
        Me.eliminar_btn2.TabIndex = 29
        Me.eliminar_btn2.Text = "Eliminar"
        Me.eliminar_btn2.UseVisualStyleBackColor = True
        '
        'limpiar_btn
        '
        Me.limpiar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.limpiar_btn.BackColor = System.Drawing.Color.Transparent
        Me.limpiar_btn.BackgroundImage = CType(resources.GetObject("limpiar_btn.BackgroundImage"), System.Drawing.Image)
        Me.limpiar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.limpiar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.limpiar_btn.FlatAppearance.BorderSize = 0
        Me.limpiar_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.limpiar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.limpiar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.limpiar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.limpiar_btn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.limpiar_btn.Location = New System.Drawing.Point(613, 749)
        Me.limpiar_btn.Name = "limpiar_btn"
        Me.limpiar_btn.Size = New System.Drawing.Size(178, 69)
        Me.limpiar_btn.TabIndex = 30
        Me.limpiar_btn.Text = "Limpiar campos"
        Me.limpiar_btn.UseVisualStyleBackColor = False
        '
        'buscar_btn
        '
        Me.buscar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.buscar_btn.BackgroundImage = CType(resources.GetObject("buscar_btn.BackgroundImage"), System.Drawing.Image)
        Me.buscar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buscar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buscar_btn.FlatAppearance.BorderSize = 0
        Me.buscar_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.buscar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.buscar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar_btn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buscar_btn.Location = New System.Drawing.Point(807, 751)
        Me.buscar_btn.Name = "buscar_btn"
        Me.buscar_btn.Size = New System.Drawing.Size(151, 67)
        Me.buscar_btn.TabIndex = 31
        Me.buscar_btn.Text = "Buscar"
        Me.buscar_btn.UseVisualStyleBackColor = True
        '
        'n_orden_box
        '
        Me.n_orden_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.n_orden_box.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_orden_box.Location = New System.Drawing.Point(471, 652)
        Me.n_orden_box.Name = "n_orden_box"
        Me.n_orden_box.Size = New System.Drawing.Size(100, 27)
        Me.n_orden_box.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(272, 652)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 22)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Numero de orden"
        '
        'fecha_box
        '
        Me.fecha_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fecha_box.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_box.Location = New System.Drawing.Point(471, 782)
        Me.fecha_box.Name = "fecha_box"
        Me.fecha_box.Size = New System.Drawing.Size(100, 27)
        Me.fecha_box.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(388, 782)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 20)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Fecha"
        '
        'correo_box
        '
        Me.correo_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.correo_box.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo_box.Location = New System.Drawing.Point(1031, 413)
        Me.correo_box.Margin = New System.Windows.Forms.Padding(4)
        Me.correo_box.Name = "correo_box"
        Me.correo_box.Size = New System.Drawing.Size(132, 27)
        Me.correo_box.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(947, 413)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Correo:"
        '
        'correo_de
        '
        Me.correo_de.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.correo_de.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo_de.Location = New System.Drawing.Point(1322, 104)
        Me.correo_de.Name = "correo_de"
        Me.correo_de.Size = New System.Drawing.Size(181, 27)
        Me.correo_de.TabIndex = 38
        Me.correo_de.Text = "correoelectronico@gmail.com"
        '
        'correo_para
        '
        Me.correo_para.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.correo_para.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo_para.Location = New System.Drawing.Point(1322, 137)
        Me.correo_para.Name = "correo_para"
        Me.correo_para.Size = New System.Drawing.Size(181, 27)
        Me.correo_para.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(1277, 104)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 20)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "De:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(1257, 137)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 20)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Para:"
        '
        'asunto_box
        '
        Me.asunto_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.asunto_box.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asunto_box.Location = New System.Drawing.Point(1325, 430)
        Me.asunto_box.Name = "asunto_box"
        Me.asunto_box.Size = New System.Drawing.Size(181, 27)
        Me.asunto_box.TabIndex = 42
        Me.asunto_box.Text = "✅AKA Orden N° 00000 - Nombre Apellido - Fecha Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(1237, 433)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 20)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Asunto:"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox8.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1325, 214)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(181, 27)
        Me.TextBox8.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(1365, 186)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 20)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Adjuntar:"
        '
        'msj
        '
        Me.msj.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.msj.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msj.Location = New System.Drawing.Point(1325, 265)
        Me.msj.Multiline = True
        Me.msj.Name = "msj"
        Me.msj.Size = New System.Drawing.Size(181, 151)
        Me.msj.TabIndex = 47
        Me.msj.Text = resources.GetString("msj.Text")
        '
        'enviar
        '
        Me.enviar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.enviar.BackgroundImage = CType(resources.GetObject("enviar.BackgroundImage"), System.Drawing.Image)
        Me.enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enviar.FlatAppearance.BorderSize = 0
        Me.enviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enviar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.enviar.Location = New System.Drawing.Point(1322, 497)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(194, 41)
        Me.enviar.TabIndex = 48
        Me.enviar.Text = "Enviar Factura"
        Me.enviar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.enviar.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(1341, 50)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 34)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Enviar"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Courier New", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(307, 9)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(226, 54)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Ordenes"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1924, 933)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.msj)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.asunto_box)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.correo_para)
        Me.Controls.Add(Me.correo_de)
        Me.Controls.Add(Me.correo_box)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.fecha_box)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.n_orden_box)
        Me.Controls.Add(Me.buscar_btn)
        Me.Controls.Add(Me.limpiar_btn)
        Me.Controls.Add(Me.eliminar_btn2)
        Me.Controls.Add(Me.agregar_btn2)
        Me.Controls.Add(Me.modificar_btn2)
        Me.Controls.Add(Me.precio_box)
        Me.Controls.Add(Me.descripción_ord_box)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.crear_pdf)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "órdenes"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents crear_pdf As System.Windows.Forms.Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents descripción_ord_box As TextBox
    Friend WithEvents precio_box As TextBox
    Friend WithEvents modificar_btn2 As Button
    Friend WithEvents agregar_btn2 As Button
    Friend WithEvents eliminar_btn2 As Button
    Friend WithEvents limpiar_btn As Button
    Friend WithEvents buscar_btn As Button
    Friend WithEvents n_orden_box As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fecha_box As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents correo_box As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents correo_de As TextBox
    Friend WithEvents correo_para As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents asunto_box As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents msj As TextBox
    Friend WithEvents enviar As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
