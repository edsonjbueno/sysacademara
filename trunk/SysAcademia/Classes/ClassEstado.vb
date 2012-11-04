Public Class ClassEstado


    Private Lista_de_Estados As New List(Of ClassEstado)

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
    Private Sub PreencheCombo()
        Dim Estados As New ClassEstado
        Estados.Nome = "MG"
        Lista_de_Estados.Add(Estados)

    End Sub
    Public Overrides Function ToString() As String
        Return Codigo_Estado & " Nome Estado " & Nome
    End Function

End Class
