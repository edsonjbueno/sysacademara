Imports System.Data.SqlClient

Public Class DAO_Mensalidade

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction

    Public Sub New(ByVal conexao As SqlConnection)

        Me.Conexao = conexao

    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)
        Me.Conexao = conexao
        Me.Transacao = Transacao
    End Sub

    Public Function Insert(ByVal Obj_Mensalidade As ClassMensalidade) As Integer

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text

        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Comando.CommandText = "insert into Mensalidade (Valor,Data_Vencimento,Codigo_Tipo) values (@Valor,@Data_Vencimento,@Codigo_Tipo)"

        Comando.Parameters.AddWithValue("@Valor", Obj_Mensalidade.Valor)
        Comando.Parameters.AddWithValue("@Data_Vencimento", BbUtil.GetNull(Obj_Mensalidade.Data_Vencimento))
        Comando.Parameters.AddWithValue("@Codigo_Tipo", BbUtil.GetNull(Obj_Mensalidade.BuscaTipo.Codigo_Tipo))

        Return Comando.ExecuteNonQuery

    End Function
   
    Public Function ListAll() As List(Of ClassMensalidade)

        Dim Mensalidades As New List(Of ClassMensalidade)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "select * from Mensalidade"

        Dim Read As SqlDataReader = Comando.ExecuteReader


        While Read.Read()
            Dim Obj_Mensalidade As New ClassMensalidade
            Obj_Mensalidade.Codigo_Mensalidade = Read("Codigo_Mensalidade")
            Obj_Mensalidade.Valor = Read("Valor")
            Obj_Mensalidade.Data_Vencimento = BbUtil.SetNull(Read("Data_Vencimento"))
            Obj_Mensalidade.BuscaTipo.Codigo_Tipo = Read("Codigo_Tipo")
            Mensalidades.Add(Obj_Mensalidade)

        End While


        If Read IsNot Nothing AndAlso Not Read.IsClosed Then
            Read.Close()

        End If

        Return Mensalidades

    End Function

    Public Function ListByTipo_Mensalidade(ByVal Codigo_Tipo As Integer) As List(Of ClassMensalidade)

        Dim Tipos As New List(Of ClassMensalidade)

        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "Select * from Mensalidade where Codigo_Tipo = @Codigo_Tipo"
        Comando.Parameters.AddWithValue("@Codigo_Tipo", Codigo_Tipo)

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()

        While Cursor.Read()
            Dim Obj_TipoMensalidade As New ClassMensalidade
            Obj_TipoMensalidade.Codigo_Mensalidade = Cursor("Codigo_Mensalidade")
            Obj_TipoMensalidade.Valor = Cursor("Valor")
            Obj_TipoMensalidade.BuscaTipo.Codigo_Tipo = Cursor("Codigo_Tipo")
            Tipos.Add(Obj_TipoMensalidade)
        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()

        End If

        Return Tipos

    End Function
    Public Function GetById(ByVal codigo As Integer) As ClassMensalidade


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Mensalidade where Codigo_Mensalidade = @Codigo_Mensalidade")
        Comando.Parameters.AddWithValue("@Codigo_Mensalidade", codigo)


        Dim Obj_Mensalidade As ClassMensalidade = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader

        If Cursor.Read Then

            Obj_Mensalidade = New ClassMensalidade
            Obj_Mensalidade.Codigo_Mensalidade = Cursor("Codigo_Mensalidade")
            Obj_Mensalidade.Data_Vencimento = BbUtil.SetNull(Cursor("Data_Vencimento"))
            Obj_Mensalidade.Valor = Cursor("Valor")
            Obj_Mensalidade.BuscaTipo.Codigo_Tipo = Cursor("Codigo_Tipo")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then

            Cursor.Close()

        End If

        Return Obj_Mensalidade


    End Function

    Public Function Update(ByVal Obj_Mensalidade As ClassMensalidade) As Integer


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Mensalidade set Valor = @Valor, Data_Vencimento = @Data_Vencimento, Codigo_Tipo = @Codigo_Tipo  where Codigo_Mensalidade = @Codigo_Mensalidade")

        Comando.Parameters.AddWithValue("@Codigo_Mensalidade", Obj_Mensalidade.Codigo_Mensalidade)
        Comando.Parameters.AddWithValue("@Valor", Obj_Mensalidade.Valor)
        Comando.Parameters.AddWithValue("@Data_Vencimento", Obj_Mensalidade.Data_Vencimento)
        Comando.Parameters.AddWithValue("@Codigo_Tipo", Obj_Mensalidade.BuscaTipo.Codigo_Tipo)

        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function


End Class

