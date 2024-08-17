Public Class frmTipodeServicio
    Dim llamar As New clsValidar
    Dim fTipo As New fTproyecto
    Dim dts As New vTipo
    Dim recibe As DataTable
    Private Sub txtNom_Leave(sender As Object, e As EventArgs) Handles txtNom.Leave
        llamar.nombreI = txtNom.Text
        txtNom.Text = llamar.nombreI
    End Sub

    Private Sub txtDes_Leave(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub frmTipodeServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Public Sub llenaGrid()
        Dim cad As String = "select intId_tProyecto as Clave,vchTipo as Tipo from tbl_tProyecto"
        recibe = fTipo.mostrar(cad)
        dgvTipoP.DataSource = recibe
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNom.Text <> vbNullString Then
                dts.gTipo = txtNom.Text
                If fTipo.insertar(dts) Then
                    MessageBox.Show("Se guardo con exito", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNom.Clear()

                    llenaGrid()
                Else
                    MessageBox.Show("No se guardo", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNom.Text <> vbNullString Then
            dts.gId = lbl_Clave.Text
            dts.gTipo = txtNom.Text
            If fTipo.editar(dts) Then
                MessageBox.Show("Se edito correctamente", "Editado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNom.Clear()
                txtNom.Enabled = False
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                llenaGrid()
            Else
                MessageBox.Show("Error al editar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe de llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvTipoP_Click(sender As Object, e As EventArgs) Handles dgvTipoP.Click
        lbl_Clave.Text = dgvTipoP.CurrentRow.Cells(0).Value.ToString
        txtNom.Text = dgvTipoP.CurrentRow.Cells(1).Value.ToString
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        txtNom.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtNom.Text <> vbNullString Then
                dts.gId = lbl_Clave.Text
                If fTipo.eliminar(dts) Then
                    MessageBox.Show("Se elimino con exito", "Eliminado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNom.Clear()
                    txtNom.Enabled = False
                    btnEliminar.Enabled = False
                    btnModificar.Enabled = False
                    lbl_Clave.Text = String.Empty
                    llenaGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        txtNom.Enabled = True
        txtNom.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        txtNom.Clear()
        txtNom.Enabled = False
    End Sub
End Class
