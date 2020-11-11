<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modificarEstadoReporteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificarEstadoReporteForm))
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxVectorAltaUsuario = New System.Windows.Forms.PictureBox()
        Me.pbxLinea = New System.Windows.Forms.PictureBox()
        Me.pbxRectangulo = New System.Windows.Forms.PictureBox()
        Me.tbxId = New System.Windows.Forms.TextBox()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxEstado
        '
        Me.cbxEstado.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"En revision", "Rechazado", "Solucionado"})
        Me.cbxEstado.Location = New System.Drawing.Point(633, 211)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(196, 30)
        Me.cbxEstado.TabIndex = 82
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
        Me.btnAceptar.TabIndex = 81
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(629, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Estado a asignar"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombre.Location = New System.Drawing.Point(291, 179)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(103, 20)
        Me.lblNombre.TabIndex = 78
        Me.lblNombre.Text = "Id de reporte"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(122, 85)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(275, 26)
        Me.lblTitulo.TabIndex = 77
        Me.lblTitulo.Text = "Modificar estado de reporte"
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = Global.miCiudad.My.Resources.Resources.Vector
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(84, 87)
        Me.pbxVectorAltaUsuario.Name = "pbxVectorAltaUsuario"
        Me.pbxVectorAltaUsuario.Size = New System.Drawing.Size(34, 27)
        Me.pbxVectorAltaUsuario.TabIndex = 76
        Me.pbxVectorAltaUsuario.TabStop = False
        '
        'pbxLinea
        '
        Me.pbxLinea.Image = CType(resources.GetObject("pbxLinea.Image"), System.Drawing.Image)
        Me.pbxLinea.Location = New System.Drawing.Point(60, 120)
        Me.pbxLinea.Name = "pbxLinea"
        Me.pbxLinea.Size = New System.Drawing.Size(1000, 14)
        Me.pbxLinea.TabIndex = 75
        Me.pbxLinea.TabStop = False
        '
        'pbxRectangulo
        '
        Me.pbxRectangulo.Image = CType(resources.GetObject("pbxRectangulo.Image"), System.Drawing.Image)
        Me.pbxRectangulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxRectangulo.Name = "pbxRectangulo"
        Me.pbxRectangulo.Size = New System.Drawing.Size(1120, 60)
        Me.pbxRectangulo.TabIndex = 74
        Me.pbxRectangulo.TabStop = False
        '
        'tbxId
        '
        Me.tbxId.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxId.Location = New System.Drawing.Point(293, 211)
        Me.tbxId.Multiline = True
        Me.tbxId.Name = "tbxId"
        Me.tbxId.Size = New System.Drawing.Size(196, 35)
        Me.tbxId.TabIndex = 73
        '
        'modificarEstadoReporteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 611)
        Me.Controls.Add(Me.cbxEstado)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Controls.Add(Me.pbxLinea)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Controls.Add(Me.tbxId)
        Me.Name = "modificarEstadoReporteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificarEstadoReporteForm"
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents cbxEstado As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
    Friend WithEvents pbxLinea As PictureBox
    Friend WithEvents pbxRectangulo As PictureBox
    Private WithEvents tbxId As TextBox
End Class
