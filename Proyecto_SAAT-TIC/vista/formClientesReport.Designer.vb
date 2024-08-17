<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formClientesReport
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
        Me.vistaClientes2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_saattic2DataSet1 = New Proyecto_SAAT_TIC.bd_saattic2DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vistaClientes2TableAdapter = New Proyecto_SAAT_TIC.bd_saattic2DataSet1TableAdapters.vistaClientes2TableAdapter()
        CType(Me.vistaClientes2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_saattic2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(364, 148)
        Me.Label1.Text = "Reporte de Clientes"
        '
        'vistaClientes2BindingSource
        '
        Me.vistaClientes2BindingSource.DataMember = "vistaClientes2"
        Me.vistaClientes2BindingSource.DataSource = Me.bd_saattic2DataSet1
        '
        'bd_saattic2DataSet1
        '
        Me.bd_saattic2DataSet1.DataSetName = "bd_saattic2DataSet1"
        Me.bd_saattic2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vistaClientes2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_SAAT_TIC.reporteClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(37, 207)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1000, 325)
        Me.ReportViewer1.TabIndex = 15
        '
        'vistaClientes2TableAdapter
        '
        Me.vistaClientes2TableAdapter.ClearBeforeFill = True
        '
        'formClientesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1062, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "formClientesReport"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ReportViewer1, 0)
        CType(Me.vistaClientes2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_saattic2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vistaClientes2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bd_saattic2DataSet1 As Proyecto_SAAT_TIC.bd_saattic2DataSet1
    Friend WithEvents vistaClientes2TableAdapter As Proyecto_SAAT_TIC.bd_saattic2DataSet1TableAdapters.vistaClientes2TableAdapter

End Class
