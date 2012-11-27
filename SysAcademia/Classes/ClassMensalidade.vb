Public Class ClassMensalidade


    Private _Codigo_Mensalidade As Integer
    Public Property Codigo_Mensalidade() As Integer
        Get
            Return _Codigo_Mensalidade
        End Get
        Set(ByVal value As Integer)
            _Codigo_Mensalidade = value
        End Set
    End Property

    Private _Data_Vencimento As Date?
    Public Property Data_Vencimento() As Date?
        Get
            Return _Data_Vencimento
        End Get
        Set(ByVal value As Date?)
            _Data_Vencimento = value
        End Set
    End Property

    Private _Valor As Double
    Public Property Valor() As Double
        Get
            Return _Valor
        End Get
        Set(ByVal value As Double)
            _Valor = value
        End Set
    End Property


    Private _BuscaTipo As New ClassTipo_Mensalidade
    Public Property BuscaTipo() As ClassTipo_Mensalidade
        Get
            Return _BuscaTipo
        End Get
        Set(ByVal value As ClassTipo_Mensalidade)
            _BuscaTipo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Valor
    End Function

End Class
