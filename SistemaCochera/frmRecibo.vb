Public Class frmRecibo

    Private Sub frmRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.x = 0 'Habilito nuevamente el primer RS

        sql = "SELECT R.idRecibo,PR.monto,P.NomApe,P.dni,day(curdate()),month(curdate()),year(curdate()) FROM recibos R INNER JOIN contratos CT ON CT.idContrato=R.idContrato INNER JOIN clientes CL ON CL.idCliente=CT.idCliente INNER JOIN personas P ON p.idPersona=CL.idPersona INNER JOIN presupuestos PR ON CT.idPresup=PR.idPresup  WHERE R.idRecibo=(SELECT MAX(idRecibo) FROM Recibos)"
        Proc(sql)

        If rs.Read = True Then
            lblNroRecibo.Text = rs(0)
            lblMonto.Text = rs(1)
            lblClienteNom.Text = rs(2)
            lblDniCliente.Text = rs(3)
            lblDiaRecibo.Text = rs(4)
            lblMesRecibo.Text = rs(5)
            lblAnioRecibo.Text = rs(6)
            lblMontoLetras.Text = GetMyNumberToWords(rs(1))

        End If

        Module1.x = 0
    End Sub
    Private Sub btnVolverInicio_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverInicio.Click
        frmInicio.Show()
        frmContratoMudanzaImg.Close()
        frmNuevoClienteContrato.Close()
        frmElegirFechaContrato.Close()
        frmElegirPresupContrato.Close()
        Me.Close()
    End Sub

    Private Sub btnImprimir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir1.Click
        MsgBox("A implementar!", , "Proximamente")
    End Sub

  
End Class