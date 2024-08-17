<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rproyectos
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
        Me.vistaProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_saattic5DataSet3 = New Proyecto_SAAT_TIC.bd_saattic5DataSet3()
        Me.vistaProyectoTableAdapter = New Proyecto_SAAT_TIC.bd_saattic5DataSet3TableAdapters.vistaProyectoTableAdapter()
        Me.bd_saattic2DataSet4 = New Proyecto_SAAT_TIC.bd_saattic2DataSet4()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.vistaProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic5DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic2DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(349, 148)
        Me.Label1.Text = "Reporte de Proyectos"
        '
        'vistaProyectoBindingSource
        '
        Me.vistaProyectoBindingSource.DataMember = "vistaProyecto"
        Me.vistaProyectoBindingSource.DataSource = Me.bd_saattic5DataSet3
        '
        'bd_saattic5DataSet3
        '
        Me.bd_saattic5DataSet3.DataSetName = "bd_saattic5DataSet3"
        Me.bd_saattic5DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vistaProyectoTableAdapter
        '
        Me.vistaProyectoTableAdapter.ClearBeforeFill = True
        '
        'bd_saattic2DataSet4
        '
        Me.bd_saattic2DataSet4.DataSetName = "bd_saattic2DataSet4"
        Me.bd_saattic2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vistaProyectoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_SAAT_TIC.reporteProyectos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(45, 207)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(984, 246)
        Me.ReportViewer1.TabIndex = 15
        '
        'Rproyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1062, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Rproyectos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ReportViewer1, 0)
        CType(Me.vistaProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic5DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic2DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vistaProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bd_saattic5DataSet3 As Proyecto_SAAT_TIC.bd_saattic5DataSet3
    Friend WithEvents vistaProyectoTableAdapter As Proyecto_SAAT_TIC.bd_saattic5DataSet3TableAdapters.vistaProyectoTableAdapter
    Friend WithEvents bd_saattic2DataSet4 As Proyecto_SAAT_TIC.bd_saattic2DataSet4
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

End Class
