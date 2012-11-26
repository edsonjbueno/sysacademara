﻿Imports System.Data.SqlClient

Public Class Relatorio_Func

    Private Sub Relatorio_Func_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MostraDados()

    End Sub

    Private Sub MostraDados()

        Dim Conexao As SqlConnection = Nothing


        Try
            Conexao = FabricadeConexao.GetConexao

            Dim DAO As New DAO_Funcionario(Conexao)

            ClassFuncionarioBindingSource.DataSource = DAO.ListAll
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception

            MessageBox.Show("Problema ao conexao ao banco!")
        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

     
    End Sub




End Class