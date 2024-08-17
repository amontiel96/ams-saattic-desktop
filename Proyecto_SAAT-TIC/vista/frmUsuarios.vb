Public Class frmUsuarios
    Dim llamar As New clsValidar()
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTelefono_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

    End Sub

    Private Sub txtComfirPass_Leave(sender As Object, e As EventArgs) Handles txtComfirPass.Leave
        llamar.password = txtComfirPass.Text
        txtComfirPass.Text = llamar.password
    End Sub

    Private Sub txtApellido_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        llamar.Correo = txtEmail.Text
        txtEmail.Text = llamar.Correo
    End Sub
End Class
