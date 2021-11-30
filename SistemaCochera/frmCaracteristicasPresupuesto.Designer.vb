<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaracteristicasPresupuesto
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
        Me.btnSiguientePasoPresup = New System.Windows.Forms.Button()
        Me.lblModificarCliente = New System.Windows.Forms.Label()
        Me.nudObjChicos = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudObjMedianos = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudObjGrandes = New System.Windows.Forms.NumericUpDown()
        Me.btnRecomendarCamion = New System.Windows.Forms.Button()
        Me.rbtCamionGrande = New System.Windows.Forms.RadioButton()
        Me.rbtCamionChico = New System.Windows.Forms.RadioButton()
        Me.rbtCamionMediano = New System.Windows.Forms.RadioButton()
        Me.lblTitCantObj = New System.Windows.Forms.Label()
        Me.lblTitCamion = New System.Windows.Forms.Label()
        Me.lblTitKm = New System.Windows.Forms.Label()
        Me.lblKilometros = New System.Windows.Forms.Label()
        Me.nudKilometros = New System.Windows.Forms.NumericUpDown()
        Me.lblTitDireccionPresup = New System.Windows.Forms.Label()
        Me.lblDireccionPresup = New System.Windows.Forms.Label()
        Me.txtDireccionPresup = New System.Windows.Forms.TextBox()
        CType(Me.nudObjChicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudObjMedianos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudObjGrandes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudKilometros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSiguientePasoPresup
        '
        Me.btnSiguientePasoPresup.BackColor = System.Drawing.Color.Salmon
        Me.btnSiguientePasoPresup.FlatAppearance.BorderSize = 0
        Me.btnSiguientePasoPresup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguientePasoPresup.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePasoPresup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSiguientePasoPresup.Location = New System.Drawing.Point(410, 412)
        Me.btnSiguientePasoPresup.Name = "btnSiguientePasoPresup"
        Me.btnSiguientePasoPresup.Size = New System.Drawing.Size(241, 49)
        Me.btnSiguientePasoPresup.TabIndex = 51
        Me.btnSiguientePasoPresup.Text = "&SIGUIENTE PASO"
        Me.btnSiguientePasoPresup.UseVisualStyleBackColor = False
        '
        'lblModificarCliente
        '
        Me.lblModificarCliente.AutoSize = True
        Me.lblModificarCliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarCliente.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblModificarCliente.Location = New System.Drawing.Point(248, 20)
        Me.lblModificarCliente.Name = "lblModificarCliente"
        Me.lblModificarCliente.Size = New System.Drawing.Size(199, 33)
        Me.lblModificarCliente.TabIndex = 38
        Me.lblModificarCliente.Text = "CREAR PRESUPUESTO"
        '
        'nudObjChicos
        '
        Me.nudObjChicos.Location = New System.Drawing.Point(186, 115)
        Me.nudObjChicos.Name = "nudObjChicos"
        Me.nudObjChicos.Size = New System.Drawing.Size(144, 20)
        Me.nudObjChicos.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(28, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Objetos Chicos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(28, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Objetos Medianos"
        '
        'nudObjMedianos
        '
        Me.nudObjMedianos.Location = New System.Drawing.Point(186, 159)
        Me.nudObjMedianos.Name = "nudObjMedianos"
        Me.nudObjMedianos.Size = New System.Drawing.Size(144, 20)
        Me.nudObjMedianos.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(28, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Objetos Grandes"
        '
        'nudObjGrandes
        '
        Me.nudObjGrandes.Location = New System.Drawing.Point(186, 208)
        Me.nudObjGrandes.Name = "nudObjGrandes"
        Me.nudObjGrandes.Size = New System.Drawing.Size(144, 20)
        Me.nudObjGrandes.TabIndex = 57
        '
        'btnRecomendarCamion
        '
        Me.btnRecomendarCamion.BackColor = System.Drawing.Color.Salmon
        Me.btnRecomendarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecomendarCamion.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecomendarCamion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRecomendarCamion.Location = New System.Drawing.Point(79, 412)
        Me.btnRecomendarCamion.Name = "btnRecomendarCamion"
        Me.btnRecomendarCamion.Size = New System.Drawing.Size(241, 49)
        Me.btnRecomendarCamion.TabIndex = 59
        Me.btnRecomendarCamion.Text = "&RECOMENDAR VEHICULO"
        Me.btnRecomendarCamion.UseVisualStyleBackColor = False
        '
        'rbtCamionGrande
        '
        Me.rbtCamionGrande.AutoSize = True
        Me.rbtCamionGrande.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCamionGrande.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtCamionGrande.Location = New System.Drawing.Point(444, 205)
        Me.rbtCamionGrande.Name = "rbtCamionGrande"
        Me.rbtCamionGrande.Size = New System.Drawing.Size(124, 27)
        Me.rbtCamionGrande.TabIndex = 60
        Me.rbtCamionGrande.Text = "Camion Grande"
        Me.rbtCamionGrande.UseVisualStyleBackColor = True
        Me.rbtCamionGrande.Visible = False
        '
        'rbtCamionChico
        '
        Me.rbtCamionChico.AutoSize = True
        Me.rbtCamionChico.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCamionChico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtCamionChico.Location = New System.Drawing.Point(447, 110)
        Me.rbtCamionChico.Name = "rbtCamionChico"
        Me.rbtCamionChico.Size = New System.Drawing.Size(113, 27)
        Me.rbtCamionChico.TabIndex = 61
        Me.rbtCamionChico.Text = "Camion Chico"
        Me.rbtCamionChico.UseVisualStyleBackColor = True
        Me.rbtCamionChico.Visible = False
        '
        'rbtCamionMediano
        '
        Me.rbtCamionMediano.AutoSize = True
        Me.rbtCamionMediano.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCamionMediano.ForeColor = System.Drawing.SystemColors.Control
        Me.rbtCamionMediano.Location = New System.Drawing.Point(444, 157)
        Me.rbtCamionMediano.Name = "rbtCamionMediano"
        Me.rbtCamionMediano.Size = New System.Drawing.Size(132, 27)
        Me.rbtCamionMediano.TabIndex = 62
        Me.rbtCamionMediano.Text = "Camion Mediano"
        Me.rbtCamionMediano.UseVisualStyleBackColor = True
        Me.rbtCamionMediano.Visible = False
        '
        'lblTitCantObj
        '
        Me.lblTitCantObj.AutoSize = True
        Me.lblTitCantObj.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCantObj.ForeColor = System.Drawing.Color.White
        Me.lblTitCantObj.Location = New System.Drawing.Point(28, 74)
        Me.lblTitCantObj.Name = "lblTitCantObj"
        Me.lblTitCantObj.Size = New System.Drawing.Size(159, 25)
        Me.lblTitCantObj.TabIndex = 63
        Me.lblTitCantObj.Text = "CANTIDAD DE OBJETOS"
        '
        'lblTitCamion
        '
        Me.lblTitCamion.AutoSize = True
        Me.lblTitCamion.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCamion.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTitCamion.Location = New System.Drawing.Point(443, 74)
        Me.lblTitCamion.Name = "lblTitCamion"
        Me.lblTitCamion.Size = New System.Drawing.Size(63, 25)
        Me.lblTitCamion.TabIndex = 64
        Me.lblTitCamion.Text = "CAMION"
        Me.lblTitCamion.Visible = False
        '
        'lblTitKm
        '
        Me.lblTitKm.AutoSize = True
        Me.lblTitKm.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitKm.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTitKm.Location = New System.Drawing.Point(28, 304)
        Me.lblTitKm.Name = "lblTitKm"
        Me.lblTitKm.Size = New System.Drawing.Size(172, 23)
        Me.lblTitKm.TabIndex = 71
        Me.lblTitKm.Text = "KILOMETROS A RECORRER"
        Me.lblTitKm.Visible = False
        '
        'lblKilometros
        '
        Me.lblKilometros.AutoSize = True
        Me.lblKilometros.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilometros.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblKilometros.Location = New System.Drawing.Point(28, 342)
        Me.lblKilometros.Name = "lblKilometros"
        Me.lblKilometros.Size = New System.Drawing.Size(69, 19)
        Me.lblKilometros.TabIndex = 66
        Me.lblKilometros.Text = "Kilometros:"
        Me.lblKilometros.Visible = False
        '
        'nudKilometros
        '
        Me.nudKilometros.Location = New System.Drawing.Point(118, 345)
        Me.nudKilometros.Name = "nudKilometros"
        Me.nudKilometros.Size = New System.Drawing.Size(165, 20)
        Me.nudKilometros.TabIndex = 65
        Me.nudKilometros.Visible = False
        '
        'lblTitDireccionPresup
        '
        Me.lblTitDireccionPresup.AutoSize = True
        Me.lblTitDireccionPresup.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDireccionPresup.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTitDireccionPresup.Location = New System.Drawing.Point(443, 304)
        Me.lblTitDireccionPresup.Name = "lblTitDireccionPresup"
        Me.lblTitDireccionPresup.Size = New System.Drawing.Size(75, 23)
        Me.lblTitDireccionPresup.TabIndex = 72
        Me.lblTitDireccionPresup.Text = "DIRECCION"
        Me.lblTitDireccionPresup.Visible = False
        '
        'lblDireccionPresup
        '
        Me.lblDireccionPresup.AutoSize = True
        Me.lblDireccionPresup.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionPresup.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDireccionPresup.Location = New System.Drawing.Point(361, 345)
        Me.lblDireccionPresup.Name = "lblDireccionPresup"
        Me.lblDireccionPresup.Size = New System.Drawing.Size(61, 19)
        Me.lblDireccionPresup.TabIndex = 73
        Me.lblDireccionPresup.Text = "Direccion:"
        Me.lblDireccionPresup.Visible = False
        '
        'txtDireccionPresup
        '
        Me.txtDireccionPresup.Location = New System.Drawing.Point(447, 347)
        Me.txtDireccionPresup.Name = "txtDireccionPresup"
        Me.txtDireccionPresup.Size = New System.Drawing.Size(246, 20)
        Me.txtDireccionPresup.TabIndex = 74
        Me.txtDireccionPresup.Visible = False
        '
        'frmCaracteristicasPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(723, 496)
        Me.Controls.Add(Me.txtDireccionPresup)
        Me.Controls.Add(Me.lblDireccionPresup)
        Me.Controls.Add(Me.lblTitDireccionPresup)
        Me.Controls.Add(Me.lblTitKm)
        Me.Controls.Add(Me.lblKilometros)
        Me.Controls.Add(Me.nudKilometros)
        Me.Controls.Add(Me.lblTitCamion)
        Me.Controls.Add(Me.lblTitCantObj)
        Me.Controls.Add(Me.rbtCamionMediano)
        Me.Controls.Add(Me.rbtCamionChico)
        Me.Controls.Add(Me.rbtCamionGrande)
        Me.Controls.Add(Me.btnRecomendarCamion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudObjGrandes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudObjMedianos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudObjChicos)
        Me.Controls.Add(Me.btnSiguientePasoPresup)
        Me.Controls.Add(Me.lblModificarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCaracteristicasPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Presupuesto"
        CType(Me.nudObjChicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudObjMedianos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudObjGrandes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudKilometros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSiguientePasoPresup As System.Windows.Forms.Button
    Friend WithEvents lblModificarCliente As System.Windows.Forms.Label
    Friend WithEvents nudObjChicos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudObjMedianos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudObjGrandes As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRecomendarCamion As System.Windows.Forms.Button
    Friend WithEvents rbtCamionGrande As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCamionChico As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCamionMediano As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitCantObj As System.Windows.Forms.Label
    Friend WithEvents lblTitCamion As System.Windows.Forms.Label
    Friend WithEvents lblTitKm As System.Windows.Forms.Label
    Friend WithEvents lblKilometros As System.Windows.Forms.Label
    Friend WithEvents nudKilometros As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTitDireccionPresup As System.Windows.Forms.Label
    Friend WithEvents lblDireccionPresup As System.Windows.Forms.Label
    Friend WithEvents txtDireccionPresup As System.Windows.Forms.TextBox
End Class
