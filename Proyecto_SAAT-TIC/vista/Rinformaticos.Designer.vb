<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rinformaticos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.vistaInformaticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_saattic5DataSet1 = New Proyecto_SAAT_TIC.bd_saattic5DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vistaInformaticosTableAdapter = New Proyecto_SAAT_TIC.bd_saattic5DataSet1TableAdapters.vistaInformaticosTableAdapter()
        Me.bd_saattic2DataSet2 = New Proyecto_SAAT_TIC.bd_saattic2DataSet2()
        CType(Me.vistaInformaticosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic5DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic2DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(320, 145)
        Me.Label1.Size = New System.Drawing.Size(697, 56)
        Me.Label1.Text = "Reporte de Informaticos"
        '
        'vistaInformaticosBindingSource
        '
        Me.vistaInformaticosBindingSource.DataMember = "vistaInformaticos"
        Me.vistaInformaticosBindingSource.DataSource = Me.bd_saattic5DataSet1
        '
        'bd_saattic5DataSet1
        '
        Me.bd_saattic5DataSet1.DataSetName = "bd_saattic5DataSet1"
        Me.bd_saattic5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vistaInformaticosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_SAAT_TIC.repoteInformaticos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(28, 204)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1001, 338)
        Me.ReportViewer1.TabIndex = 15
        '
        'vistaInformaticosTableAdapter
        '
        Me.vistaInformaticosTableAdapter.ClearBeforeFill = True
        '
        'bd_saattic2DataSet2
        '
        Me.bd_saattic2DataSet2.DataSetName = "bd_saattic2DataSet2"
        Me.bd_saattic2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rinformaticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1062, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Rinformaticos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ReportViewer1, 0)
        CType(Me.vistaInformaticosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic5DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic2DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vistaInformaticosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bd_saattic5DataSet1 As Proyecto_SAAT_TIC.bd_saattic5DataSet1
    Friend WithEvents vistaInformaticosTableAdapter As Proyecto_SAAT_TIC.bd_saattic5DataSet1TableAdapters.vistaInformaticosTableAdapter
    Friend WithEvents bd_saattic2DataSet2 As Proyecto_SAAT_TIC.bd_saattic2DataSet2

End Class
