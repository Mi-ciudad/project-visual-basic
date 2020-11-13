<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaUserMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbxVectorAltaUsuario = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(1104, 28)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaUserMenuItem, Me.BajaUsuarioToolStripMenuItem, Me.ModificarUsuarioToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuario"
        '
        'AltaUserMenuItem
        '
        Me.AltaUserMenuItem.Name = "AltaUserMenuItem"
        Me.AltaUserMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.AltaUserMenuItem.Text = "Alta "
        '
        'BajaUsuarioToolStripMenuItem
        '
        Me.BajaUsuarioToolStripMenuItem.Name = "BajaUsuarioToolStripMenuItem"
        Me.BajaUsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.BajaUsuarioToolStripMenuItem.Text = "Baja"
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        Me.ModificarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ModificarUsuarioToolStripMenuItem.Text = "Modificar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarEstadoToolStripMenuItem, Me.ListarToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'AsignarEstadoToolStripMenuItem
        '
        Me.AsignarEstadoToolStripMenuItem.Name = "AsignarEstadoToolStripMenuItem"
        Me.AsignarEstadoToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.AsignarEstadoToolStripMenuItem.Text = "Asignar estado "
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = CType(resources.GetObject("pbxVectorAltaUsuario.Image"), System.Drawing.Image)
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(639, 61)
        Me.pbxVectorAltaUsuario.Name = "pbxVectorAltaUsuario"
        Me.pbxVectorAltaUsuario.Size = New System.Drawing.Size(383, 501)
        Me.pbxVectorAltaUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxVectorAltaUsuario.TabIndex = 36
        Me.pbxVectorAltaUsuario.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 60)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(100, 286)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 54)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.5!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombre.Location = New System.Drawing.Point(123, 298)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(205, 25)
        Me.lblNombre.TabIndex = 39
        Me.lblNombre.Text = "Montevideo - Uruguay"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1104, 611)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi ciudad"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaUserMenuItem As ToolStripMenuItem
    Friend WithEvents BajaUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarEstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblNombre As Label
End Class
