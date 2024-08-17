Public Class frmLogin
    Dim llamar As New clsValidar
    Dim LLamForm As New frmPrincipal
    Dim tipoUser As String
    Dim idpersona As String
    Dim fu As New fUsuario
    Dim vu As New vUsuario
    Public ds As DataSet
    Dim cad As String
    Public id As String
    Public nom As String
    Dim contador As Integer = 0
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
      
        If Not (txtUsuario.Text = "" Or txtPassword.Text = "") Then
            Try
                Dim dt As New DataTable
                vu._users = txtUsuario.Text
                vu._pass = txtPassword.Text

                dt = fu.validarusuario(vu)

                If dt.Rows.Count > 0 Then
                    obtenerID()
                    obtenerNombre()
                    Timer1.Start()
                    Dim nivel As String
                    nivel = dt.Rows(0)("IntId_tUser")
                    If nivel = "1" Then
                        My.Forms.frmPrincipal.AdministradorToolStripMenuItem.Enabled = True
                        My.Forms.frmPrincipal.imgAdmin.Visible = True
                    ElseIf nivel = "2" Then
                        My.Forms.frmPrincipal.InformaticoToolStripMenuItem.Enabled = True
                        My.Forms.frmProyectos.recibeIDInfo = id
                        My.Forms.frmAsesorias.recibeIDInfo = id
                        My.Forms.frmPrincipal.imgInformatico.Visible = True
                    ElseIf nivel = "3" Then
                        My.Forms.frmPrincipal.UsuarioToolStripMenuItem.Enabled = True
                        My.Forms.frmProyecto.recibeIDpersona = id
                        My.Forms.frmAsesoria.recibeID = id
                        My.Forms.frmPrincipal.imgCliente.Visible = True
                    End If
                Else
                    MessageBox.Show("Error de ususario ó contraseña", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    contador = contador + 1
                    If contador = 3 Then
                        frmErrorUsuario.ShowDialog()
                    End If
                    txtPassword.Clear()
                    txtUsuario.Clear()
                    txtUsuario.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("error de usuario o contraseña", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("Verificar que esten llenos todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Sub obtenerID()
        cad = "select intId_persona,vchUsuario from tbl_personas where vchPwd='" + txtPassword.Text + "' and vchUsuario='" + txtUsuario.Text + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        cbxclave.DataSource = ds.Tables(0)
        cbxclave.DisplayMember = "intId_persona"
        cbxclave.ValueMember = "intId_persona"
        lblclave.Text = cbxclave.SelectedValue.ToString()
        id = lblclave.Text
    End Sub
    Sub obtenerNombre()
        cad = "select intId_persona,vchNombre from tbl_personas where vchPwd='" + txtPassword.Text + "' and vchUsuario='" + txtUsuario.Text + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        cbxNombre.DataSource = ds.Tables(0)
        cbxNombre.DisplayMember = "vchNombre"
        cbxNombre.ValueMember = "intId_persona"
        lblnombre.Text = cbxNombre.SelectedValue.ToString()
        nom = lblnombre.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            My.Forms.frmPrincipal.recibeNombre = cbxNombre.Text
            MessageBox.Show("Bienvenido a SAAT-TIC ", txtUsuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As DialogResult
        res = MessageBox.Show("Desea salir", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class