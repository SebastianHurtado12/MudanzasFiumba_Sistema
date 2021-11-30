Public Class frmContratoAlmacen

    Private Sub frmContratoAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNombre.Text = frmAlmacenes.nombreCliente
        lblDNI.Text = frmAlmacenes.dniCliente
        lblMail.Text = frmAlmacenes.mailCliente
        lblDireccion.Text = frmAlmacenes.domicilioCliente
        lblMonto.Text = frmSeleccioneAlmacen.monto
    End Sub

    Private Sub btnRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.Click
        Me.Hide()
        frmReciboAlmacen.Show()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("Funcion a Implementar", , "PROXIMAMENTE")
    End Sub
End Class