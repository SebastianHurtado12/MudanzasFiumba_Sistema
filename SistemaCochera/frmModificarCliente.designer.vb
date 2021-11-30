<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCliente
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
        Me.btnComprobarModificar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtDocumentoModificar = New System.Windows.Forms.TextBox()
        Me.lblModificarDNI = New System.Windows.Forms.Label()
        Me.lblIngresar = New System.Windows.Forms.Label()
        Me.lblModificarCliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnComprobarModificar
        '
        Me.btnComprobarModificar.BackColor = System.Drawing.Color.Salmon
        Me.btnComprobarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprobarModificar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobarModificar.ForeColor = System.Drawing.Color.White
        Me.btnComprobarModificar.Location = New System.Drawing.Point(224, 464)
        Me.btnComprobarModificar.Name = "btnComprobarModificar"
        Me.btnComprobarModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnComprobarModificar.Size = New System.Drawing.Size(241, 61)
        Me.btnComprobarModificar.TabIndex = 42
        Me.btnComprobarModificar.Text = "&COMPROBAR CLIENTE"
        Me.btnComprobarModificar.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Cornsilk
        Me.LinkLabel1.Location = New System.Drawing.Point(596, 523)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 32)
        Me.LinkLabel1.TabIndex = 52
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Atras"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(224, 465)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(241, 61)
        Me.btnModificar.TabIndex = 51
        Me.btnModificar.Text = "&Modificar Cliente"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(214, 387)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(365, 20)
        Me.txtDireccion.TabIndex = 50
        Me.txtDireccion.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(212, 327)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(366, 20)
        Me.txtEmail.TabIndex = 49
        Me.txtEmail.Visible = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(211, 263)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(367, 20)
        Me.txtTelefono.TabIndex = 48
        Me.txtTelefono.Visible = False
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(211, 199)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(366, 20)
        Me.txtApellido.TabIndex = 47
        Me.txtApellido.Visible = False
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblDireccion.Location = New System.Drawing.Point(41, 388)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(89, 19)
        Me.lblDireccion.TabIndex = 46
        Me.lblDireccion.Text = "Direccion:"
        Me.lblDireccion.Visible = False
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblMail.Location = New System.Drawing.Point(41, 328)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(58, 19)
        Me.lblMail.TabIndex = 45
        Me.lblMail.Text = "Email:"
        Me.lblMail.Visible = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblTelefono.Location = New System.Drawing.Point(41, 264)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(80, 19)
        Me.lblTelefono.TabIndex = 44
        Me.lblTelefono.Text = "Telefono:"
        Me.lblTelefono.Visible = False
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblApellido.Location = New System.Drawing.Point(41, 199)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(160, 21)
        Me.lblApellido.TabIndex = 43
        Me.lblApellido.Text = "Nombre Y Apellido:"
        Me.lblApellido.Visible = False
        '
        'txtDocumentoModificar
        '
        Me.txtDocumentoModificar.Location = New System.Drawing.Point(210, 136)
        Me.txtDocumentoModificar.Name = "txtDocumentoModificar"
        Me.txtDocumentoModificar.Size = New System.Drawing.Size(367, 20)
        Me.txtDocumentoModificar.TabIndex = 41
        '
        'lblModificarDNI
        '
        Me.lblModificarDNI.AutoSize = True
        Me.lblModificarDNI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarDNI.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblModificarDNI.Location = New System.Drawing.Point(41, 133)
        Me.lblModificarDNI.Name = "lblModificarDNI"
        Me.lblModificarDNI.Size = New System.Drawing.Size(108, 21)
        Me.lblModificarDNI.TabIndex = 40
        Me.lblModificarDNI.Text = "Documento:"
        '
        'lblIngresar
        '
        Me.lblIngresar.AutoSize = True
        Me.lblIngresar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresar.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblIngresar.Location = New System.Drawing.Point(12, 80)
        Me.lblIngresar.Name = "lblIngresar"
        Me.lblIngresar.Size = New System.Drawing.Size(246, 18)
        Me.lblIngresar.TabIndex = 39
        Me.lblIngresar.Text = "Ingrese Los Siguientes Datos:"
        '
        'lblModificarCliente
        '
        Me.lblModificarCliente.AutoSize = True
        Me.lblModificarCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarCliente.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblModificarCliente.Location = New System.Drawing.Point(195, 22)
        Me.lblModificarCliente.Name = "lblModificarCliente"
        Me.lblModificarCliente.Size = New System.Drawing.Size(302, 35)
        Me.lblModificarCliente.TabIndex = 38
        Me.lblModificarCliente.Text = "MODIFICAR DATOS DEL CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 538)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Mudanzas Fiumba"
        '
        'frmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(665, 564)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnComprobarModificar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtDocumentoModificar)
        Me.Controls.Add(Me.lblModificarDNI)
        Me.Controls.Add(Me.lblIngresar)
        Me.Controls.Add(Me.lblModificarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModificarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtDocumentoModificar As System.Windows.Forms.TextBox
    Friend WithEvents lblModificarDNI As System.Windows.Forms.Label
    Friend WithEvents lblIngresar As System.Windows.Forms.Label
    Friend WithEvents lblModificarCliente As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnComprobarModificar As System.Windows.Forms.Button
End Class
