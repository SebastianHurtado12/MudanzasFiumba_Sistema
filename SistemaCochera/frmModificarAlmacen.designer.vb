<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarAlmacen
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
        Me.cmbmudanza = New System.Windows.Forms.ComboBox()
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
        Me.llAtras.Location = New System.Drawing.Point(530, 331)
        Me.llAtras.Name = "llAtras"
        Me.llAtras.Size = New System.Drawing.Size(57, 32)
        Me.llAtras.TabIndex = 56
        Me.llAtras.TabStop = True
        Me.llAtras.Text = "Atras"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirmar.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(377, 123)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(148, 25)
        Me.btnConfirmar.TabIndex = 55
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnPrecio
        '
        Me.btnPrecio.BackColor = System.Drawing.Color.Salmon
        Me.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrecio.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrecio.Location = New System.Drawing.Point(176, 272)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(233, 49)
        Me.btnPrecio.TabIndex = 54
        Me.btnPrecio.Text = "&MODIFICAR PRECIO"
        Me.btnPrecio.UseVisualStyleBackColor = False
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(160, 204)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(202, 20)
        Me.txtLista.TabIndex = 53
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblPrecio.Location = New System.Drawing.Point(12, 202)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(122, 19)
        Me.lblPrecio.TabIndex = 52
        Me.lblPrecio.Text = "Precio de Lista:"
        '
        'cmbmudanza
        '
        Me.cmbmudanza.FormattingEnabled = True
        Me.cmbmudanza.Location = New System.Drawing.Point(17, 127)
        Me.cmbmudanza.Name = "cmbmudanza"
        Me.cmbmudanza.Size = New System.Drawing.Size(329, 21)
        Me.cmbmudanza.TabIndex = 51
        '
        'lblIngresar
        '
        Me.lblIngresar.AutoSize = True
        Me.lblIngresar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresar.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblIngresar.Location = New System.Drawing.Point(14, 93)
        Me.lblIngresar.Name = "lblIngresar"
        Me.lblIngresar.Size = New System.Drawing.Size(333, 18)
        Me.lblIngresar.TabIndex = 50
        Me.lblIngresar.Text = "Seleccione el Almacen Correspondiente:"
        '
        'lblModificarCliente
        '
        Me.lblModificarCliente.AutoSize = True
        Me.lblModificarCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarCliente.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblModificarCliente.Location = New System.Drawing.Point(110, 25)
        Me.lblModificarCliente.Name = "lblModificarCliente"
        Me.lblModificarCliente.Size = New System.Drawing.Size(353, 42)
        Me.lblModificarCliente.TabIndex = 49
        Me.lblModificarCliente.Text = "Modificar Precios Almacenes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Mudanzas Fiumba"
        '
        'frmModificarAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(599, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.llAtras)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnPrecio)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cmbmudanza)
        Me.Controls.Add(Me.lblIngresar)
        Me.Controls.Add(Me.lblModificarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModificarAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Almacenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llAtras As System.Windows.Forms.LinkLabel
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnPrecio As System.Windows.Forms.Button
    Friend WithEvents txtLista As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents cmbmudanza As System.Windows.Forms.ComboBox
    Friend WithEvents lblIngresar As System.Windows.Forms.Label
    Friend WithEvents lblModificarCliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
