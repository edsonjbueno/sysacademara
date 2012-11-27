Public Class ClassSituacao_Aluno


    Private _Codigo_Situacao As Integer
    Public Property Codigo_Situacao() As Integer
        Get
            Return _Codigo_Situacao
        End Get
        Set(ByVal value As Integer)
            _Codigo_Situacao = value
        End Set
    End Property


    Private _Descricao As String
    Public Property Descricao() As String
        Get
            Return _Descricao
        End Get
        Set(ByVal value As String)
            _Descricao = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Descricao
    End Function

End Class
