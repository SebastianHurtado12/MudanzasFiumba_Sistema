Public Class frmReciboAlmacen

    Private Sub frmReciboAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRecibo.Text = frmSeleccioneAlmacen.idrecibo
        lblLugar.Text = "Av.Lope de Vega 233"
        sql = "select day(curdate()), month(curdate()), year(curdate())"
        Proc(sql)
        rs.Read()
        lblDia.Text = rs(0)
        lblMes.Text = rs(1)
        lblanio.Text = rs(2)
        lblNombre.Text = frmAlmacenes.nombreCliente
        lblMonto.Text = frmSeleccioneAlmacen.monto
        lblMontoEscrito.Text = GetMyNumberToWords(frmSeleccioneAlmacen.monto)
        lblRazon.Text = "Alquiler de Almacen"

        Module1.x = 0

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("Funcion a Implementar", "PROXIMAMENTE")
    End Sub

    Private Sub btnVolverInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverInicio.Click
        Me.Hide()
        frmInicio.Show()
    End Sub
End Class