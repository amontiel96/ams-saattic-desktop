Public Class frmInformaticos
    Dim llamar As New clsValidar
    Dim fpersonas As New fPersonas
    Dim dts As New vPersonas
    Dim recibe As DataTable
    Public ds As DataSet
    Dim cad As String
    Dim fecha As Date
    Dim recibeemail As String
    Dim id_info As String

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        llamar.nombre = txtNombre.Text
        txtNombre.Text = llamar.nombre
    End Sub

    Private Sub txtApellidos_Leave(sender As Object, e As EventArgs) Handles txtApePat.Leave
        llamar.Apellidos = txtApePat.Text
        txtApePat.Text = llamar.Apellidos
    End Sub

    Private Sub txtTel_Leave(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        llamar.Correo = txtEmail.Text
        txtEmail.Text = llamar.Correo
    End Sub
    Public Sub llenaGrid()
        Dim cad As String = "select intId_area as IdArea,vchArea as Area from tbl_areasConocimiento"
        recibe = fpersonas.mostrar(cad)
        tablaAreas.DataSource = recibe
    End Sub
    Public Sub llenaGridAdministradores()
        Dim cad As String = "select tbl_personas.intId_persona as Id_persona, vchNombre as Nombre,vchAPaterno as Apellido_Paterno,vchAMaterno as Apellido_Materno,intId_municipo as IdMunicipio,vchCorreo as Correo,intId_tUser as T_Usuario,vchUsuario as Usuario,vchPwd as Contraseña,dtFRegis as Fecha_registro from tbl_personas where intId_tUser = 1"

        recibe = fpersonas.mostrar(cad)
        tablaAdmin.DataSource = recibe
    End Sub
    Public Sub llenarInformaticos()
        Dim cad As String = "select tbl_personas.intId_persona as Id_persona, tbl_personas.vchNombre as Nombre,tbl_personas.vchAPaterno as Apellido_Paterno, tbl_personas.vchAMaterno as Apellido_Materno,tbl_personas.intId_municipo as IdMunicipio,tbl_personas.vchCorreo as Correo,tbl_personas.intId_tUser as T_Usuario,tbl_personas.vchUsuario as Usuario,tbl_personas.vchPwd as Contraseña, tbl_personas.dtFRegis as Fecha_registro, intStatus as Estatus from tbl_informaticos inner join tbl_personas on tbl_informaticos.intId_persona = tbl_personas.intId_persona inner join tbl_municipios on tbl_personas.intId_municipo = tbl_municipios.intId_municipo inner join tbl_tUser on tbl_personas.intId_tUser = tbl_tUser.intId_tUser where intStatus = 1"
        recibe = fpersonas.mostrar(cad)
        tablaInfor.DataSource = recibe
    End Sub
    Public Sub llenarClientes()
        Dim cad As String = "select tbl_personas.intId_persona as Id_persona, tbl_personas.vchNombre as Nombre,tbl_personas.vchAPaterno as Apellido_Paterno, tbl_personas.vchAMaterno as Apellido_Materno,tbl_personas.intId_municipo as IdMunicipio,tbl_personas.vchCorreo as Correo,tbl_personas.intId_tUser as T_Usuario,tbl_personas.vchUsuario as Usuario,tbl_personas.vchPwd as Contraseña, tbl_personas.dtFRegis as Fecha_registro, intStatus as Estatus from tbl_clientes inner join tbl_personas on tbl_clientes.intId_persona = tbl_personas.intId_persona inner join tbl_municipios on tbl_personas.intId_municipo = tbl_municipios.intId_municipo inner join tbl_tUser on tbl_personas.intId_tUser = tbl_tUser.intId_tUser where intStatus = 1"
        recibe = fpersonas.mostrar(cad)
        tablaClientes.DataSource = recibe
    End Sub

    Private Sub frmInformaticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_clave.Visible = True
        llenaGrid()
        llenaGridAdministradores()
        llenarInformaticos()
        llenarClientes()
        cad = "SELECT intId_municipo, vchMunicipio FROM tbl_municipios"
        ds = clsPrincipal.consultaDSSQL(cad)
        cmbMunicipio.DataSource = ds.Tables(0)
        cmbMunicipio.DisplayMember = "vchMunicipio"
        cmbMunicipio.ValueMember = "intId_municipo"

        cad = "SELECT intId_tUser, vchTipoUser FROM tbl_tUser"
        ds = clsPrincipal.consultaDSSQL(cad)
        cmbTipoUsua.DataSource = ds.Tables(0)
        cmbTipoUsua.DisplayMember = "vchTipoUser"
        cmbTipoUsua.ValueMember = "intId_tUser"

    End Sub

    Private Sub cmbTipoUsua_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoUsua.TextChanged
        If cmbTipoUsua.Text = "Informatico" Then
            gbArea.Enabled = True
        ElseIf cmbTipoUsua.Text <> "Informatico" Then
            gbArea.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If cmbTipoUsua.Text = "Administrador" Or cmbTipoUsua.Text = "Cliente" Then
            guardar()
        ElseIf cmbTipoUsua.Text = "Informatico" Then
            guardar()
            btnAgregar.Enabled = True
            cad = "select max(intId_informatico) from tbl_informaticos"
            ds = clsPrincipal.consultaDSSQL(cad)
            Dim id As String = ds.Tables(0).Rows(0).Item(0)
            Dim tam As Integer = tablaAreasRecibe.RowCount - 1
            Dim i As Integer = 0
            While (i < tam)
                cad = "insert into tbl_detConocimiento(intId_informatico,intId_area)values('" + id.ToString() + "','" + tablaAreasRecibe.Rows(i).Cells(0).Value.ToString() + "')"
                clsPrincipal.comandosSQL(cad)
                i = i + 1
            End While
            limpiar(2)
            btnAgregar.Enabled = False
            btnCancelar.Enabled = False
            btnNuevo.Enabled = True
            txtNombre.Enabled = False
            txtApePat.Enabled = False
            txtApeMat.Enabled = False
            cbxTipoCOrreo.Enabled = False
            cmbMunicipio.Enabled = False
            cmbTipoUsua.Enabled = False
            txtComfirPass.Enabled = False
            txtPass.Enabled = False
            txtEmail.Enabled = False
            gbArea.Enabled = False
        End If

    End Sub
    Public Sub guardar()
        fecha = dtpFecha.Value.ToString("yyyyy-MM-dd")
        If txtPass.Text = txtComfirPass.Text Then
            Try
                Dim cor As String = txtEmail.Text + cbxTipoCOrreo.Text
                If txtNombre.Text <> vbNullString Then
                    dts.gNombre = txtNombre.Text
                    dts.gAP = txtApePat.Text
                    dts.gAM = txtApeMat.Text
                    dts.gIdMun = cmbMunicipio.SelectedValue.ToString()
                    dts.gCorreo = cor
                    dts.gIdtUser = cmbTipoUsua.SelectedValue.ToString()
                    dts.gUser = txtUsuario.Text
                    dts.gPwd = txtPass.Text
                    dts.gFecha = fecha
                    If fpersonas.insertar(dts) Then
                        txtNombre.Clear()
                        llenaGrid()
                        llenarClientes()
                        llenarInformaticos()
                        llenaGridAdministradores()
                        tablaAreasRecibe.Rows.Clear()
                        btnGuardar.Enabled = False
                        txtUsuario.Enabled = False
                        MessageBox.Show("Se guardo con exito", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se guardo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    limpiar(1)
                Else
                    MessageBox.Show("Debe llenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Verifique las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub llenarArea()
        cad = "select tbl_detConocimiento.intId_area, tbl_areasConocimiento.vchArea from tbl_detConocimiento inner join tbl_areasConocimiento on tbl_detConocimiento.intId_area = tbl_areasConocimiento.intId_area where intId_informatico = '" + lbl_clave.Text + "'"
        recibe = fpersonas.mostrar(cad)
        tablaAreasRecibe.DataSource = recibe

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        tablaAreasRecibe.ColumnCount = 2
        tablaAreasRecibe.Rows.Add(tablaAreas.CurrentRow.Cells(0).Value, tablaAreas.CurrentRow.Cells(1).Value)
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            tablaAreasRecibe.Rows.RemoveAt(tablaAreasRecibe.CurrentRow.Index)
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar fila del sistema", "No hay nada que borrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub IdInfo()
        cad = "select intId_informatico from tbl_informaticos where intId_persona = '" + lbl_clave.Text + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        id_info = ds.Tables(0).Rows(0).Item(0)
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNombre.Text <> vbNullString Then
            dts.gId = lbl_clave.Text
            dts.gNombre = txtNombre.Text
            dts.gAP = txtApePat.Text
            dts.gAM = txtApeMat.Text
            dts.gIdMun = cmbMunicipio.SelectedValue.ToString()
            dts.gIdtUser = cmbTipoUsua.SelectedValue.ToString()
            dts.gCorreo = txtEmail.Text
            dts.gUser = txtUsuario.Text
            dts.gPwd = txtPass.Text
            dts.gFecha = dtpFecha.Value.Date

            If fpersonas.editar(dts) Then
                MessageBox.Show("Se edito correctamente", "Editado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                llenaGrid()
                llenarInformaticos()
                llenaGridAdministradores()
                llenarClientes()
                campos(2)
                tablaAreasRecibe.Rows.Clear()
                If cmbTipoUsua.Text = "Informatico" Then
                    IdInfo()
                    cad = "delete tbl_detConocimiento where intId_informatico = '" + id_info + "'"
                    clsPrincipal.comandosSQL(cad)
                    Dim tam As Integer = tablaAreasRecibe.RowCount - 1
                    Dim i As Integer = 0
                    While (i < tam)
                        cad = "insert into tbl_detConocimiento(intId_informatico,intId_area)values('" + lbl_clave.Text + "','" + tablaAreasRecibe.Rows(i).Cells(0).Value.ToString() + "')"
                        clsPrincipal.comandosSQL(cad)
                        i = i + 1
                    End While
                    limpiar(2)
                    botones(2)
                Else
                    MessageBox.Show("Error al editar", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Debe de llenar los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            limpiar(1)
        End If
    End Sub

    Private Sub tablaPersonas_Click(sender As Object, e As EventArgs) Handles tablaAdmin.Click
        Try
            lbl_clave.Text = tablaAdmin.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = tablaAdmin.CurrentRow.Cells(1).Value.ToString
            txtApePat.Text = tablaAdmin.CurrentRow.Cells(2).Value.ToString
            txtApeMat.Text = tablaAdmin.CurrentRow.Cells(3).Value.ToString
            cmbMunicipio.SelectedValue = tablaAdmin.CurrentRow.Cells(4).Value.ToString()
            recibeemail = tablaAdmin.CurrentRow.Cells(5).Value.ToString
            Dim partir() As String = recibeemail.Split("@")
            Dim correo As String = partir(0).ToString()
            txtEmail.Text = correo
            cmbTipoUsua.SelectedValue = tablaAdmin.CurrentRow.Cells(6).Value.ToString()
            txtUsuario.Text = tablaAdmin.CurrentRow.Cells(7).Value.ToString
            txtPass.Text = tablaAdmin.CurrentRow.Cells(8).Value.ToString
            botones(1)
            campos(1)
        Catch ex As Exception
            MessageBox.Show("La fila no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            dts.gId = lbl_clave.Text
            If cmbTipoUsua.Text = "Administrador" Then
                If fpersonas.eliminarAdmi(dts) Then
                    MessageBox.Show("Se elimino correctamente", "Eliminado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    botones(2)
                Else
                    MessageBox.Show("Error al eliminar", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf cmbTipoUsua.Text = "Informatico" Then
                dts.gId_info = tablaInfor.CurrentRow.Cells(0).Value.ToString
                If fpersonas.eliminarInfo(dts) Then
                    MessageBox.Show("Se elimino correctamente", "Eliminado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar(2)
                    botones(2)
                Else
                    MessageBox.Show("Error al eliminar", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf cmbTipoUsua.Text = "Cliente" Then
                dts.gId_clie = tablaClientes.CurrentRow.Cells(0).Value.ToString
                If fpersonas.eliminarClien(dts) Then
                    MessageBox.Show("Se elimino correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    botones(2)
                Else
                    MessageBox.Show("Error al eliminar", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            llenaGrid()
            llenarClientes()
            llenarInformaticos()
            llenaGridAdministradores()
            limpiar(1)
        Catch ex As Exception

        End Try
        btnNuevo.Enabled = True
    End Sub

    Private Sub tablaInfor_Click(sender As Object, e As EventArgs) Handles tablaInfor.Click
        Try
            lbl_clave.Text = tablaInfor.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = tablaInfor.CurrentRow.Cells(1).Value.ToString
            txtApePat.Text = tablaInfor.CurrentRow.Cells(2).Value.ToString
            txtApeMat.Text = tablaInfor.CurrentRow.Cells(3).Value.ToString
            cmbMunicipio.SelectedValue = tablaInfor.CurrentRow.Cells(4).Value.ToString()
            recibeemail = tablaInfor.CurrentRow.Cells(5).Value.ToString
            Dim partir() As String = recibeemail.Split("@")
            Dim correo As String = partir(0).ToString()
            txtEmail.Text = correo
            cmbTipoUsua.SelectedValue = tablaInfor.CurrentRow.Cells(6).Value.ToString()
            txtUsuario.Text = tablaInfor.CurrentRow.Cells(7).Value.ToString
            txtPass.Text = tablaInfor.CurrentRow.Cells(8).Value.ToString
            botones(1)
            campos(1)
            btnAgregar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("La fila no existe", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub tablaClientes_Click(sender As Object, e As EventArgs) Handles tablaClientes.Click
        Try
            lbl_clave.Text = tablaClientes.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = tablaClientes.CurrentRow.Cells(1).Value.ToString
            txtApePat.Text = tablaClientes.CurrentRow.Cells(2).Value.ToString
            txtApeMat.Text = tablaClientes.CurrentRow.Cells(3).Value.ToString
            cmbMunicipio.SelectedValue = tablaClientes.CurrentRow.Cells(4).Value.ToString()
            recibeemail = tablaClientes.CurrentRow.Cells(5).Value.ToString
            Dim partir() As String = recibeemail.Split("@")
            Dim correo As String = partir(0).ToString()
            txtEmail.Text = correo
            cmbTipoUsua.SelectedValue = tablaClientes.CurrentRow.Cells(6).Value.ToString()
            txtUsuario.Text = tablaClientes.CurrentRow.Cells(7).Value.ToString
            txtPass.Text = tablaClientes.CurrentRow.Cells(8).Value.ToString
            botones(1)
            campos(1)


        Catch ex As Exception
            MessageBox.Show("La fila no existe", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub campos(ByVal op As Integer)
        Select Case (op)
            Case 1
                txtNombre.Enabled = True
                txtApePat.Enabled = True
                txtApeMat.Enabled = True
                txtEmail.Enabled = True
                cbxTipoCOrreo.Enabled = True
                txtPass.Enabled = True
                txtUsuario.Enabled = True
                txtComfirPass.Enabled = True
                cmbMunicipio.Enabled = True
                cmbTipoUsua.Enabled = True
                dtpFecha.Enabled = True
            Case 2
                txtNombre.Enabled = False
                txtApePat.Enabled = False
                txtApeMat.Enabled = False
                txtEmail.Enabled = False
                cbxTipoCOrreo.Enabled = False
                txtPass.Enabled = False
                txtUsuario.Enabled = False
                txtComfirPass.Enabled = False
                cmbMunicipio.Enabled = False
                cmbTipoUsua.Enabled = False
                dtpFecha.Enabled = False
        End Select
       
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        gbxDatos.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False

        campos(1)

        limpiar(1)
        txtNombre.Focus()
    End Sub
    Private Sub limpiar(ByVal opc As Integer)
        Select Case (opc)
            Case 1
                txtNombre.Clear()
                txtApeMat.Clear()
                txtApePat.Clear()
                txtEmail.Clear()
                txtUsuario.Clear()
                txtPass.Clear()
                txtComfirPass.Clear()
                lbl_clave.Text = ""
            Case 2
                tablaAreasRecibe.Rows.Clear()

        End Select

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        txtNombre.Enabled = False
        txtApePat.Enabled = False
        txtApeMat.Enabled = False
        txtEmail.Enabled = False
        cbxTipoCOrreo.Enabled = False
        txtPass.Enabled = False
        txtUsuario.Enabled = False
        txtComfirPass.Enabled = False
        cmbMunicipio.Enabled = False
        cmbTipoUsua.Enabled = False
        dtpFecha.Enabled = False
        limpiar(1)
        limpiar(2)
    End Sub
    Private Sub botones(ByVal op As Integer)
        Select Case (op)
            Case 1
                btnGuardar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True
                btnModificar.Enabled = True
            Case 2
                btnGuardar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = False
                btnModificar.Enabled = False
        End Select
        
    End Sub
End Class
