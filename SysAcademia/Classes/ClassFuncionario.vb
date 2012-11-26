'Classe Funcionario

Public Class ClassFuncionario


    Private _Telefone As New ClassTelefone
    Public Property Telefone() As ClassTelefone
        Get
            Return _Telefone
        End Get
        Set(ByVal value As ClassTelefone)
            _Telefone = value
        End Set
    End Property

    Private _Matricula_Funcionario As Integer
    Public Property Matricula_Funcionario() As Integer
        Get
            Return _Matricula_Funcionario
        End Get
        Set(ByVal value As Integer)
            _Matricula_Funcionario = value
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



    Private _Cpf As String
    Public Property Cpf() As String
        Get
            Return _Cpf
        End Get
        Set(ByVal value As String)
            _Cpf = value
        End Set
    End Property


    Private _Rg As String
    Public Property Rg() As String
        Get
            Return _Rg
        End Get
        Set(ByVal value As String)
            _Rg = value
        End Set
    End Property

    Private _Salario As Double?
    Public Property Salario() As Double?
        Get
            Return _Salario
        End Get
        Set(ByVal value As Double?)
            _Salario = value
        End Set
    End Property


    Private _SituacaoFuncionario As New ClassSituacaoFuncionario
    Public Property SituacaoFuncionario() As ClassSituacaoFuncionario
        Get
            Return _SituacaoFuncionario
        End Get
        Set(ByVal value As ClassSituacaoFuncionario)
            _SituacaoFuncionario = value
        End Set
    End Property

    Private _Codigo_Endereco As New ClassEndereco
    Public Property Codigo_Endereco() As ClassEndereco
        Get
            Return _Codigo_Endereco
        End Get
        Set(ByVal value As ClassEndereco)
            _Codigo_Endereco = value
        End Set
    End Property


    Private _Codigo_TipoFuncionario As New ClassTipoFunc
    Public Property Codigo_TipoFuncionario() As ClassTipoFunc
        Get
            Return _Codigo_TipoFuncionario
        End Get
        Set(ByVal value As ClassTipoFunc)
            _Codigo_TipoFuncionario = value
        End Set
    End Property




End Class
