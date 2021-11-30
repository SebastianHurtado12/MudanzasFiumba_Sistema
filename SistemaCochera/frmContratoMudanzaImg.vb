Public Class frmContratoMudanzaImg

    Private Sub frmContratoMudanzaImg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT P.dni,P.nomApe,P.direccion,P.email,PR.Monto,curdate() FROM contratos C INNER JOIN clientes CL ON C.idCliente=CL.idCliente INNER JOIN personas P ON CL.idPersona=P.idPersona INNER JOIN presupuestos PR ON C.idPresup=PR.idPresup WHERE C.idContrato=(SELECT MAX(idContrato) FROM contratos)"
        Proc(sql)
        rs.Read()

        lblDniNumero.Text = rs(0)
        lblClienteNombre.Text = rs(1)
        lblDireccionCliente.Text = rs(2)
        lblEmailCliente.Text = rs(3)
        lblMontoContrato.Text = rs(4)
        lblFechaActual.Text += rs(5)


        Module1.x = 0
    End Sub

    Private Sub btnVolverInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.Click
        Me.Hide()
        frmRecibo.Show()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("A implementar!", , "Proximamente")
    End Sub
End Class