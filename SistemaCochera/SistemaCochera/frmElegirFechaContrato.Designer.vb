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
        Me.SuspendLayout()
        '
        'calendarioPresup1
        '
        Me.calendarioPresup1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.calendarioPresup1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.calendarioPresup1.Location = New System.Drawing.Point(170, 101)
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
        Me.btnFecha.Location = New System.Drawing.Point(147, 302)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(241, 49)
        Me.btnFecha.TabIndex = 52
        Me.btnFecha.Text = "&SIGUIENTE PASO"
        Me.btnFecha.UseVisualStyleBackColor = False
        '
        'frmElegirFechaContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 399)
        Me.Controls.Add(Me.btnFecha)
        Me.Controls.Add(Me.calendarioPresup1)
        Me.Name = "frmElegirFechaContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmElegirFechaContrato"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents calendarioPresup1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnFecha As System.Windows.Forms.Button
End Class
