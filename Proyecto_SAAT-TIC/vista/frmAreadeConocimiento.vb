Public Class frmAreadeConocimiento
    Dim llamar As New clsValidar
    Dim farea As New fArea
    Dim dts As New vArea
    Dim recibe As DataTable
    Private Sub txtNom_Leave(sender As Object, e As EventArgs) Handles txtNom.Leave
        If Not IsNumeric(txtNom.Text) Then
        Else
            txtNom.Clear()
            txtNom.Focus()
        End If
    End Sub

    Public Sub llenaGrid()
        Dim cad As String = "select intId_area as Clave,vchArea as Area from tbl_areasConocimiento"
        recibe = farea.mostrar(cad)
        DataGridView1.DataSource = recibe
    End Sub

    Private Sub frmAreadeConocimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNom.Text <> vbNullString Then
                dts.gArea = txtNom.Text
                If farea.insertar(dts) Then
                    MessageBox.Show("Se guardo con exito", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNom.Clear()
                    btnGuardar.Enabled = False
                    btnCancelar.Enabled = False
                    btnNuevo.Enabled = True
                    txtNom.Enabled = False
                    llenaGrid()
                Else
                    MessageBox.Show("Error al guardar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_modifica_Click(sender As Object, e As EventArgs) Handles btn_modifica.Click
        If txtNom.Text <> vbNullString Then
            dts.gId = lbl_clave.Text
            dts.gArea = txtNom.Text
            If farea.editar(dts) Then
                MessageBox.Show("Se edito correctamente", "Editado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNom.Clear()
                llenaGrid()
                btn_modifica.Enabled = False
                btn_elimina.Enabled = False
            Else
                MessageBox.Show("Error al editar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe de llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_elimina_Click(sender As Object, e As EventArgs) Handles btn_elimina.Click
        Try
            If txtNom.Text <> vbNullString Then
                dts.gId = lbl_clave.Text
                If farea.eliminar(dts) Then
                    MessageBox.Show("Se elimino con exito", "Eliminado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNom.Clear()
                    lbl_clave.Text = String.Empty
                    llenaGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        lbl_clave.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtNom.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        btn_modifica.Enabled = True
        btn_elimina.Enabled = True
        txtNom.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        txtNom.Clear()
        txtNom.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        txtNom.Enabled = True
        txtNom.Focus()
    End Sub
End Class
