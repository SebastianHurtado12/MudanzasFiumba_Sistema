Public Class frmElegirPresupContrato

    Public numPresup As Integer


    Private Sub frmElegirPresupContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT idPresup,dni,nomApe,monto,direccion,fecha_emision,fecha_vencimiento,tamCamion FROM presupuestos WHERE fecha_vencimiento > curdate() AND idPresup NOT IN (SELECT idPresup FROM contratos)"
        Proc(sql)

        Do While rs.Read = True

            With lsvPresupDisponibles.Items.Add(rs(0))
                .SubItems.Add(rs(1))
                .SubItems.Add(rs(2))
                .SubItems.Add(rs(3))
                .SubItems.Add(rs(4))
                .SubItems.Add(rs(5))
                .SubItems.Add(rs(6))
            End With

        Loop

        Module1.x = 0
    End Sub

    Private Sub btnComprobarModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobarModificar.Click

        Dim a As Integer
        numPresup = lsvPresupDisponibles.SelectedItems(0).SubItems(0).Text


        a = MsgBox("Desea seleccionar el presupuesto " & numPresup & " ", MsgBoxStyle.YesNo, "Elegir cochera")

        If a = 6 Then

            Me.Hide()
            frmElegirFechaContrato.Show()

        End If
    End Sub

    Private Sub llAtras_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llAtras.LinkClicked
        Me.Close()
        frmInicio.Show()
    End Sub
End Class