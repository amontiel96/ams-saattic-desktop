<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRClientes
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bd_saattic5DataSet = New Proyecto_SAAT_TIC.bd_saattic5DataSet()
        Me.vistaClientes2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vistaClientes2TableAdapter = New Proyecto_SAAT_TIC.bd_saattic5DataSetTableAdapters.vistaClientes2TableAdapter()
        CType(Me.bd_saattic5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vistaClientes2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(355, 148)
        Me.Label1.Text = "Reporte de clientes"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vistaClientes2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_SAAT_TIC.Rclientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(39, 225)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(990, 290)
        Me.ReportViewer1.TabIndex = 15
        '
        'bd_saattic5DataSet
        '
        Me.bd_saattic5DataSet.DataSetName = "bd_saattic5DataSet"
        Me.bd_saattic5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vistaClientes2BindingSource
        '
        Me.vistaClientes2BindingSource.DataMember = "vistaClientes2"
        Me.vistaClientes2BindingSource.DataSource = Me.bd_saattic5DataSet
        '
        'vistaClientes2TableAdapter
        '
        Me.vistaClientes2TableAdapter.ClearBeforeFill = True
        '
        'frmRClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1062, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRClientes"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ReportViewer1, 0)
        CType(Me.bd_saattic5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vistaClientes2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vistaClientes2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bd_saattic5DataSet As Proyecto_SAAT_TIC.bd_saattic5DataSet
    Friend WithEvents vistaClientes2TableAdapter As Proyecto_SAAT_TIC.bd_saattic5DataSetTableAdapters.vistaClientes2TableAdapter

End Class
