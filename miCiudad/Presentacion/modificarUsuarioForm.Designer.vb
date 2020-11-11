<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modificarUserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificarUserForm))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.tbxContrasenia = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxLinea = New System.Windows.Forms.PictureBox()
        Me.pbxRectangulo = New System.Windows.Forms.PictureBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.pbxVectorAltaUsuario = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.btnAceptar.Location = New System.Drawing.Point(633, 507)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 36)
        Me.btnAceptar.TabIndex = 89
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.btnBorrar.Location = New System.Drawing.Point(390, 507)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(97, 36)
        Me.btnBorrar.TabIndex = 88
        Me.btnBorrar.Text = "Vaciar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCi.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCi.Location = New System.Drawing.Point(629, 271)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(33, 20)
        Me.lblCi.TabIndex = 87
        Me.lblCi.Text = "C.I."
        '
        'tbxCi
        '
        Me.tbxCi.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCi.Location = New System.Drawing.Point(633, 303)
        Me.tbxCi.Multiline = True
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(196, 35)
        Me.tbxCi.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(629, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Apellido"
        '
        'tbxApellido
        '
        Me.tbxApellido.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxApellido.Location = New System.Drawing.Point(633, 211)
        Me.tbxApellido.Multiline = True
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(196, 35)
        Me.tbxApellido.TabIndex = 84
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblContrasenia.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblContrasenia.Location = New System.Drawing.Point(291, 367)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(95, 20)
        Me.lblContrasenia.TabIndex = 83
        Me.lblContrasenia.Text = "Contraseña"
        '
        'tbxContrasenia
        '
        Me.tbxContrasenia.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxContrasenia.Location = New System.Drawing.Point(293, 399)
        Me.tbxContrasenia.Multiline = True
        Me.tbxContrasenia.Name = "tbxContrasenia"
        Me.tbxContrasenia.Size = New System.Drawing.Size(196, 35)
        Me.tbxContrasenia.TabIndex = 82
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCorreo.Location = New System.Drawing.Point(291, 271)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(60, 20)
        Me.lblCorreo.TabIndex = 81
        Me.lblCorreo.Text = "Correo"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCorreo.Location = New System.Drawing.Point(293, 303)
        Me.tbxCorreo.Multiline = True
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(196, 35)
        Me.tbxCorreo.TabIndex = 80
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombre.Location = New System.Drawing.Point(291, 179)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 79
        Me.lblNombre.Text = "Nombre"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(123, 85)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(177, 26)
        Me.lblTitulo.TabIndex = 78
        Me.lblTitulo.Text = "Modificar usuario"
        '
        'pbxLinea
        '
        Me.pbxLinea.Image = CType(resources.GetObject("pbxLinea.Image"), System.Drawing.Image)
        Me.pbxLinea.Location = New System.Drawing.Point(60, 120)
        Me.pbxLinea.Name = "pbxLinea"
        Me.pbxLinea.Size = New System.Drawing.Size(1000, 14)
        Me.pbxLinea.TabIndex = 76
        Me.pbxLinea.TabStop = False
        '
        'pbxRectangulo
        '
        Me.pbxRectangulo.Image = CType(resources.GetObject("pbxRectangulo.Image"), System.Drawing.Image)
        Me.pbxRectangulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxRectangulo.Name = "pbxRectangulo"
        Me.pbxRectangulo.Size = New System.Drawing.Size(1120, 60)
        Me.pbxRectangulo.TabIndex = 75
        Me.pbxRectangulo.TabStop = False
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxNombre.Location = New System.Drawing.Point(293, 211)
        Me.tbxNombre.Multiline = True
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(196, 35)
        Me.tbxNombre.TabIndex = 74
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = CType(resources.GetObject("pbxVectorAltaUsuario.Image"), System.Drawing.Image)
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(85, 85)
        Me.pbxVectorAltaUsuario.Name = "pbxVectorAltaUsuario"
        Me.pbxVectorAltaUsuario.Size = New System.Drawing.Size(34, 27)
        Me.pbxVectorAltaUsuario.TabIndex = 73
        Me.pbxVectorAltaUsuario.TabStop = False
        '
        'modificarUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 611)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.tbxCi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxApellido)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.tbxContrasenia)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbxLinea)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modificarUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi ciudad"
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblCi As Label
    Private WithEvents tbxCi As TextBox
    Friend WithEvents Label5 As Label
    Private WithEvents tbxApellido As TextBox
    Friend WithEvents lblContrasenia As Label
    Private WithEvents tbxContrasenia As TextBox
    Friend WithEvents lblCorreo As Label
    Private WithEvents tbxCorreo As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxLinea As PictureBox
    Friend WithEvents pbxRectangulo As PictureBox
    Private WithEvents tbxNombre As TextBox
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
End Class
