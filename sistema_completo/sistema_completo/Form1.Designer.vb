<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.contra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.punto1 = New System.Windows.Forms.Label()
        Me.punto2 = New System.Windows.Forms.Label()
        Me.punto3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.noiguales = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.repcontrabox = New System.Windows.Forms.TextBox()
        Me.contrabox = New System.Windows.Forms.TextBox()
        Me.usuariobox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Database2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ojo2 = New System.Windows.Forms.Button()
        Me.ojo1 = New System.Windows.Forms.Button()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Azure
        Me.Button2.Location = New System.Drawing.Point(2044, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(289, 300)
        Me.DataGridView1.TabIndex = 10
        '
        'usuario
        '
        Me.usuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.usuario.Location = New System.Drawing.Point(80, 494)
        Me.usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(521, 34)
        Me.usuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SimSun-ExtB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(207, 448)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de usuario"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SimSun-ExtB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(241, 563)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña"
        '
        'contra
        '
        Me.contra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contra.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.contra.Location = New System.Drawing.Point(79, 606)
        Me.contra.Margin = New System.Windows.Forms.Padding(4)
        Me.contra.Name = "contra"
        Me.contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contra.Size = New System.Drawing.Size(521, 34)
        Me.contra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SimSun", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(358, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(795, 60)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bienvenido/a al sistema"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(35, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "VER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(615, 879)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 46)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "  Cargando "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(143, 669)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(405, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Contraseña o nombre de usuario invalidos"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Blue
        Me.ProgressBar1.Location = New System.Drawing.Point(-321, 957)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(2691, 57)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Visible = False
        '
        'punto1
        '
        Me.punto1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.punto1.AutoSize = True
        Me.punto1.BackColor = System.Drawing.Color.Transparent
        Me.punto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.punto1.Location = New System.Drawing.Point(846, 881)
        Me.punto1.Name = "punto1"
        Me.punto1.Size = New System.Drawing.Size(32, 44)
        Me.punto1.TabIndex = 16
        Me.punto1.Text = "."
        Me.punto1.Visible = False
        '
        'punto2
        '
        Me.punto2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.punto2.AutoSize = True
        Me.punto2.BackColor = System.Drawing.Color.Transparent
        Me.punto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.punto2.Location = New System.Drawing.Point(881, 881)
        Me.punto2.Name = "punto2"
        Me.punto2.Size = New System.Drawing.Size(32, 44)
        Me.punto2.TabIndex = 17
        Me.punto2.Text = "."
        Me.punto2.Visible = False
        '
        'punto3
        '
        Me.punto3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.punto3.AutoSize = True
        Me.punto3.BackColor = System.Drawing.Color.Transparent
        Me.punto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.punto3.Location = New System.Drawing.Point(921, 881)
        Me.punto3.Name = "punto3"
        Me.punto3.Size = New System.Drawing.Size(32, 44)
        Me.punto3.TabIndex = 18
        Me.punto3.Text = "."
        Me.punto3.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("SimSun", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label6.Location = New System.Drawing.Point(-61, 391)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(795, 47)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Inicio de Sesión"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'noiguales
        '
        Me.noiguales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.noiguales.AutoSize = True
        Me.noiguales.BackColor = System.Drawing.Color.Transparent
        Me.noiguales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noiguales.ForeColor = System.Drawing.Color.Red
        Me.noiguales.Location = New System.Drawing.Point(991, 775)
        Me.noiguales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.noiguales.Name = "noiguales"
        Me.noiguales.Size = New System.Drawing.Size(404, 24)
        Me.noiguales.TabIndex = 31
        Me.noiguales.Text = "Los campos de contraseña no son iguales"
        Me.noiguales.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("SimSun-ExtB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(1048, 620)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 28)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Repetir contraseña"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("SimSun-ExtB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(1084, 526)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 28)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Contraseña"
        '
        'repcontrabox
        '
        Me.repcontrabox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.repcontrabox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.repcontrabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repcontrabox.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.repcontrabox.Location = New System.Drawing.Point(916, 653)
        Me.repcontrabox.Margin = New System.Windows.Forms.Padding(4)
        Me.repcontrabox.MaxLength = 10
        Me.repcontrabox.Name = "repcontrabox"
        Me.repcontrabox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repcontrabox.Size = New System.Drawing.Size(521, 34)
        Me.repcontrabox.TabIndex = 25
        '
        'contrabox
        '
        Me.contrabox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contrabox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.contrabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrabox.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.contrabox.Location = New System.Drawing.Point(916, 565)
        Me.contrabox.Margin = New System.Windows.Forms.Padding(4)
        Me.contrabox.MaxLength = 10
        Me.contrabox.Name = "contrabox"
        Me.contrabox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contrabox.Size = New System.Drawing.Size(521, 34)
        Me.contrabox.TabIndex = 24
        '
        'usuariobox
        '
        Me.usuariobox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usuariobox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usuariobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuariobox.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.usuariobox.Location = New System.Drawing.Point(916, 472)
        Me.usuariobox.Margin = New System.Windows.Forms.Padding(4)
        Me.usuariobox.Name = "usuariobox"
        Me.usuariobox.Size = New System.Drawing.Size(521, 34)
        Me.usuariobox.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("SimSun-ExtB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(1048, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nombre de usuario"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("SimSun", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label11.Location = New System.Drawing.Point(769, 381)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(795, 47)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Crear usuario"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("SimSun-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lavender
        Me.Label7.Location = New System.Drawing.Point(912, 695)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(522, 80)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "La contraseña debe ser minimo de 8 caracteres " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y máximo de 10, debe poseer al me" &
    "nos 2 números," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 2 mayúsculas y 2 minúsculas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 7000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'InicioBindingSource
        '
        Me.InicioBindingSource.DataMember = "inicio"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(13, 384)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(1496, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(47, 37)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(381, 146)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(759, 590)
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(677, 259)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'ojo2
        '
        Me.ojo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ojo2.BackColor = System.Drawing.Color.Transparent
        Me.ojo2.BackgroundImage = CType(resources.GetObject("ojo2.BackgroundImage"), System.Drawing.Image)
        Me.ojo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ojo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ojo2.FlatAppearance.BorderSize = 0
        Me.ojo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ojo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ojo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ojo2.Location = New System.Drawing.Point(1445, 565)
        Me.ojo2.Margin = New System.Windows.Forms.Padding(4)
        Me.ojo2.Name = "ojo2"
        Me.ojo2.Size = New System.Drawing.Size(48, 33)
        Me.ojo2.TabIndex = 30
        Me.ojo2.UseVisualStyleBackColor = False
        '
        'ojo1
        '
        Me.ojo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ojo1.BackColor = System.Drawing.Color.Transparent
        Me.ojo1.BackgroundImage = CType(resources.GetObject("ojo1.BackgroundImage"), System.Drawing.Image)
        Me.ojo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ojo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ojo1.FlatAppearance.BorderSize = 0
        Me.ojo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ojo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ojo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ojo1.Location = New System.Drawing.Point(1445, 653)
        Me.ojo1.Margin = New System.Windows.Forms.Padding(4)
        Me.ojo1.Name = "ojo1"
        Me.ojo1.Size = New System.Drawing.Size(48, 33)
        Me.ojo1.TabIndex = 29
        Me.ojo1.UseVisualStyleBackColor = False
        '
        'aceptar
        '
        Me.aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptar.AutoSize = True
        Me.aceptar.BackColor = System.Drawing.Color.Transparent
        Me.aceptar.BackgroundImage = CType(resources.GetObject("aceptar.BackgroundImage"), System.Drawing.Image)
        Me.aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aceptar.FlatAppearance.BorderSize = 0
        Me.aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptar.Font = New System.Drawing.Font("SimSun", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.ForeColor = System.Drawing.Color.White
        Me.aceptar.Location = New System.Drawing.Point(1053, 812)
        Me.aceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(287, 64)
        Me.aceptar.TabIndex = 28
        Me.aceptar.TabStop = False
        Me.aceptar.Text = "Crear cuenta"
        Me.aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1035, 146)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 231)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("SimSun", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(228, 715)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(608, 606)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 33)
        Me.Button4.TabIndex = 13
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(201, 146)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1942, 1102)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.noiguales)
        Me.Controls.Add(Me.ojo2)
        Me.Controls.Add(Me.ojo1)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.repcontrabox)
        Me.Controls.Add(Me.contrabox)
        Me.Controls.Add(Me.usuariobox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.punto3)
        Me.Controls.Add(Me.punto2)
        Me.Controls.Add(Me.punto1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.contra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Button6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents contra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents punto1 As Label
    Friend WithEvents punto2 As Label
    Friend WithEvents punto3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents noiguales As Label
    Friend WithEvents ojo2 As Button
    Friend WithEvents ojo1 As Button
    Friend WithEvents aceptar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents repcontrabox As TextBox
    Friend WithEvents contrabox As TextBox
    Friend WithEvents usuariobox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Database2DataSet1BindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents Database2DataSetBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents InicioBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
