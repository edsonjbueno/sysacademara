Public Class ClassCidade



    Private _Codigo_Cidade As Integer
    Public Property Coidgo_Cidade() As Integer
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
            _Nome = value
        End Set
    End Property
   
    Private _Estado As ClassEstado
    Public Property Estado() As ClassEstado
        Get
            Return _Estado
        End Get
        Set(ByVal value As ClassEstado)
            _Estado = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Coidgo_Cidade & "Nome Cidade " & Nome
    End Function



End Class
