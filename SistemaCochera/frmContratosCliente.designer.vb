<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratosCliente
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnSigPaso = New System.Windows.Forms.Button()
        Me.lsvAlmacenes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCocherasLibres = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Cornsilk
        Me.LinkLabel1.Location = New System.Drawing.Point(369, 438)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 38)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Atras"
        '
        'btnSigPaso
        '
        Me.btnSigPaso.BackColor = System.Drawing.Color.Salmon
        Me.btnSigPaso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigPaso.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigPaso.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSigPaso.Location = New System.Drawing.Point(147, 413)
        Me.btnSigPaso.Name = "btnSigPaso"
        Me.btnSigPaso.Size = New System.Drawing.Size(160, 50)
        Me.btnSigPaso.TabIndex = 26
        Me.btnSigPaso.Text = "Siguiente Paso"
        Me.btnSigPaso.UseVisualStyleBackColor = False
        '
        'lsvAlmacenes
        '
        Me.lsvAlmacenes.BackColor = System.Drawing.Color.Snow
        Me.lsvAlmacenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvAlmacenes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lsvAlmacenes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lsvAlmacenes.FullRowSelect = True
        Me.lsvAlmacenes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvAlmacenes.Location = New System.Drawing.Point(33, 128)
        Me.lsvAlmacenes.MultiSelect = False
        Me.lsvAlmacenes.Name = "lsvAlmacenes"
        Me.lsvAlmacenes.Size = New System.Drawing.Size(402, 270)
        Me.lsvAlmacenes.TabIndex = 25
        Me.lsvAlmacenes.UseCompatibleStateImageBehavior = False
        Me.lsvAlmacenes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Contrato"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha"
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Monto"
        Me.ColumnHeader4.Width = 181
        '
        'lblCocherasLibres
        '
        Me.lblCocherasLibres.AutoSize = True
        Me.lblCocherasLibres.BackColor = System.Drawing.Color.Transparent
        Me.lblCocherasLibres.Font = New System.Drawing.Font("Bahnschrift Condensed", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCocherasLibres.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblCocherasLibres.Location = New System.Drawing.Point(28, 97)
        Me.lblCocherasLibres.Name = "lblCocherasLibres"
        Me.lblCocherasLibres.Size = New System.Drawing.Size(174, 28)
        Me.lblCocherasLibres.TabIndex = 24
        Me.lblCocherasLibres.Text = "Contratos Del Cliente"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblDatos.Location = New System.Drawing.Point(141, 27)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(197, 35)
        Me.lblDatos.TabIndex = 23
        Me.lblDatos.Text = "ALQUILER ALMACEN"
        '
        'frmContratosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(467, 482)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnSigPaso)
        Me.Controls.Add(Me.lsvAlmacenes)
        Me.Controls.Add(Me.lblCocherasLibres)
        Me.Controls.Add(Me.lblDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContratosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSigPaso As System.Windows.Forms.Button
    Friend WithEvents lsvAlmacenes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCocherasLibres As System.Windows.Forms.Label
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
