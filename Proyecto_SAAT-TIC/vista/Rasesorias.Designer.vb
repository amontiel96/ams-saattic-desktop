<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rasesorias
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
        Me.vistaAsesoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_saattic5DataSet2 = New Proyecto_SAAT_TIC.bd_saattic5DataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vistaAsesoriasTableAdapter = New Proyecto_SAAT_TIC.bd_saattic5DataSet2TableAdapters.vistaAsesoriasTableAdapter()
        Me.bd_saattic2DataSet3 = New Proyecto_SAAT_TIC.bd_saattic2DataSet3()
        CType(Me.vistaAsesoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic5DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic2DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(361, 148)
        Me.Label1.Text = "Reporte de Asesorías"
        '
        'vistaAsesoriasBindingSource
        '
        Me.vistaAsesoriasBindingSource.DataMember = "vistaAsesorias"
        Me.vistaAsesoriasBindingSource.DataSource = Me.bd_saattic5DataSet2
        '
        'bd_saattic5DataSet2
        '
        Me.bd_saattic5DataSet2.DataSetName = "bd_saattic5DataSet2"
        Me.bd_saattic5DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vistaAsesoriasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_SAAT_TIC.reporteAsesorias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(31, 216)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(998, 326)
        Me.ReportViewer1.TabIndex = 15
        '
        'vistaAsesoriasTableAdapter
        '
        Me.vistaAsesoriasTableAdapter.ClearBeforeFill = True
        '
        'bd_saattic2DataSet3
        '
        Me.bd_saattic2DataSet3.DataSetName = "bd_saattic2DataSet3"
        Me.bd_saattic2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rasesorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1062, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Rasesorias"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ReportViewer1, 0)
        CType(Me.vistaAsesoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic5DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic2DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vistaAsesoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bd_saattic5DataSet2 As Proyecto_SAAT_TIC.bd_saattic5DataSet2
    Friend WithEvents vistaAsesoriasTableAdapter As Proyecto_SAAT_TIC.bd_saattic5DataSet2TableAdapters.vistaAsesoriasTableAdapter
    Friend WithEvents bd_saattic2DataSet3 As Proyecto_SAAT_TIC.bd_saattic2DataSet3

End Class
