<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblNroRecibo = New System.Windows.Forms.Label()
        Me.lblDireccionEmpresa = New System.Windows.Forms.Label()
        Me.lblClienteNom = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblMontoLetras = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lnklbl = New System.Windows.Forms.LinkLabel()
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        Me.btnImprimir1 = New System.Windows.Forms.Button()
        Me.lblDniCliente = New System.Windows.Forms.Label()
        Me.lblDiaRecibo = New System.Windows.Forms.Label()
        Me.lblMesRecibo = New System.Windows.Forms.Label()
        Me.lblAnioRecibo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblTitulo.Location = New System.Drawing.Point(246, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(392, 33)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "RECIBO DEL ABONO DE LA MUDANZA PAGADA"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(25, 805)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(287, 39)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lblNroRecibo
        '
        Me.lblNroRecibo.AutoSize = True
        Me.lblNroRecibo.BackColor = System.Drawing.Color.White
        Me.lblNroRecibo.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroRecibo.Location = New System.Drawing.Point(694, 74)
        Me.lblNroRecibo.Name = "lblNroRecibo"
        Me.lblNroRecibo.Size = New System.Drawing.Size(0, 24)
        Me.lblNroRecibo.TabIndex = 11
        '
        'lblDireccionEmpresa
        '
        Me.lblDireccionEmpresa.AutoSize = True
        Me.lblDireccionEmpresa.BackColor = System.Drawing.Color.White
        Me.lblDireccionEmpresa.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionEmpresa.Location = New System.Drawing.Point(116, 151)
        Me.lblDireccionEmpresa.Name = "lblDireccionEmpresa"
        Me.lblDireccionEmpresa.Size = New System.Drawing.Size(138, 17)
        Me.lblDireccionEmpresa.TabIndex = 12
        Me.lblDireccionEmpresa.Text = "AV.Lope de Vega 233"
        '
        'lblClienteNom
        '
        Me.lblClienteNom.AutoSize = True
        Me.lblClienteNom.BackColor = System.Drawing.Color.White
        Me.lblClienteNom.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteNom.Location = New System.Drawing.Point(195, 183)
        Me.lblClienteNom.Name = "lblClienteNom"
        Me.lblClienteNom.Size = New System.Drawing.Size(0, 24)
        Me.lblClienteNom.TabIndex = 13
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.White
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(637, 216)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(0, 24)
        Me.lblMonto.TabIndex = 14
        '
        'lblMontoLetras
        '
        Me.lblMontoLetras.AutoSize = True
        Me.lblMontoLetras.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMontoLetras.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoLetras.Location = New System.Drawing.Point(289, 310)
        Me.lblMontoLetras.Name = "lblMontoLetras"
        Me.lblMontoLetras.Size = New System.Drawing.Size(0, 24)
        Me.lblMontoLetras.TabIndex = 15
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.BackColor = System.Drawing.Color.White
        Me.lblConcepto.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(248, 369)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(217, 24)
        Me.lblConcepto.TabIndex = 16
        Me.lblConcepto.Text = "realizacion de mudanza."
        '
        'lnklbl
        '
        Me.lnklbl.AutoSize = True
        Me.lnklbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl.LinkColor = System.Drawing.Color.Black
        Me.lnklbl.Location = New System.Drawing.Point(712, 808)
        Me.lnklbl.Name = "lnklbl"
        Me.lnklbl.Size = New System.Drawing.Size(72, 29)
        Me.lnklbl.TabIndex = 18
        Me.lnklbl.TabStop = True
        Me.lnklbl.Text = "Atrás"
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.BackColor = System.Drawing.Color.Salmon
        Me.btnVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolverInicio.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverInicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVolverInicio.Location = New System.Drawing.Point(479, 522)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(287, 39)
        Me.btnVolverInicio.TabIndex = 22
        Me.btnVolverInicio.Text = "VOLVER AL INICIO"
        Me.btnVolverInicio.UseVisualStyleBackColor = False
        '
        'btnImprimir1
        '
        Me.btnImprimir1.BackColor = System.Drawing.Color.Salmon
        Me.btnImprimir1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir1.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimir1.Location = New System.Drawing.Point(99, 522)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(287, 39)
        Me.btnImprimir1.TabIndex = 21
        Me.btnImprimir1.Text = "IMPRIMIR"
        Me.btnImprimir1.UseVisualStyleBackColor = False
        '
        'lblDniCliente
        '
        Me.lblDniCliente.AutoSize = True
        Me.lblDniCliente.BackColor = System.Drawing.Color.White
        Me.lblDniCliente.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniCliente.Location = New System.Drawing.Point(96, 219)
        Me.lblDniCliente.Name = "lblDniCliente"
        Me.lblDniCliente.Size = New System.Drawing.Size(80, 24)
        Me.lblDniCliente.TabIndex = 24
        Me.lblDniCliente.Text = "DNI Nº: "
        '
        'lblDiaRecibo
        '
        Me.lblDiaRecibo.AutoSize = True
        Me.lblDiaRecibo.BackColor = System.Drawing.Color.White
        Me.lblDiaRecibo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaRecibo.Location = New System.Drawing.Point(300, 153)
        Me.lblDiaRecibo.Name = "lblDiaRecibo"
        Me.lblDiaRecibo.Size = New System.Drawing.Size(0, 17)
        Me.lblDiaRecibo.TabIndex = 25
        '
        'lblMesRecibo
        '
        Me.lblMesRecibo.AutoSize = True
        Me.lblMesRecibo.BackColor = System.Drawing.Color.White
        Me.lblMesRecibo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesRecibo.Location = New System.Drawing.Point(440, 152)
        Me.lblMesRecibo.Name = "lblMesRecibo"
        Me.lblMesRecibo.Size = New System.Drawing.Size(0, 17)
        Me.lblMesRecibo.TabIndex = 26
        '
        'lblAnioRecibo
        '
        Me.lblAnioRecibo.AutoSize = True
        Me.lblAnioRecibo.BackColor = System.Drawing.Color.White
        Me.lblAnioRecibo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnioRecibo.Location = New System.Drawing.Point(580, 151)
        Me.lblAnioRecibo.Name = "lblAnioRecibo"
        Me.lblAnioRecibo.Size = New System.Drawing.Size(0, 17)
        Me.lblAnioRecibo.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MudanzasFiumba.My.Resources.Resources.reciboMudanza
        Me.PictureBox1.Location = New System.Drawing.Point(66, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(742, 452)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(854, 579)
        Me.Controls.Add(Me.lblAnioRecibo)
        Me.Controls.Add(Me.lblMesRecibo)
        Me.Controls.Add(Me.lblDiaRecibo)
        Me.Controls.Add(Me.lblDniCliente)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.lnklbl)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.lblMontoLetras)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblClienteNom)
        Me.Controls.Add(Me.lblDireccionEmpresa)
        Me.Controls.Add(Me.lblNroRecibo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRecibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblNroRecibo As System.Windows.Forms.Label
    Friend WithEvents lblDireccionEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblClienteNom As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMontoLetras As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lnklbl As System.Windows.Forms.LinkLabel
    Friend WithEvents btnVolverInicio As System.Windows.Forms.Button
    Friend WithEvents btnImprimir1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDniCliente As System.Windows.Forms.Label
    Friend WithEvents lblDiaRecibo As System.Windows.Forms.Label
    Friend WithEvents lblMesRecibo As System.Windows.Forms.Label
    Friend WithEvents lblAnioRecibo As System.Windows.Forms.Label
End Class
