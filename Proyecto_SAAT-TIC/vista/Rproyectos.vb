Public Class Rproyectos

    Private Sub Rproyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic5DataSet3.vistaProyecto' Puede moverla o quitarla según sea necesario.
        Me.vistaProyectoTableAdapter.Fill(Me.bd_saattic5DataSet3.vistaProyecto)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
