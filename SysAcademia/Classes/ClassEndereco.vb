Public Class ClassEndereco


    Private _Codigo_Endereco As Integer
    Public Property Codigo_Endereco() As Integer
        Get
            Return _Codigo_Endereco
        End Get
        Set(ByVal value As Integer)
            _Codigo_Endereco = value
        End Set
    End Property

    Private _Rua As String
    Public Property Rua() As String
        Get
            Return _Rua
        End Get
        Set(ByVal value As String)
            _Rua = value
        End Set
    End Property

    Private _Numero As Integer
    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property

    Private _Complemento As String
    Public Property Complemento() As String
        Get
            Return _Complemento
        End Get
        Set(ByVal value As String)
            _Complemento = value
        End Set
    End Property

    Private _Bairro As String
    Public Property Bairro() As String
        Get
            Return _Bairro
        End Get
        Set(ByVal value As String)
            _Bairro = value
        End Set
    End Property

    Private _Busca_Cidade_Estado As ClassCidade
    Public Property Busca_Cidade_Estado() As ClassCidade
        Get
            Return _Busca_Cidade_Estado
        End Get
        Set(ByVal value As ClassCidade)
            _Busca_Cidade_Estado = value
        End Set
    End Property
End Class
