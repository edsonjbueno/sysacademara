Public Class ClassSituacaoFuncionario


    Private _Codigo_SituacaoFuncionario As Integer
    Public Property Codigo_SituacaoFuncionario() As Integer
        Get
            Return _Codigo_SituacaoFuncionario
        End Get
        Set(ByVal value As Integer)
            _Codigo_SituacaoFuncionario = value
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


End Class
