Public Class frmOpciones

    Private Sub btnModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCliente.Click
        Me.Hide()
        frmModificarCliente.Show()
    End Sub


    Private Sub btnModificarCamiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCamiones.Click
        Me.Hide()
        frmModificarCamion.Show()
    End Sub

    Private Sub btnModificarAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarAlmacen.Click
        Me.Hide()
        frmModificarAlmacen.Show()
    End Sub

    Private Sub lblOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub btnAtras_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnAtras.LinkClicked
        frmInicio.Show()
        Me.Close()
    End Sub

    Private Sub llAtras_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llAtras.LinkClicked
        frmInicio.Show()
        Me.Close()
    End Sub
End Class
