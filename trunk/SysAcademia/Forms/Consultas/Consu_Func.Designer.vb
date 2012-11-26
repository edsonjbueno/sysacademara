<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consu_Func
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ClassFuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ClassFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassFuncionarioBindingSource
        '
        Me.ClassFuncionarioBindingSource.DataSource = GetType(SysAcademia.ClassFuncionario)
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(12, 280)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(75, 23)
        Me.BtnListar.TabIndex = 1
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetRela_Func"
        ReportDataSource1.Value = Me.ClassFuncionarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SysAcademia.Report_Func.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(859, 246)
        Me.ReportViewer1.TabIndex = 2
        '
        'Consu_Func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 315)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BtnListar)
        Me.Name = "Consu_Func"
        Me.Text = "Consu_Func"
        CType(Me.ClassFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClassFuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnListar As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
