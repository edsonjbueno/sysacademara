Imports System.Data.SqlClient

Public Class DAO_Telefone

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)

        Me.Conexao = conexao
        Me.Transacao = Transacao

    End Sub

    Public Function Delete(ByVal Obj_Telefone As ClassTelefone) As Integer

        'Dim Telefones As New List(Of ClassTelefone)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("delete from Telefone where Codigo_Telefone = @Codigo_Telefone")
        Comando.Parameters.AddWithValue("@Codigo_Telefone", Obj_Telefone.Codigo_Telefone)


        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function

    Public Function Insert(ByVal Obj_Telefone As ClassTelefone) As Integer

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "insert into Telefone (Numero,Matricula_Aluno,Codigo_TipoTelefone) values (@Numero,@Matricula_Aluno,@Codigo_TipoTelefone)"

        Comando.Parameters.AddWithValue("@Numero", BbUtil.GetNull(Obj_Telefone.Numero))
        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Telefone.Matricula_Aluno)
        Comando.Parameters.AddWithValue("@Codigo_TipoTelefone", Obj_Telefone.Tipo_Telefone)

        Return Comando.ExecuteNonQuery()

    End Function

    Public Function ListAll_By_MatriculaAluno(ByVal Matricula_Aluno As Integer) As List(Of ClassTelefone)

        Dim Telefones As New List(Of ClassTelefone)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Telefone where Matricula_Aluno = @Matricula_Aluno")
        Comando.Parameters.AddWithValue("@Matricula_Aluno", Matricula_Aluno)

        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Telefone As New ClassTelefone
            Obj_Telefone.Codigo_Telefone = Cursor("Codigo_Telefone")
            Obj_Telefone.Numero = Cursor("Numero")
            Obj_Telefone.Matricula_Aluno = Cursor("Matricula_Aluno")
            Obj_Telefone.Tipo_Telefone = Cursor("Codigo_TipoTelefone")
            Telefones.Add(Obj_Telefone)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Telefones

    End Function

    Public Function ListAll() As List(Of ClassTelefone)

        Dim Cidades As New List(Of ClassTelefone)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Telefone")
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Telefone As New ClassTelefone
            Obj_Telefone.Codigo_Telefone = Cursor("Codigo_Telefone")
            Obj_Telefone.Numero = Cursor("Numero")
            Obj_Telefone.Matricula_Aluno = Cursor("Matricula_Aluno")
            Obj_Telefone.Tipo_Telefone = Cursor("Codigo_TipoTelefone")
            Cidades.Add(Obj_Telefone)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Cidades

    End Function

    Public Function GetById(ByVal codigo As Integer) As ClassTelefone


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Telefone where Codigo_Telefone = @Codigo_Telefone")
        Comando.Parameters.AddWithValue("@Codigo_Telefone", codigo)


        Dim Obj_Telefone As ClassTelefone = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader

        If Cursor.Read Then

            Obj_Telefone = New ClassTelefone

            Obj_Telefone.Codigo_Telefone = Cursor("Codigo_Telefone")
            Obj_Telefone.Numero = BbUtil.SetNull(Cursor("Numero"))
            Obj_Telefone.Matricula_Aluno = Cursor("Matricula_Aluno")
            Obj_Telefone.Tipo_Telefone = Cursor("Codigo_TipoTelefone")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Obj_Telefone


    End Function

    Public Function Atualizar(ByVal Obj_Telefone As ClassTelefone) As Integer


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Telefone set Numero = @Numero, Matricula_Aluno = @Matricula_Aluno, Codigo_TipoTelefone = @Codigo_TipoTelefone where Codigo_Telefone = @Codigo_Telefone")

        Comando.Parameters.AddWithValue("@Codigo_Telefone", Obj_Telefone.Codigo_Telefone)
        Comando.Parameters.AddWithValue("@Numero", Obj_Telefone.Numero)
        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Telefone.Matricula_Aluno)
        Comando.Parameters.AddWithValue("@Codigo_TipoTelefone", Obj_Telefone.Tipo_Telefone)

        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function


End Class
