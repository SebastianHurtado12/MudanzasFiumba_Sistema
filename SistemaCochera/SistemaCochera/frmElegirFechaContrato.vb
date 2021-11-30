Public Class frmElegirFechaContrato

    Public fechaMudanza As DateTime
    Public tamCamion As String

    Private Sub frmElegirFechaContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT tamCamion FROM presupuestos WHERE idPresup='" & frmElegirPresupContrato.numPresup & "'"
        Proc(sql)
        rs.Read()
        tamCamion = rs(0)
        'La siguiente consulta retorna a las fechas en la que todos los camiones estan operando, esto significa que no hay disponibles para el cliente
        sql = "SELECT COUNT(*),fecha_mudanza FROM contratos CT  INNER JOIN camiones C ON C.idCamion=CT.idCamion INNER JOIN preciosCamiones PC ON PC.idPrecCam=C.idPrecCam WHERE tamanio='" & rs(0) & "' AND curdate()<fecha_mudanza GROUP by fecha_mudanza HAVING COUNT(*)>=(SELECT COUNT(*) FROM Camiones C INNER JOIN preciosCamiones PC ON PC.idPrecCam=C.idPrecCam WHERE tamanio='" & rs(0) & "')"
        Proc(sql)

        Do While rs1.Read = True

            Dim a As Date = rs1(1)

            calendarioPresup1.AddBoldedDate(a)
            calendarioPresup1.UpdateBoldedDates()


        Loop

        Module1.x = 0

    End Sub

    Private Sub btnFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFecha.Click

        fechaMudanza = calendarioPresup1.SelectionStart
        MsgBox(fechaMudanza, , "a")
        Me.Hide()
        frmNuevoClienteContrato.Show()



    End Sub

   
End Class