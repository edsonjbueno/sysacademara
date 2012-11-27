Public Class ClassTipo_Mensalidade


    Private _Codigo_Tipo As Integer
    Public Property Codigo_Tipo() As Integer
        Get
            Return _Codigo_Tipo
        End Get
        Set(ByVal value As Integer)
            _Codigo_Tipo = value
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
