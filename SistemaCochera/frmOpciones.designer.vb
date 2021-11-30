<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpciones))
        Me.lblOpcionesTitulo = New System.Windows.Forms.Label()
        Me.btnModificarCamiones = New System.Windows.Forms.Button()
        Me.btnModificarAlmacen = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llAtras = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblOpcionesTitulo
        '
        resources.ApplyResources(Me.lblOpcionesTitulo, "lblOpcionesTitulo")
        Me.lblOpcionesTitulo.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblOpcionesTitulo.Name = "lblOpcionesTitulo"
        '
        'btnModificarCamiones
        '
        Me.btnModificarCamiones.BackColor = System.Drawing.Color.Salmon
        resources.ApplyResources(Me.btnModificarCamiones, "btnModificarCamiones")
        Me.btnModificarCamiones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificarCamiones.Name = "btnModificarCamiones"
        Me.btnModificarCamiones.UseVisualStyleBackColor = False
        '
        'btnModificarAlmacen
        '
        Me.btnModificarAlmacen.BackColor = System.Drawing.Color.Salmon
        resources.ApplyResources(Me.btnModificarAlmacen, "btnModificarAlmacen")
        Me.btnModificarAlmacen.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarAlmacen.Name = "btnModificarAlmacen"
        Me.btnModificarAlmacen.UseVisualStyleBackColor = False
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.Color.Salmon
        resources.ApplyResources(Me.btnModificarCliente, "btnModificarCliente")
        Me.btnModificarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnAtras
        '
        Me.btnAtras.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAtras.LinkColor = System.Drawing.Color.Cornsilk
        resources.ApplyResources(Me.btnAtras, "btnAtras")
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.TabStop = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Name = "Label1"
        '
        'llAtras
        '
        resources.ApplyResources(Me.llAtras, "llAtras")
        Me.llAtras.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.llAtras.LinkColor = System.Drawing.Color.Cornsilk
        Me.llAtras.Name = "llAtras"
        Me.llAtras.TabStop = True
        '
        'frmOpciones
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.llAtras)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.btnModificarAlmacen)
        Me.Controls.Add(Me.btnModificarCamiones)
        Me.Controls.Add(Me.lblOpcionesTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOpcionesTitulo As System.Windows.Forms.Label
    Friend WithEvents btnModificarCamiones As System.Windows.Forms.Button
    Friend WithEvents btnModificarAlmacen As System.Windows.Forms.Button
    Friend WithEvents btnModificarCliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llAtras As System.Windows.Forms.LinkLabel

End Class
