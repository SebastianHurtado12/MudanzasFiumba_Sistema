<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.btnOtrasOpciones = New System.Windows.Forms.Button()
        Me.btnVerListado = New System.Windows.Forms.Button()
        Me.btnRealizarPago = New System.Windows.Forms.Button()
        Me.btnCrearPedido = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOtrasOpciones
        '
        Me.btnOtrasOpciones.BackColor = System.Drawing.Color.Salmon
        Me.btnOtrasOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOtrasOpciones.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtrasOpciones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOtrasOpciones.Location = New System.Drawing.Point(89, 466)
        Me.btnOtrasOpciones.Name = "btnOtrasOpciones"
        Me.btnOtrasOpciones.Size = New System.Drawing.Size(333, 60)
        Me.btnOtrasOpciones.TabIndex = 12
        Me.btnOtrasOpciones.Text = "OTRAS OPCIONES"
        Me.btnOtrasOpciones.UseVisualStyleBackColor = False
        '
        'btnVerListado
        '
        Me.btnVerListado.BackColor = System.Drawing.Color.Salmon
        Me.btnVerListado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerListado.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerListado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVerListado.Location = New System.Drawing.Point(89, 274)
        Me.btnVerListado.Name = "btnVerListado"
        Me.btnVerListado.Size = New System.Drawing.Size(333, 58)
        Me.btnVerListado.TabIndex = 11
        Me.btnVerListado.Text = "ALQUILAR ALMACEN"
        Me.btnVerListado.UseVisualStyleBackColor = False
        '
        'btnRealizarPago
        '
        Me.btnRealizarPago.BackColor = System.Drawing.Color.Salmon
        Me.btnRealizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRealizarPago.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarPago.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRealizarPago.Location = New System.Drawing.Point(89, 180)
        Me.btnRealizarPago.Name = "btnRealizarPago"
        Me.btnRealizarPago.Size = New System.Drawing.Size(333, 56)
        Me.btnRealizarPago.TabIndex = 10
        Me.btnRealizarPago.Text = "PAGAR CONTRATO"
        Me.btnRealizarPago.UseVisualStyleBackColor = False
        '
        'btnCrearPedido
        '
        Me.btnCrearPedido.BackColor = System.Drawing.Color.Salmon
        Me.btnCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearPedido.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCrearPedido.Location = New System.Drawing.Point(89, 82)
        Me.btnCrearPedido.Name = "btnCrearPedido"
        Me.btnCrearPedido.Size = New System.Drawing.Size(333, 61)
        Me.btnCrearPedido.TabIndex = 9
        Me.btnCrearPedido.Text = "REALIZAR PRESUPUESTO"
        Me.btnCrearPedido.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(89, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(333, 56)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "FINALIZAR MUDANZA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(217, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 35)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "INICIO"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(513, 574)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOtrasOpciones)
        Me.Controls.Add(Me.btnVerListado)
        Me.Controls.Add(Me.btnRealizarPago)
        Me.Controls.Add(Me.btnCrearPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOtrasOpciones As System.Windows.Forms.Button
    Friend WithEvents btnVerListado As System.Windows.Forms.Button
    Friend WithEvents btnRealizarPago As System.Windows.Forms.Button
    Friend WithEvents btnCrearPedido As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
