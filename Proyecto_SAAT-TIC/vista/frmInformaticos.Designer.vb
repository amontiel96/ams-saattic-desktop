<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformaticos
    Inherits Proyecto_SAAT_TIC.Form1

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tablaClientes = New System.Windows.Forms.DataGridView()
        Me.tablaInfor = New System.Windows.Forms.DataGridView()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTipoUsua = New System.Windows.Forms.ComboBox()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.gbArea = New System.Windows.Forms.GroupBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tablaAreasRecibe = New System.Windows.Forms.DataGridView()
        Me.tablaAreas = New System.Windows.Forms.DataGridView()
        Me.txtApeMat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tablaAdmin = New System.Windows.Forms.DataGridView()
        Me.cbxTipoCOrreo = New System.Windows.Forms.ComboBox()
        Me.txtComfirPass = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtApePat = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.gbxDatos.SuspendLayout()
        CType(Me.tablaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaInfor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbArea.SuspendLayout()
        CType(Me.tablaAreasRecibe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Size = New System.Drawing.Size(1078, 42)
        Me.Panel1.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btnEliminar, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(196, 130)
        Me.Label1.Size = New System.Drawing.Size(10, 10)
        Me.Label1.Text = "Informaticos"
        '
        'gbxDatos
        '
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.Controls.Add(Me.Label15)
        Me.gbxDatos.Controls.Add(Me.Label14)
        Me.gbxDatos.Controls.Add(Me.Label13)
        Me.gbxDatos.Controls.Add(Me.tablaClientes)
        Me.gbxDatos.Controls.Add(Me.tablaInfor)
        Me.gbxDatos.Controls.Add(Me.lbl_clave)
        Me.gbxDatos.Controls.Add(Me.dtpFecha)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.Label6)
        Me.gbxDatos.Controls.Add(Me.cmbTipoUsua)
        Me.gbxDatos.Controls.Add(Me.cmbMunicipio)
        Me.gbxDatos.Controls.Add(Me.gbArea)
        Me.gbxDatos.Controls.Add(Me.txtApeMat)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.tablaAdmin)
        Me.gbxDatos.Controls.Add(Me.cbxTipoCOrreo)
        Me.gbxDatos.Controls.Add(Me.txtComfirPass)
        Me.gbxDatos.Controls.Add(Me.txtPass)
        Me.gbxDatos.Controls.Add(Me.txtUsuario)
        Me.gbxDatos.Controls.Add(Me.txtEmail)
        Me.gbxDatos.Controls.Add(Me.txtApePat)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbxDatos.Location = New System.Drawing.Point(36, 157)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(995, 382)
        Me.gbxDatos.TabIndex = 14
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(544, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Administradores"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(550, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Clientes"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(550, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Informaticos"
        '
        'tablaClientes
        '
        Me.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaClientes.Location = New System.Drawing.Point(547, 271)
        Me.tablaClientes.Name = "tablaClientes"
        Me.tablaClientes.Size = New System.Drawing.Size(431, 95)
        Me.tablaClientes.TabIndex = 35
        '
        'tablaInfor
        '
        Me.tablaInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaInfor.Location = New System.Drawing.Point(547, 165)
        Me.tablaInfor.Name = "tablaInfor"
        Me.tablaInfor.Size = New System.Drawing.Size(431, 90)
        Me.tablaInfor.TabIndex = 34
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Enabled = False
        Me.lbl_clave.Location = New System.Drawing.Point(151, 16)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(0, 13)
        Me.lbl_clave.TabIndex = 33
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(262, 210)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(259, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Fecha de registro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(18, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Municipio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(18, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Tipo de usuario:"
        '
        'cmbTipoUsua
        '
        Me.cmbTipoUsua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoUsua.Enabled = False
        Me.cmbTipoUsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTipoUsua.FormattingEnabled = True
        Me.cmbTipoUsua.Location = New System.Drawing.Point(21, 213)
        Me.cmbTipoUsua.Name = "cmbTipoUsua"
        Me.cmbTipoUsua.Size = New System.Drawing.Size(225, 21)
        Me.cmbTipoUsua.TabIndex = 28
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMunicipio.Enabled = False
        Me.cmbMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(21, 165)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(225, 21)
        Me.cmbMunicipio.TabIndex = 27
        '
        'gbArea
        '
        Me.gbArea.Controls.Add(Me.btnQuitar)
        Me.gbArea.Controls.Add(Me.btnAgregar)
        Me.gbArea.Controls.Add(Me.tablaAreasRecibe)
        Me.gbArea.Controls.Add(Me.tablaAreas)
        Me.gbArea.Enabled = False
        Me.gbArea.Location = New System.Drawing.Point(25, 246)
        Me.gbArea.Name = "gbArea"
        Me.gbArea.Size = New System.Drawing.Size(462, 120)
        Me.gbArea.TabIndex = 26
        Me.gbArea.TabStop = False
        Me.gbArea.Text = "Areas de conocimiento"
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnQuitar.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.remove
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(203, 84)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(83, 31)
        Me.btnQuitar.TabIndex = 25
        Me.btnQuitar.Text = "&Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.add1
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(203, 28)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 31)
        Me.btnAgregar.TabIndex = 24
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'tablaAreasRecibe
        '
        Me.tablaAreasRecibe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAreasRecibe.Location = New System.Drawing.Point(310, 26)
        Me.tablaAreasRecibe.Name = "tablaAreasRecibe"
        Me.tablaAreasRecibe.Size = New System.Drawing.Size(146, 84)
        Me.tablaAreasRecibe.TabIndex = 23
        '
        'tablaAreas
        '
        Me.tablaAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAreas.Location = New System.Drawing.Point(31, 28)
        Me.tablaAreas.Name = "tablaAreas"
        Me.tablaAreas.Size = New System.Drawing.Size(146, 84)
        Me.tablaAreas.TabIndex = 22
        '
        'txtApeMat
        '
        Me.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApeMat.Enabled = False
        Me.txtApeMat.Location = New System.Drawing.Point(21, 121)
        Me.txtApeMat.MaxLength = 25
        Me.txtApeMat.Name = "txtApeMat"
        Me.txtApeMat.Size = New System.Drawing.Size(225, 20)
        Me.txtApeMat.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(18, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Apellidos Materno:"
        '
        'tablaAdmin
        '
        Me.tablaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAdmin.Location = New System.Drawing.Point(547, 60)
        Me.tablaAdmin.Name = "tablaAdmin"
        Me.tablaAdmin.Size = New System.Drawing.Size(431, 86)
        Me.tablaAdmin.TabIndex = 19
        '
        'cbxTipoCOrreo
        '
        Me.cbxTipoCOrreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCOrreo.Enabled = False
        Me.cbxTipoCOrreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxTipoCOrreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCOrreo.FormattingEnabled = True
        Me.cbxTipoCOrreo.Items.AddRange(New Object() {"@hotmail.com", "@gmail.com", "@yahoo.com"})
        Me.cbxTipoCOrreo.Location = New System.Drawing.Point(387, 32)
        Me.cbxTipoCOrreo.Name = "cbxTipoCOrreo"
        Me.cbxTipoCOrreo.Size = New System.Drawing.Size(100, 21)
        Me.cbxTipoCOrreo.TabIndex = 18
        '
        'txtComfirPass
        '
        Me.txtComfirPass.Enabled = False
        Me.txtComfirPass.Location = New System.Drawing.Point(262, 165)
        Me.txtComfirPass.MaxLength = 8
        Me.txtComfirPass.Name = "txtComfirPass"
        Me.txtComfirPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtComfirPass.Size = New System.Drawing.Size(225, 20)
        Me.txtComfirPass.TabIndex = 14
        '
        'txtPass
        '
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(262, 121)
        Me.txtPass.MaxLength = 8
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(225, 20)
        Me.txtPass.TabIndex = 13
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(262, 76)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(225, 20)
        Me.txtUsuario.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(262, 33)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(119, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtApePat
        '
        Me.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApePat.Enabled = False
        Me.txtApePat.Location = New System.Drawing.Point(21, 76)
        Me.txtApePat.MaxLength = 25
        Me.txtApePat.Name = "txtApePat"
        Me.txtApePat.Size = New System.Drawing.Size(225, 20)
        Me.txtApePat.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(21, 34)
        Me.txtNombre.MaxLength = 15
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 20)
        Me.txtNombre.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(259, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Contraseña:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(259, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Comfirmar contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(259, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(259, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "E-mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(18, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Apellidos Paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(18, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre(s):"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(103, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(83, 31)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.guardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(281, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(83, 31)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.cancelar1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(457, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 31)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.kate
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(627, 8)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 23)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.Proyecto_SAAT_TIC.My.Resources.Resources.eliminar
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(799, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 34)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmInformaticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1062, 554)
        Me.Controls.Add(Me.gbxDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Name = "frmInformaticos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.gbxDatos, 0)
        Me.Panel1.ResumeLayout(False)
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.tablaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaInfor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbArea.ResumeLayout(False)
        CType(Me.tablaAreasRecibe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtComfirPass As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtApePat As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoCOrreo As System.Windows.Forms.ComboBox
    Friend WithEvents tablaAdmin As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbArea As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents tablaAreasRecibe As System.Windows.Forms.DataGridView
    Friend WithEvents tablaAreas As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoUsua As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_clave As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tablaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents tablaInfor As System.Windows.Forms.DataGridView

End Class
