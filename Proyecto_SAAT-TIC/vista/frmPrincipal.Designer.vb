<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsesoriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsesoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasDeConocimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaticosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasDeConocimientoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsesoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.imgAdmin = New System.Windows.Forms.PictureBox()
        Me.imgInformatico = New System.Windows.Forms.PictureBox()
        Me.imgCliente = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgInformatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.MenuStrip1.BackgroundImage = Global.Proyecto_SAAT_TIC.My.Resources.Resources._1
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.InformaticoToolStripMenuItem, Me.AdministradorToolStripMenuItem, Me.ToolStripMenuItem2, Me.ManualDeUsuarioToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1107, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 25)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarCesiónToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SalirToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.gohome
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(97, 25)
        Me.SalirToolStripMenuItem.Text = "Archivo"
        '
        'CerrarCesiónToolStripMenuItem
        '
        Me.CerrarCesiónToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.cerrar_cuenta
        Me.CerrarCesiónToolStripMenuItem.Name = "CerrarCesiónToolStripMenuItem"
        Me.CerrarCesiónToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.CerrarCesiónToolStripMenuItem.Text = "Cerrar cesión"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.salir1
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(179, 26)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectoToolStripMenuItem1, Me.AsesoriaToolStripMenuItem1})
        Me.UsuarioToolStripMenuItem.Enabled = False
        Me.UsuarioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.UsuarioToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.mnuClientes
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(97, 25)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ProyectoToolStripMenuItem1
        '
        Me.ProyectoToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.modificar
        Me.ProyectoToolStripMenuItem1.Name = "ProyectoToolStripMenuItem1"
        Me.ProyectoToolStripMenuItem1.Size = New System.Drawing.Size(148, 26)
        Me.ProyectoToolStripMenuItem1.Text = "Proyecto"
        '
        'AsesoriaToolStripMenuItem1
        '
        Me.AsesoriaToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.icono_alumno
        Me.AsesoriaToolStripMenuItem1.Name = "AsesoriaToolStripMenuItem1"
        Me.AsesoriaToolStripMenuItem1.Size = New System.Drawing.Size(148, 26)
        Me.AsesoriaToolStripMenuItem1.Text = "Asesoria"
        '
        'InformaticoToolStripMenuItem
        '
        Me.InformaticoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsesoriasToolStripMenuItem, Me.ProyectosToolStripMenuItem})
        Me.InformaticoToolStripMenuItem.Enabled = False
        Me.InformaticoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformaticoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.InformaticoToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.Secuty_agent
        Me.InformaticoToolStripMenuItem.Name = "InformaticoToolStripMenuItem"
        Me.InformaticoToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.InformaticoToolStripMenuItem.Text = "Informatico"
        '
        'AsesoriasToolStripMenuItem
        '
        Me.AsesoriasToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.Einstein__1_
        Me.AsesoriasToolStripMenuItem.Name = "AsesoriasToolStripMenuItem"
        Me.AsesoriasToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.AsesoriasToolStripMenuItem.Text = "Asesorias"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.pc1
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaticosToolStripMenuItem, Me.AreasDeConocimientoToolStripMenuItem, Me.ReportesToolStripMenuItem1, Me.ProyectosToolStripMenuItem1})
        Me.AdministradorToolStripMenuItem.Enabled = False
        Me.AdministradorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministradorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AdministradorToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.tester
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(148, 25)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'InformaticosToolStripMenuItem
        '
        Me.InformaticosToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.people_md
        Me.InformaticosToolStripMenuItem.Name = "InformaticosToolStripMenuItem"
        Me.InformaticosToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.InformaticosToolStripMenuItem.Text = "Personas"
        '
        'AreasDeConocimientoToolStripMenuItem
        '
        Me.AreasDeConocimientoToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.folder_fonts_512
        Me.AreasDeConocimientoToolStripMenuItem.Name = "AreasDeConocimientoToolStripMenuItem"
        Me.AreasDeConocimientoToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.AreasDeConocimientoToolStripMenuItem.Text = "Areas de conocimiento"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.InformaticosToolStripMenuItem1, Me.AreasDeConocimientoToolStripMenuItem1, Me.AsesoríasToolStripMenuItem})
        Me.ReportesToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.reportes
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(255, 26)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.report_user
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'InformaticosToolStripMenuItem1
        '
        Me.InformaticosToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.business_user_help
        Me.InformaticosToolStripMenuItem1.Name = "InformaticosToolStripMenuItem1"
        Me.InformaticosToolStripMenuItem1.Size = New System.Drawing.Size(177, 26)
        Me.InformaticosToolStripMenuItem1.Text = "Informaticos"
        '
        'AreasDeConocimientoToolStripMenuItem1
        '
        Me.AreasDeConocimientoToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.book_help
        Me.AreasDeConocimientoToolStripMenuItem1.Name = "AreasDeConocimientoToolStripMenuItem1"
        Me.AreasDeConocimientoToolStripMenuItem1.Size = New System.Drawing.Size(177, 26)
        Me.AreasDeConocimientoToolStripMenuItem1.Text = "Proyectos"
        '
        'AsesoríasToolStripMenuItem
        '
        Me.AsesoríasToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.document
        Me.AsesoríasToolStripMenuItem.Name = "AsesoríasToolStripMenuItem"
        Me.AsesoríasToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.AsesoríasToolStripMenuItem.Text = "Asesorías"
        '
        'ProyectosToolStripMenuItem1
        '
        Me.ProyectosToolStripMenuItem1.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.NotePad
        Me.ProyectosToolStripMenuItem1.Name = "ProyectosToolStripMenuItem1"
        Me.ProyectosToolStripMenuItem1.Size = New System.Drawing.Size(255, 26)
        Me.ProyectosToolStripMenuItem1.Text = "Proyectos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 25)
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ManualDeUsuarioToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.book_info
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 25)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AcercaDeToolStripMenuItem.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.help
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(224, 58)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(117, 37)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label1"
        Me.lblNombre.Visible = False
        '
        'imgAdmin
        '
        Me.imgAdmin.BackColor = System.Drawing.Color.Transparent
        Me.imgAdmin.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.pc1
        Me.imgAdmin.Location = New System.Drawing.Point(12, 47)
        Me.imgAdmin.Name = "imgAdmin"
        Me.imgAdmin.Size = New System.Drawing.Size(197, 127)
        Me.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAdmin.TabIndex = 2
        Me.imgAdmin.TabStop = False
        Me.imgAdmin.Visible = False
        '
        'imgInformatico
        '
        Me.imgInformatico.BackColor = System.Drawing.Color.Transparent
        Me.imgInformatico.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.Einstein__1_
        Me.imgInformatico.Location = New System.Drawing.Point(12, 47)
        Me.imgInformatico.Name = "imgInformatico"
        Me.imgInformatico.Size = New System.Drawing.Size(197, 127)
        Me.imgInformatico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInformatico.TabIndex = 3
        Me.imgInformatico.TabStop = False
        Me.imgInformatico.Visible = False
        '
        'imgCliente
        '
        Me.imgCliente.BackColor = System.Drawing.Color.Transparent
        Me.imgCliente.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.f41ef2f2
        Me.imgCliente.Location = New System.Drawing.Point(12, 47)
        Me.imgCliente.Name = "imgCliente"
        Me.imgCliente.Size = New System.Drawing.Size(197, 127)
        Me.imgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCliente.TabIndex = 4
        Me.imgCliente.TabStop = False
        Me.imgCliente.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Proyecto_SAAT_TIC.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1107, 508)
        Me.Controls.Add(Me.imgCliente)
        Me.Controls.Add(Me.imgInformatico)
        Me.Controls.Add(Me.imgAdmin)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio de Asesoría y Apoyo Técnico en Tecnologías de la Información y Comunicac" & _
    "ión -(SAAT-TIC)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgInformatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsesoriaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsesoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreasDeConocimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaticosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreasDeConocimientoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarCesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsesoríasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Public WithEvents imgInformatico As System.Windows.Forms.PictureBox
    Public WithEvents imgAdmin As System.Windows.Forms.PictureBox
    Public WithEvents imgCliente As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
