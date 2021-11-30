Public Class frmSeleccioneAlmacen
    Dim numAlmacen As Integer
    Dim a As Integer
    Dim IdContrato As Integer
    Public idrecibo As Integer
    Public monto As Integer
    Private Sub frmSeleccioneAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select a.idAlmacen, pa.tamanio, pa.precio from AlmacenesGM a inner join preciosAlmacenes pa ON a.idPrecAlmacen = pa.idPrecAlmacen where a.estado = 0"
        Proc(sql)
        Do While rs.Read = True

            With lsvAlmacenesDisponibles.Items.Add(rs(0))
                .SubItems.Add(rs(1))
                .SubItems.Add(rs(2))
            End With

        Loop

        Module1.x = 0
    End Sub

    Private Sub btnSigPaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigPaso.Click
        numAlmacen = lsvAlmacenesDisponibles.SelectedItems(0).Text
        monto = lsvAlmacenesDisponibles.SelectedItems(0).SubItems(2).Text

        a = MsgBox("Desea seleccionar el almacen " & numAlmacen & " ", MsgBoxStyle.YesNo, "Seleccionar Almacen")

        If a = 6 Then
            sql = "insert into contratoAlmacen values('', '" & frmContratosCliente.numContrato & "', '" & numAlmacen & "', '" & frmAlmacenes.idCliente & "', '" & Format(frmContratosCliente.fechaVencimiento, "yyyy/MM/dd") & "', curdate(), 1)"
            Proc(sql)
            sql = "update Almacenesgm set estado = 1 where idalmacen = '" & numAlmacen & "'"
            Proc(sql)
            Module1.x = 0
            sql = "select idContratoAlmacen from contratoAlmacen where idalmacen = '" & numAlmacen & "'"
            Proc(sql)
            rs.Read()
            IdContrato = rs(0)
            sql = "insert into reciboalmacen values('', '" & IdContrato & "', '" & monto & "')"
            Proc(sql)
            Module1.x = 0
            sql = "select idReciboAlmacen from reciboalmacen where idContratoAlmacen = '" & IdContrato & "'"
            Proc(sql)
            rs.Read()
            idRecibo = rs(0)
            MsgBox("El contrato del almacen fue creado")
            MsgBox("El recibo fue generado")
            Me.Hide()
            frmContratoAlmacen.Show()

        End If

        Module1.x = 0
    End Sub


End Class