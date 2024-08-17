Public Class formInforRepor

    Private Sub formInforRepor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_saattic2DataSet2.vistaInformaticos' Puede moverla o quitarla según sea necesario.
        Me.vistaInformaticosTableAdapter.Fill(Me.bd_saattic2DataSet2.vistaInformaticos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
