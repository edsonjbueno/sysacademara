Public Class ClassTelefone

    Private _Codigo_Telefone As Integer
    Public Property Codigo_Telefone() As Integer
        Get
            Return _Codigo_Telefone
        End Get
        Set(ByVal value As Integer)
            _Codigo_Telefone = value
        End Set
    End Property


    Private _Numero As String
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property


    Private _Tipo_Telefone As New ClassTipoTelefone
    Public Property Tipo_Telefone() As ClassTipoTelefone
        Get
            Return _Tipo_Telefone
        End Get
        Set(ByVal value As ClassTipoTelefone)
            _Tipo_Telefone = value
        End Set
    End Property


    Private _Matricula_Aluno As Integer
    Public Property Matricula_Aluno() As Integer
        Get
            Return _Matricula_Aluno
        End Get
        Set(ByVal value As Integer)
            _Matricula_Aluno = value
        End Set
    End Property


End Class
