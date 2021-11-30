<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElegirFechaContrato
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
        Me.calendarioPresup1 = New System.Windows.Forms.MonthCalendar()
        Me.btnFecha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calendarioPresup1
        '
        Me.calendarioPresup1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.calendarioPresup1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.calendarioPresup1.Location = New System.Drawing.Point(138, 97)
        Me.calendarioPresup1.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.calendarioPresup1.Name = "calendarioPresup1"
        Me.calendarioPresup1.TabIndex = 0
        Me.calendarioPresup1.TitleBackColor = System.Drawing.Color.Beige
        Me.calendarioPresup1.TitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.calendarioPresup1.TrailingForeColor = System.Drawing.SystemColors.ControlDarkDark
        '
        'btnFecha
        '
        Me.btnFecha.BackColor = System.Drawing.Color.Salmon
        Me.btnFecha.FlatAppearance.BorderSize = 0
        Me.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecha.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFecha.Location = New System.Drawing.Point(114, 297)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(241, 49)
        Me.btnFecha.TabIndex = 52
        Me.btnFecha.Text = "&SIGUIENTE PASO"
        Me.btnFecha.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(154, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "SELECIONE SU FECHA"
        '
        'frmElegirFechaContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(465, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFecha)
        Me.Controls.Add(Me.calendarioPresup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmElegirFechaContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir fecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calendarioPresup1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnFecha As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
