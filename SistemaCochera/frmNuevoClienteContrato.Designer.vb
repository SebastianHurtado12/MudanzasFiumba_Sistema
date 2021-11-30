<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoClienteContrato
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
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.btnEmitirCont = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblDatos.Location = New System.Drawing.Point(124, 24)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(285, 29)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "INSERTE DATOS PARA EL CONTRATO"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(19, 65)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 25)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "CLIENTE"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.White
        Me.lblDocumento.Location = New System.Drawing.Point(21, 106)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(104, 23)
        Me.lblDocumento.TabIndex = 3
        Me.lblDocumento.Text = "Nro Documento"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(20, 149)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(123, 23)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Nombre Y Apellido"
        Me.lblApellido.Visible = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(21, 190)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 23)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Telefono"
        Me.lblTelefono.Visible = False
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(20, 234)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(45, 23)
        Me.lblMail.TabIndex = 6
        Me.lblMail.Text = "Email"
        Me.lblMail.Visible = False
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.White
        Me.lblDireccion.Location = New System.Drawing.Point(22, 282)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(68, 23)
        Me.lblDireccion.TabIndex = 7
        Me.lblDireccion.Text = "Direccion"
        Me.lblDireccion.Visible = False
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(200, 150)
        Me.txtApellido.MaxLength = 70
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(292, 23)
        Me.txtApellido.TabIndex = 2
        Me.txtApellido.Visible = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(200, 194)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(292, 23)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.Visible = False
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(200, 237)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(292, 23)
        Me.txtMail.TabIndex = 4
        Me.txtMail.Visible = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(200, 283)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(292, 23)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.Visible = False
        '
        'txtDocumento
        '
        Me.txtDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(200, 107)
        Me.txtDocumento.MaxLength = 11
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(292, 23)
        Me.txtDocumento.TabIndex = 1
        '
        'btnEmitirCont
        '
        Me.btnEmitirCont.BackColor = System.Drawing.Color.Salmon
        Me.btnEmitirCont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmitirCont.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmitirCont.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmitirCont.Location = New System.Drawing.Point(129, 357)
        Me.btnEmitirCont.Name = "btnEmitirCont"
        Me.btnEmitirCont.Size = New System.Drawing.Size(241, 61)
        Me.btnEmitirCont.TabIndex = 10
        Me.btnEmitirCont.Text = "&Emitir Contrato"
        Me.btnEmitirCont.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Cornsilk
        Me.LinkLabel1.Location = New System.Drawing.Point(436, 398)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(68, 34)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Atras"
        '
        'btnComprobar
        '
        Me.btnComprobar.BackColor = System.Drawing.Color.Salmon
        Me.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprobar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComprobar.Location = New System.Drawing.Point(129, 357)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(241, 61)
        Me.btnComprobar.TabIndex = 22
        Me.btnComprobar.Text = "COMPROBAR CLIENTE"
        Me.btnComprobar.UseVisualStyleBackColor = False
        '
        'frmNuevoClienteContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(507, 432)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnEmitirCont)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNuevoClienteContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Ingreso de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents btnEmitirCont As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnComprobar As System.Windows.Forms.Button
End Class
