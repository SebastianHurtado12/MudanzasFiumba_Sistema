Public Class frmNuevoClienteContrato

    Dim a As Integer
    Dim idCliente As Integer



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frmElegirFechaContrato.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobar.Click
        sql = "select count(*) from personas p inner join clientes c ON p.idpersona = c.idpersona where p.dni = '" & txtDocumento.Text & "'"
        Proc(sql)
        rs.Read()
        'Verifico la existencia del dni
        If rs(0) > 0 Then
            'Si el dni existe
            MsgBox("El documento ingresado ya esta registrado")
            lblApellido.Visible = True
            lblTelefono.Visible = True
            lblMail.Visible = True
            lblDireccion.Visible = True

            sql = "select * from personas p inner join clientes c ON p.idpersona = c.idpersona where p.dni = '" & txtDocumento.Text & "'"
            Proc(sql)
            If rs1.Read = True Then

                txtApellido.Visible = True
                txtTelefono.Visible = True
                txtMail.Visible = True
                txtDireccion.Visible = True

                txtApellido.Text = rs1(2)

                txtTelefono.Text = rs1(3)

                txtMail.Text = rs1(4)

                txtDireccion.Text = rs1(5)

                txtApellido.Enabled = False
                txtTelefono.Enabled = False
                txtMail.Enabled = False
                txtDireccion.Enabled = False

            End If

        Else
            MsgBox("El documento no se encuentra en la base de datos")
            lblApellido.Visible = True
            lblTelefono.Visible = True
            lblMail.Visible = True
            lblDireccion.Visible = True
            txtApellido.Visible = True
            txtTelefono.Visible = True
            txtMail.Visible = True
            txtDireccion.Visible = True


        End If

        btnComprobar.Hide()
        Module1.x = 0
    End Sub


    Private Sub btnEmitirCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitirCont.Click

        Dim idConductor As Integer
        Dim idCamion As Integer

        a = MsgBox("Estas seguro de generar un contrato al cliente " & txtApellido.Text & " ?", MsgBoxStyle.YesNo, "Registrar Cliente")
        If a = 6 Then

            'Verificamos que el textbox este inhabilitado, si es asi, determinamos que se NO ha encontrado al cliente en la base de datos
            If txtApellido.Enabled = True Then
                sql = "INSERT INTO personas VALUES('','" & txtDocumento.Text & "','" & txtApellido.Text & "','" & txtTelefono.Text & "','" & txtMail.Text & "','" & txtDireccion.Text & "')"
                Proc(sql)
                sql = "SELECT MAX(idPersona) FROM personas"
                Proc(sql)
                rs1.Read()

                sql = "INSERT INTO Clientes VALUES('','" & rs1(0) & "',curdate())"
                Proc(sql)
                Module1.x = 0
            End If

            sql = "SELECT C.idCliente FROM Personas P INNER JOIN clientes C ON P.idPersona=C.idPersona WHERE dni='" & txtDocumento.Text & "'"
            Proc(sql)
            rs.Read()
            'Con la siguiente consulta asigno un conductor cualquier para que maneje el vehiculo
            sql = "SELECT C.idConductor FROM conductores C WHERE C.idConductor NOT IN (SELECT idConductor FROM contratos WHERE DATE(fecha_mudanza)='" & Format(frmElegirFechaContrato.fechaMudanza, "yyyy/MM/dd") & "')"
            Proc(sql)
            rs1.Read()

            idConductor = rs1(0)

            'Con la siguiente consulta asigno un vehiculo elegido por el cliente
            sql = "SELECT C.idCamion FROM camiones C INNER JOIN preciosCamiones PC ON PC.idPrecCam=C.idPrecCam   WHERE tamanio='" & frmElegirFechaContrato.tamCamion & "' AND  idCamion  NOT IN (SELECT idCamion FROM contratos WHERE DATE(fecha_mudanza)=DATE('" & frmElegirFechaContrato.fechaMudanza & "')) AND tamanio='" & frmElegirFechaContrato.tamCamion & "'"
            Proc(sql)
            rs1.Read()

            idCamion = rs1(0)

            sql = "INSERT INTO contratos VALUES('','" & frmElegirPresupContrato.numPresup & "','" & idConductor & "','" & rs(0) & "','" & idCamion & "','" & Format(frmElegirFechaContrato.fechaMudanza, "yyyy/MM/dd") & "' ,current_timestamp(),0)"
            Proc(sql)
            sql = "SELECT MAX(idContrato),monto FROM contratos C INNER JOIN presupuestos PR ON C.idPresup=PR.idPresup"
            Proc(sql)
            rs1.Read()
            sql = "INSERT INTO recibos VALUES('','" & rs1(0) & "',current_timestamp(),'" & rs1(1) & "')"
            Proc(sql)

            Module1.x = 0
            frmContratoMudanzaImg.Show()
            Me.Hide()

        End If


    End Sub


 
End Class