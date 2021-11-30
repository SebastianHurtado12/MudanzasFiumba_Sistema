Public Class frmAlmacenes
    Public idCliente As Integer
    Public dniCliente As Integer
    Public nombreCliente As String
    Public domicilioCliente As String
    Public NumDni As Integer
    Public mailCliente As String

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        sql = "select count(*) from personas p inner join clientes c ON p.idpersona = c.idpersona where p.dni = '" & txtDocumentoVerificar.Text & "'"
        Proc(sql)
        rs.Read()

        If rs(0) > 0 Then
            NumDni = txtDocumentoVerificar.Text
            btnVerificar.Visible() = False
            Module1.x = 0
            sql = "select * from personas p inner join clientes c ON p.idpersona = c.idpersona where p.dni = '" & txtDocumentoVerificar.Text & "'"
            Proc(sql)
            rs.Read()
            idCliente = rs(6)
            dniCliente = rs(1)
            nombreCliente = rs(2)
            mailCliente = rs(4)
            domicilioCliente = rs(5)
        Else
            MsgBox("El documento ingresado no esta registrado en la base de datos")
        End If

        Module1.x = 0


    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Me.Hide()
        frmContratosCliente.Show()
    End Sub

    Private Sub frmAlmacenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub llAtras_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llAtras.LinkClicked
        Me.Close()
        frmInicio.Show()
    End Sub
End Class