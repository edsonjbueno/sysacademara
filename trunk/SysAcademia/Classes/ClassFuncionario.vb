Public Class ClassFuncionario



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


    Private _Cpf As Integer?
    Public Property Cpf() As Integer?
        Get
            Return _Cpf
        End Get
        Set(ByVal value As Integer?)
            _Cpf = value
        End Set
    End Property


    Private _Rg As Integer?
    Public Property Rg() As Integer?
        Get
            Return _Rg
        End Get
        Set(ByVal value As Integer?)
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

 
End Class
