<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElegirPresupContrato
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
        Me.lsvPresupDisponibles = New System.Windows.Forms.ListView()
        Me.Npresup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DniCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MontoPresup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DireccionCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaEmisionPresup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaVencimientoPresup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCocherasLibres = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.btnComprobarModificar = New System.Windows.Forms.Button()
        Me.llAtras = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lsvPresupDisponibles
        '
        Me.lsvPresupDisponibles.BackColor = System.Drawing.Color.MintCream
        Me.lsvPresupDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvPresupDisponibles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Npresup, Me.DniCliente, Me.NombreCliente, Me.MontoPresup, Me.DireccionCliente, Me.FechaEmisionPresup, Me.FechaVencimientoPresup})
        Me.lsvPresupDisponibles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lsvPresupDisponibles.FullRowSelect = True
        Me.lsvPresupDisponibles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvPresupDisponibles.Location = New System.Drawing.Point(26, 121)
        Me.lsvPresupDisponibles.MultiSelect = False
        Me.lsvPresupDisponibles.Name = "lsvPresupDisponibles"
        Me.lsvPresupDisponibles.Size = New System.Drawing.Size(729, 270)
        Me.lsvPresupDisponibles.TabIndex = 12
        Me.lsvPresupDisponibles.UseCompatibleStateImageBehavior = False
        Me.lsvPresupDisponibles.View = System.Windows.Forms.View.Details
        '
        'Npresup
        '
        Me.Npresup.Text = "NºPresupuesto"
        Me.Npresup.Width = 85
        '
        'DniCliente
        '
        Me.DniCliente.Text = "Dni Cliente"
        Me.DniCliente.Width = 91
        '
        'NombreCliente
        '
        Me.NombreCliente.Text = "Nombre Cliente"
        Me.NombreCliente.Width = 144
        '
        'MontoPresup
        '
        Me.MontoPresup.Text = "Monto"
        Me.MontoPresup.Width = 81
        '
        'DireccionCliente
        '
        Me.DireccionCliente.Text = "Direccion"
        Me.DireccionCliente.Width = 139
        '
        'FechaEmisionPresup
        '
        Me.FechaEmisionPresup.Text = "Fecha Emision"
        Me.FechaEmisionPresup.Width = 84
        '
        'FechaVencimientoPresup
        '
        Me.FechaVencimientoPresup.Text = "Fecha Vencimiento"
        Me.FechaVencimientoPresup.Width = 105
        '
        'lblCocherasLibres
        '
        Me.lblCocherasLibres.AutoSize = True
        Me.lblCocherasLibres.BackColor = System.Drawing.Color.Transparent
        Me.lblCocherasLibres.Font = New System.Drawing.Font("Bahnschrift Condensed", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCocherasLibres.ForeColor = System.Drawing.Color.White
        Me.lblCocherasLibres.Location = New System.Drawing.Point(21, 78)
        Me.lblCocherasLibres.Name = "lblCocherasLibres"
        Me.lblCocherasLibres.Size = New System.Drawing.Size(215, 28)
        Me.lblCocherasLibres.TabIndex = 14
        Me.lblCocherasLibres.Text = "Seleccione su Presupuesto"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblDatos.Location = New System.Drawing.Point(296, 21)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(160, 35)
        Me.lblDatos.TabIndex = 13
        Me.lblDatos.Text = "PRESUPUESTOS"
        '
        'btnComprobarModificar
        '
        Me.btnComprobarModificar.BackColor = System.Drawing.Color.Salmon
        Me.btnComprobarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprobarModificar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobarModificar.ForeColor = System.Drawing.Color.White
        Me.btnComprobarModificar.Location = New System.Drawing.Point(268, 401)
        Me.btnComprobarModificar.Name = "btnComprobarModificar"
        Me.btnComprobarModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnComprobarModificar.Size = New System.Drawing.Size(241, 61)
        Me.btnComprobarModificar.TabIndex = 43
        Me.btnComprobarModificar.Text = "&SIGUIENTE"
        Me.btnComprobarModificar.UseVisualStyleBackColor = False
        '
        'llAtras
        '
        Me.llAtras.AutoSize = True
        Me.llAtras.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAtras.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.llAtras.LinkColor = System.Drawing.Color.Cornsilk
        Me.llAtras.Location = New System.Drawing.Point(666, 430)
        Me.llAtras.Name = "llAtras"
        Me.llAtras.Size = New System.Drawing.Size(57, 32)
        Me.llAtras.TabIndex = 57
        Me.llAtras.TabStop = True
        Me.llAtras.Text = "Atras"
        '
        'frmElegirPresupContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(767, 474)
        Me.Controls.Add(Me.llAtras)
        Me.Controls.Add(Me.btnComprobarModificar)
        Me.Controls.Add(Me.lblCocherasLibres)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.lsvPresupDisponibles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmElegirPresupContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion del Presupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvPresupDisponibles As System.Windows.Forms.ListView
    Friend WithEvents Npresup As System.Windows.Forms.ColumnHeader
    Friend WithEvents DniCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents NombreCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCocherasLibres As System.Windows.Forms.Label
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents MontoPresup As System.Windows.Forms.ColumnHeader
    Friend WithEvents DireccionCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaEmisionPresup As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaVencimientoPresup As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnComprobarModificar As System.Windows.Forms.Button
    Friend WithEvents llAtras As System.Windows.Forms.LinkLabel
End Class
