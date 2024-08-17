Public Class frmAvisos
    Dim llamar As New clsValidar()
    Private Sub txtAsunto_Leave(sender As Object, e As EventArgs) Handles txtAsunto.Leave
        llamar.DescripcionI = txtAsunto.Text
        txtAsunto.Text = llamar.DescripcionI
    End Sub
End Class
