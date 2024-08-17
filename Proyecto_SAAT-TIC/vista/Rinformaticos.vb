Public Class Rinformaticos

    Private Sub Rinformaticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic5DataSet1.vistaInformaticos' Puede moverla o quitarla según sea necesario.
        Me.vistaInformaticosTableAdapter.Fill(Me.bd_saattic5DataSet1.vistaInformaticos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
