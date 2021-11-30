<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalizarMudanza
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
        Me.lsvMudanzas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.LinkLabel1.Location = New System.Drawing.Point(605, 475)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 38)
        Me.LinkLabel1.TabIndex = 37
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Atras"
        '
        'btnSigPaso
        '
        Me.btnSigPaso.BackColor = System.Drawing.Color.Salmon
        Me.btnSigPaso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigPaso.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigPaso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSigPaso.Location = New System.Drawing.Point(243, 449)
        Me.btnSigPaso.Name = "btnSigPaso"
        Me.btnSigPaso.Size = New System.Drawing.Size(201, 50)
        Me.btnSigPaso.TabIndex = 36
        Me.btnSigPaso.Text = "Completar Mudanza"
        Me.btnSigPaso.UseVisualStyleBackColor = False
        '
        'lsvMudanzas
        '
        Me.lsvMudanzas.BackColor = System.Drawing.Color.Snow
        Me.lsvMudanzas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvMudanzas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvMudanzas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lsvMudanzas.FullRowSelect = True
        Me.lsvMudanzas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvMudanzas.Location = New System.Drawing.Point(12, 108)
        Me.lsvMudanzas.MultiSelect = False
        Me.lsvMudanzas.Name = "lsvMudanzas"
        Me.lsvMudanzas.Size = New System.Drawing.Size(658, 321)
        Me.lsvMudanzas.TabIndex = 35
        Me.lsvMudanzas.UseCompatibleStateImageBehavior = False
        Me.lsvMudanzas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Contrato"
        Me.ColumnHeader1.Width = 68
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Presupuesto"
        Me.ColumnHeader2.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cliente"
        Me.ColumnHeader4.Width = 81
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FechaMudanza"
        Me.ColumnHeader3.Width = 183
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "FechaEmision"
        Me.ColumnHeader5.Width = 173
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fin"
        '
        'lblCocherasLibres
        '
        Me.lblCocherasLibres.AutoSize = True
        Me.lblCocherasLibres.BackColor = System.Drawing.Color.Transparent
        Me.lblCocherasLibres.Font = New System.Drawing.Font("Bahnschrift Condensed", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCocherasLibres.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblCocherasLibres.Location = New System.Drawing.Point(12, 72)
        Me.lblCocherasLibres.Name = "lblCocherasLibres"
        Me.lblCocherasLibres.Size = New System.Drawing.Size(169, 28)
        Me.lblCocherasLibres.TabIndex = 34
        Me.lblCocherasLibres.Text = "Mudanzas A Realizar"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblDatos.Location = New System.Drawing.Point(236, 9)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(225, 42)
        Me.lblDatos.TabIndex = 33
        Me.lblDatos.Text = "Mudanzas Fiumba"
        '
        'frmFinalizarMudanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(682, 511)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnSigPaso)
        Me.Controls.Add(Me.lsvMudanzas)
        Me.Controls.Add(Me.lblCocherasLibres)
        Me.Controls.Add(Me.lblDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFinalizarMudanza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalizar Mudanza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSigPaso As System.Windows.Forms.Button
    Friend WithEvents lsvMudanzas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCocherasLibres As System.Windows.Forms.Label
    Friend WithEvents lblDatos As System.Windows.Forms.Label
End Class
