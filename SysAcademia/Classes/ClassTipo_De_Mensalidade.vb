Public Class ClassTipo_De_Mensalidade


    Private _Codigo_TM As Integer
    Public Property Codigo_TM() As Integer
        Get
            Return _Codigo_TM
        End Get
        Set(ByVal value As Integer)
            _Codigo_TM = value
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
