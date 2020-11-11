<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bajaUsuarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bajaUsuarioForm))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxVectorAltaUsuario = New System.Windows.Forms.PictureBox()
        Me.pbxLinea = New System.Windows.Forms.PictureBox()
        Me.pbxRectangulo = New System.Windows.Forms.PictureBox()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.btnAceptar.Location = New System.Drawing.Point(491, 516)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(140, 36)
        Me.btnAceptar.TabIndex = 71
        Me.btnAceptar.Text = "Eliminar usuario"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCi.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCi.Location = New System.Drawing.Point(81, 179)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(61, 20)
        Me.lblCi.TabIndex = 69
        Me.lblCi.Text = "Cedula"
        '
        'tbxCi
        '
        Me.tbxCi.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCi.Location = New System.Drawing.Point(85, 211)
        Me.tbxCi.Multiline = True
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(368, 35)
        Me.tbxCi.TabIndex = 68
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(123, 85)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(133, 26)
        Me.lblTitulo.TabIndex = 60
        Me.lblTitulo.Text = "Baja usuario"
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = Global.miCiudad.My.Resources.Resources.Vector
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(85, 88)
        Me.pbxVectorAltaUsuario.Name = "pbxVectorAltaUsuario"
        Me.pbxVectorAltaUsuario.Size = New System.Drawing.Size(34, 27)
        Me.pbxVectorAltaUsuario.TabIndex = 59
        Me.pbxVectorAltaUsuario.TabStop = False
        '
        'pbxLinea
        '
        Me.pbxLinea.Image = CType(resources.GetObject("pbxLinea.Image"), System.Drawing.Image)
        Me.pbxLinea.Location = New System.Drawing.Point(60, 120)
        Me.pbxLinea.Name = "pbxLinea"
        Me.pbxLinea.Size = New System.Drawing.Size(1000, 14)
        Me.pbxLinea.TabIndex = 58
        Me.pbxLinea.TabStop = False
        '
        'pbxRectangulo
        '
        Me.pbxRectangulo.Image = CType(resources.GetObject("pbxRectangulo.Image"), System.Drawing.Image)
        Me.pbxRectangulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxRectangulo.Name = "pbxRectangulo"
        Me.pbxRectangulo.Size = New System.Drawing.Size(1120, 60)
        Me.pbxRectangulo.TabIndex = 57
        Me.pbxRectangulo.TabStop = False
        '
        'bajaUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 611)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.tbxCi)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Controls.Add(Me.pbxLinea)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Name = "bajaUsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja usuario"
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblCi As Label
    Private WithEvents tbxCi As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
    Friend WithEvents pbxLinea As PictureBox
    Friend WithEvents pbxRectangulo As PictureBox
End Class
