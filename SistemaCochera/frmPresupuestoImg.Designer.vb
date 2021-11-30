<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestoImg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuestoImg))
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.lblDireEmpresa = New System.Windows.Forms.Label()
        Me.lblTelEmpresa = New System.Windows.Forms.Label()
        Me.lblEmailEmpresa = New System.Windows.Forms.Label()
        Me.lblTitPresupuesto = New System.Windows.Forms.Label()
        Me.lblNomCliente = New System.Windows.Forms.Label()
        Me.lblDireCliente = New System.Windows.Forms.Label()
        Me.lblTelCliente = New System.Windows.Forms.Label()
        Me.lblTotalCamion = New System.Windows.Forms.Label()
        Me.lblCamionPrecioPresup = New System.Windows.Forms.Label()
        Me.lblCantObjPresup = New System.Windows.Forms.Label()
        Me.lblCantKmPresup = New System.Windows.Forms.Label()
        Me.lblTotalPresup = New System.Windows.Forms.Label()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.lblPrecioTotalPresup = New System.Windows.Forms.Label()
        Me.lblNumPresup = New System.Windows.Forms.Label()
        Me.lblFechaVencimientoPresup = New System.Windows.Forms.Label()
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.pbPresupuesto = New System.Windows.Forms.PictureBox()
        CType(Me.pbPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.BackColor = System.Drawing.Color.White
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.Location = New System.Drawing.Point(121, 180)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(108, 13)
        Me.lblNomEmpresa.TabIndex = 1
        Me.lblNomEmpresa.Text = "Mudanzas Fiumba"
        '
        'lblDireEmpresa
        '
        Me.lblDireEmpresa.AutoSize = True
        Me.lblDireEmpresa.BackColor = System.Drawing.Color.White
        Me.lblDireEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireEmpresa.Location = New System.Drawing.Point(123, 196)
        Me.lblDireEmpresa.Name = "lblDireEmpresa"
        Me.lblDireEmpresa.Size = New System.Drawing.Size(183, 13)
        Me.lblDireEmpresa.TabIndex = 2
        Me.lblDireEmpresa.Text = "Av.Lope de Vega 233, CumCity"
        '
        'lblTelEmpresa
        '
        Me.lblTelEmpresa.AutoSize = True
        Me.lblTelEmpresa.BackColor = System.Drawing.Color.White
        Me.lblTelEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelEmpresa.Location = New System.Drawing.Point(123, 212)
        Me.lblTelEmpresa.Name = "lblTelEmpresa"
        Me.lblTelEmpresa.Size = New System.Drawing.Size(85, 13)
        Me.lblTelEmpresa.TabIndex = 3
        Me.lblTelEmpresa.Text = "11-3354-7576"
        '
        'lblEmailEmpresa
        '
        Me.lblEmailEmpresa.AutoSize = True
        Me.lblEmailEmpresa.BackColor = System.Drawing.Color.White
        Me.lblEmailEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailEmpresa.Location = New System.Drawing.Point(109, 226)
        Me.lblEmailEmpresa.Name = "lblEmailEmpresa"
        Me.lblEmailEmpresa.Size = New System.Drawing.Size(176, 13)
        Me.lblEmailEmpresa.TabIndex = 4
        Me.lblEmailEmpresa.Text = "mudanzasFiumba@yahoo.com"
        '
        'lblTitPresupuesto
        '
        Me.lblTitPresupuesto.AutoSize = True
        Me.lblTitPresupuesto.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPresupuesto.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitPresupuesto.Location = New System.Drawing.Point(248, 5)
        Me.lblTitPresupuesto.Name = "lblTitPresupuesto"
        Me.lblTitPresupuesto.Size = New System.Drawing.Size(200, 29)
        Me.lblTitPresupuesto.TabIndex = 5
        Me.lblTitPresupuesto.Text = "PRESUPUESTO MUDANZA"
        '
        'lblNomCliente
        '
        Me.lblNomCliente.AutoSize = True
        Me.lblNomCliente.BackColor = System.Drawing.Color.White
        Me.lblNomCliente.Location = New System.Drawing.Point(418, 180)
        Me.lblNomCliente.Name = "lblNomCliente"
        Me.lblNomCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblNomCliente.TabIndex = 6
        '
        'lblDireCliente
        '
        Me.lblDireCliente.AutoSize = True
        Me.lblDireCliente.BackColor = System.Drawing.Color.White
        Me.lblDireCliente.Location = New System.Drawing.Point(420, 197)
        Me.lblDireCliente.Name = "lblDireCliente"
        Me.lblDireCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblDireCliente.TabIndex = 7
        '
        'lblTelCliente
        '
        Me.lblTelCliente.AutoSize = True
        Me.lblTelCliente.BackColor = System.Drawing.SystemColors.Window
        Me.lblTelCliente.Location = New System.Drawing.Point(421, 212)
        Me.lblTelCliente.Name = "lblTelCliente"
        Me.lblTelCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblTelCliente.TabIndex = 8
        '
        'lblTotalCamion
        '
        Me.lblTotalCamion.AutoSize = True
        Me.lblTotalCamion.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCamion.Location = New System.Drawing.Point(580, 362)
        Me.lblTotalCamion.Name = "lblTotalCamion"
        Me.lblTotalCamion.Size = New System.Drawing.Size(16, 16)
        Me.lblTotalCamion.TabIndex = 10
        Me.lblTotalCamion.Text = "1"
        '
        'lblCamionPrecioPresup
        '
        Me.lblCamionPrecioPresup.AutoSize = True
        Me.lblCamionPrecioPresup.BackColor = System.Drawing.SystemColors.Window
        Me.lblCamionPrecioPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamionPrecioPresup.Location = New System.Drawing.Point(494, 362)
        Me.lblCamionPrecioPresup.Name = "lblCamionPrecioPresup"
        Me.lblCamionPrecioPresup.Size = New System.Drawing.Size(0, 16)
        Me.lblCamionPrecioPresup.TabIndex = 11
        '
        'lblCantObjPresup
        '
        Me.lblCantObjPresup.AutoSize = True
        Me.lblCantObjPresup.BackColor = System.Drawing.SystemColors.Window
        Me.lblCantObjPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantObjPresup.Location = New System.Drawing.Point(555, 339)
        Me.lblCantObjPresup.Name = "lblCantObjPresup"
        Me.lblCantObjPresup.Size = New System.Drawing.Size(0, 16)
        Me.lblCantObjPresup.TabIndex = 12
        '
        'lblCantKmPresup
        '
        Me.lblCantKmPresup.AutoSize = True
        Me.lblCantKmPresup.BackColor = System.Drawing.SystemColors.Window
        Me.lblCantKmPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantKmPresup.Location = New System.Drawing.Point(555, 318)
        Me.lblCantKmPresup.Name = "lblCantKmPresup"
        Me.lblCantKmPresup.Size = New System.Drawing.Size(0, 16)
        Me.lblCantKmPresup.TabIndex = 13
        '
        'lblTotalPresup
        '
        Me.lblTotalPresup.AutoSize = True
        Me.lblTotalPresup.BackColor = System.Drawing.Color.DarkGray
        Me.lblTotalPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPresup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalPresup.Location = New System.Drawing.Point(554, 508)
        Me.lblTotalPresup.Name = "lblTotalPresup"
        Me.lblTotalPresup.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalPresup.TabIndex = 14
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.BackColor = System.Drawing.SystemColors.Window
        Me.lblFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.Location = New System.Drawing.Point(539, 89)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(0, 16)
        Me.lblFechaActual.TabIndex = 15
        '
        'lblPrecioTotalPresup
        '
        Me.lblPrecioTotalPresup.AutoSize = True
        Me.lblPrecioTotalPresup.BackColor = System.Drawing.SystemColors.Window
        Me.lblPrecioTotalPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotalPresup.Location = New System.Drawing.Point(539, 105)
        Me.lblPrecioTotalPresup.Name = "lblPrecioTotalPresup"
        Me.lblPrecioTotalPresup.Size = New System.Drawing.Size(0, 16)
        Me.lblPrecioTotalPresup.TabIndex = 16
        '
        'lblNumPresup
        '
        Me.lblNumPresup.AutoSize = True
        Me.lblNumPresup.BackColor = System.Drawing.SystemColors.Window
        Me.lblNumPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPresup.Location = New System.Drawing.Point(539, 121)
        Me.lblNumPresup.Name = "lblNumPresup"
        Me.lblNumPresup.Size = New System.Drawing.Size(0, 16)
        Me.lblNumPresup.TabIndex = 17
        '
        'lblFechaVencimientoPresup
        '
        Me.lblFechaVencimientoPresup.AutoSize = True
        Me.lblFechaVencimientoPresup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFechaVencimientoPresup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVencimientoPresup.Location = New System.Drawing.Point(93, 540)
        Me.lblFechaVencimientoPresup.Name = "lblFechaVencimientoPresup"
        Me.lblFechaVencimientoPresup.Size = New System.Drawing.Size(306, 18)
        Me.lblFechaVencimientoPresup.TabIndex = 18
        Me.lblFechaVencimientoPresup.Text = "Fecha de Vencimiento del Presupuesto:"
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.BackColor = System.Drawing.Color.Salmon
        Me.btnVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolverInicio.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverInicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVolverInicio.Location = New System.Drawing.Point(398, 587)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(287, 39)
        Me.btnVolverInicio.TabIndex = 20
        Me.btnVolverInicio.Text = "VOLVER AL INICIO"
        Me.btnVolverInicio.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Salmon
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.Location = New System.Drawing.Point(21, 587)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(287, 39)
        Me.btnImprimir.TabIndex = 19
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'pbPresupuesto
        '
        Me.pbPresupuesto.BackColor = System.Drawing.Color.GhostWhite
        Me.pbPresupuesto.Image = CType(resources.GetObject("pbPresupuesto.Image"), System.Drawing.Image)
        Me.pbPresupuesto.Location = New System.Drawing.Point(64, 41)
        Me.pbPresupuesto.Name = "pbPresupuesto"
        Me.pbPresupuesto.Size = New System.Drawing.Size(570, 528)
        Me.pbPresupuesto.TabIndex = 0
        Me.pbPresupuesto.TabStop = False
        '
        'frmPresupuestoImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(709, 652)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblFechaVencimientoPresup)
        Me.Controls.Add(Me.lblNumPresup)
        Me.Controls.Add(Me.lblPrecioTotalPresup)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.lblTotalPresup)
        Me.Controls.Add(Me.lblCantKmPresup)
        Me.Controls.Add(Me.lblCantObjPresup)
        Me.Controls.Add(Me.lblCamionPrecioPresup)
        Me.Controls.Add(Me.lblTotalCamion)
        Me.Controls.Add(Me.lblTelCliente)
        Me.Controls.Add(Me.lblDireCliente)
        Me.Controls.Add(Me.lblNomCliente)
        Me.Controls.Add(Me.lblTitPresupuesto)
        Me.Controls.Add(Me.lblEmailEmpresa)
        Me.Controls.Add(Me.lblTelEmpresa)
        Me.Controls.Add(Me.lblDireEmpresa)
        Me.Controls.Add(Me.lblNomEmpresa)
        Me.Controls.Add(Me.pbPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPresupuestoImg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        CType(Me.pbPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbPresupuesto As System.Windows.Forms.PictureBox
    Friend WithEvents lblNomEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblDireEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblTelEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblEmailEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblTitPresupuesto As System.Windows.Forms.Label
    Friend WithEvents lblNomCliente As System.Windows.Forms.Label
    Friend WithEvents lblDireCliente As System.Windows.Forms.Label
    Friend WithEvents lblTelCliente As System.Windows.Forms.Label
    Friend WithEvents lblTotalCamion As System.Windows.Forms.Label
    Friend WithEvents lblCamionPrecioPresup As System.Windows.Forms.Label
    Friend WithEvents lblCantObjPresup As System.Windows.Forms.Label
    Friend WithEvents lblCantKmPresup As System.Windows.Forms.Label
    Friend WithEvents lblTotalPresup As System.Windows.Forms.Label
    Friend WithEvents lblFechaActual As System.Windows.Forms.Label
    Friend WithEvents lblPrecioTotalPresup As System.Windows.Forms.Label
    Friend WithEvents lblNumPresup As System.Windows.Forms.Label
    Friend WithEvents lblFechaVencimientoPresup As System.Windows.Forms.Label
    Friend WithEvents btnVolverInicio As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
