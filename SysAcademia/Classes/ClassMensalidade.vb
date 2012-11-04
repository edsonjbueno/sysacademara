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

    Private _Mes_Referencia As Integer
    Public Property Mes_Referencia() As Integer
        Get
            Return _Mes_Referencia
        End Get
        Set(ByVal value As Integer)
            _Mes_Referencia = value
        End Set
    End Property

    Private _Ano_Referencia As Integer
    Public Property Ano_Referencia() As Integer
        Get
            Return _Ano_Referencia
        End Get
        Set(ByVal value As Integer)
            _Ano_Referencia = value
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

    Private _Aluno As ClassAluno
    Public Property Aluno() As ClassAluno
        Get
            Return _Aluno
        End Get
        Set(ByVal value As ClassAluno)
            _Aluno = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Codigo_Mensalidade & " Data Pagamento " & Data_Pagamento & " Mês Referência " & Mes_Referencia &
            " Ano Referência " & Ano_Referencia & " Valor " & Valor & " Aluno " & Aluno.ToString
    End Function

End Class
