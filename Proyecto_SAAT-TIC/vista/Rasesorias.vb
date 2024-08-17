Public Class Rasesorias

    Private Sub Rasesorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic5DataSet2.vistaAsesorias' Puede moverla o quitarla según sea necesario.
        Me.vistaAsesoriasTableAdapter.Fill(Me.bd_saattic5DataSet2.vistaAsesorias)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
