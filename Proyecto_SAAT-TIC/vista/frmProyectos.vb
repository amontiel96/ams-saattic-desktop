Public Class frmProyectos
    Dim llamar As New clsValidar
    Dim fProyec As New fProyecto
    Dim dts As New vProyecto
    Dim recibe As DataTable
    Public ds As DataSet
    Dim cad As String
    Public recibeIDInfo As String
    Dim id_info As Integer
    Private Sub frmProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
        llenarGridAcep()
    End Sub
    Public Sub llenaGrid()
        Dim cad As String = "select intId_proyecto as Id_proyecto, intId_informatico as Id_informatico, intId_cliente as Id_cliente,vchNombrePrj as Nombre_proyecto, intId_tProyecto as Id_Tipo_proyecto,vchDescripcion as Descripcion,vchArchivo as Archivo, intStatus as Estatus from tbl_proyecto where intStatus=0"
        recibe = fProyec.mostrar(cad)
        tablaProyectos.DataSource = recibe
    End Sub
    Public Sub IdInfo()
        cad = "select intId_informatico from tbl_informaticos where intId_persona = '" + recibeIDInfo + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        id_info = ds.Tables(0).Rows(0).Item(0)
    End Sub
    Public Sub llenarGridAcep()
        IdInfo()
        Dim cad As String = "select intId_proyecto as Id_proyecto,intId_informatico as Id_informatico,intId_cliente as Id_cliente, vchNombrePrj as Nombre_proyecto,intId_tProyecto as Id_tProyecto,vchDescripcion as Descripcion,vchArchivo as Archivo, intStatus as Estatus from tbl_proyecto where intId_informatico = '" + id_info.ToString() + "' and intStatus = 1"
        recibe = fProyec.mostrar(cad)
        tablaAceptados.DataSource = recibe
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim respuesta As DialogResult = MessageBox.Show("Seguro aceptar el proyecto", "Aceptado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            If Not tablaRecibe.RowCount > 0 Then
                MessageBox.Show("Error al aceptar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                IdInfo()
                dts.gProyecto = tablaProyectos.CurrentRow.Cells(0).Value
                dts.gInfo = id_info
                If fProyec.aceptarProyecto(dts) Then
                    llenaGrid()
                    llenarGridAcep()
                    tablaRecibe.Rows.Clear()
                End If
            End If
        Else
            MessageBox.Show("Debe elegir un proyecto", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            tablaRecibe.ColumnCount = 4
            tablaRecibe.Rows.Add(tablaProyectos.CurrentRow.Cells(0).Value, recibeIDInfo, tablaProyectos.CurrentRow.Cells(3).Value, tablaProyectos.CurrentRow.Cells(4).Value)
        Catch ex As Exception
            MessageBox.Show("Elegir un proyecto", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            tablaRecibe.Rows.RemoveAt(tablaRecibe.CurrentRow.Index)
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar fila del sistema", "No hay nada que borrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
