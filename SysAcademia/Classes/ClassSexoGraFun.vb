Public Class ClassSexoGraFun

    Private _Quantidade As Integer
    Public Property Quantidade() As Integer
        Get
            Return _Quantidade
        End Get
        Set(ByVal value As Integer)
            _Quantidade = value
        End Set
    End Property


    Private _Sexo As String
    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

End Class
