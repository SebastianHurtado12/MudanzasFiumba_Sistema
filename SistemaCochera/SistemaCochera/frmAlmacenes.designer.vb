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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblModificarCliente
        '
        Me.lblModificarCliente.AutoSize = True
        Me.lblModificarCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarCliente.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblModificarCliente.Location = New System.Drawing.Point(106, 9)
        Me.lblModificarCliente.Name = "lblModificarCliente"
        Me.lblModificarCliente.Size = New System.Drawing.Size(278, 84)
        Me.lblModificarCliente.TabIndex = 39
        Me.lblModificarCliente.Text = "Verificación de Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblDocumento.Location = New System.Drawing.Point(12, 93)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(135, 21)
        Me.lblDocumento.TabIndex = 40
        Me.lblDocumento.Text = "Nro Documento"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 20)
        Me.TextBox1.TabIndex = 41
        '
        'btnVerificar
        '
        Me.btnVerificar.BackColor = System.Drawing.Color.Salmon
        Me.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerificar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVerificar.Location = New System.Drawing.Point(137, 145)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(209, 45)
        Me.btnVerificar.TabIndex = 42
        Me.btnVerificar.Text = "VERIFICAR"
        Me.btnVerificar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(0, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Mudanzas Fiumba"
        '
        'frmAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(484, 222)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblModificarCliente)
        Me.Name = "frmAlmacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAlmacenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModificarCliente As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
