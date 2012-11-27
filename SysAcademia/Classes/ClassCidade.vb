Public Class ClassCidade

    ' Classe esta pronta e funcionando, "FAVOR NÃO AUTERAR SEM FALAR COMIGO" Ederson..

    Private _Codigo_Cidade As Integer
    Public Property Codigo_Cidade() As Integer
        Get
            Return _Codigo_Cidade
        End Get
        Set(ByVal value As Integer)
            _Codigo_Cidade = value
        End Set
    End Property


    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            If value.Trim() = "" Then
                Throw New Exception("Valor inválido para parâmetro nome!")
            End If
            _Nome = value

        End Set
    End Property
   
    Private _Estado As New ClassEstado
    Public Property Estado() As ClassEstado
        Get
            Return _Estado
        End Get
        Set(ByVal value As ClassEstado)
            _Estado = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nome
    End Function
End Class
