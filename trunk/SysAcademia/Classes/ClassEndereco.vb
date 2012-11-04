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

    Private _Cidade As ClassCidade
    Public Property Cidade() As ClassCidade
        Get
            Return _Cidade
        End Get
        Set(ByVal value As ClassCidade)
            _Cidade = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Codigo_Endereco & " Rua " & Rua & " Nº " & Numero & " Complemento " & Complemento &
            " Bairro " & Bairro & " Cidade " & Cidade.ToString
    End Function







End Class
