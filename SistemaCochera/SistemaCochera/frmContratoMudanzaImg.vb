Public Class frmContratoMudanzaImg

    Private Sub frmContratoMudanzaImg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT P.dni,P.nomApe,P.direccion,P.email,PR.Monto FROM contratos C INNER JOIN clientes CL ON C.idCliente=CL.idCliente INNER JOIN personas P ON CL.idPersona=P.idPersona INNER JOIN presupuestos PR ON C.idPresup=PR.idPresup WHERE C.idContrato=(SELECT MAX(idContrato) FROM contratos)"
        Proc(sql)
        rs.Read()
    End Sub
End Class