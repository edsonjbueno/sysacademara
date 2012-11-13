Public Class ClassEstado


    ' Classe esta pronta e funcionando, "FAVOR NÃO AUTERAR SEM FALAR COMIGO" Ederson..

    Private _Codigo_Estado As Integer
    Public Property Codigo_Estado() As Integer
        Get
            Return _Codigo_Estado
        End Get
        Set(ByVal value As Integer)
            _Codigo_Estado = value
        End Set
    End Property


    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            _Nome = value
        End Set
    End Property

End Class
