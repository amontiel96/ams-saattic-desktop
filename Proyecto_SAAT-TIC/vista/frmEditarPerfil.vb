Public Class frmEditarPerfil
    Dim llamar As New clsValidar()

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        llamar.nombre = txtNombre.Text
        txtNombre.Text = llamar.nombre
    End Sub

    Private Sub txtApellidos_Leave(sender As Object, e As EventArgs) Handles txtApellidos.Leave
        llamar.Apellidos = txtApellidos.Text
        txtApellidos.Text = llamar.Apellidos
    End Sub

    Private Sub txtTel_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        llamar.password = txtPass.Text
        txtPass.Text = llamar.password
    End Sub

    Private Sub txtComfirPass_Leave(sender As Object, e As EventArgs) Handles txtComfirPass.Leave
        llamar.password = txtComfirPass.Text
        txtComfirPass.Text = llamar.password
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        llamar.Correo = txtEmail.Text
        txtEmail.Text = llamar.Correo
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
