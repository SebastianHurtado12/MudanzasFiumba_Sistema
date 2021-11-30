<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacenes
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
        Me.lblModificarCliente = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.txtDocumentoVerificar = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.llAtras = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblModificarCliente
        '
        Me.lblModificarCliente.AutoSize = True
        Me.lblModificarCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarCliente.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblModificarCliente.Location = New System.Drawing.Point(106, 18)
        Me.lblModificarCliente.Name = "lblModificarCliente"
        Me.lblModificarCliente.Size = New System.Drawing.Size(278, 84)
        Me.lblModificarCliente.TabIndex = 39
        Me.lblModificarCliente.Text = "Verificación de Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblDocumento.Location = New System.Drawing.Point(12, 83)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(135, 19)
        Me.lblDocumento.TabIndex = 40
        Me.lblDocumento.Text = "Nro Documento"
        '
        'txtDocumentoVerificar
        '
        Me.txtDocumentoVerificar.Location = New System.Drawing.Point(158, 84)
        Me.txtDocumentoVerificar.Name = "txtDocumentoVerificar"
        Me.txtDocumentoVerificar.Size = New System.Drawing.Size(254, 20)
        Me.txtDocumentoVerificar.TabIndex = 41
        '
        'btnVerificar
        '
        Me.btnVerificar.BackColor = System.Drawing.Color.Salmon
        Me.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerificar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVerificar.Location = New System.Drawing.Point(126, 127)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(209, 45)
        Me.btnVerificar.TabIndex = 42
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(126, 127)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(209, 45)
        Me.btnSiguiente.TabIndex = 43
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'llAtras
        '
        Me.llAtras.AutoSize = True
        Me.llAtras.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAtras.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.llAtras.LinkColor = System.Drawing.Color.Cornsilk
        Me.llAtras.Location = New System.Drawing.Point(393, 147)
        Me.llAtras.Name = "llAtras"
        Me.llAtras.Size = New System.Drawing.Size(57, 32)
        Me.llAtras.TabIndex = 58
        Me.llAtras.TabStop = True
        Me.llAtras.Text = "Atras"
        '
        'frmAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(462, 188)
        Me.Controls.Add(Me.llAtras)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtDocumentoVerificar)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblModificarCliente)
        Me.Controls.Add(Me.btnSiguiente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAlmacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModificarCliente As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents txtDocumentoVerificar As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents llAtras As System.Windows.Forms.LinkLabel
End Class
