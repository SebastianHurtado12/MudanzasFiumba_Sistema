Public Class frmDatosPresupuesto

    Private Sub btnComprobarModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobarModificar.Click

        If txtDocumentoSemiCliente.Text <> "" And txtNomApeSemiCliente.Text <> "" And txtTelefonoSemiCliente.Text <> "" Then
            sql = "SELECT MAX(idPresup) FROM presupuestos"
            Proc(sql)
            rs.Read()

            sql = "UPDATE presupuestos set telefono = '" & txtTelefonoSemiCliente.Text & "' , nomApe = '" & txtNomApeSemiCliente.Text & "' , dni = '" & txtDocumentoSemiCliente.Text & "' where  idPresup = '" & rs(0) & "'"
            Proc(sql)

            If frmCaracteristicasPresupuesto.cantObjChicos <> 0 Then
                sql = "INSERT INTO presupObjeto VALUES (" & rs(0) & ",1," & frmCaracteristicasPresupuesto.cantObjChicos & ")"
                Proc(sql)
            End If

            If frmCaracteristicasPresupuesto.cantObjMedianos <> 0 Then
                sql = "INSERT INTO presupObjeto VALUES (" & rs(0) & ",2," & frmCaracteristicasPresupuesto.cantObjMedianos & ")"
                Proc(sql)
            End If

            If frmCaracteristicasPresupuesto.cantObjGrandes <> 0 Then
                sql = "INSERT INTO presupObjeto VALUES (" & rs(0) & ",3," & frmCaracteristicasPresupuesto.cantObjGrandes & ")"
                Proc(sql)
            End If


            Module1.x = 0

            Me.Hide()
            frmPresupuestoImg.Show()
        End If

    End Sub


   
End Class