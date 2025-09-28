<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bases_de_datos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bases_de_datos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BasesDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SimSun", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(258, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(986, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa técnica de reparaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelContainer
        '
        Me.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelContainer.Location = New System.Drawing.Point(0, 122)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1540, 858)
        Me.panelContainer.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("SimSun", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasesDeDatosToolStripMenuItem, Me.ManualDeUsuarioToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(377, 1102)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BasesDeDatosToolStripMenuItem
        '
        Me.BasesDeDatosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BasesDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.OrdenesToolStripMenuItem})
        Me.BasesDeDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BasesDeDatosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BasesDeDatosToolStripMenuItem.Name = "BasesDeDatosToolStripMenuItem"
        Me.BasesDeDatosToolStripMenuItem.Size = New System.Drawing.Size(364, 44)
        Me.BasesDeDatosToolStripMenuItem.Text = "Bases de datos"
        Me.BasesDeDatosToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(268, 44)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'OrdenesToolStripMenuItem
        '
        Me.OrdenesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OrdenesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OrdenesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OrdenesToolStripMenuItem.Name = "OrdenesToolStripMenuItem"
        Me.OrdenesToolStripMenuItem.Size = New System.Drawing.Size(268, 44)
        Me.OrdenesToolStripMenuItem.Text = "Ordenes"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ManualDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(364, 44)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        Me.ManualDeUsuarioToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(364, 44)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        Me.AcercaDeToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(1493, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(47, 37)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'bases_de_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1942, 1102)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.panelContainer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bases_de_datos"
        Me.Text = "bases_de_datos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelContainer As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BasesDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As Button
End Class
