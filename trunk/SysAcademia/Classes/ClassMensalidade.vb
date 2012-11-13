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

    Private _Data_Pagamento As Date
    Public Property Data_Pagamento() As Date
        Get
            Return _Data_Pagamento
        End Get
        Set(ByVal value As Date)
            _Data_Pagamento = value
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

End Class
