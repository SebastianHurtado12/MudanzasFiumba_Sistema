<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCamion
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
        Me.llAtras = New System.Windows.Forms.LinkLabel()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.cmbCamiones = New System.Windows.Forms.ComboBox()
        Me.lblIngresar = New System.Windows.Forms.Label()
        Me.lblModificarCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'llAtras
        '
        Me.llAtras.AutoSize = True
        Me.llAtras.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAtras.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.llAtras.LinkColor = System.Drawing.Color.Cornsilk
        Me.llAtras.Location = New System.Drawing.Point(487, 355)
        Me.llAtras.Name = "llAtras"
        Me.llAtras.Size = New System.Drawing.Size(57, 32)
        Me.llAtras.TabIndex = 48
        Me.llAtras.TabStop = True
        Me.llAtras.Text = "Atras"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.White
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirmar.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfirmar.Location = New System.Drawing.Point(379, 130)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(148, 25)
        Me.btnConfirmar.TabIndex = 47
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnPrecio
        '
        Me.btnPrecio.BackColor = System.Drawing.Color.Salmon
        Me.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrecio.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrecio.Location = New System.Drawing.Point(162, 294)
        Me.btnPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(233, 48)
        Me.btnPrecio.TabIndex = 46
        Me.btnPrecio.Text = "&MODIFICAR PRECIO"
        Me.btnPrecio.UseVisualStyleBackColor = False
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(153, 222)
        Me.txtLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(202, 20)
        Me.txtLista.TabIndex = 45
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblPrecio.Location = New System.Drawing.Point(12, 223)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(132, 18)
        Me.lblPrecio.TabIndex = 44
        Me.lblPrecio.Text = "Precio de Lista:"
        '
        'cmbCamiones
        '
        Me.cmbCamiones.FormattingEnabled = True
        Me.cmbCamiones.Location = New System.Drawing.Point(16, 134)
        Me.cmbCamiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCamiones.Name = "cmbCamiones"
        Me.cmbCamiones.Size = New System.Drawing.Size(329, 21)
        Me.cmbCamiones.TabIndex = 43
        '
        'lblIngresar
        '
        Me.lblIngresar.AutoSize = True
        Me.lblIngresar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresar.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblIngresar.Location = New System.Drawing.Point(13, 100)
        Me.lblIngresar.Name = "lblIngresar"
        Me.lblIngresar.Size = New System.Drawing.Size(323, 18)
        Me.lblIngresar.TabIndex = 42
        Me.lblIngresar.Text = "Seleccione el Camion Correspondiente:"
        '
        'lblModificarCliente
        '
        Me.lblModificarCliente.AutoSize = True
        Me.lblModificarCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarCliente.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblModificarCliente.Location = New System.Drawing.Point(100, 27)
        Me.lblModificarCliente.Name = "lblModificarCliente"
        Me.lblModificarCliente.Size = New System.Drawing.Size(329, 39)
        Me.lblModificarCliente.TabIndex = 41
        Me.lblModificarCliente.Text = "MODIFICAR PRECIOS CAMIONES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Mudanzas Fiumba"
        '
        'frmModificarCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(556, 396)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.llAtras)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnPrecio)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cmbCamiones)
        Me.Controls.Add(Me.lblIngresar)
        Me.Controls.Add(Me.lblModificarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmModificarCamion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Camion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llAtras As System.Windows.Forms.LinkLabel
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnPrecio As System.Windows.Forms.Button
    Friend WithEvents txtLista As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents cmbCamiones As System.Windows.Forms.ComboBox
    Friend WithEvents lblIngresar As System.Windows.Forms.Label
    Friend WithEvents lblModificarCliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
