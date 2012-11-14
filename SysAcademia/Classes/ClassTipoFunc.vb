Public Class ClassTipoFunc


    Private _Codigo_TipoFuncionario As Integer
    Public Property Codigo_TipoFuncionario() As Integer
        Get
            Return _Codigo_TipoFuncionario
        End Get
        Set(ByVal value As Integer)
            _Codigo_TipoFuncionario = value
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
