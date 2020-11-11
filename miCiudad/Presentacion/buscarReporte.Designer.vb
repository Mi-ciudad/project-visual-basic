<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buscarReporte))
        Me.btnAceptar = New System.Windows.Forms.Button()
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
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.btnAceptar.Location = New System.Drawing.Point(560, 507)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 36)
        Me.btnAceptar.TabIndex = 71
        Me.btnAceptar.Text = "Buscar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombre.Location = New System.Drawing.Point(92, 179)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(103, 20)
        Me.lblNombre.TabIndex = 61
        Me.lblNombre.Text = "Id de reporte"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(123, 85)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(154, 26)
        Me.lblTitulo.TabIndex = 60
        Me.lblTitulo.Text = "Buscar reporte"
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = Global.miCiudad.My.Resources.Resources.Vector
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(85, 87)
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
        'tbxId
        '
        Me.tbxId.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxId.Location = New System.Drawing.Point(94, 211)
        Me.tbxId.Multiline = True
        Me.tbxId.Name = "tbxId"
        Me.tbxId.Size = New System.Drawing.Size(314, 35)
        Me.tbxId.TabIndex = 56
        '
        'buscarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 611)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Controls.Add(Me.pbxLinea)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Controls.Add(Me.tbxId)
        Me.Name = "buscarReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
    Friend WithEvents pbxLinea As PictureBox
    Friend WithEvents pbxRectangulo As PictureBox
    Private WithEvents tbxId As TextBox
End Class
