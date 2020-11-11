<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajaUsuarioForm
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
        Me.lblAltaUser = New System.Windows.Forms.Label()
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.blCI = New System.Windows.Forms.Label()
        Me.btnAceptarBaja = New System.Windows.Forms.Button()
        Me.btnCancelarBaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaUser.Location = New System.Drawing.Point(270, 9)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(177, 25)
        Me.lblAltaUser.TabIndex = 2
        Me.lblAltaUser.Text = "BAJA USUARIO"
        '
        'tbxCI
        '
        Me.tbxCI.Location = New System.Drawing.Point(336, 77)
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(100, 20)
        Me.tbxCI.TabIndex = 3
        '
        'blCI
        '
        Me.blCI.AutoSize = True
        Me.blCI.Location = New System.Drawing.Point(272, 80)
        Me.blCI.Name = "blCI"
        Me.blCI.Size = New System.Drawing.Size(23, 13)
        Me.blCI.TabIndex = 4
        Me.blCI.Text = "CI :"
        '
        'btnAceptarBaja
        '
        Me.btnAceptarBaja.Location = New System.Drawing.Point(416, 176)
        Me.btnAceptarBaja.Name = "btnAceptarBaja"
        Me.btnAceptarBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarBaja.TabIndex = 5
        Me.btnAceptarBaja.Text = "Aceptar"
        Me.btnAceptarBaja.UseVisualStyleBackColor = True
        '
        'btnCancelarBaja
        '
        Me.btnCancelarBaja.Location = New System.Drawing.Point(275, 176)
        Me.btnCancelarBaja.Name = "btnCancelarBaja"
        Me.btnCancelarBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarBaja.TabIndex = 6
        Me.btnCancelarBaja.Text = "Cancelar"
        Me.btnCancelarBaja.UseVisualStyleBackColor = True
        '
        'bajaUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarBaja)
        Me.Controls.Add(Me.btnAceptarBaja)
        Me.Controls.Add(Me.blCI)
        Me.Controls.Add(Me.tbxCI)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Name = "bajaUsuarioForm"
        Me.Text = "Baja usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltaUser As Label
    Friend WithEvents tbxCI As TextBox
    Friend WithEvents blCI As Label
    Friend WithEvents btnAceptarBaja As Button
    Friend WithEvents btnCancelarBaja As Button
End Class
