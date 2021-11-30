Public Class frmModificarAlmacen
    Dim a As Integer
    Private Sub frmModificarAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT tamanio FROM preciosalmacenes"
        Proc(sql)

        Do While rs.Read = True
            cmbMudanza.Items.Add(rs(0))
        Loop



        Module1.x = 0
    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        sql = "select precio from preciosalmacenes where tamanio = '" & cmbmudanza.SelectedItem & "'"
        Proc(sql)
        rs.Read()

        txtLista.Text = rs(0)

        Module1.x = 0

    End Sub

    Private Sub btnPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrecio.Click
        a = MsgBox("Desea Modificar el precio del almacen " & cmbmudanza.SelectedItem & "", MsgBoxStyle.YesNo, "Modificar Precio")

        If a = 6 Then
            sql = "UPDATE preciosalmacenes set precio = '" & txtLista.Text & "' where tamanio = '" & cmbmudanza.SelectedItem & "'"
            Proc(sql)
            rs.Read()
            MsgBox("El monto fue modificado")


        Else
            MsgBox("No se realizo modificacion en el monto")
        End If

        Module1.x = 0
    End Sub
    Private Sub llAtras_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llAtras.LinkClicked
        Me.Hide()
        frmOpciones.Show()
    End Sub
End Class