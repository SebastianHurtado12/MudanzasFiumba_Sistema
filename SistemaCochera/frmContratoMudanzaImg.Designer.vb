<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratoMudanzaImg
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
        Me.lblClienteNombre = New System.Windows.Forms.Label()
        Me.lblDniNumero = New System.Windows.Forms.Label()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.lblMontoContrato = New System.Windows.Forms.Label()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.pbContratoMudanza = New System.Windows.Forms.PictureBox()
        CType(Me.pbContratoMudanza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClienteNombre
        '
        Me.lblClienteNombre.AutoSize = True
        Me.lblClienteNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.lblClienteNombre.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteNombre.Location = New System.Drawing.Point(202, 194)
        Me.lblClienteNombre.Name = "lblClienteNombre"
        Me.lblClienteNombre.Size = New System.Drawing.Size(0, 19)
        Me.lblClienteNombre.TabIndex = 1
        '
        'lblDniNumero
        '
        Me.lblDniNumero.AutoSize = True
        Me.lblDniNumero.BackColor = System.Drawing.Color.GhostWhite
        Me.lblDniNumero.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniNumero.Location = New System.Drawing.Point(468, 194)
        Me.lblDniNumero.Name = "lblDniNumero"
        Me.lblDniNumero.Size = New System.Drawing.Size(0, 19)
        Me.lblDniNumero.TabIndex = 2
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.BackColor = System.Drawing.Color.GhostWhite
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(364, 219)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(0, 19)
        Me.lblDireccionCliente.TabIndex = 3
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.BackColor = System.Drawing.Color.GhostWhite
        Me.lblEmailCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(109, 240)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(0, 19)
        Me.lblEmailCliente.TabIndex = 4
        '
        'lblMontoContrato
        '
        Me.lblMontoContrato.AutoSize = True
        Me.lblMontoContrato.BackColor = System.Drawing.Color.GhostWhite
        Me.lblMontoContrato.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoContrato.Location = New System.Drawing.Point(104, 401)
        Me.lblMontoContrato.Name = "lblMontoContrato"
        Me.lblMontoContrato.Size = New System.Drawing.Size(0, 19)
        Me.lblMontoContrato.TabIndex = 5
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.BackColor = System.Drawing.Color.GhostWhite
        Me.lblFechaActual.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.Location = New System.Drawing.Point(69, 72)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(48, 19)
        Me.lblFechaActual.TabIndex = 6
        Me.lblFechaActual.Text = "FECHA: "
        '
        'btnRecibo
        '
        Me.btnRecibo.BackColor = System.Drawing.Color.Salmon
        Me.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecibo.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRecibo.Location = New System.Drawing.Point(414, 465)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(287, 39)
        Me.btnRecibo.TabIndex = 22
        Me.btnRecibo.Text = "Recibo"
        Me.btnRecibo.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Salmon
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Location = New System.Drawing.Point(37, 465)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(287, 39)
        Me.btnImprimir.TabIndex = 21
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'pbContratoMudanza
        '
        Me.pbContratoMudanza.Image = Global.MudanzasFiumba.My.Resources.Resources.ContratoFiumba
        Me.pbContratoMudanza.Location = New System.Drawing.Point(55, 51)
        Me.pbContratoMudanza.Name = "pbContratoMudanza"
        Me.pbContratoMudanza.Size = New System.Drawing.Size(618, 394)
        Me.pbContratoMudanza.TabIndex = 0
        Me.pbContratoMudanza.TabStop = False
        '
        'frmContratoMudanzaImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(743, 521)
        Me.Controls.Add(Me.btnRecibo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.lblMontoContrato)
        Me.Controls.Add(Me.lblEmailCliente)
        Me.Controls.Add(Me.lblDireccionCliente)
        Me.Controls.Add(Me.lblDniNumero)
        Me.Controls.Add(Me.lblClienteNombre)
        Me.Controls.Add(Me.pbContratoMudanza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContratoMudanzaImg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato Mudanza"
        CType(Me.pbContratoMudanza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbContratoMudanza As System.Windows.Forms.PictureBox
    Friend WithEvents lblClienteNombre As System.Windows.Forms.Label
    Friend WithEvents lblDniNumero As System.Windows.Forms.Label
    Friend WithEvents lblDireccionCliente As System.Windows.Forms.Label
    Friend WithEvents lblEmailCliente As System.Windows.Forms.Label
    Friend WithEvents lblMontoContrato As System.Windows.Forms.Label
    Friend WithEvents lblFechaActual As System.Windows.Forms.Label
    Friend WithEvents btnRecibo As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
