Public Class frmAsesorias
    Dim llamar As New clsValidar
    Dim faseso As New fAsesoria
    Dim dts As New vAsesoria
    Dim recibe As DataTable
    Public ds As DataSet
    Dim cad As String
    Public recibeIDInfo As String
    Dim id_info As Integer
    Public Sub llenaGrid()
        Dim cad As String = "select intId_asesoria as Id_asesoria, intId_informatico as Id_informatico, intId_cliente as Id_cliente,vchTema as Tema, vchDescripcion as Descripcion, intStatus as Estatus from tbl_asesorias where intStatus = 0"

        recibe = faseso.mostrar(cad)
        tablaAsesorias.DataSource = recibe
    End Sub
    Public Sub IdInfo()
        cad = "select intId_informatico  from tbl_informaticos where intId_persona = '" + recibeIDInfo + "'"
        ds = clsPrincipal.consultaDSSQL(cad)
        id_info = ds.Tables(0).Rows(0).Item(0)
    End Sub
    Public Sub llenarGridAcep()
        IdInfo()
        'intId_asesoria as Id_asesoria, intId_informatico as Id_informatico, intId_cliente as Id_cliente,
        Dim cad As String = "select vchTema as Tema, vchDescripcion as Descripcion, intStatus as Estado from tbl_asesorias where intId_informatico = '" + id_info.ToString() + "' and intStatus = 1"
        recibe = faseso.mostrar(cad)
        tablaAceptadas.DataSource = recibe
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim respuesta As DialogResult = MessageBox.Show("Seguro aceptar el proyecto", "Aceptado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            If Not tablaRecibe.RowCount > 0 Then
                MessageBox.Show("Error al aceptar...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                IdInfo()
                dts.gId = tablaAsesorias.CurrentRow.Cells(0).Value
                dts.gId_info = id_info
                If faseso.aceptarAsesoria(dts) Then
                    MessageBox.Show("Se acepto la asesoria", "Aceptado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenaGrid()
                    llenarGridAcep()
                    tablaRecibe.Rows.Clear()
                End If
            End If
        Else
            MessageBox.Show("Debe elegir una asesoria", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            tablaRecibe.ColumnCount = 4
            tablaRecibe.Rows.Add(tablaAsesorias.CurrentRow.Cells(0).Value, recibeIDInfo, tablaAsesorias.CurrentRow.Cells(3).Value, tablaAsesorias.CurrentRow.Cells(4).Value)
        Catch ex As Exception
            MessageBox.Show("Elegir una asesoria", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmAsesorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
        llenarGridAcep()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            tablaRecibe.Rows.RemoveAt(tablaRecibe.CurrentRow.Index)
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar fila del sistema", "No hay nada que borrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
