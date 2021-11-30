Public Class frmFinalizarMudanza
    Dim a As Integer
    Dim Mudanza As Integer
    Dim idClientefin As Integer
    Dim idcontratofin As Integer
    Dim numIdAlmacen As Integer
    Dim fechavenc As String

    Private Sub frmFinalizarMudanza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from contratos where mudanzaFin = 0"
        Proc(sql)
        Do While rs.Read = True

            With lsvMudanzas.Items.Add(rs(0))
                .SubItems.Add(rs(1))
                .SubItems.Add(rs(4))
                .SubItems.Add(rs(5))
                .SubItems.Add(rs(6))
                .SubItems.Add(rs(7))
            End With

        Loop

        Module1.x = 0
    End Sub

    Private Sub btnSigPaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigPaso.Click
        Mudanza = lsvMudanzas.SelectedItems(0).Text
        a = MsgBox("Desea seleccionar la mudanza " & Mudanza & " ", MsgBoxStyle.YesNo, "Seleccionar Mudanza")

        If a = 6 Then
            idClientefin = lsvMudanzas.SelectedItems(0).SubItems(2).Text
            idContratofin = lsvMudanzas.SelectedItems(0).Text
            sql = "update contratos set mudanzafin = 1 where idcontrato = '" & idcontratofin & "'"
            Proc(sql)
            Module1.x = 0
            sql = "select count(*) from contratoalmacen where idcliente = '" & idClientefin & "' and idcontrato = '" & idcontratofin & "'"
            Proc(sql)
            rs.Read()
            If rs(0) > 0 Then
                sql = "select idalmacen from contratoalmacen where idcliente = '" & idClientefin & "' and idcontrato = '" & idcontratofin & "'"
                Proc(sql)
                rs1.Read()
                numIdAlmacen = rs1(0)
                sql = "update almacenesgm set estado = 0 where idalmacen = '" & numIdAlmacen & "'"
                Proc(sql)
                Module1.x = 0
                sql = "update contratoalmacen set vigencia = 0 where idalmacen = '" & numIdAlmacen & "'"
                Proc(sql)
            End If
            numIdAlmacen = rs(0)
            
            MsgBox("La mudanza ha finalizado")
        End If
        Module1.x = 0
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frmInicio.Show()
    End Sub
End Class