Public Class formProyectosrepor

    Private Sub formProyectosrepor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic2DataSet3.vistaAsesorias' Puede moverla o quitarla según sea necesario.
        Me.vistaAsesoriasTableAdapter.Fill(Me.bd_saattic2DataSet3.vistaAsesorias)
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic2DataSet4.vistaProyecto' Puede moverla o quitarla según sea necesario.
        Me.vistaProyectoTableAdapter.Fill(Me.bd_saattic2DataSet4.vistaProyecto)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
