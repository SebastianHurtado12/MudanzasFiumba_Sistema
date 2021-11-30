<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciboAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboAlmacen))
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRecibo = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblanio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblMontoEscrito = New System.Windows.Forms.Label()
        Me.lblRazon = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.BackColor = System.Drawing.Color.Salmon
        Me.btnVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolverInicio.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolverInicio.Location = New System.Drawing.Point(443, 507)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(287, 38)
        Me.btnVolverInicio.TabIndex = 15
        Me.btnVolverInicio.Text = "Volver Al Inicio"
        Me.btnVolverInicio.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Salmon
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Location = New System.Drawing.Point(23, 507)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(287, 38)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblTitulo.Location = New System.Drawing.Point(231, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(300, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "* CONTRATO DE ARRENDAMIENTO DE COCHERA *"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 441)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lblRecibo
        '
        Me.lblRecibo.AutoSize = True
        Me.lblRecibo.BackColor = System.Drawing.Color.White
        Me.lblRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibo.Location = New System.Drawing.Point(629, 74)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Size = New System.Drawing.Size(49, 16)
        Me.lblRecibo.TabIndex = 17
        Me.lblRecibo.Text = "Label1"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.BackColor = System.Drawing.Color.White
        Me.lblLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(64, 140)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(49, 16)
        Me.lblLugar.TabIndex = 18
        Me.lblLugar.Text = "Label1"
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.BackColor = System.Drawing.Color.White
        Me.lblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.Location = New System.Drawing.Point(232, 140)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(49, 16)
        Me.lblDia.TabIndex = 19
        Me.lblDia.Text = "Label1"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.BackColor = System.Drawing.Color.White
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(328, 140)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(49, 16)
        Me.lblMes.TabIndex = 20
        Me.lblMes.Text = "Label1"
        '
        'lblanio
        '
        Me.lblanio.AutoSize = True
        Me.lblanio.BackColor = System.Drawing.Color.White
        Me.lblanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanio.Location = New System.Drawing.Point(509, 140)
        Me.lblanio.Name = "lblanio"
        Me.lblanio.Size = New System.Drawing.Size(49, 16)
        Me.lblanio.TabIndex = 21
        Me.lblanio.Text = "Label1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(127, 182)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(49, 16)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Label1"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.White
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(549, 210)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(49, 16)
        Me.lblMonto.TabIndex = 23
        Me.lblMonto.Text = "Label1"
        '
        'lblMontoEscrito
        '
        Me.lblMontoEscrito.AutoSize = True
        Me.lblMontoEscrito.BackColor = System.Drawing.Color.LightGray
        Me.lblMontoEscrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoEscrito.Location = New System.Drawing.Point(52, 291)
        Me.lblMontoEscrito.Name = "lblMontoEscrito"
        Me.lblMontoEscrito.Size = New System.Drawing.Size(49, 16)
        Me.lblMontoEscrito.TabIndex = 24
        Me.lblMontoEscrito.Text = "Label1"
        '
        'lblRazon
        '
        Me.lblRazon.AutoSize = True
        Me.lblRazon.BackColor = System.Drawing.Color.White
        Me.lblRazon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazon.Location = New System.Drawing.Point(196, 356)
        Me.lblRazon.Name = "lblRazon"
        Me.lblRazon.Size = New System.Drawing.Size(49, 16)
        Me.lblRazon.TabIndex = 25
        Me.lblRazon.Text = "Label1"
        '
        'frmReciboAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(765, 567)
        Me.Controls.Add(Me.lblRazon)
        Me.Controls.Add(Me.lblMontoEscrito)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblanio)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.lblDia)
        Me.Controls.Add(Me.lblLugar)
        Me.Controls.Add(Me.lblRecibo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReciboAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo almacen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolverInicio As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRecibo As System.Windows.Forms.Label
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents lblanio As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMontoEscrito As System.Windows.Forms.Label
    Friend WithEvents lblRazon As System.Windows.Forms.Label
End Class
