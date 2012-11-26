Imports System.Data.SqlClient

Public Class CadTipFunc

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        Dim conexao As SqlConnection = Nothing

        Try
            conexao = FabricadeConexao.GetConexao()

            Dim ObjTipoFunc As ClassTipoFunc = GetDadosTipoFunc()

            Dim Dao As New DAO_TipoFunc(conexao)
            Dim N As Integer = Dao.Insert(ObjTipoFunc)

            MessageBox.Show("OK! " & N)

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar o banco de dados." & ex.Message)
        End Try
        FabricadeConexao.FechaConexao(conexao)



    End Sub

    Private Function GetDadosTipoFunc() As ClassTipoFunc

        Dim ObjTipoFunc As New ClassTipoFunc

        ObjTipoFunc.Descricao = TxtDescricao.Text

        Return ObjTipoFunc
    End Function


End Class