Public Class frmInicio

    Private Sub btnCrearPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearPedido.Click
        Me.Hide()
        frmCaracteristicasPresupuesto.Show()
    End Sub

    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

  
    Private Sub btnOtrasOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrasOpciones.Click
        Me.Hide()
        frmOpciones.Show()
    End Sub

    Private Sub btnRealizarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarPago.Click
        frmElegirPresupContrato.Show()
        Me.Hide()
    End Sub

    Private Sub btnVerListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerListado.Click
        Me.Hide()
        frmAlmacenes.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmFinalizarMudanza.Show()
    End Sub
End Class