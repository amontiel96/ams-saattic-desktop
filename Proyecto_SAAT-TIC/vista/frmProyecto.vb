Public Class frmProyecto
    Dim llamar As New clsValidar
    Public recibeIDpersona As String
    Public ds As DataSet
    Dim cad As String
    Dim recibe As DataTable
    Dim fProye As New fProyecto
    Dim dts As New vProyecto
    Dim id_cliente As Integer
    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        llamar.nombreI = txtNombre.Text
        txtNombre.Text = llamar.nombreI
    End Sub

    Private Sub txtDes_Leave(sender As Object, e As EventArgs) Handles txtDes.Leave
        llamar.DescripcionI = txtDes.Text
        txtDes.Text = llamar.DescripcionI
    End Sub
    Public Sub llenaGrid()
        Cliente()
        cad = "select intId_proyecto as Id_Proyecto, vchNombrePrj as Nombre, intId_tProyecto as Tipo_Proyecto, vchDescripcion as Descripcion, intStatus as Estado from tbl_proyecto where intId_cliente ='" + id_cliente.ToString() + "'"
        recibe = fProye.mostrar(cad)
        tablaProyecto.DataSource = recibe
    End Sub
    Private Sub frmProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
        cad = "SELECT intId_tProyecto, vchTipo FROM tbl_tProyecto"
        ds = clsPrincipal.consultaDSSQL(cad)
        cbxTipoProyecto.DataSource = ds.Tables(0)
        cbxTipoProyecto.DisplayMember = "vchTipo"
        cbxTipoProyecto.ValueMember = "intId_tProyecto"
    End Sub
    Private Sub Cliente()
        cad = "select intId_cliente from tbl_clientes where intId_persona = '" + recibeIDpersona + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        id_cliente = ds.Tables(0).Rows(0).Item(0)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNombre.Text <> vbNullString Then
                Cliente()
                dts.gNombre = txtNombre.Text
                dts.gDescr = txtDes.Text
                dts.gIdTipo = cbxTipoProyecto.SelectedValue.ToString()
                dts.gCliente = id_cliente

                If fProye.insertar(dts) Then
                    MessageBox.Show("Se guardo con exito", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNombre.Clear()
                    txtDes.Clear()
                    cbxTipoProyecto.Text = ""
                    btnGuardar.Enabled = False
                    btnCancelar.Enabled = False
                    btnNuevo.Enabled = True
                    txtNombre.Enabled = False
                    txtDes.Enabled = False
                    cbxTipoProyecto.Enabled = False
                    llenaGrid()
                Else
                    MessageBox.Show("Error al guadar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNombre.Text <> vbNullString Then
            Cliente()
            dts.gProyecto = lblClave.Text
            dts.gCliente = id_cliente
            dts.gNombre = txtNombre.Text
            dts.gIdTipo = cbxTipoProyecto.SelectedValue.ToString()
            dts.gDescr = txtDes.Text
            If fProye.editar(dts) Then
                MessageBox.Show("Se edito correctamente", "Editado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombre.Clear()
                txtDes.Clear()
                cbxTipoProyecto.Text = ""
                btnEditar.Enabled = False
                txtNombre.Enabled = False
                txtDes.Enabled = False
                cbxTipoProyecto.Enabled = False
                llenaGrid()
            Else
                MessageBox.Show("Error al editar", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe de llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tablaProyecto_Click(sender As Object, e As EventArgs) Handles tablaProyecto.Click
        lblClave.Text = tablaProyecto.CurrentRow.Cells(0).Value.ToString()
        txtNombre.Text = tablaProyecto.CurrentRow.Cells(1).Value.ToString()
        cbxTipoProyecto.SelectedValue = tablaProyecto.CurrentRow.Cells(2).Value.ToString()
        txtDes.Text = tablaProyecto.CurrentRow.Cells(3).Value.ToString()

        btnEditar.Enabled = True
        txtNombre.Enabled = True
        txtDes.Enabled = True
        cbxTipoProyecto.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        txtNombre.Enabled = True
        txtDes.Enabled = True
        cbxTipoProyecto.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        txtNombre.Enabled = False
        txtDes.Enabled = False
        cbxTipoProyecto.Enabled = False
        txtNombre.Clear()
        txtDes.Clear()
        cbxTipoProyecto.Text = ""
    End Sub
End Class
