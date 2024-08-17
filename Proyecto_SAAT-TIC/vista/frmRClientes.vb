Public Class frmRClientes

    Private Sub frmRClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic5DataSet.vistaClientes2' Puede moverla o quitarla según sea necesario.
        Me.vistaClientes2TableAdapter.Fill(Me.bd_saattic5DataSet.vistaClientes2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
