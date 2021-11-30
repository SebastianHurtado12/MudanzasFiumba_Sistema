<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratoAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContratoAlmacen))
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.lblCuota = New System.Windows.Forms.Label()
        Me.lblClienteMail = New System.Windows.Forms.Label()
        Me.lblClienteDom = New System.Windows.Forms.Label()
        Me.lblClienteDNI = New System.Windows.Forms.Label()
        Me.lblClienteNom = New System.Windows.Forms.Label()
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.pbContrato = New System.Windows.Forms.PictureBox()
        CType(Me.pbContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.BackColor = System.Drawing.Color.White
        Me.lblContrato.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrato.ForeColor = System.Drawing.Color.Black
        Me.lblContrato.Location = New System.Drawing.Point(580, 462)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(0, 19)
        Me.lblContrato.TabIndex = 21
        '
        'lblCuota
        '
        Me.lblCuota.AutoSize = True
        Me.lblCuota.BackColor = System.Drawing.Color.White
        Me.lblCuota.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuota.ForeColor = System.Drawing.Color.Black
        Me.lblCuota.Location = New System.Drawing.Point(152, 462)
        Me.lblCuota.Name = "lblCuota"
        Me.lblCuota.Size = New System.Drawing.Size(0, 19)
        Me.lblCuota.TabIndex = 20
        '
        'lblClienteMail
        '
        Me.lblClienteMail.AutoSize = True
        Me.lblClienteMail.BackColor = System.Drawing.Color.White
        Me.lblClienteMail.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteMail.ForeColor = System.Drawing.Color.Black
        Me.lblClienteMail.Location = New System.Drawing.Point(141, 252)
        Me.lblClienteMail.Name = "lblClienteMail"
        Me.lblClienteMail.Size = New System.Drawing.Size(0, 17)
        Me.lblClienteMail.TabIndex = 19
        '
        'lblClienteDom
        '
        Me.lblClienteDom.AutoSize = True
        Me.lblClienteDom.BackColor = System.Drawing.Color.White
        Me.lblClienteDom.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteDom.ForeColor = System.Drawing.Color.Black
        Me.lblClienteDom.Location = New System.Drawing.Point(403, 228)
        Me.lblClienteDom.Name = "lblClienteDom"
        Me.lblClienteDom.Size = New System.Drawing.Size(0, 19)
        Me.lblClienteDom.TabIndex = 18
        '
        'lblClienteDNI
        '
        Me.lblClienteDNI.AutoSize = True
        Me.lblClienteDNI.BackColor = System.Drawing.Color.White
        Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteDNI.ForeColor = System.Drawing.Color.Black
        Me.lblClienteDNI.Location = New System.Drawing.Point(535, 196)
        Me.lblClienteDNI.Name = "lblClienteDNI"
        Me.lblClienteDNI.Size = New System.Drawing.Size(0, 19)
        Me.lblClienteDNI.TabIndex = 17
        '
        'lblClienteNom
        '
        Me.lblClienteNom.AutoSize = True
        Me.lblClienteNom.BackColor = System.Drawing.Color.White
        Me.lblClienteNom.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteNom.ForeColor = System.Drawing.Color.Black
        Me.lblClienteNom.Location = New System.Drawing.Point(258, 196)
        Me.lblClienteNom.Name = "lblClienteNom"
        Me.lblClienteNom.Size = New System.Drawing.Size(0, 19)
        Me.lblClienteNom.TabIndex = 16
        '
        'btnRecibo
        '
        Me.btnRecibo.BackColor = System.Drawing.Color.Salmon
        Me.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecibo.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRecibo.Location = New System.Drawing.Point(444, 495)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(287, 38)
        Me.btnRecibo.TabIndex = 15
        Me.btnRecibo.Text = "Dar Recibo"
        Me.btnRecibo.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Salmon
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.Location = New System.Drawing.Point(24, 495)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(287, 38)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblTitulo.Location = New System.Drawing.Point(180, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(386, 27)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "* CONTRATO DE ALQUILER DE ALMACEN *"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(202, 199)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 16)
        Me.lblNombre.TabIndex = 22
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.BackColor = System.Drawing.Color.White
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(475, 200)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(0, 16)
        Me.lblDNI.TabIndex = 23
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.White
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(372, 223)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(0, 16)
        Me.lblDireccion.TabIndex = 24
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.White
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(73, 244)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(0, 16)
        Me.lblMail.TabIndex = 25
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.White
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(87, 407)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(56, 16)
        Me.lblMonto.TabIndex = 26
        Me.lblMonto.Text = "aaaaaa"
        '
        'pbContrato
        '
        Me.pbContrato.Image = CType(resources.GetObject("pbContrato.Image"), System.Drawing.Image)
        Me.pbContrato.Location = New System.Drawing.Point(67, 57)
        Me.pbContrato.Name = "pbContrato"
        Me.pbContrato.Size = New System.Drawing.Size(614, 402)
        Me.pbContrato.TabIndex = 13
        Me.pbContrato.TabStop = False
        '
        'frmContratoAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(772, 546)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblContrato)
        Me.Controls.Add(Me.lblCuota)
        Me.Controls.Add(Me.lblClienteMail)
        Me.Controls.Add(Me.lblClienteDom)
        Me.Controls.Add(Me.lblClienteDNI)
        Me.Controls.Add(Me.lblClienteNom)
        Me.Controls.Add(Me.btnRecibo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.pbContrato)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContratoAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato Almacen"
        CType(Me.pbContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblContrato As System.Windows.Forms.Label
    Friend WithEvents lblCuota As System.Windows.Forms.Label
    Friend WithEvents lblClienteMail As System.Windows.Forms.Label
    Friend WithEvents lblClienteDom As System.Windows.Forms.Label
    Friend WithEvents lblClienteDNI As System.Windows.Forms.Label
    Friend WithEvents lblClienteNom As System.Windows.Forms.Label
    Friend WithEvents btnRecibo As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents pbContrato As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
End Class
