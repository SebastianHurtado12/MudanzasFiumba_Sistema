<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosPresupuesto
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
        Me.txtTelefonoSemiCliente = New System.Windows.Forms.TextBox()
        Me.txtNomApeSemiCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoSemiCliente = New System.Windows.Forms.Label()
        Me.lblNomApeSemiCliente = New System.Windows.Forms.Label()
        Me.txtDocumentoSemiCliente = New System.Windows.Forms.TextBox()
        Me.lblDNISemiCliente = New System.Windows.Forms.Label()
        Me.lblIngresarSemiCliente = New System.Windows.Forms.Label()
        Me.lblTitDatosPresup = New System.Windows.Forms.Label()
        Me.btnComprobarModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTelefonoSemiCliente
        '
        Me.txtTelefonoSemiCliente.Location = New System.Drawing.Point(238, 231)
        Me.txtTelefonoSemiCliente.Name = "txtTelefonoSemiCliente"
        Me.txtTelefonoSemiCliente.Size = New System.Drawing.Size(259, 20)
        Me.txtTelefonoSemiCliente.TabIndex = 44
        '
        'txtNomApeSemiCliente
        '
        Me.txtNomApeSemiCliente.Location = New System.Drawing.Point(239, 173)
        Me.txtNomApeSemiCliente.Name = "txtNomApeSemiCliente"
        Me.txtNomApeSemiCliente.Size = New System.Drawing.Size(259, 20)
        Me.txtNomApeSemiCliente.TabIndex = 43
        '
        'lblTelefonoSemiCliente
        '
        Me.lblTelefonoSemiCliente.AutoSize = True
        Me.lblTelefonoSemiCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoSemiCliente.ForeColor = System.Drawing.Color.White
        Me.lblTelefonoSemiCliente.Location = New System.Drawing.Point(57, 232)
        Me.lblTelefonoSemiCliente.Name = "lblTelefonoSemiCliente"
        Me.lblTelefonoSemiCliente.Size = New System.Drawing.Size(64, 23)
        Me.lblTelefonoSemiCliente.TabIndex = 40
        Me.lblTelefonoSemiCliente.Text = "Telefono:"
        '
        'lblNomApeSemiCliente
        '
        Me.lblNomApeSemiCliente.AutoSize = True
        Me.lblNomApeSemiCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomApeSemiCliente.ForeColor = System.Drawing.Color.Snow
        Me.lblNomApeSemiCliente.Location = New System.Drawing.Point(56, 173)
        Me.lblNomApeSemiCliente.Name = "lblNomApeSemiCliente"
        Me.lblNomApeSemiCliente.Size = New System.Drawing.Size(126, 23)
        Me.lblNomApeSemiCliente.TabIndex = 39
        Me.lblNomApeSemiCliente.Text = "Nombre Y Apellido:"
        '
        'txtDocumentoSemiCliente
        '
        Me.txtDocumentoSemiCliente.Location = New System.Drawing.Point(238, 119)
        Me.txtDocumentoSemiCliente.Name = "txtDocumentoSemiCliente"
        Me.txtDocumentoSemiCliente.Size = New System.Drawing.Size(259, 20)
        Me.txtDocumentoSemiCliente.TabIndex = 38
        '
        'lblDNISemiCliente
        '
        Me.lblDNISemiCliente.AutoSize = True
        Me.lblDNISemiCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNISemiCliente.ForeColor = System.Drawing.Color.White
        Me.lblDNISemiCliente.Location = New System.Drawing.Point(57, 117)
        Me.lblDNISemiCliente.Name = "lblDNISemiCliente"
        Me.lblDNISemiCliente.Size = New System.Drawing.Size(82, 23)
        Me.lblDNISemiCliente.TabIndex = 37
        Me.lblDNISemiCliente.Text = "Documento:"
        '
        'lblIngresarSemiCliente
        '
        Me.lblIngresarSemiCliente.AutoSize = True
        Me.lblIngresarSemiCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresarSemiCliente.ForeColor = System.Drawing.Color.White
        Me.lblIngresarSemiCliente.Location = New System.Drawing.Point(33, 75)
        Me.lblIngresarSemiCliente.Name = "lblIngresarSemiCliente"
        Me.lblIngresarSemiCliente.Size = New System.Drawing.Size(127, 19)
        Me.lblIngresarSemiCliente.TabIndex = 36
        Me.lblIngresarSemiCliente.Text = "Ingrese Los Sig. Datos:"
        '
        'lblTitDatosPresup
        '
        Me.lblTitDatosPresup.AutoSize = True
        Me.lblTitDatosPresup.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDatosPresup.ForeColor = System.Drawing.Color.White
        Me.lblTitDatosPresup.Location = New System.Drawing.Point(180, 28)
        Me.lblTitDatosPresup.Name = "lblTitDatosPresup"
        Me.lblTitDatosPresup.Size = New System.Drawing.Size(180, 33)
        Me.lblTitDatosPresup.TabIndex = 45
        Me.lblTitDatosPresup.Text = "DATOS DEL CLIENTE"
        '
        'btnComprobarModificar
        '
        Me.btnComprobarModificar.BackColor = System.Drawing.Color.Salmon
        Me.btnComprobarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprobarModificar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobarModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComprobarModificar.Location = New System.Drawing.Point(142, 312)
        Me.btnComprobarModificar.Name = "btnComprobarModificar"
        Me.btnComprobarModificar.Size = New System.Drawing.Size(241, 61)
        Me.btnComprobarModificar.TabIndex = 46
        Me.btnComprobarModificar.Text = "&CREAR PRESUPUESTO"
        Me.btnComprobarModificar.UseVisualStyleBackColor = False
        '
        'frmDatosPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(532, 408)
        Me.Controls.Add(Me.btnComprobarModificar)
        Me.Controls.Add(Me.lblTitDatosPresup)
        Me.Controls.Add(Me.txtTelefonoSemiCliente)
        Me.Controls.Add(Me.txtNomApeSemiCliente)
        Me.Controls.Add(Me.lblTelefonoSemiCliente)
        Me.Controls.Add(Me.lblNomApeSemiCliente)
        Me.Controls.Add(Me.txtDocumentoSemiCliente)
        Me.Controls.Add(Me.lblDNISemiCliente)
        Me.Controls.Add(Me.lblIngresarSemiCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDatosPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Presupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTelefonoSemiCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNomApeSemiCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonoSemiCliente As System.Windows.Forms.Label
    Friend WithEvents lblNomApeSemiCliente As System.Windows.Forms.Label
    Friend WithEvents txtDocumentoSemiCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblDNISemiCliente As System.Windows.Forms.Label
    Friend WithEvents lblIngresarSemiCliente As System.Windows.Forms.Label
    Friend WithEvents lblTitDatosPresup As System.Windows.Forms.Label
    Friend WithEvents btnComprobarModificar As System.Windows.Forms.Button
End Class
