Public Class frmPresupuestoImg

    Private Sub frmPresupuestoImg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT P.idPresup,nomApe,telefono,monto,kilometros,direccion,fecha_emision,fecha_vencimiento,PC.precio,SUM(PO.CANT) FROM presupuestos P INNER JOIN preciosCamiones PC ON P.tamCamion=PC.tamanio INNER JOIN PresupObjeto PO ON P.idPresup=PO.idPresup WHERE P.idPresup=(SELECT MAX(idpresup) from presupuestos)"
        Proc(sql)
        rs.Read()

        lblNumPresup.Text = rs(0)
        lblNomCliente.Text = rs(1)
        lblTelCliente.Text = rs(2)
        lblTotalPresup.Text = rs(3)
        lblPrecioTotalPresup.Text = rs(3)
        lblCantKmPresup.Text = rs(4)
        lblDireCliente.Text = rs(5)
        lblFechaActual.Text = rs(6)
        lblFechaVencimientoPresup.Text += rs(7)
        lblCamionPrecioPresup.Text = rs(8)
        lblCantObjPresup.Text = rs(9)

        Module1.x = 0
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("A implementar!", , "Proximamente")
    End Sub

    Private Sub btnVolverInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverInicio.Click
        'Volver a la pantalla Principal
        frmInicio.Show()
        frmCaracteristicasPresupuesto.Close()
        frmDatosPresupuesto.Close()
        Me.Close()
    End Sub
End Class