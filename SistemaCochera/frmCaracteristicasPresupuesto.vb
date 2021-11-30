Public Class frmCaracteristicasPresupuesto

    Public tamCamion As String
    Public cantObjChicos As Integer
    Public cantObjMedianos As Integer
    Public cantObjGrandes As Integer

    Private Sub btnRecomendarPresup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecomendarCamion.Click
        'Muestro las diferentes opciones
        lblTitCamion.Visible = True
        rbtCamionChico.Visible = True
        rbtCamionMediano.Visible = True
        rbtCamionGrande.Visible = True
        lblKilometros.Visible = True
        nudKilometros.Visible = True
        txtDireccionPresup.Visible = True
        lblTitDireccionPresup.Visible = True
        lblDireccionPresup.Visible = True
        lblTitKm.Visible = True

        If nudObjChicos.Value <= 15 And nudObjMedianos.Value <= 8 And nudObjGrandes.Value <= 3 Then
            rbtCamionChico.Checked = True
            tamCamion = "Chico"

        ElseIf nudObjChicos.Value <= 30 And nudObjMedianos.Value <= 16 And nudObjGrandes.Value <= 6 Then
            rbtCamionMediano.Checked = True
            tamCamion = "Mediano"
        Else
            rbtCamionGrande.Checked = True
            tamCamion = "Grande"
        End If


    End Sub

    Private Sub btnSiguientePasoPresup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguientePasoPresup.Click

        If nudKilometros.Value <> 0 And (nudObjChicos.Value <> 0 Or nudObjGrandes.Value <> 0 Or nudObjMedianos.Value <> 0) Then
            sql = "SELECT precio FROM preciosCamiones WHERE tamanio='" & tamCamion & "'"
            Proc(sql)
            rs.Read()

            sql = "INSERT INTO presupuestos VALUES ('',NULL,NULL,NULL," & nudKilometros.Value * rs(0) & "," & nudKilometros.Value & ",'" & txtDireccionPresup.Text & "','" & tamCamion & "', curdate(), DATE_ADD(curdate(), INTERVAL 2 week) )"
            Proc(sql)

            cantObjChicos = nudObjChicos.Value
            cantObjMedianos = nudObjMedianos.Value
            cantObjGrandes = nudObjGrandes.Value

            Module1.x = 0
            Me.Hide()
            frmDatosPresupuesto.Show()

        End If

    End Sub

End Class