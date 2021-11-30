Public Class frmContratosCliente
    Public numContrato As Integer
    Public fechaVencimiento As Date
    Dim a As Integer

    Private Sub frmContratosCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select c.idContrato, c.fecha_mudanza, r.precio from recibos r inner join contratos c ON r.idContrato = c.idContrato inner join Clientes cl ON c.idCliente = cl.idCliente inner join personas p ON cl.idPersona = p.idPersona where p.dni = '" & frmAlmacenes.NumDni & "'  and c.mudanzaFin = 0"
        Proc(sql)
        Do While rs.Read = True

            With lsvAlmacenes.Items.Add(rs(0))
                .SubItems.Add(rs(1))
                .SubItems.Add(rs(2))
            End With

        Loop

        Module1.x = 0
    End Sub

    Private Sub btnSigPaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigPaso.Click
        numContrato = lsvAlmacenes.SelectedItems(0).Text
        a = MsgBox("Desea seleccionar el contrato " & numContrato & " ", MsgBoxStyle.YesNo, "Seleccionar Contrato")

        If a = 6 Then
            fechaVencimiento = lsvAlmacenes.SelectedItems(0).SubItems(1).Text
            Me.Hide()
            frmSeleccioneAlmacen.Show()
        End If
    End Sub

    Private Sub lblDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDatos.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frmInicio.Show()

    End Sub
End Class