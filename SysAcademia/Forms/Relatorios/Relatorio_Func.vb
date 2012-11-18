Imports System.Data.SqlClient

Public Class Relatorio_Func

    Dim Conexao As SqlConnection = Nothing

    Private DAO As New DAO_Funcionario(Conexao)


    Private Sub Relatorio_Func_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Funcionarios As List(Of ClassFuncionario)
        Funcionarios = DAO.ListAll

        ClassFuncionarioBindingSource.DataSource = Funcionarios
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load


  
    End Sub
End Class