Public Class ClassCidade

    Private Lista_De_Cidades As New List(Of ClassCidade)

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
    Private Sub PreencheCombo()
        Dim Cidades As New ClassCidade
        Cidades.Nome = "UBERLÂNDIA"
        Lista_De_Cidades.Add(Cidades)

    End Sub
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
        Return Coidgo_Cidade & "Nome Cidade " & Nome & " Estado " & Estado.ToString
    End Function



End Class
