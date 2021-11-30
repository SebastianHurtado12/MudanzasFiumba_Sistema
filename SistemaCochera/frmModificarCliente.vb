Public Class frmModificarCliente
    Dim a As Integer
    Private Sub btnComprobarModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobarModificar.Click
        sql = "select count(*) from personas p inner join clientes c ON p.idpersona = c.idpersona where p.dni = '" & txtDocumentoModificar.Text & "'"
        Proc(sql)
        rs.Read()

        If rs(0) > 0 Then

            sql = "select * from personas p inner join clientes c ON p.idpersona = c.idpersona where p.dni = '" & txtDocumentoModificar.Text & "'"
            Proc(sql)
            If rs1.Read = True Then


                lblApellido.Visible = True
                lblDireccion.Visible = True
                lblMail.Visible = True
                lblTelefono.Visible = True
                txtApellido.Visible = True
                txtApellido.Enabled = False
                txtDireccion.Visible = True
                txtEmail.Visible = True
                txtTelefono.Visible = True

                txtApellido.Text = rs1(2)


                txtTelefono.Text = rs1(3)


                txtEmail.Text = rs1(4)


                txtDireccion.Text = rs1(5)

                btnComprobarModificar.Visible = False

            End If

        Else
            MsgBox("El Documento Ingresado no existe")
        End If

        Module1.x = 0

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        a = MsgBox("Desea Modificar los datos de " & txtApellido.Text & " con documento " & txtDocumentoModificar.Text & "", MsgBoxStyle.YesNo, "Modificar Cliente")

        If a = 6 Then
            sql = "UPDATE personas set telefono = '" & txtTelefono.Text & "' , email = '" & txtEmail.Text & "' , direccion = '" & txtDireccion.Text & "' where dni = '" & txtDocumentoModificar.Text & "'"
            Proc(sql)
            rs.Read()
            MsgBox("El Cliente Ha Sido Modificado Exitosamente")

            txtApellido.Text = ""
            txtDireccion.Text = ""
            txtDocumentoModificar.Text = ""
            txtEmail.Text = ""
            txtTelefono.Text = ""

            btnComprobarModificar.Visible = True

        Else
            MsgBox("Accion Cancelada")
        End If
        Module1.x = 0
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frmOpciones.Show()
    End Sub

End Class