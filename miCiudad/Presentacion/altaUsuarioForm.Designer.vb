<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAltaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAltaUsuario))
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.tbxContrasenia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pbxVectorAltaUsuario = New System.Windows.Forms.PictureBox()
        Me.pbxLinea = New System.Windows.Forms.PictureBox()
        Me.pbxRectangulo = New System.Windows.Forms.PictureBox()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxNombre.Location = New System.Drawing.Point(293, 211)
        Me.tbxNombre.Multiline = True
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(196, 35)
        Me.tbxNombre.TabIndex = 17
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(123, 85)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(127, 26)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "Alta usuario"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombre.Location = New System.Drawing.Point(291, 179)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCorreo.Location = New System.Drawing.Point(291, 271)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(60, 20)
        Me.lblCorreo.TabIndex = 40
        Me.lblCorreo.Text = "Correo"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCorreo.Location = New System.Drawing.Point(293, 303)
        Me.tbxCorreo.Multiline = True
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(196, 35)
        Me.tbxCorreo.TabIndex = 39
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblContrasenia.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblContrasenia.Location = New System.Drawing.Point(291, 367)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(95, 20)
        Me.lblContrasenia.TabIndex = 42
        Me.lblContrasenia.Text = "Contraseña"
        '
        'tbxContrasenia
        '
        Me.tbxContrasenia.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxContrasenia.Location = New System.Drawing.Point(293, 399)
        Me.tbxContrasenia.Multiline = True
        Me.tbxContrasenia.Name = "tbxContrasenia"
        Me.tbxContrasenia.Size = New System.Drawing.Size(196, 35)
        Me.tbxContrasenia.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(629, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Apellido"
        '
        'tbxApellido
        '
        Me.tbxApellido.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxApellido.Location = New System.Drawing.Point(633, 211)
        Me.tbxApellido.Multiline = True
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(196, 35)
        Me.tbxApellido.TabIndex = 43
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCi.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCi.Location = New System.Drawing.Point(629, 271)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(61, 20)
        Me.lblCi.TabIndex = 50
        Me.lblCi.Text = "Cedula"
        '
        'tbxCi
        '
        Me.tbxCi.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCi.Location = New System.Drawing.Point(633, 303)
        Me.tbxCi.Multiline = True
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(196, 35)
        Me.tbxCi.TabIndex = 49
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
        Me.btnBorrar.TabIndex = 51
        Me.btnBorrar.Text = "Vaciar"
        Me.btnBorrar.UseVisualStyleBackColor = False
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
        Me.btnAceptar.TabIndex = 53
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = Global.miCiudad.My.Resources.Resources.Vector
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(85, 88)
        Me.pbxVectorAltaUsuario.Name = "pbxVectorAltaUsuario"
        Me.pbxVectorAltaUsuario.Size = New System.Drawing.Size(34, 27)
        Me.pbxVectorAltaUsuario.TabIndex = 35
        Me.pbxVectorAltaUsuario.TabStop = False
        '
        'pbxLinea
        '
        Me.pbxLinea.Image = CType(resources.GetObject("pbxLinea.Image"), System.Drawing.Image)
        Me.pbxLinea.Location = New System.Drawing.Point(60, 120)
        Me.pbxLinea.Name = "pbxLinea"
        Me.pbxLinea.Size = New System.Drawing.Size(1000, 14)
        Me.pbxLinea.TabIndex = 34
        Me.pbxLinea.TabStop = False
        '
        'pbxRectangulo
        '
        Me.pbxRectangulo.Image = CType(resources.GetObject("pbxRectangulo.Image"), System.Drawing.Image)
        Me.pbxRectangulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxRectangulo.Name = "pbxRectangulo"
        Me.pbxRectangulo.Size = New System.Drawing.Size(1120, 60)
        Me.pbxRectangulo.TabIndex = 33
        Me.pbxRectangulo.TabStop = False
        '
        'formAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
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
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Controls.Add(Me.pbxLinea)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Controls.Add(Me.tbxNombre)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formAltaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxRectangulo As PictureBox
    Friend WithEvents pbxLinea As PictureBox
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Private WithEvents tbxNombre As TextBox
    Friend WithEvents lblCorreo As Label
    Private WithEvents tbxCorreo As TextBox
    Friend WithEvents lblContrasenia As Label
    Private WithEvents tbxContrasenia As TextBox
    Friend WithEvents Label5 As Label
    Private WithEvents tbxApellido As TextBox
    Friend WithEvents lblCi As Label
    Private WithEvents tbxCi As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAceptar As Button
End Class
