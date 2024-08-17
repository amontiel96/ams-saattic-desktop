Public Class frmPrincipal
    'Dim llamar As New clsValidar
    Public recibeNombre As String
    Private Sub RegistrarNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInformaticos.ShowDialog()

    End Sub

    Private Sub NuevaAreaDeConocimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmAreadeConocimiento.ShowDialog()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmTipodeServicio.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
       

    End Sub

    Private Sub ProyectoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProyectoToolStripMenuItem1.Click
        frmProyecto.ShowDialog()
    End Sub

    Private Sub AsesoriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsesoriaToolStripMenuItem1.Click
        frmAsesoria.ShowDialog()
    End Sub

    Private Sub AvisosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmAvisos.ShowDialog()
    End Sub

    Private Sub AsesoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsesoriasToolStripMenuItem.Click
        frmAsesorias.ShowDialog()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmEditarPerfil.ShowDialog()
    End Sub

    Private Sub ProyectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProyectosToolStripMenuItem.Click
        frmProyectos.ShowDialog()
    End Sub

    Private Sub SubirArchivosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmSubirArchivo.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = recibeNombre
    End Sub

    Private Sub InformaticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaticosToolStripMenuItem.Click
        frmInformaticos.ShowDialog()
    End Sub

    Private Sub AreasDeConocimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreasDeConocimientoToolStripMenuItem.Click
        frmAreadeConocimiento.ShowDialog()
    End Sub

    Private Sub ProyectosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProyectosToolStripMenuItem1.Click
        frmTipodeServicio.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcerca.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("Desea salir del sistema", "Responda la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Hasta luego", "SAAT-TIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Else
            MessageBox.Show("Gracis por seguir en el sistema", "SAAT-TIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CerrarCesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCesiónToolStripMenuItem.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("Desea cerrar sesión", "Responda la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            frmLogin.Show()
            My.Forms.frmLogin.txtUsuario.Clear()
            My.Forms.frmLogin.txtPassword.Clear()
            My.Forms.frmLogin.txtUsuario.Focus()
            My.Forms.frmLogin.cbxclave.Text = ""
            My.Forms.frmLogin.cbxNombre.Text = ""
            AdministradorToolStripMenuItem.Enabled = False
            InformaticoToolStripMenuItem.Enabled = False
            UsuarioToolStripMenuItem.Enabled = False
        Else
            MessageBox.Show("Gracias por seguir en el sistema", "SAAT-TIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        formClientesReport.ShowDialog()
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        frmManual.ShowDialog()
    End Sub

    Private Sub InformaticosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InformaticosToolStripMenuItem1.Click
        formInforRepor.ShowDialog()
    End Sub

    Private Sub AreasDeConocimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AreasDeConocimientoToolStripMenuItem1.Click
        formProyectosrepor.ShowDialog()
    End Sub

    Private Sub AsesoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsesoríasToolStripMenuItem.Click
        formProyectosrepor.ShowDialog()
    End Sub
End Class