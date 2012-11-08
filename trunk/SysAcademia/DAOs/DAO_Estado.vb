Imports System.Data.SqlClient

Public Class DAO_Estado

    Private Conexao As SqlConnection

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub
    'Public Function Insert(ByVal Obj_Estado As ClassEstado) As Integer


    '    Dim Comando As New SqlCommand()
    '    Comando.Connection = Conexao
    '    Comando.CommandType = CommandType.Text
    '    Comando.CommandText = "insert into Estado(Nome) values (@Nome)"

    '    Comando.Parameters.AddWithValue("@Nome", Obj_Estado.Nome)

    '    Dim Exe As Integer = Comando.ExecuteNonQuery
    '    Return Exe
    'End Function
    Public Function GetById(ByVal nome As Integer) As ClassEstado


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Estado order by @Nome = Nome")
        Comando.Parameters.AddWithValue("@Nome", nome)


        Dim ObjCliente As ClassEstado = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        If Cursor.Read Then
            ObjCliente = New ClassEstado
            ObjCliente.Nome = Cursor("Nome")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return ObjCliente


    End Function

    Public Function ListAll() As List(Of ClassEstado)

        Dim Estados As New List(Of ClassEstado)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Estado order by Nome")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Estado As New ClassEstado
            Obj_Estado.Nome = Cursor("Nome")
            Estados.Add(Obj_Estado)
        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Estados

    End Function


End Class
