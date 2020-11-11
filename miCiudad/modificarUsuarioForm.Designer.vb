<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarUserForm
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
        Me.cbxUserTypeMOD = New System.Windows.Forms.ComboBox()
        Me.tbxTelefonoMOD = New System.Windows.Forms.TextBox()
        Me.tbxCorreoMOD = New System.Windows.Forms.TextBox()
        Me.tbxContraseñaMOD = New System.Windows.Forms.TextBox()
        Me.tbxApellidoMOD = New System.Windows.Forms.TextBox()
        Me.tbxNombreMOD = New System.Windows.Forms.TextBox()
        Me.lbltipoUsuarioMOD = New System.Windows.Forms.Label()
        Me.lblContraseñaMOD = New System.Windows.Forms.Label()
        Me.lblCorreoMOD = New System.Windows.Forms.Label()
        Me.lblTelMOD = New System.Windows.Forms.Label()
        Me.lblApellidoMOD = New System.Windows.Forms.Label()
        Me.lblNombreMOD = New System.Windows.Forms.Label()
        Me.lblCIMOD = New System.Windows.Forms.Label()
        Me.tbxCImMOD = New System.Windows.Forms.TextBox()
        Me.lblAltaUser = New System.Windows.Forms.Label()
        Me.btnCancelarMOD = New System.Windows.Forms.Button()
        Me.btnAceptarMOD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxUserTypeMOD
        '
        Me.cbxUserTypeMOD.FormattingEnabled = True
        Me.cbxUserTypeMOD.Location = New System.Drawing.Point(367, 309)
        Me.cbxUserTypeMOD.Name = "cbxUserTypeMOD"
        Me.cbxUserTypeMOD.Size = New System.Drawing.Size(100, 21)
        Me.cbxUserTypeMOD.TabIndex = 28
        '
        'tbxTelefonoMOD
        '
        Me.tbxTelefonoMOD.Location = New System.Drawing.Point(367, 215)
        Me.tbxTelefonoMOD.Name = "tbxTelefonoMOD"
        Me.tbxTelefonoMOD.Size = New System.Drawing.Size(100, 20)
        Me.tbxTelefonoMOD.TabIndex = 27
        '
        'tbxCorreoMOD
        '
        Me.tbxCorreoMOD.Location = New System.Drawing.Point(367, 247)
        Me.tbxCorreoMOD.Name = "tbxCorreoMOD"
        Me.tbxCorreoMOD.Size = New System.Drawing.Size(100, 20)
        Me.tbxCorreoMOD.TabIndex = 26
        '
        'tbxContraseñaMOD
        '
        Me.tbxContraseñaMOD.Location = New System.Drawing.Point(367, 280)
        Me.tbxContraseñaMOD.Name = "tbxContraseñaMOD"
        Me.tbxContraseñaMOD.Size = New System.Drawing.Size(100, 20)
        Me.tbxContraseñaMOD.TabIndex = 25
        '
        'tbxApellidoMOD
        '
        Me.tbxApellidoMOD.Location = New System.Drawing.Point(367, 184)
        Me.tbxApellidoMOD.Name = "tbxApellidoMOD"
        Me.tbxApellidoMOD.Size = New System.Drawing.Size(100, 20)
        Me.tbxApellidoMOD.TabIndex = 24
        '
        'tbxNombreMOD
        '
        Me.tbxNombreMOD.Location = New System.Drawing.Point(367, 150)
        Me.tbxNombreMOD.Name = "tbxNombreMOD"
        Me.tbxNombreMOD.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombreMOD.TabIndex = 23
        '
        'lbltipoUsuarioMOD
        '
        Me.lbltipoUsuarioMOD.AutoSize = True
        Me.lbltipoUsuarioMOD.Location = New System.Drawing.Point(275, 317)
        Me.lbltipoUsuarioMOD.Name = "lbltipoUsuarioMOD"
        Me.lbltipoUsuarioMOD.Size = New System.Drawing.Size(86, 13)
        Me.lbltipoUsuarioMOD.TabIndex = 22
        Me.lbltipoUsuarioMOD.Text = "Tipo de usuario :"
        '
        'lblContraseñaMOD
        '
        Me.lblContraseñaMOD.AutoSize = True
        Me.lblContraseñaMOD.Location = New System.Drawing.Point(280, 287)
        Me.lblContraseñaMOD.Name = "lblContraseñaMOD"
        Me.lblContraseñaMOD.Size = New System.Drawing.Size(67, 13)
        Me.lblContraseñaMOD.TabIndex = 21
        Me.lblContraseñaMOD.Text = "Contraseña :"
        '
        'lblCorreoMOD
        '
        Me.lblCorreoMOD.AutoSize = True
        Me.lblCorreoMOD.Location = New System.Drawing.Point(280, 254)
        Me.lblCorreoMOD.Name = "lblCorreoMOD"
        Me.lblCorreoMOD.Size = New System.Drawing.Size(44, 13)
        Me.lblCorreoMOD.TabIndex = 20
        Me.lblCorreoMOD.Text = "Correo :"
        '
        'lblTelMOD
        '
        Me.lblTelMOD.AutoSize = True
        Me.lblTelMOD.Location = New System.Drawing.Point(280, 222)
        Me.lblTelMOD.Name = "lblTelMOD"
        Me.lblTelMOD.Size = New System.Drawing.Size(55, 13)
        Me.lblTelMOD.TabIndex = 19
        Me.lblTelMOD.Text = "Telefono :"
        '
        'lblApellidoMOD
        '
        Me.lblApellidoMOD.AutoSize = True
        Me.lblApellidoMOD.Location = New System.Drawing.Point(280, 191)
        Me.lblApellidoMOD.Name = "lblApellidoMOD"
        Me.lblApellidoMOD.Size = New System.Drawing.Size(50, 13)
        Me.lblApellidoMOD.TabIndex = 18
        Me.lblApellidoMOD.Text = "Apellido :"
        '
        'lblNombreMOD
        '
        Me.lblNombreMOD.AutoSize = True
        Me.lblNombreMOD.Location = New System.Drawing.Point(280, 157)
        Me.lblNombreMOD.Name = "lblNombreMOD"
        Me.lblNombreMOD.Size = New System.Drawing.Size(50, 13)
        Me.lblNombreMOD.TabIndex = 17
        Me.lblNombreMOD.Text = "Nombre :"
        '
        'lblCIMOD
        '
        Me.lblCIMOD.AutoSize = True
        Me.lblCIMOD.Location = New System.Drawing.Point(280, 121)
        Me.lblCIMOD.Name = "lblCIMOD"
        Me.lblCIMOD.Size = New System.Drawing.Size(23, 13)
        Me.lblCIMOD.TabIndex = 16
        Me.lblCIMOD.Text = "CI :"
        '
        'tbxCImMOD
        '
        Me.tbxCImMOD.Location = New System.Drawing.Point(367, 118)
        Me.tbxCImMOD.Name = "tbxCImMOD"
        Me.tbxCImMOD.Size = New System.Drawing.Size(100, 20)
        Me.tbxCImMOD.TabIndex = 15
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaUser.Location = New System.Drawing.Point(251, 29)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(245, 25)
        Me.lblAltaUser.TabIndex = 29
        Me.lblAltaUser.Text = "MODIFICAR USUARIO"
        '
        'btnCancelarMOD
        '
        Me.btnCancelarMOD.Location = New System.Drawing.Point(260, 368)
        Me.btnCancelarMOD.Name = "btnCancelarMOD"
        Me.btnCancelarMOD.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarMOD.TabIndex = 31
        Me.btnCancelarMOD.Text = "Cancelar"
        Me.btnCancelarMOD.UseVisualStyleBackColor = True
        '
        'btnAceptarMOD
        '
        Me.btnAceptarMOD.Location = New System.Drawing.Point(401, 368)
        Me.btnAceptarMOD.Name = "btnAceptarMOD"
        Me.btnAceptarMOD.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarMOD.TabIndex = 30
        Me.btnAceptarMOD.Text = "Aceptar"
        Me.btnAceptarMOD.UseVisualStyleBackColor = True
        '
        'modificarUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarMOD)
        Me.Controls.Add(Me.btnAceptarMOD)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Controls.Add(Me.cbxUserTypeMOD)
        Me.Controls.Add(Me.tbxTelefonoMOD)
        Me.Controls.Add(Me.tbxCorreoMOD)
        Me.Controls.Add(Me.tbxContraseñaMOD)
        Me.Controls.Add(Me.tbxApellidoMOD)
        Me.Controls.Add(Me.tbxNombreMOD)
        Me.Controls.Add(Me.lbltipoUsuarioMOD)
        Me.Controls.Add(Me.lblContraseñaMOD)
        Me.Controls.Add(Me.lblCorreoMOD)
        Me.Controls.Add(Me.lblTelMOD)
        Me.Controls.Add(Me.lblApellidoMOD)
        Me.Controls.Add(Me.lblNombreMOD)
        Me.Controls.Add(Me.lblCIMOD)
        Me.Controls.Add(Me.tbxCImMOD)
        Me.Name = "modificarUserForm"
        Me.Text = "Modificar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxUserTypeMOD As ComboBox
    Friend WithEvents tbxTelefonoMOD As TextBox
    Friend WithEvents tbxCorreoMOD As TextBox
    Friend WithEvents tbxContraseñaMOD As TextBox
    Friend WithEvents tbxApellidoMOD As TextBox
    Friend WithEvents tbxNombreMOD As TextBox
    Friend WithEvents lbltipoUsuarioMOD As Label
    Friend WithEvents lblContraseñaMOD As Label
    Friend WithEvents lblCorreoMOD As Label
    Friend WithEvents lblTelMOD As Label
    Friend WithEvents lblApellidoMOD As Label
    Friend WithEvents lblNombreMOD As Label
    Friend WithEvents lblCIMOD As Label
    Friend WithEvents tbxCImMOD As TextBox
    Friend WithEvents lblAltaUser As Label
    Friend WithEvents btnCancelarMOD As Button
    Friend WithEvents btnAceptarMOD As Button
End Class
