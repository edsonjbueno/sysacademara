Public Class ClassAluno


    Private _Matricula_Aluno As Integer
    Public Property Matricula_Aluno() As Integer
        Get
            Return _Matricula_Aluno
        End Get
        Set(ByVal value As Integer)
            _Matricula_Aluno = value
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

    Private _Data_Nasc As Date?
    Public Property Data_Nasc() As Date?
        Get
            Return _Data_Nasc
        End Get
        Set(ByVal value As Date?)
            _Data_Nasc = value
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

    Private _Mensalidade As New ClassMensalidade
    Public Property Mensalidade() As ClassMensalidade
        Get
            Return _Mensalidade
        End Get
        Set(ByVal value As ClassMensalidade)
            _Mensalidade = value
        End Set
    End Property

    Private _Situacao_Aluno As New ClassSituacao_Aluno
    Public Property Situacao_Aluno() As ClassSituacao_Aluno
        Get
            Return _Situacao_Aluno
        End Get
        Set(ByVal value As ClassSituacao_Aluno)
            _Situacao_Aluno = value
        End Set
    End Property


    Private _Lista_Telefone As New List(Of ClassTelefone)
    Public Property Lista_Telefone() As List(Of ClassTelefone)
        Get
            Return _Lista_Telefone
        End Get
        Set(ByVal value As List(Of ClassTelefone))
            _Lista_Telefone = value
        End Set
    End Property



    Private _Endereco As New ClassEndereco
    Public Property Endereco() As ClassEndereco
        Get
            Return _Endereco
        End Get
        Set(ByVal value As ClassEndereco)
            _Endereco = value
        End Set
    End Property


End Class
