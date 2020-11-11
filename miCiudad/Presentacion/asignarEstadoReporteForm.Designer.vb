<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignarEstadoReporteForm
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
        Me.lblIDreporte = New System.Windows.Forms.Label()
        Me.tbxId = New System.Windows.Forms.TextBox()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelarModReporte = New System.Windows.Forms.Button()
        Me.btnAceptarModReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaUser.Location = New System.Drawing.Point(194, 22)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(364, 25)
        Me.lblAltaUser.TabIndex = 30
        Me.lblAltaUser.Text = "ASIGNAR ESTADO DE REPORTE"
        '
        'lblIDreporte
        '
        Me.lblIDreporte.AutoSize = True
        Me.lblIDreporte.Location = New System.Drawing.Point(268, 105)
        Me.lblIDreporte.Name = "lblIDreporte"
        Me.lblIDreporte.Size = New System.Drawing.Size(77, 13)
        Me.lblIDreporte.TabIndex = 32
        Me.lblIDreporte.Text = "ID del reporte :"
        '
        'tbxId
        '
        Me.tbxId.Location = New System.Drawing.Point(366, 102)
        Me.tbxId.Name = "tbxId"
        Me.tbxId.Size = New System.Drawing.Size(100, 20)
        Me.tbxId.TabIndex = 31
        '
        'cbxEstado
        '
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"Rechazado", "Pendiente ", "En revision", "Solucionado"})
        Me.cbxEstado.Location = New System.Drawing.Point(366, 137)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(100, 21)
        Me.cbxEstado.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Estado a asignar :"
        '
        'btnCancelarModReporte
        '
        Me.btnCancelarModReporte.Location = New System.Drawing.Point(260, 224)
        Me.btnCancelarModReporte.Name = "btnCancelarModReporte"
        Me.btnCancelarModReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarModReporte.TabIndex = 36
        Me.btnCancelarModReporte.Text = "Cancelar"
        Me.btnCancelarModReporte.UseVisualStyleBackColor = True
        '
        'btnAceptarModReport
        '
        Me.btnAceptarModReport.Location = New System.Drawing.Point(401, 224)
        Me.btnAceptarModReport.Name = "btnAceptarModReport"
        Me.btnAceptarModReport.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarModReport.TabIndex = 35
        Me.btnAceptarModReport.Text = "Aceptar"
        Me.btnAceptarModReport.UseVisualStyleBackColor = True
        '
        'asignarEstadoReporteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarModReporte)
        Me.Controls.Add(Me.btnAceptarModReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxEstado)
        Me.Controls.Add(Me.lblIDreporte)
        Me.Controls.Add(Me.tbxId)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Name = "asignarEstadoReporteForm"
        Me.Text = "Asignar estado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltaUser As Label
    Friend WithEvents lblIDreporte As Label
    Friend WithEvents tbxId As TextBox
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelarModReporte As Button
    Friend WithEvents btnAceptarModReport As Button
End Class
