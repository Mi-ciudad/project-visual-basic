<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaUserForm
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
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.lblAltaUser = New System.Windows.Forms.Label()
        Me.blCI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.tbxContraseña = New System.Windows.Forms.TextBox()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.cbxUserType = New System.Windows.Forms.ComboBox()
        Me.btnAceptarAlta = New System.Windows.Forms.Button()
        Me.btnCancelarAlta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxCI
        '
        Me.tbxCI.Location = New System.Drawing.Point(363, 76)
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(100, 20)
        Me.tbxCI.TabIndex = 0
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaUser.Location = New System.Drawing.Point(286, 9)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(177, 25)
        Me.lblAltaUser.TabIndex = 1
        Me.lblAltaUser.Text = "ALTA USUARIO"
        '
        'blCI
        '
        Me.blCI.AutoSize = True
        Me.blCI.Location = New System.Drawing.Point(276, 79)
        Me.blCI.Name = "blCI"
        Me.blCI.Size = New System.Drawing.Size(23, 13)
        Me.blCI.TabIndex = 2
        Me.blCI.Text = "CI :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Correo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Contraseña :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(271, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tipo de usuario :"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(363, 108)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombre.TabIndex = 9
        '
        'tbxApellido
        '
        Me.tbxApellido.Location = New System.Drawing.Point(363, 142)
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(100, 20)
        Me.tbxApellido.TabIndex = 10

        'tbxContraseña
        '
        Me.tbxContraseña.Location = New System.Drawing.Point(363, 238)
        Me.tbxContraseña.Name = "tbxContraseña"
        Me.tbxContraseña.Size = New System.Drawing.Size(100, 20)
        Me.tbxContraseña.TabIndex = 11
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Location = New System.Drawing.Point(363, 205)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(100, 20)
        Me.tbxCorreo.TabIndex = 12
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Location = New System.Drawing.Point(363, 173)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbxTelefono.TabIndex = 13
        '
        'cbxUserType
        '
        Me.cbxUserType.FormattingEnabled = True
        Me.cbxUserType.Location = New System.Drawing.Point(363, 267)
        Me.cbxUserType.Name = "cbxUserType"
        Me.cbxUserType.Size = New System.Drawing.Size(100, 21)
        Me.cbxUserType.TabIndex = 14
        '
        'btnAceptarAlta
        '
        Me.btnAceptarAlta.Location = New System.Drawing.Point(467, 336)
        Me.btnAceptarAlta.Name = "btnAceptarAlta"
        Me.btnAceptarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarAlta.TabIndex = 15
        Me.btnAceptarAlta.Text = "Aceptar"
        Me.btnAceptarAlta.UseVisualStyleBackColor = True
        '
        'btnCancelarAlta
        '
        Me.btnCancelarAlta.Location = New System.Drawing.Point(234, 336)
        Me.btnCancelarAlta.Name = "btnCancelarAlta"
        Me.btnCancelarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarAlta.TabIndex = 16
        Me.btnCancelarAlta.Text = "Cancelar"
        Me.btnCancelarAlta.UseVisualStyleBackColor = True
        '
        'altaUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarAlta)
        Me.Controls.Add(Me.btnAceptarAlta)
        Me.Controls.Add(Me.cbxUserType)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.tbxContraseña)
        Me.Controls.Add(Me.tbxApellido)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.blCI)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Controls.Add(Me.tbxCI)
        Me.Name = "altaUserForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxCI As TextBox
    Friend WithEvents lblAltaUser As Label
    Friend WithEvents blCI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxApellido As TextBox
    Friend WithEvents tbxContraseña As TextBox
    Friend WithEvents tbxCorreo As TextBox
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents cbxUserType As ComboBox
    Friend WithEvents btnAceptarAlta As Button
    Friend WithEvents btnCancelarAlta As Button
End Class
