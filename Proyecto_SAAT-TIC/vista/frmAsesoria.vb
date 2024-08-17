Public Class frmAsesoria
    Dim llamar As New clsValidar
    Dim faseso As New fAsesoria
    Dim dts As New vAsesoria
    Dim recibe As DataTable
    Public ds As DataSet
    Dim cad As String
    Public recibeID As String
    Dim id_cliente As Integer
    Private Sub txtAsesoria_Leave(sender As Object, e As EventArgs) Handles txtAsesoria.Leave
        llamar.nombreI = txtAsesoria.Text
        txtAsesoria.Text = llamar.nombreI
    End Sub
    Private Sub txtDes_Leave(sender As Object, e As EventArgs) Handles txtDes.Leave
        llamar.DescripcionI = txtDes.Text
        txtDes.Text = llamar.DescripcionI
    End Sub
    Public Sub llenaGrid()
        Cliente()
        Dim cad As String = "select intId_asesoria as Id_Asesoria, vchTema as Tema, vchDescripcion as Descripcion, intStatus as Estado from tbl_asesorias where intId_cliente ='" + id_cliente.ToString() + "'"
        recibe = faseso.mostrar(cad)
        tablaAsesoria.DataSource = recibe
    End Sub
    Private Sub Cliente()
        cad = "select intId_cliente from tbl_clientes where intId_persona = '" + recibeID + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        id_cliente = ds.Tables(0).Rows(0).Item(0)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtAsesoria.Text <> vbNullString Then
                Cliente()
                dts.gId_clie = id_cliente
                dts.gTema = txtAsesoria.Text
                dts.gDesc = txtDes.Text
                If faseso.insertar(dts) Then
                    MessageBox.Show("Se guardo con exito", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAsesoria.Clear()
                    btnGuardar.Enabled = False
                    btnCancelar.Enabled = False
                    btnNuevo.Enabled = True
                    txtDes.Clear()
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtAsesoria.Text <> vbNullString Then
            dts.gId = lblClave.Text
            dts.gTema = txtAsesoria.Text
            dts.gDesc = txtDes.Text
            If faseso.editar(dts) Then
                MessageBox.Show("Se edito correctamente", "Editado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAsesoria.Clear()
                txtDes.Clear()
                btnModificar.Enabled = False
                txtAsesoria.Enabled = False
                txtDes.Enabled = False
                llenaGrid()
            Else
                MessageBox.Show("Error al editar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe de llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmAsesoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
        lblClave.Text = recibeID
    End Sub

    Private Sub tablaAsesoria_Click(sender As Object, e As EventArgs) Handles tablaAsesoria.Click
        lblClave.Text = tablaAsesoria.CurrentRow.Cells(0).Value.ToString
        txtAsesoria.Text = tablaAsesoria.CurrentRow.Cells(1).Value.ToString
        txtDes.Text = tablaAsesoria.CurrentRow.Cells(2).Value.ToString()
        btnModificar.Enabled = True
        txtAsesoria.Enabled = True
        txtDes.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        txtAsesoria.Enabled = True
        txtDes.Enabled = True
        txtAsesoria.Focus()
    End Sub
End Class
